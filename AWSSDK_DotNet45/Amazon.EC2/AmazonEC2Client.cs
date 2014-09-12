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
 * Do not modify this file. This file is generated from the ec2-2014-06-15.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;

using Amazon.EC2.Model;
using Amazon.EC2.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.EC2
{
    /// <summary>
    /// Implementation for accessing EC2
    ///
    /// Amazon Elastic Compute Cloud 
    /// <para>
    /// Amazon Elastic Compute Cloud (Amazon EC2) provides resizable computing capacity in
    /// the Amazon Web Services (AWS) cloud. Using Amazon EC2 eliminates your need to invest
    /// in hardware up front, so you can develop and deploy applications faster.
    /// </para>
    /// </summary>
    public partial class AmazonEC2Client : AmazonServiceClient, IAmazonEC2
    {
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
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonEC2Client()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonEC2Config()) { }

        /// <summary>
        /// Constructs AmazonEC2Client with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="region">The region to connect.</param>
        public AmazonEC2Client(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonEC2Config{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonEC2Client with the credentials loaded from the application's
        /// default configuration, and if unsuccessful from the Instance Profile service on an EC2 instance.
        /// 
        /// Example App.config with credentials set. 
        /// <code>
        /// &lt;?xml version="1.0" encoding="utf-8" ?&gt;
        /// &lt;configuration&gt;
        ///     &lt;appSettings&gt;
        ///         &lt;add key="AWSProfileName" value="AWS Default"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        /// <param name="config">The AmazonEC2Client Configuration Object</param>
        public AmazonEC2Client(AmazonEC2Config config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }

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
            : this(credentials, new AmazonEC2Config{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonEC2Client with AWS Credentials and an
        /// AmazonEC2Client Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonEC2Client Configuration Object</param>
        public AmazonEC2Client(AWSCredentials credentials, AmazonEC2Config clientConfig)
            : base(credentials, clientConfig)
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
        /// AmazonEC2Client Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonEC2Client Configuration Object</param>
        public AmazonEC2Client(string awsAccessKeyId, string awsSecretAccessKey, AmazonEC2Config clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
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
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonEC2Config{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonEC2Client with AWS Access Key ID, AWS Secret Key and an
        /// AmazonEC2Client Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonEC2Client Configuration Object</param>
        public AmazonEC2Client(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonEC2Config clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion

        #region Overrides

        protected override AbstractAWSSigner CreateSigner()
        {
            return new EC2Signer();
        }    

        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.AddHandlerBefore<Amazon.Runtime.Internal.Marshaller>(new Amazon.EC2.Internal.AmazonEC2PreMarshallHandler(this.Credentials));
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new Amazon.EC2.Internal.AmazonEC2PostMarshallHandler());
            pipeline.AddHandlerBefore<Amazon.Runtime.Internal.Unmarshaller>(new Amazon.EC2.Internal.AmazonEC2ResponseHandler());
        }    

        #endregion

        #region Dispose

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion

        
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
        public AcceptVpcPeeringConnectionResponse AcceptVpcPeeringConnection(AcceptVpcPeeringConnectionRequest request)
        {
            var marshaller = new AcceptVpcPeeringConnectionRequestMarshaller();
            var unmarshaller = AcceptVpcPeeringConnectionResponseUnmarshaller.Instance;

            return Invoke<AcceptVpcPeeringConnectionRequest,AcceptVpcPeeringConnectionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AcceptVpcPeeringConnection operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AcceptVpcPeeringConnection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<AcceptVpcPeeringConnectionResponse> AcceptVpcPeeringConnectionAsync(AcceptVpcPeeringConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AcceptVpcPeeringConnectionRequestMarshaller();
            var unmarshaller = AcceptVpcPeeringConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<AcceptVpcPeeringConnectionRequest,AcceptVpcPeeringConnectionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public AllocateAddressResponse AllocateAddress()
        {
            return AllocateAddress(new AllocateAddressRequest());
        }

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
        public AllocateAddressResponse AllocateAddress(AllocateAddressRequest request)
        {
            var marshaller = new AllocateAddressRequestMarshaller();
            var unmarshaller = AllocateAddressResponseUnmarshaller.Instance;

            return Invoke<AllocateAddressRequest,AllocateAddressResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AllocateAddress operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AllocateAddress operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<AllocateAddressResponse> AllocateAddressAsync(AllocateAddressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AllocateAddressRequestMarshaller();
            var unmarshaller = AllocateAddressResponseUnmarshaller.Instance;

            return InvokeAsync<AllocateAddressRequest,AllocateAddressResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public AssignPrivateIpAddressesResponse AssignPrivateIpAddresses(AssignPrivateIpAddressesRequest request)
        {
            var marshaller = new AssignPrivateIpAddressesRequestMarshaller();
            var unmarshaller = AssignPrivateIpAddressesResponseUnmarshaller.Instance;

            return Invoke<AssignPrivateIpAddressesRequest,AssignPrivateIpAddressesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssignPrivateIpAddresses operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssignPrivateIpAddresses operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<AssignPrivateIpAddressesResponse> AssignPrivateIpAddressesAsync(AssignPrivateIpAddressesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AssignPrivateIpAddressesRequestMarshaller();
            var unmarshaller = AssignPrivateIpAddressesResponseUnmarshaller.Instance;

            return InvokeAsync<AssignPrivateIpAddressesRequest,AssignPrivateIpAddressesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        /// [EC2-Classic, default VPC] If the Elastic IP address is already associated with a
        /// different instance, it is disassociated from that instance and associated with the
        /// specified instance.
        /// </para>
        ///  
        /// <para>
        /// [EC2-VPC] If you don't specify a private IP address, the Elastic IP address is associated
        /// with the primary IP address. If the Elastic IP address is already associated with
        /// a different instance or a network interface, you get an error unless you allow reassociation.
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
        public AssociateAddressResponse AssociateAddress(AssociateAddressRequest request)
        {
            var marshaller = new AssociateAddressRequestMarshaller();
            var unmarshaller = AssociateAddressResponseUnmarshaller.Instance;

            return Invoke<AssociateAddressRequest,AssociateAddressResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateAddress operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateAddress operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<AssociateAddressResponse> AssociateAddressAsync(AssociateAddressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AssociateAddressRequestMarshaller();
            var unmarshaller = AssociateAddressResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateAddressRequest,AssociateAddressResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public AssociateDhcpOptionsResponse AssociateDhcpOptions(AssociateDhcpOptionsRequest request)
        {
            var marshaller = new AssociateDhcpOptionsRequestMarshaller();
            var unmarshaller = AssociateDhcpOptionsResponseUnmarshaller.Instance;

            return Invoke<AssociateDhcpOptionsRequest,AssociateDhcpOptionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateDhcpOptions operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateDhcpOptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<AssociateDhcpOptionsResponse> AssociateDhcpOptionsAsync(AssociateDhcpOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AssociateDhcpOptionsRequestMarshaller();
            var unmarshaller = AssociateDhcpOptionsResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateDhcpOptionsRequest,AssociateDhcpOptionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public AssociateRouteTableResponse AssociateRouteTable(AssociateRouteTableRequest request)
        {
            var marshaller = new AssociateRouteTableRequestMarshaller();
            var unmarshaller = AssociateRouteTableResponseUnmarshaller.Instance;

            return Invoke<AssociateRouteTableRequest,AssociateRouteTableResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateRouteTable operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateRouteTable operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<AssociateRouteTableResponse> AssociateRouteTableAsync(AssociateRouteTableRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AssociateRouteTableRequestMarshaller();
            var unmarshaller = AssociateRouteTableResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateRouteTableRequest,AssociateRouteTableResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  AttachInternetGateway

        /// <summary>
        /// Attaches an Internet gateway to a VPC, enabling connectivity between the Internet
        /// and the VPC. For more information about your VPC and Internet gateway, see the <a
        /// href="http://docs.&awsdomain;/AmazonVPC/latest/UserGuide/">Amazon Virtual Private
        /// Cloud User Guide</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachInternetGateway service method.</param>
        /// 
        /// <returns>The response from the AttachInternetGateway service method, as returned by EC2.</returns>
        public AttachInternetGatewayResponse AttachInternetGateway(AttachInternetGatewayRequest request)
        {
            var marshaller = new AttachInternetGatewayRequestMarshaller();
            var unmarshaller = AttachInternetGatewayResponseUnmarshaller.Instance;

            return Invoke<AttachInternetGatewayRequest,AttachInternetGatewayResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AttachInternetGateway operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachInternetGateway operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<AttachInternetGatewayResponse> AttachInternetGatewayAsync(AttachInternetGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AttachInternetGatewayRequestMarshaller();
            var unmarshaller = AttachInternetGatewayResponseUnmarshaller.Instance;

            return InvokeAsync<AttachInternetGatewayRequest,AttachInternetGatewayResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  AttachNetworkInterface

        /// <summary>
        /// Attaches a network interface to an instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachNetworkInterface service method.</param>
        /// 
        /// <returns>The response from the AttachNetworkInterface service method, as returned by EC2.</returns>
        public AttachNetworkInterfaceResponse AttachNetworkInterface(AttachNetworkInterfaceRequest request)
        {
            var marshaller = new AttachNetworkInterfaceRequestMarshaller();
            var unmarshaller = AttachNetworkInterfaceResponseUnmarshaller.Instance;

            return Invoke<AttachNetworkInterfaceRequest,AttachNetworkInterfaceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AttachNetworkInterface operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachNetworkInterface operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<AttachNetworkInterfaceResponse> AttachNetworkInterfaceAsync(AttachNetworkInterfaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AttachNetworkInterfaceRequestMarshaller();
            var unmarshaller = AttachNetworkInterfaceResponseUnmarshaller.Instance;

            return InvokeAsync<AttachNetworkInterfaceRequest,AttachNetworkInterfaceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  AttachVolume

        /// <summary>
        /// Attaches an Amazon EBS volume to a running or stopped instance and exposes it to the
        /// instance with the specified device name.
        /// 
        ///  
        /// <para>
        /// Encrypted Amazon EBS volumes may only be attached to instances that support Amazon
        /// EBS encryption. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSEncryption.html">Amazon
        /// EBS Encryption</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// For a list of supported device names, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-attaching-volume.html">Attaching
        /// an Amazon EBS Volume to an Instance</a>. Any device names that aren't reserved for
        /// instance store volumes can be used for Amazon EBS volumes. For more information, see
        /// <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/InstanceStorage.html">Amazon
        /// EC2 Instance Store</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// If a volume has an AWS Marketplace product code:
        /// </para>
        ///  <ul> <li>The volume can only be attached as the root device of a stopped instance.</li>
        /// <li>You must be subscribed to the AWS Marketplace code that is on the volume.</li>
        /// <li>The configuration (instance type, operating system) of the instance must support
        /// that specific AWS Marketplace code. For example, you cannot take a volume from a Windows
        /// instance and attach it to a Linux instance.</li> <li>AWS Marketplace product codes
        /// are copied from the volume to the instance.</li> </ul> 
        /// <para>
        /// For an overview of the AWS Marketplace, see <a href="https://aws.amazon.com/marketplace/help/200900000">https://aws.amazon.com/marketplace/help/200900000</a>.
        /// For more information about how to use the AWS Marketplace, see <a href="https://aws.amazon.com/marketplace">AWS
        /// Marketplace</a>.
        /// </para>
        ///  
        /// <para>
        /// For more information about Amazon EBS volumes, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-attaching-volume.html">Attaching
        /// Amazon EBS Volumes</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AttachVolume service method.</param>
        /// 
        /// <returns>The response from the AttachVolume service method, as returned by EC2.</returns>
        public AttachVolumeResponse AttachVolume(AttachVolumeRequest request)
        {
            var marshaller = new AttachVolumeRequestMarshaller();
            var unmarshaller = AttachVolumeResponseUnmarshaller.Instance;

            return Invoke<AttachVolumeRequest,AttachVolumeResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AttachVolume operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachVolume operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<AttachVolumeResponse> AttachVolumeAsync(AttachVolumeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AttachVolumeRequestMarshaller();
            var unmarshaller = AttachVolumeResponseUnmarshaller.Instance;

            return InvokeAsync<AttachVolumeRequest,AttachVolumeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public AttachVpnGatewayResponse AttachVpnGateway(AttachVpnGatewayRequest request)
        {
            var marshaller = new AttachVpnGatewayRequestMarshaller();
            var unmarshaller = AttachVpnGatewayResponseUnmarshaller.Instance;

            return Invoke<AttachVpnGatewayRequest,AttachVpnGatewayResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AttachVpnGateway operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachVpnGateway operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<AttachVpnGatewayResponse> AttachVpnGatewayAsync(AttachVpnGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AttachVpnGatewayRequestMarshaller();
            var unmarshaller = AttachVpnGatewayResponseUnmarshaller.Instance;

            return InvokeAsync<AttachVpnGatewayRequest,AttachVpnGatewayResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  AuthorizeSecurityGroupEgress

        /// <summary>
        /// Adds one or more egress rules to a security group for use with a VPC. Specifically,
        /// this action permits instances to send traffic to one or more CIDR IP address ranges,
        /// or to one or more security groups for the same VPC.
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
        public AuthorizeSecurityGroupEgressResponse AuthorizeSecurityGroupEgress(AuthorizeSecurityGroupEgressRequest request)
        {
            var marshaller = new AuthorizeSecurityGroupEgressRequestMarshaller();
            var unmarshaller = AuthorizeSecurityGroupEgressResponseUnmarshaller.Instance;

            return Invoke<AuthorizeSecurityGroupEgressRequest,AuthorizeSecurityGroupEgressResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AuthorizeSecurityGroupEgress operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AuthorizeSecurityGroupEgress operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<AuthorizeSecurityGroupEgressResponse> AuthorizeSecurityGroupEgressAsync(AuthorizeSecurityGroupEgressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AuthorizeSecurityGroupEgressRequestMarshaller();
            var unmarshaller = AuthorizeSecurityGroupEgressResponseUnmarshaller.Instance;

            return InvokeAsync<AuthorizeSecurityGroupEgressRequest,AuthorizeSecurityGroupEgressResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public AuthorizeSecurityGroupIngressResponse AuthorizeSecurityGroupIngress(AuthorizeSecurityGroupIngressRequest request)
        {
            var marshaller = new AuthorizeSecurityGroupIngressRequestMarshaller();
            var unmarshaller = AuthorizeSecurityGroupIngressResponseUnmarshaller.Instance;

            return Invoke<AuthorizeSecurityGroupIngressRequest,AuthorizeSecurityGroupIngressResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AuthorizeSecurityGroupIngress operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AuthorizeSecurityGroupIngress operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<AuthorizeSecurityGroupIngressResponse> AuthorizeSecurityGroupIngressAsync(AuthorizeSecurityGroupIngressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AuthorizeSecurityGroupIngressRequestMarshaller();
            var unmarshaller = AuthorizeSecurityGroupIngressResponseUnmarshaller.Instance;

            return InvokeAsync<AuthorizeSecurityGroupIngressRequest,AuthorizeSecurityGroupIngressResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/WindowsGuide/Creating_InstanceStoreBacked_WinAMI.html">Creating
        /// an Instance Store-Backed Windows AMI</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the BundleInstance service method.</param>
        /// 
        /// <returns>The response from the BundleInstance service method, as returned by EC2.</returns>
        public BundleInstanceResponse BundleInstance(BundleInstanceRequest request)
        {
            var marshaller = new BundleInstanceRequestMarshaller();
            var unmarshaller = BundleInstanceResponseUnmarshaller.Instance;

            return Invoke<BundleInstanceRequest,BundleInstanceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the BundleInstance operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BundleInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<BundleInstanceResponse> BundleInstanceAsync(BundleInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new BundleInstanceRequestMarshaller();
            var unmarshaller = BundleInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<BundleInstanceRequest,BundleInstanceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CancelBundleTask

        /// <summary>
        /// Cancels a bundling operation for an instance store-backed Windows instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CancelBundleTask service method.</param>
        /// 
        /// <returns>The response from the CancelBundleTask service method, as returned by EC2.</returns>
        public CancelBundleTaskResponse CancelBundleTask(CancelBundleTaskRequest request)
        {
            var marshaller = new CancelBundleTaskRequestMarshaller();
            var unmarshaller = CancelBundleTaskResponseUnmarshaller.Instance;

            return Invoke<CancelBundleTaskRequest,CancelBundleTaskResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CancelBundleTask operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelBundleTask operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CancelBundleTaskResponse> CancelBundleTaskAsync(CancelBundleTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CancelBundleTaskRequestMarshaller();
            var unmarshaller = CancelBundleTaskResponseUnmarshaller.Instance;

            return InvokeAsync<CancelBundleTaskRequest,CancelBundleTaskResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public CancelConversionTaskResponse CancelConversionTask(CancelConversionTaskRequest request)
        {
            var marshaller = new CancelConversionTaskRequestMarshaller();
            var unmarshaller = CancelConversionTaskResponseUnmarshaller.Instance;

            return Invoke<CancelConversionTaskRequest,CancelConversionTaskResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CancelConversionTask operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelConversionTask operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CancelConversionTaskResponse> CancelConversionTaskAsync(CancelConversionTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CancelConversionTaskRequestMarshaller();
            var unmarshaller = CancelConversionTaskResponseUnmarshaller.Instance;

            return InvokeAsync<CancelConversionTaskRequest,CancelConversionTaskResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public CancelExportTaskResponse CancelExportTask(CancelExportTaskRequest request)
        {
            var marshaller = new CancelExportTaskRequestMarshaller();
            var unmarshaller = CancelExportTaskResponseUnmarshaller.Instance;

            return Invoke<CancelExportTaskRequest,CancelExportTaskResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CancelExportTask operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelExportTask operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CancelExportTaskResponse> CancelExportTaskAsync(CancelExportTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CancelExportTaskRequestMarshaller();
            var unmarshaller = CancelExportTaskResponseUnmarshaller.Instance;

            return InvokeAsync<CancelExportTaskRequest,CancelExportTaskResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public CancelReservedInstancesListingResponse CancelReservedInstancesListing(CancelReservedInstancesListingRequest request)
        {
            var marshaller = new CancelReservedInstancesListingRequestMarshaller();
            var unmarshaller = CancelReservedInstancesListingResponseUnmarshaller.Instance;

            return Invoke<CancelReservedInstancesListingRequest,CancelReservedInstancesListingResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CancelReservedInstancesListing operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelReservedInstancesListing operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CancelReservedInstancesListingResponse> CancelReservedInstancesListingAsync(CancelReservedInstancesListingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CancelReservedInstancesListingRequestMarshaller();
            var unmarshaller = CancelReservedInstancesListingResponseUnmarshaller.Instance;

            return InvokeAsync<CancelReservedInstancesListingRequest,CancelReservedInstancesListingResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CancelSpotInstanceRequests

        /// <summary>
        /// Cancels one or more Spot Instance requests. Spot Instances are instances that Amazon
        /// EC2 starts on your behalf when the maximum price that you specify exceeds the current
        /// Spot Price. Amazon EC2 periodically sets the Spot Price based on available Spot Instance
        /// capacity and current Spot Instance requests. For more information about Spot Instances,
        /// see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-spot-instances.html">Spot
        /// Instances</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
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
        public CancelSpotInstanceRequestsResponse CancelSpotInstanceRequests(CancelSpotInstanceRequestsRequest request)
        {
            var marshaller = new CancelSpotInstanceRequestsRequestMarshaller();
            var unmarshaller = CancelSpotInstanceRequestsResponseUnmarshaller.Instance;

            return Invoke<CancelSpotInstanceRequestsRequest,CancelSpotInstanceRequestsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CancelSpotInstanceRequests operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelSpotInstanceRequests operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CancelSpotInstanceRequestsResponse> CancelSpotInstanceRequestsAsync(CancelSpotInstanceRequestsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CancelSpotInstanceRequestsRequestMarshaller();
            var unmarshaller = CancelSpotInstanceRequestsResponseUnmarshaller.Instance;

            return InvokeAsync<CancelSpotInstanceRequestsRequest,CancelSpotInstanceRequestsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public ConfirmProductInstanceResponse ConfirmProductInstance(ConfirmProductInstanceRequest request)
        {
            var marshaller = new ConfirmProductInstanceRequestMarshaller();
            var unmarshaller = ConfirmProductInstanceResponseUnmarshaller.Instance;

            return Invoke<ConfirmProductInstanceRequest,ConfirmProductInstanceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ConfirmProductInstance operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ConfirmProductInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ConfirmProductInstanceResponse> ConfirmProductInstanceAsync(ConfirmProductInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ConfirmProductInstanceRequestMarshaller();
            var unmarshaller = ConfirmProductInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<ConfirmProductInstanceRequest,ConfirmProductInstanceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CopyImage

        /// <summary>
        /// Initiates the copy of an AMI from the specified source region to the region in which
        /// the request was made. You specify the destination region by using its endpoint when
        /// making the request. AMIs that use encrypted Amazon EBS snapshots cannot be copied
        /// with this method.
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
        public CopyImageResponse CopyImage(CopyImageRequest request)
        {
            var marshaller = new CopyImageRequestMarshaller();
            var unmarshaller = CopyImageResponseUnmarshaller.Instance;

            return Invoke<CopyImageRequest,CopyImageResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CopyImage operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopyImage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CopyImageResponse> CopyImageAsync(CopyImageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CopyImageRequestMarshaller();
            var unmarshaller = CopyImageResponseUnmarshaller.Instance;

            return InvokeAsync<CopyImageRequest,CopyImageResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CopySnapshot

        /// <summary>
        /// Copies a point-in-time snapshot of an Amazon EBS volume and stores it in Amazon S3.
        /// You can copy the snapshot within the same region or from one region to another. You
        /// can use the snapshot to create Amazon EBS volumes or Amazon Machine Images (AMIs).
        /// The snapshot is copied to the regional endpoint that you send the HTTP request to.
        /// 
        ///  
        /// <para>
        /// Copies of encrypted Amazon EBS snapshots remain encrypted. Copies of unencrypted snapshots
        /// remain unencrypted.
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
        public CopySnapshotResponse CopySnapshot(CopySnapshotRequest request)
        {
            var marshaller = new CopySnapshotRequestMarshaller();
            var unmarshaller = CopySnapshotResponseUnmarshaller.Instance;

            return Invoke<CopySnapshotRequest,CopySnapshotResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CopySnapshot operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopySnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CopySnapshotResponse> CopySnapshotAsync(CopySnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CopySnapshotRequestMarshaller();
            var unmarshaller = CopySnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<CopySnapshotRequest,CopySnapshotResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        ///  
        /// <para>
        /// For more information about VPN customer gateways, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_VPN.html">Adding
        /// a Hardware Virtual Private Gateway to Your VPC</a> in the <i>Amazon Virtual Private
        /// Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCustomerGateway service method.</param>
        /// 
        /// <returns>The response from the CreateCustomerGateway service method, as returned by EC2.</returns>
        public CreateCustomerGatewayResponse CreateCustomerGateway(CreateCustomerGatewayRequest request)
        {
            var marshaller = new CreateCustomerGatewayRequestMarshaller();
            var unmarshaller = CreateCustomerGatewayResponseUnmarshaller.Instance;

            return Invoke<CreateCustomerGatewayRequest,CreateCustomerGatewayResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCustomerGateway operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCustomerGateway operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateCustomerGatewayResponse> CreateCustomerGatewayAsync(CreateCustomerGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateCustomerGatewayRequestMarshaller();
            var unmarshaller = CreateCustomerGatewayResponseUnmarshaller.Instance;

            return InvokeAsync<CreateCustomerGatewayRequest,CreateCustomerGatewayResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        /// domain name (for example, <code>MyCompany.com</code>). If specifying more than one
        /// domain name, separate them with spaces.</li> <li> <code>ntp-servers</code> - The IP
        /// addresses of up to four Network Time Protocol (NTP) servers.</li> <li> <code>netbios-name-servers</code>
        /// - The IP addresses of up to four NetBIOS name servers.</li> <li> <code>netbios-node-type</code>
        /// - The NetBIOS node type (1, 2, 4, or 8). We recommend that you specify 2 (broadcast
        /// and multicast are not currently supported). For more information about these node
        /// types, see <a href="http://www.ietf.org/rfc/rfc2132.txt">RFC 2132</a>. </li> </ul>
        /// 
        /// <para>
        /// For more information about DHCP options, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_DHCP_Options.html">DHCP
        /// Options Sets</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDhcpOptions service method.</param>
        /// 
        /// <returns>The response from the CreateDhcpOptions service method, as returned by EC2.</returns>
        public CreateDhcpOptionsResponse CreateDhcpOptions(CreateDhcpOptionsRequest request)
        {
            var marshaller = new CreateDhcpOptionsRequestMarshaller();
            var unmarshaller = CreateDhcpOptionsResponseUnmarshaller.Instance;

            return Invoke<CreateDhcpOptionsRequest,CreateDhcpOptionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDhcpOptions operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDhcpOptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateDhcpOptionsResponse> CreateDhcpOptionsAsync(CreateDhcpOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateDhcpOptionsRequestMarshaller();
            var unmarshaller = CreateDhcpOptionsResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDhcpOptionsRequest,CreateDhcpOptionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public CreateImageResponse CreateImage(CreateImageRequest request)
        {
            var marshaller = new CreateImageRequestMarshaller();
            var unmarshaller = CreateImageResponseUnmarshaller.Instance;

            return Invoke<CreateImageRequest,CreateImageResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateImage operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateImage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateImageResponse> CreateImageAsync(CreateImageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateImageRequestMarshaller();
            var unmarshaller = CreateImageResponseUnmarshaller.Instance;

            return InvokeAsync<CreateImageRequest,CreateImageResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateInstanceExportTask

        /// <summary>
        /// Exports a running or stopped instance to an Amazon S3 bucket.
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
        public CreateInstanceExportTaskResponse CreateInstanceExportTask(CreateInstanceExportTaskRequest request)
        {
            var marshaller = new CreateInstanceExportTaskRequestMarshaller();
            var unmarshaller = CreateInstanceExportTaskResponseUnmarshaller.Instance;

            return Invoke<CreateInstanceExportTaskRequest,CreateInstanceExportTaskResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateInstanceExportTask operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateInstanceExportTask operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateInstanceExportTaskResponse> CreateInstanceExportTaskAsync(CreateInstanceExportTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateInstanceExportTaskRequestMarshaller();
            var unmarshaller = CreateInstanceExportTaskResponseUnmarshaller.Instance;

            return InvokeAsync<CreateInstanceExportTaskRequest,CreateInstanceExportTaskResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateInternetGateway

        /// <summary>
        /// Creates an Internet gateway for use with a VPC. After creating the Internet gateway,
        /// you attach it to a VPC using <a>AttachInternetGateway</a>.
        /// 
        ///  
        /// <para>
        /// For more information about your VPC and Internet gateway, see the <a href="http://docs.&awsdomain;/AmazonVPC/latest/UserGuide/">Amazon
        /// Virtual Private Cloud User Guide</a>.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the CreateInternetGateway service method, as returned by EC2.</returns>
        public CreateInternetGatewayResponse CreateInternetGateway()
        {
            return CreateInternetGateway(new CreateInternetGatewayRequest());
        }

        /// <summary>
        /// Creates an Internet gateway for use with a VPC. After creating the Internet gateway,
        /// you attach it to a VPC using <a>AttachInternetGateway</a>.
        /// 
        ///  
        /// <para>
        /// For more information about your VPC and Internet gateway, see the <a href="http://docs.&awsdomain;/AmazonVPC/latest/UserGuide/">Amazon
        /// Virtual Private Cloud User Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInternetGateway service method.</param>
        /// 
        /// <returns>The response from the CreateInternetGateway service method, as returned by EC2.</returns>
        public CreateInternetGatewayResponse CreateInternetGateway(CreateInternetGatewayRequest request)
        {
            var marshaller = new CreateInternetGatewayRequestMarshaller();
            var unmarshaller = CreateInternetGatewayResponseUnmarshaller.Instance;

            return Invoke<CreateInternetGatewayRequest,CreateInternetGatewayResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateInternetGateway operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateInternetGateway operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateInternetGatewayResponse> CreateInternetGatewayAsync(CreateInternetGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateInternetGatewayRequestMarshaller();
            var unmarshaller = CreateInternetGatewayResponseUnmarshaller.Instance;

            return InvokeAsync<CreateInternetGatewayRequest,CreateInternetGatewayResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        /// For more information about key pairs, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-key-pairs.html">Key
        /// Pairs</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateKeyPair service method.</param>
        /// 
        /// <returns>The response from the CreateKeyPair service method, as returned by EC2.</returns>
        public CreateKeyPairResponse CreateKeyPair(CreateKeyPairRequest request)
        {
            var marshaller = new CreateKeyPairRequestMarshaller();
            var unmarshaller = CreateKeyPairResponseUnmarshaller.Instance;

            return Invoke<CreateKeyPairRequest,CreateKeyPairResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateKeyPair operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateKeyPair operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateKeyPairResponse> CreateKeyPairAsync(CreateKeyPairRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateKeyPairRequestMarshaller();
            var unmarshaller = CreateKeyPairResponseUnmarshaller.Instance;

            return InvokeAsync<CreateKeyPairRequest,CreateKeyPairResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public CreateNetworkAclResponse CreateNetworkAcl(CreateNetworkAclRequest request)
        {
            var marshaller = new CreateNetworkAclRequestMarshaller();
            var unmarshaller = CreateNetworkAclResponseUnmarshaller.Instance;

            return Invoke<CreateNetworkAclRequest,CreateNetworkAclResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateNetworkAcl operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateNetworkAcl operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateNetworkAclResponse> CreateNetworkAclAsync(CreateNetworkAclRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateNetworkAclRequestMarshaller();
            var unmarshaller = CreateNetworkAclResponseUnmarshaller.Instance;

            return InvokeAsync<CreateNetworkAclRequest,CreateNetworkAclResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public CreateNetworkAclEntryResponse CreateNetworkAclEntry(CreateNetworkAclEntryRequest request)
        {
            var marshaller = new CreateNetworkAclEntryRequestMarshaller();
            var unmarshaller = CreateNetworkAclEntryResponseUnmarshaller.Instance;

            return Invoke<CreateNetworkAclEntryRequest,CreateNetworkAclEntryResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateNetworkAclEntry operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateNetworkAclEntry operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateNetworkAclEntryResponse> CreateNetworkAclEntryAsync(CreateNetworkAclEntryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateNetworkAclEntryRequestMarshaller();
            var unmarshaller = CreateNetworkAclEntryResponseUnmarshaller.Instance;

            return InvokeAsync<CreateNetworkAclEntryRequest,CreateNetworkAclEntryResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public CreateNetworkInterfaceResponse CreateNetworkInterface(CreateNetworkInterfaceRequest request)
        {
            var marshaller = new CreateNetworkInterfaceRequestMarshaller();
            var unmarshaller = CreateNetworkInterfaceResponseUnmarshaller.Instance;

            return Invoke<CreateNetworkInterfaceRequest,CreateNetworkInterfaceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateNetworkInterface operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateNetworkInterface operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateNetworkInterfaceResponse> CreateNetworkInterfaceAsync(CreateNetworkInterfaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateNetworkInterfaceRequestMarshaller();
            var unmarshaller = CreateNetworkInterfaceResponseUnmarshaller.Instance;

            return InvokeAsync<CreateNetworkInterfaceRequest,CreateNetworkInterfaceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public CreatePlacementGroupResponse CreatePlacementGroup(CreatePlacementGroupRequest request)
        {
            var marshaller = new CreatePlacementGroupRequestMarshaller();
            var unmarshaller = CreatePlacementGroupResponseUnmarshaller.Instance;

            return Invoke<CreatePlacementGroupRequest,CreatePlacementGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePlacementGroup operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePlacementGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreatePlacementGroupResponse> CreatePlacementGroupAsync(CreatePlacementGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreatePlacementGroupRequestMarshaller();
            var unmarshaller = CreatePlacementGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreatePlacementGroupRequest,CreatePlacementGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateReservedInstancesListing

        /// <summary>
        /// Creates a listing for Amazon EC2 Reserved Instances to be sold in the Reserved Instance
        /// Marketplace. You can submit one Reserved Instance listing at a time.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ri-market-general.html">Reserved
        /// Instance Marketplace</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateReservedInstancesListing service method.</param>
        /// 
        /// <returns>The response from the CreateReservedInstancesListing service method, as returned by EC2.</returns>
        public CreateReservedInstancesListingResponse CreateReservedInstancesListing(CreateReservedInstancesListingRequest request)
        {
            var marshaller = new CreateReservedInstancesListingRequestMarshaller();
            var unmarshaller = CreateReservedInstancesListingResponseUnmarshaller.Instance;

            return Invoke<CreateReservedInstancesListingRequest,CreateReservedInstancesListingResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateReservedInstancesListing operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateReservedInstancesListing operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateReservedInstancesListingResponse> CreateReservedInstancesListingAsync(CreateReservedInstancesListingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateReservedInstancesListingRequestMarshaller();
            var unmarshaller = CreateReservedInstancesListingResponseUnmarshaller.Instance;

            return InvokeAsync<CreateReservedInstancesListingRequest,CreateReservedInstancesListingResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateRoute

        /// <summary>
        /// Creates a route in a route table within a VPC.
        /// 
        ///  
        /// <para>
        /// You must specify one of the following targets: Internet gateway, NAT instance, VPC
        /// peering connection, or network interface.
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
        public CreateRouteResponse CreateRoute(CreateRouteRequest request)
        {
            var marshaller = new CreateRouteRequestMarshaller();
            var unmarshaller = CreateRouteResponseUnmarshaller.Instance;

            return Invoke<CreateRouteRequest,CreateRouteResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRoute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRoute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateRouteResponse> CreateRouteAsync(CreateRouteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateRouteRequestMarshaller();
            var unmarshaller = CreateRouteResponseUnmarshaller.Instance;

            return InvokeAsync<CreateRouteRequest,CreateRouteResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public CreateRouteTableResponse CreateRouteTable(CreateRouteTableRequest request)
        {
            var marshaller = new CreateRouteTableRequestMarshaller();
            var unmarshaller = CreateRouteTableResponseUnmarshaller.Instance;

            return Invoke<CreateRouteTableRequest,CreateRouteTableResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRouteTable operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRouteTable operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateRouteTableResponse> CreateRouteTableAsync(CreateRouteTableRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateRouteTableRequestMarshaller();
            var unmarshaller = CreateRouteTableResponseUnmarshaller.Instance;

            return InvokeAsync<CreateRouteTableRequest,CreateRouteTableResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public CreateSecurityGroupResponse CreateSecurityGroup(CreateSecurityGroupRequest request)
        {
            var marshaller = new CreateSecurityGroupRequestMarshaller();
            var unmarshaller = CreateSecurityGroupResponseUnmarshaller.Instance;

            return Invoke<CreateSecurityGroupRequest,CreateSecurityGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSecurityGroup operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSecurityGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateSecurityGroupResponse> CreateSecurityGroupAsync(CreateSecurityGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateSecurityGroupRequestMarshaller();
            var unmarshaller = CreateSecurityGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSecurityGroupRequest,CreateSecurityGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateSnapshot

        /// <summary>
        /// Creates a snapshot of an Amazon EBS volume and stores it in Amazon S3. You can use
        /// snapshots for backups, to make copies of Amazon EBS volumes, and to save data before
        /// shutting down an instance.
        /// 
        ///  
        /// <para>
        /// When a snapshot is created, any AWS Marketplace product codes that are associated
        /// with the source volume are propagated to the snapshot.
        /// </para>
        ///  
        /// <para>
        /// You can take a snapshot of an attached volume that is in use. However, snapshots only
        /// capture data that has been written to your Amazon EBS volume at the time the snapshot
        /// command is issued; this may exclude any data that has been cached by any applications
        /// or the operating system. If you can pause any file systems on the volume long enough
        /// to take a snapshot, your snapshot should be complete. However, if you cannot pause
        /// all file writes to the volume, you should unmount the volume from within the instance,
        /// issue the snapshot command, and then remount the volume to ensure a consistent and
        /// complete snapshot. You may remount and use your volume while the snapshot status is
        /// <code>pending</code>.
        /// </para>
        ///  
        /// <para>
        /// To create a snapshot for Amazon EBS volumes that serve as root devices, you should
        /// stop the instance before taking the snapshot.
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
        public CreateSnapshotResponse CreateSnapshot(CreateSnapshotRequest request)
        {
            var marshaller = new CreateSnapshotRequestMarshaller();
            var unmarshaller = CreateSnapshotResponseUnmarshaller.Instance;

            return Invoke<CreateSnapshotRequest,CreateSnapshotResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSnapshot operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateSnapshotResponse> CreateSnapshotAsync(CreateSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateSnapshotRequestMarshaller();
            var unmarshaller = CreateSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSnapshotRequest,CreateSnapshotResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateSpotDatafeedSubscription

        /// <summary>
        /// Creates a datafeed for Spot Instances, enabling you to view Spot Instance usage logs.
        /// You can create one data feed per AWS account. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-spot-instances.html">Spot
        /// Instances</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSpotDatafeedSubscription service method.</param>
        /// 
        /// <returns>The response from the CreateSpotDatafeedSubscription service method, as returned by EC2.</returns>
        public CreateSpotDatafeedSubscriptionResponse CreateSpotDatafeedSubscription(CreateSpotDatafeedSubscriptionRequest request)
        {
            var marshaller = new CreateSpotDatafeedSubscriptionRequestMarshaller();
            var unmarshaller = CreateSpotDatafeedSubscriptionResponseUnmarshaller.Instance;

            return Invoke<CreateSpotDatafeedSubscriptionRequest,CreateSpotDatafeedSubscriptionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSpotDatafeedSubscription operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSpotDatafeedSubscription operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateSpotDatafeedSubscriptionResponse> CreateSpotDatafeedSubscriptionAsync(CreateSpotDatafeedSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateSpotDatafeedSubscriptionRequestMarshaller();
            var unmarshaller = CreateSpotDatafeedSubscriptionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSpotDatafeedSubscriptionRequest,CreateSpotDatafeedSubscriptionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        /// For more information about subnets, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Subnets.html">Your
        /// VPC and Subnets</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSubnet service method.</param>
        /// 
        /// <returns>The response from the CreateSubnet service method, as returned by EC2.</returns>
        public CreateSubnetResponse CreateSubnet(CreateSubnetRequest request)
        {
            var marshaller = new CreateSubnetRequestMarshaller();
            var unmarshaller = CreateSubnetResponseUnmarshaller.Instance;

            return Invoke<CreateSubnetRequest,CreateSubnetResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSubnet operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSubnet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateSubnetResponse> CreateSubnetAsync(CreateSubnetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateSubnetRequestMarshaller();
            var unmarshaller = CreateSubnetResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSubnetRequest,CreateSubnetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateTags

        /// <summary>
        /// Adds or overwrites one or more tags for the specified EC2 resource or resources. Each
        /// resource can have a maximum of 10 tags. Each tag consists of a key and optional value.
        /// Tag keys must be unique per resource.
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
        public CreateTagsResponse CreateTags(CreateTagsRequest request)
        {
            var marshaller = new CreateTagsRequestMarshaller();
            var unmarshaller = CreateTagsResponseUnmarshaller.Instance;

            return Invoke<CreateTagsRequest,CreateTagsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTags operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateTagsResponse> CreateTagsAsync(CreateTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateTagsRequestMarshaller();
            var unmarshaller = CreateTagsResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTagsRequest,CreateTagsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateVolume

        /// <summary>
        /// Creates an Amazon EBS volume that can be attached to an instance in the same Availability
        /// Zone. The volume is created in the specified region.
        /// 
        ///  
        /// <para>
        /// You can create a new empty volume or restore a volume from an Amazon EBS snapshot.
        /// Any AWS Marketplace product codes from the snapshot are propagated to the volume.
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
        public CreateVolumeResponse CreateVolume(CreateVolumeRequest request)
        {
            var marshaller = new CreateVolumeRequestMarshaller();
            var unmarshaller = CreateVolumeResponseUnmarshaller.Instance;

            return Invoke<CreateVolumeRequest,CreateVolumeResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateVolume operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVolume operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateVolumeResponse> CreateVolumeAsync(CreateVolumeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateVolumeRequestMarshaller();
            var unmarshaller = CreateVolumeResponseUnmarshaller.Instance;

            return InvokeAsync<CreateVolumeRequest,CreateVolumeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public CreateVpcResponse CreateVpc(CreateVpcRequest request)
        {
            var marshaller = new CreateVpcRequestMarshaller();
            var unmarshaller = CreateVpcResponseUnmarshaller.Instance;

            return Invoke<CreateVpcRequest,CreateVpcResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateVpc operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVpc operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateVpcResponse> CreateVpcAsync(CreateVpcRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateVpcRequestMarshaller();
            var unmarshaller = CreateVpcResponseUnmarshaller.Instance;

            return InvokeAsync<CreateVpcRequest,CreateVpcResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public CreateVpcPeeringConnectionResponse CreateVpcPeeringConnection(CreateVpcPeeringConnectionRequest request)
        {
            var marshaller = new CreateVpcPeeringConnectionRequestMarshaller();
            var unmarshaller = CreateVpcPeeringConnectionResponseUnmarshaller.Instance;

            return Invoke<CreateVpcPeeringConnectionRequest,CreateVpcPeeringConnectionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateVpcPeeringConnection operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVpcPeeringConnection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateVpcPeeringConnectionResponse> CreateVpcPeeringConnectionAsync(CreateVpcPeeringConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateVpcPeeringConnectionRequestMarshaller();
            var unmarshaller = CreateVpcPeeringConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateVpcPeeringConnectionRequest,CreateVpcPeeringConnectionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public CreateVpnConnectionResponse CreateVpnConnection(CreateVpnConnectionRequest request)
        {
            var marshaller = new CreateVpnConnectionRequestMarshaller();
            var unmarshaller = CreateVpnConnectionResponseUnmarshaller.Instance;

            return Invoke<CreateVpnConnectionRequest,CreateVpnConnectionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateVpnConnection operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVpnConnection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateVpnConnectionResponse> CreateVpnConnectionAsync(CreateVpnConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateVpnConnectionRequestMarshaller();
            var unmarshaller = CreateVpnConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateVpnConnectionRequest,CreateVpnConnectionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public CreateVpnConnectionRouteResponse CreateVpnConnectionRoute(CreateVpnConnectionRouteRequest request)
        {
            var marshaller = new CreateVpnConnectionRouteRequestMarshaller();
            var unmarshaller = CreateVpnConnectionRouteResponseUnmarshaller.Instance;

            return Invoke<CreateVpnConnectionRouteRequest,CreateVpnConnectionRouteResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateVpnConnectionRoute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVpnConnectionRoute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateVpnConnectionRouteResponse> CreateVpnConnectionRouteAsync(CreateVpnConnectionRouteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateVpnConnectionRouteRequestMarshaller();
            var unmarshaller = CreateVpnConnectionRouteResponseUnmarshaller.Instance;

            return InvokeAsync<CreateVpnConnectionRouteRequest,CreateVpnConnectionRouteResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public CreateVpnGatewayResponse CreateVpnGateway(CreateVpnGatewayRequest request)
        {
            var marshaller = new CreateVpnGatewayRequestMarshaller();
            var unmarshaller = CreateVpnGatewayResponseUnmarshaller.Instance;

            return Invoke<CreateVpnGatewayRequest,CreateVpnGatewayResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateVpnGateway operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVpnGateway operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<CreateVpnGatewayResponse> CreateVpnGatewayAsync(CreateVpnGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateVpnGatewayRequestMarshaller();
            var unmarshaller = CreateVpnGatewayResponseUnmarshaller.Instance;

            return InvokeAsync<CreateVpnGatewayRequest,CreateVpnGatewayResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteCustomerGateway

        /// <summary>
        /// Deletes the specified customer gateway. You must delete the VPN connection before
        /// you can delete the customer gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCustomerGateway service method.</param>
        /// 
        /// <returns>The response from the DeleteCustomerGateway service method, as returned by EC2.</returns>
        public DeleteCustomerGatewayResponse DeleteCustomerGateway(DeleteCustomerGatewayRequest request)
        {
            var marshaller = new DeleteCustomerGatewayRequestMarshaller();
            var unmarshaller = DeleteCustomerGatewayResponseUnmarshaller.Instance;

            return Invoke<DeleteCustomerGatewayRequest,DeleteCustomerGatewayResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCustomerGateway operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCustomerGateway operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteCustomerGatewayResponse> DeleteCustomerGatewayAsync(DeleteCustomerGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteCustomerGatewayRequestMarshaller();
            var unmarshaller = DeleteCustomerGatewayResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteCustomerGatewayRequest,DeleteCustomerGatewayResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public DeleteDhcpOptionsResponse DeleteDhcpOptions(DeleteDhcpOptionsRequest request)
        {
            var marshaller = new DeleteDhcpOptionsRequestMarshaller();
            var unmarshaller = DeleteDhcpOptionsResponseUnmarshaller.Instance;

            return Invoke<DeleteDhcpOptionsRequest,DeleteDhcpOptionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDhcpOptions operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDhcpOptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteDhcpOptionsResponse> DeleteDhcpOptionsAsync(DeleteDhcpOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteDhcpOptionsRequestMarshaller();
            var unmarshaller = DeleteDhcpOptionsResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDhcpOptionsRequest,DeleteDhcpOptionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteInternetGateway

        /// <summary>
        /// Deletes the specified Internet gateway. You must detach the Internet gateway from
        /// the VPC before you can delete it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInternetGateway service method.</param>
        /// 
        /// <returns>The response from the DeleteInternetGateway service method, as returned by EC2.</returns>
        public DeleteInternetGatewayResponse DeleteInternetGateway(DeleteInternetGatewayRequest request)
        {
            var marshaller = new DeleteInternetGatewayRequestMarshaller();
            var unmarshaller = DeleteInternetGatewayResponseUnmarshaller.Instance;

            return Invoke<DeleteInternetGatewayRequest,DeleteInternetGatewayResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteInternetGateway operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteInternetGateway operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteInternetGatewayResponse> DeleteInternetGatewayAsync(DeleteInternetGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteInternetGatewayRequestMarshaller();
            var unmarshaller = DeleteInternetGatewayResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteInternetGatewayRequest,DeleteInternetGatewayResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteKeyPair

        /// <summary>
        /// Deletes the specified key pair, by removing the public key from Amazon EC2.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteKeyPair service method.</param>
        /// 
        /// <returns>The response from the DeleteKeyPair service method, as returned by EC2.</returns>
        public DeleteKeyPairResponse DeleteKeyPair(DeleteKeyPairRequest request)
        {
            var marshaller = new DeleteKeyPairRequestMarshaller();
            var unmarshaller = DeleteKeyPairResponseUnmarshaller.Instance;

            return Invoke<DeleteKeyPairRequest,DeleteKeyPairResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteKeyPair operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteKeyPair operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteKeyPairResponse> DeleteKeyPairAsync(DeleteKeyPairRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteKeyPairRequestMarshaller();
            var unmarshaller = DeleteKeyPairResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteKeyPairRequest,DeleteKeyPairResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteNetworkAcl

        /// <summary>
        /// Deletes the specified network ACL. You can't delete the ACL if it's associated with
        /// any subnets. You can't delete the default network ACL.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNetworkAcl service method.</param>
        /// 
        /// <returns>The response from the DeleteNetworkAcl service method, as returned by EC2.</returns>
        public DeleteNetworkAclResponse DeleteNetworkAcl(DeleteNetworkAclRequest request)
        {
            var marshaller = new DeleteNetworkAclRequestMarshaller();
            var unmarshaller = DeleteNetworkAclResponseUnmarshaller.Instance;

            return Invoke<DeleteNetworkAclRequest,DeleteNetworkAclResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteNetworkAcl operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteNetworkAcl operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteNetworkAclResponse> DeleteNetworkAclAsync(DeleteNetworkAclRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteNetworkAclRequestMarshaller();
            var unmarshaller = DeleteNetworkAclResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteNetworkAclRequest,DeleteNetworkAclResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteNetworkAclEntry

        /// <summary>
        /// Deletes the specified ingress or egress entry (rule) from the specified network ACL.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNetworkAclEntry service method.</param>
        /// 
        /// <returns>The response from the DeleteNetworkAclEntry service method, as returned by EC2.</returns>
        public DeleteNetworkAclEntryResponse DeleteNetworkAclEntry(DeleteNetworkAclEntryRequest request)
        {
            var marshaller = new DeleteNetworkAclEntryRequestMarshaller();
            var unmarshaller = DeleteNetworkAclEntryResponseUnmarshaller.Instance;

            return Invoke<DeleteNetworkAclEntryRequest,DeleteNetworkAclEntryResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteNetworkAclEntry operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteNetworkAclEntry operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteNetworkAclEntryResponse> DeleteNetworkAclEntryAsync(DeleteNetworkAclEntryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteNetworkAclEntryRequestMarshaller();
            var unmarshaller = DeleteNetworkAclEntryResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteNetworkAclEntryRequest,DeleteNetworkAclEntryResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteNetworkInterface

        /// <summary>
        /// Deletes the specified network interface. You must detach the network interface before
        /// you can delete it.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteNetworkInterface service method.</param>
        /// 
        /// <returns>The response from the DeleteNetworkInterface service method, as returned by EC2.</returns>
        public DeleteNetworkInterfaceResponse DeleteNetworkInterface(DeleteNetworkInterfaceRequest request)
        {
            var marshaller = new DeleteNetworkInterfaceRequestMarshaller();
            var unmarshaller = DeleteNetworkInterfaceResponseUnmarshaller.Instance;

            return Invoke<DeleteNetworkInterfaceRequest,DeleteNetworkInterfaceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteNetworkInterface operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteNetworkInterface operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteNetworkInterfaceResponse> DeleteNetworkInterfaceAsync(DeleteNetworkInterfaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteNetworkInterfaceRequestMarshaller();
            var unmarshaller = DeleteNetworkInterfaceResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteNetworkInterfaceRequest,DeleteNetworkInterfaceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public DeletePlacementGroupResponse DeletePlacementGroup(DeletePlacementGroupRequest request)
        {
            var marshaller = new DeletePlacementGroupRequestMarshaller();
            var unmarshaller = DeletePlacementGroupResponseUnmarshaller.Instance;

            return Invoke<DeletePlacementGroupRequest,DeletePlacementGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePlacementGroup operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePlacementGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeletePlacementGroupResponse> DeletePlacementGroupAsync(DeletePlacementGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeletePlacementGroupRequestMarshaller();
            var unmarshaller = DeletePlacementGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeletePlacementGroupRequest,DeletePlacementGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteRoute

        /// <summary>
        /// Deletes the specified route from the specified route table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRoute service method.</param>
        /// 
        /// <returns>The response from the DeleteRoute service method, as returned by EC2.</returns>
        public DeleteRouteResponse DeleteRoute(DeleteRouteRequest request)
        {
            var marshaller = new DeleteRouteRequestMarshaller();
            var unmarshaller = DeleteRouteResponseUnmarshaller.Instance;

            return Invoke<DeleteRouteRequest,DeleteRouteResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRoute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRoute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteRouteResponse> DeleteRouteAsync(DeleteRouteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteRouteRequestMarshaller();
            var unmarshaller = DeleteRouteResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteRouteRequest,DeleteRouteResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteRouteTable

        /// <summary>
        /// Deletes the specified route table. You must disassociate the route table from any
        /// subnets before you can delete it. You can't delete the main route table.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteRouteTable service method.</param>
        /// 
        /// <returns>The response from the DeleteRouteTable service method, as returned by EC2.</returns>
        public DeleteRouteTableResponse DeleteRouteTable(DeleteRouteTableRequest request)
        {
            var marshaller = new DeleteRouteTableRequestMarshaller();
            var unmarshaller = DeleteRouteTableResponseUnmarshaller.Instance;

            return Invoke<DeleteRouteTableRequest,DeleteRouteTableResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRouteTable operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRouteTable operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteRouteTableResponse> DeleteRouteTableAsync(DeleteRouteTableRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteRouteTableRequestMarshaller();
            var unmarshaller = DeleteRouteTableResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteRouteTableRequest,DeleteRouteTableResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public DeleteSecurityGroupResponse DeleteSecurityGroup(DeleteSecurityGroupRequest request)
        {
            var marshaller = new DeleteSecurityGroupRequestMarshaller();
            var unmarshaller = DeleteSecurityGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteSecurityGroupRequest,DeleteSecurityGroupResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSecurityGroup operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSecurityGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteSecurityGroupResponse> DeleteSecurityGroupAsync(DeleteSecurityGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteSecurityGroupRequestMarshaller();
            var unmarshaller = DeleteSecurityGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSecurityGroupRequest,DeleteSecurityGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        /// You cannot delete a snapshot of the root device of an Amazon EBS volume used by a
        /// registered AMI. You must first de-register the AMI before you can delete the snapshot.
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
        public DeleteSnapshotResponse DeleteSnapshot(DeleteSnapshotRequest request)
        {
            var marshaller = new DeleteSnapshotRequestMarshaller();
            var unmarshaller = DeleteSnapshotResponseUnmarshaller.Instance;

            return Invoke<DeleteSnapshotRequest,DeleteSnapshotResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSnapshot operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteSnapshotResponse> DeleteSnapshotAsync(DeleteSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteSnapshotRequestMarshaller();
            var unmarshaller = DeleteSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSnapshotRequest,DeleteSnapshotResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteSpotDatafeedSubscription

        /// <summary>
        /// Deletes the datafeed for Spot Instances. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-spot-instances.html">Spot
        /// Instances</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </summary>
        /// 
        /// <returns>The response from the DeleteSpotDatafeedSubscription service method, as returned by EC2.</returns>
        public DeleteSpotDatafeedSubscriptionResponse DeleteSpotDatafeedSubscription()
        {
            return DeleteSpotDatafeedSubscription(new DeleteSpotDatafeedSubscriptionRequest());
        }

        /// <summary>
        /// Deletes the datafeed for Spot Instances. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-spot-instances.html">Spot
        /// Instances</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSpotDatafeedSubscription service method.</param>
        /// 
        /// <returns>The response from the DeleteSpotDatafeedSubscription service method, as returned by EC2.</returns>
        public DeleteSpotDatafeedSubscriptionResponse DeleteSpotDatafeedSubscription(DeleteSpotDatafeedSubscriptionRequest request)
        {
            var marshaller = new DeleteSpotDatafeedSubscriptionRequestMarshaller();
            var unmarshaller = DeleteSpotDatafeedSubscriptionResponseUnmarshaller.Instance;

            return Invoke<DeleteSpotDatafeedSubscriptionRequest,DeleteSpotDatafeedSubscriptionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSpotDatafeedSubscription operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSpotDatafeedSubscription operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteSpotDatafeedSubscriptionResponse> DeleteSpotDatafeedSubscriptionAsync(DeleteSpotDatafeedSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteSpotDatafeedSubscriptionRequestMarshaller();
            var unmarshaller = DeleteSpotDatafeedSubscriptionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSpotDatafeedSubscriptionRequest,DeleteSpotDatafeedSubscriptionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteSubnet

        /// <summary>
        /// Deletes the specified subnet. You must terminate all running instances in the subnet
        /// before you can delete the subnet.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSubnet service method.</param>
        /// 
        /// <returns>The response from the DeleteSubnet service method, as returned by EC2.</returns>
        public DeleteSubnetResponse DeleteSubnet(DeleteSubnetRequest request)
        {
            var marshaller = new DeleteSubnetRequestMarshaller();
            var unmarshaller = DeleteSubnetResponseUnmarshaller.Instance;

            return Invoke<DeleteSubnetRequest,DeleteSubnetResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSubnet operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSubnet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteSubnetResponse> DeleteSubnetAsync(DeleteSubnetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteSubnetRequestMarshaller();
            var unmarshaller = DeleteSubnetResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSubnetRequest,DeleteSubnetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public DeleteTagsResponse DeleteTags(DeleteTagsRequest request)
        {
            var marshaller = new DeleteTagsRequestMarshaller();
            var unmarshaller = DeleteTagsResponseUnmarshaller.Instance;

            return Invoke<DeleteTagsRequest,DeleteTagsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTags operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteTagsResponse> DeleteTagsAsync(DeleteTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteTagsRequestMarshaller();
            var unmarshaller = DeleteTagsResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTagsRequest,DeleteTagsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteVolume

        /// <summary>
        /// Deletes the specified Amazon EBS volume. The volume must be in the <code>available</code>
        /// state (not attached to an instance).
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-deleting-volume.html">Deleting
        /// an Amazon EBS Volume</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVolume service method.</param>
        /// 
        /// <returns>The response from the DeleteVolume service method, as returned by EC2.</returns>
        public DeleteVolumeResponse DeleteVolume(DeleteVolumeRequest request)
        {
            var marshaller = new DeleteVolumeRequestMarshaller();
            var unmarshaller = DeleteVolumeResponseUnmarshaller.Instance;

            return Invoke<DeleteVolumeRequest,DeleteVolumeResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVolume operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVolume operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteVolumeResponse> DeleteVolumeAsync(DeleteVolumeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteVolumeRequestMarshaller();
            var unmarshaller = DeleteVolumeResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteVolumeRequest,DeleteVolumeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public DeleteVpcResponse DeleteVpc(DeleteVpcRequest request)
        {
            var marshaller = new DeleteVpcRequestMarshaller();
            var unmarshaller = DeleteVpcResponseUnmarshaller.Instance;

            return Invoke<DeleteVpcRequest,DeleteVpcResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVpc operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpc operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteVpcResponse> DeleteVpcAsync(DeleteVpcRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteVpcRequestMarshaller();
            var unmarshaller = DeleteVpcResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteVpcRequest,DeleteVpcResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public DeleteVpcPeeringConnectionResponse DeleteVpcPeeringConnection(DeleteVpcPeeringConnectionRequest request)
        {
            var marshaller = new DeleteVpcPeeringConnectionRequestMarshaller();
            var unmarshaller = DeleteVpcPeeringConnectionResponseUnmarshaller.Instance;

            return Invoke<DeleteVpcPeeringConnectionRequest,DeleteVpcPeeringConnectionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVpcPeeringConnection operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpcPeeringConnection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteVpcPeeringConnectionResponse> DeleteVpcPeeringConnectionAsync(DeleteVpcPeeringConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteVpcPeeringConnectionRequestMarshaller();
            var unmarshaller = DeleteVpcPeeringConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteVpcPeeringConnectionRequest,DeleteVpcPeeringConnectionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteVpnConnection

        /// <summary>
        /// Deletes the specified VPN connection.
        /// 
        ///  
        /// <para>
        /// If you're deleting the VPC and its associated components, we recommend that you detach
        /// the virtual private gateway from the VPC and delete the VPC before deleting the VPN
        /// connection.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpnConnection service method.</param>
        /// 
        /// <returns>The response from the DeleteVpnConnection service method, as returned by EC2.</returns>
        public DeleteVpnConnectionResponse DeleteVpnConnection(DeleteVpnConnectionRequest request)
        {
            var marshaller = new DeleteVpnConnectionRequestMarshaller();
            var unmarshaller = DeleteVpnConnectionResponseUnmarshaller.Instance;

            return Invoke<DeleteVpnConnectionRequest,DeleteVpnConnectionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVpnConnection operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpnConnection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteVpnConnectionResponse> DeleteVpnConnectionAsync(DeleteVpnConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteVpnConnectionRequestMarshaller();
            var unmarshaller = DeleteVpnConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteVpnConnectionRequest,DeleteVpnConnectionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public DeleteVpnConnectionRouteResponse DeleteVpnConnectionRoute(DeleteVpnConnectionRouteRequest request)
        {
            var marshaller = new DeleteVpnConnectionRouteRequestMarshaller();
            var unmarshaller = DeleteVpnConnectionRouteResponseUnmarshaller.Instance;

            return Invoke<DeleteVpnConnectionRouteRequest,DeleteVpnConnectionRouteResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVpnConnectionRoute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpnConnectionRoute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteVpnConnectionRouteResponse> DeleteVpnConnectionRouteAsync(DeleteVpnConnectionRouteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteVpnConnectionRouteRequestMarshaller();
            var unmarshaller = DeleteVpnConnectionRouteResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteVpnConnectionRouteRequest,DeleteVpnConnectionRouteResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public DeleteVpnGatewayResponse DeleteVpnGateway(DeleteVpnGatewayRequest request)
        {
            var marshaller = new DeleteVpnGatewayRequestMarshaller();
            var unmarshaller = DeleteVpnGatewayResponseUnmarshaller.Instance;

            return Invoke<DeleteVpnGatewayRequest,DeleteVpnGatewayResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVpnGateway operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpnGateway operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeleteVpnGatewayResponse> DeleteVpnGatewayAsync(DeleteVpnGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteVpnGatewayRequestMarshaller();
            var unmarshaller = DeleteVpnGatewayResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteVpnGatewayRequest,DeleteVpnGatewayResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public DeregisterImageResponse DeregisterImage(DeregisterImageRequest request)
        {
            var marshaller = new DeregisterImageRequestMarshaller();
            var unmarshaller = DeregisterImageResponseUnmarshaller.Instance;

            return Invoke<DeregisterImageRequest,DeregisterImageResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterImage operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterImage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DeregisterImageResponse> DeregisterImageAsync(DeregisterImageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeregisterImageRequestMarshaller();
            var unmarshaller = DeregisterImageResponseUnmarshaller.Instance;

            return InvokeAsync<DeregisterImageRequest,DeregisterImageResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeAccountAttributes

        /// <summary>
        /// Describes the specified attribute of your AWS account.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeAccountAttributes service method, as returned by EC2.</returns>
        public DescribeAccountAttributesResponse DescribeAccountAttributes()
        {
            return DescribeAccountAttributes(new DescribeAccountAttributesRequest());
        }

        /// <summary>
        /// Describes the specified attribute of your AWS account.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountAttributes service method.</param>
        /// 
        /// <returns>The response from the DescribeAccountAttributes service method, as returned by EC2.</returns>
        public DescribeAccountAttributesResponse DescribeAccountAttributes(DescribeAccountAttributesRequest request)
        {
            var marshaller = new DescribeAccountAttributesRequestMarshaller();
            var unmarshaller = DescribeAccountAttributesResponseUnmarshaller.Instance;

            return Invoke<DescribeAccountAttributesRequest,DescribeAccountAttributesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAccountAttributes operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeAccountAttributesResponse> DescribeAccountAttributesAsync(DescribeAccountAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeAccountAttributesRequestMarshaller();
            var unmarshaller = DescribeAccountAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAccountAttributesRequest,DescribeAccountAttributesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public DescribeAddressesResponse DescribeAddresses()
        {
            return DescribeAddresses(new DescribeAddressesRequest());
        }

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
        public DescribeAddressesResponse DescribeAddresses(DescribeAddressesRequest request)
        {
            var marshaller = new DescribeAddressesRequestMarshaller();
            var unmarshaller = DescribeAddressesResponseUnmarshaller.Instance;

            return Invoke<DescribeAddressesRequest,DescribeAddressesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAddresses operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAddresses operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeAddressesResponse> DescribeAddressesAsync(DescribeAddressesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeAddressesRequestMarshaller();
            var unmarshaller = DescribeAddressesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAddressesRequest,DescribeAddressesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public DescribeAvailabilityZonesResponse DescribeAvailabilityZones()
        {
            return DescribeAvailabilityZones(new DescribeAvailabilityZonesRequest());
        }

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
        public DescribeAvailabilityZonesResponse DescribeAvailabilityZones(DescribeAvailabilityZonesRequest request)
        {
            var marshaller = new DescribeAvailabilityZonesRequestMarshaller();
            var unmarshaller = DescribeAvailabilityZonesResponseUnmarshaller.Instance;

            return Invoke<DescribeAvailabilityZonesRequest,DescribeAvailabilityZonesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAvailabilityZones operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAvailabilityZones operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeAvailabilityZonesResponse> DescribeAvailabilityZonesAsync(DescribeAvailabilityZonesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeAvailabilityZonesRequestMarshaller();
            var unmarshaller = DescribeAvailabilityZonesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAvailabilityZonesRequest,DescribeAvailabilityZonesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeBundleTasks

        /// <summary>
        /// Describes one or more of your bundling tasks.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeBundleTasks service method, as returned by EC2.</returns>
        public DescribeBundleTasksResponse DescribeBundleTasks()
        {
            return DescribeBundleTasks(new DescribeBundleTasksRequest());
        }

        /// <summary>
        /// Describes one or more of your bundling tasks.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeBundleTasks service method.</param>
        /// 
        /// <returns>The response from the DescribeBundleTasks service method, as returned by EC2.</returns>
        public DescribeBundleTasksResponse DescribeBundleTasks(DescribeBundleTasksRequest request)
        {
            var marshaller = new DescribeBundleTasksRequestMarshaller();
            var unmarshaller = DescribeBundleTasksResponseUnmarshaller.Instance;

            return Invoke<DescribeBundleTasksRequest,DescribeBundleTasksResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeBundleTasks operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeBundleTasks operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeBundleTasksResponse> DescribeBundleTasksAsync(DescribeBundleTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeBundleTasksRequestMarshaller();
            var unmarshaller = DescribeBundleTasksResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeBundleTasksRequest,DescribeBundleTasksResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeConversionTasks

        /// <summary>
        /// Describes one or more of your conversion tasks. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/UploadingYourInstancesandVolumes.html">Using
        /// the Command Line Tools to Import Your Virtual Machine to Amazon EC2</a> in the <i>Amazon
        /// Elastic Compute Cloud User Guide</i>.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeConversionTasks service method, as returned by EC2.</returns>
        public DescribeConversionTasksResponse DescribeConversionTasks()
        {
            return DescribeConversionTasks(new DescribeConversionTasksRequest());
        }

        /// <summary>
        /// Describes one or more of your conversion tasks. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/UploadingYourInstancesandVolumes.html">Using
        /// the Command Line Tools to Import Your Virtual Machine to Amazon EC2</a> in the <i>Amazon
        /// Elastic Compute Cloud User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConversionTasks service method.</param>
        /// 
        /// <returns>The response from the DescribeConversionTasks service method, as returned by EC2.</returns>
        public DescribeConversionTasksResponse DescribeConversionTasks(DescribeConversionTasksRequest request)
        {
            var marshaller = new DescribeConversionTasksRequestMarshaller();
            var unmarshaller = DescribeConversionTasksResponseUnmarshaller.Instance;

            return Invoke<DescribeConversionTasksRequest,DescribeConversionTasksResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeConversionTasks operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeConversionTasks operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeConversionTasksResponse> DescribeConversionTasksAsync(DescribeConversionTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeConversionTasksRequestMarshaller();
            var unmarshaller = DescribeConversionTasksResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeConversionTasksRequest,DescribeConversionTasksResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public DescribeCustomerGatewaysResponse DescribeCustomerGateways()
        {
            return DescribeCustomerGateways(new DescribeCustomerGatewaysRequest());
        }

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
        public DescribeCustomerGatewaysResponse DescribeCustomerGateways(DescribeCustomerGatewaysRequest request)
        {
            var marshaller = new DescribeCustomerGatewaysRequestMarshaller();
            var unmarshaller = DescribeCustomerGatewaysResponseUnmarshaller.Instance;

            return Invoke<DescribeCustomerGatewaysRequest,DescribeCustomerGatewaysResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCustomerGateways operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCustomerGateways operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeCustomerGatewaysResponse> DescribeCustomerGatewaysAsync(DescribeCustomerGatewaysRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeCustomerGatewaysRequestMarshaller();
            var unmarshaller = DescribeCustomerGatewaysResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeCustomerGatewaysRequest,DescribeCustomerGatewaysResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public DescribeDhcpOptionsResponse DescribeDhcpOptions()
        {
            return DescribeDhcpOptions(new DescribeDhcpOptionsRequest());
        }

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
        public DescribeDhcpOptionsResponse DescribeDhcpOptions(DescribeDhcpOptionsRequest request)
        {
            var marshaller = new DescribeDhcpOptionsRequestMarshaller();
            var unmarshaller = DescribeDhcpOptionsResponseUnmarshaller.Instance;

            return Invoke<DescribeDhcpOptionsRequest,DescribeDhcpOptionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDhcpOptions operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDhcpOptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeDhcpOptionsResponse> DescribeDhcpOptionsAsync(DescribeDhcpOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeDhcpOptionsRequestMarshaller();
            var unmarshaller = DescribeDhcpOptionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDhcpOptionsRequest,DescribeDhcpOptionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeExportTasks

        /// <summary>
        /// Describes one or more of your export tasks.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeExportTasks service method, as returned by EC2.</returns>
        public DescribeExportTasksResponse DescribeExportTasks()
        {
            return DescribeExportTasks(new DescribeExportTasksRequest());
        }

        /// <summary>
        /// Describes one or more of your export tasks.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeExportTasks service method.</param>
        /// 
        /// <returns>The response from the DescribeExportTasks service method, as returned by EC2.</returns>
        public DescribeExportTasksResponse DescribeExportTasks(DescribeExportTasksRequest request)
        {
            var marshaller = new DescribeExportTasksRequestMarshaller();
            var unmarshaller = DescribeExportTasksResponseUnmarshaller.Instance;

            return Invoke<DescribeExportTasksRequest,DescribeExportTasksResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeExportTasks operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeExportTasks operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeExportTasksResponse> DescribeExportTasksAsync(DescribeExportTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeExportTasksRequestMarshaller();
            var unmarshaller = DescribeExportTasksResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeExportTasksRequest,DescribeExportTasksResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeImageAttribute

        /// <summary>
        /// Describes the specified attribute of the specified AMI. You can specify only one attribute
        /// at a time.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeImageAttribute service method.</param>
        /// 
        /// <returns>The response from the DescribeImageAttribute service method, as returned by EC2.</returns>
        public DescribeImageAttributeResponse DescribeImageAttribute(DescribeImageAttributeRequest request)
        {
            var marshaller = new DescribeImageAttributeRequestMarshaller();
            var unmarshaller = DescribeImageAttributeResponseUnmarshaller.Instance;

            return Invoke<DescribeImageAttributeRequest,DescribeImageAttributeResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeImageAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeImageAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeImageAttributeResponse> DescribeImageAttributeAsync(DescribeImageAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeImageAttributeRequestMarshaller();
            var unmarshaller = DescribeImageAttributeResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeImageAttributeRequest,DescribeImageAttributeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeImages

        /// <summary>
        /// Describes one or more of the images (AMIs, AKIs, and ARIs) available to you. Images
        /// available to you include public images, private images that you own, and private images
        /// owned by other AWS accounts but for which you have explicit launch permissions.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeImages service method, as returned by EC2.</returns>
        public DescribeImagesResponse DescribeImages()
        {
            return DescribeImages(new DescribeImagesRequest());
        }

        /// <summary>
        /// Describes one or more of the images (AMIs, AKIs, and ARIs) available to you. Images
        /// available to you include public images, private images that you own, and private images
        /// owned by other AWS accounts but for which you have explicit launch permissions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeImages service method.</param>
        /// 
        /// <returns>The response from the DescribeImages service method, as returned by EC2.</returns>
        public DescribeImagesResponse DescribeImages(DescribeImagesRequest request)
        {
            var marshaller = new DescribeImagesRequestMarshaller();
            var unmarshaller = DescribeImagesResponseUnmarshaller.Instance;

            return Invoke<DescribeImagesRequest,DescribeImagesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeImages operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeImages operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeImagesResponse> DescribeImagesAsync(DescribeImagesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeImagesRequestMarshaller();
            var unmarshaller = DescribeImagesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeImagesRequest,DescribeImagesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeInstanceAttribute

        /// <summary>
        /// Describes the specified attribute of the specified instance. You can specify only
        /// one attribute at a time.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstanceAttribute service method.</param>
        /// 
        /// <returns>The response from the DescribeInstanceAttribute service method, as returned by EC2.</returns>
        public DescribeInstanceAttributeResponse DescribeInstanceAttribute(DescribeInstanceAttributeRequest request)
        {
            var marshaller = new DescribeInstanceAttributeRequestMarshaller();
            var unmarshaller = DescribeInstanceAttributeResponseUnmarshaller.Instance;

            return Invoke<DescribeInstanceAttributeRequest,DescribeInstanceAttributeResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInstanceAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstanceAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeInstanceAttributeResponse> DescribeInstanceAttributeAsync(DescribeInstanceAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeInstanceAttributeRequestMarshaller();
            var unmarshaller = DescribeInstanceAttributeResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeInstanceAttributeRequest,DescribeInstanceAttributeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public DescribeInstancesResponse DescribeInstances()
        {
            return DescribeInstances(new DescribeInstancesRequest());
        }

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
        public DescribeInstancesResponse DescribeInstances(DescribeInstancesRequest request)
        {
            var marshaller = new DescribeInstancesRequestMarshaller();
            var unmarshaller = DescribeInstancesResponseUnmarshaller.Instance;

            return Invoke<DescribeInstancesRequest,DescribeInstancesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInstances operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeInstancesResponse> DescribeInstancesAsync(DescribeInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeInstancesRequestMarshaller();
            var unmarshaller = DescribeInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeInstancesRequest,DescribeInstancesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeInstanceStatus

        /// <summary>
        /// Describes the status of one or more instances, including any scheduled events.
        /// 
        ///  
        /// <para>
        /// Instance status has two main components:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// System Status reports impaired functionality that stems from issues related to the
        /// systems that support an instance, such as such as hardware failures and network connectivity
        /// problems. This call reports such problems as impaired reachability.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Instance Status reports impaired functionality that arises from problems internal
        /// to the instance. This call reports such problems as impaired reachability.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Instance status provides information about four types of scheduled events for an instance
        /// that may require your attention:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Scheduled Reboot: When Amazon EC2 determines that an instance must be rebooted, the
        /// instances status returns one of two event codes: <code>system-reboot</code> or <code>instance-reboot</code>.
        /// System reboot commonly occurs if certain maintenance or upgrade operations require
        /// a reboot of the underlying host that supports an instance. Instance reboot commonly
        /// occurs if the instance must be rebooted, rather than the underlying host. Rebooting
        /// events include a scheduled start and end time.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// System Maintenance: When Amazon EC2 determines that an instance requires maintenance
        /// that requires power or network impact, the instance status is the event code <code>system-maintenance</code>.
        /// System maintenance is either power maintenance or network maintenance. For power maintenance,
        /// your instance will be unavailable for a brief period of time and then rebooted. For
        /// network maintenance, your instance will experience a brief loss of network connectivity.
        /// System maintenance events include a scheduled start and end time. You will also be
        /// notified by email if one of your instances is set for system maintenance. The email
        /// message indicates when your instance is scheduled for maintenance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Scheduled Retirement: When Amazon EC2 determines that an instance must be shut down,
        /// the instance status is the event code <code>instance-retirement</code>. Retirement
        /// commonly occurs when the underlying host is degraded and must be replaced. Retirement
        /// events include a scheduled start and end time. You will also be notified by email
        /// if one of your instances is set to retiring. The email message indicates when your
        /// instance will be permanently retired.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Scheduled Stop: When Amazon EC2 determines that an instance must be shut down, the
        /// instances status returns an event code called <code>instance-stop</code>. Stop events
        /// include a scheduled start and end time. You will also be notified by email if one
        /// of your instances is set to stop. The email message indicates when your instance will
        /// be stopped.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When your instance is retired, it will either be terminated (if its root device type
        /// is the instance-store) or stopped (if its root device type is an EBS volume). Instances
        /// stopped due to retirement will not be restarted, but you can do so manually. You can
        /// also avoid retirement of EBS-backed instances by manually restarting your instance
        /// when its event code is <code>instance-retirement</code>. This ensures that your instance
        /// is started on a different underlying host.
        /// </para>
        ///  
        /// <para>
        /// For more information about failed status checks, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/TroubleshootingInstances.html">Troubleshooting
        /// Instances with Failed Status Checks</a> in the <i>Amazon Elastic Compute Cloud User
        /// Guide</i>. For more information about working with scheduled events, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/monitoring-instances-status-check_sched.html#schedevents_actions">Working
        /// with an Instance That Has a Scheduled Event</a> in the <i>Amazon Elastic Compute Cloud
        /// User Guide</i>.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeInstanceStatus service method, as returned by EC2.</returns>
        public DescribeInstanceStatusResponse DescribeInstanceStatus()
        {
            return DescribeInstanceStatus(new DescribeInstanceStatusRequest());
        }

        /// <summary>
        /// Describes the status of one or more instances, including any scheduled events.
        /// 
        ///  
        /// <para>
        /// Instance status has two main components:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// System Status reports impaired functionality that stems from issues related to the
        /// systems that support an instance, such as such as hardware failures and network connectivity
        /// problems. This call reports such problems as impaired reachability.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Instance Status reports impaired functionality that arises from problems internal
        /// to the instance. This call reports such problems as impaired reachability.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// Instance status provides information about four types of scheduled events for an instance
        /// that may require your attention:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// Scheduled Reboot: When Amazon EC2 determines that an instance must be rebooted, the
        /// instances status returns one of two event codes: <code>system-reboot</code> or <code>instance-reboot</code>.
        /// System reboot commonly occurs if certain maintenance or upgrade operations require
        /// a reboot of the underlying host that supports an instance. Instance reboot commonly
        /// occurs if the instance must be rebooted, rather than the underlying host. Rebooting
        /// events include a scheduled start and end time.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// System Maintenance: When Amazon EC2 determines that an instance requires maintenance
        /// that requires power or network impact, the instance status is the event code <code>system-maintenance</code>.
        /// System maintenance is either power maintenance or network maintenance. For power maintenance,
        /// your instance will be unavailable for a brief period of time and then rebooted. For
        /// network maintenance, your instance will experience a brief loss of network connectivity.
        /// System maintenance events include a scheduled start and end time. You will also be
        /// notified by email if one of your instances is set for system maintenance. The email
        /// message indicates when your instance is scheduled for maintenance.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Scheduled Retirement: When Amazon EC2 determines that an instance must be shut down,
        /// the instance status is the event code <code>instance-retirement</code>. Retirement
        /// commonly occurs when the underlying host is degraded and must be replaced. Retirement
        /// events include a scheduled start and end time. You will also be notified by email
        /// if one of your instances is set to retiring. The email message indicates when your
        /// instance will be permanently retired.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// Scheduled Stop: When Amazon EC2 determines that an instance must be shut down, the
        /// instances status returns an event code called <code>instance-stop</code>. Stop events
        /// include a scheduled start and end time. You will also be notified by email if one
        /// of your instances is set to stop. The email message indicates when your instance will
        /// be stopped.
        /// </para>
        ///  </li> </ul> 
        /// <para>
        /// When your instance is retired, it will either be terminated (if its root device type
        /// is the instance-store) or stopped (if its root device type is an EBS volume). Instances
        /// stopped due to retirement will not be restarted, but you can do so manually. You can
        /// also avoid retirement of EBS-backed instances by manually restarting your instance
        /// when its event code is <code>instance-retirement</code>. This ensures that your instance
        /// is started on a different underlying host.
        /// </para>
        ///  
        /// <para>
        /// For more information about failed status checks, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/TroubleshootingInstances.html">Troubleshooting
        /// Instances with Failed Status Checks</a> in the <i>Amazon Elastic Compute Cloud User
        /// Guide</i>. For more information about working with scheduled events, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/monitoring-instances-status-check_sched.html#schedevents_actions">Working
        /// with an Instance That Has a Scheduled Event</a> in the <i>Amazon Elastic Compute Cloud
        /// User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstanceStatus service method.</param>
        /// 
        /// <returns>The response from the DescribeInstanceStatus service method, as returned by EC2.</returns>
        public DescribeInstanceStatusResponse DescribeInstanceStatus(DescribeInstanceStatusRequest request)
        {
            var marshaller = new DescribeInstanceStatusRequestMarshaller();
            var unmarshaller = DescribeInstanceStatusResponseUnmarshaller.Instance;

            return Invoke<DescribeInstanceStatusRequest,DescribeInstanceStatusResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInstanceStatus operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstanceStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeInstanceStatusResponse> DescribeInstanceStatusAsync(DescribeInstanceStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeInstanceStatusRequestMarshaller();
            var unmarshaller = DescribeInstanceStatusResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeInstanceStatusRequest,DescribeInstanceStatusResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeInternetGateways

        /// <summary>
        /// Describes one or more of your Internet gateways.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeInternetGateways service method, as returned by EC2.</returns>
        public DescribeInternetGatewaysResponse DescribeInternetGateways()
        {
            return DescribeInternetGateways(new DescribeInternetGatewaysRequest());
        }

        /// <summary>
        /// Describes one or more of your Internet gateways.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInternetGateways service method.</param>
        /// 
        /// <returns>The response from the DescribeInternetGateways service method, as returned by EC2.</returns>
        public DescribeInternetGatewaysResponse DescribeInternetGateways(DescribeInternetGatewaysRequest request)
        {
            var marshaller = new DescribeInternetGatewaysRequestMarshaller();
            var unmarshaller = DescribeInternetGatewaysResponseUnmarshaller.Instance;

            return Invoke<DescribeInternetGatewaysRequest,DescribeInternetGatewaysResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInternetGateways operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInternetGateways operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeInternetGatewaysResponse> DescribeInternetGatewaysAsync(DescribeInternetGatewaysRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeInternetGatewaysRequestMarshaller();
            var unmarshaller = DescribeInternetGatewaysResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeInternetGatewaysRequest,DescribeInternetGatewaysResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public DescribeKeyPairsResponse DescribeKeyPairs()
        {
            return DescribeKeyPairs(new DescribeKeyPairsRequest());
        }

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
        public DescribeKeyPairsResponse DescribeKeyPairs(DescribeKeyPairsRequest request)
        {
            var marshaller = new DescribeKeyPairsRequestMarshaller();
            var unmarshaller = DescribeKeyPairsResponseUnmarshaller.Instance;

            return Invoke<DescribeKeyPairsRequest,DescribeKeyPairsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeKeyPairs operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeKeyPairs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeKeyPairsResponse> DescribeKeyPairsAsync(DescribeKeyPairsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeKeyPairsRequestMarshaller();
            var unmarshaller = DescribeKeyPairsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeKeyPairsRequest,DescribeKeyPairsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public DescribeNetworkAclsResponse DescribeNetworkAcls()
        {
            return DescribeNetworkAcls(new DescribeNetworkAclsRequest());
        }

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
        public DescribeNetworkAclsResponse DescribeNetworkAcls(DescribeNetworkAclsRequest request)
        {
            var marshaller = new DescribeNetworkAclsRequestMarshaller();
            var unmarshaller = DescribeNetworkAclsResponseUnmarshaller.Instance;

            return Invoke<DescribeNetworkAclsRequest,DescribeNetworkAclsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeNetworkAcls operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeNetworkAcls operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeNetworkAclsResponse> DescribeNetworkAclsAsync(DescribeNetworkAclsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeNetworkAclsRequestMarshaller();
            var unmarshaller = DescribeNetworkAclsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeNetworkAclsRequest,DescribeNetworkAclsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeNetworkInterfaceAttribute

        /// <summary>
        /// Describes a network interface attribute. You can specify only one attribute at a time.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeNetworkInterfaceAttribute service method.</param>
        /// 
        /// <returns>The response from the DescribeNetworkInterfaceAttribute service method, as returned by EC2.</returns>
        public DescribeNetworkInterfaceAttributeResponse DescribeNetworkInterfaceAttribute(DescribeNetworkInterfaceAttributeRequest request)
        {
            var marshaller = new DescribeNetworkInterfaceAttributeRequestMarshaller();
            var unmarshaller = DescribeNetworkInterfaceAttributeResponseUnmarshaller.Instance;

            return Invoke<DescribeNetworkInterfaceAttributeRequest,DescribeNetworkInterfaceAttributeResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeNetworkInterfaceAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeNetworkInterfaceAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeNetworkInterfaceAttributeResponse> DescribeNetworkInterfaceAttributeAsync(DescribeNetworkInterfaceAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeNetworkInterfaceAttributeRequestMarshaller();
            var unmarshaller = DescribeNetworkInterfaceAttributeResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeNetworkInterfaceAttributeRequest,DescribeNetworkInterfaceAttributeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeNetworkInterfaces

        /// <summary>
        /// Describes one or more of your network interfaces.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeNetworkInterfaces service method, as returned by EC2.</returns>
        public DescribeNetworkInterfacesResponse DescribeNetworkInterfaces()
        {
            return DescribeNetworkInterfaces(new DescribeNetworkInterfacesRequest());
        }

        /// <summary>
        /// Describes one or more of your network interfaces.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeNetworkInterfaces service method.</param>
        /// 
        /// <returns>The response from the DescribeNetworkInterfaces service method, as returned by EC2.</returns>
        public DescribeNetworkInterfacesResponse DescribeNetworkInterfaces(DescribeNetworkInterfacesRequest request)
        {
            var marshaller = new DescribeNetworkInterfacesRequestMarshaller();
            var unmarshaller = DescribeNetworkInterfacesResponseUnmarshaller.Instance;

            return Invoke<DescribeNetworkInterfacesRequest,DescribeNetworkInterfacesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeNetworkInterfaces operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeNetworkInterfaces operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeNetworkInterfacesResponse> DescribeNetworkInterfacesAsync(DescribeNetworkInterfacesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeNetworkInterfacesRequestMarshaller();
            var unmarshaller = DescribeNetworkInterfacesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeNetworkInterfacesRequest,DescribeNetworkInterfacesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribePlacementGroups

        /// <summary>
        /// Describes one or more of your placement groups. For more information about placement
        /// groups and cluster instances, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using_cluster_computing.html">Cluster
        /// Instances</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </summary>
        /// 
        /// <returns>The response from the DescribePlacementGroups service method, as returned by EC2.</returns>
        public DescribePlacementGroupsResponse DescribePlacementGroups()
        {
            return DescribePlacementGroups(new DescribePlacementGroupsRequest());
        }

        /// <summary>
        /// Describes one or more of your placement groups. For more information about placement
        /// groups and cluster instances, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using_cluster_computing.html">Cluster
        /// Instances</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribePlacementGroups service method.</param>
        /// 
        /// <returns>The response from the DescribePlacementGroups service method, as returned by EC2.</returns>
        public DescribePlacementGroupsResponse DescribePlacementGroups(DescribePlacementGroupsRequest request)
        {
            var marshaller = new DescribePlacementGroupsRequestMarshaller();
            var unmarshaller = DescribePlacementGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribePlacementGroupsRequest,DescribePlacementGroupsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribePlacementGroups operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePlacementGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribePlacementGroupsResponse> DescribePlacementGroupsAsync(DescribePlacementGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribePlacementGroupsRequestMarshaller();
            var unmarshaller = DescribePlacementGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribePlacementGroupsRequest,DescribePlacementGroupsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public DescribeRegionsResponse DescribeRegions()
        {
            return DescribeRegions(new DescribeRegionsRequest());
        }

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
        public DescribeRegionsResponse DescribeRegions(DescribeRegionsRequest request)
        {
            var marshaller = new DescribeRegionsRequestMarshaller();
            var unmarshaller = DescribeRegionsResponseUnmarshaller.Instance;

            return Invoke<DescribeRegionsRequest,DescribeRegionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRegions operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRegions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeRegionsResponse> DescribeRegionsAsync(DescribeRegionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeRegionsRequestMarshaller();
            var unmarshaller = DescribeRegionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeRegionsRequest,DescribeRegionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public DescribeReservedInstancesResponse DescribeReservedInstances()
        {
            return DescribeReservedInstances(new DescribeReservedInstancesRequest());
        }

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
        public DescribeReservedInstancesResponse DescribeReservedInstances(DescribeReservedInstancesRequest request)
        {
            var marshaller = new DescribeReservedInstancesRequestMarshaller();
            var unmarshaller = DescribeReservedInstancesResponseUnmarshaller.Instance;

            return Invoke<DescribeReservedInstancesRequest,DescribeReservedInstancesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReservedInstances operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeReservedInstancesResponse> DescribeReservedInstancesAsync(DescribeReservedInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeReservedInstancesRequestMarshaller();
            var unmarshaller = DescribeReservedInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeReservedInstancesRequest,DescribeReservedInstancesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeReservedInstancesListings

        /// <summary>
        /// Describes your account's Reserved Instance listings in the Reserved Instance Marketplace.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ri-market-general.html">Reserved
        /// Instance Marketplace</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeReservedInstancesListings service method, as returned by EC2.</returns>
        public DescribeReservedInstancesListingsResponse DescribeReservedInstancesListings()
        {
            return DescribeReservedInstancesListings(new DescribeReservedInstancesListingsRequest());
        }

        /// <summary>
        /// Describes your account's Reserved Instance listings in the Reserved Instance Marketplace.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ri-market-general.html">Reserved
        /// Instance Marketplace</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedInstancesListings service method.</param>
        /// 
        /// <returns>The response from the DescribeReservedInstancesListings service method, as returned by EC2.</returns>
        public DescribeReservedInstancesListingsResponse DescribeReservedInstancesListings(DescribeReservedInstancesListingsRequest request)
        {
            var marshaller = new DescribeReservedInstancesListingsRequestMarshaller();
            var unmarshaller = DescribeReservedInstancesListingsResponseUnmarshaller.Instance;

            return Invoke<DescribeReservedInstancesListingsRequest,DescribeReservedInstancesListingsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReservedInstancesListings operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedInstancesListings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeReservedInstancesListingsResponse> DescribeReservedInstancesListingsAsync(DescribeReservedInstancesListingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeReservedInstancesListingsRequestMarshaller();
            var unmarshaller = DescribeReservedInstancesListingsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeReservedInstancesListingsRequest,DescribeReservedInstancesListingsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeReservedInstancesModifications

        /// <summary>
        /// Describes the modifications made to your Reserved Instances. If no parameter is specified,
        /// information about all your Reserved Instances modification requests is returned. If
        /// a modification ID is specified, only information about the specific modification is
        /// returned.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeReservedInstancesModifications service method, as returned by EC2.</returns>
        public DescribeReservedInstancesModificationsResponse DescribeReservedInstancesModifications()
        {
            return DescribeReservedInstancesModifications(new DescribeReservedInstancesModificationsRequest());
        }

        /// <summary>
        /// Describes the modifications made to your Reserved Instances. If no parameter is specified,
        /// information about all your Reserved Instances modification requests is returned. If
        /// a modification ID is specified, only information about the specific modification is
        /// returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedInstancesModifications service method.</param>
        /// 
        /// <returns>The response from the DescribeReservedInstancesModifications service method, as returned by EC2.</returns>
        public DescribeReservedInstancesModificationsResponse DescribeReservedInstancesModifications(DescribeReservedInstancesModificationsRequest request)
        {
            var marshaller = new DescribeReservedInstancesModificationsRequestMarshaller();
            var unmarshaller = DescribeReservedInstancesModificationsResponseUnmarshaller.Instance;

            return Invoke<DescribeReservedInstancesModificationsRequest,DescribeReservedInstancesModificationsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReservedInstancesModifications operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedInstancesModifications operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeReservedInstancesModificationsResponse> DescribeReservedInstancesModificationsAsync(DescribeReservedInstancesModificationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeReservedInstancesModificationsRequestMarshaller();
            var unmarshaller = DescribeReservedInstancesModificationsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeReservedInstancesModificationsRequest,DescribeReservedInstancesModificationsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public DescribeReservedInstancesOfferingsResponse DescribeReservedInstancesOfferings()
        {
            return DescribeReservedInstancesOfferings(new DescribeReservedInstancesOfferingsRequest());
        }

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
        public DescribeReservedInstancesOfferingsResponse DescribeReservedInstancesOfferings(DescribeReservedInstancesOfferingsRequest request)
        {
            var marshaller = new DescribeReservedInstancesOfferingsRequestMarshaller();
            var unmarshaller = DescribeReservedInstancesOfferingsResponseUnmarshaller.Instance;

            return Invoke<DescribeReservedInstancesOfferingsRequest,DescribeReservedInstancesOfferingsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReservedInstancesOfferings operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedInstancesOfferings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeReservedInstancesOfferingsResponse> DescribeReservedInstancesOfferingsAsync(DescribeReservedInstancesOfferingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeReservedInstancesOfferingsRequestMarshaller();
            var unmarshaller = DescribeReservedInstancesOfferingsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeReservedInstancesOfferingsRequest,DescribeReservedInstancesOfferingsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeRouteTables

        /// <summary>
        /// Describes one or more of your route tables.
        /// 
        ///  
        /// <para>
        /// For more information about route tables, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Route_Tables.html">Route
        /// Tables</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeRouteTables service method, as returned by EC2.</returns>
        public DescribeRouteTablesResponse DescribeRouteTables()
        {
            return DescribeRouteTables(new DescribeRouteTablesRequest());
        }

        /// <summary>
        /// Describes one or more of your route tables.
        /// 
        ///  
        /// <para>
        /// For more information about route tables, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Route_Tables.html">Route
        /// Tables</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRouteTables service method.</param>
        /// 
        /// <returns>The response from the DescribeRouteTables service method, as returned by EC2.</returns>
        public DescribeRouteTablesResponse DescribeRouteTables(DescribeRouteTablesRequest request)
        {
            var marshaller = new DescribeRouteTablesRequestMarshaller();
            var unmarshaller = DescribeRouteTablesResponseUnmarshaller.Instance;

            return Invoke<DescribeRouteTablesRequest,DescribeRouteTablesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRouteTables operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRouteTables operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeRouteTablesResponse> DescribeRouteTablesAsync(DescribeRouteTablesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeRouteTablesRequestMarshaller();
            var unmarshaller = DescribeRouteTablesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeRouteTablesRequest,DescribeRouteTablesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public DescribeSecurityGroupsResponse DescribeSecurityGroups()
        {
            return DescribeSecurityGroups(new DescribeSecurityGroupsRequest());
        }

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
        public DescribeSecurityGroupsResponse DescribeSecurityGroups(DescribeSecurityGroupsRequest request)
        {
            var marshaller = new DescribeSecurityGroupsRequestMarshaller();
            var unmarshaller = DescribeSecurityGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribeSecurityGroupsRequest,DescribeSecurityGroupsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSecurityGroups operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSecurityGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeSecurityGroupsResponse> DescribeSecurityGroupsAsync(DescribeSecurityGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeSecurityGroupsRequestMarshaller();
            var unmarshaller = DescribeSecurityGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSecurityGroupsRequest,DescribeSecurityGroupsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeSnapshotAttribute

        /// <summary>
        /// Describes the specified attribute of the specified snapshot. You can specify only
        /// one attribute at a time.
        /// 
        ///  
        /// <para>
        /// For more information about Amazon EBS snapshots, see <a href='http://docs.&awsdomain;/AWSEC2/latest/UserGuide/EBSSnapshots.html'>Amazon
        /// EBS Snapshots</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSnapshotAttribute service method.</param>
        /// 
        /// <returns>The response from the DescribeSnapshotAttribute service method, as returned by EC2.</returns>
        public DescribeSnapshotAttributeResponse DescribeSnapshotAttribute(DescribeSnapshotAttributeRequest request)
        {
            var marshaller = new DescribeSnapshotAttributeRequestMarshaller();
            var unmarshaller = DescribeSnapshotAttributeResponseUnmarshaller.Instance;

            return Invoke<DescribeSnapshotAttributeRequest,DescribeSnapshotAttributeResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSnapshotAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSnapshotAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeSnapshotAttributeResponse> DescribeSnapshotAttributeAsync(DescribeSnapshotAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeSnapshotAttributeRequestMarshaller();
            var unmarshaller = DescribeSnapshotAttributeResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSnapshotAttributeRequest,DescribeSnapshotAttributeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeSnapshots

        /// <summary>
        /// Describes one or more of the Amazon EBS snapshots available to you. Available snapshots
        /// include public snapshots available for any AWS account to launch, private snapshots
        /// that you own, and private snapshots owned by another AWS account but for which you've
        /// been given explicit create volume permissions.
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
        /// For more information about Amazon EBS snapshots, see <a href='http://docs.&awsdomain;/AWSEC2/latest/UserGuide/EBSSnapshots.html'>Amazon
        /// EBS Snapshots</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeSnapshots service method, as returned by EC2.</returns>
        public DescribeSnapshotsResponse DescribeSnapshots()
        {
            return DescribeSnapshots(new DescribeSnapshotsRequest());
        }

        /// <summary>
        /// Describes one or more of the Amazon EBS snapshots available to you. Available snapshots
        /// include public snapshots available for any AWS account to launch, private snapshots
        /// that you own, and private snapshots owned by another AWS account but for which you've
        /// been given explicit create volume permissions.
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
        /// For more information about Amazon EBS snapshots, see <a href='http://docs.&awsdomain;/AWSEC2/latest/UserGuide/EBSSnapshots.html'>Amazon
        /// EBS Snapshots</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSnapshots service method.</param>
        /// 
        /// <returns>The response from the DescribeSnapshots service method, as returned by EC2.</returns>
        public DescribeSnapshotsResponse DescribeSnapshots(DescribeSnapshotsRequest request)
        {
            var marshaller = new DescribeSnapshotsRequestMarshaller();
            var unmarshaller = DescribeSnapshotsResponseUnmarshaller.Instance;

            return Invoke<DescribeSnapshotsRequest,DescribeSnapshotsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSnapshots operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSnapshots operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeSnapshotsResponse> DescribeSnapshotsAsync(DescribeSnapshotsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeSnapshotsRequestMarshaller();
            var unmarshaller = DescribeSnapshotsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSnapshotsRequest,DescribeSnapshotsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeSpotDatafeedSubscription

        /// <summary>
        /// Describes the datafeed for Spot Instances. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-spot-instances.html">Spot
        /// Instances</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeSpotDatafeedSubscription service method, as returned by EC2.</returns>
        public DescribeSpotDatafeedSubscriptionResponse DescribeSpotDatafeedSubscription()
        {
            return DescribeSpotDatafeedSubscription(new DescribeSpotDatafeedSubscriptionRequest());
        }

        /// <summary>
        /// Describes the datafeed for Spot Instances. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-spot-instances.html">Spot
        /// Instances</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSpotDatafeedSubscription service method.</param>
        /// 
        /// <returns>The response from the DescribeSpotDatafeedSubscription service method, as returned by EC2.</returns>
        public DescribeSpotDatafeedSubscriptionResponse DescribeSpotDatafeedSubscription(DescribeSpotDatafeedSubscriptionRequest request)
        {
            var marshaller = new DescribeSpotDatafeedSubscriptionRequestMarshaller();
            var unmarshaller = DescribeSpotDatafeedSubscriptionResponseUnmarshaller.Instance;

            return Invoke<DescribeSpotDatafeedSubscriptionRequest,DescribeSpotDatafeedSubscriptionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSpotDatafeedSubscription operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSpotDatafeedSubscription operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeSpotDatafeedSubscriptionResponse> DescribeSpotDatafeedSubscriptionAsync(DescribeSpotDatafeedSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeSpotDatafeedSubscriptionRequestMarshaller();
            var unmarshaller = DescribeSpotDatafeedSubscriptionResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSpotDatafeedSubscriptionRequest,DescribeSpotDatafeedSubscriptionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeSpotInstanceRequests

        /// <summary>
        /// Describes the Spot Instance requests that belong to your account. Spot Instances are
        /// instances that Amazon EC2 starts on your behalf when the maximum price that you specify
        /// exceeds the current Spot Price. Amazon EC2 periodically sets the Spot Price based
        /// on available Spot Instance capacity and current Spot Instance requests. For more information
        /// about Spot Instances, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-spot-instances.html">Spot
        /// Instances</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
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
        public DescribeSpotInstanceRequestsResponse DescribeSpotInstanceRequests()
        {
            return DescribeSpotInstanceRequests(new DescribeSpotInstanceRequestsRequest());
        }

        /// <summary>
        /// Describes the Spot Instance requests that belong to your account. Spot Instances are
        /// instances that Amazon EC2 starts on your behalf when the maximum price that you specify
        /// exceeds the current Spot Price. Amazon EC2 periodically sets the Spot Price based
        /// on available Spot Instance capacity and current Spot Instance requests. For more information
        /// about Spot Instances, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-spot-instances.html">Spot
        /// Instances</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
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
        public DescribeSpotInstanceRequestsResponse DescribeSpotInstanceRequests(DescribeSpotInstanceRequestsRequest request)
        {
            var marshaller = new DescribeSpotInstanceRequestsRequestMarshaller();
            var unmarshaller = DescribeSpotInstanceRequestsResponseUnmarshaller.Instance;

            return Invoke<DescribeSpotInstanceRequestsRequest,DescribeSpotInstanceRequestsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSpotInstanceRequests operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSpotInstanceRequests operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeSpotInstanceRequestsResponse> DescribeSpotInstanceRequestsAsync(DescribeSpotInstanceRequestsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeSpotInstanceRequestsRequestMarshaller();
            var unmarshaller = DescribeSpotInstanceRequestsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSpotInstanceRequestsRequest,DescribeSpotInstanceRequestsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeSpotPriceHistory

        /// <summary>
        /// Describes the Spot Price history. Spot Instances are instances that Amazon EC2 starts
        /// on your behalf when the maximum price that you specify exceeds the current Spot Price.
        /// Amazon EC2 periodically sets the Spot Price based on available Spot Instance capacity
        /// and current Spot Instance requests. For more information about Spot Instances, see
        /// <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-spot-instances.html">Spot
        /// Instances</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// 
        ///  
        /// <para>
        /// When you specify an Availability Zone, this operation describes the price history
        /// for the specified Availability Zone with the most recent set of prices listed first.
        /// If you don't specify an Availability Zone, you get the prices across all Availability
        /// Zones, starting with the most recent set. However, if you're using an API version
        /// earlier than 2011-05-15, you get the lowest price across the region for the specified
        /// time period. The prices returned are listed in chronological order, from the oldest
        /// to the most recent.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeSpotPriceHistory service method, as returned by EC2.</returns>
        public DescribeSpotPriceHistoryResponse DescribeSpotPriceHistory()
        {
            return DescribeSpotPriceHistory(new DescribeSpotPriceHistoryRequest());
        }

        /// <summary>
        /// Describes the Spot Price history. Spot Instances are instances that Amazon EC2 starts
        /// on your behalf when the maximum price that you specify exceeds the current Spot Price.
        /// Amazon EC2 periodically sets the Spot Price based on available Spot Instance capacity
        /// and current Spot Instance requests. For more information about Spot Instances, see
        /// <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-spot-instances.html">Spot
        /// Instances</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// 
        ///  
        /// <para>
        /// When you specify an Availability Zone, this operation describes the price history
        /// for the specified Availability Zone with the most recent set of prices listed first.
        /// If you don't specify an Availability Zone, you get the prices across all Availability
        /// Zones, starting with the most recent set. However, if you're using an API version
        /// earlier than 2011-05-15, you get the lowest price across the region for the specified
        /// time period. The prices returned are listed in chronological order, from the oldest
        /// to the most recent.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeSpotPriceHistory service method.</param>
        /// 
        /// <returns>The response from the DescribeSpotPriceHistory service method, as returned by EC2.</returns>
        public DescribeSpotPriceHistoryResponse DescribeSpotPriceHistory(DescribeSpotPriceHistoryRequest request)
        {
            var marshaller = new DescribeSpotPriceHistoryRequestMarshaller();
            var unmarshaller = DescribeSpotPriceHistoryResponseUnmarshaller.Instance;

            return Invoke<DescribeSpotPriceHistoryRequest,DescribeSpotPriceHistoryResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSpotPriceHistory operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSpotPriceHistory operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeSpotPriceHistoryResponse> DescribeSpotPriceHistoryAsync(DescribeSpotPriceHistoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeSpotPriceHistoryRequestMarshaller();
            var unmarshaller = DescribeSpotPriceHistoryResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSpotPriceHistoryRequest,DescribeSpotPriceHistoryResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public DescribeSubnetsResponse DescribeSubnets()
        {
            return DescribeSubnets(new DescribeSubnetsRequest());
        }

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
        public DescribeSubnetsResponse DescribeSubnets(DescribeSubnetsRequest request)
        {
            var marshaller = new DescribeSubnetsRequestMarshaller();
            var unmarshaller = DescribeSubnetsResponseUnmarshaller.Instance;

            return Invoke<DescribeSubnetsRequest,DescribeSubnetsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSubnets operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSubnets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeSubnetsResponse> DescribeSubnetsAsync(DescribeSubnetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeSubnetsRequestMarshaller();
            var unmarshaller = DescribeSubnetsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSubnetsRequest,DescribeSubnetsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public DescribeTagsResponse DescribeTags()
        {
            return DescribeTags(new DescribeTagsRequest());
        }

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
        public DescribeTagsResponse DescribeTags(DescribeTagsRequest request)
        {
            var marshaller = new DescribeTagsRequestMarshaller();
            var unmarshaller = DescribeTagsResponseUnmarshaller.Instance;

            return Invoke<DescribeTagsRequest,DescribeTagsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTags operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeTagsResponse> DescribeTagsAsync(DescribeTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeTagsRequestMarshaller();
            var unmarshaller = DescribeTagsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTagsRequest,DescribeTagsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeVolumeAttribute

        /// <summary>
        /// Describes the specified attribute of the specified volume. You can specify only one
        /// attribute at a time.
        /// 
        ///  
        /// <para>
        /// For more information about Amazon EBS volumes, see <a href='http://docs.&awsdomain;/AWSEC2/latest/UserGuide/EBSVolumes.html'>Amazon
        /// EBS Volumes</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVolumeAttribute service method.</param>
        /// 
        /// <returns>The response from the DescribeVolumeAttribute service method, as returned by EC2.</returns>
        public DescribeVolumeAttributeResponse DescribeVolumeAttribute(DescribeVolumeAttributeRequest request)
        {
            var marshaller = new DescribeVolumeAttributeRequestMarshaller();
            var unmarshaller = DescribeVolumeAttributeResponseUnmarshaller.Instance;

            return Invoke<DescribeVolumeAttributeRequest,DescribeVolumeAttributeResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVolumeAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVolumeAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeVolumeAttributeResponse> DescribeVolumeAttributeAsync(DescribeVolumeAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeVolumeAttributeRequestMarshaller();
            var unmarshaller = DescribeVolumeAttributeResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeVolumeAttributeRequest,DescribeVolumeAttributeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeVolumes

        /// <summary>
        /// Describes the specified Amazon EBS volumes.
        /// 
        ///  
        /// <para>
        /// For more information about Amazon EBS volumes, see <a href='http://docs.&awsdomain;/AWSEC2/latest/UserGuide/EBSVolumes.html'>Amazon
        /// EBS Volumes</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeVolumes service method, as returned by EC2.</returns>
        public DescribeVolumesResponse DescribeVolumes()
        {
            return DescribeVolumes(new DescribeVolumesRequest());
        }

        /// <summary>
        /// Describes the specified Amazon EBS volumes.
        /// 
        ///  
        /// <para>
        /// For more information about Amazon EBS volumes, see <a href='http://docs.&awsdomain;/AWSEC2/latest/UserGuide/EBSVolumes.html'>Amazon
        /// EBS Volumes</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVolumes service method.</param>
        /// 
        /// <returns>The response from the DescribeVolumes service method, as returned by EC2.</returns>
        public DescribeVolumesResponse DescribeVolumes(DescribeVolumesRequest request)
        {
            var marshaller = new DescribeVolumesRequestMarshaller();
            var unmarshaller = DescribeVolumesResponseUnmarshaller.Instance;

            return Invoke<DescribeVolumesRequest,DescribeVolumesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVolumes operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVolumes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeVolumesResponse> DescribeVolumesAsync(DescribeVolumesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeVolumesRequestMarshaller();
            var unmarshaller = DescribeVolumesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeVolumesRequest,DescribeVolumesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        /// </summary>
        /// 
        /// <returns>The response from the DescribeVolumeStatus service method, as returned by EC2.</returns>
        public DescribeVolumeStatusResponse DescribeVolumeStatus()
        {
            return DescribeVolumeStatus(new DescribeVolumeStatusRequest());
        }

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
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVolumeStatus service method.</param>
        /// 
        /// <returns>The response from the DescribeVolumeStatus service method, as returned by EC2.</returns>
        public DescribeVolumeStatusResponse DescribeVolumeStatus(DescribeVolumeStatusRequest request)
        {
            var marshaller = new DescribeVolumeStatusRequestMarshaller();
            var unmarshaller = DescribeVolumeStatusResponseUnmarshaller.Instance;

            return Invoke<DescribeVolumeStatusRequest,DescribeVolumeStatusResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVolumeStatus operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVolumeStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeVolumeStatusResponse> DescribeVolumeStatusAsync(DescribeVolumeStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeVolumeStatusRequestMarshaller();
            var unmarshaller = DescribeVolumeStatusResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeVolumeStatusRequest,DescribeVolumeStatusResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeVpcAttribute

        /// <summary>
        /// Describes the specified attribute of the specified VPC. You can specify only one attribute
        /// at a time.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcAttribute service method.</param>
        /// 
        /// <returns>The response from the DescribeVpcAttribute service method, as returned by EC2.</returns>
        public DescribeVpcAttributeResponse DescribeVpcAttribute(DescribeVpcAttributeRequest request)
        {
            var marshaller = new DescribeVpcAttributeRequestMarshaller();
            var unmarshaller = DescribeVpcAttributeResponseUnmarshaller.Instance;

            return Invoke<DescribeVpcAttributeRequest,DescribeVpcAttributeResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVpcAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeVpcAttributeResponse> DescribeVpcAttributeAsync(DescribeVpcAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeVpcAttributeRequestMarshaller();
            var unmarshaller = DescribeVpcAttributeResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeVpcAttributeRequest,DescribeVpcAttributeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeVpcPeeringConnections

        /// <summary>
        /// Describes one or more of your VPC peering connections.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeVpcPeeringConnections service method, as returned by EC2.</returns>
        public DescribeVpcPeeringConnectionsResponse DescribeVpcPeeringConnections()
        {
            return DescribeVpcPeeringConnections(new DescribeVpcPeeringConnectionsRequest());
        }

        /// <summary>
        /// Describes one or more of your VPC peering connections.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcPeeringConnections service method.</param>
        /// 
        /// <returns>The response from the DescribeVpcPeeringConnections service method, as returned by EC2.</returns>
        public DescribeVpcPeeringConnectionsResponse DescribeVpcPeeringConnections(DescribeVpcPeeringConnectionsRequest request)
        {
            var marshaller = new DescribeVpcPeeringConnectionsRequestMarshaller();
            var unmarshaller = DescribeVpcPeeringConnectionsResponseUnmarshaller.Instance;

            return Invoke<DescribeVpcPeeringConnectionsRequest,DescribeVpcPeeringConnectionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVpcPeeringConnections operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcPeeringConnections operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeVpcPeeringConnectionsResponse> DescribeVpcPeeringConnectionsAsync(DescribeVpcPeeringConnectionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeVpcPeeringConnectionsRequestMarshaller();
            var unmarshaller = DescribeVpcPeeringConnectionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeVpcPeeringConnectionsRequest,DescribeVpcPeeringConnectionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeVpcs

        /// <summary>
        /// Describes one or more of your VPCs.
        /// </summary>
        /// 
        /// <returns>The response from the DescribeVpcs service method, as returned by EC2.</returns>
        public DescribeVpcsResponse DescribeVpcs()
        {
            return DescribeVpcs(new DescribeVpcsRequest());
        }

        /// <summary>
        /// Describes one or more of your VPCs.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcs service method.</param>
        /// 
        /// <returns>The response from the DescribeVpcs service method, as returned by EC2.</returns>
        public DescribeVpcsResponse DescribeVpcs(DescribeVpcsRequest request)
        {
            var marshaller = new DescribeVpcsRequestMarshaller();
            var unmarshaller = DescribeVpcsResponseUnmarshaller.Instance;

            return Invoke<DescribeVpcsRequest,DescribeVpcsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVpcs operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeVpcsResponse> DescribeVpcsAsync(DescribeVpcsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeVpcsRequestMarshaller();
            var unmarshaller = DescribeVpcsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeVpcsRequest,DescribeVpcsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public DescribeVpnConnectionsResponse DescribeVpnConnections()
        {
            return DescribeVpnConnections(new DescribeVpnConnectionsRequest());
        }

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
        public DescribeVpnConnectionsResponse DescribeVpnConnections(DescribeVpnConnectionsRequest request)
        {
            var marshaller = new DescribeVpnConnectionsRequestMarshaller();
            var unmarshaller = DescribeVpnConnectionsResponseUnmarshaller.Instance;

            return Invoke<DescribeVpnConnectionsRequest,DescribeVpnConnectionsResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVpnConnections operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpnConnections operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeVpnConnectionsResponse> DescribeVpnConnectionsAsync(DescribeVpnConnectionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeVpnConnectionsRequestMarshaller();
            var unmarshaller = DescribeVpnConnectionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeVpnConnectionsRequest,DescribeVpnConnectionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public DescribeVpnGatewaysResponse DescribeVpnGateways()
        {
            return DescribeVpnGateways(new DescribeVpnGatewaysRequest());
        }

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
        public DescribeVpnGatewaysResponse DescribeVpnGateways(DescribeVpnGatewaysRequest request)
        {
            var marshaller = new DescribeVpnGatewaysRequestMarshaller();
            var unmarshaller = DescribeVpnGatewaysResponseUnmarshaller.Instance;

            return Invoke<DescribeVpnGatewaysRequest,DescribeVpnGatewaysResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVpnGateways operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpnGateways operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DescribeVpnGatewaysResponse> DescribeVpnGatewaysAsync(DescribeVpnGatewaysRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeVpnGatewaysRequestMarshaller();
            var unmarshaller = DescribeVpnGatewaysResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeVpnGatewaysRequest,DescribeVpnGatewaysResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DetachInternetGateway

        /// <summary>
        /// Detaches an Internet gateway from a VPC, disabling connectivity between the Internet
        /// and the VPC. The VPC must not contain any running instances with Elastic IP addresses.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachInternetGateway service method.</param>
        /// 
        /// <returns>The response from the DetachInternetGateway service method, as returned by EC2.</returns>
        public DetachInternetGatewayResponse DetachInternetGateway(DetachInternetGatewayRequest request)
        {
            var marshaller = new DetachInternetGatewayRequestMarshaller();
            var unmarshaller = DetachInternetGatewayResponseUnmarshaller.Instance;

            return Invoke<DetachInternetGatewayRequest,DetachInternetGatewayResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DetachInternetGateway operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachInternetGateway operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DetachInternetGatewayResponse> DetachInternetGatewayAsync(DetachInternetGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DetachInternetGatewayRequestMarshaller();
            var unmarshaller = DetachInternetGatewayResponseUnmarshaller.Instance;

            return InvokeAsync<DetachInternetGatewayRequest,DetachInternetGatewayResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DetachNetworkInterface

        /// <summary>
        /// Detaches a network interface from an instance.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DetachNetworkInterface service method.</param>
        /// 
        /// <returns>The response from the DetachNetworkInterface service method, as returned by EC2.</returns>
        public DetachNetworkInterfaceResponse DetachNetworkInterface(DetachNetworkInterfaceRequest request)
        {
            var marshaller = new DetachNetworkInterfaceRequestMarshaller();
            var unmarshaller = DetachNetworkInterfaceResponseUnmarshaller.Instance;

            return Invoke<DetachNetworkInterfaceRequest,DetachNetworkInterfaceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DetachNetworkInterface operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachNetworkInterface operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DetachNetworkInterfaceResponse> DetachNetworkInterfaceAsync(DetachNetworkInterfaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DetachNetworkInterfaceRequestMarshaller();
            var unmarshaller = DetachNetworkInterfaceResponseUnmarshaller.Instance;

            return InvokeAsync<DetachNetworkInterfaceRequest,DetachNetworkInterfaceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DetachVolume

        /// <summary>
        /// Detaches an Amazon EBS volume from an instance. Make sure to unmount any file systems
        /// on the device within your operating system before detaching the volume. Failure to
        /// do so results in the volume being stuck in a busy state while detaching.
        /// 
        ///  
        /// <para>
        /// If an Amazon EBS volume is the root device of an instance, it can't be detached while
        /// the instance is running. To detach the root volume, stop the instance first.
        /// </para>
        ///  
        /// <para>
        /// If the root volume is detached from an instance with an AWS Marketplace product code,
        /// then the AWS Marketplace product codes from that volume are no longer associated with
        /// the instance.
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
        public DetachVolumeResponse DetachVolume(DetachVolumeRequest request)
        {
            var marshaller = new DetachVolumeRequestMarshaller();
            var unmarshaller = DetachVolumeResponseUnmarshaller.Instance;

            return Invoke<DetachVolumeRequest,DetachVolumeResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DetachVolume operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachVolume operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DetachVolumeResponse> DetachVolumeAsync(DetachVolumeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DetachVolumeRequestMarshaller();
            var unmarshaller = DetachVolumeResponseUnmarshaller.Instance;

            return InvokeAsync<DetachVolumeRequest,DetachVolumeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public DetachVpnGatewayResponse DetachVpnGateway(DetachVpnGatewayRequest request)
        {
            var marshaller = new DetachVpnGatewayRequestMarshaller();
            var unmarshaller = DetachVpnGatewayResponseUnmarshaller.Instance;

            return Invoke<DetachVpnGatewayRequest,DetachVpnGatewayResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DetachVpnGateway operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachVpnGateway operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DetachVpnGatewayResponse> DetachVpnGatewayAsync(DetachVpnGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DetachVpnGatewayRequestMarshaller();
            var unmarshaller = DetachVpnGatewayResponseUnmarshaller.Instance;

            return InvokeAsync<DetachVpnGatewayRequest,DetachVpnGatewayResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DisableVgwRoutePropagation

        /// <summary>
        /// Disables a virtual private gateway (VGW) from propagating routes to the routing tables
        /// of a VPC.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisableVgwRoutePropagation service method.</param>
        /// 
        /// <returns>The response from the DisableVgwRoutePropagation service method, as returned by EC2.</returns>
        public DisableVgwRoutePropagationResponse DisableVgwRoutePropagation(DisableVgwRoutePropagationRequest request)
        {
            var marshaller = new DisableVgwRoutePropagationRequestMarshaller();
            var unmarshaller = DisableVgwRoutePropagationResponseUnmarshaller.Instance;

            return Invoke<DisableVgwRoutePropagationRequest,DisableVgwRoutePropagationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisableVgwRoutePropagation operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableVgwRoutePropagation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DisableVgwRoutePropagationResponse> DisableVgwRoutePropagationAsync(DisableVgwRoutePropagationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DisableVgwRoutePropagationRequestMarshaller();
            var unmarshaller = DisableVgwRoutePropagationResponseUnmarshaller.Instance;

            return InvokeAsync<DisableVgwRoutePropagationRequest,DisableVgwRoutePropagationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DisassociateAddress

        /// <summary>
        /// Disassociates an Elastic IP address from the instance or network interface it's associated
        /// with.
        /// 
        ///  
        /// <para>
        /// This is an idempotent operation. If you perform the operation more than once, Amazon
        /// EC2 doesn't return an error.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateAddress service method.</param>
        /// 
        /// <returns>The response from the DisassociateAddress service method, as returned by EC2.</returns>
        public DisassociateAddressResponse DisassociateAddress(DisassociateAddressRequest request)
        {
            var marshaller = new DisassociateAddressRequestMarshaller();
            var unmarshaller = DisassociateAddressResponseUnmarshaller.Instance;

            return Invoke<DisassociateAddressRequest,DisassociateAddressResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateAddress operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateAddress operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DisassociateAddressResponse> DisassociateAddressAsync(DisassociateAddressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DisassociateAddressRequestMarshaller();
            var unmarshaller = DisassociateAddressResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateAddressRequest,DisassociateAddressResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public DisassociateRouteTableResponse DisassociateRouteTable(DisassociateRouteTableRequest request)
        {
            var marshaller = new DisassociateRouteTableRequestMarshaller();
            var unmarshaller = DisassociateRouteTableResponseUnmarshaller.Instance;

            return Invoke<DisassociateRouteTableRequest,DisassociateRouteTableResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateRouteTable operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateRouteTable operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<DisassociateRouteTableResponse> DisassociateRouteTableAsync(DisassociateRouteTableRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DisassociateRouteTableRequestMarshaller();
            var unmarshaller = DisassociateRouteTableResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateRouteTableRequest,DisassociateRouteTableResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  EnableVgwRoutePropagation

        /// <summary>
        /// Enables a virtual private gateway (VGW) to propagate routes to the routing tables
        /// of a VPC.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableVgwRoutePropagation service method.</param>
        /// 
        /// <returns>The response from the EnableVgwRoutePropagation service method, as returned by EC2.</returns>
        public EnableVgwRoutePropagationResponse EnableVgwRoutePropagation(EnableVgwRoutePropagationRequest request)
        {
            var marshaller = new EnableVgwRoutePropagationRequestMarshaller();
            var unmarshaller = EnableVgwRoutePropagationResponseUnmarshaller.Instance;

            return Invoke<EnableVgwRoutePropagationRequest,EnableVgwRoutePropagationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the EnableVgwRoutePropagation operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableVgwRoutePropagation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<EnableVgwRoutePropagationResponse> EnableVgwRoutePropagationAsync(EnableVgwRoutePropagationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new EnableVgwRoutePropagationRequestMarshaller();
            var unmarshaller = EnableVgwRoutePropagationResponseUnmarshaller.Instance;

            return InvokeAsync<EnableVgwRoutePropagationRequest,EnableVgwRoutePropagationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  EnableVolumeIO

        /// <summary>
        /// Enables I/O operations for a volume that had I/O operations disabled because the data
        /// on the volume was potentially inconsistent.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the EnableVolumeIO service method.</param>
        /// 
        /// <returns>The response from the EnableVolumeIO service method, as returned by EC2.</returns>
        public EnableVolumeIOResponse EnableVolumeIO(EnableVolumeIORequest request)
        {
            var marshaller = new EnableVolumeIORequestMarshaller();
            var unmarshaller = EnableVolumeIOResponseUnmarshaller.Instance;

            return Invoke<EnableVolumeIORequest,EnableVolumeIOResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the EnableVolumeIO operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableVolumeIO operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<EnableVolumeIOResponse> EnableVolumeIOAsync(EnableVolumeIORequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new EnableVolumeIORequestMarshaller();
            var unmarshaller = EnableVolumeIOResponseUnmarshaller.Instance;

            return InvokeAsync<EnableVolumeIORequest,EnableVolumeIOResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        /// For Linux/Unix instances, the instance console output displays the exact console output
        /// that would normally be displayed on a physical monitor attached to a machine. This
        /// output is buffered because the instance produces it and then posts it to a store where
        /// the instance's owner can retrieve it.
        /// </para>
        ///  
        /// <para>
        /// For Windows instances, the instance console output displays the last three system
        /// event log errors.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConsoleOutput service method.</param>
        /// 
        /// <returns>The response from the GetConsoleOutput service method, as returned by EC2.</returns>
        public GetConsoleOutputResponse GetConsoleOutput(GetConsoleOutputRequest request)
        {
            var marshaller = new GetConsoleOutputRequestMarshaller();
            var unmarshaller = GetConsoleOutputResponseUnmarshaller.Instance;

            return Invoke<GetConsoleOutputRequest,GetConsoleOutputResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetConsoleOutput operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetConsoleOutput operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetConsoleOutputResponse> GetConsoleOutputAsync(GetConsoleOutputRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetConsoleOutputRequestMarshaller();
            var unmarshaller = GetConsoleOutputResponseUnmarshaller.Instance;

            return InvokeAsync<GetConsoleOutputRequest,GetConsoleOutputResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetPasswordData

        /// <summary>
        /// Retrieves the encrypted administrator password for an instance running Windows.
        /// 
        ///  
        /// <para>
        /// The Windows password is only generated the first time an AMI is launched. It is not
        /// generated for rebundled AMIs or after the password is changed on an instance.
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
        public GetPasswordDataResponse GetPasswordData(GetPasswordDataRequest request)
        {
            var marshaller = new GetPasswordDataRequestMarshaller();
            var unmarshaller = GetPasswordDataResponseUnmarshaller.Instance;

            return Invoke<GetPasswordDataRequest,GetPasswordDataResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetPasswordData operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPasswordData operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<GetPasswordDataResponse> GetPasswordDataAsync(GetPasswordDataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetPasswordDataRequestMarshaller();
            var unmarshaller = GetPasswordDataResponseUnmarshaller.Instance;

            return InvokeAsync<GetPasswordDataRequest,GetPasswordDataResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ImportInstance

        /// <summary>
        /// Creates an import instance task using metadata from the specified disk image. After
        /// importing the image, you then upload it using the ec2-import-volume command in the
        /// EC2 command line tools. For more information, see <ulink url="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/UploadingYourInstancesandVolumes.html">Using
        /// the Command Line Tools to Import Your Virtual Machine to Amazon EC2</ulink> in the
        /// <emphasis>Amazon Elastic Compute Cloud User Guide</emphasis>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportInstance service method.</param>
        /// 
        /// <returns>The response from the ImportInstance service method, as returned by EC2.</returns>
        public ImportInstanceResponse ImportInstance(ImportInstanceRequest request)
        {
            var marshaller = new ImportInstanceRequestMarshaller();
            var unmarshaller = ImportInstanceResponseUnmarshaller.Instance;

            return Invoke<ImportInstanceRequest,ImportInstanceResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ImportInstance operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ImportInstanceResponse> ImportInstanceAsync(ImportInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ImportInstanceRequestMarshaller();
            var unmarshaller = ImportInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<ImportInstanceRequest,ImportInstanceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public ImportKeyPairResponse ImportKeyPair(ImportKeyPairRequest request)
        {
            var marshaller = new ImportKeyPairRequestMarshaller();
            var unmarshaller = ImportKeyPairResponseUnmarshaller.Instance;

            return Invoke<ImportKeyPairRequest,ImportKeyPairResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ImportKeyPair operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportKeyPair operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ImportKeyPairResponse> ImportKeyPairAsync(ImportKeyPairRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ImportKeyPairRequestMarshaller();
            var unmarshaller = ImportKeyPairResponseUnmarshaller.Instance;

            return InvokeAsync<ImportKeyPairRequest,ImportKeyPairResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ImportVolume

        /// <summary>
        /// Creates an import volume task using metadata from the specified disk image. After
        /// importing the image, you then upload it using the ec2-import-volume command in the
        /// Amazon EC2 command-line interface (CLI) tools. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/UploadingYourInstancesandVolumes.html">Using
        /// the Command Line Tools to Import Your Virtual Machine to Amazon EC2</a> in the <i>Amazon
        /// Elastic Compute Cloud User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ImportVolume service method.</param>
        /// 
        /// <returns>The response from the ImportVolume service method, as returned by EC2.</returns>
        public ImportVolumeResponse ImportVolume(ImportVolumeRequest request)
        {
            var marshaller = new ImportVolumeRequestMarshaller();
            var unmarshaller = ImportVolumeResponseUnmarshaller.Instance;

            return Invoke<ImportVolumeRequest,ImportVolumeResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ImportVolume operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportVolume operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ImportVolumeResponse> ImportVolumeAsync(ImportVolumeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ImportVolumeRequestMarshaller();
            var unmarshaller = ImportVolumeResponseUnmarshaller.Instance;

            return InvokeAsync<ImportVolumeRequest,ImportVolumeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ModifyImageAttribute

        /// <summary>
        /// Modifies the specified attribute of the specified AMI. You can specify only one attribute
        /// at a time.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyImageAttribute service method.</param>
        /// 
        /// <returns>The response from the ModifyImageAttribute service method, as returned by EC2.</returns>
        public ModifyImageAttributeResponse ModifyImageAttribute(ModifyImageAttributeRequest request)
        {
            var marshaller = new ModifyImageAttributeRequestMarshaller();
            var unmarshaller = ModifyImageAttributeResponseUnmarshaller.Instance;

            return Invoke<ModifyImageAttributeRequest,ModifyImageAttributeResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyImageAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyImageAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ModifyImageAttributeResponse> ModifyImageAttributeAsync(ModifyImageAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ModifyImageAttributeRequestMarshaller();
            var unmarshaller = ModifyImageAttributeResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyImageAttributeRequest,ModifyImageAttributeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public ModifyInstanceAttributeResponse ModifyInstanceAttribute(ModifyInstanceAttributeRequest request)
        {
            var marshaller = new ModifyInstanceAttributeRequestMarshaller();
            var unmarshaller = ModifyInstanceAttributeResponseUnmarshaller.Instance;

            return Invoke<ModifyInstanceAttributeRequest,ModifyInstanceAttributeResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyInstanceAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyInstanceAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ModifyInstanceAttributeResponse> ModifyInstanceAttributeAsync(ModifyInstanceAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ModifyInstanceAttributeRequestMarshaller();
            var unmarshaller = ModifyInstanceAttributeResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyInstanceAttributeRequest,ModifyInstanceAttributeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ModifyNetworkInterfaceAttribute

        /// <summary>
        /// Modifies the specified network interface attribute. You can specify only one attribute
        /// at a time.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyNetworkInterfaceAttribute service method.</param>
        /// 
        /// <returns>The response from the ModifyNetworkInterfaceAttribute service method, as returned by EC2.</returns>
        public ModifyNetworkInterfaceAttributeResponse ModifyNetworkInterfaceAttribute(ModifyNetworkInterfaceAttributeRequest request)
        {
            var marshaller = new ModifyNetworkInterfaceAttributeRequestMarshaller();
            var unmarshaller = ModifyNetworkInterfaceAttributeResponseUnmarshaller.Instance;

            return Invoke<ModifyNetworkInterfaceAttributeRequest,ModifyNetworkInterfaceAttributeResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyNetworkInterfaceAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyNetworkInterfaceAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ModifyNetworkInterfaceAttributeResponse> ModifyNetworkInterfaceAttributeAsync(ModifyNetworkInterfaceAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ModifyNetworkInterfaceAttributeRequestMarshaller();
            var unmarshaller = ModifyNetworkInterfaceAttributeResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyNetworkInterfaceAttributeRequest,ModifyNetworkInterfaceAttributeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ModifyReservedInstances

        /// <summary>
        /// Modifies the Availability Zone, instance count, instance type, or network platform
        /// (EC2-Classic or EC2-VPC) of your Reserved Instances. The Reserved Instances to be
        /// modified must be identical, except for Availability Zone, network platform, and instance
        /// type.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyReservedInstances service method.</param>
        /// 
        /// <returns>The response from the ModifyReservedInstances service method, as returned by EC2.</returns>
        public ModifyReservedInstancesResponse ModifyReservedInstances(ModifyReservedInstancesRequest request)
        {
            var marshaller = new ModifyReservedInstancesRequestMarshaller();
            var unmarshaller = ModifyReservedInstancesResponseUnmarshaller.Instance;

            return Invoke<ModifyReservedInstancesRequest,ModifyReservedInstancesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyReservedInstances operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyReservedInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ModifyReservedInstancesResponse> ModifyReservedInstancesAsync(ModifyReservedInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ModifyReservedInstancesRequestMarshaller();
            var unmarshaller = ModifyReservedInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyReservedInstancesRequest,ModifyReservedInstancesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifySnapshotAttribute service method.</param>
        /// 
        /// <returns>The response from the ModifySnapshotAttribute service method, as returned by EC2.</returns>
        public ModifySnapshotAttributeResponse ModifySnapshotAttribute(ModifySnapshotAttributeRequest request)
        {
            var marshaller = new ModifySnapshotAttributeRequestMarshaller();
            var unmarshaller = ModifySnapshotAttributeResponseUnmarshaller.Instance;

            return Invoke<ModifySnapshotAttributeRequest,ModifySnapshotAttributeResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifySnapshotAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifySnapshotAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ModifySnapshotAttributeResponse> ModifySnapshotAttributeAsync(ModifySnapshotAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ModifySnapshotAttributeRequestMarshaller();
            var unmarshaller = ModifySnapshotAttributeResponseUnmarshaller.Instance;

            return InvokeAsync<ModifySnapshotAttributeRequest,ModifySnapshotAttributeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ModifySubnetAttribute

        /// <summary>
        /// Modifies a subnet attribute.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifySubnetAttribute service method.</param>
        /// 
        /// <returns>The response from the ModifySubnetAttribute service method, as returned by EC2.</returns>
        public ModifySubnetAttributeResponse ModifySubnetAttribute(ModifySubnetAttributeRequest request)
        {
            var marshaller = new ModifySubnetAttributeRequestMarshaller();
            var unmarshaller = ModifySubnetAttributeResponseUnmarshaller.Instance;

            return Invoke<ModifySubnetAttributeRequest,ModifySubnetAttributeResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifySubnetAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifySubnetAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ModifySubnetAttributeResponse> ModifySubnetAttributeAsync(ModifySubnetAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ModifySubnetAttributeRequestMarshaller();
            var unmarshaller = ModifySubnetAttributeResponseUnmarshaller.Instance;

            return InvokeAsync<ModifySubnetAttributeRequest,ModifySubnetAttributeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public ModifyVolumeAttributeResponse ModifyVolumeAttribute(ModifyVolumeAttributeRequest request)
        {
            var marshaller = new ModifyVolumeAttributeRequestMarshaller();
            var unmarshaller = ModifyVolumeAttributeResponseUnmarshaller.Instance;

            return Invoke<ModifyVolumeAttributeRequest,ModifyVolumeAttributeResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyVolumeAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyVolumeAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ModifyVolumeAttributeResponse> ModifyVolumeAttributeAsync(ModifyVolumeAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ModifyVolumeAttributeRequestMarshaller();
            var unmarshaller = ModifyVolumeAttributeResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyVolumeAttributeRequest,ModifyVolumeAttributeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ModifyVpcAttribute

        /// <summary>
        /// Modifies the specified attribute of the specified VPC.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ModifyVpcAttribute service method.</param>
        /// 
        /// <returns>The response from the ModifyVpcAttribute service method, as returned by EC2.</returns>
        public ModifyVpcAttributeResponse ModifyVpcAttribute(ModifyVpcAttributeRequest request)
        {
            var marshaller = new ModifyVpcAttributeRequestMarshaller();
            var unmarshaller = ModifyVpcAttributeResponseUnmarshaller.Instance;

            return Invoke<ModifyVpcAttributeRequest,ModifyVpcAttributeResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyVpcAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyVpcAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ModifyVpcAttributeResponse> ModifyVpcAttributeAsync(ModifyVpcAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ModifyVpcAttributeRequestMarshaller();
            var unmarshaller = ModifyVpcAttributeResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyVpcAttributeRequest,ModifyVpcAttributeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public MonitorInstancesResponse MonitorInstances(MonitorInstancesRequest request)
        {
            var marshaller = new MonitorInstancesRequestMarshaller();
            var unmarshaller = MonitorInstancesResponseUnmarshaller.Instance;

            return Invoke<MonitorInstancesRequest,MonitorInstancesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the MonitorInstances operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the MonitorInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<MonitorInstancesResponse> MonitorInstancesAsync(MonitorInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new MonitorInstancesRequestMarshaller();
            var unmarshaller = MonitorInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<MonitorInstancesRequest,MonitorInstancesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PurchaseReservedInstancesOffering

        /// <summary>
        /// Purchases a Reserved Instance for use with your account. With Amazon EC2 Reserved
        /// Instances, you obtain a capacity reservation for a certain instance configuration
        /// over a specified period of time. You pay a lower usage rate than with On-Demand instances
        /// for the time that you actually use the capacity reservation.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ri-market-general.html">Reserved
        /// Instance Marketplace</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PurchaseReservedInstancesOffering service method.</param>
        /// 
        /// <returns>The response from the PurchaseReservedInstancesOffering service method, as returned by EC2.</returns>
        public PurchaseReservedInstancesOfferingResponse PurchaseReservedInstancesOffering(PurchaseReservedInstancesOfferingRequest request)
        {
            var marshaller = new PurchaseReservedInstancesOfferingRequestMarshaller();
            var unmarshaller = PurchaseReservedInstancesOfferingResponseUnmarshaller.Instance;

            return Invoke<PurchaseReservedInstancesOfferingRequest,PurchaseReservedInstancesOfferingResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PurchaseReservedInstancesOffering operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PurchaseReservedInstancesOffering operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<PurchaseReservedInstancesOfferingResponse> PurchaseReservedInstancesOfferingAsync(PurchaseReservedInstancesOfferingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PurchaseReservedInstancesOfferingRequestMarshaller();
            var unmarshaller = PurchaseReservedInstancesOfferingResponseUnmarshaller.Instance;

            return InvokeAsync<PurchaseReservedInstancesOfferingRequest,PurchaseReservedInstancesOfferingResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public RebootInstancesResponse RebootInstances(RebootInstancesRequest request)
        {
            var marshaller = new RebootInstancesRequestMarshaller();
            var unmarshaller = RebootInstancesResponseUnmarshaller.Instance;

            return Invoke<RebootInstancesRequest,RebootInstancesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RebootInstances operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RebootInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<RebootInstancesResponse> RebootInstancesAsync(RebootInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RebootInstancesRequestMarshaller();
            var unmarshaller = RebootInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<RebootInstancesRequest,RebootInstancesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RegisterImage

        /// <summary>
        /// Registers an AMI. When you're creating an AMI, this is the final step you must complete
        /// before you can launch an instance from the AMI. For more information about creating
        /// AMIs, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/creating-an-ami.html">Creating
        /// Your Own AMIs</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// 
        ///  
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
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterImage service method.</param>
        /// 
        /// <returns>The response from the RegisterImage service method, as returned by EC2.</returns>
        public RegisterImageResponse RegisterImage(RegisterImageRequest request)
        {
            var marshaller = new RegisterImageRequestMarshaller();
            var unmarshaller = RegisterImageResponseUnmarshaller.Instance;

            return Invoke<RegisterImageRequest,RegisterImageResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterImage operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterImage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<RegisterImageResponse> RegisterImageAsync(RegisterImageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RegisterImageRequestMarshaller();
            var unmarshaller = RegisterImageResponseUnmarshaller.Instance;

            return InvokeAsync<RegisterImageRequest,RegisterImageResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RejectVpcPeeringConnection

        /// <summary>
        /// Rejects a VPC peering connection request. The VPC peering connection must be in the
        /// <code>pending-acceptance</code> state. Use the <code>DescribeVpcPeeringConnections</code>
        /// request to view your outstanding VPC peering connection requests.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RejectVpcPeeringConnection service method.</param>
        /// 
        /// <returns>The response from the RejectVpcPeeringConnection service method, as returned by EC2.</returns>
        public RejectVpcPeeringConnectionResponse RejectVpcPeeringConnection(RejectVpcPeeringConnectionRequest request)
        {
            var marshaller = new RejectVpcPeeringConnectionRequestMarshaller();
            var unmarshaller = RejectVpcPeeringConnectionResponseUnmarshaller.Instance;

            return Invoke<RejectVpcPeeringConnectionRequest,RejectVpcPeeringConnectionResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RejectVpcPeeringConnection operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RejectVpcPeeringConnection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<RejectVpcPeeringConnectionResponse> RejectVpcPeeringConnectionAsync(RejectVpcPeeringConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RejectVpcPeeringConnectionRequestMarshaller();
            var unmarshaller = RejectVpcPeeringConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<RejectVpcPeeringConnectionRequest,RejectVpcPeeringConnectionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        /// [Nondefault VPC] You must use the <a>DisassociateAddress</a> to disassociate the Elastic
        /// IP address before you try to release it. Otherwise, Amazon EC2 returns an error (<code>InvalidIPAddress.InUse</code>).
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReleaseAddress service method.</param>
        /// 
        /// <returns>The response from the ReleaseAddress service method, as returned by EC2.</returns>
        public ReleaseAddressResponse ReleaseAddress(ReleaseAddressRequest request)
        {
            var marshaller = new ReleaseAddressRequestMarshaller();
            var unmarshaller = ReleaseAddressResponseUnmarshaller.Instance;

            return Invoke<ReleaseAddressRequest,ReleaseAddressResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ReleaseAddress operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReleaseAddress operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ReleaseAddressResponse> ReleaseAddressAsync(ReleaseAddressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ReleaseAddressRequestMarshaller();
            var unmarshaller = ReleaseAddressResponseUnmarshaller.Instance;

            return InvokeAsync<ReleaseAddressRequest,ReleaseAddressResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public ReplaceNetworkAclAssociationResponse ReplaceNetworkAclAssociation(ReplaceNetworkAclAssociationRequest request)
        {
            var marshaller = new ReplaceNetworkAclAssociationRequestMarshaller();
            var unmarshaller = ReplaceNetworkAclAssociationResponseUnmarshaller.Instance;

            return Invoke<ReplaceNetworkAclAssociationRequest,ReplaceNetworkAclAssociationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ReplaceNetworkAclAssociation operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReplaceNetworkAclAssociation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ReplaceNetworkAclAssociationResponse> ReplaceNetworkAclAssociationAsync(ReplaceNetworkAclAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ReplaceNetworkAclAssociationRequestMarshaller();
            var unmarshaller = ReplaceNetworkAclAssociationResponseUnmarshaller.Instance;

            return InvokeAsync<ReplaceNetworkAclAssociationRequest,ReplaceNetworkAclAssociationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public ReplaceNetworkAclEntryResponse ReplaceNetworkAclEntry(ReplaceNetworkAclEntryRequest request)
        {
            var marshaller = new ReplaceNetworkAclEntryRequestMarshaller();
            var unmarshaller = ReplaceNetworkAclEntryResponseUnmarshaller.Instance;

            return Invoke<ReplaceNetworkAclEntryRequest,ReplaceNetworkAclEntryResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ReplaceNetworkAclEntry operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReplaceNetworkAclEntry operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ReplaceNetworkAclEntryResponse> ReplaceNetworkAclEntryAsync(ReplaceNetworkAclEntryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ReplaceNetworkAclEntryRequestMarshaller();
            var unmarshaller = ReplaceNetworkAclEntryResponseUnmarshaller.Instance;

            return InvokeAsync<ReplaceNetworkAclEntryRequest,ReplaceNetworkAclEntryResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ReplaceRoute

        /// <summary>
        /// Replaces an existing route within a route table in a VPC. You must provide only one
        /// of the following: Internet gateway, NAT instance, VPC peering connection, or network
        /// interface.
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
        public ReplaceRouteResponse ReplaceRoute(ReplaceRouteRequest request)
        {
            var marshaller = new ReplaceRouteRequestMarshaller();
            var unmarshaller = ReplaceRouteResponseUnmarshaller.Instance;

            return Invoke<ReplaceRouteRequest,ReplaceRouteResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ReplaceRoute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReplaceRoute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ReplaceRouteResponse> ReplaceRouteAsync(ReplaceRouteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ReplaceRouteRequestMarshaller();
            var unmarshaller = ReplaceRouteResponseUnmarshaller.Instance;

            return InvokeAsync<ReplaceRouteRequest,ReplaceRouteResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public ReplaceRouteTableAssociationResponse ReplaceRouteTableAssociation(ReplaceRouteTableAssociationRequest request)
        {
            var marshaller = new ReplaceRouteTableAssociationRequestMarshaller();
            var unmarshaller = ReplaceRouteTableAssociationResponseUnmarshaller.Instance;

            return Invoke<ReplaceRouteTableAssociationRequest,ReplaceRouteTableAssociationResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ReplaceRouteTableAssociation operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReplaceRouteTableAssociation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ReplaceRouteTableAssociationResponse> ReplaceRouteTableAssociationAsync(ReplaceRouteTableAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ReplaceRouteTableAssociationRequestMarshaller();
            var unmarshaller = ReplaceRouteTableAssociationResponseUnmarshaller.Instance;

            return InvokeAsync<ReplaceRouteTableAssociationRequest,ReplaceRouteTableAssociationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ReportInstanceStatus

        /// <summary>
        /// Submits feedback about the status of an instance. The instance must be in the <code>running</code>
        /// state. If your experience with the instance differs from the instance status returned
        /// by <a>DescribeInstanceStatus</a>, use <a>ReportInstanceStatus</a> to report your experience
        /// with the instance. Amazon EC2 collects this information to improve the accuracy of
        /// status checks.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ReportInstanceStatus service method.</param>
        /// 
        /// <returns>The response from the ReportInstanceStatus service method, as returned by EC2.</returns>
        public ReportInstanceStatusResponse ReportInstanceStatus(ReportInstanceStatusRequest request)
        {
            var marshaller = new ReportInstanceStatusRequestMarshaller();
            var unmarshaller = ReportInstanceStatusResponseUnmarshaller.Instance;

            return Invoke<ReportInstanceStatusRequest,ReportInstanceStatusResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ReportInstanceStatus operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReportInstanceStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ReportInstanceStatusResponse> ReportInstanceStatusAsync(ReportInstanceStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ReportInstanceStatusRequestMarshaller();
            var unmarshaller = ReportInstanceStatusResponseUnmarshaller.Instance;

            return InvokeAsync<ReportInstanceStatusRequest,ReportInstanceStatusResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RequestSpotInstances

        /// <summary>
        /// Creates a Spot Instance request. Spot Instances are instances that Amazon EC2 starts
        /// on your behalf when the maximum price that you specify exceeds the current Spot Price.
        /// Amazon EC2 periodically sets the Spot Price based on available Spot Instance capacity
        /// and current Spot Instance requests. For more information about Spot Instances, see
        /// <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-spot-instances.html">Spot
        /// Instances</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RequestSpotInstances service method.</param>
        /// 
        /// <returns>The response from the RequestSpotInstances service method, as returned by EC2.</returns>
        public RequestSpotInstancesResponse RequestSpotInstances(RequestSpotInstancesRequest request)
        {
            var marshaller = new RequestSpotInstancesRequestMarshaller();
            var unmarshaller = RequestSpotInstancesResponseUnmarshaller.Instance;

            return Invoke<RequestSpotInstancesRequest,RequestSpotInstancesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RequestSpotInstances operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RequestSpotInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<RequestSpotInstancesResponse> RequestSpotInstancesAsync(RequestSpotInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RequestSpotInstancesRequestMarshaller();
            var unmarshaller = RequestSpotInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<RequestSpotInstancesRequest,RequestSpotInstancesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ResetImageAttribute

        /// <summary>
        /// Resets an attribute of an AMI to its default value.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetImageAttribute service method.</param>
        /// 
        /// <returns>The response from the ResetImageAttribute service method, as returned by EC2.</returns>
        public ResetImageAttributeResponse ResetImageAttribute(ResetImageAttributeRequest request)
        {
            var marshaller = new ResetImageAttributeRequestMarshaller();
            var unmarshaller = ResetImageAttributeResponseUnmarshaller.Instance;

            return Invoke<ResetImageAttributeRequest,ResetImageAttributeResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ResetImageAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetImageAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ResetImageAttributeResponse> ResetImageAttributeAsync(ResetImageAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ResetImageAttributeRequestMarshaller();
            var unmarshaller = ResetImageAttributeResponseUnmarshaller.Instance;

            return InvokeAsync<ResetImageAttributeRequest,ResetImageAttributeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ResetInstanceAttribute

        /// <summary>
        /// Resets an attribute of an instance to its default value. To reset the kernel or RAM
        /// disk, the instance must be in a stopped state. To reset the <code>SourceDestCheck</code>,
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
        public ResetInstanceAttributeResponse ResetInstanceAttribute(ResetInstanceAttributeRequest request)
        {
            var marshaller = new ResetInstanceAttributeRequestMarshaller();
            var unmarshaller = ResetInstanceAttributeResponseUnmarshaller.Instance;

            return Invoke<ResetInstanceAttributeRequest,ResetInstanceAttributeResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ResetInstanceAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetInstanceAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ResetInstanceAttributeResponse> ResetInstanceAttributeAsync(ResetInstanceAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ResetInstanceAttributeRequestMarshaller();
            var unmarshaller = ResetInstanceAttributeResponseUnmarshaller.Instance;

            return InvokeAsync<ResetInstanceAttributeRequest,ResetInstanceAttributeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ResetNetworkInterfaceAttribute

        /// <summary>
        /// Resets a network interface attribute. You can specify only one attribute at a time.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ResetNetworkInterfaceAttribute service method.</param>
        /// 
        /// <returns>The response from the ResetNetworkInterfaceAttribute service method, as returned by EC2.</returns>
        public ResetNetworkInterfaceAttributeResponse ResetNetworkInterfaceAttribute(ResetNetworkInterfaceAttributeRequest request)
        {
            var marshaller = new ResetNetworkInterfaceAttributeRequestMarshaller();
            var unmarshaller = ResetNetworkInterfaceAttributeResponseUnmarshaller.Instance;

            return Invoke<ResetNetworkInterfaceAttributeRequest,ResetNetworkInterfaceAttributeResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ResetNetworkInterfaceAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetNetworkInterfaceAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ResetNetworkInterfaceAttributeResponse> ResetNetworkInterfaceAttributeAsync(ResetNetworkInterfaceAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ResetNetworkInterfaceAttributeRequestMarshaller();
            var unmarshaller = ResetNetworkInterfaceAttributeResponseUnmarshaller.Instance;

            return InvokeAsync<ResetNetworkInterfaceAttributeRequest,ResetNetworkInterfaceAttributeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public ResetSnapshotAttributeResponse ResetSnapshotAttribute(ResetSnapshotAttributeRequest request)
        {
            var marshaller = new ResetSnapshotAttributeRequestMarshaller();
            var unmarshaller = ResetSnapshotAttributeResponseUnmarshaller.Instance;

            return Invoke<ResetSnapshotAttributeRequest,ResetSnapshotAttributeResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ResetSnapshotAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetSnapshotAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<ResetSnapshotAttributeResponse> ResetSnapshotAttributeAsync(ResetSnapshotAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ResetSnapshotAttributeRequestMarshaller();
            var unmarshaller = ResetSnapshotAttributeResponseUnmarshaller.Instance;

            return InvokeAsync<ResetSnapshotAttributeRequest,ResetSnapshotAttributeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public RevokeSecurityGroupEgressResponse RevokeSecurityGroupEgress(RevokeSecurityGroupEgressRequest request)
        {
            var marshaller = new RevokeSecurityGroupEgressRequestMarshaller();
            var unmarshaller = RevokeSecurityGroupEgressResponseUnmarshaller.Instance;

            return Invoke<RevokeSecurityGroupEgressRequest,RevokeSecurityGroupEgressResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RevokeSecurityGroupEgress operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RevokeSecurityGroupEgress operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<RevokeSecurityGroupEgressResponse> RevokeSecurityGroupEgressAsync(RevokeSecurityGroupEgressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RevokeSecurityGroupEgressRequestMarshaller();
            var unmarshaller = RevokeSecurityGroupEgressResponseUnmarshaller.Instance;

            return InvokeAsync<RevokeSecurityGroupEgressRequest,RevokeSecurityGroupEgressResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public RevokeSecurityGroupIngressResponse RevokeSecurityGroupIngress(RevokeSecurityGroupIngressRequest request)
        {
            var marshaller = new RevokeSecurityGroupIngressRequestMarshaller();
            var unmarshaller = RevokeSecurityGroupIngressResponseUnmarshaller.Instance;

            return Invoke<RevokeSecurityGroupIngressRequest,RevokeSecurityGroupIngressResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RevokeSecurityGroupIngress operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RevokeSecurityGroupIngress operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<RevokeSecurityGroupIngressResponse> RevokeSecurityGroupIngressAsync(RevokeSecurityGroupIngressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RevokeSecurityGroupIngressRequestMarshaller();
            var unmarshaller = RevokeSecurityGroupIngressResponseUnmarshaller.Instance;

            return InvokeAsync<RevokeSecurityGroupIngressRequest,RevokeSecurityGroupIngressResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public RunInstancesResponse RunInstances(RunInstancesRequest request)
        {
            var marshaller = new RunInstancesRequestMarshaller();
            var unmarshaller = RunInstancesResponseUnmarshaller.Instance;

            return Invoke<RunInstancesRequest,RunInstancesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RunInstances operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RunInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<RunInstancesResponse> RunInstancesAsync(RunInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RunInstancesRequestMarshaller();
            var unmarshaller = RunInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<RunInstancesRequest,RunInstancesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public StartInstancesResponse StartInstances(StartInstancesRequest request)
        {
            var marshaller = new StartInstancesRequestMarshaller();
            var unmarshaller = StartInstancesResponseUnmarshaller.Instance;

            return Invoke<StartInstancesRequest,StartInstancesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartInstances operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<StartInstancesResponse> StartInstancesAsync(StartInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new StartInstancesRequestMarshaller();
            var unmarshaller = StartInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<StartInstancesRequest,StartInstancesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public StopInstancesResponse StopInstances(StopInstancesRequest request)
        {
            var marshaller = new StopInstancesRequestMarshaller();
            var unmarshaller = StopInstancesResponseUnmarshaller.Instance;

            return Invoke<StopInstancesRequest,StopInstancesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StopInstances operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<StopInstancesResponse> StopInstancesAsync(StopInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new StopInstancesRequestMarshaller();
            var unmarshaller = StopInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<StopInstancesRequest,StopInstancesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        /// By default, Amazon EC2 deletes all Amazon EBS volumes that were attached when the
        /// instance launched. Volumes attached after instance launch continue running.
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
        public TerminateInstancesResponse TerminateInstances(TerminateInstancesRequest request)
        {
            var marshaller = new TerminateInstancesRequestMarshaller();
            var unmarshaller = TerminateInstancesResponseUnmarshaller.Instance;

            return Invoke<TerminateInstancesRequest,TerminateInstancesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the TerminateInstances operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TerminateInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<TerminateInstancesResponse> TerminateInstancesAsync(TerminateInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new TerminateInstancesRequestMarshaller();
            var unmarshaller = TerminateInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<TerminateInstancesRequest,TerminateInstancesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UnassignPrivateIpAddresses

        /// <summary>
        /// Unassigns one or more secondary private IP addresses from a network interface.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UnassignPrivateIpAddresses service method.</param>
        /// 
        /// <returns>The response from the UnassignPrivateIpAddresses service method, as returned by EC2.</returns>
        public UnassignPrivateIpAddressesResponse UnassignPrivateIpAddresses(UnassignPrivateIpAddressesRequest request)
        {
            var marshaller = new UnassignPrivateIpAddressesRequestMarshaller();
            var unmarshaller = UnassignPrivateIpAddressesResponseUnmarshaller.Instance;

            return Invoke<UnassignPrivateIpAddressesRequest,UnassignPrivateIpAddressesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UnassignPrivateIpAddresses operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UnassignPrivateIpAddresses operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<UnassignPrivateIpAddressesResponse> UnassignPrivateIpAddressesAsync(UnassignPrivateIpAddressesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UnassignPrivateIpAddressesRequestMarshaller();
            var unmarshaller = UnassignPrivateIpAddressesResponseUnmarshaller.Instance;

            return InvokeAsync<UnassignPrivateIpAddressesRequest,UnassignPrivateIpAddressesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

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
        public UnmonitorInstancesResponse UnmonitorInstances(UnmonitorInstancesRequest request)
        {
            var marshaller = new UnmonitorInstancesRequestMarshaller();
            var unmarshaller = UnmonitorInstancesResponseUnmarshaller.Instance;

            return Invoke<UnmonitorInstancesRequest,UnmonitorInstancesResponse>(request, marshaller, unmarshaller);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UnmonitorInstances operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2"/>
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UnmonitorInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        public Task<UnmonitorInstancesResponse> UnmonitorInstancesAsync(UnmonitorInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UnmonitorInstancesRequestMarshaller();
            var unmarshaller = UnmonitorInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<UnmonitorInstancesRequest,UnmonitorInstancesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
    }
}