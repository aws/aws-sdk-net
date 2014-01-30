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
using Amazon.EC2.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.EC2
{
    /// <summary>
    /// Implementation for accessing AmazonEC2.
    /// 
    /// Amazon Elastic Compute Cloud <para>Amazon Elastic Compute Cloud (Amazon EC2) provides resizable computing capacity in the Amazon Web
    /// Services (AWS) cloud. Using Amazon EC2 eliminates your need to invest in hardware up front, so you can develop and deploy applications
    /// faster.</para>
    /// </summary>
    /// <summary>
    /// Implementation for accessing AmazonEC2.
    /// 
    /// <para> Amazon Elastic Compute Cloud (Amazon EC2) is a web service that provides resizable compute capacity in the cloud. It is designed to
    /// make web-scale computing easier for developers. </para> <para> Amazon EC2's simple web service interface allows you to obtain and configure
    /// capacity with minimal friction. It provides you with complete control of your computing resources and lets you run on Amazon's proven
    /// computing environment. Amazon EC2 reduces the time required to obtain and boot new server instances to minutes, allowing you to quickly
    /// scale capacity, both up and down, as your computing requirements change. Amazon EC2 changes the economics of computing by allowing you to
    /// pay only for capacity that you actually use. Amazon EC2 provides developers the tools to build failure resilient applications and isolate
    /// themselves from common failure scenarios. </para> <para> Visit http://aws.amazon.com/ec2/ for more information. </para>
    /// </summary>
	public partial class AmazonEC2Client : AmazonWebServiceClient, Amazon.EC2.IAmazonEC2
    {

        EC2Signer signer = new EC2Signer();
        #region Constructors

        /// <summary>
        /// Constructs AmazonEC2Client with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonEC2Client(AWSCredentials credentials)
            : this(credentials, new AmazonEC2Config())
        {
        }

        /// <summary>
        /// Constructs AmazonEC2Client with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonEC2Client(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonEC2Config(){RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonEC2Client with AWS Credentials and an
        /// AmazonEC2Client Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonEC2Client Configuration Object</param>
        public AmazonEC2Client(AWSCredentials credentials, AmazonEC2Config clientConfig)
            : base(credentials, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        /// <summary>
        /// Constructs AmazonEC2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonEC2Client(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonEC2Config())
        {
        }

        /// <summary>
        /// Constructs AmazonEC2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonEC2Client(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonEC2Config() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonEC2Client with AWS Access Key ID, AWS Secret Key and an
        /// AmazonEC2Client Configuration object. If the config object's
        /// UseSecureStringForAwsSecretKey is false, the AWS Secret Key
        /// is stored as a clear-text string. Please use this option only
        /// if the application environment doesn't allow the use of SecureStrings.
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonEC2Client Configuration Object</param>
        public AmazonEC2Client(string awsAccessKeyId, string awsSecretAccessKey, AmazonEC2Config clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        /// <summary>
        /// Constructs AmazonEC2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonEC2Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonEC2Config())
        {
        }

        /// <summary>
        /// Constructs AmazonEC2Client with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonEC2Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonEC2Config(){RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonEC2Client with AWS Access Key ID, AWS Secret Key and an
        /// AmazonEC2Client Configuration object. If the config object's
        /// UseSecureStringForAwsSecretKey is false, the AWS Secret Key
        /// is stored as a clear-text string. Please use this option only
        /// if the application environment doesn't allow the use of SecureStrings.
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonEC2Client Configuration Object</param>
        public AmazonEC2Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonEC2Config clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        #endregion

 
		internal AllocateAddressResponse AllocateAddress(AllocateAddressRequest request)
        {
            var task = AllocateAddressAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Acquires an Elastic IP address.</para> <para>An Elastic IP address is for use either in the EC2-Classic platform or in a VPC. For more
        /// information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/elastic-ip-addresses-eip.html">Elastic IP Addresses</a> in the
        /// <i>Amazon Elastic Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="allocateAddressRequest">Container for the necessary parameters to execute the AllocateAddress service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the AllocateAddress service method, as returned by AmazonEC2.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<AllocateAddressResponse> AllocateAddressAsync(AllocateAddressRequest allocateAddressRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AllocateAddressRequestMarshaller();
            var unmarshaller = AllocateAddressResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, AllocateAddressRequest, AllocateAddressResponse>(allocateAddressRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal AssignPrivateIpAddressesResponse AssignPrivateIpAddresses(AssignPrivateIpAddressesRequest request)
        {
            var task = AssignPrivateIpAddressesAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Assigns one or more secondary private IP addresses to the specified network interface. You can specify one or more specific secondary
        /// IP addresses, or you can specify the number of secondary IP addresses to be automatically assigned within the subnet's CIDR block range. The
        /// number of secondary IP addresses that you can assign to an instance varies by instance type. For information about instance types, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-types.html">Instance Types</a> in the <i>Amazon Elastic Compute Cloud
        /// User Guide</i> . For more information about Elastic IP addresses, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/elastic-ip-addresses-eip.html">Elastic IP Addresses</a> in the <i>Amazon Elastic
        /// Compute Cloud User Guide</i> .</para> <para>AssignPrivateIpAddresses is available only in EC2-VPC.</para>
        /// </summary>
        /// 
        /// <param name="assignPrivateIpAddressesRequest">Container for the necessary parameters to execute the AssignPrivateIpAddresses service method
        /// on AmazonEC2.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<AssignPrivateIpAddressesResponse> AssignPrivateIpAddressesAsync(AssignPrivateIpAddressesRequest assignPrivateIpAddressesRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AssignPrivateIpAddressesRequestMarshaller();
            var unmarshaller = AssignPrivateIpAddressesResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, AssignPrivateIpAddressesRequest, AssignPrivateIpAddressesResponse>(assignPrivateIpAddressesRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal AssociateAddressResponse AssociateAddress(AssociateAddressRequest request)
        {
            var task = AssociateAddressAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Associates an Elastic IP address with an instance or a network interface.</para> <para>An Elastic IP address is for use in either the
        /// EC2-Classic platform or in a VPC. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/elastic-ip-addresses-eip.html">Elastic IP Addresses</a> in the <i>Amazon Elastic
        /// Compute Cloud User Guide</i> .</para> <para>[EC2-Classic, default VPC] If the Elastic IP address is already associated with a different
        /// instance, it is disassociated from that instance and associated with the specified instance.</para> <para>[EC2-VPC] If you don't specify a
        /// private IP address, the Elastic IP address is associated with the primary IP address. If the Elastic IP address is already associated with a
        /// different instance or a network interface, you get an error unless you allow reassociation.</para> <para>This is an idempotent operation. If
        /// you perform the operation more than once, Amazon EC2 doesn't return an error.</para>
        /// </summary>
        /// 
        /// <param name="associateAddressRequest">Container for the necessary parameters to execute the AssociateAddress service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the AssociateAddress service method, as returned by AmazonEC2.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<AssociateAddressResponse> AssociateAddressAsync(AssociateAddressRequest associateAddressRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AssociateAddressRequestMarshaller();
            var unmarshaller = AssociateAddressResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, AssociateAddressRequest, AssociateAddressResponse>(associateAddressRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal AssociateDhcpOptionsResponse AssociateDhcpOptions(AssociateDhcpOptionsRequest request)
        {
            var task = AssociateDhcpOptionsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Associates a set of DHCP options (that you've previously created) with the specified VPC, or associates no DHCP options with the
        /// VPC.</para> <para>After you associate the options with the VPC, any existing instances and all new instances that you launch in that VPC use
        /// the options. You don't need to restart or relaunch the instances. They automatically pick up the changes within a few hours, depending on
        /// how frequently the instance renews its DHCP lease. You can explicitly renew the lease using the operating system on the instance.</para>
        /// <para>For more information, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_DHCP_Options.html">DHCP Options Sets</a>
        /// in the <i>Amazon Virtual Private Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="associateDhcpOptionsRequest">Container for the necessary parameters to execute the AssociateDhcpOptions service method on
        /// AmazonEC2.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<AssociateDhcpOptionsResponse> AssociateDhcpOptionsAsync(AssociateDhcpOptionsRequest associateDhcpOptionsRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AssociateDhcpOptionsRequestMarshaller();
            var unmarshaller = AssociateDhcpOptionsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, AssociateDhcpOptionsRequest, AssociateDhcpOptionsResponse>(associateDhcpOptionsRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal AssociateRouteTableResponse AssociateRouteTable(AssociateRouteTableRequest request)
        {
            var task = AssociateRouteTableAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Associates a subnet with a route table. The subnet and route table must be in the same VPC. This association causes traffic
        /// originating from the subnet to be routed according to the routes in the route table. The action returns an association ID, which you need in
        /// order to disassociate the route table from the subnet later. A route table can be associated with multiple subnets.</para> <para>For more
        /// information about route tables, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Route_Tables.html">Route Tables</a>
        /// in the <i>Amazon Virtual Private Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="associateRouteTableRequest">Container for the necessary parameters to execute the AssociateRouteTable service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the AssociateRouteTable service method, as returned by AmazonEC2.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<AssociateRouteTableResponse> AssociateRouteTableAsync(AssociateRouteTableRequest associateRouteTableRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AssociateRouteTableRequestMarshaller();
            var unmarshaller = AssociateRouteTableResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, AssociateRouteTableRequest, AssociateRouteTableResponse>(associateRouteTableRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal AttachInternetGatewayResponse AttachInternetGateway(AttachInternetGatewayRequest request)
        {
            var task = AttachInternetGatewayAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Attaches an Internet gateway to a VPC, enabling connectivity between the Internet and the VPC. For more information about your VPC and
        /// Internet gateway, see the <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/">Amazon Virtual Private Cloud User Guide</a>
        /// .</para>
        /// </summary>
        /// 
        /// <param name="attachInternetGatewayRequest">Container for the necessary parameters to execute the AttachInternetGateway service method on
        /// AmazonEC2.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<AttachInternetGatewayResponse> AttachInternetGatewayAsync(AttachInternetGatewayRequest attachInternetGatewayRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AttachInternetGatewayRequestMarshaller();
            var unmarshaller = AttachInternetGatewayResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, AttachInternetGatewayRequest, AttachInternetGatewayResponse>(attachInternetGatewayRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal AttachNetworkInterfaceResponse AttachNetworkInterface(AttachNetworkInterfaceRequest request)
        {
            var task = AttachNetworkInterfaceAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Attaches a network interface to an instance.</para>
        /// </summary>
        /// 
        /// <param name="attachNetworkInterfaceRequest">Container for the necessary parameters to execute the AttachNetworkInterface service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the AttachNetworkInterface service method, as returned by AmazonEC2.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<AttachNetworkInterfaceResponse> AttachNetworkInterfaceAsync(AttachNetworkInterfaceRequest attachNetworkInterfaceRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AttachNetworkInterfaceRequestMarshaller();
            var unmarshaller = AttachNetworkInterfaceResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, AttachNetworkInterfaceRequest, AttachNetworkInterfaceResponse>(attachNetworkInterfaceRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal AttachVolumeResponse AttachVolume(AttachVolumeRequest request)
        {
            var task = AttachVolumeAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Attaches an Amazon EBS volume to a running or stopped instance and exposes it to the instance with the specified device name.</para>
        /// <para>For a list of supported device names, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-attaching-volume.html">Attaching an Amazon EBS Volume to an Instance</a> . Any device names that aren't reserved for instance store volumes can be used for Amazon
        /// EBS volumes. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/InstanceStorage.html">Amazon EC2
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
        /// <para>For an overview of the AWS Marketplace, see <a href="https://aws.amazon.com/marketplace/help/200900000">https://aws.amazon.com/marketplace/help/200900000</a> . For more information about how to use the AWS Marketplace, see <a href="https://aws.amazon.com/marketplace">AWS Marketplace</a> .</para> <para>For more information about Amazon EBS volumes, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-attaching-volume.html">Attaching Amazon EBS Volumes</a> in the <i>Amazon
        /// Elastic Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="attachVolumeRequest">Container for the necessary parameters to execute the AttachVolume service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the AttachVolume service method, as returned by AmazonEC2.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<AttachVolumeResponse> AttachVolumeAsync(AttachVolumeRequest attachVolumeRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AttachVolumeRequestMarshaller();
            var unmarshaller = AttachVolumeResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, AttachVolumeRequest, AttachVolumeResponse>(attachVolumeRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal AttachVpnGatewayResponse AttachVpnGateway(AttachVpnGatewayRequest request)
        {
            var task = AttachVpnGatewayAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Attaches a virtual private gateway to a VPC. For more information, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_VPN.html">Adding a Hardware Virtual Private Gateway to Your VPC</a> in the
        /// <i>Amazon Virtual Private Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="attachVpnGatewayRequest">Container for the necessary parameters to execute the AttachVpnGateway service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the AttachVpnGateway service method, as returned by AmazonEC2.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<AttachVpnGatewayResponse> AttachVpnGatewayAsync(AttachVpnGatewayRequest attachVpnGatewayRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AttachVpnGatewayRequestMarshaller();
            var unmarshaller = AttachVpnGatewayResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, AttachVpnGatewayRequest, AttachVpnGatewayResponse>(attachVpnGatewayRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal AuthorizeSecurityGroupEgressResponse AuthorizeSecurityGroupEgress(AuthorizeSecurityGroupEgressRequest request)
        {
            var task = AuthorizeSecurityGroupEgressAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Adds one or more egress rules to a security group for use with a VPC. Specifically, this action permits instances to send traffic to
        /// one or more CIDR IP address ranges, or to one or more security groups for the same VPC.</para> <para><b>IMPORTANT:</b> You can have up to 50
        /// rules per security group (covering both ingress and egress rules). </para> <para>A security group is for use with instances either in the
        /// EC2-Classic platform or in a specific VPC. This action doesn't apply to security groups for use in EC2-Classic. For more information, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_SecurityGroups.html">Security Groups for Your VPC</a> in the <i>Amazon
        /// Virtual Private Cloud User Guide</i> .</para> <para>Each rule consists of the protocol (for example, TCP), plus either a CIDR range or a
        /// source group. For the TCP and UDP protocols, you must also specify the destination port or port range. For the ICMP protocol, you must also
        /// specify the ICMP type and code. You can use -1 for the type or code to mean all types or all codes.</para> <para>Rule changes are propagated
        /// to affected instances as quickly as possible. However, a small delay might occur.</para>
        /// </summary>
        /// 
        /// <param name="authorizeSecurityGroupEgressRequest">Container for the necessary parameters to execute the AuthorizeSecurityGroupEgress service
        /// method on AmazonEC2.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<AuthorizeSecurityGroupEgressResponse> AuthorizeSecurityGroupEgressAsync(AuthorizeSecurityGroupEgressRequest authorizeSecurityGroupEgressRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AuthorizeSecurityGroupEgressRequestMarshaller();
            var unmarshaller = AuthorizeSecurityGroupEgressResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, AuthorizeSecurityGroupEgressRequest, AuthorizeSecurityGroupEgressResponse>(authorizeSecurityGroupEgressRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal AuthorizeSecurityGroupIngressResponse AuthorizeSecurityGroupIngress(AuthorizeSecurityGroupIngressRequest request)
        {
            var task = AuthorizeSecurityGroupIngressAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

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
        /// service method on AmazonEC2.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<AuthorizeSecurityGroupIngressResponse> AuthorizeSecurityGroupIngressAsync(AuthorizeSecurityGroupIngressRequest authorizeSecurityGroupIngressRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AuthorizeSecurityGroupIngressRequestMarshaller();
            var unmarshaller = AuthorizeSecurityGroupIngressResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, AuthorizeSecurityGroupIngressRequest, AuthorizeSecurityGroupIngressResponse>(authorizeSecurityGroupIngressRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal BundleInstanceResponse BundleInstance(BundleInstanceRequest request)
        {
            var task = BundleInstanceAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Bundles an Amazon instance store-backed Windows instance.</para> <para>During bundling, only the root device volume (C:\) is bundled.
        /// Data on other instance store volumes is not preserved.</para> <para><b>NOTE:</b> This procedure is not applicable for Linux/Unix instances
        /// or Windows instances that are backed by Amazon EBS. </para> <para>For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/WindowsGuide/Creating_InstanceStoreBacked_WinAMI.html">Creating an Instance Store-Backed
        /// Windows AMI</a> .</para>
        /// </summary>
        /// 
        /// <param name="bundleInstanceRequest">Container for the necessary parameters to execute the BundleInstance service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the BundleInstance service method, as returned by AmazonEC2.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<BundleInstanceResponse> BundleInstanceAsync(BundleInstanceRequest bundleInstanceRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new BundleInstanceRequestMarshaller();
            var unmarshaller = BundleInstanceResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, BundleInstanceRequest, BundleInstanceResponse>(bundleInstanceRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal CancelBundleTaskResponse CancelBundleTask(CancelBundleTaskRequest request)
        {
            var task = CancelBundleTaskAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Cancels a bundling operation for an instance store-backed Windows instance.</para>
        /// </summary>
        /// 
        /// <param name="cancelBundleTaskRequest">Container for the necessary parameters to execute the CancelBundleTask service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the CancelBundleTask service method, as returned by AmazonEC2.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<CancelBundleTaskResponse> CancelBundleTaskAsync(CancelBundleTaskRequest cancelBundleTaskRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CancelBundleTaskRequestMarshaller();
            var unmarshaller = CancelBundleTaskResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CancelBundleTaskRequest, CancelBundleTaskResponse>(cancelBundleTaskRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal CancelConversionTaskResponse CancelConversionTask(CancelConversionTaskRequest request)
        {
            var task = CancelConversionTaskAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Cancels an active conversion task. The task can be the import of an instance or volume. The action removes all artifacts of the
        /// conversion, including a partially uploaded volume or instance. If the conversion is complete or is in the process of transferring the final
        /// disk image, the command fails and returns an exception.</para> <para>For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/UploadingYourInstancesandVolumes.html">Using the Command Line Tools to Import Your
        /// Virtual Machine to Amazon EC2</a> in the <i>Amazon Elastic Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="cancelConversionTaskRequest">Container for the necessary parameters to execute the CancelConversionTask service method on
        /// AmazonEC2.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<CancelConversionTaskResponse> CancelConversionTaskAsync(CancelConversionTaskRequest cancelConversionTaskRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CancelConversionTaskRequestMarshaller();
            var unmarshaller = CancelConversionTaskResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CancelConversionTaskRequest, CancelConversionTaskResponse>(cancelConversionTaskRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal CancelExportTaskResponse CancelExportTask(CancelExportTaskRequest request)
        {
            var task = CancelExportTaskAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Cancels an active export task. The request removes all artifacts of the export, including any partially-created Amazon S3 objects. If
        /// the export task is complete or is in the process of transferring the final disk image, the command fails and returns an error.</para>
        /// </summary>
        /// 
        /// <param name="cancelExportTaskRequest">Container for the necessary parameters to execute the CancelExportTask service method on
        /// AmazonEC2.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<CancelExportTaskResponse> CancelExportTaskAsync(CancelExportTaskRequest cancelExportTaskRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CancelExportTaskRequestMarshaller();
            var unmarshaller = CancelExportTaskResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CancelExportTaskRequest, CancelExportTaskResponse>(cancelExportTaskRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal CancelReservedInstancesListingResponse CancelReservedInstancesListing(CancelReservedInstancesListingRequest request)
        {
            var task = CancelReservedInstancesListingAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Cancels the specified Reserved Instance listing in the Reserved Instance Marketplace.</para> <para>For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ri-market-general.html">Reserved Instance Marketplace</a> in the <i>Amazon Elastic
        /// Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="cancelReservedInstancesListingRequest">Container for the necessary parameters to execute the CancelReservedInstancesListing
        /// service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the CancelReservedInstancesListing service method, as returned by AmazonEC2.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<CancelReservedInstancesListingResponse> CancelReservedInstancesListingAsync(CancelReservedInstancesListingRequest cancelReservedInstancesListingRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CancelReservedInstancesListingRequestMarshaller();
            var unmarshaller = CancelReservedInstancesListingResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CancelReservedInstancesListingRequest, CancelReservedInstancesListingResponse>(cancelReservedInstancesListingRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal CancelSpotInstanceRequestsResponse CancelSpotInstanceRequests(CancelSpotInstanceRequestsRequest request)
        {
            var task = CancelSpotInstanceRequestsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Cancels one or more Spot Instance requests. Spot Instances are instances that Amazon EC2 starts on your behalf when the maximum price
        /// that you specify exceeds the current Spot Price. Amazon EC2 periodically sets the Spot Price based on available Spot Instance capacity and
        /// current Spot Instance requests. For more information about Spot Instances, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-spot-instances.html">Spot Instances</a> in the <i>Amazon Elastic Compute
        /// Cloud User Guide</i> .</para> <para><b>IMPORTANT:</b> Canceling a Spot Instance request does not terminate running Spot Instances associated
        /// with the request. </para>
        /// </summary>
        /// 
        /// <param name="cancelSpotInstanceRequestsRequest">Container for the necessary parameters to execute the CancelSpotInstanceRequests service
        /// method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the CancelSpotInstanceRequests service method, as returned by AmazonEC2.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<CancelSpotInstanceRequestsResponse> CancelSpotInstanceRequestsAsync(CancelSpotInstanceRequestsRequest cancelSpotInstanceRequestsRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CancelSpotInstanceRequestsRequestMarshaller();
            var unmarshaller = CancelSpotInstanceRequestsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CancelSpotInstanceRequestsRequest, CancelSpotInstanceRequestsResponse>(cancelSpotInstanceRequestsRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal ConfirmProductInstanceResponse ConfirmProductInstance(ConfirmProductInstanceRequest request)
        {
            var task = ConfirmProductInstanceAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Determines whether a product code is associated with an instance. This action can only be used by the owner of the product code. It is
        /// useful when a product code owner needs to verify whether another user's instance is eligible for support.</para>
        /// </summary>
        /// 
        /// <param name="confirmProductInstanceRequest">Container for the necessary parameters to execute the ConfirmProductInstance service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the ConfirmProductInstance service method, as returned by AmazonEC2.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<ConfirmProductInstanceResponse> ConfirmProductInstanceAsync(ConfirmProductInstanceRequest confirmProductInstanceRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ConfirmProductInstanceRequestMarshaller();
            var unmarshaller = ConfirmProductInstanceResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, ConfirmProductInstanceRequest, ConfirmProductInstanceResponse>(confirmProductInstanceRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal CopyImageResponse CopyImage(CopyImageRequest request)
        {
            var task = CopyImageAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Initiates the copy of an AMI from the specified source region to the region in which the request was made.</para> <para>For more
        /// information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/CopyingAMIs.html">Copying AMIs</a> in the <i>Amazon Elastic
        /// Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="copyImageRequest">Container for the necessary parameters to execute the CopyImage service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the CopyImage service method, as returned by AmazonEC2.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<CopyImageResponse> CopyImageAsync(CopyImageRequest copyImageRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CopyImageRequestMarshaller();
            var unmarshaller = CopyImageResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CopyImageRequest, CopyImageResponse>(copyImageRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal CopySnapshotResponse CopySnapshot(CopySnapshotRequest request)
        {
            var task = CopySnapshotAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Copies a point-in-time snapshot of an Amazon EBS volume and stores it in Amazon S3. You can copy the snapshot within the same region
        /// or from one region to another. You can use the snapshot to create Amazon EBS volumes or Amazon Machine Images (AMIs).</para> <para>For more
        /// information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-copy-snapshot.html">Copying an Amazon EBS Snapshot</a> in
        /// the <i>Amazon Elastic Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="copySnapshotRequest">Container for the necessary parameters to execute the CopySnapshot service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the CopySnapshot service method, as returned by AmazonEC2.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<CopySnapshotResponse> CopySnapshotAsync(CopySnapshotRequest copySnapshotRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CopySnapshotRequestMarshaller();
            var unmarshaller = CopySnapshotResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CopySnapshotRequest, CopySnapshotResponse>(copySnapshotRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal CreateCustomerGatewayResponse CreateCustomerGateway(CreateCustomerGatewayRequest request)
        {
            var task = CreateCustomerGatewayAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Provides information to AWS about your VPN customer gateway device. The customer gateway is the appliance at your end of the VPN
        /// connection. (The device on the AWS side of the VPN connection is the virtual private gateway.) You must provide the Internet-routable IP
        /// address of the customer gateway's external interface. The IP address must be static and can't be behind a device performing network address
        /// translation (NAT).</para> <para>For devices that use Border Gateway Protocol (BGP), you can also provide the device's BGP Autonomous System
        /// Number (ASN). You can use an existing ASN assigned to your network. If you don't have an ASN already, you can use a private ASN (in the
        /// 64512 - 65534 range).</para> <para><b>NOTE:</b> Amazon EC2 supports all 2-byte ASN numbers in the range of 1 - 65534, with the exception of
        /// 7224, which is reserved in the us-east-1 region, and 9059, which is reserved in the eu-west-1 region. </para> <para>For more information
        /// about VPN customer gateways, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_VPN.html">Adding a Hardware Virtual
        /// Private Gateway to Your VPC</a> in the <i>Amazon Virtual Private Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="createCustomerGatewayRequest">Container for the necessary parameters to execute the CreateCustomerGateway service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the CreateCustomerGateway service method, as returned by AmazonEC2.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<CreateCustomerGatewayResponse> CreateCustomerGatewayAsync(CreateCustomerGatewayRequest createCustomerGatewayRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateCustomerGatewayRequestMarshaller();
            var unmarshaller = CreateCustomerGatewayResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CreateCustomerGatewayRequest, CreateCustomerGatewayResponse>(createCustomerGatewayRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal CreateDhcpOptionsResponse CreateDhcpOptions(CreateDhcpOptionsRequest request)
        {
            var task = CreateDhcpOptionsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Creates a set of DHCP options for your VPC. After creating the set, you must associate it with the VPC, causing all existing and new
        /// instances that you launch in the VPC to use this set of DHCP options. The following are the individual DHCP options you can specify. For
        /// more information about the options, see <a href="http://www.ietf.org/rfc/rfc2132.txt">RFC 2132</a> .</para> <para>For more information
        /// about DHCP options, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_DHCP_Options.html">DHCP Options Sets</a> in the
        /// <i>Amazon Virtual Private Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="createDhcpOptionsRequest">Container for the necessary parameters to execute the CreateDhcpOptions service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the CreateDhcpOptions service method, as returned by AmazonEC2.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<CreateDhcpOptionsResponse> CreateDhcpOptionsAsync(CreateDhcpOptionsRequest createDhcpOptionsRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateDhcpOptionsRequestMarshaller();
            var unmarshaller = CreateDhcpOptionsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CreateDhcpOptionsRequest, CreateDhcpOptionsResponse>(createDhcpOptionsRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal CreateImageResponse CreateImage(CreateImageRequest request)
        {
            var task = CreateImageAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Creates an Amazon EBS-backed AMI from an Amazon EBS-backed instance that is either running or stopped.</para> <para>If you customized
        /// your instance with instance store volumes or EBS volumes in addition to the root device volume, the new AMI contains block device mapping
        /// information for those volumes. When you launch an instance from this new AMI, the instance automatically launches with those additional
        /// volumes.</para> <para>For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/creating-an-ami-ebs.html">Creating Amazon EBS-Backed Linux AMIs</a> in the <i>Amazon Elastic Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="createImageRequest">Container for the necessary parameters to execute the CreateImage service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the CreateImage service method, as returned by AmazonEC2.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<CreateImageResponse> CreateImageAsync(CreateImageRequest createImageRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateImageRequestMarshaller();
            var unmarshaller = CreateImageResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CreateImageRequest, CreateImageResponse>(createImageRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal CreateInstanceExportTaskResponse CreateInstanceExportTask(CreateInstanceExportTaskRequest request)
        {
            var task = CreateInstanceExportTaskAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Exports a running or stopped instance to an Amazon S3 bucket.</para> <para>For information about the supported operating systems,
        /// image formats, and known limitations for the types of instances you can export, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ExportingEC2Instances.html">Exporting EC2 Instances</a> in the <i>Amazon Elastic
        /// Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="createInstanceExportTaskRequest">Container for the necessary parameters to execute the CreateInstanceExportTask service method
        /// on AmazonEC2.</param>
        /// 
        /// <returns>The response from the CreateInstanceExportTask service method, as returned by AmazonEC2.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<CreateInstanceExportTaskResponse> CreateInstanceExportTaskAsync(CreateInstanceExportTaskRequest createInstanceExportTaskRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateInstanceExportTaskRequestMarshaller();
            var unmarshaller = CreateInstanceExportTaskResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CreateInstanceExportTaskRequest, CreateInstanceExportTaskResponse>(createInstanceExportTaskRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal CreateInternetGatewayResponse CreateInternetGateway(CreateInternetGatewayRequest request)
        {
            var task = CreateInternetGatewayAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Creates an Internet gateway for use with a VPC. After creating the Internet gateway, you attach it to a VPC using
        /// AttachInternetGateway.</para> <para>For more information about your VPC and Internet gateway, see the <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/">Amazon Virtual Private Cloud User Guide</a> .</para>
        /// </summary>
        /// 
        /// <param name="createInternetGatewayRequest">Container for the necessary parameters to execute the CreateInternetGateway service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the CreateInternetGateway service method, as returned by AmazonEC2.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<CreateInternetGatewayResponse> CreateInternetGatewayAsync(CreateInternetGatewayRequest createInternetGatewayRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateInternetGatewayRequestMarshaller();
            var unmarshaller = CreateInternetGatewayResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CreateInternetGatewayRequest, CreateInternetGatewayResponse>(createInternetGatewayRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal CreateKeyPairResponse CreateKeyPair(CreateKeyPairRequest request)
        {
            var task = CreateKeyPairAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Creates a 2048-bit RSA key pair with the specified name. Amazon EC2 stores the public key and displays the private key for you to save
        /// to a file. The private key is returned as an unencrypted PEM encoded PKCS#8 private key. If a key with the specified name already exists,
        /// Amazon EC2 returns an error.</para> <para>You can have up to five thousand key pairs per region.</para> <para>For more information about key
        /// pairs, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-key-pairs.html">Key Pairs</a> in the <i>Amazon Elastic Compute
        /// Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="createKeyPairRequest">Container for the necessary parameters to execute the CreateKeyPair service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the CreateKeyPair service method, as returned by AmazonEC2.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<CreateKeyPairResponse> CreateKeyPairAsync(CreateKeyPairRequest createKeyPairRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateKeyPairRequestMarshaller();
            var unmarshaller = CreateKeyPairResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CreateKeyPairRequest, CreateKeyPairResponse>(createKeyPairRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal CreateNetworkAclResponse CreateNetworkAcl(CreateNetworkAclRequest request)
        {
            var task = CreateNetworkAclAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Creates a network ACL in a VPC. Network ACLs provide an optional layer of security (in addition to security groups) for the instances
        /// in your VPC.</para> <para>For more information about network ACLs, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_ACLs.html">Network ACLs</a> in the <i>Amazon Virtual Private Cloud User
        /// Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="createNetworkAclRequest">Container for the necessary parameters to execute the CreateNetworkAcl service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the CreateNetworkAcl service method, as returned by AmazonEC2.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<CreateNetworkAclResponse> CreateNetworkAclAsync(CreateNetworkAclRequest createNetworkAclRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateNetworkAclRequestMarshaller();
            var unmarshaller = CreateNetworkAclResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CreateNetworkAclRequest, CreateNetworkAclResponse>(createNetworkAclRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal CreateNetworkAclEntryResponse CreateNetworkAclEntry(CreateNetworkAclEntryRequest request)
        {
            var task = CreateNetworkAclEntryAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Creates an entry (a rule) in a network ACL with the specified rule number. Each network ACL has a set of numbered ingress rules and a
        /// separate set of numbered egress rules. When determining whether a packet should be allowed in or out of a subnet associated with the ACL, we
        /// process the entries in the ACL according to the rule numbers, in ascending order. Each network ACL has a set of ingress rules and a separate
        /// set of egress rules.</para> <para>We recommend that you leave room between the rule numbers (for example, 100, 110, 120, ...), and not
        /// number them one right after the other (for example, 101, 102, 103, ...). This makes it easier to add a rule between existing ones without
        /// having to renumber the rules.</para> <para>After you add an entry, you can't modify it; you must either replace it, or create an entry and
        /// delete the old one.</para> <para>For more information about network ACLs, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_ACLs.html">Network ACLs</a> in the <i>Amazon Virtual Private Cloud User
        /// Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="createNetworkAclEntryRequest">Container for the necessary parameters to execute the CreateNetworkAclEntry service method on
        /// AmazonEC2.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<CreateNetworkAclEntryResponse> CreateNetworkAclEntryAsync(CreateNetworkAclEntryRequest createNetworkAclEntryRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateNetworkAclEntryRequestMarshaller();
            var unmarshaller = CreateNetworkAclEntryResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CreateNetworkAclEntryRequest, CreateNetworkAclEntryResponse>(createNetworkAclEntryRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal CreateNetworkInterfaceResponse CreateNetworkInterface(CreateNetworkInterfaceRequest request)
        {
            var task = CreateNetworkInterfaceAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Creates a network interface in the specified subnet.</para> <para>For more information about network interfaces, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-eni.html">Elastic Network Interfaces</a> in the <i>Amazon Elastic Compute
        /// Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="createNetworkInterfaceRequest">Container for the necessary parameters to execute the CreateNetworkInterface service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the CreateNetworkInterface service method, as returned by AmazonEC2.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<CreateNetworkInterfaceResponse> CreateNetworkInterfaceAsync(CreateNetworkInterfaceRequest createNetworkInterfaceRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateNetworkInterfaceRequestMarshaller();
            var unmarshaller = CreateNetworkInterfaceResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CreateNetworkInterfaceRequest, CreateNetworkInterfaceResponse>(createNetworkInterfaceRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal CreatePlacementGroupResponse CreatePlacementGroup(CreatePlacementGroupRequest request)
        {
            var task = CreatePlacementGroupAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Creates a placement group that you launch cluster instances into. You must give the group a name that's unique within the scope of
        /// your account.</para> <para>For more information about placement groups and cluster instances, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using_cluster_computing.html">Cluster Instances</a> in the <i>Amazon Elastic
        /// Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="createPlacementGroupRequest">Container for the necessary parameters to execute the CreatePlacementGroup service method on
        /// AmazonEC2.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<CreatePlacementGroupResponse> CreatePlacementGroupAsync(CreatePlacementGroupRequest createPlacementGroupRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreatePlacementGroupRequestMarshaller();
            var unmarshaller = CreatePlacementGroupResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CreatePlacementGroupRequest, CreatePlacementGroupResponse>(createPlacementGroupRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal CreateReservedInstancesListingResponse CreateReservedInstancesListing(CreateReservedInstancesListingRequest request)
        {
            var task = CreateReservedInstancesListingAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Creates a listing for Amazon EC2 Reserved Instances to be sold in the Reserved Instance Marketplace. You can submit one Reserved
        /// Instance listing at a time.</para> <para>For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ri-market-general.html">Reserved Instance Marketplace</a> in the <i>Amazon Elastic
        /// Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="createReservedInstancesListingRequest">Container for the necessary parameters to execute the CreateReservedInstancesListing
        /// service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the CreateReservedInstancesListing service method, as returned by AmazonEC2.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<CreateReservedInstancesListingResponse> CreateReservedInstancesListingAsync(CreateReservedInstancesListingRequest createReservedInstancesListingRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateReservedInstancesListingRequestMarshaller();
            var unmarshaller = CreateReservedInstancesListingResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CreateReservedInstancesListingRequest, CreateReservedInstancesListingResponse>(createReservedInstancesListingRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal CreateRouteResponse CreateRoute(CreateRouteRequest request)
        {
            var task = CreateRouteAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

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
        /// about route tables, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Route_Tables.html">Route Tables</a> in the
        /// <i>Amazon Virtual Private Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="createRouteRequest">Container for the necessary parameters to execute the CreateRoute service method on AmazonEC2.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<CreateRouteResponse> CreateRouteAsync(CreateRouteRequest createRouteRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateRouteRequestMarshaller();
            var unmarshaller = CreateRouteResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CreateRouteRequest, CreateRouteResponse>(createRouteRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal CreateRouteTableResponse CreateRouteTable(CreateRouteTableRequest request)
        {
            var task = CreateRouteTableAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Creates a route table for the specified VPC. After you create a route table, you can add routes and associate the table with a
        /// subnet.</para> <para>For more information about route tables, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Route_Tables.html">Route Tables</a> in the <i>Amazon Virtual Private Cloud
        /// User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="createRouteTableRequest">Container for the necessary parameters to execute the CreateRouteTable service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the CreateRouteTable service method, as returned by AmazonEC2.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<CreateRouteTableResponse> CreateRouteTableAsync(CreateRouteTableRequest createRouteTableRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateRouteTableRequestMarshaller();
            var unmarshaller = CreateRouteTableResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CreateRouteTableRequest, CreateRouteTableResponse>(createRouteTableRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal CreateSecurityGroupResponse CreateSecurityGroup(CreateSecurityGroupRequest request)
        {
            var task = CreateSecurityGroupAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Creates a security group.</para> <para>A security group is for use with instances either in the EC2-Classic platform or in a specific
        /// VPC. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-network-security.html">Amazon EC2 Security
        /// Groups</a> in the <i>Amazon Elastic Compute Cloud User Guide</i> and <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_SecurityGroups.html">Security Groups for Your VPC</a> in the <i>Amazon
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
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the CreateSecurityGroup service method, as returned by AmazonEC2.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<CreateSecurityGroupResponse> CreateSecurityGroupAsync(CreateSecurityGroupRequest createSecurityGroupRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateSecurityGroupRequestMarshaller();
            var unmarshaller = CreateSecurityGroupResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CreateSecurityGroupRequest, CreateSecurityGroupResponse>(createSecurityGroupRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal CreateSnapshotResponse CreateSnapshot(CreateSnapshotRequest request)
        {
            var task = CreateSnapshotAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Creates a snapshot of an Amazon EBS volume and stores it in Amazon S3. You can use snapshots for backups, to make copies of Amazon EBS
        /// volumes, and to save data before shutting down an instance.</para> <para>When a snapshot is created, any AWS Marketplace product codes that
        /// are associated with the source volume are propagated to the snapshot.</para> <para>You can take a snapshot of an attached volume that is in
        /// use. However, snapshots only capture data that has been written to your Amazon EBS volume at the time the snapshot command is issued; this
        /// may exclude any data that has been cached by any applications or the operating system. If you can pause any file writes to the volume long
        /// enough to take a snapshot, your snapshot should be complete. However, if you cannot pause all file writes to the volume, you should unmount
        /// the volume from within the instance, issue the snapshot command, and then remount the volume to ensure a consistent and complete snapshot.
        /// You may remount and use your volume while the snapshot status is <c>pending</c> .</para> <para>To create a snapshot for Amazon EBS volumes
        /// that serve as root devices, you should stop the instance before taking the snapshot.</para> <para>For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-creating-snapshot.html">Creating an Amazon EBS Snapshot</a> in the <i>Amazon
        /// Elastic Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="createSnapshotRequest">Container for the necessary parameters to execute the CreateSnapshot service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the CreateSnapshot service method, as returned by AmazonEC2.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<CreateSnapshotResponse> CreateSnapshotAsync(CreateSnapshotRequest createSnapshotRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateSnapshotRequestMarshaller();
            var unmarshaller = CreateSnapshotResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CreateSnapshotRequest, CreateSnapshotResponse>(createSnapshotRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal CreateSpotDatafeedSubscriptionResponse CreateSpotDatafeedSubscription(CreateSpotDatafeedSubscriptionRequest request)
        {
            var task = CreateSpotDatafeedSubscriptionAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Creates a datafeed for Spot Instances, enabling you to view Spot Instance usage logs. You can create one data feed per AWS account.
        /// For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-spot-instances.html">Spot Instances</a> in the
        /// <i>Amazon Elastic Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="createSpotDatafeedSubscriptionRequest">Container for the necessary parameters to execute the CreateSpotDatafeedSubscription
        /// service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the CreateSpotDatafeedSubscription service method, as returned by AmazonEC2.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<CreateSpotDatafeedSubscriptionResponse> CreateSpotDatafeedSubscriptionAsync(CreateSpotDatafeedSubscriptionRequest createSpotDatafeedSubscriptionRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateSpotDatafeedSubscriptionRequestMarshaller();
            var unmarshaller = CreateSpotDatafeedSubscriptionResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CreateSpotDatafeedSubscriptionRequest, CreateSpotDatafeedSubscriptionResponse>(createSpotDatafeedSubscriptionRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal CreateSubnetResponse CreateSubnet(CreateSubnetRequest request)
        {
            var task = CreateSubnetAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Creates a subnet in an existing VPC.</para> <para>When you create each subnet, you provide the VPC ID and the CIDR block you want for
        /// the subnet. After you create a subnet, you can't change its CIDR block. The subnet's CIDR block can be the same as the VPC's CIDR block
        /// (assuming you want only a single subnet in the VPC), or a subset of the VPC's CIDR block. If you create more than one subnet in a VPC, the
        /// subnets' CIDR blocks must not overlap. The smallest subnet (and VPC) you can create uses a /28 netmask (16 IP addresses), and the largest
        /// uses a /16 netmask (65,536 IP addresses).</para> <para><b>IMPORTANT:</b> AWS reserves both the first four and the last IP address in each
        /// subnet's CIDR block. They're not available for use. </para> <para>If you add more than one subnet to a VPC, they're set up in a star
        /// topology with a logical router in the middle.</para> <para>For more information about subnets, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Subnets.html">Your VPC and Subnets</a> in the <i>Amazon Virtual Private
        /// Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="createSubnetRequest">Container for the necessary parameters to execute the CreateSubnet service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the CreateSubnet service method, as returned by AmazonEC2.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<CreateSubnetResponse> CreateSubnetAsync(CreateSubnetRequest createSubnetRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateSubnetRequestMarshaller();
            var unmarshaller = CreateSubnetResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CreateSubnetRequest, CreateSubnetResponse>(createSubnetRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal CreateTagsResponse CreateTags(CreateTagsRequest request)
        {
            var task = CreateTagsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Adds or overwrites one or more tags for the specified EC2 resource or resources. Each resource can have a maximum of 10 tags. Each tag
        /// consists of a key and optional value. Tag keys must be unique per resource.</para> <para>For more information about tags, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_Tags.html">Tagging Your Resources</a> in the <i>Amazon Elastic Compute Cloud
        /// User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="createTagsRequest">Container for the necessary parameters to execute the CreateTags service method on AmazonEC2.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<CreateTagsResponse> CreateTagsAsync(CreateTagsRequest createTagsRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateTagsRequestMarshaller();
            var unmarshaller = CreateTagsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CreateTagsRequest, CreateTagsResponse>(createTagsRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal CreateVolumeResponse CreateVolume(CreateVolumeRequest request)
        {
            var task = CreateVolumeAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Creates an Amazon EBS volume that can be attached to any instance in the same Availability Zone.</para> <para>Any AWS Marketplace
        /// product codes from the snapshot are propagated to the volume.</para> <para>For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-creating-volume.html">Creating or Restoring an Amazon EBS Volume</a> in the
        /// <i>Amazon Elastic Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="createVolumeRequest">Container for the necessary parameters to execute the CreateVolume service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the CreateVolume service method, as returned by AmazonEC2.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<CreateVolumeResponse> CreateVolumeAsync(CreateVolumeRequest createVolumeRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateVolumeRequestMarshaller();
            var unmarshaller = CreateVolumeResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CreateVolumeRequest, CreateVolumeResponse>(createVolumeRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal CreateVpcResponse CreateVpc(CreateVpcRequest request)
        {
            var task = CreateVpcAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Creates a VPC with the specified CIDR block.</para> <para>The smallest VPC you can create uses a /28 netmask (16 IP addresses), and
        /// the largest uses a /16 netmask (65,536 IP addresses). To help you decide how big to make your VPC, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Subnets.html">Your VPC and Subnets</a> in the <i>Amazon Virtual Private
        /// Cloud User Guide</i> .</para> <para>By default, each instance you launch in the VPC has the default DHCP options, which includes only a
        /// default DNS server that we provide (AmazonProvidedDNS). For more information about DHCP options, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_DHCP_Options.html">DHCP Options Sets</a> in the <i>Amazon Virtual Private
        /// Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="createVpcRequest">Container for the necessary parameters to execute the CreateVpc service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the CreateVpc service method, as returned by AmazonEC2.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<CreateVpcResponse> CreateVpcAsync(CreateVpcRequest createVpcRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateVpcRequestMarshaller();
            var unmarshaller = CreateVpcResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CreateVpcRequest, CreateVpcResponse>(createVpcRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal CreateVpnConnectionResponse CreateVpnConnection(CreateVpnConnectionRequest request)
        {
            var task = CreateVpnConnectionAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Creates a VPN connection between an existing virtual private gateway and a VPN customer gateway. The only supported connection type is
        /// <c>ipsec.1</c> .</para> <para>The response includes information that you need to give to your network administrator to configure your
        /// customer gateway.</para> <para><b>IMPORTANT:</b> We strongly recommend that you use HTTPS when calling this operation because the response
        /// contains sensitive cryptographic information for configuring your customer gateway. </para> <para>If you decide to shut down your VPN
        /// connection for any reason and later create a new VPN connection, you must reconfigure your customer gateway with the new information
        /// returned from this call.</para> <para>For more information about VPN connections, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_VPN.html">Adding a Hardware Virtual Private Gateway to Your VPC</a> in the
        /// <i>Amazon Virtual Private Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="createVpnConnectionRequest">Container for the necessary parameters to execute the CreateVpnConnection service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the CreateVpnConnection service method, as returned by AmazonEC2.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<CreateVpnConnectionResponse> CreateVpnConnectionAsync(CreateVpnConnectionRequest createVpnConnectionRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateVpnConnectionRequestMarshaller();
            var unmarshaller = CreateVpnConnectionResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CreateVpnConnectionRequest, CreateVpnConnectionResponse>(createVpnConnectionRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal CreateVpnConnectionRouteResponse CreateVpnConnectionRoute(CreateVpnConnectionRouteRequest request)
        {
            var task = CreateVpnConnectionRouteAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Creates a static route associated with a VPN connection between an existing virtual private gateway and a VPN customer gateway. The
        /// static route allows traffic to be routed from the virtual private gateway to the VPN customer gateway.</para> <para>For more information
        /// about VPN connections, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_VPN.html">Adding a Hardware Virtual Private
        /// Gateway to Your VPC</a> in the <i>Amazon Virtual Private Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="createVpnConnectionRouteRequest">Container for the necessary parameters to execute the CreateVpnConnectionRoute service method
        /// on AmazonEC2.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<CreateVpnConnectionRouteResponse> CreateVpnConnectionRouteAsync(CreateVpnConnectionRouteRequest createVpnConnectionRouteRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateVpnConnectionRouteRequestMarshaller();
            var unmarshaller = CreateVpnConnectionRouteResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CreateVpnConnectionRouteRequest, CreateVpnConnectionRouteResponse>(createVpnConnectionRouteRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal CreateVpnGatewayResponse CreateVpnGateway(CreateVpnGatewayRequest request)
        {
            var task = CreateVpnGatewayAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Creates a virtual private gateway. A virtual private gateway is the endpoint on the VPC side of your VPN connection. You can create a
        /// virtual private gateway before creating the VPC itself.</para> <para>For more information about virtual private gateways, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_VPN.html">Adding a Hardware Virtual Private Gateway to Your VPC</a> in the
        /// <i>Amazon Virtual Private Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="createVpnGatewayRequest">Container for the necessary parameters to execute the CreateVpnGateway service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the CreateVpnGateway service method, as returned by AmazonEC2.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<CreateVpnGatewayResponse> CreateVpnGatewayAsync(CreateVpnGatewayRequest createVpnGatewayRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateVpnGatewayRequestMarshaller();
            var unmarshaller = CreateVpnGatewayResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CreateVpnGatewayRequest, CreateVpnGatewayResponse>(createVpnGatewayRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DeleteCustomerGatewayResponse DeleteCustomerGateway(DeleteCustomerGatewayRequest request)
        {
            var task = DeleteCustomerGatewayAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Deletes the specified customer gateway. You must delete the VPN connection before you can delete the customer gateway.</para>
        /// </summary>
        /// 
        /// <param name="deleteCustomerGatewayRequest">Container for the necessary parameters to execute the DeleteCustomerGateway service method on
        /// AmazonEC2.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DeleteCustomerGatewayResponse> DeleteCustomerGatewayAsync(DeleteCustomerGatewayRequest deleteCustomerGatewayRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteCustomerGatewayRequestMarshaller();
            var unmarshaller = DeleteCustomerGatewayResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DeleteCustomerGatewayRequest, DeleteCustomerGatewayResponse>(deleteCustomerGatewayRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DeleteDhcpOptionsResponse DeleteDhcpOptions(DeleteDhcpOptionsRequest request)
        {
            var task = DeleteDhcpOptionsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Deletes the specified set of DHCP options. You must disassociate the set of DHCP options before you can delete it. You can
        /// disassociate the set of DHCP options by associating either a new set of options or the default set of options with the VPC.</para>
        /// </summary>
        /// 
        /// <param name="deleteDhcpOptionsRequest">Container for the necessary parameters to execute the DeleteDhcpOptions service method on
        /// AmazonEC2.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DeleteDhcpOptionsResponse> DeleteDhcpOptionsAsync(DeleteDhcpOptionsRequest deleteDhcpOptionsRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteDhcpOptionsRequestMarshaller();
            var unmarshaller = DeleteDhcpOptionsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DeleteDhcpOptionsRequest, DeleteDhcpOptionsResponse>(deleteDhcpOptionsRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DeleteInternetGatewayResponse DeleteInternetGateway(DeleteInternetGatewayRequest request)
        {
            var task = DeleteInternetGatewayAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Deletes the specified Internet gateway. You must detach the Internet gateway from the VPC before you can delete it.</para>
        /// </summary>
        /// 
        /// <param name="deleteInternetGatewayRequest">Container for the necessary parameters to execute the DeleteInternetGateway service method on
        /// AmazonEC2.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DeleteInternetGatewayResponse> DeleteInternetGatewayAsync(DeleteInternetGatewayRequest deleteInternetGatewayRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteInternetGatewayRequestMarshaller();
            var unmarshaller = DeleteInternetGatewayResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DeleteInternetGatewayRequest, DeleteInternetGatewayResponse>(deleteInternetGatewayRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DeleteKeyPairResponse DeleteKeyPair(DeleteKeyPairRequest request)
        {
            var task = DeleteKeyPairAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Deletes the specified key pair, by removing the public key from Amazon EC2.</para>
        /// </summary>
        /// 
        /// <param name="deleteKeyPairRequest">Container for the necessary parameters to execute the DeleteKeyPair service method on AmazonEC2.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DeleteKeyPairResponse> DeleteKeyPairAsync(DeleteKeyPairRequest deleteKeyPairRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteKeyPairRequestMarshaller();
            var unmarshaller = DeleteKeyPairResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DeleteKeyPairRequest, DeleteKeyPairResponse>(deleteKeyPairRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DeleteNetworkAclResponse DeleteNetworkAcl(DeleteNetworkAclRequest request)
        {
            var task = DeleteNetworkAclAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Deletes the specified network ACL. You can't delete the ACL if it's associated with any subnets. You can't delete the default network
        /// ACL.</para>
        /// </summary>
        /// 
        /// <param name="deleteNetworkAclRequest">Container for the necessary parameters to execute the DeleteNetworkAcl service method on
        /// AmazonEC2.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DeleteNetworkAclResponse> DeleteNetworkAclAsync(DeleteNetworkAclRequest deleteNetworkAclRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteNetworkAclRequestMarshaller();
            var unmarshaller = DeleteNetworkAclResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DeleteNetworkAclRequest, DeleteNetworkAclResponse>(deleteNetworkAclRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DeleteNetworkAclEntryResponse DeleteNetworkAclEntry(DeleteNetworkAclEntryRequest request)
        {
            var task = DeleteNetworkAclEntryAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Deletes the specified ingress or egress entry (rule) from the specified network ACL.</para>
        /// </summary>
        /// 
        /// <param name="deleteNetworkAclEntryRequest">Container for the necessary parameters to execute the DeleteNetworkAclEntry service method on
        /// AmazonEC2.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DeleteNetworkAclEntryResponse> DeleteNetworkAclEntryAsync(DeleteNetworkAclEntryRequest deleteNetworkAclEntryRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteNetworkAclEntryRequestMarshaller();
            var unmarshaller = DeleteNetworkAclEntryResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DeleteNetworkAclEntryRequest, DeleteNetworkAclEntryResponse>(deleteNetworkAclEntryRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DeleteNetworkInterfaceResponse DeleteNetworkInterface(DeleteNetworkInterfaceRequest request)
        {
            var task = DeleteNetworkInterfaceAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Deletes the specified network interface. You must detach the network interface before you can delete it.</para>
        /// </summary>
        /// 
        /// <param name="deleteNetworkInterfaceRequest">Container for the necessary parameters to execute the DeleteNetworkInterface service method on
        /// AmazonEC2.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DeleteNetworkInterfaceResponse> DeleteNetworkInterfaceAsync(DeleteNetworkInterfaceRequest deleteNetworkInterfaceRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteNetworkInterfaceRequestMarshaller();
            var unmarshaller = DeleteNetworkInterfaceResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DeleteNetworkInterfaceRequest, DeleteNetworkInterfaceResponse>(deleteNetworkInterfaceRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DeletePlacementGroupResponse DeletePlacementGroup(DeletePlacementGroupRequest request)
        {
            var task = DeletePlacementGroupAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Deletes the specified placement group. You must terminate all instances in the placement group before you can delete the placement
        /// group. For more information about placement groups and cluster instances, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using_cluster_computing.html">Cluster Instances</a> in the <i>Amazon Elastic
        /// Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="deletePlacementGroupRequest">Container for the necessary parameters to execute the DeletePlacementGroup service method on
        /// AmazonEC2.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DeletePlacementGroupResponse> DeletePlacementGroupAsync(DeletePlacementGroupRequest deletePlacementGroupRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeletePlacementGroupRequestMarshaller();
            var unmarshaller = DeletePlacementGroupResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DeletePlacementGroupRequest, DeletePlacementGroupResponse>(deletePlacementGroupRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DeleteRouteResponse DeleteRoute(DeleteRouteRequest request)
        {
            var task = DeleteRouteAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Deletes the specified route from the specified route table.</para>
        /// </summary>
        /// 
        /// <param name="deleteRouteRequest">Container for the necessary parameters to execute the DeleteRoute service method on AmazonEC2.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DeleteRouteResponse> DeleteRouteAsync(DeleteRouteRequest deleteRouteRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteRouteRequestMarshaller();
            var unmarshaller = DeleteRouteResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DeleteRouteRequest, DeleteRouteResponse>(deleteRouteRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DeleteRouteTableResponse DeleteRouteTable(DeleteRouteTableRequest request)
        {
            var task = DeleteRouteTableAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Deletes the specified route table. You must disassociate the route table from any subnets before you can delete it. You can't delete
        /// the main route table.</para>
        /// </summary>
        /// 
        /// <param name="deleteRouteTableRequest">Container for the necessary parameters to execute the DeleteRouteTable service method on
        /// AmazonEC2.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DeleteRouteTableResponse> DeleteRouteTableAsync(DeleteRouteTableRequest deleteRouteTableRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteRouteTableRequestMarshaller();
            var unmarshaller = DeleteRouteTableResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DeleteRouteTableRequest, DeleteRouteTableResponse>(deleteRouteTableRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DeleteSecurityGroupResponse DeleteSecurityGroup(DeleteSecurityGroupRequest request)
        {
            var task = DeleteSecurityGroupAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Deletes a security group.</para> <para>If you attempt to delete a security group that is associated with an instance, or is referenced
        /// by another security group, the operation fails with <c>InvalidGroup.InUse</c> in EC2-Classic or <c>DependencyViolation</c> in
        /// EC2-VPC.</para>
        /// </summary>
        /// 
        /// <param name="deleteSecurityGroupRequest">Container for the necessary parameters to execute the DeleteSecurityGroup service method on
        /// AmazonEC2.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DeleteSecurityGroupResponse> DeleteSecurityGroupAsync(DeleteSecurityGroupRequest deleteSecurityGroupRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteSecurityGroupRequestMarshaller();
            var unmarshaller = DeleteSecurityGroupResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DeleteSecurityGroupRequest, DeleteSecurityGroupResponse>(deleteSecurityGroupRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DeleteSnapshotResponse DeleteSnapshot(DeleteSnapshotRequest request)
        {
            var task = DeleteSnapshotAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Deletes the specified snapshot.</para> <para>When you make periodic snapshots of a volume, the snapshots are incremental, and only the
        /// blocks on the device that have changed since your last snapshot are saved in the new snapshot. When you delete a snapshot, only the data not
        /// needed for any other snapshot is removed. So regardless of which prior snapshots have been deleted, all active snapshots will have access to
        /// all the information needed to restore the volume.</para> <para>You cannot delete a snapshot of the root device of an Amazon EBS volume used
        /// by a registered AMI. You must first de-register the AMI before you can delete the snapshot.</para> <para>For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-deleting-snapshot.html">Deleting an Amazon EBS Snapshot</a> in the <i>Amazon
        /// Elastic Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="deleteSnapshotRequest">Container for the necessary parameters to execute the DeleteSnapshot service method on
        /// AmazonEC2.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DeleteSnapshotResponse> DeleteSnapshotAsync(DeleteSnapshotRequest deleteSnapshotRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteSnapshotRequestMarshaller();
            var unmarshaller = DeleteSnapshotResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DeleteSnapshotRequest, DeleteSnapshotResponse>(deleteSnapshotRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DeleteSpotDatafeedSubscriptionResponse DeleteSpotDatafeedSubscription(DeleteSpotDatafeedSubscriptionRequest request)
        {
            var task = DeleteSpotDatafeedSubscriptionAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Deletes the datafeed for Spot Instances. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-spot-instances.html">Spot Instances</a> in the <i>Amazon Elastic Compute
        /// Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="deleteSpotDatafeedSubscriptionRequest">Container for the necessary parameters to execute the DeleteSpotDatafeedSubscription
        /// service method on AmazonEC2.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DeleteSpotDatafeedSubscriptionResponse> DeleteSpotDatafeedSubscriptionAsync(DeleteSpotDatafeedSubscriptionRequest deleteSpotDatafeedSubscriptionRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteSpotDatafeedSubscriptionRequestMarshaller();
            var unmarshaller = DeleteSpotDatafeedSubscriptionResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DeleteSpotDatafeedSubscriptionRequest, DeleteSpotDatafeedSubscriptionResponse>(deleteSpotDatafeedSubscriptionRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DeleteSubnetResponse DeleteSubnet(DeleteSubnetRequest request)
        {
            var task = DeleteSubnetAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Deletes the specified subnet. You must terminate all running instances in the subnet before you can delete the subnet.</para>
        /// </summary>
        /// 
        /// <param name="deleteSubnetRequest">Container for the necessary parameters to execute the DeleteSubnet service method on AmazonEC2.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DeleteSubnetResponse> DeleteSubnetAsync(DeleteSubnetRequest deleteSubnetRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteSubnetRequestMarshaller();
            var unmarshaller = DeleteSubnetResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DeleteSubnetRequest, DeleteSubnetResponse>(deleteSubnetRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DeleteTagsResponse DeleteTags(DeleteTagsRequest request)
        {
            var task = DeleteTagsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Deletes the specified set of tags from the specified set of resources. This call is designed to follow a <c>DescribeTags</c>
        /// request.</para> <para>For more information about tags, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_Tags.html">Tagging Your Resources</a> in the <i>Amazon Elastic Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="deleteTagsRequest">Container for the necessary parameters to execute the DeleteTags service method on AmazonEC2.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DeleteTagsResponse> DeleteTagsAsync(DeleteTagsRequest deleteTagsRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteTagsRequestMarshaller();
            var unmarshaller = DeleteTagsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DeleteTagsRequest, DeleteTagsResponse>(deleteTagsRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DeleteVolumeResponse DeleteVolume(DeleteVolumeRequest request)
        {
            var task = DeleteVolumeAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Deletes the specified Amazon EBS volume. The volume must be in the <c>available</c> state (not attached to an instance).</para>
        /// <para><b>NOTE:</b> The volume remains in the deleting state for several minutes. </para> <para>For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-deleting-volume.html">Deleting an Amazon EBS Volume</a> in the <i>Amazon
        /// Elastic Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="deleteVolumeRequest">Container for the necessary parameters to execute the DeleteVolume service method on AmazonEC2.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DeleteVolumeResponse> DeleteVolumeAsync(DeleteVolumeRequest deleteVolumeRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteVolumeRequestMarshaller();
            var unmarshaller = DeleteVolumeResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DeleteVolumeRequest, DeleteVolumeResponse>(deleteVolumeRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DeleteVpcResponse DeleteVpc(DeleteVpcRequest request)
        {
            var task = DeleteVpcAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Deletes the specified VPC. You must detach or delete all gateways and resources that are associated with the VPC before you can delete
        /// it. For example, you must terminate all instances running in the VPC, delete all security groups associated with the VPC (except the default
        /// one), delete all route tables associated with the VPC (except the default one), and so on.</para>
        /// </summary>
        /// 
        /// <param name="deleteVpcRequest">Container for the necessary parameters to execute the DeleteVpc service method on AmazonEC2.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DeleteVpcResponse> DeleteVpcAsync(DeleteVpcRequest deleteVpcRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteVpcRequestMarshaller();
            var unmarshaller = DeleteVpcResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DeleteVpcRequest, DeleteVpcResponse>(deleteVpcRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DeleteVpnConnectionResponse DeleteVpnConnection(DeleteVpnConnectionRequest request)
        {
            var task = DeleteVpnConnectionAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Deletes the specified VPN connection.</para> <para>If you're deleting the VPC and its associated components, we recommend that you
        /// detach the virtual private gateway from the VPC and delete the VPC before deleting the VPN connection.</para>
        /// </summary>
        /// 
        /// <param name="deleteVpnConnectionRequest">Container for the necessary parameters to execute the DeleteVpnConnection service method on
        /// AmazonEC2.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DeleteVpnConnectionResponse> DeleteVpnConnectionAsync(DeleteVpnConnectionRequest deleteVpnConnectionRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteVpnConnectionRequestMarshaller();
            var unmarshaller = DeleteVpnConnectionResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DeleteVpnConnectionRequest, DeleteVpnConnectionResponse>(deleteVpnConnectionRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DeleteVpnConnectionRouteResponse DeleteVpnConnectionRoute(DeleteVpnConnectionRouteRequest request)
        {
            var task = DeleteVpnConnectionRouteAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Deletes the specified static route associated with a VPN connection between an existing virtual private gateway and a VPN customer
        /// gateway. The static route allows traffic to be routed from the virtual private gateway to the VPN customer gateway.</para>
        /// </summary>
        /// 
        /// <param name="deleteVpnConnectionRouteRequest">Container for the necessary parameters to execute the DeleteVpnConnectionRoute service method
        /// on AmazonEC2.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DeleteVpnConnectionRouteResponse> DeleteVpnConnectionRouteAsync(DeleteVpnConnectionRouteRequest deleteVpnConnectionRouteRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteVpnConnectionRouteRequestMarshaller();
            var unmarshaller = DeleteVpnConnectionRouteResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DeleteVpnConnectionRouteRequest, DeleteVpnConnectionRouteResponse>(deleteVpnConnectionRouteRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DeleteVpnGatewayResponse DeleteVpnGateway(DeleteVpnGatewayRequest request)
        {
            var task = DeleteVpnGatewayAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Deletes the specified virtual private gateway. We recommend that before you delete a virtual private gateway, you detach it from the
        /// VPC and delete the VPN connection. Note that you don't need to delete the virtual private gateway if you plan to delete and recreate the VPN
        /// connection between your VPC and your network.</para>
        /// </summary>
        /// 
        /// <param name="deleteVpnGatewayRequest">Container for the necessary parameters to execute the DeleteVpnGateway service method on
        /// AmazonEC2.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DeleteVpnGatewayResponse> DeleteVpnGatewayAsync(DeleteVpnGatewayRequest deleteVpnGatewayRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteVpnGatewayRequestMarshaller();
            var unmarshaller = DeleteVpnGatewayResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DeleteVpnGatewayRequest, DeleteVpnGatewayResponse>(deleteVpnGatewayRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DeregisterImageResponse DeregisterImage(DeregisterImageRequest request)
        {
            var task = DeregisterImageAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Deregisters the specified AMI. After you deregister an AMI, it can't be used to launch new instances.</para> <para>This command does
        /// not delete the AMI.</para>
        /// </summary>
        /// 
        /// <param name="deregisterImageRequest">Container for the necessary parameters to execute the DeregisterImage service method on
        /// AmazonEC2.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DeregisterImageResponse> DeregisterImageAsync(DeregisterImageRequest deregisterImageRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeregisterImageRequestMarshaller();
            var unmarshaller = DeregisterImageResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DeregisterImageRequest, DeregisterImageResponse>(deregisterImageRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DescribeAccountAttributesResponse DescribeAccountAttributes(DescribeAccountAttributesRequest request)
        {
            var task = DescribeAccountAttributesAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Describes the specified attribute of your AWS account.</para>
        /// </summary>
        /// 
        /// <param name="describeAccountAttributesRequest">Container for the necessary parameters to execute the DescribeAccountAttributes service
        /// method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeAccountAttributes service method, as returned by AmazonEC2.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DescribeAccountAttributesResponse> DescribeAccountAttributesAsync(DescribeAccountAttributesRequest describeAccountAttributesRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeAccountAttributesRequestMarshaller();
            var unmarshaller = DescribeAccountAttributesResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeAccountAttributesRequest, DescribeAccountAttributesResponse>(describeAccountAttributesRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DescribeAddressesResponse DescribeAddresses(DescribeAddressesRequest request)
        {
            var task = DescribeAddressesAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Describes one or more of your Elastic IP addresses.</para> <para>An Elastic IP address is for use in either the EC2-Classic platform
        /// or in a VPC. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/elastic-ip-addresses-eip.html">Elastic
        /// IP Addresses</a> in the <i>Amazon Elastic Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="describeAddressesRequest">Container for the necessary parameters to execute the DescribeAddresses service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeAddresses service method, as returned by AmazonEC2.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DescribeAddressesResponse> DescribeAddressesAsync(DescribeAddressesRequest describeAddressesRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeAddressesRequestMarshaller();
            var unmarshaller = DescribeAddressesResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeAddressesRequest, DescribeAddressesResponse>(describeAddressesRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DescribeAvailabilityZonesResponse DescribeAvailabilityZones(DescribeAvailabilityZonesRequest request)
        {
            var task = DescribeAvailabilityZonesAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Describes one or more of the Availability Zones that are available to you. The results include zones only for the region you're
        /// currently using. If there is an event impacting an Availability Zone, you can use this request to view the state and any provided message
        /// for that Availability Zone.</para> <para>For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-regions-availability-zones.html">Regions and Availability Zones</a> in the
        /// <i>Amazon Elastic Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="describeAvailabilityZonesRequest">Container for the necessary parameters to execute the DescribeAvailabilityZones service
        /// method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeAvailabilityZones service method, as returned by AmazonEC2.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DescribeAvailabilityZonesResponse> DescribeAvailabilityZonesAsync(DescribeAvailabilityZonesRequest describeAvailabilityZonesRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeAvailabilityZonesRequestMarshaller();
            var unmarshaller = DescribeAvailabilityZonesResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeAvailabilityZonesRequest, DescribeAvailabilityZonesResponse>(describeAvailabilityZonesRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DescribeBundleTasksResponse DescribeBundleTasks(DescribeBundleTasksRequest request)
        {
            var task = DescribeBundleTasksAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Describes one or more of your bundling tasks.</para> <para><b>NOTE:</b> Completed bundle tasks are listed for only a limited time. If
        /// your bundle task is no longer in the list, you can still register an AMI from it. Just use RegisterImage with the Amazon S3 bucket name and
        /// image manifest name you provided to the bundle task. </para>
        /// </summary>
        /// 
        /// <param name="describeBundleTasksRequest">Container for the necessary parameters to execute the DescribeBundleTasks service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeBundleTasks service method, as returned by AmazonEC2.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DescribeBundleTasksResponse> DescribeBundleTasksAsync(DescribeBundleTasksRequest describeBundleTasksRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeBundleTasksRequestMarshaller();
            var unmarshaller = DescribeBundleTasksResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeBundleTasksRequest, DescribeBundleTasksResponse>(describeBundleTasksRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DescribeConversionTasksResponse DescribeConversionTasks(DescribeConversionTasksRequest request)
        {
            var task = DescribeConversionTasksAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Describes one or more of your conversion tasks. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/UploadingYourInstancesandVolumes.html">Using the Command Line Tools to Import Your
        /// Virtual Machine to Amazon EC2</a> in the <i>Amazon Elastic Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="describeConversionTasksRequest">Container for the necessary parameters to execute the DescribeConversionTasks service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeConversionTasks service method, as returned by AmazonEC2.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DescribeConversionTasksResponse> DescribeConversionTasksAsync(DescribeConversionTasksRequest describeConversionTasksRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeConversionTasksRequestMarshaller();
            var unmarshaller = DescribeConversionTasksResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeConversionTasksRequest, DescribeConversionTasksResponse>(describeConversionTasksRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DescribeCustomerGatewaysResponse DescribeCustomerGateways(DescribeCustomerGatewaysRequest request)
        {
            var task = DescribeCustomerGatewaysAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Describes one or more of your VPN customer gateways.</para> <para>For more information about VPN customer gateways, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_VPN.html">Adding a Hardware Virtual Private Gateway to Your VPC</a> in the
        /// <i>Amazon Virtual Private Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="describeCustomerGatewaysRequest">Container for the necessary parameters to execute the DescribeCustomerGateways service method
        /// on AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeCustomerGateways service method, as returned by AmazonEC2.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DescribeCustomerGatewaysResponse> DescribeCustomerGatewaysAsync(DescribeCustomerGatewaysRequest describeCustomerGatewaysRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeCustomerGatewaysRequestMarshaller();
            var unmarshaller = DescribeCustomerGatewaysResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeCustomerGatewaysRequest, DescribeCustomerGatewaysResponse>(describeCustomerGatewaysRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DescribeDhcpOptionsResponse DescribeDhcpOptions(DescribeDhcpOptionsRequest request)
        {
            var task = DescribeDhcpOptionsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Describes one or more of your DHCP options sets.</para> <para>For more information about DHCP options sets, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_DHCP_Options.html">DHCP Options Sets</a> in the <i>Amazon Virtual Private
        /// Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="describeDhcpOptionsRequest">Container for the necessary parameters to execute the DescribeDhcpOptions service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeDhcpOptions service method, as returned by AmazonEC2.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DescribeDhcpOptionsResponse> DescribeDhcpOptionsAsync(DescribeDhcpOptionsRequest describeDhcpOptionsRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeDhcpOptionsRequestMarshaller();
            var unmarshaller = DescribeDhcpOptionsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeDhcpOptionsRequest, DescribeDhcpOptionsResponse>(describeDhcpOptionsRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DescribeExportTasksResponse DescribeExportTasks(DescribeExportTasksRequest request)
        {
            var task = DescribeExportTasksAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Describes one or more of your export tasks.</para>
        /// </summary>
        /// 
        /// <param name="describeExportTasksRequest">Container for the necessary parameters to execute the DescribeExportTasks service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeExportTasks service method, as returned by AmazonEC2.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DescribeExportTasksResponse> DescribeExportTasksAsync(DescribeExportTasksRequest describeExportTasksRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeExportTasksRequestMarshaller();
            var unmarshaller = DescribeExportTasksResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeExportTasksRequest, DescribeExportTasksResponse>(describeExportTasksRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DescribeImageAttributeResponse DescribeImageAttribute(DescribeImageAttributeRequest request)
        {
            var task = DescribeImageAttributeAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Describes an attributes of an AMI. You can specify only one attribute at a time.</para>
        /// </summary>
        /// 
        /// <param name="describeImageAttributeRequest">Container for the necessary parameters to execute the DescribeImageAttribute service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeImageAttribute service method, as returned by AmazonEC2.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DescribeImageAttributeResponse> DescribeImageAttributeAsync(DescribeImageAttributeRequest describeImageAttributeRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeImageAttributeRequestMarshaller();
            var unmarshaller = DescribeImageAttributeResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeImageAttributeRequest, DescribeImageAttributeResponse>(describeImageAttributeRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DescribeImagesResponse DescribeImages(DescribeImagesRequest request)
        {
            var task = DescribeImagesAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Describes one or more of the images (AMIs, AKIs, and ARIs) available to you. Images available to you include public images, private
        /// images that you own, and private images owned by other AWS accounts but for which you have explicit launch permissions.</para>
        /// <para><b>NOTE:</b> Deregistered images are included in the returned results for an unspecified interval after deregistration. </para>
        /// </summary>
        /// 
        /// <param name="describeImagesRequest">Container for the necessary parameters to execute the DescribeImages service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeImages service method, as returned by AmazonEC2.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DescribeImagesResponse> DescribeImagesAsync(DescribeImagesRequest describeImagesRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeImagesRequestMarshaller();
            var unmarshaller = DescribeImagesResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeImagesRequest, DescribeImagesResponse>(describeImagesRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DescribeInstanceAttributeResponse DescribeInstanceAttribute(DescribeInstanceAttributeRequest request)
        {
            var task = DescribeInstanceAttributeAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Describes an attribute of the specified instance. You can specify only one attribute at a time.</para>
        /// </summary>
        /// 
        /// <param name="describeInstanceAttributeRequest">Container for the necessary parameters to execute the DescribeInstanceAttribute service
        /// method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeInstanceAttribute service method, as returned by AmazonEC2.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DescribeInstanceAttributeResponse> DescribeInstanceAttributeAsync(DescribeInstanceAttributeRequest describeInstanceAttributeRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeInstanceAttributeRequestMarshaller();
            var unmarshaller = DescribeInstanceAttributeResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeInstanceAttributeRequest, DescribeInstanceAttributeResponse>(describeInstanceAttributeRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DescribeInstancesResponse DescribeInstances(DescribeInstancesRequest request)
        {
            var task = DescribeInstancesAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Describes one or more of your instances.</para> <para>If you specify one or more instance IDs, Amazon EC2 returns information for
        /// those instances. If you do not specify instance IDs, Amazon EC2 returns information for all relevant instances. If you specify an instance
        /// ID that is not valid, an error is returned. If you specify an instance that you do not own, it is not included in the returned
        /// results.</para> <para>Recently terminated instances might appear in the returned results. This interval is usually less than one
        /// hour.</para>
        /// </summary>
        /// 
        /// <param name="describeInstancesRequest">Container for the necessary parameters to execute the DescribeInstances service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeInstances service method, as returned by AmazonEC2.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DescribeInstancesResponse> DescribeInstancesAsync(DescribeInstancesRequest describeInstancesRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeInstancesRequestMarshaller();
            var unmarshaller = DescribeInstancesResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeInstancesRequest, DescribeInstancesResponse>(describeInstancesRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DescribeInstanceStatusResponse DescribeInstanceStatus(DescribeInstanceStatusRequest request)
        {
            var task = DescribeInstanceStatusAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

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
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeInstanceStatus service method, as returned by AmazonEC2.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DescribeInstanceStatusResponse> DescribeInstanceStatusAsync(DescribeInstanceStatusRequest describeInstanceStatusRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeInstanceStatusRequestMarshaller();
            var unmarshaller = DescribeInstanceStatusResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeInstanceStatusRequest, DescribeInstanceStatusResponse>(describeInstanceStatusRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DescribeInternetGatewaysResponse DescribeInternetGateways(DescribeInternetGatewaysRequest request)
        {
            var task = DescribeInternetGatewaysAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Describes one or more of your Internet gateways.</para>
        /// </summary>
        /// 
        /// <param name="describeInternetGatewaysRequest">Container for the necessary parameters to execute the DescribeInternetGateways service method
        /// on AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeInternetGateways service method, as returned by AmazonEC2.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DescribeInternetGatewaysResponse> DescribeInternetGatewaysAsync(DescribeInternetGatewaysRequest describeInternetGatewaysRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeInternetGatewaysRequestMarshaller();
            var unmarshaller = DescribeInternetGatewaysResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeInternetGatewaysRequest, DescribeInternetGatewaysResponse>(describeInternetGatewaysRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DescribeKeyPairsResponse DescribeKeyPairs(DescribeKeyPairsRequest request)
        {
            var task = DescribeKeyPairsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Describes one or more of your key pairs.</para> <para>For more information about key pairs, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-key-pairs.html">Key Pairs</a> in the <i>Amazon Elastic Compute Cloud User
        /// Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="describeKeyPairsRequest">Container for the necessary parameters to execute the DescribeKeyPairs service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeKeyPairs service method, as returned by AmazonEC2.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DescribeKeyPairsResponse> DescribeKeyPairsAsync(DescribeKeyPairsRequest describeKeyPairsRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeKeyPairsRequestMarshaller();
            var unmarshaller = DescribeKeyPairsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeKeyPairsRequest, DescribeKeyPairsResponse>(describeKeyPairsRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DescribeNetworkAclsResponse DescribeNetworkAcls(DescribeNetworkAclsRequest request)
        {
            var task = DescribeNetworkAclsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Describes one or more of your network ACLs.</para> <para>For more information about network ACLs, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_ACLs.html">Network ACLs</a> in the <i>Amazon Virtual Private Cloud User
        /// Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="describeNetworkAclsRequest">Container for the necessary parameters to execute the DescribeNetworkAcls service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeNetworkAcls service method, as returned by AmazonEC2.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DescribeNetworkAclsResponse> DescribeNetworkAclsAsync(DescribeNetworkAclsRequest describeNetworkAclsRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeNetworkAclsRequestMarshaller();
            var unmarshaller = DescribeNetworkAclsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeNetworkAclsRequest, DescribeNetworkAclsResponse>(describeNetworkAclsRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DescribeNetworkInterfaceAttributeResponse DescribeNetworkInterfaceAttribute(DescribeNetworkInterfaceAttributeRequest request)
        {
            var task = DescribeNetworkInterfaceAttributeAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Describes a network interface attribute. You can specify only one attribute at a time.</para>
        /// </summary>
        /// 
        /// <param name="describeNetworkInterfaceAttributeRequest">Container for the necessary parameters to execute the
        /// DescribeNetworkInterfaceAttribute service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeNetworkInterfaceAttribute service method, as returned by AmazonEC2.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DescribeNetworkInterfaceAttributeResponse> DescribeNetworkInterfaceAttributeAsync(DescribeNetworkInterfaceAttributeRequest describeNetworkInterfaceAttributeRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeNetworkInterfaceAttributeRequestMarshaller();
            var unmarshaller = DescribeNetworkInterfaceAttributeResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeNetworkInterfaceAttributeRequest, DescribeNetworkInterfaceAttributeResponse>(describeNetworkInterfaceAttributeRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DescribeNetworkInterfacesResponse DescribeNetworkInterfaces(DescribeNetworkInterfacesRequest request)
        {
            var task = DescribeNetworkInterfacesAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Describes one or more of your network interfaces.</para>
        /// </summary>
        /// 
        /// <param name="describeNetworkInterfacesRequest">Container for the necessary parameters to execute the DescribeNetworkInterfaces service
        /// method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeNetworkInterfaces service method, as returned by AmazonEC2.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DescribeNetworkInterfacesResponse> DescribeNetworkInterfacesAsync(DescribeNetworkInterfacesRequest describeNetworkInterfacesRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeNetworkInterfacesRequestMarshaller();
            var unmarshaller = DescribeNetworkInterfacesResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeNetworkInterfacesRequest, DescribeNetworkInterfacesResponse>(describeNetworkInterfacesRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DescribePlacementGroupsResponse DescribePlacementGroups(DescribePlacementGroupsRequest request)
        {
            var task = DescribePlacementGroupsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Describes one or more of your placement groups. For more information about placement groups and cluster instances, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using_cluster_computing.html">Cluster Instances</a> in the <i>Amazon Elastic
        /// Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="describePlacementGroupsRequest">Container for the necessary parameters to execute the DescribePlacementGroups service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribePlacementGroups service method, as returned by AmazonEC2.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DescribePlacementGroupsResponse> DescribePlacementGroupsAsync(DescribePlacementGroupsRequest describePlacementGroupsRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribePlacementGroupsRequestMarshaller();
            var unmarshaller = DescribePlacementGroupsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribePlacementGroupsRequest, DescribePlacementGroupsResponse>(describePlacementGroupsRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DescribeRegionsResponse DescribeRegions(DescribeRegionsRequest request)
        {
            var task = DescribeRegionsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Describes one or more regions that are currently available to you.</para> <para>For a list of the regions supported by Amazon EC2, see
        /// <a href="http://docs.aws.amazon.com/general/latest/gr/rande.html#ec2_region">Regions and Endpoints</a> .</para>
        /// </summary>
        /// 
        /// <param name="describeRegionsRequest">Container for the necessary parameters to execute the DescribeRegions service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeRegions service method, as returned by AmazonEC2.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DescribeRegionsResponse> DescribeRegionsAsync(DescribeRegionsRequest describeRegionsRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeRegionsRequestMarshaller();
            var unmarshaller = DescribeRegionsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeRegionsRequest, DescribeRegionsResponse>(describeRegionsRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DescribeReservedInstancesResponse DescribeReservedInstances(DescribeReservedInstancesRequest request)
        {
            var task = DescribeReservedInstancesAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Describes one or more of the Reserved Instances that you purchased.</para> <para>For more information about Reserved Instances, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/concepts-on-demand-reserved-instances.html">Reserved Instances</a> in the
        /// <i>Amazon Elastic Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="describeReservedInstancesRequest">Container for the necessary parameters to execute the DescribeReservedInstances service
        /// method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeReservedInstances service method, as returned by AmazonEC2.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DescribeReservedInstancesResponse> DescribeReservedInstancesAsync(DescribeReservedInstancesRequest describeReservedInstancesRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeReservedInstancesRequestMarshaller();
            var unmarshaller = DescribeReservedInstancesResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeReservedInstancesRequest, DescribeReservedInstancesResponse>(describeReservedInstancesRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DescribeReservedInstancesListingsResponse DescribeReservedInstancesListings(DescribeReservedInstancesListingsRequest request)
        {
            var task = DescribeReservedInstancesListingsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Describes your account's Reserved Instance listings in the Reserved Instance Marketplace.</para> <para>For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ri-market-general.html">Reserved Instance Marketplace</a> in the <i>Amazon Elastic
        /// Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="describeReservedInstancesListingsRequest">Container for the necessary parameters to execute the
        /// DescribeReservedInstancesListings service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeReservedInstancesListings service method, as returned by AmazonEC2.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DescribeReservedInstancesListingsResponse> DescribeReservedInstancesListingsAsync(DescribeReservedInstancesListingsRequest describeReservedInstancesListingsRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeReservedInstancesListingsRequestMarshaller();
            var unmarshaller = DescribeReservedInstancesListingsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeReservedInstancesListingsRequest, DescribeReservedInstancesListingsResponse>(describeReservedInstancesListingsRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DescribeReservedInstancesModificationsResponse DescribeReservedInstancesModifications(DescribeReservedInstancesModificationsRequest request)
        {
            var task = DescribeReservedInstancesModificationsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Describes the modifications made to your Reserved Instances. If no parameter is specified, information about all your Reserved
        /// Instances modification requests is returned. If a modification ID is specified, only information about the specific modification is
        /// returned.</para>
        /// </summary>
        /// 
        /// <param name="describeReservedInstancesModificationsRequest">Container for the necessary parameters to execute the
        /// DescribeReservedInstancesModifications service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeReservedInstancesModifications service method, as returned by AmazonEC2.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DescribeReservedInstancesModificationsResponse> DescribeReservedInstancesModificationsAsync(DescribeReservedInstancesModificationsRequest describeReservedInstancesModificationsRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeReservedInstancesModificationsRequestMarshaller();
            var unmarshaller = DescribeReservedInstancesModificationsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeReservedInstancesModificationsRequest, DescribeReservedInstancesModificationsResponse>(describeReservedInstancesModificationsRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DescribeReservedInstancesOfferingsResponse DescribeReservedInstancesOfferings(DescribeReservedInstancesOfferingsRequest request)
        {
            var task = DescribeReservedInstancesOfferingsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Describes Reserved Instance offerings that are available for purchase. With Reserved Instances, you purchase the right to launch
        /// instances for a period of time. During that time period, you do not receive insufficient capacity errors, and you pay a lower usage rate
        /// than the rate charged for On-Demand instances for the actual time used.</para> <para>For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ri-market-general.html">Reserved Instance Marketplace</a> in the <i>Amazon Elastic
        /// Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="describeReservedInstancesOfferingsRequest">Container for the necessary parameters to execute the
        /// DescribeReservedInstancesOfferings service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeReservedInstancesOfferings service method, as returned by AmazonEC2.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DescribeReservedInstancesOfferingsResponse> DescribeReservedInstancesOfferingsAsync(DescribeReservedInstancesOfferingsRequest describeReservedInstancesOfferingsRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeReservedInstancesOfferingsRequestMarshaller();
            var unmarshaller = DescribeReservedInstancesOfferingsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeReservedInstancesOfferingsRequest, DescribeReservedInstancesOfferingsResponse>(describeReservedInstancesOfferingsRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DescribeRouteTablesResponse DescribeRouteTables(DescribeRouteTablesRequest request)
        {
            var task = DescribeRouteTablesAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Describes one or more of your route tables.</para> <para>For more information about route tables, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Route_Tables.html">Route Tables</a> in the <i>Amazon Virtual Private Cloud
        /// User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="describeRouteTablesRequest">Container for the necessary parameters to execute the DescribeRouteTables service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeRouteTables service method, as returned by AmazonEC2.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DescribeRouteTablesResponse> DescribeRouteTablesAsync(DescribeRouteTablesRequest describeRouteTablesRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeRouteTablesRequestMarshaller();
            var unmarshaller = DescribeRouteTablesResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeRouteTablesRequest, DescribeRouteTablesResponse>(describeRouteTablesRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DescribeSecurityGroupsResponse DescribeSecurityGroups(DescribeSecurityGroupsRequest request)
        {
            var task = DescribeSecurityGroupsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Describes one or more of your security groups.</para> <para>A security group is for use with instances either in the EC2-Classic
        /// platform or in a specific VPC. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-network-security.html">Amazon EC2 Security Groups</a> in the <i>Amazon
        /// Elastic Compute Cloud User Guide</i> and <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_SecurityGroups.html">Security
        /// Groups for Your VPC</a> in the <i>Amazon Virtual Private Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="describeSecurityGroupsRequest">Container for the necessary parameters to execute the DescribeSecurityGroups service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeSecurityGroups service method, as returned by AmazonEC2.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DescribeSecurityGroupsResponse> DescribeSecurityGroupsAsync(DescribeSecurityGroupsRequest describeSecurityGroupsRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeSecurityGroupsRequestMarshaller();
            var unmarshaller = DescribeSecurityGroupsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeSecurityGroupsRequest, DescribeSecurityGroupsResponse>(describeSecurityGroupsRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DescribeSnapshotAttributeResponse DescribeSnapshotAttribute(DescribeSnapshotAttributeRequest request)
        {
            var task = DescribeSnapshotAttributeAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Describes an attribute of the specified snapshot. You can specify only one attribute at a time.</para> <para>For more information
        /// about Amazon EBS snapshots, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSSnapshots.html">Amazon EBS Snapshots</a> in
        /// the <i>Amazon Elastic Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="describeSnapshotAttributeRequest">Container for the necessary parameters to execute the DescribeSnapshotAttribute service
        /// method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeSnapshotAttribute service method, as returned by AmazonEC2.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DescribeSnapshotAttributeResponse> DescribeSnapshotAttributeAsync(DescribeSnapshotAttributeRequest describeSnapshotAttributeRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeSnapshotAttributeRequestMarshaller();
            var unmarshaller = DescribeSnapshotAttributeResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeSnapshotAttributeRequest, DescribeSnapshotAttributeResponse>(describeSnapshotAttributeRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DescribeSnapshotsResponse DescribeSnapshots(DescribeSnapshotsRequest request)
        {
            var task = DescribeSnapshotsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

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
        /// <c>all</c> for public snapshots.</para> <para>For more information about Amazon EBS snapshots, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSSnapshots.html">Amazon EBS Snapshots</a> in the <i>Amazon Elastic Compute Cloud
        /// User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="describeSnapshotsRequest">Container for the necessary parameters to execute the DescribeSnapshots service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeSnapshots service method, as returned by AmazonEC2.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DescribeSnapshotsResponse> DescribeSnapshotsAsync(DescribeSnapshotsRequest describeSnapshotsRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeSnapshotsRequestMarshaller();
            var unmarshaller = DescribeSnapshotsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeSnapshotsRequest, DescribeSnapshotsResponse>(describeSnapshotsRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DescribeSpotDatafeedSubscriptionResponse DescribeSpotDatafeedSubscription(DescribeSpotDatafeedSubscriptionRequest request)
        {
            var task = DescribeSpotDatafeedSubscriptionAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Describes the datafeed for Spot Instances. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-spot-instances.html">Spot Instances</a> in the <i>Amazon Elastic Compute
        /// Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="describeSpotDatafeedSubscriptionRequest">Container for the necessary parameters to execute the DescribeSpotDatafeedSubscription
        /// service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeSpotDatafeedSubscription service method, as returned by AmazonEC2.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DescribeSpotDatafeedSubscriptionResponse> DescribeSpotDatafeedSubscriptionAsync(DescribeSpotDatafeedSubscriptionRequest describeSpotDatafeedSubscriptionRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeSpotDatafeedSubscriptionRequestMarshaller();
            var unmarshaller = DescribeSpotDatafeedSubscriptionResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeSpotDatafeedSubscriptionRequest, DescribeSpotDatafeedSubscriptionResponse>(describeSpotDatafeedSubscriptionRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DescribeSpotInstanceRequestsResponse DescribeSpotInstanceRequests(DescribeSpotInstanceRequestsRequest request)
        {
            var task = DescribeSpotInstanceRequestsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Describes the Spot Instance requests that belong to your account. Spot Instances are instances that Amazon EC2 starts on your behalf
        /// when the maximum price that you specify exceeds the current Spot Price. Amazon EC2 periodically sets the Spot Price based on available Spot
        /// Instance capacity and current Spot Instance requests. For more information about Spot Instances, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-spot-instances.html">Spot Instances</a> in the <i>Amazon Elastic Compute
        /// Cloud User Guide</i> .</para> <para>You can use <c>DescribeSpotInstanceRequests</c> to find a running Spot Instance by examining the
        /// response. If the status of the Spot Instance is <c>fulfilled</c> , the instance ID appears in the response and contains the identifier of
        /// the instance. Alternatively, you can use DescribeInstances with a filter to look for instances where the instance lifecycle is <c>spot</c>
        /// .</para>
        /// </summary>
        /// 
        /// <param name="describeSpotInstanceRequestsRequest">Container for the necessary parameters to execute the DescribeSpotInstanceRequests service
        /// method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeSpotInstanceRequests service method, as returned by AmazonEC2.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DescribeSpotInstanceRequestsResponse> DescribeSpotInstanceRequestsAsync(DescribeSpotInstanceRequestsRequest describeSpotInstanceRequestsRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeSpotInstanceRequestsRequestMarshaller();
            var unmarshaller = DescribeSpotInstanceRequestsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeSpotInstanceRequestsRequest, DescribeSpotInstanceRequestsResponse>(describeSpotInstanceRequestsRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DescribeSpotPriceHistoryResponse DescribeSpotPriceHistory(DescribeSpotPriceHistoryRequest request)
        {
            var task = DescribeSpotPriceHistoryAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Describes the Spot Price history. Spot Instances are instances that Amazon EC2 starts on your behalf when the maximum price that you
        /// specify exceeds the current Spot Price. Amazon EC2 periodically sets the Spot Price based on available Spot Instance capacity and current
        /// Spot Instance requests. For more information about Spot Instances, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-spot-instances.html">Spot Instances</a> in the <i>Amazon Elastic Compute
        /// Cloud User Guide</i> .</para> <para>When you specify an Availability Zone, this operation describes the price history for the specified
        /// Availability Zone with the most recent set of prices listed first. If you don't specify an Availability Zone, you get the prices across all
        /// Availability Zones, starting with the most recent set. However, if you're using an API version earlier than 2011-05-15, you get the lowest
        /// price across the region for the specified time period. The prices returned are listed in chronological order, from the oldest to the most
        /// recent.</para>
        /// </summary>
        /// 
        /// <param name="describeSpotPriceHistoryRequest">Container for the necessary parameters to execute the DescribeSpotPriceHistory service method
        /// on AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeSpotPriceHistory service method, as returned by AmazonEC2.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DescribeSpotPriceHistoryResponse> DescribeSpotPriceHistoryAsync(DescribeSpotPriceHistoryRequest describeSpotPriceHistoryRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeSpotPriceHistoryRequestMarshaller();
            var unmarshaller = DescribeSpotPriceHistoryResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeSpotPriceHistoryRequest, DescribeSpotPriceHistoryResponse>(describeSpotPriceHistoryRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DescribeSubnetsResponse DescribeSubnets(DescribeSubnetsRequest request)
        {
            var task = DescribeSubnetsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Describes one or more of your subnets.</para> <para>For more information about subnets, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Subnets.html">Your VPC and Subnets</a> in the <i>Amazon Virtual Private
        /// Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="describeSubnetsRequest">Container for the necessary parameters to execute the DescribeSubnets service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeSubnets service method, as returned by AmazonEC2.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DescribeSubnetsResponse> DescribeSubnetsAsync(DescribeSubnetsRequest describeSubnetsRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeSubnetsRequestMarshaller();
            var unmarshaller = DescribeSubnetsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeSubnetsRequest, DescribeSubnetsResponse>(describeSubnetsRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DescribeTagsResponse DescribeTags(DescribeTagsRequest request)
        {
            var task = DescribeTagsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Describes one or more of the tags for your EC2 resources.</para> <para>For more information about tags, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_Tags.html">Tagging Your Resources</a> in the <i>Amazon Elastic Compute Cloud
        /// User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="describeTagsRequest">Container for the necessary parameters to execute the DescribeTags service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeTags service method, as returned by AmazonEC2.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DescribeTagsResponse> DescribeTagsAsync(DescribeTagsRequest describeTagsRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeTagsRequestMarshaller();
            var unmarshaller = DescribeTagsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeTagsRequest, DescribeTagsResponse>(describeTagsRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DescribeVolumeAttributeResponse DescribeVolumeAttribute(DescribeVolumeAttributeRequest request)
        {
            var task = DescribeVolumeAttributeAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Describes the specified attribute of the specified volume. You can specify only one attribute at a time.</para> <para>For more
        /// information about Amazon EBS volumes, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSVolumes.html">Amazon EBS
        /// Volumes</a> in the <i>Amazon Elastic Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="describeVolumeAttributeRequest">Container for the necessary parameters to execute the DescribeVolumeAttribute service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeVolumeAttribute service method, as returned by AmazonEC2.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DescribeVolumeAttributeResponse> DescribeVolumeAttributeAsync(DescribeVolumeAttributeRequest describeVolumeAttributeRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeVolumeAttributeRequestMarshaller();
            var unmarshaller = DescribeVolumeAttributeResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeVolumeAttributeRequest, DescribeVolumeAttributeResponse>(describeVolumeAttributeRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DescribeVolumesResponse DescribeVolumes(DescribeVolumesRequest request)
        {
            var task = DescribeVolumesAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Describes the specified Amazon EBS volumes.</para> <para>For more information about Amazon EBS volumes, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSVolumes.html">Amazon EBS Volumes</a> in the <i>Amazon Elastic Compute Cloud
        /// User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="describeVolumesRequest">Container for the necessary parameters to execute the DescribeVolumes service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeVolumes service method, as returned by AmazonEC2.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DescribeVolumesResponse> DescribeVolumesAsync(DescribeVolumesRequest describeVolumesRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeVolumesRequestMarshaller();
            var unmarshaller = DescribeVolumesResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeVolumesRequest, DescribeVolumesResponse>(describeVolumesRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DescribeVolumeStatusResponse DescribeVolumeStatus(DescribeVolumeStatusRequest request)
        {
            var task = DescribeVolumeStatusAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

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
        /// place on your volume at the time. We recommend that you retry the request. For more information on volume status, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/monitoring-volume-status.html">Monitoring the Status of Your Volumes</a> .</para>
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
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeVolumeStatus service method, as returned by AmazonEC2.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DescribeVolumeStatusResponse> DescribeVolumeStatusAsync(DescribeVolumeStatusRequest describeVolumeStatusRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeVolumeStatusRequestMarshaller();
            var unmarshaller = DescribeVolumeStatusResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeVolumeStatusRequest, DescribeVolumeStatusResponse>(describeVolumeStatusRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DescribeVpcAttributeResponse DescribeVpcAttribute(DescribeVpcAttributeRequest request)
        {
            var task = DescribeVpcAttributeAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Describes the specified attribute of the specified VPC. You can specify only one attribute at a time.</para>
        /// </summary>
        /// 
        /// <param name="describeVpcAttributeRequest">Container for the necessary parameters to execute the DescribeVpcAttribute service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeVpcAttribute service method, as returned by AmazonEC2.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DescribeVpcAttributeResponse> DescribeVpcAttributeAsync(DescribeVpcAttributeRequest describeVpcAttributeRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeVpcAttributeRequestMarshaller();
            var unmarshaller = DescribeVpcAttributeResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeVpcAttributeRequest, DescribeVpcAttributeResponse>(describeVpcAttributeRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DescribeVpcsResponse DescribeVpcs(DescribeVpcsRequest request)
        {
            var task = DescribeVpcsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Describes one or more of your VPCs.</para>
        /// </summary>
        /// 
        /// <param name="describeVpcsRequest">Container for the necessary parameters to execute the DescribeVpcs service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeVpcs service method, as returned by AmazonEC2.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DescribeVpcsResponse> DescribeVpcsAsync(DescribeVpcsRequest describeVpcsRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeVpcsRequestMarshaller();
            var unmarshaller = DescribeVpcsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeVpcsRequest, DescribeVpcsResponse>(describeVpcsRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DescribeVpnConnectionsResponse DescribeVpnConnections(DescribeVpnConnectionsRequest request)
        {
            var task = DescribeVpnConnectionsAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Describes one or more of your VPN connections.</para> <para>For more information about VPN connections, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_VPN.html">Adding a Hardware Virtual Private Gateway to Your VPC</a> in the
        /// <i>Amazon Virtual Private Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="describeVpnConnectionsRequest">Container for the necessary parameters to execute the DescribeVpnConnections service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeVpnConnections service method, as returned by AmazonEC2.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DescribeVpnConnectionsResponse> DescribeVpnConnectionsAsync(DescribeVpnConnectionsRequest describeVpnConnectionsRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeVpnConnectionsRequestMarshaller();
            var unmarshaller = DescribeVpnConnectionsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeVpnConnectionsRequest, DescribeVpnConnectionsResponse>(describeVpnConnectionsRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DescribeVpnGatewaysResponse DescribeVpnGateways(DescribeVpnGatewaysRequest request)
        {
            var task = DescribeVpnGatewaysAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Describes one or more of your virtual private gateways.</para> <para>For more information about virtual private gateways, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_VPN.html">Adding an IPsec Hardware VPN to Your VPC</a> in the <i>Amazon
        /// Virtual Private Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="describeVpnGatewaysRequest">Container for the necessary parameters to execute the DescribeVpnGateways service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeVpnGateways service method, as returned by AmazonEC2.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DescribeVpnGatewaysResponse> DescribeVpnGatewaysAsync(DescribeVpnGatewaysRequest describeVpnGatewaysRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeVpnGatewaysRequestMarshaller();
            var unmarshaller = DescribeVpnGatewaysResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeVpnGatewaysRequest, DescribeVpnGatewaysResponse>(describeVpnGatewaysRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DetachInternetGatewayResponse DetachInternetGateway(DetachInternetGatewayRequest request)
        {
            var task = DetachInternetGatewayAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Detaches an Internet gateway from a VPC, disabling connectivity between the Internet and the VPC. The VPC must not contain any running
        /// instances with Elastic IP addresses.</para>
        /// </summary>
        /// 
        /// <param name="detachInternetGatewayRequest">Container for the necessary parameters to execute the DetachInternetGateway service method on
        /// AmazonEC2.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DetachInternetGatewayResponse> DetachInternetGatewayAsync(DetachInternetGatewayRequest detachInternetGatewayRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DetachInternetGatewayRequestMarshaller();
            var unmarshaller = DetachInternetGatewayResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DetachInternetGatewayRequest, DetachInternetGatewayResponse>(detachInternetGatewayRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DetachNetworkInterfaceResponse DetachNetworkInterface(DetachNetworkInterfaceRequest request)
        {
            var task = DetachNetworkInterfaceAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Detaches a network interface from an instance.</para>
        /// </summary>
        /// 
        /// <param name="detachNetworkInterfaceRequest">Container for the necessary parameters to execute the DetachNetworkInterface service method on
        /// AmazonEC2.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DetachNetworkInterfaceResponse> DetachNetworkInterfaceAsync(DetachNetworkInterfaceRequest detachNetworkInterfaceRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DetachNetworkInterfaceRequestMarshaller();
            var unmarshaller = DetachNetworkInterfaceResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DetachNetworkInterfaceRequest, DetachNetworkInterfaceResponse>(detachNetworkInterfaceRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DetachVolumeResponse DetachVolume(DetachVolumeRequest request)
        {
            var task = DetachVolumeAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Detaches an Amazon EBS volume from an instance. Make sure to unmount any file systems on the device within your operating system
        /// before detaching the volume. Failure to do so results in the volume being stuck in a busy state while detaching.</para> <para>If an Amazon
        /// EBS volume is the root device of an instance, it can't be detached while the instance is running. To detach the root volume, stop the
        /// instance first.</para> <para>If the root volume is detached from an instance with an AWS Marketplace product code, then the AWS Marketplace
        /// product codes from that volume are no longer associated with the instance.</para> <para>For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-detaching-volume.html">Detaching an Amazon EBS Volume</a> in the <i>Amazon
        /// Elastic Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="detachVolumeRequest">Container for the necessary parameters to execute the DetachVolume service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the DetachVolume service method, as returned by AmazonEC2.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DetachVolumeResponse> DetachVolumeAsync(DetachVolumeRequest detachVolumeRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DetachVolumeRequestMarshaller();
            var unmarshaller = DetachVolumeResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DetachVolumeRequest, DetachVolumeResponse>(detachVolumeRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DetachVpnGatewayResponse DetachVpnGateway(DetachVpnGatewayRequest request)
        {
            var task = DetachVpnGatewayAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Detaches a virtual private gateway from a VPC. You do this if you're planning to turn off the VPC and not use it anymore. You can
        /// confirm a virtual private gateway has been completely detached from a VPC by describing the virtual private gateway (any attachments to the
        /// virtual private gateway are also described).</para> <para>You must wait for the attachment's state to switch to <c>detached</c> before you
        /// can delete the VPC or attach a different VPC to the virtual private gateway.</para>
        /// </summary>
        /// 
        /// <param name="detachVpnGatewayRequest">Container for the necessary parameters to execute the DetachVpnGateway service method on
        /// AmazonEC2.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DetachVpnGatewayResponse> DetachVpnGatewayAsync(DetachVpnGatewayRequest detachVpnGatewayRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DetachVpnGatewayRequestMarshaller();
            var unmarshaller = DetachVpnGatewayResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DetachVpnGatewayRequest, DetachVpnGatewayResponse>(detachVpnGatewayRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DisableVgwRoutePropagationResponse DisableVgwRoutePropagation(DisableVgwRoutePropagationRequest request)
        {
            var task = DisableVgwRoutePropagationAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Disables a virtual private gateway (VGW) from propagating routes to the routing tables of a VPC.</para>
        /// </summary>
        /// 
        /// <param name="disableVgwRoutePropagationRequest">Container for the necessary parameters to execute the DisableVgwRoutePropagation service
        /// method on AmazonEC2.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DisableVgwRoutePropagationResponse> DisableVgwRoutePropagationAsync(DisableVgwRoutePropagationRequest disableVgwRoutePropagationRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DisableVgwRoutePropagationRequestMarshaller();
            var unmarshaller = DisableVgwRoutePropagationResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DisableVgwRoutePropagationRequest, DisableVgwRoutePropagationResponse>(disableVgwRoutePropagationRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DisassociateAddressResponse DisassociateAddress(DisassociateAddressRequest request)
        {
            var task = DisassociateAddressAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Disassociates an Elastic IP address from the instance or network interface it's associated with.</para> <para>This is an idempotent
        /// operation. If you perform the operation more than once, Amazon EC2 doesn't return an error.</para>
        /// </summary>
        /// 
        /// <param name="disassociateAddressRequest">Container for the necessary parameters to execute the DisassociateAddress service method on
        /// AmazonEC2.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DisassociateAddressResponse> DisassociateAddressAsync(DisassociateAddressRequest disassociateAddressRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DisassociateAddressRequestMarshaller();
            var unmarshaller = DisassociateAddressResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DisassociateAddressRequest, DisassociateAddressResponse>(disassociateAddressRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal DisassociateRouteTableResponse DisassociateRouteTable(DisassociateRouteTableRequest request)
        {
            var task = DisassociateRouteTableAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Disassociates a subnet from a route table.</para> <para>After you perform this action, the subnet no longer uses the routes in the
        /// route table. Instead, it uses the routes in the VPC's main route table. For more information about route tables, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Route_Tables.html">Route Tables</a> in the <i>Amazon Virtual Private Cloud
        /// User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="disassociateRouteTableRequest">Container for the necessary parameters to execute the DisassociateRouteTable service method on
        /// AmazonEC2.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<DisassociateRouteTableResponse> DisassociateRouteTableAsync(DisassociateRouteTableRequest disassociateRouteTableRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DisassociateRouteTableRequestMarshaller();
            var unmarshaller = DisassociateRouteTableResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DisassociateRouteTableRequest, DisassociateRouteTableResponse>(disassociateRouteTableRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal EnableVgwRoutePropagationResponse EnableVgwRoutePropagation(EnableVgwRoutePropagationRequest request)
        {
            var task = EnableVgwRoutePropagationAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Enables a virtual private gateway (VGW) to propagate routes to the routing tables of a VPC.</para>
        /// </summary>
        /// 
        /// <param name="enableVgwRoutePropagationRequest">Container for the necessary parameters to execute the EnableVgwRoutePropagation service
        /// method on AmazonEC2.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<EnableVgwRoutePropagationResponse> EnableVgwRoutePropagationAsync(EnableVgwRoutePropagationRequest enableVgwRoutePropagationRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new EnableVgwRoutePropagationRequestMarshaller();
            var unmarshaller = EnableVgwRoutePropagationResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, EnableVgwRoutePropagationRequest, EnableVgwRoutePropagationResponse>(enableVgwRoutePropagationRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal EnableVolumeIOResponse EnableVolumeIO(EnableVolumeIORequest request)
        {
            var task = EnableVolumeIOAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Enables I/O operations for a volume that had I/O operations disabled because the data on the volume was potentially
        /// inconsistent.</para>
        /// </summary>
        /// 
        /// <param name="enableVolumeIORequest">Container for the necessary parameters to execute the EnableVolumeIO service method on
        /// AmazonEC2.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<EnableVolumeIOResponse> EnableVolumeIOAsync(EnableVolumeIORequest enableVolumeIORequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new EnableVolumeIORequestMarshaller();
            var unmarshaller = EnableVolumeIOResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, EnableVolumeIORequest, EnableVolumeIOResponse>(enableVolumeIORequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal GetConsoleOutputResponse GetConsoleOutput(GetConsoleOutputRequest request)
        {
            var task = GetConsoleOutputAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

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
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the GetConsoleOutput service method, as returned by AmazonEC2.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<GetConsoleOutputResponse> GetConsoleOutputAsync(GetConsoleOutputRequest getConsoleOutputRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetConsoleOutputRequestMarshaller();
            var unmarshaller = GetConsoleOutputResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, GetConsoleOutputRequest, GetConsoleOutputResponse>(getConsoleOutputRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal GetPasswordDataResponse GetPasswordData(GetPasswordDataRequest request)
        {
            var task = GetPasswordDataAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Retrieves the encrypted administrator password for an instance running Windows.</para> <para>The Windows password is only generated
        /// the first time an AMI is launched. It is not generated for rebundled AMIs or after the password is changed on an instance.</para> <para>The
        /// password is encrypted using the key pair that you specified when you launched the instance. You must provide the corresponding key pair
        /// file.</para> <para>Password generation and encryption takes a few moments. We recommend that you wait up to 15 minutes after launching an
        /// instance before trying to retrieve the generated password.</para>
        /// </summary>
        /// 
        /// <param name="getPasswordDataRequest">Container for the necessary parameters to execute the GetPasswordData service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the GetPasswordData service method, as returned by AmazonEC2.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<GetPasswordDataResponse> GetPasswordDataAsync(GetPasswordDataRequest getPasswordDataRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetPasswordDataRequestMarshaller();
            var unmarshaller = GetPasswordDataResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, GetPasswordDataRequest, GetPasswordDataResponse>(getPasswordDataRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal ImportInstanceResponse ImportInstance(ImportInstanceRequest request)
        {
            var task = ImportInstanceAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Creates an import instance task using metadata from the specified disk image. After importing the image, you then upload it using the
        /// ec2-upload-disk-image command in the EC2 command line tools. For more information, see Using the Command Line Tools to Import Your Virtual
        /// Machine to Amazon EC2 in the Amazon Elastic Compute Cloud User Guide.</para>
        /// </summary>
        /// 
        /// <param name="importInstanceRequest">Container for the necessary parameters to execute the ImportInstance service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the ImportInstance service method, as returned by AmazonEC2.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<ImportInstanceResponse> ImportInstanceAsync(ImportInstanceRequest importInstanceRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ImportInstanceRequestMarshaller();
            var unmarshaller = ImportInstanceResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, ImportInstanceRequest, ImportInstanceResponse>(importInstanceRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal ImportKeyPairResponse ImportKeyPair(ImportKeyPairRequest request)
        {
            var task = ImportKeyPairAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Imports the public key from an RSA key pair that you created with a third-party tool. Compare this with CreateKeyPair, in which AWS
        /// creates the key pair and gives the keys to you (AWS keeps a copy of the public key). With ImportKeyPair, you create the key pair and give
        /// AWS just the public key. The private key is never transferred between you and AWS.</para> <para>For more information about key pairs, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-key-pairs.html">Key Pairs</a> in the <i>Amazon Elastic Compute Cloud User
        /// Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="importKeyPairRequest">Container for the necessary parameters to execute the ImportKeyPair service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the ImportKeyPair service method, as returned by AmazonEC2.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<ImportKeyPairResponse> ImportKeyPairAsync(ImportKeyPairRequest importKeyPairRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ImportKeyPairRequestMarshaller();
            var unmarshaller = ImportKeyPairResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, ImportKeyPairRequest, ImportKeyPairResponse>(importKeyPairRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal ImportVolumeResponse ImportVolume(ImportVolumeRequest request)
        {
            var task = ImportVolumeAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Creates an import volume task using metadata from the specified disk image. After importing the image, you then upload it using the
        /// ec2-upload-disk-image command in the Amazon EC2 command-line interface (CLI) tools. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/UploadingYourInstancesandVolumes.html">Using the Command Line Tools to Import Your
        /// Virtual Machine to Amazon EC2</a> in the <i>Amazon Elastic Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="importVolumeRequest">Container for the necessary parameters to execute the ImportVolume service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the ImportVolume service method, as returned by AmazonEC2.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<ImportVolumeResponse> ImportVolumeAsync(ImportVolumeRequest importVolumeRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ImportVolumeRequestMarshaller();
            var unmarshaller = ImportVolumeResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, ImportVolumeRequest, ImportVolumeResponse>(importVolumeRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal ModifyImageAttributeResponse ModifyImageAttribute(ModifyImageAttributeRequest request)
        {
            var task = ModifyImageAttributeAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Modifies the specified attribute of the specified AMI. You can specify only one attribute at a time.</para> <para><b>NOTE:</b> AWS
        /// Marketplace product codes cannot be modified. Images with an AWS Marketplace product code cannot be made public. </para>
        /// </summary>
        /// 
        /// <param name="modifyImageAttributeRequest">Container for the necessary parameters to execute the ModifyImageAttribute service method on
        /// AmazonEC2.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<ModifyImageAttributeResponse> ModifyImageAttributeAsync(ModifyImageAttributeRequest modifyImageAttributeRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ModifyImageAttributeRequestMarshaller();
            var unmarshaller = ModifyImageAttributeResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, ModifyImageAttributeRequest, ModifyImageAttributeResponse>(modifyImageAttributeRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal ModifyInstanceAttributeResponse ModifyInstanceAttribute(ModifyInstanceAttributeRequest request)
        {
            var task = ModifyInstanceAttributeAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Modifies the specified attribute of the specified instance. You can specify only one attribute at a time.</para> <para>To modify some
        /// attributes, the instance must be stopped. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_ChangingAttributesWhileInstanceStopped.html">Modifying Attributes of a
        /// Stopped Instance</a> in the <i>Amazon Elastic Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="modifyInstanceAttributeRequest">Container for the necessary parameters to execute the ModifyInstanceAttribute service method on
        /// AmazonEC2.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<ModifyInstanceAttributeResponse> ModifyInstanceAttributeAsync(ModifyInstanceAttributeRequest modifyInstanceAttributeRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ModifyInstanceAttributeRequestMarshaller();
            var unmarshaller = ModifyInstanceAttributeResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, ModifyInstanceAttributeRequest, ModifyInstanceAttributeResponse>(modifyInstanceAttributeRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal ModifyNetworkInterfaceAttributeResponse ModifyNetworkInterfaceAttribute(ModifyNetworkInterfaceAttributeRequest request)
        {
            var task = ModifyNetworkInterfaceAttributeAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Modifies the specified network interface attribute. You can specify only one attribute at a time.</para>
        /// </summary>
        /// 
        /// <param name="modifyNetworkInterfaceAttributeRequest">Container for the necessary parameters to execute the ModifyNetworkInterfaceAttribute
        /// service method on AmazonEC2.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<ModifyNetworkInterfaceAttributeResponse> ModifyNetworkInterfaceAttributeAsync(ModifyNetworkInterfaceAttributeRequest modifyNetworkInterfaceAttributeRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ModifyNetworkInterfaceAttributeRequestMarshaller();
            var unmarshaller = ModifyNetworkInterfaceAttributeResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, ModifyNetworkInterfaceAttributeRequest, ModifyNetworkInterfaceAttributeResponse>(modifyNetworkInterfaceAttributeRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal ModifyReservedInstancesResponse ModifyReservedInstances(ModifyReservedInstancesRequest request)
        {
            var task = ModifyReservedInstancesAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Modifies the Availability Zone, instance count, instance type, or network platform (EC2-Classic or EC2-VPC) of your Reserved
        /// Instances. The Reserved Instances to be modified must be identical, except for Availability Zone, network platform, and instance
        /// type.</para>
        /// </summary>
        /// 
        /// <param name="modifyReservedInstancesRequest">Container for the necessary parameters to execute the ModifyReservedInstances service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the ModifyReservedInstances service method, as returned by AmazonEC2.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<ModifyReservedInstancesResponse> ModifyReservedInstancesAsync(ModifyReservedInstancesRequest modifyReservedInstancesRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ModifyReservedInstancesRequestMarshaller();
            var unmarshaller = ModifyReservedInstancesResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, ModifyReservedInstancesRequest, ModifyReservedInstancesResponse>(modifyReservedInstancesRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal ModifySnapshotAttributeResponse ModifySnapshotAttribute(ModifySnapshotAttributeRequest request)
        {
            var task = ModifySnapshotAttributeAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Adds or removes permission settings for the specified snapshot.</para> <para>For more information on modifying snapshot permissions,
        /// see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-modifying-snapshot-permissions.html">Sharing Snapshots</a> in the
        /// <i>Amazon Elastic Compute Cloud User Guide</i> .</para> <para><b>NOTE:</b> Snapshots with AWS Marketplace product codes cannot be made
        /// public. </para>
        /// </summary>
        /// 
        /// <param name="modifySnapshotAttributeRequest">Container for the necessary parameters to execute the ModifySnapshotAttribute service method on
        /// AmazonEC2.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<ModifySnapshotAttributeResponse> ModifySnapshotAttributeAsync(ModifySnapshotAttributeRequest modifySnapshotAttributeRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ModifySnapshotAttributeRequestMarshaller();
            var unmarshaller = ModifySnapshotAttributeResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, ModifySnapshotAttributeRequest, ModifySnapshotAttributeResponse>(modifySnapshotAttributeRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal ModifyVolumeAttributeResponse ModifyVolumeAttribute(ModifyVolumeAttributeRequest request)
        {
            var task = ModifyVolumeAttributeAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Modifies a volume attribute.</para> <para>By default, all I/O operations for the volume are suspended when the data on the volume is
        /// determined to be potentially inconsistent, to prevent undetectable, latent data corruption. The I/O access to the volume can be resumed by
        /// first enabling I/O access and then checking the data consistency on your volume.</para> <para>You can change the default behavior to resume
        /// I/O operations. We recommend that you change this only for boot volumes or for volumes that are stateless or disposable.</para>
        /// </summary>
        /// 
        /// <param name="modifyVolumeAttributeRequest">Container for the necessary parameters to execute the ModifyVolumeAttribute service method on
        /// AmazonEC2.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<ModifyVolumeAttributeResponse> ModifyVolumeAttributeAsync(ModifyVolumeAttributeRequest modifyVolumeAttributeRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ModifyVolumeAttributeRequestMarshaller();
            var unmarshaller = ModifyVolumeAttributeResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, ModifyVolumeAttributeRequest, ModifyVolumeAttributeResponse>(modifyVolumeAttributeRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal ModifyVpcAttributeResponse ModifyVpcAttribute(ModifyVpcAttributeRequest request)
        {
            var task = ModifyVpcAttributeAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Modifies the specified attribute of the specified VPC.</para>
        /// </summary>
        /// 
        /// <param name="modifyVpcAttributeRequest">Container for the necessary parameters to execute the ModifyVpcAttribute service method on
        /// AmazonEC2.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<ModifyVpcAttributeResponse> ModifyVpcAttributeAsync(ModifyVpcAttributeRequest modifyVpcAttributeRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ModifyVpcAttributeRequestMarshaller();
            var unmarshaller = ModifyVpcAttributeResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, ModifyVpcAttributeRequest, ModifyVpcAttributeResponse>(modifyVpcAttributeRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal MonitorInstancesResponse MonitorInstances(MonitorInstancesRequest request)
        {
            var task = MonitorInstancesAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Enables monitoring for a running instance. For more information about monitoring instances, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-cloudwatch.html">Monitoring Your Instances and Volumes</a> in the <i>Amazon
        /// Elastic Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="monitorInstancesRequest">Container for the necessary parameters to execute the MonitorInstances service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the MonitorInstances service method, as returned by AmazonEC2.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<MonitorInstancesResponse> MonitorInstancesAsync(MonitorInstancesRequest monitorInstancesRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new MonitorInstancesRequestMarshaller();
            var unmarshaller = MonitorInstancesResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, MonitorInstancesRequest, MonitorInstancesResponse>(monitorInstancesRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal PurchaseReservedInstancesOfferingResponse PurchaseReservedInstancesOffering(PurchaseReservedInstancesOfferingRequest request)
        {
            var task = PurchaseReservedInstancesOfferingAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Purchases a Reserved Instance for use with your account. With Amazon EC2 Reserved Instances, you obtain a capacity reservation for a
        /// certain instance configuration over a specified period of time. You pay a lower usage rate than with On-Demand instances for the time that
        /// you actually use the capacity reservation.</para> <para>For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ri-market-general.html">Reserved Instance Marketplace</a> in the <i>Amazon Elastic
        /// Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="purchaseReservedInstancesOfferingRequest">Container for the necessary parameters to execute the
        /// PurchaseReservedInstancesOffering service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the PurchaseReservedInstancesOffering service method, as returned by AmazonEC2.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<PurchaseReservedInstancesOfferingResponse> PurchaseReservedInstancesOfferingAsync(PurchaseReservedInstancesOfferingRequest purchaseReservedInstancesOfferingRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PurchaseReservedInstancesOfferingRequestMarshaller();
            var unmarshaller = PurchaseReservedInstancesOfferingResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, PurchaseReservedInstancesOfferingRequest, PurchaseReservedInstancesOfferingResponse>(purchaseReservedInstancesOfferingRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal RebootInstancesResponse RebootInstances(RebootInstancesRequest request)
        {
            var task = RebootInstancesAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Requests a reboot of one or more instances. This operation is asynchronous; it only queues a request to reboot the specified
        /// instances. The operation succeeds if the instances are valid and belong to you. Requests to reboot terminated instances are ignored.</para>
        /// <para>If a Linux/Unix instance does not cleanly shut down within four minutes, Amazon EC2 performs a hard reboot.</para>
        /// </summary>
        /// 
        /// <param name="rebootInstancesRequest">Container for the necessary parameters to execute the RebootInstances service method on
        /// AmazonEC2.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<RebootInstancesResponse> RebootInstancesAsync(RebootInstancesRequest rebootInstancesRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RebootInstancesRequestMarshaller();
            var unmarshaller = RebootInstancesResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, RebootInstancesRequest, RebootInstancesResponse>(rebootInstancesRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal RegisterImageResponse RegisterImage(RegisterImageRequest request)
        {
            var task = RegisterImageAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Registers an AMI. When you're creating an AMI, this is the final step you must complete before you can launch an instance from the
        /// AMI. For more information about creating AMIs, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/creating-an-ami.html">Creating Your Own AMIs</a> in the <i>Amazon Elastic Compute Cloud User Guide</i> .</para> <para><b>NOTE:</b> For Amazon EBS-backed
        /// instances, CreateImage creates and registers the AMI in a single request, so you don't have to register the AMI yourself. </para> <para>You
        /// can also use <c>RegisterImage</c> to create an Amazon EBS-backed AMI from a snapshot of a root device volume. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_LaunchingInstanceFromSnapshot.html">Launching an Instance from a
        /// Snapshot</a> in the <i>Amazon Elastic Compute Cloud User Guide</i> .</para> <para>If needed, you can deregister an AMI at any time. Any
        /// modifications you make to an AMI backed by an instance store volume invalidates its registration. If you make changes to an image,
        /// deregister the previous image and register the new image.</para> <para><b>NOTE:</b> You can't register an image where a secondary (non-root)
        /// snapshot has AWS Marketplace product codes. </para>
        /// </summary>
        /// 
        /// <param name="registerImageRequest">Container for the necessary parameters to execute the RegisterImage service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the RegisterImage service method, as returned by AmazonEC2.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<RegisterImageResponse> RegisterImageAsync(RegisterImageRequest registerImageRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RegisterImageRequestMarshaller();
            var unmarshaller = RegisterImageResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, RegisterImageRequest, RegisterImageResponse>(registerImageRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal ReleaseAddressResponse ReleaseAddress(ReleaseAddressRequest request)
        {
            var task = ReleaseAddressAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

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
        /// AmazonEC2.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<ReleaseAddressResponse> ReleaseAddressAsync(ReleaseAddressRequest releaseAddressRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ReleaseAddressRequestMarshaller();
            var unmarshaller = ReleaseAddressResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, ReleaseAddressRequest, ReleaseAddressResponse>(releaseAddressRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal ReplaceNetworkAclAssociationResponse ReplaceNetworkAclAssociation(ReplaceNetworkAclAssociationRequest request)
        {
            var task = ReplaceNetworkAclAssociationAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Changes which network ACL a subnet is associated with. By default when you create a subnet, it's automatically associated with the
        /// default network ACL. For more information about network ACLs, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_ACLs.html">Network ACLs</a> in the <i>Amazon Virtual Private Cloud User
        /// Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="replaceNetworkAclAssociationRequest">Container for the necessary parameters to execute the ReplaceNetworkAclAssociation service
        /// method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the ReplaceNetworkAclAssociation service method, as returned by AmazonEC2.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<ReplaceNetworkAclAssociationResponse> ReplaceNetworkAclAssociationAsync(ReplaceNetworkAclAssociationRequest replaceNetworkAclAssociationRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ReplaceNetworkAclAssociationRequestMarshaller();
            var unmarshaller = ReplaceNetworkAclAssociationResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, ReplaceNetworkAclAssociationRequest, ReplaceNetworkAclAssociationResponse>(replaceNetworkAclAssociationRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal ReplaceNetworkAclEntryResponse ReplaceNetworkAclEntry(ReplaceNetworkAclEntryRequest request)
        {
            var task = ReplaceNetworkAclEntryAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Replaces an entry (rule) in a network ACL. For more information about network ACLs, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_ACLs.html">Network ACLs</a> in the <i>Amazon Virtual Private Cloud User
        /// Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="replaceNetworkAclEntryRequest">Container for the necessary parameters to execute the ReplaceNetworkAclEntry service method on
        /// AmazonEC2.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<ReplaceNetworkAclEntryResponse> ReplaceNetworkAclEntryAsync(ReplaceNetworkAclEntryRequest replaceNetworkAclEntryRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ReplaceNetworkAclEntryRequestMarshaller();
            var unmarshaller = ReplaceNetworkAclEntryResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, ReplaceNetworkAclEntryRequest, ReplaceNetworkAclEntryResponse>(replaceNetworkAclEntryRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal ReplaceRouteResponse ReplaceRoute(ReplaceRouteRequest request)
        {
            var task = ReplaceRouteAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Replaces an existing route within a route table in a VPC. You must provide only one of the following: Internet gateway, NAT instance,
        /// or network interface.</para> <para>For more information about route tables, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Route_Tables.html">Route Tables</a> in the <i>Amazon Virtual Private Cloud
        /// User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="replaceRouteRequest">Container for the necessary parameters to execute the ReplaceRoute service method on AmazonEC2.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<ReplaceRouteResponse> ReplaceRouteAsync(ReplaceRouteRequest replaceRouteRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ReplaceRouteRequestMarshaller();
            var unmarshaller = ReplaceRouteResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, ReplaceRouteRequest, ReplaceRouteResponse>(replaceRouteRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal ReplaceRouteTableAssociationResponse ReplaceRouteTableAssociation(ReplaceRouteTableAssociationRequest request)
        {
            var task = ReplaceRouteTableAssociationAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Changes the route table associated with a given subnet in a VPC. After the operation completes, the subnet uses the routes in the new
        /// route table it's associated with. For more information about route tables, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Route_Tables.html">Route Tables</a> in the <i>Amazon Virtual Private Cloud
        /// User Guide</i> .</para> <para>You can also use ReplaceRouteTableAssociation to change which table is the main route table in the VPC. You
        /// just specify the main route table's association ID and the route table to be the new main route table.</para>
        /// </summary>
        /// 
        /// <param name="replaceRouteTableAssociationRequest">Container for the necessary parameters to execute the ReplaceRouteTableAssociation service
        /// method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the ReplaceRouteTableAssociation service method, as returned by AmazonEC2.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<ReplaceRouteTableAssociationResponse> ReplaceRouteTableAssociationAsync(ReplaceRouteTableAssociationRequest replaceRouteTableAssociationRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ReplaceRouteTableAssociationRequestMarshaller();
            var unmarshaller = ReplaceRouteTableAssociationResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, ReplaceRouteTableAssociationRequest, ReplaceRouteTableAssociationResponse>(replaceRouteTableAssociationRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal ReportInstanceStatusResponse ReportInstanceStatus(ReportInstanceStatusRequest request)
        {
            var task = ReportInstanceStatusAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Submits feedback about the status of an instance. The instance must be in the <c>running</c> state. If your experience with the
        /// instance differs from the instance status returned by DescribeInstanceStatus, use ReportInstanceStatus to report your experience with the
        /// instance. Amazon EC2 collects this information to improve the accuracy of status checks.</para>
        /// </summary>
        /// 
        /// <param name="reportInstanceStatusRequest">Container for the necessary parameters to execute the ReportInstanceStatus service method on
        /// AmazonEC2.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<ReportInstanceStatusResponse> ReportInstanceStatusAsync(ReportInstanceStatusRequest reportInstanceStatusRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ReportInstanceStatusRequestMarshaller();
            var unmarshaller = ReportInstanceStatusResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, ReportInstanceStatusRequest, ReportInstanceStatusResponse>(reportInstanceStatusRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal RequestSpotInstancesResponse RequestSpotInstances(RequestSpotInstancesRequest request)
        {
            var task = RequestSpotInstancesAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Creates a Spot Instance request. Spot Instances are instances that Amazon EC2 starts on your behalf when the maximum price that you
        /// specify exceeds the current Spot Price. Amazon EC2 periodically sets the Spot Price based on available Spot Instance capacity and current
        /// Spot Instance requests. For more information about Spot Instances, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-spot-instances.html">Spot Instances</a> in the <i>Amazon Elastic Compute
        /// Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="requestSpotInstancesRequest">Container for the necessary parameters to execute the RequestSpotInstances service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the RequestSpotInstances service method, as returned by AmazonEC2.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<RequestSpotInstancesResponse> RequestSpotInstancesAsync(RequestSpotInstancesRequest requestSpotInstancesRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RequestSpotInstancesRequestMarshaller();
            var unmarshaller = RequestSpotInstancesResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, RequestSpotInstancesRequest, RequestSpotInstancesResponse>(requestSpotInstancesRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal ResetImageAttributeResponse ResetImageAttribute(ResetImageAttributeRequest request)
        {
            var task = ResetImageAttributeAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Resets an attribute of an AMI to its default value.</para>
        /// </summary>
        /// 
        /// <param name="resetImageAttributeRequest">Container for the necessary parameters to execute the ResetImageAttribute service method on
        /// AmazonEC2.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<ResetImageAttributeResponse> ResetImageAttributeAsync(ResetImageAttributeRequest resetImageAttributeRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ResetImageAttributeRequestMarshaller();
            var unmarshaller = ResetImageAttributeResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, ResetImageAttributeRequest, ResetImageAttributeResponse>(resetImageAttributeRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal ResetInstanceAttributeResponse ResetInstanceAttribute(ResetInstanceAttributeRequest request)
        {
            var task = ResetInstanceAttributeAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Resets an attribute of an instance to its default value. To reset the kernel or RAM disk, the instance must be in a stopped state. To
        /// reset the <c>SourceDestCheck</c> , the instance can be either running or stopped.</para> <para>The <c>SourceDestCheck</c> attribute controls
        /// whether source/destination checking is enabled. The default value is <c>true</c> , which means checking is enabled. This value must be
        /// <c>false</c> for a NAT instance to perform NAT. For more information, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_NAT_Instance.html">NAT Instances</a> in the <i>Amazon Virtual Private Cloud
        /// User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="resetInstanceAttributeRequest">Container for the necessary parameters to execute the ResetInstanceAttribute service method on
        /// AmazonEC2.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<ResetInstanceAttributeResponse> ResetInstanceAttributeAsync(ResetInstanceAttributeRequest resetInstanceAttributeRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ResetInstanceAttributeRequestMarshaller();
            var unmarshaller = ResetInstanceAttributeResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, ResetInstanceAttributeRequest, ResetInstanceAttributeResponse>(resetInstanceAttributeRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal ResetNetworkInterfaceAttributeResponse ResetNetworkInterfaceAttribute(ResetNetworkInterfaceAttributeRequest request)
        {
            var task = ResetNetworkInterfaceAttributeAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Resets a network interface attribute. You can specify only one attribute at a time.</para>
        /// </summary>
        /// 
        /// <param name="resetNetworkInterfaceAttributeRequest">Container for the necessary parameters to execute the ResetNetworkInterfaceAttribute
        /// service method on AmazonEC2.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<ResetNetworkInterfaceAttributeResponse> ResetNetworkInterfaceAttributeAsync(ResetNetworkInterfaceAttributeRequest resetNetworkInterfaceAttributeRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ResetNetworkInterfaceAttributeRequestMarshaller();
            var unmarshaller = ResetNetworkInterfaceAttributeResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, ResetNetworkInterfaceAttributeRequest, ResetNetworkInterfaceAttributeResponse>(resetNetworkInterfaceAttributeRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal ResetSnapshotAttributeResponse ResetSnapshotAttribute(ResetSnapshotAttributeRequest request)
        {
            var task = ResetSnapshotAttributeAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Resets permission settings for the specified snapshot.</para> <para>For more information on modifying snapshot permissions, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-modifying-snapshot-permissions.html">Sharing Snapshots</a> in the <i>Amazon
        /// Elastic Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="resetSnapshotAttributeRequest">Container for the necessary parameters to execute the ResetSnapshotAttribute service method on
        /// AmazonEC2.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<ResetSnapshotAttributeResponse> ResetSnapshotAttributeAsync(ResetSnapshotAttributeRequest resetSnapshotAttributeRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ResetSnapshotAttributeRequestMarshaller();
            var unmarshaller = ResetSnapshotAttributeResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, ResetSnapshotAttributeRequest, ResetSnapshotAttributeResponse>(resetSnapshotAttributeRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal RevokeSecurityGroupEgressResponse RevokeSecurityGroupEgress(RevokeSecurityGroupEgressRequest request)
        {
            var task = RevokeSecurityGroupEgressAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Removes one or more egress rules from a security group for EC2-VPC. The values that you specify in the revoke request (for example,
        /// ports) must match the existing rule's values for the rule to be revoked.</para> <para>Each rule consists of the protocol and the CIDR range
        /// or source security group. For the TCP and UDP protocols, you must also specify the destination port or range of ports. For the ICMP
        /// protocol, you must also specify the ICMP type and code.</para> <para>Rule changes are propagated to instances within the security group as
        /// quickly as possible. However, a small delay might occur.</para>
        /// </summary>
        /// 
        /// <param name="revokeSecurityGroupEgressRequest">Container for the necessary parameters to execute the RevokeSecurityGroupEgress service
        /// method on AmazonEC2.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<RevokeSecurityGroupEgressResponse> RevokeSecurityGroupEgressAsync(RevokeSecurityGroupEgressRequest revokeSecurityGroupEgressRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RevokeSecurityGroupEgressRequestMarshaller();
            var unmarshaller = RevokeSecurityGroupEgressResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, RevokeSecurityGroupEgressRequest, RevokeSecurityGroupEgressResponse>(revokeSecurityGroupEgressRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal RevokeSecurityGroupIngressResponse RevokeSecurityGroupIngress(RevokeSecurityGroupIngressRequest request)
        {
            var task = RevokeSecurityGroupIngressAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Removes one or more ingress rules from a security group. The values that you specify in the revoke request (for example, ports) must
        /// match the existing rule's values for the rule to be removed.</para> <para>Each rule consists of the protocol and the CIDR range or source
        /// security group. For the TCP and UDP protocols, you must also specify the destination port or range of ports. For the ICMP protocol, you must
        /// also specify the ICMP type and code.</para> <para>Rule changes are propagated to instances within the security group as quickly as possible.
        /// However, a small delay might occur.</para>
        /// </summary>
        /// 
        /// <param name="revokeSecurityGroupIngressRequest">Container for the necessary parameters to execute the RevokeSecurityGroupIngress service
        /// method on AmazonEC2.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<RevokeSecurityGroupIngressResponse> RevokeSecurityGroupIngressAsync(RevokeSecurityGroupIngressRequest revokeSecurityGroupIngressRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RevokeSecurityGroupIngressRequestMarshaller();
            var unmarshaller = RevokeSecurityGroupIngressResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, RevokeSecurityGroupIngressRequest, RevokeSecurityGroupIngressResponse>(revokeSecurityGroupIngressRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal RunInstancesResponse RunInstances(RunInstancesRequest request)
        {
            var task = RunInstancesAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Launches the specified number of instances using an AMI for which you have permissions.</para> <para>When you launch an instance, it
        /// enters the <c>pending</c> state. After the instance is ready for you, it enters the <c>running</c> state. To check the state of your
        /// instance, call DescribeInstances.</para> <para>If you don't specify a security group when launching an instance, Amazon EC2 uses the default
        /// security group. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-network-security.html">Security
        /// Groups</a> in the <i>Amazon Elastic Compute Cloud User Guide</i> .</para> <para>Linux instances have access to the public key of the key
        /// pair at boot. You can use this key to provide secure access to the instance. Amazon EC2 public images use this feature to provide secure
        /// access without passwords. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-key-pairs.html">Key
        /// Pairs</a> in the <i>Amazon Elastic Compute Cloud User Guide</i> .</para> <para>You can provide optional user data when launching an
        /// instance. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/AESDG-chapter-instancedata.html">Instance
        /// Metadata</a> in the <i>Amazon Elastic Compute Cloud User Guide</i> .</para> <para>If any of the AMIs have a product code attached for which
        /// the user has not subscribed, <c>RunInstances</c> fails.</para>
        /// </summary>
        /// 
        /// <param name="runInstancesRequest">Container for the necessary parameters to execute the RunInstances service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the RunInstances service method, as returned by AmazonEC2.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<RunInstancesResponse> RunInstancesAsync(RunInstancesRequest runInstancesRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RunInstancesRequestMarshaller();
            var unmarshaller = RunInstancesResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, RunInstancesRequest, RunInstancesResponse>(runInstancesRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal StartInstancesResponse StartInstances(StartInstancesRequest request)
        {
            var task = StartInstancesAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Starts an Amazon EBS-backed AMI that you've previously stopped.</para> <para>Instances that use Amazon EBS volumes as their root
        /// devices can be quickly stopped and started. When an instance is stopped, the compute resources are released and you are not billed for
        /// hourly instance usage. However, your root partition Amazon EBS volume remains, continues to persist your data, and you are charged for
        /// Amazon EBS volume usage. You can restart your instance at any time. Each time you transition an instance from stopped to started, Amazon EC2
        /// charges a full instance hour, even if transitions happen multiple times within a single hour.</para> <para>Before stopping an instance, make
        /// sure it is in a state from which it can be restarted. Stopping an instance does not preserve data stored in RAM.</para> <para>Performing
        /// this operation on an instance that uses an instance store as its root device returns an error.</para> <para>For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Stop_Start.html">Stopping Instances</a> in the <i>Amazon Elastic Compute Cloud
        /// User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="startInstancesRequest">Container for the necessary parameters to execute the StartInstances service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the StartInstances service method, as returned by AmazonEC2.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<StartInstancesResponse> StartInstancesAsync(StartInstancesRequest startInstancesRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new StartInstancesRequestMarshaller();
            var unmarshaller = StartInstancesResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, StartInstancesRequest, StartInstancesResponse>(startInstancesRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal StopInstancesResponse StopInstances(StopInstancesRequest request)
        {
            var task = StopInstancesAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

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
        /// automatically deleted. For more information about the differences between stopping and terminating instances, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-instance-lifecycle.html">Instance Lifecycle</a> in the <i>Amazon Elastic
        /// Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="stopInstancesRequest">Container for the necessary parameters to execute the StopInstances service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the StopInstances service method, as returned by AmazonEC2.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<StopInstancesResponse> StopInstancesAsync(StopInstancesRequest stopInstancesRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new StopInstancesRequestMarshaller();
            var unmarshaller = StopInstancesResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, StopInstancesRequest, StopInstancesResponse>(stopInstancesRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal TerminateInstancesResponse TerminateInstances(TerminateInstancesRequest request)
        {
            var task = TerminateInstancesAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Shuts down one or more instances. This operation is idempotent; if you terminate an instance more than once, each call
        /// succeeds.</para> <para>Terminated instances remain visible after termination (for approximately one hour).</para> <para>By default, Amazon
        /// EC2 deletes all Amazon EBS volumes that were attached when the instance launched. Volumes attached after instance launch continue
        /// running.</para> <para>You can stop, start, and terminate EBS-backed instances. You can only terminate instance store-backed instances. What
        /// happens to an instance differs if you stop it or terminate it. For example, when you stop an instance, the root device and any other devices
        /// attached to the instance persist. When you terminate an instance, the root device and any other devices attached during the instance launch
        /// are automatically deleted. For more information about the differences between stopping and terminating instances, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-instance-lifecycle.html">Instance Lifecycle</a> in the <i>Amazon Elastic
        /// Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="terminateInstancesRequest">Container for the necessary parameters to execute the TerminateInstances service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the TerminateInstances service method, as returned by AmazonEC2.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<TerminateInstancesResponse> TerminateInstancesAsync(TerminateInstancesRequest terminateInstancesRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new TerminateInstancesRequestMarshaller();
            var unmarshaller = TerminateInstancesResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, TerminateInstancesRequest, TerminateInstancesResponse>(terminateInstancesRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal UnassignPrivateIpAddressesResponse UnassignPrivateIpAddresses(UnassignPrivateIpAddressesRequest request)
        {
            var task = UnassignPrivateIpAddressesAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Unassigns one or more secondary private IP addresses from a network interface.</para>
        /// </summary>
        /// 
        /// <param name="unassignPrivateIpAddressesRequest">Container for the necessary parameters to execute the UnassignPrivateIpAddresses service
        /// method on AmazonEC2.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<UnassignPrivateIpAddressesResponse> UnassignPrivateIpAddressesAsync(UnassignPrivateIpAddressesRequest unassignPrivateIpAddressesRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UnassignPrivateIpAddressesRequestMarshaller();
            var unmarshaller = UnassignPrivateIpAddressesResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, UnassignPrivateIpAddressesRequest, UnassignPrivateIpAddressesResponse>(unassignPrivateIpAddressesRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
 
		internal UnmonitorInstancesResponse UnmonitorInstances(UnmonitorInstancesRequest request)
        {
            var task = UnmonitorInstancesAsync(request);
            try
            {
                return task.Result;
            }
            catch(AggregateException e)
            {
                throw e.InnerException;
            }
        }

        /// <summary>
        /// <para>Disables monitoring for a running instance. For more information about monitoring instances, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-cloudwatch.html">Monitoring Your Instances and Volumes</a> in the <i>Amazon
        /// Elastic Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="unmonitorInstancesRequest">Container for the necessary parameters to execute the UnmonitorInstances service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the UnmonitorInstances service method, as returned by AmazonEC2.</returns>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
		public Task<UnmonitorInstancesResponse> UnmonitorInstancesAsync(UnmonitorInstancesRequest unmonitorInstancesRequest, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UnmonitorInstancesRequestMarshaller();
            var unmarshaller = UnmonitorInstancesResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, UnmonitorInstancesRequest, UnmonitorInstancesResponse>(unmonitorInstancesRequest, marshaller, unmarshaller, signer, cancellationToken);
        }
    }
}
