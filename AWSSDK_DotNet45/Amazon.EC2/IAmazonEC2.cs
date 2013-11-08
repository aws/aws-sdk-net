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

using Amazon.EC2.Model;

namespace Amazon.EC2
{
    /// <summary>
    /// Interface for accessing AmazonEC2.
    /// 
    /// <para> Amazon Elastic Compute Cloud (Amazon EC2) is a web service that provides resizable compute capacity in the cloud. It is designed to
    /// make web-scale computing easier for developers. </para> <para> Amazon EC2's simple web service interface allows you to obtain and configure
    /// capacity with minimal friction. It provides you with complete control of your computing resources and lets you run on Amazon's proven
    /// computing environment. Amazon EC2 reduces the time required to obtain and boot new server instances to minutes, allowing you to quickly
    /// scale capacity, both up and down, as your computing requirements change. Amazon EC2 changes the economics of computing by allowing you to
    /// pay only for capacity that you actually use. Amazon EC2 provides developers the tools to build failure resilient applications and isolate
    /// themselves from common failure scenarios. </para> <para> Visit <a href="http://aws.amazon.com/ec2/">http://aws.amazon.com/ec2/</a> for more
    /// information. </para>
    /// </summary>
	public partial interface IAmazonEC2 : IDisposable
    {
 

        /// <summary>
        /// <para> The AllocateAddress operation acquires an elastic IP address for use with your account. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AllocateAddress service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the AllocateAddress service method, as returned by AmazonEC2.</returns>
		AllocateAddressResponse AllocateAddress(AllocateAddressRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AllocateAddress operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.AllocateAddress"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AllocateAddress operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<AllocateAddressResponse> AllocateAddressAsync(AllocateAddressRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> The AllocateAddress operation acquires an elastic IP address for use with your account. </para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the AllocateAddress service method, as returned by AmazonEC2.</returns>
		AllocateAddressResponse AllocateAddress();
 

        /// <summary>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssignPrivateIpAddresses service method
        /// on AmazonEC2.</param>
		AssignPrivateIpAddressesResponse AssignPrivateIpAddresses(AssignPrivateIpAddressesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssignPrivateIpAddresses operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.AssignPrivateIpAddresses"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssignPrivateIpAddresses operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<AssignPrivateIpAddressesResponse> AssignPrivateIpAddressesAsync(AssignPrivateIpAddressesRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> The AssociateAddress operation associates an elastic IP address with an instance. </para> <para> If the IP address is currently
        /// assigned to another instance, the IP address is assigned to the new instance. This is an idempotent operation. If you enter it more than
        /// once, Amazon EC2 does not return an error. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateAddress service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the AssociateAddress service method, as returned by AmazonEC2.</returns>
		AssociateAddressResponse AssociateAddress(AssociateAddressRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateAddress operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.AssociateAddress"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateAddress operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<AssociateAddressResponse> AssociateAddressAsync(AssociateAddressRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Associates a set of DHCP options (that you've previously created) with the specified VPC. Or, associates the default DHCP options
        /// with the VPC. The default set consists of the standard EC2 host name, no domain name, no DNS server, no NTP server, and no NetBIOS server or
        /// node type. After you associate the options with the VPC, any existing instances and all new instances that you launch in that VPC use the
        /// options. For more information about the supported DHCP options and using them with Amazon VPC, go to Using DHCP Options in the Amazon
        /// Virtual Private Cloud Developer Guide. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateDhcpOptions service method on
        /// AmazonEC2.</param>
		AssociateDhcpOptionsResponse AssociateDhcpOptions(AssociateDhcpOptionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateDhcpOptions operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.AssociateDhcpOptions"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateDhcpOptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<AssociateDhcpOptionsResponse> AssociateDhcpOptionsAsync(AssociateDhcpOptionsRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Associates a subnet with a route table. The subnet and route table must be in the same VPC. This association causes traffic
        /// originating from the subnet to be routed according to the routes in the route table. The action returns an association ID, which you need if
        /// you want to disassociate the route table from the subnet later. A route table can be associated with multiple subnets. </para> <para> For
        /// more information about route tables, go to <a href="http://docs.amazonwebservices.com/AmazonVPC/latest/UserGuide/VPC_Route_Tables.html">Route Tables</a> in the Amazon Virtual Private Cloud User Guide. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateRouteTable service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the AssociateRouteTable service method, as returned by AmazonEC2.</returns>
		AssociateRouteTableResponse AssociateRouteTable(AssociateRouteTableRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateRouteTable operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.AssociateRouteTable"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateRouteTable operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<AssociateRouteTableResponse> AssociateRouteTableAsync(AssociateRouteTableRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Attaches an Internet gateway to a VPC, enabling connectivity between the Internet and the VPC. For more information about your VPC
        /// and Internet gateway, go to the Amazon Virtual Private Cloud User Guide. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachInternetGateway service method on
        /// AmazonEC2.</param>
		AttachInternetGatewayResponse AttachInternetGateway(AttachInternetGatewayRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AttachInternetGateway operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.AttachInternetGateway"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachInternetGateway operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<AttachInternetGatewayResponse> AttachInternetGatewayAsync(AttachInternetGatewayRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachNetworkInterface service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the AttachNetworkInterface service method, as returned by AmazonEC2.</returns>
		AttachNetworkInterfaceResponse AttachNetworkInterface(AttachNetworkInterfaceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AttachNetworkInterface operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.AttachNetworkInterface"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachNetworkInterface operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<AttachNetworkInterfaceResponse> AttachNetworkInterfaceAsync(AttachNetworkInterfaceRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Attach a previously created volume to a running instance. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachVolume service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the AttachVolume service method, as returned by AmazonEC2.</returns>
		AttachVolumeResponse AttachVolume(AttachVolumeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AttachVolume operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.AttachVolume"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachVolume operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<AttachVolumeResponse> AttachVolumeAsync(AttachVolumeRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Attaches a VPN gateway to a VPC. This is the last step required to get your VPC fully connected to your data center before launching
        /// instances in it. For more information, go to Process for Using Amazon VPC in the Amazon Virtual Private Cloud Developer Guide. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachVpnGateway service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the AttachVpnGateway service method, as returned by AmazonEC2.</returns>
		AttachVpnGatewayResponse AttachVpnGateway(AttachVpnGatewayRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AttachVpnGateway operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.AttachVpnGateway"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachVpnGateway operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<AttachVpnGatewayResponse> AttachVpnGatewayAsync(AttachVpnGatewayRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> This action applies only to security groups in a VPC; it's not supported for EC2 security groups. For information about Amazon
        /// Virtual Private Cloud and VPC security groups, go to the Amazon Virtual Private Cloud User Guide. </para> <para> The action adds one or more
        /// egress rules to a VPC security group. Specifically, this permits instances in a security group to send traffic to either one or more
        /// destination CIDR IP address ranges, or to one or more destination security groups in the same VPC. </para> <para> Each rule consists of the
        /// protocol (e.g., TCP), plus either a CIDR range, or a source group. For the TCP and UDP protocols, you must also specify the destination port
        /// or port range. For the ICMP protocol, you must also specify the ICMP type and code. You can use <c>-1</c> as a wildcard for the ICMP type or
        /// code. </para> <para> Rule changes are propagated to instances within the security group as quickly as possible. However, a small delay might
        /// occur. </para> <para> <b>Important:</b> For VPC security groups: You can have up to 50 rules total per group (covering both ingress and
        /// egress). </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AuthorizeSecurityGroupEgress service
        /// method on AmazonEC2.</param>
		AuthorizeSecurityGroupEgressResponse AuthorizeSecurityGroupEgress(AuthorizeSecurityGroupEgressRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AuthorizeSecurityGroupEgress operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.AuthorizeSecurityGroupEgress"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AuthorizeSecurityGroupEgress operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<AuthorizeSecurityGroupEgressResponse> AuthorizeSecurityGroupEgressAsync(AuthorizeSecurityGroupEgressRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> The AuthorizeSecurityGroupIngress operation adds permissions to a security group. </para> <para> Permissions are specified by the IP
        /// protocol (TCP, UDP or ICMP), the source of the request (by IP range or an Amazon EC2 user-group pair), the source and destination port
        /// ranges (for TCP and UDP), and the ICMP codes and types (for ICMP). When authorizing ICMP, <c>-1</c> can be used as a wildcard in the type
        /// and code fields. </para> <para> Permission changes are propagated to instances within the security group as quickly as possible. However,
        /// depending on the number of instances, a small delay might occur. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AuthorizeSecurityGroupIngress
        /// service method on AmazonEC2.</param>
		AuthorizeSecurityGroupIngressResponse AuthorizeSecurityGroupIngress(AuthorizeSecurityGroupIngressRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the AuthorizeSecurityGroupIngress operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.AuthorizeSecurityGroupIngress"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AuthorizeSecurityGroupIngress operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<AuthorizeSecurityGroupIngressResponse> AuthorizeSecurityGroupIngressAsync(AuthorizeSecurityGroupIngressRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> The BundleInstance operation request that an instance is bundled the next time it boots. The bundling process creates a new image
        /// from a running instance and stores the AMI data in S3. Once bundled, the image must be registered in the normal way using the RegisterImage
        /// API. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BundleInstance service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the BundleInstance service method, as returned by AmazonEC2.</returns>
		BundleInstanceResponse BundleInstance(BundleInstanceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the BundleInstance operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.BundleInstance"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BundleInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<BundleInstanceResponse> BundleInstanceAsync(BundleInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> CancelBundleTask operation cancels a pending or in-progress bundling task. This is an asynchronous call and it make take a while for
        /// the task to be canceled. If a task is canceled while it is storing items, there may be parts of the incomplete AMI stored in S3. It is up to
        /// the caller to clean up these parts from S3. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelBundleTask service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the CancelBundleTask service method, as returned by AmazonEC2.</returns>
		CancelBundleTaskResponse CancelBundleTask(CancelBundleTaskRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CancelBundleTask operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CancelBundleTask"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelBundleTask operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<CancelBundleTaskResponse> CancelBundleTaskAsync(CancelBundleTaskRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelConversionTask service method on
        /// AmazonEC2.</param>
		CancelConversionTaskResponse CancelConversionTask(CancelConversionTaskRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CancelConversionTask operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CancelConversionTask"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelConversionTask operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<CancelConversionTaskResponse> CancelConversionTaskAsync(CancelConversionTaskRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelExportTask service method on
        /// AmazonEC2.</param>
		CancelExportTaskResponse CancelExportTask(CancelExportTaskRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CancelExportTask operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CancelExportTask"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelExportTask operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<CancelExportTaskResponse> CancelExportTaskAsync(CancelExportTaskRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelReservedInstancesListing
        /// service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the CancelReservedInstancesListing service method, as returned by AmazonEC2.</returns>
		CancelReservedInstancesListingResponse CancelReservedInstancesListing(CancelReservedInstancesListingRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CancelReservedInstancesListing operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CancelReservedInstancesListing"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelReservedInstancesListing operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<CancelReservedInstancesListingResponse> CancelReservedInstancesListingAsync(CancelReservedInstancesListingRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Cancels one or more Spot Instance requests. </para> <para> Spot Instances are instances that Amazon EC2 starts on your behalf when
        /// the maximum price that you specify exceeds the current Spot Price. Amazon EC2 periodically sets the Spot Price based on available Spot
        /// Instance capacity and current spot instance requests. </para> <para> For conceptual information about Spot Instances, refer to the Amazon
        /// Elastic Compute Cloud Developer Guide or Amazon Elastic Compute Cloud User Guide .
        /// </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelSpotInstanceRequests service
        /// method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the CancelSpotInstanceRequests service method, as returned by AmazonEC2.</returns>
		CancelSpotInstanceRequestsResponse CancelSpotInstanceRequests(CancelSpotInstanceRequestsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CancelSpotInstanceRequests operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CancelSpotInstanceRequests"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelSpotInstanceRequests operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<CancelSpotInstanceRequestsResponse> CancelSpotInstanceRequestsAsync(CancelSpotInstanceRequestsRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> The ConfirmProductInstance operation returns true if the specified product code is attached to the specified instance. The operation
        /// returns false if the product code is not attached to the instance. </para> <para> The ConfirmProductInstance operation can only be executed
        /// by the owner of the AMI. This feature is useful when an AMI owner is providing support and wants to verify whether a user's instance is
        /// eligible. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ConfirmProductInstance service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the ConfirmProductInstance service method, as returned by AmazonEC2.</returns>
		ConfirmProductInstanceResponse ConfirmProductInstance(ConfirmProductInstanceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ConfirmProductInstance operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ConfirmProductInstance"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ConfirmProductInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<ConfirmProductInstanceResponse> ConfirmProductInstanceAsync(ConfirmProductInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopyImage service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the CopyImage service method, as returned by AmazonEC2.</returns>
		CopyImageResponse CopyImage(CopyImageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CopyImage operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CopyImage"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopyImage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<CopyImageResponse> CopyImageAsync(CopyImageRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopySnapshot service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the CopySnapshot service method, as returned by AmazonEC2.</returns>
		CopySnapshotResponse CopySnapshot(CopySnapshotRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CopySnapshot operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CopySnapshot"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopySnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<CopySnapshotResponse> CopySnapshotAsync(CopySnapshotRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Provides information to AWS about your customer gateway device. The customer gateway is the appliance at your end of the VPN
        /// connection (compared to the VPN gateway, which is the device at the AWS side of the VPN connection). You can have a single active customer
        /// gateway per AWS account (active means that you've created a VPN connection to use with the customer gateway). AWS might delete any customer
        /// gateway that you create with this operation if you leave it inactive for an extended period of time. </para> <para> You must provide the
        /// Internet-routable IP address of the customer gateway's external interface. The IP address must be static. </para> <para> You must also
        /// provide the device's Border Gateway Protocol (BGP) Autonomous System Number (ASN). You can use an existing ASN assigned to your network. If
        /// you don't have an ASN already, you can use a private ASN (in the 64512 - 65534 range). For more information about ASNs, go to <a href="http://en.wikipedia.org/wiki/Autonomous_system_%28Internet%29"> http://en.wikipedia.org/wiki/Autonomous_system_%28Internet%29</a> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCustomerGateway service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the CreateCustomerGateway service method, as returned by AmazonEC2.</returns>
		CreateCustomerGatewayResponse CreateCustomerGateway(CreateCustomerGatewayRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCustomerGateway operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateCustomerGateway"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCustomerGateway operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<CreateCustomerGatewayResponse> CreateCustomerGatewayAsync(CreateCustomerGatewayRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Creates a set of DHCP options that you can then associate with one or more VPCs, causing all existing and new instances that you
        /// launch in those VPCs to use the set of DHCP options. The following table lists the individual DHCP options you can specify. For more
        /// information about the options, go to <a href="http://www.ietf.org/rfc/rfc2132.txt">http://www.ietf.org/rfc/rfc2132.txt</a> </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDhcpOptions service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the CreateDhcpOptions service method, as returned by AmazonEC2.</returns>
		CreateDhcpOptionsResponse CreateDhcpOptions(CreateDhcpOptionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDhcpOptions operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateDhcpOptions"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDhcpOptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<CreateDhcpOptionsResponse> CreateDhcpOptionsAsync(CreateDhcpOptionsRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Creates an Amazon EBS-backed AMI from a "running" or "stopped" instance. AMIs that use an Amazon EBS root device boot faster than
        /// AMIs that use instance stores. They can be up to 1 TiB in size, use storage that persists on instance failure, and can be stopped and
        /// started. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateImage service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the CreateImage service method, as returned by AmazonEC2.</returns>
		CreateImageResponse CreateImage(CreateImageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateImage operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateImage"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateImage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<CreateImageResponse> CreateImageAsync(CreateImageRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateInstanceExportTask service method
        /// on AmazonEC2.</param>
        /// 
        /// <returns>The response from the CreateInstanceExportTask service method, as returned by AmazonEC2.</returns>
		CreateInstanceExportTaskResponse CreateInstanceExportTask(CreateInstanceExportTaskRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateInstanceExportTask operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateInstanceExportTask"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateInstanceExportTask operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<CreateInstanceExportTaskResponse> CreateInstanceExportTaskAsync(CreateInstanceExportTaskRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Creates a new Internet gateway in your AWS account. After creating the Internet gateway, you then attach it to a VPC using
        /// <c>AttachInternetGateway</c> . For more information about your VPC and Internet gateway, go to Amazon Virtual Private Cloud User Guide.
        /// </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateInternetGateway service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the CreateInternetGateway service method, as returned by AmazonEC2.</returns>
		CreateInternetGatewayResponse CreateInternetGateway(CreateInternetGatewayRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateInternetGateway operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateInternetGateway"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateInternetGateway operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<CreateInternetGatewayResponse> CreateInternetGatewayAsync(CreateInternetGatewayRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Creates a new Internet gateway in your AWS account. After creating the Internet gateway, you then attach it to a VPC using
        /// <c>AttachInternetGateway</c> . For more information about your VPC and Internet gateway, go to Amazon Virtual Private Cloud User Guide.
        /// </para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the CreateInternetGateway service method, as returned by AmazonEC2.</returns>
		CreateInternetGatewayResponse CreateInternetGateway();
 

        /// <summary>
        /// <para> The CreateKeyPair operation creates a new 2048 bit RSA key pair and returns a unique ID that can be used to reference this key pair
        /// when launching new instances. For more information, see RunInstances. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateKeyPair service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the CreateKeyPair service method, as returned by AmazonEC2.</returns>
		CreateKeyPairResponse CreateKeyPair(CreateKeyPairRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateKeyPair operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateKeyPair"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateKeyPair operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<CreateKeyPairResponse> CreateKeyPairAsync(CreateKeyPairRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Creates a new network ACL in a VPC. Network ACLs provide an optional layer of security (on top of security groups) for the instances
        /// in your VPC. For more information about network ACLs, go to Network ACLs in the Amazon Virtual Private Cloud User Guide. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateNetworkAcl service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the CreateNetworkAcl service method, as returned by AmazonEC2.</returns>
		CreateNetworkAclResponse CreateNetworkAcl(CreateNetworkAclRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateNetworkAcl operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateNetworkAcl"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateNetworkAcl operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<CreateNetworkAclResponse> CreateNetworkAclAsync(CreateNetworkAclRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Creates an entry (i.e., rule) in a network ACL with a rule number you specify. Each network ACL has a set of numbered ingress rules
        /// and a separate set of numbered egress rules. When determining whether a packet should be allowed in or out of a subnet associated with the
        /// ACL, Amazon VPC processes the entries in the ACL according to the rule numbers, in ascending order. </para> <para> <b>Important:</b> We
        /// recommend that you leave room between the rules (e.g., 100, 110, 120, etc.), and not number them sequentially (101, 102, 103, etc.). This
        /// allows you to easily add a new rule between existing ones without having to renumber the rules. </para> <para> After you add an entry, you
        /// can't modify it; you must either replace it, or create a new entry and delete the old one. </para> <para> For more information about network
        /// ACLs, go to Network ACLs in the Amazon Virtual Private Cloud User Guide. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateNetworkAclEntry service method on
        /// AmazonEC2.</param>
		CreateNetworkAclEntryResponse CreateNetworkAclEntry(CreateNetworkAclEntryRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateNetworkAclEntry operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateNetworkAclEntry"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateNetworkAclEntry operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<CreateNetworkAclEntryResponse> CreateNetworkAclEntryAsync(CreateNetworkAclEntryRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateNetworkInterface service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the CreateNetworkInterface service method, as returned by AmazonEC2.</returns>
		CreateNetworkInterfaceResponse CreateNetworkInterface(CreateNetworkInterfaceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateNetworkInterface operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateNetworkInterface"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateNetworkInterface operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<CreateNetworkInterfaceResponse> CreateNetworkInterfaceAsync(CreateNetworkInterfaceRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Creates a PlacementGroup into which multiple Amazon EC2 instances can be launched. Users must give the group a name unique within the
        /// scope of the user account. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePlacementGroup service method on
        /// AmazonEC2.</param>
		CreatePlacementGroupResponse CreatePlacementGroup(CreatePlacementGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePlacementGroup operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreatePlacementGroup"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePlacementGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<CreatePlacementGroupResponse> CreatePlacementGroupAsync(CreatePlacementGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateReservedInstancesListing
        /// service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the CreateReservedInstancesListing service method, as returned by AmazonEC2.</returns>
		CreateReservedInstancesListingResponse CreateReservedInstancesListing(CreateReservedInstancesListingRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateReservedInstancesListing operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateReservedInstancesListing"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateReservedInstancesListing operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<CreateReservedInstancesListingResponse> CreateReservedInstancesListingAsync(CreateReservedInstancesListingRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Creates a new route in a route table within a VPC. The route's target can be either a gateway attached to the VPC or a NAT instance
        /// in the VPC. </para> <para> When determining how to route traffic, we use the route with the most specific match. For example, let's say the
        /// traffic is destined for <c>192.0.2.3</c> , and the route table includes the following two routes: </para>
        /// <ul>
        /// <li> <c>192.0.2.0/24</c> (goes to some target A) </li>
        /// <li> <c>192.0.2.0/28</c> (goes to some target B) </li>
        /// 
        /// </ul>
        /// <para> Both routes apply to the traffic destined for <c>192.0.2.3</c> . However, the second route in the list is more specific, so we use
        /// that route to determine where to target the traffic. </para> <para> For more information about route tables, go to <a href="http://docs.amazonwebservices.com/AmazonVPC/latest/UserGuide/VPC_Route_Tables.html">Route Tables</a> in the Amazon Virtual Private
        /// Cloud User Guide. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRoute service method on AmazonEC2.</param>
		CreateRouteResponse CreateRoute(CreateRouteRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRoute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateRoute"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRoute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<CreateRouteResponse> CreateRouteAsync(CreateRouteRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Creates a new route table within a VPC. After you create a new route table, you can add routes and associate the table with a subnet.
        /// For more information about route tables, go to <a href="http://docs.amazonwebservices.com/AmazonVPC/latest/UserGuide/VPC_Route_Tables.html">Route Tables</a> in the Amazon Virtual Private Cloud User Guide. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRouteTable service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the CreateRouteTable service method, as returned by AmazonEC2.</returns>
		CreateRouteTableResponse CreateRouteTable(CreateRouteTableRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRouteTable operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateRouteTable"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRouteTable operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<CreateRouteTableResponse> CreateRouteTableAsync(CreateRouteTableRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> The CreateSecurityGroup operation creates a new security group. </para> <para> Every instance is launched in a security group. If no
        /// security group is specified during launch, the instances are launched in the default security group. Instances within the same security
        /// group have unrestricted network access to each other. Instances will reject network access attempts from other instances in a different
        /// security group. As the owner of instances you can grant or revoke specific permissions using the AuthorizeSecurityGroupIngress and
        /// RevokeSecurityGroupIngress operations. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSecurityGroup service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the CreateSecurityGroup service method, as returned by AmazonEC2.</returns>
		CreateSecurityGroupResponse CreateSecurityGroup(CreateSecurityGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSecurityGroup operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateSecurityGroup"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSecurityGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<CreateSecurityGroupResponse> CreateSecurityGroupAsync(CreateSecurityGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Create a snapshot of the volume identified by volume ID. A volume does not have to be detached at the time the snapshot is taken.
        /// </para> <para><b>NOTE:</b> Snapshot creation requires that the system is in a consistent state. For instance, this means that if taking a
        /// snapshot of a database, the tables must be read-only locked to ensure that the snapshot will not contain a corrupted version of the
        /// database. Therefore, be careful when using this API to ensure that the system remains in the consistent state until the create snapshot
        /// status has returned. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSnapshot service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the CreateSnapshot service method, as returned by AmazonEC2.</returns>
		CreateSnapshotResponse CreateSnapshot(CreateSnapshotRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSnapshot operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateSnapshot"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<CreateSnapshotResponse> CreateSnapshotAsync(CreateSnapshotRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Creates the data feed for Spot Instances, enabling you to view Spot Instance usage logs. You can create one data feed per account.
        /// </para> <para> For conceptual information about Spot Instances, refer to the Amazon Elastic Compute Cloud Developer Guide or Amazon Elastic
        /// Compute Cloud User Guide .
        /// </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSpotDatafeedSubscription
        /// service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the CreateSpotDatafeedSubscription service method, as returned by AmazonEC2.</returns>
		CreateSpotDatafeedSubscriptionResponse CreateSpotDatafeedSubscription(CreateSpotDatafeedSubscriptionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSpotDatafeedSubscription operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateSpotDatafeedSubscription"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSpotDatafeedSubscription operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<CreateSpotDatafeedSubscriptionResponse> CreateSpotDatafeedSubscriptionAsync(CreateSpotDatafeedSubscriptionRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Creates a subnet in an existing VPC. You can create up to 20 subnets in a VPC. If you add more than one subnet to a VPC, they're set
        /// up in a star topology with a logical router in the middle. When you create each subnet, you provide the VPC ID and the CIDR block you want
        /// for the subnet. Once you create a subnet, you can't change its CIDR block. The subnet's CIDR block can be the same as the VPC's CIDR block
        /// (assuming you want only a single subnet in the VPC), or a subset of the VPC's CIDR block. If you create more than one subnet in a VPC, the
        /// subnets' CIDR blocks must not overlap. The smallest subnet (and VPC) you can create uses a <c>/28</c> netmask (16 IP addresses), and the
        /// largest uses a <c>/18</c> netmask (16,384 IP addresses). </para> <para><b>IMPORTANT:</b> AWS reserves both the first four and the last IP
        /// address in each subnet's CIDR block. They're not available for use. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSubnet service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the CreateSubnet service method, as returned by AmazonEC2.</returns>
		CreateSubnetResponse CreateSubnet(CreateSubnetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSubnet operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateSubnet"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSubnet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<CreateSubnetResponse> CreateSubnetAsync(CreateSubnetRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Adds or overwrites tags for the specified resources. Each resource can have a maximum of 10 tags. Each tag consists of a key-value
        /// pair. Tag keys must be unique per resource. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTags service method on AmazonEC2.</param>
		CreateTagsResponse CreateTags(CreateTagsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTags operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateTags"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<CreateTagsResponse> CreateTagsAsync(CreateTagsRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Initializes an empty volume of a given size. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVolume service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the CreateVolume service method, as returned by AmazonEC2.</returns>
		CreateVolumeResponse CreateVolume(CreateVolumeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateVolume operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateVolume"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVolume operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<CreateVolumeResponse> CreateVolumeAsync(CreateVolumeRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Creates a VPC with the CIDR block you specify. The smallest VPC you can create uses a <c>/28</c> netmask (16 IP addresses), and the
        /// largest uses a <c>/18</c> netmask (16,384 IP addresses). To help you decide how big to make your VPC, go to the topic about creating VPCs in
        /// the Amazon Virtual Private Cloud Developer Guide. </para> <para> By default, each instance you launch in the VPC has the default DHCP
        /// options (the standard EC2 host name, no domain name, no DNS server, no NTP server, and no NetBIOS server or node type). </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVpc service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the CreateVpc service method, as returned by AmazonEC2.</returns>
		CreateVpcResponse CreateVpc(CreateVpcRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateVpc operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateVpc"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVpc operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<CreateVpcResponse> CreateVpcAsync(CreateVpcRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Creates a new VPN connection between an existing VPN gateway and customer gateway. The only supported connection type is ipsec.1.
        /// </para> <para> The response includes information that you need to configure your customer gateway, in XML format. We recommend you use the
        /// command line version of this operation ( <c>ec2-create-vpn-connection</c> ), which takes an <c>-f</c> option (for format) and returns
        /// configuration information formatted as expected by the vendor you specified, or in a generic, human readable format. For information about
        /// the command, go to <c>ec2-create-vpn-connection</c> in the Amazon Virtual Private Cloud Command Line Reference. </para>
        /// <para><b>IMPORTANT:</b> We strongly recommend you use HTTPS when calling this operation because the response contains sensitive
        /// cryptographic information for configuring your customer gateway. If you decide to shut down your VPN connection for any reason and then
        /// create a new one, you must re-configure your customer gateway with the new information returned from this call. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVpnConnection service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the CreateVpnConnection service method, as returned by AmazonEC2.</returns>
		CreateVpnConnectionResponse CreateVpnConnection(CreateVpnConnectionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateVpnConnection operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateVpnConnection"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVpnConnection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<CreateVpnConnectionResponse> CreateVpnConnectionAsync(CreateVpnConnectionRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVpnConnectionRoute service method
        /// on AmazonEC2.</param>
		CreateVpnConnectionRouteResponse CreateVpnConnectionRoute(CreateVpnConnectionRouteRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateVpnConnectionRoute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateVpnConnectionRoute"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVpnConnectionRoute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<CreateVpnConnectionRouteResponse> CreateVpnConnectionRouteAsync(CreateVpnConnectionRouteRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Creates a new VPN gateway. A VPN gateway is the VPC-side endpoint for your VPN connection. You can create a VPN gateway before
        /// creating the VPC itself. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVpnGateway service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the CreateVpnGateway service method, as returned by AmazonEC2.</returns>
		CreateVpnGatewayResponse CreateVpnGateway(CreateVpnGatewayRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the CreateVpnGateway operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateVpnGateway"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVpnGateway operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<CreateVpnGatewayResponse> CreateVpnGatewayAsync(CreateVpnGatewayRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Deletes a customer gateway. You must delete the VPN connection before deleting the customer gateway. </para> <para> You can have a
        /// single active customer gateway per AWS account (active means that you've created a VPN connection with that customer gateway). AWS might
        /// delete any customer gateway you leave inactive for an extended period of time. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCustomerGateway service method on
        /// AmazonEC2.</param>
		DeleteCustomerGatewayResponse DeleteCustomerGateway(DeleteCustomerGatewayRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCustomerGateway operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteCustomerGateway"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCustomerGateway operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DeleteCustomerGatewayResponse> DeleteCustomerGatewayAsync(DeleteCustomerGatewayRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Deletes a set of DHCP options that you specify. Amazon VPC returns an error if the set of options you specify is currently associated
        /// with a VPC. You can disassociate the set of options by associating either a new set of options or the default options with the VPC. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDhcpOptions service method on
        /// AmazonEC2.</param>
		DeleteDhcpOptionsResponse DeleteDhcpOptions(DeleteDhcpOptionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDhcpOptions operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteDhcpOptions"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDhcpOptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DeleteDhcpOptionsResponse> DeleteDhcpOptionsAsync(DeleteDhcpOptionsRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Deletes an Internet gateway from your AWS account. The gateway must not be attached to a VPC. For more information about your VPC and
        /// Internet gateway, go to Amazon Virtual Private Cloud User Guide. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteInternetGateway service method on
        /// AmazonEC2.</param>
		DeleteInternetGatewayResponse DeleteInternetGateway(DeleteInternetGatewayRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteInternetGateway operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteInternetGateway"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteInternetGateway operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DeleteInternetGatewayResponse> DeleteInternetGatewayAsync(DeleteInternetGatewayRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> The DeleteKeyPair operation deletes a key pair. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteKeyPair service method on AmazonEC2.</param>
		DeleteKeyPairResponse DeleteKeyPair(DeleteKeyPairRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteKeyPair operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteKeyPair"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteKeyPair operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DeleteKeyPairResponse> DeleteKeyPairAsync(DeleteKeyPairRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Deletes a network ACL from a VPC. The ACL must not have any subnets associated with it. You can't delete the default network ACL. For
        /// more information about network ACLs, go to Network ACLs in the Amazon Virtual Private Cloud User Guide. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteNetworkAcl service method on
        /// AmazonEC2.</param>
		DeleteNetworkAclResponse DeleteNetworkAcl(DeleteNetworkAclRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteNetworkAcl operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteNetworkAcl"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteNetworkAcl operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DeleteNetworkAclResponse> DeleteNetworkAclAsync(DeleteNetworkAclRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Deletes an ingress or egress entry (i.e., rule) from a network ACL. For more information about network ACLs, go to Network ACLs in
        /// the Amazon Virtual Private Cloud User Guide. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteNetworkAclEntry service method on
        /// AmazonEC2.</param>
		DeleteNetworkAclEntryResponse DeleteNetworkAclEntry(DeleteNetworkAclEntryRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteNetworkAclEntry operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteNetworkAclEntry"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteNetworkAclEntry operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DeleteNetworkAclEntryResponse> DeleteNetworkAclEntryAsync(DeleteNetworkAclEntryRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteNetworkInterface service method on
        /// AmazonEC2.</param>
		DeleteNetworkInterfaceResponse DeleteNetworkInterface(DeleteNetworkInterfaceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteNetworkInterface operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteNetworkInterface"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteNetworkInterface operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DeleteNetworkInterfaceResponse> DeleteNetworkInterfaceAsync(DeleteNetworkInterfaceRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Deletes a PlacementGroup from a user's account. Terminate all Amazon EC2 instances in the placement group before deletion. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePlacementGroup service method on
        /// AmazonEC2.</param>
		DeletePlacementGroupResponse DeletePlacementGroup(DeletePlacementGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePlacementGroup operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeletePlacementGroup"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePlacementGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DeletePlacementGroupResponse> DeletePlacementGroupAsync(DeletePlacementGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Deletes a route from a route table in a VPC. For more information about route tables, go to <a href="http://docs.amazonwebservices.com/AmazonVPC/latest/UserGuide/VPC_Route_Tables.html">Route Tables</a> in the Amazon Virtual Private
        /// Cloud User Guide. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRoute service method on AmazonEC2.</param>
		DeleteRouteResponse DeleteRoute(DeleteRouteRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRoute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteRoute"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRoute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DeleteRouteResponse> DeleteRouteAsync(DeleteRouteRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Deletes a route table from a VPC. The route table must not be associated with a subnet. You can't delete the main route table. For
        /// more information about route tables, go to <a href="http://docs.amazonwebservices.com/AmazonVPC/latest/UserGuide/VPC_Route_Tables.html">Route Tables</a> in the Amazon Virtual Private Cloud User Guide. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRouteTable service method on
        /// AmazonEC2.</param>
		DeleteRouteTableResponse DeleteRouteTable(DeleteRouteTableRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRouteTable operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteRouteTable"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRouteTable operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DeleteRouteTableResponse> DeleteRouteTableAsync(DeleteRouteTableRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> The DeleteSecurityGroup operation deletes a security group. </para> <para><b>NOTE:</b> If you attempt to delete a security group that
        /// contains instances, a fault is returned. If you attempt to delete a security group that is referenced by another security group, a fault is
        /// returned. For example, if security group B has a rule that allows access from security group A, security group A cannot be deleted until the
        /// allow rule is removed. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSecurityGroup service method on
        /// AmazonEC2.</param>
		DeleteSecurityGroupResponse DeleteSecurityGroup(DeleteSecurityGroupRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSecurityGroup operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteSecurityGroup"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSecurityGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DeleteSecurityGroupResponse> DeleteSecurityGroupAsync(DeleteSecurityGroupRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Deletes the snapshot identified by <c>snapshotId</c> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSnapshot service method on
        /// AmazonEC2.</param>
		DeleteSnapshotResponse DeleteSnapshot(DeleteSnapshotRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSnapshot operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteSnapshot"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DeleteSnapshotResponse> DeleteSnapshotAsync(DeleteSnapshotRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Deletes the data feed for Spot Instances. </para> <para> For conceptual information about Spot Instances, refer to the Amazon Elastic
        /// Compute Cloud Developer Guide or Amazon Elastic Compute Cloud User Guide .
        /// </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSpotDatafeedSubscription
        /// service method on AmazonEC2.</param>
		DeleteSpotDatafeedSubscriptionResponse DeleteSpotDatafeedSubscription(DeleteSpotDatafeedSubscriptionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSpotDatafeedSubscription operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteSpotDatafeedSubscription"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSpotDatafeedSubscription operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DeleteSpotDatafeedSubscriptionResponse> DeleteSpotDatafeedSubscriptionAsync(DeleteSpotDatafeedSubscriptionRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Deletes the data feed for Spot Instances. </para> <para> For conceptual information about Spot Instances, refer to the Amazon Elastic
        /// Compute Cloud Developer Guide or Amazon Elastic Compute Cloud User Guide .
        /// </para>
        /// </summary>
        /// 
		DeleteSpotDatafeedSubscriptionResponse DeleteSpotDatafeedSubscription();
 

        /// <summary>
        /// <para> Deletes a subnet from a VPC. You must terminate all running instances in the subnet before deleting it, otherwise Amazon VPC returns
        /// an error. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSubnet service method on AmazonEC2.</param>
		DeleteSubnetResponse DeleteSubnet(DeleteSubnetRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSubnet operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteSubnet"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSubnet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DeleteSubnetResponse> DeleteSubnetAsync(DeleteSubnetRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Deletes tags from the specified Amazon EC2 resources. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTags service method on AmazonEC2.</param>
		DeleteTagsResponse DeleteTags(DeleteTagsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTags operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteTags"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DeleteTagsResponse> DeleteTagsAsync(DeleteTagsRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Deletes a previously created volume. Once successfully deleted, a new volume can be created with the same name. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVolume service method on AmazonEC2.</param>
		DeleteVolumeResponse DeleteVolume(DeleteVolumeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVolume operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteVolume"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVolume operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DeleteVolumeResponse> DeleteVolumeAsync(DeleteVolumeRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Deletes a VPC. You must detach or delete all gateways or other objects that are dependent on the VPC first. For example, you must
        /// terminate all running instances, delete all VPC security groups (except the default), delete all the route tables (except the default), etc.
        /// </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpc service method on AmazonEC2.</param>
		DeleteVpcResponse DeleteVpc(DeleteVpcRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVpc operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteVpc"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpc operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DeleteVpcResponse> DeleteVpcAsync(DeleteVpcRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Deletes a VPN connection. Use this if you want to delete a VPC and all its associated components. Another reason to use this
        /// operation is if you believe the tunnel credentials for your VPN connection have been compromised. In that situation, you can delete the VPN
        /// connection and create a new one that has new keys, without needing to delete the VPC or VPN gateway. If you create a new VPN connection, you
        /// must reconfigure the customer gateway using the new configuration information returned with the new VPN connection ID. </para> <para> If
        /// you're deleting the VPC and all its associated parts, we recommend you detach the VPN gateway from the VPC and delete the VPC before
        /// deleting the VPN connection. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpnConnection service method on
        /// AmazonEC2.</param>
		DeleteVpnConnectionResponse DeleteVpnConnection(DeleteVpnConnectionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVpnConnection operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteVpnConnection"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpnConnection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DeleteVpnConnectionResponse> DeleteVpnConnectionAsync(DeleteVpnConnectionRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpnConnectionRoute service method
        /// on AmazonEC2.</param>
		DeleteVpnConnectionRouteResponse DeleteVpnConnectionRoute(DeleteVpnConnectionRouteRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVpnConnectionRoute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteVpnConnectionRoute"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpnConnectionRoute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DeleteVpnConnectionRouteResponse> DeleteVpnConnectionRouteAsync(DeleteVpnConnectionRouteRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Deletes a VPN gateway. Use this when you want to delete a VPC and all its associated components because you no longer need them. We
        /// recommend that before you delete a VPN gateway, you detach it from the VPC and delete the VPN connection. Note that you don't need to delete
        /// the VPN gateway if you just want to delete and re-create the VPN connection between your VPC and data center. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpnGateway service method on
        /// AmazonEC2.</param>
		DeleteVpnGatewayResponse DeleteVpnGateway(DeleteVpnGatewayRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVpnGateway operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteVpnGateway"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpnGateway operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DeleteVpnGatewayResponse> DeleteVpnGatewayAsync(DeleteVpnGatewayRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> The DeregisterImage operation deregisters an AMI. Once deregistered, instances of the AMI can no longer be launched. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterImage service method on
        /// AmazonEC2.</param>
		DeregisterImageResponse DeregisterImage(DeregisterImageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterImage operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeregisterImage"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterImage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DeregisterImageResponse> DeregisterImageAsync(DeregisterImageRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountAttributes service
        /// method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeAccountAttributes service method, as returned by AmazonEC2.</returns>
		DescribeAccountAttributesResponse DescribeAccountAttributes(DescribeAccountAttributesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAccountAttributes operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeAccountAttributes"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeAccountAttributesResponse> DescribeAccountAttributesAsync(DescribeAccountAttributesRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeAccountAttributes service method, as returned by AmazonEC2.</returns>
		DescribeAccountAttributesResponse DescribeAccountAttributes();
 

        /// <summary>
        /// <para> The DescribeAddresses operation lists elastic IP addresses assigned to your account. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAddresses service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeAddresses service method, as returned by AmazonEC2.</returns>
		DescribeAddressesResponse DescribeAddresses(DescribeAddressesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAddresses operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeAddresses"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAddresses operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeAddressesResponse> DescribeAddressesAsync(DescribeAddressesRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> The DescribeAddresses operation lists elastic IP addresses assigned to your account. </para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeAddresses service method, as returned by AmazonEC2.</returns>
		DescribeAddressesResponse DescribeAddresses();
 

        /// <summary>
        /// <para> The DescribeAvailabilityZones operation describes availability zones that are currently available to the account and their states.
        /// </para> <para> Availability zones are not the same across accounts. The availability zone <c>us-east-1a</c> for account A is not necessarily
        /// the same as <c>us-east-1a</c> for account B. Zone assignments are mapped independently for each account. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAvailabilityZones service
        /// method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeAvailabilityZones service method, as returned by AmazonEC2.</returns>
		DescribeAvailabilityZonesResponse DescribeAvailabilityZones(DescribeAvailabilityZonesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAvailabilityZones operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeAvailabilityZones"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAvailabilityZones operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeAvailabilityZonesResponse> DescribeAvailabilityZonesAsync(DescribeAvailabilityZonesRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> The DescribeAvailabilityZones operation describes availability zones that are currently available to the account and their states.
        /// </para> <para> Availability zones are not the same across accounts. The availability zone <c>us-east-1a</c> for account A is not necessarily
        /// the same as <c>us-east-1a</c> for account B. Zone assignments are mapped independently for each account. </para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeAvailabilityZones service method, as returned by AmazonEC2.</returns>
		DescribeAvailabilityZonesResponse DescribeAvailabilityZones();
 

        /// <summary>
        /// <para> The DescribeBundleTasks operation describes in-progress and recent bundle tasks. Complete and failed tasks are removed from the list
        /// a short time after completion. If no bundle ids are given, all bundle tasks are returned. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeBundleTasks service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeBundleTasks service method, as returned by AmazonEC2.</returns>
		DescribeBundleTasksResponse DescribeBundleTasks(DescribeBundleTasksRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeBundleTasks operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeBundleTasks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeBundleTasks operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeBundleTasksResponse> DescribeBundleTasksAsync(DescribeBundleTasksRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> The DescribeBundleTasks operation describes in-progress and recent bundle tasks. Complete and failed tasks are removed from the list
        /// a short time after completion. If no bundle ids are given, all bundle tasks are returned. </para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeBundleTasks service method, as returned by AmazonEC2.</returns>
		DescribeBundleTasksResponse DescribeBundleTasks();
 

        /// <summary>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeConversionTasks service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeConversionTasks service method, as returned by AmazonEC2.</returns>
		DescribeConversionTasksResponse DescribeConversionTasks(DescribeConversionTasksRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeConversionTasks operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeConversionTasks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeConversionTasks operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeConversionTasksResponse> DescribeConversionTasksAsync(DescribeConversionTasksRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeConversionTasks service method, as returned by AmazonEC2.</returns>
		DescribeConversionTasksResponse DescribeConversionTasks();
 

        /// <summary>
        /// <para> Gives you information about your customer gateways. You can filter the results to return information only about customer gateways
        /// that match criteria you specify. For example, you could ask to get information about a particular customer gateway (or all) only if the
        /// gateway's state is pending or available. You can specify multiple filters (e.g., the customer gateway has a particular IP address for the
        /// Internet-routable external interface, and the gateway's state is pending or available). The result includes information for a particular
        /// customer gateway only if the gateway matches all your filters. If there's no match, no special message is returned; the response is simply
        /// empty. The following table shows the available filters. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCustomerGateways service method
        /// on AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeCustomerGateways service method, as returned by AmazonEC2.</returns>
		DescribeCustomerGatewaysResponse DescribeCustomerGateways(DescribeCustomerGatewaysRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCustomerGateways operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeCustomerGateways"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCustomerGateways operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeCustomerGatewaysResponse> DescribeCustomerGatewaysAsync(DescribeCustomerGatewaysRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Gives you information about your customer gateways. You can filter the results to return information only about customer gateways
        /// that match criteria you specify. For example, you could ask to get information about a particular customer gateway (or all) only if the
        /// gateway's state is pending or available. You can specify multiple filters (e.g., the customer gateway has a particular IP address for the
        /// Internet-routable external interface, and the gateway's state is pending or available). The result includes information for a particular
        /// customer gateway only if the gateway matches all your filters. If there's no match, no special message is returned; the response is simply
        /// empty. The following table shows the available filters. </para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeCustomerGateways service method, as returned by AmazonEC2.</returns>
		DescribeCustomerGatewaysResponse DescribeCustomerGateways();
 

        /// <summary>
        /// <para> Gives you information about one or more sets of DHCP options. You can specify one or more DHCP options set IDs, or no IDs (to
        /// describe all your sets of DHCP options). The returned information consists of: </para>
        /// <ul>
        /// <li> The DHCP options set ID </li>
        /// <li> The options </li>
        /// 
        /// </ul>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDhcpOptions service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeDhcpOptions service method, as returned by AmazonEC2.</returns>
		DescribeDhcpOptionsResponse DescribeDhcpOptions(DescribeDhcpOptionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDhcpOptions operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeDhcpOptions"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDhcpOptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeDhcpOptionsResponse> DescribeDhcpOptionsAsync(DescribeDhcpOptionsRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Gives you information about one or more sets of DHCP options. You can specify one or more DHCP options set IDs, or no IDs (to
        /// describe all your sets of DHCP options). The returned information consists of: </para>
        /// <ul>
        /// <li> The DHCP options set ID </li>
        /// <li> The options </li>
        /// 
        /// </ul>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeDhcpOptions service method, as returned by AmazonEC2.</returns>
		DescribeDhcpOptionsResponse DescribeDhcpOptions();
 

        /// <summary>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeExportTasks service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeExportTasks service method, as returned by AmazonEC2.</returns>
		DescribeExportTasksResponse DescribeExportTasks(DescribeExportTasksRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeExportTasks operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeExportTasks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeExportTasks operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeExportTasksResponse> DescribeExportTasksAsync(DescribeExportTasksRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeExportTasks service method, as returned by AmazonEC2.</returns>
		DescribeExportTasksResponse DescribeExportTasks();
 

        /// <summary>
        /// <para> The DescribeImageAttribute operation returns information about an attribute of an AMI. Only one attribute can be specified per call.
        /// </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeImageAttribute service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeImageAttribute service method, as returned by AmazonEC2.</returns>
		DescribeImageAttributeResponse DescribeImageAttribute(DescribeImageAttributeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeImageAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeImageAttribute"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeImageAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeImageAttributeResponse> DescribeImageAttributeAsync(DescribeImageAttributeRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> The DescribeImages operation returns information about AMIs, AKIs, and ARIs available to the user. Information returned includes
        /// image type, product codes, architecture, and kernel and RAM disk IDs. Images available to the user include public images available for any
        /// user to launch, private images owned by the user making the request, and private images owned by other users for which the user has explicit
        /// launch permissions. </para> <para> Launch permissions fall into three categories: </para>
        /// <ul>
        /// <li> <b>Public:</b> The owner of the AMI granted launch permissions for the AMI to the all group. All users have launch permissions for
        /// these AMIs. </li>
        /// <li> <b>Explicit:</b> The owner of the AMI granted launch permissions to a specific user. </li>
        /// <li> <b>Implicit:</b> A user has implicit launch permissions for all AMIs he or she owns. </li>
        /// 
        /// </ul>
        /// <para> The list of AMIs returned can be modified by specifying AMI IDs, AMI owners, or users with launch permissions. If no options are
        /// specified, Amazon EC2 returns all AMIs for which the user has launch permissions. </para> <para> If you specify one or more AMI IDs, only
        /// AMIs that have the specified IDs are returned. If you specify an invalid AMI ID, a fault is returned. If you specify an AMI ID for which you
        /// do not have access, it will not be included in the returned results. </para> <para> If you specify one or more AMI owners, only AMIs from
        /// the specified owners and for which you have access are returned. The results can include the account IDs of the specified owners, amazon for
        /// AMIs owned by Amazon or self for AMIs that you own. </para> <para> If you specify a list of executable users, only users that have launch
        /// permissions for the AMIs are returned. You can specify account IDs (if you own the AMI(s)), self for AMIs for which you own or have explicit
        /// permissions, or all for public AMIs. </para> <para><b>NOTE:</b> Deregistered images are included in the returned results for an unspecified
        /// interval after deregistration. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeImages service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeImages service method, as returned by AmazonEC2.</returns>
		DescribeImagesResponse DescribeImages(DescribeImagesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeImages operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeImages"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeImages operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeImagesResponse> DescribeImagesAsync(DescribeImagesRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> The DescribeImages operation returns information about AMIs, AKIs, and ARIs available to the user. Information returned includes
        /// image type, product codes, architecture, and kernel and RAM disk IDs. Images available to the user include public images available for any
        /// user to launch, private images owned by the user making the request, and private images owned by other users for which the user has explicit
        /// launch permissions. </para> <para> Launch permissions fall into three categories: </para>
        /// <ul>
        /// <li> <b>Public:</b> The owner of the AMI granted launch permissions for the AMI to the all group. All users have launch permissions for
        /// these AMIs. </li>
        /// <li> <b>Explicit:</b> The owner of the AMI granted launch permissions to a specific user. </li>
        /// <li> <b>Implicit:</b> A user has implicit launch permissions for all AMIs he or she owns. </li>
        /// 
        /// </ul>
        /// <para> The list of AMIs returned can be modified by specifying AMI IDs, AMI owners, or users with launch permissions. If no options are
        /// specified, Amazon EC2 returns all AMIs for which the user has launch permissions. </para> <para> If you specify one or more AMI IDs, only
        /// AMIs that have the specified IDs are returned. If you specify an invalid AMI ID, a fault is returned. If you specify an AMI ID for which you
        /// do not have access, it will not be included in the returned results. </para> <para> If you specify one or more AMI owners, only AMIs from
        /// the specified owners and for which you have access are returned. The results can include the account IDs of the specified owners, amazon for
        /// AMIs owned by Amazon or self for AMIs that you own. </para> <para> If you specify a list of executable users, only users that have launch
        /// permissions for the AMIs are returned. You can specify account IDs (if you own the AMI(s)), self for AMIs for which you own or have explicit
        /// permissions, or all for public AMIs. </para> <para><b>NOTE:</b> Deregistered images are included in the returned results for an unspecified
        /// interval after deregistration. </para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeImages service method, as returned by AmazonEC2.</returns>
		DescribeImagesResponse DescribeImages();
 

        /// <summary>
        /// <para> Returns information about an attribute of an instance. Only one attribute can be specified per call. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstanceAttribute service
        /// method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeInstanceAttribute service method, as returned by AmazonEC2.</returns>
		DescribeInstanceAttributeResponse DescribeInstanceAttribute(DescribeInstanceAttributeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInstanceAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeInstanceAttribute"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstanceAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeInstanceAttributeResponse> DescribeInstanceAttributeAsync(DescribeInstanceAttributeRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> The DescribeInstances operation returns information about instances that you own. </para> <para> If you specify one or more instance
        /// IDs, Amazon EC2 returns information for those instances. If you do not specify instance IDs, Amazon EC2 returns information for all relevant
        /// instances. If you specify an invalid instance ID, a fault is returned. If you specify an instance that you do not own, it will not be
        /// included in the returned results. </para> <para> Recently terminated instances might appear in the returned results. This interval is
        /// usually less than one hour. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstances service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeInstances service method, as returned by AmazonEC2.</returns>
		DescribeInstancesResponse DescribeInstances(DescribeInstancesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInstances operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeInstances"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeInstancesResponse> DescribeInstancesAsync(DescribeInstancesRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> The DescribeInstances operation returns information about instances that you own. </para> <para> If you specify one or more instance
        /// IDs, Amazon EC2 returns information for those instances. If you do not specify instance IDs, Amazon EC2 returns information for all relevant
        /// instances. If you specify an invalid instance ID, a fault is returned. If you specify an instance that you do not own, it will not be
        /// included in the returned results. </para> <para> Recently terminated instances might appear in the returned results. This interval is
        /// usually less than one hour. </para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeInstances service method, as returned by AmazonEC2.</returns>
		DescribeInstancesResponse DescribeInstances();
 

        /// <summary>
        /// <para> Describes the status of an Amazon Elastic Compute Cloud (Amazon EC2) instance. Instance status provides information about two types
        /// of scheduled events for an instance that may require your attention: </para>
        /// <ul>
        /// <li> Scheduled Reboot: When Amazon EC2 determines that an instance must be rebooted, the instance's status will return one of two event
        /// codes: <c>system-reboot</c> or <c>instance-reboot</c> . System reboot commonly occurs if certain maintenance or upgrade operations require a
        /// reboot of the underlying host that supports an instance. Instance reboot commonly occurs if the instance must be rebooted, rather than the
        /// underlying host. Rebooting events include a scheduled start and end time. </li>
        /// <li> Scheduled Retirement: When Amazon EC2 determines that an instance must be shut down, the instance's status will return an event code
        /// called <c>instance-retirement</c> . Retirement commonly occurs when the underlying host is degraded and must be replaced. Retirement events
        /// include a scheduled start and end time. You're also notified by email if one of your instances is set to retiring. The email message
        /// indicates when your instance will be permanently retired. </li>
        /// 
        /// </ul>
        /// <para> If your instance is permanently retired, it will not be restarted. You can avoid retirement by manually restarting your instance
        /// when its event code is <c>instance-retirement</c> . This ensures that your instance is started on a healthy host. </para> <para>
        /// <c>DescribeInstanceStatus</c> returns information only for instances in the running state. </para> <para> You can filter the results to
        /// return information only about instances that match criteria you specify. For example, you could get information about instances in a
        /// specific Availability Zone. You can specify multiple values for a filter (e.g., more than one Availability Zone). An instance must match at
        /// least one of the specified values for it to be included in the results. </para> <para> You can specify multiple filters. An instance must
        /// match all the filters for it to be included in the results. If there's no match, no special message is returned; the response is simply
        /// empty. </para> <para> You can use wildcards with the filter values: <c>*</c> matches zero or more characters, and <c>?</c> matches exactly
        /// one character. You can escape special characters using a backslash before the character. For example, a value of <c>\*amazon\?\\</c>
        /// searches for the literal string <c>*amazon?\</c> .
        /// </para> <para> The following filters are available: </para>
        /// <ul>
        /// <li> <c>availability-zone</c> - Filter on an instance's availability zone. </li>
        /// <li> <c>instance-state-name</c> - Filter on the intended state of the instance, e.g., running. </li>
        /// <li> <c>instance-state-code</c> - Filter on the intended state code of the instance, e.g., 16. </li>
        /// 
        /// </ul>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstanceStatus service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeInstanceStatus service method, as returned by AmazonEC2.</returns>
		DescribeInstanceStatusResponse DescribeInstanceStatus(DescribeInstanceStatusRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInstanceStatus operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeInstanceStatus"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstanceStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeInstanceStatusResponse> DescribeInstanceStatusAsync(DescribeInstanceStatusRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Describes the status of an Amazon Elastic Compute Cloud (Amazon EC2) instance. Instance status provides information about two types
        /// of scheduled events for an instance that may require your attention: </para>
        /// <ul>
        /// <li> Scheduled Reboot: When Amazon EC2 determines that an instance must be rebooted, the instance's status will return one of two event
        /// codes: <c>system-reboot</c> or <c>instance-reboot</c> . System reboot commonly occurs if certain maintenance or upgrade operations require a
        /// reboot of the underlying host that supports an instance. Instance reboot commonly occurs if the instance must be rebooted, rather than the
        /// underlying host. Rebooting events include a scheduled start and end time. </li>
        /// <li> Scheduled Retirement: When Amazon EC2 determines that an instance must be shut down, the instance's status will return an event code
        /// called <c>instance-retirement</c> . Retirement commonly occurs when the underlying host is degraded and must be replaced. Retirement events
        /// include a scheduled start and end time. You're also notified by email if one of your instances is set to retiring. The email message
        /// indicates when your instance will be permanently retired. </li>
        /// 
        /// </ul>
        /// <para> If your instance is permanently retired, it will not be restarted. You can avoid retirement by manually restarting your instance
        /// when its event code is <c>instance-retirement</c> . This ensures that your instance is started on a healthy host. </para> <para>
        /// <c>DescribeInstanceStatus</c> returns information only for instances in the running state. </para> <para> You can filter the results to
        /// return information only about instances that match criteria you specify. For example, you could get information about instances in a
        /// specific Availability Zone. You can specify multiple values for a filter (e.g., more than one Availability Zone). An instance must match at
        /// least one of the specified values for it to be included in the results. </para> <para> You can specify multiple filters. An instance must
        /// match all the filters for it to be included in the results. If there's no match, no special message is returned; the response is simply
        /// empty. </para> <para> You can use wildcards with the filter values: <c>*</c> matches zero or more characters, and <c>?</c> matches exactly
        /// one character. You can escape special characters using a backslash before the character. For example, a value of <c>\*amazon\?\\</c>
        /// searches for the literal string <c>*amazon?\</c> .
        /// </para> <para> The following filters are available: </para>
        /// <ul>
        /// <li> <c>availability-zone</c> - Filter on an instance's availability zone. </li>
        /// <li> <c>instance-state-name</c> - Filter on the intended state of the instance, e.g., running. </li>
        /// <li> <c>instance-state-code</c> - Filter on the intended state code of the instance, e.g., 16. </li>
        /// 
        /// </ul>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeInstanceStatus service method, as returned by AmazonEC2.</returns>
		DescribeInstanceStatusResponse DescribeInstanceStatus();
 

        /// <summary>
        /// <para> Gives you information about your Internet gateways. You can filter the results to return information only about Internet gateways
        /// that match criteria you specify. For example, you could get information only about gateways with particular tags. The Internet gateway must
        /// match at least one of the specified values for it to be included in the results. </para> <para> You can specify multiple filters (e.g., the
        /// Internet gateway is attached to a particular VPC and is tagged with a particular value). The result includes information for a particular
        /// Internet gateway only if the gateway matches all your filters. If there's no match, no special message is returned; the response is simply
        /// empty. </para> <para> You can use wildcards with the filter values: an asterisk matches zero or more characters, and <c>?</c> matches
        /// exactly one character. You can escape special characters using a backslash before the character. For example, a value of <c>\*amazon\?\\</c>
        /// searches for the literal string <c>*amazon?\</c> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInternetGateways service method
        /// on AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeInternetGateways service method, as returned by AmazonEC2.</returns>
		DescribeInternetGatewaysResponse DescribeInternetGateways(DescribeInternetGatewaysRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInternetGateways operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeInternetGateways"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInternetGateways operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeInternetGatewaysResponse> DescribeInternetGatewaysAsync(DescribeInternetGatewaysRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Gives you information about your Internet gateways. You can filter the results to return information only about Internet gateways
        /// that match criteria you specify. For example, you could get information only about gateways with particular tags. The Internet gateway must
        /// match at least one of the specified values for it to be included in the results. </para> <para> You can specify multiple filters (e.g., the
        /// Internet gateway is attached to a particular VPC and is tagged with a particular value). The result includes information for a particular
        /// Internet gateway only if the gateway matches all your filters. If there's no match, no special message is returned; the response is simply
        /// empty. </para> <para> You can use wildcards with the filter values: an asterisk matches zero or more characters, and <c>?</c> matches
        /// exactly one character. You can escape special characters using a backslash before the character. For example, a value of <c>\*amazon\?\\</c>
        /// searches for the literal string <c>*amazon?\</c> .
        /// </para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeInternetGateways service method, as returned by AmazonEC2.</returns>
		DescribeInternetGatewaysResponse DescribeInternetGateways();
 

        /// <summary>
        /// <para> The DescribeKeyPairs operation returns information about key pairs available to you. If you specify key pairs, information about
        /// those key pairs is returned. Otherwise, information for all registered key pairs is returned. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeKeyPairs service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeKeyPairs service method, as returned by AmazonEC2.</returns>
		DescribeKeyPairsResponse DescribeKeyPairs(DescribeKeyPairsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeKeyPairs operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeKeyPairs"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeKeyPairs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeKeyPairsResponse> DescribeKeyPairsAsync(DescribeKeyPairsRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> The DescribeKeyPairs operation returns information about key pairs available to you. If you specify key pairs, information about
        /// those key pairs is returned. Otherwise, information for all registered key pairs is returned. </para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeKeyPairs service method, as returned by AmazonEC2.</returns>
		DescribeKeyPairsResponse DescribeKeyPairs();
 
        /// <summary>
        /// <para> Gives you information about the network ACLs in your VPC. You can filter the results to return information only about ACLs that match
        /// criteria you specify. For example, you could get information only the ACL associated with a particular subnet. The ACL must match at least
        /// one of the specified values for it to be included in the results. </para> <para> You can specify multiple filters (e.g., the ACL is
        /// associated with a particular subnet and has an egress entry that denies traffic to a particular port). The result includes information for a
        /// particular ACL only if it matches all your filters. If there's no match, no special message is returned; the response is simply empty.
        /// </para> <para> You can use wildcards with the filter values: an asterisk matches zero or more characters, and <c>?</c> matches exactly one
        /// character. You can escape special characters using a backslash before the character. For example, a value of <c>\*amazon\?\\</c> searches
        /// for the literal string <c>*amazon?\</c> .
        /// </para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeNetworkAcls service method, as returned by AmazonEC2.</returns>
		DescribeNetworkAclsResponse DescribeNetworkAcls();
 

        /// <summary>
        /// <para> Gives you information about the network ACLs in your VPC. You can filter the results to return information only about ACLs that match
        /// criteria you specify. For example, you could get information only the ACL associated with a particular subnet. The ACL must match at least
        /// one of the specified values for it to be included in the results. </para> <para> You can specify multiple filters (e.g., the ACL is
        /// associated with a particular subnet and has an egress entry that denies traffic to a particular port). The result includes information for a
        /// particular ACL only if it matches all your filters. If there's no match, no special message is returned; the response is simply empty.
        /// </para> <para> You can use wildcards with the filter values: an asterisk matches zero or more characters, and <c>?</c> matches exactly one
        /// character. You can escape special characters using a backslash before the character. For example, a value of <c>\*amazon\?\\</c> searches
        /// for the literal string <c>*amazon?\</c> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeNetworkAcls service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeNetworkAcls service method, as returned by AmazonEC2.</returns>
		DescribeNetworkAclsResponse DescribeNetworkAcls(DescribeNetworkAclsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeNetworkAcls operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeNetworkAcls"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeNetworkAcls operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeNetworkAclsResponse> DescribeNetworkAclsAsync(DescribeNetworkAclsRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the
        /// DescribeNetworkInterfaceAttribute service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeNetworkInterfaceAttribute service method, as returned by AmazonEC2.</returns>
		DescribeNetworkInterfaceAttributeResponse DescribeNetworkInterfaceAttribute(DescribeNetworkInterfaceAttributeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeNetworkInterfaceAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeNetworkInterfaceAttribute"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeNetworkInterfaceAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeNetworkInterfaceAttributeResponse> DescribeNetworkInterfaceAttributeAsync(DescribeNetworkInterfaceAttributeRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeNetworkInterfaces service
        /// method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeNetworkInterfaces service method, as returned by AmazonEC2.</returns>
		DescribeNetworkInterfacesResponse DescribeNetworkInterfaces(DescribeNetworkInterfacesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeNetworkInterfaces operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeNetworkInterfaces"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeNetworkInterfaces operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeNetworkInterfacesResponse> DescribeNetworkInterfacesAsync(DescribeNetworkInterfacesRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeNetworkInterfaces service method, as returned by AmazonEC2.</returns>
		DescribeNetworkInterfacesResponse DescribeNetworkInterfaces();
 

        /// <summary>
        /// <para> Returns information about one or more PlacementGroup instances in a user's account. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePlacementGroups service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribePlacementGroups service method, as returned by AmazonEC2.</returns>
		DescribePlacementGroupsResponse DescribePlacementGroups(DescribePlacementGroupsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribePlacementGroups operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribePlacementGroups"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePlacementGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribePlacementGroupsResponse> DescribePlacementGroupsAsync(DescribePlacementGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Returns information about one or more PlacementGroup instances in a user's account. </para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribePlacementGroups service method, as returned by AmazonEC2.</returns>
		DescribePlacementGroupsResponse DescribePlacementGroups();
 

        /// <summary>
        /// <para> The DescribeRegions operation describes regions zones that are currently available to the account. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRegions service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeRegions service method, as returned by AmazonEC2.</returns>
		DescribeRegionsResponse DescribeRegions(DescribeRegionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRegions operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeRegions"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRegions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeRegionsResponse> DescribeRegionsAsync(DescribeRegionsRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> The DescribeRegions operation describes regions zones that are currently available to the account. </para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeRegions service method, as returned by AmazonEC2.</returns>
		DescribeRegionsResponse DescribeRegions();
 

        /// <summary>
        /// <para> The DescribeReservedInstances operation describes Reserved Instances that were purchased for use with your account. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedInstances service
        /// method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeReservedInstances service method, as returned by AmazonEC2.</returns>
		DescribeReservedInstancesResponse DescribeReservedInstances(DescribeReservedInstancesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReservedInstances operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeReservedInstances"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeReservedInstancesResponse> DescribeReservedInstancesAsync(DescribeReservedInstancesRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> The DescribeReservedInstances operation describes Reserved Instances that were purchased for use with your account. </para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeReservedInstances service method, as returned by AmazonEC2.</returns>
		DescribeReservedInstancesResponse DescribeReservedInstances();
 

        /// <summary>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the
        /// DescribeReservedInstancesListings service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeReservedInstancesListings service method, as returned by AmazonEC2.</returns>
		DescribeReservedInstancesListingsResponse DescribeReservedInstancesListings(DescribeReservedInstancesListingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReservedInstancesListings operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeReservedInstancesListings"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedInstancesListings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeReservedInstancesListingsResponse> DescribeReservedInstancesListingsAsync(DescribeReservedInstancesListingsRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeReservedInstancesListings service method, as returned by AmazonEC2.</returns>
		DescribeReservedInstancesListingsResponse DescribeReservedInstancesListings();
 

        /// <summary>
        /// <para> The DescribeReservedInstancesModifications operation describes modifications made to Reserved Instances in your account. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the
        /// DescribeReservedInstancesModifications service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeReservedInstancesModifications service method, as returned by AmazonEC2.</returns>
		DescribeReservedInstancesModificationsResponse DescribeReservedInstancesModifications(DescribeReservedInstancesModificationsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReservedInstancesModifications operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeReservedInstancesModifications"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedInstancesModifications operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeReservedInstancesModificationsResponse> DescribeReservedInstancesModificationsAsync(DescribeReservedInstancesModificationsRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> The DescribeReservedInstancesModifications operation describes modifications made to Reserved Instances in your account. </para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeReservedInstancesModifications service method, as returned by AmazonEC2.</returns>
		DescribeReservedInstancesModificationsResponse DescribeReservedInstancesModifications();
 

        /// <summary>
        /// <para> The DescribeReservedInstancesOfferings operation describes Reserved Instance offerings that are available for purchase. With Amazon
        /// EC2 Reserved Instances, you purchase the right to launch Amazon EC2 instances for a period of time (without getting insufficient capacity
        /// errors) and pay a lower usage rate for the actual time used. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the
        /// DescribeReservedInstancesOfferings service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeReservedInstancesOfferings service method, as returned by AmazonEC2.</returns>
		DescribeReservedInstancesOfferingsResponse DescribeReservedInstancesOfferings(DescribeReservedInstancesOfferingsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReservedInstancesOfferings operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeReservedInstancesOfferings"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedInstancesOfferings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeReservedInstancesOfferingsResponse> DescribeReservedInstancesOfferingsAsync(DescribeReservedInstancesOfferingsRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> The DescribeReservedInstancesOfferings operation describes Reserved Instance offerings that are available for purchase. With Amazon
        /// EC2 Reserved Instances, you purchase the right to launch Amazon EC2 instances for a period of time (without getting insufficient capacity
        /// errors) and pay a lower usage rate for the actual time used. </para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeReservedInstancesOfferings service method, as returned by AmazonEC2.</returns>
		DescribeReservedInstancesOfferingsResponse DescribeReservedInstancesOfferings();
 

        /// <summary>
        /// <para> Gives you information about your route tables. You can filter the results to return information only about tables that match criteria
        /// you specify. For example, you could get information only about a table associated with a particular subnet. You can specify multiple values
        /// for the filter. The table must match at least one of the specified values for it to be included in the results. </para> <para> You can
        /// specify multiple filters (e.g., the table has a particular route, and is associated with a particular subnet). The result includes
        /// information for a particular table only if it matches all your filters. If there's no match, no special message is returned; the response is
        /// simply empty. </para> <para> You can use wildcards with the filter values: an asterisk matches zero or more characters, and <c>?</c> matches
        /// exactly one character. You can escape special characters using a backslash before the character. For example, a value of <c>\*amazon\?\\</c>
        /// searches for the literal string <c>*amazon?\</c> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRouteTables service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeRouteTables service method, as returned by AmazonEC2.</returns>
		DescribeRouteTablesResponse DescribeRouteTables(DescribeRouteTablesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRouteTables operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeRouteTables"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRouteTables operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeRouteTablesResponse> DescribeRouteTablesAsync(DescribeRouteTablesRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Gives you information about your route tables. You can filter the results to return information only about tables that match criteria
        /// you specify. For example, you could get information only about a table associated with a particular subnet. You can specify multiple values
        /// for the filter. The table must match at least one of the specified values for it to be included in the results. </para> <para> You can
        /// specify multiple filters (e.g., the table has a particular route, and is associated with a particular subnet). The result includes
        /// information for a particular table only if it matches all your filters. If there's no match, no special message is returned; the response is
        /// simply empty. </para> <para> You can use wildcards with the filter values: an asterisk matches zero or more characters, and <c>?</c> matches
        /// exactly one character. You can escape special characters using a backslash before the character. For example, a value of <c>\*amazon\?\\</c>
        /// searches for the literal string <c>*amazon?\</c> .
        /// </para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeRouteTables service method, as returned by AmazonEC2.</returns>
		DescribeRouteTablesResponse DescribeRouteTables();
 

        /// <summary>
        /// <para> The DescribeSecurityGroups operation returns information about security groups that you own. </para> <para> If you specify security
        /// group names, information about those security group is returned. Otherwise, information for all security group is returned. If you specify a
        /// group that does not exist, a fault is returned. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSecurityGroups service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeSecurityGroups service method, as returned by AmazonEC2.</returns>
		DescribeSecurityGroupsResponse DescribeSecurityGroups(DescribeSecurityGroupsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSecurityGroups operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeSecurityGroups"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSecurityGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeSecurityGroupsResponse> DescribeSecurityGroupsAsync(DescribeSecurityGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> The DescribeSecurityGroups operation returns information about security groups that you own. </para> <para> If you specify security
        /// group names, information about those security group is returned. Otherwise, information for all security group is returned. If you specify a
        /// group that does not exist, a fault is returned. </para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeSecurityGroups service method, as returned by AmazonEC2.</returns>
		DescribeSecurityGroupsResponse DescribeSecurityGroups();
 

        /// <summary>
        /// <para> Returns information about an attribute of a snapshot. Only one attribute can be specified per call. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSnapshotAttribute service
        /// method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeSnapshotAttribute service method, as returned by AmazonEC2.</returns>
		DescribeSnapshotAttributeResponse DescribeSnapshotAttribute(DescribeSnapshotAttributeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSnapshotAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeSnapshotAttribute"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSnapshotAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeSnapshotAttributeResponse> DescribeSnapshotAttributeAsync(DescribeSnapshotAttributeRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Returns information about the Amazon EBS snapshots available to you. Snapshots available to you include public snapshots available
        /// for any AWS account to launch, private snapshots you own, and private snapshots owned by another AWS account but for which you've been given
        /// explicit create volume permissions. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSnapshots service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeSnapshots service method, as returned by AmazonEC2.</returns>
		DescribeSnapshotsResponse DescribeSnapshots(DescribeSnapshotsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSnapshots operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeSnapshots"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSnapshots operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeSnapshotsResponse> DescribeSnapshotsAsync(DescribeSnapshotsRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Returns information about the Amazon EBS snapshots available to you. Snapshots available to you include public snapshots available
        /// for any AWS account to launch, private snapshots you own, and private snapshots owned by another AWS account but for which you've been given
        /// explicit create volume permissions. </para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeSnapshots service method, as returned by AmazonEC2.</returns>
		DescribeSnapshotsResponse DescribeSnapshots();
 

        /// <summary>
        /// <para> Describes the data feed for Spot Instances. </para> <para> For conceptual information about Spot Instances, refer to the Amazon
        /// Elastic Compute Cloud Developer Guide or Amazon Elastic Compute Cloud User Guide .
        /// </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSpotDatafeedSubscription
        /// service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeSpotDatafeedSubscription service method, as returned by AmazonEC2.</returns>
		DescribeSpotDatafeedSubscriptionResponse DescribeSpotDatafeedSubscription(DescribeSpotDatafeedSubscriptionRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSpotDatafeedSubscription operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeSpotDatafeedSubscription"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSpotDatafeedSubscription operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeSpotDatafeedSubscriptionResponse> DescribeSpotDatafeedSubscriptionAsync(DescribeSpotDatafeedSubscriptionRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Describes the data feed for Spot Instances. </para> <para> For conceptual information about Spot Instances, refer to the Amazon
        /// Elastic Compute Cloud Developer Guide or Amazon Elastic Compute Cloud User Guide .
        /// </para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeSpotDatafeedSubscription service method, as returned by AmazonEC2.</returns>
		DescribeSpotDatafeedSubscriptionResponse DescribeSpotDatafeedSubscription();
 

        /// <summary>
        /// <para> Describes Spot Instance requests. Spot Instances are instances that Amazon EC2 starts on your behalf when the maximum price that you
        /// specify exceeds the current Spot Price. Amazon EC2 periodically sets the Spot Price based on available Spot Instance capacity and current
        /// spot instance requests. For conceptual information about Spot Instances, refer to the <a href="http://docs.amazonwebservices.com/AWSEC2/2010-08-31/DeveloperGuide/"> Amazon Elastic Compute Cloud Developer Guide</a> or <a href="http://docs.amazonwebservices.com/AWSEC2/2010-08-31/UserGuide/"> Amazon Elastic Compute Cloud User Guide</a> .
        /// </para> <para> You can filter the results to return information only about Spot Instance requests that match criteria you specify. For
        /// example, you could get information about requests where the Spot Price you specified is a certain value (you can't use greater than or less
        /// than comparison, but you can use <c>*</c> and <c>?</c> wildcards). You can specify multiple values for a filter. A Spot Instance request
        /// must match at least one of the specified values for it to be included in the results. </para> <para> You can specify multiple filters (e.g.,
        /// the Spot Price is equal to a particular value, and the instance type is <c>m1.small</c> ). The result includes information for a particular
        /// request only if it matches all your filters. If there's no match, no special message is returned; the response is simply empty. </para>
        /// <para> You can use wildcards with the filter values: an asterisk matches zero or more characters, and <c>?</c> matches exactly one
        /// character. You can escape special characters using a backslash before the character. For example, a value of <c>\*amazon\?\\</c> searches
        /// for the literal string <c>*amazon?\</c> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSpotInstanceRequests service
        /// method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeSpotInstanceRequests service method, as returned by AmazonEC2.</returns>
		DescribeSpotInstanceRequestsResponse DescribeSpotInstanceRequests(DescribeSpotInstanceRequestsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSpotInstanceRequests operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeSpotInstanceRequests"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSpotInstanceRequests operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeSpotInstanceRequestsResponse> DescribeSpotInstanceRequestsAsync(DescribeSpotInstanceRequestsRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Describes Spot Instance requests. Spot Instances are instances that Amazon EC2 starts on your behalf when the maximum price that you
        /// specify exceeds the current Spot Price. Amazon EC2 periodically sets the Spot Price based on available Spot Instance capacity and current
        /// spot instance requests. For conceptual information about Spot Instances, refer to the <a href="http://docs.amazonwebservices.com/AWSEC2/2010-08-31/DeveloperGuide/"> Amazon Elastic Compute Cloud Developer Guide</a> or <a href="http://docs.amazonwebservices.com/AWSEC2/2010-08-31/UserGuide/"> Amazon Elastic Compute Cloud User Guide</a> .
        /// </para> <para> You can filter the results to return information only about Spot Instance requests that match criteria you specify. For
        /// example, you could get information about requests where the Spot Price you specified is a certain value (you can't use greater than or less
        /// than comparison, but you can use <c>*</c> and <c>?</c> wildcards). You can specify multiple values for a filter. A Spot Instance request
        /// must match at least one of the specified values for it to be included in the results. </para> <para> You can specify multiple filters (e.g.,
        /// the Spot Price is equal to a particular value, and the instance type is <c>m1.small</c> ). The result includes information for a particular
        /// request only if it matches all your filters. If there's no match, no special message is returned; the response is simply empty. </para>
        /// <para> You can use wildcards with the filter values: an asterisk matches zero or more characters, and <c>?</c> matches exactly one
        /// character. You can escape special characters using a backslash before the character. For example, a value of <c>\*amazon\?\\</c> searches
        /// for the literal string <c>*amazon?\</c> .
        /// </para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeSpotInstanceRequests service method, as returned by AmazonEC2.</returns>
		DescribeSpotInstanceRequestsResponse DescribeSpotInstanceRequests();
 

        /// <summary>
        /// <para> Describes the Spot Price history. </para> <para> Spot Instances are instances that Amazon EC2 starts on your behalf when the maximum
        /// price that you specify exceeds the current Spot Price. Amazon EC2 periodically sets the Spot Price based on available Spot Instance capacity
        /// and current spot instance requests. </para> <para> For conceptual information about Spot Instances, refer to the Amazon Elastic Compute
        /// Cloud Developer Guide or Amazon Elastic Compute Cloud User Guide .
        /// </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSpotPriceHistory service method
        /// on AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeSpotPriceHistory service method, as returned by AmazonEC2.</returns>
		DescribeSpotPriceHistoryResponse DescribeSpotPriceHistory(DescribeSpotPriceHistoryRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSpotPriceHistory operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeSpotPriceHistory"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSpotPriceHistory operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeSpotPriceHistoryResponse> DescribeSpotPriceHistoryAsync(DescribeSpotPriceHistoryRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Describes the Spot Price history. </para> <para> Spot Instances are instances that Amazon EC2 starts on your behalf when the maximum
        /// price that you specify exceeds the current Spot Price. Amazon EC2 periodically sets the Spot Price based on available Spot Instance capacity
        /// and current spot instance requests. </para> <para> For conceptual information about Spot Instances, refer to the Amazon Elastic Compute
        /// Cloud Developer Guide or Amazon Elastic Compute Cloud User Guide .
        /// </para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeSpotPriceHistory service method, as returned by AmazonEC2.</returns>
		DescribeSpotPriceHistoryResponse DescribeSpotPriceHistory();
 

        /// <summary>
        /// <para> Gives you information about your subnets. You can filter the results to return information only about subnets that match criteria you
        /// specify. </para> <para> For example, you could ask to get information about a particular subnet (or all) only if the subnet's state is
        /// available. You can specify multiple filters (e.g., the subnet is in a particular VPC, and the subnet's state is available). </para> <para>
        /// The result includes information for a particular subnet only if the subnet matches all your filters. If there's no match, no special message
        /// is returned; the response is simply empty. The following table shows the available filters. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSubnets service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeSubnets service method, as returned by AmazonEC2.</returns>
		DescribeSubnetsResponse DescribeSubnets(DescribeSubnetsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSubnets operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeSubnets"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSubnets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeSubnetsResponse> DescribeSubnetsAsync(DescribeSubnetsRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Gives you information about your subnets. You can filter the results to return information only about subnets that match criteria you
        /// specify. </para> <para> For example, you could ask to get information about a particular subnet (or all) only if the subnet's state is
        /// available. You can specify multiple filters (e.g., the subnet is in a particular VPC, and the subnet's state is available). </para> <para>
        /// The result includes information for a particular subnet only if the subnet matches all your filters. If there's no match, no special message
        /// is returned; the response is simply empty. The following table shows the available filters. </para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeSubnets service method, as returned by AmazonEC2.</returns>
		DescribeSubnetsResponse DescribeSubnets();
 

        /// <summary>
        /// <para> Describes the tags for the specified resources. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTags service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeTags service method, as returned by AmazonEC2.</returns>
		DescribeTagsResponse DescribeTags(DescribeTagsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTags operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeTags"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeTagsResponse> DescribeTagsAsync(DescribeTagsRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Describes the tags for the specified resources. </para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeTags service method, as returned by AmazonEC2.</returns>
		DescribeTagsResponse DescribeTags();
 

        /// <summary>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVolumeAttribute service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeVolumeAttribute service method, as returned by AmazonEC2.</returns>
		DescribeVolumeAttributeResponse DescribeVolumeAttribute(DescribeVolumeAttributeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVolumeAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeVolumeAttribute"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVolumeAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeVolumeAttributeResponse> DescribeVolumeAttributeAsync(DescribeVolumeAttributeRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Describes the status of the indicated volume or, in lieu of any specified, all volumes belonging to the caller. Volumes that have
        /// been deleted are not described. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVolumes service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeVolumes service method, as returned by AmazonEC2.</returns>
		DescribeVolumesResponse DescribeVolumes(DescribeVolumesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVolumes operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeVolumes"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVolumes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeVolumesResponse> DescribeVolumesAsync(DescribeVolumesRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Describes the status of the indicated volume or, in lieu of any specified, all volumes belonging to the caller. Volumes that have
        /// been deleted are not described. </para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeVolumes service method, as returned by AmazonEC2.</returns>
		DescribeVolumesResponse DescribeVolumes();
 

        /// <summary>
        /// <para> Describes the status of a volume. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVolumeStatus service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeVolumeStatus service method, as returned by AmazonEC2.</returns>
		DescribeVolumeStatusResponse DescribeVolumeStatus(DescribeVolumeStatusRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVolumeStatus operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeVolumeStatus"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVolumeStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeVolumeStatusResponse> DescribeVolumeStatusAsync(DescribeVolumeStatusRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Describes the status of a volume. </para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeVolumeStatus service method, as returned by AmazonEC2.</returns>
		DescribeVolumeStatusResponse DescribeVolumeStatus();
 

        /// <summary>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcAttribute service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeVpcAttribute service method, as returned by AmazonEC2.</returns>
		DescribeVpcAttributeResponse DescribeVpcAttribute(DescribeVpcAttributeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVpcAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeVpcAttribute"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeVpcAttributeResponse> DescribeVpcAttributeAsync(DescribeVpcAttributeRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Gives you information about your VPCs. You can filter the results to return information only about VPCs that match criteria you
        /// specify. </para> <para> For example, you could ask to get information about a particular VPC or VPCs (or all your VPCs) only if the VPC's
        /// state is available. You can specify multiple filters (e.g., the VPC uses one of several sets of DHCP options, and the VPC's state is
        /// available). The result includes information for a particular VPC only if the VPC matches all your filters. </para> <para> If there's no
        /// match, no special message is returned; the response is simply empty. The following table shows the available filters. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcs service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeVpcs service method, as returned by AmazonEC2.</returns>
		DescribeVpcsResponse DescribeVpcs(DescribeVpcsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVpcs operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeVpcs"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeVpcsResponse> DescribeVpcsAsync(DescribeVpcsRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Gives you information about your VPCs. You can filter the results to return information only about VPCs that match criteria you
        /// specify. </para> <para> For example, you could ask to get information about a particular VPC or VPCs (or all your VPCs) only if the VPC's
        /// state is available. You can specify multiple filters (e.g., the VPC uses one of several sets of DHCP options, and the VPC's state is
        /// available). The result includes information for a particular VPC only if the VPC matches all your filters. </para> <para> If there's no
        /// match, no special message is returned; the response is simply empty. The following table shows the available filters. </para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeVpcs service method, as returned by AmazonEC2.</returns>
		DescribeVpcsResponse DescribeVpcs();
 

        /// <summary>
        /// <para> Gives you information about your VPN connections. </para> <para><b>IMPORTANT:</b> We strongly recommend you use HTTPS when calling
        /// this operation because the response contains sensitive cryptographic information for configuring your customer gateway. You can filter the
        /// results to return information only about VPN connections that match criteria you specify. For example, you could ask to get information
        /// about a particular VPN connection (or all) only if the VPN's state is pending or available. You can specify multiple filters (e.g., the VPN
        /// connection is associated with a particular VPN gateway, and the gateway's state is pending or available). The result includes information
        /// for a particular VPN connection only if the VPN connection matches all your filters. If there's no match, no special message is returned;
        /// the response is simply empty. The following table shows the available filters. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpnConnections service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeVpnConnections service method, as returned by AmazonEC2.</returns>
		DescribeVpnConnectionsResponse DescribeVpnConnections(DescribeVpnConnectionsRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVpnConnections operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeVpnConnections"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpnConnections operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeVpnConnectionsResponse> DescribeVpnConnectionsAsync(DescribeVpnConnectionsRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Gives you information about your VPN connections. </para> <para><b>IMPORTANT:</b> We strongly recommend you use HTTPS when calling
        /// this operation because the response contains sensitive cryptographic information for configuring your customer gateway. You can filter the
        /// results to return information only about VPN connections that match criteria you specify. For example, you could ask to get information
        /// about a particular VPN connection (or all) only if the VPN's state is pending or available. You can specify multiple filters (e.g., the VPN
        /// connection is associated with a particular VPN gateway, and the gateway's state is pending or available). The result includes information
        /// for a particular VPN connection only if the VPN connection matches all your filters. If there's no match, no special message is returned;
        /// the response is simply empty. The following table shows the available filters. </para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeVpnConnections service method, as returned by AmazonEC2.</returns>
		DescribeVpnConnectionsResponse DescribeVpnConnections();
 

        /// <summary>
        /// <para> Gives you information about your VPN gateways. You can filter the results to return information only about VPN gateways that match
        /// criteria you specify. </para> <para> For example, you could ask to get information about a particular VPN gateway (or all) only if the
        /// gateway's state is pending or available. You can specify multiple filters (e.g., the VPN gateway is in a particular Availability Zone and
        /// the gateway's state is pending or available). </para> <para> The result includes information for a particular VPN gateway only if the
        /// gateway matches all your filters. If there's no match, no special message is returned; the response is simply empty. The following table
        /// shows the available filters. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpnGateways service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeVpnGateways service method, as returned by AmazonEC2.</returns>
		DescribeVpnGatewaysResponse DescribeVpnGateways(DescribeVpnGatewaysRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVpnGateways operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeVpnGateways"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpnGateways operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DescribeVpnGatewaysResponse> DescribeVpnGatewaysAsync(DescribeVpnGatewaysRequest request, CancellationToken cancellationToken = default(CancellationToken));
 
        /// <summary>
        /// <para> Gives you information about your VPN gateways. You can filter the results to return information only about VPN gateways that match
        /// criteria you specify. </para> <para> For example, you could ask to get information about a particular VPN gateway (or all) only if the
        /// gateway's state is pending or available. You can specify multiple filters (e.g., the VPN gateway is in a particular Availability Zone and
        /// the gateway's state is pending or available). </para> <para> The result includes information for a particular VPN gateway only if the
        /// gateway matches all your filters. If there's no match, no special message is returned; the response is simply empty. The following table
        /// shows the available filters. </para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeVpnGateways service method, as returned by AmazonEC2.</returns>
		DescribeVpnGatewaysResponse DescribeVpnGateways();
 

        /// <summary>
        /// <para> Detaches an Internet gateway from a VPC, disabling connectivity between the Internet and the VPC. The VPC must not contain any
        /// running instances with elastic IP addresses. For more information about your VPC and Internet gateway, go to Amazon Virtual Private Cloud
        /// User Guide. </para> <para> For more information about Amazon Virtual Private Cloud and Internet gateways, go to the Amazon Virtual Private
        /// Cloud User Guide. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachInternetGateway service method on
        /// AmazonEC2.</param>
		DetachInternetGatewayResponse DetachInternetGateway(DetachInternetGatewayRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DetachInternetGateway operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DetachInternetGateway"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachInternetGateway operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DetachInternetGatewayResponse> DetachInternetGatewayAsync(DetachInternetGatewayRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachNetworkInterface service method on
        /// AmazonEC2.</param>
		DetachNetworkInterfaceResponse DetachNetworkInterface(DetachNetworkInterfaceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DetachNetworkInterface operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DetachNetworkInterface"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachNetworkInterface operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DetachNetworkInterfaceResponse> DetachNetworkInterfaceAsync(DetachNetworkInterfaceRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Detach a previously attached volume from a running instance. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachVolume service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the DetachVolume service method, as returned by AmazonEC2.</returns>
		DetachVolumeResponse DetachVolume(DetachVolumeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DetachVolume operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DetachVolume"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachVolume operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DetachVolumeResponse> DetachVolumeAsync(DetachVolumeRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Detaches a VPN gateway from a VPC. You do this if you're planning to turn off the VPC and not use it anymore. You can confirm a VPN
        /// gateway has been completely detached from a VPC by describing the VPN gateway (any attachments to the VPN gateway are also described).
        /// </para> <para> You must wait for the attachment's state to switch to detached before you can delete the VPC or attach a different VPC to the
        /// VPN gateway. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachVpnGateway service method on
        /// AmazonEC2.</param>
		DetachVpnGatewayResponse DetachVpnGateway(DetachVpnGatewayRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DetachVpnGateway operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DetachVpnGateway"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachVpnGateway operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DetachVpnGatewayResponse> DetachVpnGatewayAsync(DetachVpnGatewayRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableVgwRoutePropagation service
        /// method on AmazonEC2.</param>
		DisableVgwRoutePropagationResponse DisableVgwRoutePropagation(DisableVgwRoutePropagationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisableVgwRoutePropagation operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DisableVgwRoutePropagation"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableVgwRoutePropagation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DisableVgwRoutePropagationResponse> DisableVgwRoutePropagationAsync(DisableVgwRoutePropagationRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> The DisassociateAddress operation disassociates the specified elastic IP address from the instance to which it is assigned. This is
        /// an idempotent operation. If you enter it more than once, Amazon EC2 does not return an error. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateAddress service method on
        /// AmazonEC2.</param>
		DisassociateAddressResponse DisassociateAddress(DisassociateAddressRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateAddress operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DisassociateAddress"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateAddress operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DisassociateAddressResponse> DisassociateAddressAsync(DisassociateAddressRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Disassociates a subnet from a route table. </para> <para> After you perform this action, the subnet no longer uses the routes in the
        /// route table. Instead it uses the routes in the VPC's main route table. For more information about route tables, go to <a href="http://docs.amazonwebservices.com/AmazonVPC/latest/UserGuide/VPC_Route_Tables.html">Route Tables</a> in the Amazon Virtual Private
        /// Cloud User Guide. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateRouteTable service method on
        /// AmazonEC2.</param>
		DisassociateRouteTableResponse DisassociateRouteTable(DisassociateRouteTableRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateRouteTable operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DisassociateRouteTable"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateRouteTable operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<DisassociateRouteTableResponse> DisassociateRouteTableAsync(DisassociateRouteTableRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableVgwRoutePropagation service
        /// method on AmazonEC2.</param>
		EnableVgwRoutePropagationResponse EnableVgwRoutePropagation(EnableVgwRoutePropagationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the EnableVgwRoutePropagation operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.EnableVgwRoutePropagation"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableVgwRoutePropagation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<EnableVgwRoutePropagationResponse> EnableVgwRoutePropagationAsync(EnableVgwRoutePropagationRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Enable IO on the volume after an event has occured. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableVolumeIO service method on
        /// AmazonEC2.</param>
		EnableVolumeIOResponse EnableVolumeIO(EnableVolumeIORequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the EnableVolumeIO operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.EnableVolumeIO"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableVolumeIO operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<EnableVolumeIOResponse> EnableVolumeIOAsync(EnableVolumeIORequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> The GetConsoleOutput operation retrieves console output for the specified instance. </para> <para> Instance console output is
        /// buffered and posted shortly after instance boot, reboot, and termination. Amazon EC2 preserves the most recent 64 KB output which will be
        /// available for at least one hour after the most recent post. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetConsoleOutput service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the GetConsoleOutput service method, as returned by AmazonEC2.</returns>
		GetConsoleOutputResponse GetConsoleOutput(GetConsoleOutputRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetConsoleOutput operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.GetConsoleOutput"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetConsoleOutput operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<GetConsoleOutputResponse> GetConsoleOutputAsync(GetConsoleOutputRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Retrieves the encrypted administrator password for the instances running Windows. </para> <para><b>NOTE:</b> The Windows password is
        /// only generated the first time an AMI is launched. It is not generated for rebundled AMIs or after the password is changed on an instance.
        /// The password is encrypted using the key pair that you provided. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPasswordData service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the GetPasswordData service method, as returned by AmazonEC2.</returns>
		GetPasswordDataResponse GetPasswordData(GetPasswordDataRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the GetPasswordData operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.GetPasswordData"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPasswordData operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<GetPasswordDataResponse> GetPasswordDataAsync(GetPasswordDataRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportInstance service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the ImportInstance service method, as returned by AmazonEC2.</returns>
		ImportInstanceResponse ImportInstance(ImportInstanceRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ImportInstance operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ImportInstance"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<ImportInstanceResponse> ImportInstanceAsync(ImportInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Imports the public key from an RSA key pair created with a third-party tool. This operation differs from CreateKeyPair as the private
        /// key is never transferred between the caller and AWS servers. </para> <para> RSA key pairs are easily created on Microsoft Windows and Linux
        /// OS systems using the <c>ssh-keygen</c> command line tool provided with the standard OpenSSH installation. Standard library support for RSA
        /// key pair creation is also available for Java, Ruby, Python, and many other programming languages. </para> <para>The following formats are
        /// supported:</para>
        /// <ul>
        /// <li> OpenSSH public key format, </li>
        /// <li> Base64 encoded DER format. </li>
        /// <li> SSH public key file format as specified in <a href="http://tools.ietf.org/html/rfc4716"> RFC4716 </a> .
        /// </li>
        /// 
        /// </ul>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportKeyPair service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the ImportKeyPair service method, as returned by AmazonEC2.</returns>
		ImportKeyPairResponse ImportKeyPair(ImportKeyPairRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ImportKeyPair operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ImportKeyPair"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportKeyPair operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<ImportKeyPairResponse> ImportKeyPairAsync(ImportKeyPairRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportVolume service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the ImportVolume service method, as returned by AmazonEC2.</returns>
		ImportVolumeResponse ImportVolume(ImportVolumeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ImportVolume operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ImportVolume"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportVolume operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<ImportVolumeResponse> ImportVolumeAsync(ImportVolumeRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> The ModifyImageAttribute operation modifies an attribute of an AMI. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyImageAttribute service method on
        /// AmazonEC2.</param>
		ModifyImageAttributeResponse ModifyImageAttribute(ModifyImageAttributeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyImageAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ModifyImageAttribute"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyImageAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<ModifyImageAttributeResponse> ModifyImageAttributeAsync(ModifyImageAttributeRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Modifies an attribute of an instance. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyInstanceAttribute service method on
        /// AmazonEC2.</param>
		ModifyInstanceAttributeResponse ModifyInstanceAttribute(ModifyInstanceAttributeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyInstanceAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ModifyInstanceAttribute"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyInstanceAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<ModifyInstanceAttributeResponse> ModifyInstanceAttributeAsync(ModifyInstanceAttributeRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyNetworkInterfaceAttribute
        /// service method on AmazonEC2.</param>
		ModifyNetworkInterfaceAttributeResponse ModifyNetworkInterfaceAttribute(ModifyNetworkInterfaceAttributeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyNetworkInterfaceAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ModifyNetworkInterfaceAttribute"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyNetworkInterfaceAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<ModifyNetworkInterfaceAttributeResponse> ModifyNetworkInterfaceAttributeAsync(ModifyNetworkInterfaceAttributeRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> The ModifyReservedInstances operation modifies the Availability Zone, instance count, instance type, or network platform (EC2-Classic
        /// or EC2-VPC) of your Reserved Instances. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyReservedInstances service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the ModifyReservedInstances service method, as returned by AmazonEC2.</returns>
		ModifyReservedInstancesResponse ModifyReservedInstances(ModifyReservedInstancesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyReservedInstances operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ModifyReservedInstances"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyReservedInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<ModifyReservedInstancesResponse> ModifyReservedInstancesAsync(ModifyReservedInstancesRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Adds or remove permission settings for the specified snapshot. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifySnapshotAttribute service method on
        /// AmazonEC2.</param>
		ModifySnapshotAttributeResponse ModifySnapshotAttribute(ModifySnapshotAttributeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ModifySnapshotAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ModifySnapshotAttribute"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifySnapshotAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<ModifySnapshotAttributeResponse> ModifySnapshotAttributeAsync(ModifySnapshotAttributeRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyVolumeAttribute service method on
        /// AmazonEC2.</param>
		ModifyVolumeAttributeResponse ModifyVolumeAttribute(ModifyVolumeAttributeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyVolumeAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ModifyVolumeAttribute"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyVolumeAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<ModifyVolumeAttributeResponse> ModifyVolumeAttributeAsync(ModifyVolumeAttributeRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyVpcAttribute service method on
        /// AmazonEC2.</param>
		ModifyVpcAttributeResponse ModifyVpcAttribute(ModifyVpcAttributeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyVpcAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ModifyVpcAttribute"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyVpcAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<ModifyVpcAttributeResponse> ModifyVpcAttributeAsync(ModifyVpcAttributeRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Enables monitoring for a running instance. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the MonitorInstances service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the MonitorInstances service method, as returned by AmazonEC2.</returns>
		MonitorInstancesResponse MonitorInstances(MonitorInstancesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the MonitorInstances operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.MonitorInstances"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the MonitorInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<MonitorInstancesResponse> MonitorInstancesAsync(MonitorInstancesRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> The PurchaseReservedInstancesOffering operation purchases a Reserved Instance for use with your account. With Amazon EC2 Reserved
        /// Instances, you purchase the right to launch Amazon EC2 instances for a period of time (without getting insufficient capacity errors) and pay
        /// a lower usage rate for the actual time used. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the
        /// PurchaseReservedInstancesOffering service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the PurchaseReservedInstancesOffering service method, as returned by AmazonEC2.</returns>
		PurchaseReservedInstancesOfferingResponse PurchaseReservedInstancesOffering(PurchaseReservedInstancesOfferingRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the PurchaseReservedInstancesOffering operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.PurchaseReservedInstancesOffering"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PurchaseReservedInstancesOffering operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<PurchaseReservedInstancesOfferingResponse> PurchaseReservedInstancesOfferingAsync(PurchaseReservedInstancesOfferingRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> The RebootInstances operation requests a reboot of one or more instances. This operation is asynchronous; it only queues a request to
        /// reboot the specified instance(s). The operation will succeed if the instances are valid and belong to the user. Requests to reboot
        /// terminated instances are ignored. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RebootInstances service method on
        /// AmazonEC2.</param>
		RebootInstancesResponse RebootInstances(RebootInstancesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RebootInstances operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.RebootInstances"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RebootInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<RebootInstancesResponse> RebootInstancesAsync(RebootInstancesRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> The RegisterImage operation registers an AMI with Amazon EC2. Images must be registered before they can be launched. For more
        /// information, see RunInstances. </para> <para> Each AMI is associated with an unique ID which is provided by the Amazon EC2 service through
        /// the RegisterImage operation. During registration, Amazon EC2 retrieves the specified image manifest from Amazon S3 and verifies that the
        /// image is owned by the user registering the image. </para> <para> The image manifest is retrieved once and stored within the Amazon EC2. Any
        /// modifications to an image in Amazon S3 invalidates this registration. If you make changes to an image, deregister the previous image and
        /// register the new image. For more information, see DeregisterImage. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterImage service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the RegisterImage service method, as returned by AmazonEC2.</returns>
		RegisterImageResponse RegisterImage(RegisterImageRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterImage operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.RegisterImage"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterImage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<RegisterImageResponse> RegisterImageAsync(RegisterImageRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> The ReleaseAddress operation releases an elastic IP address associated with your account. </para> <para><b>NOTE:</b> Releasing an IP
        /// address automatically disassociates it from any instance with which it is associated. For more information, see DisassociateAddress. </para>
        /// <para><b>IMPORTANT:</b> After releasing an elastic IP address, it is released to the IP address pool and might no longer be available to
        /// your account. Make sure to update your DNS records and any servers or devices that communicate with the address. If you run this operation
        /// on an elastic IP address that is already released, the address might be assigned to another account which will cause Amazon EC2 to return an
        /// error. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReleaseAddress service method on
        /// AmazonEC2.</param>
		ReleaseAddressResponse ReleaseAddress(ReleaseAddressRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ReleaseAddress operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ReleaseAddress"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReleaseAddress operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<ReleaseAddressResponse> ReleaseAddressAsync(ReleaseAddressRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Changes which network ACL a subnet is associated with. By default when you create a subnet, it's automatically associated with the
        /// default network ACL. For more information about network ACLs, go to Network ACLs in the Amazon Virtual Private Cloud User Guide. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReplaceNetworkAclAssociation service
        /// method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the ReplaceNetworkAclAssociation service method, as returned by AmazonEC2.</returns>
		ReplaceNetworkAclAssociationResponse ReplaceNetworkAclAssociation(ReplaceNetworkAclAssociationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ReplaceNetworkAclAssociation operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ReplaceNetworkAclAssociation"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReplaceNetworkAclAssociation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<ReplaceNetworkAclAssociationResponse> ReplaceNetworkAclAssociationAsync(ReplaceNetworkAclAssociationRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Replaces an entry (i.e., rule) in a network ACL. For more information about network ACLs, go to Network ACLs in the Amazon Virtual
        /// Private Cloud User Guide. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReplaceNetworkAclEntry service method on
        /// AmazonEC2.</param>
		ReplaceNetworkAclEntryResponse ReplaceNetworkAclEntry(ReplaceNetworkAclEntryRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ReplaceNetworkAclEntry operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ReplaceNetworkAclEntry"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReplaceNetworkAclEntry operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<ReplaceNetworkAclEntryResponse> ReplaceNetworkAclEntryAsync(ReplaceNetworkAclEntryRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Replaces an existing route within a route table in a VPC. For more information about route tables, go to <a href="http://docs.amazonwebservices.com/AmazonVPC/latest/UserGuide/VPC_Route_Tables.html">Route Tables</a> in the Amazon Virtual Private
        /// Cloud User Guide. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReplaceRoute service method on AmazonEC2.</param>
		ReplaceRouteResponse ReplaceRoute(ReplaceRouteRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ReplaceRoute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ReplaceRoute"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReplaceRoute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<ReplaceRouteResponse> ReplaceRouteAsync(ReplaceRouteRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Changes the route table associated with a given subnet in a VPC. After you execute this action, the subnet uses the routes in the new
        /// route table it's associated with. For more information about route tables, go to <a href="http://docs.amazonwebservices.com/AmazonVPC/latest/UserGuide/VPC_Route_Tables.html">Route Tables</a> in the Amazon Virtual Private
        /// Cloud User Guide. </para> <para> You can also use this to change which table is the main route table in the VPC. You just specify the main
        /// route table's association ID and the route table that you want to be the new main route table. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReplaceRouteTableAssociation service
        /// method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the ReplaceRouteTableAssociation service method, as returned by AmazonEC2.</returns>
		ReplaceRouteTableAssociationResponse ReplaceRouteTableAssociation(ReplaceRouteTableAssociationRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ReplaceRouteTableAssociation operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ReplaceRouteTableAssociation"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReplaceRouteTableAssociation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<ReplaceRouteTableAssociationResponse> ReplaceRouteTableAssociationAsync(ReplaceRouteTableAssociationRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReportInstanceStatus service method on
        /// AmazonEC2.</param>
		ReportInstanceStatusResponse ReportInstanceStatus(ReportInstanceStatusRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ReportInstanceStatus operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ReportInstanceStatus"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReportInstanceStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<ReportInstanceStatusResponse> ReportInstanceStatusAsync(ReportInstanceStatusRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Creates a Spot Instance request. </para> <para> Spot Instances are instances that Amazon EC2 starts on your behalf when the maximum
        /// price that you specify exceeds the current Spot Price. Amazon EC2 periodically sets the Spot Price based on available Spot Instance capacity
        /// and current spot instance requests. </para> <para> For conceptual information about Spot Instances, refer to the Amazon Elastic Compute
        /// Cloud Developer Guide or Amazon Elastic Compute Cloud User Guide. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RequestSpotInstances service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the RequestSpotInstances service method, as returned by AmazonEC2.</returns>
		RequestSpotInstancesResponse RequestSpotInstances(RequestSpotInstancesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RequestSpotInstances operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.RequestSpotInstances"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RequestSpotInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<RequestSpotInstancesResponse> RequestSpotInstancesAsync(RequestSpotInstancesRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> The ResetImageAttribute operation resets an attribute of an AMI to its default value. </para> <para><b>NOTE:</b> The productCodes
        /// attribute cannot be reset. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetImageAttribute service method on
        /// AmazonEC2.</param>
		ResetImageAttributeResponse ResetImageAttribute(ResetImageAttributeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ResetImageAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ResetImageAttribute"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetImageAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<ResetImageAttributeResponse> ResetImageAttributeAsync(ResetImageAttributeRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Resets an attribute of an instance to its default value. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetInstanceAttribute service method on
        /// AmazonEC2.</param>
		ResetInstanceAttributeResponse ResetInstanceAttribute(ResetInstanceAttributeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ResetInstanceAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ResetInstanceAttribute"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetInstanceAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<ResetInstanceAttributeResponse> ResetInstanceAttributeAsync(ResetInstanceAttributeRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetNetworkInterfaceAttribute
        /// service method on AmazonEC2.</param>
		ResetNetworkInterfaceAttributeResponse ResetNetworkInterfaceAttribute(ResetNetworkInterfaceAttributeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ResetNetworkInterfaceAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ResetNetworkInterfaceAttribute"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetNetworkInterfaceAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<ResetNetworkInterfaceAttributeResponse> ResetNetworkInterfaceAttributeAsync(ResetNetworkInterfaceAttributeRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Resets permission settings for the specified snapshot. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetSnapshotAttribute service method on
        /// AmazonEC2.</param>
		ResetSnapshotAttributeResponse ResetSnapshotAttribute(ResetSnapshotAttributeRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the ResetSnapshotAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ResetSnapshotAttribute"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetSnapshotAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<ResetSnapshotAttributeResponse> ResetSnapshotAttributeAsync(ResetSnapshotAttributeRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> This action applies only to security groups in a VPC. It doesn't work with EC2 security groups. For information about Amazon Virtual
        /// Private Cloud and VPC security groups, go to the Amazon Virtual Private Cloud User Guide. </para> <para> The action removes one or more
        /// egress rules from a VPC security group. The values that you specify in the revoke request (e.g., ports, etc.) must match the existing rule's
        /// values in order for the rule to be revoked. </para> <para> Each rule consists of the protocol, and the CIDR range or destination security
        /// group. For the TCP and UDP protocols, you must also specify the destination port or range of ports. For the ICMP protocol, you must also
        /// specify the ICMP type and code. </para> <para> Rule changes are propagated to instances within the security group as quickly as possible.
        /// However, a small delay might occur. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RevokeSecurityGroupEgress service
        /// method on AmazonEC2.</param>
		RevokeSecurityGroupEgressResponse RevokeSecurityGroupEgress(RevokeSecurityGroupEgressRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RevokeSecurityGroupEgress operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.RevokeSecurityGroupEgress"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RevokeSecurityGroupEgress operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<RevokeSecurityGroupEgressResponse> RevokeSecurityGroupEgressAsync(RevokeSecurityGroupEgressRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> The RevokeSecurityGroupIngress operation revokes permissions from a security group. The permissions used to revoke must be specified
        /// using the same values used to grant the permissions. </para> <para> Permissions are specified by IP protocol (TCP, UDP, or ICMP), the source
        /// of the request (by IP range or an Amazon EC2 user-group pair), the source and destination port ranges (for TCP and UDP), and the ICMP codes
        /// and types (for ICMP). </para> <para> Permission changes are quickly propagated to instances within the security group. However, depending on
        /// the number of instances in the group, a small delay might occur. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RevokeSecurityGroupIngress service
        /// method on AmazonEC2.</param>
		RevokeSecurityGroupIngressResponse RevokeSecurityGroupIngress(RevokeSecurityGroupIngressRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RevokeSecurityGroupIngress operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.RevokeSecurityGroupIngress"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RevokeSecurityGroupIngress operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<RevokeSecurityGroupIngressResponse> RevokeSecurityGroupIngressAsync(RevokeSecurityGroupIngressRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> The RunInstances operation launches a specified number of instances. </para> <para> If Amazon EC2 cannot launch the minimum number
        /// AMIs you request, no instances launch. If there is insufficient capacity to launch the maximum number of AMIs you request, Amazon EC2
        /// launches as many as possible to satisfy the requested maximum values. </para> <para> Every instance is launched in a security group. If you
        /// do not specify a security group at launch, the instances start in your default security group. For more information on creating security
        /// groups, see CreateSecurityGroup. </para> <para> An optional instance type can be specified. For information about instance types, see
        /// Instance Types. </para> <para> You can provide an optional key pair ID for each image in the launch request (for more information, see
        /// CreateKeyPair). All instances that are created from images that use this key pair will have access to the associated public key at boot. You
        /// can use this key to provide secure access to an instance of an image on a per-instance basis. Amazon EC2 public images use this feature to
        /// provide secure access without passwords. </para> <para><b>IMPORTANT:</b> Launching public images without a key pair ID will leave them
        /// inaccessible. The public key material is made available to the instance at boot time by placing it in the openssh_id.pub file on a logical
        /// device that is exposed to the instance as /dev/sda2 (the ephemeral store). The format of this file is suitable for use as an entry within
        /// ~/.ssh/authorized_keys (the OpenSSH format). This can be done at boot (e.g., as part of rc.local) allowing for secure access without
        /// passwords. Optional user data can be provided in the launch request. All instances that collectively comprise the launch request have access
        /// to this data For more information, see Instance Metadata. </para> <para><b>NOTE:</b> If any of the AMIs have a product code attached for
        /// which the user has not subscribed, the RunInstances call will fail. </para> <para><b>IMPORTANT:</b> We strongly recommend using the 2.6.18
        /// Xen stock kernel with the c1.medium and c1.xlarge instances. Although the default Amazon EC2 kernels will work, the new kernels provide
        /// greater stability and performance for these instance types. For more information about kernels, see Kernels, RAM Disks, and Block Device
        /// Mappings. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RunInstances service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the RunInstances service method, as returned by AmazonEC2.</returns>
		RunInstancesResponse RunInstances(RunInstancesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the RunInstances operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.RunInstances"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RunInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<RunInstancesResponse> RunInstancesAsync(RunInstancesRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Starts an instance that uses an Amazon EBS volume as its root device. Instances that use Amazon EBS volumes as their root devices can
        /// be quickly stopped and started. When an instance is stopped, the compute resources are released and you are not billed for hourly instance
        /// usage. However, your root partition Amazon EBS volume remains, continues to persist your data, and you are charged for Amazon EBS volume
        /// usage. You can restart your instance at any time. </para> <para><b>NOTE:</b> Performing this operation on an instance that uses an instance
        /// store as its root device returns an error. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartInstances service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the StartInstances service method, as returned by AmazonEC2.</returns>
		StartInstancesResponse StartInstances(StartInstancesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StartInstances operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.StartInstances"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<StartInstancesResponse> StartInstancesAsync(StartInstancesRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Stops an instance that uses an Amazon EBS volume as its root device. Instances that use Amazon EBS volumes as their root devices can
        /// be quickly stopped and started. When an instance is stopped, the compute resources are released and you are not billed for hourly instance
        /// usage. However, your root partition Amazon EBS volume remains, continues to persist your data, and you are charged for Amazon EBS volume
        /// usage. You can restart your instance at any time. </para> <para><b>NOTE:</b> Before stopping an instance, make sure it is in a state from
        /// which it can be restarted. Stopping an instance does not preserve data stored in RAM. Performing this operation on an instance that uses an
        /// instance store as its root device returns an error. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopInstances service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the StopInstances service method, as returned by AmazonEC2.</returns>
		StopInstancesResponse StopInstances(StopInstancesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the StopInstances operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.StopInstances"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<StopInstancesResponse> StopInstancesAsync(StopInstancesRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> The TerminateInstances operation shuts down one or more instances. This operation is idempotent; if you terminate an instance more
        /// than once, each call will succeed. </para> <para> Terminated instances will remain visible after termination (approximately one hour).
        /// </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TerminateInstances service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the TerminateInstances service method, as returned by AmazonEC2.</returns>
		TerminateInstancesResponse TerminateInstances(TerminateInstancesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the TerminateInstances operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.TerminateInstances"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TerminateInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<TerminateInstancesResponse> TerminateInstancesAsync(TerminateInstancesRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UnassignPrivateIpAddresses service
        /// method on AmazonEC2.</param>
		UnassignPrivateIpAddressesResponse UnassignPrivateIpAddresses(UnassignPrivateIpAddressesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UnassignPrivateIpAddresses operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.UnassignPrivateIpAddresses"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UnassignPrivateIpAddresses operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<UnassignPrivateIpAddressesResponse> UnassignPrivateIpAddressesAsync(UnassignPrivateIpAddressesRequest request, CancellationToken cancellationToken = default(CancellationToken));
 

        /// <summary>
        /// <para> Disables monitoring for a running instance. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UnmonitorInstances service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the UnmonitorInstances service method, as returned by AmazonEC2.</returns>
		UnmonitorInstancesResponse UnmonitorInstances(UnmonitorInstancesRequest request);

        /// <summary>
        /// Initiates the asynchronous execution of the UnmonitorInstances operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.UnmonitorInstances"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UnmonitorInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		Task<UnmonitorInstancesResponse> UnmonitorInstancesAsync(UnmonitorInstancesRequest request, CancellationToken cancellationToken = default(CancellationToken));
    }
}
