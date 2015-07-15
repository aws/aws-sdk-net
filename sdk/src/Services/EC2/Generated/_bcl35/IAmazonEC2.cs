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
 * Do not modify this file. This file is generated from the ec2-2015-04-15.normal.json service model.
 */


using System;
using System.Collections.Generic;

using Amazon.EC2.Model;

namespace Amazon.EC2
{
    /// <summary>
    /// Interface for accessing EC2
    ///
    /// Amazon Elastic Compute Cloud 
    /// <para>
    /// Amazon Elastic Compute Cloud (Amazon EC2) provides resizable computing capacity in
    /// the Amazon Web Services (AWS) cloud. Using Amazon EC2 eliminates your need to invest
    /// in hardware up front, so you can develop and deploy applications faster.
    /// </para>
    /// </summary>
    public partial interface IAmazonEC2 : IDisposable
    {

        
        #region  AcceptVpcPeeringConnection


        /// <summary>
        /// Accept a VPC peering connection request. To accept a request, the VPC peering connection
        /// must be in the <code>pending-acceptance</code> state, and you must be the owner of
        /// the peer VPC. Use the <code>DescribeVpcPeeringConnections</code> request to view your
        /// outstanding VPC peering connection requests.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptVpcPeeringConnection service method.</param>
        /// 
        /// <returns>The response from the AcceptVpcPeeringConnection service method, as returned by EC2.</returns>
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
        IAsyncResult BeginAcceptVpcPeeringConnection(AcceptVpcPeeringConnectionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AcceptVpcPeeringConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAcceptVpcPeeringConnection.</param>
        /// 
        /// <returns>Returns a  AcceptVpcPeeringConnectionResult from EC2.</returns>
        AcceptVpcPeeringConnectionResponse EndAcceptVpcPeeringConnection(IAsyncResult asyncResult);

        #endregion
        
        #region  AllocateAddress


        /// <summary>
        /// Acquires an Elastic IP address.
        /// 
        ///  
        /// <para>
        /// An Elastic IP address is for use either in the EC2-Classic platform or in a VPC. For
        /// more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/elastic-ip-addresses-eip.html">Elastic
        /// IP Addresses</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the AllocateAddress service method, as returned by EC2.</returns>
        AllocateAddressResponse AllocateAddress();

        /// <summary>
        /// Acquires an Elastic IP address.
        /// 
        ///  
        /// <para>
        /// An Elastic IP address is for use either in the EC2-Classic platform or in a VPC. For
        /// more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/elastic-ip-addresses-eip.html">Elastic
        /// IP Addresses</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AllocateAddress service method.</param>
        /// 
        /// <returns>The response from the AllocateAddress service method, as returned by EC2.</returns>
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
        IAsyncResult BeginAllocateAddress(AllocateAddressRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AllocateAddress operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAllocateAddress.</param>
        /// 
        /// <returns>Returns a  AllocateAddressResult from EC2.</returns>
        AllocateAddressResponse EndAllocateAddress(IAsyncResult asyncResult);

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
        IAsyncResult BeginAssignPrivateIpAddresses(AssignPrivateIpAddressesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssignPrivateIpAddresses operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssignPrivateIpAddresses.</param>
        /// 
        /// <returns>Returns a  AssignPrivateIpAddressesResult from EC2.</returns>
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
        /// with the specified instance.
        /// </para>
        ///  
        /// <para>
        /// [VPC in an EC2-Classic account] If you don't specify a private IP address, the Elastic
        /// IP address is associated with the primary IP address. If the Elastic IP address is
        /// already associated with a different instance or a network interface, you get an error
        /// unless you allow reassociation.
        /// </para>
        ///  
        /// <para>
        /// This is an idempotent operation. If you perform the operation more than once, Amazon
        /// EC2 doesn't return an error.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateAddress service method.</param>
        /// 
        /// <returns>The response from the AssociateAddress service method, as returned by EC2.</returns>
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
        IAsyncResult BeginAssociateAddress(AssociateAddressRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateAddress operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateAddress.</param>
        /// 
        /// <returns>Returns a  AssociateAddressResult from EC2.</returns>
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
        IAsyncResult BeginAssociateDhcpOptions(AssociateDhcpOptionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateDhcpOptions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateDhcpOptions.</param>
        /// 
        /// <returns>Returns a  AssociateDhcpOptionsResult from EC2.</returns>
        AssociateDhcpOptionsResponse EndAssociateDhcpOptions(IAsyncResult asyncResult);

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
        IAsyncResult BeginAssociateRouteTable(AssociateRouteTableRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateRouteTable operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateRouteTable.</param>
        /// 
        /// <returns>Returns a  AssociateRouteTableResult from EC2.</returns>
        AssociateRouteTableResponse EndAssociateRouteTable(IAsyncResult asyncResult);

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
        IAsyncResult BeginAttachClassicLinkVpc(AttachClassicLinkVpcRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AttachClassicLinkVpc operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAttachClassicLinkVpc.</param>
        /// 
        /// <returns>Returns a  AttachClassicLinkVpcResult from EC2.</returns>
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
        IAsyncResult BeginAttachInternetGateway(AttachInternetGatewayRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AttachInternetGateway operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAttachInternetGateway.</param>
        /// 
        /// <returns>Returns a  AttachInternetGatewayResult from EC2.</returns>
        AttachInternetGatewayResponse EndAttachInternetGateway(IAsyncResult asyncResult);

        #endregion
        
        #region  AttachNetworkInterface


        /// <summary>
        /// Attaches a network interface to an instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachNetworkInterface service method.</param>
        /// 
        /// <returns>The response from the AttachNetworkInterface service method, as returned by EC2.</returns>
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
        IAsyncResult BeginAttachNetworkInterface(AttachNetworkInterfaceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AttachNetworkInterface operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAttachNetworkInterface.</param>
        /// 
        /// <returns>Returns a  AttachNetworkInterfaceResult from EC2.</returns>
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
        ///  <ul> <li>The volume can be attached only to a stopped instance.</li> <li>AWS Marketplace
        /// product codes are copied from the volume to the instance.</li> <li>You must be subscribed
        /// to the product.</li> <li>The instance type and operating system of the instance must
        /// support the product. For example, you can't detach a volume from a Windows instance
        /// and attach it to a Linux instance.</li> </ul> 
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
        IAsyncResult BeginAttachVolume(AttachVolumeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AttachVolume operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAttachVolume.</param>
        /// 
        /// <returns>Returns a  AttachVolumeResult from EC2.</returns>
        AttachVolumeResponse EndAttachVolume(IAsyncResult asyncResult);

        #endregion
        
        #region  AttachVpnGateway


        /// <summary>
        /// Attaches a virtual private gateway to a VPC. For more information, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_VPN.html">Adding
        /// a Hardware Virtual Private Gateway to Your VPC</a> in the <i>Amazon Virtual Private
        /// Cloud User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachVpnGateway service method.</param>
        /// 
        /// <returns>The response from the AttachVpnGateway service method, as returned by EC2.</returns>
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
        IAsyncResult BeginAttachVpnGateway(AttachVpnGatewayRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AttachVpnGateway operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAttachVpnGateway.</param>
        /// 
        /// <returns>Returns a  AttachVpnGatewayResult from EC2.</returns>
        AttachVpnGatewayResponse EndAttachVpnGateway(IAsyncResult asyncResult);

        #endregion
        
        #region  AuthorizeSecurityGroupEgress


        /// <summary>
        /// Adds one or more egress rules to a security group for use with a VPC. Specifically,
        /// this action permits instances to send traffic to one or more destination CIDR IP address
        /// ranges, or to one or more destination security groups for the same VPC.
        /// 
        ///  <important> 
        /// <para>
        /// You can have up to 50 rules per security group (covering both ingress and egress rules).
        /// </para>
        ///  </important> 
        /// <para>
        /// A security group is for use with instances either in the EC2-Classic platform or in
        /// a specific VPC. This action doesn't apply to security groups for use in EC2-Classic.
        /// For more information, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_SecurityGroups.html">Security
        /// Groups for Your VPC</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// Each rule consists of the protocol (for example, TCP), plus either a CIDR range or
        /// a source group. For the TCP and UDP protocols, you must also specify the destination
        /// port or port range. For the ICMP protocol, you must also specify the ICMP type and
        /// code. You can use -1 for the type or code to mean all types or all codes.
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
        IAsyncResult BeginAuthorizeSecurityGroupEgress(AuthorizeSecurityGroupEgressRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AuthorizeSecurityGroupEgress operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAuthorizeSecurityGroupEgress.</param>
        /// 
        /// <returns>Returns a  AuthorizeSecurityGroupEgressResult from EC2.</returns>
        AuthorizeSecurityGroupEgressResponse EndAuthorizeSecurityGroupEgress(IAsyncResult asyncResult);

        #endregion
        
        #region  AuthorizeSecurityGroupIngress


        /// <summary>
        /// Adds one or more ingress rules to a security group.
        /// 
        ///  <important> 
        /// <para>
        /// EC2-Classic: You can have up to 100 rules per group.
        /// </para>
        ///  
        /// <para>
        /// EC2-VPC: You can have up to 50 rules per group (covering both ingress and egress rules).
        /// </para>
        ///  </important> 
        /// <para>
        /// Rule changes are propagated to instances within the security group as quickly as possible.
        /// However, a small delay might occur.
        /// </para>
        ///  
        /// <para>
        /// [EC2-Classic] This action gives one or more CIDR IP address ranges permission to access
        /// a security group in your account, or gives one or more security groups (called the
        /// <i>source groups</i>) permission to access a security group for your account. A source
        /// group can be for your own AWS account, or another.
        /// </para>
        ///  
        /// <para>
        /// [EC2-VPC] This action gives one or more CIDR IP address ranges permission to access
        /// a security group in your VPC, or gives one or more other security groups (called the
        /// <i>source groups</i>) permission to access a security group for your VPC. The security
        /// groups must all be for the same VPC.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AuthorizeSecurityGroupIngress service method.</param>
        /// 
        /// <returns>The response from the AuthorizeSecurityGroupIngress service method, as returned by EC2.</returns>
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
        IAsyncResult BeginAuthorizeSecurityGroupIngress(AuthorizeSecurityGroupIngressRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  AuthorizeSecurityGroupIngress operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAuthorizeSecurityGroupIngress.</param>
        /// 
        /// <returns>Returns a  AuthorizeSecurityGroupIngressResult from EC2.</returns>
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
        IAsyncResult BeginBundleInstance(BundleInstanceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  BundleInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBundleInstance.</param>
        /// 
        /// <returns>Returns a  BundleInstanceResult from EC2.</returns>
        BundleInstanceResponse EndBundleInstance(IAsyncResult asyncResult);

        #endregion
        
        #region  CancelBundleTask


        /// <summary>
        /// Cancels a bundling operation for an instance store-backed Windows instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelBundleTask service method.</param>
        /// 
        /// <returns>The response from the CancelBundleTask service method, as returned by EC2.</returns>
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
        IAsyncResult BeginCancelBundleTask(CancelBundleTaskRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CancelBundleTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelBundleTask.</param>
        /// 
        /// <returns>Returns a  CancelBundleTaskResult from EC2.</returns>
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
        /// For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/UploadingYourInstancesandVolumes.html">Using
        /// the Command Line Tools to Import Your Virtual Machine to Amazon EC2</a> in the <i>Amazon
        /// Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelConversionTask service method.</param>
        /// 
        /// <returns>The response from the CancelConversionTask service method, as returned by EC2.</returns>
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
        IAsyncResult BeginCancelConversionTask(CancelConversionTaskRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CancelConversionTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelConversionTask.</param>
        /// 
        /// <returns>Returns a  CancelConversionTaskResult from EC2.</returns>
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
        IAsyncResult BeginCancelExportTask(CancelExportTaskRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CancelExportTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelExportTask.</param>
        /// 
        /// <returns>Returns a  CancelExportTaskResult from EC2.</returns>
        CancelExportTaskResponse EndCancelExportTask(IAsyncResult asyncResult);

        #endregion
        
        #region  CancelImportTask


        /// <summary>
        /// Cancels an in-process import virtual machine or import snapshot task.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelImportTask service method.</param>
        /// 
        /// <returns>The response from the CancelImportTask service method, as returned by EC2.</returns>
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
        IAsyncResult BeginCancelImportTask(CancelImportTaskRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CancelImportTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelImportTask.</param>
        /// 
        /// <returns>Returns a  CancelImportTaskResult from EC2.</returns>
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
        IAsyncResult BeginCancelReservedInstancesListing(CancelReservedInstancesListingRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CancelReservedInstancesListing operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelReservedInstancesListing.</param>
        /// 
        /// <returns>Returns a  CancelReservedInstancesListingResult from EC2.</returns>
        CancelReservedInstancesListingResponse EndCancelReservedInstancesListing(IAsyncResult asyncResult);

        #endregion
        
        #region  CancelSpotFleetRequests


        /// <summary>
        /// Cancels the specified Spot fleet requests.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelSpotFleetRequests service method.</param>
        /// 
        /// <returns>The response from the CancelSpotFleetRequests service method, as returned by EC2.</returns>
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
        IAsyncResult BeginCancelSpotFleetRequests(CancelSpotFleetRequestsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CancelSpotFleetRequests operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelSpotFleetRequests.</param>
        /// 
        /// <returns>Returns a  CancelSpotFleetRequestsResult from EC2.</returns>
        CancelSpotFleetRequestsResponse EndCancelSpotFleetRequests(IAsyncResult asyncResult);

        #endregion
        
        #region  CancelSpotInstanceRequests


        /// <summary>
        /// Cancels one or more Spot Instance requests. Spot Instances are instances that Amazon
        /// EC2 starts on your behalf when the bid price that you specify exceeds the current
        /// Spot Price. Amazon EC2 periodically sets the Spot Price based on available Spot Instance
        /// capacity and current Spot Instance requests. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/spot-requests.html">Spot
        /// Instance Requests</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
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
        IAsyncResult BeginCancelSpotInstanceRequests(CancelSpotInstanceRequestsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CancelSpotInstanceRequests operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelSpotInstanceRequests.</param>
        /// 
        /// <returns>Returns a  CancelSpotInstanceRequestsResult from EC2.</returns>
        CancelSpotInstanceRequestsResponse EndCancelSpotInstanceRequests(IAsyncResult asyncResult);

        #endregion
        
        #region  ConfirmProductInstance


        /// <summary>
        /// Determines whether a product code is associated with an instance. This action can
        /// only be used by the owner of the product code. It is useful when a product code owner
        /// needs to verify whether another user's instance is eligible for support.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ConfirmProductInstance service method.</param>
        /// 
        /// <returns>The response from the ConfirmProductInstance service method, as returned by EC2.</returns>
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
        IAsyncResult BeginConfirmProductInstance(ConfirmProductInstanceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ConfirmProductInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginConfirmProductInstance.</param>
        /// 
        /// <returns>Returns a  ConfirmProductInstanceResult from EC2.</returns>
        ConfirmProductInstanceResponse EndConfirmProductInstance(IAsyncResult asyncResult);

        #endregion
        
        #region  CopyImage


        /// <summary>
        /// Initiates the copy of an AMI from the specified source region to the current region.
        /// You specify the destination region by using its endpoint when making the request.
        /// AMIs that use encrypted EBS snapshots cannot be copied with this method.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/CopyingAMIs.html">Copying
        /// AMIs</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CopyImage service method.</param>
        /// 
        /// <returns>The response from the CopyImage service method, as returned by EC2.</returns>
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
        IAsyncResult BeginCopyImage(CopyImageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CopyImage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCopyImage.</param>
        /// 
        /// <returns>Returns a  CopyImageResult from EC2.</returns>
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
        /// Key Management Service (KMS) master key; however, you can specify a non-default master
        /// key with the <code>KmsKeyId</code> parameter.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-copy-snapshot.html">Copying
        /// an Amazon EBS Snapshot</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CopySnapshot service method.</param>
        /// 
        /// <returns>The response from the CopySnapshot service method, as returned by EC2.</returns>
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
        IAsyncResult BeginCopySnapshot(CopySnapshotRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CopySnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCopySnapshot.</param>
        /// 
        /// <returns>Returns a  CopySnapshotResult from EC2.</returns>
        CopySnapshotResponse EndCopySnapshot(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateCustomerGateway


        /// <summary>
        /// Provides information to AWS about your VPN customer gateway device. The customer gateway
        /// is the appliance at your end of the VPN connection. (The device on the AWS side of
        /// the VPN connection is the virtual private gateway.) You must provide the Internet-routable
        /// IP address of the customer gateway's external interface. The IP address must be static
        /// and can't be behind a device performing network address translation (NAT).
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
        /// For more information about VPN customer gateways, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_VPN.html">Adding
        /// a Hardware Virtual Private Gateway to Your VPC</a> in the <i>Amazon Virtual Private
        /// Cloud User Guide</i>.
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
        IAsyncResult BeginCreateCustomerGateway(CreateCustomerGatewayRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCustomerGateway operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCustomerGateway.</param>
        /// 
        /// <returns>Returns a  CreateCustomerGatewayResult from EC2.</returns>
        CreateCustomerGatewayResponse EndCreateCustomerGateway(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateDhcpOptions


        /// <summary>
        /// Creates a set of DHCP options for your VPC. After creating the set, you must associate
        /// it with the VPC, causing all existing and new instances that you launch in the VPC
        /// to use this set of DHCP options. The following are the individual DHCP options you
        /// can specify. For more information about the options, see <a href="http://www.ietf.org/rfc/rfc2132.txt">RFC
        /// 2132</a>.
        /// 
        ///  <ul> <li> <code>domain-name-servers</code> - The IP addresses of up to four domain
        /// name servers, or <code>AmazonProvidedDNS</code>. The default DHCP option set specifies
        /// <code>AmazonProvidedDNS</code>. If specifying more than one domain name server, specify
        /// the IP addresses in a single parameter, separated by commas.</li> <li> <code>domain-name</code>
        /// - If you're using AmazonProvidedDNS in <code>us-east-1</code>, specify <code>ec2.internal</code>.
        /// If you're using AmazonProvidedDNS in another region, specify <code>region.compute.internal</code>
        /// (for example, <code>ap-northeast-1.compute.internal</code>). Otherwise, specify a
        /// domain name (for example, <code>MyCompany.com</code>). <b>Important</b>: Some Linux
        /// operating systems accept multiple domain names separated by spaces. However, Windows
        /// and other Linux operating systems treat the value as a single domain, which results
        /// in unexpected behavior. If your DHCP options set is associated with a VPC that has
        /// instances with multiple operating systems, specify only one domain name.</li> <li>
        /// <code>ntp-servers</code> - The IP addresses of up to four Network Time Protocol (NTP)
        /// servers.</li> <li> <code>netbios-name-servers</code> - The IP addresses of up to four
        /// NetBIOS name servers.</li> <li> <code>netbios-node-type</code> - The NetBIOS node
        /// type (1, 2, 4, or 8). We recommend that you specify 2 (broadcast and multicast are
        /// not currently supported). For more information about these node types, see <a href="http://www.ietf.org/rfc/rfc2132.txt">RFC
        /// 2132</a>. </li> </ul> 
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
        IAsyncResult BeginCreateDhcpOptions(CreateDhcpOptionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDhcpOptions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDhcpOptions.</param>
        /// 
        /// <returns>Returns a  CreateDhcpOptionsResult from EC2.</returns>
        CreateDhcpOptionsResponse EndCreateDhcpOptions(IAsyncResult asyncResult);

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
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateFlowLogs service method.</param>
        /// 
        /// <returns>The response from the CreateFlowLogs service method, as returned by EC2.</returns>
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
        IAsyncResult BeginCreateFlowLogs(CreateFlowLogsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateFlowLogs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateFlowLogs.</param>
        /// 
        /// <returns>Returns a  CreateFlowLogsResult from EC2.</returns>
        CreateFlowLogsResponse EndCreateFlowLogs(IAsyncResult asyncResult);

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
        IAsyncResult BeginCreateImage(CreateImageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateImage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateImage.</param>
        /// 
        /// <returns>Returns a  CreateImageResult from EC2.</returns>
        CreateImageResponse EndCreateImage(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateInstanceExportTask


        /// <summary>
        /// Exports a running or stopped instance to an S3 bucket.
        /// 
        ///  
        /// <para>
        /// For information about the supported operating systems, image formats, and known limitations
        /// for the types of instances you can export, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ExportingEC2Instances.html">Exporting
        /// EC2 Instances</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInstanceExportTask service method.</param>
        /// 
        /// <returns>The response from the CreateInstanceExportTask service method, as returned by EC2.</returns>
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
        IAsyncResult BeginCreateInstanceExportTask(CreateInstanceExportTaskRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateInstanceExportTask operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateInstanceExportTask.</param>
        /// 
        /// <returns>Returns a  CreateInstanceExportTaskResult from EC2.</returns>
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
        IAsyncResult BeginCreateInternetGateway(CreateInternetGatewayRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateInternetGateway operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateInternetGateway.</param>
        /// 
        /// <returns>Returns a  CreateInternetGatewayResult from EC2.</returns>
        CreateInternetGatewayResponse EndCreateInternetGateway(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateKeyPair


        /// <summary>
        /// Creates a 2048-bit RSA key pair with the specified name. Amazon EC2 stores the public
        /// key and displays the private key for you to save to a file. The private key is returned
        /// as an unencrypted PEM encoded PKCS#8 private key. If a key with the specified name
        /// already exists, Amazon EC2 returns an error.
        /// 
        ///  
        /// <para>
        /// You can have up to five thousand key pairs per region.
        /// </para>
        ///  
        /// <para>
        /// The key pair returned to you is available only in the region in which you create it.
        /// To create a key pair that is available in all regions, use <a>ImportKeyPair</a>.
        /// </para>
        ///  
        /// <para>
        /// For more information about key pairs, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-key-pairs.html">Key
        /// Pairs</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateKeyPair service method.</param>
        /// 
        /// <returns>The response from the CreateKeyPair service method, as returned by EC2.</returns>
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
        IAsyncResult BeginCreateKeyPair(CreateKeyPairRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateKeyPair operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateKeyPair.</param>
        /// 
        /// <returns>Returns a  CreateKeyPairResult from EC2.</returns>
        CreateKeyPairResponse EndCreateKeyPair(IAsyncResult asyncResult);

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
        IAsyncResult BeginCreateNetworkAcl(CreateNetworkAclRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateNetworkAcl operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateNetworkAcl.</param>
        /// 
        /// <returns>Returns a  CreateNetworkAclResult from EC2.</returns>
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
        IAsyncResult BeginCreateNetworkAclEntry(CreateNetworkAclEntryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateNetworkAclEntry operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateNetworkAclEntry.</param>
        /// 
        /// <returns>Returns a  CreateNetworkAclEntryResult from EC2.</returns>
        CreateNetworkAclEntryResponse EndCreateNetworkAclEntry(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateNetworkInterface


        /// <summary>
        /// Creates a network interface in the specified subnet.
        /// 
        ///  
        /// <para>
        /// For more information about network interfaces, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-eni.html">Elastic
        /// Network Interfaces</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateNetworkInterface service method.</param>
        /// 
        /// <returns>The response from the CreateNetworkInterface service method, as returned by EC2.</returns>
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
        IAsyncResult BeginCreateNetworkInterface(CreateNetworkInterfaceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateNetworkInterface operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateNetworkInterface.</param>
        /// 
        /// <returns>Returns a  CreateNetworkInterfaceResult from EC2.</returns>
        CreateNetworkInterfaceResponse EndCreateNetworkInterface(IAsyncResult asyncResult);

        #endregion
        
        #region  CreatePlacementGroup


        /// <summary>
        /// Creates a placement group that you launch cluster instances into. You must give the
        /// group a name that's unique within the scope of your account.
        /// 
        ///  
        /// <para>
        /// For more information about placement groups and cluster instances, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using_cluster_computing.html">Cluster
        /// Instances</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePlacementGroup service method.</param>
        /// 
        /// <returns>The response from the CreatePlacementGroup service method, as returned by EC2.</returns>
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
        IAsyncResult BeginCreatePlacementGroup(CreatePlacementGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreatePlacementGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePlacementGroup.</param>
        /// 
        /// <returns>Returns a  CreatePlacementGroupResult from EC2.</returns>
        CreatePlacementGroupResponse EndCreatePlacementGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateReservedInstancesListing


        /// <summary>
        /// Creates a listing for Amazon EC2 Reserved Instances to be sold in the Reserved Instance
        /// Marketplace. You can submit one Reserved Instance listing at a time. To get a list
        /// of your Reserved Instances, you can use the <a>DescribeReservedInstances</a> operation.
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
        /// To sell your Reserved Instances, you must first register as a seller in the Reserved
        /// Instance Marketplace. After completing the registration process, you can create a
        /// Reserved Instance Marketplace listing of some or all of your Reserved Instances, and
        /// specify the upfront price to receive for them. Your Reserved Instance listings then
        /// become available for purchase. To view the details of your Reserved Instance listing,
        /// you can use the <a>DescribeReservedInstancesListings</a> operation.
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
        IAsyncResult BeginCreateReservedInstancesListing(CreateReservedInstancesListingRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateReservedInstancesListing operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateReservedInstancesListing.</param>
        /// 
        /// <returns>Returns a  CreateReservedInstancesListingResult from EC2.</returns>
        CreateReservedInstancesListingResponse EndCreateReservedInstancesListing(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateRoute


        /// <summary>
        /// Creates a route in a route table within a VPC.
        /// 
        ///  
        /// <para>
        /// You must specify one of the following targets: Internet gateway or virtual private
        /// gateway, NAT instance, VPC peering connection, or network interface.
        /// </para>
        ///  
        /// <para>
        /// When determining how to route traffic, we use the route with the most specific match.
        /// For example, let's say the traffic is destined for <code>192.0.2.3</code>, and the
        /// route table includes the following two routes:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// <code>192.0.2.0/24</code> (goes to some target A)
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>192.0.2.0/28</code> (goes to some target B)
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
        IAsyncResult BeginCreateRoute(CreateRouteRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRoute operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRoute.</param>
        /// 
        /// <returns>Returns a  CreateRouteResult from EC2.</returns>
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
        IAsyncResult BeginCreateRouteTable(CreateRouteTableRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateRouteTable operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRouteTable.</param>
        /// 
        /// <returns>Returns a  CreateRouteTableResult from EC2.</returns>
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
        /// EC2-VPC: You can create up to 100 security groups per VPC.
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
        IAsyncResult BeginCreateSecurityGroup(CreateSecurityGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSecurityGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSecurityGroup.</param>
        /// 
        /// <returns>Returns a  CreateSecurityGroupResult from EC2.</returns>
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
        /// For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/AmazonEBS.html">Amazon
        /// Elastic Block Store</a> and <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSEncryption.html">Amazon
        /// EBS Encryption</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSnapshot service method.</param>
        /// 
        /// <returns>The response from the CreateSnapshot service method, as returned by EC2.</returns>
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
        IAsyncResult BeginCreateSnapshot(CreateSnapshotRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSnapshot.</param>
        /// 
        /// <returns>Returns a  CreateSnapshotResult from EC2.</returns>
        CreateSnapshotResponse EndCreateSnapshot(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateSpotDatafeedSubscription


        /// <summary>
        /// Creates a data feed for Spot Instances, enabling you to view Spot Instance usage logs.
        /// You can create one data feed per AWS account. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/spot-data-feeds.html">Spot
        /// Instance Data Feed</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSpotDatafeedSubscription service method.</param>
        /// 
        /// <returns>The response from the CreateSpotDatafeedSubscription service method, as returned by EC2.</returns>
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
        IAsyncResult BeginCreateSpotDatafeedSubscription(CreateSpotDatafeedSubscriptionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSpotDatafeedSubscription operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSpotDatafeedSubscription.</param>
        /// 
        /// <returns>Returns a  CreateSpotDatafeedSubscriptionResult from EC2.</returns>
        CreateSpotDatafeedSubscriptionResponse EndCreateSpotDatafeedSubscription(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateSubnet


        /// <summary>
        /// Creates a subnet in an existing VPC.
        /// 
        ///  
        /// <para>
        /// When you create each subnet, you provide the VPC ID and the CIDR block you want for
        /// the subnet. After you create a subnet, you can't change its CIDR block. The subnet's
        /// CIDR block can be the same as the VPC's CIDR block (assuming you want only a single
        /// subnet in the VPC), or a subset of the VPC's CIDR block. If you create more than one
        /// subnet in a VPC, the subnets' CIDR blocks must not overlap. The smallest subnet (and
        /// VPC) you can create uses a /28 netmask (16 IP addresses), and the largest uses a /16
        /// netmask (65,536 IP addresses).
        /// </para>
        ///  <important> 
        /// <para>
        /// AWS reserves both the first four and the last IP address in each subnet's CIDR block.
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
        IAsyncResult BeginCreateSubnet(CreateSubnetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSubnet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSubnet.</param>
        /// 
        /// <returns>Returns a  CreateSubnetResult from EC2.</returns>
        CreateSubnetResponse EndCreateSubnet(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateTags


        /// <summary>
        /// Adds or overwrites one or more tags for the specified Amazon EC2 resource or resources.
        /// Each resource can have a maximum of 10 tags. Each tag consists of a key and optional
        /// value. Tag keys must be unique per resource.
        /// 
        ///  
        /// <para>
        /// For more information about tags, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_Tags.html">Tagging
        /// Your Resources</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTags service method.</param>
        /// 
        /// <returns>The response from the CreateTags service method, as returned by EC2.</returns>
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
        IAsyncResult BeginCreateTags(CreateTagsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTags.</param>
        /// 
        /// <returns>Returns a  CreateTagsResult from EC2.</returns>
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
        /// For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-creating-volume.html">Creating
        /// or Restoring an Amazon EBS Volume</a> in the <i>Amazon Elastic Compute Cloud User
        /// Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVolume service method.</param>
        /// 
        /// <returns>The response from the CreateVolume service method, as returned by EC2.</returns>
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
        IAsyncResult BeginCreateVolume(CreateVolumeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateVolume operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateVolume.</param>
        /// 
        /// <returns>Returns a  CreateVolumeResult from EC2.</returns>
        CreateVolumeResponse EndCreateVolume(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateVpc


        /// <summary>
        /// Creates a VPC with the specified CIDR block.
        /// 
        ///  
        /// <para>
        /// The smallest VPC you can create uses a /28 netmask (16 IP addresses), and the largest
        /// uses a /16 netmask (65,536 IP addresses). To help you decide how big to make your
        /// VPC, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Subnets.html">Your
        /// VPC and Subnets</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// By default, each instance you launch in the VPC has the default DHCP options, which
        /// includes only a default DNS server that we provide (AmazonProvidedDNS). For more information
        /// about DHCP options, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_DHCP_Options.html">DHCP
        /// Options Sets</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVpc service method.</param>
        /// 
        /// <returns>The response from the CreateVpc service method, as returned by EC2.</returns>
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
        IAsyncResult BeginCreateVpc(CreateVpcRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateVpc operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateVpc.</param>
        /// 
        /// <returns>Returns a  CreateVpcResult from EC2.</returns>
        CreateVpcResponse EndCreateVpc(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateVpcEndpoint


        /// <summary>
        /// Creates a VPC endpoint for a specified AWS service. An endpoint enables you to create
        /// a private connection between your VPC and another AWS service in your account. You
        /// can specify an endpoint policy to attach to the endpoint that will control access
        /// to the service from your VPC. You can also specify the VPC route tables that use the
        /// endpoint.
        /// 
        ///  
        /// <para>
        /// Currently, only endpoints to Amazon S3 are supported.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVpcEndpoint service method.</param>
        /// 
        /// <returns>The response from the CreateVpcEndpoint service method, as returned by EC2.</returns>
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
        IAsyncResult BeginCreateVpcEndpoint(CreateVpcEndpointRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateVpcEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateVpcEndpoint.</param>
        /// 
        /// <returns>Returns a  CreateVpcEndpointResult from EC2.</returns>
        CreateVpcEndpointResponse EndCreateVpcEndpoint(IAsyncResult asyncResult);

        #endregion
        
        #region  CreateVpcPeeringConnection


        /// <summary>
        /// Requests a VPC peering connection between two VPCs: a requester VPC that you own and
        /// a peer VPC with which to create the connection. The peer VPC can belong to another
        /// AWS account. The requester VPC and peer VPC cannot have overlapping CIDR blocks.
        /// 
        ///  
        /// <para>
        /// The owner of the peer VPC must accept the peering request to activate the peering
        /// connection. The VPC peering connection request expires after 7 days, after which it
        /// cannot be accepted or rejected.
        /// </para>
        ///  
        /// <para>
        /// A <code>CreateVpcPeeringConnection</code> request between VPCs with overlapping CIDR
        /// blocks results in the VPC peering connection having a status of <code>failed</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVpcPeeringConnection service method.</param>
        /// 
        /// <returns>The response from the CreateVpcPeeringConnection service method, as returned by EC2.</returns>
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
        IAsyncResult BeginCreateVpcPeeringConnection(CreateVpcPeeringConnectionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateVpcPeeringConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateVpcPeeringConnection.</param>
        /// 
        /// <returns>Returns a  CreateVpcPeeringConnectionResult from EC2.</returns>
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
        /// For more information about VPN connections, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_VPN.html">Adding
        /// a Hardware Virtual Private Gateway to Your VPC</a> in the <i>Amazon Virtual Private
        /// Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVpnConnection service method.</param>
        /// 
        /// <returns>The response from the CreateVpnConnection service method, as returned by EC2.</returns>
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
        IAsyncResult BeginCreateVpnConnection(CreateVpnConnectionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateVpnConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateVpnConnection.</param>
        /// 
        /// <returns>Returns a  CreateVpnConnectionResult from EC2.</returns>
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
        /// For more information about VPN connections, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_VPN.html">Adding
        /// a Hardware Virtual Private Gateway to Your VPC</a> in the <i>Amazon Virtual Private
        /// Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVpnConnectionRoute service method.</param>
        /// 
        /// <returns>The response from the CreateVpnConnectionRoute service method, as returned by EC2.</returns>
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
        IAsyncResult BeginCreateVpnConnectionRoute(CreateVpnConnectionRouteRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateVpnConnectionRoute operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateVpnConnectionRoute.</param>
        /// 
        /// <returns>Returns a  CreateVpnConnectionRouteResult from EC2.</returns>
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
        /// For more information about virtual private gateways, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_VPN.html">Adding
        /// a Hardware Virtual Private Gateway to Your VPC</a> in the <i>Amazon Virtual Private
        /// Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVpnGateway service method.</param>
        /// 
        /// <returns>The response from the CreateVpnGateway service method, as returned by EC2.</returns>
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
        IAsyncResult BeginCreateVpnGateway(CreateVpnGatewayRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  CreateVpnGateway operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateVpnGateway.</param>
        /// 
        /// <returns>Returns a  CreateVpnGatewayResult from EC2.</returns>
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
        IAsyncResult BeginDeleteCustomerGateway(DeleteCustomerGatewayRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCustomerGateway operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCustomerGateway.</param>
        /// 
        /// <returns>Returns a  DeleteCustomerGatewayResult from EC2.</returns>
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
        IAsyncResult BeginDeleteDhcpOptions(DeleteDhcpOptionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDhcpOptions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDhcpOptions.</param>
        /// 
        /// <returns>Returns a  DeleteDhcpOptionsResult from EC2.</returns>
        DeleteDhcpOptionsResponse EndDeleteDhcpOptions(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteFlowLogs


        /// <summary>
        /// Deletes one or more flow logs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteFlowLogs service method.</param>
        /// 
        /// <returns>The response from the DeleteFlowLogs service method, as returned by EC2.</returns>
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
        IAsyncResult BeginDeleteFlowLogs(DeleteFlowLogsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteFlowLogs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteFlowLogs.</param>
        /// 
        /// <returns>Returns a  DeleteFlowLogsResult from EC2.</returns>
        DeleteFlowLogsResponse EndDeleteFlowLogs(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteInternetGateway


        /// <summary>
        /// Deletes the specified Internet gateway. You must detach the Internet gateway from
        /// the VPC before you can delete it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInternetGateway service method.</param>
        /// 
        /// <returns>The response from the DeleteInternetGateway service method, as returned by EC2.</returns>
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
        IAsyncResult BeginDeleteInternetGateway(DeleteInternetGatewayRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteInternetGateway operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteInternetGateway.</param>
        /// 
        /// <returns>Returns a  DeleteInternetGatewayResult from EC2.</returns>
        DeleteInternetGatewayResponse EndDeleteInternetGateway(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteKeyPair


        /// <summary>
        /// Deletes the specified key pair, by removing the public key from Amazon EC2.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteKeyPair service method.</param>
        /// 
        /// <returns>The response from the DeleteKeyPair service method, as returned by EC2.</returns>
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
        IAsyncResult BeginDeleteKeyPair(DeleteKeyPairRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteKeyPair operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteKeyPair.</param>
        /// 
        /// <returns>Returns a  DeleteKeyPairResult from EC2.</returns>
        DeleteKeyPairResponse EndDeleteKeyPair(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteNetworkAcl


        /// <summary>
        /// Deletes the specified network ACL. You can't delete the ACL if it's associated with
        /// any subnets. You can't delete the default network ACL.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNetworkAcl service method.</param>
        /// 
        /// <returns>The response from the DeleteNetworkAcl service method, as returned by EC2.</returns>
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
        IAsyncResult BeginDeleteNetworkAcl(DeleteNetworkAclRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteNetworkAcl operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteNetworkAcl.</param>
        /// 
        /// <returns>Returns a  DeleteNetworkAclResult from EC2.</returns>
        DeleteNetworkAclResponse EndDeleteNetworkAcl(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteNetworkAclEntry


        /// <summary>
        /// Deletes the specified ingress or egress entry (rule) from the specified network ACL.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNetworkAclEntry service method.</param>
        /// 
        /// <returns>The response from the DeleteNetworkAclEntry service method, as returned by EC2.</returns>
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
        IAsyncResult BeginDeleteNetworkAclEntry(DeleteNetworkAclEntryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteNetworkAclEntry operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteNetworkAclEntry.</param>
        /// 
        /// <returns>Returns a  DeleteNetworkAclEntryResult from EC2.</returns>
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
        IAsyncResult BeginDeleteNetworkInterface(DeleteNetworkInterfaceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteNetworkInterface operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteNetworkInterface.</param>
        /// 
        /// <returns>Returns a  DeleteNetworkInterfaceResult from EC2.</returns>
        DeleteNetworkInterfaceResponse EndDeleteNetworkInterface(IAsyncResult asyncResult);

        #endregion
        
        #region  DeletePlacementGroup


        /// <summary>
        /// Deletes the specified placement group. You must terminate all instances in the placement
        /// group before you can delete the placement group. For more information about placement
        /// groups and cluster instances, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using_cluster_computing.html">Cluster
        /// Instances</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePlacementGroup service method.</param>
        /// 
        /// <returns>The response from the DeletePlacementGroup service method, as returned by EC2.</returns>
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
        IAsyncResult BeginDeletePlacementGroup(DeletePlacementGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePlacementGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePlacementGroup.</param>
        /// 
        /// <returns>Returns a  DeletePlacementGroupResult from EC2.</returns>
        DeletePlacementGroupResponse EndDeletePlacementGroup(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteRoute


        /// <summary>
        /// Deletes the specified route from the specified route table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRoute service method.</param>
        /// 
        /// <returns>The response from the DeleteRoute service method, as returned by EC2.</returns>
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
        IAsyncResult BeginDeleteRoute(DeleteRouteRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRoute operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRoute.</param>
        /// 
        /// <returns>Returns a  DeleteRouteResult from EC2.</returns>
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
        IAsyncResult BeginDeleteRouteTable(DeleteRouteTableRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteRouteTable operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRouteTable.</param>
        /// 
        /// <returns>Returns a  DeleteRouteTableResult from EC2.</returns>
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
        IAsyncResult BeginDeleteSecurityGroup(DeleteSecurityGroupRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSecurityGroup operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSecurityGroup.</param>
        /// 
        /// <returns>Returns a  DeleteSecurityGroupResult from EC2.</returns>
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
        IAsyncResult BeginDeleteSnapshot(DeleteSnapshotRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSnapshot.</param>
        /// 
        /// <returns>Returns a  DeleteSnapshotResult from EC2.</returns>
        DeleteSnapshotResponse EndDeleteSnapshot(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteSpotDatafeedSubscription


        /// <summary>
        /// Deletes the data feed for Spot Instances. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/spot-data-feeds.html">Spot
        /// Instance Data Feed</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </summary>
        /// 
        /// <returns>The response from the DeleteSpotDatafeedSubscription service method, as returned by EC2.</returns>
        DeleteSpotDatafeedSubscriptionResponse DeleteSpotDatafeedSubscription();

        /// <summary>
        /// Deletes the data feed for Spot Instances. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/spot-data-feeds.html">Spot
        /// Instance Data Feed</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSpotDatafeedSubscription service method.</param>
        /// 
        /// <returns>The response from the DeleteSpotDatafeedSubscription service method, as returned by EC2.</returns>
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
        IAsyncResult BeginDeleteSpotDatafeedSubscription(DeleteSpotDatafeedSubscriptionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSpotDatafeedSubscription operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSpotDatafeedSubscription.</param>
        /// 
        /// <returns>Returns a  DeleteSpotDatafeedSubscriptionResult from EC2.</returns>
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
        IAsyncResult BeginDeleteSubnet(DeleteSubnetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSubnet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSubnet.</param>
        /// 
        /// <returns>Returns a  DeleteSubnetResult from EC2.</returns>
        DeleteSubnetResponse EndDeleteSubnet(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteTags


        /// <summary>
        /// Deletes the specified set of tags from the specified set of resources. This call is
        /// designed to follow a <code>DescribeTags</code> request.
        /// 
        ///  
        /// <para>
        /// For more information about tags, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_Tags.html">Tagging
        /// Your Resources</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteTags service method.</param>
        /// 
        /// <returns>The response from the DeleteTags service method, as returned by EC2.</returns>
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
        IAsyncResult BeginDeleteTags(DeleteTagsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTags.</param>
        /// 
        /// <returns>Returns a  DeleteTagsResult from EC2.</returns>
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
        IAsyncResult BeginDeleteVolume(DeleteVolumeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVolume operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVolume.</param>
        /// 
        /// <returns>Returns a  DeleteVolumeResult from EC2.</returns>
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
        IAsyncResult BeginDeleteVpc(DeleteVpcRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVpc operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVpc.</param>
        /// 
        /// <returns>Returns a  DeleteVpcResult from EC2.</returns>
        DeleteVpcResponse EndDeleteVpc(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteVpcEndpoints


        /// <summary>
        /// Deletes one or more specified VPC endpoints. Deleting the endpoint also deletes the
        /// endpoint routes in the route tables that were associated with the endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpcEndpoints service method.</param>
        /// 
        /// <returns>The response from the DeleteVpcEndpoints service method, as returned by EC2.</returns>
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
        IAsyncResult BeginDeleteVpcEndpoints(DeleteVpcEndpointsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVpcEndpoints operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVpcEndpoints.</param>
        /// 
        /// <returns>Returns a  DeleteVpcEndpointsResult from EC2.</returns>
        DeleteVpcEndpointsResponse EndDeleteVpcEndpoints(IAsyncResult asyncResult);

        #endregion
        
        #region  DeleteVpcPeeringConnection


        /// <summary>
        /// Deletes a VPC peering connection. Either the owner of the requester VPC or the owner
        /// of the peer VPC can delete the VPC peering connection if it's in the <code>active</code>
        /// state. The owner of the requester VPC can delete a VPC peering connection in the <code>pending-acceptance</code>
        /// state.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpcPeeringConnection service method.</param>
        /// 
        /// <returns>The response from the DeleteVpcPeeringConnection service method, as returned by EC2.</returns>
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
        IAsyncResult BeginDeleteVpcPeeringConnection(DeleteVpcPeeringConnectionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVpcPeeringConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVpcPeeringConnection.</param>
        /// 
        /// <returns>Returns a  DeleteVpcPeeringConnectionResult from EC2.</returns>
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
        IAsyncResult BeginDeleteVpnConnection(DeleteVpnConnectionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVpnConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVpnConnection.</param>
        /// 
        /// <returns>Returns a  DeleteVpnConnectionResult from EC2.</returns>
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
        IAsyncResult BeginDeleteVpnConnectionRoute(DeleteVpnConnectionRouteRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVpnConnectionRoute operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVpnConnectionRoute.</param>
        /// 
        /// <returns>Returns a  DeleteVpnConnectionRouteResult from EC2.</returns>
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
        IAsyncResult BeginDeleteVpnGateway(DeleteVpnGatewayRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteVpnGateway operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVpnGateway.</param>
        /// 
        /// <returns>Returns a  DeleteVpnGatewayResult from EC2.</returns>
        DeleteVpnGatewayResponse EndDeleteVpnGateway(IAsyncResult asyncResult);

        #endregion
        
        #region  DeregisterImage


        /// <summary>
        /// Deregisters the specified AMI. After you deregister an AMI, it can't be used to launch
        /// new instances.
        /// 
        ///  
        /// <para>
        /// This command does not delete the AMI.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterImage service method.</param>
        /// 
        /// <returns>The response from the DeregisterImage service method, as returned by EC2.</returns>
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
        IAsyncResult BeginDeregisterImage(DeregisterImageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DeregisterImage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeregisterImage.</param>
        /// 
        /// <returns>Returns a  DeregisterImageResult from EC2.</returns>
        DeregisterImageResponse EndDeregisterImage(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeAccountAttributes


        /// <summary>
        /// Describes attributes of your AWS account. The following are the supported account
        /// attributes:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// <code>supported-platforms</code>: Indicates whether your account can launch instances
        /// into EC2-Classic and EC2-VPC, or only into EC2-VPC.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>default-vpc</code>: The ID of the default VPC for your account, or <code>none</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>max-instances</code>: The maximum number of On-Demand instances that you can
        /// run.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>vpc-max-security-groups-per-interface</code>: The maximum number of security
        /// groups that you can assign to a network interface.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>max-elastic-ips</code>: The maximum number of Elastic IP addresses that you
        /// can allocate for use with EC2-Classic. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>vpc-max-elastic-ips</code>: The maximum number of Elastic IP addresses that
        /// you can allocate for use with EC2-VPC.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeAccountAttributes service method, as returned by EC2.</returns>
        DescribeAccountAttributesResponse DescribeAccountAttributes();

        /// <summary>
        /// Describes attributes of your AWS account. The following are the supported account
        /// attributes:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// <code>supported-platforms</code>: Indicates whether your account can launch instances
        /// into EC2-Classic and EC2-VPC, or only into EC2-VPC.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>default-vpc</code>: The ID of the default VPC for your account, or <code>none</code>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>max-instances</code>: The maximum number of On-Demand instances that you can
        /// run.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>vpc-max-security-groups-per-interface</code>: The maximum number of security
        /// groups that you can assign to a network interface.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>max-elastic-ips</code>: The maximum number of Elastic IP addresses that you
        /// can allocate for use with EC2-Classic. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <code>vpc-max-elastic-ips</code>: The maximum number of Elastic IP addresses that
        /// you can allocate for use with EC2-VPC.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountAttributes service method.</param>
        /// 
        /// <returns>The response from the DescribeAccountAttributes service method, as returned by EC2.</returns>
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
        IAsyncResult BeginDescribeAccountAttributes(DescribeAccountAttributesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAccountAttributes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAccountAttributes.</param>
        /// 
        /// <returns>Returns a  DescribeAccountAttributesResult from EC2.</returns>
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
        IAsyncResult BeginDescribeAddresses(DescribeAddressesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAddresses operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAddresses.</param>
        /// 
        /// <returns>Returns a  DescribeAddressesResult from EC2.</returns>
        DescribeAddressesResponse EndDescribeAddresses(IAsyncResult asyncResult);

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
        IAsyncResult BeginDescribeAvailabilityZones(DescribeAvailabilityZonesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeAvailabilityZones operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAvailabilityZones.</param>
        /// 
        /// <returns>Returns a  DescribeAvailabilityZonesResult from EC2.</returns>
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
        /// </note>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeBundleTasks service method, as returned by EC2.</returns>
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
        /// </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBundleTasks service method.</param>
        /// 
        /// <returns>The response from the DescribeBundleTasks service method, as returned by EC2.</returns>
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
        IAsyncResult BeginDescribeBundleTasks(DescribeBundleTasksRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeBundleTasks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeBundleTasks.</param>
        /// 
        /// <returns>Returns a  DescribeBundleTasksResult from EC2.</returns>
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
        IAsyncResult BeginDescribeClassicLinkInstances(DescribeClassicLinkInstancesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeClassicLinkInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeClassicLinkInstances.</param>
        /// 
        /// <returns>Returns a  DescribeClassicLinkInstancesResult from EC2.</returns>
        DescribeClassicLinkInstancesResponse EndDescribeClassicLinkInstances(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeConversionTasks


        /// <summary>
        /// Describes one or more of your conversion tasks. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/UploadingYourInstancesandVolumes.html">Using
        /// the Command Line Tools to Import Your Virtual Machine to Amazon EC2</a> in the <i>Amazon
        /// Elastic Compute Cloud User Guide</i>.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeConversionTasks service method, as returned by EC2.</returns>
        DescribeConversionTasksResponse DescribeConversionTasks();

        /// <summary>
        /// Describes one or more of your conversion tasks. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/UploadingYourInstancesandVolumes.html">Using
        /// the Command Line Tools to Import Your Virtual Machine to Amazon EC2</a> in the <i>Amazon
        /// Elastic Compute Cloud User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConversionTasks service method.</param>
        /// 
        /// <returns>The response from the DescribeConversionTasks service method, as returned by EC2.</returns>
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
        IAsyncResult BeginDescribeConversionTasks(DescribeConversionTasksRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeConversionTasks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeConversionTasks.</param>
        /// 
        /// <returns>Returns a  DescribeConversionTasksResult from EC2.</returns>
        DescribeConversionTasksResponse EndDescribeConversionTasks(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeCustomerGateways


        /// <summary>
        /// Describes one or more of your VPN customer gateways.
        /// 
        ///  
        /// <para>
        /// For more information about VPN customer gateways, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_VPN.html">Adding
        /// a Hardware Virtual Private Gateway to Your VPC</a> in the <i>Amazon Virtual Private
        /// Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeCustomerGateways service method, as returned by EC2.</returns>
        DescribeCustomerGatewaysResponse DescribeCustomerGateways();

        /// <summary>
        /// Describes one or more of your VPN customer gateways.
        /// 
        ///  
        /// <para>
        /// For more information about VPN customer gateways, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_VPN.html">Adding
        /// a Hardware Virtual Private Gateway to Your VPC</a> in the <i>Amazon Virtual Private
        /// Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCustomerGateways service method.</param>
        /// 
        /// <returns>The response from the DescribeCustomerGateways service method, as returned by EC2.</returns>
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
        IAsyncResult BeginDescribeCustomerGateways(DescribeCustomerGatewaysRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeCustomerGateways operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCustomerGateways.</param>
        /// 
        /// <returns>Returns a  DescribeCustomerGatewaysResult from EC2.</returns>
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
        IAsyncResult BeginDescribeDhcpOptions(DescribeDhcpOptionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeDhcpOptions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDhcpOptions.</param>
        /// 
        /// <returns>Returns a  DescribeDhcpOptionsResult from EC2.</returns>
        DescribeDhcpOptionsResponse EndDescribeDhcpOptions(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeExportTasks


        /// <summary>
        /// Describes one or more of your export tasks.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeExportTasks service method, as returned by EC2.</returns>
        DescribeExportTasksResponse DescribeExportTasks();

        /// <summary>
        /// Describes one or more of your export tasks.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeExportTasks service method.</param>
        /// 
        /// <returns>The response from the DescribeExportTasks service method, as returned by EC2.</returns>
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
        IAsyncResult BeginDescribeExportTasks(DescribeExportTasksRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeExportTasks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeExportTasks.</param>
        /// 
        /// <returns>Returns a  DescribeExportTasksResult from EC2.</returns>
        DescribeExportTasksResponse EndDescribeExportTasks(IAsyncResult asyncResult);

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
        IAsyncResult BeginDescribeFlowLogs(DescribeFlowLogsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeFlowLogs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeFlowLogs.</param>
        /// 
        /// <returns>Returns a  DescribeFlowLogsResult from EC2.</returns>
        DescribeFlowLogsResponse EndDescribeFlowLogs(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeImageAttribute


        /// <summary>
        /// Describes the specified attribute of the specified AMI. You can specify only one attribute
        /// at a time.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeImageAttribute service method.</param>
        /// 
        /// <returns>The response from the DescribeImageAttribute service method, as returned by EC2.</returns>
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
        IAsyncResult BeginDescribeImageAttribute(DescribeImageAttributeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeImageAttribute operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeImageAttribute.</param>
        /// 
        /// <returns>Returns a  DescribeImageAttributeResult from EC2.</returns>
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
        /// </note>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeImages service method, as returned by EC2.</returns>
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
        /// </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeImages service method.</param>
        /// 
        /// <returns>The response from the DescribeImages service method, as returned by EC2.</returns>
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
        IAsyncResult BeginDescribeImages(DescribeImagesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeImages operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeImages.</param>
        /// 
        /// <returns>Returns a  DescribeImagesResult from EC2.</returns>
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
        IAsyncResult BeginDescribeImportImageTasks(DescribeImportImageTasksRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeImportImageTasks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeImportImageTasks.</param>
        /// 
        /// <returns>Returns a  DescribeImportImageTasksResult from EC2.</returns>
        DescribeImportImageTasksResponse EndDescribeImportImageTasks(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeImportSnapshotTasks


        /// <summary>
        /// Describes your import snapshot tasks.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeImportSnapshotTasks service method.</param>
        /// 
        /// <returns>The response from the DescribeImportSnapshotTasks service method, as returned by EC2.</returns>
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
        IAsyncResult BeginDescribeImportSnapshotTasks(DescribeImportSnapshotTasksRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeImportSnapshotTasks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeImportSnapshotTasks.</param>
        /// 
        /// <returns>Returns a  DescribeImportSnapshotTasksResult from EC2.</returns>
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
        IAsyncResult BeginDescribeInstanceAttribute(DescribeInstanceAttributeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeInstanceAttribute operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeInstanceAttribute.</param>
        /// 
        /// <returns>Returns a  DescribeInstanceAttributeResult from EC2.</returns>
        DescribeInstanceAttributeResponse EndDescribeInstanceAttribute(IAsyncResult asyncResult);

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
        /// </summary>
        /// 
        /// <returns>The response from the DescribeInstances service method, as returned by EC2.</returns>
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
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstances service method.</param>
        /// 
        /// <returns>The response from the DescribeInstances service method, as returned by EC2.</returns>
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
        IAsyncResult BeginDescribeInstances(DescribeInstancesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeInstances.</param>
        /// 
        /// <returns>Returns a  DescribeInstancesResult from EC2.</returns>
        DescribeInstancesResponse EndDescribeInstances(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeInstanceStatus


        /// <summary>
        /// Describes the status of one or more instances.
        /// 
        ///  
        /// <para>
        /// Instance status includes the following components:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// <b>Status checks</b> - Amazon EC2 performs status checks on running EC2 instances
        /// to identify hardware and software issues. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/monitoring-system-instance-status-check.html">Status
        /// Checks for Your Instances</a> and <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/TroubleshootingInstances.html">Troubleshooting
        /// Instances with Failed Status Checks</a> in the <i>Amazon Elastic Compute Cloud User
        /// Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <b>Scheduled events</b> - Amazon EC2 can schedule events (such as reboot, stop, or
        /// terminate) for your instances related to hardware issues, software updates, or system
        /// maintenance. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/monitoring-instances-status-check_sched.html">Scheduled
        /// Events for Your Instances</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <b>Instance state</b> - You can manage your instances from the moment you launch them
        /// through their termination. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-instance-lifecycle.html">Instance
        /// Lifecycle</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeInstanceStatus service method, as returned by EC2.</returns>
        DescribeInstanceStatusResponse DescribeInstanceStatus();

        /// <summary>
        /// Describes the status of one or more instances.
        /// 
        ///  
        /// <para>
        /// Instance status includes the following components:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// <b>Status checks</b> - Amazon EC2 performs status checks on running EC2 instances
        /// to identify hardware and software issues. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/monitoring-system-instance-status-check.html">Status
        /// Checks for Your Instances</a> and <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/TroubleshootingInstances.html">Troubleshooting
        /// Instances with Failed Status Checks</a> in the <i>Amazon Elastic Compute Cloud User
        /// Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <b>Scheduled events</b> - Amazon EC2 can schedule events (such as reboot, stop, or
        /// terminate) for your instances related to hardware issues, software updates, or system
        /// maintenance. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/monitoring-instances-status-check_sched.html">Scheduled
        /// Events for Your Instances</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// <b>Instance state</b> - You can manage your instances from the moment you launch them
        /// through their termination. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-instance-lifecycle.html">Instance
        /// Lifecycle</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstanceStatus service method.</param>
        /// 
        /// <returns>The response from the DescribeInstanceStatus service method, as returned by EC2.</returns>
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
        IAsyncResult BeginDescribeInstanceStatus(DescribeInstanceStatusRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeInstanceStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeInstanceStatus.</param>
        /// 
        /// <returns>Returns a  DescribeInstanceStatusResult from EC2.</returns>
        DescribeInstanceStatusResponse EndDescribeInstanceStatus(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeInternetGateways


        /// <summary>
        /// Describes one or more of your Internet gateways.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeInternetGateways service method, as returned by EC2.</returns>
        DescribeInternetGatewaysResponse DescribeInternetGateways();

        /// <summary>
        /// Describes one or more of your Internet gateways.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInternetGateways service method.</param>
        /// 
        /// <returns>The response from the DescribeInternetGateways service method, as returned by EC2.</returns>
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
        IAsyncResult BeginDescribeInternetGateways(DescribeInternetGatewaysRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeInternetGateways operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeInternetGateways.</param>
        /// 
        /// <returns>Returns a  DescribeInternetGatewaysResult from EC2.</returns>
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
        IAsyncResult BeginDescribeKeyPairs(DescribeKeyPairsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeKeyPairs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeKeyPairs.</param>
        /// 
        /// <returns>Returns a  DescribeKeyPairsResult from EC2.</returns>
        DescribeKeyPairsResponse EndDescribeKeyPairs(IAsyncResult asyncResult);

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
        IAsyncResult BeginDescribeMovingAddresses(DescribeMovingAddressesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeMovingAddresses operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeMovingAddresses.</param>
        /// 
        /// <returns>Returns a  DescribeMovingAddressesResult from EC2.</returns>
        DescribeMovingAddressesResponse EndDescribeMovingAddresses(IAsyncResult asyncResult);

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
        IAsyncResult BeginDescribeNetworkAcls(DescribeNetworkAclsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeNetworkAcls operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeNetworkAcls.</param>
        /// 
        /// <returns>Returns a  DescribeNetworkAclsResult from EC2.</returns>
        DescribeNetworkAclsResponse EndDescribeNetworkAcls(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeNetworkInterfaceAttribute


        /// <summary>
        /// Describes a network interface attribute. You can specify only one attribute at a time.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeNetworkInterfaceAttribute service method.</param>
        /// 
        /// <returns>The response from the DescribeNetworkInterfaceAttribute service method, as returned by EC2.</returns>
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
        IAsyncResult BeginDescribeNetworkInterfaceAttribute(DescribeNetworkInterfaceAttributeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeNetworkInterfaceAttribute operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeNetworkInterfaceAttribute.</param>
        /// 
        /// <returns>Returns a  DescribeNetworkInterfaceAttributeResult from EC2.</returns>
        DescribeNetworkInterfaceAttributeResponse EndDescribeNetworkInterfaceAttribute(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeNetworkInterfaces


        /// <summary>
        /// Describes one or more of your network interfaces.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeNetworkInterfaces service method, as returned by EC2.</returns>
        DescribeNetworkInterfacesResponse DescribeNetworkInterfaces();

        /// <summary>
        /// Describes one or more of your network interfaces.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeNetworkInterfaces service method.</param>
        /// 
        /// <returns>The response from the DescribeNetworkInterfaces service method, as returned by EC2.</returns>
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
        IAsyncResult BeginDescribeNetworkInterfaces(DescribeNetworkInterfacesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeNetworkInterfaces operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeNetworkInterfaces.</param>
        /// 
        /// <returns>Returns a  DescribeNetworkInterfacesResult from EC2.</returns>
        DescribeNetworkInterfacesResponse EndDescribeNetworkInterfaces(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribePlacementGroups


        /// <summary>
        /// Describes one or more of your placement groups. For more information about placement
        /// groups and cluster instances, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using_cluster_computing.html">Cluster
        /// Instances</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </summary>
        /// 
        /// <returns>The response from the DescribePlacementGroups service method, as returned by EC2.</returns>
        DescribePlacementGroupsResponse DescribePlacementGroups();

        /// <summary>
        /// Describes one or more of your placement groups. For more information about placement
        /// groups and cluster instances, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using_cluster_computing.html">Cluster
        /// Instances</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePlacementGroups service method.</param>
        /// 
        /// <returns>The response from the DescribePlacementGroups service method, as returned by EC2.</returns>
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
        IAsyncResult BeginDescribePlacementGroups(DescribePlacementGroupsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribePlacementGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribePlacementGroups.</param>
        /// 
        /// <returns>Returns a  DescribePlacementGroupsResult from EC2.</returns>
        DescribePlacementGroupsResponse EndDescribePlacementGroups(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribePrefixLists


        /// <summary>
        /// Describes available AWS services in a prefix list format, which includes the prefix
        /// list name and prefix list ID of the service and the IP address range for the service.
        /// A prefix list ID is required for creating an outbound security group rule that allows
        /// traffic from a VPC to access an AWS service through a VPC endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePrefixLists service method.</param>
        /// 
        /// <returns>The response from the DescribePrefixLists service method, as returned by EC2.</returns>
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
        IAsyncResult BeginDescribePrefixLists(DescribePrefixListsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribePrefixLists operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribePrefixLists.</param>
        /// 
        /// <returns>Returns a  DescribePrefixListsResult from EC2.</returns>
        DescribePrefixListsResponse EndDescribePrefixLists(IAsyncResult asyncResult);

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
        IAsyncResult BeginDescribeRegions(DescribeRegionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeRegions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeRegions.</param>
        /// 
        /// <returns>Returns a  DescribeRegionsResult from EC2.</returns>
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
        IAsyncResult BeginDescribeReservedInstances(DescribeReservedInstancesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeReservedInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeReservedInstances.</param>
        /// 
        /// <returns>Returns a  DescribeReservedInstancesResult from EC2.</returns>
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
        IAsyncResult BeginDescribeReservedInstancesListings(DescribeReservedInstancesListingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeReservedInstancesListings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeReservedInstancesListings.</param>
        /// 
        /// <returns>Returns a  DescribeReservedInstancesListingsResult from EC2.</returns>
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
        IAsyncResult BeginDescribeReservedInstancesModifications(DescribeReservedInstancesModificationsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeReservedInstancesModifications operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeReservedInstancesModifications.</param>
        /// 
        /// <returns>Returns a  DescribeReservedInstancesModificationsResult from EC2.</returns>
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
        /// For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ri-market-general.html">Reserved
        /// Instance Marketplace</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeReservedInstancesOfferings service method, as returned by EC2.</returns>
        DescribeReservedInstancesOfferingsResponse DescribeReservedInstancesOfferings();

        /// <summary>
        /// Describes Reserved Instance offerings that are available for purchase. With Reserved
        /// Instances, you purchase the right to launch instances for a period of time. During
        /// that time period, you do not receive insufficient capacity errors, and you pay a lower
        /// usage rate than the rate charged for On-Demand instances for the actual time used.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ri-market-general.html">Reserved
        /// Instance Marketplace</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedInstancesOfferings service method.</param>
        /// 
        /// <returns>The response from the DescribeReservedInstancesOfferings service method, as returned by EC2.</returns>
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
        IAsyncResult BeginDescribeReservedInstancesOfferings(DescribeReservedInstancesOfferingsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeReservedInstancesOfferings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeReservedInstancesOfferings.</param>
        /// 
        /// <returns>Returns a  DescribeReservedInstancesOfferingsResult from EC2.</returns>
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
        IAsyncResult BeginDescribeRouteTables(DescribeRouteTablesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeRouteTables operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeRouteTables.</param>
        /// 
        /// <returns>Returns a  DescribeRouteTablesResult from EC2.</returns>
        DescribeRouteTablesResponse EndDescribeRouteTables(IAsyncResult asyncResult);

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
        IAsyncResult BeginDescribeSecurityGroups(DescribeSecurityGroupsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSecurityGroups operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSecurityGroups.</param>
        /// 
        /// <returns>Returns a  DescribeSecurityGroupsResult from EC2.</returns>
        DescribeSecurityGroupsResponse EndDescribeSecurityGroups(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeSnapshotAttribute


        /// <summary>
        /// Describes the specified attribute of the specified snapshot. You can specify only
        /// one attribute at a time.
        /// 
        ///  
        /// <para>
        /// For more information about EBS snapshots, see <a href='http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSSnapshots.html'>Amazon
        /// EBS Snapshots</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSnapshotAttribute service method.</param>
        /// 
        /// <returns>The response from the DescribeSnapshotAttribute service method, as returned by EC2.</returns>
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
        IAsyncResult BeginDescribeSnapshotAttribute(DescribeSnapshotAttributeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSnapshotAttribute operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSnapshotAttribute.</param>
        /// 
        /// <returns>Returns a  DescribeSnapshotAttributeResult from EC2.</returns>
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
        ///  <ul> <li> <i>public</i>: The owner of the snapshot granted create volume permissions
        /// for the snapshot to the <code>all</code> group. All AWS accounts have create volume
        /// permissions for these snapshots.</li> <li> <i>explicit</i>: The owner of the snapshot
        /// granted create volume permissions to a specific AWS account.</li> <li> <i>implicit</i>:
        /// An AWS account has implicit create volume permissions for all snapshots it owns.</li>
        /// </ul> 
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
        /// If you specify one or more snapshot owners, only snapshots from the specified owners
        /// and for which you have access are returned. The results can include the AWS account
        /// IDs of the specified owners, <code>amazon</code> for snapshots owned by Amazon, or
        /// <code>self</code> for snapshots that you own.
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
        /// For more information about EBS snapshots, see <a href='http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSSnapshots.html'>Amazon
        /// EBS Snapshots</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeSnapshots service method, as returned by EC2.</returns>
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
        ///  <ul> <li> <i>public</i>: The owner of the snapshot granted create volume permissions
        /// for the snapshot to the <code>all</code> group. All AWS accounts have create volume
        /// permissions for these snapshots.</li> <li> <i>explicit</i>: The owner of the snapshot
        /// granted create volume permissions to a specific AWS account.</li> <li> <i>implicit</i>:
        /// An AWS account has implicit create volume permissions for all snapshots it owns.</li>
        /// </ul> 
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
        /// If you specify one or more snapshot owners, only snapshots from the specified owners
        /// and for which you have access are returned. The results can include the AWS account
        /// IDs of the specified owners, <code>amazon</code> for snapshots owned by Amazon, or
        /// <code>self</code> for snapshots that you own.
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
        /// For more information about EBS snapshots, see <a href='http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSSnapshots.html'>Amazon
        /// EBS Snapshots</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSnapshots service method.</param>
        /// 
        /// <returns>The response from the DescribeSnapshots service method, as returned by EC2.</returns>
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
        IAsyncResult BeginDescribeSnapshots(DescribeSnapshotsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSnapshots operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSnapshots.</param>
        /// 
        /// <returns>Returns a  DescribeSnapshotsResult from EC2.</returns>
        DescribeSnapshotsResponse EndDescribeSnapshots(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeSpotDatafeedSubscription


        /// <summary>
        /// Describes the data feed for Spot Instances. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/spot-data-feeds.html">Spot
        /// Instance Data Feed</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeSpotDatafeedSubscription service method, as returned by EC2.</returns>
        DescribeSpotDatafeedSubscriptionResponse DescribeSpotDatafeedSubscription();

        /// <summary>
        /// Describes the data feed for Spot Instances. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/spot-data-feeds.html">Spot
        /// Instance Data Feed</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSpotDatafeedSubscription service method.</param>
        /// 
        /// <returns>The response from the DescribeSpotDatafeedSubscription service method, as returned by EC2.</returns>
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
        IAsyncResult BeginDescribeSpotDatafeedSubscription(DescribeSpotDatafeedSubscriptionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSpotDatafeedSubscription operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSpotDatafeedSubscription.</param>
        /// 
        /// <returns>Returns a  DescribeSpotDatafeedSubscriptionResult from EC2.</returns>
        DescribeSpotDatafeedSubscriptionResponse EndDescribeSpotDatafeedSubscription(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeSpotFleetInstances


        /// <summary>
        /// Describes the running instances for the specified Spot fleet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSpotFleetInstances service method.</param>
        /// 
        /// <returns>The response from the DescribeSpotFleetInstances service method, as returned by EC2.</returns>
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
        IAsyncResult BeginDescribeSpotFleetInstances(DescribeSpotFleetInstancesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSpotFleetInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSpotFleetInstances.</param>
        /// 
        /// <returns>Returns a  DescribeSpotFleetInstancesResult from EC2.</returns>
        DescribeSpotFleetInstancesResponse EndDescribeSpotFleetInstances(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeSpotFleetRequestHistory


        /// <summary>
        /// Describes the events for the specified Spot fleet request during the specified time.
        /// 
        ///  
        /// <para>
        /// Spot fleet events are delayed by up to 30 seconds before they can be described. This
        /// ensures that you can query by the last evaluated time and not miss a recorded event.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSpotFleetRequestHistory service method.</param>
        /// 
        /// <returns>The response from the DescribeSpotFleetRequestHistory service method, as returned by EC2.</returns>
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
        IAsyncResult BeginDescribeSpotFleetRequestHistory(DescribeSpotFleetRequestHistoryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSpotFleetRequestHistory operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSpotFleetRequestHistory.</param>
        /// 
        /// <returns>Returns a  DescribeSpotFleetRequestHistoryResult from EC2.</returns>
        DescribeSpotFleetRequestHistoryResponse EndDescribeSpotFleetRequestHistory(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeSpotFleetRequests


        /// <summary>
        /// Describes your Spot fleet requests.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSpotFleetRequests service method.</param>
        /// 
        /// <returns>The response from the DescribeSpotFleetRequests service method, as returned by EC2.</returns>
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
        IAsyncResult BeginDescribeSpotFleetRequests(DescribeSpotFleetRequestsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSpotFleetRequests operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSpotFleetRequests.</param>
        /// 
        /// <returns>Returns a  DescribeSpotFleetRequestsResult from EC2.</returns>
        DescribeSpotFleetRequestsResponse EndDescribeSpotFleetRequests(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeSpotInstanceRequests


        /// <summary>
        /// Describes the Spot Instance requests that belong to your account. Spot Instances are
        /// instances that Amazon EC2 launches when the bid price that you specify exceeds the
        /// current Spot Price. Amazon EC2 periodically sets the Spot Price based on available
        /// Spot Instance capacity and current Spot Instance requests. For more information, see
        /// <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/spot-requests.html">Spot
        /// Instance Requests</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// 
        ///  
        /// <para>
        /// You can use <code>DescribeSpotInstanceRequests</code> to find a running Spot Instance
        /// by examining the response. If the status of the Spot Instance is <code>fulfilled</code>,
        /// the instance ID appears in the response and contains the identifier of the instance.
        /// Alternatively, you can use <a>DescribeInstances</a> with a filter to look for instances
        /// where the instance lifecycle is <code>spot</code>.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeSpotInstanceRequests service method, as returned by EC2.</returns>
        DescribeSpotInstanceRequestsResponse DescribeSpotInstanceRequests();

        /// <summary>
        /// Describes the Spot Instance requests that belong to your account. Spot Instances are
        /// instances that Amazon EC2 launches when the bid price that you specify exceeds the
        /// current Spot Price. Amazon EC2 periodically sets the Spot Price based on available
        /// Spot Instance capacity and current Spot Instance requests. For more information, see
        /// <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/spot-requests.html">Spot
        /// Instance Requests</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// 
        ///  
        /// <para>
        /// You can use <code>DescribeSpotInstanceRequests</code> to find a running Spot Instance
        /// by examining the response. If the status of the Spot Instance is <code>fulfilled</code>,
        /// the instance ID appears in the response and contains the identifier of the instance.
        /// Alternatively, you can use <a>DescribeInstances</a> with a filter to look for instances
        /// where the instance lifecycle is <code>spot</code>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSpotInstanceRequests service method.</param>
        /// 
        /// <returns>The response from the DescribeSpotInstanceRequests service method, as returned by EC2.</returns>
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
        IAsyncResult BeginDescribeSpotInstanceRequests(DescribeSpotInstanceRequestsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSpotInstanceRequests operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSpotInstanceRequests.</param>
        /// 
        /// <returns>Returns a  DescribeSpotInstanceRequestsResult from EC2.</returns>
        DescribeSpotInstanceRequestsResponse EndDescribeSpotInstanceRequests(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeSpotPriceHistory


        /// <summary>
        /// Describes the Spot Price history. The prices returned are listed in chronological
        /// order, from the oldest to the most recent, for up to the past 90 days. For more information,
        /// see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-spot-instances-history.html">Spot
        /// Instance Pricing History</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
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
        DescribeSpotPriceHistoryResponse DescribeSpotPriceHistory();

        /// <summary>
        /// Describes the Spot Price history. The prices returned are listed in chronological
        /// order, from the oldest to the most recent, for up to the past 90 days. For more information,
        /// see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-spot-instances-history.html">Spot
        /// Instance Pricing History</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
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
        IAsyncResult BeginDescribeSpotPriceHistory(DescribeSpotPriceHistoryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSpotPriceHistory operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSpotPriceHistory.</param>
        /// 
        /// <returns>Returns a  DescribeSpotPriceHistoryResult from EC2.</returns>
        DescribeSpotPriceHistoryResponse EndDescribeSpotPriceHistory(IAsyncResult asyncResult);

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
        IAsyncResult BeginDescribeSubnets(DescribeSubnetsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeSubnets operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSubnets.</param>
        /// 
        /// <returns>Returns a  DescribeSubnetsResult from EC2.</returns>
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
        IAsyncResult BeginDescribeTags(DescribeTagsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeTags operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTags.</param>
        /// 
        /// <returns>Returns a  DescribeTagsResult from EC2.</returns>
        DescribeTagsResponse EndDescribeTags(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeVolumeAttribute


        /// <summary>
        /// Describes the specified attribute of the specified volume. You can specify only one
        /// attribute at a time.
        /// 
        ///  
        /// <para>
        /// For more information about EBS volumes, see <a href='http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSVolumes.html'>Amazon
        /// EBS Volumes</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVolumeAttribute service method.</param>
        /// 
        /// <returns>The response from the DescribeVolumeAttribute service method, as returned by EC2.</returns>
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
        IAsyncResult BeginDescribeVolumeAttribute(DescribeVolumeAttributeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeVolumeAttribute operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeVolumeAttribute.</param>
        /// 
        /// <returns>Returns a  DescribeVolumeAttributeResult from EC2.</returns>
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
        /// For more information about EBS volumes, see <a href='http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSVolumes.html'>Amazon
        /// EBS Volumes</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeVolumes service method, as returned by EC2.</returns>
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
        /// For more information about EBS volumes, see <a href='http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSVolumes.html'>Amazon
        /// EBS Volumes</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVolumes service method.</param>
        /// 
        /// <returns>The response from the DescribeVolumes service method, as returned by EC2.</returns>
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
        IAsyncResult BeginDescribeVolumes(DescribeVolumesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeVolumes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeVolumes.</param>
        /// 
        /// <returns>Returns a  DescribeVolumesResult from EC2.</returns>
        DescribeVolumesResponse EndDescribeVolumes(IAsyncResult asyncResult);

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
        /// <i>Status</i>: Reflects the current status of the volume. The possible values are
        /// <code>ok</code>, <code>impaired</code> , <code>warning</code>, or <code>insufficient-data</code>.
        /// If all checks pass, the overall status of the volume is <code>ok</code>. If the check
        /// fails, the overall status is <code>impaired</code>. If the status is <code>insufficient-data</code>,
        /// then the checks may still be taking place on your volume at the time. We recommend
        /// that you retry the request. For more information on volume status, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/monitoring-volume-status.html">Monitoring
        /// the Status of Your Volumes</a>.
        /// </para>
        ///  
        /// <para>
        /// <i>Events</i>: Reflect the cause of a volume status and may require you to take action.
        /// For example, if your volume returns an <code>impaired</code> status, then the volume
        /// event might be <code>potential-data-inconsistency</code>. This means that your volume
        /// has been affected by an issue with the underlying host, has all I/O operations disabled,
        /// and may have inconsistent data.
        /// </para>
        ///  
        /// <para>
        /// <i>Actions</i>: Reflect the actions you may have to take in response to an event.
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
        /// <i>Status</i>: Reflects the current status of the volume. The possible values are
        /// <code>ok</code>, <code>impaired</code> , <code>warning</code>, or <code>insufficient-data</code>.
        /// If all checks pass, the overall status of the volume is <code>ok</code>. If the check
        /// fails, the overall status is <code>impaired</code>. If the status is <code>insufficient-data</code>,
        /// then the checks may still be taking place on your volume at the time. We recommend
        /// that you retry the request. For more information on volume status, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/monitoring-volume-status.html">Monitoring
        /// the Status of Your Volumes</a>.
        /// </para>
        ///  
        /// <para>
        /// <i>Events</i>: Reflect the cause of a volume status and may require you to take action.
        /// For example, if your volume returns an <code>impaired</code> status, then the volume
        /// event might be <code>potential-data-inconsistency</code>. This means that your volume
        /// has been affected by an issue with the underlying host, has all I/O operations disabled,
        /// and may have inconsistent data.
        /// </para>
        ///  
        /// <para>
        /// <i>Actions</i>: Reflect the actions you may have to take in response to an event.
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
        IAsyncResult BeginDescribeVolumeStatus(DescribeVolumeStatusRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeVolumeStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeVolumeStatus.</param>
        /// 
        /// <returns>Returns a  DescribeVolumeStatusResult from EC2.</returns>
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
        IAsyncResult BeginDescribeVpcAttribute(DescribeVpcAttributeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeVpcAttribute operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeVpcAttribute.</param>
        /// 
        /// <returns>Returns a  DescribeVpcAttributeResult from EC2.</returns>
        DescribeVpcAttributeResponse EndDescribeVpcAttribute(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeVpcClassicLink


        /// <summary>
        /// Describes the ClassicLink status of one or more VPCs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcClassicLink service method.</param>
        /// 
        /// <returns>The response from the DescribeVpcClassicLink service method, as returned by EC2.</returns>
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
        IAsyncResult BeginDescribeVpcClassicLink(DescribeVpcClassicLinkRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeVpcClassicLink operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeVpcClassicLink.</param>
        /// 
        /// <returns>Returns a  DescribeVpcClassicLinkResult from EC2.</returns>
        DescribeVpcClassicLinkResponse EndDescribeVpcClassicLink(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeVpcEndpoints


        /// <summary>
        /// Describes one or more of your VPC endpoints.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcEndpoints service method.</param>
        /// 
        /// <returns>The response from the DescribeVpcEndpoints service method, as returned by EC2.</returns>
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
        IAsyncResult BeginDescribeVpcEndpoints(DescribeVpcEndpointsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeVpcEndpoints operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeVpcEndpoints.</param>
        /// 
        /// <returns>Returns a  DescribeVpcEndpointsResult from EC2.</returns>
        DescribeVpcEndpointsResponse EndDescribeVpcEndpoints(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeVpcEndpointServices


        /// <summary>
        /// Describes all supported AWS services that can be specified when creating a VPC endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcEndpointServices service method.</param>
        /// 
        /// <returns>The response from the DescribeVpcEndpointServices service method, as returned by EC2.</returns>
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
        IAsyncResult BeginDescribeVpcEndpointServices(DescribeVpcEndpointServicesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeVpcEndpointServices operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeVpcEndpointServices.</param>
        /// 
        /// <returns>Returns a  DescribeVpcEndpointServicesResult from EC2.</returns>
        DescribeVpcEndpointServicesResponse EndDescribeVpcEndpointServices(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeVpcPeeringConnections


        /// <summary>
        /// Describes one or more of your VPC peering connections.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeVpcPeeringConnections service method, as returned by EC2.</returns>
        DescribeVpcPeeringConnectionsResponse DescribeVpcPeeringConnections();

        /// <summary>
        /// Describes one or more of your VPC peering connections.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcPeeringConnections service method.</param>
        /// 
        /// <returns>The response from the DescribeVpcPeeringConnections service method, as returned by EC2.</returns>
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
        IAsyncResult BeginDescribeVpcPeeringConnections(DescribeVpcPeeringConnectionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeVpcPeeringConnections operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeVpcPeeringConnections.</param>
        /// 
        /// <returns>Returns a  DescribeVpcPeeringConnectionsResult from EC2.</returns>
        DescribeVpcPeeringConnectionsResponse EndDescribeVpcPeeringConnections(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeVpcs


        /// <summary>
        /// Describes one or more of your VPCs.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeVpcs service method, as returned by EC2.</returns>
        DescribeVpcsResponse DescribeVpcs();

        /// <summary>
        /// Describes one or more of your VPCs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcs service method.</param>
        /// 
        /// <returns>The response from the DescribeVpcs service method, as returned by EC2.</returns>
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
        IAsyncResult BeginDescribeVpcs(DescribeVpcsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeVpcs operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeVpcs.</param>
        /// 
        /// <returns>Returns a  DescribeVpcsResult from EC2.</returns>
        DescribeVpcsResponse EndDescribeVpcs(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeVpnConnections


        /// <summary>
        /// Describes one or more of your VPN connections.
        /// 
        ///  
        /// <para>
        /// For more information about VPN connections, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_VPN.html">Adding
        /// a Hardware Virtual Private Gateway to Your VPC</a> in the <i>Amazon Virtual Private
        /// Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeVpnConnections service method, as returned by EC2.</returns>
        DescribeVpnConnectionsResponse DescribeVpnConnections();

        /// <summary>
        /// Describes one or more of your VPN connections.
        /// 
        ///  
        /// <para>
        /// For more information about VPN connections, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_VPN.html">Adding
        /// a Hardware Virtual Private Gateway to Your VPC</a> in the <i>Amazon Virtual Private
        /// Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpnConnections service method.</param>
        /// 
        /// <returns>The response from the DescribeVpnConnections service method, as returned by EC2.</returns>
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
        IAsyncResult BeginDescribeVpnConnections(DescribeVpnConnectionsRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeVpnConnections operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeVpnConnections.</param>
        /// 
        /// <returns>Returns a  DescribeVpnConnectionsResult from EC2.</returns>
        DescribeVpnConnectionsResponse EndDescribeVpnConnections(IAsyncResult asyncResult);

        #endregion
        
        #region  DescribeVpnGateways


        /// <summary>
        /// Describes one or more of your virtual private gateways.
        /// 
        ///  
        /// <para>
        /// For more information about virtual private gateways, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_VPN.html">Adding
        /// an IPsec Hardware VPN to Your VPC</a> in the <i>Amazon Virtual Private Cloud User
        /// Guide</i>.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeVpnGateways service method, as returned by EC2.</returns>
        DescribeVpnGatewaysResponse DescribeVpnGateways();

        /// <summary>
        /// Describes one or more of your virtual private gateways.
        /// 
        ///  
        /// <para>
        /// For more information about virtual private gateways, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_VPN.html">Adding
        /// an IPsec Hardware VPN to Your VPC</a> in the <i>Amazon Virtual Private Cloud User
        /// Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpnGateways service method.</param>
        /// 
        /// <returns>The response from the DescribeVpnGateways service method, as returned by EC2.</returns>
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
        IAsyncResult BeginDescribeVpnGateways(DescribeVpnGatewaysRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeVpnGateways operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeVpnGateways.</param>
        /// 
        /// <returns>Returns a  DescribeVpnGatewaysResult from EC2.</returns>
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
        IAsyncResult BeginDetachClassicLinkVpc(DetachClassicLinkVpcRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DetachClassicLinkVpc operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetachClassicLinkVpc.</param>
        /// 
        /// <returns>Returns a  DetachClassicLinkVpcResult from EC2.</returns>
        DetachClassicLinkVpcResponse EndDetachClassicLinkVpc(IAsyncResult asyncResult);

        #endregion
        
        #region  DetachInternetGateway


        /// <summary>
        /// Detaches an Internet gateway from a VPC, disabling connectivity between the Internet
        /// and the VPC. The VPC must not contain any running instances with Elastic IP addresses.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachInternetGateway service method.</param>
        /// 
        /// <returns>The response from the DetachInternetGateway service method, as returned by EC2.</returns>
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
        IAsyncResult BeginDetachInternetGateway(DetachInternetGatewayRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DetachInternetGateway operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetachInternetGateway.</param>
        /// 
        /// <returns>Returns a  DetachInternetGatewayResult from EC2.</returns>
        DetachInternetGatewayResponse EndDetachInternetGateway(IAsyncResult asyncResult);

        #endregion
        
        #region  DetachNetworkInterface


        /// <summary>
        /// Detaches a network interface from an instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachNetworkInterface service method.</param>
        /// 
        /// <returns>The response from the DetachNetworkInterface service method, as returned by EC2.</returns>
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
        IAsyncResult BeginDetachNetworkInterface(DetachNetworkInterfaceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DetachNetworkInterface operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetachNetworkInterface.</param>
        /// 
        /// <returns>Returns a  DetachNetworkInterfaceResult from EC2.</returns>
        DetachNetworkInterfaceResponse EndDetachNetworkInterface(IAsyncResult asyncResult);

        #endregion
        
        #region  DetachVolume


        /// <summary>
        /// Detaches an EBS volume from an instance. Make sure to unmount any file systems on
        /// the device within your operating system before detaching the volume. Failure to do
        /// so results in the volume being stuck in a busy state while detaching.
        /// 
        ///  
        /// <para>
        /// If an Amazon EBS volume is the root device of an instance, it can't be detached while
        /// the instance is running. To detach the root volume, stop the instance first.
        /// </para>
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
        IAsyncResult BeginDetachVolume(DetachVolumeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DetachVolume operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetachVolume.</param>
        /// 
        /// <returns>Returns a  DetachVolumeResult from EC2.</returns>
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
        IAsyncResult BeginDetachVpnGateway(DetachVpnGatewayRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DetachVpnGateway operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetachVpnGateway.</param>
        /// 
        /// <returns>Returns a  DetachVpnGatewayResult from EC2.</returns>
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
        IAsyncResult BeginDisableVgwRoutePropagation(DisableVgwRoutePropagationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisableVgwRoutePropagation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisableVgwRoutePropagation.</param>
        /// 
        /// <returns>Returns a  DisableVgwRoutePropagationResult from EC2.</returns>
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
        IAsyncResult BeginDisableVpcClassicLink(DisableVpcClassicLinkRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisableVpcClassicLink operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisableVpcClassicLink.</param>
        /// 
        /// <returns>Returns a  DisableVpcClassicLinkResult from EC2.</returns>
        DisableVpcClassicLinkResponse EndDisableVpcClassicLink(IAsyncResult asyncResult);

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
        IAsyncResult BeginDisassociateAddress(DisassociateAddressRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateAddress operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateAddress.</param>
        /// 
        /// <returns>Returns a  DisassociateAddressResult from EC2.</returns>
        DisassociateAddressResponse EndDisassociateAddress(IAsyncResult asyncResult);

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
        IAsyncResult BeginDisassociateRouteTable(DisassociateRouteTableRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateRouteTable operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateRouteTable.</param>
        /// 
        /// <returns>Returns a  DisassociateRouteTableResult from EC2.</returns>
        DisassociateRouteTableResponse EndDisassociateRouteTable(IAsyncResult asyncResult);

        #endregion
        
        #region  EnableVgwRoutePropagation


        /// <summary>
        /// Enables a virtual private gateway (VGW) to propagate routes to the specified route
        /// table of a VPC.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableVgwRoutePropagation service method.</param>
        /// 
        /// <returns>The response from the EnableVgwRoutePropagation service method, as returned by EC2.</returns>
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
        IAsyncResult BeginEnableVgwRoutePropagation(EnableVgwRoutePropagationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  EnableVgwRoutePropagation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEnableVgwRoutePropagation.</param>
        /// 
        /// <returns>Returns a  EnableVgwRoutePropagationResult from EC2.</returns>
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
        IAsyncResult BeginEnableVolumeIO(EnableVolumeIORequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  EnableVolumeIO operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEnableVolumeIO.</param>
        /// 
        /// <returns>Returns a  EnableVolumeIOResult from EC2.</returns>
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
        /// in the Amazon Elastic Compute Cloud User Guide.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableVpcClassicLink service method.</param>
        /// 
        /// <returns>The response from the EnableVpcClassicLink service method, as returned by EC2.</returns>
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
        IAsyncResult BeginEnableVpcClassicLink(EnableVpcClassicLinkRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  EnableVpcClassicLink operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEnableVpcClassicLink.</param>
        /// 
        /// <returns>Returns a  EnableVpcClassicLinkResult from EC2.</returns>
        EnableVpcClassicLinkResponse EndEnableVpcClassicLink(IAsyncResult asyncResult);

        #endregion
        
        #region  GetConsoleOutput


        /// <summary>
        /// Gets the console output for the specified instance.
        /// 
        ///  
        /// <para>
        /// Instances do not have a physical monitor through which you can view their console
        /// output. They also lack physical controls that allow you to power up, reboot, or shut
        /// them down. To allow these actions, we provide them through the Amazon EC2 API and
        /// command line interface.
        /// </para>
        ///  
        /// <para>
        /// Instance console output is buffered and posted shortly after instance boot, reboot,
        /// and termination. Amazon EC2 preserves the most recent 64 KB output which is available
        /// for at least one hour after the most recent post.
        /// </para>
        ///  
        /// <para>
        /// For Linux instances, the instance console output displays the exact console output
        /// that would normally be displayed on a physical monitor attached to a computer. This
        /// output is buffered because the instance produces it and then posts it to a store where
        /// the instance's owner can retrieve it.
        /// </para>
        ///  
        /// <para>
        /// For Windows instances, the instance console output includes output from the EC2Config
        /// service.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConsoleOutput service method.</param>
        /// 
        /// <returns>The response from the GetConsoleOutput service method, as returned by EC2.</returns>
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
        IAsyncResult BeginGetConsoleOutput(GetConsoleOutputRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetConsoleOutput operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetConsoleOutput.</param>
        /// 
        /// <returns>Returns a  GetConsoleOutputResult from EC2.</returns>
        GetConsoleOutputResponse EndGetConsoleOutput(IAsyncResult asyncResult);

        #endregion
        
        #region  GetPasswordData


        /// <summary>
        /// Retrieves the encrypted administrator password for an instance running Windows.
        /// 
        ///  
        /// <para>
        /// The Windows password is generated at boot if the <code>EC2Config</code> service plugin,
        /// <code>Ec2SetPassword</code>, is enabled. This usually only happens the first time
        /// an AMI is launched, and then <code>Ec2SetPassword</code> is automatically disabled.
        /// The password is not generated for rebundled AMIs unless <code>Ec2SetPassword</code>
        /// is enabled before bundling.
        /// </para>
        ///  
        /// <para>
        /// The password is encrypted using the key pair that you specified when you launched
        /// the instance. You must provide the corresponding key pair file.
        /// </para>
        ///  
        /// <para>
        /// Password generation and encryption takes a few moments. We recommend that you wait
        /// up to 15 minutes after launching an instance before trying to retrieve the generated
        /// password.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetPasswordData service method.</param>
        /// 
        /// <returns>The response from the GetPasswordData service method, as returned by EC2.</returns>
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
        IAsyncResult BeginGetPasswordData(GetPasswordDataRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  GetPasswordData operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPasswordData.</param>
        /// 
        /// <returns>Returns a  GetPasswordDataResult from EC2.</returns>
        GetPasswordDataResponse EndGetPasswordData(IAsyncResult asyncResult);

        #endregion
        
        #region  ImportImage


        /// <summary>
        /// Import single or multi-volume disk images or EBS snapshots into an Amazon Machine
        /// Image (AMI).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportImage service method.</param>
        /// 
        /// <returns>The response from the ImportImage service method, as returned by EC2.</returns>
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
        IAsyncResult BeginImportImage(ImportImageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ImportImage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginImportImage.</param>
        /// 
        /// <returns>Returns a  ImportImageResult from EC2.</returns>
        ImportImageResponse EndImportImage(IAsyncResult asyncResult);

        #endregion
        
        #region  ImportInstance


        /// <summary>
        /// Creates an import instance task using metadata from the specified disk image. <code>ImportInstance</code>
        /// only supports single-volume VMs. To import multi-volume VMs, use <a>ImportImage</a>.
        /// After importing the image, you then upload it using the <code>ec2-import-volume</code>
        /// command in the EC2 command line tools. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/UploadingYourInstancesandVolumes.html">Using
        /// the Command Line Tools to Import Your Virtual Machine to Amazon EC2</a> in the <i>Amazon
        /// Elastic Compute Cloud User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportInstance service method.</param>
        /// 
        /// <returns>The response from the ImportInstance service method, as returned by EC2.</returns>
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
        IAsyncResult BeginImportInstance(ImportInstanceRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ImportInstance operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginImportInstance.</param>
        /// 
        /// <returns>Returns a  ImportInstanceResult from EC2.</returns>
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
        IAsyncResult BeginImportKeyPair(ImportKeyPairRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ImportKeyPair operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginImportKeyPair.</param>
        /// 
        /// <returns>Returns a  ImportKeyPairResult from EC2.</returns>
        ImportKeyPairResponse EndImportKeyPair(IAsyncResult asyncResult);

        #endregion
        
        #region  ImportSnapshot


        /// <summary>
        /// Imports a disk into an EBS snapshot.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportSnapshot service method.</param>
        /// 
        /// <returns>The response from the ImportSnapshot service method, as returned by EC2.</returns>
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
        IAsyncResult BeginImportSnapshot(ImportSnapshotRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ImportSnapshot operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginImportSnapshot.</param>
        /// 
        /// <returns>Returns a  ImportSnapshotResult from EC2.</returns>
        ImportSnapshotResponse EndImportSnapshot(IAsyncResult asyncResult);

        #endregion
        
        #region  ImportVolume


        /// <summary>
        /// Creates an import volume task using metadata from the specified disk image. After
        /// importing the image, you then upload it using the <code>ec2-import-volume</code> command
        /// in the Amazon EC2 command-line interface (CLI) tools. For more information, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/UploadingYourInstancesandVolumes.html">Using
        /// the Command Line Tools to Import Your Virtual Machine to Amazon EC2</a> in the <i>Amazon
        /// Elastic Compute Cloud User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportVolume service method.</param>
        /// 
        /// <returns>The response from the ImportVolume service method, as returned by EC2.</returns>
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
        IAsyncResult BeginImportVolume(ImportVolumeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ImportVolume operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginImportVolume.</param>
        /// 
        /// <returns>Returns a  ImportVolumeResult from EC2.</returns>
        ImportVolumeResponse EndImportVolume(IAsyncResult asyncResult);

        #endregion
        
        #region  ModifyImageAttribute


        /// <summary>
        /// Modifies the specified attribute of the specified AMI. You can specify only one attribute
        /// at a time.
        /// 
        ///  <note>
        /// <para>
        /// AWS Marketplace product codes cannot be modified. Images with an AWS Marketplace product
        /// code cannot be made public.
        /// </para>
        /// </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyImageAttribute service method.</param>
        /// 
        /// <returns>The response from the ModifyImageAttribute service method, as returned by EC2.</returns>
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
        IAsyncResult BeginModifyImageAttribute(ModifyImageAttributeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyImageAttribute operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyImageAttribute.</param>
        /// 
        /// <returns>Returns a  ModifyImageAttributeResult from EC2.</returns>
        ModifyImageAttributeResponse EndModifyImageAttribute(IAsyncResult asyncResult);

        #endregion
        
        #region  ModifyInstanceAttribute


        /// <summary>
        /// Modifies the specified attribute of the specified instance. You can specify only one
        /// attribute at a time.
        /// 
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
        IAsyncResult BeginModifyInstanceAttribute(ModifyInstanceAttributeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyInstanceAttribute operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyInstanceAttribute.</param>
        /// 
        /// <returns>Returns a  ModifyInstanceAttributeResult from EC2.</returns>
        ModifyInstanceAttributeResponse EndModifyInstanceAttribute(IAsyncResult asyncResult);

        #endregion
        
        #region  ModifyNetworkInterfaceAttribute


        /// <summary>
        /// Modifies the specified network interface attribute. You can specify only one attribute
        /// at a time.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyNetworkInterfaceAttribute service method.</param>
        /// 
        /// <returns>The response from the ModifyNetworkInterfaceAttribute service method, as returned by EC2.</returns>
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
        IAsyncResult BeginModifyNetworkInterfaceAttribute(ModifyNetworkInterfaceAttributeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyNetworkInterfaceAttribute operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyNetworkInterfaceAttribute.</param>
        /// 
        /// <returns>Returns a  ModifyNetworkInterfaceAttributeResult from EC2.</returns>
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
        IAsyncResult BeginModifyReservedInstances(ModifyReservedInstancesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyReservedInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyReservedInstances.</param>
        /// 
        /// <returns>Returns a  ModifyReservedInstancesResult from EC2.</returns>
        ModifyReservedInstancesResponse EndModifyReservedInstances(IAsyncResult asyncResult);

        #endregion
        
        #region  ModifySnapshotAttribute


        /// <summary>
        /// Adds or removes permission settings for the specified snapshot. You may add or remove
        /// specified AWS account IDs from a snapshot's list of create volume permissions, but
        /// you cannot do both in a single API call. If you need to both add and remove account
        /// IDs for a snapshot, you must use multiple API calls.
        /// 
        ///  
        /// <para>
        /// For more information on modifying snapshot permissions, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-modifying-snapshot-permissions.html">Sharing
        /// Snapshots</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  <note> 
        /// <para>
        /// Snapshots with AWS Marketplace product codes cannot be made public.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifySnapshotAttribute service method.</param>
        /// 
        /// <returns>The response from the ModifySnapshotAttribute service method, as returned by EC2.</returns>
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
        IAsyncResult BeginModifySnapshotAttribute(ModifySnapshotAttributeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ModifySnapshotAttribute operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifySnapshotAttribute.</param>
        /// 
        /// <returns>Returns a  ModifySnapshotAttributeResult from EC2.</returns>
        ModifySnapshotAttributeResponse EndModifySnapshotAttribute(IAsyncResult asyncResult);

        #endregion
        
        #region  ModifySubnetAttribute


        /// <summary>
        /// Modifies a subnet attribute.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifySubnetAttribute service method.</param>
        /// 
        /// <returns>The response from the ModifySubnetAttribute service method, as returned by EC2.</returns>
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
        IAsyncResult BeginModifySubnetAttribute(ModifySubnetAttributeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ModifySubnetAttribute operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifySubnetAttribute.</param>
        /// 
        /// <returns>Returns a  ModifySubnetAttributeResult from EC2.</returns>
        ModifySubnetAttributeResponse EndModifySubnetAttribute(IAsyncResult asyncResult);

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
        IAsyncResult BeginModifyVolumeAttribute(ModifyVolumeAttributeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyVolumeAttribute operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyVolumeAttribute.</param>
        /// 
        /// <returns>Returns a  ModifyVolumeAttributeResult from EC2.</returns>
        ModifyVolumeAttributeResponse EndModifyVolumeAttribute(IAsyncResult asyncResult);

        #endregion
        
        #region  ModifyVpcAttribute


        /// <summary>
        /// Modifies the specified attribute of the specified VPC.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyVpcAttribute service method.</param>
        /// 
        /// <returns>The response from the ModifyVpcAttribute service method, as returned by EC2.</returns>
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
        IAsyncResult BeginModifyVpcAttribute(ModifyVpcAttributeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyVpcAttribute operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyVpcAttribute.</param>
        /// 
        /// <returns>Returns a  ModifyVpcAttributeResult from EC2.</returns>
        ModifyVpcAttributeResponse EndModifyVpcAttribute(IAsyncResult asyncResult);

        #endregion
        
        #region  ModifyVpcEndpoint


        /// <summary>
        /// Modifies attributes of a specified VPC endpoint. You can modify the policy associated
        /// with the endpoint, and you can add and remove route tables associated with the endpoint.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyVpcEndpoint service method.</param>
        /// 
        /// <returns>The response from the ModifyVpcEndpoint service method, as returned by EC2.</returns>
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
        IAsyncResult BeginModifyVpcEndpoint(ModifyVpcEndpointRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ModifyVpcEndpoint operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyVpcEndpoint.</param>
        /// 
        /// <returns>Returns a  ModifyVpcEndpointResult from EC2.</returns>
        ModifyVpcEndpointResponse EndModifyVpcEndpoint(IAsyncResult asyncResult);

        #endregion
        
        #region  MonitorInstances


        /// <summary>
        /// Enables monitoring for a running instance. For more information about monitoring instances,
        /// see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-cloudwatch.html">Monitoring
        /// Your Instances and Volumes</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the MonitorInstances service method.</param>
        /// 
        /// <returns>The response from the MonitorInstances service method, as returned by EC2.</returns>
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
        IAsyncResult BeginMonitorInstances(MonitorInstancesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  MonitorInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginMonitorInstances.</param>
        /// 
        /// <returns>Returns a  MonitorInstancesResult from EC2.</returns>
        MonitorInstancesResponse EndMonitorInstances(IAsyncResult asyncResult);

        #endregion
        
        #region  MoveAddressToVpc


        /// <summary>
        /// Moves an Elastic IP address from the EC2-Classic platform to the EC2-VPC platform.
        /// The Elastic IP address must be allocated to your account, and it must not be associated
        /// with an instance. After the Elastic IP address is moved, it is no longer available
        /// for use in the EC2-Classic platform, unless you move it back using the <a>RestoreAddressToClassic</a>
        /// request. You cannot move an Elastic IP address that's allocated for use in the EC2-VPC
        /// platform to the EC2-Classic platform.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the MoveAddressToVpc service method.</param>
        /// 
        /// <returns>The response from the MoveAddressToVpc service method, as returned by EC2.</returns>
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
        IAsyncResult BeginMoveAddressToVpc(MoveAddressToVpcRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  MoveAddressToVpc operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginMoveAddressToVpc.</param>
        /// 
        /// <returns>Returns a  MoveAddressToVpcResult from EC2.</returns>
        MoveAddressToVpcResponse EndMoveAddressToVpc(IAsyncResult asyncResult);

        #endregion
        
        #region  PurchaseReservedInstancesOffering


        /// <summary>
        /// Purchases a Reserved Instance for use with your account. With Amazon EC2 Reserved
        /// Instances, you obtain a capacity reservation for a certain instance configuration
        /// over a specified period of time and pay a lower hourly rate compared to on-Demand
        /// Instance pricing.
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
        IAsyncResult BeginPurchaseReservedInstancesOffering(PurchaseReservedInstancesOfferingRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  PurchaseReservedInstancesOffering operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPurchaseReservedInstancesOffering.</param>
        /// 
        /// <returns>Returns a  PurchaseReservedInstancesOfferingResult from EC2.</returns>
        PurchaseReservedInstancesOfferingResponse EndPurchaseReservedInstancesOffering(IAsyncResult asyncResult);

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
        /// If a Linux/Unix instance does not cleanly shut down within four minutes, Amazon EC2
        /// performs a hard reboot.
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
        IAsyncResult BeginRebootInstances(RebootInstancesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RebootInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRebootInstances.</param>
        /// 
        /// <returns>Returns a  RebootInstancesResult from EC2.</returns>
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
        /// </note> 
        /// <para>
        /// You can also use <code>RegisterImage</code> to create an Amazon EBS-backed AMI from
        /// a snapshot of a root device volume. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_LaunchingInstanceFromSnapshot.html">Launching
        /// an Instance from a Snapshot</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If needed, you can deregister an AMI at any time. Any modifications you make to an
        /// AMI backed by an instance store volume invalidates its registration. If you make changes
        /// to an image, deregister the previous image and register the new image.
        /// </para>
        ///  <note>
        /// <para>
        /// You can't register an image where a secondary (non-root) snapshot has AWS Marketplace
        /// product codes.
        /// </para>
        /// </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterImage service method.</param>
        /// 
        /// <returns>The response from the RegisterImage service method, as returned by EC2.</returns>
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
        IAsyncResult BeginRegisterImage(RegisterImageRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterImage operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterImage.</param>
        /// 
        /// <returns>Returns a  RegisterImageResult from EC2.</returns>
        RegisterImageResponse EndRegisterImage(IAsyncResult asyncResult);

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
        IAsyncResult BeginRejectVpcPeeringConnection(RejectVpcPeeringConnectionRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RejectVpcPeeringConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRejectVpcPeeringConnection.</param>
        /// 
        /// <returns>Returns a  RejectVpcPeeringConnectionResult from EC2.</returns>
        RejectVpcPeeringConnectionResponse EndRejectVpcPeeringConnection(IAsyncResult asyncResult);

        #endregion
        
        #region  ReleaseAddress


        /// <summary>
        /// Releases the specified Elastic IP address.
        /// 
        ///  
        /// <para>
        /// After releasing an Elastic IP address, it is released to the IP address pool and might
        /// be unavailable to you. Be sure to update your DNS records and any servers or devices
        /// that communicate with the address. If you attempt to release an Elastic IP address
        /// that you already released, you'll get an <code>AuthFailure</code> error if the address
        /// is already allocated to another AWS account.
        /// </para>
        ///  
        /// <para>
        /// [EC2-Classic, default VPC] Releasing an Elastic IP address automatically disassociates
        /// it from any instance that it's associated with. To disassociate an Elastic IP address
        /// without releasing it, use <a>DisassociateAddress</a>.
        /// </para>
        ///  
        /// <para>
        /// [Nondefault VPC] You must use <a>DisassociateAddress</a> to disassociate the Elastic
        /// IP address before you try to release it. Otherwise, Amazon EC2 returns an error (<code>InvalidIPAddress.InUse</code>).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReleaseAddress service method.</param>
        /// 
        /// <returns>The response from the ReleaseAddress service method, as returned by EC2.</returns>
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
        IAsyncResult BeginReleaseAddress(ReleaseAddressRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ReleaseAddress operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginReleaseAddress.</param>
        /// 
        /// <returns>Returns a  ReleaseAddressResult from EC2.</returns>
        ReleaseAddressResponse EndReleaseAddress(IAsyncResult asyncResult);

        #endregion
        
        #region  ReplaceNetworkAclAssociation


        /// <summary>
        /// Changes which network ACL a subnet is associated with. By default when you create
        /// a subnet, it's automatically associated with the default network ACL. For more information
        /// about network ACLs, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_ACLs.html">Network
        /// ACLs</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReplaceNetworkAclAssociation service method.</param>
        /// 
        /// <returns>The response from the ReplaceNetworkAclAssociation service method, as returned by EC2.</returns>
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
        IAsyncResult BeginReplaceNetworkAclAssociation(ReplaceNetworkAclAssociationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ReplaceNetworkAclAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginReplaceNetworkAclAssociation.</param>
        /// 
        /// <returns>Returns a  ReplaceNetworkAclAssociationResult from EC2.</returns>
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
        IAsyncResult BeginReplaceNetworkAclEntry(ReplaceNetworkAclEntryRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ReplaceNetworkAclEntry operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginReplaceNetworkAclEntry.</param>
        /// 
        /// <returns>Returns a  ReplaceNetworkAclEntryResult from EC2.</returns>
        ReplaceNetworkAclEntryResponse EndReplaceNetworkAclEntry(IAsyncResult asyncResult);

        #endregion
        
        #region  ReplaceRoute


        /// <summary>
        /// Replaces an existing route within a route table in a VPC. You must provide only one
        /// of the following: Internet gateway or virtual private gateway, NAT instance, VPC peering
        /// connection, or network interface.
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
        IAsyncResult BeginReplaceRoute(ReplaceRouteRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ReplaceRoute operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginReplaceRoute.</param>
        /// 
        /// <returns>Returns a  ReplaceRouteResult from EC2.</returns>
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
        IAsyncResult BeginReplaceRouteTableAssociation(ReplaceRouteTableAssociationRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ReplaceRouteTableAssociation operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginReplaceRouteTableAssociation.</param>
        /// 
        /// <returns>Returns a  ReplaceRouteTableAssociationResult from EC2.</returns>
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
        IAsyncResult BeginReportInstanceStatus(ReportInstanceStatusRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ReportInstanceStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginReportInstanceStatus.</param>
        /// 
        /// <returns>Returns a  ReportInstanceStatusResult from EC2.</returns>
        ReportInstanceStatusResponse EndReportInstanceStatus(IAsyncResult asyncResult);

        #endregion
        
        #region  RequestSpotFleet


        /// <summary>
        /// Creates a Spot fleet request.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/spot-fleet.html">Spot
        /// Fleets</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RequestSpotFleet service method.</param>
        /// 
        /// <returns>The response from the RequestSpotFleet service method, as returned by EC2.</returns>
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
        IAsyncResult BeginRequestSpotFleet(RequestSpotFleetRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RequestSpotFleet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRequestSpotFleet.</param>
        /// 
        /// <returns>Returns a  RequestSpotFleetResult from EC2.</returns>
        RequestSpotFleetResponse EndRequestSpotFleet(IAsyncResult asyncResult);

        #endregion
        
        #region  RequestSpotInstances


        /// <summary>
        /// Creates a Spot Instance request. Spot Instances are instances that Amazon EC2 launches
        /// when the bid price that you specify exceeds the current Spot Price. Amazon EC2 periodically
        /// sets the Spot Price based on available Spot Instance capacity and current Spot Instance
        /// requests. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/spot-requests.html">Spot
        /// Instance Requests</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RequestSpotInstances service method.</param>
        /// 
        /// <returns>The response from the RequestSpotInstances service method, as returned by EC2.</returns>
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
        IAsyncResult BeginRequestSpotInstances(RequestSpotInstancesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RequestSpotInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRequestSpotInstances.</param>
        /// 
        /// <returns>Returns a  RequestSpotInstancesResult from EC2.</returns>
        RequestSpotInstancesResponse EndRequestSpotInstances(IAsyncResult asyncResult);

        #endregion
        
        #region  ResetImageAttribute


        /// <summary>
        /// Resets an attribute of an AMI to its default value.
        /// 
        ///  <note>
        /// <para>
        ///  The productCodes attribute can't be reset. 
        /// </para>
        /// </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetImageAttribute service method.</param>
        /// 
        /// <returns>The response from the ResetImageAttribute service method, as returned by EC2.</returns>
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
        IAsyncResult BeginResetImageAttribute(ResetImageAttributeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ResetImageAttribute operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResetImageAttribute.</param>
        /// 
        /// <returns>Returns a  ResetImageAttributeResult from EC2.</returns>
        ResetImageAttributeResponse EndResetImageAttribute(IAsyncResult asyncResult);

        #endregion
        
        #region  ResetInstanceAttribute


        /// <summary>
        /// Resets an attribute of an instance to its default value. To reset the <code>kernel</code>
        /// or <code>ramdisk</code>, the instance must be in a stopped state. To reset the <code>SourceDestCheck</code>,
        /// the instance can be either running or stopped.
        /// 
        ///  
        /// <para>
        /// The <code>SourceDestCheck</code> attribute controls whether source/destination checking
        /// is enabled. The default value is <code>true</code>, which means checking is enabled.
        /// This value must be <code>false</code> for a NAT instance to perform NAT. For more
        /// information, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_NAT_Instance.html">NAT
        /// Instances</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetInstanceAttribute service method.</param>
        /// 
        /// <returns>The response from the ResetInstanceAttribute service method, as returned by EC2.</returns>
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
        IAsyncResult BeginResetInstanceAttribute(ResetInstanceAttributeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ResetInstanceAttribute operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResetInstanceAttribute.</param>
        /// 
        /// <returns>Returns a  ResetInstanceAttributeResult from EC2.</returns>
        ResetInstanceAttributeResponse EndResetInstanceAttribute(IAsyncResult asyncResult);

        #endregion
        
        #region  ResetNetworkInterfaceAttribute


        /// <summary>
        /// Resets a network interface attribute. You can specify only one attribute at a time.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetNetworkInterfaceAttribute service method.</param>
        /// 
        /// <returns>The response from the ResetNetworkInterfaceAttribute service method, as returned by EC2.</returns>
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
        IAsyncResult BeginResetNetworkInterfaceAttribute(ResetNetworkInterfaceAttributeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ResetNetworkInterfaceAttribute operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResetNetworkInterfaceAttribute.</param>
        /// 
        /// <returns>Returns a  ResetNetworkInterfaceAttributeResult from EC2.</returns>
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
        IAsyncResult BeginResetSnapshotAttribute(ResetSnapshotAttributeRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  ResetSnapshotAttribute operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResetSnapshotAttribute.</param>
        /// 
        /// <returns>Returns a  ResetSnapshotAttributeResult from EC2.</returns>
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
        IAsyncResult BeginRestoreAddressToClassic(RestoreAddressToClassicRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RestoreAddressToClassic operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRestoreAddressToClassic.</param>
        /// 
        /// <returns>Returns a  RestoreAddressToClassicResult from EC2.</returns>
        RestoreAddressToClassicResponse EndRestoreAddressToClassic(IAsyncResult asyncResult);

        #endregion
        
        #region  RevokeSecurityGroupEgress


        /// <summary>
        /// Removes one or more egress rules from a security group for EC2-VPC. The values that
        /// you specify in the revoke request (for example, ports) must match the existing rule's
        /// values for the rule to be revoked.
        /// 
        ///  
        /// <para>
        /// Each rule consists of the protocol and the CIDR range or source security group. For
        /// the TCP and UDP protocols, you must also specify the destination port or range of
        /// ports. For the ICMP protocol, you must also specify the ICMP type and code.
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
        IAsyncResult BeginRevokeSecurityGroupEgress(RevokeSecurityGroupEgressRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RevokeSecurityGroupEgress operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRevokeSecurityGroupEgress.</param>
        /// 
        /// <returns>Returns a  RevokeSecurityGroupEgressResult from EC2.</returns>
        RevokeSecurityGroupEgressResponse EndRevokeSecurityGroupEgress(IAsyncResult asyncResult);

        #endregion
        
        #region  RevokeSecurityGroupIngress


        /// <summary>
        /// Removes one or more ingress rules from a security group. The values that you specify
        /// in the revoke request (for example, ports) must match the existing rule's values for
        /// the rule to be removed.
        /// 
        ///  
        /// <para>
        /// Each rule consists of the protocol and the CIDR range or source security group. For
        /// the TCP and UDP protocols, you must also specify the destination port or range of
        /// ports. For the ICMP protocol, you must also specify the ICMP type and code.
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
        IAsyncResult BeginRevokeSecurityGroupIngress(RevokeSecurityGroupIngressRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RevokeSecurityGroupIngress operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRevokeSecurityGroupIngress.</param>
        /// 
        /// <returns>Returns a  RevokeSecurityGroupIngressResult from EC2.</returns>
        RevokeSecurityGroupIngressResponse EndRevokeSecurityGroupIngress(IAsyncResult asyncResult);

        #endregion
        
        #region  RunInstances


        /// <summary>
        /// Launches the specified number of instances using an AMI for which you have permissions.
        /// 
        ///  
        /// <para>
        /// When you launch an instance, it enters the <code>pending</code> state. After the instance
        /// is ready for you, it enters the <code>running</code> state. To check the state of
        /// your instance, call <a>DescribeInstances</a>.
        /// </para>
        ///  
        /// <para>
        /// If you don't specify a security group when launching an instance, Amazon EC2 uses
        /// the default security group. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-network-security.html">Security
        /// Groups</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
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
        /// You can provide optional user data when launching an instance. For more information,
        /// see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/AESDG-chapter-instancedata.html">Instance
        /// Metadata</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If any of the AMIs have a product code attached for which the user has not subscribed,
        /// <code>RunInstances</code> fails.
        /// </para>
        ///  
        /// <para>
        /// T2 instance types can only be launched into a VPC. If you do not have a default VPC,
        /// or if you do not specify a subnet ID in the request, <code>RunInstances</code> fails.
        /// </para>
        ///  
        /// <para>
        /// For more information about troubleshooting, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_InstanceStraightToTerminated.html">What
        /// To Do If An Instance Immediately Terminates</a>, and <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/TroubleshootingInstancesConnecting.html">Troubleshooting
        /// Connecting to Your Instance</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RunInstances service method.</param>
        /// 
        /// <returns>The response from the RunInstances service method, as returned by EC2.</returns>
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
        IAsyncResult BeginRunInstances(RunInstancesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  RunInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRunInstances.</param>
        /// 
        /// <returns>Returns a  RunInstancesResult from EC2.</returns>
        RunInstancesResponse EndRunInstances(IAsyncResult asyncResult);

        #endregion
        
        #region  StartInstances


        /// <summary>
        /// Starts an Amazon EBS-backed AMI that you've previously stopped.
        /// 
        ///  
        /// <para>
        /// Instances that use Amazon EBS volumes as their root devices can be quickly stopped
        /// and started. When an instance is stopped, the compute resources are released and you
        /// are not billed for hourly instance usage. However, your root partition Amazon EBS
        /// volume remains, continues to persist your data, and you are charged for Amazon EBS
        /// volume usage. You can restart your instance at any time. Each time you transition
        /// an instance from stopped to started, Amazon EC2 charges a full instance hour, even
        /// if transitions happen multiple times within a single hour.
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
        IAsyncResult BeginStartInstances(StartInstancesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StartInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartInstances.</param>
        /// 
        /// <returns>Returns a  StartInstancesResult from EC2.</returns>
        StartInstancesResponse EndStartInstances(IAsyncResult asyncResult);

        #endregion
        
        #region  StopInstances


        /// <summary>
        /// Stops an Amazon EBS-backed instance. Each time you transition an instance from stopped
        /// to started, Amazon EC2 charges a full instance hour, even if transitions happen multiple
        /// times within a single hour.
        /// 
        ///  
        /// <para>
        /// You can't start or stop Spot Instances.
        /// </para>
        ///  
        /// <para>
        /// Instances that use Amazon EBS volumes as their root devices can be quickly stopped
        /// and started. When an instance is stopped, the compute resources are released and you
        /// are not billed for hourly instance usage. However, your root partition Amazon EBS
        /// volume remains, continues to persist your data, and you are charged for Amazon EBS
        /// volume usage. You can restart your instance at any time.
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
        /// You can stop, start, and terminate EBS-backed instances. You can only terminate instance
        /// store-backed instances. What happens to an instance differs if you stop it or terminate
        /// it. For example, when you stop an instance, the root device and any other devices
        /// attached to the instance persist. When you terminate an instance, the root device
        /// and any other devices attached during the instance launch are automatically deleted.
        /// For more information about the differences between stopping and terminating instances,
        /// see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-instance-lifecycle.html">Instance
        /// Lifecycle</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For more information about troubleshooting, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/TroubleshootingInstancesStopping.html">Troubleshooting
        /// Stopping Your Instance</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopInstances service method.</param>
        /// 
        /// <returns>The response from the StopInstances service method, as returned by EC2.</returns>
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
        IAsyncResult BeginStopInstances(StopInstancesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  StopInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopInstances.</param>
        /// 
        /// <returns>Returns a  StopInstancesResult from EC2.</returns>
        StopInstancesResponse EndStopInstances(IAsyncResult asyncResult);

        #endregion
        
        #region  TerminateInstances


        /// <summary>
        /// Shuts down one or more instances. This operation is idempotent; if you terminate an
        /// instance more than once, each call succeeds.
        /// 
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
        /// attached to the instance persist. When you terminate an instance, the root device
        /// and any other devices attached during the instance launch are automatically deleted.
        /// For more information about the differences between stopping and terminating instances,
        /// see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-instance-lifecycle.html">Instance
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
        IAsyncResult BeginTerminateInstances(TerminateInstancesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  TerminateInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTerminateInstances.</param>
        /// 
        /// <returns>Returns a  TerminateInstancesResult from EC2.</returns>
        TerminateInstancesResponse EndTerminateInstances(IAsyncResult asyncResult);

        #endregion
        
        #region  UnassignPrivateIpAddresses


        /// <summary>
        /// Unassigns one or more secondary private IP addresses from a network interface.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UnassignPrivateIpAddresses service method.</param>
        /// 
        /// <returns>The response from the UnassignPrivateIpAddresses service method, as returned by EC2.</returns>
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
        IAsyncResult BeginUnassignPrivateIpAddresses(UnassignPrivateIpAddressesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UnassignPrivateIpAddresses operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUnassignPrivateIpAddresses.</param>
        /// 
        /// <returns>Returns a  UnassignPrivateIpAddressesResult from EC2.</returns>
        UnassignPrivateIpAddressesResponse EndUnassignPrivateIpAddresses(IAsyncResult asyncResult);

        #endregion
        
        #region  UnmonitorInstances


        /// <summary>
        /// Disables monitoring for a running instance. For more information about monitoring
        /// instances, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-cloudwatch.html">Monitoring
        /// Your Instances and Volumes</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UnmonitorInstances service method.</param>
        /// 
        /// <returns>The response from the UnmonitorInstances service method, as returned by EC2.</returns>
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
        IAsyncResult BeginUnmonitorInstances(UnmonitorInstancesRequest request, AsyncCallback callback, object state);



        /// <summary>
        /// Finishes the asynchronous execution of the  UnmonitorInstances operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUnmonitorInstances.</param>
        /// 
        /// <returns>Returns a  UnmonitorInstancesResult from EC2.</returns>
        UnmonitorInstancesResponse EndUnmonitorInstances(IAsyncResult asyncResult);

        #endregion
        
    }
}