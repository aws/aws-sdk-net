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
 * Do not modify this file. This file is generated from the ec2-2016-11-15.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.Runtime;
using Amazon.EC2.Model;

namespace Amazon.EC2
{
    /// <summary>
    /// Interface for accessing EC2
    ///
    /// Amazon Elastic Compute Cloud 
    /// <para>
    /// Amazon Elastic Compute Cloud (Amazon EC2) provides resizable computing capacity in
    /// the AWS Cloud. Using Amazon EC2 eliminates the need to invest in hardware up front,
    /// so you can develop and deploy applications faster.
    /// </para>
    /// </summary>
    public partial interface IAmazonEC2 : IAmazonService, IDisposable
    {

        
        #region  AcceptReservedInstancesExchangeQuote


        /// <summary>
        /// Accepts the Convertible Reserved Instance exchange quote described in the <a>GetReservedInstancesExchangeQuote</a>
        /// call.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptReservedInstancesExchangeQuote service method.</param>
        /// 
        /// <returns>The response from the AcceptReservedInstancesExchangeQuote service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AcceptReservedInstancesExchangeQuote">REST API Reference for AcceptReservedInstancesExchangeQuote Operation</seealso>
        AcceptReservedInstancesExchangeQuoteResponse AcceptReservedInstancesExchangeQuote(AcceptReservedInstancesExchangeQuoteRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AcceptReservedInstancesExchangeQuote operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AcceptReservedInstancesExchangeQuote operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAcceptReservedInstancesExchangeQuote
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AcceptReservedInstancesExchangeQuote">REST API Reference for AcceptReservedInstancesExchangeQuote Operation</seealso>
        IAsyncResult BeginAcceptReservedInstancesExchangeQuote(AcceptReservedInstancesExchangeQuoteRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AcceptReservedInstancesExchangeQuote operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAcceptReservedInstancesExchangeQuote.</param>
        /// 
        /// <returns>Returns a  AcceptReservedInstancesExchangeQuoteResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AcceptReservedInstancesExchangeQuote">REST API Reference for AcceptReservedInstancesExchangeQuote Operation</seealso>
        AcceptReservedInstancesExchangeQuoteResponse EndAcceptReservedInstancesExchangeQuote(IAsyncResult asyncResult);

        #endregion
        
        #region  AcceptVpcEndpointConnections


        /// <summary>
        /// Accepts one or more interface VPC endpoint connection requests to your VPC endpoint
        /// service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptVpcEndpointConnections service method.</param>
        /// 
        /// <returns>The response from the AcceptVpcEndpointConnections service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AcceptVpcEndpointConnections">REST API Reference for AcceptVpcEndpointConnections Operation</seealso>
        AcceptVpcEndpointConnectionsResponse AcceptVpcEndpointConnections(AcceptVpcEndpointConnectionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AcceptVpcEndpointConnections operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AcceptVpcEndpointConnections operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAcceptVpcEndpointConnections
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AcceptVpcEndpointConnections">REST API Reference for AcceptVpcEndpointConnections Operation</seealso>
        IAsyncResult BeginAcceptVpcEndpointConnections(AcceptVpcEndpointConnectionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AcceptVpcEndpointConnections operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAcceptVpcEndpointConnections.</param>
        /// 
        /// <returns>Returns a  AcceptVpcEndpointConnectionsResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AcceptVpcEndpointConnections">REST API Reference for AcceptVpcEndpointConnections Operation</seealso>
        AcceptVpcEndpointConnectionsResponse EndAcceptVpcEndpointConnections(IAsyncResult asyncResult);

        #endregion
        
        #region  AcceptVpcPeeringConnection


        /// <summary>
        /// Accept a VPC peering connection request. To accept a request, the VPC peering connection
        /// must be in the <code>pending-acceptance</code> state, and you must be the owner of
        /// the peer VPC. Use <a>DescribeVpcPeeringConnections</a> to view your outstanding VPC
        /// peering connection requests.
        /// 
        ///  
        /// <para>
        /// For an inter-region VPC peering connection request, you must accept the VPC peering
        /// connection in the region of the accepter VPC.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptVpcPeeringConnection service method.</param>
        /// 
        /// <returns>The response from the AcceptVpcPeeringConnection service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AcceptVpcPeeringConnection">REST API Reference for AcceptVpcPeeringConnection Operation</seealso>
        AcceptVpcPeeringConnectionResponse AcceptVpcPeeringConnection(AcceptVpcPeeringConnectionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AcceptVpcPeeringConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AcceptVpcPeeringConnection operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAcceptVpcPeeringConnection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AcceptVpcPeeringConnection">REST API Reference for AcceptVpcPeeringConnection Operation</seealso>
        IAsyncResult BeginAcceptVpcPeeringConnection(AcceptVpcPeeringConnectionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AcceptVpcPeeringConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAcceptVpcPeeringConnection.</param>
        /// 
        /// <returns>Returns a  AcceptVpcPeeringConnectionResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AcceptVpcPeeringConnection">REST API Reference for AcceptVpcPeeringConnection Operation</seealso>
        AcceptVpcPeeringConnectionResponse EndAcceptVpcPeeringConnection(IAsyncResult asyncResult);

        #endregion
        
        #region  AllocateAddress


        /// <summary>
        /// Allocates an Elastic IP address.
        /// 
        ///  
        /// <para>
        /// An Elastic IP address is for use either in the EC2-Classic platform or in a VPC. By
        /// default, you can allocate 5 Elastic IP addresses for EC2-Classic per region and 5
        /// Elastic IP addresses for EC2-VPC per region.
        /// </para>
        ///  
        /// <para>
        /// If you release an Elastic IP address for use in a VPC, you might be able to recover
        /// it. To recover an Elastic IP address that you released, specify it in the <code>Address</code>
        /// parameter. Note that you cannot recover an Elastic IP address that you released after
        /// it is allocated to another AWS account.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/elastic-ip-addresses-eip.html">Elastic
        /// IP Addresses</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the AllocateAddress service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AllocateAddress">REST API Reference for AllocateAddress Operation</seealso>
        AllocateAddressResponse AllocateAddress();

        /// <summary>
        /// Allocates an Elastic IP address.
        /// 
        ///  
        /// <para>
        /// An Elastic IP address is for use either in the EC2-Classic platform or in a VPC. By
        /// default, you can allocate 5 Elastic IP addresses for EC2-Classic per region and 5
        /// Elastic IP addresses for EC2-VPC per region.
        /// </para>
        ///  
        /// <para>
        /// If you release an Elastic IP address for use in a VPC, you might be able to recover
        /// it. To recover an Elastic IP address that you released, specify it in the <code>Address</code>
        /// parameter. Note that you cannot recover an Elastic IP address that you released after
        /// it is allocated to another AWS account.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/elastic-ip-addresses-eip.html">Elastic
        /// IP Addresses</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AllocateAddress service method.</param>
        /// 
        /// <returns>The response from the AllocateAddress service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AllocateAddress">REST API Reference for AllocateAddress Operation</seealso>
        AllocateAddressResponse AllocateAddress(AllocateAddressRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AllocateAddress operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AllocateAddress operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAllocateAddress
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AllocateAddress">REST API Reference for AllocateAddress Operation</seealso>
        IAsyncResult BeginAllocateAddress(AllocateAddressRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AllocateAddress operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAllocateAddress.</param>
        /// 
        /// <returns>Returns a  AllocateAddressResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AllocateAddress">REST API Reference for AllocateAddress Operation</seealso>
        AllocateAddressResponse EndAllocateAddress(IAsyncResult asyncResult);

        #endregion
        
        #region  AllocateHosts


        /// <summary>
        /// Allocates a Dedicated Host to your account. At minimum you need to specify the instance
        /// size type, Availability Zone, and quantity of hosts you want to allocate.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AllocateHosts service method.</param>
        /// 
        /// <returns>The response from the AllocateHosts service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AllocateHosts">REST API Reference for AllocateHosts Operation</seealso>
        AllocateHostsResponse AllocateHosts(AllocateHostsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AllocateHosts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AllocateHosts operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAllocateHosts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AllocateHosts">REST API Reference for AllocateHosts Operation</seealso>
        IAsyncResult BeginAllocateHosts(AllocateHostsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AllocateHosts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAllocateHosts.</param>
        /// 
        /// <returns>Returns a  AllocateHostsResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AllocateHosts">REST API Reference for AllocateHosts Operation</seealso>
        AllocateHostsResponse EndAllocateHosts(IAsyncResult asyncResult);

        #endregion
        
        #region  AssignIpv6Addresses


        /// <summary>
        /// Assigns one or more IPv6 addresses to the specified network interface. You can specify
        /// one or more specific IPv6 addresses, or you can specify the number of IPv6 addresses
        /// to be automatically assigned from within the subnet's IPv6 CIDR block range. You can
        /// assign as many IPv6 addresses to a network interface as you can assign private IPv4
        /// addresses, and the limit varies per instance type. For information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-eni.html#AvailableIpPerENI">IP
        /// Addresses Per Network Interface Per Instance Type</a> in the <i>Amazon Elastic Compute
        /// Cloud User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssignIpv6Addresses service method.</param>
        /// 
        /// <returns>The response from the AssignIpv6Addresses service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AssignIpv6Addresses">REST API Reference for AssignIpv6Addresses Operation</seealso>
        AssignIpv6AddressesResponse AssignIpv6Addresses(AssignIpv6AddressesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssignIpv6Addresses operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssignIpv6Addresses operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssignIpv6Addresses
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AssignIpv6Addresses">REST API Reference for AssignIpv6Addresses Operation</seealso>
        IAsyncResult BeginAssignIpv6Addresses(AssignIpv6AddressesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssignIpv6Addresses operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssignIpv6Addresses.</param>
        /// 
        /// <returns>Returns a  AssignIpv6AddressesResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AssignIpv6Addresses">REST API Reference for AssignIpv6Addresses Operation</seealso>
        AssignIpv6AddressesResponse EndAssignIpv6Addresses(IAsyncResult asyncResult);

        #endregion
        
        #region  AssignPrivateIpAddresses


        /// <summary>
        /// Assigns one or more secondary private IP addresses to the specified network interface.
        /// You can specify one or more specific secondary IP addresses, or you can specify the
        /// number of secondary IP addresses to be automatically assigned within the subnet's
        /// CIDR block range. The number of secondary IP addresses that you can assign to an instance
        /// varies by instance type. For information about instance types, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-types.html">Instance
        /// Types</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>. For more information
        /// about Elastic IP addresses, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/elastic-ip-addresses-eip.html">Elastic
        /// IP Addresses</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// 
        ///  
        /// <para>
        /// AssignPrivateIpAddresses is available only in EC2-VPC.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssignPrivateIpAddresses service method.</param>
        /// 
        /// <returns>The response from the AssignPrivateIpAddresses service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AssignPrivateIpAddresses">REST API Reference for AssignPrivateIpAddresses Operation</seealso>
        AssignPrivateIpAddressesResponse AssignPrivateIpAddresses(AssignPrivateIpAddressesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssignPrivateIpAddresses operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssignPrivateIpAddresses operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssignPrivateIpAddresses
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AssignPrivateIpAddresses">REST API Reference for AssignPrivateIpAddresses Operation</seealso>
        IAsyncResult BeginAssignPrivateIpAddresses(AssignPrivateIpAddressesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssignPrivateIpAddresses operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssignPrivateIpAddresses.</param>
        /// 
        /// <returns>Returns a  AssignPrivateIpAddressesResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AssignPrivateIpAddresses">REST API Reference for AssignPrivateIpAddresses Operation</seealso>
        AssignPrivateIpAddressesResponse EndAssignPrivateIpAddresses(IAsyncResult asyncResult);

        #endregion
        
        #region  AssociateAddress


        /// <summary>
        /// Associates an Elastic IP address with an instance or a network interface.
        /// 
        ///  
        /// <para>
        /// An Elastic IP address is for use in either the EC2-Classic platform or in a VPC. For
        /// more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/elastic-ip-addresses-eip.html">Elastic
        /// IP Addresses</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// [EC2-Classic, VPC in an EC2-VPC-only account] If the Elastic IP address is already
        /// associated with a different instance, it is disassociated from that instance and associated
        /// with the specified instance. If you associate an Elastic IP address with an instance
        /// that has an existing Elastic IP address, the existing address is disassociated from
        /// the instance, but remains allocated to your account.
        /// </para>
        ///  
        /// <para>
        /// [VPC in an EC2-Classic account] If you don't specify a private IP address, the Elastic
        /// IP address is associated with the primary IP address. If the Elastic IP address is
        /// already associated with a different instance or a network interface, you get an error
        /// unless you allow reassociation. You cannot associate an Elastic IP address with an
        /// instance or network interface that has an existing Elastic IP address.
        /// </para>
        ///  <important> 
        /// <para>
        /// This is an idempotent operation. If you perform the operation more than once, Amazon
        /// EC2 doesn't return an error, and you may be charged for each time the Elastic IP address
        /// is remapped to the same instance. For more information, see the <i>Elastic IP Addresses</i>
        /// section of <a href="http://aws.amazon.com/ec2/pricing/">Amazon EC2 Pricing</a>.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateAddress service method.</param>
        /// 
        /// <returns>The response from the AssociateAddress service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AssociateAddress">REST API Reference for AssociateAddress Operation</seealso>
        AssociateAddressResponse AssociateAddress(AssociateAddressRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateAddress operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateAddress operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateAddress
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AssociateAddress">REST API Reference for AssociateAddress Operation</seealso>
        IAsyncResult BeginAssociateAddress(AssociateAddressRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateAddress operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateAddress.</param>
        /// 
        /// <returns>Returns a  AssociateAddressResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AssociateAddress">REST API Reference for AssociateAddress Operation</seealso>
        AssociateAddressResponse EndAssociateAddress(IAsyncResult asyncResult);

        #endregion
        
        #region  AssociateDhcpOptions


        /// <summary>
        /// Associates a set of DHCP options (that you've previously created) with the specified
        /// VPC, or associates no DHCP options with the VPC.
        /// 
        ///  
        /// <para>
        /// After you associate the options with the VPC, any existing instances and all new instances
        /// that you launch in that VPC use the options. You don't need to restart or relaunch
        /// the instances. They automatically pick up the changes within a few hours, depending
        /// on how frequently the instance renews its DHCP lease. You can explicitly renew the
        /// lease using the operating system on the instance.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_DHCP_Options.html">DHCP
        /// Options Sets</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateDhcpOptions service method.</param>
        /// 
        /// <returns>The response from the AssociateDhcpOptions service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AssociateDhcpOptions">REST API Reference for AssociateDhcpOptions Operation</seealso>
        AssociateDhcpOptionsResponse AssociateDhcpOptions(AssociateDhcpOptionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateDhcpOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateDhcpOptions operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateDhcpOptions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AssociateDhcpOptions">REST API Reference for AssociateDhcpOptions Operation</seealso>
        IAsyncResult BeginAssociateDhcpOptions(AssociateDhcpOptionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateDhcpOptions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateDhcpOptions.</param>
        /// 
        /// <returns>Returns a  AssociateDhcpOptionsResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AssociateDhcpOptions">REST API Reference for AssociateDhcpOptions Operation</seealso>
        AssociateDhcpOptionsResponse EndAssociateDhcpOptions(IAsyncResult asyncResult);

        #endregion
        
        #region  AssociateIamInstanceProfile


        /// <summary>
        /// Associates an IAM instance profile with a running or stopped instance. You cannot
        /// associate more than one IAM instance profile with an instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateIamInstanceProfile service method.</param>
        /// 
        /// <returns>The response from the AssociateIamInstanceProfile service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AssociateIamInstanceProfile">REST API Reference for AssociateIamInstanceProfile Operation</seealso>
        AssociateIamInstanceProfileResponse AssociateIamInstanceProfile(AssociateIamInstanceProfileRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateIamInstanceProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateIamInstanceProfile operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateIamInstanceProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AssociateIamInstanceProfile">REST API Reference for AssociateIamInstanceProfile Operation</seealso>
        IAsyncResult BeginAssociateIamInstanceProfile(AssociateIamInstanceProfileRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateIamInstanceProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateIamInstanceProfile.</param>
        /// 
        /// <returns>Returns a  AssociateIamInstanceProfileResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AssociateIamInstanceProfile">REST API Reference for AssociateIamInstanceProfile Operation</seealso>
        AssociateIamInstanceProfileResponse EndAssociateIamInstanceProfile(IAsyncResult asyncResult);

        #endregion
        
        #region  AssociateRouteTable


        /// <summary>
        /// Associates a subnet with a route table. The subnet and route table must be in the
        /// same VPC. This association causes traffic originating from the subnet to be routed
        /// according to the routes in the route table. The action returns an association ID,
        /// which you need in order to disassociate the route table from the subnet later. A route
        /// table can be associated with multiple subnets.
        /// 
        ///  
        /// <para>
        /// For more information about route tables, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Route_Tables.html">Route
        /// Tables</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateRouteTable service method.</param>
        /// 
        /// <returns>The response from the AssociateRouteTable service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AssociateRouteTable">REST API Reference for AssociateRouteTable Operation</seealso>
        AssociateRouteTableResponse AssociateRouteTable(AssociateRouteTableRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateRouteTable operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateRouteTable operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateRouteTable
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AssociateRouteTable">REST API Reference for AssociateRouteTable Operation</seealso>
        IAsyncResult BeginAssociateRouteTable(AssociateRouteTableRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateRouteTable operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateRouteTable.</param>
        /// 
        /// <returns>Returns a  AssociateRouteTableResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AssociateRouteTable">REST API Reference for AssociateRouteTable Operation</seealso>
        AssociateRouteTableResponse EndAssociateRouteTable(IAsyncResult asyncResult);

        #endregion
        
        #region  AssociateSubnetCidrBlock


        /// <summary>
        /// Associates a CIDR block with your subnet. You can only associate a single IPv6 CIDR
        /// block with your subnet. An IPv6 CIDR block must have a prefix length of /64.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateSubnetCidrBlock service method.</param>
        /// 
        /// <returns>The response from the AssociateSubnetCidrBlock service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AssociateSubnetCidrBlock">REST API Reference for AssociateSubnetCidrBlock Operation</seealso>
        AssociateSubnetCidrBlockResponse AssociateSubnetCidrBlock(AssociateSubnetCidrBlockRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateSubnetCidrBlock operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateSubnetCidrBlock operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateSubnetCidrBlock
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AssociateSubnetCidrBlock">REST API Reference for AssociateSubnetCidrBlock Operation</seealso>
        IAsyncResult BeginAssociateSubnetCidrBlock(AssociateSubnetCidrBlockRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateSubnetCidrBlock operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateSubnetCidrBlock.</param>
        /// 
        /// <returns>Returns a  AssociateSubnetCidrBlockResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AssociateSubnetCidrBlock">REST API Reference for AssociateSubnetCidrBlock Operation</seealso>
        AssociateSubnetCidrBlockResponse EndAssociateSubnetCidrBlock(IAsyncResult asyncResult);

        #endregion
        
        #region  AssociateVpcCidrBlock


        /// <summary>
        /// Associates a CIDR block with your VPC. You can associate a secondary IPv4 CIDR block,
        /// or you can associate an Amazon-provided IPv6 CIDR block. The IPv6 CIDR block size
        /// is fixed at /56.
        /// 
        ///  
        /// <para>
        /// For more information about associating CIDR blocks with your VPC and applicable restrictions,
        /// see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Subnets.html#VPC_Sizing">VPC
        /// and Subnet Sizing</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateVpcCidrBlock service method.</param>
        /// 
        /// <returns>The response from the AssociateVpcCidrBlock service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AssociateVpcCidrBlock">REST API Reference for AssociateVpcCidrBlock Operation</seealso>
        AssociateVpcCidrBlockResponse AssociateVpcCidrBlock(AssociateVpcCidrBlockRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateVpcCidrBlock operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateVpcCidrBlock operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateVpcCidrBlock
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AssociateVpcCidrBlock">REST API Reference for AssociateVpcCidrBlock Operation</seealso>
        IAsyncResult BeginAssociateVpcCidrBlock(AssociateVpcCidrBlockRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateVpcCidrBlock operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateVpcCidrBlock.</param>
        /// 
        /// <returns>Returns a  AssociateVpcCidrBlockResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AssociateVpcCidrBlock">REST API Reference for AssociateVpcCidrBlock Operation</seealso>
        AssociateVpcCidrBlockResponse EndAssociateVpcCidrBlock(IAsyncResult asyncResult);

        #endregion
        
        #region  AttachClassicLinkVpc


        /// <summary>
        /// Links an EC2-Classic instance to a ClassicLink-enabled VPC through one or more of
        /// the VPC's security groups. You cannot link an EC2-Classic instance to more than one
        /// VPC at a time. You can only link an instance that's in the <code>running</code> state.
        /// An instance is automatically unlinked from a VPC when it's stopped - you can link
        /// it to the VPC again when you restart it.
        /// 
        ///  
        /// <para>
        /// After you've linked an instance, you cannot change the VPC security groups that are
        /// associated with it. To change the security groups, you must first unlink the instance,
        /// and then link it again.
        /// </para>
        ///  
        /// <para>
        /// Linking your instance to a VPC is sometimes referred to as <i>attaching</i> your instance.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachClassicLinkVpc service method.</param>
        /// 
        /// <returns>The response from the AttachClassicLinkVpc service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AttachClassicLinkVpc">REST API Reference for AttachClassicLinkVpc Operation</seealso>
        AttachClassicLinkVpcResponse AttachClassicLinkVpc(AttachClassicLinkVpcRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AttachClassicLinkVpc operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachClassicLinkVpc operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAttachClassicLinkVpc
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AttachClassicLinkVpc">REST API Reference for AttachClassicLinkVpc Operation</seealso>
        IAsyncResult BeginAttachClassicLinkVpc(AttachClassicLinkVpcRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AttachClassicLinkVpc operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAttachClassicLinkVpc.</param>
        /// 
        /// <returns>Returns a  AttachClassicLinkVpcResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AttachClassicLinkVpc">REST API Reference for AttachClassicLinkVpc Operation</seealso>
        AttachClassicLinkVpcResponse EndAttachClassicLinkVpc(IAsyncResult asyncResult);

        #endregion
        
        #region  AttachInternetGateway


        /// <summary>
        /// Attaches an Internet gateway to a VPC, enabling connectivity between the Internet
        /// and the VPC. For more information about your VPC and Internet gateway, see the <a
        /// href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/">Amazon Virtual Private
        /// Cloud User Guide</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachInternetGateway service method.</param>
        /// 
        /// <returns>The response from the AttachInternetGateway service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AttachInternetGateway">REST API Reference for AttachInternetGateway Operation</seealso>
        AttachInternetGatewayResponse AttachInternetGateway(AttachInternetGatewayRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AttachInternetGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachInternetGateway operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAttachInternetGateway
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AttachInternetGateway">REST API Reference for AttachInternetGateway Operation</seealso>
        IAsyncResult BeginAttachInternetGateway(AttachInternetGatewayRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AttachInternetGateway operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAttachInternetGateway.</param>
        /// 
        /// <returns>Returns a  AttachInternetGatewayResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AttachInternetGateway">REST API Reference for AttachInternetGateway Operation</seealso>
        AttachInternetGatewayResponse EndAttachInternetGateway(IAsyncResult asyncResult);

        #endregion
        
        #region  AttachNetworkInterface


        /// <summary>
        /// Attaches a network interface to an instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachNetworkInterface service method.</param>
        /// 
        /// <returns>The response from the AttachNetworkInterface service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AttachNetworkInterface">REST API Reference for AttachNetworkInterface Operation</seealso>
        AttachNetworkInterfaceResponse AttachNetworkInterface(AttachNetworkInterfaceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AttachNetworkInterface operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachNetworkInterface operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAttachNetworkInterface
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AttachNetworkInterface">REST API Reference for AttachNetworkInterface Operation</seealso>
        IAsyncResult BeginAttachNetworkInterface(AttachNetworkInterfaceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AttachNetworkInterface operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAttachNetworkInterface.</param>
        /// 
        /// <returns>Returns a  AttachNetworkInterfaceResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AttachNetworkInterface">REST API Reference for AttachNetworkInterface Operation</seealso>
        AttachNetworkInterfaceResponse EndAttachNetworkInterface(IAsyncResult asyncResult);

        #endregion
        
        #region  AttachVolume


        /// <summary>
        /// Attaches an EBS volume to a running or stopped instance and exposes it to the instance
        /// with the specified device name.
        /// 
        ///  
        /// <para>
        /// Encrypted EBS volumes may only be attached to instances that support Amazon EBS encryption.
        /// For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSEncryption.html">Amazon
        /// EBS Encryption</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For a list of supported device names, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-attaching-volume.html">Attaching
        /// an EBS Volume to an Instance</a>. Any device names that aren't reserved for instance
        /// store volumes can be used for EBS volumes. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/InstanceStorage.html">Amazon
        /// EC2 Instance Store</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If a volume has an AWS Marketplace product code:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The volume can be attached only to a stopped instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// AWS Marketplace product codes are copied from the volume to the instance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// You must be subscribed to the product.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The instance type and operating system of the instance must support the product. For
        /// example, you can't detach a volume from a Windows instance and attach it to a Linux
        /// instance.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// For an overview of the AWS Marketplace, see <a href="https://aws.amazon.com/marketplace/help/200900000">Introducing
        /// AWS Marketplace</a>.
        /// </para>
        ///  
        /// <para>
        /// For more information about EBS volumes, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-attaching-volume.html">Attaching
        /// Amazon EBS Volumes</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachVolume service method.</param>
        /// 
        /// <returns>The response from the AttachVolume service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AttachVolume">REST API Reference for AttachVolume Operation</seealso>
        AttachVolumeResponse AttachVolume(AttachVolumeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AttachVolume operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachVolume operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAttachVolume
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AttachVolume">REST API Reference for AttachVolume Operation</seealso>
        IAsyncResult BeginAttachVolume(AttachVolumeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AttachVolume operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAttachVolume.</param>
        /// 
        /// <returns>Returns a  AttachVolumeResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AttachVolume">REST API Reference for AttachVolume Operation</seealso>
        AttachVolumeResponse EndAttachVolume(IAsyncResult asyncResult);

        #endregion
        
        #region  AttachVpnGateway


        /// <summary>
        /// Attaches a virtual private gateway to a VPC. You can attach one virtual private gateway
        /// to one VPC at a time.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_VPN.html">AWS
        /// Managed VPN Connections</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachVpnGateway service method.</param>
        /// 
        /// <returns>The response from the AttachVpnGateway service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AttachVpnGateway">REST API Reference for AttachVpnGateway Operation</seealso>
        AttachVpnGatewayResponse AttachVpnGateway(AttachVpnGatewayRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AttachVpnGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachVpnGateway operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAttachVpnGateway
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AttachVpnGateway">REST API Reference for AttachVpnGateway Operation</seealso>
        IAsyncResult BeginAttachVpnGateway(AttachVpnGatewayRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AttachVpnGateway operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAttachVpnGateway.</param>
        /// 
        /// <returns>Returns a  AttachVpnGatewayResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AttachVpnGateway">REST API Reference for AttachVpnGateway Operation</seealso>
        AttachVpnGatewayResponse EndAttachVpnGateway(IAsyncResult asyncResult);

        #endregion
        
        #region  AuthorizeSecurityGroupEgress


        /// <summary>
        /// [EC2-VPC only] Adds one or more egress rules to a security group for use with a VPC.
        /// Specifically, this action permits instances to send traffic to one or more destination
        /// IPv4 or IPv6 CIDR address ranges, or to one or more destination security groups for
        /// the same VPC. This action doesn't apply to security groups for use in EC2-Classic.
        /// For more information, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_SecurityGroups.html">Security
        /// Groups for Your VPC</a> in the <i>Amazon Virtual Private Cloud User Guide</i>. For
        /// more information about security group limits, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Appendix_Limits.html">Amazon
        /// VPC Limits</a>.
        /// 
        ///  
        /// <para>
        /// Each rule consists of the protocol (for example, TCP), plus either a CIDR range or
        /// a source group. For the TCP and UDP protocols, you must also specify the destination
        /// port or port range. For the ICMP protocol, you must also specify the ICMP type and
        /// code. You can use -1 for the type or code to mean all types or all codes. You can
        /// optionally specify a description for the rule.
        /// </para>
        ///  
        /// <para>
        /// Rule changes are propagated to affected instances as quickly as possible. However,
        /// a small delay might occur.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AuthorizeSecurityGroupEgress service method.</param>
        /// 
        /// <returns>The response from the AuthorizeSecurityGroupEgress service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AuthorizeSecurityGroupEgress">REST API Reference for AuthorizeSecurityGroupEgress Operation</seealso>
        AuthorizeSecurityGroupEgressResponse AuthorizeSecurityGroupEgress(AuthorizeSecurityGroupEgressRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AuthorizeSecurityGroupEgress operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AuthorizeSecurityGroupEgress operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAuthorizeSecurityGroupEgress
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AuthorizeSecurityGroupEgress">REST API Reference for AuthorizeSecurityGroupEgress Operation</seealso>
        IAsyncResult BeginAuthorizeSecurityGroupEgress(AuthorizeSecurityGroupEgressRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AuthorizeSecurityGroupEgress operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAuthorizeSecurityGroupEgress.</param>
        /// 
        /// <returns>Returns a  AuthorizeSecurityGroupEgressResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AuthorizeSecurityGroupEgress">REST API Reference for AuthorizeSecurityGroupEgress Operation</seealso>
        AuthorizeSecurityGroupEgressResponse EndAuthorizeSecurityGroupEgress(IAsyncResult asyncResult);

        #endregion
        
        #region  AuthorizeSecurityGroupIngress


        /// <summary>
        /// Adds one or more ingress rules to a security group.
        /// 
        ///  
        /// <para>
        /// Rule changes are propagated to instances within the security group as quickly as possible.
        /// However, a small delay might occur.
        /// </para>
        ///  
        /// <para>
        /// [EC2-Classic] This action gives one or more IPv4 CIDR address ranges permission to
        /// access a security group in your account, or gives one or more security groups (called
        /// the <i>source groups</i>) permission to access a security group for your account.
        /// A source group can be for your own AWS account, or another. You can have up to 100
        /// rules per group.
        /// </para>
        ///  
        /// <para>
        /// [EC2-VPC] This action gives one or more IPv4 or IPv6 CIDR address ranges permission
        /// to access a security group in your VPC, or gives one or more other security groups
        /// (called the <i>source groups</i>) permission to access a security group for your VPC.
        /// The security groups must all be for the same VPC or a peer VPC in a VPC peering connection.
        /// For more information about VPC security group limits, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Appendix_Limits.html">Amazon
        /// VPC Limits</a>.
        /// </para>
        ///  
        /// <para>
        /// You can optionally specify a description for the security group rule.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AuthorizeSecurityGroupIngress service method.</param>
        /// 
        /// <returns>The response from the AuthorizeSecurityGroupIngress service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AuthorizeSecurityGroupIngress">REST API Reference for AuthorizeSecurityGroupIngress Operation</seealso>
        AuthorizeSecurityGroupIngressResponse AuthorizeSecurityGroupIngress(AuthorizeSecurityGroupIngressRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AuthorizeSecurityGroupIngress operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AuthorizeSecurityGroupIngress operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAuthorizeSecurityGroupIngress
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AuthorizeSecurityGroupIngress">REST API Reference for AuthorizeSecurityGroupIngress Operation</seealso>
        IAsyncResult BeginAuthorizeSecurityGroupIngress(AuthorizeSecurityGroupIngressRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AuthorizeSecurityGroupIngress operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAuthorizeSecurityGroupIngress.</param>
        /// 
        /// <returns>Returns a  AuthorizeSecurityGroupIngressResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AuthorizeSecurityGroupIngress">REST API Reference for AuthorizeSecurityGroupIngress Operation</seealso>
        AuthorizeSecurityGroupIngressResponse EndAuthorizeSecurityGroupIngress(IAsyncResult asyncResult);

        #endregion
        
        #region  BundleInstance


        /// <summary>
        /// Bundles an Amazon instance store-backed Windows instance.
        /// 
        ///  
        /// <para>
        /// During bundling, only the root device volume (C:\) is bundled. Data on other instance
        /// store volumes is not preserved.
        /// </para>
        ///  <note> 
        /// <para>
        /// This action is not applicable for Linux/Unix instances or Windows instances that are
        /// backed by Amazon EBS.
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/WindowsGuide/Creating_InstanceStoreBacked_WinAMI.html">Creating
        /// an Instance Store-Backed Windows AMI</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BundleInstance service method.</param>
        /// 
        /// <returns>The response from the BundleInstance service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/BundleInstance">REST API Reference for BundleInstance Operation</seealso>
        BundleInstanceResponse BundleInstance(BundleInstanceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BundleInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BundleInstance operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBundleInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/BundleInstance">REST API Reference for BundleInstance Operation</seealso>
        IAsyncResult BeginBundleInstance(BundleInstanceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BundleInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBundleInstance.</param>
        /// 
        /// <returns>Returns a  BundleInstanceResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/BundleInstance">REST API Reference for BundleInstance Operation</seealso>
        BundleInstanceResponse EndBundleInstance(IAsyncResult asyncResult);

        #endregion
        
        #region  CancelBundleTask


        /// <summary>
        /// Cancels a bundling operation for an instance store-backed Windows instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelBundleTask service method.</param>
        /// 
        /// <returns>The response from the CancelBundleTask service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CancelBundleTask">REST API Reference for CancelBundleTask Operation</seealso>
        CancelBundleTaskResponse CancelBundleTask(CancelBundleTaskRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CancelBundleTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelBundleTask operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelBundleTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CancelBundleTask">REST API Reference for CancelBundleTask Operation</seealso>
        IAsyncResult BeginCancelBundleTask(CancelBundleTaskRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CancelBundleTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelBundleTask.</param>
        /// 
        /// <returns>Returns a  CancelBundleTaskResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CancelBundleTask">REST API Reference for CancelBundleTask Operation</seealso>
        CancelBundleTaskResponse EndCancelBundleTask(IAsyncResult asyncResult);

        #endregion
        
        #region  CancelConversionTask


        /// <summary>
        /// Cancels an active conversion task. The task can be the import of an instance or volume.
        /// The action removes all artifacts of the conversion, including a partially uploaded
        /// volume or instance. If the conversion is complete or is in the process of transferring
        /// the final disk image, the command fails and returns an exception.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/CommandLineReference/ec2-cli-vmimport-export.html">Importing
        /// a Virtual Machine Using the Amazon EC2 CLI</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelConversionTask service method.</param>
        /// 
        /// <returns>The response from the CancelConversionTask service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CancelConversionTask">REST API Reference for CancelConversionTask Operation</seealso>
        CancelConversionTaskResponse CancelConversionTask(CancelConversionTaskRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CancelConversionTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelConversionTask operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelConversionTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CancelConversionTask">REST API Reference for CancelConversionTask Operation</seealso>
        IAsyncResult BeginCancelConversionTask(CancelConversionTaskRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CancelConversionTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelConversionTask.</param>
        /// 
        /// <returns>Returns a  CancelConversionTaskResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CancelConversionTask">REST API Reference for CancelConversionTask Operation</seealso>
        CancelConversionTaskResponse EndCancelConversionTask(IAsyncResult asyncResult);

        #endregion
        
        #region  CancelExportTask


        /// <summary>
        /// Cancels an active export task. The request removes all artifacts of the export, including
        /// any partially-created Amazon S3 objects. If the export task is complete or is in the
        /// process of transferring the final disk image, the command fails and returns an error.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelExportTask service method.</param>
        /// 
        /// <returns>The response from the CancelExportTask service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CancelExportTask">REST API Reference for CancelExportTask Operation</seealso>
        CancelExportTaskResponse CancelExportTask(CancelExportTaskRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CancelExportTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelExportTask operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelExportTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CancelExportTask">REST API Reference for CancelExportTask Operation</seealso>
        IAsyncResult BeginCancelExportTask(CancelExportTaskRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CancelExportTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelExportTask.</param>
        /// 
        /// <returns>Returns a  CancelExportTaskResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CancelExportTask">REST API Reference for CancelExportTask Operation</seealso>
        CancelExportTaskResponse EndCancelExportTask(IAsyncResult asyncResult);

        #endregion
        
        #region  CancelImportTask


        /// <summary>
        /// Cancels an in-process import virtual machine or import snapshot task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelImportTask service method.</param>
        /// 
        /// <returns>The response from the CancelImportTask service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CancelImportTask">REST API Reference for CancelImportTask Operation</seealso>
        CancelImportTaskResponse CancelImportTask(CancelImportTaskRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CancelImportTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelImportTask operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelImportTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CancelImportTask">REST API Reference for CancelImportTask Operation</seealso>
        IAsyncResult BeginCancelImportTask(CancelImportTaskRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CancelImportTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelImportTask.</param>
        /// 
        /// <returns>Returns a  CancelImportTaskResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CancelImportTask">REST API Reference for CancelImportTask Operation</seealso>
        CancelImportTaskResponse EndCancelImportTask(IAsyncResult asyncResult);

        #endregion
        
        #region  CancelReservedInstancesListing


        /// <summary>
        /// Cancels the specified Reserved Instance listing in the Reserved Instance Marketplace.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ri-market-general.html">Reserved
        /// Instance Marketplace</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelReservedInstancesListing service method.</param>
        /// 
        /// <returns>The response from the CancelReservedInstancesListing service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CancelReservedInstancesListing">REST API Reference for CancelReservedInstancesListing Operation</seealso>
        CancelReservedInstancesListingResponse CancelReservedInstancesListing(CancelReservedInstancesListingRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CancelReservedInstancesListing operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelReservedInstancesListing operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelReservedInstancesListing
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CancelReservedInstancesListing">REST API Reference for CancelReservedInstancesListing Operation</seealso>
        IAsyncResult BeginCancelReservedInstancesListing(CancelReservedInstancesListingRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CancelReservedInstancesListing operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelReservedInstancesListing.</param>
        /// 
        /// <returns>Returns a  CancelReservedInstancesListingResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CancelReservedInstancesListing">REST API Reference for CancelReservedInstancesListing Operation</seealso>
        CancelReservedInstancesListingResponse EndCancelReservedInstancesListing(IAsyncResult asyncResult);

        #endregion
        
        #region  CancelSpotFleetRequests


        /// <summary>
        /// Cancels the specified Spot Fleet requests.
        /// 
        ///  
        /// <para>
        /// After you cancel a Spot Fleet request, the Spot Fleet launches no new Spot Instances.
        /// You must specify whether the Spot Fleet should also terminate its Spot Instances.
        /// If you terminate the instances, the Spot Fleet request enters the <code>cancelled_terminating</code>
        /// state. Otherwise, the Spot Fleet request enters the <code>cancelled_running</code>
        /// state and the instances continue to run until they are interrupted or you terminate
        /// them manually.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelSpotFleetRequests service method.</param>
        /// 
        /// <returns>The response from the CancelSpotFleetRequests service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CancelSpotFleetRequests">REST API Reference for CancelSpotFleetRequests Operation</seealso>
        CancelSpotFleetRequestsResponse CancelSpotFleetRequests(CancelSpotFleetRequestsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CancelSpotFleetRequests operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelSpotFleetRequests operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelSpotFleetRequests
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CancelSpotFleetRequests">REST API Reference for CancelSpotFleetRequests Operation</seealso>
        IAsyncResult BeginCancelSpotFleetRequests(CancelSpotFleetRequestsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CancelSpotFleetRequests operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelSpotFleetRequests.</param>
        /// 
        /// <returns>Returns a  CancelSpotFleetRequestsResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CancelSpotFleetRequests">REST API Reference for CancelSpotFleetRequests Operation</seealso>
        CancelSpotFleetRequestsResponse EndCancelSpotFleetRequests(IAsyncResult asyncResult);

        #endregion
        
        #region  CancelSpotInstanceRequests


        /// <summary>
        /// Cancels one or more Spot Instance requests.
        /// 
        ///  <important> 
        /// <para>
        /// Canceling a Spot Instance request does not terminate running Spot Instances associated
        /// with the request.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelSpotInstanceRequests service method.</param>
        /// 
        /// <returns>The response from the CancelSpotInstanceRequests service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CancelSpotInstanceRequests">REST API Reference for CancelSpotInstanceRequests Operation</seealso>
        CancelSpotInstanceRequestsResponse CancelSpotInstanceRequests(CancelSpotInstanceRequestsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CancelSpotInstanceRequests operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelSpotInstanceRequests operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelSpotInstanceRequests
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CancelSpotInstanceRequests">REST API Reference for CancelSpotInstanceRequests Operation</seealso>
        IAsyncResult BeginCancelSpotInstanceRequests(CancelSpotInstanceRequestsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CancelSpotInstanceRequests operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelSpotInstanceRequests.</param>
        /// 
        /// <returns>Returns a  CancelSpotInstanceRequestsResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CancelSpotInstanceRequests">REST API Reference for CancelSpotInstanceRequests Operation</seealso>
        CancelSpotInstanceRequestsResponse EndCancelSpotInstanceRequests(IAsyncResult asyncResult);

        #endregion
        
        #region  ConfirmProductInstance


        /// <summary>
        /// Determines whether a product code is associated with an instance. This action can
        /// only be used by the owner of the product code. It is useful when a product code owner
        /// must verify whether another user's instance is eligible for support.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ConfirmProductInstance service method.</param>
        /// 
        /// <returns>The response from the ConfirmProductInstance service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ConfirmProductInstance">REST API Reference for ConfirmProductInstance Operation</seealso>
        ConfirmProductInstanceResponse ConfirmProductInstance(ConfirmProductInstanceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ConfirmProductInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ConfirmProductInstance operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndConfirmProductInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ConfirmProductInstance">REST API Reference for ConfirmProductInstance Operation</seealso>
        IAsyncResult BeginConfirmProductInstance(ConfirmProductInstanceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ConfirmProductInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginConfirmProductInstance.</param>
        /// 
        /// <returns>Returns a  ConfirmProductInstanceResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ConfirmProductInstance">REST API Reference for ConfirmProductInstance Operation</seealso>
        ConfirmProductInstanceResponse EndConfirmProductInstance(IAsyncResult asyncResult);

        #endregion
        
        #region  CopyFpgaImage


        /// <summary>
        /// Copies the specified Amazon FPGA Image (AFI) to the current region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CopyFpgaImage service method.</param>
        /// 
        /// <returns>The response from the CopyFpgaImage service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CopyFpgaImage">REST API Reference for CopyFpgaImage Operation</seealso>
        CopyFpgaImageResponse CopyFpgaImage(CopyFpgaImageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CopyFpgaImage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopyFpgaImage operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCopyFpgaImage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CopyFpgaImage">REST API Reference for CopyFpgaImage Operation</seealso>
        IAsyncResult BeginCopyFpgaImage(CopyFpgaImageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CopyFpgaImage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCopyFpgaImage.</param>
        /// 
        /// <returns>Returns a  CopyFpgaImageResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CopyFpgaImage">REST API Reference for CopyFpgaImage Operation</seealso>
        CopyFpgaImageResponse EndCopyFpgaImage(IAsyncResult asyncResult);

        #endregion
        
        #region  CopyImage


        /// <summary>
        /// Initiates the copy of an AMI from the specified source region to the current region.
        /// You specify the destination region by using its endpoint when making the request.
        /// 
        ///  
        /// <para>
        /// For more information about the prerequisites and limits when copying an AMI, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/CopyingAMIs.html">Copying
        /// an AMI</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CopyImage service method.</param>
        /// 
        /// <returns>The response from the CopyImage service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CopyImage">REST API Reference for CopyImage Operation</seealso>
        CopyImageResponse CopyImage(CopyImageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CopyImage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopyImage operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCopyImage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CopyImage">REST API Reference for CopyImage Operation</seealso>
        IAsyncResult BeginCopyImage(CopyImageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CopyImage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCopyImage.</param>
        /// 
        /// <returns>Returns a  CopyImageResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CopyImage">REST API Reference for CopyImage Operation</seealso>
        CopyImageResponse EndCopyImage(IAsyncResult asyncResult);

        #endregion
        
        #region  CopySnapshot


        /// <summary>
        /// Copies a point-in-time snapshot of an EBS volume and stores it in Amazon S3. You can
        /// copy the snapshot within the same region or from one region to another. You can use
        /// the snapshot to create EBS volumes or Amazon Machine Images (AMIs). The snapshot is
        /// copied to the regional endpoint that you send the HTTP request to.
        /// 
        ///  
        /// <para>
        /// Copies of encrypted EBS snapshots remain encrypted. Copies of unencrypted snapshots
        /// remain unencrypted, unless the <code>Encrypted</code> flag is specified during the
        /// snapshot copy operation. By default, encrypted snapshot copies use the default AWS
        /// Key Management Service (AWS KMS) customer master key (CMK); however, you can specify
        /// a non-default CMK with the <code>KmsKeyId</code> parameter. 
        /// </para>
        ///  <note> 
        /// <para>
        /// To copy an encrypted snapshot that has been shared from another account, you must
        /// have permissions for the CMK used to encrypt the snapshot.
        /// </para>
        ///  </note> <note> 
        /// <para>
        /// Snapshots created by the CopySnapshot action have an arbitrary volume ID that should
        /// not be used for any purpose.
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-copy-snapshot.html">Copying
        /// an Amazon EBS Snapshot</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CopySnapshot service method.</param>
        /// 
        /// <returns>The response from the CopySnapshot service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CopySnapshot">REST API Reference for CopySnapshot Operation</seealso>
        CopySnapshotResponse CopySnapshot(CopySnapshotRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CopySnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopySnapshot operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCopySnapshot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CopySnapshot">REST API Reference for CopySnapshot Operation</seealso>
        IAsyncResult BeginCopySnapshot(CopySnapshotRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CopySnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCopySnapshot.</param>
        /// 
        /// <returns>Returns a  CopySnapshotResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CopySnapshot">REST API Reference for CopySnapshot Operation</seealso>
        CopySnapshotResponse EndCopySnapshot(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateCustomerGateway


        /// <summary>
        /// Provides information to AWS about your VPN customer gateway device. The customer gateway
        /// is the appliance at your end of the VPN connection. (The device on the AWS side of
        /// the VPN connection is the virtual private gateway.) You must provide the Internet-routable
        /// IP address of the customer gateway's external interface. The IP address must be static
        /// and may be behind a device performing network address translation (NAT).
        /// 
        ///  
        /// <para>
        /// For devices that use Border Gateway Protocol (BGP), you can also provide the device's
        /// BGP Autonomous System Number (ASN). You can use an existing ASN assigned to your network.
        /// If you don't have an ASN already, you can use a private ASN (in the 64512 - 65534
        /// range).
        /// </para>
        ///  <note> 
        /// <para>
        /// Amazon EC2 supports all 2-byte ASN numbers in the range of 1 - 65534, with the exception
        /// of 7224, which is reserved in the <code>us-east-1</code> region, and 9059, which is
        /// reserved in the <code>eu-west-1</code> region.
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information about VPN customer gateways, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_VPN.html">AWS
        /// Managed VPN Connections</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        ///  <important> 
        /// <para>
        /// You cannot create more than one customer gateway with the same VPN type, IP address,
        /// and BGP ASN parameter values. If you run an identical request more than one time,
        /// the first request creates the customer gateway, and subsequent requests return information
        /// about the existing customer gateway. The subsequent requests do not create new customer
        /// gateway resources.
        /// </para>
        ///  </important>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCustomerGateway service method.</param>
        /// 
        /// <returns>The response from the CreateCustomerGateway service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateCustomerGateway">REST API Reference for CreateCustomerGateway Operation</seealso>
        CreateCustomerGatewayResponse CreateCustomerGateway(CreateCustomerGatewayRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCustomerGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCustomerGateway operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCustomerGateway
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateCustomerGateway">REST API Reference for CreateCustomerGateway Operation</seealso>
        IAsyncResult BeginCreateCustomerGateway(CreateCustomerGatewayRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCustomerGateway operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCustomerGateway.</param>
        /// 
        /// <returns>Returns a  CreateCustomerGatewayResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateCustomerGateway">REST API Reference for CreateCustomerGateway Operation</seealso>
        CreateCustomerGatewayResponse EndCreateCustomerGateway(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateDefaultSubnet


        /// <summary>
        /// Creates a default subnet with a size <code>/20</code> IPv4 CIDR block in the specified
        /// Availability Zone in your default VPC. You can have only one default subnet per Availability
        /// Zone. For more information, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/default-vpc.html#create-default-subnet">Creating
        /// a Default Subnet</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDefaultSubnet service method.</param>
        /// 
        /// <returns>The response from the CreateDefaultSubnet service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateDefaultSubnet">REST API Reference for CreateDefaultSubnet Operation</seealso>
        CreateDefaultSubnetResponse CreateDefaultSubnet(CreateDefaultSubnetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDefaultSubnet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDefaultSubnet operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDefaultSubnet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateDefaultSubnet">REST API Reference for CreateDefaultSubnet Operation</seealso>
        IAsyncResult BeginCreateDefaultSubnet(CreateDefaultSubnetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDefaultSubnet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDefaultSubnet.</param>
        /// 
        /// <returns>Returns a  CreateDefaultSubnetResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateDefaultSubnet">REST API Reference for CreateDefaultSubnet Operation</seealso>
        CreateDefaultSubnetResponse EndCreateDefaultSubnet(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateDefaultVpc


        /// <summary>
        /// Creates a default VPC with a size <code>/16</code> IPv4 CIDR block and a default subnet
        /// in each Availability Zone. For more information about the components of a default
        /// VPC, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/default-vpc.html">Default
        /// VPC and Default Subnets</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// You cannot specify the components of the default VPC yourself.
        /// 
        ///  
        /// <para>
        /// You can create a default VPC if you deleted your previous default VPC. You cannot
        /// have more than one default VPC per region. 
        /// </para>
        ///  
        /// <para>
        /// If your account supports EC2-Classic, you cannot use this action to create a default
        /// VPC in a region that supports EC2-Classic. If you want a default VPC in a region that
        /// supports EC2-Classic, see "I really want a default VPC for my existing EC2 account.
        /// Is that possible?" in the <a href="http://aws.amazon.com/vpc/faqs/#Default_VPCs">Default
        /// VPCs FAQ</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDefaultVpc service method.</param>
        /// 
        /// <returns>The response from the CreateDefaultVpc service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateDefaultVpc">REST API Reference for CreateDefaultVpc Operation</seealso>
        CreateDefaultVpcResponse CreateDefaultVpc(CreateDefaultVpcRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDefaultVpc operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDefaultVpc operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDefaultVpc
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateDefaultVpc">REST API Reference for CreateDefaultVpc Operation</seealso>
        IAsyncResult BeginCreateDefaultVpc(CreateDefaultVpcRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDefaultVpc operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDefaultVpc.</param>
        /// 
        /// <returns>Returns a  CreateDefaultVpcResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateDefaultVpc">REST API Reference for CreateDefaultVpc Operation</seealso>
        CreateDefaultVpcResponse EndCreateDefaultVpc(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateDhcpOptions


        /// <summary>
        /// Creates a set of DHCP options for your VPC. After creating the set, you must associate
        /// it with the VPC, causing all existing and new instances that you launch in the VPC
        /// to use this set of DHCP options. The following are the individual DHCP options you
        /// can specify. For more information about the options, see <a href="http://www.ietf.org/rfc/rfc2132.txt">RFC
        /// 2132</a>.
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <code>domain-name-servers</code> - The IP addresses of up to four domain name servers,
        /// or AmazonProvidedDNS. The default DHCP option set specifies AmazonProvidedDNS. If
        /// specifying more than one domain name server, specify the IP addresses in a single
        /// parameter, separated by commas. If you want your instance to receive a custom DNS
        /// hostname as specified in <code>domain-name</code>, you must set <code>domain-name-servers</code>
        /// to a custom DNS server.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>domain-name</code> - If you're using AmazonProvidedDNS in <code>us-east-1</code>,
        /// specify <code>ec2.internal</code>. If you're using AmazonProvidedDNS in another region,
        /// specify <code>region.compute.internal</code> (for example, <code>ap-northeast-1.compute.internal</code>).
        /// Otherwise, specify a domain name (for example, <code>MyCompany.com</code>). This value
        /// is used to complete unqualified DNS hostnames. <b>Important</b>: Some Linux operating
        /// systems accept multiple domain names separated by spaces. However, Windows and other
        /// Linux operating systems treat the value as a single domain, which results in unexpected
        /// behavior. If your DHCP options set is associated with a VPC that has instances with
        /// multiple operating systems, specify only one domain name.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>ntp-servers</code> - The IP addresses of up to four Network Time Protocol (NTP)
        /// servers.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>netbios-name-servers</code> - The IP addresses of up to four NetBIOS name servers.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>netbios-node-type</code> - The NetBIOS node type (1, 2, 4, or 8). We recommend
        /// that you specify 2 (broadcast and multicast are not currently supported). For more
        /// information about these node types, see <a href="http://www.ietf.org/rfc/rfc2132.txt">RFC
        /// 2132</a>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Your VPC automatically starts out with a set of DHCP options that includes only a
        /// DNS server that we provide (AmazonProvidedDNS). If you create a set of options, and
        /// if your VPC has an Internet gateway, make sure to set the <code>domain-name-servers</code>
        /// option either to <code>AmazonProvidedDNS</code> or to a domain name server of your
        /// choice. For more information about DHCP options, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_DHCP_Options.html">DHCP
        /// Options Sets</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDhcpOptions service method.</param>
        /// 
        /// <returns>The response from the CreateDhcpOptions service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateDhcpOptions">REST API Reference for CreateDhcpOptions Operation</seealso>
        CreateDhcpOptionsResponse CreateDhcpOptions(CreateDhcpOptionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDhcpOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDhcpOptions operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDhcpOptions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateDhcpOptions">REST API Reference for CreateDhcpOptions Operation</seealso>
        IAsyncResult BeginCreateDhcpOptions(CreateDhcpOptionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDhcpOptions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDhcpOptions.</param>
        /// 
        /// <returns>Returns a  CreateDhcpOptionsResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateDhcpOptions">REST API Reference for CreateDhcpOptions Operation</seealso>
        CreateDhcpOptionsResponse EndCreateDhcpOptions(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateEgressOnlyInternetGateway


        /// <summary>
        /// [IPv6 only] Creates an egress-only Internet gateway for your VPC. An egress-only Internet
        /// gateway is used to enable outbound communication over IPv6 from instances in your
        /// VPC to the Internet, and prevents hosts outside of your VPC from initiating an IPv6
        /// connection with your instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateEgressOnlyInternetGateway service method.</param>
        /// 
        /// <returns>The response from the CreateEgressOnlyInternetGateway service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateEgressOnlyInternetGateway">REST API Reference for CreateEgressOnlyInternetGateway Operation</seealso>
        CreateEgressOnlyInternetGatewayResponse CreateEgressOnlyInternetGateway(CreateEgressOnlyInternetGatewayRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateEgressOnlyInternetGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEgressOnlyInternetGateway operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateEgressOnlyInternetGateway
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateEgressOnlyInternetGateway">REST API Reference for CreateEgressOnlyInternetGateway Operation</seealso>
        IAsyncResult BeginCreateEgressOnlyInternetGateway(CreateEgressOnlyInternetGatewayRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateEgressOnlyInternetGateway operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateEgressOnlyInternetGateway.</param>
        /// 
        /// <returns>Returns a  CreateEgressOnlyInternetGatewayResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateEgressOnlyInternetGateway">REST API Reference for CreateEgressOnlyInternetGateway Operation</seealso>
        CreateEgressOnlyInternetGatewayResponse EndCreateEgressOnlyInternetGateway(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateFleet


        /// <summary>
        /// Launches an EC2 Fleet.
        /// 
        ///  
        /// <para>
        /// You can create a single EC2 Fleet that includes multiple launch specifications that
        /// vary by instance type, AMI, Availability Zone, or subnet.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-fleet.html">Launching
        /// an EC2 Fleet</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFleet service method.</param>
        /// 
        /// <returns>The response from the CreateFleet service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateFleet">REST API Reference for CreateFleet Operation</seealso>
        CreateFleetResponse CreateFleet(CreateFleetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateFleet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateFleet operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateFleet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateFleet">REST API Reference for CreateFleet Operation</seealso>
        IAsyncResult BeginCreateFleet(CreateFleetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateFleet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateFleet.</param>
        /// 
        /// <returns>Returns a  CreateFleetResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateFleet">REST API Reference for CreateFleet Operation</seealso>
        CreateFleetResponse EndCreateFleet(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateFlowLogs


        /// <summary>
        /// Creates one or more flow logs to capture IP traffic for a specific network interface,
        /// subnet, or VPC. Flow logs are delivered to a specified log group in Amazon CloudWatch
        /// Logs. If you specify a VPC or subnet in the request, a log stream is created in CloudWatch
        /// Logs for each network interface in the subnet or VPC. Log streams can include information
        /// about accepted and rejected traffic to a network interface. You can view the data
        /// in your log streams using Amazon CloudWatch Logs.
        /// 
        ///  
        /// <para>
        /// In your request, you must also specify an IAM role that has permission to publish
        /// logs to CloudWatch Logs.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/flow-logs.html">VPC
        /// Flow Logs</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFlowLogs service method.</param>
        /// 
        /// <returns>The response from the CreateFlowLogs service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateFlowLogs">REST API Reference for CreateFlowLogs Operation</seealso>
        CreateFlowLogsResponse CreateFlowLogs(CreateFlowLogsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateFlowLogs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateFlowLogs operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateFlowLogs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateFlowLogs">REST API Reference for CreateFlowLogs Operation</seealso>
        IAsyncResult BeginCreateFlowLogs(CreateFlowLogsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateFlowLogs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateFlowLogs.</param>
        /// 
        /// <returns>Returns a  CreateFlowLogsResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateFlowLogs">REST API Reference for CreateFlowLogs Operation</seealso>
        CreateFlowLogsResponse EndCreateFlowLogs(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateFpgaImage


        /// <summary>
        /// Creates an Amazon FPGA Image (AFI) from the specified design checkpoint (DCP).
        /// 
        ///  
        /// <para>
        /// The create operation is asynchronous. To verify that the AFI is ready for use, check
        /// the output logs.
        /// </para>
        ///  
        /// <para>
        /// An AFI contains the FPGA bitstream that is ready to download to an FPGA. You can securely
        /// deploy an AFI on one or more FPGA-accelerated instances. For more information, see
        /// the <a href="https://github.com/aws/aws-fpga/">AWS FPGA Hardware Development Kit</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFpgaImage service method.</param>
        /// 
        /// <returns>The response from the CreateFpgaImage service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateFpgaImage">REST API Reference for CreateFpgaImage Operation</seealso>
        CreateFpgaImageResponse CreateFpgaImage(CreateFpgaImageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateFpgaImage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateFpgaImage operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateFpgaImage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateFpgaImage">REST API Reference for CreateFpgaImage Operation</seealso>
        IAsyncResult BeginCreateFpgaImage(CreateFpgaImageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateFpgaImage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateFpgaImage.</param>
        /// 
        /// <returns>Returns a  CreateFpgaImageResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateFpgaImage">REST API Reference for CreateFpgaImage Operation</seealso>
        CreateFpgaImageResponse EndCreateFpgaImage(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateImage


        /// <summary>
        /// Creates an Amazon EBS-backed AMI from an Amazon EBS-backed instance that is either
        /// running or stopped.
        /// 
        ///  
        /// <para>
        /// If you customized your instance with instance store volumes or EBS volumes in addition
        /// to the root device volume, the new AMI contains block device mapping information for
        /// those volumes. When you launch an instance from this new AMI, the instance automatically
        /// launches with those additional volumes.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/creating-an-ami-ebs.html">Creating
        /// Amazon EBS-Backed Linux AMIs</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateImage service method.</param>
        /// 
        /// <returns>The response from the CreateImage service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateImage">REST API Reference for CreateImage Operation</seealso>
        CreateImageResponse CreateImage(CreateImageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateImage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateImage operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateImage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateImage">REST API Reference for CreateImage Operation</seealso>
        IAsyncResult BeginCreateImage(CreateImageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateImage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateImage.</param>
        /// 
        /// <returns>Returns a  CreateImageResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateImage">REST API Reference for CreateImage Operation</seealso>
        CreateImageResponse EndCreateImage(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateInstanceExportTask


        /// <summary>
        /// Exports a running or stopped instance to an S3 bucket.
        /// 
        ///  
        /// <para>
        /// For information about the supported operating systems, image formats, and known limitations
        /// for the types of instances you can export, see <a href="http://docs.aws.amazon.com/vm-import/latest/userguide/vmexport.html">Exporting
        /// an Instance as a VM Using VM Import/Export</a> in the <i>VM Import/Export User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInstanceExportTask service method.</param>
        /// 
        /// <returns>The response from the CreateInstanceExportTask service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateInstanceExportTask">REST API Reference for CreateInstanceExportTask Operation</seealso>
        CreateInstanceExportTaskResponse CreateInstanceExportTask(CreateInstanceExportTaskRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateInstanceExportTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateInstanceExportTask operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateInstanceExportTask
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateInstanceExportTask">REST API Reference for CreateInstanceExportTask Operation</seealso>
        IAsyncResult BeginCreateInstanceExportTask(CreateInstanceExportTaskRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateInstanceExportTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateInstanceExportTask.</param>
        /// 
        /// <returns>Returns a  CreateInstanceExportTaskResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateInstanceExportTask">REST API Reference for CreateInstanceExportTask Operation</seealso>
        CreateInstanceExportTaskResponse EndCreateInstanceExportTask(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateInternetGateway


        /// <summary>
        /// Creates an Internet gateway for use with a VPC. After creating the Internet gateway,
        /// you attach it to a VPC using <a>AttachInternetGateway</a>.
        /// 
        ///  
        /// <para>
        /// For more information about your VPC and Internet gateway, see the <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/">Amazon
        /// Virtual Private Cloud User Guide</a>.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the CreateInternetGateway service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateInternetGateway">REST API Reference for CreateInternetGateway Operation</seealso>
        CreateInternetGatewayResponse CreateInternetGateway();

        /// <summary>
        /// Creates an Internet gateway for use with a VPC. After creating the Internet gateway,
        /// you attach it to a VPC using <a>AttachInternetGateway</a>.
        /// 
        ///  
        /// <para>
        /// For more information about your VPC and Internet gateway, see the <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/">Amazon
        /// Virtual Private Cloud User Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInternetGateway service method.</param>
        /// 
        /// <returns>The response from the CreateInternetGateway service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateInternetGateway">REST API Reference for CreateInternetGateway Operation</seealso>
        CreateInternetGatewayResponse CreateInternetGateway(CreateInternetGatewayRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateInternetGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateInternetGateway operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateInternetGateway
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateInternetGateway">REST API Reference for CreateInternetGateway Operation</seealso>
        IAsyncResult BeginCreateInternetGateway(CreateInternetGatewayRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateInternetGateway operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateInternetGateway.</param>
        /// 
        /// <returns>Returns a  CreateInternetGatewayResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateInternetGateway">REST API Reference for CreateInternetGateway Operation</seealso>
        CreateInternetGatewayResponse EndCreateInternetGateway(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateKeyPair


        /// <summary>
        /// Creates a 2048-bit RSA key pair with the specified name. Amazon EC2 stores the public
        /// key and displays the private key for you to save to a file. The private key is returned
        /// as an unencrypted PEM encoded PKCS#1 private key. If a key with the specified name
        /// already exists, Amazon EC2 returns an error.
        /// 
        ///  
        /// <para>
        /// You can have up to five thousand key pairs per region.
        /// </para>
        ///  
        /// <para>
        /// The key pair returned to you is available only in the region in which you create it.
        /// If you prefer, you can create your own key pair using a third-party tool and upload
        /// it to any region using <a>ImportKeyPair</a>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-key-pairs.html">Key
        /// Pairs</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateKeyPair service method.</param>
        /// 
        /// <returns>The response from the CreateKeyPair service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateKeyPair">REST API Reference for CreateKeyPair Operation</seealso>
        CreateKeyPairResponse CreateKeyPair(CreateKeyPairRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateKeyPair operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateKeyPair operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateKeyPair
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateKeyPair">REST API Reference for CreateKeyPair Operation</seealso>
        IAsyncResult BeginCreateKeyPair(CreateKeyPairRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateKeyPair operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateKeyPair.</param>
        /// 
        /// <returns>Returns a  CreateKeyPairResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateKeyPair">REST API Reference for CreateKeyPair Operation</seealso>
        CreateKeyPairResponse EndCreateKeyPair(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateLaunchTemplate


        /// <summary>
        /// Creates a launch template. A launch template contains the parameters to launch an
        /// instance. When you launch an instance using <a>RunInstances</a>, you can specify a
        /// launch template instead of providing the launch parameters in the request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLaunchTemplate service method.</param>
        /// 
        /// <returns>The response from the CreateLaunchTemplate service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateLaunchTemplate">REST API Reference for CreateLaunchTemplate Operation</seealso>
        CreateLaunchTemplateResponse CreateLaunchTemplate(CreateLaunchTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLaunchTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLaunchTemplate operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateLaunchTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateLaunchTemplate">REST API Reference for CreateLaunchTemplate Operation</seealso>
        IAsyncResult BeginCreateLaunchTemplate(CreateLaunchTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateLaunchTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLaunchTemplate.</param>
        /// 
        /// <returns>Returns a  CreateLaunchTemplateResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateLaunchTemplate">REST API Reference for CreateLaunchTemplate Operation</seealso>
        CreateLaunchTemplateResponse EndCreateLaunchTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateLaunchTemplateVersion


        /// <summary>
        /// Creates a new version for a launch template. You can specify an existing version of
        /// launch template from which to base the new version.
        /// 
        ///  
        /// <para>
        /// Launch template versions are numbered in the order in which they are created. You
        /// cannot specify, change, or replace the numbering of launch template versions.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLaunchTemplateVersion service method.</param>
        /// 
        /// <returns>The response from the CreateLaunchTemplateVersion service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateLaunchTemplateVersion">REST API Reference for CreateLaunchTemplateVersion Operation</seealso>
        CreateLaunchTemplateVersionResponse CreateLaunchTemplateVersion(CreateLaunchTemplateVersionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLaunchTemplateVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLaunchTemplateVersion operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateLaunchTemplateVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateLaunchTemplateVersion">REST API Reference for CreateLaunchTemplateVersion Operation</seealso>
        IAsyncResult BeginCreateLaunchTemplateVersion(CreateLaunchTemplateVersionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateLaunchTemplateVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLaunchTemplateVersion.</param>
        /// 
        /// <returns>Returns a  CreateLaunchTemplateVersionResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateLaunchTemplateVersion">REST API Reference for CreateLaunchTemplateVersion Operation</seealso>
        CreateLaunchTemplateVersionResponse EndCreateLaunchTemplateVersion(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateNatGateway


        /// <summary>
        /// Creates a NAT gateway in the specified public subnet. This action creates a network
        /// interface in the specified subnet with a private IP address from the IP address range
        /// of the subnet. Internet-bound traffic from a private subnet can be routed to the NAT
        /// gateway, therefore enabling instances in the private subnet to connect to the internet.
        /// For more information, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/vpc-nat-gateway.html">NAT
        /// Gateways</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNatGateway service method.</param>
        /// 
        /// <returns>The response from the CreateNatGateway service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateNatGateway">REST API Reference for CreateNatGateway Operation</seealso>
        CreateNatGatewayResponse CreateNatGateway(CreateNatGatewayRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateNatGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateNatGateway operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateNatGateway
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateNatGateway">REST API Reference for CreateNatGateway Operation</seealso>
        IAsyncResult BeginCreateNatGateway(CreateNatGatewayRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateNatGateway operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateNatGateway.</param>
        /// 
        /// <returns>Returns a  CreateNatGatewayResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateNatGateway">REST API Reference for CreateNatGateway Operation</seealso>
        CreateNatGatewayResponse EndCreateNatGateway(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateNetworkAcl


        /// <summary>
        /// Creates a network ACL in a VPC. Network ACLs provide an optional layer of security
        /// (in addition to security groups) for the instances in your VPC.
        /// 
        ///  
        /// <para>
        /// For more information about network ACLs, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_ACLs.html">Network
        /// ACLs</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNetworkAcl service method.</param>
        /// 
        /// <returns>The response from the CreateNetworkAcl service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateNetworkAcl">REST API Reference for CreateNetworkAcl Operation</seealso>
        CreateNetworkAclResponse CreateNetworkAcl(CreateNetworkAclRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateNetworkAcl operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateNetworkAcl operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateNetworkAcl
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateNetworkAcl">REST API Reference for CreateNetworkAcl Operation</seealso>
        IAsyncResult BeginCreateNetworkAcl(CreateNetworkAclRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateNetworkAcl operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateNetworkAcl.</param>
        /// 
        /// <returns>Returns a  CreateNetworkAclResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateNetworkAcl">REST API Reference for CreateNetworkAcl Operation</seealso>
        CreateNetworkAclResponse EndCreateNetworkAcl(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateNetworkAclEntry


        /// <summary>
        /// Creates an entry (a rule) in a network ACL with the specified rule number. Each network
        /// ACL has a set of numbered ingress rules and a separate set of numbered egress rules.
        /// When determining whether a packet should be allowed in or out of a subnet associated
        /// with the ACL, we process the entries in the ACL according to the rule numbers, in
        /// ascending order. Each network ACL has a set of ingress rules and a separate set of
        /// egress rules.
        /// 
        ///  
        /// <para>
        /// We recommend that you leave room between the rule numbers (for example, 100, 110,
        /// 120, ...), and not number them one right after the other (for example, 101, 102, 103,
        /// ...). This makes it easier to add a rule between existing ones without having to renumber
        /// the rules.
        /// </para>
        ///  
        /// <para>
        /// After you add an entry, you can't modify it; you must either replace it, or create
        /// an entry and delete the old one.
        /// </para>
        ///  
        /// <para>
        /// For more information about network ACLs, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_ACLs.html">Network
        /// ACLs</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNetworkAclEntry service method.</param>
        /// 
        /// <returns>The response from the CreateNetworkAclEntry service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateNetworkAclEntry">REST API Reference for CreateNetworkAclEntry Operation</seealso>
        CreateNetworkAclEntryResponse CreateNetworkAclEntry(CreateNetworkAclEntryRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateNetworkAclEntry operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateNetworkAclEntry operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateNetworkAclEntry
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateNetworkAclEntry">REST API Reference for CreateNetworkAclEntry Operation</seealso>
        IAsyncResult BeginCreateNetworkAclEntry(CreateNetworkAclEntryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateNetworkAclEntry operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateNetworkAclEntry.</param>
        /// 
        /// <returns>Returns a  CreateNetworkAclEntryResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateNetworkAclEntry">REST API Reference for CreateNetworkAclEntry Operation</seealso>
        CreateNetworkAclEntryResponse EndCreateNetworkAclEntry(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateNetworkInterface


        /// <summary>
        /// Creates a network interface in the specified subnet.
        /// 
        ///  
        /// <para>
        /// For more information about network interfaces, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-eni.html">Elastic
        /// Network Interfaces</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNetworkInterface service method.</param>
        /// 
        /// <returns>The response from the CreateNetworkInterface service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateNetworkInterface">REST API Reference for CreateNetworkInterface Operation</seealso>
        CreateNetworkInterfaceResponse CreateNetworkInterface(CreateNetworkInterfaceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateNetworkInterface operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateNetworkInterface operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateNetworkInterface
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateNetworkInterface">REST API Reference for CreateNetworkInterface Operation</seealso>
        IAsyncResult BeginCreateNetworkInterface(CreateNetworkInterfaceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateNetworkInterface operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateNetworkInterface.</param>
        /// 
        /// <returns>Returns a  CreateNetworkInterfaceResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateNetworkInterface">REST API Reference for CreateNetworkInterface Operation</seealso>
        CreateNetworkInterfaceResponse EndCreateNetworkInterface(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateNetworkInterfacePermission


        /// <summary>
        /// Grants an AWS-authorized account permission to attach the specified network interface
        /// to an instance in their account.
        /// 
        ///  
        /// <para>
        /// You can grant permission to a single AWS account only, and only one account at a time.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNetworkInterfacePermission service method.</param>
        /// 
        /// <returns>The response from the CreateNetworkInterfacePermission service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateNetworkInterfacePermission">REST API Reference for CreateNetworkInterfacePermission Operation</seealso>
        CreateNetworkInterfacePermissionResponse CreateNetworkInterfacePermission(CreateNetworkInterfacePermissionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateNetworkInterfacePermission operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateNetworkInterfacePermission operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateNetworkInterfacePermission
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateNetworkInterfacePermission">REST API Reference for CreateNetworkInterfacePermission Operation</seealso>
        IAsyncResult BeginCreateNetworkInterfacePermission(CreateNetworkInterfacePermissionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateNetworkInterfacePermission operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateNetworkInterfacePermission.</param>
        /// 
        /// <returns>Returns a  CreateNetworkInterfacePermissionResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateNetworkInterfacePermission">REST API Reference for CreateNetworkInterfacePermission Operation</seealso>
        CreateNetworkInterfacePermissionResponse EndCreateNetworkInterfacePermission(IAsyncResult asyncResult);

        #endregion
        
        #region  CreatePlacementGroup


        /// <summary>
        /// Creates a placement group in which to launch instances. The strategy of the placement
        /// group determines how the instances are organized within the group. 
        /// 
        ///  
        /// <para>
        /// A <code>cluster</code> placement group is a logical grouping of instances within a
        /// single Availability Zone that benefit from low network latency, high network throughput.
        /// A <code>spread</code> placement group places instances on distinct hardware.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/placement-groups.html">Placement
        /// Groups</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePlacementGroup service method.</param>
        /// 
        /// <returns>The response from the CreatePlacementGroup service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreatePlacementGroup">REST API Reference for CreatePlacementGroup Operation</seealso>
        CreatePlacementGroupResponse CreatePlacementGroup(CreatePlacementGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePlacementGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePlacementGroup operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreatePlacementGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreatePlacementGroup">REST API Reference for CreatePlacementGroup Operation</seealso>
        IAsyncResult BeginCreatePlacementGroup(CreatePlacementGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePlacementGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePlacementGroup.</param>
        /// 
        /// <returns>Returns a  CreatePlacementGroupResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreatePlacementGroup">REST API Reference for CreatePlacementGroup Operation</seealso>
        CreatePlacementGroupResponse EndCreatePlacementGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateReservedInstancesListing


        /// <summary>
        /// Creates a listing for Amazon EC2 Standard Reserved Instances to be sold in the Reserved
        /// Instance Marketplace. You can submit one Standard Reserved Instance listing at a time.
        /// To get a list of your Standard Reserved Instances, you can use the <a>DescribeReservedInstances</a>
        /// operation.
        /// 
        ///  <note> 
        /// <para>
        /// Only Standard Reserved Instances with a capacity reservation can be sold in the Reserved
        /// Instance Marketplace. Convertible Reserved Instances and Standard Reserved Instances
        /// with a regional benefit cannot be sold.
        /// </para>
        ///  </note> 
        /// <para>
        /// The Reserved Instance Marketplace matches sellers who want to resell Standard Reserved
        /// Instance capacity that they no longer need with buyers who want to purchase additional
        /// capacity. Reserved Instances bought and sold through the Reserved Instance Marketplace
        /// work like any other Reserved Instances.
        /// </para>
        ///  
        /// <para>
        /// To sell your Standard Reserved Instances, you must first register as a seller in the
        /// Reserved Instance Marketplace. After completing the registration process, you can
        /// create a Reserved Instance Marketplace listing of some or all of your Standard Reserved
        /// Instances, and specify the upfront price to receive for them. Your Standard Reserved
        /// Instance listings then become available for purchase. To view the details of your
        /// Standard Reserved Instance listing, you can use the <a>DescribeReservedInstancesListings</a>
        /// operation.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ri-market-general.html">Reserved
        /// Instance Marketplace</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateReservedInstancesListing service method.</param>
        /// 
        /// <returns>The response from the CreateReservedInstancesListing service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateReservedInstancesListing">REST API Reference for CreateReservedInstancesListing Operation</seealso>
        CreateReservedInstancesListingResponse CreateReservedInstancesListing(CreateReservedInstancesListingRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateReservedInstancesListing operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateReservedInstancesListing operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateReservedInstancesListing
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateReservedInstancesListing">REST API Reference for CreateReservedInstancesListing Operation</seealso>
        IAsyncResult BeginCreateReservedInstancesListing(CreateReservedInstancesListingRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateReservedInstancesListing operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateReservedInstancesListing.</param>
        /// 
        /// <returns>Returns a  CreateReservedInstancesListingResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateReservedInstancesListing">REST API Reference for CreateReservedInstancesListing Operation</seealso>
        CreateReservedInstancesListingResponse EndCreateReservedInstancesListing(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateRoute


        /// <summary>
        /// Creates a route in a route table within a VPC.
        /// 
        ///  
        /// <para>
        /// You must specify one of the following targets: Internet gateway or virtual private
        /// gateway, NAT instance, NAT gateway, VPC peering connection, network interface, or
        /// egress-only Internet gateway.
        /// </para>
        ///  
        /// <para>
        /// When determining how to route traffic, we use the route with the most specific match.
        /// For example, traffic is destined for the IPv4 address <code>192.0.2.3</code>, and
        /// the route table includes the following two IPv4 routes:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <code>192.0.2.0/24</code> (goes to some target A)
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>192.0.2.0/28</code> (goes to some target B)
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Both routes apply to the traffic destined for <code>192.0.2.3</code>. However, the
        /// second route in the list covers a smaller number of IP addresses and is therefore
        /// more specific, so we use that route to determine where to target the traffic.
        /// </para>
        ///  
        /// <para>
        /// For more information about route tables, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Route_Tables.html">Route
        /// Tables</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRoute service method.</param>
        /// 
        /// <returns>The response from the CreateRoute service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateRoute">REST API Reference for CreateRoute Operation</seealso>
        CreateRouteResponse CreateRoute(CreateRouteRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRoute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRoute operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateRoute
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateRoute">REST API Reference for CreateRoute Operation</seealso>
        IAsyncResult BeginCreateRoute(CreateRouteRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRoute operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRoute.</param>
        /// 
        /// <returns>Returns a  CreateRouteResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateRoute">REST API Reference for CreateRoute Operation</seealso>
        CreateRouteResponse EndCreateRoute(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateRouteTable


        /// <summary>
        /// Creates a route table for the specified VPC. After you create a route table, you can
        /// add routes and associate the table with a subnet.
        /// 
        ///  
        /// <para>
        /// For more information about route tables, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Route_Tables.html">Route
        /// Tables</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateRouteTable service method.</param>
        /// 
        /// <returns>The response from the CreateRouteTable service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateRouteTable">REST API Reference for CreateRouteTable Operation</seealso>
        CreateRouteTableResponse CreateRouteTable(CreateRouteTableRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRouteTable operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRouteTable operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateRouteTable
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateRouteTable">REST API Reference for CreateRouteTable Operation</seealso>
        IAsyncResult BeginCreateRouteTable(CreateRouteTableRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRouteTable operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRouteTable.</param>
        /// 
        /// <returns>Returns a  CreateRouteTableResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateRouteTable">REST API Reference for CreateRouteTable Operation</seealso>
        CreateRouteTableResponse EndCreateRouteTable(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateSecurityGroup


        /// <summary>
        /// Creates a security group.
        /// 
        ///  
        /// <para>
        /// A security group is for use with instances either in the EC2-Classic platform or in
        /// a specific VPC. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-network-security.html">Amazon
        /// EC2 Security Groups</a> in the <i>Amazon Elastic Compute Cloud User Guide</i> and
        /// <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_SecurityGroups.html">Security
        /// Groups for Your VPC</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        ///  <important> 
        /// <para>
        /// EC2-Classic: You can have up to 500 security groups.
        /// </para>
        ///  
        /// <para>
        /// EC2-VPC: You can create up to 500 security groups per VPC.
        /// </para>
        ///  </important> 
        /// <para>
        /// When you create a security group, you specify a friendly name of your choice. You
        /// can have a security group for use in EC2-Classic with the same name as a security
        /// group for use in a VPC. However, you can't have two security groups for use in EC2-Classic
        /// with the same name or two security groups for use in a VPC with the same name.
        /// </para>
        ///  
        /// <para>
        /// You have a default security group for use in EC2-Classic and a default security group
        /// for use in your VPC. If you don't specify a security group when you launch an instance,
        /// the instance is launched into the appropriate default security group. A default security
        /// group includes a default rule that grants instances unrestricted network access to
        /// each other.
        /// </para>
        ///  
        /// <para>
        /// You can add or remove rules from your security groups using <a>AuthorizeSecurityGroupIngress</a>,
        /// <a>AuthorizeSecurityGroupEgress</a>, <a>RevokeSecurityGroupIngress</a>, and <a>RevokeSecurityGroupEgress</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSecurityGroup service method.</param>
        /// 
        /// <returns>The response from the CreateSecurityGroup service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateSecurityGroup">REST API Reference for CreateSecurityGroup Operation</seealso>
        CreateSecurityGroupResponse CreateSecurityGroup(CreateSecurityGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSecurityGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSecurityGroup operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSecurityGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateSecurityGroup">REST API Reference for CreateSecurityGroup Operation</seealso>
        IAsyncResult BeginCreateSecurityGroup(CreateSecurityGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSecurityGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSecurityGroup.</param>
        /// 
        /// <returns>Returns a  CreateSecurityGroupResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateSecurityGroup">REST API Reference for CreateSecurityGroup Operation</seealso>
        CreateSecurityGroupResponse EndCreateSecurityGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateSnapshot


        /// <summary>
        /// Creates a snapshot of an EBS volume and stores it in Amazon S3. You can use snapshots
        /// for backups, to make copies of EBS volumes, and to save data before shutting down
        /// an instance.
        /// 
        ///  
        /// <para>
        /// When a snapshot is created, any AWS Marketplace product codes that are associated
        /// with the source volume are propagated to the snapshot.
        /// </para>
        ///  
        /// <para>
        /// You can take a snapshot of an attached volume that is in use. However, snapshots only
        /// capture data that has been written to your EBS volume at the time the snapshot command
        /// is issued; this may exclude any data that has been cached by any applications or the
        /// operating system. If you can pause any file systems on the volume long enough to take
        /// a snapshot, your snapshot should be complete. However, if you cannot pause all file
        /// writes to the volume, you should unmount the volume from within the instance, issue
        /// the snapshot command, and then remount the volume to ensure a consistent and complete
        /// snapshot. You may remount and use your volume while the snapshot status is <code>pending</code>.
        /// </para>
        ///  
        /// <para>
        /// To create a snapshot for EBS volumes that serve as root devices, you should stop the
        /// instance before taking the snapshot.
        /// </para>
        ///  
        /// <para>
        /// Snapshots that are taken from encrypted volumes are automatically encrypted. Volumes
        /// that are created from encrypted snapshots are also automatically encrypted. Your encrypted
        /// volumes and any associated snapshots always remain protected.
        /// </para>
        ///  
        /// <para>
        /// You can tag your snapshots during creation. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_Tags.html">Tagging
        /// Your Amazon EC2 Resources</a>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/AmazonEBS.html">Amazon
        /// Elastic Block Store</a> and <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSEncryption.html">Amazon
        /// EBS Encryption</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSnapshot service method.</param>
        /// 
        /// <returns>The response from the CreateSnapshot service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateSnapshot">REST API Reference for CreateSnapshot Operation</seealso>
        CreateSnapshotResponse CreateSnapshot(CreateSnapshotRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSnapshot operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSnapshot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateSnapshot">REST API Reference for CreateSnapshot Operation</seealso>
        IAsyncResult BeginCreateSnapshot(CreateSnapshotRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSnapshot.</param>
        /// 
        /// <returns>Returns a  CreateSnapshotResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateSnapshot">REST API Reference for CreateSnapshot Operation</seealso>
        CreateSnapshotResponse EndCreateSnapshot(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateSpotDatafeedSubscription


        /// <summary>
        /// Creates a data feed for Spot Instances, enabling you to view Spot Instance usage logs.
        /// You can create one data feed per AWS account. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/spot-data-feeds.html">Spot
        /// Instance Data Feed</a> in the <i>Amazon EC2 User Guide for Linux Instances</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSpotDatafeedSubscription service method.</param>
        /// 
        /// <returns>The response from the CreateSpotDatafeedSubscription service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateSpotDatafeedSubscription">REST API Reference for CreateSpotDatafeedSubscription Operation</seealso>
        CreateSpotDatafeedSubscriptionResponse CreateSpotDatafeedSubscription(CreateSpotDatafeedSubscriptionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSpotDatafeedSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSpotDatafeedSubscription operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSpotDatafeedSubscription
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateSpotDatafeedSubscription">REST API Reference for CreateSpotDatafeedSubscription Operation</seealso>
        IAsyncResult BeginCreateSpotDatafeedSubscription(CreateSpotDatafeedSubscriptionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSpotDatafeedSubscription operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSpotDatafeedSubscription.</param>
        /// 
        /// <returns>Returns a  CreateSpotDatafeedSubscriptionResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateSpotDatafeedSubscription">REST API Reference for CreateSpotDatafeedSubscription Operation</seealso>
        CreateSpotDatafeedSubscriptionResponse EndCreateSpotDatafeedSubscription(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateSubnet


        /// <summary>
        /// Creates a subnet in an existing VPC.
        /// 
        ///  
        /// <para>
        /// When you create each subnet, you provide the VPC ID and the IPv4 CIDR block you want
        /// for the subnet. After you create a subnet, you can't change its CIDR block. The size
        /// of the subnet's IPv4 CIDR block can be the same as a VPC's IPv4 CIDR block, or a subset
        /// of a VPC's IPv4 CIDR block. If you create more than one subnet in a VPC, the subnets'
        /// CIDR blocks must not overlap. The smallest IPv4 subnet (and VPC) you can create uses
        /// a /28 netmask (16 IPv4 addresses), and the largest uses a /16 netmask (65,536 IPv4
        /// addresses).
        /// </para>
        ///  
        /// <para>
        /// If you've associated an IPv6 CIDR block with your VPC, you can create a subnet with
        /// an IPv6 CIDR block that uses a /64 prefix length. 
        /// </para>
        ///  <important> 
        /// <para>
        /// AWS reserves both the first four and the last IPv4 address in each subnet's CIDR block.
        /// They're not available for use.
        /// </para>
        ///  </important> 
        /// <para>
        /// If you add more than one subnet to a VPC, they're set up in a star topology with a
        /// logical router in the middle.
        /// </para>
        ///  
        /// <para>
        /// If you launch an instance in a VPC using an Amazon EBS-backed AMI, the IP address
        /// doesn't change if you stop and restart the instance (unlike a similar instance launched
        /// outside a VPC, which gets a new IP address when restarted). It's therefore possible
        /// to have a subnet with no running instances (they're all stopped), but no remaining
        /// IP addresses available.
        /// </para>
        ///  
        /// <para>
        /// For more information about subnets, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Subnets.html">Your
        /// VPC and Subnets</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSubnet service method.</param>
        /// 
        /// <returns>The response from the CreateSubnet service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateSubnet">REST API Reference for CreateSubnet Operation</seealso>
        CreateSubnetResponse CreateSubnet(CreateSubnetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSubnet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSubnet operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSubnet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateSubnet">REST API Reference for CreateSubnet Operation</seealso>
        IAsyncResult BeginCreateSubnet(CreateSubnetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSubnet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSubnet.</param>
        /// 
        /// <returns>Returns a  CreateSubnetResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateSubnet">REST API Reference for CreateSubnet Operation</seealso>
        CreateSubnetResponse EndCreateSubnet(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateTags


        /// <summary>
        /// Adds or overwrites one or more tags for the specified Amazon EC2 resource or resources.
        /// Each resource can have a maximum of 50 tags. Each tag consists of a key and optional
        /// value. Tag keys must be unique per resource.
        /// 
        ///  
        /// <para>
        /// For more information about tags, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_Tags.html">Tagging
        /// Your Resources</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>. For more
        /// information about creating IAM policies that control users' access to resources based
        /// on tags, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-supported-iam-actions-resources.html">Supported
        /// Resource-Level Permissions for Amazon EC2 API Actions</a> in the <i>Amazon Elastic
        /// Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTags service method.</param>
        /// 
        /// <returns>The response from the CreateTags service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateTags">REST API Reference for CreateTags Operation</seealso>
        CreateTagsResponse CreateTags(CreateTagsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTags operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTags
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateTags">REST API Reference for CreateTags Operation</seealso>
        IAsyncResult BeginCreateTags(CreateTagsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTags.</param>
        /// 
        /// <returns>Returns a  CreateTagsResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateTags">REST API Reference for CreateTags Operation</seealso>
        CreateTagsResponse EndCreateTags(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateVolume


        /// <summary>
        /// Creates an EBS volume that can be attached to an instance in the same Availability
        /// Zone. The volume is created in the regional endpoint that you send the HTTP request
        /// to. For more information see <a href="http://docs.aws.amazon.com/general/latest/gr/rande.html">Regions
        /// and Endpoints</a>.
        /// 
        ///  
        /// <para>
        /// You can create a new empty volume or restore a volume from an EBS snapshot. Any AWS
        /// Marketplace product codes from the snapshot are propagated to the volume.
        /// </para>
        ///  
        /// <para>
        /// You can create encrypted volumes with the <code>Encrypted</code> parameter. Encrypted
        /// volumes may only be attached to instances that support Amazon EBS encryption. Volumes
        /// that are created from encrypted snapshots are also automatically encrypted. For more
        /// information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSEncryption.html">Amazon
        /// EBS Encryption</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can tag your volumes during creation. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_Tags.html">Tagging
        /// Your Amazon EC2 Resources</a>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-creating-volume.html">Creating
        /// an Amazon EBS Volume</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVolume service method.</param>
        /// 
        /// <returns>The response from the CreateVolume service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateVolume">REST API Reference for CreateVolume Operation</seealso>
        CreateVolumeResponse CreateVolume(CreateVolumeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateVolume operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVolume operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateVolume
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateVolume">REST API Reference for CreateVolume Operation</seealso>
        IAsyncResult BeginCreateVolume(CreateVolumeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateVolume operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateVolume.</param>
        /// 
        /// <returns>Returns a  CreateVolumeResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateVolume">REST API Reference for CreateVolume Operation</seealso>
        CreateVolumeResponse EndCreateVolume(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateVpc


        /// <summary>
        /// Creates a VPC with the specified IPv4 CIDR block. The smallest VPC you can create
        /// uses a /28 netmask (16 IPv4 addresses), and the largest uses a /16 netmask (65,536
        /// IPv4 addresses). To help you decide how big to make your VPC, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Subnets.html">Your
        /// VPC and Subnets</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// 
        ///  
        /// <para>
        /// You can optionally request an Amazon-provided IPv6 CIDR block for the VPC. The IPv6
        /// CIDR block uses a /56 prefix length, and is allocated from Amazon's pool of IPv6 addresses.
        /// You cannot choose the IPv6 range for your VPC.
        /// </para>
        ///  
        /// <para>
        /// By default, each instance you launch in the VPC has the default DHCP options, which
        /// includes only a default DNS server that we provide (AmazonProvidedDNS). For more information
        /// about DHCP options, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_DHCP_Options.html">DHCP
        /// Options Sets</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can specify the instance tenancy value for the VPC when you create it. You can't
        /// change this value for the VPC after you create it. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/dedicated-instance.html">Dedicated
        /// Instances</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVpc service method.</param>
        /// 
        /// <returns>The response from the CreateVpc service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateVpc">REST API Reference for CreateVpc Operation</seealso>
        CreateVpcResponse CreateVpc(CreateVpcRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateVpc operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVpc operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateVpc
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateVpc">REST API Reference for CreateVpc Operation</seealso>
        IAsyncResult BeginCreateVpc(CreateVpcRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateVpc operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateVpc.</param>
        /// 
        /// <returns>Returns a  CreateVpcResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateVpc">REST API Reference for CreateVpc Operation</seealso>
        CreateVpcResponse EndCreateVpc(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateVpcEndpoint


        /// <summary>
        /// Creates a VPC endpoint for a specified service. An endpoint enables you to create
        /// a private connection between your VPC and the service. The service may be provided
        /// by AWS, an AWS Marketplace partner, or another AWS account. For more information,
        /// see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/vpc-endpoints.html">VPC
        /// Endpoints</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// 
        ///  
        /// <para>
        /// A <code>gateway</code> endpoint serves as a target for a route in your route table
        /// for traffic destined for the AWS service. You can specify an endpoint policy to attach
        /// to the endpoint that will control access to the service from your VPC. You can also
        /// specify the VPC route tables that use the endpoint.
        /// </para>
        ///  
        /// <para>
        /// An <code>interface</code> endpoint is a network interface in your subnet that serves
        /// as an endpoint for communicating with the specified service. You can specify the subnets
        /// in which to create an endpoint, and the security groups to associate with the endpoint
        /// network interface.
        /// </para>
        ///  
        /// <para>
        /// Use <a>DescribeVpcEndpointServices</a> to get a list of supported services.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVpcEndpoint service method.</param>
        /// 
        /// <returns>The response from the CreateVpcEndpoint service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateVpcEndpoint">REST API Reference for CreateVpcEndpoint Operation</seealso>
        CreateVpcEndpointResponse CreateVpcEndpoint(CreateVpcEndpointRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateVpcEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVpcEndpoint operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateVpcEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateVpcEndpoint">REST API Reference for CreateVpcEndpoint Operation</seealso>
        IAsyncResult BeginCreateVpcEndpoint(CreateVpcEndpointRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateVpcEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateVpcEndpoint.</param>
        /// 
        /// <returns>Returns a  CreateVpcEndpointResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateVpcEndpoint">REST API Reference for CreateVpcEndpoint Operation</seealso>
        CreateVpcEndpointResponse EndCreateVpcEndpoint(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateVpcEndpointConnectionNotification


        /// <summary>
        /// Creates a connection notification for a specified VPC endpoint or VPC endpoint service.
        /// A connection notification notifies you of specific endpoint events. You must create
        /// an SNS topic to receive notifications. For more information, see <a href="http://docs.aws.amazon.com/sns/latest/dg/CreateTopic.html">Create
        /// a Topic</a> in the <i>Amazon Simple Notification Service Developer Guide</i>.
        /// 
        ///  
        /// <para>
        /// You can create a connection notification for interface endpoints only.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVpcEndpointConnectionNotification service method.</param>
        /// 
        /// <returns>The response from the CreateVpcEndpointConnectionNotification service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateVpcEndpointConnectionNotification">REST API Reference for CreateVpcEndpointConnectionNotification Operation</seealso>
        CreateVpcEndpointConnectionNotificationResponse CreateVpcEndpointConnectionNotification(CreateVpcEndpointConnectionNotificationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateVpcEndpointConnectionNotification operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVpcEndpointConnectionNotification operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateVpcEndpointConnectionNotification
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateVpcEndpointConnectionNotification">REST API Reference for CreateVpcEndpointConnectionNotification Operation</seealso>
        IAsyncResult BeginCreateVpcEndpointConnectionNotification(CreateVpcEndpointConnectionNotificationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateVpcEndpointConnectionNotification operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateVpcEndpointConnectionNotification.</param>
        /// 
        /// <returns>Returns a  CreateVpcEndpointConnectionNotificationResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateVpcEndpointConnectionNotification">REST API Reference for CreateVpcEndpointConnectionNotification Operation</seealso>
        CreateVpcEndpointConnectionNotificationResponse EndCreateVpcEndpointConnectionNotification(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateVpcEndpointServiceConfiguration


        /// <summary>
        /// Creates a VPC endpoint service configuration to which service consumers (AWS accounts,
        /// IAM users, and IAM roles) can connect. Service consumers can create an interface VPC
        /// endpoint to connect to your service.
        /// 
        ///  
        /// <para>
        /// To create an endpoint service configuration, you must first create a Network Load
        /// Balancer for your service. For more information, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/endpoint-service.html">VPC
        /// Endpoint Services</a> in the <i>Amazon Virtual Private Cloud User Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVpcEndpointServiceConfiguration service method.</param>
        /// 
        /// <returns>The response from the CreateVpcEndpointServiceConfiguration service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateVpcEndpointServiceConfiguration">REST API Reference for CreateVpcEndpointServiceConfiguration Operation</seealso>
        CreateVpcEndpointServiceConfigurationResponse CreateVpcEndpointServiceConfiguration(CreateVpcEndpointServiceConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateVpcEndpointServiceConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVpcEndpointServiceConfiguration operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateVpcEndpointServiceConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateVpcEndpointServiceConfiguration">REST API Reference for CreateVpcEndpointServiceConfiguration Operation</seealso>
        IAsyncResult BeginCreateVpcEndpointServiceConfiguration(CreateVpcEndpointServiceConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateVpcEndpointServiceConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateVpcEndpointServiceConfiguration.</param>
        /// 
        /// <returns>Returns a  CreateVpcEndpointServiceConfigurationResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateVpcEndpointServiceConfiguration">REST API Reference for CreateVpcEndpointServiceConfiguration Operation</seealso>
        CreateVpcEndpointServiceConfigurationResponse EndCreateVpcEndpointServiceConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateVpcPeeringConnection


        /// <summary>
        /// Requests a VPC peering connection between two VPCs: a requester VPC that you own and
        /// an accepter VPC with which to create the connection. The accepter VPC can belong to
        /// another AWS account and can be in a different region to the requester VPC. The requester
        /// VPC and accepter VPC cannot have overlapping CIDR blocks.
        /// 
        ///  <note> 
        /// <para>
        /// Limitations and rules apply to a VPC peering connection. For more information, see
        /// the <a href="http://docs.aws.amazon.com/AmazonVPC/latest/PeeringGuide/vpc-peering-basics.html#vpc-peering-limitations">limitations</a>
        /// section in the <i>VPC Peering Guide</i>.
        /// </para>
        ///  </note> 
        /// <para>
        /// The owner of the accepter VPC must accept the peering request to activate the peering
        /// connection. The VPC peering connection request expires after 7 days, after which it
        /// cannot be accepted or rejected.
        /// </para>
        ///  
        /// <para>
        /// If you create a VPC peering connection request between VPCs with overlapping CIDR
        /// blocks, the VPC peering connection has a status of <code>failed</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVpcPeeringConnection service method.</param>
        /// 
        /// <returns>The response from the CreateVpcPeeringConnection service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateVpcPeeringConnection">REST API Reference for CreateVpcPeeringConnection Operation</seealso>
        CreateVpcPeeringConnectionResponse CreateVpcPeeringConnection(CreateVpcPeeringConnectionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateVpcPeeringConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVpcPeeringConnection operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateVpcPeeringConnection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateVpcPeeringConnection">REST API Reference for CreateVpcPeeringConnection Operation</seealso>
        IAsyncResult BeginCreateVpcPeeringConnection(CreateVpcPeeringConnectionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateVpcPeeringConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateVpcPeeringConnection.</param>
        /// 
        /// <returns>Returns a  CreateVpcPeeringConnectionResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateVpcPeeringConnection">REST API Reference for CreateVpcPeeringConnection Operation</seealso>
        CreateVpcPeeringConnectionResponse EndCreateVpcPeeringConnection(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateVpnConnection


        /// <summary>
        /// Creates a VPN connection between an existing virtual private gateway and a VPN customer
        /// gateway. The only supported connection type is <code>ipsec.1</code>.
        /// 
        ///  
        /// <para>
        /// The response includes information that you need to give to your network administrator
        /// to configure your customer gateway.
        /// </para>
        ///  <important> 
        /// <para>
        /// We strongly recommend that you use HTTPS when calling this operation because the response
        /// contains sensitive cryptographic information for configuring your customer gateway.
        /// </para>
        ///  </important> 
        /// <para>
        /// If you decide to shut down your VPN connection for any reason and later create a new
        /// VPN connection, you must reconfigure your customer gateway with the new information
        /// returned from this call.
        /// </para>
        ///  
        /// <para>
        /// This is an idempotent operation. If you perform the operation more than once, Amazon
        /// EC2 doesn't return an error.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_VPN.html">AWS
        /// Managed VPN Connections</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVpnConnection service method.</param>
        /// 
        /// <returns>The response from the CreateVpnConnection service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateVpnConnection">REST API Reference for CreateVpnConnection Operation</seealso>
        CreateVpnConnectionResponse CreateVpnConnection(CreateVpnConnectionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateVpnConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVpnConnection operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateVpnConnection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateVpnConnection">REST API Reference for CreateVpnConnection Operation</seealso>
        IAsyncResult BeginCreateVpnConnection(CreateVpnConnectionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateVpnConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateVpnConnection.</param>
        /// 
        /// <returns>Returns a  CreateVpnConnectionResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateVpnConnection">REST API Reference for CreateVpnConnection Operation</seealso>
        CreateVpnConnectionResponse EndCreateVpnConnection(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateVpnConnectionRoute


        /// <summary>
        /// Creates a static route associated with a VPN connection between an existing virtual
        /// private gateway and a VPN customer gateway. The static route allows traffic to be
        /// routed from the virtual private gateway to the VPN customer gateway.
        /// 
        ///  
        /// <para>
        /// For more information about VPN connections, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_VPN.html">AWS
        /// Managed VPN Connections</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVpnConnectionRoute service method.</param>
        /// 
        /// <returns>The response from the CreateVpnConnectionRoute service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateVpnConnectionRoute">REST API Reference for CreateVpnConnectionRoute Operation</seealso>
        CreateVpnConnectionRouteResponse CreateVpnConnectionRoute(CreateVpnConnectionRouteRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateVpnConnectionRoute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVpnConnectionRoute operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateVpnConnectionRoute
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateVpnConnectionRoute">REST API Reference for CreateVpnConnectionRoute Operation</seealso>
        IAsyncResult BeginCreateVpnConnectionRoute(CreateVpnConnectionRouteRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateVpnConnectionRoute operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateVpnConnectionRoute.</param>
        /// 
        /// <returns>Returns a  CreateVpnConnectionRouteResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateVpnConnectionRoute">REST API Reference for CreateVpnConnectionRoute Operation</seealso>
        CreateVpnConnectionRouteResponse EndCreateVpnConnectionRoute(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateVpnGateway


        /// <summary>
        /// Creates a virtual private gateway. A virtual private gateway is the endpoint on the
        /// VPC side of your VPN connection. You can create a virtual private gateway before creating
        /// the VPC itself.
        /// 
        ///  
        /// <para>
        /// For more information about virtual private gateways, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_VPN.html">AWS
        /// Managed VPN Connections</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVpnGateway service method.</param>
        /// 
        /// <returns>The response from the CreateVpnGateway service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateVpnGateway">REST API Reference for CreateVpnGateway Operation</seealso>
        CreateVpnGatewayResponse CreateVpnGateway(CreateVpnGatewayRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateVpnGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVpnGateway operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateVpnGateway
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateVpnGateway">REST API Reference for CreateVpnGateway Operation</seealso>
        IAsyncResult BeginCreateVpnGateway(CreateVpnGatewayRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateVpnGateway operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateVpnGateway.</param>
        /// 
        /// <returns>Returns a  CreateVpnGatewayResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateVpnGateway">REST API Reference for CreateVpnGateway Operation</seealso>
        CreateVpnGatewayResponse EndCreateVpnGateway(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteCustomerGateway


        /// <summary>
        /// Deletes the specified customer gateway. You must delete the VPN connection before
        /// you can delete the customer gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCustomerGateway service method.</param>
        /// 
        /// <returns>The response from the DeleteCustomerGateway service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteCustomerGateway">REST API Reference for DeleteCustomerGateway Operation</seealso>
        DeleteCustomerGatewayResponse DeleteCustomerGateway(DeleteCustomerGatewayRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCustomerGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCustomerGateway operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCustomerGateway
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteCustomerGateway">REST API Reference for DeleteCustomerGateway Operation</seealso>
        IAsyncResult BeginDeleteCustomerGateway(DeleteCustomerGatewayRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCustomerGateway operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCustomerGateway.</param>
        /// 
        /// <returns>Returns a  DeleteCustomerGatewayResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteCustomerGateway">REST API Reference for DeleteCustomerGateway Operation</seealso>
        DeleteCustomerGatewayResponse EndDeleteCustomerGateway(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteDhcpOptions


        /// <summary>
        /// Deletes the specified set of DHCP options. You must disassociate the set of DHCP options
        /// before you can delete it. You can disassociate the set of DHCP options by associating
        /// either a new set of options or the default set of options with the VPC.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDhcpOptions service method.</param>
        /// 
        /// <returns>The response from the DeleteDhcpOptions service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteDhcpOptions">REST API Reference for DeleteDhcpOptions Operation</seealso>
        DeleteDhcpOptionsResponse DeleteDhcpOptions(DeleteDhcpOptionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDhcpOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDhcpOptions operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDhcpOptions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteDhcpOptions">REST API Reference for DeleteDhcpOptions Operation</seealso>
        IAsyncResult BeginDeleteDhcpOptions(DeleteDhcpOptionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDhcpOptions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDhcpOptions.</param>
        /// 
        /// <returns>Returns a  DeleteDhcpOptionsResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteDhcpOptions">REST API Reference for DeleteDhcpOptions Operation</seealso>
        DeleteDhcpOptionsResponse EndDeleteDhcpOptions(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteEgressOnlyInternetGateway


        /// <summary>
        /// Deletes an egress-only Internet gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteEgressOnlyInternetGateway service method.</param>
        /// 
        /// <returns>The response from the DeleteEgressOnlyInternetGateway service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteEgressOnlyInternetGateway">REST API Reference for DeleteEgressOnlyInternetGateway Operation</seealso>
        DeleteEgressOnlyInternetGatewayResponse DeleteEgressOnlyInternetGateway(DeleteEgressOnlyInternetGatewayRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEgressOnlyInternetGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEgressOnlyInternetGateway operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteEgressOnlyInternetGateway
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteEgressOnlyInternetGateway">REST API Reference for DeleteEgressOnlyInternetGateway Operation</seealso>
        IAsyncResult BeginDeleteEgressOnlyInternetGateway(DeleteEgressOnlyInternetGatewayRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteEgressOnlyInternetGateway operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteEgressOnlyInternetGateway.</param>
        /// 
        /// <returns>Returns a  DeleteEgressOnlyInternetGatewayResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteEgressOnlyInternetGateway">REST API Reference for DeleteEgressOnlyInternetGateway Operation</seealso>
        DeleteEgressOnlyInternetGatewayResponse EndDeleteEgressOnlyInternetGateway(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteFleets


        /// <summary>
        /// Deletes the specified EC2 Fleet.
        /// 
        ///  
        /// <para>
        /// After you delete an EC2 Fleet, the EC2 Fleet launches no new instances. You must specify
        /// whether the EC2 Fleet should also terminate its instances. If you terminate the instances,
        /// the EC2 Fleet enters the <code>deleted_terminating</code> state. Otherwise, the EC2
        /// Fleet enters the <code>deleted_running</code> state, and the instances continue to
        /// run until they are interrupted or you terminate them manually. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFleets service method.</param>
        /// 
        /// <returns>The response from the DeleteFleets service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteFleets">REST API Reference for DeleteFleets Operation</seealso>
        DeleteFleetsResponse DeleteFleets(DeleteFleetsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteFleets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFleets operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteFleets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteFleets">REST API Reference for DeleteFleets Operation</seealso>
        IAsyncResult BeginDeleteFleets(DeleteFleetsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteFleets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteFleets.</param>
        /// 
        /// <returns>Returns a  DeleteFleetsResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteFleets">REST API Reference for DeleteFleets Operation</seealso>
        DeleteFleetsResponse EndDeleteFleets(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteFlowLogs


        /// <summary>
        /// Deletes one or more flow logs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFlowLogs service method.</param>
        /// 
        /// <returns>The response from the DeleteFlowLogs service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteFlowLogs">REST API Reference for DeleteFlowLogs Operation</seealso>
        DeleteFlowLogsResponse DeleteFlowLogs(DeleteFlowLogsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteFlowLogs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFlowLogs operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteFlowLogs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteFlowLogs">REST API Reference for DeleteFlowLogs Operation</seealso>
        IAsyncResult BeginDeleteFlowLogs(DeleteFlowLogsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteFlowLogs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteFlowLogs.</param>
        /// 
        /// <returns>Returns a  DeleteFlowLogsResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteFlowLogs">REST API Reference for DeleteFlowLogs Operation</seealso>
        DeleteFlowLogsResponse EndDeleteFlowLogs(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteFpgaImage


        /// <summary>
        /// Deletes the specified Amazon FPGA Image (AFI).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFpgaImage service method.</param>
        /// 
        /// <returns>The response from the DeleteFpgaImage service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteFpgaImage">REST API Reference for DeleteFpgaImage Operation</seealso>
        DeleteFpgaImageResponse DeleteFpgaImage(DeleteFpgaImageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteFpgaImage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFpgaImage operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteFpgaImage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteFpgaImage">REST API Reference for DeleteFpgaImage Operation</seealso>
        IAsyncResult BeginDeleteFpgaImage(DeleteFpgaImageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteFpgaImage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteFpgaImage.</param>
        /// 
        /// <returns>Returns a  DeleteFpgaImageResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteFpgaImage">REST API Reference for DeleteFpgaImage Operation</seealso>
        DeleteFpgaImageResponse EndDeleteFpgaImage(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteInternetGateway


        /// <summary>
        /// Deletes the specified Internet gateway. You must detach the Internet gateway from
        /// the VPC before you can delete it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInternetGateway service method.</param>
        /// 
        /// <returns>The response from the DeleteInternetGateway service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteInternetGateway">REST API Reference for DeleteInternetGateway Operation</seealso>
        DeleteInternetGatewayResponse DeleteInternetGateway(DeleteInternetGatewayRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteInternetGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteInternetGateway operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteInternetGateway
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteInternetGateway">REST API Reference for DeleteInternetGateway Operation</seealso>
        IAsyncResult BeginDeleteInternetGateway(DeleteInternetGatewayRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteInternetGateway operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteInternetGateway.</param>
        /// 
        /// <returns>Returns a  DeleteInternetGatewayResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteInternetGateway">REST API Reference for DeleteInternetGateway Operation</seealso>
        DeleteInternetGatewayResponse EndDeleteInternetGateway(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteKeyPair


        /// <summary>
        /// Deletes the specified key pair, by removing the public key from Amazon EC2.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteKeyPair service method.</param>
        /// 
        /// <returns>The response from the DeleteKeyPair service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteKeyPair">REST API Reference for DeleteKeyPair Operation</seealso>
        DeleteKeyPairResponse DeleteKeyPair(DeleteKeyPairRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteKeyPair operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteKeyPair operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteKeyPair
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteKeyPair">REST API Reference for DeleteKeyPair Operation</seealso>
        IAsyncResult BeginDeleteKeyPair(DeleteKeyPairRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteKeyPair operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteKeyPair.</param>
        /// 
        /// <returns>Returns a  DeleteKeyPairResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteKeyPair">REST API Reference for DeleteKeyPair Operation</seealso>
        DeleteKeyPairResponse EndDeleteKeyPair(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteLaunchTemplate


        /// <summary>
        /// Deletes a launch template. Deleting a launch template deletes all of its versions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLaunchTemplate service method.</param>
        /// 
        /// <returns>The response from the DeleteLaunchTemplate service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteLaunchTemplate">REST API Reference for DeleteLaunchTemplate Operation</seealso>
        DeleteLaunchTemplateResponse DeleteLaunchTemplate(DeleteLaunchTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLaunchTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLaunchTemplate operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteLaunchTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteLaunchTemplate">REST API Reference for DeleteLaunchTemplate Operation</seealso>
        IAsyncResult BeginDeleteLaunchTemplate(DeleteLaunchTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteLaunchTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteLaunchTemplate.</param>
        /// 
        /// <returns>Returns a  DeleteLaunchTemplateResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteLaunchTemplate">REST API Reference for DeleteLaunchTemplate Operation</seealso>
        DeleteLaunchTemplateResponse EndDeleteLaunchTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteLaunchTemplateVersions


        /// <summary>
        /// Deletes one or more versions of a launch template. You cannot delete the default version
        /// of a launch template; you must first assign a different version as the default. If
        /// the default version is the only version for the launch template, you must delete the
        /// entire launch template using <a>DeleteLaunchTemplate</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLaunchTemplateVersions service method.</param>
        /// 
        /// <returns>The response from the DeleteLaunchTemplateVersions service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteLaunchTemplateVersions">REST API Reference for DeleteLaunchTemplateVersions Operation</seealso>
        DeleteLaunchTemplateVersionsResponse DeleteLaunchTemplateVersions(DeleteLaunchTemplateVersionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLaunchTemplateVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLaunchTemplateVersions operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteLaunchTemplateVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteLaunchTemplateVersions">REST API Reference for DeleteLaunchTemplateVersions Operation</seealso>
        IAsyncResult BeginDeleteLaunchTemplateVersions(DeleteLaunchTemplateVersionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteLaunchTemplateVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteLaunchTemplateVersions.</param>
        /// 
        /// <returns>Returns a  DeleteLaunchTemplateVersionsResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteLaunchTemplateVersions">REST API Reference for DeleteLaunchTemplateVersions Operation</seealso>
        DeleteLaunchTemplateVersionsResponse EndDeleteLaunchTemplateVersions(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteNatGateway


        /// <summary>
        /// Deletes the specified NAT gateway. Deleting a NAT gateway disassociates its Elastic
        /// IP address, but does not release the address from your account. Deleting a NAT gateway
        /// does not delete any NAT gateway routes in your route tables.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNatGateway service method.</param>
        /// 
        /// <returns>The response from the DeleteNatGateway service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteNatGateway">REST API Reference for DeleteNatGateway Operation</seealso>
        DeleteNatGatewayResponse DeleteNatGateway(DeleteNatGatewayRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteNatGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteNatGateway operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteNatGateway
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteNatGateway">REST API Reference for DeleteNatGateway Operation</seealso>
        IAsyncResult BeginDeleteNatGateway(DeleteNatGatewayRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteNatGateway operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteNatGateway.</param>
        /// 
        /// <returns>Returns a  DeleteNatGatewayResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteNatGateway">REST API Reference for DeleteNatGateway Operation</seealso>
        DeleteNatGatewayResponse EndDeleteNatGateway(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteNetworkAcl


        /// <summary>
        /// Deletes the specified network ACL. You can't delete the ACL if it's associated with
        /// any subnets. You can't delete the default network ACL.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNetworkAcl service method.</param>
        /// 
        /// <returns>The response from the DeleteNetworkAcl service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteNetworkAcl">REST API Reference for DeleteNetworkAcl Operation</seealso>
        DeleteNetworkAclResponse DeleteNetworkAcl(DeleteNetworkAclRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteNetworkAcl operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteNetworkAcl operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteNetworkAcl
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteNetworkAcl">REST API Reference for DeleteNetworkAcl Operation</seealso>
        IAsyncResult BeginDeleteNetworkAcl(DeleteNetworkAclRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteNetworkAcl operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteNetworkAcl.</param>
        /// 
        /// <returns>Returns a  DeleteNetworkAclResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteNetworkAcl">REST API Reference for DeleteNetworkAcl Operation</seealso>
        DeleteNetworkAclResponse EndDeleteNetworkAcl(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteNetworkAclEntry


        /// <summary>
        /// Deletes the specified ingress or egress entry (rule) from the specified network ACL.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNetworkAclEntry service method.</param>
        /// 
        /// <returns>The response from the DeleteNetworkAclEntry service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteNetworkAclEntry">REST API Reference for DeleteNetworkAclEntry Operation</seealso>
        DeleteNetworkAclEntryResponse DeleteNetworkAclEntry(DeleteNetworkAclEntryRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteNetworkAclEntry operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteNetworkAclEntry operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteNetworkAclEntry
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteNetworkAclEntry">REST API Reference for DeleteNetworkAclEntry Operation</seealso>
        IAsyncResult BeginDeleteNetworkAclEntry(DeleteNetworkAclEntryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteNetworkAclEntry operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteNetworkAclEntry.</param>
        /// 
        /// <returns>Returns a  DeleteNetworkAclEntryResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteNetworkAclEntry">REST API Reference for DeleteNetworkAclEntry Operation</seealso>
        DeleteNetworkAclEntryResponse EndDeleteNetworkAclEntry(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteNetworkInterface


        /// <summary>
        /// Deletes the specified network interface. You must detach the network interface before
        /// you can delete it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNetworkInterface service method.</param>
        /// 
        /// <returns>The response from the DeleteNetworkInterface service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteNetworkInterface">REST API Reference for DeleteNetworkInterface Operation</seealso>
        DeleteNetworkInterfaceResponse DeleteNetworkInterface(DeleteNetworkInterfaceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteNetworkInterface operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteNetworkInterface operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteNetworkInterface
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteNetworkInterface">REST API Reference for DeleteNetworkInterface Operation</seealso>
        IAsyncResult BeginDeleteNetworkInterface(DeleteNetworkInterfaceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteNetworkInterface operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteNetworkInterface.</param>
        /// 
        /// <returns>Returns a  DeleteNetworkInterfaceResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteNetworkInterface">REST API Reference for DeleteNetworkInterface Operation</seealso>
        DeleteNetworkInterfaceResponse EndDeleteNetworkInterface(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteNetworkInterfacePermission


        /// <summary>
        /// Deletes a permission for a network interface. By default, you cannot delete the permission
        /// if the account for which you're removing the permission has attached the network interface
        /// to an instance. However, you can force delete the permission, regardless of any attachment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNetworkInterfacePermission service method.</param>
        /// 
        /// <returns>The response from the DeleteNetworkInterfacePermission service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteNetworkInterfacePermission">REST API Reference for DeleteNetworkInterfacePermission Operation</seealso>
        DeleteNetworkInterfacePermissionResponse DeleteNetworkInterfacePermission(DeleteNetworkInterfacePermissionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteNetworkInterfacePermission operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteNetworkInterfacePermission operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteNetworkInterfacePermission
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteNetworkInterfacePermission">REST API Reference for DeleteNetworkInterfacePermission Operation</seealso>
        IAsyncResult BeginDeleteNetworkInterfacePermission(DeleteNetworkInterfacePermissionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteNetworkInterfacePermission operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteNetworkInterfacePermission.</param>
        /// 
        /// <returns>Returns a  DeleteNetworkInterfacePermissionResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteNetworkInterfacePermission">REST API Reference for DeleteNetworkInterfacePermission Operation</seealso>
        DeleteNetworkInterfacePermissionResponse EndDeleteNetworkInterfacePermission(IAsyncResult asyncResult);

        #endregion
        
        #region  DeletePlacementGroup


        /// <summary>
        /// Deletes the specified placement group. You must terminate all instances in the placement
        /// group before you can delete the placement group. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/placement-groups.html">Placement
        /// Groups</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePlacementGroup service method.</param>
        /// 
        /// <returns>The response from the DeletePlacementGroup service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeletePlacementGroup">REST API Reference for DeletePlacementGroup Operation</seealso>
        DeletePlacementGroupResponse DeletePlacementGroup(DeletePlacementGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePlacementGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePlacementGroup operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePlacementGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeletePlacementGroup">REST API Reference for DeletePlacementGroup Operation</seealso>
        IAsyncResult BeginDeletePlacementGroup(DeletePlacementGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePlacementGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePlacementGroup.</param>
        /// 
        /// <returns>Returns a  DeletePlacementGroupResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeletePlacementGroup">REST API Reference for DeletePlacementGroup Operation</seealso>
        DeletePlacementGroupResponse EndDeletePlacementGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteRoute


        /// <summary>
        /// Deletes the specified route from the specified route table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRoute service method.</param>
        /// 
        /// <returns>The response from the DeleteRoute service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteRoute">REST API Reference for DeleteRoute Operation</seealso>
        DeleteRouteResponse DeleteRoute(DeleteRouteRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRoute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRoute operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRoute
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteRoute">REST API Reference for DeleteRoute Operation</seealso>
        IAsyncResult BeginDeleteRoute(DeleteRouteRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRoute operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRoute.</param>
        /// 
        /// <returns>Returns a  DeleteRouteResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteRoute">REST API Reference for DeleteRoute Operation</seealso>
        DeleteRouteResponse EndDeleteRoute(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteRouteTable


        /// <summary>
        /// Deletes the specified route table. You must disassociate the route table from any
        /// subnets before you can delete it. You can't delete the main route table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRouteTable service method.</param>
        /// 
        /// <returns>The response from the DeleteRouteTable service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteRouteTable">REST API Reference for DeleteRouteTable Operation</seealso>
        DeleteRouteTableResponse DeleteRouteTable(DeleteRouteTableRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRouteTable operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRouteTable operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteRouteTable
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteRouteTable">REST API Reference for DeleteRouteTable Operation</seealso>
        IAsyncResult BeginDeleteRouteTable(DeleteRouteTableRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRouteTable operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRouteTable.</param>
        /// 
        /// <returns>Returns a  DeleteRouteTableResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteRouteTable">REST API Reference for DeleteRouteTable Operation</seealso>
        DeleteRouteTableResponse EndDeleteRouteTable(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteSecurityGroup


        /// <summary>
        /// Deletes a security group.
        /// 
        ///  
        /// <para>
        /// If you attempt to delete a security group that is associated with an instance, or
        /// is referenced by another security group, the operation fails with <code>InvalidGroup.InUse</code>
        /// in EC2-Classic or <code>DependencyViolation</code> in EC2-VPC.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSecurityGroup service method.</param>
        /// 
        /// <returns>The response from the DeleteSecurityGroup service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteSecurityGroup">REST API Reference for DeleteSecurityGroup Operation</seealso>
        DeleteSecurityGroupResponse DeleteSecurityGroup(DeleteSecurityGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSecurityGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSecurityGroup operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSecurityGroup
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteSecurityGroup">REST API Reference for DeleteSecurityGroup Operation</seealso>
        IAsyncResult BeginDeleteSecurityGroup(DeleteSecurityGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSecurityGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSecurityGroup.</param>
        /// 
        /// <returns>Returns a  DeleteSecurityGroupResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteSecurityGroup">REST API Reference for DeleteSecurityGroup Operation</seealso>
        DeleteSecurityGroupResponse EndDeleteSecurityGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteSnapshot


        /// <summary>
        /// Deletes the specified snapshot.
        /// 
        ///  
        /// <para>
        /// When you make periodic snapshots of a volume, the snapshots are incremental, and only
        /// the blocks on the device that have changed since your last snapshot are saved in the
        /// new snapshot. When you delete a snapshot, only the data not needed for any other snapshot
        /// is removed. So regardless of which prior snapshots have been deleted, all active snapshots
        /// will have access to all the information needed to restore the volume.
        /// </para>
        ///  
        /// <para>
        /// You cannot delete a snapshot of the root device of an EBS volume used by a registered
        /// AMI. You must first de-register the AMI before you can delete the snapshot.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-deleting-snapshot.html">Deleting
        /// an Amazon EBS Snapshot</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSnapshot service method.</param>
        /// 
        /// <returns>The response from the DeleteSnapshot service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteSnapshot">REST API Reference for DeleteSnapshot Operation</seealso>
        DeleteSnapshotResponse DeleteSnapshot(DeleteSnapshotRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSnapshot operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSnapshot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteSnapshot">REST API Reference for DeleteSnapshot Operation</seealso>
        IAsyncResult BeginDeleteSnapshot(DeleteSnapshotRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSnapshot.</param>
        /// 
        /// <returns>Returns a  DeleteSnapshotResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteSnapshot">REST API Reference for DeleteSnapshot Operation</seealso>
        DeleteSnapshotResponse EndDeleteSnapshot(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteSpotDatafeedSubscription


        /// <summary>
        /// Deletes the data feed for Spot Instances.
        /// </summary>
        /// 
        /// <returns>The response from the DeleteSpotDatafeedSubscription service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteSpotDatafeedSubscription">REST API Reference for DeleteSpotDatafeedSubscription Operation</seealso>
        DeleteSpotDatafeedSubscriptionResponse DeleteSpotDatafeedSubscription();

        /// <summary>
        /// Deletes the data feed for Spot Instances.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSpotDatafeedSubscription service method.</param>
        /// 
        /// <returns>The response from the DeleteSpotDatafeedSubscription service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteSpotDatafeedSubscription">REST API Reference for DeleteSpotDatafeedSubscription Operation</seealso>
        DeleteSpotDatafeedSubscriptionResponse DeleteSpotDatafeedSubscription(DeleteSpotDatafeedSubscriptionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSpotDatafeedSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSpotDatafeedSubscription operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSpotDatafeedSubscription
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteSpotDatafeedSubscription">REST API Reference for DeleteSpotDatafeedSubscription Operation</seealso>
        IAsyncResult BeginDeleteSpotDatafeedSubscription(DeleteSpotDatafeedSubscriptionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSpotDatafeedSubscription operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSpotDatafeedSubscription.</param>
        /// 
        /// <returns>Returns a  DeleteSpotDatafeedSubscriptionResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteSpotDatafeedSubscription">REST API Reference for DeleteSpotDatafeedSubscription Operation</seealso>
        DeleteSpotDatafeedSubscriptionResponse EndDeleteSpotDatafeedSubscription(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteSubnet


        /// <summary>
        /// Deletes the specified subnet. You must terminate all running instances in the subnet
        /// before you can delete the subnet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSubnet service method.</param>
        /// 
        /// <returns>The response from the DeleteSubnet service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteSubnet">REST API Reference for DeleteSubnet Operation</seealso>
        DeleteSubnetResponse DeleteSubnet(DeleteSubnetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSubnet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSubnet operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSubnet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteSubnet">REST API Reference for DeleteSubnet Operation</seealso>
        IAsyncResult BeginDeleteSubnet(DeleteSubnetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSubnet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSubnet.</param>
        /// 
        /// <returns>Returns a  DeleteSubnetResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteSubnet">REST API Reference for DeleteSubnet Operation</seealso>
        DeleteSubnetResponse EndDeleteSubnet(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteTags


        /// <summary>
        /// Deletes the specified set of tags from the specified set of resources.
        /// 
        ///  
        /// <para>
        /// To list the current tags, use <a>DescribeTags</a>. For more information about tags,
        /// see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_Tags.html">Tagging
        /// Your Resources</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTags service method.</param>
        /// 
        /// <returns>The response from the DeleteTags service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteTags">REST API Reference for DeleteTags Operation</seealso>
        DeleteTagsResponse DeleteTags(DeleteTagsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTags operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteTags
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteTags">REST API Reference for DeleteTags Operation</seealso>
        IAsyncResult BeginDeleteTags(DeleteTagsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTags.</param>
        /// 
        /// <returns>Returns a  DeleteTagsResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteTags">REST API Reference for DeleteTags Operation</seealso>
        DeleteTagsResponse EndDeleteTags(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteVolume


        /// <summary>
        /// Deletes the specified EBS volume. The volume must be in the <code>available</code>
        /// state (not attached to an instance).
        /// 
        ///  <note> 
        /// <para>
        /// The volume may remain in the <code>deleting</code> state for several minutes.
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-deleting-volume.html">Deleting
        /// an Amazon EBS Volume</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVolume service method.</param>
        /// 
        /// <returns>The response from the DeleteVolume service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteVolume">REST API Reference for DeleteVolume Operation</seealso>
        DeleteVolumeResponse DeleteVolume(DeleteVolumeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVolume operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVolume operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVolume
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteVolume">REST API Reference for DeleteVolume Operation</seealso>
        IAsyncResult BeginDeleteVolume(DeleteVolumeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVolume operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVolume.</param>
        /// 
        /// <returns>Returns a  DeleteVolumeResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteVolume">REST API Reference for DeleteVolume Operation</seealso>
        DeleteVolumeResponse EndDeleteVolume(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteVpc


        /// <summary>
        /// Deletes the specified VPC. You must detach or delete all gateways and resources that
        /// are associated with the VPC before you can delete it. For example, you must terminate
        /// all instances running in the VPC, delete all security groups associated with the VPC
        /// (except the default one), delete all route tables associated with the VPC (except
        /// the default one), and so on.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpc service method.</param>
        /// 
        /// <returns>The response from the DeleteVpc service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteVpc">REST API Reference for DeleteVpc Operation</seealso>
        DeleteVpcResponse DeleteVpc(DeleteVpcRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVpc operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpc operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVpc
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteVpc">REST API Reference for DeleteVpc Operation</seealso>
        IAsyncResult BeginDeleteVpc(DeleteVpcRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVpc operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVpc.</param>
        /// 
        /// <returns>Returns a  DeleteVpcResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteVpc">REST API Reference for DeleteVpc Operation</seealso>
        DeleteVpcResponse EndDeleteVpc(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteVpcEndpointConnectionNotifications


        /// <summary>
        /// Deletes one or more VPC endpoint connection notifications.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpcEndpointConnectionNotifications service method.</param>
        /// 
        /// <returns>The response from the DeleteVpcEndpointConnectionNotifications service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteVpcEndpointConnectionNotifications">REST API Reference for DeleteVpcEndpointConnectionNotifications Operation</seealso>
        DeleteVpcEndpointConnectionNotificationsResponse DeleteVpcEndpointConnectionNotifications(DeleteVpcEndpointConnectionNotificationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVpcEndpointConnectionNotifications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpcEndpointConnectionNotifications operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVpcEndpointConnectionNotifications
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteVpcEndpointConnectionNotifications">REST API Reference for DeleteVpcEndpointConnectionNotifications Operation</seealso>
        IAsyncResult BeginDeleteVpcEndpointConnectionNotifications(DeleteVpcEndpointConnectionNotificationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVpcEndpointConnectionNotifications operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVpcEndpointConnectionNotifications.</param>
        /// 
        /// <returns>Returns a  DeleteVpcEndpointConnectionNotificationsResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteVpcEndpointConnectionNotifications">REST API Reference for DeleteVpcEndpointConnectionNotifications Operation</seealso>
        DeleteVpcEndpointConnectionNotificationsResponse EndDeleteVpcEndpointConnectionNotifications(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteVpcEndpoints


        /// <summary>
        /// Deletes one or more specified VPC endpoints. Deleting a gateway endpoint also deletes
        /// the endpoint routes in the route tables that were associated with the endpoint. Deleting
        /// an interface endpoint deletes the endpoint network interfaces.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpcEndpoints service method.</param>
        /// 
        /// <returns>The response from the DeleteVpcEndpoints service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteVpcEndpoints">REST API Reference for DeleteVpcEndpoints Operation</seealso>
        DeleteVpcEndpointsResponse DeleteVpcEndpoints(DeleteVpcEndpointsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVpcEndpoints operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpcEndpoints operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVpcEndpoints
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteVpcEndpoints">REST API Reference for DeleteVpcEndpoints Operation</seealso>
        IAsyncResult BeginDeleteVpcEndpoints(DeleteVpcEndpointsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVpcEndpoints operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVpcEndpoints.</param>
        /// 
        /// <returns>Returns a  DeleteVpcEndpointsResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteVpcEndpoints">REST API Reference for DeleteVpcEndpoints Operation</seealso>
        DeleteVpcEndpointsResponse EndDeleteVpcEndpoints(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteVpcEndpointServiceConfigurations


        /// <summary>
        /// Deletes one or more VPC endpoint service configurations in your account. Before you
        /// delete the endpoint service configuration, you must reject any <code>Available</code>
        /// or <code>PendingAcceptance</code> interface endpoint connections that are attached
        /// to the service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpcEndpointServiceConfigurations service method.</param>
        /// 
        /// <returns>The response from the DeleteVpcEndpointServiceConfigurations service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteVpcEndpointServiceConfigurations">REST API Reference for DeleteVpcEndpointServiceConfigurations Operation</seealso>
        DeleteVpcEndpointServiceConfigurationsResponse DeleteVpcEndpointServiceConfigurations(DeleteVpcEndpointServiceConfigurationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVpcEndpointServiceConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpcEndpointServiceConfigurations operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVpcEndpointServiceConfigurations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteVpcEndpointServiceConfigurations">REST API Reference for DeleteVpcEndpointServiceConfigurations Operation</seealso>
        IAsyncResult BeginDeleteVpcEndpointServiceConfigurations(DeleteVpcEndpointServiceConfigurationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVpcEndpointServiceConfigurations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVpcEndpointServiceConfigurations.</param>
        /// 
        /// <returns>Returns a  DeleteVpcEndpointServiceConfigurationsResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteVpcEndpointServiceConfigurations">REST API Reference for DeleteVpcEndpointServiceConfigurations Operation</seealso>
        DeleteVpcEndpointServiceConfigurationsResponse EndDeleteVpcEndpointServiceConfigurations(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteVpcPeeringConnection


        /// <summary>
        /// Deletes a VPC peering connection. Either the owner of the requester VPC or the owner
        /// of the accepter VPC can delete the VPC peering connection if it's in the <code>active</code>
        /// state. The owner of the requester VPC can delete a VPC peering connection in the <code>pending-acceptance</code>
        /// state. You cannot delete a VPC peering connection that's in the <code>failed</code>
        /// state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpcPeeringConnection service method.</param>
        /// 
        /// <returns>The response from the DeleteVpcPeeringConnection service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteVpcPeeringConnection">REST API Reference for DeleteVpcPeeringConnection Operation</seealso>
        DeleteVpcPeeringConnectionResponse DeleteVpcPeeringConnection(DeleteVpcPeeringConnectionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVpcPeeringConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpcPeeringConnection operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVpcPeeringConnection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteVpcPeeringConnection">REST API Reference for DeleteVpcPeeringConnection Operation</seealso>
        IAsyncResult BeginDeleteVpcPeeringConnection(DeleteVpcPeeringConnectionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVpcPeeringConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVpcPeeringConnection.</param>
        /// 
        /// <returns>Returns a  DeleteVpcPeeringConnectionResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteVpcPeeringConnection">REST API Reference for DeleteVpcPeeringConnection Operation</seealso>
        DeleteVpcPeeringConnectionResponse EndDeleteVpcPeeringConnection(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteVpnConnection


        /// <summary>
        /// Deletes the specified VPN connection.
        /// 
        ///  
        /// <para>
        /// If you're deleting the VPC and its associated components, we recommend that you detach
        /// the virtual private gateway from the VPC and delete the VPC before deleting the VPN
        /// connection. If you believe that the tunnel credentials for your VPN connection have
        /// been compromised, you can delete the VPN connection and create a new one that has
        /// new keys, without needing to delete the VPC or virtual private gateway. If you create
        /// a new VPN connection, you must reconfigure the customer gateway using the new configuration
        /// information returned with the new VPN connection ID.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpnConnection service method.</param>
        /// 
        /// <returns>The response from the DeleteVpnConnection service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteVpnConnection">REST API Reference for DeleteVpnConnection Operation</seealso>
        DeleteVpnConnectionResponse DeleteVpnConnection(DeleteVpnConnectionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVpnConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpnConnection operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVpnConnection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteVpnConnection">REST API Reference for DeleteVpnConnection Operation</seealso>
        IAsyncResult BeginDeleteVpnConnection(DeleteVpnConnectionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVpnConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVpnConnection.</param>
        /// 
        /// <returns>Returns a  DeleteVpnConnectionResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteVpnConnection">REST API Reference for DeleteVpnConnection Operation</seealso>
        DeleteVpnConnectionResponse EndDeleteVpnConnection(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteVpnConnectionRoute


        /// <summary>
        /// Deletes the specified static route associated with a VPN connection between an existing
        /// virtual private gateway and a VPN customer gateway. The static route allows traffic
        /// to be routed from the virtual private gateway to the VPN customer gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpnConnectionRoute service method.</param>
        /// 
        /// <returns>The response from the DeleteVpnConnectionRoute service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteVpnConnectionRoute">REST API Reference for DeleteVpnConnectionRoute Operation</seealso>
        DeleteVpnConnectionRouteResponse DeleteVpnConnectionRoute(DeleteVpnConnectionRouteRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVpnConnectionRoute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpnConnectionRoute operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVpnConnectionRoute
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteVpnConnectionRoute">REST API Reference for DeleteVpnConnectionRoute Operation</seealso>
        IAsyncResult BeginDeleteVpnConnectionRoute(DeleteVpnConnectionRouteRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVpnConnectionRoute operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVpnConnectionRoute.</param>
        /// 
        /// <returns>Returns a  DeleteVpnConnectionRouteResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteVpnConnectionRoute">REST API Reference for DeleteVpnConnectionRoute Operation</seealso>
        DeleteVpnConnectionRouteResponse EndDeleteVpnConnectionRoute(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteVpnGateway


        /// <summary>
        /// Deletes the specified virtual private gateway. We recommend that before you delete
        /// a virtual private gateway, you detach it from the VPC and delete the VPN connection.
        /// Note that you don't need to delete the virtual private gateway if you plan to delete
        /// and recreate the VPN connection between your VPC and your network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpnGateway service method.</param>
        /// 
        /// <returns>The response from the DeleteVpnGateway service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteVpnGateway">REST API Reference for DeleteVpnGateway Operation</seealso>
        DeleteVpnGatewayResponse DeleteVpnGateway(DeleteVpnGatewayRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVpnGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpnGateway operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteVpnGateway
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteVpnGateway">REST API Reference for DeleteVpnGateway Operation</seealso>
        IAsyncResult BeginDeleteVpnGateway(DeleteVpnGatewayRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVpnGateway operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVpnGateway.</param>
        /// 
        /// <returns>Returns a  DeleteVpnGatewayResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteVpnGateway">REST API Reference for DeleteVpnGateway Operation</seealso>
        DeleteVpnGatewayResponse EndDeleteVpnGateway(IAsyncResult asyncResult);

        #endregion
        
        #region  DeregisterImage


        /// <summary>
        /// Deregisters the specified AMI. After you deregister an AMI, it can't be used to launch
        /// new instances; however, it doesn't affect any instances that you've already launched
        /// from the AMI. You'll continue to incur usage costs for those instances until you terminate
        /// them.
        /// 
        ///  
        /// <para>
        /// When you deregister an Amazon EBS-backed AMI, it doesn't affect the snapshot that
        /// was created for the root volume of the instance during the AMI creation process. When
        /// you deregister an instance store-backed AMI, it doesn't affect the files that you
        /// uploaded to Amazon S3 when you created the AMI.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterImage service method.</param>
        /// 
        /// <returns>The response from the DeregisterImage service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeregisterImage">REST API Reference for DeregisterImage Operation</seealso>
        DeregisterImageResponse DeregisterImage(DeregisterImageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterImage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterImage operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeregisterImage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeregisterImage">REST API Reference for DeregisterImage Operation</seealso>
        IAsyncResult BeginDeregisterImage(DeregisterImageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeregisterImage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeregisterImage.</param>
        /// 
        /// <returns>Returns a  DeregisterImageResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeregisterImage">REST API Reference for DeregisterImage Operation</seealso>
        DeregisterImageResponse EndDeregisterImage(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeAccountAttributes


        /// <summary>
        /// Describes attributes of your AWS account. The following are the supported account
        /// attributes:
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <code>supported-platforms</code>: Indicates whether your account can launch instances
        /// into EC2-Classic and EC2-VPC, or only into EC2-VPC.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>default-vpc</code>: The ID of the default VPC for your account, or <code>none</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>max-instances</code>: The maximum number of On-Demand Instances that you can
        /// run.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>vpc-max-security-groups-per-interface</code>: The maximum number of security
        /// groups that you can assign to a network interface.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>max-elastic-ips</code>: The maximum number of Elastic IP addresses that you
        /// can allocate for use with EC2-Classic. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>vpc-max-elastic-ips</code>: The maximum number of Elastic IP addresses that
        /// you can allocate for use with EC2-VPC.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeAccountAttributes service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeAccountAttributes">REST API Reference for DescribeAccountAttributes Operation</seealso>
        DescribeAccountAttributesResponse DescribeAccountAttributes();

        /// <summary>
        /// Describes attributes of your AWS account. The following are the supported account
        /// attributes:
        /// 
        ///  <ul> <li> 
        /// <para>
        ///  <code>supported-platforms</code>: Indicates whether your account can launch instances
        /// into EC2-Classic and EC2-VPC, or only into EC2-VPC.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>default-vpc</code>: The ID of the default VPC for your account, or <code>none</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>max-instances</code>: The maximum number of On-Demand Instances that you can
        /// run.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>vpc-max-security-groups-per-interface</code>: The maximum number of security
        /// groups that you can assign to a network interface.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>max-elastic-ips</code>: The maximum number of Elastic IP addresses that you
        /// can allocate for use with EC2-Classic. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <code>vpc-max-elastic-ips</code>: The maximum number of Elastic IP addresses that
        /// you can allocate for use with EC2-VPC.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountAttributes service method.</param>
        /// 
        /// <returns>The response from the DescribeAccountAttributes service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeAccountAttributes">REST API Reference for DescribeAccountAttributes Operation</seealso>
        DescribeAccountAttributesResponse DescribeAccountAttributes(DescribeAccountAttributesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAccountAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountAttributes operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAccountAttributes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeAccountAttributes">REST API Reference for DescribeAccountAttributes Operation</seealso>
        IAsyncResult BeginDescribeAccountAttributes(DescribeAccountAttributesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAccountAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAccountAttributes.</param>
        /// 
        /// <returns>Returns a  DescribeAccountAttributesResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeAccountAttributes">REST API Reference for DescribeAccountAttributes Operation</seealso>
        DescribeAccountAttributesResponse EndDescribeAccountAttributes(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeAddresses


        /// <summary>
        /// Describes one or more of your Elastic IP addresses.
        /// 
        ///  
        /// <para>
        /// An Elastic IP address is for use in either the EC2-Classic platform or in a VPC. For
        /// more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/elastic-ip-addresses-eip.html">Elastic
        /// IP Addresses</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeAddresses service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeAddresses">REST API Reference for DescribeAddresses Operation</seealso>
        DescribeAddressesResponse DescribeAddresses();

        /// <summary>
        /// Describes one or more of your Elastic IP addresses.
        /// 
        ///  
        /// <para>
        /// An Elastic IP address is for use in either the EC2-Classic platform or in a VPC. For
        /// more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/elastic-ip-addresses-eip.html">Elastic
        /// IP Addresses</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAddresses service method.</param>
        /// 
        /// <returns>The response from the DescribeAddresses service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeAddresses">REST API Reference for DescribeAddresses Operation</seealso>
        DescribeAddressesResponse DescribeAddresses(DescribeAddressesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAddresses operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAddresses operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAddresses
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeAddresses">REST API Reference for DescribeAddresses Operation</seealso>
        IAsyncResult BeginDescribeAddresses(DescribeAddressesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAddresses operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAddresses.</param>
        /// 
        /// <returns>Returns a  DescribeAddressesResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeAddresses">REST API Reference for DescribeAddresses Operation</seealso>
        DescribeAddressesResponse EndDescribeAddresses(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeAggregateIdFormat


        /// <summary>
        /// Describes the longer ID format settings for all resource types in a specific region.
        /// This request is useful for performing a quick audit to determine whether a specific
        /// region is fully opted in for longer IDs (17-character IDs).
        /// 
        ///  
        /// <para>
        /// This request only returns information about resource types that support longer IDs.
        /// </para>
        ///  
        /// <para>
        /// The following resource types support longer IDs: <code>bundle</code> | <code>conversion-task</code>
        /// | <code>customer-gateway</code> | <code>dhcp-options</code> | <code>elastic-ip-allocation</code>
        /// | <code>elastic-ip-association</code> | <code>export-task</code> | <code>flow-log</code>
        /// | <code>image</code> | <code>import-task</code> | <code>instance</code> | <code>internet-gateway</code>
        /// | <code>network-acl</code> | <code>network-acl-association</code> | <code>network-interface</code>
        /// | <code>network-interface-attachment</code> | <code>prefix-list</code> | <code>reservation</code>
        /// | <code>route-table</code> | <code>route-table-association</code> | <code>security-group</code>
        /// | <code>snapshot</code> | <code>subnet</code> | <code>subnet-cidr-block-association</code>
        /// | <code>volume</code> | <code>vpc</code> | <code>vpc-cidr-block-association</code>
        /// | <code>vpc-endpoint</code> | <code>vpc-peering-connection</code> | <code>vpn-connection</code>
        /// | <code>vpn-gateway</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAggregateIdFormat service method.</param>
        /// 
        /// <returns>The response from the DescribeAggregateIdFormat service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeAggregateIdFormat">REST API Reference for DescribeAggregateIdFormat Operation</seealso>
        DescribeAggregateIdFormatResponse DescribeAggregateIdFormat(DescribeAggregateIdFormatRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAggregateIdFormat operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAggregateIdFormat operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAggregateIdFormat
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeAggregateIdFormat">REST API Reference for DescribeAggregateIdFormat Operation</seealso>
        IAsyncResult BeginDescribeAggregateIdFormat(DescribeAggregateIdFormatRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAggregateIdFormat operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAggregateIdFormat.</param>
        /// 
        /// <returns>Returns a  DescribeAggregateIdFormatResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeAggregateIdFormat">REST API Reference for DescribeAggregateIdFormat Operation</seealso>
        DescribeAggregateIdFormatResponse EndDescribeAggregateIdFormat(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeAvailabilityZones


        /// <summary>
        /// Describes one or more of the Availability Zones that are available to you. The results
        /// include zones only for the region you're currently using. If there is an event impacting
        /// an Availability Zone, you can use this request to view the state and any provided
        /// message for that Availability Zone.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-regions-availability-zones.html">Regions
        /// and Availability Zones</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeAvailabilityZones service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeAvailabilityZones">REST API Reference for DescribeAvailabilityZones Operation</seealso>
        DescribeAvailabilityZonesResponse DescribeAvailabilityZones();

        /// <summary>
        /// Describes one or more of the Availability Zones that are available to you. The results
        /// include zones only for the region you're currently using. If there is an event impacting
        /// an Availability Zone, you can use this request to view the state and any provided
        /// message for that Availability Zone.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-regions-availability-zones.html">Regions
        /// and Availability Zones</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAvailabilityZones service method.</param>
        /// 
        /// <returns>The response from the DescribeAvailabilityZones service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeAvailabilityZones">REST API Reference for DescribeAvailabilityZones Operation</seealso>
        DescribeAvailabilityZonesResponse DescribeAvailabilityZones(DescribeAvailabilityZonesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAvailabilityZones operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAvailabilityZones operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAvailabilityZones
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeAvailabilityZones">REST API Reference for DescribeAvailabilityZones Operation</seealso>
        IAsyncResult BeginDescribeAvailabilityZones(DescribeAvailabilityZonesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAvailabilityZones operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAvailabilityZones.</param>
        /// 
        /// <returns>Returns a  DescribeAvailabilityZonesResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeAvailabilityZones">REST API Reference for DescribeAvailabilityZones Operation</seealso>
        DescribeAvailabilityZonesResponse EndDescribeAvailabilityZones(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeBundleTasks


        /// <summary>
        /// Describes one or more of your bundling tasks.
        /// 
        ///  <note> 
        /// <para>
        /// Completed bundle tasks are listed for only a limited time. If your bundle task is
        /// no longer in the list, you can still register an AMI from it. Just use <code>RegisterImage</code>
        /// with the Amazon S3 bucket name and image manifest name you provided to the bundle
        /// task.
        /// </para>
        ///  </note>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeBundleTasks service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeBundleTasks">REST API Reference for DescribeBundleTasks Operation</seealso>
        DescribeBundleTasksResponse DescribeBundleTasks();

        /// <summary>
        /// Describes one or more of your bundling tasks.
        /// 
        ///  <note> 
        /// <para>
        /// Completed bundle tasks are listed for only a limited time. If your bundle task is
        /// no longer in the list, you can still register an AMI from it. Just use <code>RegisterImage</code>
        /// with the Amazon S3 bucket name and image manifest name you provided to the bundle
        /// task.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBundleTasks service method.</param>
        /// 
        /// <returns>The response from the DescribeBundleTasks service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeBundleTasks">REST API Reference for DescribeBundleTasks Operation</seealso>
        DescribeBundleTasksResponse DescribeBundleTasks(DescribeBundleTasksRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeBundleTasks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeBundleTasks operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeBundleTasks
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeBundleTasks">REST API Reference for DescribeBundleTasks Operation</seealso>
        IAsyncResult BeginDescribeBundleTasks(DescribeBundleTasksRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeBundleTasks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeBundleTasks.</param>
        /// 
        /// <returns>Returns a  DescribeBundleTasksResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeBundleTasks">REST API Reference for DescribeBundleTasks Operation</seealso>
        DescribeBundleTasksResponse EndDescribeBundleTasks(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeClassicLinkInstances


        /// <summary>
        /// Describes one or more of your linked EC2-Classic instances. This request only returns
        /// information about EC2-Classic instances linked to a VPC through ClassicLink; you cannot
        /// use this request to return information about other instances.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeClassicLinkInstances service method.</param>
        /// 
        /// <returns>The response from the DescribeClassicLinkInstances service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeClassicLinkInstances">REST API Reference for DescribeClassicLinkInstances Operation</seealso>
        DescribeClassicLinkInstancesResponse DescribeClassicLinkInstances(DescribeClassicLinkInstancesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeClassicLinkInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeClassicLinkInstances operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeClassicLinkInstances
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeClassicLinkInstances">REST API Reference for DescribeClassicLinkInstances Operation</seealso>
        IAsyncResult BeginDescribeClassicLinkInstances(DescribeClassicLinkInstancesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeClassicLinkInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeClassicLinkInstances.</param>
        /// 
        /// <returns>Returns a  DescribeClassicLinkInstancesResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeClassicLinkInstances">REST API Reference for DescribeClassicLinkInstances Operation</seealso>
        DescribeClassicLinkInstancesResponse EndDescribeClassicLinkInstances(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeConversionTasks


        /// <summary>
        /// Describes one or more of your conversion tasks. For more information, see the <a href="http://docs.aws.amazon.com/vm-import/latest/userguide/">VM
        /// Import/Export User Guide</a>.
        /// 
        ///  
        /// <para>
        /// For information about the import manifest referenced by this API action, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/APIReference/manifest.html">VM
        /// Import Manifest</a>.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeConversionTasks service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeConversionTasks">REST API Reference for DescribeConversionTasks Operation</seealso>
        DescribeConversionTasksResponse DescribeConversionTasks();

        /// <summary>
        /// Describes one or more of your conversion tasks. For more information, see the <a href="http://docs.aws.amazon.com/vm-import/latest/userguide/">VM
        /// Import/Export User Guide</a>.
        /// 
        ///  
        /// <para>
        /// For information about the import manifest referenced by this API action, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/APIReference/manifest.html">VM
        /// Import Manifest</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConversionTasks service method.</param>
        /// 
        /// <returns>The response from the DescribeConversionTasks service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeConversionTasks">REST API Reference for DescribeConversionTasks Operation</seealso>
        DescribeConversionTasksResponse DescribeConversionTasks(DescribeConversionTasksRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeConversionTasks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeConversionTasks operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeConversionTasks
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeConversionTasks">REST API Reference for DescribeConversionTasks Operation</seealso>
        IAsyncResult BeginDescribeConversionTasks(DescribeConversionTasksRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeConversionTasks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeConversionTasks.</param>
        /// 
        /// <returns>Returns a  DescribeConversionTasksResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeConversionTasks">REST API Reference for DescribeConversionTasks Operation</seealso>
        DescribeConversionTasksResponse EndDescribeConversionTasks(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeCustomerGateways


        /// <summary>
        /// Describes one or more of your VPN customer gateways.
        /// 
        ///  
        /// <para>
        /// For more information about VPN customer gateways, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_VPN.html">AWS
        /// Managed VPN Connections</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeCustomerGateways service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeCustomerGateways">REST API Reference for DescribeCustomerGateways Operation</seealso>
        DescribeCustomerGatewaysResponse DescribeCustomerGateways();

        /// <summary>
        /// Describes one or more of your VPN customer gateways.
        /// 
        ///  
        /// <para>
        /// For more information about VPN customer gateways, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_VPN.html">AWS
        /// Managed VPN Connections</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCustomerGateways service method.</param>
        /// 
        /// <returns>The response from the DescribeCustomerGateways service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeCustomerGateways">REST API Reference for DescribeCustomerGateways Operation</seealso>
        DescribeCustomerGatewaysResponse DescribeCustomerGateways(DescribeCustomerGatewaysRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCustomerGateways operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCustomerGateways operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeCustomerGateways
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeCustomerGateways">REST API Reference for DescribeCustomerGateways Operation</seealso>
        IAsyncResult BeginDescribeCustomerGateways(DescribeCustomerGatewaysRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeCustomerGateways operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCustomerGateways.</param>
        /// 
        /// <returns>Returns a  DescribeCustomerGatewaysResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeCustomerGateways">REST API Reference for DescribeCustomerGateways Operation</seealso>
        DescribeCustomerGatewaysResponse EndDescribeCustomerGateways(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeDhcpOptions


        /// <summary>
        /// Describes one or more of your DHCP options sets.
        /// 
        ///  
        /// <para>
        /// For more information about DHCP options sets, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_DHCP_Options.html">DHCP
        /// Options Sets</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeDhcpOptions service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeDhcpOptions">REST API Reference for DescribeDhcpOptions Operation</seealso>
        DescribeDhcpOptionsResponse DescribeDhcpOptions();

        /// <summary>
        /// Describes one or more of your DHCP options sets.
        /// 
        ///  
        /// <para>
        /// For more information about DHCP options sets, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_DHCP_Options.html">DHCP
        /// Options Sets</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDhcpOptions service method.</param>
        /// 
        /// <returns>The response from the DescribeDhcpOptions service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeDhcpOptions">REST API Reference for DescribeDhcpOptions Operation</seealso>
        DescribeDhcpOptionsResponse DescribeDhcpOptions(DescribeDhcpOptionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDhcpOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDhcpOptions operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeDhcpOptions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeDhcpOptions">REST API Reference for DescribeDhcpOptions Operation</seealso>
        IAsyncResult BeginDescribeDhcpOptions(DescribeDhcpOptionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDhcpOptions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDhcpOptions.</param>
        /// 
        /// <returns>Returns a  DescribeDhcpOptionsResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeDhcpOptions">REST API Reference for DescribeDhcpOptions Operation</seealso>
        DescribeDhcpOptionsResponse EndDescribeDhcpOptions(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeEgressOnlyInternetGateways


        /// <summary>
        /// Describes one or more of your egress-only Internet gateways.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeEgressOnlyInternetGateways service method.</param>
        /// 
        /// <returns>The response from the DescribeEgressOnlyInternetGateways service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeEgressOnlyInternetGateways">REST API Reference for DescribeEgressOnlyInternetGateways Operation</seealso>
        DescribeEgressOnlyInternetGatewaysResponse DescribeEgressOnlyInternetGateways(DescribeEgressOnlyInternetGatewaysRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEgressOnlyInternetGateways operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEgressOnlyInternetGateways operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeEgressOnlyInternetGateways
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeEgressOnlyInternetGateways">REST API Reference for DescribeEgressOnlyInternetGateways Operation</seealso>
        IAsyncResult BeginDescribeEgressOnlyInternetGateways(DescribeEgressOnlyInternetGatewaysRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeEgressOnlyInternetGateways operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeEgressOnlyInternetGateways.</param>
        /// 
        /// <returns>Returns a  DescribeEgressOnlyInternetGatewaysResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeEgressOnlyInternetGateways">REST API Reference for DescribeEgressOnlyInternetGateways Operation</seealso>
        DescribeEgressOnlyInternetGatewaysResponse EndDescribeEgressOnlyInternetGateways(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeElasticGpus


        /// <summary>
        /// Describes the Elastic GPUs associated with your instances. For more information about
        /// Elastic GPUs, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/WindowsGuide/elastic-gpus.html">Amazon
        /// EC2 Elastic GPUs</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeElasticGpus service method.</param>
        /// 
        /// <returns>The response from the DescribeElasticGpus service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeElasticGpus">REST API Reference for DescribeElasticGpus Operation</seealso>
        DescribeElasticGpusResponse DescribeElasticGpus(DescribeElasticGpusRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeElasticGpus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeElasticGpus operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeElasticGpus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeElasticGpus">REST API Reference for DescribeElasticGpus Operation</seealso>
        IAsyncResult BeginDescribeElasticGpus(DescribeElasticGpusRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeElasticGpus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeElasticGpus.</param>
        /// 
        /// <returns>Returns a  DescribeElasticGpusResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeElasticGpus">REST API Reference for DescribeElasticGpus Operation</seealso>
        DescribeElasticGpusResponse EndDescribeElasticGpus(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeExportTasks


        /// <summary>
        /// Describes one or more of your export tasks.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeExportTasks service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeExportTasks">REST API Reference for DescribeExportTasks Operation</seealso>
        DescribeExportTasksResponse DescribeExportTasks();

        /// <summary>
        /// Describes one or more of your export tasks.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeExportTasks service method.</param>
        /// 
        /// <returns>The response from the DescribeExportTasks service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeExportTasks">REST API Reference for DescribeExportTasks Operation</seealso>
        DescribeExportTasksResponse DescribeExportTasks(DescribeExportTasksRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeExportTasks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeExportTasks operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeExportTasks
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeExportTasks">REST API Reference for DescribeExportTasks Operation</seealso>
        IAsyncResult BeginDescribeExportTasks(DescribeExportTasksRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeExportTasks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeExportTasks.</param>
        /// 
        /// <returns>Returns a  DescribeExportTasksResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeExportTasks">REST API Reference for DescribeExportTasks Operation</seealso>
        DescribeExportTasksResponse EndDescribeExportTasks(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeFleetHistory


        /// <summary>
        /// Describes the events for the specified EC2 Fleet during the specified time.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleetHistory service method.</param>
        /// 
        /// <returns>The response from the DescribeFleetHistory service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeFleetHistory">REST API Reference for DescribeFleetHistory Operation</seealso>
        DescribeFleetHistoryResponse DescribeFleetHistory(DescribeFleetHistoryRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeFleetHistory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleetHistory operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeFleetHistory
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeFleetHistory">REST API Reference for DescribeFleetHistory Operation</seealso>
        IAsyncResult BeginDescribeFleetHistory(DescribeFleetHistoryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeFleetHistory operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeFleetHistory.</param>
        /// 
        /// <returns>Returns a  DescribeFleetHistoryResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeFleetHistory">REST API Reference for DescribeFleetHistory Operation</seealso>
        DescribeFleetHistoryResponse EndDescribeFleetHistory(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeFleetInstances


        /// <summary>
        /// Describes the running instances for the specified EC2 Fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleetInstances service method.</param>
        /// 
        /// <returns>The response from the DescribeFleetInstances service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeFleetInstances">REST API Reference for DescribeFleetInstances Operation</seealso>
        DescribeFleetInstancesResponse DescribeFleetInstances(DescribeFleetInstancesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeFleetInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleetInstances operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeFleetInstances
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeFleetInstances">REST API Reference for DescribeFleetInstances Operation</seealso>
        IAsyncResult BeginDescribeFleetInstances(DescribeFleetInstancesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeFleetInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeFleetInstances.</param>
        /// 
        /// <returns>Returns a  DescribeFleetInstancesResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeFleetInstances">REST API Reference for DescribeFleetInstances Operation</seealso>
        DescribeFleetInstancesResponse EndDescribeFleetInstances(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeFleets


        /// <summary>
        /// Describes the specified EC2 Fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleets service method.</param>
        /// 
        /// <returns>The response from the DescribeFleets service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeFleets">REST API Reference for DescribeFleets Operation</seealso>
        DescribeFleetsResponse DescribeFleets(DescribeFleetsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeFleets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleets operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeFleets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeFleets">REST API Reference for DescribeFleets Operation</seealso>
        IAsyncResult BeginDescribeFleets(DescribeFleetsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeFleets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeFleets.</param>
        /// 
        /// <returns>Returns a  DescribeFleetsResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeFleets">REST API Reference for DescribeFleets Operation</seealso>
        DescribeFleetsResponse EndDescribeFleets(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeFlowLogs


        /// <summary>
        /// Describes one or more flow logs. To view the information in your flow logs (the log
        /// streams for the network interfaces), you must use the CloudWatch Logs console or the
        /// CloudWatch Logs API.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFlowLogs service method.</param>
        /// 
        /// <returns>The response from the DescribeFlowLogs service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeFlowLogs">REST API Reference for DescribeFlowLogs Operation</seealso>
        DescribeFlowLogsResponse DescribeFlowLogs(DescribeFlowLogsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeFlowLogs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeFlowLogs operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeFlowLogs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeFlowLogs">REST API Reference for DescribeFlowLogs Operation</seealso>
        IAsyncResult BeginDescribeFlowLogs(DescribeFlowLogsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeFlowLogs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeFlowLogs.</param>
        /// 
        /// <returns>Returns a  DescribeFlowLogsResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeFlowLogs">REST API Reference for DescribeFlowLogs Operation</seealso>
        DescribeFlowLogsResponse EndDescribeFlowLogs(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeFpgaImageAttribute


        /// <summary>
        /// Describes the specified attribute of the specified Amazon FPGA Image (AFI).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFpgaImageAttribute service method.</param>
        /// 
        /// <returns>The response from the DescribeFpgaImageAttribute service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeFpgaImageAttribute">REST API Reference for DescribeFpgaImageAttribute Operation</seealso>
        DescribeFpgaImageAttributeResponse DescribeFpgaImageAttribute(DescribeFpgaImageAttributeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeFpgaImageAttribute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeFpgaImageAttribute operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeFpgaImageAttribute
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeFpgaImageAttribute">REST API Reference for DescribeFpgaImageAttribute Operation</seealso>
        IAsyncResult BeginDescribeFpgaImageAttribute(DescribeFpgaImageAttributeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeFpgaImageAttribute operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeFpgaImageAttribute.</param>
        /// 
        /// <returns>Returns a  DescribeFpgaImageAttributeResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeFpgaImageAttribute">REST API Reference for DescribeFpgaImageAttribute Operation</seealso>
        DescribeFpgaImageAttributeResponse EndDescribeFpgaImageAttribute(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeFpgaImages


        /// <summary>
        /// Describes one or more available Amazon FPGA Images (AFIs). These include public AFIs,
        /// private AFIs that you own, and AFIs owned by other AWS accounts for which you have
        /// load permissions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeFpgaImages service method.</param>
        /// 
        /// <returns>The response from the DescribeFpgaImages service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeFpgaImages">REST API Reference for DescribeFpgaImages Operation</seealso>
        DescribeFpgaImagesResponse DescribeFpgaImages(DescribeFpgaImagesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeFpgaImages operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeFpgaImages operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeFpgaImages
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeFpgaImages">REST API Reference for DescribeFpgaImages Operation</seealso>
        IAsyncResult BeginDescribeFpgaImages(DescribeFpgaImagesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeFpgaImages operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeFpgaImages.</param>
        /// 
        /// <returns>Returns a  DescribeFpgaImagesResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeFpgaImages">REST API Reference for DescribeFpgaImages Operation</seealso>
        DescribeFpgaImagesResponse EndDescribeFpgaImages(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeHostReservationOfferings


        /// <summary>
        /// Describes the Dedicated Host Reservations that are available to purchase.
        /// 
        ///  
        /// <para>
        /// The results describe all the Dedicated Host Reservation offerings, including offerings
        /// that may not match the instance family and region of your Dedicated Hosts. When purchasing
        /// an offering, ensure that the the instance family and region of the offering matches
        /// that of the Dedicated Host/s it will be associated with. For an overview of supported
        /// instance types, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/dedicated-hosts-overview.html">Dedicated
        /// Hosts Overview</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeHostReservationOfferings service method.</param>
        /// 
        /// <returns>The response from the DescribeHostReservationOfferings service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeHostReservationOfferings">REST API Reference for DescribeHostReservationOfferings Operation</seealso>
        DescribeHostReservationOfferingsResponse DescribeHostReservationOfferings(DescribeHostReservationOfferingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeHostReservationOfferings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeHostReservationOfferings operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeHostReservationOfferings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeHostReservationOfferings">REST API Reference for DescribeHostReservationOfferings Operation</seealso>
        IAsyncResult BeginDescribeHostReservationOfferings(DescribeHostReservationOfferingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeHostReservationOfferings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeHostReservationOfferings.</param>
        /// 
        /// <returns>Returns a  DescribeHostReservationOfferingsResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeHostReservationOfferings">REST API Reference for DescribeHostReservationOfferings Operation</seealso>
        DescribeHostReservationOfferingsResponse EndDescribeHostReservationOfferings(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeHostReservations


        /// <summary>
        /// Describes Dedicated Host Reservations which are associated with Dedicated Hosts in
        /// your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeHostReservations service method.</param>
        /// 
        /// <returns>The response from the DescribeHostReservations service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeHostReservations">REST API Reference for DescribeHostReservations Operation</seealso>
        DescribeHostReservationsResponse DescribeHostReservations(DescribeHostReservationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeHostReservations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeHostReservations operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeHostReservations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeHostReservations">REST API Reference for DescribeHostReservations Operation</seealso>
        IAsyncResult BeginDescribeHostReservations(DescribeHostReservationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeHostReservations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeHostReservations.</param>
        /// 
        /// <returns>Returns a  DescribeHostReservationsResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeHostReservations">REST API Reference for DescribeHostReservations Operation</seealso>
        DescribeHostReservationsResponse EndDescribeHostReservations(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeHosts


        /// <summary>
        /// Describes one or more of your Dedicated Hosts.
        /// 
        ///  
        /// <para>
        /// The results describe only the Dedicated Hosts in the region you're currently using.
        /// All listed instances consume capacity on your Dedicated Host. Dedicated Hosts that
        /// have recently been released will be listed with the state <code>released</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeHosts service method.</param>
        /// 
        /// <returns>The response from the DescribeHosts service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeHosts">REST API Reference for DescribeHosts Operation</seealso>
        DescribeHostsResponse DescribeHosts(DescribeHostsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeHosts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeHosts operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeHosts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeHosts">REST API Reference for DescribeHosts Operation</seealso>
        IAsyncResult BeginDescribeHosts(DescribeHostsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeHosts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeHosts.</param>
        /// 
        /// <returns>Returns a  DescribeHostsResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeHosts">REST API Reference for DescribeHosts Operation</seealso>
        DescribeHostsResponse EndDescribeHosts(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeIamInstanceProfileAssociations


        /// <summary>
        /// Describes your IAM instance profile associations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeIamInstanceProfileAssociations service method.</param>
        /// 
        /// <returns>The response from the DescribeIamInstanceProfileAssociations service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeIamInstanceProfileAssociations">REST API Reference for DescribeIamInstanceProfileAssociations Operation</seealso>
        DescribeIamInstanceProfileAssociationsResponse DescribeIamInstanceProfileAssociations(DescribeIamInstanceProfileAssociationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeIamInstanceProfileAssociations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeIamInstanceProfileAssociations operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeIamInstanceProfileAssociations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeIamInstanceProfileAssociations">REST API Reference for DescribeIamInstanceProfileAssociations Operation</seealso>
        IAsyncResult BeginDescribeIamInstanceProfileAssociations(DescribeIamInstanceProfileAssociationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeIamInstanceProfileAssociations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeIamInstanceProfileAssociations.</param>
        /// 
        /// <returns>Returns a  DescribeIamInstanceProfileAssociationsResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeIamInstanceProfileAssociations">REST API Reference for DescribeIamInstanceProfileAssociations Operation</seealso>
        DescribeIamInstanceProfileAssociationsResponse EndDescribeIamInstanceProfileAssociations(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeIdentityIdFormat


        /// <summary>
        /// Describes the ID format settings for resources for the specified IAM user, IAM role,
        /// or root user. For example, you can view the resource types that are enabled for longer
        /// IDs. This request only returns information about resource types whose ID formats can
        /// be modified; it does not return information about other resource types. For more information,
        /// see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/resource-ids.html">Resource
        /// IDs</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>. 
        /// 
        ///  
        /// <para>
        /// The following resource types support longer IDs: <code>bundle</code> | <code>conversion-task</code>
        /// | <code>customer-gateway</code> | <code>dhcp-options</code> | <code>elastic-ip-allocation</code>
        /// | <code>elastic-ip-association</code> | <code>export-task</code> | <code>flow-log</code>
        /// | <code>image</code> | <code>import-task</code> | <code>instance</code> | <code>internet-gateway</code>
        /// | <code>network-acl</code> | <code>network-acl-association</code> | <code>network-interface</code>
        /// | <code>network-interface-attachment</code> | <code>prefix-list</code> | <code>reservation</code>
        /// | <code>route-table</code> | <code>route-table-association</code> | <code>security-group</code>
        /// | <code>snapshot</code> | <code>subnet</code> | <code>subnet-cidr-block-association</code>
        /// | <code>volume</code> | <code>vpc</code> | <code>vpc-cidr-block-association</code>
        /// | <code>vpc-endpoint</code> | <code>vpc-peering-connection</code> | <code>vpn-connection</code>
        /// | <code>vpn-gateway</code>. 
        /// </para>
        ///  
        /// <para>
        /// These settings apply to the principal specified in the request. They do not apply
        /// to the principal that makes the request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeIdentityIdFormat service method.</param>
        /// 
        /// <returns>The response from the DescribeIdentityIdFormat service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeIdentityIdFormat">REST API Reference for DescribeIdentityIdFormat Operation</seealso>
        DescribeIdentityIdFormatResponse DescribeIdentityIdFormat(DescribeIdentityIdFormatRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeIdentityIdFormat operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeIdentityIdFormat operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeIdentityIdFormat
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeIdentityIdFormat">REST API Reference for DescribeIdentityIdFormat Operation</seealso>
        IAsyncResult BeginDescribeIdentityIdFormat(DescribeIdentityIdFormatRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeIdentityIdFormat operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeIdentityIdFormat.</param>
        /// 
        /// <returns>Returns a  DescribeIdentityIdFormatResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeIdentityIdFormat">REST API Reference for DescribeIdentityIdFormat Operation</seealso>
        DescribeIdentityIdFormatResponse EndDescribeIdentityIdFormat(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeIdFormat


        /// <summary>
        /// Describes the ID format settings for your resources on a per-region basis, for example,
        /// to view which resource types are enabled for longer IDs. This request only returns
        /// information about resource types whose ID formats can be modified; it does not return
        /// information about other resource types.
        /// 
        ///  
        /// <para>
        /// The following resource types support longer IDs: <code>bundle</code> | <code>conversion-task</code>
        /// | <code>customer-gateway</code> | <code>dhcp-options</code> | <code>elastic-ip-allocation</code>
        /// | <code>elastic-ip-association</code> | <code>export-task</code> | <code>flow-log</code>
        /// | <code>image</code> | <code>import-task</code> | <code>instance</code> | <code>internet-gateway</code>
        /// | <code>network-acl</code> | <code>network-acl-association</code> | <code>network-interface</code>
        /// | <code>network-interface-attachment</code> | <code>prefix-list</code> | <code>reservation</code>
        /// | <code>route-table</code> | <code>route-table-association</code> | <code>security-group</code>
        /// | <code>snapshot</code> | <code>subnet</code> | <code>subnet-cidr-block-association</code>
        /// | <code>volume</code> | <code>vpc</code> | <code>vpc-cidr-block-association</code>
        /// | <code>vpc-endpoint</code> | <code>vpc-peering-connection</code> | <code>vpn-connection</code>
        /// | <code>vpn-gateway</code>. 
        /// </para>
        ///  
        /// <para>
        /// These settings apply to the IAM user who makes the request; they do not apply to the
        /// entire AWS account. By default, an IAM user defaults to the same settings as the root
        /// user, unless they explicitly override the settings by running the <a>ModifyIdFormat</a>
        /// command. Resources created with longer IDs are visible to all IAM users, regardless
        /// of these settings and provided that they have permission to use the relevant <code>Describe</code>
        /// command for the resource type.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeIdFormat service method.</param>
        /// 
        /// <returns>The response from the DescribeIdFormat service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeIdFormat">REST API Reference for DescribeIdFormat Operation</seealso>
        DescribeIdFormatResponse DescribeIdFormat(DescribeIdFormatRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeIdFormat operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeIdFormat operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeIdFormat
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeIdFormat">REST API Reference for DescribeIdFormat Operation</seealso>
        IAsyncResult BeginDescribeIdFormat(DescribeIdFormatRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeIdFormat operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeIdFormat.</param>
        /// 
        /// <returns>Returns a  DescribeIdFormatResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeIdFormat">REST API Reference for DescribeIdFormat Operation</seealso>
        DescribeIdFormatResponse EndDescribeIdFormat(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeImageAttribute


        /// <summary>
        /// Describes the specified attribute of the specified AMI. You can specify only one attribute
        /// at a time.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeImageAttribute service method.</param>
        /// 
        /// <returns>The response from the DescribeImageAttribute service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeImageAttribute">REST API Reference for DescribeImageAttribute Operation</seealso>
        DescribeImageAttributeResponse DescribeImageAttribute(DescribeImageAttributeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeImageAttribute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeImageAttribute operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeImageAttribute
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeImageAttribute">REST API Reference for DescribeImageAttribute Operation</seealso>
        IAsyncResult BeginDescribeImageAttribute(DescribeImageAttributeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeImageAttribute operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeImageAttribute.</param>
        /// 
        /// <returns>Returns a  DescribeImageAttributeResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeImageAttribute">REST API Reference for DescribeImageAttribute Operation</seealso>
        DescribeImageAttributeResponse EndDescribeImageAttribute(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeImages


        /// <summary>
        /// Describes one or more of the images (AMIs, AKIs, and ARIs) available to you. Images
        /// available to you include public images, private images that you own, and private images
        /// owned by other AWS accounts but for which you have explicit launch permissions.
        /// 
        ///  <note> 
        /// <para>
        /// Deregistered images are included in the returned results for an unspecified interval
        /// after deregistration.
        /// </para>
        ///  </note>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeImages service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeImages">REST API Reference for DescribeImages Operation</seealso>
        DescribeImagesResponse DescribeImages();

        /// <summary>
        /// Describes one or more of the images (AMIs, AKIs, and ARIs) available to you. Images
        /// available to you include public images, private images that you own, and private images
        /// owned by other AWS accounts but for which you have explicit launch permissions.
        /// 
        ///  <note> 
        /// <para>
        /// Deregistered images are included in the returned results for an unspecified interval
        /// after deregistration.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeImages service method.</param>
        /// 
        /// <returns>The response from the DescribeImages service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeImages">REST API Reference for DescribeImages Operation</seealso>
        DescribeImagesResponse DescribeImages(DescribeImagesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeImages operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeImages operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeImages
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeImages">REST API Reference for DescribeImages Operation</seealso>
        IAsyncResult BeginDescribeImages(DescribeImagesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeImages operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeImages.</param>
        /// 
        /// <returns>Returns a  DescribeImagesResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeImages">REST API Reference for DescribeImages Operation</seealso>
        DescribeImagesResponse EndDescribeImages(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeImportImageTasks


        /// <summary>
        /// Displays details about an import virtual machine or import snapshot tasks that are
        /// already created.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeImportImageTasks service method.</param>
        /// 
        /// <returns>The response from the DescribeImportImageTasks service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeImportImageTasks">REST API Reference for DescribeImportImageTasks Operation</seealso>
        DescribeImportImageTasksResponse DescribeImportImageTasks(DescribeImportImageTasksRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeImportImageTasks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeImportImageTasks operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeImportImageTasks
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeImportImageTasks">REST API Reference for DescribeImportImageTasks Operation</seealso>
        IAsyncResult BeginDescribeImportImageTasks(DescribeImportImageTasksRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeImportImageTasks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeImportImageTasks.</param>
        /// 
        /// <returns>Returns a  DescribeImportImageTasksResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeImportImageTasks">REST API Reference for DescribeImportImageTasks Operation</seealso>
        DescribeImportImageTasksResponse EndDescribeImportImageTasks(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeImportSnapshotTasks


        /// <summary>
        /// Describes your import snapshot tasks.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeImportSnapshotTasks service method.</param>
        /// 
        /// <returns>The response from the DescribeImportSnapshotTasks service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeImportSnapshotTasks">REST API Reference for DescribeImportSnapshotTasks Operation</seealso>
        DescribeImportSnapshotTasksResponse DescribeImportSnapshotTasks(DescribeImportSnapshotTasksRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeImportSnapshotTasks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeImportSnapshotTasks operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeImportSnapshotTasks
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeImportSnapshotTasks">REST API Reference for DescribeImportSnapshotTasks Operation</seealso>
        IAsyncResult BeginDescribeImportSnapshotTasks(DescribeImportSnapshotTasksRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeImportSnapshotTasks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeImportSnapshotTasks.</param>
        /// 
        /// <returns>Returns a  DescribeImportSnapshotTasksResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeImportSnapshotTasks">REST API Reference for DescribeImportSnapshotTasks Operation</seealso>
        DescribeImportSnapshotTasksResponse EndDescribeImportSnapshotTasks(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeInstanceAttribute


        /// <summary>
        /// Describes the specified attribute of the specified instance. You can specify only
        /// one attribute at a time. Valid attribute values are: <code>instanceType</code> | <code>kernel</code>
        /// | <code>ramdisk</code> | <code>userData</code> | <code>disableApiTermination</code>
        /// | <code>instanceInitiatedShutdownBehavior</code> | <code>rootDeviceName</code> | <code>blockDeviceMapping</code>
        /// | <code>productCodes</code> | <code>sourceDestCheck</code> | <code>groupSet</code>
        /// | <code>ebsOptimized</code> | <code>sriovNetSupport</code>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstanceAttribute service method.</param>
        /// 
        /// <returns>The response from the DescribeInstanceAttribute service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeInstanceAttribute">REST API Reference for DescribeInstanceAttribute Operation</seealso>
        DescribeInstanceAttributeResponse DescribeInstanceAttribute(DescribeInstanceAttributeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInstanceAttribute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstanceAttribute operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeInstanceAttribute
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeInstanceAttribute">REST API Reference for DescribeInstanceAttribute Operation</seealso>
        IAsyncResult BeginDescribeInstanceAttribute(DescribeInstanceAttributeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeInstanceAttribute operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeInstanceAttribute.</param>
        /// 
        /// <returns>Returns a  DescribeInstanceAttributeResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeInstanceAttribute">REST API Reference for DescribeInstanceAttribute Operation</seealso>
        DescribeInstanceAttributeResponse EndDescribeInstanceAttribute(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeInstanceCreditSpecifications


        /// <summary>
        /// Describes the credit option for CPU usage of one or more of your T2 instances. The
        /// credit options are <code>standard</code> and <code>unlimited</code>.
        /// 
        ///  
        /// <para>
        /// If you do not specify an instance ID, Amazon EC2 returns only the T2 instances with
        /// the <code>unlimited</code> credit option. If you specify one or more instance IDs,
        /// Amazon EC2 returns the credit option (<code>standard</code> or <code>unlimited</code>)
        /// of those instances. If you specify an instance ID that is not valid, such as an instance
        /// that is not a T2 instance, an error is returned.
        /// </para>
        ///  
        /// <para>
        /// Recently terminated instances might appear in the returned results. This interval
        /// is usually less than one hour.
        /// </para>
        ///  
        /// <para>
        /// If an Availability Zone is experiencing a service disruption and you specify instance
        /// IDs in the affected zone, or do not specify any instance IDs at all, the call fails.
        /// If you specify only instance IDs in an unaffected zone, the call works normally.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/t2-instances.html">T2
        /// Instances</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstanceCreditSpecifications service method.</param>
        /// 
        /// <returns>The response from the DescribeInstanceCreditSpecifications service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeInstanceCreditSpecifications">REST API Reference for DescribeInstanceCreditSpecifications Operation</seealso>
        DescribeInstanceCreditSpecificationsResponse DescribeInstanceCreditSpecifications(DescribeInstanceCreditSpecificationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInstanceCreditSpecifications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstanceCreditSpecifications operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeInstanceCreditSpecifications
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeInstanceCreditSpecifications">REST API Reference for DescribeInstanceCreditSpecifications Operation</seealso>
        IAsyncResult BeginDescribeInstanceCreditSpecifications(DescribeInstanceCreditSpecificationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeInstanceCreditSpecifications operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeInstanceCreditSpecifications.</param>
        /// 
        /// <returns>Returns a  DescribeInstanceCreditSpecificationsResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeInstanceCreditSpecifications">REST API Reference for DescribeInstanceCreditSpecifications Operation</seealso>
        DescribeInstanceCreditSpecificationsResponse EndDescribeInstanceCreditSpecifications(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeInstances


        /// <summary>
        /// Describes one or more of your instances.
        /// 
        ///  
        /// <para>
        /// If you specify one or more instance IDs, Amazon EC2 returns information for those
        /// instances. If you do not specify instance IDs, Amazon EC2 returns information for
        /// all relevant instances. If you specify an instance ID that is not valid, an error
        /// is returned. If you specify an instance that you do not own, it is not included in
        /// the returned results.
        /// </para>
        ///  
        /// <para>
        /// Recently terminated instances might appear in the returned results. This interval
        /// is usually less than one hour.
        /// </para>
        ///  
        /// <para>
        /// If you describe instances in the rare case where an Availability Zone is experiencing
        /// a service disruption and you specify instance IDs that are in the affected zone, or
        /// do not specify any instance IDs at all, the call fails. If you describe instances
        /// and specify only instance IDs that are in an unaffected zone, the call works normally.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeInstances service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeInstances">REST API Reference for DescribeInstances Operation</seealso>
        DescribeInstancesResponse DescribeInstances();

        /// <summary>
        /// Describes one or more of your instances.
        /// 
        ///  
        /// <para>
        /// If you specify one or more instance IDs, Amazon EC2 returns information for those
        /// instances. If you do not specify instance IDs, Amazon EC2 returns information for
        /// all relevant instances. If you specify an instance ID that is not valid, an error
        /// is returned. If you specify an instance that you do not own, it is not included in
        /// the returned results.
        /// </para>
        ///  
        /// <para>
        /// Recently terminated instances might appear in the returned results. This interval
        /// is usually less than one hour.
        /// </para>
        ///  
        /// <para>
        /// If you describe instances in the rare case where an Availability Zone is experiencing
        /// a service disruption and you specify instance IDs that are in the affected zone, or
        /// do not specify any instance IDs at all, the call fails. If you describe instances
        /// and specify only instance IDs that are in an unaffected zone, the call works normally.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstances service method.</param>
        /// 
        /// <returns>The response from the DescribeInstances service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeInstances">REST API Reference for DescribeInstances Operation</seealso>
        DescribeInstancesResponse DescribeInstances(DescribeInstancesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstances operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeInstances
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeInstances">REST API Reference for DescribeInstances Operation</seealso>
        IAsyncResult BeginDescribeInstances(DescribeInstancesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeInstances.</param>
        /// 
        /// <returns>Returns a  DescribeInstancesResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeInstances">REST API Reference for DescribeInstances Operation</seealso>
        DescribeInstancesResponse EndDescribeInstances(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeInstanceStatus


        /// <summary>
        /// Describes the status of one or more instances. By default, only running instances
        /// are described, unless you specifically indicate to return the status of all instances.
        /// 
        ///  
        /// <para>
        /// Instance status includes the following components:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Status checks</b> - Amazon EC2 performs status checks on running EC2 instances
        /// to identify hardware and software issues. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/monitoring-system-instance-status-check.html">Status
        /// Checks for Your Instances</a> and <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/TroubleshootingInstances.html">Troubleshooting
        /// Instances with Failed Status Checks</a> in the <i>Amazon Elastic Compute Cloud User
        /// Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Scheduled events</b> - Amazon EC2 can schedule events (such as reboot, stop, or
        /// terminate) for your instances related to hardware issues, software updates, or system
        /// maintenance. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/monitoring-instances-status-check_sched.html">Scheduled
        /// Events for Your Instances</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Instance state</b> - You can manage your instances from the moment you launch
        /// them through their termination. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-instance-lifecycle.html">Instance
        /// Lifecycle</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeInstanceStatus service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeInstanceStatus">REST API Reference for DescribeInstanceStatus Operation</seealso>
        DescribeInstanceStatusResponse DescribeInstanceStatus();

        /// <summary>
        /// Describes the status of one or more instances. By default, only running instances
        /// are described, unless you specifically indicate to return the status of all instances.
        /// 
        ///  
        /// <para>
        /// Instance status includes the following components:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <b>Status checks</b> - Amazon EC2 performs status checks on running EC2 instances
        /// to identify hardware and software issues. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/monitoring-system-instance-status-check.html">Status
        /// Checks for Your Instances</a> and <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/TroubleshootingInstances.html">Troubleshooting
        /// Instances with Failed Status Checks</a> in the <i>Amazon Elastic Compute Cloud User
        /// Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Scheduled events</b> - Amazon EC2 can schedule events (such as reboot, stop, or
        /// terminate) for your instances related to hardware issues, software updates, or system
        /// maintenance. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/monitoring-instances-status-check_sched.html">Scheduled
        /// Events for Your Instances</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Instance state</b> - You can manage your instances from the moment you launch
        /// them through their termination. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-instance-lifecycle.html">Instance
        /// Lifecycle</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstanceStatus service method.</param>
        /// 
        /// <returns>The response from the DescribeInstanceStatus service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeInstanceStatus">REST API Reference for DescribeInstanceStatus Operation</seealso>
        DescribeInstanceStatusResponse DescribeInstanceStatus(DescribeInstanceStatusRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInstanceStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstanceStatus operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeInstanceStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeInstanceStatus">REST API Reference for DescribeInstanceStatus Operation</seealso>
        IAsyncResult BeginDescribeInstanceStatus(DescribeInstanceStatusRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeInstanceStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeInstanceStatus.</param>
        /// 
        /// <returns>Returns a  DescribeInstanceStatusResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeInstanceStatus">REST API Reference for DescribeInstanceStatus Operation</seealso>
        DescribeInstanceStatusResponse EndDescribeInstanceStatus(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeInternetGateways


        /// <summary>
        /// Describes one or more of your Internet gateways.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeInternetGateways service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeInternetGateways">REST API Reference for DescribeInternetGateways Operation</seealso>
        DescribeInternetGatewaysResponse DescribeInternetGateways();

        /// <summary>
        /// Describes one or more of your Internet gateways.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInternetGateways service method.</param>
        /// 
        /// <returns>The response from the DescribeInternetGateways service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeInternetGateways">REST API Reference for DescribeInternetGateways Operation</seealso>
        DescribeInternetGatewaysResponse DescribeInternetGateways(DescribeInternetGatewaysRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInternetGateways operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInternetGateways operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeInternetGateways
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeInternetGateways">REST API Reference for DescribeInternetGateways Operation</seealso>
        IAsyncResult BeginDescribeInternetGateways(DescribeInternetGatewaysRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeInternetGateways operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeInternetGateways.</param>
        /// 
        /// <returns>Returns a  DescribeInternetGatewaysResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeInternetGateways">REST API Reference for DescribeInternetGateways Operation</seealso>
        DescribeInternetGatewaysResponse EndDescribeInternetGateways(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeKeyPairs


        /// <summary>
        /// Describes one or more of your key pairs.
        /// 
        ///  
        /// <para>
        /// For more information about key pairs, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-key-pairs.html">Key
        /// Pairs</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeKeyPairs service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeKeyPairs">REST API Reference for DescribeKeyPairs Operation</seealso>
        DescribeKeyPairsResponse DescribeKeyPairs();

        /// <summary>
        /// Describes one or more of your key pairs.
        /// 
        ///  
        /// <para>
        /// For more information about key pairs, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-key-pairs.html">Key
        /// Pairs</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeKeyPairs service method.</param>
        /// 
        /// <returns>The response from the DescribeKeyPairs service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeKeyPairs">REST API Reference for DescribeKeyPairs Operation</seealso>
        DescribeKeyPairsResponse DescribeKeyPairs(DescribeKeyPairsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeKeyPairs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeKeyPairs operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeKeyPairs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeKeyPairs">REST API Reference for DescribeKeyPairs Operation</seealso>
        IAsyncResult BeginDescribeKeyPairs(DescribeKeyPairsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeKeyPairs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeKeyPairs.</param>
        /// 
        /// <returns>Returns a  DescribeKeyPairsResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeKeyPairs">REST API Reference for DescribeKeyPairs Operation</seealso>
        DescribeKeyPairsResponse EndDescribeKeyPairs(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeLaunchTemplates


        /// <summary>
        /// Describes one or more launch templates.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLaunchTemplates service method.</param>
        /// 
        /// <returns>The response from the DescribeLaunchTemplates service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeLaunchTemplates">REST API Reference for DescribeLaunchTemplates Operation</seealso>
        DescribeLaunchTemplatesResponse DescribeLaunchTemplates(DescribeLaunchTemplatesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLaunchTemplates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLaunchTemplates operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeLaunchTemplates
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeLaunchTemplates">REST API Reference for DescribeLaunchTemplates Operation</seealso>
        IAsyncResult BeginDescribeLaunchTemplates(DescribeLaunchTemplatesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeLaunchTemplates operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeLaunchTemplates.</param>
        /// 
        /// <returns>Returns a  DescribeLaunchTemplatesResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeLaunchTemplates">REST API Reference for DescribeLaunchTemplates Operation</seealso>
        DescribeLaunchTemplatesResponse EndDescribeLaunchTemplates(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeLaunchTemplateVersions


        /// <summary>
        /// Describes one or more versions of a specified launch template. You can describe all
        /// versions, individual versions, or a range of versions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLaunchTemplateVersions service method.</param>
        /// 
        /// <returns>The response from the DescribeLaunchTemplateVersions service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeLaunchTemplateVersions">REST API Reference for DescribeLaunchTemplateVersions Operation</seealso>
        DescribeLaunchTemplateVersionsResponse DescribeLaunchTemplateVersions(DescribeLaunchTemplateVersionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLaunchTemplateVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLaunchTemplateVersions operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeLaunchTemplateVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeLaunchTemplateVersions">REST API Reference for DescribeLaunchTemplateVersions Operation</seealso>
        IAsyncResult BeginDescribeLaunchTemplateVersions(DescribeLaunchTemplateVersionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeLaunchTemplateVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeLaunchTemplateVersions.</param>
        /// 
        /// <returns>Returns a  DescribeLaunchTemplateVersionsResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeLaunchTemplateVersions">REST API Reference for DescribeLaunchTemplateVersions Operation</seealso>
        DescribeLaunchTemplateVersionsResponse EndDescribeLaunchTemplateVersions(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeMovingAddresses


        /// <summary>
        /// Describes your Elastic IP addresses that are being moved to the EC2-VPC platform,
        /// or that are being restored to the EC2-Classic platform. This request does not return
        /// information about any other Elastic IP addresses in your account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeMovingAddresses service method.</param>
        /// 
        /// <returns>The response from the DescribeMovingAddresses service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeMovingAddresses">REST API Reference for DescribeMovingAddresses Operation</seealso>
        DescribeMovingAddressesResponse DescribeMovingAddresses(DescribeMovingAddressesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeMovingAddresses operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeMovingAddresses operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeMovingAddresses
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeMovingAddresses">REST API Reference for DescribeMovingAddresses Operation</seealso>
        IAsyncResult BeginDescribeMovingAddresses(DescribeMovingAddressesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeMovingAddresses operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeMovingAddresses.</param>
        /// 
        /// <returns>Returns a  DescribeMovingAddressesResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeMovingAddresses">REST API Reference for DescribeMovingAddresses Operation</seealso>
        DescribeMovingAddressesResponse EndDescribeMovingAddresses(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeNatGateways


        /// <summary>
        /// Describes one or more of the your NAT gateways.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeNatGateways service method.</param>
        /// 
        /// <returns>The response from the DescribeNatGateways service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeNatGateways">REST API Reference for DescribeNatGateways Operation</seealso>
        DescribeNatGatewaysResponse DescribeNatGateways(DescribeNatGatewaysRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeNatGateways operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeNatGateways operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeNatGateways
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeNatGateways">REST API Reference for DescribeNatGateways Operation</seealso>
        IAsyncResult BeginDescribeNatGateways(DescribeNatGatewaysRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeNatGateways operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeNatGateways.</param>
        /// 
        /// <returns>Returns a  DescribeNatGatewaysResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeNatGateways">REST API Reference for DescribeNatGateways Operation</seealso>
        DescribeNatGatewaysResponse EndDescribeNatGateways(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeNetworkAcls


        /// <summary>
        /// Describes one or more of your network ACLs.
        /// 
        ///  
        /// <para>
        /// For more information about network ACLs, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_ACLs.html">Network
        /// ACLs</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeNetworkAcls service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeNetworkAcls">REST API Reference for DescribeNetworkAcls Operation</seealso>
        DescribeNetworkAclsResponse DescribeNetworkAcls();

        /// <summary>
        /// Describes one or more of your network ACLs.
        /// 
        ///  
        /// <para>
        /// For more information about network ACLs, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_ACLs.html">Network
        /// ACLs</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeNetworkAcls service method.</param>
        /// 
        /// <returns>The response from the DescribeNetworkAcls service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeNetworkAcls">REST API Reference for DescribeNetworkAcls Operation</seealso>
        DescribeNetworkAclsResponse DescribeNetworkAcls(DescribeNetworkAclsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeNetworkAcls operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeNetworkAcls operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeNetworkAcls
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeNetworkAcls">REST API Reference for DescribeNetworkAcls Operation</seealso>
        IAsyncResult BeginDescribeNetworkAcls(DescribeNetworkAclsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeNetworkAcls operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeNetworkAcls.</param>
        /// 
        /// <returns>Returns a  DescribeNetworkAclsResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeNetworkAcls">REST API Reference for DescribeNetworkAcls Operation</seealso>
        DescribeNetworkAclsResponse EndDescribeNetworkAcls(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeNetworkInterfaceAttribute


        /// <summary>
        /// Describes a network interface attribute. You can specify only one attribute at a time.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeNetworkInterfaceAttribute service method.</param>
        /// 
        /// <returns>The response from the DescribeNetworkInterfaceAttribute service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeNetworkInterfaceAttribute">REST API Reference for DescribeNetworkInterfaceAttribute Operation</seealso>
        DescribeNetworkInterfaceAttributeResponse DescribeNetworkInterfaceAttribute(DescribeNetworkInterfaceAttributeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeNetworkInterfaceAttribute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeNetworkInterfaceAttribute operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeNetworkInterfaceAttribute
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeNetworkInterfaceAttribute">REST API Reference for DescribeNetworkInterfaceAttribute Operation</seealso>
        IAsyncResult BeginDescribeNetworkInterfaceAttribute(DescribeNetworkInterfaceAttributeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeNetworkInterfaceAttribute operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeNetworkInterfaceAttribute.</param>
        /// 
        /// <returns>Returns a  DescribeNetworkInterfaceAttributeResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeNetworkInterfaceAttribute">REST API Reference for DescribeNetworkInterfaceAttribute Operation</seealso>
        DescribeNetworkInterfaceAttributeResponse EndDescribeNetworkInterfaceAttribute(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeNetworkInterfacePermissions


        /// <summary>
        /// Describes the permissions for your network interfaces.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeNetworkInterfacePermissions service method.</param>
        /// 
        /// <returns>The response from the DescribeNetworkInterfacePermissions service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeNetworkInterfacePermissions">REST API Reference for DescribeNetworkInterfacePermissions Operation</seealso>
        DescribeNetworkInterfacePermissionsResponse DescribeNetworkInterfacePermissions(DescribeNetworkInterfacePermissionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeNetworkInterfacePermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeNetworkInterfacePermissions operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeNetworkInterfacePermissions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeNetworkInterfacePermissions">REST API Reference for DescribeNetworkInterfacePermissions Operation</seealso>
        IAsyncResult BeginDescribeNetworkInterfacePermissions(DescribeNetworkInterfacePermissionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeNetworkInterfacePermissions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeNetworkInterfacePermissions.</param>
        /// 
        /// <returns>Returns a  DescribeNetworkInterfacePermissionsResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeNetworkInterfacePermissions">REST API Reference for DescribeNetworkInterfacePermissions Operation</seealso>
        DescribeNetworkInterfacePermissionsResponse EndDescribeNetworkInterfacePermissions(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeNetworkInterfaces


        /// <summary>
        /// Describes one or more of your network interfaces.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeNetworkInterfaces service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeNetworkInterfaces">REST API Reference for DescribeNetworkInterfaces Operation</seealso>
        DescribeNetworkInterfacesResponse DescribeNetworkInterfaces();

        /// <summary>
        /// Describes one or more of your network interfaces.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeNetworkInterfaces service method.</param>
        /// 
        /// <returns>The response from the DescribeNetworkInterfaces service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeNetworkInterfaces">REST API Reference for DescribeNetworkInterfaces Operation</seealso>
        DescribeNetworkInterfacesResponse DescribeNetworkInterfaces(DescribeNetworkInterfacesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeNetworkInterfaces operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeNetworkInterfaces operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeNetworkInterfaces
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeNetworkInterfaces">REST API Reference for DescribeNetworkInterfaces Operation</seealso>
        IAsyncResult BeginDescribeNetworkInterfaces(DescribeNetworkInterfacesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeNetworkInterfaces operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeNetworkInterfaces.</param>
        /// 
        /// <returns>Returns a  DescribeNetworkInterfacesResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeNetworkInterfaces">REST API Reference for DescribeNetworkInterfaces Operation</seealso>
        DescribeNetworkInterfacesResponse EndDescribeNetworkInterfaces(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribePlacementGroups


        /// <summary>
        /// Describes one or more of your placement groups. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/placement-groups.html">Placement
        /// Groups</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </summary>
        /// 
        /// <returns>The response from the DescribePlacementGroups service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribePlacementGroups">REST API Reference for DescribePlacementGroups Operation</seealso>
        DescribePlacementGroupsResponse DescribePlacementGroups();

        /// <summary>
        /// Describes one or more of your placement groups. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/placement-groups.html">Placement
        /// Groups</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePlacementGroups service method.</param>
        /// 
        /// <returns>The response from the DescribePlacementGroups service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribePlacementGroups">REST API Reference for DescribePlacementGroups Operation</seealso>
        DescribePlacementGroupsResponse DescribePlacementGroups(DescribePlacementGroupsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribePlacementGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePlacementGroups operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribePlacementGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribePlacementGroups">REST API Reference for DescribePlacementGroups Operation</seealso>
        IAsyncResult BeginDescribePlacementGroups(DescribePlacementGroupsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribePlacementGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribePlacementGroups.</param>
        /// 
        /// <returns>Returns a  DescribePlacementGroupsResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribePlacementGroups">REST API Reference for DescribePlacementGroups Operation</seealso>
        DescribePlacementGroupsResponse EndDescribePlacementGroups(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribePrefixLists


        /// <summary>
        /// Describes available AWS services in a prefix list format, which includes the prefix
        /// list name and prefix list ID of the service and the IP address range for the service.
        /// A prefix list ID is required for creating an outbound security group rule that allows
        /// traffic from a VPC to access an AWS service through a gateway VPC endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePrefixLists service method.</param>
        /// 
        /// <returns>The response from the DescribePrefixLists service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribePrefixLists">REST API Reference for DescribePrefixLists Operation</seealso>
        DescribePrefixListsResponse DescribePrefixLists(DescribePrefixListsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribePrefixLists operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePrefixLists operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribePrefixLists
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribePrefixLists">REST API Reference for DescribePrefixLists Operation</seealso>
        IAsyncResult BeginDescribePrefixLists(DescribePrefixListsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribePrefixLists operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribePrefixLists.</param>
        /// 
        /// <returns>Returns a  DescribePrefixListsResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribePrefixLists">REST API Reference for DescribePrefixLists Operation</seealso>
        DescribePrefixListsResponse EndDescribePrefixLists(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribePrincipalIdFormat


        /// <summary>
        /// Describes the ID format settings for the root user and all IAM roles and IAM users
        /// that have explicitly specified a longer ID (17-character ID) preference. 
        /// 
        ///  
        /// <para>
        /// By default, all IAM roles and IAM users default to the same ID settings as the root
        /// user, unless they explicitly override the settings. This request is useful for identifying
        /// those IAM users and IAM roles that have overridden the default ID settings.
        /// </para>
        ///  
        /// <para>
        /// The following resource types support longer IDs: <code>bundle</code> | <code>conversion-task</code>
        /// | <code>customer-gateway</code> | <code>dhcp-options</code> | <code>elastic-ip-allocation</code>
        /// | <code>elastic-ip-association</code> | <code>export-task</code> | <code>flow-log</code>
        /// | <code>image</code> | <code>import-task</code> | <code>instance</code> | <code>internet-gateway</code>
        /// | <code>network-acl</code> | <code>network-acl-association</code> | <code>network-interface</code>
        /// | <code>network-interface-attachment</code> | <code>prefix-list</code> | <code>reservation</code>
        /// | <code>route-table</code> | <code>route-table-association</code> | <code>security-group</code>
        /// | <code>snapshot</code> | <code>subnet</code> | <code>subnet-cidr-block-association</code>
        /// | <code>volume</code> | <code>vpc</code> | <code>vpc-cidr-block-association</code>
        /// | <code>vpc-endpoint</code> | <code>vpc-peering-connection</code> | <code>vpn-connection</code>
        /// | <code>vpn-gateway</code>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePrincipalIdFormat service method.</param>
        /// 
        /// <returns>The response from the DescribePrincipalIdFormat service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribePrincipalIdFormat">REST API Reference for DescribePrincipalIdFormat Operation</seealso>
        DescribePrincipalIdFormatResponse DescribePrincipalIdFormat(DescribePrincipalIdFormatRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribePrincipalIdFormat operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePrincipalIdFormat operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribePrincipalIdFormat
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribePrincipalIdFormat">REST API Reference for DescribePrincipalIdFormat Operation</seealso>
        IAsyncResult BeginDescribePrincipalIdFormat(DescribePrincipalIdFormatRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribePrincipalIdFormat operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribePrincipalIdFormat.</param>
        /// 
        /// <returns>Returns a  DescribePrincipalIdFormatResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribePrincipalIdFormat">REST API Reference for DescribePrincipalIdFormat Operation</seealso>
        DescribePrincipalIdFormatResponse EndDescribePrincipalIdFormat(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeRegions


        /// <summary>
        /// Describes one or more regions that are currently available to you.
        /// 
        ///  
        /// <para>
        /// For a list of the regions supported by Amazon EC2, see <a href="http://docs.aws.amazon.com/general/latest/gr/rande.html#ec2_region">Regions
        /// and Endpoints</a>.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeRegions service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeRegions">REST API Reference for DescribeRegions Operation</seealso>
        DescribeRegionsResponse DescribeRegions();

        /// <summary>
        /// Describes one or more regions that are currently available to you.
        /// 
        ///  
        /// <para>
        /// For a list of the regions supported by Amazon EC2, see <a href="http://docs.aws.amazon.com/general/latest/gr/rande.html#ec2_region">Regions
        /// and Endpoints</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRegions service method.</param>
        /// 
        /// <returns>The response from the DescribeRegions service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeRegions">REST API Reference for DescribeRegions Operation</seealso>
        DescribeRegionsResponse DescribeRegions(DescribeRegionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRegions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRegions operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeRegions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeRegions">REST API Reference for DescribeRegions Operation</seealso>
        IAsyncResult BeginDescribeRegions(DescribeRegionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeRegions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeRegions.</param>
        /// 
        /// <returns>Returns a  DescribeRegionsResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeRegions">REST API Reference for DescribeRegions Operation</seealso>
        DescribeRegionsResponse EndDescribeRegions(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeReservedInstances


        /// <summary>
        /// Describes one or more of the Reserved Instances that you purchased.
        /// 
        ///  
        /// <para>
        /// For more information about Reserved Instances, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/concepts-on-demand-reserved-instances.html">Reserved
        /// Instances</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeReservedInstances service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeReservedInstances">REST API Reference for DescribeReservedInstances Operation</seealso>
        DescribeReservedInstancesResponse DescribeReservedInstances();

        /// <summary>
        /// Describes one or more of the Reserved Instances that you purchased.
        /// 
        ///  
        /// <para>
        /// For more information about Reserved Instances, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/concepts-on-demand-reserved-instances.html">Reserved
        /// Instances</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedInstances service method.</param>
        /// 
        /// <returns>The response from the DescribeReservedInstances service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeReservedInstances">REST API Reference for DescribeReservedInstances Operation</seealso>
        DescribeReservedInstancesResponse DescribeReservedInstances(DescribeReservedInstancesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReservedInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedInstances operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeReservedInstances
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeReservedInstances">REST API Reference for DescribeReservedInstances Operation</seealso>
        IAsyncResult BeginDescribeReservedInstances(DescribeReservedInstancesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeReservedInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeReservedInstances.</param>
        /// 
        /// <returns>Returns a  DescribeReservedInstancesResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeReservedInstances">REST API Reference for DescribeReservedInstances Operation</seealso>
        DescribeReservedInstancesResponse EndDescribeReservedInstances(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeReservedInstancesListings


        /// <summary>
        /// Describes your account's Reserved Instance listings in the Reserved Instance Marketplace.
        /// 
        ///  
        /// <para>
        /// The Reserved Instance Marketplace matches sellers who want to resell Reserved Instance
        /// capacity that they no longer need with buyers who want to purchase additional capacity.
        /// Reserved Instances bought and sold through the Reserved Instance Marketplace work
        /// like any other Reserved Instances.
        /// </para>
        ///  
        /// <para>
        /// As a seller, you choose to list some or all of your Reserved Instances, and you specify
        /// the upfront price to receive for them. Your Reserved Instances are then listed in
        /// the Reserved Instance Marketplace and are available for purchase.
        /// </para>
        ///  
        /// <para>
        /// As a buyer, you specify the configuration of the Reserved Instance to purchase, and
        /// the Marketplace matches what you're searching for with what's available. The Marketplace
        /// first sells the lowest priced Reserved Instances to you, and continues to sell available
        /// Reserved Instance listings to you until your demand is met. You are charged based
        /// on the total price of all of the listings that you purchase.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ri-market-general.html">Reserved
        /// Instance Marketplace</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeReservedInstancesListings service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeReservedInstancesListings">REST API Reference for DescribeReservedInstancesListings Operation</seealso>
        DescribeReservedInstancesListingsResponse DescribeReservedInstancesListings();

        /// <summary>
        /// Describes your account's Reserved Instance listings in the Reserved Instance Marketplace.
        /// 
        ///  
        /// <para>
        /// The Reserved Instance Marketplace matches sellers who want to resell Reserved Instance
        /// capacity that they no longer need with buyers who want to purchase additional capacity.
        /// Reserved Instances bought and sold through the Reserved Instance Marketplace work
        /// like any other Reserved Instances.
        /// </para>
        ///  
        /// <para>
        /// As a seller, you choose to list some or all of your Reserved Instances, and you specify
        /// the upfront price to receive for them. Your Reserved Instances are then listed in
        /// the Reserved Instance Marketplace and are available for purchase.
        /// </para>
        ///  
        /// <para>
        /// As a buyer, you specify the configuration of the Reserved Instance to purchase, and
        /// the Marketplace matches what you're searching for with what's available. The Marketplace
        /// first sells the lowest priced Reserved Instances to you, and continues to sell available
        /// Reserved Instance listings to you until your demand is met. You are charged based
        /// on the total price of all of the listings that you purchase.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ri-market-general.html">Reserved
        /// Instance Marketplace</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedInstancesListings service method.</param>
        /// 
        /// <returns>The response from the DescribeReservedInstancesListings service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeReservedInstancesListings">REST API Reference for DescribeReservedInstancesListings Operation</seealso>
        DescribeReservedInstancesListingsResponse DescribeReservedInstancesListings(DescribeReservedInstancesListingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReservedInstancesListings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedInstancesListings operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeReservedInstancesListings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeReservedInstancesListings">REST API Reference for DescribeReservedInstancesListings Operation</seealso>
        IAsyncResult BeginDescribeReservedInstancesListings(DescribeReservedInstancesListingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeReservedInstancesListings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeReservedInstancesListings.</param>
        /// 
        /// <returns>Returns a  DescribeReservedInstancesListingsResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeReservedInstancesListings">REST API Reference for DescribeReservedInstancesListings Operation</seealso>
        DescribeReservedInstancesListingsResponse EndDescribeReservedInstancesListings(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeReservedInstancesModifications


        /// <summary>
        /// Describes the modifications made to your Reserved Instances. If no parameter is specified,
        /// information about all your Reserved Instances modification requests is returned. If
        /// a modification ID is specified, only information about the specific modification is
        /// returned.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ri-modifying.html">Modifying
        /// Reserved Instances</a> in the Amazon Elastic Compute Cloud User Guide.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeReservedInstancesModifications service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeReservedInstancesModifications">REST API Reference for DescribeReservedInstancesModifications Operation</seealso>
        DescribeReservedInstancesModificationsResponse DescribeReservedInstancesModifications();

        /// <summary>
        /// Describes the modifications made to your Reserved Instances. If no parameter is specified,
        /// information about all your Reserved Instances modification requests is returned. If
        /// a modification ID is specified, only information about the specific modification is
        /// returned.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ri-modifying.html">Modifying
        /// Reserved Instances</a> in the Amazon Elastic Compute Cloud User Guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedInstancesModifications service method.</param>
        /// 
        /// <returns>The response from the DescribeReservedInstancesModifications service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeReservedInstancesModifications">REST API Reference for DescribeReservedInstancesModifications Operation</seealso>
        DescribeReservedInstancesModificationsResponse DescribeReservedInstancesModifications(DescribeReservedInstancesModificationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReservedInstancesModifications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedInstancesModifications operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeReservedInstancesModifications
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeReservedInstancesModifications">REST API Reference for DescribeReservedInstancesModifications Operation</seealso>
        IAsyncResult BeginDescribeReservedInstancesModifications(DescribeReservedInstancesModificationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeReservedInstancesModifications operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeReservedInstancesModifications.</param>
        /// 
        /// <returns>Returns a  DescribeReservedInstancesModificationsResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeReservedInstancesModifications">REST API Reference for DescribeReservedInstancesModifications Operation</seealso>
        DescribeReservedInstancesModificationsResponse EndDescribeReservedInstancesModifications(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeReservedInstancesOfferings


        /// <summary>
        /// Describes Reserved Instance offerings that are available for purchase. With Reserved
        /// Instances, you purchase the right to launch instances for a period of time. During
        /// that time period, you do not receive insufficient capacity errors, and you pay a lower
        /// usage rate than the rate charged for On-Demand instances for the actual time used.
        /// 
        ///  
        /// <para>
        /// If you have listed your own Reserved Instances for sale in the Reserved Instance Marketplace,
        /// they will be excluded from these results. This is to ensure that you do not purchase
        /// your own Reserved Instances.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ri-market-general.html">Reserved
        /// Instance Marketplace</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeReservedInstancesOfferings service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeReservedInstancesOfferings">REST API Reference for DescribeReservedInstancesOfferings Operation</seealso>
        DescribeReservedInstancesOfferingsResponse DescribeReservedInstancesOfferings();

        /// <summary>
        /// Describes Reserved Instance offerings that are available for purchase. With Reserved
        /// Instances, you purchase the right to launch instances for a period of time. During
        /// that time period, you do not receive insufficient capacity errors, and you pay a lower
        /// usage rate than the rate charged for On-Demand instances for the actual time used.
        /// 
        ///  
        /// <para>
        /// If you have listed your own Reserved Instances for sale in the Reserved Instance Marketplace,
        /// they will be excluded from these results. This is to ensure that you do not purchase
        /// your own Reserved Instances.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ri-market-general.html">Reserved
        /// Instance Marketplace</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedInstancesOfferings service method.</param>
        /// 
        /// <returns>The response from the DescribeReservedInstancesOfferings service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeReservedInstancesOfferings">REST API Reference for DescribeReservedInstancesOfferings Operation</seealso>
        DescribeReservedInstancesOfferingsResponse DescribeReservedInstancesOfferings(DescribeReservedInstancesOfferingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReservedInstancesOfferings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedInstancesOfferings operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeReservedInstancesOfferings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeReservedInstancesOfferings">REST API Reference for DescribeReservedInstancesOfferings Operation</seealso>
        IAsyncResult BeginDescribeReservedInstancesOfferings(DescribeReservedInstancesOfferingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeReservedInstancesOfferings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeReservedInstancesOfferings.</param>
        /// 
        /// <returns>Returns a  DescribeReservedInstancesOfferingsResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeReservedInstancesOfferings">REST API Reference for DescribeReservedInstancesOfferings Operation</seealso>
        DescribeReservedInstancesOfferingsResponse EndDescribeReservedInstancesOfferings(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeRouteTables


        /// <summary>
        /// Describes one or more of your route tables.
        /// 
        ///  
        /// <para>
        /// Each subnet in your VPC must be associated with a route table. If a subnet is not
        /// explicitly associated with any route table, it is implicitly associated with the main
        /// route table. This command does not return the subnet ID for implicit associations.
        /// </para>
        ///  
        /// <para>
        /// For more information about route tables, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Route_Tables.html">Route
        /// Tables</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeRouteTables service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeRouteTables">REST API Reference for DescribeRouteTables Operation</seealso>
        DescribeRouteTablesResponse DescribeRouteTables();

        /// <summary>
        /// Describes one or more of your route tables.
        /// 
        ///  
        /// <para>
        /// Each subnet in your VPC must be associated with a route table. If a subnet is not
        /// explicitly associated with any route table, it is implicitly associated with the main
        /// route table. This command does not return the subnet ID for implicit associations.
        /// </para>
        ///  
        /// <para>
        /// For more information about route tables, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Route_Tables.html">Route
        /// Tables</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRouteTables service method.</param>
        /// 
        /// <returns>The response from the DescribeRouteTables service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeRouteTables">REST API Reference for DescribeRouteTables Operation</seealso>
        DescribeRouteTablesResponse DescribeRouteTables(DescribeRouteTablesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRouteTables operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRouteTables operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeRouteTables
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeRouteTables">REST API Reference for DescribeRouteTables Operation</seealso>
        IAsyncResult BeginDescribeRouteTables(DescribeRouteTablesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeRouteTables operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeRouteTables.</param>
        /// 
        /// <returns>Returns a  DescribeRouteTablesResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeRouteTables">REST API Reference for DescribeRouteTables Operation</seealso>
        DescribeRouteTablesResponse EndDescribeRouteTables(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeScheduledInstanceAvailability


        /// <summary>
        /// Finds available schedules that meet the specified criteria.
        /// 
        ///  
        /// <para>
        /// You can search for an available schedule no more than 3 months in advance. You must
        /// meet the minimum required duration of 1,200 hours per year. For example, the minimum
        /// daily schedule is 4 hours, the minimum weekly schedule is 24 hours, and the minimum
        /// monthly schedule is 100 hours.
        /// </para>
        ///  
        /// <para>
        /// After you find a schedule that meets your needs, call <a>PurchaseScheduledInstances</a>
        /// to purchase Scheduled Instances with that schedule.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeScheduledInstanceAvailability service method.</param>
        /// 
        /// <returns>The response from the DescribeScheduledInstanceAvailability service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeScheduledInstanceAvailability">REST API Reference for DescribeScheduledInstanceAvailability Operation</seealso>
        DescribeScheduledInstanceAvailabilityResponse DescribeScheduledInstanceAvailability(DescribeScheduledInstanceAvailabilityRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeScheduledInstanceAvailability operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeScheduledInstanceAvailability operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeScheduledInstanceAvailability
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeScheduledInstanceAvailability">REST API Reference for DescribeScheduledInstanceAvailability Operation</seealso>
        IAsyncResult BeginDescribeScheduledInstanceAvailability(DescribeScheduledInstanceAvailabilityRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeScheduledInstanceAvailability operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeScheduledInstanceAvailability.</param>
        /// 
        /// <returns>Returns a  DescribeScheduledInstanceAvailabilityResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeScheduledInstanceAvailability">REST API Reference for DescribeScheduledInstanceAvailability Operation</seealso>
        DescribeScheduledInstanceAvailabilityResponse EndDescribeScheduledInstanceAvailability(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeScheduledInstances


        /// <summary>
        /// Describes one or more of your Scheduled Instances.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeScheduledInstances service method.</param>
        /// 
        /// <returns>The response from the DescribeScheduledInstances service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeScheduledInstances">REST API Reference for DescribeScheduledInstances Operation</seealso>
        DescribeScheduledInstancesResponse DescribeScheduledInstances(DescribeScheduledInstancesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeScheduledInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeScheduledInstances operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeScheduledInstances
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeScheduledInstances">REST API Reference for DescribeScheduledInstances Operation</seealso>
        IAsyncResult BeginDescribeScheduledInstances(DescribeScheduledInstancesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeScheduledInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeScheduledInstances.</param>
        /// 
        /// <returns>Returns a  DescribeScheduledInstancesResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeScheduledInstances">REST API Reference for DescribeScheduledInstances Operation</seealso>
        DescribeScheduledInstancesResponse EndDescribeScheduledInstances(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeSecurityGroupReferences


        /// <summary>
        /// [EC2-VPC only] Describes the VPCs on the other side of a VPC peering connection that
        /// are referencing the security groups you've specified in this request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSecurityGroupReferences service method.</param>
        /// 
        /// <returns>The response from the DescribeSecurityGroupReferences service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSecurityGroupReferences">REST API Reference for DescribeSecurityGroupReferences Operation</seealso>
        DescribeSecurityGroupReferencesResponse DescribeSecurityGroupReferences(DescribeSecurityGroupReferencesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSecurityGroupReferences operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSecurityGroupReferences operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSecurityGroupReferences
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSecurityGroupReferences">REST API Reference for DescribeSecurityGroupReferences Operation</seealso>
        IAsyncResult BeginDescribeSecurityGroupReferences(DescribeSecurityGroupReferencesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSecurityGroupReferences operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSecurityGroupReferences.</param>
        /// 
        /// <returns>Returns a  DescribeSecurityGroupReferencesResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSecurityGroupReferences">REST API Reference for DescribeSecurityGroupReferences Operation</seealso>
        DescribeSecurityGroupReferencesResponse EndDescribeSecurityGroupReferences(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeSecurityGroups


        /// <summary>
        /// Describes one or more of your security groups.
        /// 
        ///  
        /// <para>
        /// A security group is for use with instances either in the EC2-Classic platform or in
        /// a specific VPC. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-network-security.html">Amazon
        /// EC2 Security Groups</a> in the <i>Amazon Elastic Compute Cloud User Guide</i> and
        /// <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_SecurityGroups.html">Security
        /// Groups for Your VPC</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeSecurityGroups service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSecurityGroups">REST API Reference for DescribeSecurityGroups Operation</seealso>
        DescribeSecurityGroupsResponse DescribeSecurityGroups();

        /// <summary>
        /// Describes one or more of your security groups.
        /// 
        ///  
        /// <para>
        /// A security group is for use with instances either in the EC2-Classic platform or in
        /// a specific VPC. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-network-security.html">Amazon
        /// EC2 Security Groups</a> in the <i>Amazon Elastic Compute Cloud User Guide</i> and
        /// <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_SecurityGroups.html">Security
        /// Groups for Your VPC</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSecurityGroups service method.</param>
        /// 
        /// <returns>The response from the DescribeSecurityGroups service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSecurityGroups">REST API Reference for DescribeSecurityGroups Operation</seealso>
        DescribeSecurityGroupsResponse DescribeSecurityGroups(DescribeSecurityGroupsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSecurityGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSecurityGroups operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSecurityGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSecurityGroups">REST API Reference for DescribeSecurityGroups Operation</seealso>
        IAsyncResult BeginDescribeSecurityGroups(DescribeSecurityGroupsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSecurityGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSecurityGroups.</param>
        /// 
        /// <returns>Returns a  DescribeSecurityGroupsResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSecurityGroups">REST API Reference for DescribeSecurityGroups Operation</seealso>
        DescribeSecurityGroupsResponse EndDescribeSecurityGroups(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeSnapshotAttribute


        /// <summary>
        /// Describes the specified attribute of the specified snapshot. You can specify only
        /// one attribute at a time.
        /// 
        ///  
        /// <para>
        /// For more information about EBS snapshots, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSSnapshots.html">Amazon
        /// EBS Snapshots</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSnapshotAttribute service method.</param>
        /// 
        /// <returns>The response from the DescribeSnapshotAttribute service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSnapshotAttribute">REST API Reference for DescribeSnapshotAttribute Operation</seealso>
        DescribeSnapshotAttributeResponse DescribeSnapshotAttribute(DescribeSnapshotAttributeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSnapshotAttribute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSnapshotAttribute operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSnapshotAttribute
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSnapshotAttribute">REST API Reference for DescribeSnapshotAttribute Operation</seealso>
        IAsyncResult BeginDescribeSnapshotAttribute(DescribeSnapshotAttributeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSnapshotAttribute operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSnapshotAttribute.</param>
        /// 
        /// <returns>Returns a  DescribeSnapshotAttributeResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSnapshotAttribute">REST API Reference for DescribeSnapshotAttribute Operation</seealso>
        DescribeSnapshotAttributeResponse EndDescribeSnapshotAttribute(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeSnapshots


        /// <summary>
        /// Describes one or more of the EBS snapshots available to you. Available snapshots include
        /// public snapshots available for any AWS account to launch, private snapshots that you
        /// own, and private snapshots owned by another AWS account but for which you've been
        /// given explicit create volume permissions.
        /// 
        ///  
        /// <para>
        /// The create volume permissions fall into the following categories:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <i>public</i>: The owner of the snapshot granted create volume permissions for the
        /// snapshot to the <code>all</code> group. All AWS accounts have create volume permissions
        /// for these snapshots.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>explicit</i>: The owner of the snapshot granted create volume permissions to a
        /// specific AWS account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>implicit</i>: An AWS account has implicit create volume permissions for all snapshots
        /// it owns.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The list of snapshots returned can be modified by specifying snapshot IDs, snapshot
        /// owners, or AWS accounts with create volume permissions. If no options are specified,
        /// Amazon EC2 returns all snapshots for which you have create volume permissions.
        /// </para>
        ///  
        /// <para>
        /// If you specify one or more snapshot IDs, only snapshots that have the specified IDs
        /// are returned. If you specify an invalid snapshot ID, an error is returned. If you
        /// specify a snapshot ID for which you do not have access, it is not included in the
        /// returned results.
        /// </para>
        ///  
        /// <para>
        /// If you specify one or more snapshot owners using the <code>OwnerIds</code> option,
        /// only snapshots from the specified owners and for which you have access are returned.
        /// The results can include the AWS account IDs of the specified owners, <code>amazon</code>
        /// for snapshots owned by Amazon, or <code>self</code> for snapshots that you own.
        /// </para>
        ///  
        /// <para>
        /// If you specify a list of restorable users, only snapshots with create snapshot permissions
        /// for those users are returned. You can specify AWS account IDs (if you own the snapshots),
        /// <code>self</code> for snapshots for which you own or have explicit permissions, or
        /// <code>all</code> for public snapshots.
        /// </para>
        ///  
        /// <para>
        /// If you are describing a long list of snapshots, you can paginate the output to make
        /// the list more manageable. The <code>MaxResults</code> parameter sets the maximum number
        /// of results returned in a single page. If the list of results exceeds your <code>MaxResults</code>
        /// value, then that number of results is returned along with a <code>NextToken</code>
        /// value that can be passed to a subsequent <code>DescribeSnapshots</code> request to
        /// retrieve the remaining results.
        /// </para>
        ///  
        /// <para>
        /// For more information about EBS snapshots, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSSnapshots.html">Amazon
        /// EBS Snapshots</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeSnapshots service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSnapshots">REST API Reference for DescribeSnapshots Operation</seealso>
        DescribeSnapshotsResponse DescribeSnapshots();

        /// <summary>
        /// Describes one or more of the EBS snapshots available to you. Available snapshots include
        /// public snapshots available for any AWS account to launch, private snapshots that you
        /// own, and private snapshots owned by another AWS account but for which you've been
        /// given explicit create volume permissions.
        /// 
        ///  
        /// <para>
        /// The create volume permissions fall into the following categories:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        ///  <i>public</i>: The owner of the snapshot granted create volume permissions for the
        /// snapshot to the <code>all</code> group. All AWS accounts have create volume permissions
        /// for these snapshots.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>explicit</i>: The owner of the snapshot granted create volume permissions to a
        /// specific AWS account.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <i>implicit</i>: An AWS account has implicit create volume permissions for all snapshots
        /// it owns.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// The list of snapshots returned can be modified by specifying snapshot IDs, snapshot
        /// owners, or AWS accounts with create volume permissions. If no options are specified,
        /// Amazon EC2 returns all snapshots for which you have create volume permissions.
        /// </para>
        ///  
        /// <para>
        /// If you specify one or more snapshot IDs, only snapshots that have the specified IDs
        /// are returned. If you specify an invalid snapshot ID, an error is returned. If you
        /// specify a snapshot ID for which you do not have access, it is not included in the
        /// returned results.
        /// </para>
        ///  
        /// <para>
        /// If you specify one or more snapshot owners using the <code>OwnerIds</code> option,
        /// only snapshots from the specified owners and for which you have access are returned.
        /// The results can include the AWS account IDs of the specified owners, <code>amazon</code>
        /// for snapshots owned by Amazon, or <code>self</code> for snapshots that you own.
        /// </para>
        ///  
        /// <para>
        /// If you specify a list of restorable users, only snapshots with create snapshot permissions
        /// for those users are returned. You can specify AWS account IDs (if you own the snapshots),
        /// <code>self</code> for snapshots for which you own or have explicit permissions, or
        /// <code>all</code> for public snapshots.
        /// </para>
        ///  
        /// <para>
        /// If you are describing a long list of snapshots, you can paginate the output to make
        /// the list more manageable. The <code>MaxResults</code> parameter sets the maximum number
        /// of results returned in a single page. If the list of results exceeds your <code>MaxResults</code>
        /// value, then that number of results is returned along with a <code>NextToken</code>
        /// value that can be passed to a subsequent <code>DescribeSnapshots</code> request to
        /// retrieve the remaining results.
        /// </para>
        ///  
        /// <para>
        /// For more information about EBS snapshots, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSSnapshots.html">Amazon
        /// EBS Snapshots</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSnapshots service method.</param>
        /// 
        /// <returns>The response from the DescribeSnapshots service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSnapshots">REST API Reference for DescribeSnapshots Operation</seealso>
        DescribeSnapshotsResponse DescribeSnapshots(DescribeSnapshotsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSnapshots operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSnapshots operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSnapshots
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSnapshots">REST API Reference for DescribeSnapshots Operation</seealso>
        IAsyncResult BeginDescribeSnapshots(DescribeSnapshotsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSnapshots operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSnapshots.</param>
        /// 
        /// <returns>Returns a  DescribeSnapshotsResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSnapshots">REST API Reference for DescribeSnapshots Operation</seealso>
        DescribeSnapshotsResponse EndDescribeSnapshots(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeSpotDatafeedSubscription


        /// <summary>
        /// Describes the data feed for Spot Instances. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/spot-data-feeds.html">Spot
        /// Instance Data Feed</a> in the <i>Amazon EC2 User Guide for Linux Instances</i>.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeSpotDatafeedSubscription service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSpotDatafeedSubscription">REST API Reference for DescribeSpotDatafeedSubscription Operation</seealso>
        DescribeSpotDatafeedSubscriptionResponse DescribeSpotDatafeedSubscription();

        /// <summary>
        /// Describes the data feed for Spot Instances. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/spot-data-feeds.html">Spot
        /// Instance Data Feed</a> in the <i>Amazon EC2 User Guide for Linux Instances</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSpotDatafeedSubscription service method.</param>
        /// 
        /// <returns>The response from the DescribeSpotDatafeedSubscription service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSpotDatafeedSubscription">REST API Reference for DescribeSpotDatafeedSubscription Operation</seealso>
        DescribeSpotDatafeedSubscriptionResponse DescribeSpotDatafeedSubscription(DescribeSpotDatafeedSubscriptionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSpotDatafeedSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSpotDatafeedSubscription operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSpotDatafeedSubscription
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSpotDatafeedSubscription">REST API Reference for DescribeSpotDatafeedSubscription Operation</seealso>
        IAsyncResult BeginDescribeSpotDatafeedSubscription(DescribeSpotDatafeedSubscriptionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSpotDatafeedSubscription operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSpotDatafeedSubscription.</param>
        /// 
        /// <returns>Returns a  DescribeSpotDatafeedSubscriptionResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSpotDatafeedSubscription">REST API Reference for DescribeSpotDatafeedSubscription Operation</seealso>
        DescribeSpotDatafeedSubscriptionResponse EndDescribeSpotDatafeedSubscription(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeSpotFleetInstances


        /// <summary>
        /// Describes the running instances for the specified Spot Fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSpotFleetInstances service method.</param>
        /// 
        /// <returns>The response from the DescribeSpotFleetInstances service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSpotFleetInstances">REST API Reference for DescribeSpotFleetInstances Operation</seealso>
        DescribeSpotFleetInstancesResponse DescribeSpotFleetInstances(DescribeSpotFleetInstancesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSpotFleetInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSpotFleetInstances operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSpotFleetInstances
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSpotFleetInstances">REST API Reference for DescribeSpotFleetInstances Operation</seealso>
        IAsyncResult BeginDescribeSpotFleetInstances(DescribeSpotFleetInstancesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSpotFleetInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSpotFleetInstances.</param>
        /// 
        /// <returns>Returns a  DescribeSpotFleetInstancesResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSpotFleetInstances">REST API Reference for DescribeSpotFleetInstances Operation</seealso>
        DescribeSpotFleetInstancesResponse EndDescribeSpotFleetInstances(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeSpotFleetRequestHistory


        /// <summary>
        /// Describes the events for the specified Spot Fleet request during the specified time.
        /// 
        ///  
        /// <para>
        /// Spot Fleet events are delayed by up to 30 seconds before they can be described. This
        /// ensures that you can query by the last evaluated time and not miss a recorded event.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSpotFleetRequestHistory service method.</param>
        /// 
        /// <returns>The response from the DescribeSpotFleetRequestHistory service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSpotFleetRequestHistory">REST API Reference for DescribeSpotFleetRequestHistory Operation</seealso>
        DescribeSpotFleetRequestHistoryResponse DescribeSpotFleetRequestHistory(DescribeSpotFleetRequestHistoryRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSpotFleetRequestHistory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSpotFleetRequestHistory operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSpotFleetRequestHistory
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSpotFleetRequestHistory">REST API Reference for DescribeSpotFleetRequestHistory Operation</seealso>
        IAsyncResult BeginDescribeSpotFleetRequestHistory(DescribeSpotFleetRequestHistoryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSpotFleetRequestHistory operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSpotFleetRequestHistory.</param>
        /// 
        /// <returns>Returns a  DescribeSpotFleetRequestHistoryResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSpotFleetRequestHistory">REST API Reference for DescribeSpotFleetRequestHistory Operation</seealso>
        DescribeSpotFleetRequestHistoryResponse EndDescribeSpotFleetRequestHistory(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeSpotFleetRequests


        /// <summary>
        /// Describes your Spot Fleet requests.
        /// 
        ///  
        /// <para>
        /// Spot Fleet requests are deleted 48 hours after they are canceled and their instances
        /// are terminated.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSpotFleetRequests service method.</param>
        /// 
        /// <returns>The response from the DescribeSpotFleetRequests service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSpotFleetRequests">REST API Reference for DescribeSpotFleetRequests Operation</seealso>
        DescribeSpotFleetRequestsResponse DescribeSpotFleetRequests(DescribeSpotFleetRequestsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSpotFleetRequests operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSpotFleetRequests operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSpotFleetRequests
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSpotFleetRequests">REST API Reference for DescribeSpotFleetRequests Operation</seealso>
        IAsyncResult BeginDescribeSpotFleetRequests(DescribeSpotFleetRequestsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSpotFleetRequests operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSpotFleetRequests.</param>
        /// 
        /// <returns>Returns a  DescribeSpotFleetRequestsResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSpotFleetRequests">REST API Reference for DescribeSpotFleetRequests Operation</seealso>
        DescribeSpotFleetRequestsResponse EndDescribeSpotFleetRequests(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeSpotInstanceRequests


        /// <summary>
        /// Describes the specified Spot Instance requests.
        /// 
        ///  
        /// <para>
        /// You can use <code>DescribeSpotInstanceRequests</code> to find a running Spot Instance
        /// by examining the response. If the status of the Spot Instance is <code>fulfilled</code>,
        /// the instance ID appears in the response and contains the identifier of the instance.
        /// Alternatively, you can use <a>DescribeInstances</a> with a filter to look for instances
        /// where the instance lifecycle is <code>spot</code>.
        /// </para>
        ///  
        /// <para>
        /// Spot Instance requests are deleted four hours after they are canceled and their instances
        /// are terminated.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeSpotInstanceRequests service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSpotInstanceRequests">REST API Reference for DescribeSpotInstanceRequests Operation</seealso>
        DescribeSpotInstanceRequestsResponse DescribeSpotInstanceRequests();

        /// <summary>
        /// Describes the specified Spot Instance requests.
        /// 
        ///  
        /// <para>
        /// You can use <code>DescribeSpotInstanceRequests</code> to find a running Spot Instance
        /// by examining the response. If the status of the Spot Instance is <code>fulfilled</code>,
        /// the instance ID appears in the response and contains the identifier of the instance.
        /// Alternatively, you can use <a>DescribeInstances</a> with a filter to look for instances
        /// where the instance lifecycle is <code>spot</code>.
        /// </para>
        ///  
        /// <para>
        /// Spot Instance requests are deleted four hours after they are canceled and their instances
        /// are terminated.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSpotInstanceRequests service method.</param>
        /// 
        /// <returns>The response from the DescribeSpotInstanceRequests service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSpotInstanceRequests">REST API Reference for DescribeSpotInstanceRequests Operation</seealso>
        DescribeSpotInstanceRequestsResponse DescribeSpotInstanceRequests(DescribeSpotInstanceRequestsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSpotInstanceRequests operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSpotInstanceRequests operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSpotInstanceRequests
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSpotInstanceRequests">REST API Reference for DescribeSpotInstanceRequests Operation</seealso>
        IAsyncResult BeginDescribeSpotInstanceRequests(DescribeSpotInstanceRequestsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSpotInstanceRequests operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSpotInstanceRequests.</param>
        /// 
        /// <returns>Returns a  DescribeSpotInstanceRequestsResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSpotInstanceRequests">REST API Reference for DescribeSpotInstanceRequests Operation</seealso>
        DescribeSpotInstanceRequestsResponse EndDescribeSpotInstanceRequests(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeSpotPriceHistory


        /// <summary>
        /// Describes the Spot price history. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-spot-instances-history.html">Spot
        /// Instance Pricing History</a> in the <i>Amazon EC2 User Guide for Linux Instances</i>.
        /// 
        ///  
        /// <para>
        /// When you specify a start and end time, this operation returns the prices of the instance
        /// types within the time range that you specified and the time when the price changed.
        /// The price is valid within the time period that you specified; the response merely
        /// indicates the last time that the price changed.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeSpotPriceHistory service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSpotPriceHistory">REST API Reference for DescribeSpotPriceHistory Operation</seealso>
        DescribeSpotPriceHistoryResponse DescribeSpotPriceHistory();

        /// <summary>
        /// Describes the Spot price history. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-spot-instances-history.html">Spot
        /// Instance Pricing History</a> in the <i>Amazon EC2 User Guide for Linux Instances</i>.
        /// 
        ///  
        /// <para>
        /// When you specify a start and end time, this operation returns the prices of the instance
        /// types within the time range that you specified and the time when the price changed.
        /// The price is valid within the time period that you specified; the response merely
        /// indicates the last time that the price changed.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSpotPriceHistory service method.</param>
        /// 
        /// <returns>The response from the DescribeSpotPriceHistory service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSpotPriceHistory">REST API Reference for DescribeSpotPriceHistory Operation</seealso>
        DescribeSpotPriceHistoryResponse DescribeSpotPriceHistory(DescribeSpotPriceHistoryRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSpotPriceHistory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSpotPriceHistory operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSpotPriceHistory
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSpotPriceHistory">REST API Reference for DescribeSpotPriceHistory Operation</seealso>
        IAsyncResult BeginDescribeSpotPriceHistory(DescribeSpotPriceHistoryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSpotPriceHistory operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSpotPriceHistory.</param>
        /// 
        /// <returns>Returns a  DescribeSpotPriceHistoryResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSpotPriceHistory">REST API Reference for DescribeSpotPriceHistory Operation</seealso>
        DescribeSpotPriceHistoryResponse EndDescribeSpotPriceHistory(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeStaleSecurityGroups


        /// <summary>
        /// [EC2-VPC only] Describes the stale security group rules for security groups in a specified
        /// VPC. Rules are stale when they reference a deleted security group in a peer VPC, or
        /// a security group in a peer VPC for which the VPC peering connection has been deleted.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeStaleSecurityGroups service method.</param>
        /// 
        /// <returns>The response from the DescribeStaleSecurityGroups service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeStaleSecurityGroups">REST API Reference for DescribeStaleSecurityGroups Operation</seealso>
        DescribeStaleSecurityGroupsResponse DescribeStaleSecurityGroups(DescribeStaleSecurityGroupsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStaleSecurityGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStaleSecurityGroups operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeStaleSecurityGroups
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeStaleSecurityGroups">REST API Reference for DescribeStaleSecurityGroups Operation</seealso>
        IAsyncResult BeginDescribeStaleSecurityGroups(DescribeStaleSecurityGroupsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeStaleSecurityGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeStaleSecurityGroups.</param>
        /// 
        /// <returns>Returns a  DescribeStaleSecurityGroupsResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeStaleSecurityGroups">REST API Reference for DescribeStaleSecurityGroups Operation</seealso>
        DescribeStaleSecurityGroupsResponse EndDescribeStaleSecurityGroups(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeSubnets


        /// <summary>
        /// Describes one or more of your subnets.
        /// 
        ///  
        /// <para>
        /// For more information about subnets, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Subnets.html">Your
        /// VPC and Subnets</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeSubnets service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSubnets">REST API Reference for DescribeSubnets Operation</seealso>
        DescribeSubnetsResponse DescribeSubnets();

        /// <summary>
        /// Describes one or more of your subnets.
        /// 
        ///  
        /// <para>
        /// For more information about subnets, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Subnets.html">Your
        /// VPC and Subnets</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSubnets service method.</param>
        /// 
        /// <returns>The response from the DescribeSubnets service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSubnets">REST API Reference for DescribeSubnets Operation</seealso>
        DescribeSubnetsResponse DescribeSubnets(DescribeSubnetsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSubnets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSubnets operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSubnets
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSubnets">REST API Reference for DescribeSubnets Operation</seealso>
        IAsyncResult BeginDescribeSubnets(DescribeSubnetsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSubnets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSubnets.</param>
        /// 
        /// <returns>Returns a  DescribeSubnetsResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSubnets">REST API Reference for DescribeSubnets Operation</seealso>
        DescribeSubnetsResponse EndDescribeSubnets(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeTags


        /// <summary>
        /// Describes one or more of the tags for your EC2 resources.
        /// 
        ///  
        /// <para>
        /// For more information about tags, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_Tags.html">Tagging
        /// Your Resources</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeTags service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeTags">REST API Reference for DescribeTags Operation</seealso>
        DescribeTagsResponse DescribeTags();

        /// <summary>
        /// Describes one or more of the tags for your EC2 resources.
        /// 
        ///  
        /// <para>
        /// For more information about tags, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_Tags.html">Tagging
        /// Your Resources</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTags service method.</param>
        /// 
        /// <returns>The response from the DescribeTags service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeTags">REST API Reference for DescribeTags Operation</seealso>
        DescribeTagsResponse DescribeTags(DescribeTagsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTags operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTags
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeTags">REST API Reference for DescribeTags Operation</seealso>
        IAsyncResult BeginDescribeTags(DescribeTagsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTags.</param>
        /// 
        /// <returns>Returns a  DescribeTagsResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeTags">REST API Reference for DescribeTags Operation</seealso>
        DescribeTagsResponse EndDescribeTags(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeVolumeAttribute


        /// <summary>
        /// Describes the specified attribute of the specified volume. You can specify only one
        /// attribute at a time.
        /// 
        ///  
        /// <para>
        /// For more information about EBS volumes, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSVolumes.html">Amazon
        /// EBS Volumes</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVolumeAttribute service method.</param>
        /// 
        /// <returns>The response from the DescribeVolumeAttribute service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVolumeAttribute">REST API Reference for DescribeVolumeAttribute Operation</seealso>
        DescribeVolumeAttributeResponse DescribeVolumeAttribute(DescribeVolumeAttributeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVolumeAttribute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVolumeAttribute operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeVolumeAttribute
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVolumeAttribute">REST API Reference for DescribeVolumeAttribute Operation</seealso>
        IAsyncResult BeginDescribeVolumeAttribute(DescribeVolumeAttributeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeVolumeAttribute operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeVolumeAttribute.</param>
        /// 
        /// <returns>Returns a  DescribeVolumeAttributeResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVolumeAttribute">REST API Reference for DescribeVolumeAttribute Operation</seealso>
        DescribeVolumeAttributeResponse EndDescribeVolumeAttribute(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeVolumes


        /// <summary>
        /// Describes the specified EBS volumes.
        /// 
        ///  
        /// <para>
        /// If you are describing a long list of volumes, you can paginate the output to make
        /// the list more manageable. The <code>MaxResults</code> parameter sets the maximum number
        /// of results returned in a single page. If the list of results exceeds your <code>MaxResults</code>
        /// value, then that number of results is returned along with a <code>NextToken</code>
        /// value that can be passed to a subsequent <code>DescribeVolumes</code> request to retrieve
        /// the remaining results.
        /// </para>
        ///  
        /// <para>
        /// For more information about EBS volumes, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSVolumes.html">Amazon
        /// EBS Volumes</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeVolumes service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVolumes">REST API Reference for DescribeVolumes Operation</seealso>
        DescribeVolumesResponse DescribeVolumes();

        /// <summary>
        /// Describes the specified EBS volumes.
        /// 
        ///  
        /// <para>
        /// If you are describing a long list of volumes, you can paginate the output to make
        /// the list more manageable. The <code>MaxResults</code> parameter sets the maximum number
        /// of results returned in a single page. If the list of results exceeds your <code>MaxResults</code>
        /// value, then that number of results is returned along with a <code>NextToken</code>
        /// value that can be passed to a subsequent <code>DescribeVolumes</code> request to retrieve
        /// the remaining results.
        /// </para>
        ///  
        /// <para>
        /// For more information about EBS volumes, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSVolumes.html">Amazon
        /// EBS Volumes</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVolumes service method.</param>
        /// 
        /// <returns>The response from the DescribeVolumes service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVolumes">REST API Reference for DescribeVolumes Operation</seealso>
        DescribeVolumesResponse DescribeVolumes(DescribeVolumesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVolumes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVolumes operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeVolumes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVolumes">REST API Reference for DescribeVolumes Operation</seealso>
        IAsyncResult BeginDescribeVolumes(DescribeVolumesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeVolumes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeVolumes.</param>
        /// 
        /// <returns>Returns a  DescribeVolumesResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVolumes">REST API Reference for DescribeVolumes Operation</seealso>
        DescribeVolumesResponse EndDescribeVolumes(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeVolumesModifications


        /// <summary>
        /// Reports the current modification status of EBS volumes.
        /// 
        ///  
        /// <para>
        /// Current-generation EBS volumes support modification of attributes including type,
        /// size, and (for <code>io1</code> volumes) IOPS provisioning while either attached to
        /// or detached from an instance. Following an action from the API or the console to modify
        /// a volume, the status of the modification may be <code>modifying</code>, <code>optimizing</code>,
        /// <code>completed</code>, or <code>failed</code>. If a volume has never been modified,
        /// then certain elements of the returned <code>VolumeModification</code> objects are
        /// null. 
        /// </para>
        ///  
        /// <para>
        ///  You can also use CloudWatch Events to check the status of a modification to an EBS
        /// volume. For information about CloudWatch Events, see the <a href="http://docs.aws.amazon.com/AmazonCloudWatch/latest/events/">Amazon
        /// CloudWatch Events User Guide</a>. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-expand-volume.html#monitoring_mods">Monitoring
        /// Volume Modifications"</a>. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVolumesModifications service method.</param>
        /// 
        /// <returns>The response from the DescribeVolumesModifications service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVolumesModifications">REST API Reference for DescribeVolumesModifications Operation</seealso>
        DescribeVolumesModificationsResponse DescribeVolumesModifications(DescribeVolumesModificationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVolumesModifications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVolumesModifications operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeVolumesModifications
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVolumesModifications">REST API Reference for DescribeVolumesModifications Operation</seealso>
        IAsyncResult BeginDescribeVolumesModifications(DescribeVolumesModificationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeVolumesModifications operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeVolumesModifications.</param>
        /// 
        /// <returns>Returns a  DescribeVolumesModificationsResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVolumesModifications">REST API Reference for DescribeVolumesModifications Operation</seealso>
        DescribeVolumesModificationsResponse EndDescribeVolumesModifications(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeVolumeStatus


        /// <summary>
        /// Describes the status of the specified volumes. Volume status provides the result of
        /// the checks performed on your volumes to determine events that can impair the performance
        /// of your volumes. The performance of a volume can be affected if an issue occurs on
        /// the volume's underlying host. If the volume's underlying host experiences a power
        /// outage or system issue, after the system is restored, there could be data inconsistencies
        /// on the volume. Volume events notify you if this occurs. Volume actions notify you
        /// if any action needs to be taken in response to the event.
        /// 
        ///  
        /// <para>
        /// The <code>DescribeVolumeStatus</code> operation provides the following information
        /// about the specified volumes:
        /// </para>
        ///  
        /// <para>
        ///  <i>Status</i>: Reflects the current status of the volume. The possible values are
        /// <code>ok</code>, <code>impaired</code> , <code>warning</code>, or <code>insufficient-data</code>.
        /// If all checks pass, the overall status of the volume is <code>ok</code>. If the check
        /// fails, the overall status is <code>impaired</code>. If the status is <code>insufficient-data</code>,
        /// then the checks may still be taking place on your volume at the time. We recommend
        /// that you retry the request. For more information on volume status, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/monitoring-volume-status.html">Monitoring
        /// the Status of Your Volumes</a>.
        /// </para>
        ///  
        /// <para>
        ///  <i>Events</i>: Reflect the cause of a volume status and may require you to take action.
        /// For example, if your volume returns an <code>impaired</code> status, then the volume
        /// event might be <code>potential-data-inconsistency</code>. This means that your volume
        /// has been affected by an issue with the underlying host, has all I/O operations disabled,
        /// and may have inconsistent data.
        /// </para>
        ///  
        /// <para>
        ///  <i>Actions</i>: Reflect the actions you may have to take in response to an event.
        /// For example, if the status of the volume is <code>impaired</code> and the volume event
        /// shows <code>potential-data-inconsistency</code>, then the action shows <code>enable-volume-io</code>.
        /// This means that you may want to enable the I/O operations for the volume by calling
        /// the <a>EnableVolumeIO</a> action and then check the volume for data consistency.
        /// </para>
        ///  <note> 
        /// <para>
        /// Volume status is based on the volume status checks, and does not reflect the volume
        /// state. Therefore, volume status does not indicate volumes in the <code>error</code>
        /// state (for example, when a volume is incapable of accepting I/O.)
        /// </para>
        ///  </note>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeVolumeStatus service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVolumeStatus">REST API Reference for DescribeVolumeStatus Operation</seealso>
        DescribeVolumeStatusResponse DescribeVolumeStatus();

        /// <summary>
        /// Describes the status of the specified volumes. Volume status provides the result of
        /// the checks performed on your volumes to determine events that can impair the performance
        /// of your volumes. The performance of a volume can be affected if an issue occurs on
        /// the volume's underlying host. If the volume's underlying host experiences a power
        /// outage or system issue, after the system is restored, there could be data inconsistencies
        /// on the volume. Volume events notify you if this occurs. Volume actions notify you
        /// if any action needs to be taken in response to the event.
        /// 
        ///  
        /// <para>
        /// The <code>DescribeVolumeStatus</code> operation provides the following information
        /// about the specified volumes:
        /// </para>
        ///  
        /// <para>
        ///  <i>Status</i>: Reflects the current status of the volume. The possible values are
        /// <code>ok</code>, <code>impaired</code> , <code>warning</code>, or <code>insufficient-data</code>.
        /// If all checks pass, the overall status of the volume is <code>ok</code>. If the check
        /// fails, the overall status is <code>impaired</code>. If the status is <code>insufficient-data</code>,
        /// then the checks may still be taking place on your volume at the time. We recommend
        /// that you retry the request. For more information on volume status, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/monitoring-volume-status.html">Monitoring
        /// the Status of Your Volumes</a>.
        /// </para>
        ///  
        /// <para>
        ///  <i>Events</i>: Reflect the cause of a volume status and may require you to take action.
        /// For example, if your volume returns an <code>impaired</code> status, then the volume
        /// event might be <code>potential-data-inconsistency</code>. This means that your volume
        /// has been affected by an issue with the underlying host, has all I/O operations disabled,
        /// and may have inconsistent data.
        /// </para>
        ///  
        /// <para>
        ///  <i>Actions</i>: Reflect the actions you may have to take in response to an event.
        /// For example, if the status of the volume is <code>impaired</code> and the volume event
        /// shows <code>potential-data-inconsistency</code>, then the action shows <code>enable-volume-io</code>.
        /// This means that you may want to enable the I/O operations for the volume by calling
        /// the <a>EnableVolumeIO</a> action and then check the volume for data consistency.
        /// </para>
        ///  <note> 
        /// <para>
        /// Volume status is based on the volume status checks, and does not reflect the volume
        /// state. Therefore, volume status does not indicate volumes in the <code>error</code>
        /// state (for example, when a volume is incapable of accepting I/O.)
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVolumeStatus service method.</param>
        /// 
        /// <returns>The response from the DescribeVolumeStatus service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVolumeStatus">REST API Reference for DescribeVolumeStatus Operation</seealso>
        DescribeVolumeStatusResponse DescribeVolumeStatus(DescribeVolumeStatusRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVolumeStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVolumeStatus operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeVolumeStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVolumeStatus">REST API Reference for DescribeVolumeStatus Operation</seealso>
        IAsyncResult BeginDescribeVolumeStatus(DescribeVolumeStatusRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeVolumeStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeVolumeStatus.</param>
        /// 
        /// <returns>Returns a  DescribeVolumeStatusResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVolumeStatus">REST API Reference for DescribeVolumeStatus Operation</seealso>
        DescribeVolumeStatusResponse EndDescribeVolumeStatus(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeVpcAttribute


        /// <summary>
        /// Describes the specified attribute of the specified VPC. You can specify only one attribute
        /// at a time.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcAttribute service method.</param>
        /// 
        /// <returns>The response from the DescribeVpcAttribute service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcAttribute">REST API Reference for DescribeVpcAttribute Operation</seealso>
        DescribeVpcAttributeResponse DescribeVpcAttribute(DescribeVpcAttributeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVpcAttribute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcAttribute operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeVpcAttribute
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcAttribute">REST API Reference for DescribeVpcAttribute Operation</seealso>
        IAsyncResult BeginDescribeVpcAttribute(DescribeVpcAttributeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeVpcAttribute operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeVpcAttribute.</param>
        /// 
        /// <returns>Returns a  DescribeVpcAttributeResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcAttribute">REST API Reference for DescribeVpcAttribute Operation</seealso>
        DescribeVpcAttributeResponse EndDescribeVpcAttribute(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeVpcClassicLink


        /// <summary>
        /// Describes the ClassicLink status of one or more VPCs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcClassicLink service method.</param>
        /// 
        /// <returns>The response from the DescribeVpcClassicLink service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcClassicLink">REST API Reference for DescribeVpcClassicLink Operation</seealso>
        DescribeVpcClassicLinkResponse DescribeVpcClassicLink(DescribeVpcClassicLinkRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVpcClassicLink operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcClassicLink operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeVpcClassicLink
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcClassicLink">REST API Reference for DescribeVpcClassicLink Operation</seealso>
        IAsyncResult BeginDescribeVpcClassicLink(DescribeVpcClassicLinkRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeVpcClassicLink operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeVpcClassicLink.</param>
        /// 
        /// <returns>Returns a  DescribeVpcClassicLinkResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcClassicLink">REST API Reference for DescribeVpcClassicLink Operation</seealso>
        DescribeVpcClassicLinkResponse EndDescribeVpcClassicLink(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeVpcClassicLinkDnsSupport


        /// <summary>
        /// Describes the ClassicLink DNS support status of one or more VPCs. If enabled, the
        /// DNS hostname of a linked EC2-Classic instance resolves to its private IP address when
        /// addressed from an instance in the VPC to which it's linked. Similarly, the DNS hostname
        /// of an instance in a VPC resolves to its private IP address when addressed from a linked
        /// EC2-Classic instance. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/vpc-classiclink.html">ClassicLink</a>
        /// in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcClassicLinkDnsSupport service method.</param>
        /// 
        /// <returns>The response from the DescribeVpcClassicLinkDnsSupport service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcClassicLinkDnsSupport">REST API Reference for DescribeVpcClassicLinkDnsSupport Operation</seealso>
        DescribeVpcClassicLinkDnsSupportResponse DescribeVpcClassicLinkDnsSupport(DescribeVpcClassicLinkDnsSupportRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVpcClassicLinkDnsSupport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcClassicLinkDnsSupport operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeVpcClassicLinkDnsSupport
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcClassicLinkDnsSupport">REST API Reference for DescribeVpcClassicLinkDnsSupport Operation</seealso>
        IAsyncResult BeginDescribeVpcClassicLinkDnsSupport(DescribeVpcClassicLinkDnsSupportRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeVpcClassicLinkDnsSupport operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeVpcClassicLinkDnsSupport.</param>
        /// 
        /// <returns>Returns a  DescribeVpcClassicLinkDnsSupportResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcClassicLinkDnsSupport">REST API Reference for DescribeVpcClassicLinkDnsSupport Operation</seealso>
        DescribeVpcClassicLinkDnsSupportResponse EndDescribeVpcClassicLinkDnsSupport(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeVpcEndpointConnectionNotifications


        /// <summary>
        /// Describes the connection notifications for VPC endpoints and VPC endpoint services.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcEndpointConnectionNotifications service method.</param>
        /// 
        /// <returns>The response from the DescribeVpcEndpointConnectionNotifications service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcEndpointConnectionNotifications">REST API Reference for DescribeVpcEndpointConnectionNotifications Operation</seealso>
        DescribeVpcEndpointConnectionNotificationsResponse DescribeVpcEndpointConnectionNotifications(DescribeVpcEndpointConnectionNotificationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVpcEndpointConnectionNotifications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcEndpointConnectionNotifications operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeVpcEndpointConnectionNotifications
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcEndpointConnectionNotifications">REST API Reference for DescribeVpcEndpointConnectionNotifications Operation</seealso>
        IAsyncResult BeginDescribeVpcEndpointConnectionNotifications(DescribeVpcEndpointConnectionNotificationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeVpcEndpointConnectionNotifications operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeVpcEndpointConnectionNotifications.</param>
        /// 
        /// <returns>Returns a  DescribeVpcEndpointConnectionNotificationsResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcEndpointConnectionNotifications">REST API Reference for DescribeVpcEndpointConnectionNotifications Operation</seealso>
        DescribeVpcEndpointConnectionNotificationsResponse EndDescribeVpcEndpointConnectionNotifications(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeVpcEndpointConnections


        /// <summary>
        /// Describes the VPC endpoint connections to your VPC endpoint services, including any
        /// endpoints that are pending your acceptance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcEndpointConnections service method.</param>
        /// 
        /// <returns>The response from the DescribeVpcEndpointConnections service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcEndpointConnections">REST API Reference for DescribeVpcEndpointConnections Operation</seealso>
        DescribeVpcEndpointConnectionsResponse DescribeVpcEndpointConnections(DescribeVpcEndpointConnectionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVpcEndpointConnections operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcEndpointConnections operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeVpcEndpointConnections
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcEndpointConnections">REST API Reference for DescribeVpcEndpointConnections Operation</seealso>
        IAsyncResult BeginDescribeVpcEndpointConnections(DescribeVpcEndpointConnectionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeVpcEndpointConnections operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeVpcEndpointConnections.</param>
        /// 
        /// <returns>Returns a  DescribeVpcEndpointConnectionsResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcEndpointConnections">REST API Reference for DescribeVpcEndpointConnections Operation</seealso>
        DescribeVpcEndpointConnectionsResponse EndDescribeVpcEndpointConnections(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeVpcEndpoints


        /// <summary>
        /// Describes one or more of your VPC endpoints.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcEndpoints service method.</param>
        /// 
        /// <returns>The response from the DescribeVpcEndpoints service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcEndpoints">REST API Reference for DescribeVpcEndpoints Operation</seealso>
        DescribeVpcEndpointsResponse DescribeVpcEndpoints(DescribeVpcEndpointsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVpcEndpoints operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcEndpoints operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeVpcEndpoints
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcEndpoints">REST API Reference for DescribeVpcEndpoints Operation</seealso>
        IAsyncResult BeginDescribeVpcEndpoints(DescribeVpcEndpointsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeVpcEndpoints operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeVpcEndpoints.</param>
        /// 
        /// <returns>Returns a  DescribeVpcEndpointsResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcEndpoints">REST API Reference for DescribeVpcEndpoints Operation</seealso>
        DescribeVpcEndpointsResponse EndDescribeVpcEndpoints(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeVpcEndpointServiceConfigurations


        /// <summary>
        /// Describes the VPC endpoint service configurations in your account (your services).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcEndpointServiceConfigurations service method.</param>
        /// 
        /// <returns>The response from the DescribeVpcEndpointServiceConfigurations service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcEndpointServiceConfigurations">REST API Reference for DescribeVpcEndpointServiceConfigurations Operation</seealso>
        DescribeVpcEndpointServiceConfigurationsResponse DescribeVpcEndpointServiceConfigurations(DescribeVpcEndpointServiceConfigurationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVpcEndpointServiceConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcEndpointServiceConfigurations operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeVpcEndpointServiceConfigurations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcEndpointServiceConfigurations">REST API Reference for DescribeVpcEndpointServiceConfigurations Operation</seealso>
        IAsyncResult BeginDescribeVpcEndpointServiceConfigurations(DescribeVpcEndpointServiceConfigurationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeVpcEndpointServiceConfigurations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeVpcEndpointServiceConfigurations.</param>
        /// 
        /// <returns>Returns a  DescribeVpcEndpointServiceConfigurationsResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcEndpointServiceConfigurations">REST API Reference for DescribeVpcEndpointServiceConfigurations Operation</seealso>
        DescribeVpcEndpointServiceConfigurationsResponse EndDescribeVpcEndpointServiceConfigurations(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeVpcEndpointServicePermissions


        /// <summary>
        /// Describes the principals (service consumers) that are permitted to discover your VPC
        /// endpoint service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcEndpointServicePermissions service method.</param>
        /// 
        /// <returns>The response from the DescribeVpcEndpointServicePermissions service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcEndpointServicePermissions">REST API Reference for DescribeVpcEndpointServicePermissions Operation</seealso>
        DescribeVpcEndpointServicePermissionsResponse DescribeVpcEndpointServicePermissions(DescribeVpcEndpointServicePermissionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVpcEndpointServicePermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcEndpointServicePermissions operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeVpcEndpointServicePermissions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcEndpointServicePermissions">REST API Reference for DescribeVpcEndpointServicePermissions Operation</seealso>
        IAsyncResult BeginDescribeVpcEndpointServicePermissions(DescribeVpcEndpointServicePermissionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeVpcEndpointServicePermissions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeVpcEndpointServicePermissions.</param>
        /// 
        /// <returns>Returns a  DescribeVpcEndpointServicePermissionsResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcEndpointServicePermissions">REST API Reference for DescribeVpcEndpointServicePermissions Operation</seealso>
        DescribeVpcEndpointServicePermissionsResponse EndDescribeVpcEndpointServicePermissions(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeVpcEndpointServices


        /// <summary>
        /// Describes available services to which you can create a VPC endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcEndpointServices service method.</param>
        /// 
        /// <returns>The response from the DescribeVpcEndpointServices service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcEndpointServices">REST API Reference for DescribeVpcEndpointServices Operation</seealso>
        DescribeVpcEndpointServicesResponse DescribeVpcEndpointServices(DescribeVpcEndpointServicesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVpcEndpointServices operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcEndpointServices operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeVpcEndpointServices
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcEndpointServices">REST API Reference for DescribeVpcEndpointServices Operation</seealso>
        IAsyncResult BeginDescribeVpcEndpointServices(DescribeVpcEndpointServicesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeVpcEndpointServices operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeVpcEndpointServices.</param>
        /// 
        /// <returns>Returns a  DescribeVpcEndpointServicesResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcEndpointServices">REST API Reference for DescribeVpcEndpointServices Operation</seealso>
        DescribeVpcEndpointServicesResponse EndDescribeVpcEndpointServices(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeVpcPeeringConnections


        /// <summary>
        /// Describes one or more of your VPC peering connections.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeVpcPeeringConnections service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcPeeringConnections">REST API Reference for DescribeVpcPeeringConnections Operation</seealso>
        DescribeVpcPeeringConnectionsResponse DescribeVpcPeeringConnections();

        /// <summary>
        /// Describes one or more of your VPC peering connections.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcPeeringConnections service method.</param>
        /// 
        /// <returns>The response from the DescribeVpcPeeringConnections service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcPeeringConnections">REST API Reference for DescribeVpcPeeringConnections Operation</seealso>
        DescribeVpcPeeringConnectionsResponse DescribeVpcPeeringConnections(DescribeVpcPeeringConnectionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVpcPeeringConnections operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcPeeringConnections operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeVpcPeeringConnections
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcPeeringConnections">REST API Reference for DescribeVpcPeeringConnections Operation</seealso>
        IAsyncResult BeginDescribeVpcPeeringConnections(DescribeVpcPeeringConnectionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeVpcPeeringConnections operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeVpcPeeringConnections.</param>
        /// 
        /// <returns>Returns a  DescribeVpcPeeringConnectionsResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcPeeringConnections">REST API Reference for DescribeVpcPeeringConnections Operation</seealso>
        DescribeVpcPeeringConnectionsResponse EndDescribeVpcPeeringConnections(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeVpcs


        /// <summary>
        /// Describes one or more of your VPCs.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeVpcs service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcs">REST API Reference for DescribeVpcs Operation</seealso>
        DescribeVpcsResponse DescribeVpcs();

        /// <summary>
        /// Describes one or more of your VPCs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcs service method.</param>
        /// 
        /// <returns>The response from the DescribeVpcs service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcs">REST API Reference for DescribeVpcs Operation</seealso>
        DescribeVpcsResponse DescribeVpcs(DescribeVpcsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVpcs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcs operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeVpcs
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcs">REST API Reference for DescribeVpcs Operation</seealso>
        IAsyncResult BeginDescribeVpcs(DescribeVpcsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeVpcs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeVpcs.</param>
        /// 
        /// <returns>Returns a  DescribeVpcsResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcs">REST API Reference for DescribeVpcs Operation</seealso>
        DescribeVpcsResponse EndDescribeVpcs(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeVpnConnections


        /// <summary>
        /// Describes one or more of your VPN connections.
        /// 
        ///  
        /// <para>
        /// For more information about VPN connections, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_VPN.html">AWS
        /// Managed VPN Connections</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeVpnConnections service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpnConnections">REST API Reference for DescribeVpnConnections Operation</seealso>
        DescribeVpnConnectionsResponse DescribeVpnConnections();

        /// <summary>
        /// Describes one or more of your VPN connections.
        /// 
        ///  
        /// <para>
        /// For more information about VPN connections, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_VPN.html">AWS
        /// Managed VPN Connections</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpnConnections service method.</param>
        /// 
        /// <returns>The response from the DescribeVpnConnections service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpnConnections">REST API Reference for DescribeVpnConnections Operation</seealso>
        DescribeVpnConnectionsResponse DescribeVpnConnections(DescribeVpnConnectionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVpnConnections operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpnConnections operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeVpnConnections
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpnConnections">REST API Reference for DescribeVpnConnections Operation</seealso>
        IAsyncResult BeginDescribeVpnConnections(DescribeVpnConnectionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeVpnConnections operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeVpnConnections.</param>
        /// 
        /// <returns>Returns a  DescribeVpnConnectionsResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpnConnections">REST API Reference for DescribeVpnConnections Operation</seealso>
        DescribeVpnConnectionsResponse EndDescribeVpnConnections(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeVpnGateways


        /// <summary>
        /// Describes one or more of your virtual private gateways.
        /// 
        ///  
        /// <para>
        /// For more information about virtual private gateways, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_VPN.html">AWS
        /// Managed VPN Connections</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeVpnGateways service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpnGateways">REST API Reference for DescribeVpnGateways Operation</seealso>
        DescribeVpnGatewaysResponse DescribeVpnGateways();

        /// <summary>
        /// Describes one or more of your virtual private gateways.
        /// 
        ///  
        /// <para>
        /// For more information about virtual private gateways, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_VPN.html">AWS
        /// Managed VPN Connections</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpnGateways service method.</param>
        /// 
        /// <returns>The response from the DescribeVpnGateways service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpnGateways">REST API Reference for DescribeVpnGateways Operation</seealso>
        DescribeVpnGatewaysResponse DescribeVpnGateways(DescribeVpnGatewaysRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVpnGateways operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpnGateways operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeVpnGateways
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpnGateways">REST API Reference for DescribeVpnGateways Operation</seealso>
        IAsyncResult BeginDescribeVpnGateways(DescribeVpnGatewaysRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeVpnGateways operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeVpnGateways.</param>
        /// 
        /// <returns>Returns a  DescribeVpnGatewaysResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpnGateways">REST API Reference for DescribeVpnGateways Operation</seealso>
        DescribeVpnGatewaysResponse EndDescribeVpnGateways(IAsyncResult asyncResult);

        #endregion
        
        #region  DetachClassicLinkVpc


        /// <summary>
        /// Unlinks (detaches) a linked EC2-Classic instance from a VPC. After the instance has
        /// been unlinked, the VPC security groups are no longer associated with it. An instance
        /// is automatically unlinked from a VPC when it's stopped.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachClassicLinkVpc service method.</param>
        /// 
        /// <returns>The response from the DetachClassicLinkVpc service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DetachClassicLinkVpc">REST API Reference for DetachClassicLinkVpc Operation</seealso>
        DetachClassicLinkVpcResponse DetachClassicLinkVpc(DetachClassicLinkVpcRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DetachClassicLinkVpc operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachClassicLinkVpc operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDetachClassicLinkVpc
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DetachClassicLinkVpc">REST API Reference for DetachClassicLinkVpc Operation</seealso>
        IAsyncResult BeginDetachClassicLinkVpc(DetachClassicLinkVpcRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DetachClassicLinkVpc operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetachClassicLinkVpc.</param>
        /// 
        /// <returns>Returns a  DetachClassicLinkVpcResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DetachClassicLinkVpc">REST API Reference for DetachClassicLinkVpc Operation</seealso>
        DetachClassicLinkVpcResponse EndDetachClassicLinkVpc(IAsyncResult asyncResult);

        #endregion
        
        #region  DetachInternetGateway


        /// <summary>
        /// Detaches an Internet gateway from a VPC, disabling connectivity between the Internet
        /// and the VPC. The VPC must not contain any running instances with Elastic IP addresses
        /// or public IPv4 addresses.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachInternetGateway service method.</param>
        /// 
        /// <returns>The response from the DetachInternetGateway service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DetachInternetGateway">REST API Reference for DetachInternetGateway Operation</seealso>
        DetachInternetGatewayResponse DetachInternetGateway(DetachInternetGatewayRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DetachInternetGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachInternetGateway operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDetachInternetGateway
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DetachInternetGateway">REST API Reference for DetachInternetGateway Operation</seealso>
        IAsyncResult BeginDetachInternetGateway(DetachInternetGatewayRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DetachInternetGateway operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetachInternetGateway.</param>
        /// 
        /// <returns>Returns a  DetachInternetGatewayResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DetachInternetGateway">REST API Reference for DetachInternetGateway Operation</seealso>
        DetachInternetGatewayResponse EndDetachInternetGateway(IAsyncResult asyncResult);

        #endregion
        
        #region  DetachNetworkInterface


        /// <summary>
        /// Detaches a network interface from an instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachNetworkInterface service method.</param>
        /// 
        /// <returns>The response from the DetachNetworkInterface service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DetachNetworkInterface">REST API Reference for DetachNetworkInterface Operation</seealso>
        DetachNetworkInterfaceResponse DetachNetworkInterface(DetachNetworkInterfaceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DetachNetworkInterface operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachNetworkInterface operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDetachNetworkInterface
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DetachNetworkInterface">REST API Reference for DetachNetworkInterface Operation</seealso>
        IAsyncResult BeginDetachNetworkInterface(DetachNetworkInterfaceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DetachNetworkInterface operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetachNetworkInterface.</param>
        /// 
        /// <returns>Returns a  DetachNetworkInterfaceResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DetachNetworkInterface">REST API Reference for DetachNetworkInterface Operation</seealso>
        DetachNetworkInterfaceResponse EndDetachNetworkInterface(IAsyncResult asyncResult);

        #endregion
        
        #region  DetachVolume


        /// <summary>
        /// Detaches an EBS volume from an instance. Make sure to unmount any file systems on
        /// the device within your operating system before detaching the volume. Failure to do
        /// so can result in the volume becoming stuck in the <code>busy</code> state while detaching.
        /// If this happens, detachment can be delayed indefinitely until you unmount the volume,
        /// force detachment, reboot the instance, or all three. If an EBS volume is the root
        /// device of an instance, it can't be detached while the instance is running. To detach
        /// the root volume, stop the instance first.
        /// 
        ///  
        /// <para>
        /// When a volume with an AWS Marketplace product code is detached from an instance, the
        /// product code is no longer associated with the instance.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-detaching-volume.html">Detaching
        /// an Amazon EBS Volume</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachVolume service method.</param>
        /// 
        /// <returns>The response from the DetachVolume service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DetachVolume">REST API Reference for DetachVolume Operation</seealso>
        DetachVolumeResponse DetachVolume(DetachVolumeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DetachVolume operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachVolume operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDetachVolume
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DetachVolume">REST API Reference for DetachVolume Operation</seealso>
        IAsyncResult BeginDetachVolume(DetachVolumeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DetachVolume operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetachVolume.</param>
        /// 
        /// <returns>Returns a  DetachVolumeResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DetachVolume">REST API Reference for DetachVolume Operation</seealso>
        DetachVolumeResponse EndDetachVolume(IAsyncResult asyncResult);

        #endregion
        
        #region  DetachVpnGateway


        /// <summary>
        /// Detaches a virtual private gateway from a VPC. You do this if you're planning to turn
        /// off the VPC and not use it anymore. You can confirm a virtual private gateway has
        /// been completely detached from a VPC by describing the virtual private gateway (any
        /// attachments to the virtual private gateway are also described).
        /// 
        ///  
        /// <para>
        /// You must wait for the attachment's state to switch to <code>detached</code> before
        /// you can delete the VPC or attach a different VPC to the virtual private gateway.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachVpnGateway service method.</param>
        /// 
        /// <returns>The response from the DetachVpnGateway service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DetachVpnGateway">REST API Reference for DetachVpnGateway Operation</seealso>
        DetachVpnGatewayResponse DetachVpnGateway(DetachVpnGatewayRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DetachVpnGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachVpnGateway operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDetachVpnGateway
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DetachVpnGateway">REST API Reference for DetachVpnGateway Operation</seealso>
        IAsyncResult BeginDetachVpnGateway(DetachVpnGatewayRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DetachVpnGateway operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetachVpnGateway.</param>
        /// 
        /// <returns>Returns a  DetachVpnGatewayResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DetachVpnGateway">REST API Reference for DetachVpnGateway Operation</seealso>
        DetachVpnGatewayResponse EndDetachVpnGateway(IAsyncResult asyncResult);

        #endregion
        
        #region  DisableVgwRoutePropagation


        /// <summary>
        /// Disables a virtual private gateway (VGW) from propagating routes to a specified route
        /// table of a VPC.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableVgwRoutePropagation service method.</param>
        /// 
        /// <returns>The response from the DisableVgwRoutePropagation service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DisableVgwRoutePropagation">REST API Reference for DisableVgwRoutePropagation Operation</seealso>
        DisableVgwRoutePropagationResponse DisableVgwRoutePropagation(DisableVgwRoutePropagationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisableVgwRoutePropagation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableVgwRoutePropagation operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisableVgwRoutePropagation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DisableVgwRoutePropagation">REST API Reference for DisableVgwRoutePropagation Operation</seealso>
        IAsyncResult BeginDisableVgwRoutePropagation(DisableVgwRoutePropagationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisableVgwRoutePropagation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisableVgwRoutePropagation.</param>
        /// 
        /// <returns>Returns a  DisableVgwRoutePropagationResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DisableVgwRoutePropagation">REST API Reference for DisableVgwRoutePropagation Operation</seealso>
        DisableVgwRoutePropagationResponse EndDisableVgwRoutePropagation(IAsyncResult asyncResult);

        #endregion
        
        #region  DisableVpcClassicLink


        /// <summary>
        /// Disables ClassicLink for a VPC. You cannot disable ClassicLink for a VPC that has
        /// EC2-Classic instances linked to it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableVpcClassicLink service method.</param>
        /// 
        /// <returns>The response from the DisableVpcClassicLink service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DisableVpcClassicLink">REST API Reference for DisableVpcClassicLink Operation</seealso>
        DisableVpcClassicLinkResponse DisableVpcClassicLink(DisableVpcClassicLinkRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisableVpcClassicLink operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableVpcClassicLink operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisableVpcClassicLink
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DisableVpcClassicLink">REST API Reference for DisableVpcClassicLink Operation</seealso>
        IAsyncResult BeginDisableVpcClassicLink(DisableVpcClassicLinkRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisableVpcClassicLink operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisableVpcClassicLink.</param>
        /// 
        /// <returns>Returns a  DisableVpcClassicLinkResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DisableVpcClassicLink">REST API Reference for DisableVpcClassicLink Operation</seealso>
        DisableVpcClassicLinkResponse EndDisableVpcClassicLink(IAsyncResult asyncResult);

        #endregion
        
        #region  DisableVpcClassicLinkDnsSupport


        /// <summary>
        /// Disables ClassicLink DNS support for a VPC. If disabled, DNS hostnames resolve to
        /// public IP addresses when addressed between a linked EC2-Classic instance and instances
        /// in the VPC to which it's linked. For more information about ClassicLink, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/vpc-classiclink.html">ClassicLink</a>
        /// in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableVpcClassicLinkDnsSupport service method.</param>
        /// 
        /// <returns>The response from the DisableVpcClassicLinkDnsSupport service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DisableVpcClassicLinkDnsSupport">REST API Reference for DisableVpcClassicLinkDnsSupport Operation</seealso>
        DisableVpcClassicLinkDnsSupportResponse DisableVpcClassicLinkDnsSupport(DisableVpcClassicLinkDnsSupportRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisableVpcClassicLinkDnsSupport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableVpcClassicLinkDnsSupport operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisableVpcClassicLinkDnsSupport
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DisableVpcClassicLinkDnsSupport">REST API Reference for DisableVpcClassicLinkDnsSupport Operation</seealso>
        IAsyncResult BeginDisableVpcClassicLinkDnsSupport(DisableVpcClassicLinkDnsSupportRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisableVpcClassicLinkDnsSupport operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisableVpcClassicLinkDnsSupport.</param>
        /// 
        /// <returns>Returns a  DisableVpcClassicLinkDnsSupportResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DisableVpcClassicLinkDnsSupport">REST API Reference for DisableVpcClassicLinkDnsSupport Operation</seealso>
        DisableVpcClassicLinkDnsSupportResponse EndDisableVpcClassicLinkDnsSupport(IAsyncResult asyncResult);

        #endregion
        
        #region  DisassociateAddress


        /// <summary>
        /// Disassociates an Elastic IP address from the instance or network interface it's associated
        /// with.
        /// 
        ///  
        /// <para>
        /// An Elastic IP address is for use in either the EC2-Classic platform or in a VPC. For
        /// more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/elastic-ip-addresses-eip.html">Elastic
        /// IP Addresses</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// This is an idempotent operation. If you perform the operation more than once, Amazon
        /// EC2 doesn't return an error.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateAddress service method.</param>
        /// 
        /// <returns>The response from the DisassociateAddress service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DisassociateAddress">REST API Reference for DisassociateAddress Operation</seealso>
        DisassociateAddressResponse DisassociateAddress(DisassociateAddressRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateAddress operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateAddress operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateAddress
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DisassociateAddress">REST API Reference for DisassociateAddress Operation</seealso>
        IAsyncResult BeginDisassociateAddress(DisassociateAddressRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateAddress operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateAddress.</param>
        /// 
        /// <returns>Returns a  DisassociateAddressResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DisassociateAddress">REST API Reference for DisassociateAddress Operation</seealso>
        DisassociateAddressResponse EndDisassociateAddress(IAsyncResult asyncResult);

        #endregion
        
        #region  DisassociateIamInstanceProfile


        /// <summary>
        /// Disassociates an IAM instance profile from a running or stopped instance.
        /// 
        ///  
        /// <para>
        /// Use <a>DescribeIamInstanceProfileAssociations</a> to get the association ID.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateIamInstanceProfile service method.</param>
        /// 
        /// <returns>The response from the DisassociateIamInstanceProfile service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DisassociateIamInstanceProfile">REST API Reference for DisassociateIamInstanceProfile Operation</seealso>
        DisassociateIamInstanceProfileResponse DisassociateIamInstanceProfile(DisassociateIamInstanceProfileRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateIamInstanceProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateIamInstanceProfile operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateIamInstanceProfile
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DisassociateIamInstanceProfile">REST API Reference for DisassociateIamInstanceProfile Operation</seealso>
        IAsyncResult BeginDisassociateIamInstanceProfile(DisassociateIamInstanceProfileRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateIamInstanceProfile operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateIamInstanceProfile.</param>
        /// 
        /// <returns>Returns a  DisassociateIamInstanceProfileResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DisassociateIamInstanceProfile">REST API Reference for DisassociateIamInstanceProfile Operation</seealso>
        DisassociateIamInstanceProfileResponse EndDisassociateIamInstanceProfile(IAsyncResult asyncResult);

        #endregion
        
        #region  DisassociateRouteTable


        /// <summary>
        /// Disassociates a subnet from a route table.
        /// 
        ///  
        /// <para>
        /// After you perform this action, the subnet no longer uses the routes in the route table.
        /// Instead, it uses the routes in the VPC's main route table. For more information about
        /// route tables, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Route_Tables.html">Route
        /// Tables</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateRouteTable service method.</param>
        /// 
        /// <returns>The response from the DisassociateRouteTable service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DisassociateRouteTable">REST API Reference for DisassociateRouteTable Operation</seealso>
        DisassociateRouteTableResponse DisassociateRouteTable(DisassociateRouteTableRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateRouteTable operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateRouteTable operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateRouteTable
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DisassociateRouteTable">REST API Reference for DisassociateRouteTable Operation</seealso>
        IAsyncResult BeginDisassociateRouteTable(DisassociateRouteTableRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateRouteTable operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateRouteTable.</param>
        /// 
        /// <returns>Returns a  DisassociateRouteTableResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DisassociateRouteTable">REST API Reference for DisassociateRouteTable Operation</seealso>
        DisassociateRouteTableResponse EndDisassociateRouteTable(IAsyncResult asyncResult);

        #endregion
        
        #region  DisassociateSubnetCidrBlock


        /// <summary>
        /// Disassociates a CIDR block from a subnet. Currently, you can disassociate an IPv6
        /// CIDR block only. You must detach or delete all gateways and resources that are associated
        /// with the CIDR block before you can disassociate it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateSubnetCidrBlock service method.</param>
        /// 
        /// <returns>The response from the DisassociateSubnetCidrBlock service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DisassociateSubnetCidrBlock">REST API Reference for DisassociateSubnetCidrBlock Operation</seealso>
        DisassociateSubnetCidrBlockResponse DisassociateSubnetCidrBlock(DisassociateSubnetCidrBlockRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateSubnetCidrBlock operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateSubnetCidrBlock operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateSubnetCidrBlock
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DisassociateSubnetCidrBlock">REST API Reference for DisassociateSubnetCidrBlock Operation</seealso>
        IAsyncResult BeginDisassociateSubnetCidrBlock(DisassociateSubnetCidrBlockRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateSubnetCidrBlock operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateSubnetCidrBlock.</param>
        /// 
        /// <returns>Returns a  DisassociateSubnetCidrBlockResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DisassociateSubnetCidrBlock">REST API Reference for DisassociateSubnetCidrBlock Operation</seealso>
        DisassociateSubnetCidrBlockResponse EndDisassociateSubnetCidrBlock(IAsyncResult asyncResult);

        #endregion
        
        #region  DisassociateVpcCidrBlock


        /// <summary>
        /// Disassociates a CIDR block from a VPC. To disassociate the CIDR block, you must specify
        /// its association ID. You can get the association ID by using <a>DescribeVpcs</a>. You
        /// must detach or delete all gateways and resources that are associated with the CIDR
        /// block before you can disassociate it. 
        /// 
        ///  
        /// <para>
        /// You cannot disassociate the CIDR block with which you originally created the VPC (the
        /// primary CIDR block).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateVpcCidrBlock service method.</param>
        /// 
        /// <returns>The response from the DisassociateVpcCidrBlock service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DisassociateVpcCidrBlock">REST API Reference for DisassociateVpcCidrBlock Operation</seealso>
        DisassociateVpcCidrBlockResponse DisassociateVpcCidrBlock(DisassociateVpcCidrBlockRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateVpcCidrBlock operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateVpcCidrBlock operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateVpcCidrBlock
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DisassociateVpcCidrBlock">REST API Reference for DisassociateVpcCidrBlock Operation</seealso>
        IAsyncResult BeginDisassociateVpcCidrBlock(DisassociateVpcCidrBlockRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateVpcCidrBlock operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateVpcCidrBlock.</param>
        /// 
        /// <returns>Returns a  DisassociateVpcCidrBlockResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DisassociateVpcCidrBlock">REST API Reference for DisassociateVpcCidrBlock Operation</seealso>
        DisassociateVpcCidrBlockResponse EndDisassociateVpcCidrBlock(IAsyncResult asyncResult);

        #endregion
        
        #region  EnableVgwRoutePropagation


        /// <summary>
        /// Enables a virtual private gateway (VGW) to propagate routes to the specified route
        /// table of a VPC.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableVgwRoutePropagation service method.</param>
        /// 
        /// <returns>The response from the EnableVgwRoutePropagation service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/EnableVgwRoutePropagation">REST API Reference for EnableVgwRoutePropagation Operation</seealso>
        EnableVgwRoutePropagationResponse EnableVgwRoutePropagation(EnableVgwRoutePropagationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the EnableVgwRoutePropagation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableVgwRoutePropagation operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEnableVgwRoutePropagation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/EnableVgwRoutePropagation">REST API Reference for EnableVgwRoutePropagation Operation</seealso>
        IAsyncResult BeginEnableVgwRoutePropagation(EnableVgwRoutePropagationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  EnableVgwRoutePropagation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEnableVgwRoutePropagation.</param>
        /// 
        /// <returns>Returns a  EnableVgwRoutePropagationResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/EnableVgwRoutePropagation">REST API Reference for EnableVgwRoutePropagation Operation</seealso>
        EnableVgwRoutePropagationResponse EndEnableVgwRoutePropagation(IAsyncResult asyncResult);

        #endregion
        
        #region  EnableVolumeIO


        /// <summary>
        /// Enables I/O operations for a volume that had I/O operations disabled because the data
        /// on the volume was potentially inconsistent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableVolumeIO service method.</param>
        /// 
        /// <returns>The response from the EnableVolumeIO service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/EnableVolumeIO">REST API Reference for EnableVolumeIO Operation</seealso>
        EnableVolumeIOResponse EnableVolumeIO(EnableVolumeIORequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the EnableVolumeIO operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableVolumeIO operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEnableVolumeIO
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/EnableVolumeIO">REST API Reference for EnableVolumeIO Operation</seealso>
        IAsyncResult BeginEnableVolumeIO(EnableVolumeIORequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  EnableVolumeIO operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEnableVolumeIO.</param>
        /// 
        /// <returns>Returns a  EnableVolumeIOResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/EnableVolumeIO">REST API Reference for EnableVolumeIO Operation</seealso>
        EnableVolumeIOResponse EndEnableVolumeIO(IAsyncResult asyncResult);

        #endregion
        
        #region  EnableVpcClassicLink


        /// <summary>
        /// Enables a VPC for ClassicLink. You can then link EC2-Classic instances to your ClassicLink-enabled
        /// VPC to allow communication over private IP addresses. You cannot enable your VPC for
        /// ClassicLink if any of your VPC's route tables have existing routes for address ranges
        /// within the <code>10.0.0.0/8</code> IP address range, excluding local routes for VPCs
        /// in the <code>10.0.0.0/16</code> and <code>10.1.0.0/16</code> IP address ranges. For
        /// more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/vpc-classiclink.html">ClassicLink</a>
        /// in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableVpcClassicLink service method.</param>
        /// 
        /// <returns>The response from the EnableVpcClassicLink service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/EnableVpcClassicLink">REST API Reference for EnableVpcClassicLink Operation</seealso>
        EnableVpcClassicLinkResponse EnableVpcClassicLink(EnableVpcClassicLinkRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the EnableVpcClassicLink operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableVpcClassicLink operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEnableVpcClassicLink
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/EnableVpcClassicLink">REST API Reference for EnableVpcClassicLink Operation</seealso>
        IAsyncResult BeginEnableVpcClassicLink(EnableVpcClassicLinkRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  EnableVpcClassicLink operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEnableVpcClassicLink.</param>
        /// 
        /// <returns>Returns a  EnableVpcClassicLinkResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/EnableVpcClassicLink">REST API Reference for EnableVpcClassicLink Operation</seealso>
        EnableVpcClassicLinkResponse EndEnableVpcClassicLink(IAsyncResult asyncResult);

        #endregion
        
        #region  EnableVpcClassicLinkDnsSupport


        /// <summary>
        /// Enables a VPC to support DNS hostname resolution for ClassicLink. If enabled, the
        /// DNS hostname of a linked EC2-Classic instance resolves to its private IP address when
        /// addressed from an instance in the VPC to which it's linked. Similarly, the DNS hostname
        /// of an instance in a VPC resolves to its private IP address when addressed from a linked
        /// EC2-Classic instance. For more information about ClassicLink, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/vpc-classiclink.html">ClassicLink</a>
        /// in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableVpcClassicLinkDnsSupport service method.</param>
        /// 
        /// <returns>The response from the EnableVpcClassicLinkDnsSupport service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/EnableVpcClassicLinkDnsSupport">REST API Reference for EnableVpcClassicLinkDnsSupport Operation</seealso>
        EnableVpcClassicLinkDnsSupportResponse EnableVpcClassicLinkDnsSupport(EnableVpcClassicLinkDnsSupportRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the EnableVpcClassicLinkDnsSupport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableVpcClassicLinkDnsSupport operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndEnableVpcClassicLinkDnsSupport
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/EnableVpcClassicLinkDnsSupport">REST API Reference for EnableVpcClassicLinkDnsSupport Operation</seealso>
        IAsyncResult BeginEnableVpcClassicLinkDnsSupport(EnableVpcClassicLinkDnsSupportRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  EnableVpcClassicLinkDnsSupport operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEnableVpcClassicLinkDnsSupport.</param>
        /// 
        /// <returns>Returns a  EnableVpcClassicLinkDnsSupportResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/EnableVpcClassicLinkDnsSupport">REST API Reference for EnableVpcClassicLinkDnsSupport Operation</seealso>
        EnableVpcClassicLinkDnsSupportResponse EndEnableVpcClassicLinkDnsSupport(IAsyncResult asyncResult);

        #endregion
        
        #region  GetConsoleOutput


        /// <summary>
        /// Gets the console output for the specified instance. For Linux instances, the instance
        /// console output displays the exact console output that would normally be displayed
        /// on a physical monitor attached to a computer. For Windows instances, the instance
        /// console output includes output from the EC2Config service.
        /// 
        ///  
        /// <para>
        ///  <a>GetConsoleOutput</a> returns up to 64 KB of console output shortly after it's
        /// generated by the instance.
        /// </para>
        ///  
        /// <para>
        /// By default, the console output returns buffered information that was posted shortly
        /// after an instance transition state (start, stop, reboot, or terminate). This information
        /// is available for at least one hour after the most recent post.
        /// </para>
        ///  
        /// <para>
        /// You can optionally retrieve the latest serial console output at any time during the
        /// instance lifecycle. This option is only supported on C5, M5, and <code>i3.metal</code>
        /// instances.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConsoleOutput service method.</param>
        /// 
        /// <returns>The response from the GetConsoleOutput service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/GetConsoleOutput">REST API Reference for GetConsoleOutput Operation</seealso>
        GetConsoleOutputResponse GetConsoleOutput(GetConsoleOutputRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetConsoleOutput operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetConsoleOutput operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetConsoleOutput
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/GetConsoleOutput">REST API Reference for GetConsoleOutput Operation</seealso>
        IAsyncResult BeginGetConsoleOutput(GetConsoleOutputRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetConsoleOutput operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetConsoleOutput.</param>
        /// 
        /// <returns>Returns a  GetConsoleOutputResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/GetConsoleOutput">REST API Reference for GetConsoleOutput Operation</seealso>
        GetConsoleOutputResponse EndGetConsoleOutput(IAsyncResult asyncResult);

        #endregion
        
        #region  GetConsoleScreenshot


        /// <summary>
        /// Retrieve a JPG-format screenshot of a running instance to help with troubleshooting.
        /// 
        ///  
        /// <para>
        /// The returned content is Base64-encoded.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConsoleScreenshot service method.</param>
        /// 
        /// <returns>The response from the GetConsoleScreenshot service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/GetConsoleScreenshot">REST API Reference for GetConsoleScreenshot Operation</seealso>
        GetConsoleScreenshotResponse GetConsoleScreenshot(GetConsoleScreenshotRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetConsoleScreenshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetConsoleScreenshot operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetConsoleScreenshot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/GetConsoleScreenshot">REST API Reference for GetConsoleScreenshot Operation</seealso>
        IAsyncResult BeginGetConsoleScreenshot(GetConsoleScreenshotRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetConsoleScreenshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetConsoleScreenshot.</param>
        /// 
        /// <returns>Returns a  GetConsoleScreenshotResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/GetConsoleScreenshot">REST API Reference for GetConsoleScreenshot Operation</seealso>
        GetConsoleScreenshotResponse EndGetConsoleScreenshot(IAsyncResult asyncResult);

        #endregion
        
        #region  GetHostReservationPurchasePreview


        /// <summary>
        /// Preview a reservation purchase with configurations that match those of your Dedicated
        /// Host. You must have active Dedicated Hosts in your account before you purchase a reservation.
        /// 
        ///  
        /// <para>
        /// This is a preview of the <a>PurchaseHostReservation</a> action and does not result
        /// in the offering being purchased.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetHostReservationPurchasePreview service method.</param>
        /// 
        /// <returns>The response from the GetHostReservationPurchasePreview service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/GetHostReservationPurchasePreview">REST API Reference for GetHostReservationPurchasePreview Operation</seealso>
        GetHostReservationPurchasePreviewResponse GetHostReservationPurchasePreview(GetHostReservationPurchasePreviewRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetHostReservationPurchasePreview operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetHostReservationPurchasePreview operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetHostReservationPurchasePreview
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/GetHostReservationPurchasePreview">REST API Reference for GetHostReservationPurchasePreview Operation</seealso>
        IAsyncResult BeginGetHostReservationPurchasePreview(GetHostReservationPurchasePreviewRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetHostReservationPurchasePreview operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetHostReservationPurchasePreview.</param>
        /// 
        /// <returns>Returns a  GetHostReservationPurchasePreviewResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/GetHostReservationPurchasePreview">REST API Reference for GetHostReservationPurchasePreview Operation</seealso>
        GetHostReservationPurchasePreviewResponse EndGetHostReservationPurchasePreview(IAsyncResult asyncResult);

        #endregion
        
        #region  GetLaunchTemplateData


        /// <summary>
        /// Retrieves the configuration data of the specified instance. You can use this data
        /// to create a launch template.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLaunchTemplateData service method.</param>
        /// 
        /// <returns>The response from the GetLaunchTemplateData service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/GetLaunchTemplateData">REST API Reference for GetLaunchTemplateData Operation</seealso>
        GetLaunchTemplateDataResponse GetLaunchTemplateData(GetLaunchTemplateDataRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetLaunchTemplateData operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLaunchTemplateData operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetLaunchTemplateData
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/GetLaunchTemplateData">REST API Reference for GetLaunchTemplateData Operation</seealso>
        IAsyncResult BeginGetLaunchTemplateData(GetLaunchTemplateDataRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetLaunchTemplateData operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetLaunchTemplateData.</param>
        /// 
        /// <returns>Returns a  GetLaunchTemplateDataResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/GetLaunchTemplateData">REST API Reference for GetLaunchTemplateData Operation</seealso>
        GetLaunchTemplateDataResponse EndGetLaunchTemplateData(IAsyncResult asyncResult);

        #endregion
        
        #region  GetPasswordData


        /// <summary>
        /// Retrieves the encrypted administrator password for a running Windows instance.
        /// 
        ///  
        /// <para>
        /// The Windows password is generated at boot by the <code>EC2Config</code> service or
        /// <code>EC2Launch</code> scripts (Windows Server 2016 and later). This usually only
        /// happens the first time an instance is launched. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/WindowsGuide/UsingConfig_WinAMI.html">EC2Config</a>
        /// and <a href="http://docs.aws.amazon.com/AWSEC2/latest/WindowsGuide/ec2launch.html">EC2Launch</a>
        /// in the Amazon Elastic Compute Cloud User Guide.
        /// </para>
        ///  
        /// <para>
        /// For the <code>EC2Config</code> service, the password is not generated for rebundled
        /// AMIs unless <code>Ec2SetPassword</code> is enabled before bundling.
        /// </para>
        ///  
        /// <para>
        /// The password is encrypted using the key pair that you specified when you launched
        /// the instance. You must provide the corresponding key pair file.
        /// </para>
        ///  
        /// <para>
        /// When you launch an instance, password generation and encryption may take a few minutes.
        /// If you try to retrieve the password before it's available, the output returns an empty
        /// string. We recommend that you wait up to 15 minutes after launching an instance before
        /// trying to retrieve the generated password.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPasswordData service method.</param>
        /// 
        /// <returns>The response from the GetPasswordData service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/GetPasswordData">REST API Reference for GetPasswordData Operation</seealso>
        GetPasswordDataResponse GetPasswordData(GetPasswordDataRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetPasswordData operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPasswordData operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPasswordData
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/GetPasswordData">REST API Reference for GetPasswordData Operation</seealso>
        IAsyncResult BeginGetPasswordData(GetPasswordDataRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetPasswordData operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPasswordData.</param>
        /// 
        /// <returns>Returns a  GetPasswordDataResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/GetPasswordData">REST API Reference for GetPasswordData Operation</seealso>
        GetPasswordDataResponse EndGetPasswordData(IAsyncResult asyncResult);

        #endregion
        
        #region  GetReservedInstancesExchangeQuote


        /// <summary>
        /// Returns a quote and exchange information for exchanging one or more specified Convertible
        /// Reserved Instances for a new Convertible Reserved Instance. If the exchange cannot
        /// be performed, the reason is returned in the response. Use <a>AcceptReservedInstancesExchangeQuote</a>
        /// to perform the exchange.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetReservedInstancesExchangeQuote service method.</param>
        /// 
        /// <returns>The response from the GetReservedInstancesExchangeQuote service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/GetReservedInstancesExchangeQuote">REST API Reference for GetReservedInstancesExchangeQuote Operation</seealso>
        GetReservedInstancesExchangeQuoteResponse GetReservedInstancesExchangeQuote(GetReservedInstancesExchangeQuoteRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetReservedInstancesExchangeQuote operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetReservedInstancesExchangeQuote operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetReservedInstancesExchangeQuote
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/GetReservedInstancesExchangeQuote">REST API Reference for GetReservedInstancesExchangeQuote Operation</seealso>
        IAsyncResult BeginGetReservedInstancesExchangeQuote(GetReservedInstancesExchangeQuoteRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetReservedInstancesExchangeQuote operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetReservedInstancesExchangeQuote.</param>
        /// 
        /// <returns>Returns a  GetReservedInstancesExchangeQuoteResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/GetReservedInstancesExchangeQuote">REST API Reference for GetReservedInstancesExchangeQuote Operation</seealso>
        GetReservedInstancesExchangeQuoteResponse EndGetReservedInstancesExchangeQuote(IAsyncResult asyncResult);

        #endregion
        
        #region  ImportImage


        /// <summary>
        /// Import single or multi-volume disk images or EBS snapshots into an Amazon Machine
        /// Image (AMI). For more information, see <a href="http://docs.aws.amazon.com/vm-import/latest/userguide/vmimport-image-import.html">Importing
        /// a VM as an Image Using VM Import/Export</a> in the <i>VM Import/Export User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportImage service method.</param>
        /// 
        /// <returns>The response from the ImportImage service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ImportImage">REST API Reference for ImportImage Operation</seealso>
        ImportImageResponse ImportImage(ImportImageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ImportImage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportImage operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndImportImage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ImportImage">REST API Reference for ImportImage Operation</seealso>
        IAsyncResult BeginImportImage(ImportImageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ImportImage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginImportImage.</param>
        /// 
        /// <returns>Returns a  ImportImageResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ImportImage">REST API Reference for ImportImage Operation</seealso>
        ImportImageResponse EndImportImage(IAsyncResult asyncResult);

        #endregion
        
        #region  ImportInstance


        /// <summary>
        /// Creates an import instance task using metadata from the specified disk image. <code>ImportInstance</code>
        /// only supports single-volume VMs. To import multi-volume VMs, use <a>ImportImage</a>.
        /// For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/CommandLineReference/ec2-cli-vmimport-export.html">Importing
        /// a Virtual Machine Using the Amazon EC2 CLI</a>.
        /// 
        ///  
        /// <para>
        /// For information about the import manifest referenced by this API action, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/APIReference/manifest.html">VM
        /// Import Manifest</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportInstance service method.</param>
        /// 
        /// <returns>The response from the ImportInstance service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ImportInstance">REST API Reference for ImportInstance Operation</seealso>
        ImportInstanceResponse ImportInstance(ImportInstanceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ImportInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportInstance operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndImportInstance
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ImportInstance">REST API Reference for ImportInstance Operation</seealso>
        IAsyncResult BeginImportInstance(ImportInstanceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ImportInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginImportInstance.</param>
        /// 
        /// <returns>Returns a  ImportInstanceResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ImportInstance">REST API Reference for ImportInstance Operation</seealso>
        ImportInstanceResponse EndImportInstance(IAsyncResult asyncResult);

        #endregion
        
        #region  ImportKeyPair


        /// <summary>
        /// Imports the public key from an RSA key pair that you created with a third-party tool.
        /// Compare this with <a>CreateKeyPair</a>, in which AWS creates the key pair and gives
        /// the keys to you (AWS keeps a copy of the public key). With ImportKeyPair, you create
        /// the key pair and give AWS just the public key. The private key is never transferred
        /// between you and AWS.
        /// 
        ///  
        /// <para>
        /// For more information about key pairs, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-key-pairs.html">Key
        /// Pairs</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportKeyPair service method.</param>
        /// 
        /// <returns>The response from the ImportKeyPair service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ImportKeyPair">REST API Reference for ImportKeyPair Operation</seealso>
        ImportKeyPairResponse ImportKeyPair(ImportKeyPairRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ImportKeyPair operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportKeyPair operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndImportKeyPair
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ImportKeyPair">REST API Reference for ImportKeyPair Operation</seealso>
        IAsyncResult BeginImportKeyPair(ImportKeyPairRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ImportKeyPair operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginImportKeyPair.</param>
        /// 
        /// <returns>Returns a  ImportKeyPairResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ImportKeyPair">REST API Reference for ImportKeyPair Operation</seealso>
        ImportKeyPairResponse EndImportKeyPair(IAsyncResult asyncResult);

        #endregion
        
        #region  ImportSnapshot


        /// <summary>
        /// Imports a disk into an EBS snapshot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportSnapshot service method.</param>
        /// 
        /// <returns>The response from the ImportSnapshot service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ImportSnapshot">REST API Reference for ImportSnapshot Operation</seealso>
        ImportSnapshotResponse ImportSnapshot(ImportSnapshotRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ImportSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportSnapshot operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndImportSnapshot
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ImportSnapshot">REST API Reference for ImportSnapshot Operation</seealso>
        IAsyncResult BeginImportSnapshot(ImportSnapshotRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ImportSnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginImportSnapshot.</param>
        /// 
        /// <returns>Returns a  ImportSnapshotResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ImportSnapshot">REST API Reference for ImportSnapshot Operation</seealso>
        ImportSnapshotResponse EndImportSnapshot(IAsyncResult asyncResult);

        #endregion
        
        #region  ImportVolume


        /// <summary>
        /// Creates an import volume task using metadata from the specified disk image.For more
        /// information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/CommandLineReference/importing-your-volumes-into-amazon-ebs.html">Importing
        /// Disks to Amazon EBS</a>.
        /// 
        ///  
        /// <para>
        /// For information about the import manifest referenced by this API action, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/APIReference/manifest.html">VM
        /// Import Manifest</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportVolume service method.</param>
        /// 
        /// <returns>The response from the ImportVolume service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ImportVolume">REST API Reference for ImportVolume Operation</seealso>
        ImportVolumeResponse ImportVolume(ImportVolumeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ImportVolume operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportVolume operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndImportVolume
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ImportVolume">REST API Reference for ImportVolume Operation</seealso>
        IAsyncResult BeginImportVolume(ImportVolumeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ImportVolume operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginImportVolume.</param>
        /// 
        /// <returns>Returns a  ImportVolumeResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ImportVolume">REST API Reference for ImportVolume Operation</seealso>
        ImportVolumeResponse EndImportVolume(IAsyncResult asyncResult);

        #endregion
        
        #region  ModifyFleet


        /// <summary>
        /// Modifies the specified EC2 Fleet.
        /// 
        ///  
        /// <para>
        /// While the EC2 Fleet is being modified, it is in the <code>modifying</code> state.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyFleet service method.</param>
        /// 
        /// <returns>The response from the ModifyFleet service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyFleet">REST API Reference for ModifyFleet Operation</seealso>
        ModifyFleetResponse ModifyFleet(ModifyFleetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyFleet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyFleet operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyFleet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyFleet">REST API Reference for ModifyFleet Operation</seealso>
        IAsyncResult BeginModifyFleet(ModifyFleetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyFleet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyFleet.</param>
        /// 
        /// <returns>Returns a  ModifyFleetResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyFleet">REST API Reference for ModifyFleet Operation</seealso>
        ModifyFleetResponse EndModifyFleet(IAsyncResult asyncResult);

        #endregion
        
        #region  ModifyFpgaImageAttribute


        /// <summary>
        /// Modifies the specified attribute of the specified Amazon FPGA Image (AFI).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyFpgaImageAttribute service method.</param>
        /// 
        /// <returns>The response from the ModifyFpgaImageAttribute service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyFpgaImageAttribute">REST API Reference for ModifyFpgaImageAttribute Operation</seealso>
        ModifyFpgaImageAttributeResponse ModifyFpgaImageAttribute(ModifyFpgaImageAttributeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyFpgaImageAttribute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyFpgaImageAttribute operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyFpgaImageAttribute
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyFpgaImageAttribute">REST API Reference for ModifyFpgaImageAttribute Operation</seealso>
        IAsyncResult BeginModifyFpgaImageAttribute(ModifyFpgaImageAttributeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyFpgaImageAttribute operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyFpgaImageAttribute.</param>
        /// 
        /// <returns>Returns a  ModifyFpgaImageAttributeResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyFpgaImageAttribute">REST API Reference for ModifyFpgaImageAttribute Operation</seealso>
        ModifyFpgaImageAttributeResponse EndModifyFpgaImageAttribute(IAsyncResult asyncResult);

        #endregion
        
        #region  ModifyHosts


        /// <summary>
        /// Modify the auto-placement setting of a Dedicated Host. When auto-placement is enabled,
        /// AWS will place instances that you launch with a tenancy of <code>host</code>, but
        /// without targeting a specific host ID, onto any available Dedicated Host in your account
        /// which has auto-placement enabled. When auto-placement is disabled, you need to provide
        /// a host ID if you want the instance to launch onto a specific host. If no host ID is
        /// provided, the instance will be launched onto a suitable host which has auto-placement
        /// enabled.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyHosts service method.</param>
        /// 
        /// <returns>The response from the ModifyHosts service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyHosts">REST API Reference for ModifyHosts Operation</seealso>
        ModifyHostsResponse ModifyHosts(ModifyHostsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyHosts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyHosts operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyHosts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyHosts">REST API Reference for ModifyHosts Operation</seealso>
        IAsyncResult BeginModifyHosts(ModifyHostsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyHosts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyHosts.</param>
        /// 
        /// <returns>Returns a  ModifyHostsResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyHosts">REST API Reference for ModifyHosts Operation</seealso>
        ModifyHostsResponse EndModifyHosts(IAsyncResult asyncResult);

        #endregion
        
        #region  ModifyIdentityIdFormat


        /// <summary>
        /// Modifies the ID format of a resource for a specified IAM user, IAM role, or the root
        /// user for an account; or all IAM users, IAM roles, and the root user for an account.
        /// You can specify that resources should receive longer IDs (17-character IDs) when they
        /// are created. 
        /// 
        ///  
        /// <para>
        /// This request can only be used to modify longer ID settings for resource types that
        /// are within the opt-in period. Resources currently in their opt-in period include:
        /// <code>bundle</code> | <code>conversion-task</code> | <code>customer-gateway</code>
        /// | <code>dhcp-options</code> | <code>elastic-ip-allocation</code> | <code>elastic-ip-association</code>
        /// | <code>export-task</code> | <code>flow-log</code> | <code>image</code> | <code>import-task</code>
        /// | <code>internet-gateway</code> | <code>network-acl</code> | <code>network-acl-association</code>
        /// | <code>network-interface</code> | <code>network-interface-attachment</code> | <code>prefix-list</code>
        /// | <code>route-table</code> | <code>route-table-association</code> | <code>security-group</code>
        /// | <code>subnet</code> | <code>subnet-cidr-block-association</code> | <code>vpc</code>
        /// | <code>vpc-cidr-block-association</code> | <code>vpc-endpoint</code> | <code>vpc-peering-connection</code>
        /// | <code>vpn-connection</code> | <code>vpn-gateway</code>. 
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/resource-ids.html">Resource
        /// IDs</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>. 
        /// </para>
        ///  
        /// <para>
        /// This setting applies to the principal specified in the request; it does not apply
        /// to the principal that makes the request. 
        /// </para>
        ///  
        /// <para>
        /// Resources created with longer IDs are visible to all IAM roles and users, regardless
        /// of these settings and provided that they have permission to use the relevant <code>Describe</code>
        /// command for the resource type.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyIdentityIdFormat service method.</param>
        /// 
        /// <returns>The response from the ModifyIdentityIdFormat service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyIdentityIdFormat">REST API Reference for ModifyIdentityIdFormat Operation</seealso>
        ModifyIdentityIdFormatResponse ModifyIdentityIdFormat(ModifyIdentityIdFormatRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyIdentityIdFormat operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyIdentityIdFormat operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyIdentityIdFormat
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyIdentityIdFormat">REST API Reference for ModifyIdentityIdFormat Operation</seealso>
        IAsyncResult BeginModifyIdentityIdFormat(ModifyIdentityIdFormatRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyIdentityIdFormat operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyIdentityIdFormat.</param>
        /// 
        /// <returns>Returns a  ModifyIdentityIdFormatResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyIdentityIdFormat">REST API Reference for ModifyIdentityIdFormat Operation</seealso>
        ModifyIdentityIdFormatResponse EndModifyIdentityIdFormat(IAsyncResult asyncResult);

        #endregion
        
        #region  ModifyIdFormat


        /// <summary>
        /// Modifies the ID format for the specified resource on a per-region basis. You can specify
        /// that resources should receive longer IDs (17-character IDs) when they are created.
        /// 
        ///  
        /// <para>
        /// This request can only be used to modify longer ID settings for resource types that
        /// are within the opt-in period. Resources currently in their opt-in period include:
        /// <code>bundle</code> | <code>conversion-task</code> | <code>customer-gateway</code>
        /// | <code>dhcp-options</code> | <code>elastic-ip-allocation</code> | <code>elastic-ip-association</code>
        /// | <code>export-task</code> | <code>flow-log</code> | <code>image</code> | <code>import-task</code>
        /// | <code>internet-gateway</code> | <code>network-acl</code> | <code>network-acl-association</code>
        /// | <code>network-interface</code> | <code>network-interface-attachment</code> | <code>prefix-list</code>
        /// | <code>route-table</code> | <code>route-table-association</code> | <code>security-group</code>
        /// | <code>subnet</code> | <code>subnet-cidr-block-association</code> | <code>vpc</code>
        /// | <code>vpc-cidr-block-association</code> | <code>vpc-endpoint</code> | <code>vpc-peering-connection</code>
        /// | <code>vpn-connection</code> | <code>vpn-gateway</code>.
        /// </para>
        ///  
        /// <para>
        /// This setting applies to the IAM user who makes the request; it does not apply to the
        /// entire AWS account. By default, an IAM user defaults to the same settings as the root
        /// user. If you're using this action as the root user, then these settings apply to the
        /// entire account, unless an IAM user explicitly overrides these settings for themselves.
        /// For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/resource-ids.html">Resource
        /// IDs</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>. 
        /// </para>
        ///  
        /// <para>
        /// Resources created with longer IDs are visible to all IAM roles and users, regardless
        /// of these settings and provided that they have permission to use the relevant <code>Describe</code>
        /// command for the resource type.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyIdFormat service method.</param>
        /// 
        /// <returns>The response from the ModifyIdFormat service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyIdFormat">REST API Reference for ModifyIdFormat Operation</seealso>
        ModifyIdFormatResponse ModifyIdFormat(ModifyIdFormatRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyIdFormat operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyIdFormat operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyIdFormat
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyIdFormat">REST API Reference for ModifyIdFormat Operation</seealso>
        IAsyncResult BeginModifyIdFormat(ModifyIdFormatRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyIdFormat operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyIdFormat.</param>
        /// 
        /// <returns>Returns a  ModifyIdFormatResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyIdFormat">REST API Reference for ModifyIdFormat Operation</seealso>
        ModifyIdFormatResponse EndModifyIdFormat(IAsyncResult asyncResult);

        #endregion
        
        #region  ModifyImageAttribute


        /// <summary>
        /// Modifies the specified attribute of the specified AMI. You can specify only one attribute
        /// at a time. You can use the <code>Attribute</code> parameter to specify the attribute
        /// or one of the following parameters: <code>Description</code>, <code>LaunchPermission</code>,
        /// or <code>ProductCode</code>.
        /// 
        ///  
        /// <para>
        /// AWS Marketplace product codes cannot be modified. Images with an AWS Marketplace product
        /// code cannot be made public.
        /// </para>
        ///  
        /// <para>
        /// To enable the SriovNetSupport enhanced networking attribute of an image, enable SriovNetSupport
        /// on an instance and create an AMI from the instance.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyImageAttribute service method.</param>
        /// 
        /// <returns>The response from the ModifyImageAttribute service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyImageAttribute">REST API Reference for ModifyImageAttribute Operation</seealso>
        ModifyImageAttributeResponse ModifyImageAttribute(ModifyImageAttributeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyImageAttribute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyImageAttribute operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyImageAttribute
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyImageAttribute">REST API Reference for ModifyImageAttribute Operation</seealso>
        IAsyncResult BeginModifyImageAttribute(ModifyImageAttributeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyImageAttribute operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyImageAttribute.</param>
        /// 
        /// <returns>Returns a  ModifyImageAttributeResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyImageAttribute">REST API Reference for ModifyImageAttribute Operation</seealso>
        ModifyImageAttributeResponse EndModifyImageAttribute(IAsyncResult asyncResult);

        #endregion
        
        #region  ModifyInstanceAttribute


        /// <summary>
        /// Modifies the specified attribute of the specified instance. You can specify only one
        /// attribute at a time.
        /// 
        ///  
        /// <para>
        ///  <b>Note: </b>Using this action to change the security groups associated with an elastic
        /// network interface (ENI) attached to an instance in a VPC can result in an error if
        /// the instance has more than one ENI. To change the security groups associated with
        /// an ENI attached to an instance that has multiple ENIs, we recommend that you use the
        /// <a>ModifyNetworkInterfaceAttribute</a> action.
        /// </para>
        ///  
        /// <para>
        /// To modify some attributes, the instance must be stopped. For more information, see
        /// <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_ChangingAttributesWhileInstanceStopped.html">Modifying
        /// Attributes of a Stopped Instance</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyInstanceAttribute service method.</param>
        /// 
        /// <returns>The response from the ModifyInstanceAttribute service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyInstanceAttribute">REST API Reference for ModifyInstanceAttribute Operation</seealso>
        ModifyInstanceAttributeResponse ModifyInstanceAttribute(ModifyInstanceAttributeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyInstanceAttribute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyInstanceAttribute operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyInstanceAttribute
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyInstanceAttribute">REST API Reference for ModifyInstanceAttribute Operation</seealso>
        IAsyncResult BeginModifyInstanceAttribute(ModifyInstanceAttributeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyInstanceAttribute operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyInstanceAttribute.</param>
        /// 
        /// <returns>Returns a  ModifyInstanceAttributeResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyInstanceAttribute">REST API Reference for ModifyInstanceAttribute Operation</seealso>
        ModifyInstanceAttributeResponse EndModifyInstanceAttribute(IAsyncResult asyncResult);

        #endregion
        
        #region  ModifyInstanceCreditSpecification


        /// <summary>
        /// Modifies the credit option for CPU usage on a running or stopped T2 instance. The
        /// credit options are <code>standard</code> and <code>unlimited</code>.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/t2-instances.html">T2
        /// Instances</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyInstanceCreditSpecification service method.</param>
        /// 
        /// <returns>The response from the ModifyInstanceCreditSpecification service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyInstanceCreditSpecification">REST API Reference for ModifyInstanceCreditSpecification Operation</seealso>
        ModifyInstanceCreditSpecificationResponse ModifyInstanceCreditSpecification(ModifyInstanceCreditSpecificationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyInstanceCreditSpecification operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyInstanceCreditSpecification operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyInstanceCreditSpecification
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyInstanceCreditSpecification">REST API Reference for ModifyInstanceCreditSpecification Operation</seealso>
        IAsyncResult BeginModifyInstanceCreditSpecification(ModifyInstanceCreditSpecificationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyInstanceCreditSpecification operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyInstanceCreditSpecification.</param>
        /// 
        /// <returns>Returns a  ModifyInstanceCreditSpecificationResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyInstanceCreditSpecification">REST API Reference for ModifyInstanceCreditSpecification Operation</seealso>
        ModifyInstanceCreditSpecificationResponse EndModifyInstanceCreditSpecification(IAsyncResult asyncResult);

        #endregion
        
        #region  ModifyInstancePlacement


        /// <summary>
        /// Modifies the placement attributes for a specified instance. You can do the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Modify the affinity between an instance and a <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/dedicated-hosts-overview.html">Dedicated
        /// Host</a>. When affinity is set to <code>host</code> and the instance is not associated
        /// with a specific Dedicated Host, the next time the instance is launched, it is automatically
        /// associated with the host on which it lands. If the instance is restarted or rebooted,
        /// this relationship persists.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Change the Dedicated Host with which an instance is associated.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Change the instance tenancy of an instance from <code>host</code> to <code>dedicated</code>,
        /// or from <code>dedicated</code> to <code>host</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Move an instance to or from a <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/placement-groups.html">placement
        /// group</a>.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// At least one attribute for affinity, host ID, tenancy, or placement group name must
        /// be specified in the request. Affinity and tenancy can be modified in the same request.
        /// </para>
        ///  
        /// <para>
        /// To modify the host ID, tenancy, or placement group for an instance, the instance must
        /// be in the <code>stopped</code> state.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyInstancePlacement service method.</param>
        /// 
        /// <returns>The response from the ModifyInstancePlacement service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyInstancePlacement">REST API Reference for ModifyInstancePlacement Operation</seealso>
        ModifyInstancePlacementResponse ModifyInstancePlacement(ModifyInstancePlacementRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyInstancePlacement operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyInstancePlacement operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyInstancePlacement
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyInstancePlacement">REST API Reference for ModifyInstancePlacement Operation</seealso>
        IAsyncResult BeginModifyInstancePlacement(ModifyInstancePlacementRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyInstancePlacement operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyInstancePlacement.</param>
        /// 
        /// <returns>Returns a  ModifyInstancePlacementResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyInstancePlacement">REST API Reference for ModifyInstancePlacement Operation</seealso>
        ModifyInstancePlacementResponse EndModifyInstancePlacement(IAsyncResult asyncResult);

        #endregion
        
        #region  ModifyLaunchTemplate


        /// <summary>
        /// Modifies a launch template. You can specify which version of the launch template to
        /// set as the default version. When launching an instance, the default version applies
        /// when a launch template version is not specified.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyLaunchTemplate service method.</param>
        /// 
        /// <returns>The response from the ModifyLaunchTemplate service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyLaunchTemplate">REST API Reference for ModifyLaunchTemplate Operation</seealso>
        ModifyLaunchTemplateResponse ModifyLaunchTemplate(ModifyLaunchTemplateRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyLaunchTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyLaunchTemplate operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyLaunchTemplate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyLaunchTemplate">REST API Reference for ModifyLaunchTemplate Operation</seealso>
        IAsyncResult BeginModifyLaunchTemplate(ModifyLaunchTemplateRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyLaunchTemplate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyLaunchTemplate.</param>
        /// 
        /// <returns>Returns a  ModifyLaunchTemplateResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyLaunchTemplate">REST API Reference for ModifyLaunchTemplate Operation</seealso>
        ModifyLaunchTemplateResponse EndModifyLaunchTemplate(IAsyncResult asyncResult);

        #endregion
        
        #region  ModifyNetworkInterfaceAttribute


        /// <summary>
        /// Modifies the specified network interface attribute. You can specify only one attribute
        /// at a time.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyNetworkInterfaceAttribute service method.</param>
        /// 
        /// <returns>The response from the ModifyNetworkInterfaceAttribute service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyNetworkInterfaceAttribute">REST API Reference for ModifyNetworkInterfaceAttribute Operation</seealso>
        ModifyNetworkInterfaceAttributeResponse ModifyNetworkInterfaceAttribute(ModifyNetworkInterfaceAttributeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyNetworkInterfaceAttribute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyNetworkInterfaceAttribute operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyNetworkInterfaceAttribute
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyNetworkInterfaceAttribute">REST API Reference for ModifyNetworkInterfaceAttribute Operation</seealso>
        IAsyncResult BeginModifyNetworkInterfaceAttribute(ModifyNetworkInterfaceAttributeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyNetworkInterfaceAttribute operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyNetworkInterfaceAttribute.</param>
        /// 
        /// <returns>Returns a  ModifyNetworkInterfaceAttributeResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyNetworkInterfaceAttribute">REST API Reference for ModifyNetworkInterfaceAttribute Operation</seealso>
        ModifyNetworkInterfaceAttributeResponse EndModifyNetworkInterfaceAttribute(IAsyncResult asyncResult);

        #endregion
        
        #region  ModifyReservedInstances


        /// <summary>
        /// Modifies the Availability Zone, instance count, instance type, or network platform
        /// (EC2-Classic or EC2-VPC) of your Reserved Instances. The Reserved Instances to be
        /// modified must be identical, except for Availability Zone, network platform, and instance
        /// type.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ri-modifying.html">Modifying
        /// Reserved Instances</a> in the Amazon Elastic Compute Cloud User Guide.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyReservedInstances service method.</param>
        /// 
        /// <returns>The response from the ModifyReservedInstances service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyReservedInstances">REST API Reference for ModifyReservedInstances Operation</seealso>
        ModifyReservedInstancesResponse ModifyReservedInstances(ModifyReservedInstancesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyReservedInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyReservedInstances operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyReservedInstances
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyReservedInstances">REST API Reference for ModifyReservedInstances Operation</seealso>
        IAsyncResult BeginModifyReservedInstances(ModifyReservedInstancesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyReservedInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyReservedInstances.</param>
        /// 
        /// <returns>Returns a  ModifyReservedInstancesResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyReservedInstances">REST API Reference for ModifyReservedInstances Operation</seealso>
        ModifyReservedInstancesResponse EndModifyReservedInstances(IAsyncResult asyncResult);

        #endregion
        
        #region  ModifySnapshotAttribute


        /// <summary>
        /// Adds or removes permission settings for the specified snapshot. You may add or remove
        /// specified AWS account IDs from a snapshot's list of create volume permissions, but
        /// you cannot do both in a single API call. If you need to both add and remove account
        /// IDs for a snapshot, you must use multiple API calls.
        /// 
        ///  <note> 
        /// <para>
        /// Encrypted snapshots and snapshots with AWS Marketplace product codes cannot be made
        /// public. Snapshots encrypted with your default CMK cannot be shared with other accounts.
        /// </para>
        ///  </note> 
        /// <para>
        /// For more information on modifying snapshot permissions, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-modifying-snapshot-permissions.html">Sharing
        /// Snapshots</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifySnapshotAttribute service method.</param>
        /// 
        /// <returns>The response from the ModifySnapshotAttribute service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifySnapshotAttribute">REST API Reference for ModifySnapshotAttribute Operation</seealso>
        ModifySnapshotAttributeResponse ModifySnapshotAttribute(ModifySnapshotAttributeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ModifySnapshotAttribute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifySnapshotAttribute operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifySnapshotAttribute
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifySnapshotAttribute">REST API Reference for ModifySnapshotAttribute Operation</seealso>
        IAsyncResult BeginModifySnapshotAttribute(ModifySnapshotAttributeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ModifySnapshotAttribute operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifySnapshotAttribute.</param>
        /// 
        /// <returns>Returns a  ModifySnapshotAttributeResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifySnapshotAttribute">REST API Reference for ModifySnapshotAttribute Operation</seealso>
        ModifySnapshotAttributeResponse EndModifySnapshotAttribute(IAsyncResult asyncResult);

        #endregion
        
        #region  ModifySpotFleetRequest


        /// <summary>
        /// Modifies the specified Spot Fleet request.
        /// 
        ///  
        /// <para>
        /// While the Spot Fleet request is being modified, it is in the <code>modifying</code>
        /// state.
        /// </para>
        ///  
        /// <para>
        /// To scale up your Spot Fleet, increase its target capacity. The Spot Fleet launches
        /// the additional Spot Instances according to the allocation strategy for the Spot Fleet
        /// request. If the allocation strategy is <code>lowestPrice</code>, the Spot Fleet launches
        /// instances using the Spot pool with the lowest price. If the allocation strategy is
        /// <code>diversified</code>, the Spot Fleet distributes the instances across the Spot
        /// pools.
        /// </para>
        ///  
        /// <para>
        /// To scale down your Spot Fleet, decrease its target capacity. First, the Spot Fleet
        /// cancels any open requests that exceed the new target capacity. You can request that
        /// the Spot Fleet terminate Spot Instances until the size of the fleet no longer exceeds
        /// the new target capacity. If the allocation strategy is <code>lowestPrice</code>, the
        /// Spot Fleet terminates the instances with the highest price per unit. If the allocation
        /// strategy is <code>diversified</code>, the Spot Fleet terminates instances across the
        /// Spot pools. Alternatively, you can request that the Spot Fleet keep the fleet at its
        /// current size, but not replace any Spot Instances that are interrupted or that you
        /// terminate manually.
        /// </para>
        ///  
        /// <para>
        /// If you are finished with your Spot Fleet for now, but will use it again later, you
        /// can set the target capacity to 0.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifySpotFleetRequest service method.</param>
        /// 
        /// <returns>The response from the ModifySpotFleetRequest service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifySpotFleetRequest">REST API Reference for ModifySpotFleetRequest Operation</seealso>
        ModifySpotFleetRequestResponse ModifySpotFleetRequest(ModifySpotFleetRequestRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ModifySpotFleetRequest operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifySpotFleetRequest operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifySpotFleetRequest
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifySpotFleetRequest">REST API Reference for ModifySpotFleetRequest Operation</seealso>
        IAsyncResult BeginModifySpotFleetRequest(ModifySpotFleetRequestRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ModifySpotFleetRequest operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifySpotFleetRequest.</param>
        /// 
        /// <returns>Returns a  ModifySpotFleetRequestResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifySpotFleetRequest">REST API Reference for ModifySpotFleetRequest Operation</seealso>
        ModifySpotFleetRequestResponse EndModifySpotFleetRequest(IAsyncResult asyncResult);

        #endregion
        
        #region  ModifySubnetAttribute


        /// <summary>
        /// Modifies a subnet attribute. You can only modify one attribute at a time.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifySubnetAttribute service method.</param>
        /// 
        /// <returns>The response from the ModifySubnetAttribute service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifySubnetAttribute">REST API Reference for ModifySubnetAttribute Operation</seealso>
        ModifySubnetAttributeResponse ModifySubnetAttribute(ModifySubnetAttributeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ModifySubnetAttribute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifySubnetAttribute operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifySubnetAttribute
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifySubnetAttribute">REST API Reference for ModifySubnetAttribute Operation</seealso>
        IAsyncResult BeginModifySubnetAttribute(ModifySubnetAttributeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ModifySubnetAttribute operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifySubnetAttribute.</param>
        /// 
        /// <returns>Returns a  ModifySubnetAttributeResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifySubnetAttribute">REST API Reference for ModifySubnetAttribute Operation</seealso>
        ModifySubnetAttributeResponse EndModifySubnetAttribute(IAsyncResult asyncResult);

        #endregion
        
        #region  ModifyVolume


        /// <summary>
        /// You can modify several parameters of an existing EBS volume, including volume size,
        /// volume type, and IOPS capacity. If your EBS volume is attached to a current-generation
        /// EC2 instance type, you may be able to apply these changes without stopping the instance
        /// or detaching the volume from it. For more information about modifying an EBS volume
        /// running Linux, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-expand-volume.html">Modifying
        /// the Size, IOPS, or Type of an EBS Volume on Linux</a>. For more information about
        /// modifying an EBS volume running Windows, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/WindowsGuide/ebs-expand-volume.html">Modifying
        /// the Size, IOPS, or Type of an EBS Volume on Windows</a>. 
        /// 
        ///  
        /// <para>
        ///  When you complete a resize operation on your volume, you need to extend the volume's
        /// file-system size to take advantage of the new storage capacity. For information about
        /// extending a Linux file system, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-expand-volume.html#recognize-expanded-volume-linux">Extending
        /// a Linux File System</a>. For information about extending a Windows file system, see
        /// <a href="http://docs.aws.amazon.com/AWSEC2/latest/WindowsGuide/ebs-expand-volume.html#recognize-expanded-volume-windows">Extending
        /// a Windows File System</a>. 
        /// </para>
        ///  
        /// <para>
        ///  You can use CloudWatch Events to check the status of a modification to an EBS volume.
        /// For information about CloudWatch Events, see the <a href="http://docs.aws.amazon.com/AmazonCloudWatch/latest/events/">Amazon
        /// CloudWatch Events User Guide</a>. You can also track the status of a modification
        /// using the <a>DescribeVolumesModifications</a> API. For information about tracking
        /// status changes using either method, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-expand-volume.html#monitoring_mods">Monitoring
        /// Volume Modifications</a>. 
        /// </para>
        ///  <note> 
        /// <para>
        /// With previous-generation instance types, resizing an EBS volume may require detaching
        /// and reattaching the volume or stopping and restarting the instance. For more information
        /// about modifying an EBS volume running Linux, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-expand-volume.html">Modifying
        /// the Size, IOPS, or Type of an EBS Volume on Linux</a>. For more information about
        /// modifying an EBS volume running Windows, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/WindowsGuide/ebs-expand-volume.html">Modifying
        /// the Size, IOPS, or Type of an EBS Volume on Windows</a>.
        /// </para>
        ///  </note> <note> 
        /// <para>
        /// If you reach the maximum volume modification rate per volume limit, you will need
        /// to wait at least six hours before applying further modifications to the affected EBS
        /// volume.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyVolume service method.</param>
        /// 
        /// <returns>The response from the ModifyVolume service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyVolume">REST API Reference for ModifyVolume Operation</seealso>
        ModifyVolumeResponse ModifyVolume(ModifyVolumeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyVolume operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyVolume operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyVolume
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyVolume">REST API Reference for ModifyVolume Operation</seealso>
        IAsyncResult BeginModifyVolume(ModifyVolumeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyVolume operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyVolume.</param>
        /// 
        /// <returns>Returns a  ModifyVolumeResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyVolume">REST API Reference for ModifyVolume Operation</seealso>
        ModifyVolumeResponse EndModifyVolume(IAsyncResult asyncResult);

        #endregion
        
        #region  ModifyVolumeAttribute


        /// <summary>
        /// Modifies a volume attribute.
        /// 
        ///  
        /// <para>
        /// By default, all I/O operations for the volume are suspended when the data on the volume
        /// is determined to be potentially inconsistent, to prevent undetectable, latent data
        /// corruption. The I/O access to the volume can be resumed by first enabling I/O access
        /// and then checking the data consistency on your volume.
        /// </para>
        ///  
        /// <para>
        /// You can change the default behavior to resume I/O operations. We recommend that you
        /// change this only for boot volumes or for volumes that are stateless or disposable.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyVolumeAttribute service method.</param>
        /// 
        /// <returns>The response from the ModifyVolumeAttribute service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyVolumeAttribute">REST API Reference for ModifyVolumeAttribute Operation</seealso>
        ModifyVolumeAttributeResponse ModifyVolumeAttribute(ModifyVolumeAttributeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyVolumeAttribute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyVolumeAttribute operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyVolumeAttribute
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyVolumeAttribute">REST API Reference for ModifyVolumeAttribute Operation</seealso>
        IAsyncResult BeginModifyVolumeAttribute(ModifyVolumeAttributeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyVolumeAttribute operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyVolumeAttribute.</param>
        /// 
        /// <returns>Returns a  ModifyVolumeAttributeResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyVolumeAttribute">REST API Reference for ModifyVolumeAttribute Operation</seealso>
        ModifyVolumeAttributeResponse EndModifyVolumeAttribute(IAsyncResult asyncResult);

        #endregion
        
        #region  ModifyVpcAttribute


        /// <summary>
        /// Modifies the specified attribute of the specified VPC.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyVpcAttribute service method.</param>
        /// 
        /// <returns>The response from the ModifyVpcAttribute service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyVpcAttribute">REST API Reference for ModifyVpcAttribute Operation</seealso>
        ModifyVpcAttributeResponse ModifyVpcAttribute(ModifyVpcAttributeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyVpcAttribute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyVpcAttribute operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyVpcAttribute
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyVpcAttribute">REST API Reference for ModifyVpcAttribute Operation</seealso>
        IAsyncResult BeginModifyVpcAttribute(ModifyVpcAttributeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyVpcAttribute operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyVpcAttribute.</param>
        /// 
        /// <returns>Returns a  ModifyVpcAttributeResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyVpcAttribute">REST API Reference for ModifyVpcAttribute Operation</seealso>
        ModifyVpcAttributeResponse EndModifyVpcAttribute(IAsyncResult asyncResult);

        #endregion
        
        #region  ModifyVpcEndpoint


        /// <summary>
        /// Modifies attributes of a specified VPC endpoint. The attributes that you can modify
        /// depend on the type of VPC endpoint (interface or gateway). For more information, see
        /// <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/vpc-endpoints.html">VPC
        /// Endpoints</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyVpcEndpoint service method.</param>
        /// 
        /// <returns>The response from the ModifyVpcEndpoint service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyVpcEndpoint">REST API Reference for ModifyVpcEndpoint Operation</seealso>
        ModifyVpcEndpointResponse ModifyVpcEndpoint(ModifyVpcEndpointRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyVpcEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyVpcEndpoint operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyVpcEndpoint
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyVpcEndpoint">REST API Reference for ModifyVpcEndpoint Operation</seealso>
        IAsyncResult BeginModifyVpcEndpoint(ModifyVpcEndpointRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyVpcEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyVpcEndpoint.</param>
        /// 
        /// <returns>Returns a  ModifyVpcEndpointResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyVpcEndpoint">REST API Reference for ModifyVpcEndpoint Operation</seealso>
        ModifyVpcEndpointResponse EndModifyVpcEndpoint(IAsyncResult asyncResult);

        #endregion
        
        #region  ModifyVpcEndpointConnectionNotification


        /// <summary>
        /// Modifies a connection notification for VPC endpoint or VPC endpoint service. You can
        /// change the SNS topic for the notification, or the events for which to be notified.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyVpcEndpointConnectionNotification service method.</param>
        /// 
        /// <returns>The response from the ModifyVpcEndpointConnectionNotification service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyVpcEndpointConnectionNotification">REST API Reference for ModifyVpcEndpointConnectionNotification Operation</seealso>
        ModifyVpcEndpointConnectionNotificationResponse ModifyVpcEndpointConnectionNotification(ModifyVpcEndpointConnectionNotificationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyVpcEndpointConnectionNotification operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyVpcEndpointConnectionNotification operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyVpcEndpointConnectionNotification
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyVpcEndpointConnectionNotification">REST API Reference for ModifyVpcEndpointConnectionNotification Operation</seealso>
        IAsyncResult BeginModifyVpcEndpointConnectionNotification(ModifyVpcEndpointConnectionNotificationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyVpcEndpointConnectionNotification operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyVpcEndpointConnectionNotification.</param>
        /// 
        /// <returns>Returns a  ModifyVpcEndpointConnectionNotificationResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyVpcEndpointConnectionNotification">REST API Reference for ModifyVpcEndpointConnectionNotification Operation</seealso>
        ModifyVpcEndpointConnectionNotificationResponse EndModifyVpcEndpointConnectionNotification(IAsyncResult asyncResult);

        #endregion
        
        #region  ModifyVpcEndpointServiceConfiguration


        /// <summary>
        /// Modifies the attributes of your VPC endpoint service configuration. You can change
        /// the Network Load Balancers for your service, and you can specify whether acceptance
        /// is required for requests to connect to your endpoint service through an interface
        /// VPC endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyVpcEndpointServiceConfiguration service method.</param>
        /// 
        /// <returns>The response from the ModifyVpcEndpointServiceConfiguration service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyVpcEndpointServiceConfiguration">REST API Reference for ModifyVpcEndpointServiceConfiguration Operation</seealso>
        ModifyVpcEndpointServiceConfigurationResponse ModifyVpcEndpointServiceConfiguration(ModifyVpcEndpointServiceConfigurationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyVpcEndpointServiceConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyVpcEndpointServiceConfiguration operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyVpcEndpointServiceConfiguration
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyVpcEndpointServiceConfiguration">REST API Reference for ModifyVpcEndpointServiceConfiguration Operation</seealso>
        IAsyncResult BeginModifyVpcEndpointServiceConfiguration(ModifyVpcEndpointServiceConfigurationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyVpcEndpointServiceConfiguration operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyVpcEndpointServiceConfiguration.</param>
        /// 
        /// <returns>Returns a  ModifyVpcEndpointServiceConfigurationResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyVpcEndpointServiceConfiguration">REST API Reference for ModifyVpcEndpointServiceConfiguration Operation</seealso>
        ModifyVpcEndpointServiceConfigurationResponse EndModifyVpcEndpointServiceConfiguration(IAsyncResult asyncResult);

        #endregion
        
        #region  ModifyVpcEndpointServicePermissions


        /// <summary>
        /// Modifies the permissions for your <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/endpoint-service.html">VPC
        /// endpoint service</a>. You can add or remove permissions for service consumers (IAM
        /// users, IAM roles, and AWS accounts) to connect to your endpoint service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyVpcEndpointServicePermissions service method.</param>
        /// 
        /// <returns>The response from the ModifyVpcEndpointServicePermissions service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyVpcEndpointServicePermissions">REST API Reference for ModifyVpcEndpointServicePermissions Operation</seealso>
        ModifyVpcEndpointServicePermissionsResponse ModifyVpcEndpointServicePermissions(ModifyVpcEndpointServicePermissionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyVpcEndpointServicePermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyVpcEndpointServicePermissions operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyVpcEndpointServicePermissions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyVpcEndpointServicePermissions">REST API Reference for ModifyVpcEndpointServicePermissions Operation</seealso>
        IAsyncResult BeginModifyVpcEndpointServicePermissions(ModifyVpcEndpointServicePermissionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyVpcEndpointServicePermissions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyVpcEndpointServicePermissions.</param>
        /// 
        /// <returns>Returns a  ModifyVpcEndpointServicePermissionsResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyVpcEndpointServicePermissions">REST API Reference for ModifyVpcEndpointServicePermissions Operation</seealso>
        ModifyVpcEndpointServicePermissionsResponse EndModifyVpcEndpointServicePermissions(IAsyncResult asyncResult);

        #endregion
        
        #region  ModifyVpcPeeringConnectionOptions


        /// <summary>
        /// Modifies the VPC peering connection options on one side of a VPC peering connection.
        /// You can do the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// Enable/disable communication over the peering connection between an EC2-Classic instance
        /// that's linked to your VPC (using ClassicLink) and instances in the peer VPC.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Enable/disable communication over the peering connection between instances in your
        /// VPC and an EC2-Classic instance that's linked to the peer VPC.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Enable/disable the ability to resolve public DNS hostnames to private IP addresses
        /// when queried from instances in the peer VPC.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// If the peered VPCs are in different accounts, each owner must initiate a separate
        /// request to modify the peering connection options, depending on whether their VPC was
        /// the requester or accepter for the VPC peering connection. If the peered VPCs are in
        /// the same account, you can modify the requester and accepter options in the same request.
        /// To confirm which VPC is the accepter and requester for a VPC peering connection, use
        /// the <a>DescribeVpcPeeringConnections</a> command.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyVpcPeeringConnectionOptions service method.</param>
        /// 
        /// <returns>The response from the ModifyVpcPeeringConnectionOptions service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyVpcPeeringConnectionOptions">REST API Reference for ModifyVpcPeeringConnectionOptions Operation</seealso>
        ModifyVpcPeeringConnectionOptionsResponse ModifyVpcPeeringConnectionOptions(ModifyVpcPeeringConnectionOptionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyVpcPeeringConnectionOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyVpcPeeringConnectionOptions operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyVpcPeeringConnectionOptions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyVpcPeeringConnectionOptions">REST API Reference for ModifyVpcPeeringConnectionOptions Operation</seealso>
        IAsyncResult BeginModifyVpcPeeringConnectionOptions(ModifyVpcPeeringConnectionOptionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyVpcPeeringConnectionOptions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyVpcPeeringConnectionOptions.</param>
        /// 
        /// <returns>Returns a  ModifyVpcPeeringConnectionOptionsResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyVpcPeeringConnectionOptions">REST API Reference for ModifyVpcPeeringConnectionOptions Operation</seealso>
        ModifyVpcPeeringConnectionOptionsResponse EndModifyVpcPeeringConnectionOptions(IAsyncResult asyncResult);

        #endregion
        
        #region  ModifyVpcTenancy


        /// <summary>
        /// Modifies the instance tenancy attribute of the specified VPC. You can change the instance
        /// tenancy attribute of a VPC to <code>default</code> only. You cannot change the instance
        /// tenancy attribute to <code>dedicated</code>.
        /// 
        ///  
        /// <para>
        /// After you modify the tenancy of the VPC, any new instances that you launch into the
        /// VPC have a tenancy of <code>default</code>, unless you specify otherwise during launch.
        /// The tenancy of any existing instances in the VPC is not affected.
        /// </para>
        ///  
        /// <para>
        /// For more information about Dedicated Instances, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/dedicated-instance.html">Dedicated
        /// Instances</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyVpcTenancy service method.</param>
        /// 
        /// <returns>The response from the ModifyVpcTenancy service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyVpcTenancy">REST API Reference for ModifyVpcTenancy Operation</seealso>
        ModifyVpcTenancyResponse ModifyVpcTenancy(ModifyVpcTenancyRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyVpcTenancy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyVpcTenancy operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndModifyVpcTenancy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyVpcTenancy">REST API Reference for ModifyVpcTenancy Operation</seealso>
        IAsyncResult BeginModifyVpcTenancy(ModifyVpcTenancyRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyVpcTenancy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyVpcTenancy.</param>
        /// 
        /// <returns>Returns a  ModifyVpcTenancyResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyVpcTenancy">REST API Reference for ModifyVpcTenancy Operation</seealso>
        ModifyVpcTenancyResponse EndModifyVpcTenancy(IAsyncResult asyncResult);

        #endregion
        
        #region  MonitorInstances


        /// <summary>
        /// Enables detailed monitoring for a running instance. Otherwise, basic monitoring is
        /// enabled. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-cloudwatch.html">Monitoring
        /// Your Instances and Volumes</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// 
        ///  
        /// <para>
        /// To disable detailed monitoring, see .
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the MonitorInstances service method.</param>
        /// 
        /// <returns>The response from the MonitorInstances service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/MonitorInstances">REST API Reference for MonitorInstances Operation</seealso>
        MonitorInstancesResponse MonitorInstances(MonitorInstancesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the MonitorInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the MonitorInstances operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndMonitorInstances
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/MonitorInstances">REST API Reference for MonitorInstances Operation</seealso>
        IAsyncResult BeginMonitorInstances(MonitorInstancesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  MonitorInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginMonitorInstances.</param>
        /// 
        /// <returns>Returns a  MonitorInstancesResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/MonitorInstances">REST API Reference for MonitorInstances Operation</seealso>
        MonitorInstancesResponse EndMonitorInstances(IAsyncResult asyncResult);

        #endregion
        
        #region  MoveAddressToVpc


        /// <summary>
        /// Moves an Elastic IP address from the EC2-Classic platform to the EC2-VPC platform.
        /// The Elastic IP address must be allocated to your account for more than 24 hours, and
        /// it must not be associated with an instance. After the Elastic IP address is moved,
        /// it is no longer available for use in the EC2-Classic platform, unless you move it
        /// back using the <a>RestoreAddressToClassic</a> request. You cannot move an Elastic
        /// IP address that was originally allocated for use in the EC2-VPC platform to the EC2-Classic
        /// platform.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the MoveAddressToVpc service method.</param>
        /// 
        /// <returns>The response from the MoveAddressToVpc service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/MoveAddressToVpc">REST API Reference for MoveAddressToVpc Operation</seealso>
        MoveAddressToVpcResponse MoveAddressToVpc(MoveAddressToVpcRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the MoveAddressToVpc operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the MoveAddressToVpc operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndMoveAddressToVpc
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/MoveAddressToVpc">REST API Reference for MoveAddressToVpc Operation</seealso>
        IAsyncResult BeginMoveAddressToVpc(MoveAddressToVpcRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  MoveAddressToVpc operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginMoveAddressToVpc.</param>
        /// 
        /// <returns>Returns a  MoveAddressToVpcResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/MoveAddressToVpc">REST API Reference for MoveAddressToVpc Operation</seealso>
        MoveAddressToVpcResponse EndMoveAddressToVpc(IAsyncResult asyncResult);

        #endregion
        
        #region  PurchaseHostReservation


        /// <summary>
        /// Purchase a reservation with configurations that match those of your Dedicated Host.
        /// You must have active Dedicated Hosts in your account before you purchase a reservation.
        /// This action results in the specified reservation being purchased and charged to your
        /// account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PurchaseHostReservation service method.</param>
        /// 
        /// <returns>The response from the PurchaseHostReservation service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/PurchaseHostReservation">REST API Reference for PurchaseHostReservation Operation</seealso>
        PurchaseHostReservationResponse PurchaseHostReservation(PurchaseHostReservationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PurchaseHostReservation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PurchaseHostReservation operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPurchaseHostReservation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/PurchaseHostReservation">REST API Reference for PurchaseHostReservation Operation</seealso>
        IAsyncResult BeginPurchaseHostReservation(PurchaseHostReservationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PurchaseHostReservation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPurchaseHostReservation.</param>
        /// 
        /// <returns>Returns a  PurchaseHostReservationResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/PurchaseHostReservation">REST API Reference for PurchaseHostReservation Operation</seealso>
        PurchaseHostReservationResponse EndPurchaseHostReservation(IAsyncResult asyncResult);

        #endregion
        
        #region  PurchaseReservedInstancesOffering


        /// <summary>
        /// Purchases a Reserved Instance for use with your account. With Reserved Instances,
        /// you pay a lower hourly rate compared to On-Demand instance pricing.
        /// 
        ///  
        /// <para>
        /// Use <a>DescribeReservedInstancesOfferings</a> to get a list of Reserved Instance offerings
        /// that match your specifications. After you've purchased a Reserved Instance, you can
        /// check for your new Reserved Instance with <a>DescribeReservedInstances</a>.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/concepts-on-demand-reserved-instances.html">Reserved
        /// Instances</a> and <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ri-market-general.html">Reserved
        /// Instance Marketplace</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PurchaseReservedInstancesOffering service method.</param>
        /// 
        /// <returns>The response from the PurchaseReservedInstancesOffering service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/PurchaseReservedInstancesOffering">REST API Reference for PurchaseReservedInstancesOffering Operation</seealso>
        PurchaseReservedInstancesOfferingResponse PurchaseReservedInstancesOffering(PurchaseReservedInstancesOfferingRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PurchaseReservedInstancesOffering operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PurchaseReservedInstancesOffering operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPurchaseReservedInstancesOffering
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/PurchaseReservedInstancesOffering">REST API Reference for PurchaseReservedInstancesOffering Operation</seealso>
        IAsyncResult BeginPurchaseReservedInstancesOffering(PurchaseReservedInstancesOfferingRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PurchaseReservedInstancesOffering operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPurchaseReservedInstancesOffering.</param>
        /// 
        /// <returns>Returns a  PurchaseReservedInstancesOfferingResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/PurchaseReservedInstancesOffering">REST API Reference for PurchaseReservedInstancesOffering Operation</seealso>
        PurchaseReservedInstancesOfferingResponse EndPurchaseReservedInstancesOffering(IAsyncResult asyncResult);

        #endregion
        
        #region  PurchaseScheduledInstances


        /// <summary>
        /// Purchases one or more Scheduled Instances with the specified schedule.
        /// 
        ///  
        /// <para>
        /// Scheduled Instances enable you to purchase Amazon EC2 compute capacity by the hour
        /// for a one-year term. Before you can purchase a Scheduled Instance, you must call <a>DescribeScheduledInstanceAvailability</a>
        /// to check for available schedules and obtain a purchase token. After you purchase a
        /// Scheduled Instance, you must call <a>RunScheduledInstances</a> during each scheduled
        /// time period.
        /// </para>
        ///  
        /// <para>
        /// After you purchase a Scheduled Instance, you can't cancel, modify, or resell your
        /// purchase.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PurchaseScheduledInstances service method.</param>
        /// 
        /// <returns>The response from the PurchaseScheduledInstances service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/PurchaseScheduledInstances">REST API Reference for PurchaseScheduledInstances Operation</seealso>
        PurchaseScheduledInstancesResponse PurchaseScheduledInstances(PurchaseScheduledInstancesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PurchaseScheduledInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PurchaseScheduledInstances operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPurchaseScheduledInstances
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/PurchaseScheduledInstances">REST API Reference for PurchaseScheduledInstances Operation</seealso>
        IAsyncResult BeginPurchaseScheduledInstances(PurchaseScheduledInstancesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PurchaseScheduledInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPurchaseScheduledInstances.</param>
        /// 
        /// <returns>Returns a  PurchaseScheduledInstancesResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/PurchaseScheduledInstances">REST API Reference for PurchaseScheduledInstances Operation</seealso>
        PurchaseScheduledInstancesResponse EndPurchaseScheduledInstances(IAsyncResult asyncResult);

        #endregion
        
        #region  RebootInstances


        /// <summary>
        /// Requests a reboot of one or more instances. This operation is asynchronous; it only
        /// queues a request to reboot the specified instances. The operation succeeds if the
        /// instances are valid and belong to you. Requests to reboot terminated instances are
        /// ignored.
        /// 
        ///  
        /// <para>
        /// If an instance does not cleanly shut down within four minutes, Amazon EC2 performs
        /// a hard reboot.
        /// </para>
        ///  
        /// <para>
        /// For more information about troubleshooting, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-console.html">Getting
        /// Console Output and Rebooting Instances</a> in the <i>Amazon Elastic Compute Cloud
        /// User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RebootInstances service method.</param>
        /// 
        /// <returns>The response from the RebootInstances service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RebootInstances">REST API Reference for RebootInstances Operation</seealso>
        RebootInstancesResponse RebootInstances(RebootInstancesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RebootInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RebootInstances operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRebootInstances
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RebootInstances">REST API Reference for RebootInstances Operation</seealso>
        IAsyncResult BeginRebootInstances(RebootInstancesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RebootInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRebootInstances.</param>
        /// 
        /// <returns>Returns a  RebootInstancesResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RebootInstances">REST API Reference for RebootInstances Operation</seealso>
        RebootInstancesResponse EndRebootInstances(IAsyncResult asyncResult);

        #endregion
        
        #region  RegisterImage


        /// <summary>
        /// Registers an AMI. When you're creating an AMI, this is the final step you must complete
        /// before you can launch an instance from the AMI. For more information about creating
        /// AMIs, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/creating-an-ami.html">Creating
        /// Your Own AMIs</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// 
        ///  <note> 
        /// <para>
        /// For Amazon EBS-backed instances, <a>CreateImage</a> creates and registers the AMI
        /// in a single request, so you don't have to register the AMI yourself.
        /// </para>
        ///  </note> 
        /// <para>
        /// You can also use <code>RegisterImage</code> to create an Amazon EBS-backed Linux AMI
        /// from a snapshot of a root device volume. You specify the snapshot using the block
        /// device mapping. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-launch-snapshot.html">Launching
        /// a Linux Instance from a Backup</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// You can't register an image where a secondary (non-root) snapshot has AWS Marketplace
        /// product codes.
        /// </para>
        ///  
        /// <para>
        /// Some Linux distributions, such as Red Hat Enterprise Linux (RHEL) and SUSE Linux Enterprise
        /// Server (SLES), use the EC2 billing product code associated with an AMI to verify the
        /// subscription status for package updates. Creating an AMI from an EBS snapshot does
        /// not maintain this billing code, and subsequent instances launched from such an AMI
        /// will not be able to connect to package update infrastructure. To create an AMI that
        /// must retain billing codes, see <a>CreateImage</a>.
        /// </para>
        ///  
        /// <para>
        /// If needed, you can deregister an AMI at any time. Any modifications you make to an
        /// AMI backed by an instance store volume invalidates its registration. If you make changes
        /// to an image, deregister the previous image and register the new image.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterImage service method.</param>
        /// 
        /// <returns>The response from the RegisterImage service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RegisterImage">REST API Reference for RegisterImage Operation</seealso>
        RegisterImageResponse RegisterImage(RegisterImageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterImage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterImage operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegisterImage
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RegisterImage">REST API Reference for RegisterImage Operation</seealso>
        IAsyncResult BeginRegisterImage(RegisterImageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterImage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterImage.</param>
        /// 
        /// <returns>Returns a  RegisterImageResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RegisterImage">REST API Reference for RegisterImage Operation</seealso>
        RegisterImageResponse EndRegisterImage(IAsyncResult asyncResult);

        #endregion
        
        #region  RejectVpcEndpointConnections


        /// <summary>
        /// Rejects one or more VPC endpoint connection requests to your VPC endpoint service.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RejectVpcEndpointConnections service method.</param>
        /// 
        /// <returns>The response from the RejectVpcEndpointConnections service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RejectVpcEndpointConnections">REST API Reference for RejectVpcEndpointConnections Operation</seealso>
        RejectVpcEndpointConnectionsResponse RejectVpcEndpointConnections(RejectVpcEndpointConnectionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RejectVpcEndpointConnections operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RejectVpcEndpointConnections operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRejectVpcEndpointConnections
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RejectVpcEndpointConnections">REST API Reference for RejectVpcEndpointConnections Operation</seealso>
        IAsyncResult BeginRejectVpcEndpointConnections(RejectVpcEndpointConnectionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RejectVpcEndpointConnections operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRejectVpcEndpointConnections.</param>
        /// 
        /// <returns>Returns a  RejectVpcEndpointConnectionsResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RejectVpcEndpointConnections">REST API Reference for RejectVpcEndpointConnections Operation</seealso>
        RejectVpcEndpointConnectionsResponse EndRejectVpcEndpointConnections(IAsyncResult asyncResult);

        #endregion
        
        #region  RejectVpcPeeringConnection


        /// <summary>
        /// Rejects a VPC peering connection request. The VPC peering connection must be in the
        /// <code>pending-acceptance</code> state. Use the <a>DescribeVpcPeeringConnections</a>
        /// request to view your outstanding VPC peering connection requests. To delete an active
        /// VPC peering connection, or to delete a VPC peering connection request that you initiated,
        /// use <a>DeleteVpcPeeringConnection</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RejectVpcPeeringConnection service method.</param>
        /// 
        /// <returns>The response from the RejectVpcPeeringConnection service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RejectVpcPeeringConnection">REST API Reference for RejectVpcPeeringConnection Operation</seealso>
        RejectVpcPeeringConnectionResponse RejectVpcPeeringConnection(RejectVpcPeeringConnectionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RejectVpcPeeringConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RejectVpcPeeringConnection operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRejectVpcPeeringConnection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RejectVpcPeeringConnection">REST API Reference for RejectVpcPeeringConnection Operation</seealso>
        IAsyncResult BeginRejectVpcPeeringConnection(RejectVpcPeeringConnectionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RejectVpcPeeringConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRejectVpcPeeringConnection.</param>
        /// 
        /// <returns>Returns a  RejectVpcPeeringConnectionResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RejectVpcPeeringConnection">REST API Reference for RejectVpcPeeringConnection Operation</seealso>
        RejectVpcPeeringConnectionResponse EndRejectVpcPeeringConnection(IAsyncResult asyncResult);

        #endregion
        
        #region  ReleaseAddress


        /// <summary>
        /// Releases the specified Elastic IP address.
        /// 
        ///  
        /// <para>
        /// [EC2-Classic, default VPC] Releasing an Elastic IP address automatically disassociates
        /// it from any instance that it's associated with. To disassociate an Elastic IP address
        /// without releasing it, use <a>DisassociateAddress</a>.
        /// </para>
        ///  
        /// <para>
        /// [Nondefault VPC] You must use <a>DisassociateAddress</a> to disassociate the Elastic
        /// IP address before you can release it. Otherwise, Amazon EC2 returns an error (<code>InvalidIPAddress.InUse</code>).
        /// </para>
        ///  
        /// <para>
        /// After releasing an Elastic IP address, it is released to the IP address pool. Be sure
        /// to update your DNS records and any servers or devices that communicate with the address.
        /// If you attempt to release an Elastic IP address that you already released, you'll
        /// get an <code>AuthFailure</code> error if the address is already allocated to another
        /// AWS account.
        /// </para>
        ///  
        /// <para>
        /// [EC2-VPC] After you release an Elastic IP address for use in a VPC, you might be able
        /// to recover it. For more information, see <a>AllocateAddress</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReleaseAddress service method.</param>
        /// 
        /// <returns>The response from the ReleaseAddress service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ReleaseAddress">REST API Reference for ReleaseAddress Operation</seealso>
        ReleaseAddressResponse ReleaseAddress(ReleaseAddressRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ReleaseAddress operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReleaseAddress operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndReleaseAddress
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ReleaseAddress">REST API Reference for ReleaseAddress Operation</seealso>
        IAsyncResult BeginReleaseAddress(ReleaseAddressRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ReleaseAddress operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginReleaseAddress.</param>
        /// 
        /// <returns>Returns a  ReleaseAddressResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ReleaseAddress">REST API Reference for ReleaseAddress Operation</seealso>
        ReleaseAddressResponse EndReleaseAddress(IAsyncResult asyncResult);

        #endregion
        
        #region  ReleaseHosts


        /// <summary>
        /// When you no longer want to use an On-Demand Dedicated Host it can be released. On-Demand
        /// billing is stopped and the host goes into <code>released</code> state. The host ID
        /// of Dedicated Hosts that have been released can no longer be specified in another request,
        /// e.g., ModifyHosts. You must stop or terminate all instances on a host before it can
        /// be released.
        /// 
        ///  
        /// <para>
        /// When Dedicated Hosts are released, it make take some time for them to stop counting
        /// toward your limit and you may receive capacity errors when trying to allocate new
        /// Dedicated hosts. Try waiting a few minutes, and then try again.
        /// </para>
        ///  
        /// <para>
        /// Released hosts will still appear in a <a>DescribeHosts</a> response.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReleaseHosts service method.</param>
        /// 
        /// <returns>The response from the ReleaseHosts service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ReleaseHosts">REST API Reference for ReleaseHosts Operation</seealso>
        ReleaseHostsResponse ReleaseHosts(ReleaseHostsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ReleaseHosts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReleaseHosts operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndReleaseHosts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ReleaseHosts">REST API Reference for ReleaseHosts Operation</seealso>
        IAsyncResult BeginReleaseHosts(ReleaseHostsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ReleaseHosts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginReleaseHosts.</param>
        /// 
        /// <returns>Returns a  ReleaseHostsResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ReleaseHosts">REST API Reference for ReleaseHosts Operation</seealso>
        ReleaseHostsResponse EndReleaseHosts(IAsyncResult asyncResult);

        #endregion
        
        #region  ReplaceIamInstanceProfileAssociation


        /// <summary>
        /// Replaces an IAM instance profile for the specified running instance. You can use this
        /// action to change the IAM instance profile that's associated with an instance without
        /// having to disassociate the existing IAM instance profile first.
        /// 
        ///  
        /// <para>
        /// Use <a>DescribeIamInstanceProfileAssociations</a> to get the association ID.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReplaceIamInstanceProfileAssociation service method.</param>
        /// 
        /// <returns>The response from the ReplaceIamInstanceProfileAssociation service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ReplaceIamInstanceProfileAssociation">REST API Reference for ReplaceIamInstanceProfileAssociation Operation</seealso>
        ReplaceIamInstanceProfileAssociationResponse ReplaceIamInstanceProfileAssociation(ReplaceIamInstanceProfileAssociationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ReplaceIamInstanceProfileAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReplaceIamInstanceProfileAssociation operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndReplaceIamInstanceProfileAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ReplaceIamInstanceProfileAssociation">REST API Reference for ReplaceIamInstanceProfileAssociation Operation</seealso>
        IAsyncResult BeginReplaceIamInstanceProfileAssociation(ReplaceIamInstanceProfileAssociationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ReplaceIamInstanceProfileAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginReplaceIamInstanceProfileAssociation.</param>
        /// 
        /// <returns>Returns a  ReplaceIamInstanceProfileAssociationResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ReplaceIamInstanceProfileAssociation">REST API Reference for ReplaceIamInstanceProfileAssociation Operation</seealso>
        ReplaceIamInstanceProfileAssociationResponse EndReplaceIamInstanceProfileAssociation(IAsyncResult asyncResult);

        #endregion
        
        #region  ReplaceNetworkAclAssociation


        /// <summary>
        /// Changes which network ACL a subnet is associated with. By default when you create
        /// a subnet, it's automatically associated with the default network ACL. For more information
        /// about network ACLs, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_ACLs.html">Network
        /// ACLs</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// 
        ///  
        /// <para>
        /// This is an idempotent operation.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReplaceNetworkAclAssociation service method.</param>
        /// 
        /// <returns>The response from the ReplaceNetworkAclAssociation service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ReplaceNetworkAclAssociation">REST API Reference for ReplaceNetworkAclAssociation Operation</seealso>
        ReplaceNetworkAclAssociationResponse ReplaceNetworkAclAssociation(ReplaceNetworkAclAssociationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ReplaceNetworkAclAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReplaceNetworkAclAssociation operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndReplaceNetworkAclAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ReplaceNetworkAclAssociation">REST API Reference for ReplaceNetworkAclAssociation Operation</seealso>
        IAsyncResult BeginReplaceNetworkAclAssociation(ReplaceNetworkAclAssociationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ReplaceNetworkAclAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginReplaceNetworkAclAssociation.</param>
        /// 
        /// <returns>Returns a  ReplaceNetworkAclAssociationResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ReplaceNetworkAclAssociation">REST API Reference for ReplaceNetworkAclAssociation Operation</seealso>
        ReplaceNetworkAclAssociationResponse EndReplaceNetworkAclAssociation(IAsyncResult asyncResult);

        #endregion
        
        #region  ReplaceNetworkAclEntry


        /// <summary>
        /// Replaces an entry (rule) in a network ACL. For more information about network ACLs,
        /// see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_ACLs.html">Network
        /// ACLs</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReplaceNetworkAclEntry service method.</param>
        /// 
        /// <returns>The response from the ReplaceNetworkAclEntry service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ReplaceNetworkAclEntry">REST API Reference for ReplaceNetworkAclEntry Operation</seealso>
        ReplaceNetworkAclEntryResponse ReplaceNetworkAclEntry(ReplaceNetworkAclEntryRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ReplaceNetworkAclEntry operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReplaceNetworkAclEntry operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndReplaceNetworkAclEntry
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ReplaceNetworkAclEntry">REST API Reference for ReplaceNetworkAclEntry Operation</seealso>
        IAsyncResult BeginReplaceNetworkAclEntry(ReplaceNetworkAclEntryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ReplaceNetworkAclEntry operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginReplaceNetworkAclEntry.</param>
        /// 
        /// <returns>Returns a  ReplaceNetworkAclEntryResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ReplaceNetworkAclEntry">REST API Reference for ReplaceNetworkAclEntry Operation</seealso>
        ReplaceNetworkAclEntryResponse EndReplaceNetworkAclEntry(IAsyncResult asyncResult);

        #endregion
        
        #region  ReplaceRoute


        /// <summary>
        /// Replaces an existing route within a route table in a VPC. You must provide only one
        /// of the following: Internet gateway or virtual private gateway, NAT instance, NAT gateway,
        /// VPC peering connection, network interface, or egress-only Internet gateway.
        /// 
        ///  
        /// <para>
        /// For more information about route tables, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Route_Tables.html">Route
        /// Tables</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReplaceRoute service method.</param>
        /// 
        /// <returns>The response from the ReplaceRoute service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ReplaceRoute">REST API Reference for ReplaceRoute Operation</seealso>
        ReplaceRouteResponse ReplaceRoute(ReplaceRouteRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ReplaceRoute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReplaceRoute operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndReplaceRoute
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ReplaceRoute">REST API Reference for ReplaceRoute Operation</seealso>
        IAsyncResult BeginReplaceRoute(ReplaceRouteRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ReplaceRoute operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginReplaceRoute.</param>
        /// 
        /// <returns>Returns a  ReplaceRouteResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ReplaceRoute">REST API Reference for ReplaceRoute Operation</seealso>
        ReplaceRouteResponse EndReplaceRoute(IAsyncResult asyncResult);

        #endregion
        
        #region  ReplaceRouteTableAssociation


        /// <summary>
        /// Changes the route table associated with a given subnet in a VPC. After the operation
        /// completes, the subnet uses the routes in the new route table it's associated with.
        /// For more information about route tables, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Route_Tables.html">Route
        /// Tables</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// 
        ///  
        /// <para>
        /// You can also use ReplaceRouteTableAssociation to change which table is the main route
        /// table in the VPC. You just specify the main route table's association ID and the route
        /// table to be the new main route table.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReplaceRouteTableAssociation service method.</param>
        /// 
        /// <returns>The response from the ReplaceRouteTableAssociation service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ReplaceRouteTableAssociation">REST API Reference for ReplaceRouteTableAssociation Operation</seealso>
        ReplaceRouteTableAssociationResponse ReplaceRouteTableAssociation(ReplaceRouteTableAssociationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ReplaceRouteTableAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReplaceRouteTableAssociation operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndReplaceRouteTableAssociation
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ReplaceRouteTableAssociation">REST API Reference for ReplaceRouteTableAssociation Operation</seealso>
        IAsyncResult BeginReplaceRouteTableAssociation(ReplaceRouteTableAssociationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ReplaceRouteTableAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginReplaceRouteTableAssociation.</param>
        /// 
        /// <returns>Returns a  ReplaceRouteTableAssociationResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ReplaceRouteTableAssociation">REST API Reference for ReplaceRouteTableAssociation Operation</seealso>
        ReplaceRouteTableAssociationResponse EndReplaceRouteTableAssociation(IAsyncResult asyncResult);

        #endregion
        
        #region  ReportInstanceStatus


        /// <summary>
        /// Submits feedback about the status of an instance. The instance must be in the <code>running</code>
        /// state. If your experience with the instance differs from the instance status returned
        /// by <a>DescribeInstanceStatus</a>, use <a>ReportInstanceStatus</a> to report your experience
        /// with the instance. Amazon EC2 collects this information to improve the accuracy of
        /// status checks.
        /// 
        ///  
        /// <para>
        /// Use of this action does not change the value returned by <a>DescribeInstanceStatus</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReportInstanceStatus service method.</param>
        /// 
        /// <returns>The response from the ReportInstanceStatus service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ReportInstanceStatus">REST API Reference for ReportInstanceStatus Operation</seealso>
        ReportInstanceStatusResponse ReportInstanceStatus(ReportInstanceStatusRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ReportInstanceStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReportInstanceStatus operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndReportInstanceStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ReportInstanceStatus">REST API Reference for ReportInstanceStatus Operation</seealso>
        IAsyncResult BeginReportInstanceStatus(ReportInstanceStatusRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ReportInstanceStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginReportInstanceStatus.</param>
        /// 
        /// <returns>Returns a  ReportInstanceStatusResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ReportInstanceStatus">REST API Reference for ReportInstanceStatus Operation</seealso>
        ReportInstanceStatusResponse EndReportInstanceStatus(IAsyncResult asyncResult);

        #endregion
        
        #region  RequestSpotFleet


        /// <summary>
        /// Creates a Spot Fleet request.
        /// 
        ///  
        /// <para>
        /// The Spot Fleet request specifies the total target capacity and the On-Demand target
        /// capacity. Amazon EC2 calculates the difference between the total capacity and On-Demand
        /// capacity, and launches the difference as Spot capacity.
        /// </para>
        ///  
        /// <para>
        /// You can submit a single request that includes multiple launch specifications that
        /// vary by instance type, AMI, Availability Zone, or subnet.
        /// </para>
        ///  
        /// <para>
        /// By default, the Spot Fleet requests Spot Instances in the Spot pool where the price
        /// per unit is the lowest. Each launch specification can include its own instance weighting
        /// that reflects the value of the instance type to your application workload.
        /// </para>
        ///  
        /// <para>
        /// Alternatively, you can specify that the Spot Fleet distribute the target capacity
        /// across the Spot pools included in its launch specifications. By ensuring that the
        /// Spot Instances in your Spot Fleet are in different Spot pools, you can improve the
        /// availability of your fleet.
        /// </para>
        ///  
        /// <para>
        /// You can specify tags for the Spot Instances. You cannot tag other resource types in
        /// a Spot Fleet request because only the <code>instance</code> resource type is supported.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/spot-fleet-requests.html">Spot
        /// Fleet Requests</a> in the <i>Amazon EC2 User Guide for Linux Instances</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RequestSpotFleet service method.</param>
        /// 
        /// <returns>The response from the RequestSpotFleet service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RequestSpotFleet">REST API Reference for RequestSpotFleet Operation</seealso>
        RequestSpotFleetResponse RequestSpotFleet(RequestSpotFleetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RequestSpotFleet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RequestSpotFleet operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRequestSpotFleet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RequestSpotFleet">REST API Reference for RequestSpotFleet Operation</seealso>
        IAsyncResult BeginRequestSpotFleet(RequestSpotFleetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RequestSpotFleet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRequestSpotFleet.</param>
        /// 
        /// <returns>Returns a  RequestSpotFleetResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RequestSpotFleet">REST API Reference for RequestSpotFleet Operation</seealso>
        RequestSpotFleetResponse EndRequestSpotFleet(IAsyncResult asyncResult);

        #endregion
        
        #region  RequestSpotInstances


        /// <summary>
        /// Creates a Spot Instance request.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/spot-requests.html">Spot
        /// Instance Requests</a> in the <i>Amazon EC2 User Guide for Linux Instances</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RequestSpotInstances service method.</param>
        /// 
        /// <returns>The response from the RequestSpotInstances service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RequestSpotInstances">REST API Reference for RequestSpotInstances Operation</seealso>
        RequestSpotInstancesResponse RequestSpotInstances(RequestSpotInstancesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RequestSpotInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RequestSpotInstances operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRequestSpotInstances
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RequestSpotInstances">REST API Reference for RequestSpotInstances Operation</seealso>
        IAsyncResult BeginRequestSpotInstances(RequestSpotInstancesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RequestSpotInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRequestSpotInstances.</param>
        /// 
        /// <returns>Returns a  RequestSpotInstancesResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RequestSpotInstances">REST API Reference for RequestSpotInstances Operation</seealso>
        RequestSpotInstancesResponse EndRequestSpotInstances(IAsyncResult asyncResult);

        #endregion
        
        #region  ResetFpgaImageAttribute


        /// <summary>
        /// Resets the specified attribute of the specified Amazon FPGA Image (AFI) to its default
        /// value. You can only reset the load permission attribute.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetFpgaImageAttribute service method.</param>
        /// 
        /// <returns>The response from the ResetFpgaImageAttribute service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ResetFpgaImageAttribute">REST API Reference for ResetFpgaImageAttribute Operation</seealso>
        ResetFpgaImageAttributeResponse ResetFpgaImageAttribute(ResetFpgaImageAttributeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ResetFpgaImageAttribute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetFpgaImageAttribute operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndResetFpgaImageAttribute
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ResetFpgaImageAttribute">REST API Reference for ResetFpgaImageAttribute Operation</seealso>
        IAsyncResult BeginResetFpgaImageAttribute(ResetFpgaImageAttributeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ResetFpgaImageAttribute operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResetFpgaImageAttribute.</param>
        /// 
        /// <returns>Returns a  ResetFpgaImageAttributeResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ResetFpgaImageAttribute">REST API Reference for ResetFpgaImageAttribute Operation</seealso>
        ResetFpgaImageAttributeResponse EndResetFpgaImageAttribute(IAsyncResult asyncResult);

        #endregion
        
        #region  ResetImageAttribute


        /// <summary>
        /// Resets an attribute of an AMI to its default value.
        /// 
        ///  <note> 
        /// <para>
        /// The productCodes attribute can't be reset.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetImageAttribute service method.</param>
        /// 
        /// <returns>The response from the ResetImageAttribute service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ResetImageAttribute">REST API Reference for ResetImageAttribute Operation</seealso>
        ResetImageAttributeResponse ResetImageAttribute(ResetImageAttributeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ResetImageAttribute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetImageAttribute operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndResetImageAttribute
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ResetImageAttribute">REST API Reference for ResetImageAttribute Operation</seealso>
        IAsyncResult BeginResetImageAttribute(ResetImageAttributeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ResetImageAttribute operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResetImageAttribute.</param>
        /// 
        /// <returns>Returns a  ResetImageAttributeResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ResetImageAttribute">REST API Reference for ResetImageAttribute Operation</seealso>
        ResetImageAttributeResponse EndResetImageAttribute(IAsyncResult asyncResult);

        #endregion
        
        #region  ResetInstanceAttribute


        /// <summary>
        /// Resets an attribute of an instance to its default value. To reset the <code>kernel</code>
        /// or <code>ramdisk</code>, the instance must be in a stopped state. To reset the <code>sourceDestCheck</code>,
        /// the instance can be either running or stopped.
        /// 
        ///  
        /// <para>
        /// The <code>sourceDestCheck</code> attribute controls whether source/destination checking
        /// is enabled. The default value is <code>true</code>, which means checking is enabled.
        /// This value must be <code>false</code> for a NAT instance to perform NAT. For more
        /// information, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_NAT_Instance.html">NAT
        /// Instances</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetInstanceAttribute service method.</param>
        /// 
        /// <returns>The response from the ResetInstanceAttribute service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ResetInstanceAttribute">REST API Reference for ResetInstanceAttribute Operation</seealso>
        ResetInstanceAttributeResponse ResetInstanceAttribute(ResetInstanceAttributeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ResetInstanceAttribute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetInstanceAttribute operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndResetInstanceAttribute
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ResetInstanceAttribute">REST API Reference for ResetInstanceAttribute Operation</seealso>
        IAsyncResult BeginResetInstanceAttribute(ResetInstanceAttributeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ResetInstanceAttribute operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResetInstanceAttribute.</param>
        /// 
        /// <returns>Returns a  ResetInstanceAttributeResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ResetInstanceAttribute">REST API Reference for ResetInstanceAttribute Operation</seealso>
        ResetInstanceAttributeResponse EndResetInstanceAttribute(IAsyncResult asyncResult);

        #endregion
        
        #region  ResetNetworkInterfaceAttribute


        /// <summary>
        /// Resets a network interface attribute. You can specify only one attribute at a time.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetNetworkInterfaceAttribute service method.</param>
        /// 
        /// <returns>The response from the ResetNetworkInterfaceAttribute service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ResetNetworkInterfaceAttribute">REST API Reference for ResetNetworkInterfaceAttribute Operation</seealso>
        ResetNetworkInterfaceAttributeResponse ResetNetworkInterfaceAttribute(ResetNetworkInterfaceAttributeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ResetNetworkInterfaceAttribute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetNetworkInterfaceAttribute operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndResetNetworkInterfaceAttribute
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ResetNetworkInterfaceAttribute">REST API Reference for ResetNetworkInterfaceAttribute Operation</seealso>
        IAsyncResult BeginResetNetworkInterfaceAttribute(ResetNetworkInterfaceAttributeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ResetNetworkInterfaceAttribute operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResetNetworkInterfaceAttribute.</param>
        /// 
        /// <returns>Returns a  ResetNetworkInterfaceAttributeResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ResetNetworkInterfaceAttribute">REST API Reference for ResetNetworkInterfaceAttribute Operation</seealso>
        ResetNetworkInterfaceAttributeResponse EndResetNetworkInterfaceAttribute(IAsyncResult asyncResult);

        #endregion
        
        #region  ResetSnapshotAttribute


        /// <summary>
        /// Resets permission settings for the specified snapshot.
        /// 
        ///  
        /// <para>
        /// For more information on modifying snapshot permissions, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-modifying-snapshot-permissions.html">Sharing
        /// Snapshots</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetSnapshotAttribute service method.</param>
        /// 
        /// <returns>The response from the ResetSnapshotAttribute service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ResetSnapshotAttribute">REST API Reference for ResetSnapshotAttribute Operation</seealso>
        ResetSnapshotAttributeResponse ResetSnapshotAttribute(ResetSnapshotAttributeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ResetSnapshotAttribute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetSnapshotAttribute operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndResetSnapshotAttribute
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ResetSnapshotAttribute">REST API Reference for ResetSnapshotAttribute Operation</seealso>
        IAsyncResult BeginResetSnapshotAttribute(ResetSnapshotAttributeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ResetSnapshotAttribute operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResetSnapshotAttribute.</param>
        /// 
        /// <returns>Returns a  ResetSnapshotAttributeResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ResetSnapshotAttribute">REST API Reference for ResetSnapshotAttribute Operation</seealso>
        ResetSnapshotAttributeResponse EndResetSnapshotAttribute(IAsyncResult asyncResult);

        #endregion
        
        #region  RestoreAddressToClassic


        /// <summary>
        /// Restores an Elastic IP address that was previously moved to the EC2-VPC platform back
        /// to the EC2-Classic platform. You cannot move an Elastic IP address that was originally
        /// allocated for use in EC2-VPC. The Elastic IP address must not be associated with an
        /// instance or network interface.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreAddressToClassic service method.</param>
        /// 
        /// <returns>The response from the RestoreAddressToClassic service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RestoreAddressToClassic">REST API Reference for RestoreAddressToClassic Operation</seealso>
        RestoreAddressToClassicResponse RestoreAddressToClassic(RestoreAddressToClassicRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RestoreAddressToClassic operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RestoreAddressToClassic operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRestoreAddressToClassic
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RestoreAddressToClassic">REST API Reference for RestoreAddressToClassic Operation</seealso>
        IAsyncResult BeginRestoreAddressToClassic(RestoreAddressToClassicRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RestoreAddressToClassic operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRestoreAddressToClassic.</param>
        /// 
        /// <returns>Returns a  RestoreAddressToClassicResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RestoreAddressToClassic">REST API Reference for RestoreAddressToClassic Operation</seealso>
        RestoreAddressToClassicResponse EndRestoreAddressToClassic(IAsyncResult asyncResult);

        #endregion
        
        #region  RevokeSecurityGroupEgress


        /// <summary>
        /// [EC2-VPC only] Removes one or more egress rules from a security group for EC2-VPC.
        /// This action doesn't apply to security groups for use in EC2-Classic. To remove a rule,
        /// the values that you specify (for example, ports) must match the existing rule's values
        /// exactly.
        /// 
        ///  
        /// <para>
        /// Each rule consists of the protocol and the IPv4 or IPv6 CIDR range or source security
        /// group. For the TCP and UDP protocols, you must also specify the destination port or
        /// range of ports. For the ICMP protocol, you must also specify the ICMP type and code.
        /// If the security group rule has a description, you do not have to specify the description
        /// to revoke the rule.
        /// </para>
        ///  
        /// <para>
        /// Rule changes are propagated to instances within the security group as quickly as possible.
        /// However, a small delay might occur.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RevokeSecurityGroupEgress service method.</param>
        /// 
        /// <returns>The response from the RevokeSecurityGroupEgress service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RevokeSecurityGroupEgress">REST API Reference for RevokeSecurityGroupEgress Operation</seealso>
        RevokeSecurityGroupEgressResponse RevokeSecurityGroupEgress(RevokeSecurityGroupEgressRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RevokeSecurityGroupEgress operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RevokeSecurityGroupEgress operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRevokeSecurityGroupEgress
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RevokeSecurityGroupEgress">REST API Reference for RevokeSecurityGroupEgress Operation</seealso>
        IAsyncResult BeginRevokeSecurityGroupEgress(RevokeSecurityGroupEgressRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RevokeSecurityGroupEgress operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRevokeSecurityGroupEgress.</param>
        /// 
        /// <returns>Returns a  RevokeSecurityGroupEgressResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RevokeSecurityGroupEgress">REST API Reference for RevokeSecurityGroupEgress Operation</seealso>
        RevokeSecurityGroupEgressResponse EndRevokeSecurityGroupEgress(IAsyncResult asyncResult);

        #endregion
        
        #region  RevokeSecurityGroupIngress


        /// <summary>
        /// Removes one or more ingress rules from a security group. To remove a rule, the values
        /// that you specify (for example, ports) must match the existing rule's values exactly.
        /// 
        ///  <note> 
        /// <para>
        /// [EC2-Classic security groups only] If the values you specify do not match the existing
        /// rule's values, no error is returned. Use <a>DescribeSecurityGroups</a> to verify that
        /// the rule has been removed.
        /// </para>
        ///  </note> 
        /// <para>
        /// Each rule consists of the protocol and the CIDR range or source security group. For
        /// the TCP and UDP protocols, you must also specify the destination port or range of
        /// ports. For the ICMP protocol, you must also specify the ICMP type and code. If the
        /// security group rule has a description, you do not have to specify the description
        /// to revoke the rule.
        /// </para>
        ///  
        /// <para>
        /// Rule changes are propagated to instances within the security group as quickly as possible.
        /// However, a small delay might occur.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RevokeSecurityGroupIngress service method.</param>
        /// 
        /// <returns>The response from the RevokeSecurityGroupIngress service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RevokeSecurityGroupIngress">REST API Reference for RevokeSecurityGroupIngress Operation</seealso>
        RevokeSecurityGroupIngressResponse RevokeSecurityGroupIngress(RevokeSecurityGroupIngressRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RevokeSecurityGroupIngress operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RevokeSecurityGroupIngress operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRevokeSecurityGroupIngress
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RevokeSecurityGroupIngress">REST API Reference for RevokeSecurityGroupIngress Operation</seealso>
        IAsyncResult BeginRevokeSecurityGroupIngress(RevokeSecurityGroupIngressRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RevokeSecurityGroupIngress operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRevokeSecurityGroupIngress.</param>
        /// 
        /// <returns>Returns a  RevokeSecurityGroupIngressResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RevokeSecurityGroupIngress">REST API Reference for RevokeSecurityGroupIngress Operation</seealso>
        RevokeSecurityGroupIngressResponse EndRevokeSecurityGroupIngress(IAsyncResult asyncResult);

        #endregion
        
        #region  RunInstances


        /// <summary>
        /// Launches the specified number of instances using an AMI for which you have permissions.
        /// 
        /// 
        ///  
        /// <para>
        /// You can specify a number of options, or leave the default options. The following rules
        /// apply:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// [EC2-VPC] If you don't specify a subnet ID, we choose a default subnet from your default
        /// VPC for you. If you don't have a default VPC, you must specify a subnet ID in the
        /// request.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// [EC2-Classic] If don't specify an Availability Zone, we choose one for you.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Some instance types must be launched into a VPC. If you do not have a default VPC,
        /// or if you do not specify a subnet ID, the request fails. For more information, see
        /// <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-vpc.html#vpc-only-instance-types">Instance
        /// Types Available Only in a VPC</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// [EC2-VPC] All instances have a network interface with a primary private IPv4 address.
        /// If you don't specify this address, we choose one from the IPv4 range of your subnet.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Not all instance types support IPv6 addresses. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-types.html">Instance
        /// Types</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If you don't specify a security group ID, we use the default security group. For more
        /// information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-network-security.html">Security
        /// Groups</a>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// If any of the AMIs have a product code attached for which the user has not subscribed,
        /// the request fails.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// You can create a <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-launch-templates.html">launch
        /// template</a>, which is a resource that contains the parameters to launch an instance.
        /// When you launch an instance using <a>RunInstances</a>, you can specify the launch
        /// template instead of specifying the launch parameters.
        /// </para>
        ///  
        /// <para>
        /// To ensure faster instance launches, break up large requests into smaller batches.
        /// For example, create five separate launch requests for 100 instances each instead of
        /// one launch request for 500 instances.
        /// </para>
        ///  
        /// <para>
        /// An instance is ready for you to use when it's in the <code>running</code> state. You
        /// can check the state of your instance using <a>DescribeInstances</a>. You can tag instances
        /// and EBS volumes during launch, after launch, or both. For more information, see <a>CreateTags</a>
        /// and <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_Tags.html">Tagging
        /// Your Amazon EC2 Resources</a>.
        /// </para>
        ///  
        /// <para>
        /// Linux instances have access to the public key of the key pair at boot. You can use
        /// this key to provide secure access to the instance. Amazon EC2 public images use this
        /// feature to provide secure access without passwords. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-key-pairs.html">Key
        /// Pairs</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For troubleshooting, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_InstanceStraightToTerminated.html">What
        /// To Do If An Instance Immediately Terminates</a>, and <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/TroubleshootingInstancesConnecting.html">Troubleshooting
        /// Connecting to Your Instance</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RunInstances service method.</param>
        /// 
        /// <returns>The response from the RunInstances service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RunInstances">REST API Reference for RunInstances Operation</seealso>
        RunInstancesResponse RunInstances(RunInstancesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RunInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RunInstances operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRunInstances
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RunInstances">REST API Reference for RunInstances Operation</seealso>
        IAsyncResult BeginRunInstances(RunInstancesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RunInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRunInstances.</param>
        /// 
        /// <returns>Returns a  RunInstancesResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RunInstances">REST API Reference for RunInstances Operation</seealso>
        RunInstancesResponse EndRunInstances(IAsyncResult asyncResult);

        #endregion
        
        #region  RunScheduledInstances


        /// <summary>
        /// Launches the specified Scheduled Instances.
        /// 
        ///  
        /// <para>
        /// Before you can launch a Scheduled Instance, you must purchase it and obtain an identifier
        /// using <a>PurchaseScheduledInstances</a>.
        /// </para>
        ///  
        /// <para>
        /// You must launch a Scheduled Instance during its scheduled time period. You can't stop
        /// or reboot a Scheduled Instance, but you can terminate it as needed. If you terminate
        /// a Scheduled Instance before the current scheduled time period ends, you can launch
        /// it again after a few minutes. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-scheduled-instances.html">Scheduled
        /// Instances</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RunScheduledInstances service method.</param>
        /// 
        /// <returns>The response from the RunScheduledInstances service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RunScheduledInstances">REST API Reference for RunScheduledInstances Operation</seealso>
        RunScheduledInstancesResponse RunScheduledInstances(RunScheduledInstancesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RunScheduledInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RunScheduledInstances operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRunScheduledInstances
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RunScheduledInstances">REST API Reference for RunScheduledInstances Operation</seealso>
        IAsyncResult BeginRunScheduledInstances(RunScheduledInstancesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RunScheduledInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRunScheduledInstances.</param>
        /// 
        /// <returns>Returns a  RunScheduledInstancesResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RunScheduledInstances">REST API Reference for RunScheduledInstances Operation</seealso>
        RunScheduledInstancesResponse EndRunScheduledInstances(IAsyncResult asyncResult);

        #endregion
        
        #region  StartInstances


        /// <summary>
        /// Starts an Amazon EBS-backed instance that you've previously stopped.
        /// 
        ///  
        /// <para>
        /// Instances that use Amazon EBS volumes as their root devices can be quickly stopped
        /// and started. When an instance is stopped, the compute resources are released and you
        /// are not billed for instance usage. However, your root partition Amazon EBS volume
        /// remains and continues to persist your data, and you are charged for Amazon EBS volume
        /// usage. You can restart your instance at any time. Every time you start your Windows
        /// instance, Amazon EC2 charges you for a full instance hour. If you stop and restart
        /// your Windows instance, a new instance hour begins and Amazon EC2 charges you for another
        /// full instance hour even if you are still within the same 60-minute period when it
        /// was stopped. Every time you start your Linux instance, Amazon EC2 charges a one-minute
        /// minimum for instance usage, and thereafter charges per second for instance usage.
        /// </para>
        ///  
        /// <para>
        /// Before stopping an instance, make sure it is in a state from which it can be restarted.
        /// Stopping an instance does not preserve data stored in RAM.
        /// </para>
        ///  
        /// <para>
        /// Performing this operation on an instance that uses an instance store as its root device
        /// returns an error.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Stop_Start.html">Stopping
        /// Instances</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartInstances service method.</param>
        /// 
        /// <returns>The response from the StartInstances service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/StartInstances">REST API Reference for StartInstances Operation</seealso>
        StartInstancesResponse StartInstances(StartInstancesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartInstances operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartInstances
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/StartInstances">REST API Reference for StartInstances Operation</seealso>
        IAsyncResult BeginStartInstances(StartInstancesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartInstances.</param>
        /// 
        /// <returns>Returns a  StartInstancesResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/StartInstances">REST API Reference for StartInstances Operation</seealso>
        StartInstancesResponse EndStartInstances(IAsyncResult asyncResult);

        #endregion
        
        #region  StopInstances


        /// <summary>
        /// Stops an Amazon EBS-backed instance.
        /// 
        ///  
        /// <para>
        /// We don't charge usage for a stopped instance, or data transfer fees; however, your
        /// root partition Amazon EBS volume remains and continues to persist your data, and you
        /// are charged for Amazon EBS volume usage. Every time you start your Windows instance,
        /// Amazon EC2 charges you for a full instance hour. If you stop and restart your Windows
        /// instance, a new instance hour begins and Amazon EC2 charges you for another full instance
        /// hour even if you are still within the same 60-minute period when it was stopped. Every
        /// time you start your Linux instance, Amazon EC2 charges a one-minute minimum for instance
        /// usage, and thereafter charges per second for instance usage.
        /// </para>
        ///  
        /// <para>
        /// You can't start or stop Spot Instances, and you can't stop instance store-backed instances.
        /// </para>
        ///  
        /// <para>
        /// When you stop an instance, we shut it down. You can restart your instance at any time.
        /// Before stopping an instance, make sure it is in a state from which it can be restarted.
        /// Stopping an instance does not preserve data stored in RAM.
        /// </para>
        ///  
        /// <para>
        /// Stopping an instance is different to rebooting or terminating it. For example, when
        /// you stop an instance, the root device and any other devices attached to the instance
        /// persist. When you terminate an instance, the root device and any other devices attached
        /// during the instance launch are automatically deleted. For more information about the
        /// differences between rebooting, stopping, and terminating instances, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-instance-lifecycle.html">Instance
        /// Lifecycle</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// When you stop an instance, we attempt to shut it down forcibly after a short while.
        /// If your instance appears stuck in the stopping state after a period of time, there
        /// may be an issue with the underlying host computer. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/TroubleshootingInstancesStopping.html">Troubleshooting
        /// Stopping Your Instance</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopInstances service method.</param>
        /// 
        /// <returns>The response from the StopInstances service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/StopInstances">REST API Reference for StopInstances Operation</seealso>
        StopInstancesResponse StopInstances(StopInstancesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StopInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopInstances operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopInstances
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/StopInstances">REST API Reference for StopInstances Operation</seealso>
        IAsyncResult BeginStopInstances(StopInstancesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopInstances.</param>
        /// 
        /// <returns>Returns a  StopInstancesResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/StopInstances">REST API Reference for StopInstances Operation</seealso>
        StopInstancesResponse EndStopInstances(IAsyncResult asyncResult);

        #endregion
        
        #region  TerminateInstances


        /// <summary>
        /// Shuts down one or more instances. This operation is idempotent; if you terminate an
        /// instance more than once, each call succeeds. 
        /// 
        ///  
        /// <para>
        /// If you specify multiple instances and the request fails (for example, because of a
        /// single incorrect instance ID), none of the instances are terminated.
        /// </para>
        ///  
        /// <para>
        /// Terminated instances remain visible after termination (for approximately one hour).
        /// </para>
        ///  
        /// <para>
        /// By default, Amazon EC2 deletes all EBS volumes that were attached when the instance
        /// launched. Volumes attached after instance launch continue running.
        /// </para>
        ///  
        /// <para>
        /// You can stop, start, and terminate EBS-backed instances. You can only terminate instance
        /// store-backed instances. What happens to an instance differs if you stop it or terminate
        /// it. For example, when you stop an instance, the root device and any other devices
        /// attached to the instance persist. When you terminate an instance, any attached EBS
        /// volumes with the <code>DeleteOnTermination</code> block device mapping parameter set
        /// to <code>true</code> are automatically deleted. For more information about the differences
        /// between stopping and terminating instances, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-instance-lifecycle.html">Instance
        /// Lifecycle</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information about troubleshooting, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/TroubleshootingInstancesShuttingDown.html">Troubleshooting
        /// Terminating Your Instance</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TerminateInstances service method.</param>
        /// 
        /// <returns>The response from the TerminateInstances service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/TerminateInstances">REST API Reference for TerminateInstances Operation</seealso>
        TerminateInstancesResponse TerminateInstances(TerminateInstancesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TerminateInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TerminateInstances operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTerminateInstances
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/TerminateInstances">REST API Reference for TerminateInstances Operation</seealso>
        IAsyncResult BeginTerminateInstances(TerminateInstancesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TerminateInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTerminateInstances.</param>
        /// 
        /// <returns>Returns a  TerminateInstancesResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/TerminateInstances">REST API Reference for TerminateInstances Operation</seealso>
        TerminateInstancesResponse EndTerminateInstances(IAsyncResult asyncResult);

        #endregion
        
        #region  UnassignIpv6Addresses


        /// <summary>
        /// Unassigns one or more IPv6 addresses from a network interface.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UnassignIpv6Addresses service method.</param>
        /// 
        /// <returns>The response from the UnassignIpv6Addresses service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/UnassignIpv6Addresses">REST API Reference for UnassignIpv6Addresses Operation</seealso>
        UnassignIpv6AddressesResponse UnassignIpv6Addresses(UnassignIpv6AddressesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UnassignIpv6Addresses operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UnassignIpv6Addresses operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUnassignIpv6Addresses
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/UnassignIpv6Addresses">REST API Reference for UnassignIpv6Addresses Operation</seealso>
        IAsyncResult BeginUnassignIpv6Addresses(UnassignIpv6AddressesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UnassignIpv6Addresses operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUnassignIpv6Addresses.</param>
        /// 
        /// <returns>Returns a  UnassignIpv6AddressesResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/UnassignIpv6Addresses">REST API Reference for UnassignIpv6Addresses Operation</seealso>
        UnassignIpv6AddressesResponse EndUnassignIpv6Addresses(IAsyncResult asyncResult);

        #endregion
        
        #region  UnassignPrivateIpAddresses


        /// <summary>
        /// Unassigns one or more secondary private IP addresses from a network interface.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UnassignPrivateIpAddresses service method.</param>
        /// 
        /// <returns>The response from the UnassignPrivateIpAddresses service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/UnassignPrivateIpAddresses">REST API Reference for UnassignPrivateIpAddresses Operation</seealso>
        UnassignPrivateIpAddressesResponse UnassignPrivateIpAddresses(UnassignPrivateIpAddressesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UnassignPrivateIpAddresses operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UnassignPrivateIpAddresses operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUnassignPrivateIpAddresses
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/UnassignPrivateIpAddresses">REST API Reference for UnassignPrivateIpAddresses Operation</seealso>
        IAsyncResult BeginUnassignPrivateIpAddresses(UnassignPrivateIpAddressesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UnassignPrivateIpAddresses operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUnassignPrivateIpAddresses.</param>
        /// 
        /// <returns>Returns a  UnassignPrivateIpAddressesResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/UnassignPrivateIpAddresses">REST API Reference for UnassignPrivateIpAddresses Operation</seealso>
        UnassignPrivateIpAddressesResponse EndUnassignPrivateIpAddresses(IAsyncResult asyncResult);

        #endregion
        
        #region  UnmonitorInstances


        /// <summary>
        /// Disables detailed monitoring for a running instance. For more information, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-cloudwatch.html">Monitoring
        /// Your Instances and Volumes</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UnmonitorInstances service method.</param>
        /// 
        /// <returns>The response from the UnmonitorInstances service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/UnmonitorInstances">REST API Reference for UnmonitorInstances Operation</seealso>
        UnmonitorInstancesResponse UnmonitorInstances(UnmonitorInstancesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UnmonitorInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UnmonitorInstances operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUnmonitorInstances
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/UnmonitorInstances">REST API Reference for UnmonitorInstances Operation</seealso>
        IAsyncResult BeginUnmonitorInstances(UnmonitorInstancesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UnmonitorInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUnmonitorInstances.</param>
        /// 
        /// <returns>Returns a  UnmonitorInstancesResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/UnmonitorInstances">REST API Reference for UnmonitorInstances Operation</seealso>
        UnmonitorInstancesResponse EndUnmonitorInstances(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateSecurityGroupRuleDescriptionsEgress


        /// <summary>
        /// [EC2-VPC only] Updates the description of an egress (outbound) security group rule.
        /// You can replace an existing description, or add a description to a rule that did not
        /// have one previously.
        /// 
        ///  
        /// <para>
        /// You specify the description as part of the IP permissions structure. You can remove
        /// a description for a security group rule by omitting the description parameter in the
        /// request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSecurityGroupRuleDescriptionsEgress service method.</param>
        /// 
        /// <returns>The response from the UpdateSecurityGroupRuleDescriptionsEgress service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/UpdateSecurityGroupRuleDescriptionsEgress">REST API Reference for UpdateSecurityGroupRuleDescriptionsEgress Operation</seealso>
        UpdateSecurityGroupRuleDescriptionsEgressResponse UpdateSecurityGroupRuleDescriptionsEgress(UpdateSecurityGroupRuleDescriptionsEgressRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSecurityGroupRuleDescriptionsEgress operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSecurityGroupRuleDescriptionsEgress operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSecurityGroupRuleDescriptionsEgress
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/UpdateSecurityGroupRuleDescriptionsEgress">REST API Reference for UpdateSecurityGroupRuleDescriptionsEgress Operation</seealso>
        IAsyncResult BeginUpdateSecurityGroupRuleDescriptionsEgress(UpdateSecurityGroupRuleDescriptionsEgressRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSecurityGroupRuleDescriptionsEgress operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSecurityGroupRuleDescriptionsEgress.</param>
        /// 
        /// <returns>Returns a  UpdateSecurityGroupRuleDescriptionsEgressResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/UpdateSecurityGroupRuleDescriptionsEgress">REST API Reference for UpdateSecurityGroupRuleDescriptionsEgress Operation</seealso>
        UpdateSecurityGroupRuleDescriptionsEgressResponse EndUpdateSecurityGroupRuleDescriptionsEgress(IAsyncResult asyncResult);

        #endregion
        
        #region  UpdateSecurityGroupRuleDescriptionsIngress


        /// <summary>
        /// Updates the description of an ingress (inbound) security group rule. You can replace
        /// an existing description, or add a description to a rule that did not have one previously.
        /// 
        ///  
        /// <para>
        /// You specify the description as part of the IP permissions structure. You can remove
        /// a description for a security group rule by omitting the description parameter in the
        /// request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSecurityGroupRuleDescriptionsIngress service method.</param>
        /// 
        /// <returns>The response from the UpdateSecurityGroupRuleDescriptionsIngress service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/UpdateSecurityGroupRuleDescriptionsIngress">REST API Reference for UpdateSecurityGroupRuleDescriptionsIngress Operation</seealso>
        UpdateSecurityGroupRuleDescriptionsIngressResponse UpdateSecurityGroupRuleDescriptionsIngress(UpdateSecurityGroupRuleDescriptionsIngressRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSecurityGroupRuleDescriptionsIngress operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSecurityGroupRuleDescriptionsIngress operation on AmazonEC2Client.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSecurityGroupRuleDescriptionsIngress
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/UpdateSecurityGroupRuleDescriptionsIngress">REST API Reference for UpdateSecurityGroupRuleDescriptionsIngress Operation</seealso>
        IAsyncResult BeginUpdateSecurityGroupRuleDescriptionsIngress(UpdateSecurityGroupRuleDescriptionsIngressRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSecurityGroupRuleDescriptionsIngress operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSecurityGroupRuleDescriptionsIngress.</param>
        /// 
        /// <returns>Returns a  UpdateSecurityGroupRuleDescriptionsIngressResult from EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/UpdateSecurityGroupRuleDescriptionsIngress">REST API Reference for UpdateSecurityGroupRuleDescriptionsIngress Operation</seealso>
        UpdateSecurityGroupRuleDescriptionsIngressResponse EndUpdateSecurityGroupRuleDescriptionsIngress(IAsyncResult asyncResult);

        #endregion
        
    }
}