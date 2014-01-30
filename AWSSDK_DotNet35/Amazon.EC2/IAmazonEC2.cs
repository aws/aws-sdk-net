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

using Amazon.EC2;
using Amazon.EC2.Model;

namespace Amazon.EC2
{
    /// <summary>
    /// Interface for accessing AmazonEC2.
    ///  
    ///  Amazon Elastic Compute Cloud <para>Amazon Elastic Compute Cloud (Amazon EC2) provides resizable computing capacity in the Amazon Web
    /// Services (AWS) cloud. Using Amazon EC2 eliminates your need to invest in hardware up front, so you can develop and deploy applications
    /// faster.</para>
    /// </summary>
    public partial interface IAmazonEC2 : IDisposable
    {


        #region AllocateAddress

        /// <summary>
        /// <para>Acquires an Elastic IP address.</para> <para>An Elastic IP address is for use either in the EC2-Classic platform or in a VPC. For more
        /// information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/elastic-ip-addresses-eip.html" >Elastic IP Addresses</a> in the
        /// <i>Amazon Elastic Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="allocateAddressRequest">Container for the necessary parameters to execute the AllocateAddress service method on
        ///          AmazonEC2.</param>
        /// 
        /// <returns>The response from the AllocateAddress service method, as returned by AmazonEC2.</returns>
        /// 
        AllocateAddressResponse AllocateAddress(AllocateAddressRequest allocateAddressRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the AllocateAddress operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.AllocateAddress"/>
        /// </summary>
        /// 
        /// <param name="allocateAddressRequest">Container for the necessary parameters to execute the AllocateAddress operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAllocateAddress
        ///         operation.</returns>
        IAsyncResult BeginAllocateAddress(AllocateAddressRequest allocateAddressRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the AllocateAddress operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.AllocateAddress"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAllocateAddress.</param>
        /// 
        /// <returns>Returns a AllocateAddressResult from AmazonEC2.</returns>
        AllocateAddressResponse EndAllocateAddress(IAsyncResult asyncResult);

        /// <summary>
        /// <para>Acquires an Elastic IP address.</para> <para>An Elastic IP address is for use either in the EC2-Classic platform or in a VPC. For more
        /// information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/elastic-ip-addresses-eip.html" >Elastic IP Addresses</a> in the
        /// <i>Amazon Elastic Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <returns>The response from the AllocateAddress service method, as returned by AmazonEC2.</returns>
        /// 
        AllocateAddressResponse AllocateAddress();
        
        #endregion
        
    

        #region AssignPrivateIpAddresses

        /// <summary>
        /// <para>Assigns one or more secondary private IP addresses to the specified network interface. You can specify one or more specific secondary
        /// IP addresses, or you can specify the number of secondary IP addresses to be automatically assigned within the subnet's CIDR block range. The
        /// number of secondary IP addresses that you can assign to an instance varies by instance type. For information about instance types, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-types.html" >Instance Types</a> in the <i>Amazon Elastic Compute Cloud
        /// User Guide</i> . For more information about Elastic IP addresses, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/elastic-ip-addresses-eip.html" >Elastic IP Addresses</a> in the <i>Amazon Elastic
        /// Compute Cloud User Guide</i> .</para> <para>AssignPrivateIpAddresses is available only in EC2-VPC.</para>
        /// </summary>
        /// 
        /// <param name="assignPrivateIpAddressesRequest">Container for the necessary parameters to execute the AssignPrivateIpAddresses service method
        ///          on AmazonEC2.</param>
        /// 
        AssignPrivateIpAddressesResponse AssignPrivateIpAddresses(AssignPrivateIpAddressesRequest assignPrivateIpAddressesRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the AssignPrivateIpAddresses operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.AssignPrivateIpAddresses"/>
        /// </summary>
        /// 
        /// <param name="assignPrivateIpAddressesRequest">Container for the necessary parameters to execute the AssignPrivateIpAddresses operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginAssignPrivateIpAddresses(AssignPrivateIpAddressesRequest assignPrivateIpAddressesRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the AssignPrivateIpAddresses operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.AssignPrivateIpAddresses"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssignPrivateIpAddresses.</param>
        AssignPrivateIpAddressesResponse EndAssignPrivateIpAddresses(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region AssociateAddress

        /// <summary>
        /// <para>Associates an Elastic IP address with an instance or a network interface.</para> <para>An Elastic IP address is for use in either the
        /// EC2-Classic platform or in a VPC. For more information, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/elastic-ip-addresses-eip.html" >Elastic IP Addresses</a> in the <i>Amazon Elastic
        /// Compute Cloud User Guide</i> .</para> <para>[EC2-Classic, default VPC] If the Elastic IP address is already associated with a different
        /// instance, it is disassociated from that instance and associated with the specified instance.</para> <para>[EC2-VPC] If you don't specify a
        /// private IP address, the Elastic IP address is associated with the primary IP address. If the Elastic IP address is already associated with a
        /// different instance or a network interface, you get an error unless you allow reassociation.</para> <para>This is an idempotent operation. If
        /// you perform the operation more than once, Amazon EC2 doesn't return an error.</para>
        /// </summary>
        /// 
        /// <param name="associateAddressRequest">Container for the necessary parameters to execute the AssociateAddress service method on
        ///          AmazonEC2.</param>
        /// 
        /// <returns>The response from the AssociateAddress service method, as returned by AmazonEC2.</returns>
        /// 
        AssociateAddressResponse AssociateAddress(AssociateAddressRequest associateAddressRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateAddress operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.AssociateAddress"/>
        /// </summary>
        /// 
        /// <param name="associateAddressRequest">Container for the necessary parameters to execute the AssociateAddress operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateAddress
        ///         operation.</returns>
        IAsyncResult BeginAssociateAddress(AssociateAddressRequest associateAddressRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the AssociateAddress operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.AssociateAddress"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateAddress.</param>
        /// 
        /// <returns>Returns a AssociateAddressResult from AmazonEC2.</returns>
        AssociateAddressResponse EndAssociateAddress(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region AssociateDhcpOptions

        /// <summary>
        /// <para>Associates a set of DHCP options (that you've previously created) with the specified VPC, or associates no DHCP options with the
        /// VPC.</para> <para>After you associate the options with the VPC, any existing instances and all new instances that you launch in that VPC use
        /// the options. You don't need to restart or relaunch the instances. They automatically pick up the changes within a few hours, depending on
        /// how frequently the instance renews its DHCP lease. You can explicitly renew the lease using the operating system on the instance.</para>
        /// <para>For more information, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_DHCP_Options.html" >DHCP Options Sets</a>
        /// in the <i>Amazon Virtual Private Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="associateDhcpOptionsRequest">Container for the necessary parameters to execute the AssociateDhcpOptions service method on
        ///          AmazonEC2.</param>
        /// 
        AssociateDhcpOptionsResponse AssociateDhcpOptions(AssociateDhcpOptionsRequest associateDhcpOptionsRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateDhcpOptions operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.AssociateDhcpOptions"/>
        /// </summary>
        /// 
        /// <param name="associateDhcpOptionsRequest">Container for the necessary parameters to execute the AssociateDhcpOptions operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginAssociateDhcpOptions(AssociateDhcpOptionsRequest associateDhcpOptionsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the AssociateDhcpOptions operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.AssociateDhcpOptions"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateDhcpOptions.</param>
        AssociateDhcpOptionsResponse EndAssociateDhcpOptions(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region AssociateRouteTable

        /// <summary>
        /// <para>Associates a subnet with a route table. The subnet and route table must be in the same VPC. This association causes traffic
        /// originating from the subnet to be routed according to the routes in the route table. The action returns an association ID, which you need in
        /// order to disassociate the route table from the subnet later. A route table can be associated with multiple subnets.</para> <para>For more
        /// information about route tables, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Route_Tables.html" >Route Tables</a>
        /// in the <i>Amazon Virtual Private Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="associateRouteTableRequest">Container for the necessary parameters to execute the AssociateRouteTable service method on
        ///          AmazonEC2.</param>
        /// 
        /// <returns>The response from the AssociateRouteTable service method, as returned by AmazonEC2.</returns>
        /// 
        AssociateRouteTableResponse AssociateRouteTable(AssociateRouteTableRequest associateRouteTableRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateRouteTable operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.AssociateRouteTable"/>
        /// </summary>
        /// 
        /// <param name="associateRouteTableRequest">Container for the necessary parameters to execute the AssociateRouteTable operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndAssociateRouteTable operation.</returns>
        IAsyncResult BeginAssociateRouteTable(AssociateRouteTableRequest associateRouteTableRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the AssociateRouteTable operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.AssociateRouteTable"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateRouteTable.</param>
        /// 
        /// <returns>Returns a AssociateRouteTableResult from AmazonEC2.</returns>
        AssociateRouteTableResponse EndAssociateRouteTable(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region AttachInternetGateway

        /// <summary>
        /// <para>Attaches an Internet gateway to a VPC, enabling connectivity between the Internet and the VPC. For more information about your VPC and
        /// Internet gateway, see the <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/" >Amazon Virtual Private Cloud User Guide</a>
        /// .</para>
        /// </summary>
        /// 
        /// <param name="attachInternetGatewayRequest">Container for the necessary parameters to execute the AttachInternetGateway service method on
        ///          AmazonEC2.</param>
        /// 
        AttachInternetGatewayResponse AttachInternetGateway(AttachInternetGatewayRequest attachInternetGatewayRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the AttachInternetGateway operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.AttachInternetGateway"/>
        /// </summary>
        /// 
        /// <param name="attachInternetGatewayRequest">Container for the necessary parameters to execute the AttachInternetGateway operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginAttachInternetGateway(AttachInternetGatewayRequest attachInternetGatewayRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the AttachInternetGateway operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.AttachInternetGateway"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAttachInternetGateway.</param>
        AttachInternetGatewayResponse EndAttachInternetGateway(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region AttachNetworkInterface

        /// <summary>
        /// <para>Attaches a network interface to an instance.</para>
        /// </summary>
        /// 
        /// <param name="attachNetworkInterfaceRequest">Container for the necessary parameters to execute the AttachNetworkInterface service method on
        ///          AmazonEC2.</param>
        /// 
        /// <returns>The response from the AttachNetworkInterface service method, as returned by AmazonEC2.</returns>
        /// 
        AttachNetworkInterfaceResponse AttachNetworkInterface(AttachNetworkInterfaceRequest attachNetworkInterfaceRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the AttachNetworkInterface operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.AttachNetworkInterface"/>
        /// </summary>
        /// 
        /// <param name="attachNetworkInterfaceRequest">Container for the necessary parameters to execute the AttachNetworkInterface operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndAttachNetworkInterface operation.</returns>
        IAsyncResult BeginAttachNetworkInterface(AttachNetworkInterfaceRequest attachNetworkInterfaceRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the AttachNetworkInterface operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.AttachNetworkInterface"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAttachNetworkInterface.</param>
        /// 
        /// <returns>Returns a AttachNetworkInterfaceResult from AmazonEC2.</returns>
        AttachNetworkInterfaceResponse EndAttachNetworkInterface(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region AttachVolume

        /// <summary>
        /// <para>Attaches an Amazon EBS volume to a running or stopped instance and exposes it to the instance with the specified device name.</para>
        /// <para>For a list of supported device names, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-attaching-volume.html"
        /// >Attaching an Amazon EBS Volume to an Instance</a> . Any device names that aren't reserved for instance store volumes can be used for Amazon
        /// EBS volumes. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/InstanceStorage.html" >Amazon EC2
        /// Instance Store</a> in the <i>Amazon Elastic Compute Cloud User Guide</i> .</para> <para>If a volume has an AWS Marketplace product
        /// code:</para>
        /// <ul>
        /// <li>The volume can only be attached as the root device of a stopped instance.</li>
        /// <li>You must be subscribed to the AWS Marketplace code that is on the volume.</li>
        /// <li>The configuration (instance type, operating system) of the instance must support that specific AWS Marketplace code. For example, you
        /// cannot take a volume from a Windows instance and attach it to a Linux instance.</li>
        /// <li>AWS Marketplace product codes are copied from the volume to the instance.</li>
        /// 
        /// </ul>
        /// <para>For an overview of the AWS Marketplace, see <a href="https://aws.amazon.com/marketplace/help/200900000"
        /// >https://aws.amazon.com/marketplace/help/200900000</a> . For more information about how to use the AWS Marketplace, see <a
        /// href="https://aws.amazon.com/marketplace" >AWS Marketplace</a> .</para> <para>For more information about Amazon EBS volumes, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-attaching-volume.html" >Attaching Amazon EBS Volumes</a> in the <i>Amazon
        /// Elastic Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="attachVolumeRequest">Container for the necessary parameters to execute the AttachVolume service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the AttachVolume service method, as returned by AmazonEC2.</returns>
        /// 
        AttachVolumeResponse AttachVolume(AttachVolumeRequest attachVolumeRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the AttachVolume operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.AttachVolume"/>
        /// </summary>
        /// 
        /// <param name="attachVolumeRequest">Container for the necessary parameters to execute the AttachVolume operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAttachVolume
        ///         operation.</returns>
        IAsyncResult BeginAttachVolume(AttachVolumeRequest attachVolumeRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the AttachVolume operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.AttachVolume"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAttachVolume.</param>
        /// 
        /// <returns>Returns a AttachVolumeResult from AmazonEC2.</returns>
        AttachVolumeResponse EndAttachVolume(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region AttachVpnGateway

        /// <summary>
        /// <para>Attaches a virtual private gateway to a VPC. For more information, see <a
        /// href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_VPN.html" >Adding a Hardware Virtual Private Gateway to Your VPC</a> in the
        /// <i>Amazon Virtual Private Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="attachVpnGatewayRequest">Container for the necessary parameters to execute the AttachVpnGateway service method on
        ///          AmazonEC2.</param>
        /// 
        /// <returns>The response from the AttachVpnGateway service method, as returned by AmazonEC2.</returns>
        /// 
        AttachVpnGatewayResponse AttachVpnGateway(AttachVpnGatewayRequest attachVpnGatewayRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the AttachVpnGateway operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.AttachVpnGateway"/>
        /// </summary>
        /// 
        /// <param name="attachVpnGatewayRequest">Container for the necessary parameters to execute the AttachVpnGateway operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAttachVpnGateway
        ///         operation.</returns>
        IAsyncResult BeginAttachVpnGateway(AttachVpnGatewayRequest attachVpnGatewayRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the AttachVpnGateway operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.AttachVpnGateway"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAttachVpnGateway.</param>
        /// 
        /// <returns>Returns a AttachVpnGatewayResult from AmazonEC2.</returns>
        AttachVpnGatewayResponse EndAttachVpnGateway(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region AuthorizeSecurityGroupEgress

        /// <summary>
        /// <para>Adds one or more egress rules to a security group for use with a VPC. Specifically, this action permits instances to send traffic to
        /// one or more CIDR IP address ranges, or to one or more security groups for the same VPC.</para> <para><b>IMPORTANT:</b> You can have up to 50
        /// rules per security group (covering both ingress and egress rules). </para> <para>A security group is for use with instances either in the
        /// EC2-Classic platform or in a specific VPC. This action doesn't apply to security groups for use in EC2-Classic. For more information, see <a
        /// href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_SecurityGroups.html" >Security Groups for Your VPC</a> in the <i>Amazon
        /// Virtual Private Cloud User Guide</i> .</para> <para>Each rule consists of the protocol (for example, TCP), plus either a CIDR range or a
        /// source group. For the TCP and UDP protocols, you must also specify the destination port or port range. For the ICMP protocol, you must also
        /// specify the ICMP type and code. You can use -1 for the type or code to mean all types or all codes.</para> <para>Rule changes are propagated
        /// to affected instances as quickly as possible. However, a small delay might occur.</para>
        /// </summary>
        /// 
        /// <param name="authorizeSecurityGroupEgressRequest">Container for the necessary parameters to execute the AuthorizeSecurityGroupEgress service
        ///          method on AmazonEC2.</param>
        /// 
        AuthorizeSecurityGroupEgressResponse AuthorizeSecurityGroupEgress(AuthorizeSecurityGroupEgressRequest authorizeSecurityGroupEgressRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the AuthorizeSecurityGroupEgress operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.AuthorizeSecurityGroupEgress"/>
        /// </summary>
        /// 
        /// <param name="authorizeSecurityGroupEgressRequest">Container for the necessary parameters to execute the AuthorizeSecurityGroupEgress
        ///          operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginAuthorizeSecurityGroupEgress(AuthorizeSecurityGroupEgressRequest authorizeSecurityGroupEgressRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the AuthorizeSecurityGroupEgress operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.AuthorizeSecurityGroupEgress"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAuthorizeSecurityGroupEgress.</param>
        AuthorizeSecurityGroupEgressResponse EndAuthorizeSecurityGroupEgress(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region AuthorizeSecurityGroupIngress

        /// <summary>
        /// <para>Adds one or more ingress rules to a security group.</para> <para><b>IMPORTANT:</b> EC2-Classic: You can have up to 100 rules per
        /// group. EC2-VPC: You can have up to 50 rules per group (covering both ingress and egress rules). </para> <para>Rule changes are propagated to
        /// instances within the security group as quickly as possible. However, a small delay might occur.</para> <para>[EC2-Classic] This action gives
        /// one or more CIDR IP address ranges permission to access a security group in your account, or gives one or more security groups (called the
        /// <i>source groups</i> ) permission to access a security group for your account. A source group can be for your own AWS account, or
        /// another.</para> <para>[EC2-VPC] This action gives one or more CIDR IP address ranges permission to access a security group in your VPC, or
        /// gives one or more other security groups (called the <i>source groups</i> ) permission to access a security group for your VPC. The security
        /// groups must all be for the same VPC.</para>
        /// </summary>
        /// 
        /// <param name="authorizeSecurityGroupIngressRequest">Container for the necessary parameters to execute the AuthorizeSecurityGroupIngress
        ///          service method on AmazonEC2.</param>
        /// 
        AuthorizeSecurityGroupIngressResponse AuthorizeSecurityGroupIngress(AuthorizeSecurityGroupIngressRequest authorizeSecurityGroupIngressRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the AuthorizeSecurityGroupIngress operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.AuthorizeSecurityGroupIngress"/>
        /// </summary>
        /// 
        /// <param name="authorizeSecurityGroupIngressRequest">Container for the necessary parameters to execute the AuthorizeSecurityGroupIngress
        ///          operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginAuthorizeSecurityGroupIngress(AuthorizeSecurityGroupIngressRequest authorizeSecurityGroupIngressRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the AuthorizeSecurityGroupIngress operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.AuthorizeSecurityGroupIngress"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAuthorizeSecurityGroupIngress.</param>
        AuthorizeSecurityGroupIngressResponse EndAuthorizeSecurityGroupIngress(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region BundleInstance

        /// <summary>
        /// <para>Bundles an Amazon instance store-backed Windows instance.</para> <para>During bundling, only the root device volume (C:\) is bundled.
        /// Data on other instance store volumes is not preserved.</para> <para><b>NOTE:</b> This procedure is not applicable for Linux/Unix instances
        /// or Windows instances that are backed by Amazon EBS. </para> <para>For more information, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/WindowsGuide/Creating_InstanceStoreBacked_WinAMI.html" >Creating an Instance Store-Backed
        /// Windows AMI</a> .</para>
        /// </summary>
        /// 
        /// <param name="bundleInstanceRequest">Container for the necessary parameters to execute the BundleInstance service method on
        ///          AmazonEC2.</param>
        /// 
        /// <returns>The response from the BundleInstance service method, as returned by AmazonEC2.</returns>
        /// 
        BundleInstanceResponse BundleInstance(BundleInstanceRequest bundleInstanceRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the BundleInstance operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.BundleInstance"/>
        /// </summary>
        /// 
        /// <param name="bundleInstanceRequest">Container for the necessary parameters to execute the BundleInstance operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBundleInstance
        ///         operation.</returns>
        IAsyncResult BeginBundleInstance(BundleInstanceRequest bundleInstanceRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the BundleInstance operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.BundleInstance"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBundleInstance.</param>
        /// 
        /// <returns>Returns a BundleInstanceResult from AmazonEC2.</returns>
        BundleInstanceResponse EndBundleInstance(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region CancelBundleTask

        /// <summary>
        /// <para>Cancels a bundling operation for an instance store-backed Windows instance.</para>
        /// </summary>
        /// 
        /// <param name="cancelBundleTaskRequest">Container for the necessary parameters to execute the CancelBundleTask service method on
        ///          AmazonEC2.</param>
        /// 
        /// <returns>The response from the CancelBundleTask service method, as returned by AmazonEC2.</returns>
        /// 
        CancelBundleTaskResponse CancelBundleTask(CancelBundleTaskRequest cancelBundleTaskRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the CancelBundleTask operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CancelBundleTask"/>
        /// </summary>
        /// 
        /// <param name="cancelBundleTaskRequest">Container for the necessary parameters to execute the CancelBundleTask operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelBundleTask
        ///         operation.</returns>
        IAsyncResult BeginCancelBundleTask(CancelBundleTaskRequest cancelBundleTaskRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the CancelBundleTask operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CancelBundleTask"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelBundleTask.</param>
        /// 
        /// <returns>Returns a CancelBundleTaskResult from AmazonEC2.</returns>
        CancelBundleTaskResponse EndCancelBundleTask(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region CancelConversionTask

        /// <summary>
        /// <para>Cancels an active conversion task. The task can be the import of an instance or volume. The action removes all artifacts of the
        /// conversion, including a partially uploaded volume or instance. If the conversion is complete or is in the process of transferring the final
        /// disk image, the command fails and returns an exception.</para> <para>For more information, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/UploadingYourInstancesandVolumes.html" >Using the Command Line Tools to Import Your
        /// Virtual Machine to Amazon EC2</a> in the <i>Amazon Elastic Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="cancelConversionTaskRequest">Container for the necessary parameters to execute the CancelConversionTask service method on
        ///          AmazonEC2.</param>
        /// 
        CancelConversionTaskResponse CancelConversionTask(CancelConversionTaskRequest cancelConversionTaskRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the CancelConversionTask operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CancelConversionTask"/>
        /// </summary>
        /// 
        /// <param name="cancelConversionTaskRequest">Container for the necessary parameters to execute the CancelConversionTask operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginCancelConversionTask(CancelConversionTaskRequest cancelConversionTaskRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the CancelConversionTask operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CancelConversionTask"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelConversionTask.</param>
        CancelConversionTaskResponse EndCancelConversionTask(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region CancelExportTask

        /// <summary>
        /// <para>Cancels an active export task. The request removes all artifacts of the export, including any partially-created Amazon S3 objects. If
        /// the export task is complete or is in the process of transferring the final disk image, the command fails and returns an error.</para>
        /// </summary>
        /// 
        /// <param name="cancelExportTaskRequest">Container for the necessary parameters to execute the CancelExportTask service method on
        ///          AmazonEC2.</param>
        /// 
        CancelExportTaskResponse CancelExportTask(CancelExportTaskRequest cancelExportTaskRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the CancelExportTask operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CancelExportTask"/>
        /// </summary>
        /// 
        /// <param name="cancelExportTaskRequest">Container for the necessary parameters to execute the CancelExportTask operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginCancelExportTask(CancelExportTaskRequest cancelExportTaskRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the CancelExportTask operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CancelExportTask"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelExportTask.</param>
        CancelExportTaskResponse EndCancelExportTask(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region CancelReservedInstancesListing

        /// <summary>
        /// <para>Cancels the specified Reserved Instance listing in the Reserved Instance Marketplace.</para> <para>For more information, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ri-market-general.html" >Reserved Instance Marketplace</a> in the <i>Amazon Elastic
        /// Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="cancelReservedInstancesListingRequest">Container for the necessary parameters to execute the CancelReservedInstancesListing
        ///          service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the CancelReservedInstancesListing service method, as returned by AmazonEC2.</returns>
        /// 
        CancelReservedInstancesListingResponse CancelReservedInstancesListing(CancelReservedInstancesListingRequest cancelReservedInstancesListingRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the CancelReservedInstancesListing operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CancelReservedInstancesListing"/>
        /// </summary>
        /// 
        /// <param name="cancelReservedInstancesListingRequest">Container for the necessary parameters to execute the CancelReservedInstancesListing
        ///          operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndCancelReservedInstancesListing operation.</returns>
        IAsyncResult BeginCancelReservedInstancesListing(CancelReservedInstancesListingRequest cancelReservedInstancesListingRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the CancelReservedInstancesListing operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CancelReservedInstancesListing"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelReservedInstancesListing.</param>
        /// 
        /// <returns>Returns a CancelReservedInstancesListingResult from AmazonEC2.</returns>
        CancelReservedInstancesListingResponse EndCancelReservedInstancesListing(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region CancelSpotInstanceRequests

        /// <summary>
        /// <para>Cancels one or more Spot Instance requests. Spot Instances are instances that Amazon EC2 starts on your behalf when the maximum price
        /// that you specify exceeds the current Spot Price. Amazon EC2 periodically sets the Spot Price based on available Spot Instance capacity and
        /// current Spot Instance requests. For more information about Spot Instances, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-spot-instances.html" >Spot Instances</a> in the <i>Amazon Elastic Compute
        /// Cloud User Guide</i> .</para> <para><b>IMPORTANT:</b> Canceling a Spot Instance request does not terminate running Spot Instances associated
        /// with the request. </para>
        /// </summary>
        /// 
        /// <param name="cancelSpotInstanceRequestsRequest">Container for the necessary parameters to execute the CancelSpotInstanceRequests service
        ///          method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the CancelSpotInstanceRequests service method, as returned by AmazonEC2.</returns>
        /// 
        CancelSpotInstanceRequestsResponse CancelSpotInstanceRequests(CancelSpotInstanceRequestsRequest cancelSpotInstanceRequestsRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the CancelSpotInstanceRequests operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CancelSpotInstanceRequests"/>
        /// </summary>
        /// 
        /// <param name="cancelSpotInstanceRequestsRequest">Container for the necessary parameters to execute the CancelSpotInstanceRequests operation
        ///          on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndCancelSpotInstanceRequests operation.</returns>
        IAsyncResult BeginCancelSpotInstanceRequests(CancelSpotInstanceRequestsRequest cancelSpotInstanceRequestsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the CancelSpotInstanceRequests operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CancelSpotInstanceRequests"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelSpotInstanceRequests.</param>
        /// 
        /// <returns>Returns a CancelSpotInstanceRequestsResult from AmazonEC2.</returns>
        CancelSpotInstanceRequestsResponse EndCancelSpotInstanceRequests(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region ConfirmProductInstance

        /// <summary>
        /// <para>Determines whether a product code is associated with an instance. This action can only be used by the owner of the product code. It is
        /// useful when a product code owner needs to verify whether another user's instance is eligible for support.</para>
        /// </summary>
        /// 
        /// <param name="confirmProductInstanceRequest">Container for the necessary parameters to execute the ConfirmProductInstance service method on
        ///          AmazonEC2.</param>
        /// 
        /// <returns>The response from the ConfirmProductInstance service method, as returned by AmazonEC2.</returns>
        /// 
        ConfirmProductInstanceResponse ConfirmProductInstance(ConfirmProductInstanceRequest confirmProductInstanceRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the ConfirmProductInstance operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ConfirmProductInstance"/>
        /// </summary>
        /// 
        /// <param name="confirmProductInstanceRequest">Container for the necessary parameters to execute the ConfirmProductInstance operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndConfirmProductInstance operation.</returns>
        IAsyncResult BeginConfirmProductInstance(ConfirmProductInstanceRequest confirmProductInstanceRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the ConfirmProductInstance operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ConfirmProductInstance"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginConfirmProductInstance.</param>
        /// 
        /// <returns>Returns a ConfirmProductInstanceResult from AmazonEC2.</returns>
        ConfirmProductInstanceResponse EndConfirmProductInstance(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region CopyImage

        /// <summary>
        /// <para>Initiates the copy of an AMI from the specified source region to the region in which the request was made.</para> <para>For more
        /// information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/CopyingAMIs.html" >Copying AMIs</a> in the <i>Amazon Elastic
        /// Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="copyImageRequest">Container for the necessary parameters to execute the CopyImage service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the CopyImage service method, as returned by AmazonEC2.</returns>
        /// 
        CopyImageResponse CopyImage(CopyImageRequest copyImageRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the CopyImage operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CopyImage"/>
        /// </summary>
        /// 
        /// <param name="copyImageRequest">Container for the necessary parameters to execute the CopyImage operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCopyImage
        ///         operation.</returns>
        IAsyncResult BeginCopyImage(CopyImageRequest copyImageRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the CopyImage operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CopyImage"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCopyImage.</param>
        /// 
        /// <returns>Returns a CopyImageResult from AmazonEC2.</returns>
        CopyImageResponse EndCopyImage(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region CopySnapshot

        /// <summary>
        /// <para>Copies a point-in-time snapshot of an Amazon EBS volume and stores it in Amazon S3. You can copy the snapshot within the same region
        /// or from one region to another. You can use the snapshot to create Amazon EBS volumes or Amazon Machine Images (AMIs).</para> <para>For more
        /// information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-copy-snapshot.html" >Copying an Amazon EBS Snapshot</a> in
        /// the <i>Amazon Elastic Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="copySnapshotRequest">Container for the necessary parameters to execute the CopySnapshot service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the CopySnapshot service method, as returned by AmazonEC2.</returns>
        /// 
        CopySnapshotResponse CopySnapshot(CopySnapshotRequest copySnapshotRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the CopySnapshot operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CopySnapshot"/>
        /// </summary>
        /// 
        /// <param name="copySnapshotRequest">Container for the necessary parameters to execute the CopySnapshot operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCopySnapshot
        ///         operation.</returns>
        IAsyncResult BeginCopySnapshot(CopySnapshotRequest copySnapshotRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the CopySnapshot operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CopySnapshot"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCopySnapshot.</param>
        /// 
        /// <returns>Returns a CopySnapshotResult from AmazonEC2.</returns>
        CopySnapshotResponse EndCopySnapshot(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region CreateCustomerGateway

        /// <summary>
        /// <para>Provides information to AWS about your VPN customer gateway device. The customer gateway is the appliance at your end of the VPN
        /// connection. (The device on the AWS side of the VPN connection is the virtual private gateway.) You must provide the Internet-routable IP
        /// address of the customer gateway's external interface. The IP address must be static and can't be behind a device performing network address
        /// translation (NAT).</para> <para>For devices that use Border Gateway Protocol (BGP), you can also provide the device's BGP Autonomous System
        /// Number (ASN). You can use an existing ASN assigned to your network. If you don't have an ASN already, you can use a private ASN (in the
        /// 64512 - 65534 range).</para> <para><b>NOTE:</b> Amazon EC2 supports all 2-byte ASN numbers in the range of 1 - 65534, with the exception of
        /// 7224, which is reserved in the us-east-1 region, and 9059, which is reserved in the eu-west-1 region. </para> <para>For more information
        /// about VPN customer gateways, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_VPN.html" >Adding a Hardware Virtual
        /// Private Gateway to Your VPC</a> in the <i>Amazon Virtual Private Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="createCustomerGatewayRequest">Container for the necessary parameters to execute the CreateCustomerGateway service method on
        ///          AmazonEC2.</param>
        /// 
        /// <returns>The response from the CreateCustomerGateway service method, as returned by AmazonEC2.</returns>
        /// 
        CreateCustomerGatewayResponse CreateCustomerGateway(CreateCustomerGatewayRequest createCustomerGatewayRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCustomerGateway operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateCustomerGateway"/>
        /// </summary>
        /// 
        /// <param name="createCustomerGatewayRequest">Container for the necessary parameters to execute the CreateCustomerGateway operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndCreateCustomerGateway operation.</returns>
        IAsyncResult BeginCreateCustomerGateway(CreateCustomerGatewayRequest createCustomerGatewayRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the CreateCustomerGateway operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateCustomerGateway"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCustomerGateway.</param>
        /// 
        /// <returns>Returns a CreateCustomerGatewayResult from AmazonEC2.</returns>
        CreateCustomerGatewayResponse EndCreateCustomerGateway(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region CreateDhcpOptions

        /// <summary>
        /// <para>Creates a set of DHCP options for your VPC. After creating the set, you must associate it with the VPC, causing all existing and new
        /// instances that you launch in the VPC to use this set of DHCP options. The following are the individual DHCP options you can specify. For
        /// more information about the options, see <a href="http://www.ietf.org/rfc/rfc2132.txt" >RFC 2132</a> .</para> <para>For more information
        /// about DHCP options, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_DHCP_Options.html" >DHCP Options Sets</a> in the
        /// <i>Amazon Virtual Private Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="createDhcpOptionsRequest">Container for the necessary parameters to execute the CreateDhcpOptions service method on
        ///          AmazonEC2.</param>
        /// 
        /// <returns>The response from the CreateDhcpOptions service method, as returned by AmazonEC2.</returns>
        /// 
        CreateDhcpOptionsResponse CreateDhcpOptions(CreateDhcpOptionsRequest createDhcpOptionsRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDhcpOptions operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateDhcpOptions"/>
        /// </summary>
        /// 
        /// <param name="createDhcpOptionsRequest">Container for the necessary parameters to execute the CreateDhcpOptions operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDhcpOptions
        ///         operation.</returns>
        IAsyncResult BeginCreateDhcpOptions(CreateDhcpOptionsRequest createDhcpOptionsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the CreateDhcpOptions operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateDhcpOptions"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDhcpOptions.</param>
        /// 
        /// <returns>Returns a CreateDhcpOptionsResult from AmazonEC2.</returns>
        CreateDhcpOptionsResponse EndCreateDhcpOptions(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region CreateImage

        /// <summary>
        /// <para>Creates an Amazon EBS-backed AMI from an Amazon EBS-backed instance that is either running or stopped.</para> <para>If you customized
        /// your instance with instance store volumes or EBS volumes in addition to the root device volume, the new AMI contains block device mapping
        /// information for those volumes. When you launch an instance from this new AMI, the instance automatically launches with those additional
        /// volumes.</para> <para>For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/creating-an-ami-ebs.html"
        /// >Creating Amazon EBS-Backed Linux AMIs</a> in the <i>Amazon Elastic Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="createImageRequest">Container for the necessary parameters to execute the CreateImage service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the CreateImage service method, as returned by AmazonEC2.</returns>
        /// 
        CreateImageResponse CreateImage(CreateImageRequest createImageRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateImage operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateImage"/>
        /// </summary>
        /// 
        /// <param name="createImageRequest">Container for the necessary parameters to execute the CreateImage operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateImage
        ///         operation.</returns>
        IAsyncResult BeginCreateImage(CreateImageRequest createImageRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the CreateImage operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateImage"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateImage.</param>
        /// 
        /// <returns>Returns a CreateImageResult from AmazonEC2.</returns>
        CreateImageResponse EndCreateImage(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region CreateInstanceExportTask

        /// <summary>
        /// <para>Exports a running or stopped instance to an Amazon S3 bucket.</para> <para>For information about the supported operating systems,
        /// image formats, and known limitations for the types of instances you can export, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ExportingEC2Instances.html" >Exporting EC2 Instances</a> in the <i>Amazon Elastic
        /// Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="createInstanceExportTaskRequest">Container for the necessary parameters to execute the CreateInstanceExportTask service method
        ///          on AmazonEC2.</param>
        /// 
        /// <returns>The response from the CreateInstanceExportTask service method, as returned by AmazonEC2.</returns>
        /// 
        CreateInstanceExportTaskResponse CreateInstanceExportTask(CreateInstanceExportTaskRequest createInstanceExportTaskRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateInstanceExportTask operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateInstanceExportTask"/>
        /// </summary>
        /// 
        /// <param name="createInstanceExportTaskRequest">Container for the necessary parameters to execute the CreateInstanceExportTask operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndCreateInstanceExportTask operation.</returns>
        IAsyncResult BeginCreateInstanceExportTask(CreateInstanceExportTaskRequest createInstanceExportTaskRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the CreateInstanceExportTask operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateInstanceExportTask"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateInstanceExportTask.</param>
        /// 
        /// <returns>Returns a CreateInstanceExportTaskResult from AmazonEC2.</returns>
        CreateInstanceExportTaskResponse EndCreateInstanceExportTask(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region CreateInternetGateway

        /// <summary>
        /// <para>Creates an Internet gateway for use with a VPC. After creating the Internet gateway, you attach it to a VPC using
        /// AttachInternetGateway.</para> <para>For more information about your VPC and Internet gateway, see the <a
        /// href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/" >Amazon Virtual Private Cloud User Guide</a> .</para>
        /// </summary>
        /// 
        /// <param name="createInternetGatewayRequest">Container for the necessary parameters to execute the CreateInternetGateway service method on
        ///          AmazonEC2.</param>
        /// 
        /// <returns>The response from the CreateInternetGateway service method, as returned by AmazonEC2.</returns>
        /// 
        CreateInternetGatewayResponse CreateInternetGateway(CreateInternetGatewayRequest createInternetGatewayRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateInternetGateway operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateInternetGateway"/>
        /// </summary>
        /// 
        /// <param name="createInternetGatewayRequest">Container for the necessary parameters to execute the CreateInternetGateway operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndCreateInternetGateway operation.</returns>
        IAsyncResult BeginCreateInternetGateway(CreateInternetGatewayRequest createInternetGatewayRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the CreateInternetGateway operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateInternetGateway"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateInternetGateway.</param>
        /// 
        /// <returns>Returns a CreateInternetGatewayResult from AmazonEC2.</returns>
        CreateInternetGatewayResponse EndCreateInternetGateway(IAsyncResult asyncResult);

        /// <summary>
        /// <para>Creates an Internet gateway for use with a VPC. After creating the Internet gateway, you attach it to a VPC using
        /// AttachInternetGateway.</para> <para>For more information about your VPC and Internet gateway, see the <a
        /// href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/" >Amazon Virtual Private Cloud User Guide</a> .</para>
        /// </summary>
        /// 
        /// <returns>The response from the CreateInternetGateway service method, as returned by AmazonEC2.</returns>
        /// 
        CreateInternetGatewayResponse CreateInternetGateway();
        
        #endregion
        
    

        #region CreateKeyPair

        /// <summary>
        /// <para>Creates a 2048-bit RSA key pair with the specified name. Amazon EC2 stores the public key and displays the private key for you to save
        /// to a file. The private key is returned as an unencrypted PEM encoded PKCS#8 private key. If a key with the specified name already exists,
        /// Amazon EC2 returns an error.</para> <para>You can have up to five thousand key pairs per region.</para> <para>For more information about key
        /// pairs, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-key-pairs.html" >Key Pairs</a> in the <i>Amazon Elastic Compute
        /// Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="createKeyPairRequest">Container for the necessary parameters to execute the CreateKeyPair service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the CreateKeyPair service method, as returned by AmazonEC2.</returns>
        /// 
        CreateKeyPairResponse CreateKeyPair(CreateKeyPairRequest createKeyPairRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateKeyPair operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateKeyPair"/>
        /// </summary>
        /// 
        /// <param name="createKeyPairRequest">Container for the necessary parameters to execute the CreateKeyPair operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateKeyPair
        ///         operation.</returns>
        IAsyncResult BeginCreateKeyPair(CreateKeyPairRequest createKeyPairRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the CreateKeyPair operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateKeyPair"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateKeyPair.</param>
        /// 
        /// <returns>Returns a CreateKeyPairResult from AmazonEC2.</returns>
        CreateKeyPairResponse EndCreateKeyPair(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region CreateNetworkAcl

        /// <summary>
        /// <para>Creates a network ACL in a VPC. Network ACLs provide an optional layer of security (in addition to security groups) for the instances
        /// in your VPC.</para> <para>For more information about network ACLs, see <a
        /// href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_ACLs.html" >Network ACLs</a> in the <i>Amazon Virtual Private Cloud User
        /// Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="createNetworkAclRequest">Container for the necessary parameters to execute the CreateNetworkAcl service method on
        ///          AmazonEC2.</param>
        /// 
        /// <returns>The response from the CreateNetworkAcl service method, as returned by AmazonEC2.</returns>
        /// 
        CreateNetworkAclResponse CreateNetworkAcl(CreateNetworkAclRequest createNetworkAclRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateNetworkAcl operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateNetworkAcl"/>
        /// </summary>
        /// 
        /// <param name="createNetworkAclRequest">Container for the necessary parameters to execute the CreateNetworkAcl operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateNetworkAcl
        ///         operation.</returns>
        IAsyncResult BeginCreateNetworkAcl(CreateNetworkAclRequest createNetworkAclRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the CreateNetworkAcl operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateNetworkAcl"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateNetworkAcl.</param>
        /// 
        /// <returns>Returns a CreateNetworkAclResult from AmazonEC2.</returns>
        CreateNetworkAclResponse EndCreateNetworkAcl(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region CreateNetworkAclEntry

        /// <summary>
        /// <para>Creates an entry (a rule) in a network ACL with the specified rule number. Each network ACL has a set of numbered ingress rules and a
        /// separate set of numbered egress rules. When determining whether a packet should be allowed in or out of a subnet associated with the ACL, we
        /// process the entries in the ACL according to the rule numbers, in ascending order. Each network ACL has a set of ingress rules and a separate
        /// set of egress rules.</para> <para>We recommend that you leave room between the rule numbers (for example, 100, 110, 120, ...), and not
        /// number them one right after the other (for example, 101, 102, 103, ...). This makes it easier to add a rule between existing ones without
        /// having to renumber the rules.</para> <para>After you add an entry, you can't modify it; you must either replace it, or create an entry and
        /// delete the old one.</para> <para>For more information about network ACLs, see <a
        /// href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_ACLs.html" >Network ACLs</a> in the <i>Amazon Virtual Private Cloud User
        /// Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="createNetworkAclEntryRequest">Container for the necessary parameters to execute the CreateNetworkAclEntry service method on
        ///          AmazonEC2.</param>
        /// 
        CreateNetworkAclEntryResponse CreateNetworkAclEntry(CreateNetworkAclEntryRequest createNetworkAclEntryRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateNetworkAclEntry operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateNetworkAclEntry"/>
        /// </summary>
        /// 
        /// <param name="createNetworkAclEntryRequest">Container for the necessary parameters to execute the CreateNetworkAclEntry operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginCreateNetworkAclEntry(CreateNetworkAclEntryRequest createNetworkAclEntryRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the CreateNetworkAclEntry operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateNetworkAclEntry"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateNetworkAclEntry.</param>
        CreateNetworkAclEntryResponse EndCreateNetworkAclEntry(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region CreateNetworkInterface

        /// <summary>
        /// <para>Creates a network interface in the specified subnet.</para> <para>For more information about network interfaces, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-eni.html" >Elastic Network Interfaces</a> in the <i>Amazon Elastic Compute
        /// Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="createNetworkInterfaceRequest">Container for the necessary parameters to execute the CreateNetworkInterface service method on
        ///          AmazonEC2.</param>
        /// 
        /// <returns>The response from the CreateNetworkInterface service method, as returned by AmazonEC2.</returns>
        /// 
        CreateNetworkInterfaceResponse CreateNetworkInterface(CreateNetworkInterfaceRequest createNetworkInterfaceRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateNetworkInterface operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateNetworkInterface"/>
        /// </summary>
        /// 
        /// <param name="createNetworkInterfaceRequest">Container for the necessary parameters to execute the CreateNetworkInterface operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndCreateNetworkInterface operation.</returns>
        IAsyncResult BeginCreateNetworkInterface(CreateNetworkInterfaceRequest createNetworkInterfaceRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the CreateNetworkInterface operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateNetworkInterface"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateNetworkInterface.</param>
        /// 
        /// <returns>Returns a CreateNetworkInterfaceResult from AmazonEC2.</returns>
        CreateNetworkInterfaceResponse EndCreateNetworkInterface(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region CreatePlacementGroup

        /// <summary>
        /// <para>Creates a placement group that you launch cluster instances into. You must give the group a name that's unique within the scope of
        /// your account.</para> <para>For more information about placement groups and cluster instances, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using_cluster_computing.html" >Cluster Instances</a> in the <i>Amazon Elastic
        /// Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="createPlacementGroupRequest">Container for the necessary parameters to execute the CreatePlacementGroup service method on
        ///          AmazonEC2.</param>
        /// 
        CreatePlacementGroupResponse CreatePlacementGroup(CreatePlacementGroupRequest createPlacementGroupRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePlacementGroup operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreatePlacementGroup"/>
        /// </summary>
        /// 
        /// <param name="createPlacementGroupRequest">Container for the necessary parameters to execute the CreatePlacementGroup operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginCreatePlacementGroup(CreatePlacementGroupRequest createPlacementGroupRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the CreatePlacementGroup operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreatePlacementGroup"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePlacementGroup.</param>
        CreatePlacementGroupResponse EndCreatePlacementGroup(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region CreateReservedInstancesListing

        /// <summary>
        /// <para>Creates a listing for Amazon EC2 Reserved Instances to be sold in the Reserved Instance Marketplace. You can submit one Reserved
        /// Instance listing at a time.</para> <para>For more information, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ri-market-general.html" >Reserved Instance Marketplace</a> in the <i>Amazon Elastic
        /// Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="createReservedInstancesListingRequest">Container for the necessary parameters to execute the CreateReservedInstancesListing
        ///          service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the CreateReservedInstancesListing service method, as returned by AmazonEC2.</returns>
        /// 
        CreateReservedInstancesListingResponse CreateReservedInstancesListing(CreateReservedInstancesListingRequest createReservedInstancesListingRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateReservedInstancesListing operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateReservedInstancesListing"/>
        /// </summary>
        /// 
        /// <param name="createReservedInstancesListingRequest">Container for the necessary parameters to execute the CreateReservedInstancesListing
        ///          operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndCreateReservedInstancesListing operation.</returns>
        IAsyncResult BeginCreateReservedInstancesListing(CreateReservedInstancesListingRequest createReservedInstancesListingRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the CreateReservedInstancesListing operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateReservedInstancesListing"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateReservedInstancesListing.</param>
        /// 
        /// <returns>Returns a CreateReservedInstancesListingResult from AmazonEC2.</returns>
        CreateReservedInstancesListingResponse EndCreateReservedInstancesListing(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region CreateRoute

        /// <summary>
        /// <para>Creates a route in a route table within a VPC.</para> <para>You must specify one of the following targets: Internet gateway, NAT
        /// instance, or network interface.</para> <para>When determining how to route traffic, we use the route with the most specific match. For
        /// example, let's say the traffic is destined for <c>192.0.2.3</c> , and the route table includes the following two routes:</para>
        /// <ul>
        /// <li> <para> <c>192.0.2.0/24</c> (goes to some target A)</para> </li>
        /// <li> <para> <c>192.0.2.0/28</c> (goes to some target B)</para> </li>
        /// 
        /// </ul>
        /// <para>Both routes apply to the traffic destined for <c>192.0.2.3</c> . However, the second route in the list covers a smaller number of IP
        /// addresses and is therefore more specific, so we use that route to determine where to target the traffic.</para> <para>For more information
        /// about route tables, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Route_Tables.html" >Route Tables</a> in the
        /// <i>Amazon Virtual Private Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="createRouteRequest">Container for the necessary parameters to execute the CreateRoute service method on AmazonEC2.</param>
        /// 
        CreateRouteResponse CreateRoute(CreateRouteRequest createRouteRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRoute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateRoute"/>
        /// </summary>
        /// 
        /// <param name="createRouteRequest">Container for the necessary parameters to execute the CreateRoute operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginCreateRoute(CreateRouteRequest createRouteRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the CreateRoute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateRoute"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRoute.</param>
        CreateRouteResponse EndCreateRoute(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region CreateRouteTable

        /// <summary>
        /// <para>Creates a route table for the specified VPC. After you create a route table, you can add routes and associate the table with a
        /// subnet.</para> <para>For more information about route tables, see <a
        /// href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Route_Tables.html" >Route Tables</a> in the <i>Amazon Virtual Private Cloud
        /// User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="createRouteTableRequest">Container for the necessary parameters to execute the CreateRouteTable service method on
        ///          AmazonEC2.</param>
        /// 
        /// <returns>The response from the CreateRouteTable service method, as returned by AmazonEC2.</returns>
        /// 
        CreateRouteTableResponse CreateRouteTable(CreateRouteTableRequest createRouteTableRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRouteTable operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateRouteTable"/>
        /// </summary>
        /// 
        /// <param name="createRouteTableRequest">Container for the necessary parameters to execute the CreateRouteTable operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateRouteTable
        ///         operation.</returns>
        IAsyncResult BeginCreateRouteTable(CreateRouteTableRequest createRouteTableRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the CreateRouteTable operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateRouteTable"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRouteTable.</param>
        /// 
        /// <returns>Returns a CreateRouteTableResult from AmazonEC2.</returns>
        CreateRouteTableResponse EndCreateRouteTable(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region CreateSecurityGroup

        /// <summary>
        /// <para>Creates a security group.</para> <para>A security group is for use with instances either in the EC2-Classic platform or in a specific
        /// VPC. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-network-security.html" >Amazon EC2 Security
        /// Groups</a> in the <i>Amazon Elastic Compute Cloud User Guide</i> and <a
        /// href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_SecurityGroups.html" >Security Groups for Your VPC</a> in the <i>Amazon
        /// Virtual Private Cloud User Guide</i> .</para> <para><b>IMPORTANT:</b> EC2-Classic: You can have up to 500 security groups. EC2-VPC: You can
        /// create up to 100 security groups per VPC. </para> <para>When you create a security group, you specify a friendly name of your choice. You
        /// can have a security group for use in EC2-Classic with the same name as a security group for use in a VPC. However, you can't have two
        /// security groups for use in EC2-Classic with the same name or two security groups for use in a VPC with the same name.</para> <para>You have
        /// a default security group for use in EC2-Classic and a default security group for use in your VPC. If you don't specify a security group when
        /// you launch an instance, the instance is launched into the appropriate default security group. A default security group includes a default
        /// rule that grants instances unrestricted network access to each other.</para> <para>You can add or remove rules from your security groups
        /// using AuthorizeSecurityGroupIngress, AuthorizeSecurityGroupEgress, RevokeSecurityGroupIngress, and RevokeSecurityGroupEgress.</para>
        /// </summary>
        /// 
        /// <param name="createSecurityGroupRequest">Container for the necessary parameters to execute the CreateSecurityGroup service method on
        ///          AmazonEC2.</param>
        /// 
        /// <returns>The response from the CreateSecurityGroup service method, as returned by AmazonEC2.</returns>
        /// 
        CreateSecurityGroupResponse CreateSecurityGroup(CreateSecurityGroupRequest createSecurityGroupRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSecurityGroup operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateSecurityGroup"/>
        /// </summary>
        /// 
        /// <param name="createSecurityGroupRequest">Container for the necessary parameters to execute the CreateSecurityGroup operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndCreateSecurityGroup operation.</returns>
        IAsyncResult BeginCreateSecurityGroup(CreateSecurityGroupRequest createSecurityGroupRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the CreateSecurityGroup operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateSecurityGroup"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSecurityGroup.</param>
        /// 
        /// <returns>Returns a CreateSecurityGroupResult from AmazonEC2.</returns>
        CreateSecurityGroupResponse EndCreateSecurityGroup(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region CreateSnapshot

        /// <summary>
        /// <para>Creates a snapshot of an Amazon EBS volume and stores it in Amazon S3. You can use snapshots for backups, to make copies of Amazon EBS
        /// volumes, and to save data before shutting down an instance.</para> <para>When a snapshot is created, any AWS Marketplace product codes that
        /// are associated with the source volume are propagated to the snapshot.</para> <para>You can take a snapshot of an attached volume that is in
        /// use. However, snapshots only capture data that has been written to your Amazon EBS volume at the time the snapshot command is issued; this
        /// may exclude any data that has been cached by any applications or the operating system. If you can pause any file writes to the volume long
        /// enough to take a snapshot, your snapshot should be complete. However, if you cannot pause all file writes to the volume, you should unmount
        /// the volume from within the instance, issue the snapshot command, and then remount the volume to ensure a consistent and complete snapshot.
        /// You may remount and use your volume while the snapshot status is <c>pending</c> .</para> <para>To create a snapshot for Amazon EBS volumes
        /// that serve as root devices, you should stop the instance before taking the snapshot.</para> <para>For more information, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-creating-snapshot.html" >Creating an Amazon EBS Snapshot</a> in the <i>Amazon
        /// Elastic Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="createSnapshotRequest">Container for the necessary parameters to execute the CreateSnapshot service method on
        ///          AmazonEC2.</param>
        /// 
        /// <returns>The response from the CreateSnapshot service method, as returned by AmazonEC2.</returns>
        /// 
        CreateSnapshotResponse CreateSnapshot(CreateSnapshotRequest createSnapshotRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSnapshot operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateSnapshot"/>
        /// </summary>
        /// 
        /// <param name="createSnapshotRequest">Container for the necessary parameters to execute the CreateSnapshot operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSnapshot
        ///         operation.</returns>
        IAsyncResult BeginCreateSnapshot(CreateSnapshotRequest createSnapshotRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the CreateSnapshot operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateSnapshot"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSnapshot.</param>
        /// 
        /// <returns>Returns a CreateSnapshotResult from AmazonEC2.</returns>
        CreateSnapshotResponse EndCreateSnapshot(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region CreateSpotDatafeedSubscription

        /// <summary>
        /// <para>Creates a datafeed for Spot Instances, enabling you to view Spot Instance usage logs. You can create one data feed per AWS account.
        /// For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-spot-instances.html" >Spot Instances</a> in the
        /// <i>Amazon Elastic Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="createSpotDatafeedSubscriptionRequest">Container for the necessary parameters to execute the CreateSpotDatafeedSubscription
        ///          service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the CreateSpotDatafeedSubscription service method, as returned by AmazonEC2.</returns>
        /// 
        CreateSpotDatafeedSubscriptionResponse CreateSpotDatafeedSubscription(CreateSpotDatafeedSubscriptionRequest createSpotDatafeedSubscriptionRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSpotDatafeedSubscription operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateSpotDatafeedSubscription"/>
        /// </summary>
        /// 
        /// <param name="createSpotDatafeedSubscriptionRequest">Container for the necessary parameters to execute the CreateSpotDatafeedSubscription
        ///          operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndCreateSpotDatafeedSubscription operation.</returns>
        IAsyncResult BeginCreateSpotDatafeedSubscription(CreateSpotDatafeedSubscriptionRequest createSpotDatafeedSubscriptionRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the CreateSpotDatafeedSubscription operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateSpotDatafeedSubscription"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSpotDatafeedSubscription.</param>
        /// 
        /// <returns>Returns a CreateSpotDatafeedSubscriptionResult from AmazonEC2.</returns>
        CreateSpotDatafeedSubscriptionResponse EndCreateSpotDatafeedSubscription(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region CreateSubnet

        /// <summary>
        /// <para>Creates a subnet in an existing VPC.</para> <para>When you create each subnet, you provide the VPC ID and the CIDR block you want for
        /// the subnet. After you create a subnet, you can't change its CIDR block. The subnet's CIDR block can be the same as the VPC's CIDR block
        /// (assuming you want only a single subnet in the VPC), or a subset of the VPC's CIDR block. If you create more than one subnet in a VPC, the
        /// subnets' CIDR blocks must not overlap. The smallest subnet (and VPC) you can create uses a /28 netmask (16 IP addresses), and the largest
        /// uses a /16 netmask (65,536 IP addresses).</para> <para><b>IMPORTANT:</b> AWS reserves both the first four and the last IP address in each
        /// subnet's CIDR block. They're not available for use. </para> <para>If you add more than one subnet to a VPC, they're set up in a star
        /// topology with a logical router in the middle.</para> <para>For more information about subnets, see <a
        /// href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Subnets.html" >Your VPC and Subnets</a> in the <i>Amazon Virtual Private
        /// Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="createSubnetRequest">Container for the necessary parameters to execute the CreateSubnet service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the CreateSubnet service method, as returned by AmazonEC2.</returns>
        /// 
        CreateSubnetResponse CreateSubnet(CreateSubnetRequest createSubnetRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSubnet operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateSubnet"/>
        /// </summary>
        /// 
        /// <param name="createSubnetRequest">Container for the necessary parameters to execute the CreateSubnet operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSubnet
        ///         operation.</returns>
        IAsyncResult BeginCreateSubnet(CreateSubnetRequest createSubnetRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the CreateSubnet operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateSubnet"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSubnet.</param>
        /// 
        /// <returns>Returns a CreateSubnetResult from AmazonEC2.</returns>
        CreateSubnetResponse EndCreateSubnet(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region CreateTags

        /// <summary>
        /// <para>Adds or overwrites one or more tags for the specified EC2 resource or resources. Each resource can have a maximum of 10 tags. Each tag
        /// consists of a key and optional value. Tag keys must be unique per resource.</para> <para>For more information about tags, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_Tags.html" >Tagging Your Resources</a> in the <i>Amazon Elastic Compute Cloud
        /// User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="createTagsRequest">Container for the necessary parameters to execute the CreateTags service method on AmazonEC2.</param>
        /// 
        CreateTagsResponse CreateTags(CreateTagsRequest createTagsRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTags operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateTags"/>
        /// </summary>
        /// 
        /// <param name="createTagsRequest">Container for the necessary parameters to execute the CreateTags operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginCreateTags(CreateTagsRequest createTagsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the CreateTags operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateTags"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTags.</param>
        CreateTagsResponse EndCreateTags(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region CreateVolume

        /// <summary>
        /// <para>Creates an Amazon EBS volume that can be attached to any instance in the same Availability Zone.</para> <para>Any AWS Marketplace
        /// product codes from the snapshot are propagated to the volume.</para> <para>For more information, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-creating-volume.html" >Creating or Restoring an Amazon EBS Volume</a> in the
        /// <i>Amazon Elastic Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="createVolumeRequest">Container for the necessary parameters to execute the CreateVolume service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the CreateVolume service method, as returned by AmazonEC2.</returns>
        /// 
        CreateVolumeResponse CreateVolume(CreateVolumeRequest createVolumeRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateVolume operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateVolume"/>
        /// </summary>
        /// 
        /// <param name="createVolumeRequest">Container for the necessary parameters to execute the CreateVolume operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateVolume
        ///         operation.</returns>
        IAsyncResult BeginCreateVolume(CreateVolumeRequest createVolumeRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the CreateVolume operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateVolume"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateVolume.</param>
        /// 
        /// <returns>Returns a CreateVolumeResult from AmazonEC2.</returns>
        CreateVolumeResponse EndCreateVolume(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region CreateVpc

        /// <summary>
        /// <para>Creates a VPC with the specified CIDR block.</para> <para>The smallest VPC you can create uses a /28 netmask (16 IP addresses), and
        /// the largest uses a /16 netmask (65,536 IP addresses). To help you decide how big to make your VPC, see <a
        /// href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Subnets.html" >Your VPC and Subnets</a> in the <i>Amazon Virtual Private
        /// Cloud User Guide</i> .</para> <para>By default, each instance you launch in the VPC has the default DHCP options, which includes only a
        /// default DNS server that we provide (AmazonProvidedDNS). For more information about DHCP options, see <a
        /// href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_DHCP_Options.html" >DHCP Options Sets</a> in the <i>Amazon Virtual Private
        /// Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="createVpcRequest">Container for the necessary parameters to execute the CreateVpc service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the CreateVpc service method, as returned by AmazonEC2.</returns>
        /// 
        CreateVpcResponse CreateVpc(CreateVpcRequest createVpcRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateVpc operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateVpc"/>
        /// </summary>
        /// 
        /// <param name="createVpcRequest">Container for the necessary parameters to execute the CreateVpc operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateVpc
        ///         operation.</returns>
        IAsyncResult BeginCreateVpc(CreateVpcRequest createVpcRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the CreateVpc operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateVpc"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateVpc.</param>
        /// 
        /// <returns>Returns a CreateVpcResult from AmazonEC2.</returns>
        CreateVpcResponse EndCreateVpc(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region CreateVpnConnection

        /// <summary>
        /// <para>Creates a VPN connection between an existing virtual private gateway and a VPN customer gateway. The only supported connection type is
        /// <c>ipsec.1</c> .</para> <para>The response includes information that you need to give to your network administrator to configure your
        /// customer gateway.</para> <para><b>IMPORTANT:</b> We strongly recommend that you use HTTPS when calling this operation because the response
        /// contains sensitive cryptographic information for configuring your customer gateway. </para> <para>If you decide to shut down your VPN
        /// connection for any reason and later create a new VPN connection, you must reconfigure your customer gateway with the new information
        /// returned from this call.</para> <para>For more information about VPN connections, see <a
        /// href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_VPN.html" >Adding a Hardware Virtual Private Gateway to Your VPC</a> in the
        /// <i>Amazon Virtual Private Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="createVpnConnectionRequest">Container for the necessary parameters to execute the CreateVpnConnection service method on
        ///          AmazonEC2.</param>
        /// 
        /// <returns>The response from the CreateVpnConnection service method, as returned by AmazonEC2.</returns>
        /// 
        CreateVpnConnectionResponse CreateVpnConnection(CreateVpnConnectionRequest createVpnConnectionRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateVpnConnection operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateVpnConnection"/>
        /// </summary>
        /// 
        /// <param name="createVpnConnectionRequest">Container for the necessary parameters to execute the CreateVpnConnection operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndCreateVpnConnection operation.</returns>
        IAsyncResult BeginCreateVpnConnection(CreateVpnConnectionRequest createVpnConnectionRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the CreateVpnConnection operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateVpnConnection"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateVpnConnection.</param>
        /// 
        /// <returns>Returns a CreateVpnConnectionResult from AmazonEC2.</returns>
        CreateVpnConnectionResponse EndCreateVpnConnection(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region CreateVpnConnectionRoute

        /// <summary>
        /// <para>Creates a static route associated with a VPN connection between an existing virtual private gateway and a VPN customer gateway. The
        /// static route allows traffic to be routed from the virtual private gateway to the VPN customer gateway.</para> <para>For more information
        /// about VPN connections, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_VPN.html" >Adding a Hardware Virtual Private
        /// Gateway to Your VPC</a> in the <i>Amazon Virtual Private Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="createVpnConnectionRouteRequest">Container for the necessary parameters to execute the CreateVpnConnectionRoute service method
        ///          on AmazonEC2.</param>
        /// 
        CreateVpnConnectionRouteResponse CreateVpnConnectionRoute(CreateVpnConnectionRouteRequest createVpnConnectionRouteRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateVpnConnectionRoute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateVpnConnectionRoute"/>
        /// </summary>
        /// 
        /// <param name="createVpnConnectionRouteRequest">Container for the necessary parameters to execute the CreateVpnConnectionRoute operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginCreateVpnConnectionRoute(CreateVpnConnectionRouteRequest createVpnConnectionRouteRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the CreateVpnConnectionRoute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateVpnConnectionRoute"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateVpnConnectionRoute.</param>
        CreateVpnConnectionRouteResponse EndCreateVpnConnectionRoute(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region CreateVpnGateway

        /// <summary>
        /// <para>Creates a virtual private gateway. A virtual private gateway is the endpoint on the VPC side of your VPN connection. You can create a
        /// virtual private gateway before creating the VPC itself.</para> <para>For more information about virtual private gateways, see <a
        /// href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_VPN.html" >Adding a Hardware Virtual Private Gateway to Your VPC</a> in the
        /// <i>Amazon Virtual Private Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="createVpnGatewayRequest">Container for the necessary parameters to execute the CreateVpnGateway service method on
        ///          AmazonEC2.</param>
        /// 
        /// <returns>The response from the CreateVpnGateway service method, as returned by AmazonEC2.</returns>
        /// 
        CreateVpnGatewayResponse CreateVpnGateway(CreateVpnGatewayRequest createVpnGatewayRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateVpnGateway operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateVpnGateway"/>
        /// </summary>
        /// 
        /// <param name="createVpnGatewayRequest">Container for the necessary parameters to execute the CreateVpnGateway operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateVpnGateway
        ///         operation.</returns>
        IAsyncResult BeginCreateVpnGateway(CreateVpnGatewayRequest createVpnGatewayRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the CreateVpnGateway operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateVpnGateway"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateVpnGateway.</param>
        /// 
        /// <returns>Returns a CreateVpnGatewayResult from AmazonEC2.</returns>
        CreateVpnGatewayResponse EndCreateVpnGateway(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DeleteCustomerGateway

        /// <summary>
        /// <para>Deletes the specified customer gateway. You must delete the VPN connection before you can delete the customer gateway.</para>
        /// </summary>
        /// 
        /// <param name="deleteCustomerGatewayRequest">Container for the necessary parameters to execute the DeleteCustomerGateway service method on
        ///          AmazonEC2.</param>
        /// 
        DeleteCustomerGatewayResponse DeleteCustomerGateway(DeleteCustomerGatewayRequest deleteCustomerGatewayRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCustomerGateway operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteCustomerGateway"/>
        /// </summary>
        /// 
        /// <param name="deleteCustomerGatewayRequest">Container for the necessary parameters to execute the DeleteCustomerGateway operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginDeleteCustomerGateway(DeleteCustomerGatewayRequest deleteCustomerGatewayRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteCustomerGateway operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteCustomerGateway"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCustomerGateway.</param>
        DeleteCustomerGatewayResponse EndDeleteCustomerGateway(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DeleteDhcpOptions

        /// <summary>
        /// <para>Deletes the specified set of DHCP options. You must disassociate the set of DHCP options before you can delete it. You can
        /// disassociate the set of DHCP options by associating either a new set of options or the default set of options with the VPC.</para>
        /// </summary>
        /// 
        /// <param name="deleteDhcpOptionsRequest">Container for the necessary parameters to execute the DeleteDhcpOptions service method on
        ///          AmazonEC2.</param>
        /// 
        DeleteDhcpOptionsResponse DeleteDhcpOptions(DeleteDhcpOptionsRequest deleteDhcpOptionsRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDhcpOptions operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteDhcpOptions"/>
        /// </summary>
        /// 
        /// <param name="deleteDhcpOptionsRequest">Container for the necessary parameters to execute the DeleteDhcpOptions operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginDeleteDhcpOptions(DeleteDhcpOptionsRequest deleteDhcpOptionsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteDhcpOptions operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteDhcpOptions"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDhcpOptions.</param>
        DeleteDhcpOptionsResponse EndDeleteDhcpOptions(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DeleteInternetGateway

        /// <summary>
        /// <para>Deletes the specified Internet gateway. You must detach the Internet gateway from the VPC before you can delete it.</para>
        /// </summary>
        /// 
        /// <param name="deleteInternetGatewayRequest">Container for the necessary parameters to execute the DeleteInternetGateway service method on
        ///          AmazonEC2.</param>
        /// 
        DeleteInternetGatewayResponse DeleteInternetGateway(DeleteInternetGatewayRequest deleteInternetGatewayRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteInternetGateway operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteInternetGateway"/>
        /// </summary>
        /// 
        /// <param name="deleteInternetGatewayRequest">Container for the necessary parameters to execute the DeleteInternetGateway operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginDeleteInternetGateway(DeleteInternetGatewayRequest deleteInternetGatewayRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteInternetGateway operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteInternetGateway"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteInternetGateway.</param>
        DeleteInternetGatewayResponse EndDeleteInternetGateway(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DeleteKeyPair

        /// <summary>
        /// <para>Deletes the specified key pair, by removing the public key from Amazon EC2.</para>
        /// </summary>
        /// 
        /// <param name="deleteKeyPairRequest">Container for the necessary parameters to execute the DeleteKeyPair service method on AmazonEC2.</param>
        /// 
        DeleteKeyPairResponse DeleteKeyPair(DeleteKeyPairRequest deleteKeyPairRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteKeyPair operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteKeyPair"/>
        /// </summary>
        /// 
        /// <param name="deleteKeyPairRequest">Container for the necessary parameters to execute the DeleteKeyPair operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginDeleteKeyPair(DeleteKeyPairRequest deleteKeyPairRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteKeyPair operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteKeyPair"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteKeyPair.</param>
        DeleteKeyPairResponse EndDeleteKeyPair(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DeleteNetworkAcl

        /// <summary>
        /// <para>Deletes the specified network ACL. You can't delete the ACL if it's associated with any subnets. You can't delete the default network
        /// ACL.</para>
        /// </summary>
        /// 
        /// <param name="deleteNetworkAclRequest">Container for the necessary parameters to execute the DeleteNetworkAcl service method on
        ///          AmazonEC2.</param>
        /// 
        DeleteNetworkAclResponse DeleteNetworkAcl(DeleteNetworkAclRequest deleteNetworkAclRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteNetworkAcl operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteNetworkAcl"/>
        /// </summary>
        /// 
        /// <param name="deleteNetworkAclRequest">Container for the necessary parameters to execute the DeleteNetworkAcl operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginDeleteNetworkAcl(DeleteNetworkAclRequest deleteNetworkAclRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteNetworkAcl operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteNetworkAcl"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteNetworkAcl.</param>
        DeleteNetworkAclResponse EndDeleteNetworkAcl(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DeleteNetworkAclEntry

        /// <summary>
        /// <para>Deletes the specified ingress or egress entry (rule) from the specified network ACL.</para>
        /// </summary>
        /// 
        /// <param name="deleteNetworkAclEntryRequest">Container for the necessary parameters to execute the DeleteNetworkAclEntry service method on
        ///          AmazonEC2.</param>
        /// 
        DeleteNetworkAclEntryResponse DeleteNetworkAclEntry(DeleteNetworkAclEntryRequest deleteNetworkAclEntryRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteNetworkAclEntry operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteNetworkAclEntry"/>
        /// </summary>
        /// 
        /// <param name="deleteNetworkAclEntryRequest">Container for the necessary parameters to execute the DeleteNetworkAclEntry operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginDeleteNetworkAclEntry(DeleteNetworkAclEntryRequest deleteNetworkAclEntryRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteNetworkAclEntry operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteNetworkAclEntry"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteNetworkAclEntry.</param>
        DeleteNetworkAclEntryResponse EndDeleteNetworkAclEntry(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DeleteNetworkInterface

        /// <summary>
        /// <para>Deletes the specified network interface. You must detach the network interface before you can delete it.</para>
        /// </summary>
        /// 
        /// <param name="deleteNetworkInterfaceRequest">Container for the necessary parameters to execute the DeleteNetworkInterface service method on
        ///          AmazonEC2.</param>
        /// 
        DeleteNetworkInterfaceResponse DeleteNetworkInterface(DeleteNetworkInterfaceRequest deleteNetworkInterfaceRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteNetworkInterface operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteNetworkInterface"/>
        /// </summary>
        /// 
        /// <param name="deleteNetworkInterfaceRequest">Container for the necessary parameters to execute the DeleteNetworkInterface operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginDeleteNetworkInterface(DeleteNetworkInterfaceRequest deleteNetworkInterfaceRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteNetworkInterface operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteNetworkInterface"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteNetworkInterface.</param>
        DeleteNetworkInterfaceResponse EndDeleteNetworkInterface(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DeletePlacementGroup

        /// <summary>
        /// <para>Deletes the specified placement group. You must terminate all instances in the placement group before you can delete the placement
        /// group. For more information about placement groups and cluster instances, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using_cluster_computing.html" >Cluster Instances</a> in the <i>Amazon Elastic
        /// Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="deletePlacementGroupRequest">Container for the necessary parameters to execute the DeletePlacementGroup service method on
        ///          AmazonEC2.</param>
        /// 
        DeletePlacementGroupResponse DeletePlacementGroup(DeletePlacementGroupRequest deletePlacementGroupRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePlacementGroup operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeletePlacementGroup"/>
        /// </summary>
        /// 
        /// <param name="deletePlacementGroupRequest">Container for the necessary parameters to execute the DeletePlacementGroup operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginDeletePlacementGroup(DeletePlacementGroupRequest deletePlacementGroupRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeletePlacementGroup operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeletePlacementGroup"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePlacementGroup.</param>
        DeletePlacementGroupResponse EndDeletePlacementGroup(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DeleteRoute

        /// <summary>
        /// <para>Deletes the specified route from the specified route table.</para>
        /// </summary>
        /// 
        /// <param name="deleteRouteRequest">Container for the necessary parameters to execute the DeleteRoute service method on AmazonEC2.</param>
        /// 
        DeleteRouteResponse DeleteRoute(DeleteRouteRequest deleteRouteRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRoute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteRoute"/>
        /// </summary>
        /// 
        /// <param name="deleteRouteRequest">Container for the necessary parameters to execute the DeleteRoute operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginDeleteRoute(DeleteRouteRequest deleteRouteRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteRoute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteRoute"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRoute.</param>
        DeleteRouteResponse EndDeleteRoute(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DeleteRouteTable

        /// <summary>
        /// <para>Deletes the specified route table. You must disassociate the route table from any subnets before you can delete it. You can't delete
        /// the main route table.</para>
        /// </summary>
        /// 
        /// <param name="deleteRouteTableRequest">Container for the necessary parameters to execute the DeleteRouteTable service method on
        ///          AmazonEC2.</param>
        /// 
        DeleteRouteTableResponse DeleteRouteTable(DeleteRouteTableRequest deleteRouteTableRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRouteTable operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteRouteTable"/>
        /// </summary>
        /// 
        /// <param name="deleteRouteTableRequest">Container for the necessary parameters to execute the DeleteRouteTable operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginDeleteRouteTable(DeleteRouteTableRequest deleteRouteTableRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteRouteTable operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteRouteTable"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRouteTable.</param>
        DeleteRouteTableResponse EndDeleteRouteTable(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DeleteSecurityGroup

        /// <summary>
        /// <para>Deletes a security group.</para> <para>If you attempt to delete a security group that is associated with an instance, or is referenced
        /// by another security group, the operation fails with <c>InvalidGroup.InUse</c> in EC2-Classic or <c>DependencyViolation</c> in
        /// EC2-VPC.</para>
        /// </summary>
        /// 
        /// <param name="deleteSecurityGroupRequest">Container for the necessary parameters to execute the DeleteSecurityGroup service method on
        ///          AmazonEC2.</param>
        /// 
        DeleteSecurityGroupResponse DeleteSecurityGroup(DeleteSecurityGroupRequest deleteSecurityGroupRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSecurityGroup operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteSecurityGroup"/>
        /// </summary>
        /// 
        /// <param name="deleteSecurityGroupRequest">Container for the necessary parameters to execute the DeleteSecurityGroup operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginDeleteSecurityGroup(DeleteSecurityGroupRequest deleteSecurityGroupRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteSecurityGroup operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteSecurityGroup"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSecurityGroup.</param>
        DeleteSecurityGroupResponse EndDeleteSecurityGroup(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DeleteSnapshot

        /// <summary>
        /// <para>Deletes the specified snapshot.</para> <para>When you make periodic snapshots of a volume, the snapshots are incremental, and only the
        /// blocks on the device that have changed since your last snapshot are saved in the new snapshot. When you delete a snapshot, only the data not
        /// needed for any other snapshot is removed. So regardless of which prior snapshots have been deleted, all active snapshots will have access to
        /// all the information needed to restore the volume.</para> <para>You cannot delete a snapshot of the root device of an Amazon EBS volume used
        /// by a registered AMI. You must first de-register the AMI before you can delete the snapshot.</para> <para>For more information, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-deleting-snapshot.html" >Deleting an Amazon EBS Snapshot</a> in the <i>Amazon
        /// Elastic Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="deleteSnapshotRequest">Container for the necessary parameters to execute the DeleteSnapshot service method on
        ///          AmazonEC2.</param>
        /// 
        DeleteSnapshotResponse DeleteSnapshot(DeleteSnapshotRequest deleteSnapshotRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSnapshot operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteSnapshot"/>
        /// </summary>
        /// 
        /// <param name="deleteSnapshotRequest">Container for the necessary parameters to execute the DeleteSnapshot operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginDeleteSnapshot(DeleteSnapshotRequest deleteSnapshotRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteSnapshot operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteSnapshot"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSnapshot.</param>
        DeleteSnapshotResponse EndDeleteSnapshot(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DeleteSpotDatafeedSubscription

        /// <summary>
        /// <para>Deletes the datafeed for Spot Instances. For more information, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-spot-instances.html" >Spot Instances</a> in the <i>Amazon Elastic Compute
        /// Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="deleteSpotDatafeedSubscriptionRequest">Container for the necessary parameters to execute the DeleteSpotDatafeedSubscription
        ///          service method on AmazonEC2.</param>
        /// 
        DeleteSpotDatafeedSubscriptionResponse DeleteSpotDatafeedSubscription(DeleteSpotDatafeedSubscriptionRequest deleteSpotDatafeedSubscriptionRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSpotDatafeedSubscription operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteSpotDatafeedSubscription"/>
        /// </summary>
        /// 
        /// <param name="deleteSpotDatafeedSubscriptionRequest">Container for the necessary parameters to execute the DeleteSpotDatafeedSubscription
        ///          operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginDeleteSpotDatafeedSubscription(DeleteSpotDatafeedSubscriptionRequest deleteSpotDatafeedSubscriptionRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteSpotDatafeedSubscription operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteSpotDatafeedSubscription"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSpotDatafeedSubscription.</param>
        DeleteSpotDatafeedSubscriptionResponse EndDeleteSpotDatafeedSubscription(IAsyncResult asyncResult);

        /// <summary>
        /// <para>Deletes the datafeed for Spot Instances. For more information, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-spot-instances.html" >Spot Instances</a> in the <i>Amazon Elastic Compute
        /// Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        DeleteSpotDatafeedSubscriptionResponse DeleteSpotDatafeedSubscription();
        
        #endregion
        
    

        #region DeleteSubnet

        /// <summary>
        /// <para>Deletes the specified subnet. You must terminate all running instances in the subnet before you can delete the subnet.</para>
        /// </summary>
        /// 
        /// <param name="deleteSubnetRequest">Container for the necessary parameters to execute the DeleteSubnet service method on AmazonEC2.</param>
        /// 
        DeleteSubnetResponse DeleteSubnet(DeleteSubnetRequest deleteSubnetRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSubnet operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteSubnet"/>
        /// </summary>
        /// 
        /// <param name="deleteSubnetRequest">Container for the necessary parameters to execute the DeleteSubnet operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginDeleteSubnet(DeleteSubnetRequest deleteSubnetRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteSubnet operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteSubnet"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSubnet.</param>
        DeleteSubnetResponse EndDeleteSubnet(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DeleteTags

        /// <summary>
        /// <para>Deletes the specified set of tags from the specified set of resources. This call is designed to follow a <c>DescribeTags</c>
        /// request.</para> <para>For more information about tags, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_Tags.html"
        /// >Tagging Your Resources</a> in the <i>Amazon Elastic Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="deleteTagsRequest">Container for the necessary parameters to execute the DeleteTags service method on AmazonEC2.</param>
        /// 
        DeleteTagsResponse DeleteTags(DeleteTagsRequest deleteTagsRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTags operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteTags"/>
        /// </summary>
        /// 
        /// <param name="deleteTagsRequest">Container for the necessary parameters to execute the DeleteTags operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginDeleteTags(DeleteTagsRequest deleteTagsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteTags operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteTags"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTags.</param>
        DeleteTagsResponse EndDeleteTags(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DeleteVolume

        /// <summary>
        /// <para>Deletes the specified Amazon EBS volume. The volume must be in the <c>available</c> state (not attached to an instance).</para>
        /// <para><b>NOTE:</b> The volume remains in the deleting state for several minutes. </para> <para>For more information, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-deleting-volume.html" >Deleting an Amazon EBS Volume</a> in the <i>Amazon
        /// Elastic Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="deleteVolumeRequest">Container for the necessary parameters to execute the DeleteVolume service method on AmazonEC2.</param>
        /// 
        DeleteVolumeResponse DeleteVolume(DeleteVolumeRequest deleteVolumeRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVolume operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteVolume"/>
        /// </summary>
        /// 
        /// <param name="deleteVolumeRequest">Container for the necessary parameters to execute the DeleteVolume operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginDeleteVolume(DeleteVolumeRequest deleteVolumeRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteVolume operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteVolume"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVolume.</param>
        DeleteVolumeResponse EndDeleteVolume(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DeleteVpc

        /// <summary>
        /// <para>Deletes the specified VPC. You must detach or delete all gateways and resources that are associated with the VPC before you can delete
        /// it. For example, you must terminate all instances running in the VPC, delete all security groups associated with the VPC (except the default
        /// one), delete all route tables associated with the VPC (except the default one), and so on.</para>
        /// </summary>
        /// 
        /// <param name="deleteVpcRequest">Container for the necessary parameters to execute the DeleteVpc service method on AmazonEC2.</param>
        /// 
        DeleteVpcResponse DeleteVpc(DeleteVpcRequest deleteVpcRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVpc operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteVpc"/>
        /// </summary>
        /// 
        /// <param name="deleteVpcRequest">Container for the necessary parameters to execute the DeleteVpc operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginDeleteVpc(DeleteVpcRequest deleteVpcRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteVpc operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteVpc"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVpc.</param>
        DeleteVpcResponse EndDeleteVpc(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DeleteVpnConnection

        /// <summary>
        /// <para>Deletes the specified VPN connection.</para> <para>If you're deleting the VPC and its associated components, we recommend that you
        /// detach the virtual private gateway from the VPC and delete the VPC before deleting the VPN connection.</para>
        /// </summary>
        /// 
        /// <param name="deleteVpnConnectionRequest">Container for the necessary parameters to execute the DeleteVpnConnection service method on
        ///          AmazonEC2.</param>
        /// 
        DeleteVpnConnectionResponse DeleteVpnConnection(DeleteVpnConnectionRequest deleteVpnConnectionRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVpnConnection operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteVpnConnection"/>
        /// </summary>
        /// 
        /// <param name="deleteVpnConnectionRequest">Container for the necessary parameters to execute the DeleteVpnConnection operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginDeleteVpnConnection(DeleteVpnConnectionRequest deleteVpnConnectionRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteVpnConnection operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteVpnConnection"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVpnConnection.</param>
        DeleteVpnConnectionResponse EndDeleteVpnConnection(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DeleteVpnConnectionRoute

        /// <summary>
        /// <para>Deletes the specified static route associated with a VPN connection between an existing virtual private gateway and a VPN customer
        /// gateway. The static route allows traffic to be routed from the virtual private gateway to the VPN customer gateway.</para>
        /// </summary>
        /// 
        /// <param name="deleteVpnConnectionRouteRequest">Container for the necessary parameters to execute the DeleteVpnConnectionRoute service method
        ///          on AmazonEC2.</param>
        /// 
        DeleteVpnConnectionRouteResponse DeleteVpnConnectionRoute(DeleteVpnConnectionRouteRequest deleteVpnConnectionRouteRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVpnConnectionRoute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteVpnConnectionRoute"/>
        /// </summary>
        /// 
        /// <param name="deleteVpnConnectionRouteRequest">Container for the necessary parameters to execute the DeleteVpnConnectionRoute operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginDeleteVpnConnectionRoute(DeleteVpnConnectionRouteRequest deleteVpnConnectionRouteRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteVpnConnectionRoute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteVpnConnectionRoute"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVpnConnectionRoute.</param>
        DeleteVpnConnectionRouteResponse EndDeleteVpnConnectionRoute(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DeleteVpnGateway

        /// <summary>
        /// <para>Deletes the specified virtual private gateway. We recommend that before you delete a virtual private gateway, you detach it from the
        /// VPC and delete the VPN connection. Note that you don't need to delete the virtual private gateway if you plan to delete and recreate the VPN
        /// connection between your VPC and your network.</para>
        /// </summary>
        /// 
        /// <param name="deleteVpnGatewayRequest">Container for the necessary parameters to execute the DeleteVpnGateway service method on
        ///          AmazonEC2.</param>
        /// 
        DeleteVpnGatewayResponse DeleteVpnGateway(DeleteVpnGatewayRequest deleteVpnGatewayRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVpnGateway operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteVpnGateway"/>
        /// </summary>
        /// 
        /// <param name="deleteVpnGatewayRequest">Container for the necessary parameters to execute the DeleteVpnGateway operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginDeleteVpnGateway(DeleteVpnGatewayRequest deleteVpnGatewayRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteVpnGateway operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteVpnGateway"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVpnGateway.</param>
        DeleteVpnGatewayResponse EndDeleteVpnGateway(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DeregisterImage

        /// <summary>
        /// <para>Deregisters the specified AMI. After you deregister an AMI, it can't be used to launch new instances.</para> <para>This command does
        /// not delete the AMI.</para>
        /// </summary>
        /// 
        /// <param name="deregisterImageRequest">Container for the necessary parameters to execute the DeregisterImage service method on
        ///          AmazonEC2.</param>
        /// 
        DeregisterImageResponse DeregisterImage(DeregisterImageRequest deregisterImageRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterImage operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeregisterImage"/>
        /// </summary>
        /// 
        /// <param name="deregisterImageRequest">Container for the necessary parameters to execute the DeregisterImage operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginDeregisterImage(DeregisterImageRequest deregisterImageRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DeregisterImage operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeregisterImage"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeregisterImage.</param>
        DeregisterImageResponse EndDeregisterImage(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DescribeAccountAttributes

        /// <summary>
        /// <para>Describes the specified attribute of your AWS account.</para>
        /// </summary>
        /// 
        /// <param name="describeAccountAttributesRequest">Container for the necessary parameters to execute the DescribeAccountAttributes service
        ///          method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeAccountAttributes service method, as returned by AmazonEC2.</returns>
        /// 
        DescribeAccountAttributesResponse DescribeAccountAttributes(DescribeAccountAttributesRequest describeAccountAttributesRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAccountAttributes operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeAccountAttributes"/>
        /// </summary>
        /// 
        /// <param name="describeAccountAttributesRequest">Container for the necessary parameters to execute the DescribeAccountAttributes operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeAccountAttributes operation.</returns>
        IAsyncResult BeginDescribeAccountAttributes(DescribeAccountAttributesRequest describeAccountAttributesRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeAccountAttributes operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeAccountAttributes"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAccountAttributes.</param>
        /// 
        /// <returns>Returns a DescribeAccountAttributesResult from AmazonEC2.</returns>
        DescribeAccountAttributesResponse EndDescribeAccountAttributes(IAsyncResult asyncResult);

        /// <summary>
        /// <para>Describes the specified attribute of your AWS account.</para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeAccountAttributes service method, as returned by AmazonEC2.</returns>
        /// 
        DescribeAccountAttributesResponse DescribeAccountAttributes();
        
        #endregion
        
    

        #region DescribeAddresses

        /// <summary>
        /// <para>Describes one or more of your Elastic IP addresses.</para> <para>An Elastic IP address is for use in either the EC2-Classic platform
        /// or in a VPC. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/elastic-ip-addresses-eip.html" >Elastic
        /// IP Addresses</a> in the <i>Amazon Elastic Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="describeAddressesRequest">Container for the necessary parameters to execute the DescribeAddresses service method on
        ///          AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeAddresses service method, as returned by AmazonEC2.</returns>
        /// 
        DescribeAddressesResponse DescribeAddresses(DescribeAddressesRequest describeAddressesRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAddresses operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeAddresses"/>
        /// </summary>
        /// 
        /// <param name="describeAddressesRequest">Container for the necessary parameters to execute the DescribeAddresses operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAddresses
        ///         operation.</returns>
        IAsyncResult BeginDescribeAddresses(DescribeAddressesRequest describeAddressesRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeAddresses operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeAddresses"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAddresses.</param>
        /// 
        /// <returns>Returns a DescribeAddressesResult from AmazonEC2.</returns>
        DescribeAddressesResponse EndDescribeAddresses(IAsyncResult asyncResult);

        /// <summary>
        /// <para>Describes one or more of your Elastic IP addresses.</para> <para>An Elastic IP address is for use in either the EC2-Classic platform
        /// or in a VPC. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/elastic-ip-addresses-eip.html" >Elastic
        /// IP Addresses</a> in the <i>Amazon Elastic Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeAddresses service method, as returned by AmazonEC2.</returns>
        /// 
        DescribeAddressesResponse DescribeAddresses();
        
        #endregion
        
    

        #region DescribeAvailabilityZones

        /// <summary>
        /// <para>Describes one or more of the Availability Zones that are available to you. The results include zones only for the region you're
        /// currently using. If there is an event impacting an Availability Zone, you can use this request to view the state and any provided message
        /// for that Availability Zone.</para> <para>For more information, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-regions-availability-zones.html" >Regions and Availability Zones</a> in the
        /// <i>Amazon Elastic Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="describeAvailabilityZonesRequest">Container for the necessary parameters to execute the DescribeAvailabilityZones service
        ///          method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeAvailabilityZones service method, as returned by AmazonEC2.</returns>
        /// 
        DescribeAvailabilityZonesResponse DescribeAvailabilityZones(DescribeAvailabilityZonesRequest describeAvailabilityZonesRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAvailabilityZones operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeAvailabilityZones"/>
        /// </summary>
        /// 
        /// <param name="describeAvailabilityZonesRequest">Container for the necessary parameters to execute the DescribeAvailabilityZones operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeAvailabilityZones operation.</returns>
        IAsyncResult BeginDescribeAvailabilityZones(DescribeAvailabilityZonesRequest describeAvailabilityZonesRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeAvailabilityZones operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeAvailabilityZones"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAvailabilityZones.</param>
        /// 
        /// <returns>Returns a DescribeAvailabilityZonesResult from AmazonEC2.</returns>
        DescribeAvailabilityZonesResponse EndDescribeAvailabilityZones(IAsyncResult asyncResult);

        /// <summary>
        /// <para>Describes one or more of the Availability Zones that are available to you. The results include zones only for the region you're
        /// currently using. If there is an event impacting an Availability Zone, you can use this request to view the state and any provided message
        /// for that Availability Zone.</para> <para>For more information, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-regions-availability-zones.html" >Regions and Availability Zones</a> in the
        /// <i>Amazon Elastic Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeAvailabilityZones service method, as returned by AmazonEC2.</returns>
        /// 
        DescribeAvailabilityZonesResponse DescribeAvailabilityZones();
        
        #endregion
        
    

        #region DescribeBundleTasks

        /// <summary>
        /// <para>Describes one or more of your bundling tasks.</para> <para><b>NOTE:</b> Completed bundle tasks are listed for only a limited time. If
        /// your bundle task is no longer in the list, you can still register an AMI from it. Just use RegisterImage with the Amazon S3 bucket name and
        /// image manifest name you provided to the bundle task. </para>
        /// </summary>
        /// 
        /// <param name="describeBundleTasksRequest">Container for the necessary parameters to execute the DescribeBundleTasks service method on
        ///          AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeBundleTasks service method, as returned by AmazonEC2.</returns>
        /// 
        DescribeBundleTasksResponse DescribeBundleTasks(DescribeBundleTasksRequest describeBundleTasksRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeBundleTasks operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeBundleTasks"/>
        /// </summary>
        /// 
        /// <param name="describeBundleTasksRequest">Container for the necessary parameters to execute the DescribeBundleTasks operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeBundleTasks operation.</returns>
        IAsyncResult BeginDescribeBundleTasks(DescribeBundleTasksRequest describeBundleTasksRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeBundleTasks operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeBundleTasks"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeBundleTasks.</param>
        /// 
        /// <returns>Returns a DescribeBundleTasksResult from AmazonEC2.</returns>
        DescribeBundleTasksResponse EndDescribeBundleTasks(IAsyncResult asyncResult);

        /// <summary>
        /// <para>Describes one or more of your bundling tasks.</para> <para><b>NOTE:</b> Completed bundle tasks are listed for only a limited time. If
        /// your bundle task is no longer in the list, you can still register an AMI from it. Just use RegisterImage with the Amazon S3 bucket name and
        /// image manifest name you provided to the bundle task. </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeBundleTasks service method, as returned by AmazonEC2.</returns>
        /// 
        DescribeBundleTasksResponse DescribeBundleTasks();
        
        #endregion
        
    

        #region DescribeConversionTasks

        /// <summary>
        /// <para>Describes one or more of your conversion tasks. For more information, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/UploadingYourInstancesandVolumes.html" >Using the Command Line Tools to Import Your
        /// Virtual Machine to Amazon EC2</a> in the <i>Amazon Elastic Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="describeConversionTasksRequest">Container for the necessary parameters to execute the DescribeConversionTasks service method on
        ///          AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeConversionTasks service method, as returned by AmazonEC2.</returns>
        /// 
        DescribeConversionTasksResponse DescribeConversionTasks(DescribeConversionTasksRequest describeConversionTasksRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeConversionTasks operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeConversionTasks"/>
        /// </summary>
        /// 
        /// <param name="describeConversionTasksRequest">Container for the necessary parameters to execute the DescribeConversionTasks operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeConversionTasks operation.</returns>
        IAsyncResult BeginDescribeConversionTasks(DescribeConversionTasksRequest describeConversionTasksRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeConversionTasks operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeConversionTasks"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeConversionTasks.</param>
        /// 
        /// <returns>Returns a DescribeConversionTasksResult from AmazonEC2.</returns>
        DescribeConversionTasksResponse EndDescribeConversionTasks(IAsyncResult asyncResult);

        /// <summary>
        /// <para>Describes one or more of your conversion tasks. For more information, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/UploadingYourInstancesandVolumes.html" >Using the Command Line Tools to Import Your
        /// Virtual Machine to Amazon EC2</a> in the <i>Amazon Elastic Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeConversionTasks service method, as returned by AmazonEC2.</returns>
        /// 
        DescribeConversionTasksResponse DescribeConversionTasks();
        
        #endregion
        
    

        #region DescribeCustomerGateways

        /// <summary>
        /// <para>Describes one or more of your VPN customer gateways.</para> <para>For more information about VPN customer gateways, see <a
        /// href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_VPN.html" >Adding a Hardware Virtual Private Gateway to Your VPC</a> in the
        /// <i>Amazon Virtual Private Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="describeCustomerGatewaysRequest">Container for the necessary parameters to execute the DescribeCustomerGateways service method
        ///          on AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeCustomerGateways service method, as returned by AmazonEC2.</returns>
        /// 
        DescribeCustomerGatewaysResponse DescribeCustomerGateways(DescribeCustomerGatewaysRequest describeCustomerGatewaysRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCustomerGateways operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeCustomerGateways"/>
        /// </summary>
        /// 
        /// <param name="describeCustomerGatewaysRequest">Container for the necessary parameters to execute the DescribeCustomerGateways operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeCustomerGateways operation.</returns>
        IAsyncResult BeginDescribeCustomerGateways(DescribeCustomerGatewaysRequest describeCustomerGatewaysRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeCustomerGateways operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeCustomerGateways"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCustomerGateways.</param>
        /// 
        /// <returns>Returns a DescribeCustomerGatewaysResult from AmazonEC2.</returns>
        DescribeCustomerGatewaysResponse EndDescribeCustomerGateways(IAsyncResult asyncResult);

        /// <summary>
        /// <para>Describes one or more of your VPN customer gateways.</para> <para>For more information about VPN customer gateways, see <a
        /// href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_VPN.html" >Adding a Hardware Virtual Private Gateway to Your VPC</a> in the
        /// <i>Amazon Virtual Private Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeCustomerGateways service method, as returned by AmazonEC2.</returns>
        /// 
        DescribeCustomerGatewaysResponse DescribeCustomerGateways();
        
        #endregion
        
    

        #region DescribeDhcpOptions

        /// <summary>
        /// <para>Describes one or more of your DHCP options sets.</para> <para>For more information about DHCP options sets, see <a
        /// href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_DHCP_Options.html" >DHCP Options Sets</a> in the <i>Amazon Virtual Private
        /// Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="describeDhcpOptionsRequest">Container for the necessary parameters to execute the DescribeDhcpOptions service method on
        ///          AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeDhcpOptions service method, as returned by AmazonEC2.</returns>
        /// 
        DescribeDhcpOptionsResponse DescribeDhcpOptions(DescribeDhcpOptionsRequest describeDhcpOptionsRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDhcpOptions operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeDhcpOptions"/>
        /// </summary>
        /// 
        /// <param name="describeDhcpOptionsRequest">Container for the necessary parameters to execute the DescribeDhcpOptions operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeDhcpOptions operation.</returns>
        IAsyncResult BeginDescribeDhcpOptions(DescribeDhcpOptionsRequest describeDhcpOptionsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeDhcpOptions operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeDhcpOptions"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDhcpOptions.</param>
        /// 
        /// <returns>Returns a DescribeDhcpOptionsResult from AmazonEC2.</returns>
        DescribeDhcpOptionsResponse EndDescribeDhcpOptions(IAsyncResult asyncResult);

        /// <summary>
        /// <para>Describes one or more of your DHCP options sets.</para> <para>For more information about DHCP options sets, see <a
        /// href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_DHCP_Options.html" >DHCP Options Sets</a> in the <i>Amazon Virtual Private
        /// Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeDhcpOptions service method, as returned by AmazonEC2.</returns>
        /// 
        DescribeDhcpOptionsResponse DescribeDhcpOptions();
        
        #endregion
        
    

        #region DescribeExportTasks

        /// <summary>
        /// <para>Describes one or more of your export tasks.</para>
        /// </summary>
        /// 
        /// <param name="describeExportTasksRequest">Container for the necessary parameters to execute the DescribeExportTasks service method on
        ///          AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeExportTasks service method, as returned by AmazonEC2.</returns>
        /// 
        DescribeExportTasksResponse DescribeExportTasks(DescribeExportTasksRequest describeExportTasksRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeExportTasks operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeExportTasks"/>
        /// </summary>
        /// 
        /// <param name="describeExportTasksRequest">Container for the necessary parameters to execute the DescribeExportTasks operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeExportTasks operation.</returns>
        IAsyncResult BeginDescribeExportTasks(DescribeExportTasksRequest describeExportTasksRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeExportTasks operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeExportTasks"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeExportTasks.</param>
        /// 
        /// <returns>Returns a DescribeExportTasksResult from AmazonEC2.</returns>
        DescribeExportTasksResponse EndDescribeExportTasks(IAsyncResult asyncResult);

        /// <summary>
        /// <para>Describes one or more of your export tasks.</para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeExportTasks service method, as returned by AmazonEC2.</returns>
        /// 
        DescribeExportTasksResponse DescribeExportTasks();
        
        #endregion
        
    

        #region DescribeImageAttribute

        /// <summary>
        /// <para>Describes an attributes of an AMI. You can specify only one attribute at a time.</para>
        /// </summary>
        /// 
        /// <param name="describeImageAttributeRequest">Container for the necessary parameters to execute the DescribeImageAttribute service method on
        ///          AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeImageAttribute service method, as returned by AmazonEC2.</returns>
        /// 
        DescribeImageAttributeResponse DescribeImageAttribute(DescribeImageAttributeRequest describeImageAttributeRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeImageAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeImageAttribute"/>
        /// </summary>
        /// 
        /// <param name="describeImageAttributeRequest">Container for the necessary parameters to execute the DescribeImageAttribute operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeImageAttribute operation.</returns>
        IAsyncResult BeginDescribeImageAttribute(DescribeImageAttributeRequest describeImageAttributeRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeImageAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeImageAttribute"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeImageAttribute.</param>
        /// 
        /// <returns>Returns a DescribeImageAttributeResult from AmazonEC2.</returns>
        DescribeImageAttributeResponse EndDescribeImageAttribute(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DescribeImages

        /// <summary>
        /// <para>Describes one or more of the images (AMIs, AKIs, and ARIs) available to you. Images available to you include public images, private
        /// images that you own, and private images owned by other AWS accounts but for which you have explicit launch permissions.</para>
        /// <para><b>NOTE:</b> Deregistered images are included in the returned results for an unspecified interval after deregistration. </para>
        /// </summary>
        /// 
        /// <param name="describeImagesRequest">Container for the necessary parameters to execute the DescribeImages service method on
        ///          AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeImages service method, as returned by AmazonEC2.</returns>
        /// 
        DescribeImagesResponse DescribeImages(DescribeImagesRequest describeImagesRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeImages operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeImages"/>
        /// </summary>
        /// 
        /// <param name="describeImagesRequest">Container for the necessary parameters to execute the DescribeImages operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeImages
        ///         operation.</returns>
        IAsyncResult BeginDescribeImages(DescribeImagesRequest describeImagesRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeImages operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeImages"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeImages.</param>
        /// 
        /// <returns>Returns a DescribeImagesResult from AmazonEC2.</returns>
        DescribeImagesResponse EndDescribeImages(IAsyncResult asyncResult);

        /// <summary>
        /// <para>Describes one or more of the images (AMIs, AKIs, and ARIs) available to you. Images available to you include public images, private
        /// images that you own, and private images owned by other AWS accounts but for which you have explicit launch permissions.</para>
        /// <para><b>NOTE:</b> Deregistered images are included in the returned results for an unspecified interval after deregistration. </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeImages service method, as returned by AmazonEC2.</returns>
        /// 
        DescribeImagesResponse DescribeImages();
        
        #endregion
        
    

        #region DescribeInstanceAttribute

        /// <summary>
        /// <para>Describes an attribute of the specified instance. You can specify only one attribute at a time.</para>
        /// </summary>
        /// 
        /// <param name="describeInstanceAttributeRequest">Container for the necessary parameters to execute the DescribeInstanceAttribute service
        ///          method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeInstanceAttribute service method, as returned by AmazonEC2.</returns>
        /// 
        DescribeInstanceAttributeResponse DescribeInstanceAttribute(DescribeInstanceAttributeRequest describeInstanceAttributeRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInstanceAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeInstanceAttribute"/>
        /// </summary>
        /// 
        /// <param name="describeInstanceAttributeRequest">Container for the necessary parameters to execute the DescribeInstanceAttribute operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeInstanceAttribute operation.</returns>
        IAsyncResult BeginDescribeInstanceAttribute(DescribeInstanceAttributeRequest describeInstanceAttributeRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeInstanceAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeInstanceAttribute"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeInstanceAttribute.</param>
        /// 
        /// <returns>Returns a DescribeInstanceAttributeResult from AmazonEC2.</returns>
        DescribeInstanceAttributeResponse EndDescribeInstanceAttribute(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DescribeInstanceStatus

        /// <summary>
        /// <para>Describes the status of one or more instances, including any scheduled events.</para> <para>Instance status has two main
        /// components:</para>
        /// <ul>
        /// <li> <para>System Status reports impaired functionality that stems from issues related to the systems that support an instance, such as
        /// such as hardware failures and network connectivity problems. This call reports such problems as impaired reachability.</para> </li>
        /// <li> <para>Instance Status reports impaired functionality that arises from problems internal to the instance. This call reports such
        /// problems as impaired reachability.</para> </li>
        /// 
        /// </ul>
        /// <para>Instance status provides information about four types of scheduled events for an instance that may require your attention:</para>
        /// <ul>
        /// <li> <para>Scheduled Reboot: When Amazon EC2 determines that an instance must be rebooted, the instances status returns one of two event
        /// codes: <c>system-reboot</c> or <c>instance-reboot</c> . System reboot commonly occurs if certain maintenance or upgrade operations require a
        /// reboot of the underlying host that supports an instance. Instance reboot commonly occurs if the instance must be rebooted, rather than the
        /// underlying host. Rebooting events include a scheduled start and end time.</para> </li>
        /// <li> <para>System Maintenance: When Amazon EC2 determines that an instance requires maintenance that requires power or network impact, the
        /// instance status is the event code <c>system-maintenance</c> . System maintenance is either power maintenance or network maintenance. For
        /// power maintenance, your instance will be unavailable for a brief period of time and then rebooted. For network maintenance, your instance
        /// will experience a brief loss of network connectivity. System maintenance events include a scheduled start and end time. You will also be
        /// notified by email if one of your instances is set for system maintenance. The email message indicates when your instance is scheduled for
        /// maintenance.</para> </li>
        /// <li> <para>Scheduled Retirement: When Amazon EC2 determines that an instance must be shut down, the instance status is the event code
        /// <c>instance-retirement</c> . Retirement commonly occurs when the underlying host is degraded and must be replaced. Retirement events include
        /// a scheduled start and end time. You will also be notified by email if one of your instances is set to retiring. The email message indicates
        /// when your instance will be permanently retired.</para> </li>
        /// <li> <para>Scheduled Stop: When Amazon EC2 determines that an instance must be shut down, the instances status returns an event code called
        /// <c>instance-stop</c> .
        /// Stop events include a scheduled start and end time. You will also be notified by email if one of your instances is set to stop. The
        /// email message indicates when your instance will be stopped.</para> </li>
        /// 
        /// </ul>
        /// <para>When your instance is retired, it will either be terminated (if its root device type is the instance-store) or stopped (if its root
        /// device type is an EBS volume). Instances stopped due to retirement will not be restarted, but you can do so manually. You can also avoid
        /// retirement of EBS-backed instances by manually restarting your instance when its event code is <c>instance-retirement</c> . This ensures
        /// that your instance is started on a different underlying host.</para>
        /// </summary>
        /// 
        /// <param name="describeInstanceStatusRequest">Container for the necessary parameters to execute the DescribeInstanceStatus service method on
        ///          AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeInstanceStatus service method, as returned by AmazonEC2.</returns>
        /// 
        DescribeInstanceStatusResponse DescribeInstanceStatus(DescribeInstanceStatusRequest describeInstanceStatusRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInstanceStatus operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeInstanceStatus"/>
        /// </summary>
        /// 
        /// <param name="describeInstanceStatusRequest">Container for the necessary parameters to execute the DescribeInstanceStatus operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeInstanceStatus operation.</returns>
        IAsyncResult BeginDescribeInstanceStatus(DescribeInstanceStatusRequest describeInstanceStatusRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeInstanceStatus operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeInstanceStatus"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeInstanceStatus.</param>
        /// 
        /// <returns>Returns a DescribeInstanceStatusResult from AmazonEC2.</returns>
        DescribeInstanceStatusResponse EndDescribeInstanceStatus(IAsyncResult asyncResult);

        /// <summary>
        /// <para>Describes the status of one or more instances, including any scheduled events.</para> <para>Instance status has two main
        /// components:</para>
        /// <ul>
        /// <li> <para>System Status reports impaired functionality that stems from issues related to the systems that support an instance, such as
        /// such as hardware failures and network connectivity problems. This call reports such problems as impaired reachability.</para> </li>
        /// <li> <para>Instance Status reports impaired functionality that arises from problems internal to the instance. This call reports such
        /// problems as impaired reachability.</para> </li>
        /// 
        /// </ul>
        /// <para>Instance status provides information about four types of scheduled events for an instance that may require your attention:</para>
        /// <ul>
        /// <li> <para>Scheduled Reboot: When Amazon EC2 determines that an instance must be rebooted, the instances status returns one of two event
        /// codes: <c>system-reboot</c> or <c>instance-reboot</c> . System reboot commonly occurs if certain maintenance or upgrade operations require a
        /// reboot of the underlying host that supports an instance. Instance reboot commonly occurs if the instance must be rebooted, rather than the
        /// underlying host. Rebooting events include a scheduled start and end time.</para> </li>
        /// <li> <para>System Maintenance: When Amazon EC2 determines that an instance requires maintenance that requires power or network impact, the
        /// instance status is the event code <c>system-maintenance</c> . System maintenance is either power maintenance or network maintenance. For
        /// power maintenance, your instance will be unavailable for a brief period of time and then rebooted. For network maintenance, your instance
        /// will experience a brief loss of network connectivity. System maintenance events include a scheduled start and end time. You will also be
        /// notified by email if one of your instances is set for system maintenance. The email message indicates when your instance is scheduled for
        /// maintenance.</para> </li>
        /// <li> <para>Scheduled Retirement: When Amazon EC2 determines that an instance must be shut down, the instance status is the event code
        /// <c>instance-retirement</c> . Retirement commonly occurs when the underlying host is degraded and must be replaced. Retirement events include
        /// a scheduled start and end time. You will also be notified by email if one of your instances is set to retiring. The email message indicates
        /// when your instance will be permanently retired.</para> </li>
        /// <li> <para>Scheduled Stop: When Amazon EC2 determines that an instance must be shut down, the instances status returns an event code called
        /// <c>instance-stop</c> .
        /// Stop events include a scheduled start and end time. You will also be notified by email if one of your instances is set to stop. The
        /// email message indicates when your instance will be stopped.</para> </li>
        /// 
        /// </ul>
        /// <para>When your instance is retired, it will either be terminated (if its root device type is the instance-store) or stopped (if its root
        /// device type is an EBS volume). Instances stopped due to retirement will not be restarted, but you can do so manually. You can also avoid
        /// retirement of EBS-backed instances by manually restarting your instance when its event code is <c>instance-retirement</c> . This ensures
        /// that your instance is started on a different underlying host.</para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeInstanceStatus service method, as returned by AmazonEC2.</returns>
        /// 
        DescribeInstanceStatusResponse DescribeInstanceStatus();
        
        #endregion
        
    

        #region DescribeInstances

        /// <summary>
        /// <para>Describes one or more of your instances.</para> <para>If you specify one or more instance IDs, Amazon EC2 returns information for
        /// those instances. If you do not specify instance IDs, Amazon EC2 returns information for all relevant instances. If you specify an instance
        /// ID that is not valid, an error is returned. If you specify an instance that you do not own, it is not included in the returned
        /// results.</para> <para>Recently terminated instances might appear in the returned results. This interval is usually less than one
        /// hour.</para>
        /// </summary>
        /// 
        /// <param name="describeInstancesRequest">Container for the necessary parameters to execute the DescribeInstances service method on
        ///          AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeInstances service method, as returned by AmazonEC2.</returns>
        /// 
        DescribeInstancesResponse DescribeInstances(DescribeInstancesRequest describeInstancesRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInstances operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeInstances"/>
        /// </summary>
        /// 
        /// <param name="describeInstancesRequest">Container for the necessary parameters to execute the DescribeInstances operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeInstances
        ///         operation.</returns>
        IAsyncResult BeginDescribeInstances(DescribeInstancesRequest describeInstancesRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeInstances operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeInstances"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeInstances.</param>
        /// 
        /// <returns>Returns a DescribeInstancesResult from AmazonEC2.</returns>
        DescribeInstancesResponse EndDescribeInstances(IAsyncResult asyncResult);

        /// <summary>
        /// <para>Describes one or more of your instances.</para> <para>If you specify one or more instance IDs, Amazon EC2 returns information for
        /// those instances. If you do not specify instance IDs, Amazon EC2 returns information for all relevant instances. If you specify an instance
        /// ID that is not valid, an error is returned. If you specify an instance that you do not own, it is not included in the returned
        /// results.</para> <para>Recently terminated instances might appear in the returned results. This interval is usually less than one
        /// hour.</para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeInstances service method, as returned by AmazonEC2.</returns>
        /// 
        DescribeInstancesResponse DescribeInstances();
        
        #endregion
        
    

        #region DescribeInternetGateways

        /// <summary>
        /// <para>Describes one or more of your Internet gateways.</para>
        /// </summary>
        /// 
        /// <param name="describeInternetGatewaysRequest">Container for the necessary parameters to execute the DescribeInternetGateways service method
        ///          on AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeInternetGateways service method, as returned by AmazonEC2.</returns>
        /// 
        DescribeInternetGatewaysResponse DescribeInternetGateways(DescribeInternetGatewaysRequest describeInternetGatewaysRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInternetGateways operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeInternetGateways"/>
        /// </summary>
        /// 
        /// <param name="describeInternetGatewaysRequest">Container for the necessary parameters to execute the DescribeInternetGateways operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeInternetGateways operation.</returns>
        IAsyncResult BeginDescribeInternetGateways(DescribeInternetGatewaysRequest describeInternetGatewaysRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeInternetGateways operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeInternetGateways"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeInternetGateways.</param>
        /// 
        /// <returns>Returns a DescribeInternetGatewaysResult from AmazonEC2.</returns>
        DescribeInternetGatewaysResponse EndDescribeInternetGateways(IAsyncResult asyncResult);

        /// <summary>
        /// <para>Describes one or more of your Internet gateways.</para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeInternetGateways service method, as returned by AmazonEC2.</returns>
        /// 
        DescribeInternetGatewaysResponse DescribeInternetGateways();
        
        #endregion
        
    

        #region DescribeKeyPairs

        /// <summary>
        /// <para>Describes one or more of your key pairs.</para> <para>For more information about key pairs, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-key-pairs.html" >Key Pairs</a> in the <i>Amazon Elastic Compute Cloud User
        /// Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="describeKeyPairsRequest">Container for the necessary parameters to execute the DescribeKeyPairs service method on
        ///          AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeKeyPairs service method, as returned by AmazonEC2.</returns>
        /// 
        DescribeKeyPairsResponse DescribeKeyPairs(DescribeKeyPairsRequest describeKeyPairsRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeKeyPairs operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeKeyPairs"/>
        /// </summary>
        /// 
        /// <param name="describeKeyPairsRequest">Container for the necessary parameters to execute the DescribeKeyPairs operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeKeyPairs
        ///         operation.</returns>
        IAsyncResult BeginDescribeKeyPairs(DescribeKeyPairsRequest describeKeyPairsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeKeyPairs operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeKeyPairs"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeKeyPairs.</param>
        /// 
        /// <returns>Returns a DescribeKeyPairsResult from AmazonEC2.</returns>
        DescribeKeyPairsResponse EndDescribeKeyPairs(IAsyncResult asyncResult);

        /// <summary>
        /// <para>Describes one or more of your key pairs.</para> <para>For more information about key pairs, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-key-pairs.html" >Key Pairs</a> in the <i>Amazon Elastic Compute Cloud User
        /// Guide</i> .</para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeKeyPairs service method, as returned by AmazonEC2.</returns>
        /// 
        DescribeKeyPairsResponse DescribeKeyPairs();
        
        #endregion
        
    

        #region DescribeNetworkAcls

        /// <summary>
        /// <para>Describes one or more of your network ACLs.</para> <para>For more information about network ACLs, see <a
        /// href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_ACLs.html" >Network ACLs</a> in the <i>Amazon Virtual Private Cloud User
        /// Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="describeNetworkAclsRequest">Container for the necessary parameters to execute the DescribeNetworkAcls service method on
        ///          AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeNetworkAcls service method, as returned by AmazonEC2.</returns>
        /// 
        DescribeNetworkAclsResponse DescribeNetworkAcls(DescribeNetworkAclsRequest describeNetworkAclsRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeNetworkAcls operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeNetworkAcls"/>
        /// </summary>
        /// 
        /// <param name="describeNetworkAclsRequest">Container for the necessary parameters to execute the DescribeNetworkAcls operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeNetworkAcls operation.</returns>
        IAsyncResult BeginDescribeNetworkAcls(DescribeNetworkAclsRequest describeNetworkAclsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeNetworkAcls operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeNetworkAcls"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeNetworkAcls.</param>
        /// 
        /// <returns>Returns a DescribeNetworkAclsResult from AmazonEC2.</returns>
        DescribeNetworkAclsResponse EndDescribeNetworkAcls(IAsyncResult asyncResult);

        /// <summary>
        /// <para>Describes one or more of your network ACLs.</para> <para>For more information about network ACLs, see <a
        /// href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_ACLs.html" >Network ACLs</a> in the <i>Amazon Virtual Private Cloud User
        /// Guide</i> .</para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeNetworkAcls service method, as returned by AmazonEC2.</returns>
        /// 
        DescribeNetworkAclsResponse DescribeNetworkAcls();
        
        #endregion
        
    

        #region DescribeNetworkInterfaceAttribute

        /// <summary>
        /// <para>Describes a network interface attribute. You can specify only one attribute at a time.</para>
        /// </summary>
        /// 
        /// <param name="describeNetworkInterfaceAttributeRequest">Container for the necessary parameters to execute the
        ///          DescribeNetworkInterfaceAttribute service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeNetworkInterfaceAttribute service method, as returned by AmazonEC2.</returns>
        /// 
        DescribeNetworkInterfaceAttributeResponse DescribeNetworkInterfaceAttribute(DescribeNetworkInterfaceAttributeRequest describeNetworkInterfaceAttributeRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeNetworkInterfaceAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeNetworkInterfaceAttribute"/>
        /// </summary>
        /// 
        /// <param name="describeNetworkInterfaceAttributeRequest">Container for the necessary parameters to execute the
        ///          DescribeNetworkInterfaceAttribute operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeNetworkInterfaceAttribute operation.</returns>
        IAsyncResult BeginDescribeNetworkInterfaceAttribute(DescribeNetworkInterfaceAttributeRequest describeNetworkInterfaceAttributeRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeNetworkInterfaceAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeNetworkInterfaceAttribute"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeNetworkInterfaceAttribute.</param>
        /// 
        /// <returns>Returns a DescribeNetworkInterfaceAttributeResult from AmazonEC2.</returns>
        DescribeNetworkInterfaceAttributeResponse EndDescribeNetworkInterfaceAttribute(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DescribeNetworkInterfaces

        /// <summary>
        /// <para>Describes one or more of your network interfaces.</para>
        /// </summary>
        /// 
        /// <param name="describeNetworkInterfacesRequest">Container for the necessary parameters to execute the DescribeNetworkInterfaces service
        ///          method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeNetworkInterfaces service method, as returned by AmazonEC2.</returns>
        /// 
        DescribeNetworkInterfacesResponse DescribeNetworkInterfaces(DescribeNetworkInterfacesRequest describeNetworkInterfacesRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeNetworkInterfaces operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeNetworkInterfaces"/>
        /// </summary>
        /// 
        /// <param name="describeNetworkInterfacesRequest">Container for the necessary parameters to execute the DescribeNetworkInterfaces operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeNetworkInterfaces operation.</returns>
        IAsyncResult BeginDescribeNetworkInterfaces(DescribeNetworkInterfacesRequest describeNetworkInterfacesRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeNetworkInterfaces operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeNetworkInterfaces"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeNetworkInterfaces.</param>
        /// 
        /// <returns>Returns a DescribeNetworkInterfacesResult from AmazonEC2.</returns>
        DescribeNetworkInterfacesResponse EndDescribeNetworkInterfaces(IAsyncResult asyncResult);

        /// <summary>
        /// <para>Describes one or more of your network interfaces.</para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeNetworkInterfaces service method, as returned by AmazonEC2.</returns>
        /// 
        DescribeNetworkInterfacesResponse DescribeNetworkInterfaces();
        
        #endregion
        
    

        #region DescribePlacementGroups

        /// <summary>
        /// <para>Describes one or more of your placement groups. For more information about placement groups and cluster instances, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using_cluster_computing.html" >Cluster Instances</a> in the <i>Amazon Elastic
        /// Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="describePlacementGroupsRequest">Container for the necessary parameters to execute the DescribePlacementGroups service method on
        ///          AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribePlacementGroups service method, as returned by AmazonEC2.</returns>
        /// 
        DescribePlacementGroupsResponse DescribePlacementGroups(DescribePlacementGroupsRequest describePlacementGroupsRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribePlacementGroups operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribePlacementGroups"/>
        /// </summary>
        /// 
        /// <param name="describePlacementGroupsRequest">Container for the necessary parameters to execute the DescribePlacementGroups operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribePlacementGroups operation.</returns>
        IAsyncResult BeginDescribePlacementGroups(DescribePlacementGroupsRequest describePlacementGroupsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribePlacementGroups operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribePlacementGroups"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribePlacementGroups.</param>
        /// 
        /// <returns>Returns a DescribePlacementGroupsResult from AmazonEC2.</returns>
        DescribePlacementGroupsResponse EndDescribePlacementGroups(IAsyncResult asyncResult);

        /// <summary>
        /// <para>Describes one or more of your placement groups. For more information about placement groups and cluster instances, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using_cluster_computing.html" >Cluster Instances</a> in the <i>Amazon Elastic
        /// Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribePlacementGroups service method, as returned by AmazonEC2.</returns>
        /// 
        DescribePlacementGroupsResponse DescribePlacementGroups();
        
        #endregion
        
    

        #region DescribeRegions

        /// <summary>
        /// <para>Describes one or more regions that are currently available to you.</para> <para>For a list of the regions supported by Amazon EC2, see
        /// <a href="http://docs.aws.amazon.com/general/latest/gr/rande.html#ec2_region" >Regions and Endpoints</a> .</para>
        /// </summary>
        /// 
        /// <param name="describeRegionsRequest">Container for the necessary parameters to execute the DescribeRegions service method on
        ///          AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeRegions service method, as returned by AmazonEC2.</returns>
        /// 
        DescribeRegionsResponse DescribeRegions(DescribeRegionsRequest describeRegionsRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRegions operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeRegions"/>
        /// </summary>
        /// 
        /// <param name="describeRegionsRequest">Container for the necessary parameters to execute the DescribeRegions operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeRegions
        ///         operation.</returns>
        IAsyncResult BeginDescribeRegions(DescribeRegionsRequest describeRegionsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeRegions operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeRegions"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeRegions.</param>
        /// 
        /// <returns>Returns a DescribeRegionsResult from AmazonEC2.</returns>
        DescribeRegionsResponse EndDescribeRegions(IAsyncResult asyncResult);

        /// <summary>
        /// <para>Describes one or more regions that are currently available to you.</para> <para>For a list of the regions supported by Amazon EC2, see
        /// <a href="http://docs.aws.amazon.com/general/latest/gr/rande.html#ec2_region" >Regions and Endpoints</a> .</para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeRegions service method, as returned by AmazonEC2.</returns>
        /// 
        DescribeRegionsResponse DescribeRegions();
        
        #endregion
        
    

        #region DescribeReservedInstances

        /// <summary>
        /// <para>Describes one or more of the Reserved Instances that you purchased.</para> <para>For more information about Reserved Instances, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/concepts-on-demand-reserved-instances.html" >Reserved Instances</a> in the
        /// <i>Amazon Elastic Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="describeReservedInstancesRequest">Container for the necessary parameters to execute the DescribeReservedInstances service
        ///          method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeReservedInstances service method, as returned by AmazonEC2.</returns>
        /// 
        DescribeReservedInstancesResponse DescribeReservedInstances(DescribeReservedInstancesRequest describeReservedInstancesRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReservedInstances operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeReservedInstances"/>
        /// </summary>
        /// 
        /// <param name="describeReservedInstancesRequest">Container for the necessary parameters to execute the DescribeReservedInstances operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeReservedInstances operation.</returns>
        IAsyncResult BeginDescribeReservedInstances(DescribeReservedInstancesRequest describeReservedInstancesRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeReservedInstances operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeReservedInstances"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeReservedInstances.</param>
        /// 
        /// <returns>Returns a DescribeReservedInstancesResult from AmazonEC2.</returns>
        DescribeReservedInstancesResponse EndDescribeReservedInstances(IAsyncResult asyncResult);

        /// <summary>
        /// <para>Describes one or more of the Reserved Instances that you purchased.</para> <para>For more information about Reserved Instances, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/concepts-on-demand-reserved-instances.html" >Reserved Instances</a> in the
        /// <i>Amazon Elastic Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeReservedInstances service method, as returned by AmazonEC2.</returns>
        /// 
        DescribeReservedInstancesResponse DescribeReservedInstances();
        
        #endregion
        
    

        #region DescribeReservedInstancesListings

        /// <summary>
        /// <para>Describes your account's Reserved Instance listings in the Reserved Instance Marketplace.</para> <para>For more information, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ri-market-general.html" >Reserved Instance Marketplace</a> in the <i>Amazon Elastic
        /// Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="describeReservedInstancesListingsRequest">Container for the necessary parameters to execute the
        ///          DescribeReservedInstancesListings service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeReservedInstancesListings service method, as returned by AmazonEC2.</returns>
        /// 
        DescribeReservedInstancesListingsResponse DescribeReservedInstancesListings(DescribeReservedInstancesListingsRequest describeReservedInstancesListingsRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReservedInstancesListings operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeReservedInstancesListings"/>
        /// </summary>
        /// 
        /// <param name="describeReservedInstancesListingsRequest">Container for the necessary parameters to execute the
        ///          DescribeReservedInstancesListings operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeReservedInstancesListings operation.</returns>
        IAsyncResult BeginDescribeReservedInstancesListings(DescribeReservedInstancesListingsRequest describeReservedInstancesListingsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeReservedInstancesListings operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeReservedInstancesListings"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeReservedInstancesListings.</param>
        /// 
        /// <returns>Returns a DescribeReservedInstancesListingsResult from AmazonEC2.</returns>
        DescribeReservedInstancesListingsResponse EndDescribeReservedInstancesListings(IAsyncResult asyncResult);

        /// <summary>
        /// <para>Describes your account's Reserved Instance listings in the Reserved Instance Marketplace.</para> <para>For more information, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ri-market-general.html" >Reserved Instance Marketplace</a> in the <i>Amazon Elastic
        /// Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeReservedInstancesListings service method, as returned by AmazonEC2.</returns>
        /// 
        DescribeReservedInstancesListingsResponse DescribeReservedInstancesListings();
        
        #endregion
        
    

        #region DescribeReservedInstancesModifications

        /// <summary>
        /// <para>Describes the modifications made to your Reserved Instances. If no parameter is specified, information about all your Reserved
        /// Instances modification requests is returned. If a modification ID is specified, only information about the specific modification is
        /// returned.</para>
        /// </summary>
        /// 
        /// <param name="describeReservedInstancesModificationsRequest">Container for the necessary parameters to execute the
        ///          DescribeReservedInstancesModifications service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeReservedInstancesModifications service method, as returned by AmazonEC2.</returns>
        /// 
        DescribeReservedInstancesModificationsResponse DescribeReservedInstancesModifications(DescribeReservedInstancesModificationsRequest describeReservedInstancesModificationsRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReservedInstancesModifications operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeReservedInstancesModifications"/>
        /// </summary>
        /// 
        /// <param name="describeReservedInstancesModificationsRequest">Container for the necessary parameters to execute the
        ///          DescribeReservedInstancesModifications operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeReservedInstancesModifications operation.</returns>
        IAsyncResult BeginDescribeReservedInstancesModifications(DescribeReservedInstancesModificationsRequest describeReservedInstancesModificationsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeReservedInstancesModifications operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeReservedInstancesModifications"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeReservedInstancesModifications.</param>
        /// 
        /// <returns>Returns a DescribeReservedInstancesModificationsResult from AmazonEC2.</returns>
        DescribeReservedInstancesModificationsResponse EndDescribeReservedInstancesModifications(IAsyncResult asyncResult);

        /// <summary>
        /// <para>Describes the modifications made to your Reserved Instances. If no parameter is specified, information about all your Reserved
        /// Instances modification requests is returned. If a modification ID is specified, only information about the specific modification is
        /// returned.</para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeReservedInstancesModifications service method, as returned by AmazonEC2.</returns>
        /// 
        DescribeReservedInstancesModificationsResponse DescribeReservedInstancesModifications();
        
        #endregion
        
    

        #region DescribeReservedInstancesOfferings

        /// <summary>
        /// <para>Describes Reserved Instance offerings that are available for purchase. With Reserved Instances, you purchase the right to launch
        /// instances for a period of time. During that time period, you do not receive insufficient capacity errors, and you pay a lower usage rate
        /// than the rate charged for On-Demand instances for the actual time used.</para> <para>For more information, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ri-market-general.html" >Reserved Instance Marketplace</a> in the <i>Amazon Elastic
        /// Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="describeReservedInstancesOfferingsRequest">Container for the necessary parameters to execute the
        ///          DescribeReservedInstancesOfferings service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeReservedInstancesOfferings service method, as returned by AmazonEC2.</returns>
        /// 
        DescribeReservedInstancesOfferingsResponse DescribeReservedInstancesOfferings(DescribeReservedInstancesOfferingsRequest describeReservedInstancesOfferingsRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReservedInstancesOfferings operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeReservedInstancesOfferings"/>
        /// </summary>
        /// 
        /// <param name="describeReservedInstancesOfferingsRequest">Container for the necessary parameters to execute the
        ///          DescribeReservedInstancesOfferings operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeReservedInstancesOfferings operation.</returns>
        IAsyncResult BeginDescribeReservedInstancesOfferings(DescribeReservedInstancesOfferingsRequest describeReservedInstancesOfferingsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeReservedInstancesOfferings operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeReservedInstancesOfferings"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeReservedInstancesOfferings.</param>
        /// 
        /// <returns>Returns a DescribeReservedInstancesOfferingsResult from AmazonEC2.</returns>
        DescribeReservedInstancesOfferingsResponse EndDescribeReservedInstancesOfferings(IAsyncResult asyncResult);

        /// <summary>
        /// <para>Describes Reserved Instance offerings that are available for purchase. With Reserved Instances, you purchase the right to launch
        /// instances for a period of time. During that time period, you do not receive insufficient capacity errors, and you pay a lower usage rate
        /// than the rate charged for On-Demand instances for the actual time used.</para> <para>For more information, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ri-market-general.html" >Reserved Instance Marketplace</a> in the <i>Amazon Elastic
        /// Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeReservedInstancesOfferings service method, as returned by AmazonEC2.</returns>
        /// 
        DescribeReservedInstancesOfferingsResponse DescribeReservedInstancesOfferings();
        
        #endregion
        
    

        #region DescribeRouteTables

        /// <summary>
        /// <para>Describes one or more of your route tables.</para> <para>For more information about route tables, see <a
        /// href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Route_Tables.html" >Route Tables</a> in the <i>Amazon Virtual Private Cloud
        /// User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="describeRouteTablesRequest">Container for the necessary parameters to execute the DescribeRouteTables service method on
        ///          AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeRouteTables service method, as returned by AmazonEC2.</returns>
        /// 
        DescribeRouteTablesResponse DescribeRouteTables(DescribeRouteTablesRequest describeRouteTablesRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRouteTables operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeRouteTables"/>
        /// </summary>
        /// 
        /// <param name="describeRouteTablesRequest">Container for the necessary parameters to execute the DescribeRouteTables operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeRouteTables operation.</returns>
        IAsyncResult BeginDescribeRouteTables(DescribeRouteTablesRequest describeRouteTablesRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeRouteTables operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeRouteTables"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeRouteTables.</param>
        /// 
        /// <returns>Returns a DescribeRouteTablesResult from AmazonEC2.</returns>
        DescribeRouteTablesResponse EndDescribeRouteTables(IAsyncResult asyncResult);

        /// <summary>
        /// <para>Describes one or more of your route tables.</para> <para>For more information about route tables, see <a
        /// href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Route_Tables.html" >Route Tables</a> in the <i>Amazon Virtual Private Cloud
        /// User Guide</i> .</para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeRouteTables service method, as returned by AmazonEC2.</returns>
        /// 
        DescribeRouteTablesResponse DescribeRouteTables();
        
        #endregion
        
    

        #region DescribeSecurityGroups

        /// <summary>
        /// <para>Describes one or more of your security groups.</para> <para>A security group is for use with instances either in the EC2-Classic
        /// platform or in a specific VPC. For more information, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-network-security.html" >Amazon EC2 Security Groups</a> in the <i>Amazon
        /// Elastic Compute Cloud User Guide</i> and <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_SecurityGroups.html" >Security
        /// Groups for Your VPC</a> in the <i>Amazon Virtual Private Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="describeSecurityGroupsRequest">Container for the necessary parameters to execute the DescribeSecurityGroups service method on
        ///          AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeSecurityGroups service method, as returned by AmazonEC2.</returns>
        /// 
        DescribeSecurityGroupsResponse DescribeSecurityGroups(DescribeSecurityGroupsRequest describeSecurityGroupsRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSecurityGroups operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeSecurityGroups"/>
        /// </summary>
        /// 
        /// <param name="describeSecurityGroupsRequest">Container for the necessary parameters to execute the DescribeSecurityGroups operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeSecurityGroups operation.</returns>
        IAsyncResult BeginDescribeSecurityGroups(DescribeSecurityGroupsRequest describeSecurityGroupsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeSecurityGroups operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeSecurityGroups"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSecurityGroups.</param>
        /// 
        /// <returns>Returns a DescribeSecurityGroupsResult from AmazonEC2.</returns>
        DescribeSecurityGroupsResponse EndDescribeSecurityGroups(IAsyncResult asyncResult);

        /// <summary>
        /// <para>Describes one or more of your security groups.</para> <para>A security group is for use with instances either in the EC2-Classic
        /// platform or in a specific VPC. For more information, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-network-security.html" >Amazon EC2 Security Groups</a> in the <i>Amazon
        /// Elastic Compute Cloud User Guide</i> and <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_SecurityGroups.html" >Security
        /// Groups for Your VPC</a> in the <i>Amazon Virtual Private Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeSecurityGroups service method, as returned by AmazonEC2.</returns>
        /// 
        DescribeSecurityGroupsResponse DescribeSecurityGroups();
        
        #endregion
        
    

        #region DescribeSnapshotAttribute

        /// <summary>
        /// <para>Describes an attribute of the specified snapshot. You can specify only one attribute at a time.</para> <para>For more information
        /// about Amazon EBS snapshots, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSSnapshots.html" >Amazon EBS Snapshots</a> in
        /// the <i>Amazon Elastic Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="describeSnapshotAttributeRequest">Container for the necessary parameters to execute the DescribeSnapshotAttribute service
        ///          method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeSnapshotAttribute service method, as returned by AmazonEC2.</returns>
        /// 
        DescribeSnapshotAttributeResponse DescribeSnapshotAttribute(DescribeSnapshotAttributeRequest describeSnapshotAttributeRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSnapshotAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeSnapshotAttribute"/>
        /// </summary>
        /// 
        /// <param name="describeSnapshotAttributeRequest">Container for the necessary parameters to execute the DescribeSnapshotAttribute operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeSnapshotAttribute operation.</returns>
        IAsyncResult BeginDescribeSnapshotAttribute(DescribeSnapshotAttributeRequest describeSnapshotAttributeRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeSnapshotAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeSnapshotAttribute"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSnapshotAttribute.</param>
        /// 
        /// <returns>Returns a DescribeSnapshotAttributeResult from AmazonEC2.</returns>
        DescribeSnapshotAttributeResponse EndDescribeSnapshotAttribute(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DescribeSnapshots

        /// <summary>
        /// <para>Describes one or more of the Amazon EBS snapshots available to you. Available snapshots include public snapshots available for any AWS
        /// account to launch, private snapshots that you own, and private snapshots owned by another AWS account but for which you've been given
        /// explicit create volume permissions.</para> <para>The create volume permissions fall into the following categories:</para>
        /// <ul>
        /// <li> <i>public</i> : The owner of the snapshot granted create volume permissions for the snapshot to the <c>all</c> group. All AWS accounts
        /// have create volume permissions for these snapshots.</li>
        /// <li> <i>explicit</i> : The owner of the snapshot granted create volume permissions to a specific AWS account.</li>
        /// <li> <i>implicit</i> : An AWS account has implicit create volume permissions for all snapshots it owns.</li>
        /// 
        /// </ul>
        /// <para>The list of snapshots returned can be modified by specifying snapshot IDs, snapshot owners, or AWS accounts with create volume
        /// permissions. If no options are specified, Amazon EC2 returns all snapshots for which you have create volume permissions.</para> <para>If you
        /// specify one or more snapshot IDs, only snapshots that have the specified IDs are returned. If you specify an invalid snapshot ID, an error
        /// is returned. If you specify a snapshot ID for which you do not have access, it is not included in the returned results.</para> <para>If you
        /// specify one or more snapshot owners, only snapshots from the specified owners and for which you have access are returned. The results can
        /// include the AWS account IDs of the specified owners, <c>amazon</c> for snapshots owned by Amazon, or <c>self</c> for snapshots that you
        /// own.</para> <para>If you specify a list of restorable users, only snapshots with create snapshot permissions for those users are returned.
        /// You can specify AWS account IDs (if you own the snapshots), <c>self</c> for snapshots for which you own or have explicit permissions, or
        /// <c>all</c> for public snapshots.</para> <para>For more information about Amazon EBS snapshots, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSSnapshots.html" >Amazon EBS Snapshots</a> in the <i>Amazon Elastic Compute Cloud
        /// User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="describeSnapshotsRequest">Container for the necessary parameters to execute the DescribeSnapshots service method on
        ///          AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeSnapshots service method, as returned by AmazonEC2.</returns>
        /// 
        DescribeSnapshotsResponse DescribeSnapshots(DescribeSnapshotsRequest describeSnapshotsRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSnapshots operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeSnapshots"/>
        /// </summary>
        /// 
        /// <param name="describeSnapshotsRequest">Container for the necessary parameters to execute the DescribeSnapshots operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSnapshots
        ///         operation.</returns>
        IAsyncResult BeginDescribeSnapshots(DescribeSnapshotsRequest describeSnapshotsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeSnapshots operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeSnapshots"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSnapshots.</param>
        /// 
        /// <returns>Returns a DescribeSnapshotsResult from AmazonEC2.</returns>
        DescribeSnapshotsResponse EndDescribeSnapshots(IAsyncResult asyncResult);

        /// <summary>
        /// <para>Describes one or more of the Amazon EBS snapshots available to you. Available snapshots include public snapshots available for any AWS
        /// account to launch, private snapshots that you own, and private snapshots owned by another AWS account but for which you've been given
        /// explicit create volume permissions.</para> <para>The create volume permissions fall into the following categories:</para>
        /// <ul>
        /// <li> <i>public</i> : The owner of the snapshot granted create volume permissions for the snapshot to the <c>all</c> group. All AWS accounts
        /// have create volume permissions for these snapshots.</li>
        /// <li> <i>explicit</i> : The owner of the snapshot granted create volume permissions to a specific AWS account.</li>
        /// <li> <i>implicit</i> : An AWS account has implicit create volume permissions for all snapshots it owns.</li>
        /// 
        /// </ul>
        /// <para>The list of snapshots returned can be modified by specifying snapshot IDs, snapshot owners, or AWS accounts with create volume
        /// permissions. If no options are specified, Amazon EC2 returns all snapshots for which you have create volume permissions.</para> <para>If you
        /// specify one or more snapshot IDs, only snapshots that have the specified IDs are returned. If you specify an invalid snapshot ID, an error
        /// is returned. If you specify a snapshot ID for which you do not have access, it is not included in the returned results.</para> <para>If you
        /// specify one or more snapshot owners, only snapshots from the specified owners and for which you have access are returned. The results can
        /// include the AWS account IDs of the specified owners, <c>amazon</c> for snapshots owned by Amazon, or <c>self</c> for snapshots that you
        /// own.</para> <para>If you specify a list of restorable users, only snapshots with create snapshot permissions for those users are returned.
        /// You can specify AWS account IDs (if you own the snapshots), <c>self</c> for snapshots for which you own or have explicit permissions, or
        /// <c>all</c> for public snapshots.</para> <para>For more information about Amazon EBS snapshots, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSSnapshots.html" >Amazon EBS Snapshots</a> in the <i>Amazon Elastic Compute Cloud
        /// User Guide</i> .</para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeSnapshots service method, as returned by AmazonEC2.</returns>
        /// 
        DescribeSnapshotsResponse DescribeSnapshots();
        
        #endregion
        
    

        #region DescribeSpotDatafeedSubscription

        /// <summary>
        /// <para>Describes the datafeed for Spot Instances. For more information, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-spot-instances.html" >Spot Instances</a> in the <i>Amazon Elastic Compute
        /// Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="describeSpotDatafeedSubscriptionRequest">Container for the necessary parameters to execute the DescribeSpotDatafeedSubscription
        ///          service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeSpotDatafeedSubscription service method, as returned by AmazonEC2.</returns>
        /// 
        DescribeSpotDatafeedSubscriptionResponse DescribeSpotDatafeedSubscription(DescribeSpotDatafeedSubscriptionRequest describeSpotDatafeedSubscriptionRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSpotDatafeedSubscription operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeSpotDatafeedSubscription"/>
        /// </summary>
        /// 
        /// <param name="describeSpotDatafeedSubscriptionRequest">Container for the necessary parameters to execute the DescribeSpotDatafeedSubscription
        ///          operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeSpotDatafeedSubscription operation.</returns>
        IAsyncResult BeginDescribeSpotDatafeedSubscription(DescribeSpotDatafeedSubscriptionRequest describeSpotDatafeedSubscriptionRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeSpotDatafeedSubscription operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeSpotDatafeedSubscription"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSpotDatafeedSubscription.</param>
        /// 
        /// <returns>Returns a DescribeSpotDatafeedSubscriptionResult from AmazonEC2.</returns>
        DescribeSpotDatafeedSubscriptionResponse EndDescribeSpotDatafeedSubscription(IAsyncResult asyncResult);

        /// <summary>
        /// <para>Describes the datafeed for Spot Instances. For more information, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-spot-instances.html" >Spot Instances</a> in the <i>Amazon Elastic Compute
        /// Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeSpotDatafeedSubscription service method, as returned by AmazonEC2.</returns>
        /// 
        DescribeSpotDatafeedSubscriptionResponse DescribeSpotDatafeedSubscription();
        
        #endregion
        
    

        #region DescribeSpotInstanceRequests

        /// <summary>
        /// <para>Describes the Spot Instance requests that belong to your account. Spot Instances are instances that Amazon EC2 starts on your behalf
        /// when the maximum price that you specify exceeds the current Spot Price. Amazon EC2 periodically sets the Spot Price based on available Spot
        /// Instance capacity and current Spot Instance requests. For more information about Spot Instances, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-spot-instances.html" >Spot Instances</a> in the <i>Amazon Elastic Compute
        /// Cloud User Guide</i> .</para> <para>You can use <c>DescribeSpotInstanceRequests</c> to find a running Spot Instance by examining the
        /// response. If the status of the Spot Instance is <c>fulfilled</c> , the instance ID appears in the response and contains the identifier of
        /// the instance. Alternatively, you can use DescribeInstances with a filter to look for instances where the instance lifecycle is <c>spot</c>
        /// .</para>
        /// </summary>
        /// 
        /// <param name="describeSpotInstanceRequestsRequest">Container for the necessary parameters to execute the DescribeSpotInstanceRequests service
        ///          method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeSpotInstanceRequests service method, as returned by AmazonEC2.</returns>
        /// 
        DescribeSpotInstanceRequestsResponse DescribeSpotInstanceRequests(DescribeSpotInstanceRequestsRequest describeSpotInstanceRequestsRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSpotInstanceRequests operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeSpotInstanceRequests"/>
        /// </summary>
        /// 
        /// <param name="describeSpotInstanceRequestsRequest">Container for the necessary parameters to execute the DescribeSpotInstanceRequests
        ///          operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeSpotInstanceRequests operation.</returns>
        IAsyncResult BeginDescribeSpotInstanceRequests(DescribeSpotInstanceRequestsRequest describeSpotInstanceRequestsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeSpotInstanceRequests operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeSpotInstanceRequests"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSpotInstanceRequests.</param>
        /// 
        /// <returns>Returns a DescribeSpotInstanceRequestsResult from AmazonEC2.</returns>
        DescribeSpotInstanceRequestsResponse EndDescribeSpotInstanceRequests(IAsyncResult asyncResult);

        /// <summary>
        /// <para>Describes the Spot Instance requests that belong to your account. Spot Instances are instances that Amazon EC2 starts on your behalf
        /// when the maximum price that you specify exceeds the current Spot Price. Amazon EC2 periodically sets the Spot Price based on available Spot
        /// Instance capacity and current Spot Instance requests. For more information about Spot Instances, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-spot-instances.html" >Spot Instances</a> in the <i>Amazon Elastic Compute
        /// Cloud User Guide</i> .</para> <para>You can use <c>DescribeSpotInstanceRequests</c> to find a running Spot Instance by examining the
        /// response. If the status of the Spot Instance is <c>fulfilled</c> , the instance ID appears in the response and contains the identifier of
        /// the instance. Alternatively, you can use DescribeInstances with a filter to look for instances where the instance lifecycle is <c>spot</c>
        /// .</para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeSpotInstanceRequests service method, as returned by AmazonEC2.</returns>
        /// 
        DescribeSpotInstanceRequestsResponse DescribeSpotInstanceRequests();
        
        #endregion
        
    

        #region DescribeSpotPriceHistory

        /// <summary>
        /// <para>Describes the Spot Price history. Spot Instances are instances that Amazon EC2 starts on your behalf when the maximum price that you
        /// specify exceeds the current Spot Price. Amazon EC2 periodically sets the Spot Price based on available Spot Instance capacity and current
        /// Spot Instance requests. For more information about Spot Instances, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-spot-instances.html" >Spot Instances</a> in the <i>Amazon Elastic Compute
        /// Cloud User Guide</i> .</para> <para>When you specify an Availability Zone, this operation describes the price history for the specified
        /// Availability Zone with the most recent set of prices listed first. If you don't specify an Availability Zone, you get the prices across all
        /// Availability Zones, starting with the most recent set. However, if you're using an API version earlier than 2011-05-15, you get the lowest
        /// price across the region for the specified time period. The prices returned are listed in chronological order, from the oldest to the most
        /// recent.</para>
        /// </summary>
        /// 
        /// <param name="describeSpotPriceHistoryRequest">Container for the necessary parameters to execute the DescribeSpotPriceHistory service method
        ///          on AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeSpotPriceHistory service method, as returned by AmazonEC2.</returns>
        /// 
        DescribeSpotPriceHistoryResponse DescribeSpotPriceHistory(DescribeSpotPriceHistoryRequest describeSpotPriceHistoryRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSpotPriceHistory operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeSpotPriceHistory"/>
        /// </summary>
        /// 
        /// <param name="describeSpotPriceHistoryRequest">Container for the necessary parameters to execute the DescribeSpotPriceHistory operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeSpotPriceHistory operation.</returns>
        IAsyncResult BeginDescribeSpotPriceHistory(DescribeSpotPriceHistoryRequest describeSpotPriceHistoryRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeSpotPriceHistory operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeSpotPriceHistory"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSpotPriceHistory.</param>
        /// 
        /// <returns>Returns a DescribeSpotPriceHistoryResult from AmazonEC2.</returns>
        DescribeSpotPriceHistoryResponse EndDescribeSpotPriceHistory(IAsyncResult asyncResult);

        /// <summary>
        /// <para>Describes the Spot Price history. Spot Instances are instances that Amazon EC2 starts on your behalf when the maximum price that you
        /// specify exceeds the current Spot Price. Amazon EC2 periodically sets the Spot Price based on available Spot Instance capacity and current
        /// Spot Instance requests. For more information about Spot Instances, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-spot-instances.html" >Spot Instances</a> in the <i>Amazon Elastic Compute
        /// Cloud User Guide</i> .</para> <para>When you specify an Availability Zone, this operation describes the price history for the specified
        /// Availability Zone with the most recent set of prices listed first. If you don't specify an Availability Zone, you get the prices across all
        /// Availability Zones, starting with the most recent set. However, if you're using an API version earlier than 2011-05-15, you get the lowest
        /// price across the region for the specified time period. The prices returned are listed in chronological order, from the oldest to the most
        /// recent.</para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeSpotPriceHistory service method, as returned by AmazonEC2.</returns>
        /// 
        DescribeSpotPriceHistoryResponse DescribeSpotPriceHistory();
        
        #endregion
        
    

        #region DescribeSubnets

        /// <summary>
        /// <para>Describes one or more of your subnets.</para> <para>For more information about subnets, see <a
        /// href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Subnets.html" >Your VPC and Subnets</a> in the <i>Amazon Virtual Private
        /// Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="describeSubnetsRequest">Container for the necessary parameters to execute the DescribeSubnets service method on
        ///          AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeSubnets service method, as returned by AmazonEC2.</returns>
        /// 
        DescribeSubnetsResponse DescribeSubnets(DescribeSubnetsRequest describeSubnetsRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSubnets operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeSubnets"/>
        /// </summary>
        /// 
        /// <param name="describeSubnetsRequest">Container for the necessary parameters to execute the DescribeSubnets operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSubnets
        ///         operation.</returns>
        IAsyncResult BeginDescribeSubnets(DescribeSubnetsRequest describeSubnetsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeSubnets operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeSubnets"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSubnets.</param>
        /// 
        /// <returns>Returns a DescribeSubnetsResult from AmazonEC2.</returns>
        DescribeSubnetsResponse EndDescribeSubnets(IAsyncResult asyncResult);

        /// <summary>
        /// <para>Describes one or more of your subnets.</para> <para>For more information about subnets, see <a
        /// href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Subnets.html" >Your VPC and Subnets</a> in the <i>Amazon Virtual Private
        /// Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeSubnets service method, as returned by AmazonEC2.</returns>
        /// 
        DescribeSubnetsResponse DescribeSubnets();
        
        #endregion
        
    

        #region DescribeTags

        /// <summary>
        /// <para>Describes one or more of the tags for your EC2 resources.</para> <para>For more information about tags, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_Tags.html" >Tagging Your Resources</a> in the <i>Amazon Elastic Compute Cloud
        /// User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="describeTagsRequest">Container for the necessary parameters to execute the DescribeTags service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeTags service method, as returned by AmazonEC2.</returns>
        /// 
        DescribeTagsResponse DescribeTags(DescribeTagsRequest describeTagsRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTags operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeTags"/>
        /// </summary>
        /// 
        /// <param name="describeTagsRequest">Container for the necessary parameters to execute the DescribeTags operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTags
        ///         operation.</returns>
        IAsyncResult BeginDescribeTags(DescribeTagsRequest describeTagsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeTags operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeTags"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTags.</param>
        /// 
        /// <returns>Returns a DescribeTagsResult from AmazonEC2.</returns>
        DescribeTagsResponse EndDescribeTags(IAsyncResult asyncResult);

        /// <summary>
        /// <para>Describes one or more of the tags for your EC2 resources.</para> <para>For more information about tags, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_Tags.html" >Tagging Your Resources</a> in the <i>Amazon Elastic Compute Cloud
        /// User Guide</i> .</para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeTags service method, as returned by AmazonEC2.</returns>
        /// 
        DescribeTagsResponse DescribeTags();
        
        #endregion
        
    

        #region DescribeVolumeAttribute

        /// <summary>
        /// <para>Describes the specified attribute of the specified volume. You can specify only one attribute at a time.</para> <para>For more
        /// information about Amazon EBS volumes, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSVolumes.html" >Amazon EBS
        /// Volumes</a> in the <i>Amazon Elastic Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="describeVolumeAttributeRequest">Container for the necessary parameters to execute the DescribeVolumeAttribute service method on
        ///          AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeVolumeAttribute service method, as returned by AmazonEC2.</returns>
        /// 
        DescribeVolumeAttributeResponse DescribeVolumeAttribute(DescribeVolumeAttributeRequest describeVolumeAttributeRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVolumeAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeVolumeAttribute"/>
        /// </summary>
        /// 
        /// <param name="describeVolumeAttributeRequest">Container for the necessary parameters to execute the DescribeVolumeAttribute operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeVolumeAttribute operation.</returns>
        IAsyncResult BeginDescribeVolumeAttribute(DescribeVolumeAttributeRequest describeVolumeAttributeRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeVolumeAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeVolumeAttribute"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeVolumeAttribute.</param>
        /// 
        /// <returns>Returns a DescribeVolumeAttributeResult from AmazonEC2.</returns>
        DescribeVolumeAttributeResponse EndDescribeVolumeAttribute(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DescribeVolumeStatus

        /// <summary>
        /// <para>Describes the status of the specified volumes. Volume status provides the result of the checks performed on your volumes to determine
        /// events that can impair the performance of your volumes. The performance of a volume can be affected if an issue occurs on the volume's
        /// underlying host. If the volume's underlying host experiences a power outage or system issue, after the system is restored, there could be
        /// data inconsistencies on the volume. Volume events notify you if this occurs. Volume actions notify you if any action needs to be taken in
        /// response to the event.</para> <para>The <c>DescribeVolumeStatus</c> operation provides the following information about the specified
        /// volumes:</para> <para> <i>Status</i> : Reflects the current status of the volume. The possible values are <c>ok</c> ,
        /// <c>impaired</c> ,
        /// <c>warning</c> , or <c>insufficient-data</c> . If all checks pass, the overall status of the volume is <c>ok</c> . If
        /// the check fails, the overall status is <c>impaired</c> . If the status is <c>insufficient-data</c> , then the checks may still be taking
        /// place on your volume at the time. We recommend that you retry the request. For more information on volume status, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/monitoring-volume-status.html" >Monitoring the Status of Your Volumes</a> .</para>
        /// <para> <i>Events</i> : Reflect the cause of a volume status and may require you to take action. For example, if your volume returns an
        /// <c>impaired</c> status, then the volume event might be <c>potential-data-inconsistency</c> . This means that your volume has been affected
        /// by an issue with the underlying host, has all I/O operations disabled, and may have inconsistent data.</para> <para> <i>Actions</i> :
        /// Reflect the actions you may have to take in response to an event. For example, if the status of the volume is <c>impaired</c> and the volume
        /// event shows <c>potential-data-inconsistency</c> , then the action shows <c>enable-volume-io</c> . This means that you may want to enable the
        /// I/O operations for the volume by calling the EnableVolumeIO action and then check the volume for data consistency.</para> <para><b>NOTE:</b>
        /// Volume status is based on the volume status checks, and does not reflect the volume state. Therefore, volume status does not indicate
        /// volumes in the error state (for example, when a volume is incapable of accepting I/O.) </para>
        /// </summary>
        /// 
        /// <param name="describeVolumeStatusRequest">Container for the necessary parameters to execute the DescribeVolumeStatus service method on
        ///          AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeVolumeStatus service method, as returned by AmazonEC2.</returns>
        /// 
        DescribeVolumeStatusResponse DescribeVolumeStatus(DescribeVolumeStatusRequest describeVolumeStatusRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVolumeStatus operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeVolumeStatus"/>
        /// </summary>
        /// 
        /// <param name="describeVolumeStatusRequest">Container for the necessary parameters to execute the DescribeVolumeStatus operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeVolumeStatus operation.</returns>
        IAsyncResult BeginDescribeVolumeStatus(DescribeVolumeStatusRequest describeVolumeStatusRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeVolumeStatus operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeVolumeStatus"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeVolumeStatus.</param>
        /// 
        /// <returns>Returns a DescribeVolumeStatusResult from AmazonEC2.</returns>
        DescribeVolumeStatusResponse EndDescribeVolumeStatus(IAsyncResult asyncResult);

        /// <summary>
        /// <para>Describes the status of the specified volumes. Volume status provides the result of the checks performed on your volumes to determine
        /// events that can impair the performance of your volumes. The performance of a volume can be affected if an issue occurs on the volume's
        /// underlying host. If the volume's underlying host experiences a power outage or system issue, after the system is restored, there could be
        /// data inconsistencies on the volume. Volume events notify you if this occurs. Volume actions notify you if any action needs to be taken in
        /// response to the event.</para> <para>The <c>DescribeVolumeStatus</c> operation provides the following information about the specified
        /// volumes:</para> <para> <i>Status</i> : Reflects the current status of the volume. The possible values are <c>ok</c> ,
        /// <c>impaired</c> ,
        /// <c>warning</c> , or <c>insufficient-data</c> . If all checks pass, the overall status of the volume is <c>ok</c> . If
        /// the check fails, the overall status is <c>impaired</c> . If the status is <c>insufficient-data</c> , then the checks may still be taking
        /// place on your volume at the time. We recommend that you retry the request. For more information on volume status, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/monitoring-volume-status.html" >Monitoring the Status of Your Volumes</a> .</para>
        /// <para> <i>Events</i> : Reflect the cause of a volume status and may require you to take action. For example, if your volume returns an
        /// <c>impaired</c> status, then the volume event might be <c>potential-data-inconsistency</c> . This means that your volume has been affected
        /// by an issue with the underlying host, has all I/O operations disabled, and may have inconsistent data.</para> <para> <i>Actions</i> :
        /// Reflect the actions you may have to take in response to an event. For example, if the status of the volume is <c>impaired</c> and the volume
        /// event shows <c>potential-data-inconsistency</c> , then the action shows <c>enable-volume-io</c> . This means that you may want to enable the
        /// I/O operations for the volume by calling the EnableVolumeIO action and then check the volume for data consistency.</para> <para><b>NOTE:</b>
        /// Volume status is based on the volume status checks, and does not reflect the volume state. Therefore, volume status does not indicate
        /// volumes in the error state (for example, when a volume is incapable of accepting I/O.) </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeVolumeStatus service method, as returned by AmazonEC2.</returns>
        /// 
        DescribeVolumeStatusResponse DescribeVolumeStatus();
        
        #endregion
        
    

        #region DescribeVolumes

        /// <summary>
        /// <para>Describes the specified Amazon EBS volumes.</para> <para>For more information about Amazon EBS volumes, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSVolumes.html" >Amazon EBS Volumes</a> in the <i>Amazon Elastic Compute Cloud
        /// User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="describeVolumesRequest">Container for the necessary parameters to execute the DescribeVolumes service method on
        ///          AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeVolumes service method, as returned by AmazonEC2.</returns>
        /// 
        DescribeVolumesResponse DescribeVolumes(DescribeVolumesRequest describeVolumesRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVolumes operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeVolumes"/>
        /// </summary>
        /// 
        /// <param name="describeVolumesRequest">Container for the necessary parameters to execute the DescribeVolumes operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeVolumes
        ///         operation.</returns>
        IAsyncResult BeginDescribeVolumes(DescribeVolumesRequest describeVolumesRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeVolumes operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeVolumes"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeVolumes.</param>
        /// 
        /// <returns>Returns a DescribeVolumesResult from AmazonEC2.</returns>
        DescribeVolumesResponse EndDescribeVolumes(IAsyncResult asyncResult);

        /// <summary>
        /// <para>Describes the specified Amazon EBS volumes.</para> <para>For more information about Amazon EBS volumes, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSVolumes.html" >Amazon EBS Volumes</a> in the <i>Amazon Elastic Compute Cloud
        /// User Guide</i> .</para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeVolumes service method, as returned by AmazonEC2.</returns>
        /// 
        DescribeVolumesResponse DescribeVolumes();
        
        #endregion
        
    

        #region DescribeVpcAttribute

        /// <summary>
        /// <para>Describes the specified attribute of the specified VPC. You can specify only one attribute at a time.</para>
        /// </summary>
        /// 
        /// <param name="describeVpcAttributeRequest">Container for the necessary parameters to execute the DescribeVpcAttribute service method on
        ///          AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeVpcAttribute service method, as returned by AmazonEC2.</returns>
        /// 
        DescribeVpcAttributeResponse DescribeVpcAttribute(DescribeVpcAttributeRequest describeVpcAttributeRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVpcAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeVpcAttribute"/>
        /// </summary>
        /// 
        /// <param name="describeVpcAttributeRequest">Container for the necessary parameters to execute the DescribeVpcAttribute operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeVpcAttribute operation.</returns>
        IAsyncResult BeginDescribeVpcAttribute(DescribeVpcAttributeRequest describeVpcAttributeRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeVpcAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeVpcAttribute"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeVpcAttribute.</param>
        /// 
        /// <returns>Returns a DescribeVpcAttributeResult from AmazonEC2.</returns>
        DescribeVpcAttributeResponse EndDescribeVpcAttribute(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DescribeVpcs

        /// <summary>
        /// <para>Describes one or more of your VPCs.</para>
        /// </summary>
        /// 
        /// <param name="describeVpcsRequest">Container for the necessary parameters to execute the DescribeVpcs service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeVpcs service method, as returned by AmazonEC2.</returns>
        /// 
        DescribeVpcsResponse DescribeVpcs(DescribeVpcsRequest describeVpcsRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVpcs operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeVpcs"/>
        /// </summary>
        /// 
        /// <param name="describeVpcsRequest">Container for the necessary parameters to execute the DescribeVpcs operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeVpcs
        ///         operation.</returns>
        IAsyncResult BeginDescribeVpcs(DescribeVpcsRequest describeVpcsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeVpcs operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeVpcs"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeVpcs.</param>
        /// 
        /// <returns>Returns a DescribeVpcsResult from AmazonEC2.</returns>
        DescribeVpcsResponse EndDescribeVpcs(IAsyncResult asyncResult);

        /// <summary>
        /// <para>Describes one or more of your VPCs.</para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeVpcs service method, as returned by AmazonEC2.</returns>
        /// 
        DescribeVpcsResponse DescribeVpcs();
        
        #endregion
        
    

        #region DescribeVpnConnections

        /// <summary>
        /// <para>Describes one or more of your VPN connections.</para> <para>For more information about VPN connections, see <a
        /// href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_VPN.html" >Adding a Hardware Virtual Private Gateway to Your VPC</a> in the
        /// <i>Amazon Virtual Private Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="describeVpnConnectionsRequest">Container for the necessary parameters to execute the DescribeVpnConnections service method on
        ///          AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeVpnConnections service method, as returned by AmazonEC2.</returns>
        /// 
        DescribeVpnConnectionsResponse DescribeVpnConnections(DescribeVpnConnectionsRequest describeVpnConnectionsRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVpnConnections operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeVpnConnections"/>
        /// </summary>
        /// 
        /// <param name="describeVpnConnectionsRequest">Container for the necessary parameters to execute the DescribeVpnConnections operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeVpnConnections operation.</returns>
        IAsyncResult BeginDescribeVpnConnections(DescribeVpnConnectionsRequest describeVpnConnectionsRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeVpnConnections operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeVpnConnections"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeVpnConnections.</param>
        /// 
        /// <returns>Returns a DescribeVpnConnectionsResult from AmazonEC2.</returns>
        DescribeVpnConnectionsResponse EndDescribeVpnConnections(IAsyncResult asyncResult);

        /// <summary>
        /// <para>Describes one or more of your VPN connections.</para> <para>For more information about VPN connections, see <a
        /// href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_VPN.html" >Adding a Hardware Virtual Private Gateway to Your VPC</a> in the
        /// <i>Amazon Virtual Private Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeVpnConnections service method, as returned by AmazonEC2.</returns>
        /// 
        DescribeVpnConnectionsResponse DescribeVpnConnections();
        
        #endregion
        
    

        #region DescribeVpnGateways

        /// <summary>
        /// <para>Describes one or more of your virtual private gateways.</para> <para>For more information about virtual private gateways, see <a
        /// href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_VPN.html" >Adding an IPsec Hardware VPN to Your VPC</a> in the <i>Amazon
        /// Virtual Private Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="describeVpnGatewaysRequest">Container for the necessary parameters to execute the DescribeVpnGateways service method on
        ///          AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeVpnGateways service method, as returned by AmazonEC2.</returns>
        /// 
        DescribeVpnGatewaysResponse DescribeVpnGateways(DescribeVpnGatewaysRequest describeVpnGatewaysRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVpnGateways operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeVpnGateways"/>
        /// </summary>
        /// 
        /// <param name="describeVpnGatewaysRequest">Container for the necessary parameters to execute the DescribeVpnGateways operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeVpnGateways operation.</returns>
        IAsyncResult BeginDescribeVpnGateways(DescribeVpnGatewaysRequest describeVpnGatewaysRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeVpnGateways operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeVpnGateways"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeVpnGateways.</param>
        /// 
        /// <returns>Returns a DescribeVpnGatewaysResult from AmazonEC2.</returns>
        DescribeVpnGatewaysResponse EndDescribeVpnGateways(IAsyncResult asyncResult);

        /// <summary>
        /// <para>Describes one or more of your virtual private gateways.</para> <para>For more information about virtual private gateways, see <a
        /// href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_VPN.html" >Adding an IPsec Hardware VPN to Your VPC</a> in the <i>Amazon
        /// Virtual Private Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeVpnGateways service method, as returned by AmazonEC2.</returns>
        /// 
        DescribeVpnGatewaysResponse DescribeVpnGateways();
        
        #endregion
        
    

        #region DetachInternetGateway

        /// <summary>
        /// <para>Detaches an Internet gateway from a VPC, disabling connectivity between the Internet and the VPC. The VPC must not contain any running
        /// instances with Elastic IP addresses.</para>
        /// </summary>
        /// 
        /// <param name="detachInternetGatewayRequest">Container for the necessary parameters to execute the DetachInternetGateway service method on
        ///          AmazonEC2.</param>
        /// 
        DetachInternetGatewayResponse DetachInternetGateway(DetachInternetGatewayRequest detachInternetGatewayRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DetachInternetGateway operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DetachInternetGateway"/>
        /// </summary>
        /// 
        /// <param name="detachInternetGatewayRequest">Container for the necessary parameters to execute the DetachInternetGateway operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginDetachInternetGateway(DetachInternetGatewayRequest detachInternetGatewayRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DetachInternetGateway operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DetachInternetGateway"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetachInternetGateway.</param>
        DetachInternetGatewayResponse EndDetachInternetGateway(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DetachNetworkInterface

        /// <summary>
        /// <para>Detaches a network interface from an instance.</para>
        /// </summary>
        /// 
        /// <param name="detachNetworkInterfaceRequest">Container for the necessary parameters to execute the DetachNetworkInterface service method on
        ///          AmazonEC2.</param>
        /// 
        DetachNetworkInterfaceResponse DetachNetworkInterface(DetachNetworkInterfaceRequest detachNetworkInterfaceRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DetachNetworkInterface operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DetachNetworkInterface"/>
        /// </summary>
        /// 
        /// <param name="detachNetworkInterfaceRequest">Container for the necessary parameters to execute the DetachNetworkInterface operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginDetachNetworkInterface(DetachNetworkInterfaceRequest detachNetworkInterfaceRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DetachNetworkInterface operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DetachNetworkInterface"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetachNetworkInterface.</param>
        DetachNetworkInterfaceResponse EndDetachNetworkInterface(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DetachVolume

        /// <summary>
        /// <para>Detaches an Amazon EBS volume from an instance. Make sure to unmount any file systems on the device within your operating system
        /// before detaching the volume. Failure to do so results in the volume being stuck in a busy state while detaching.</para> <para>If an Amazon
        /// EBS volume is the root device of an instance, it can't be detached while the instance is running. To detach the root volume, stop the
        /// instance first.</para> <para>If the root volume is detached from an instance with an AWS Marketplace product code, then the AWS Marketplace
        /// product codes from that volume are no longer associated with the instance.</para> <para>For more information, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-detaching-volume.html" >Detaching an Amazon EBS Volume</a> in the <i>Amazon
        /// Elastic Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="detachVolumeRequest">Container for the necessary parameters to execute the DetachVolume service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the DetachVolume service method, as returned by AmazonEC2.</returns>
        /// 
        DetachVolumeResponse DetachVolume(DetachVolumeRequest detachVolumeRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DetachVolume operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DetachVolume"/>
        /// </summary>
        /// 
        /// <param name="detachVolumeRequest">Container for the necessary parameters to execute the DetachVolume operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDetachVolume
        ///         operation.</returns>
        IAsyncResult BeginDetachVolume(DetachVolumeRequest detachVolumeRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DetachVolume operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DetachVolume"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetachVolume.</param>
        /// 
        /// <returns>Returns a DetachVolumeResult from AmazonEC2.</returns>
        DetachVolumeResponse EndDetachVolume(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DetachVpnGateway

        /// <summary>
        /// <para>Detaches a virtual private gateway from a VPC. You do this if you're planning to turn off the VPC and not use it anymore. You can
        /// confirm a virtual private gateway has been completely detached from a VPC by describing the virtual private gateway (any attachments to the
        /// virtual private gateway are also described).</para> <para>You must wait for the attachment's state to switch to <c>detached</c> before you
        /// can delete the VPC or attach a different VPC to the virtual private gateway.</para>
        /// </summary>
        /// 
        /// <param name="detachVpnGatewayRequest">Container for the necessary parameters to execute the DetachVpnGateway service method on
        ///          AmazonEC2.</param>
        /// 
        DetachVpnGatewayResponse DetachVpnGateway(DetachVpnGatewayRequest detachVpnGatewayRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DetachVpnGateway operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DetachVpnGateway"/>
        /// </summary>
        /// 
        /// <param name="detachVpnGatewayRequest">Container for the necessary parameters to execute the DetachVpnGateway operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginDetachVpnGateway(DetachVpnGatewayRequest detachVpnGatewayRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DetachVpnGateway operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DetachVpnGateway"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetachVpnGateway.</param>
        DetachVpnGatewayResponse EndDetachVpnGateway(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DisableVgwRoutePropagation

        /// <summary>
        /// <para>Disables a virtual private gateway (VGW) from propagating routes to the routing tables of a VPC.</para>
        /// </summary>
        /// 
        /// <param name="disableVgwRoutePropagationRequest">Container for the necessary parameters to execute the DisableVgwRoutePropagation service
        ///          method on AmazonEC2.</param>
        /// 
        DisableVgwRoutePropagationResponse DisableVgwRoutePropagation(DisableVgwRoutePropagationRequest disableVgwRoutePropagationRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DisableVgwRoutePropagation operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DisableVgwRoutePropagation"/>
        /// </summary>
        /// 
        /// <param name="disableVgwRoutePropagationRequest">Container for the necessary parameters to execute the DisableVgwRoutePropagation operation
        ///          on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginDisableVgwRoutePropagation(DisableVgwRoutePropagationRequest disableVgwRoutePropagationRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DisableVgwRoutePropagation operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DisableVgwRoutePropagation"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisableVgwRoutePropagation.</param>
        DisableVgwRoutePropagationResponse EndDisableVgwRoutePropagation(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DisassociateAddress

        /// <summary>
        /// <para>Disassociates an Elastic IP address from the instance or network interface it's associated with.</para> <para>This is an idempotent
        /// operation. If you perform the operation more than once, Amazon EC2 doesn't return an error.</para>
        /// </summary>
        /// 
        /// <param name="disassociateAddressRequest">Container for the necessary parameters to execute the DisassociateAddress service method on
        ///          AmazonEC2.</param>
        /// 
        DisassociateAddressResponse DisassociateAddress(DisassociateAddressRequest disassociateAddressRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateAddress operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DisassociateAddress"/>
        /// </summary>
        /// 
        /// <param name="disassociateAddressRequest">Container for the necessary parameters to execute the DisassociateAddress operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginDisassociateAddress(DisassociateAddressRequest disassociateAddressRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DisassociateAddress operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DisassociateAddress"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateAddress.</param>
        DisassociateAddressResponse EndDisassociateAddress(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region DisassociateRouteTable

        /// <summary>
        /// <para>Disassociates a subnet from a route table.</para> <para>After you perform this action, the subnet no longer uses the routes in the
        /// route table. Instead, it uses the routes in the VPC's main route table. For more information about route tables, see <a
        /// href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Route_Tables.html" >Route Tables</a> in the <i>Amazon Virtual Private Cloud
        /// User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="disassociateRouteTableRequest">Container for the necessary parameters to execute the DisassociateRouteTable service method on
        ///          AmazonEC2.</param>
        /// 
        DisassociateRouteTableResponse DisassociateRouteTable(DisassociateRouteTableRequest disassociateRouteTableRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateRouteTable operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DisassociateRouteTable"/>
        /// </summary>
        /// 
        /// <param name="disassociateRouteTableRequest">Container for the necessary parameters to execute the DisassociateRouteTable operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginDisassociateRouteTable(DisassociateRouteTableRequest disassociateRouteTableRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the DisassociateRouteTable operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DisassociateRouteTable"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateRouteTable.</param>
        DisassociateRouteTableResponse EndDisassociateRouteTable(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region EnableVgwRoutePropagation

        /// <summary>
        /// <para>Enables a virtual private gateway (VGW) to propagate routes to the routing tables of a VPC.</para>
        /// </summary>
        /// 
        /// <param name="enableVgwRoutePropagationRequest">Container for the necessary parameters to execute the EnableVgwRoutePropagation service
        ///          method on AmazonEC2.</param>
        /// 
        EnableVgwRoutePropagationResponse EnableVgwRoutePropagation(EnableVgwRoutePropagationRequest enableVgwRoutePropagationRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the EnableVgwRoutePropagation operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.EnableVgwRoutePropagation"/>
        /// </summary>
        /// 
        /// <param name="enableVgwRoutePropagationRequest">Container for the necessary parameters to execute the EnableVgwRoutePropagation operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginEnableVgwRoutePropagation(EnableVgwRoutePropagationRequest enableVgwRoutePropagationRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the EnableVgwRoutePropagation operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.EnableVgwRoutePropagation"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEnableVgwRoutePropagation.</param>
        EnableVgwRoutePropagationResponse EndEnableVgwRoutePropagation(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region EnableVolumeIO

        /// <summary>
        /// <para>Enables I/O operations for a volume that had I/O operations disabled because the data on the volume was potentially
        /// inconsistent.</para>
        /// </summary>
        /// 
        /// <param name="enableVolumeIORequest">Container for the necessary parameters to execute the EnableVolumeIO service method on
        ///          AmazonEC2.</param>
        /// 
        EnableVolumeIOResponse EnableVolumeIO(EnableVolumeIORequest enableVolumeIORequest);

        /// <summary>
        /// Initiates the asynchronous execution of the EnableVolumeIO operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.EnableVolumeIO"/>
        /// </summary>
        /// 
        /// <param name="enableVolumeIORequest">Container for the necessary parameters to execute the EnableVolumeIO operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginEnableVolumeIO(EnableVolumeIORequest enableVolumeIORequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the EnableVolumeIO operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.EnableVolumeIO"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEnableVolumeIO.</param>
        EnableVolumeIOResponse EndEnableVolumeIO(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region GetConsoleOutput

        /// <summary>
        /// <para>Gets the console output for the specified instance.</para> <para>Instances do not have a physical monitor through which you can view
        /// their console output. They also lack physical controls that allow you to power up, reboot, or shut them down. To allow these actions, we
        /// provide them through the Amazon EC2 API and command line interface.</para> <para>Instance console output is buffered and posted shortly
        /// after instance boot, reboot, and termination. Amazon EC2 preserves the most recent 64 KB output which is available for at least one hour
        /// after the most recent post.</para> <para>For Linux/Unix instances, the instance console output displays the exact console output that would
        /// normally be displayed on a physical monitor attached to a machine. This output is buffered because the instance produces it and then posts
        /// it to a store where the instance's owner can retrieve it.</para> <para>For Windows instances, the instance console output displays the last
        /// three system event log errors.</para>
        /// </summary>
        /// 
        /// <param name="getConsoleOutputRequest">Container for the necessary parameters to execute the GetConsoleOutput service method on
        ///          AmazonEC2.</param>
        /// 
        /// <returns>The response from the GetConsoleOutput service method, as returned by AmazonEC2.</returns>
        /// 
        GetConsoleOutputResponse GetConsoleOutput(GetConsoleOutputRequest getConsoleOutputRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the GetConsoleOutput operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.GetConsoleOutput"/>
        /// </summary>
        /// 
        /// <param name="getConsoleOutputRequest">Container for the necessary parameters to execute the GetConsoleOutput operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetConsoleOutput
        ///         operation.</returns>
        IAsyncResult BeginGetConsoleOutput(GetConsoleOutputRequest getConsoleOutputRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the GetConsoleOutput operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.GetConsoleOutput"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetConsoleOutput.</param>
        /// 
        /// <returns>Returns a GetConsoleOutputResult from AmazonEC2.</returns>
        GetConsoleOutputResponse EndGetConsoleOutput(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region GetPasswordData

        /// <summary>
        /// <para>Retrieves the encrypted administrator password for an instance running Windows.</para> <para>The Windows password is only generated
        /// the first time an AMI is launched. It is not generated for rebundled AMIs or after the password is changed on an instance.</para> <para>The
        /// password is encrypted using the key pair that you specified when you launched the instance. You must provide the corresponding key pair
        /// file.</para> <para>Password generation and encryption takes a few moments. We recommend that you wait up to 15 minutes after launching an
        /// instance before trying to retrieve the generated password.</para>
        /// </summary>
        /// 
        /// <param name="getPasswordDataRequest">Container for the necessary parameters to execute the GetPasswordData service method on
        ///          AmazonEC2.</param>
        /// 
        /// <returns>The response from the GetPasswordData service method, as returned by AmazonEC2.</returns>
        /// 
        GetPasswordDataResponse GetPasswordData(GetPasswordDataRequest getPasswordDataRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the GetPasswordData operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.GetPasswordData"/>
        /// </summary>
        /// 
        /// <param name="getPasswordDataRequest">Container for the necessary parameters to execute the GetPasswordData operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPasswordData
        ///         operation.</returns>
        IAsyncResult BeginGetPasswordData(GetPasswordDataRequest getPasswordDataRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the GetPasswordData operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.GetPasswordData"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPasswordData.</param>
        /// 
        /// <returns>Returns a GetPasswordDataResult from AmazonEC2.</returns>
        GetPasswordDataResponse EndGetPasswordData(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region ImportInstance

        /// <summary>
        /// <para>Creates an import instance task using metadata from the specified disk image. After importing the image, you then upload it using the
        /// ec2-upload-disk-image command in the EC2 command line tools. For more information, see Using the Command Line Tools to Import Your Virtual
        /// Machine to Amazon EC2 in the Amazon Elastic Compute Cloud User Guide.</para>
        /// </summary>
        /// 
        /// <param name="importInstanceRequest">Container for the necessary parameters to execute the ImportInstance service method on
        ///          AmazonEC2.</param>
        /// 
        /// <returns>The response from the ImportInstance service method, as returned by AmazonEC2.</returns>
        /// 
        ImportInstanceResponse ImportInstance(ImportInstanceRequest importInstanceRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the ImportInstance operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ImportInstance"/>
        /// </summary>
        /// 
        /// <param name="importInstanceRequest">Container for the necessary parameters to execute the ImportInstance operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndImportInstance
        ///         operation.</returns>
        IAsyncResult BeginImportInstance(ImportInstanceRequest importInstanceRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the ImportInstance operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ImportInstance"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginImportInstance.</param>
        /// 
        /// <returns>Returns a ImportInstanceResult from AmazonEC2.</returns>
        ImportInstanceResponse EndImportInstance(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region ImportKeyPair

        /// <summary>
        /// <para>Imports the public key from an RSA key pair that you created with a third-party tool. Compare this with CreateKeyPair, in which AWS
        /// creates the key pair and gives the keys to you (AWS keeps a copy of the public key). With ImportKeyPair, you create the key pair and give
        /// AWS just the public key. The private key is never transferred between you and AWS.</para> <para>For more information about key pairs, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-key-pairs.html" >Key Pairs</a> in the <i>Amazon Elastic Compute Cloud User
        /// Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="importKeyPairRequest">Container for the necessary parameters to execute the ImportKeyPair service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the ImportKeyPair service method, as returned by AmazonEC2.</returns>
        /// 
        ImportKeyPairResponse ImportKeyPair(ImportKeyPairRequest importKeyPairRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the ImportKeyPair operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ImportKeyPair"/>
        /// </summary>
        /// 
        /// <param name="importKeyPairRequest">Container for the necessary parameters to execute the ImportKeyPair operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndImportKeyPair
        ///         operation.</returns>
        IAsyncResult BeginImportKeyPair(ImportKeyPairRequest importKeyPairRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the ImportKeyPair operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ImportKeyPair"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginImportKeyPair.</param>
        /// 
        /// <returns>Returns a ImportKeyPairResult from AmazonEC2.</returns>
        ImportKeyPairResponse EndImportKeyPair(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region ImportVolume

        /// <summary>
        /// <para>Creates an import volume task using metadata from the specified disk image. After importing the image, you then upload it using the
        /// ec2-upload-disk-image command in the Amazon EC2 command-line interface (CLI) tools. For more information, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/UploadingYourInstancesandVolumes.html" >Using the Command Line Tools to Import Your
        /// Virtual Machine to Amazon EC2</a> in the <i>Amazon Elastic Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="importVolumeRequest">Container for the necessary parameters to execute the ImportVolume service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the ImportVolume service method, as returned by AmazonEC2.</returns>
        /// 
        ImportVolumeResponse ImportVolume(ImportVolumeRequest importVolumeRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the ImportVolume operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ImportVolume"/>
        /// </summary>
        /// 
        /// <param name="importVolumeRequest">Container for the necessary parameters to execute the ImportVolume operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndImportVolume
        ///         operation.</returns>
        IAsyncResult BeginImportVolume(ImportVolumeRequest importVolumeRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the ImportVolume operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ImportVolume"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginImportVolume.</param>
        /// 
        /// <returns>Returns a ImportVolumeResult from AmazonEC2.</returns>
        ImportVolumeResponse EndImportVolume(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region ModifyImageAttribute

        /// <summary>
        /// <para>Modifies the specified attribute of the specified AMI. You can specify only one attribute at a time.</para> <para><b>NOTE:</b> AWS
        /// Marketplace product codes cannot be modified. Images with an AWS Marketplace product code cannot be made public. </para>
        /// </summary>
        /// 
        /// <param name="modifyImageAttributeRequest">Container for the necessary parameters to execute the ModifyImageAttribute service method on
        ///          AmazonEC2.</param>
        /// 
        ModifyImageAttributeResponse ModifyImageAttribute(ModifyImageAttributeRequest modifyImageAttributeRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyImageAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ModifyImageAttribute"/>
        /// </summary>
        /// 
        /// <param name="modifyImageAttributeRequest">Container for the necessary parameters to execute the ModifyImageAttribute operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginModifyImageAttribute(ModifyImageAttributeRequest modifyImageAttributeRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the ModifyImageAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ModifyImageAttribute"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyImageAttribute.</param>
        ModifyImageAttributeResponse EndModifyImageAttribute(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region ModifyInstanceAttribute

        /// <summary>
        /// <para>Modifies the specified attribute of the specified instance. You can specify only one attribute at a time.</para> <para>To modify some
        /// attributes, the instance must be stopped. For more information, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_ChangingAttributesWhileInstanceStopped.html" >Modifying Attributes of a
        /// Stopped Instance</a> in the <i>Amazon Elastic Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="modifyInstanceAttributeRequest">Container for the necessary parameters to execute the ModifyInstanceAttribute service method on
        ///          AmazonEC2.</param>
        /// 
        ModifyInstanceAttributeResponse ModifyInstanceAttribute(ModifyInstanceAttributeRequest modifyInstanceAttributeRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyInstanceAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ModifyInstanceAttribute"/>
        /// </summary>
        /// 
        /// <param name="modifyInstanceAttributeRequest">Container for the necessary parameters to execute the ModifyInstanceAttribute operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginModifyInstanceAttribute(ModifyInstanceAttributeRequest modifyInstanceAttributeRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the ModifyInstanceAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ModifyInstanceAttribute"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyInstanceAttribute.</param>
        ModifyInstanceAttributeResponse EndModifyInstanceAttribute(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region ModifyNetworkInterfaceAttribute

        /// <summary>
        /// <para>Modifies the specified network interface attribute. You can specify only one attribute at a time.</para>
        /// </summary>
        /// 
        /// <param name="modifyNetworkInterfaceAttributeRequest">Container for the necessary parameters to execute the ModifyNetworkInterfaceAttribute
        ///          service method on AmazonEC2.</param>
        /// 
        ModifyNetworkInterfaceAttributeResponse ModifyNetworkInterfaceAttribute(ModifyNetworkInterfaceAttributeRequest modifyNetworkInterfaceAttributeRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyNetworkInterfaceAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ModifyNetworkInterfaceAttribute"/>
        /// </summary>
        /// 
        /// <param name="modifyNetworkInterfaceAttributeRequest">Container for the necessary parameters to execute the ModifyNetworkInterfaceAttribute
        ///          operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginModifyNetworkInterfaceAttribute(ModifyNetworkInterfaceAttributeRequest modifyNetworkInterfaceAttributeRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the ModifyNetworkInterfaceAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ModifyNetworkInterfaceAttribute"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyNetworkInterfaceAttribute.</param>
        ModifyNetworkInterfaceAttributeResponse EndModifyNetworkInterfaceAttribute(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region ModifyReservedInstances

        /// <summary>
        /// <para>Modifies the Availability Zone, instance count, instance type, or network platform (EC2-Classic or EC2-VPC) of your Reserved
        /// Instances. The Reserved Instances to be modified must be identical, except for Availability Zone, network platform, and instance
        /// type.</para>
        /// </summary>
        /// 
        /// <param name="modifyReservedInstancesRequest">Container for the necessary parameters to execute the ModifyReservedInstances service method on
        ///          AmazonEC2.</param>
        /// 
        /// <returns>The response from the ModifyReservedInstances service method, as returned by AmazonEC2.</returns>
        /// 
        ModifyReservedInstancesResponse ModifyReservedInstances(ModifyReservedInstancesRequest modifyReservedInstancesRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyReservedInstances operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ModifyReservedInstances"/>
        /// </summary>
        /// 
        /// <param name="modifyReservedInstancesRequest">Container for the necessary parameters to execute the ModifyReservedInstances operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndModifyReservedInstances operation.</returns>
        IAsyncResult BeginModifyReservedInstances(ModifyReservedInstancesRequest modifyReservedInstancesRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the ModifyReservedInstances operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ModifyReservedInstances"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyReservedInstances.</param>
        /// 
        /// <returns>Returns a ModifyReservedInstancesResult from AmazonEC2.</returns>
        ModifyReservedInstancesResponse EndModifyReservedInstances(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region ModifySnapshotAttribute

        /// <summary>
        /// <para>Adds or removes permission settings for the specified snapshot.</para> <para>For more information on modifying snapshot permissions,
        /// see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-modifying-snapshot-permissions.html" >Sharing Snapshots</a> in the
        /// <i>Amazon Elastic Compute Cloud User Guide</i> .</para> <para><b>NOTE:</b> Snapshots with AWS Marketplace product codes cannot be made
        /// public. </para>
        /// </summary>
        /// 
        /// <param name="modifySnapshotAttributeRequest">Container for the necessary parameters to execute the ModifySnapshotAttribute service method on
        ///          AmazonEC2.</param>
        /// 
        ModifySnapshotAttributeResponse ModifySnapshotAttribute(ModifySnapshotAttributeRequest modifySnapshotAttributeRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the ModifySnapshotAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ModifySnapshotAttribute"/>
        /// </summary>
        /// 
        /// <param name="modifySnapshotAttributeRequest">Container for the necessary parameters to execute the ModifySnapshotAttribute operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginModifySnapshotAttribute(ModifySnapshotAttributeRequest modifySnapshotAttributeRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the ModifySnapshotAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ModifySnapshotAttribute"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifySnapshotAttribute.</param>
        ModifySnapshotAttributeResponse EndModifySnapshotAttribute(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region ModifyVolumeAttribute

        /// <summary>
        /// <para>Modifies a volume attribute.</para> <para>By default, all I/O operations for the volume are suspended when the data on the volume is
        /// determined to be potentially inconsistent, to prevent undetectable, latent data corruption. The I/O access to the volume can be resumed by
        /// first enabling I/O access and then checking the data consistency on your volume.</para> <para>You can change the default behavior to resume
        /// I/O operations. We recommend that you change this only for boot volumes or for volumes that are stateless or disposable.</para>
        /// </summary>
        /// 
        /// <param name="modifyVolumeAttributeRequest">Container for the necessary parameters to execute the ModifyVolumeAttribute service method on
        ///          AmazonEC2.</param>
        /// 
        ModifyVolumeAttributeResponse ModifyVolumeAttribute(ModifyVolumeAttributeRequest modifyVolumeAttributeRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyVolumeAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ModifyVolumeAttribute"/>
        /// </summary>
        /// 
        /// <param name="modifyVolumeAttributeRequest">Container for the necessary parameters to execute the ModifyVolumeAttribute operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginModifyVolumeAttribute(ModifyVolumeAttributeRequest modifyVolumeAttributeRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the ModifyVolumeAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ModifyVolumeAttribute"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyVolumeAttribute.</param>
        ModifyVolumeAttributeResponse EndModifyVolumeAttribute(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region ModifyVpcAttribute

        /// <summary>
        /// <para>Modifies the specified attribute of the specified VPC.</para>
        /// </summary>
        /// 
        /// <param name="modifyVpcAttributeRequest">Container for the necessary parameters to execute the ModifyVpcAttribute service method on
        ///          AmazonEC2.</param>
        /// 
        ModifyVpcAttributeResponse ModifyVpcAttribute(ModifyVpcAttributeRequest modifyVpcAttributeRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyVpcAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ModifyVpcAttribute"/>
        /// </summary>
        /// 
        /// <param name="modifyVpcAttributeRequest">Container for the necessary parameters to execute the ModifyVpcAttribute operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginModifyVpcAttribute(ModifyVpcAttributeRequest modifyVpcAttributeRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the ModifyVpcAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ModifyVpcAttribute"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyVpcAttribute.</param>
        ModifyVpcAttributeResponse EndModifyVpcAttribute(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region MonitorInstances

        /// <summary>
        /// <para>Enables monitoring for a running instance. For more information about monitoring instances, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-cloudwatch.html" >Monitoring Your Instances and Volumes</a> in the <i>Amazon
        /// Elastic Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="monitorInstancesRequest">Container for the necessary parameters to execute the MonitorInstances service method on
        ///          AmazonEC2.</param>
        /// 
        /// <returns>The response from the MonitorInstances service method, as returned by AmazonEC2.</returns>
        /// 
        MonitorInstancesResponse MonitorInstances(MonitorInstancesRequest monitorInstancesRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the MonitorInstances operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.MonitorInstances"/>
        /// </summary>
        /// 
        /// <param name="monitorInstancesRequest">Container for the necessary parameters to execute the MonitorInstances operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndMonitorInstances
        ///         operation.</returns>
        IAsyncResult BeginMonitorInstances(MonitorInstancesRequest monitorInstancesRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the MonitorInstances operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.MonitorInstances"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginMonitorInstances.</param>
        /// 
        /// <returns>Returns a MonitorInstancesResult from AmazonEC2.</returns>
        MonitorInstancesResponse EndMonitorInstances(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region PurchaseReservedInstancesOffering

        /// <summary>
        /// <para>Purchases a Reserved Instance for use with your account. With Amazon EC2 Reserved Instances, you obtain a capacity reservation for a
        /// certain instance configuration over a specified period of time. You pay a lower usage rate than with On-Demand instances for the time that
        /// you actually use the capacity reservation.</para> <para>For more information, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ri-market-general.html" >Reserved Instance Marketplace</a> in the <i>Amazon Elastic
        /// Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="purchaseReservedInstancesOfferingRequest">Container for the necessary parameters to execute the
        ///          PurchaseReservedInstancesOffering service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the PurchaseReservedInstancesOffering service method, as returned by AmazonEC2.</returns>
        /// 
        PurchaseReservedInstancesOfferingResponse PurchaseReservedInstancesOffering(PurchaseReservedInstancesOfferingRequest purchaseReservedInstancesOfferingRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the PurchaseReservedInstancesOffering operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.PurchaseReservedInstancesOffering"/>
        /// </summary>
        /// 
        /// <param name="purchaseReservedInstancesOfferingRequest">Container for the necessary parameters to execute the
        ///          PurchaseReservedInstancesOffering operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndPurchaseReservedInstancesOffering operation.</returns>
        IAsyncResult BeginPurchaseReservedInstancesOffering(PurchaseReservedInstancesOfferingRequest purchaseReservedInstancesOfferingRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the PurchaseReservedInstancesOffering operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.PurchaseReservedInstancesOffering"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPurchaseReservedInstancesOffering.</param>
        /// 
        /// <returns>Returns a PurchaseReservedInstancesOfferingResult from AmazonEC2.</returns>
        PurchaseReservedInstancesOfferingResponse EndPurchaseReservedInstancesOffering(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region RebootInstances

        /// <summary>
        /// <para>Requests a reboot of one or more instances. This operation is asynchronous; it only queues a request to reboot the specified
        /// instances. The operation succeeds if the instances are valid and belong to you. Requests to reboot terminated instances are ignored.</para>
        /// <para>If a Linux/Unix instance does not cleanly shut down within four minutes, Amazon EC2 performs a hard reboot.</para>
        /// </summary>
        /// 
        /// <param name="rebootInstancesRequest">Container for the necessary parameters to execute the RebootInstances service method on
        ///          AmazonEC2.</param>
        /// 
        RebootInstancesResponse RebootInstances(RebootInstancesRequest rebootInstancesRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the RebootInstances operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.RebootInstances"/>
        /// </summary>
        /// 
        /// <param name="rebootInstancesRequest">Container for the necessary parameters to execute the RebootInstances operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginRebootInstances(RebootInstancesRequest rebootInstancesRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the RebootInstances operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.RebootInstances"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRebootInstances.</param>
        RebootInstancesResponse EndRebootInstances(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region RegisterImage

        /// <summary>
        /// <para>Registers an AMI. When you're creating an AMI, this is the final step you must complete before you can launch an instance from the
        /// AMI. For more information about creating AMIs, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/creating-an-ami.html"
        /// >Creating Your Own AMIs</a> in the <i>Amazon Elastic Compute Cloud User Guide</i> .</para> <para><b>NOTE:</b> For Amazon EBS-backed
        /// instances, CreateImage creates and registers the AMI in a single request, so you don't have to register the AMI yourself. </para> <para>You
        /// can also use <c>RegisterImage</c> to create an Amazon EBS-backed AMI from a snapshot of a root device volume. For more information, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_LaunchingInstanceFromSnapshot.html" >Launching an Instance from a
        /// Snapshot</a> in the <i>Amazon Elastic Compute Cloud User Guide</i> .</para> <para>If needed, you can deregister an AMI at any time. Any
        /// modifications you make to an AMI backed by an instance store volume invalidates its registration. If you make changes to an image,
        /// deregister the previous image and register the new image.</para> <para><b>NOTE:</b> You can't register an image where a secondary (non-root)
        /// snapshot has AWS Marketplace product codes. </para>
        /// </summary>
        /// 
        /// <param name="registerImageRequest">Container for the necessary parameters to execute the RegisterImage service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the RegisterImage service method, as returned by AmazonEC2.</returns>
        /// 
        RegisterImageResponse RegisterImage(RegisterImageRequest registerImageRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterImage operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.RegisterImage"/>
        /// </summary>
        /// 
        /// <param name="registerImageRequest">Container for the necessary parameters to execute the RegisterImage operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegisterImage
        ///         operation.</returns>
        IAsyncResult BeginRegisterImage(RegisterImageRequest registerImageRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the RegisterImage operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.RegisterImage"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterImage.</param>
        /// 
        /// <returns>Returns a RegisterImageResult from AmazonEC2.</returns>
        RegisterImageResponse EndRegisterImage(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region ReleaseAddress

        /// <summary>
        /// <para>Releases the specified Elastic IP address.</para> <para>After releasing an Elastic IP address, it is released to the IP address pool
        /// and might be unavailable to you. Be sure to update your DNS records and any servers or devices that communicate with the address. If you
        /// attempt to release an Elastic IP address that you already released, you'll get an <c>AuthFailure</c> error if the address is already
        /// allocated to another AWS account.</para> <para>[EC2-Classic, default VPC] Releasing an Elastic IP address automatically disassociates it
        /// from any instance that it's associated with. To disassociate an Elastic IP address without releasing it, use DisassociateAddress.</para>
        /// <para>[Nondefault VPC] You must use the DisassociateAddress to disassociate the Elastic IP address before you try to release it. Otherwise,
        /// Amazon EC2 returns an error ( <c>InvalidIPAddress.InUse</c> ).</para>
        /// </summary>
        /// 
        /// <param name="releaseAddressRequest">Container for the necessary parameters to execute the ReleaseAddress service method on
        ///          AmazonEC2.</param>
        /// 
        ReleaseAddressResponse ReleaseAddress(ReleaseAddressRequest releaseAddressRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the ReleaseAddress operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ReleaseAddress"/>
        /// </summary>
        /// 
        /// <param name="releaseAddressRequest">Container for the necessary parameters to execute the ReleaseAddress operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginReleaseAddress(ReleaseAddressRequest releaseAddressRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the ReleaseAddress operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ReleaseAddress"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginReleaseAddress.</param>
        ReleaseAddressResponse EndReleaseAddress(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region ReplaceNetworkAclAssociation

        /// <summary>
        /// <para>Changes which network ACL a subnet is associated with. By default when you create a subnet, it's automatically associated with the
        /// default network ACL. For more information about network ACLs, see <a
        /// href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_ACLs.html" >Network ACLs</a> in the <i>Amazon Virtual Private Cloud User
        /// Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="replaceNetworkAclAssociationRequest">Container for the necessary parameters to execute the ReplaceNetworkAclAssociation service
        ///          method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the ReplaceNetworkAclAssociation service method, as returned by AmazonEC2.</returns>
        /// 
        ReplaceNetworkAclAssociationResponse ReplaceNetworkAclAssociation(ReplaceNetworkAclAssociationRequest replaceNetworkAclAssociationRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the ReplaceNetworkAclAssociation operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ReplaceNetworkAclAssociation"/>
        /// </summary>
        /// 
        /// <param name="replaceNetworkAclAssociationRequest">Container for the necessary parameters to execute the ReplaceNetworkAclAssociation
        ///          operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndReplaceNetworkAclAssociation operation.</returns>
        IAsyncResult BeginReplaceNetworkAclAssociation(ReplaceNetworkAclAssociationRequest replaceNetworkAclAssociationRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the ReplaceNetworkAclAssociation operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ReplaceNetworkAclAssociation"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginReplaceNetworkAclAssociation.</param>
        /// 
        /// <returns>Returns a ReplaceNetworkAclAssociationResult from AmazonEC2.</returns>
        ReplaceNetworkAclAssociationResponse EndReplaceNetworkAclAssociation(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region ReplaceNetworkAclEntry

        /// <summary>
        /// <para>Replaces an entry (rule) in a network ACL. For more information about network ACLs, see <a
        /// href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_ACLs.html" >Network ACLs</a> in the <i>Amazon Virtual Private Cloud User
        /// Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="replaceNetworkAclEntryRequest">Container for the necessary parameters to execute the ReplaceNetworkAclEntry service method on
        ///          AmazonEC2.</param>
        /// 
        ReplaceNetworkAclEntryResponse ReplaceNetworkAclEntry(ReplaceNetworkAclEntryRequest replaceNetworkAclEntryRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the ReplaceNetworkAclEntry operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ReplaceNetworkAclEntry"/>
        /// </summary>
        /// 
        /// <param name="replaceNetworkAclEntryRequest">Container for the necessary parameters to execute the ReplaceNetworkAclEntry operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginReplaceNetworkAclEntry(ReplaceNetworkAclEntryRequest replaceNetworkAclEntryRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the ReplaceNetworkAclEntry operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ReplaceNetworkAclEntry"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginReplaceNetworkAclEntry.</param>
        ReplaceNetworkAclEntryResponse EndReplaceNetworkAclEntry(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region ReplaceRoute

        /// <summary>
        /// <para>Replaces an existing route within a route table in a VPC. You must provide only one of the following: Internet gateway, NAT instance,
        /// or network interface.</para> <para>For more information about route tables, see <a
        /// href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Route_Tables.html" >Route Tables</a> in the <i>Amazon Virtual Private Cloud
        /// User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="replaceRouteRequest">Container for the necessary parameters to execute the ReplaceRoute service method on AmazonEC2.</param>
        /// 
        ReplaceRouteResponse ReplaceRoute(ReplaceRouteRequest replaceRouteRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the ReplaceRoute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ReplaceRoute"/>
        /// </summary>
        /// 
        /// <param name="replaceRouteRequest">Container for the necessary parameters to execute the ReplaceRoute operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginReplaceRoute(ReplaceRouteRequest replaceRouteRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the ReplaceRoute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ReplaceRoute"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginReplaceRoute.</param>
        ReplaceRouteResponse EndReplaceRoute(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region ReplaceRouteTableAssociation

        /// <summary>
        /// <para>Changes the route table associated with a given subnet in a VPC. After the operation completes, the subnet uses the routes in the new
        /// route table it's associated with. For more information about route tables, see <a
        /// href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Route_Tables.html" >Route Tables</a> in the <i>Amazon Virtual Private Cloud
        /// User Guide</i> .</para> <para>You can also use ReplaceRouteTableAssociation to change which table is the main route table in the VPC. You
        /// just specify the main route table's association ID and the route table to be the new main route table.</para>
        /// </summary>
        /// 
        /// <param name="replaceRouteTableAssociationRequest">Container for the necessary parameters to execute the ReplaceRouteTableAssociation service
        ///          method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the ReplaceRouteTableAssociation service method, as returned by AmazonEC2.</returns>
        /// 
        ReplaceRouteTableAssociationResponse ReplaceRouteTableAssociation(ReplaceRouteTableAssociationRequest replaceRouteTableAssociationRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the ReplaceRouteTableAssociation operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ReplaceRouteTableAssociation"/>
        /// </summary>
        /// 
        /// <param name="replaceRouteTableAssociationRequest">Container for the necessary parameters to execute the ReplaceRouteTableAssociation
        ///          operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndReplaceRouteTableAssociation operation.</returns>
        IAsyncResult BeginReplaceRouteTableAssociation(ReplaceRouteTableAssociationRequest replaceRouteTableAssociationRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the ReplaceRouteTableAssociation operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ReplaceRouteTableAssociation"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginReplaceRouteTableAssociation.</param>
        /// 
        /// <returns>Returns a ReplaceRouteTableAssociationResult from AmazonEC2.</returns>
        ReplaceRouteTableAssociationResponse EndReplaceRouteTableAssociation(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region ReportInstanceStatus

        /// <summary>
        /// <para>Submits feedback about the status of an instance. The instance must be in the <c>running</c> state. If your experience with the
        /// instance differs from the instance status returned by DescribeInstanceStatus, use ReportInstanceStatus to report your experience with the
        /// instance. Amazon EC2 collects this information to improve the accuracy of status checks.</para>
        /// </summary>
        /// 
        /// <param name="reportInstanceStatusRequest">Container for the necessary parameters to execute the ReportInstanceStatus service method on
        ///          AmazonEC2.</param>
        /// 
        ReportInstanceStatusResponse ReportInstanceStatus(ReportInstanceStatusRequest reportInstanceStatusRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the ReportInstanceStatus operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ReportInstanceStatus"/>
        /// </summary>
        /// 
        /// <param name="reportInstanceStatusRequest">Container for the necessary parameters to execute the ReportInstanceStatus operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginReportInstanceStatus(ReportInstanceStatusRequest reportInstanceStatusRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the ReportInstanceStatus operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ReportInstanceStatus"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginReportInstanceStatus.</param>
        ReportInstanceStatusResponse EndReportInstanceStatus(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region RequestSpotInstances

        /// <summary>
        /// <para>Creates a Spot Instance request. Spot Instances are instances that Amazon EC2 starts on your behalf when the maximum price that you
        /// specify exceeds the current Spot Price. Amazon EC2 periodically sets the Spot Price based on available Spot Instance capacity and current
        /// Spot Instance requests. For more information about Spot Instances, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-spot-instances.html" >Spot Instances</a> in the <i>Amazon Elastic Compute
        /// Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="requestSpotInstancesRequest">Container for the necessary parameters to execute the RequestSpotInstances service method on
        ///          AmazonEC2.</param>
        /// 
        /// <returns>The response from the RequestSpotInstances service method, as returned by AmazonEC2.</returns>
        /// 
        RequestSpotInstancesResponse RequestSpotInstances(RequestSpotInstancesRequest requestSpotInstancesRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the RequestSpotInstances operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.RequestSpotInstances"/>
        /// </summary>
        /// 
        /// <param name="requestSpotInstancesRequest">Container for the necessary parameters to execute the RequestSpotInstances operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndRequestSpotInstances operation.</returns>
        IAsyncResult BeginRequestSpotInstances(RequestSpotInstancesRequest requestSpotInstancesRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the RequestSpotInstances operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.RequestSpotInstances"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRequestSpotInstances.</param>
        /// 
        /// <returns>Returns a RequestSpotInstancesResult from AmazonEC2.</returns>
        RequestSpotInstancesResponse EndRequestSpotInstances(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region ResetImageAttribute

        /// <summary>
        /// <para>Resets an attribute of an AMI to its default value.</para>
        /// </summary>
        /// 
        /// <param name="resetImageAttributeRequest">Container for the necessary parameters to execute the ResetImageAttribute service method on
        ///          AmazonEC2.</param>
        /// 
        ResetImageAttributeResponse ResetImageAttribute(ResetImageAttributeRequest resetImageAttributeRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the ResetImageAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ResetImageAttribute"/>
        /// </summary>
        /// 
        /// <param name="resetImageAttributeRequest">Container for the necessary parameters to execute the ResetImageAttribute operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginResetImageAttribute(ResetImageAttributeRequest resetImageAttributeRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the ResetImageAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ResetImageAttribute"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResetImageAttribute.</param>
        ResetImageAttributeResponse EndResetImageAttribute(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region ResetInstanceAttribute

        /// <summary>
        /// <para>Resets an attribute of an instance to its default value. To reset the kernel or RAM disk, the instance must be in a stopped state. To
        /// reset the <c>SourceDestCheck</c> , the instance can be either running or stopped.</para> <para>The <c>SourceDestCheck</c> attribute controls
        /// whether source/destination checking is enabled. The default value is <c>true</c> , which means checking is enabled. This value must be
        /// <c>false</c> for a NAT instance to perform NAT. For more information, see <a
        /// href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_NAT_Instance.html" >NAT Instances</a> in the <i>Amazon Virtual Private Cloud
        /// User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="resetInstanceAttributeRequest">Container for the necessary parameters to execute the ResetInstanceAttribute service method on
        ///          AmazonEC2.</param>
        /// 
        ResetInstanceAttributeResponse ResetInstanceAttribute(ResetInstanceAttributeRequest resetInstanceAttributeRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the ResetInstanceAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ResetInstanceAttribute"/>
        /// </summary>
        /// 
        /// <param name="resetInstanceAttributeRequest">Container for the necessary parameters to execute the ResetInstanceAttribute operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginResetInstanceAttribute(ResetInstanceAttributeRequest resetInstanceAttributeRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the ResetInstanceAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ResetInstanceAttribute"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResetInstanceAttribute.</param>
        ResetInstanceAttributeResponse EndResetInstanceAttribute(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region ResetNetworkInterfaceAttribute

        /// <summary>
        /// <para>Resets a network interface attribute. You can specify only one attribute at a time.</para>
        /// </summary>
        /// 
        /// <param name="resetNetworkInterfaceAttributeRequest">Container for the necessary parameters to execute the ResetNetworkInterfaceAttribute
        ///          service method on AmazonEC2.</param>
        /// 
        ResetNetworkInterfaceAttributeResponse ResetNetworkInterfaceAttribute(ResetNetworkInterfaceAttributeRequest resetNetworkInterfaceAttributeRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the ResetNetworkInterfaceAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ResetNetworkInterfaceAttribute"/>
        /// </summary>
        /// 
        /// <param name="resetNetworkInterfaceAttributeRequest">Container for the necessary parameters to execute the ResetNetworkInterfaceAttribute
        ///          operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginResetNetworkInterfaceAttribute(ResetNetworkInterfaceAttributeRequest resetNetworkInterfaceAttributeRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the ResetNetworkInterfaceAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ResetNetworkInterfaceAttribute"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResetNetworkInterfaceAttribute.</param>
        ResetNetworkInterfaceAttributeResponse EndResetNetworkInterfaceAttribute(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region ResetSnapshotAttribute

        /// <summary>
        /// <para>Resets permission settings for the specified snapshot.</para> <para>For more information on modifying snapshot permissions, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-modifying-snapshot-permissions.html" >Sharing Snapshots</a> in the <i>Amazon
        /// Elastic Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="resetSnapshotAttributeRequest">Container for the necessary parameters to execute the ResetSnapshotAttribute service method on
        ///          AmazonEC2.</param>
        /// 
        ResetSnapshotAttributeResponse ResetSnapshotAttribute(ResetSnapshotAttributeRequest resetSnapshotAttributeRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the ResetSnapshotAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ResetSnapshotAttribute"/>
        /// </summary>
        /// 
        /// <param name="resetSnapshotAttributeRequest">Container for the necessary parameters to execute the ResetSnapshotAttribute operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginResetSnapshotAttribute(ResetSnapshotAttributeRequest resetSnapshotAttributeRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the ResetSnapshotAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ResetSnapshotAttribute"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResetSnapshotAttribute.</param>
        ResetSnapshotAttributeResponse EndResetSnapshotAttribute(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region RevokeSecurityGroupEgress

        /// <summary>
        /// <para>Removes one or more egress rules from a security group for EC2-VPC. The values that you specify in the revoke request (for example,
        /// ports) must match the existing rule's values for the rule to be revoked.</para> <para>Each rule consists of the protocol and the CIDR range
        /// or source security group. For the TCP and UDP protocols, you must also specify the destination port or range of ports. For the ICMP
        /// protocol, you must also specify the ICMP type and code.</para> <para>Rule changes are propagated to instances within the security group as
        /// quickly as possible. However, a small delay might occur.</para>
        /// </summary>
        /// 
        /// <param name="revokeSecurityGroupEgressRequest">Container for the necessary parameters to execute the RevokeSecurityGroupEgress service
        ///          method on AmazonEC2.</param>
        /// 
        RevokeSecurityGroupEgressResponse RevokeSecurityGroupEgress(RevokeSecurityGroupEgressRequest revokeSecurityGroupEgressRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the RevokeSecurityGroupEgress operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.RevokeSecurityGroupEgress"/>
        /// </summary>
        /// 
        /// <param name="revokeSecurityGroupEgressRequest">Container for the necessary parameters to execute the RevokeSecurityGroupEgress operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginRevokeSecurityGroupEgress(RevokeSecurityGroupEgressRequest revokeSecurityGroupEgressRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the RevokeSecurityGroupEgress operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.RevokeSecurityGroupEgress"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRevokeSecurityGroupEgress.</param>
        RevokeSecurityGroupEgressResponse EndRevokeSecurityGroupEgress(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region RevokeSecurityGroupIngress

        /// <summary>
        /// <para>Removes one or more ingress rules from a security group. The values that you specify in the revoke request (for example, ports) must
        /// match the existing rule's values for the rule to be removed.</para> <para>Each rule consists of the protocol and the CIDR range or source
        /// security group. For the TCP and UDP protocols, you must also specify the destination port or range of ports. For the ICMP protocol, you must
        /// also specify the ICMP type and code.</para> <para>Rule changes are propagated to instances within the security group as quickly as possible.
        /// However, a small delay might occur.</para>
        /// </summary>
        /// 
        /// <param name="revokeSecurityGroupIngressRequest">Container for the necessary parameters to execute the RevokeSecurityGroupIngress service
        ///          method on AmazonEC2.</param>
        /// 
        RevokeSecurityGroupIngressResponse RevokeSecurityGroupIngress(RevokeSecurityGroupIngressRequest revokeSecurityGroupIngressRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the RevokeSecurityGroupIngress operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.RevokeSecurityGroupIngress"/>
        /// </summary>
        /// 
        /// <param name="revokeSecurityGroupIngressRequest">Container for the necessary parameters to execute the RevokeSecurityGroupIngress operation
        ///          on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginRevokeSecurityGroupIngress(RevokeSecurityGroupIngressRequest revokeSecurityGroupIngressRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the RevokeSecurityGroupIngress operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.RevokeSecurityGroupIngress"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRevokeSecurityGroupIngress.</param>
        RevokeSecurityGroupIngressResponse EndRevokeSecurityGroupIngress(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region RunInstances

        /// <summary>
        /// <para>Launches the specified number of instances using an AMI for which you have permissions.</para> <para>When you launch an instance, it
        /// enters the <c>pending</c> state. After the instance is ready for you, it enters the <c>running</c> state. To check the state of your
        /// instance, call DescribeInstances.</para> <para>If you don't specify a security group when launching an instance, Amazon EC2 uses the default
        /// security group. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-network-security.html" >Security
        /// Groups</a> in the <i>Amazon Elastic Compute Cloud User Guide</i> .</para> <para>Linux instances have access to the public key of the key
        /// pair at boot. You can use this key to provide secure access to the instance. Amazon EC2 public images use this feature to provide secure
        /// access without passwords. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-key-pairs.html" >Key
        /// Pairs</a> in the <i>Amazon Elastic Compute Cloud User Guide</i> .</para> <para>You can provide optional user data when launching an
        /// instance. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/AESDG-chapter-instancedata.html" >Instance
        /// Metadata</a> in the <i>Amazon Elastic Compute Cloud User Guide</i> .</para> <para>If any of the AMIs have a product code attached for which
        /// the user has not subscribed, <c>RunInstances</c> fails.</para>
        /// </summary>
        /// 
        /// <param name="runInstancesRequest">Container for the necessary parameters to execute the RunInstances service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the RunInstances service method, as returned by AmazonEC2.</returns>
        /// 
        RunInstancesResponse RunInstances(RunInstancesRequest runInstancesRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the RunInstances operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.RunInstances"/>
        /// </summary>
        /// 
        /// <param name="runInstancesRequest">Container for the necessary parameters to execute the RunInstances operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRunInstances
        ///         operation.</returns>
        IAsyncResult BeginRunInstances(RunInstancesRequest runInstancesRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the RunInstances operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.RunInstances"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRunInstances.</param>
        /// 
        /// <returns>Returns a RunInstancesResult from AmazonEC2.</returns>
        RunInstancesResponse EndRunInstances(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region StartInstances

        /// <summary>
        /// <para>Starts an Amazon EBS-backed AMI that you've previously stopped.</para> <para>Instances that use Amazon EBS volumes as their root
        /// devices can be quickly stopped and started. When an instance is stopped, the compute resources are released and you are not billed for
        /// hourly instance usage. However, your root partition Amazon EBS volume remains, continues to persist your data, and you are charged for
        /// Amazon EBS volume usage. You can restart your instance at any time. Each time you transition an instance from stopped to started, Amazon EC2
        /// charges a full instance hour, even if transitions happen multiple times within a single hour.</para> <para>Before stopping an instance, make
        /// sure it is in a state from which it can be restarted. Stopping an instance does not preserve data stored in RAM.</para> <para>Performing
        /// this operation on an instance that uses an instance store as its root device returns an error.</para> <para>For more information, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Stop_Start.html" >Stopping Instances</a> in the <i>Amazon Elastic Compute Cloud
        /// User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="startInstancesRequest">Container for the necessary parameters to execute the StartInstances service method on
        ///          AmazonEC2.</param>
        /// 
        /// <returns>The response from the StartInstances service method, as returned by AmazonEC2.</returns>
        /// 
        StartInstancesResponse StartInstances(StartInstancesRequest startInstancesRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the StartInstances operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.StartInstances"/>
        /// </summary>
        /// 
        /// <param name="startInstancesRequest">Container for the necessary parameters to execute the StartInstances operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartInstances
        ///         operation.</returns>
        IAsyncResult BeginStartInstances(StartInstancesRequest startInstancesRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the StartInstances operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.StartInstances"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartInstances.</param>
        /// 
        /// <returns>Returns a StartInstancesResult from AmazonEC2.</returns>
        StartInstancesResponse EndStartInstances(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region StopInstances

        /// <summary>
        /// <para>Stops an Amazon EBS-backed instance. Each time you transition an instance from stopped to started, Amazon EC2 charges a full instance
        /// hour, even if transitions happen multiple times within a single hour.</para> <para>You can't start or stop Spot Instances.</para>
        /// <para>Instances that use Amazon EBS volumes as their root devices can be quickly stopped and started. When an instance is stopped, the
        /// compute resources are released and you are not billed for hourly instance usage. However, your root partition Amazon EBS volume remains,
        /// continues to persist your data, and you are charged for Amazon EBS volume usage. You can restart your instance at any time.</para>
        /// <para>Before stopping an instance, make sure it is in a state from which it can be restarted. Stopping an instance does not preserve data
        /// stored in RAM.</para> <para>Performing this operation on an instance that uses an instance store as its root device returns an error.</para>
        /// <para>You can stop, start, and terminate EBS-backed instances. You can only terminate instance store-backed instances. What happens to an
        /// instance differs if you stop it or terminate it. For example, when you stop an instance, the root device and any other devices attached to
        /// the instance persist. When you terminate an instance, the root device and any other devices attached during the instance launch are
        /// automatically deleted. For more information about the differences between stopping and terminating instances, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-instance-lifecycle.html" >Instance Lifecycle</a> in the <i>Amazon Elastic
        /// Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="stopInstancesRequest">Container for the necessary parameters to execute the StopInstances service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the StopInstances service method, as returned by AmazonEC2.</returns>
        /// 
        StopInstancesResponse StopInstances(StopInstancesRequest stopInstancesRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the StopInstances operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.StopInstances"/>
        /// </summary>
        /// 
        /// <param name="stopInstancesRequest">Container for the necessary parameters to execute the StopInstances operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopInstances
        ///         operation.</returns>
        IAsyncResult BeginStopInstances(StopInstancesRequest stopInstancesRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the StopInstances operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.StopInstances"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopInstances.</param>
        /// 
        /// <returns>Returns a StopInstancesResult from AmazonEC2.</returns>
        StopInstancesResponse EndStopInstances(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region TerminateInstances

        /// <summary>
        /// <para>Shuts down one or more instances. This operation is idempotent; if you terminate an instance more than once, each call
        /// succeeds.</para> <para>Terminated instances remain visible after termination (for approximately one hour).</para> <para>By default, Amazon
        /// EC2 deletes all Amazon EBS volumes that were attached when the instance launched. Volumes attached after instance launch continue
        /// running.</para> <para>You can stop, start, and terminate EBS-backed instances. You can only terminate instance store-backed instances. What
        /// happens to an instance differs if you stop it or terminate it. For example, when you stop an instance, the root device and any other devices
        /// attached to the instance persist. When you terminate an instance, the root device and any other devices attached during the instance launch
        /// are automatically deleted. For more information about the differences between stopping and terminating instances, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-instance-lifecycle.html" >Instance Lifecycle</a> in the <i>Amazon Elastic
        /// Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="terminateInstancesRequest">Container for the necessary parameters to execute the TerminateInstances service method on
        ///          AmazonEC2.</param>
        /// 
        /// <returns>The response from the TerminateInstances service method, as returned by AmazonEC2.</returns>
        /// 
        TerminateInstancesResponse TerminateInstances(TerminateInstancesRequest terminateInstancesRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the TerminateInstances operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.TerminateInstances"/>
        /// </summary>
        /// 
        /// <param name="terminateInstancesRequest">Container for the necessary parameters to execute the TerminateInstances operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndTerminateInstances operation.</returns>
        IAsyncResult BeginTerminateInstances(TerminateInstancesRequest terminateInstancesRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the TerminateInstances operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.TerminateInstances"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTerminateInstances.</param>
        /// 
        /// <returns>Returns a TerminateInstancesResult from AmazonEC2.</returns>
        TerminateInstancesResponse EndTerminateInstances(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region UnassignPrivateIpAddresses

        /// <summary>
        /// <para>Unassigns one or more secondary private IP addresses from a network interface.</para>
        /// </summary>
        /// 
        /// <param name="unassignPrivateIpAddressesRequest">Container for the necessary parameters to execute the UnassignPrivateIpAddresses service
        ///          method on AmazonEC2.</param>
        /// 
        UnassignPrivateIpAddressesResponse UnassignPrivateIpAddresses(UnassignPrivateIpAddressesRequest unassignPrivateIpAddressesRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the UnassignPrivateIpAddresses operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.UnassignPrivateIpAddresses"/>
        /// </summary>
        /// 
        /// <param name="unassignPrivateIpAddressesRequest">Container for the necessary parameters to execute the UnassignPrivateIpAddresses operation
        ///          on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        IAsyncResult BeginUnassignPrivateIpAddresses(UnassignPrivateIpAddressesRequest unassignPrivateIpAddressesRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the UnassignPrivateIpAddresses operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.UnassignPrivateIpAddresses"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUnassignPrivateIpAddresses.</param>
        UnassignPrivateIpAddressesResponse EndUnassignPrivateIpAddresses(IAsyncResult asyncResult);
        
        #endregion
        
    

        #region UnmonitorInstances

        /// <summary>
        /// <para>Disables monitoring for a running instance. For more information about monitoring instances, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-cloudwatch.html" >Monitoring Your Instances and Volumes</a> in the <i>Amazon
        /// Elastic Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="unmonitorInstancesRequest">Container for the necessary parameters to execute the UnmonitorInstances service method on
        ///          AmazonEC2.</param>
        /// 
        /// <returns>The response from the UnmonitorInstances service method, as returned by AmazonEC2.</returns>
        /// 
        UnmonitorInstancesResponse UnmonitorInstances(UnmonitorInstancesRequest unmonitorInstancesRequest);

        /// <summary>
        /// Initiates the asynchronous execution of the UnmonitorInstances operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.UnmonitorInstances"/>
        /// </summary>
        /// 
        /// <param name="unmonitorInstancesRequest">Container for the necessary parameters to execute the UnmonitorInstances operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndUnmonitorInstances operation.</returns>
        IAsyncResult BeginUnmonitorInstances(UnmonitorInstancesRequest unmonitorInstancesRequest, AsyncCallback callback, object state);

        /// <summary>
        /// Finishes the asynchronous execution of the UnmonitorInstances operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.UnmonitorInstances"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUnmonitorInstances.</param>
        /// 
        /// <returns>Returns a UnmonitorInstancesResult from AmazonEC2.</returns>
        UnmonitorInstancesResponse EndUnmonitorInstances(IAsyncResult asyncResult);
        
        #endregion
        
    
    }
}
    
