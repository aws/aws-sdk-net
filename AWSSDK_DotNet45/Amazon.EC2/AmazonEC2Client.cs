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

        #region Dispose

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion

        #region Constructors

        /// <summary>
        /// Constructs AmazonEC2Client with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonEC2Client()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonEC2Config(), AuthenticationTypes.User | AuthenticationTypes.Session) { }

        /// <summary>
        /// Constructs AmazonEC2Client with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonEC2Client(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonEC2Config(){RegionEndpoint = region}, AuthenticationTypes.User | AuthenticationTypes.Session) { }

        /// <summary>
        /// Constructs AmazonEC2Client with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonEC2 Configuration Object</param>
        public AmazonEC2Client(AmazonEC2Config config)
            : base(FallbackCredentialsFactory.GetCredentials(), config, AuthenticationTypes.User | AuthenticationTypes.Session) { }

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

 
        /// <summary>
        /// <para>Acquires an Elastic IP address.</para> <para>An Elastic IP address is for use either in the EC2-Classic platform or in a VPC. For more
        /// information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/elastic-ip-addresses-eip.html">Elastic IP Addresses</a> in the
        /// <i>Amazon Elastic Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AllocateAddress service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the AllocateAddress service method, as returned by AmazonEC2.</returns>
		public AllocateAddressResponse AllocateAddress(AllocateAddressRequest request)
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
        /// Initiates the asynchronous execution of the AllocateAddress operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.AllocateAddress"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AllocateAddress operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<AllocateAddressResponse> AllocateAddressAsync(AllocateAddressRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AllocateAddressRequestMarshaller();
            var unmarshaller = AllocateAddressResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, AllocateAddressRequest, AllocateAddressResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Acquires an Elastic IP address.</para> <para>An Elastic IP address is for use either in the EC2-Classic platform or in a VPC. For more
        /// information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/elastic-ip-addresses-eip.html">Elastic IP Addresses</a> in the
        /// <i>Amazon Elastic Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the AllocateAddress service method, as returned by AmazonEC2.</returns>
		public AllocateAddressResponse AllocateAddress()
        {
            return this.AllocateAddress(new AllocateAddressRequest());
        }
 
        /// <summary>
        /// <para>Assigns one or more secondary private IP addresses to the specified network interface. You can specify one or more specific secondary
        /// IP addresses, or you can specify the number of secondary IP addresses to be automatically assigned within the subnet's CIDR block range. The
        /// number of secondary IP addresses that you can assign to an instance varies by instance type. For information about instance types, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-types.html">Instance Types</a> in the <i>Amazon Elastic Compute Cloud
        /// User Guide</i> . For more information about Elastic IP addresses, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/elastic-ip-addresses-eip.html">Elastic IP Addresses</a> in the <i>Amazon Elastic
        /// Compute Cloud User Guide</i> .</para> <para>AssignPrivateIpAddresses is available only in EC2-VPC.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssignPrivateIpAddresses service method
        /// on AmazonEC2.</param>
		public AssignPrivateIpAddressesResponse AssignPrivateIpAddresses(AssignPrivateIpAddressesRequest request)
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
        /// Initiates the asynchronous execution of the AssignPrivateIpAddresses operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.AssignPrivateIpAddresses"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssignPrivateIpAddresses operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<AssignPrivateIpAddressesResponse> AssignPrivateIpAddressesAsync(AssignPrivateIpAddressesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AssignPrivateIpAddressesRequestMarshaller();
            var unmarshaller = AssignPrivateIpAddressesResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, AssignPrivateIpAddressesRequest, AssignPrivateIpAddressesResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
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
        /// <param name="request">Container for the necessary parameters to execute the AssociateAddress service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the AssociateAddress service method, as returned by AmazonEC2.</returns>
		public AssociateAddressResponse AssociateAddress(AssociateAddressRequest request)
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
        /// Initiates the asynchronous execution of the AssociateAddress operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.AssociateAddress"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateAddress operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<AssociateAddressResponse> AssociateAddressAsync(AssociateAddressRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AssociateAddressRequestMarshaller();
            var unmarshaller = AssociateAddressResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, AssociateAddressRequest, AssociateAddressResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
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
        /// <param name="request">Container for the necessary parameters to execute the AssociateDhcpOptions service method on
        /// AmazonEC2.</param>
		public AssociateDhcpOptionsResponse AssociateDhcpOptions(AssociateDhcpOptionsRequest request)
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
        /// Initiates the asynchronous execution of the AssociateDhcpOptions operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.AssociateDhcpOptions"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateDhcpOptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<AssociateDhcpOptionsResponse> AssociateDhcpOptionsAsync(AssociateDhcpOptionsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AssociateDhcpOptionsRequestMarshaller();
            var unmarshaller = AssociateDhcpOptionsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, AssociateDhcpOptionsRequest, AssociateDhcpOptionsResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Associates a subnet with a route table. The subnet and route table must be in the same VPC. This association causes traffic
        /// originating from the subnet to be routed according to the routes in the route table. The action returns an association ID, which you need in
        /// order to disassociate the route table from the subnet later. A route table can be associated with multiple subnets.</para> <para>For more
        /// information about route tables, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Route_Tables.html">Route Tables</a>
        /// in the <i>Amazon Virtual Private Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateRouteTable service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the AssociateRouteTable service method, as returned by AmazonEC2.</returns>
		public AssociateRouteTableResponse AssociateRouteTable(AssociateRouteTableRequest request)
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
        /// Initiates the asynchronous execution of the AssociateRouteTable operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.AssociateRouteTable"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateRouteTable operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<AssociateRouteTableResponse> AssociateRouteTableAsync(AssociateRouteTableRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AssociateRouteTableRequestMarshaller();
            var unmarshaller = AssociateRouteTableResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, AssociateRouteTableRequest, AssociateRouteTableResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Attaches an Internet gateway to a VPC, enabling connectivity between the Internet and the VPC. For more information about your VPC and
        /// Internet gateway, see the <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/">Amazon Virtual Private Cloud User Guide</a>
        /// .</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachInternetGateway service method on
        /// AmazonEC2.</param>
		public AttachInternetGatewayResponse AttachInternetGateway(AttachInternetGatewayRequest request)
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
        /// Initiates the asynchronous execution of the AttachInternetGateway operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.AttachInternetGateway"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachInternetGateway operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<AttachInternetGatewayResponse> AttachInternetGatewayAsync(AttachInternetGatewayRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AttachInternetGatewayRequestMarshaller();
            var unmarshaller = AttachInternetGatewayResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, AttachInternetGatewayRequest, AttachInternetGatewayResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Attaches a network interface to an instance.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachNetworkInterface service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the AttachNetworkInterface service method, as returned by AmazonEC2.</returns>
		public AttachNetworkInterfaceResponse AttachNetworkInterface(AttachNetworkInterfaceRequest request)
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
        /// Initiates the asynchronous execution of the AttachNetworkInterface operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.AttachNetworkInterface"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachNetworkInterface operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<AttachNetworkInterfaceResponse> AttachNetworkInterfaceAsync(AttachNetworkInterfaceRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AttachNetworkInterfaceRequestMarshaller();
            var unmarshaller = AttachNetworkInterfaceResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, AttachNetworkInterfaceRequest, AttachNetworkInterfaceResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
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
        /// <param name="request">Container for the necessary parameters to execute the AttachVolume service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the AttachVolume service method, as returned by AmazonEC2.</returns>
		public AttachVolumeResponse AttachVolume(AttachVolumeRequest request)
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
        /// Initiates the asynchronous execution of the AttachVolume operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.AttachVolume"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachVolume operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<AttachVolumeResponse> AttachVolumeAsync(AttachVolumeRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AttachVolumeRequestMarshaller();
            var unmarshaller = AttachVolumeResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, AttachVolumeRequest, AttachVolumeResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Attaches a virtual private gateway to a VPC. For more information, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_VPN.html">Adding a Hardware Virtual Private Gateway to Your VPC</a> in the
        /// <i>Amazon Virtual Private Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachVpnGateway service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the AttachVpnGateway service method, as returned by AmazonEC2.</returns>
		public AttachVpnGatewayResponse AttachVpnGateway(AttachVpnGatewayRequest request)
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
        /// Initiates the asynchronous execution of the AttachVpnGateway operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.AttachVpnGateway"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachVpnGateway operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<AttachVpnGatewayResponse> AttachVpnGatewayAsync(AttachVpnGatewayRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AttachVpnGatewayRequestMarshaller();
            var unmarshaller = AttachVpnGatewayResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, AttachVpnGatewayRequest, AttachVpnGatewayResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
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
        /// <param name="request">Container for the necessary parameters to execute the AuthorizeSecurityGroupEgress service
        /// method on AmazonEC2.</param>
		public AuthorizeSecurityGroupEgressResponse AuthorizeSecurityGroupEgress(AuthorizeSecurityGroupEgressRequest request)
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
        /// Initiates the asynchronous execution of the AuthorizeSecurityGroupEgress operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.AuthorizeSecurityGroupEgress"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AuthorizeSecurityGroupEgress operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<AuthorizeSecurityGroupEgressResponse> AuthorizeSecurityGroupEgressAsync(AuthorizeSecurityGroupEgressRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AuthorizeSecurityGroupEgressRequestMarshaller();
            var unmarshaller = AuthorizeSecurityGroupEgressResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, AuthorizeSecurityGroupEgressRequest, AuthorizeSecurityGroupEgressResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
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
        /// <param name="request">Container for the necessary parameters to execute the AuthorizeSecurityGroupIngress
        /// service method on AmazonEC2.</param>
		public AuthorizeSecurityGroupIngressResponse AuthorizeSecurityGroupIngress(AuthorizeSecurityGroupIngressRequest request)
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
        /// Initiates the asynchronous execution of the AuthorizeSecurityGroupIngress operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.AuthorizeSecurityGroupIngress"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AuthorizeSecurityGroupIngress operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<AuthorizeSecurityGroupIngressResponse> AuthorizeSecurityGroupIngressAsync(AuthorizeSecurityGroupIngressRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AuthorizeSecurityGroupIngressRequestMarshaller();
            var unmarshaller = AuthorizeSecurityGroupIngressResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, AuthorizeSecurityGroupIngressRequest, AuthorizeSecurityGroupIngressResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Bundles an Amazon instance store-backed Windows instance.</para> <para>During bundling, only the root device volume (C:\) is bundled.
        /// Data on other instance store volumes is not preserved.</para> <para><b>NOTE:</b> This procedure is not applicable for Linux/Unix instances
        /// or Windows instances that are backed by Amazon EBS. </para> <para>For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/WindowsGuide/Creating_InstanceStoreBacked_WinAMI.html">Creating an Instance Store-Backed
        /// Windows AMI</a> .</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BundleInstance service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the BundleInstance service method, as returned by AmazonEC2.</returns>
		public BundleInstanceResponse BundleInstance(BundleInstanceRequest request)
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
        /// Initiates the asynchronous execution of the BundleInstance operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.BundleInstance"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BundleInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<BundleInstanceResponse> BundleInstanceAsync(BundleInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new BundleInstanceRequestMarshaller();
            var unmarshaller = BundleInstanceResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, BundleInstanceRequest, BundleInstanceResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Cancels a bundling operation for an instance store-backed Windows instance.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelBundleTask service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the CancelBundleTask service method, as returned by AmazonEC2.</returns>
		public CancelBundleTaskResponse CancelBundleTask(CancelBundleTaskRequest request)
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
        /// Initiates the asynchronous execution of the CancelBundleTask operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CancelBundleTask"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelBundleTask operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<CancelBundleTaskResponse> CancelBundleTaskAsync(CancelBundleTaskRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CancelBundleTaskRequestMarshaller();
            var unmarshaller = CancelBundleTaskResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CancelBundleTaskRequest, CancelBundleTaskResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Cancels an active conversion task. The task can be the import of an instance or volume. The action removes all artifacts of the
        /// conversion, including a partially uploaded volume or instance. If the conversion is complete or is in the process of transferring the final
        /// disk image, the command fails and returns an exception.</para> <para>For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/UploadingYourInstancesandVolumes.html">Using the Command Line Tools to Import Your
        /// Virtual Machine to Amazon EC2</a> in the <i>Amazon Elastic Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelConversionTask service method on
        /// AmazonEC2.</param>
		public CancelConversionTaskResponse CancelConversionTask(CancelConversionTaskRequest request)
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
        /// Initiates the asynchronous execution of the CancelConversionTask operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CancelConversionTask"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelConversionTask operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<CancelConversionTaskResponse> CancelConversionTaskAsync(CancelConversionTaskRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CancelConversionTaskRequestMarshaller();
            var unmarshaller = CancelConversionTaskResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CancelConversionTaskRequest, CancelConversionTaskResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Cancels an active export task. The request removes all artifacts of the export, including any partially-created Amazon S3 objects. If
        /// the export task is complete or is in the process of transferring the final disk image, the command fails and returns an error.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelExportTask service method on
        /// AmazonEC2.</param>
		public CancelExportTaskResponse CancelExportTask(CancelExportTaskRequest request)
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
        /// Initiates the asynchronous execution of the CancelExportTask operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CancelExportTask"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelExportTask operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<CancelExportTaskResponse> CancelExportTaskAsync(CancelExportTaskRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CancelExportTaskRequestMarshaller();
            var unmarshaller = CancelExportTaskResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CancelExportTaskRequest, CancelExportTaskResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Cancels the specified Reserved Instance listing in the Reserved Instance Marketplace.</para> <para>For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ri-market-general.html">Reserved Instance Marketplace</a> in the <i>Amazon Elastic
        /// Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelReservedInstancesListing
        /// service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the CancelReservedInstancesListing service method, as returned by AmazonEC2.</returns>
		public CancelReservedInstancesListingResponse CancelReservedInstancesListing(CancelReservedInstancesListingRequest request)
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
        /// Initiates the asynchronous execution of the CancelReservedInstancesListing operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CancelReservedInstancesListing"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelReservedInstancesListing operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<CancelReservedInstancesListingResponse> CancelReservedInstancesListingAsync(CancelReservedInstancesListingRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CancelReservedInstancesListingRequestMarshaller();
            var unmarshaller = CancelReservedInstancesListingResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CancelReservedInstancesListingRequest, CancelReservedInstancesListingResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Cancels one or more Spot Instance requests. Spot Instances are instances that Amazon EC2 starts on your behalf when the maximum price
        /// that you specify exceeds the current Spot Price. Amazon EC2 periodically sets the Spot Price based on available Spot Instance capacity and
        /// current Spot Instance requests. For more information about Spot Instances, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-spot-instances.html">Spot Instances</a> in the <i>Amazon Elastic Compute
        /// Cloud User Guide</i> .</para> <para><b>IMPORTANT:</b> Canceling a Spot Instance request does not terminate running Spot Instances associated
        /// with the request. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelSpotInstanceRequests service
        /// method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the CancelSpotInstanceRequests service method, as returned by AmazonEC2.</returns>
		public CancelSpotInstanceRequestsResponse CancelSpotInstanceRequests(CancelSpotInstanceRequestsRequest request)
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
        /// Initiates the asynchronous execution of the CancelSpotInstanceRequests operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CancelSpotInstanceRequests"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelSpotInstanceRequests operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<CancelSpotInstanceRequestsResponse> CancelSpotInstanceRequestsAsync(CancelSpotInstanceRequestsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CancelSpotInstanceRequestsRequestMarshaller();
            var unmarshaller = CancelSpotInstanceRequestsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CancelSpotInstanceRequestsRequest, CancelSpotInstanceRequestsResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Determines whether a product code is associated with an instance. This action can only be used by the owner of the product code. It is
        /// useful when a product code owner needs to verify whether another user's instance is eligible for support.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ConfirmProductInstance service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the ConfirmProductInstance service method, as returned by AmazonEC2.</returns>
		public ConfirmProductInstanceResponse ConfirmProductInstance(ConfirmProductInstanceRequest request)
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
        /// Initiates the asynchronous execution of the ConfirmProductInstance operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ConfirmProductInstance"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ConfirmProductInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<ConfirmProductInstanceResponse> ConfirmProductInstanceAsync(ConfirmProductInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ConfirmProductInstanceRequestMarshaller();
            var unmarshaller = ConfirmProductInstanceResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, ConfirmProductInstanceRequest, ConfirmProductInstanceResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Initiates the copy of an AMI from the specified source region to the region in which the request was made.</para> <para>For more
        /// information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/CopyingAMIs.html">Copying AMIs</a> in the <i>Amazon Elastic
        /// Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopyImage service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the CopyImage service method, as returned by AmazonEC2.</returns>
		public CopyImageResponse CopyImage(CopyImageRequest request)
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
        /// Initiates the asynchronous execution of the CopyImage operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CopyImage"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopyImage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<CopyImageResponse> CopyImageAsync(CopyImageRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CopyImageRequestMarshaller();
            var unmarshaller = CopyImageResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CopyImageRequest, CopyImageResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Copies a point-in-time snapshot of an Amazon EBS volume and stores it in Amazon S3. You can copy the snapshot within the same region
        /// or from one region to another. You can use the snapshot to create Amazon EBS volumes or Amazon Machine Images (AMIs).</para> <para>For more
        /// information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-copy-snapshot.html">Copying an Amazon EBS Snapshot</a> in
        /// the <i>Amazon Elastic Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopySnapshot service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the CopySnapshot service method, as returned by AmazonEC2.</returns>
		public CopySnapshotResponse CopySnapshot(CopySnapshotRequest request)
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
        /// Initiates the asynchronous execution of the CopySnapshot operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CopySnapshot"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopySnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<CopySnapshotResponse> CopySnapshotAsync(CopySnapshotRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CopySnapshotRequestMarshaller();
            var unmarshaller = CopySnapshotResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CopySnapshotRequest, CopySnapshotResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
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
        /// <param name="request">Container for the necessary parameters to execute the CreateCustomerGateway service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the CreateCustomerGateway service method, as returned by AmazonEC2.</returns>
		public CreateCustomerGatewayResponse CreateCustomerGateway(CreateCustomerGatewayRequest request)
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
        /// Initiates the asynchronous execution of the CreateCustomerGateway operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateCustomerGateway"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCustomerGateway operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<CreateCustomerGatewayResponse> CreateCustomerGatewayAsync(CreateCustomerGatewayRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateCustomerGatewayRequestMarshaller();
            var unmarshaller = CreateCustomerGatewayResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CreateCustomerGatewayRequest, CreateCustomerGatewayResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Creates a set of DHCP options for your VPC. After creating the set, you must associate it with the VPC, causing all existing and new
        /// instances that you launch in the VPC to use this set of DHCP options. The following are the individual DHCP options you can specify. For
        /// more information about the options, see <a href="http://www.ietf.org/rfc/rfc2132.txt">RFC 2132</a> .</para> <para>For more information
        /// about DHCP options, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_DHCP_Options.html">DHCP Options Sets</a> in the
        /// <i>Amazon Virtual Private Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDhcpOptions service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the CreateDhcpOptions service method, as returned by AmazonEC2.</returns>
		public CreateDhcpOptionsResponse CreateDhcpOptions(CreateDhcpOptionsRequest request)
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
        /// Initiates the asynchronous execution of the CreateDhcpOptions operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateDhcpOptions"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDhcpOptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<CreateDhcpOptionsResponse> CreateDhcpOptionsAsync(CreateDhcpOptionsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateDhcpOptionsRequestMarshaller();
            var unmarshaller = CreateDhcpOptionsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CreateDhcpOptionsRequest, CreateDhcpOptionsResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Creates an Amazon EBS-backed AMI from an Amazon EBS-backed instance that is either running or stopped.</para> <para>If you customized
        /// your instance with instance store volumes or EBS volumes in addition to the root device volume, the new AMI contains block device mapping
        /// information for those volumes. When you launch an instance from this new AMI, the instance automatically launches with those additional
        /// volumes.</para> <para>For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/creating-an-ami-ebs.html">Creating Amazon EBS-Backed Linux AMIs</a> in the <i>Amazon Elastic Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateImage service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the CreateImage service method, as returned by AmazonEC2.</returns>
		public CreateImageResponse CreateImage(CreateImageRequest request)
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
        /// Initiates the asynchronous execution of the CreateImage operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateImage"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateImage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<CreateImageResponse> CreateImageAsync(CreateImageRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateImageRequestMarshaller();
            var unmarshaller = CreateImageResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CreateImageRequest, CreateImageResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Exports a running or stopped instance to an Amazon S3 bucket.</para> <para>For information about the supported operating systems,
        /// image formats, and known limitations for the types of instances you can export, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ExportingEC2Instances.html">Exporting EC2 Instances</a> in the <i>Amazon Elastic
        /// Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateInstanceExportTask service method
        /// on AmazonEC2.</param>
        /// 
        /// <returns>The response from the CreateInstanceExportTask service method, as returned by AmazonEC2.</returns>
		public CreateInstanceExportTaskResponse CreateInstanceExportTask(CreateInstanceExportTaskRequest request)
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
        /// Initiates the asynchronous execution of the CreateInstanceExportTask operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateInstanceExportTask"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateInstanceExportTask operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<CreateInstanceExportTaskResponse> CreateInstanceExportTaskAsync(CreateInstanceExportTaskRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateInstanceExportTaskRequestMarshaller();
            var unmarshaller = CreateInstanceExportTaskResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CreateInstanceExportTaskRequest, CreateInstanceExportTaskResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Creates an Internet gateway for use with a VPC. After creating the Internet gateway, you attach it to a VPC using
        /// AttachInternetGateway.</para> <para>For more information about your VPC and Internet gateway, see the <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/">Amazon Virtual Private Cloud User Guide</a> .</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateInternetGateway service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the CreateInternetGateway service method, as returned by AmazonEC2.</returns>
		public CreateInternetGatewayResponse CreateInternetGateway(CreateInternetGatewayRequest request)
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
        /// Initiates the asynchronous execution of the CreateInternetGateway operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateInternetGateway"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateInternetGateway operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<CreateInternetGatewayResponse> CreateInternetGatewayAsync(CreateInternetGatewayRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateInternetGatewayRequestMarshaller();
            var unmarshaller = CreateInternetGatewayResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CreateInternetGatewayRequest, CreateInternetGatewayResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Creates an Internet gateway for use with a VPC. After creating the Internet gateway, you attach it to a VPC using
        /// AttachInternetGateway.</para> <para>For more information about your VPC and Internet gateway, see the <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/">Amazon Virtual Private Cloud User Guide</a> .</para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the CreateInternetGateway service method, as returned by AmazonEC2.</returns>
		public CreateInternetGatewayResponse CreateInternetGateway()
        {
            return this.CreateInternetGateway(new CreateInternetGatewayRequest());
        }
 
        /// <summary>
        /// <para>Creates a 2048-bit RSA key pair with the specified name. Amazon EC2 stores the public key and displays the private key for you to save
        /// to a file. The private key is returned as an unencrypted PEM encoded PKCS#8 private key. If a key with the specified name already exists,
        /// Amazon EC2 returns an error.</para> <para>You can have up to five thousand key pairs per region.</para> <para>For more information about key
        /// pairs, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-key-pairs.html">Key Pairs</a> in the <i>Amazon Elastic Compute
        /// Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateKeyPair service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the CreateKeyPair service method, as returned by AmazonEC2.</returns>
		public CreateKeyPairResponse CreateKeyPair(CreateKeyPairRequest request)
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
        /// Initiates the asynchronous execution of the CreateKeyPair operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateKeyPair"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateKeyPair operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<CreateKeyPairResponse> CreateKeyPairAsync(CreateKeyPairRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateKeyPairRequestMarshaller();
            var unmarshaller = CreateKeyPairResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CreateKeyPairRequest, CreateKeyPairResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Creates a network ACL in a VPC. Network ACLs provide an optional layer of security (in addition to security groups) for the instances
        /// in your VPC.</para> <para>For more information about network ACLs, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_ACLs.html">Network ACLs</a> in the <i>Amazon Virtual Private Cloud User
        /// Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateNetworkAcl service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the CreateNetworkAcl service method, as returned by AmazonEC2.</returns>
		public CreateNetworkAclResponse CreateNetworkAcl(CreateNetworkAclRequest request)
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
        /// Initiates the asynchronous execution of the CreateNetworkAcl operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateNetworkAcl"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateNetworkAcl operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<CreateNetworkAclResponse> CreateNetworkAclAsync(CreateNetworkAclRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateNetworkAclRequestMarshaller();
            var unmarshaller = CreateNetworkAclResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CreateNetworkAclRequest, CreateNetworkAclResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
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
        /// <param name="request">Container for the necessary parameters to execute the CreateNetworkAclEntry service method on
        /// AmazonEC2.</param>
		public CreateNetworkAclEntryResponse CreateNetworkAclEntry(CreateNetworkAclEntryRequest request)
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
        /// Initiates the asynchronous execution of the CreateNetworkAclEntry operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateNetworkAclEntry"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateNetworkAclEntry operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<CreateNetworkAclEntryResponse> CreateNetworkAclEntryAsync(CreateNetworkAclEntryRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateNetworkAclEntryRequestMarshaller();
            var unmarshaller = CreateNetworkAclEntryResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CreateNetworkAclEntryRequest, CreateNetworkAclEntryResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Creates a network interface in the specified subnet.</para> <para>For more information about network interfaces, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-eni.html">Elastic Network Interfaces</a> in the <i>Amazon Elastic Compute
        /// Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateNetworkInterface service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the CreateNetworkInterface service method, as returned by AmazonEC2.</returns>
		public CreateNetworkInterfaceResponse CreateNetworkInterface(CreateNetworkInterfaceRequest request)
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
        /// Initiates the asynchronous execution of the CreateNetworkInterface operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateNetworkInterface"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateNetworkInterface operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<CreateNetworkInterfaceResponse> CreateNetworkInterfaceAsync(CreateNetworkInterfaceRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateNetworkInterfaceRequestMarshaller();
            var unmarshaller = CreateNetworkInterfaceResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CreateNetworkInterfaceRequest, CreateNetworkInterfaceResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Creates a placement group that you launch cluster instances into. You must give the group a name that's unique within the scope of
        /// your account.</para> <para>For more information about placement groups and cluster instances, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using_cluster_computing.html">Cluster Instances</a> in the <i>Amazon Elastic
        /// Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePlacementGroup service method on
        /// AmazonEC2.</param>
		public CreatePlacementGroupResponse CreatePlacementGroup(CreatePlacementGroupRequest request)
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
        /// Initiates the asynchronous execution of the CreatePlacementGroup operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreatePlacementGroup"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePlacementGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<CreatePlacementGroupResponse> CreatePlacementGroupAsync(CreatePlacementGroupRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreatePlacementGroupRequestMarshaller();
            var unmarshaller = CreatePlacementGroupResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CreatePlacementGroupRequest, CreatePlacementGroupResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Creates a listing for Amazon EC2 Reserved Instances to be sold in the Reserved Instance Marketplace. You can submit one Reserved
        /// Instance listing at a time.</para> <para>For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ri-market-general.html">Reserved Instance Marketplace</a> in the <i>Amazon Elastic
        /// Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateReservedInstancesListing
        /// service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the CreateReservedInstancesListing service method, as returned by AmazonEC2.</returns>
		public CreateReservedInstancesListingResponse CreateReservedInstancesListing(CreateReservedInstancesListingRequest request)
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
        /// Initiates the asynchronous execution of the CreateReservedInstancesListing operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateReservedInstancesListing"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateReservedInstancesListing operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<CreateReservedInstancesListingResponse> CreateReservedInstancesListingAsync(CreateReservedInstancesListingRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateReservedInstancesListingRequestMarshaller();
            var unmarshaller = CreateReservedInstancesListingResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CreateReservedInstancesListingRequest, CreateReservedInstancesListingResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
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
        /// <param name="request">Container for the necessary parameters to execute the CreateRoute service method on AmazonEC2.</param>
		public CreateRouteResponse CreateRoute(CreateRouteRequest request)
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
        /// Initiates the asynchronous execution of the CreateRoute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateRoute"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRoute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<CreateRouteResponse> CreateRouteAsync(CreateRouteRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateRouteRequestMarshaller();
            var unmarshaller = CreateRouteResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CreateRouteRequest, CreateRouteResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Creates a route table for the specified VPC. After you create a route table, you can add routes and associate the table with a
        /// subnet.</para> <para>For more information about route tables, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Route_Tables.html">Route Tables</a> in the <i>Amazon Virtual Private Cloud
        /// User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRouteTable service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the CreateRouteTable service method, as returned by AmazonEC2.</returns>
		public CreateRouteTableResponse CreateRouteTable(CreateRouteTableRequest request)
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
        /// Initiates the asynchronous execution of the CreateRouteTable operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateRouteTable"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRouteTable operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<CreateRouteTableResponse> CreateRouteTableAsync(CreateRouteTableRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateRouteTableRequestMarshaller();
            var unmarshaller = CreateRouteTableResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CreateRouteTableRequest, CreateRouteTableResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
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
        /// <param name="request">Container for the necessary parameters to execute the CreateSecurityGroup service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the CreateSecurityGroup service method, as returned by AmazonEC2.</returns>
		public CreateSecurityGroupResponse CreateSecurityGroup(CreateSecurityGroupRequest request)
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
        /// Initiates the asynchronous execution of the CreateSecurityGroup operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateSecurityGroup"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSecurityGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<CreateSecurityGroupResponse> CreateSecurityGroupAsync(CreateSecurityGroupRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateSecurityGroupRequestMarshaller();
            var unmarshaller = CreateSecurityGroupResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CreateSecurityGroupRequest, CreateSecurityGroupResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
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
        /// <param name="request">Container for the necessary parameters to execute the CreateSnapshot service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the CreateSnapshot service method, as returned by AmazonEC2.</returns>
		public CreateSnapshotResponse CreateSnapshot(CreateSnapshotRequest request)
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
        /// Initiates the asynchronous execution of the CreateSnapshot operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateSnapshot"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<CreateSnapshotResponse> CreateSnapshotAsync(CreateSnapshotRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateSnapshotRequestMarshaller();
            var unmarshaller = CreateSnapshotResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CreateSnapshotRequest, CreateSnapshotResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Creates a datafeed for Spot Instances, enabling you to view Spot Instance usage logs. You can create one data feed per AWS account.
        /// For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-spot-instances.html">Spot Instances</a> in the
        /// <i>Amazon Elastic Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSpotDatafeedSubscription
        /// service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the CreateSpotDatafeedSubscription service method, as returned by AmazonEC2.</returns>
		public CreateSpotDatafeedSubscriptionResponse CreateSpotDatafeedSubscription(CreateSpotDatafeedSubscriptionRequest request)
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
        /// Initiates the asynchronous execution of the CreateSpotDatafeedSubscription operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateSpotDatafeedSubscription"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSpotDatafeedSubscription operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<CreateSpotDatafeedSubscriptionResponse> CreateSpotDatafeedSubscriptionAsync(CreateSpotDatafeedSubscriptionRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateSpotDatafeedSubscriptionRequestMarshaller();
            var unmarshaller = CreateSpotDatafeedSubscriptionResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CreateSpotDatafeedSubscriptionRequest, CreateSpotDatafeedSubscriptionResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
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
        /// <param name="request">Container for the necessary parameters to execute the CreateSubnet service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the CreateSubnet service method, as returned by AmazonEC2.</returns>
		public CreateSubnetResponse CreateSubnet(CreateSubnetRequest request)
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
        /// Initiates the asynchronous execution of the CreateSubnet operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateSubnet"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSubnet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<CreateSubnetResponse> CreateSubnetAsync(CreateSubnetRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateSubnetRequestMarshaller();
            var unmarshaller = CreateSubnetResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CreateSubnetRequest, CreateSubnetResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Adds or overwrites one or more tags for the specified EC2 resource or resources. Each resource can have a maximum of 10 tags. Each tag
        /// consists of a key and optional value. Tag keys must be unique per resource.</para> <para>For more information about tags, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_Tags.html">Tagging Your Resources</a> in the <i>Amazon Elastic Compute Cloud
        /// User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTags service method on AmazonEC2.</param>
		public CreateTagsResponse CreateTags(CreateTagsRequest request)
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
        /// Initiates the asynchronous execution of the CreateTags operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateTags"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<CreateTagsResponse> CreateTagsAsync(CreateTagsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateTagsRequestMarshaller();
            var unmarshaller = CreateTagsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CreateTagsRequest, CreateTagsResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Creates an Amazon EBS volume that can be attached to any instance in the same Availability Zone.</para> <para>Any AWS Marketplace
        /// product codes from the snapshot are propagated to the volume.</para> <para>For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-creating-volume.html">Creating or Restoring an Amazon EBS Volume</a> in the
        /// <i>Amazon Elastic Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVolume service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the CreateVolume service method, as returned by AmazonEC2.</returns>
		public CreateVolumeResponse CreateVolume(CreateVolumeRequest request)
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
        /// Initiates the asynchronous execution of the CreateVolume operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateVolume"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVolume operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<CreateVolumeResponse> CreateVolumeAsync(CreateVolumeRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateVolumeRequestMarshaller();
            var unmarshaller = CreateVolumeResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CreateVolumeRequest, CreateVolumeResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Creates a VPC with the specified CIDR block.</para> <para>The smallest VPC you can create uses a /28 netmask (16 IP addresses), and
        /// the largest uses a /16 netmask (65,536 IP addresses). To help you decide how big to make your VPC, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Subnets.html">Your VPC and Subnets</a> in the <i>Amazon Virtual Private
        /// Cloud User Guide</i> .</para> <para>By default, each instance you launch in the VPC has the default DHCP options, which includes only a
        /// default DNS server that we provide (AmazonProvidedDNS). For more information about DHCP options, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_DHCP_Options.html">DHCP Options Sets</a> in the <i>Amazon Virtual Private
        /// Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVpc service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the CreateVpc service method, as returned by AmazonEC2.</returns>
		public CreateVpcResponse CreateVpc(CreateVpcRequest request)
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
        /// Initiates the asynchronous execution of the CreateVpc operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateVpc"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVpc operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<CreateVpcResponse> CreateVpcAsync(CreateVpcRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateVpcRequestMarshaller();
            var unmarshaller = CreateVpcResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CreateVpcRequest, CreateVpcResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
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
        /// <param name="request">Container for the necessary parameters to execute the CreateVpnConnection service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the CreateVpnConnection service method, as returned by AmazonEC2.</returns>
		public CreateVpnConnectionResponse CreateVpnConnection(CreateVpnConnectionRequest request)
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
        /// Initiates the asynchronous execution of the CreateVpnConnection operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateVpnConnection"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVpnConnection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<CreateVpnConnectionResponse> CreateVpnConnectionAsync(CreateVpnConnectionRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateVpnConnectionRequestMarshaller();
            var unmarshaller = CreateVpnConnectionResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CreateVpnConnectionRequest, CreateVpnConnectionResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Creates a static route associated with a VPN connection between an existing virtual private gateway and a VPN customer gateway. The
        /// static route allows traffic to be routed from the virtual private gateway to the VPN customer gateway.</para> <para>For more information
        /// about VPN connections, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_VPN.html">Adding a Hardware Virtual Private
        /// Gateway to Your VPC</a> in the <i>Amazon Virtual Private Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVpnConnectionRoute service method
        /// on AmazonEC2.</param>
		public CreateVpnConnectionRouteResponse CreateVpnConnectionRoute(CreateVpnConnectionRouteRequest request)
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
        /// Initiates the asynchronous execution of the CreateVpnConnectionRoute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateVpnConnectionRoute"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVpnConnectionRoute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<CreateVpnConnectionRouteResponse> CreateVpnConnectionRouteAsync(CreateVpnConnectionRouteRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateVpnConnectionRouteRequestMarshaller();
            var unmarshaller = CreateVpnConnectionRouteResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CreateVpnConnectionRouteRequest, CreateVpnConnectionRouteResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Creates a virtual private gateway. A virtual private gateway is the endpoint on the VPC side of your VPN connection. You can create a
        /// virtual private gateway before creating the VPC itself.</para> <para>For more information about virtual private gateways, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_VPN.html">Adding a Hardware Virtual Private Gateway to Your VPC</a> in the
        /// <i>Amazon Virtual Private Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVpnGateway service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the CreateVpnGateway service method, as returned by AmazonEC2.</returns>
		public CreateVpnGatewayResponse CreateVpnGateway(CreateVpnGatewayRequest request)
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
        /// Initiates the asynchronous execution of the CreateVpnGateway operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateVpnGateway"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVpnGateway operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<CreateVpnGatewayResponse> CreateVpnGatewayAsync(CreateVpnGatewayRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateVpnGatewayRequestMarshaller();
            var unmarshaller = CreateVpnGatewayResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, CreateVpnGatewayRequest, CreateVpnGatewayResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Deletes the specified customer gateway. You must delete the VPN connection before you can delete the customer gateway.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCustomerGateway service method on
        /// AmazonEC2.</param>
		public DeleteCustomerGatewayResponse DeleteCustomerGateway(DeleteCustomerGatewayRequest request)
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
        /// Initiates the asynchronous execution of the DeleteCustomerGateway operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteCustomerGateway"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCustomerGateway operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DeleteCustomerGatewayResponse> DeleteCustomerGatewayAsync(DeleteCustomerGatewayRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteCustomerGatewayRequestMarshaller();
            var unmarshaller = DeleteCustomerGatewayResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DeleteCustomerGatewayRequest, DeleteCustomerGatewayResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Deletes the specified set of DHCP options. You must disassociate the set of DHCP options before you can delete it. You can
        /// disassociate the set of DHCP options by associating either a new set of options or the default set of options with the VPC.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDhcpOptions service method on
        /// AmazonEC2.</param>
		public DeleteDhcpOptionsResponse DeleteDhcpOptions(DeleteDhcpOptionsRequest request)
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
        /// Initiates the asynchronous execution of the DeleteDhcpOptions operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteDhcpOptions"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDhcpOptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DeleteDhcpOptionsResponse> DeleteDhcpOptionsAsync(DeleteDhcpOptionsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteDhcpOptionsRequestMarshaller();
            var unmarshaller = DeleteDhcpOptionsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DeleteDhcpOptionsRequest, DeleteDhcpOptionsResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Deletes the specified Internet gateway. You must detach the Internet gateway from the VPC before you can delete it.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteInternetGateway service method on
        /// AmazonEC2.</param>
		public DeleteInternetGatewayResponse DeleteInternetGateway(DeleteInternetGatewayRequest request)
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
        /// Initiates the asynchronous execution of the DeleteInternetGateway operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteInternetGateway"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteInternetGateway operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DeleteInternetGatewayResponse> DeleteInternetGatewayAsync(DeleteInternetGatewayRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteInternetGatewayRequestMarshaller();
            var unmarshaller = DeleteInternetGatewayResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DeleteInternetGatewayRequest, DeleteInternetGatewayResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Deletes the specified key pair, by removing the public key from Amazon EC2.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteKeyPair service method on AmazonEC2.</param>
		public DeleteKeyPairResponse DeleteKeyPair(DeleteKeyPairRequest request)
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
        /// Initiates the asynchronous execution of the DeleteKeyPair operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteKeyPair"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteKeyPair operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DeleteKeyPairResponse> DeleteKeyPairAsync(DeleteKeyPairRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteKeyPairRequestMarshaller();
            var unmarshaller = DeleteKeyPairResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DeleteKeyPairRequest, DeleteKeyPairResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Deletes the specified network ACL. You can't delete the ACL if it's associated with any subnets. You can't delete the default network
        /// ACL.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteNetworkAcl service method on
        /// AmazonEC2.</param>
		public DeleteNetworkAclResponse DeleteNetworkAcl(DeleteNetworkAclRequest request)
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
        /// Initiates the asynchronous execution of the DeleteNetworkAcl operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteNetworkAcl"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteNetworkAcl operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DeleteNetworkAclResponse> DeleteNetworkAclAsync(DeleteNetworkAclRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteNetworkAclRequestMarshaller();
            var unmarshaller = DeleteNetworkAclResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DeleteNetworkAclRequest, DeleteNetworkAclResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Deletes the specified ingress or egress entry (rule) from the specified network ACL.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteNetworkAclEntry service method on
        /// AmazonEC2.</param>
		public DeleteNetworkAclEntryResponse DeleteNetworkAclEntry(DeleteNetworkAclEntryRequest request)
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
        /// Initiates the asynchronous execution of the DeleteNetworkAclEntry operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteNetworkAclEntry"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteNetworkAclEntry operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DeleteNetworkAclEntryResponse> DeleteNetworkAclEntryAsync(DeleteNetworkAclEntryRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteNetworkAclEntryRequestMarshaller();
            var unmarshaller = DeleteNetworkAclEntryResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DeleteNetworkAclEntryRequest, DeleteNetworkAclEntryResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Deletes the specified network interface. You must detach the network interface before you can delete it.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteNetworkInterface service method on
        /// AmazonEC2.</param>
		public DeleteNetworkInterfaceResponse DeleteNetworkInterface(DeleteNetworkInterfaceRequest request)
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
        /// Initiates the asynchronous execution of the DeleteNetworkInterface operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteNetworkInterface"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteNetworkInterface operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DeleteNetworkInterfaceResponse> DeleteNetworkInterfaceAsync(DeleteNetworkInterfaceRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteNetworkInterfaceRequestMarshaller();
            var unmarshaller = DeleteNetworkInterfaceResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DeleteNetworkInterfaceRequest, DeleteNetworkInterfaceResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Deletes the specified placement group. You must terminate all instances in the placement group before you can delete the placement
        /// group. For more information about placement groups and cluster instances, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using_cluster_computing.html">Cluster Instances</a> in the <i>Amazon Elastic
        /// Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePlacementGroup service method on
        /// AmazonEC2.</param>
		public DeletePlacementGroupResponse DeletePlacementGroup(DeletePlacementGroupRequest request)
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
        /// Initiates the asynchronous execution of the DeletePlacementGroup operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeletePlacementGroup"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePlacementGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DeletePlacementGroupResponse> DeletePlacementGroupAsync(DeletePlacementGroupRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeletePlacementGroupRequestMarshaller();
            var unmarshaller = DeletePlacementGroupResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DeletePlacementGroupRequest, DeletePlacementGroupResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Deletes the specified route from the specified route table.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRoute service method on AmazonEC2.</param>
		public DeleteRouteResponse DeleteRoute(DeleteRouteRequest request)
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
        /// Initiates the asynchronous execution of the DeleteRoute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteRoute"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRoute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DeleteRouteResponse> DeleteRouteAsync(DeleteRouteRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteRouteRequestMarshaller();
            var unmarshaller = DeleteRouteResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DeleteRouteRequest, DeleteRouteResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Deletes the specified route table. You must disassociate the route table from any subnets before you can delete it. You can't delete
        /// the main route table.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRouteTable service method on
        /// AmazonEC2.</param>
		public DeleteRouteTableResponse DeleteRouteTable(DeleteRouteTableRequest request)
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
        /// Initiates the asynchronous execution of the DeleteRouteTable operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteRouteTable"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRouteTable operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DeleteRouteTableResponse> DeleteRouteTableAsync(DeleteRouteTableRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteRouteTableRequestMarshaller();
            var unmarshaller = DeleteRouteTableResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DeleteRouteTableRequest, DeleteRouteTableResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Deletes a security group.</para> <para>If you attempt to delete a security group that is associated with an instance, or is referenced
        /// by another security group, the operation fails with <c>InvalidGroup.InUse</c> in EC2-Classic or <c>DependencyViolation</c> in
        /// EC2-VPC.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSecurityGroup service method on
        /// AmazonEC2.</param>
		public DeleteSecurityGroupResponse DeleteSecurityGroup(DeleteSecurityGroupRequest request)
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
        /// Initiates the asynchronous execution of the DeleteSecurityGroup operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteSecurityGroup"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSecurityGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DeleteSecurityGroupResponse> DeleteSecurityGroupAsync(DeleteSecurityGroupRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteSecurityGroupRequestMarshaller();
            var unmarshaller = DeleteSecurityGroupResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DeleteSecurityGroupRequest, DeleteSecurityGroupResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
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
        /// <param name="request">Container for the necessary parameters to execute the DeleteSnapshot service method on
        /// AmazonEC2.</param>
		public DeleteSnapshotResponse DeleteSnapshot(DeleteSnapshotRequest request)
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
        /// Initiates the asynchronous execution of the DeleteSnapshot operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteSnapshot"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DeleteSnapshotResponse> DeleteSnapshotAsync(DeleteSnapshotRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteSnapshotRequestMarshaller();
            var unmarshaller = DeleteSnapshotResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DeleteSnapshotRequest, DeleteSnapshotResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Deletes the datafeed for Spot Instances. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-spot-instances.html">Spot Instances</a> in the <i>Amazon Elastic Compute
        /// Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSpotDatafeedSubscription
        /// service method on AmazonEC2.</param>
		public DeleteSpotDatafeedSubscriptionResponse DeleteSpotDatafeedSubscription(DeleteSpotDatafeedSubscriptionRequest request)
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
        /// Initiates the asynchronous execution of the DeleteSpotDatafeedSubscription operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteSpotDatafeedSubscription"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSpotDatafeedSubscription operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DeleteSpotDatafeedSubscriptionResponse> DeleteSpotDatafeedSubscriptionAsync(DeleteSpotDatafeedSubscriptionRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteSpotDatafeedSubscriptionRequestMarshaller();
            var unmarshaller = DeleteSpotDatafeedSubscriptionResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DeleteSpotDatafeedSubscriptionRequest, DeleteSpotDatafeedSubscriptionResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Deletes the datafeed for Spot Instances. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-spot-instances.html">Spot Instances</a> in the <i>Amazon Elastic Compute
        /// Cloud User Guide</i> .</para>
        /// </summary>
        /// 
		public DeleteSpotDatafeedSubscriptionResponse DeleteSpotDatafeedSubscription()
        {
            return this.DeleteSpotDatafeedSubscription(new DeleteSpotDatafeedSubscriptionRequest());
        }
 
        /// <summary>
        /// <para>Deletes the specified subnet. You must terminate all running instances in the subnet before you can delete the subnet.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSubnet service method on AmazonEC2.</param>
		public DeleteSubnetResponse DeleteSubnet(DeleteSubnetRequest request)
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
        /// Initiates the asynchronous execution of the DeleteSubnet operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteSubnet"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSubnet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DeleteSubnetResponse> DeleteSubnetAsync(DeleteSubnetRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteSubnetRequestMarshaller();
            var unmarshaller = DeleteSubnetResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DeleteSubnetRequest, DeleteSubnetResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Deletes the specified set of tags from the specified set of resources. This call is designed to follow a <c>DescribeTags</c>
        /// request.</para> <para>For more information about tags, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_Tags.html">Tagging Your Resources</a> in the <i>Amazon Elastic Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTags service method on AmazonEC2.</param>
		public DeleteTagsResponse DeleteTags(DeleteTagsRequest request)
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
        /// Initiates the asynchronous execution of the DeleteTags operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteTags"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DeleteTagsResponse> DeleteTagsAsync(DeleteTagsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteTagsRequestMarshaller();
            var unmarshaller = DeleteTagsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DeleteTagsRequest, DeleteTagsResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Deletes the specified Amazon EBS volume. The volume must be in the <c>available</c> state (not attached to an instance).</para>
        /// <para><b>NOTE:</b> The volume remains in the deleting state for several minutes. </para> <para>For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-deleting-volume.html">Deleting an Amazon EBS Volume</a> in the <i>Amazon
        /// Elastic Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVolume service method on AmazonEC2.</param>
		public DeleteVolumeResponse DeleteVolume(DeleteVolumeRequest request)
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
        /// Initiates the asynchronous execution of the DeleteVolume operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteVolume"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVolume operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DeleteVolumeResponse> DeleteVolumeAsync(DeleteVolumeRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteVolumeRequestMarshaller();
            var unmarshaller = DeleteVolumeResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DeleteVolumeRequest, DeleteVolumeResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Deletes the specified VPC. You must detach or delete all gateways and resources that are associated with the VPC before you can delete
        /// it. For example, you must terminate all instances running in the VPC, delete all security groups associated with the VPC (except the default
        /// one), delete all route tables associated with the VPC (except the default one), and so on.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpc service method on AmazonEC2.</param>
		public DeleteVpcResponse DeleteVpc(DeleteVpcRequest request)
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
        /// Initiates the asynchronous execution of the DeleteVpc operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteVpc"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpc operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DeleteVpcResponse> DeleteVpcAsync(DeleteVpcRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteVpcRequestMarshaller();
            var unmarshaller = DeleteVpcResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DeleteVpcRequest, DeleteVpcResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Deletes the specified VPN connection.</para> <para>If you're deleting the VPC and its associated components, we recommend that you
        /// detach the virtual private gateway from the VPC and delete the VPC before deleting the VPN connection.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpnConnection service method on
        /// AmazonEC2.</param>
		public DeleteVpnConnectionResponse DeleteVpnConnection(DeleteVpnConnectionRequest request)
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
        /// Initiates the asynchronous execution of the DeleteVpnConnection operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteVpnConnection"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpnConnection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DeleteVpnConnectionResponse> DeleteVpnConnectionAsync(DeleteVpnConnectionRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteVpnConnectionRequestMarshaller();
            var unmarshaller = DeleteVpnConnectionResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DeleteVpnConnectionRequest, DeleteVpnConnectionResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Deletes the specified static route associated with a VPN connection between an existing virtual private gateway and a VPN customer
        /// gateway. The static route allows traffic to be routed from the virtual private gateway to the VPN customer gateway.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpnConnectionRoute service method
        /// on AmazonEC2.</param>
		public DeleteVpnConnectionRouteResponse DeleteVpnConnectionRoute(DeleteVpnConnectionRouteRequest request)
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
        /// Initiates the asynchronous execution of the DeleteVpnConnectionRoute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteVpnConnectionRoute"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpnConnectionRoute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DeleteVpnConnectionRouteResponse> DeleteVpnConnectionRouteAsync(DeleteVpnConnectionRouteRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteVpnConnectionRouteRequestMarshaller();
            var unmarshaller = DeleteVpnConnectionRouteResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DeleteVpnConnectionRouteRequest, DeleteVpnConnectionRouteResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Deletes the specified virtual private gateway. We recommend that before you delete a virtual private gateway, you detach it from the
        /// VPC and delete the VPN connection. Note that you don't need to delete the virtual private gateway if you plan to delete and recreate the VPN
        /// connection between your VPC and your network.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpnGateway service method on
        /// AmazonEC2.</param>
		public DeleteVpnGatewayResponse DeleteVpnGateway(DeleteVpnGatewayRequest request)
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
        /// Initiates the asynchronous execution of the DeleteVpnGateway operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteVpnGateway"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpnGateway operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DeleteVpnGatewayResponse> DeleteVpnGatewayAsync(DeleteVpnGatewayRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteVpnGatewayRequestMarshaller();
            var unmarshaller = DeleteVpnGatewayResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DeleteVpnGatewayRequest, DeleteVpnGatewayResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Deregisters the specified AMI. After you deregister an AMI, it can't be used to launch new instances.</para> <para>This command does
        /// not delete the AMI.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterImage service method on
        /// AmazonEC2.</param>
		public DeregisterImageResponse DeregisterImage(DeregisterImageRequest request)
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
        /// Initiates the asynchronous execution of the DeregisterImage operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeregisterImage"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterImage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DeregisterImageResponse> DeregisterImageAsync(DeregisterImageRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeregisterImageRequestMarshaller();
            var unmarshaller = DeregisterImageResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DeregisterImageRequest, DeregisterImageResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Describes the specified attribute of your AWS account.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountAttributes service
        /// method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeAccountAttributes service method, as returned by AmazonEC2.</returns>
		public DescribeAccountAttributesResponse DescribeAccountAttributes(DescribeAccountAttributesRequest request)
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
        /// Initiates the asynchronous execution of the DescribeAccountAttributes operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeAccountAttributes"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DescribeAccountAttributesResponse> DescribeAccountAttributesAsync(DescribeAccountAttributesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeAccountAttributesRequestMarshaller();
            var unmarshaller = DescribeAccountAttributesResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeAccountAttributesRequest, DescribeAccountAttributesResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Describes the specified attribute of your AWS account.</para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeAccountAttributes service method, as returned by AmazonEC2.</returns>
		public DescribeAccountAttributesResponse DescribeAccountAttributes()
        {
            return this.DescribeAccountAttributes(new DescribeAccountAttributesRequest());
        }
 
        /// <summary>
        /// <para>Describes one or more of your Elastic IP addresses.</para> <para>An Elastic IP address is for use in either the EC2-Classic platform
        /// or in a VPC. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/elastic-ip-addresses-eip.html">Elastic
        /// IP Addresses</a> in the <i>Amazon Elastic Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAddresses service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeAddresses service method, as returned by AmazonEC2.</returns>
		public DescribeAddressesResponse DescribeAddresses(DescribeAddressesRequest request)
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
        /// Initiates the asynchronous execution of the DescribeAddresses operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeAddresses"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAddresses operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DescribeAddressesResponse> DescribeAddressesAsync(DescribeAddressesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeAddressesRequestMarshaller();
            var unmarshaller = DescribeAddressesResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeAddressesRequest, DescribeAddressesResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Describes one or more of your Elastic IP addresses.</para> <para>An Elastic IP address is for use in either the EC2-Classic platform
        /// or in a VPC. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/elastic-ip-addresses-eip.html">Elastic
        /// IP Addresses</a> in the <i>Amazon Elastic Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeAddresses service method, as returned by AmazonEC2.</returns>
		public DescribeAddressesResponse DescribeAddresses()
        {
            return this.DescribeAddresses(new DescribeAddressesRequest());
        }
 
        /// <summary>
        /// <para>Describes one or more of the Availability Zones that are available to you. The results include zones only for the region you're
        /// currently using. If there is an event impacting an Availability Zone, you can use this request to view the state and any provided message
        /// for that Availability Zone.</para> <para>For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-regions-availability-zones.html">Regions and Availability Zones</a> in the
        /// <i>Amazon Elastic Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAvailabilityZones service
        /// method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeAvailabilityZones service method, as returned by AmazonEC2.</returns>
		public DescribeAvailabilityZonesResponse DescribeAvailabilityZones(DescribeAvailabilityZonesRequest request)
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
        /// Initiates the asynchronous execution of the DescribeAvailabilityZones operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeAvailabilityZones"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAvailabilityZones operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DescribeAvailabilityZonesResponse> DescribeAvailabilityZonesAsync(DescribeAvailabilityZonesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeAvailabilityZonesRequestMarshaller();
            var unmarshaller = DescribeAvailabilityZonesResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeAvailabilityZonesRequest, DescribeAvailabilityZonesResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Describes one or more of the Availability Zones that are available to you. The results include zones only for the region you're
        /// currently using. If there is an event impacting an Availability Zone, you can use this request to view the state and any provided message
        /// for that Availability Zone.</para> <para>For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-regions-availability-zones.html">Regions and Availability Zones</a> in the
        /// <i>Amazon Elastic Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeAvailabilityZones service method, as returned by AmazonEC2.</returns>
		public DescribeAvailabilityZonesResponse DescribeAvailabilityZones()
        {
            return this.DescribeAvailabilityZones(new DescribeAvailabilityZonesRequest());
        }
 
        /// <summary>
        /// <para>Describes one or more of your bundling tasks.</para> <para><b>NOTE:</b> Completed bundle tasks are listed for only a limited time. If
        /// your bundle task is no longer in the list, you can still register an AMI from it. Just use RegisterImage with the Amazon S3 bucket name and
        /// image manifest name you provided to the bundle task. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeBundleTasks service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeBundleTasks service method, as returned by AmazonEC2.</returns>
		public DescribeBundleTasksResponse DescribeBundleTasks(DescribeBundleTasksRequest request)
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
        /// Initiates the asynchronous execution of the DescribeBundleTasks operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeBundleTasks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeBundleTasks operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DescribeBundleTasksResponse> DescribeBundleTasksAsync(DescribeBundleTasksRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeBundleTasksRequestMarshaller();
            var unmarshaller = DescribeBundleTasksResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeBundleTasksRequest, DescribeBundleTasksResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Describes one or more of your bundling tasks.</para> <para><b>NOTE:</b> Completed bundle tasks are listed for only a limited time. If
        /// your bundle task is no longer in the list, you can still register an AMI from it. Just use RegisterImage with the Amazon S3 bucket name and
        /// image manifest name you provided to the bundle task. </para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeBundleTasks service method, as returned by AmazonEC2.</returns>
		public DescribeBundleTasksResponse DescribeBundleTasks()
        {
            return this.DescribeBundleTasks(new DescribeBundleTasksRequest());
        }
 
        /// <summary>
        /// <para>Describes one or more of your conversion tasks. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/UploadingYourInstancesandVolumes.html">Using the Command Line Tools to Import Your
        /// Virtual Machine to Amazon EC2</a> in the <i>Amazon Elastic Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeConversionTasks service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeConversionTasks service method, as returned by AmazonEC2.</returns>
		public DescribeConversionTasksResponse DescribeConversionTasks(DescribeConversionTasksRequest request)
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
        /// Initiates the asynchronous execution of the DescribeConversionTasks operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeConversionTasks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeConversionTasks operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DescribeConversionTasksResponse> DescribeConversionTasksAsync(DescribeConversionTasksRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeConversionTasksRequestMarshaller();
            var unmarshaller = DescribeConversionTasksResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeConversionTasksRequest, DescribeConversionTasksResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Describes one or more of your conversion tasks. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/UploadingYourInstancesandVolumes.html">Using the Command Line Tools to Import Your
        /// Virtual Machine to Amazon EC2</a> in the <i>Amazon Elastic Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeConversionTasks service method, as returned by AmazonEC2.</returns>
		public DescribeConversionTasksResponse DescribeConversionTasks()
        {
            return this.DescribeConversionTasks(new DescribeConversionTasksRequest());
        }
 
        /// <summary>
        /// <para>Describes one or more of your VPN customer gateways.</para> <para>For more information about VPN customer gateways, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_VPN.html">Adding a Hardware Virtual Private Gateway to Your VPC</a> in the
        /// <i>Amazon Virtual Private Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCustomerGateways service method
        /// on AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeCustomerGateways service method, as returned by AmazonEC2.</returns>
		public DescribeCustomerGatewaysResponse DescribeCustomerGateways(DescribeCustomerGatewaysRequest request)
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
        /// Initiates the asynchronous execution of the DescribeCustomerGateways operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeCustomerGateways"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCustomerGateways operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DescribeCustomerGatewaysResponse> DescribeCustomerGatewaysAsync(DescribeCustomerGatewaysRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeCustomerGatewaysRequestMarshaller();
            var unmarshaller = DescribeCustomerGatewaysResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeCustomerGatewaysRequest, DescribeCustomerGatewaysResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Describes one or more of your VPN customer gateways.</para> <para>For more information about VPN customer gateways, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_VPN.html">Adding a Hardware Virtual Private Gateway to Your VPC</a> in the
        /// <i>Amazon Virtual Private Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeCustomerGateways service method, as returned by AmazonEC2.</returns>
		public DescribeCustomerGatewaysResponse DescribeCustomerGateways()
        {
            return this.DescribeCustomerGateways(new DescribeCustomerGatewaysRequest());
        }
 
        /// <summary>
        /// <para>Describes one or more of your DHCP options sets.</para> <para>For more information about DHCP options sets, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_DHCP_Options.html">DHCP Options Sets</a> in the <i>Amazon Virtual Private
        /// Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDhcpOptions service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeDhcpOptions service method, as returned by AmazonEC2.</returns>
		public DescribeDhcpOptionsResponse DescribeDhcpOptions(DescribeDhcpOptionsRequest request)
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
        /// Initiates the asynchronous execution of the DescribeDhcpOptions operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeDhcpOptions"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDhcpOptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DescribeDhcpOptionsResponse> DescribeDhcpOptionsAsync(DescribeDhcpOptionsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeDhcpOptionsRequestMarshaller();
            var unmarshaller = DescribeDhcpOptionsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeDhcpOptionsRequest, DescribeDhcpOptionsResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Describes one or more of your DHCP options sets.</para> <para>For more information about DHCP options sets, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_DHCP_Options.html">DHCP Options Sets</a> in the <i>Amazon Virtual Private
        /// Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeDhcpOptions service method, as returned by AmazonEC2.</returns>
		public DescribeDhcpOptionsResponse DescribeDhcpOptions()
        {
            return this.DescribeDhcpOptions(new DescribeDhcpOptionsRequest());
        }
 
        /// <summary>
        /// <para>Describes one or more of your export tasks.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeExportTasks service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeExportTasks service method, as returned by AmazonEC2.</returns>
		public DescribeExportTasksResponse DescribeExportTasks(DescribeExportTasksRequest request)
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
        /// Initiates the asynchronous execution of the DescribeExportTasks operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeExportTasks"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeExportTasks operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DescribeExportTasksResponse> DescribeExportTasksAsync(DescribeExportTasksRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeExportTasksRequestMarshaller();
            var unmarshaller = DescribeExportTasksResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeExportTasksRequest, DescribeExportTasksResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Describes one or more of your export tasks.</para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeExportTasks service method, as returned by AmazonEC2.</returns>
		public DescribeExportTasksResponse DescribeExportTasks()
        {
            return this.DescribeExportTasks(new DescribeExportTasksRequest());
        }
 
        /// <summary>
        /// <para>Describes an attributes of an AMI. You can specify only one attribute at a time.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeImageAttribute service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeImageAttribute service method, as returned by AmazonEC2.</returns>
		public DescribeImageAttributeResponse DescribeImageAttribute(DescribeImageAttributeRequest request)
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
        /// Initiates the asynchronous execution of the DescribeImageAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeImageAttribute"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeImageAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DescribeImageAttributeResponse> DescribeImageAttributeAsync(DescribeImageAttributeRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeImageAttributeRequestMarshaller();
            var unmarshaller = DescribeImageAttributeResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeImageAttributeRequest, DescribeImageAttributeResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Describes one or more of the images (AMIs, AKIs, and ARIs) available to you. Images available to you include public images, private
        /// images that you own, and private images owned by other AWS accounts but for which you have explicit launch permissions.</para>
        /// <para><b>NOTE:</b> Deregistered images are included in the returned results for an unspecified interval after deregistration. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeImages service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeImages service method, as returned by AmazonEC2.</returns>
		public DescribeImagesResponse DescribeImages(DescribeImagesRequest request)
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
        /// Initiates the asynchronous execution of the DescribeImages operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeImages"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeImages operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DescribeImagesResponse> DescribeImagesAsync(DescribeImagesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeImagesRequestMarshaller();
            var unmarshaller = DescribeImagesResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeImagesRequest, DescribeImagesResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Describes one or more of the images (AMIs, AKIs, and ARIs) available to you. Images available to you include public images, private
        /// images that you own, and private images owned by other AWS accounts but for which you have explicit launch permissions.</para>
        /// <para><b>NOTE:</b> Deregistered images are included in the returned results for an unspecified interval after deregistration. </para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeImages service method, as returned by AmazonEC2.</returns>
		public DescribeImagesResponse DescribeImages()
        {
            return this.DescribeImages(new DescribeImagesRequest());
        }
 
        /// <summary>
        /// <para>Describes an attribute of the specified instance. You can specify only one attribute at a time.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstanceAttribute service
        /// method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeInstanceAttribute service method, as returned by AmazonEC2.</returns>
		public DescribeInstanceAttributeResponse DescribeInstanceAttribute(DescribeInstanceAttributeRequest request)
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
        /// Initiates the asynchronous execution of the DescribeInstanceAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeInstanceAttribute"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstanceAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DescribeInstanceAttributeResponse> DescribeInstanceAttributeAsync(DescribeInstanceAttributeRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeInstanceAttributeRequestMarshaller();
            var unmarshaller = DescribeInstanceAttributeResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeInstanceAttributeRequest, DescribeInstanceAttributeResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Describes one or more of your instances.</para> <para>If you specify one or more instance IDs, Amazon EC2 returns information for
        /// those instances. If you do not specify instance IDs, Amazon EC2 returns information for all relevant instances. If you specify an instance
        /// ID that is not valid, an error is returned. If you specify an instance that you do not own, it is not included in the returned
        /// results.</para> <para>Recently terminated instances might appear in the returned results. This interval is usually less than one
        /// hour.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstances service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeInstances service method, as returned by AmazonEC2.</returns>
		public DescribeInstancesResponse DescribeInstances(DescribeInstancesRequest request)
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
        /// Initiates the asynchronous execution of the DescribeInstances operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeInstances"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DescribeInstancesResponse> DescribeInstancesAsync(DescribeInstancesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeInstancesRequestMarshaller();
            var unmarshaller = DescribeInstancesResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeInstancesRequest, DescribeInstancesResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Describes one or more of your instances.</para> <para>If you specify one or more instance IDs, Amazon EC2 returns information for
        /// those instances. If you do not specify instance IDs, Amazon EC2 returns information for all relevant instances. If you specify an instance
        /// ID that is not valid, an error is returned. If you specify an instance that you do not own, it is not included in the returned
        /// results.</para> <para>Recently terminated instances might appear in the returned results. This interval is usually less than one
        /// hour.</para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeInstances service method, as returned by AmazonEC2.</returns>
		public DescribeInstancesResponse DescribeInstances()
        {
            return this.DescribeInstances(new DescribeInstancesRequest());
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstanceStatus service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeInstanceStatus service method, as returned by AmazonEC2.</returns>
		public DescribeInstanceStatusResponse DescribeInstanceStatus(DescribeInstanceStatusRequest request)
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
        /// Initiates the asynchronous execution of the DescribeInstanceStatus operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeInstanceStatus"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstanceStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DescribeInstanceStatusResponse> DescribeInstanceStatusAsync(DescribeInstanceStatusRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeInstanceStatusRequestMarshaller();
            var unmarshaller = DescribeInstanceStatusResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeInstanceStatusRequest, DescribeInstanceStatusResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
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
        /// 
        /// <returns>The response from the DescribeInstanceStatus service method, as returned by AmazonEC2.</returns>
		public DescribeInstanceStatusResponse DescribeInstanceStatus()
        {
            return this.DescribeInstanceStatus(new DescribeInstanceStatusRequest());
        }
 
        /// <summary>
        /// <para>Describes one or more of your Internet gateways.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInternetGateways service method
        /// on AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeInternetGateways service method, as returned by AmazonEC2.</returns>
		public DescribeInternetGatewaysResponse DescribeInternetGateways(DescribeInternetGatewaysRequest request)
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
        /// Initiates the asynchronous execution of the DescribeInternetGateways operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeInternetGateways"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInternetGateways operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DescribeInternetGatewaysResponse> DescribeInternetGatewaysAsync(DescribeInternetGatewaysRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeInternetGatewaysRequestMarshaller();
            var unmarshaller = DescribeInternetGatewaysResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeInternetGatewaysRequest, DescribeInternetGatewaysResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Describes one or more of your Internet gateways.</para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeInternetGateways service method, as returned by AmazonEC2.</returns>
		public DescribeInternetGatewaysResponse DescribeInternetGateways()
        {
            return this.DescribeInternetGateways(new DescribeInternetGatewaysRequest());
        }
 
        /// <summary>
        /// <para>Describes one or more of your key pairs.</para> <para>For more information about key pairs, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-key-pairs.html">Key Pairs</a> in the <i>Amazon Elastic Compute Cloud User
        /// Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeKeyPairs service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeKeyPairs service method, as returned by AmazonEC2.</returns>
		public DescribeKeyPairsResponse DescribeKeyPairs(DescribeKeyPairsRequest request)
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
        /// Initiates the asynchronous execution of the DescribeKeyPairs operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeKeyPairs"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeKeyPairs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DescribeKeyPairsResponse> DescribeKeyPairsAsync(DescribeKeyPairsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeKeyPairsRequestMarshaller();
            var unmarshaller = DescribeKeyPairsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeKeyPairsRequest, DescribeKeyPairsResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Describes one or more of your key pairs.</para> <para>For more information about key pairs, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-key-pairs.html">Key Pairs</a> in the <i>Amazon Elastic Compute Cloud User
        /// Guide</i> .</para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeKeyPairs service method, as returned by AmazonEC2.</returns>
		public DescribeKeyPairsResponse DescribeKeyPairs()
        {
            return this.DescribeKeyPairs(new DescribeKeyPairsRequest());
        }
 
        /// <summary>
        /// <para>Describes one or more of your network ACLs.</para> <para>For more information about network ACLs, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_ACLs.html">Network ACLs</a> in the <i>Amazon Virtual Private Cloud User
        /// Guide</i> .</para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeNetworkAcls service method, as returned by AmazonEC2.</returns>
		public DescribeNetworkAclsResponse DescribeNetworkAcls()
        {
            return this.DescribeNetworkAcls(new DescribeNetworkAclsRequest());
        }
 
        /// <summary>
        /// <para>Describes one or more of your network ACLs.</para> <para>For more information about network ACLs, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_ACLs.html">Network ACLs</a> in the <i>Amazon Virtual Private Cloud User
        /// Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeNetworkAcls service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeNetworkAcls service method, as returned by AmazonEC2.</returns>
		public DescribeNetworkAclsResponse DescribeNetworkAcls(DescribeNetworkAclsRequest request)
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
        /// Initiates the asynchronous execution of the DescribeNetworkAcls operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeNetworkAcls"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeNetworkAcls operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DescribeNetworkAclsResponse> DescribeNetworkAclsAsync(DescribeNetworkAclsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeNetworkAclsRequestMarshaller();
            var unmarshaller = DescribeNetworkAclsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeNetworkAclsRequest, DescribeNetworkAclsResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Describes a network interface attribute. You can specify only one attribute at a time.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the
        /// DescribeNetworkInterfaceAttribute service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeNetworkInterfaceAttribute service method, as returned by AmazonEC2.</returns>
		public DescribeNetworkInterfaceAttributeResponse DescribeNetworkInterfaceAttribute(DescribeNetworkInterfaceAttributeRequest request)
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
        /// Initiates the asynchronous execution of the DescribeNetworkInterfaceAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeNetworkInterfaceAttribute"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeNetworkInterfaceAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DescribeNetworkInterfaceAttributeResponse> DescribeNetworkInterfaceAttributeAsync(DescribeNetworkInterfaceAttributeRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeNetworkInterfaceAttributeRequestMarshaller();
            var unmarshaller = DescribeNetworkInterfaceAttributeResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeNetworkInterfaceAttributeRequest, DescribeNetworkInterfaceAttributeResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Describes one or more of your network interfaces.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeNetworkInterfaces service
        /// method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeNetworkInterfaces service method, as returned by AmazonEC2.</returns>
		public DescribeNetworkInterfacesResponse DescribeNetworkInterfaces(DescribeNetworkInterfacesRequest request)
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
        /// Initiates the asynchronous execution of the DescribeNetworkInterfaces operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeNetworkInterfaces"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeNetworkInterfaces operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DescribeNetworkInterfacesResponse> DescribeNetworkInterfacesAsync(DescribeNetworkInterfacesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeNetworkInterfacesRequestMarshaller();
            var unmarshaller = DescribeNetworkInterfacesResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeNetworkInterfacesRequest, DescribeNetworkInterfacesResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Describes one or more of your network interfaces.</para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeNetworkInterfaces service method, as returned by AmazonEC2.</returns>
		public DescribeNetworkInterfacesResponse DescribeNetworkInterfaces()
        {
            return this.DescribeNetworkInterfaces(new DescribeNetworkInterfacesRequest());
        }
 
        /// <summary>
        /// <para>Describes one or more of your placement groups. For more information about placement groups and cluster instances, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using_cluster_computing.html">Cluster Instances</a> in the <i>Amazon Elastic
        /// Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePlacementGroups service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribePlacementGroups service method, as returned by AmazonEC2.</returns>
		public DescribePlacementGroupsResponse DescribePlacementGroups(DescribePlacementGroupsRequest request)
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
        /// Initiates the asynchronous execution of the DescribePlacementGroups operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribePlacementGroups"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePlacementGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DescribePlacementGroupsResponse> DescribePlacementGroupsAsync(DescribePlacementGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribePlacementGroupsRequestMarshaller();
            var unmarshaller = DescribePlacementGroupsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribePlacementGroupsRequest, DescribePlacementGroupsResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Describes one or more of your placement groups. For more information about placement groups and cluster instances, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using_cluster_computing.html">Cluster Instances</a> in the <i>Amazon Elastic
        /// Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribePlacementGroups service method, as returned by AmazonEC2.</returns>
		public DescribePlacementGroupsResponse DescribePlacementGroups()
        {
            return this.DescribePlacementGroups(new DescribePlacementGroupsRequest());
        }
 
        /// <summary>
        /// <para>Describes one or more regions that are currently available to you.</para> <para>For a list of the regions supported by Amazon EC2, see
        /// <a href="http://docs.aws.amazon.com/general/latest/gr/rande.html#ec2_region">Regions and Endpoints</a> .</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRegions service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeRegions service method, as returned by AmazonEC2.</returns>
		public DescribeRegionsResponse DescribeRegions(DescribeRegionsRequest request)
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
        /// Initiates the asynchronous execution of the DescribeRegions operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeRegions"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRegions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DescribeRegionsResponse> DescribeRegionsAsync(DescribeRegionsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeRegionsRequestMarshaller();
            var unmarshaller = DescribeRegionsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeRegionsRequest, DescribeRegionsResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Describes one or more regions that are currently available to you.</para> <para>For a list of the regions supported by Amazon EC2, see
        /// <a href="http://docs.aws.amazon.com/general/latest/gr/rande.html#ec2_region">Regions and Endpoints</a> .</para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeRegions service method, as returned by AmazonEC2.</returns>
		public DescribeRegionsResponse DescribeRegions()
        {
            return this.DescribeRegions(new DescribeRegionsRequest());
        }
 
        /// <summary>
        /// <para>Describes one or more of the Reserved Instances that you purchased.</para> <para>For more information about Reserved Instances, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/concepts-on-demand-reserved-instances.html">Reserved Instances</a> in the
        /// <i>Amazon Elastic Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedInstances service
        /// method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeReservedInstances service method, as returned by AmazonEC2.</returns>
		public DescribeReservedInstancesResponse DescribeReservedInstances(DescribeReservedInstancesRequest request)
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
        /// Initiates the asynchronous execution of the DescribeReservedInstances operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeReservedInstances"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DescribeReservedInstancesResponse> DescribeReservedInstancesAsync(DescribeReservedInstancesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeReservedInstancesRequestMarshaller();
            var unmarshaller = DescribeReservedInstancesResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeReservedInstancesRequest, DescribeReservedInstancesResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Describes one or more of the Reserved Instances that you purchased.</para> <para>For more information about Reserved Instances, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/concepts-on-demand-reserved-instances.html">Reserved Instances</a> in the
        /// <i>Amazon Elastic Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeReservedInstances service method, as returned by AmazonEC2.</returns>
		public DescribeReservedInstancesResponse DescribeReservedInstances()
        {
            return this.DescribeReservedInstances(new DescribeReservedInstancesRequest());
        }
 
        /// <summary>
        /// <para>Describes your account's Reserved Instance listings in the Reserved Instance Marketplace.</para> <para>For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ri-market-general.html">Reserved Instance Marketplace</a> in the <i>Amazon Elastic
        /// Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the
        /// DescribeReservedInstancesListings service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeReservedInstancesListings service method, as returned by AmazonEC2.</returns>
		public DescribeReservedInstancesListingsResponse DescribeReservedInstancesListings(DescribeReservedInstancesListingsRequest request)
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
        /// Initiates the asynchronous execution of the DescribeReservedInstancesListings operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeReservedInstancesListings"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedInstancesListings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DescribeReservedInstancesListingsResponse> DescribeReservedInstancesListingsAsync(DescribeReservedInstancesListingsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeReservedInstancesListingsRequestMarshaller();
            var unmarshaller = DescribeReservedInstancesListingsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeReservedInstancesListingsRequest, DescribeReservedInstancesListingsResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Describes your account's Reserved Instance listings in the Reserved Instance Marketplace.</para> <para>For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ri-market-general.html">Reserved Instance Marketplace</a> in the <i>Amazon Elastic
        /// Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeReservedInstancesListings service method, as returned by AmazonEC2.</returns>
		public DescribeReservedInstancesListingsResponse DescribeReservedInstancesListings()
        {
            return this.DescribeReservedInstancesListings(new DescribeReservedInstancesListingsRequest());
        }
 
        /// <summary>
        /// <para>Describes the modifications made to your Reserved Instances. If no parameter is specified, information about all your Reserved
        /// Instances modification requests is returned. If a modification ID is specified, only information about the specific modification is
        /// returned.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the
        /// DescribeReservedInstancesModifications service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeReservedInstancesModifications service method, as returned by AmazonEC2.</returns>
		public DescribeReservedInstancesModificationsResponse DescribeReservedInstancesModifications(DescribeReservedInstancesModificationsRequest request)
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
        /// Initiates the asynchronous execution of the DescribeReservedInstancesModifications operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeReservedInstancesModifications"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedInstancesModifications operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DescribeReservedInstancesModificationsResponse> DescribeReservedInstancesModificationsAsync(DescribeReservedInstancesModificationsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeReservedInstancesModificationsRequestMarshaller();
            var unmarshaller = DescribeReservedInstancesModificationsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeReservedInstancesModificationsRequest, DescribeReservedInstancesModificationsResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Describes the modifications made to your Reserved Instances. If no parameter is specified, information about all your Reserved
        /// Instances modification requests is returned. If a modification ID is specified, only information about the specific modification is
        /// returned.</para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeReservedInstancesModifications service method, as returned by AmazonEC2.</returns>
		public DescribeReservedInstancesModificationsResponse DescribeReservedInstancesModifications()
        {
            return this.DescribeReservedInstancesModifications(new DescribeReservedInstancesModificationsRequest());
        }
 
        /// <summary>
        /// <para>Describes Reserved Instance offerings that are available for purchase. With Reserved Instances, you purchase the right to launch
        /// instances for a period of time. During that time period, you do not receive insufficient capacity errors, and you pay a lower usage rate
        /// than the rate charged for On-Demand instances for the actual time used.</para> <para>For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ri-market-general.html">Reserved Instance Marketplace</a> in the <i>Amazon Elastic
        /// Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the
        /// DescribeReservedInstancesOfferings service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeReservedInstancesOfferings service method, as returned by AmazonEC2.</returns>
		public DescribeReservedInstancesOfferingsResponse DescribeReservedInstancesOfferings(DescribeReservedInstancesOfferingsRequest request)
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
        /// Initiates the asynchronous execution of the DescribeReservedInstancesOfferings operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeReservedInstancesOfferings"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedInstancesOfferings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DescribeReservedInstancesOfferingsResponse> DescribeReservedInstancesOfferingsAsync(DescribeReservedInstancesOfferingsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeReservedInstancesOfferingsRequestMarshaller();
            var unmarshaller = DescribeReservedInstancesOfferingsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeReservedInstancesOfferingsRequest, DescribeReservedInstancesOfferingsResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Describes Reserved Instance offerings that are available for purchase. With Reserved Instances, you purchase the right to launch
        /// instances for a period of time. During that time period, you do not receive insufficient capacity errors, and you pay a lower usage rate
        /// than the rate charged for On-Demand instances for the actual time used.</para> <para>For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ri-market-general.html">Reserved Instance Marketplace</a> in the <i>Amazon Elastic
        /// Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeReservedInstancesOfferings service method, as returned by AmazonEC2.</returns>
		public DescribeReservedInstancesOfferingsResponse DescribeReservedInstancesOfferings()
        {
            return this.DescribeReservedInstancesOfferings(new DescribeReservedInstancesOfferingsRequest());
        }
 
        /// <summary>
        /// <para>Describes one or more of your route tables.</para> <para>For more information about route tables, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Route_Tables.html">Route Tables</a> in the <i>Amazon Virtual Private Cloud
        /// User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRouteTables service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeRouteTables service method, as returned by AmazonEC2.</returns>
		public DescribeRouteTablesResponse DescribeRouteTables(DescribeRouteTablesRequest request)
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
        /// Initiates the asynchronous execution of the DescribeRouteTables operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeRouteTables"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRouteTables operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DescribeRouteTablesResponse> DescribeRouteTablesAsync(DescribeRouteTablesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeRouteTablesRequestMarshaller();
            var unmarshaller = DescribeRouteTablesResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeRouteTablesRequest, DescribeRouteTablesResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Describes one or more of your route tables.</para> <para>For more information about route tables, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Route_Tables.html">Route Tables</a> in the <i>Amazon Virtual Private Cloud
        /// User Guide</i> .</para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeRouteTables service method, as returned by AmazonEC2.</returns>
		public DescribeRouteTablesResponse DescribeRouteTables()
        {
            return this.DescribeRouteTables(new DescribeRouteTablesRequest());
        }
 
        /// <summary>
        /// <para>Describes one or more of your security groups.</para> <para>A security group is for use with instances either in the EC2-Classic
        /// platform or in a specific VPC. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-network-security.html">Amazon EC2 Security Groups</a> in the <i>Amazon
        /// Elastic Compute Cloud User Guide</i> and <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_SecurityGroups.html">Security
        /// Groups for Your VPC</a> in the <i>Amazon Virtual Private Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSecurityGroups service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeSecurityGroups service method, as returned by AmazonEC2.</returns>
		public DescribeSecurityGroupsResponse DescribeSecurityGroups(DescribeSecurityGroupsRequest request)
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
        /// Initiates the asynchronous execution of the DescribeSecurityGroups operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeSecurityGroups"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSecurityGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DescribeSecurityGroupsResponse> DescribeSecurityGroupsAsync(DescribeSecurityGroupsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeSecurityGroupsRequestMarshaller();
            var unmarshaller = DescribeSecurityGroupsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeSecurityGroupsRequest, DescribeSecurityGroupsResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Describes one or more of your security groups.</para> <para>A security group is for use with instances either in the EC2-Classic
        /// platform or in a specific VPC. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-network-security.html">Amazon EC2 Security Groups</a> in the <i>Amazon
        /// Elastic Compute Cloud User Guide</i> and <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_SecurityGroups.html">Security
        /// Groups for Your VPC</a> in the <i>Amazon Virtual Private Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeSecurityGroups service method, as returned by AmazonEC2.</returns>
		public DescribeSecurityGroupsResponse DescribeSecurityGroups()
        {
            return this.DescribeSecurityGroups(new DescribeSecurityGroupsRequest());
        }
 
        /// <summary>
        /// <para>Describes an attribute of the specified snapshot. You can specify only one attribute at a time.</para> <para>For more information
        /// about Amazon EBS snapshots, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSSnapshots.html">Amazon EBS Snapshots</a> in
        /// the <i>Amazon Elastic Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSnapshotAttribute service
        /// method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeSnapshotAttribute service method, as returned by AmazonEC2.</returns>
		public DescribeSnapshotAttributeResponse DescribeSnapshotAttribute(DescribeSnapshotAttributeRequest request)
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
        /// Initiates the asynchronous execution of the DescribeSnapshotAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeSnapshotAttribute"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSnapshotAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DescribeSnapshotAttributeResponse> DescribeSnapshotAttributeAsync(DescribeSnapshotAttributeRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeSnapshotAttributeRequestMarshaller();
            var unmarshaller = DescribeSnapshotAttributeResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeSnapshotAttributeRequest, DescribeSnapshotAttributeResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeSnapshots service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeSnapshots service method, as returned by AmazonEC2.</returns>
		public DescribeSnapshotsResponse DescribeSnapshots(DescribeSnapshotsRequest request)
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
        /// Initiates the asynchronous execution of the DescribeSnapshots operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeSnapshots"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSnapshots operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DescribeSnapshotsResponse> DescribeSnapshotsAsync(DescribeSnapshotsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeSnapshotsRequestMarshaller();
            var unmarshaller = DescribeSnapshotsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeSnapshotsRequest, DescribeSnapshotsResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
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
        /// 
        /// <returns>The response from the DescribeSnapshots service method, as returned by AmazonEC2.</returns>
		public DescribeSnapshotsResponse DescribeSnapshots()
        {
            return this.DescribeSnapshots(new DescribeSnapshotsRequest());
        }
 
        /// <summary>
        /// <para>Describes the datafeed for Spot Instances. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-spot-instances.html">Spot Instances</a> in the <i>Amazon Elastic Compute
        /// Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSpotDatafeedSubscription
        /// service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeSpotDatafeedSubscription service method, as returned by AmazonEC2.</returns>
		public DescribeSpotDatafeedSubscriptionResponse DescribeSpotDatafeedSubscription(DescribeSpotDatafeedSubscriptionRequest request)
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
        /// Initiates the asynchronous execution of the DescribeSpotDatafeedSubscription operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeSpotDatafeedSubscription"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSpotDatafeedSubscription operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DescribeSpotDatafeedSubscriptionResponse> DescribeSpotDatafeedSubscriptionAsync(DescribeSpotDatafeedSubscriptionRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeSpotDatafeedSubscriptionRequestMarshaller();
            var unmarshaller = DescribeSpotDatafeedSubscriptionResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeSpotDatafeedSubscriptionRequest, DescribeSpotDatafeedSubscriptionResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Describes the datafeed for Spot Instances. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-spot-instances.html">Spot Instances</a> in the <i>Amazon Elastic Compute
        /// Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeSpotDatafeedSubscription service method, as returned by AmazonEC2.</returns>
		public DescribeSpotDatafeedSubscriptionResponse DescribeSpotDatafeedSubscription()
        {
            return this.DescribeSpotDatafeedSubscription(new DescribeSpotDatafeedSubscriptionRequest());
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeSpotInstanceRequests service
        /// method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeSpotInstanceRequests service method, as returned by AmazonEC2.</returns>
		public DescribeSpotInstanceRequestsResponse DescribeSpotInstanceRequests(DescribeSpotInstanceRequestsRequest request)
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
        /// Initiates the asynchronous execution of the DescribeSpotInstanceRequests operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeSpotInstanceRequests"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSpotInstanceRequests operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DescribeSpotInstanceRequestsResponse> DescribeSpotInstanceRequestsAsync(DescribeSpotInstanceRequestsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeSpotInstanceRequestsRequestMarshaller();
            var unmarshaller = DescribeSpotInstanceRequestsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeSpotInstanceRequestsRequest, DescribeSpotInstanceRequestsResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
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
        /// 
        /// <returns>The response from the DescribeSpotInstanceRequests service method, as returned by AmazonEC2.</returns>
		public DescribeSpotInstanceRequestsResponse DescribeSpotInstanceRequests()
        {
            return this.DescribeSpotInstanceRequests(new DescribeSpotInstanceRequestsRequest());
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeSpotPriceHistory service method
        /// on AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeSpotPriceHistory service method, as returned by AmazonEC2.</returns>
		public DescribeSpotPriceHistoryResponse DescribeSpotPriceHistory(DescribeSpotPriceHistoryRequest request)
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
        /// Initiates the asynchronous execution of the DescribeSpotPriceHistory operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeSpotPriceHistory"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSpotPriceHistory operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DescribeSpotPriceHistoryResponse> DescribeSpotPriceHistoryAsync(DescribeSpotPriceHistoryRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeSpotPriceHistoryRequestMarshaller();
            var unmarshaller = DescribeSpotPriceHistoryResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeSpotPriceHistoryRequest, DescribeSpotPriceHistoryResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
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
        /// 
        /// <returns>The response from the DescribeSpotPriceHistory service method, as returned by AmazonEC2.</returns>
		public DescribeSpotPriceHistoryResponse DescribeSpotPriceHistory()
        {
            return this.DescribeSpotPriceHistory(new DescribeSpotPriceHistoryRequest());
        }
 
        /// <summary>
        /// <para>Describes one or more of your subnets.</para> <para>For more information about subnets, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Subnets.html">Your VPC and Subnets</a> in the <i>Amazon Virtual Private
        /// Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSubnets service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeSubnets service method, as returned by AmazonEC2.</returns>
		public DescribeSubnetsResponse DescribeSubnets(DescribeSubnetsRequest request)
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
        /// Initiates the asynchronous execution of the DescribeSubnets operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeSubnets"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSubnets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DescribeSubnetsResponse> DescribeSubnetsAsync(DescribeSubnetsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeSubnetsRequestMarshaller();
            var unmarshaller = DescribeSubnetsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeSubnetsRequest, DescribeSubnetsResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Describes one or more of your subnets.</para> <para>For more information about subnets, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Subnets.html">Your VPC and Subnets</a> in the <i>Amazon Virtual Private
        /// Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeSubnets service method, as returned by AmazonEC2.</returns>
		public DescribeSubnetsResponse DescribeSubnets()
        {
            return this.DescribeSubnets(new DescribeSubnetsRequest());
        }
 
        /// <summary>
        /// <para>Describes one or more of the tags for your EC2 resources.</para> <para>For more information about tags, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_Tags.html">Tagging Your Resources</a> in the <i>Amazon Elastic Compute Cloud
        /// User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTags service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeTags service method, as returned by AmazonEC2.</returns>
		public DescribeTagsResponse DescribeTags(DescribeTagsRequest request)
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
        /// Initiates the asynchronous execution of the DescribeTags operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeTags"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DescribeTagsResponse> DescribeTagsAsync(DescribeTagsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeTagsRequestMarshaller();
            var unmarshaller = DescribeTagsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeTagsRequest, DescribeTagsResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Describes one or more of the tags for your EC2 resources.</para> <para>For more information about tags, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_Tags.html">Tagging Your Resources</a> in the <i>Amazon Elastic Compute Cloud
        /// User Guide</i> .</para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeTags service method, as returned by AmazonEC2.</returns>
		public DescribeTagsResponse DescribeTags()
        {
            return this.DescribeTags(new DescribeTagsRequest());
        }
 
        /// <summary>
        /// <para>Describes the specified attribute of the specified volume. You can specify only one attribute at a time.</para> <para>For more
        /// information about Amazon EBS volumes, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSVolumes.html">Amazon EBS
        /// Volumes</a> in the <i>Amazon Elastic Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVolumeAttribute service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeVolumeAttribute service method, as returned by AmazonEC2.</returns>
		public DescribeVolumeAttributeResponse DescribeVolumeAttribute(DescribeVolumeAttributeRequest request)
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
        /// Initiates the asynchronous execution of the DescribeVolumeAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeVolumeAttribute"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVolumeAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DescribeVolumeAttributeResponse> DescribeVolumeAttributeAsync(DescribeVolumeAttributeRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeVolumeAttributeRequestMarshaller();
            var unmarshaller = DescribeVolumeAttributeResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeVolumeAttributeRequest, DescribeVolumeAttributeResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Describes the specified Amazon EBS volumes.</para> <para>For more information about Amazon EBS volumes, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSVolumes.html">Amazon EBS Volumes</a> in the <i>Amazon Elastic Compute Cloud
        /// User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVolumes service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeVolumes service method, as returned by AmazonEC2.</returns>
		public DescribeVolumesResponse DescribeVolumes(DescribeVolumesRequest request)
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
        /// Initiates the asynchronous execution of the DescribeVolumes operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeVolumes"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVolumes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DescribeVolumesResponse> DescribeVolumesAsync(DescribeVolumesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeVolumesRequestMarshaller();
            var unmarshaller = DescribeVolumesResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeVolumesRequest, DescribeVolumesResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Describes the specified Amazon EBS volumes.</para> <para>For more information about Amazon EBS volumes, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSVolumes.html">Amazon EBS Volumes</a> in the <i>Amazon Elastic Compute Cloud
        /// User Guide</i> .</para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeVolumes service method, as returned by AmazonEC2.</returns>
		public DescribeVolumesResponse DescribeVolumes()
        {
            return this.DescribeVolumes(new DescribeVolumesRequest());
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
        /// <param name="request">Container for the necessary parameters to execute the DescribeVolumeStatus service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeVolumeStatus service method, as returned by AmazonEC2.</returns>
		public DescribeVolumeStatusResponse DescribeVolumeStatus(DescribeVolumeStatusRequest request)
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
        /// Initiates the asynchronous execution of the DescribeVolumeStatus operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeVolumeStatus"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVolumeStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DescribeVolumeStatusResponse> DescribeVolumeStatusAsync(DescribeVolumeStatusRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeVolumeStatusRequestMarshaller();
            var unmarshaller = DescribeVolumeStatusResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeVolumeStatusRequest, DescribeVolumeStatusResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
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
        /// 
        /// <returns>The response from the DescribeVolumeStatus service method, as returned by AmazonEC2.</returns>
		public DescribeVolumeStatusResponse DescribeVolumeStatus()
        {
            return this.DescribeVolumeStatus(new DescribeVolumeStatusRequest());
        }
 
        /// <summary>
        /// <para>Describes the specified attribute of the specified VPC. You can specify only one attribute at a time.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcAttribute service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeVpcAttribute service method, as returned by AmazonEC2.</returns>
		public DescribeVpcAttributeResponse DescribeVpcAttribute(DescribeVpcAttributeRequest request)
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
        /// Initiates the asynchronous execution of the DescribeVpcAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeVpcAttribute"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DescribeVpcAttributeResponse> DescribeVpcAttributeAsync(DescribeVpcAttributeRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeVpcAttributeRequestMarshaller();
            var unmarshaller = DescribeVpcAttributeResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeVpcAttributeRequest, DescribeVpcAttributeResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Describes one or more of your VPCs.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcs service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeVpcs service method, as returned by AmazonEC2.</returns>
		public DescribeVpcsResponse DescribeVpcs(DescribeVpcsRequest request)
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
        /// Initiates the asynchronous execution of the DescribeVpcs operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeVpcs"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DescribeVpcsResponse> DescribeVpcsAsync(DescribeVpcsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeVpcsRequestMarshaller();
            var unmarshaller = DescribeVpcsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeVpcsRequest, DescribeVpcsResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Describes one or more of your VPCs.</para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeVpcs service method, as returned by AmazonEC2.</returns>
		public DescribeVpcsResponse DescribeVpcs()
        {
            return this.DescribeVpcs(new DescribeVpcsRequest());
        }
 
        /// <summary>
        /// <para>Describes one or more of your VPN connections.</para> <para>For more information about VPN connections, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_VPN.html">Adding a Hardware Virtual Private Gateway to Your VPC</a> in the
        /// <i>Amazon Virtual Private Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpnConnections service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeVpnConnections service method, as returned by AmazonEC2.</returns>
		public DescribeVpnConnectionsResponse DescribeVpnConnections(DescribeVpnConnectionsRequest request)
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
        /// Initiates the asynchronous execution of the DescribeVpnConnections operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeVpnConnections"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpnConnections operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DescribeVpnConnectionsResponse> DescribeVpnConnectionsAsync(DescribeVpnConnectionsRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeVpnConnectionsRequestMarshaller();
            var unmarshaller = DescribeVpnConnectionsResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeVpnConnectionsRequest, DescribeVpnConnectionsResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Describes one or more of your VPN connections.</para> <para>For more information about VPN connections, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_VPN.html">Adding a Hardware Virtual Private Gateway to Your VPC</a> in the
        /// <i>Amazon Virtual Private Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeVpnConnections service method, as returned by AmazonEC2.</returns>
		public DescribeVpnConnectionsResponse DescribeVpnConnections()
        {
            return this.DescribeVpnConnections(new DescribeVpnConnectionsRequest());
        }
 
        /// <summary>
        /// <para>Describes one or more of your virtual private gateways.</para> <para>For more information about virtual private gateways, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_VPN.html">Adding an IPsec Hardware VPN to Your VPC</a> in the <i>Amazon
        /// Virtual Private Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpnGateways service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeVpnGateways service method, as returned by AmazonEC2.</returns>
		public DescribeVpnGatewaysResponse DescribeVpnGateways(DescribeVpnGatewaysRequest request)
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
        /// Initiates the asynchronous execution of the DescribeVpnGateways operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeVpnGateways"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpnGateways operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DescribeVpnGatewaysResponse> DescribeVpnGatewaysAsync(DescribeVpnGatewaysRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeVpnGatewaysRequestMarshaller();
            var unmarshaller = DescribeVpnGatewaysResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DescribeVpnGatewaysRequest, DescribeVpnGatewaysResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Describes one or more of your virtual private gateways.</para> <para>For more information about virtual private gateways, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_VPN.html">Adding an IPsec Hardware VPN to Your VPC</a> in the <i>Amazon
        /// Virtual Private Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// 
        /// <returns>The response from the DescribeVpnGateways service method, as returned by AmazonEC2.</returns>
		public DescribeVpnGatewaysResponse DescribeVpnGateways()
        {
            return this.DescribeVpnGateways(new DescribeVpnGatewaysRequest());
        }
 
        /// <summary>
        /// <para>Detaches an Internet gateway from a VPC, disabling connectivity between the Internet and the VPC. The VPC must not contain any running
        /// instances with Elastic IP addresses.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachInternetGateway service method on
        /// AmazonEC2.</param>
		public DetachInternetGatewayResponse DetachInternetGateway(DetachInternetGatewayRequest request)
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
        /// Initiates the asynchronous execution of the DetachInternetGateway operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DetachInternetGateway"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachInternetGateway operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DetachInternetGatewayResponse> DetachInternetGatewayAsync(DetachInternetGatewayRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DetachInternetGatewayRequestMarshaller();
            var unmarshaller = DetachInternetGatewayResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DetachInternetGatewayRequest, DetachInternetGatewayResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Detaches a network interface from an instance.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachNetworkInterface service method on
        /// AmazonEC2.</param>
		public DetachNetworkInterfaceResponse DetachNetworkInterface(DetachNetworkInterfaceRequest request)
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
        /// Initiates the asynchronous execution of the DetachNetworkInterface operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DetachNetworkInterface"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachNetworkInterface operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DetachNetworkInterfaceResponse> DetachNetworkInterfaceAsync(DetachNetworkInterfaceRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DetachNetworkInterfaceRequestMarshaller();
            var unmarshaller = DetachNetworkInterfaceResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DetachNetworkInterfaceRequest, DetachNetworkInterfaceResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
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
        /// <param name="request">Container for the necessary parameters to execute the DetachVolume service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the DetachVolume service method, as returned by AmazonEC2.</returns>
		public DetachVolumeResponse DetachVolume(DetachVolumeRequest request)
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
        /// Initiates the asynchronous execution of the DetachVolume operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DetachVolume"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachVolume operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DetachVolumeResponse> DetachVolumeAsync(DetachVolumeRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DetachVolumeRequestMarshaller();
            var unmarshaller = DetachVolumeResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DetachVolumeRequest, DetachVolumeResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Detaches a virtual private gateway from a VPC. You do this if you're planning to turn off the VPC and not use it anymore. You can
        /// confirm a virtual private gateway has been completely detached from a VPC by describing the virtual private gateway (any attachments to the
        /// virtual private gateway are also described).</para> <para>You must wait for the attachment's state to switch to <c>detached</c> before you
        /// can delete the VPC or attach a different VPC to the virtual private gateway.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachVpnGateway service method on
        /// AmazonEC2.</param>
		public DetachVpnGatewayResponse DetachVpnGateway(DetachVpnGatewayRequest request)
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
        /// Initiates the asynchronous execution of the DetachVpnGateway operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DetachVpnGateway"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachVpnGateway operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DetachVpnGatewayResponse> DetachVpnGatewayAsync(DetachVpnGatewayRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DetachVpnGatewayRequestMarshaller();
            var unmarshaller = DetachVpnGatewayResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DetachVpnGatewayRequest, DetachVpnGatewayResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Disables a virtual private gateway (VGW) from propagating routes to the routing tables of a VPC.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableVgwRoutePropagation service
        /// method on AmazonEC2.</param>
		public DisableVgwRoutePropagationResponse DisableVgwRoutePropagation(DisableVgwRoutePropagationRequest request)
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
        /// Initiates the asynchronous execution of the DisableVgwRoutePropagation operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DisableVgwRoutePropagation"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableVgwRoutePropagation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DisableVgwRoutePropagationResponse> DisableVgwRoutePropagationAsync(DisableVgwRoutePropagationRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DisableVgwRoutePropagationRequestMarshaller();
            var unmarshaller = DisableVgwRoutePropagationResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DisableVgwRoutePropagationRequest, DisableVgwRoutePropagationResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Disassociates an Elastic IP address from the instance or network interface it's associated with.</para> <para>This is an idempotent
        /// operation. If you perform the operation more than once, Amazon EC2 doesn't return an error.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateAddress service method on
        /// AmazonEC2.</param>
		public DisassociateAddressResponse DisassociateAddress(DisassociateAddressRequest request)
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
        /// Initiates the asynchronous execution of the DisassociateAddress operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DisassociateAddress"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateAddress operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DisassociateAddressResponse> DisassociateAddressAsync(DisassociateAddressRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DisassociateAddressRequestMarshaller();
            var unmarshaller = DisassociateAddressResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DisassociateAddressRequest, DisassociateAddressResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Disassociates a subnet from a route table.</para> <para>After you perform this action, the subnet no longer uses the routes in the
        /// route table. Instead, it uses the routes in the VPC's main route table. For more information about route tables, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Route_Tables.html">Route Tables</a> in the <i>Amazon Virtual Private Cloud
        /// User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateRouteTable service method on
        /// AmazonEC2.</param>
		public DisassociateRouteTableResponse DisassociateRouteTable(DisassociateRouteTableRequest request)
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
        /// Initiates the asynchronous execution of the DisassociateRouteTable operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DisassociateRouteTable"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateRouteTable operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<DisassociateRouteTableResponse> DisassociateRouteTableAsync(DisassociateRouteTableRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DisassociateRouteTableRequestMarshaller();
            var unmarshaller = DisassociateRouteTableResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, DisassociateRouteTableRequest, DisassociateRouteTableResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Enables a virtual private gateway (VGW) to propagate routes to the routing tables of a VPC.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableVgwRoutePropagation service
        /// method on AmazonEC2.</param>
		public EnableVgwRoutePropagationResponse EnableVgwRoutePropagation(EnableVgwRoutePropagationRequest request)
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
        /// Initiates the asynchronous execution of the EnableVgwRoutePropagation operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.EnableVgwRoutePropagation"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableVgwRoutePropagation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<EnableVgwRoutePropagationResponse> EnableVgwRoutePropagationAsync(EnableVgwRoutePropagationRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new EnableVgwRoutePropagationRequestMarshaller();
            var unmarshaller = EnableVgwRoutePropagationResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, EnableVgwRoutePropagationRequest, EnableVgwRoutePropagationResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Enables I/O operations for a volume that had I/O operations disabled because the data on the volume was potentially
        /// inconsistent.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableVolumeIO service method on
        /// AmazonEC2.</param>
		public EnableVolumeIOResponse EnableVolumeIO(EnableVolumeIORequest request)
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
        /// Initiates the asynchronous execution of the EnableVolumeIO operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.EnableVolumeIO"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableVolumeIO operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<EnableVolumeIOResponse> EnableVolumeIOAsync(EnableVolumeIORequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new EnableVolumeIORequestMarshaller();
            var unmarshaller = EnableVolumeIOResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, EnableVolumeIORequest, EnableVolumeIOResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
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
        /// <param name="request">Container for the necessary parameters to execute the GetConsoleOutput service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the GetConsoleOutput service method, as returned by AmazonEC2.</returns>
		public GetConsoleOutputResponse GetConsoleOutput(GetConsoleOutputRequest request)
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
        /// Initiates the asynchronous execution of the GetConsoleOutput operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.GetConsoleOutput"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetConsoleOutput operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<GetConsoleOutputResponse> GetConsoleOutputAsync(GetConsoleOutputRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetConsoleOutputRequestMarshaller();
            var unmarshaller = GetConsoleOutputResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, GetConsoleOutputRequest, GetConsoleOutputResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Retrieves the encrypted administrator password for an instance running Windows.</para> <para>The Windows password is only generated
        /// the first time an AMI is launched. It is not generated for rebundled AMIs or after the password is changed on an instance.</para> <para>The
        /// password is encrypted using the key pair that you specified when you launched the instance. You must provide the corresponding key pair
        /// file.</para> <para>Password generation and encryption takes a few moments. We recommend that you wait up to 15 minutes after launching an
        /// instance before trying to retrieve the generated password.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPasswordData service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the GetPasswordData service method, as returned by AmazonEC2.</returns>
		public GetPasswordDataResponse GetPasswordData(GetPasswordDataRequest request)
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
        /// Initiates the asynchronous execution of the GetPasswordData operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.GetPasswordData"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPasswordData operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<GetPasswordDataResponse> GetPasswordDataAsync(GetPasswordDataRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetPasswordDataRequestMarshaller();
            var unmarshaller = GetPasswordDataResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, GetPasswordDataRequest, GetPasswordDataResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Creates an import instance task using metadata from the specified disk image. After importing the image, you then upload it using the
        /// ec2-upload-disk-image command in the EC2 command line tools. For more information, see Using the Command Line Tools to Import Your Virtual
        /// Machine to Amazon EC2 in the Amazon Elastic Compute Cloud User Guide.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportInstance service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the ImportInstance service method, as returned by AmazonEC2.</returns>
		public ImportInstanceResponse ImportInstance(ImportInstanceRequest request)
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
        /// Initiates the asynchronous execution of the ImportInstance operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ImportInstance"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<ImportInstanceResponse> ImportInstanceAsync(ImportInstanceRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ImportInstanceRequestMarshaller();
            var unmarshaller = ImportInstanceResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, ImportInstanceRequest, ImportInstanceResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Imports the public key from an RSA key pair that you created with a third-party tool. Compare this with CreateKeyPair, in which AWS
        /// creates the key pair and gives the keys to you (AWS keeps a copy of the public key). With ImportKeyPair, you create the key pair and give
        /// AWS just the public key. The private key is never transferred between you and AWS.</para> <para>For more information about key pairs, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-key-pairs.html">Key Pairs</a> in the <i>Amazon Elastic Compute Cloud User
        /// Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportKeyPair service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the ImportKeyPair service method, as returned by AmazonEC2.</returns>
		public ImportKeyPairResponse ImportKeyPair(ImportKeyPairRequest request)
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
        /// Initiates the asynchronous execution of the ImportKeyPair operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ImportKeyPair"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportKeyPair operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<ImportKeyPairResponse> ImportKeyPairAsync(ImportKeyPairRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ImportKeyPairRequestMarshaller();
            var unmarshaller = ImportKeyPairResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, ImportKeyPairRequest, ImportKeyPairResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Creates an import volume task using metadata from the specified disk image. After importing the image, you then upload it using the
        /// ec2-upload-disk-image command in the Amazon EC2 command-line interface (CLI) tools. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/UploadingYourInstancesandVolumes.html">Using the Command Line Tools to Import Your
        /// Virtual Machine to Amazon EC2</a> in the <i>Amazon Elastic Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportVolume service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the ImportVolume service method, as returned by AmazonEC2.</returns>
		public ImportVolumeResponse ImportVolume(ImportVolumeRequest request)
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
        /// Initiates the asynchronous execution of the ImportVolume operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ImportVolume"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportVolume operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<ImportVolumeResponse> ImportVolumeAsync(ImportVolumeRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ImportVolumeRequestMarshaller();
            var unmarshaller = ImportVolumeResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, ImportVolumeRequest, ImportVolumeResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Modifies the specified attribute of the specified AMI. You can specify only one attribute at a time.</para> <para><b>NOTE:</b> AWS
        /// Marketplace product codes cannot be modified. Images with an AWS Marketplace product code cannot be made public. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyImageAttribute service method on
        /// AmazonEC2.</param>
		public ModifyImageAttributeResponse ModifyImageAttribute(ModifyImageAttributeRequest request)
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
        /// Initiates the asynchronous execution of the ModifyImageAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ModifyImageAttribute"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyImageAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<ModifyImageAttributeResponse> ModifyImageAttributeAsync(ModifyImageAttributeRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ModifyImageAttributeRequestMarshaller();
            var unmarshaller = ModifyImageAttributeResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, ModifyImageAttributeRequest, ModifyImageAttributeResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Modifies the specified attribute of the specified instance. You can specify only one attribute at a time.</para> <para>To modify some
        /// attributes, the instance must be stopped. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_ChangingAttributesWhileInstanceStopped.html">Modifying Attributes of a
        /// Stopped Instance</a> in the <i>Amazon Elastic Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyInstanceAttribute service method on
        /// AmazonEC2.</param>
		public ModifyInstanceAttributeResponse ModifyInstanceAttribute(ModifyInstanceAttributeRequest request)
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
        /// Initiates the asynchronous execution of the ModifyInstanceAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ModifyInstanceAttribute"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyInstanceAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<ModifyInstanceAttributeResponse> ModifyInstanceAttributeAsync(ModifyInstanceAttributeRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ModifyInstanceAttributeRequestMarshaller();
            var unmarshaller = ModifyInstanceAttributeResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, ModifyInstanceAttributeRequest, ModifyInstanceAttributeResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Modifies the specified network interface attribute. You can specify only one attribute at a time.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyNetworkInterfaceAttribute
        /// service method on AmazonEC2.</param>
		public ModifyNetworkInterfaceAttributeResponse ModifyNetworkInterfaceAttribute(ModifyNetworkInterfaceAttributeRequest request)
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
        /// Initiates the asynchronous execution of the ModifyNetworkInterfaceAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ModifyNetworkInterfaceAttribute"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyNetworkInterfaceAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<ModifyNetworkInterfaceAttributeResponse> ModifyNetworkInterfaceAttributeAsync(ModifyNetworkInterfaceAttributeRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ModifyNetworkInterfaceAttributeRequestMarshaller();
            var unmarshaller = ModifyNetworkInterfaceAttributeResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, ModifyNetworkInterfaceAttributeRequest, ModifyNetworkInterfaceAttributeResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Modifies the Availability Zone, instance count, instance type, or network platform (EC2-Classic or EC2-VPC) of your Reserved
        /// Instances. The Reserved Instances to be modified must be identical, except for Availability Zone, network platform, and instance
        /// type.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyReservedInstances service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the ModifyReservedInstances service method, as returned by AmazonEC2.</returns>
		public ModifyReservedInstancesResponse ModifyReservedInstances(ModifyReservedInstancesRequest request)
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
        /// Initiates the asynchronous execution of the ModifyReservedInstances operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ModifyReservedInstances"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyReservedInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<ModifyReservedInstancesResponse> ModifyReservedInstancesAsync(ModifyReservedInstancesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ModifyReservedInstancesRequestMarshaller();
            var unmarshaller = ModifyReservedInstancesResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, ModifyReservedInstancesRequest, ModifyReservedInstancesResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Adds or removes permission settings for the specified snapshot.</para> <para>For more information on modifying snapshot permissions,
        /// see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-modifying-snapshot-permissions.html">Sharing Snapshots</a> in the
        /// <i>Amazon Elastic Compute Cloud User Guide</i> .</para> <para><b>NOTE:</b> Snapshots with AWS Marketplace product codes cannot be made
        /// public. </para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifySnapshotAttribute service method on
        /// AmazonEC2.</param>
		public ModifySnapshotAttributeResponse ModifySnapshotAttribute(ModifySnapshotAttributeRequest request)
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
        /// Initiates the asynchronous execution of the ModifySnapshotAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ModifySnapshotAttribute"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifySnapshotAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<ModifySnapshotAttributeResponse> ModifySnapshotAttributeAsync(ModifySnapshotAttributeRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ModifySnapshotAttributeRequestMarshaller();
            var unmarshaller = ModifySnapshotAttributeResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, ModifySnapshotAttributeRequest, ModifySnapshotAttributeResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Modifies a volume attribute.</para> <para>By default, all I/O operations for the volume are suspended when the data on the volume is
        /// determined to be potentially inconsistent, to prevent undetectable, latent data corruption. The I/O access to the volume can be resumed by
        /// first enabling I/O access and then checking the data consistency on your volume.</para> <para>You can change the default behavior to resume
        /// I/O operations. We recommend that you change this only for boot volumes or for volumes that are stateless or disposable.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyVolumeAttribute service method on
        /// AmazonEC2.</param>
		public ModifyVolumeAttributeResponse ModifyVolumeAttribute(ModifyVolumeAttributeRequest request)
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
        /// Initiates the asynchronous execution of the ModifyVolumeAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ModifyVolumeAttribute"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyVolumeAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<ModifyVolumeAttributeResponse> ModifyVolumeAttributeAsync(ModifyVolumeAttributeRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ModifyVolumeAttributeRequestMarshaller();
            var unmarshaller = ModifyVolumeAttributeResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, ModifyVolumeAttributeRequest, ModifyVolumeAttributeResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Modifies the specified attribute of the specified VPC.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyVpcAttribute service method on
        /// AmazonEC2.</param>
		public ModifyVpcAttributeResponse ModifyVpcAttribute(ModifyVpcAttributeRequest request)
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
        /// Initiates the asynchronous execution of the ModifyVpcAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ModifyVpcAttribute"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyVpcAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<ModifyVpcAttributeResponse> ModifyVpcAttributeAsync(ModifyVpcAttributeRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ModifyVpcAttributeRequestMarshaller();
            var unmarshaller = ModifyVpcAttributeResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, ModifyVpcAttributeRequest, ModifyVpcAttributeResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Enables monitoring for a running instance. For more information about monitoring instances, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-cloudwatch.html">Monitoring Your Instances and Volumes</a> in the <i>Amazon
        /// Elastic Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the MonitorInstances service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the MonitorInstances service method, as returned by AmazonEC2.</returns>
		public MonitorInstancesResponse MonitorInstances(MonitorInstancesRequest request)
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
        /// Initiates the asynchronous execution of the MonitorInstances operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.MonitorInstances"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the MonitorInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<MonitorInstancesResponse> MonitorInstancesAsync(MonitorInstancesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new MonitorInstancesRequestMarshaller();
            var unmarshaller = MonitorInstancesResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, MonitorInstancesRequest, MonitorInstancesResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Purchases a Reserved Instance for use with your account. With Amazon EC2 Reserved Instances, you obtain a capacity reservation for a
        /// certain instance configuration over a specified period of time. You pay a lower usage rate than with On-Demand instances for the time that
        /// you actually use the capacity reservation.</para> <para>For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ri-market-general.html">Reserved Instance Marketplace</a> in the <i>Amazon Elastic
        /// Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the
        /// PurchaseReservedInstancesOffering service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the PurchaseReservedInstancesOffering service method, as returned by AmazonEC2.</returns>
		public PurchaseReservedInstancesOfferingResponse PurchaseReservedInstancesOffering(PurchaseReservedInstancesOfferingRequest request)
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
        /// Initiates the asynchronous execution of the PurchaseReservedInstancesOffering operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.PurchaseReservedInstancesOffering"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PurchaseReservedInstancesOffering operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<PurchaseReservedInstancesOfferingResponse> PurchaseReservedInstancesOfferingAsync(PurchaseReservedInstancesOfferingRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PurchaseReservedInstancesOfferingRequestMarshaller();
            var unmarshaller = PurchaseReservedInstancesOfferingResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, PurchaseReservedInstancesOfferingRequest, PurchaseReservedInstancesOfferingResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Requests a reboot of one or more instances. This operation is asynchronous; it only queues a request to reboot the specified
        /// instances. The operation succeeds if the instances are valid and belong to you. Requests to reboot terminated instances are ignored.</para>
        /// <para>If a Linux/Unix instance does not cleanly shut down within four minutes, Amazon EC2 performs a hard reboot.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RebootInstances service method on
        /// AmazonEC2.</param>
		public RebootInstancesResponse RebootInstances(RebootInstancesRequest request)
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
        /// Initiates the asynchronous execution of the RebootInstances operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.RebootInstances"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RebootInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<RebootInstancesResponse> RebootInstancesAsync(RebootInstancesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RebootInstancesRequestMarshaller();
            var unmarshaller = RebootInstancesResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, RebootInstancesRequest, RebootInstancesResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
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
        /// <param name="request">Container for the necessary parameters to execute the RegisterImage service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the RegisterImage service method, as returned by AmazonEC2.</returns>
		public RegisterImageResponse RegisterImage(RegisterImageRequest request)
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
        /// Initiates the asynchronous execution of the RegisterImage operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.RegisterImage"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterImage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<RegisterImageResponse> RegisterImageAsync(RegisterImageRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RegisterImageRequestMarshaller();
            var unmarshaller = RegisterImageResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, RegisterImageRequest, RegisterImageResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
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
        /// <param name="request">Container for the necessary parameters to execute the ReleaseAddress service method on
        /// AmazonEC2.</param>
		public ReleaseAddressResponse ReleaseAddress(ReleaseAddressRequest request)
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
        /// Initiates the asynchronous execution of the ReleaseAddress operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ReleaseAddress"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReleaseAddress operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<ReleaseAddressResponse> ReleaseAddressAsync(ReleaseAddressRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ReleaseAddressRequestMarshaller();
            var unmarshaller = ReleaseAddressResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, ReleaseAddressRequest, ReleaseAddressResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Changes which network ACL a subnet is associated with. By default when you create a subnet, it's automatically associated with the
        /// default network ACL. For more information about network ACLs, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_ACLs.html">Network ACLs</a> in the <i>Amazon Virtual Private Cloud User
        /// Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReplaceNetworkAclAssociation service
        /// method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the ReplaceNetworkAclAssociation service method, as returned by AmazonEC2.</returns>
		public ReplaceNetworkAclAssociationResponse ReplaceNetworkAclAssociation(ReplaceNetworkAclAssociationRequest request)
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
        /// Initiates the asynchronous execution of the ReplaceNetworkAclAssociation operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ReplaceNetworkAclAssociation"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReplaceNetworkAclAssociation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<ReplaceNetworkAclAssociationResponse> ReplaceNetworkAclAssociationAsync(ReplaceNetworkAclAssociationRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ReplaceNetworkAclAssociationRequestMarshaller();
            var unmarshaller = ReplaceNetworkAclAssociationResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, ReplaceNetworkAclAssociationRequest, ReplaceNetworkAclAssociationResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Replaces an entry (rule) in a network ACL. For more information about network ACLs, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_ACLs.html">Network ACLs</a> in the <i>Amazon Virtual Private Cloud User
        /// Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReplaceNetworkAclEntry service method on
        /// AmazonEC2.</param>
		public ReplaceNetworkAclEntryResponse ReplaceNetworkAclEntry(ReplaceNetworkAclEntryRequest request)
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
        /// Initiates the asynchronous execution of the ReplaceNetworkAclEntry operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ReplaceNetworkAclEntry"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReplaceNetworkAclEntry operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<ReplaceNetworkAclEntryResponse> ReplaceNetworkAclEntryAsync(ReplaceNetworkAclEntryRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ReplaceNetworkAclEntryRequestMarshaller();
            var unmarshaller = ReplaceNetworkAclEntryResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, ReplaceNetworkAclEntryRequest, ReplaceNetworkAclEntryResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Replaces an existing route within a route table in a VPC. You must provide only one of the following: Internet gateway, NAT instance,
        /// or network interface.</para> <para>For more information about route tables, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Route_Tables.html">Route Tables</a> in the <i>Amazon Virtual Private Cloud
        /// User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReplaceRoute service method on AmazonEC2.</param>
		public ReplaceRouteResponse ReplaceRoute(ReplaceRouteRequest request)
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
        /// Initiates the asynchronous execution of the ReplaceRoute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ReplaceRoute"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReplaceRoute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<ReplaceRouteResponse> ReplaceRouteAsync(ReplaceRouteRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ReplaceRouteRequestMarshaller();
            var unmarshaller = ReplaceRouteResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, ReplaceRouteRequest, ReplaceRouteResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Changes the route table associated with a given subnet in a VPC. After the operation completes, the subnet uses the routes in the new
        /// route table it's associated with. For more information about route tables, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Route_Tables.html">Route Tables</a> in the <i>Amazon Virtual Private Cloud
        /// User Guide</i> .</para> <para>You can also use ReplaceRouteTableAssociation to change which table is the main route table in the VPC. You
        /// just specify the main route table's association ID and the route table to be the new main route table.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReplaceRouteTableAssociation service
        /// method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the ReplaceRouteTableAssociation service method, as returned by AmazonEC2.</returns>
		public ReplaceRouteTableAssociationResponse ReplaceRouteTableAssociation(ReplaceRouteTableAssociationRequest request)
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
        /// Initiates the asynchronous execution of the ReplaceRouteTableAssociation operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ReplaceRouteTableAssociation"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReplaceRouteTableAssociation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<ReplaceRouteTableAssociationResponse> ReplaceRouteTableAssociationAsync(ReplaceRouteTableAssociationRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ReplaceRouteTableAssociationRequestMarshaller();
            var unmarshaller = ReplaceRouteTableAssociationResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, ReplaceRouteTableAssociationRequest, ReplaceRouteTableAssociationResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Submits feedback about the status of an instance. The instance must be in the <c>running</c> state. If your experience with the
        /// instance differs from the instance status returned by DescribeInstanceStatus, use ReportInstanceStatus to report your experience with the
        /// instance. Amazon EC2 collects this information to improve the accuracy of status checks.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReportInstanceStatus service method on
        /// AmazonEC2.</param>
		public ReportInstanceStatusResponse ReportInstanceStatus(ReportInstanceStatusRequest request)
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
        /// Initiates the asynchronous execution of the ReportInstanceStatus operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ReportInstanceStatus"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReportInstanceStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<ReportInstanceStatusResponse> ReportInstanceStatusAsync(ReportInstanceStatusRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ReportInstanceStatusRequestMarshaller();
            var unmarshaller = ReportInstanceStatusResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, ReportInstanceStatusRequest, ReportInstanceStatusResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Creates a Spot Instance request. Spot Instances are instances that Amazon EC2 starts on your behalf when the maximum price that you
        /// specify exceeds the current Spot Price. Amazon EC2 periodically sets the Spot Price based on available Spot Instance capacity and current
        /// Spot Instance requests. For more information about Spot Instances, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-spot-instances.html">Spot Instances</a> in the <i>Amazon Elastic Compute
        /// Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RequestSpotInstances service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the RequestSpotInstances service method, as returned by AmazonEC2.</returns>
		public RequestSpotInstancesResponse RequestSpotInstances(RequestSpotInstancesRequest request)
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
        /// Initiates the asynchronous execution of the RequestSpotInstances operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.RequestSpotInstances"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RequestSpotInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<RequestSpotInstancesResponse> RequestSpotInstancesAsync(RequestSpotInstancesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RequestSpotInstancesRequestMarshaller();
            var unmarshaller = RequestSpotInstancesResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, RequestSpotInstancesRequest, RequestSpotInstancesResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Resets an attribute of an AMI to its default value.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetImageAttribute service method on
        /// AmazonEC2.</param>
		public ResetImageAttributeResponse ResetImageAttribute(ResetImageAttributeRequest request)
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
        /// Initiates the asynchronous execution of the ResetImageAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ResetImageAttribute"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetImageAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<ResetImageAttributeResponse> ResetImageAttributeAsync(ResetImageAttributeRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ResetImageAttributeRequestMarshaller();
            var unmarshaller = ResetImageAttributeResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, ResetImageAttributeRequest, ResetImageAttributeResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Resets an attribute of an instance to its default value. To reset the kernel or RAM disk, the instance must be in a stopped state. To
        /// reset the <c>SourceDestCheck</c> , the instance can be either running or stopped.</para> <para>The <c>SourceDestCheck</c> attribute controls
        /// whether source/destination checking is enabled. The default value is <c>true</c> , which means checking is enabled. This value must be
        /// <c>false</c> for a NAT instance to perform NAT. For more information, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_NAT_Instance.html">NAT Instances</a> in the <i>Amazon Virtual Private Cloud
        /// User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetInstanceAttribute service method on
        /// AmazonEC2.</param>
		public ResetInstanceAttributeResponse ResetInstanceAttribute(ResetInstanceAttributeRequest request)
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
        /// Initiates the asynchronous execution of the ResetInstanceAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ResetInstanceAttribute"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetInstanceAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<ResetInstanceAttributeResponse> ResetInstanceAttributeAsync(ResetInstanceAttributeRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ResetInstanceAttributeRequestMarshaller();
            var unmarshaller = ResetInstanceAttributeResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, ResetInstanceAttributeRequest, ResetInstanceAttributeResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Resets a network interface attribute. You can specify only one attribute at a time.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetNetworkInterfaceAttribute
        /// service method on AmazonEC2.</param>
		public ResetNetworkInterfaceAttributeResponse ResetNetworkInterfaceAttribute(ResetNetworkInterfaceAttributeRequest request)
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
        /// Initiates the asynchronous execution of the ResetNetworkInterfaceAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ResetNetworkInterfaceAttribute"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetNetworkInterfaceAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<ResetNetworkInterfaceAttributeResponse> ResetNetworkInterfaceAttributeAsync(ResetNetworkInterfaceAttributeRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ResetNetworkInterfaceAttributeRequestMarshaller();
            var unmarshaller = ResetNetworkInterfaceAttributeResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, ResetNetworkInterfaceAttributeRequest, ResetNetworkInterfaceAttributeResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Resets permission settings for the specified snapshot.</para> <para>For more information on modifying snapshot permissions, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-modifying-snapshot-permissions.html">Sharing Snapshots</a> in the <i>Amazon
        /// Elastic Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetSnapshotAttribute service method on
        /// AmazonEC2.</param>
		public ResetSnapshotAttributeResponse ResetSnapshotAttribute(ResetSnapshotAttributeRequest request)
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
        /// Initiates the asynchronous execution of the ResetSnapshotAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ResetSnapshotAttribute"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetSnapshotAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<ResetSnapshotAttributeResponse> ResetSnapshotAttributeAsync(ResetSnapshotAttributeRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ResetSnapshotAttributeRequestMarshaller();
            var unmarshaller = ResetSnapshotAttributeResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, ResetSnapshotAttributeRequest, ResetSnapshotAttributeResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Removes one or more egress rules from a security group for EC2-VPC. The values that you specify in the revoke request (for example,
        /// ports) must match the existing rule's values for the rule to be revoked.</para> <para>Each rule consists of the protocol and the CIDR range
        /// or source security group. For the TCP and UDP protocols, you must also specify the destination port or range of ports. For the ICMP
        /// protocol, you must also specify the ICMP type and code.</para> <para>Rule changes are propagated to instances within the security group as
        /// quickly as possible. However, a small delay might occur.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RevokeSecurityGroupEgress service
        /// method on AmazonEC2.</param>
		public RevokeSecurityGroupEgressResponse RevokeSecurityGroupEgress(RevokeSecurityGroupEgressRequest request)
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
        /// Initiates the asynchronous execution of the RevokeSecurityGroupEgress operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.RevokeSecurityGroupEgress"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RevokeSecurityGroupEgress operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<RevokeSecurityGroupEgressResponse> RevokeSecurityGroupEgressAsync(RevokeSecurityGroupEgressRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RevokeSecurityGroupEgressRequestMarshaller();
            var unmarshaller = RevokeSecurityGroupEgressResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, RevokeSecurityGroupEgressRequest, RevokeSecurityGroupEgressResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Removes one or more ingress rules from a security group. The values that you specify in the revoke request (for example, ports) must
        /// match the existing rule's values for the rule to be removed.</para> <para>Each rule consists of the protocol and the CIDR range or source
        /// security group. For the TCP and UDP protocols, you must also specify the destination port or range of ports. For the ICMP protocol, you must
        /// also specify the ICMP type and code.</para> <para>Rule changes are propagated to instances within the security group as quickly as possible.
        /// However, a small delay might occur.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RevokeSecurityGroupIngress service
        /// method on AmazonEC2.</param>
		public RevokeSecurityGroupIngressResponse RevokeSecurityGroupIngress(RevokeSecurityGroupIngressRequest request)
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
        /// Initiates the asynchronous execution of the RevokeSecurityGroupIngress operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.RevokeSecurityGroupIngress"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RevokeSecurityGroupIngress operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<RevokeSecurityGroupIngressResponse> RevokeSecurityGroupIngressAsync(RevokeSecurityGroupIngressRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RevokeSecurityGroupIngressRequestMarshaller();
            var unmarshaller = RevokeSecurityGroupIngressResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, RevokeSecurityGroupIngressRequest, RevokeSecurityGroupIngressResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
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
        /// <param name="request">Container for the necessary parameters to execute the RunInstances service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the RunInstances service method, as returned by AmazonEC2.</returns>
		public RunInstancesResponse RunInstances(RunInstancesRequest request)
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
        /// Initiates the asynchronous execution of the RunInstances operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.RunInstances"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RunInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<RunInstancesResponse> RunInstancesAsync(RunInstancesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RunInstancesRequestMarshaller();
            var unmarshaller = RunInstancesResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, RunInstancesRequest, RunInstancesResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
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
        /// <param name="request">Container for the necessary parameters to execute the StartInstances service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the StartInstances service method, as returned by AmazonEC2.</returns>
		public StartInstancesResponse StartInstances(StartInstancesRequest request)
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
        /// Initiates the asynchronous execution of the StartInstances operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.StartInstances"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<StartInstancesResponse> StartInstancesAsync(StartInstancesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new StartInstancesRequestMarshaller();
            var unmarshaller = StartInstancesResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, StartInstancesRequest, StartInstancesResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
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
        /// <param name="request">Container for the necessary parameters to execute the StopInstances service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the StopInstances service method, as returned by AmazonEC2.</returns>
		public StopInstancesResponse StopInstances(StopInstancesRequest request)
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
        /// Initiates the asynchronous execution of the StopInstances operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.StopInstances"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<StopInstancesResponse> StopInstancesAsync(StopInstancesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new StopInstancesRequestMarshaller();
            var unmarshaller = StopInstancesResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, StopInstancesRequest, StopInstancesResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
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
        /// <param name="request">Container for the necessary parameters to execute the TerminateInstances service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the TerminateInstances service method, as returned by AmazonEC2.</returns>
		public TerminateInstancesResponse TerminateInstances(TerminateInstancesRequest request)
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
        /// Initiates the asynchronous execution of the TerminateInstances operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.TerminateInstances"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TerminateInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<TerminateInstancesResponse> TerminateInstancesAsync(TerminateInstancesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new TerminateInstancesRequestMarshaller();
            var unmarshaller = TerminateInstancesResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, TerminateInstancesRequest, TerminateInstancesResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Unassigns one or more secondary private IP addresses from a network interface.</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UnassignPrivateIpAddresses service
        /// method on AmazonEC2.</param>
		public UnassignPrivateIpAddressesResponse UnassignPrivateIpAddresses(UnassignPrivateIpAddressesRequest request)
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
        /// Initiates the asynchronous execution of the UnassignPrivateIpAddresses operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.UnassignPrivateIpAddresses"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UnassignPrivateIpAddresses operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<UnassignPrivateIpAddressesResponse> UnassignPrivateIpAddressesAsync(UnassignPrivateIpAddressesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UnassignPrivateIpAddressesRequestMarshaller();
            var unmarshaller = UnassignPrivateIpAddressesResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, UnassignPrivateIpAddressesRequest, UnassignPrivateIpAddressesResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
 
        /// <summary>
        /// <para>Disables monitoring for a running instance. For more information about monitoring instances, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-cloudwatch.html">Monitoring Your Instances and Volumes</a> in the <i>Amazon
        /// Elastic Compute Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UnmonitorInstances service method on
        /// AmazonEC2.</param>
        /// 
        /// <returns>The response from the UnmonitorInstances service method, as returned by AmazonEC2.</returns>
		public UnmonitorInstancesResponse UnmonitorInstances(UnmonitorInstancesRequest request)
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
        /// Initiates the asynchronous execution of the UnmonitorInstances operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.UnmonitorInstances"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UnmonitorInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
		public Task<UnmonitorInstancesResponse> UnmonitorInstancesAsync(UnmonitorInstancesRequest request, CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UnmonitorInstancesRequestMarshaller();
            var unmarshaller = UnmonitorInstancesResponseUnmarshaller.GetInstance();
            return Invoke<IRequest, UnmonitorInstancesRequest, UnmonitorInstancesResponse>(request, marshaller, unmarshaller, signer, cancellationToken);
        }
    }
}
