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
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.EC2.Model;
using Amazon.EC2.Model.Internal.MarshallTransformations;
using Amazon.EC2.Internal;
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
    /// Amazon Elastic Compute Cloud (Amazon EC2) provides secure and resizable computing
    /// capacity in the AWS cloud. Using Amazon EC2 eliminates the need to invest in hardware
    /// up front, so you can develop and deploy applications faster.
    /// </para>
    ///  
    /// <para>
    /// To learn more about Amazon EC2, Amazon EBS, and Amazon VPC, see the following resources:
    /// </para>
    ///  <ul> <li> 
    /// <para>
    ///  <a href="http://aws.amazon.com/ec2">Amazon EC2 product page</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="http://aws.amazon.com/documentation/ec2">Amazon EC2 documentation</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="http://aws.amazon.com/ebs">Amazon EBS product page</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="http://aws.amazon.com/vpc">Amazon VPC product page</a> 
    /// </para>
    ///  </li> <li> 
    /// <para>
    ///  <a href="http://aws.amazon.com/documentation/vpc">Amazon VPC documentation</a> 
    /// </para>
    ///  </li> </ul>
    /// </summary>
    public partial class AmazonEC2Client : AmazonServiceClient, IAmazonEC2
    {
        private static IServiceMetadata serviceMetadata = new AmazonEC2Metadata();
        
        #region Constructors

#if CORECLR
    
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

#endif

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

        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        } 

        /// <summary>
        /// Customizes the runtime pipeline.
        /// </summary>
        /// <param name="pipeline">Runtime pipeline for the current client.</param>
        protected override void CustomizeRuntimePipeline(RuntimePipeline pipeline)
        {
            pipeline.AddHandlerBefore<Amazon.Runtime.Internal.Marshaller>(new Amazon.EC2.Internal.AmazonEC2PreMarshallHandler(this.Credentials));
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new Amazon.EC2.Internal.AmazonEC2PostMarshallHandler());
            pipeline.AddHandlerBefore<Amazon.Runtime.Internal.Unmarshaller>(new Amazon.EC2.Internal.AmazonEC2ResponseHandler());
        }
        /// <summary>
        /// Capture metadata for the service.
        /// </summary>
        protected override IServiceMetadata ServiceMetadata
        {
            get
            {
                return serviceMetadata;
            }
        }

        #endregion

        #region Dispose

        /// <summary>
        /// Disposes the service client.
        /// </summary>
        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion


        #region  AcceptReservedInstancesExchangeQuote

        internal virtual AcceptReservedInstancesExchangeQuoteResponse AcceptReservedInstancesExchangeQuote(AcceptReservedInstancesExchangeQuoteRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AcceptReservedInstancesExchangeQuoteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptReservedInstancesExchangeQuoteResponseUnmarshaller.Instance;

            return Invoke<AcceptReservedInstancesExchangeQuoteResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AcceptReservedInstancesExchangeQuote operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AcceptReservedInstancesExchangeQuote operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AcceptReservedInstancesExchangeQuote">REST API Reference for AcceptReservedInstancesExchangeQuote Operation</seealso>
        public virtual Task<AcceptReservedInstancesExchangeQuoteResponse> AcceptReservedInstancesExchangeQuoteAsync(AcceptReservedInstancesExchangeQuoteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AcceptReservedInstancesExchangeQuoteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptReservedInstancesExchangeQuoteResponseUnmarshaller.Instance;

            return InvokeAsync<AcceptReservedInstancesExchangeQuoteResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AcceptTransitGatewayVpcAttachment

        internal virtual AcceptTransitGatewayVpcAttachmentResponse AcceptTransitGatewayVpcAttachment(AcceptTransitGatewayVpcAttachmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AcceptTransitGatewayVpcAttachmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptTransitGatewayVpcAttachmentResponseUnmarshaller.Instance;

            return Invoke<AcceptTransitGatewayVpcAttachmentResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AcceptTransitGatewayVpcAttachment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AcceptTransitGatewayVpcAttachment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AcceptTransitGatewayVpcAttachment">REST API Reference for AcceptTransitGatewayVpcAttachment Operation</seealso>
        public virtual Task<AcceptTransitGatewayVpcAttachmentResponse> AcceptTransitGatewayVpcAttachmentAsync(AcceptTransitGatewayVpcAttachmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AcceptTransitGatewayVpcAttachmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptTransitGatewayVpcAttachmentResponseUnmarshaller.Instance;

            return InvokeAsync<AcceptTransitGatewayVpcAttachmentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AcceptVpcEndpointConnections

        internal virtual AcceptVpcEndpointConnectionsResponse AcceptVpcEndpointConnections(AcceptVpcEndpointConnectionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AcceptVpcEndpointConnectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptVpcEndpointConnectionsResponseUnmarshaller.Instance;

            return Invoke<AcceptVpcEndpointConnectionsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AcceptVpcEndpointConnections operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AcceptVpcEndpointConnections operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AcceptVpcEndpointConnections">REST API Reference for AcceptVpcEndpointConnections Operation</seealso>
        public virtual Task<AcceptVpcEndpointConnectionsResponse> AcceptVpcEndpointConnectionsAsync(AcceptVpcEndpointConnectionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AcceptVpcEndpointConnectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptVpcEndpointConnectionsResponseUnmarshaller.Instance;

            return InvokeAsync<AcceptVpcEndpointConnectionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AcceptVpcPeeringConnection

        internal virtual AcceptVpcPeeringConnectionResponse AcceptVpcPeeringConnection(AcceptVpcPeeringConnectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AcceptVpcPeeringConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptVpcPeeringConnectionResponseUnmarshaller.Instance;

            return Invoke<AcceptVpcPeeringConnectionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AcceptVpcPeeringConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AcceptVpcPeeringConnection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AcceptVpcPeeringConnection">REST API Reference for AcceptVpcPeeringConnection Operation</seealso>
        public virtual Task<AcceptVpcPeeringConnectionResponse> AcceptVpcPeeringConnectionAsync(AcceptVpcPeeringConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AcceptVpcPeeringConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptVpcPeeringConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<AcceptVpcPeeringConnectionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AdvertiseByoipCidr

        internal virtual AdvertiseByoipCidrResponse AdvertiseByoipCidr(AdvertiseByoipCidrRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdvertiseByoipCidrRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdvertiseByoipCidrResponseUnmarshaller.Instance;

            return Invoke<AdvertiseByoipCidrResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AdvertiseByoipCidr operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AdvertiseByoipCidr operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AdvertiseByoipCidr">REST API Reference for AdvertiseByoipCidr Operation</seealso>
        public virtual Task<AdvertiseByoipCidrResponse> AdvertiseByoipCidrAsync(AdvertiseByoipCidrRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AdvertiseByoipCidrRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AdvertiseByoipCidrResponseUnmarshaller.Instance;

            return InvokeAsync<AdvertiseByoipCidrResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AllocateAddress

        internal virtual AllocateAddressResponse AllocateAddress()
        {
            return AllocateAddress(new AllocateAddressRequest());
        }
        internal virtual AllocateAddressResponse AllocateAddress(AllocateAddressRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AllocateAddressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AllocateAddressResponseUnmarshaller.Instance;

            return Invoke<AllocateAddressResponse>(request, options);
        }


        /// <summary>
        /// Allocates an Elastic IP address to your AWS account. After you allocate the Elastic
        /// IP address you can associate it with an instance or network interface. After you release
        /// an Elastic IP address, it is released to the IP address pool and can be allocated
        /// to a different AWS account.
        /// 
        ///  
        /// <para>
        /// You can allocate an Elastic IP address from an address pool owned by AWS or from an
        /// address pool created from a public IPv4 address range that you have brought to AWS
        /// for use with your AWS resources using bring your own IP addresses (BYOIP). For more
        /// information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-byoip.html">Bring
        /// Your Own IP Addresses (BYOIP)</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  
        /// <para>
        /// [EC2-VPC] If you release an Elastic IP address, you might be able to recover it. You
        /// cannot recover an Elastic IP address that you released after it is allocated to another
        /// AWS account. You cannot recover an Elastic IP address for EC2-Classic. To attempt
        /// to recover an Elastic IP address that you released, specify it in this operation.
        /// </para>
        ///  
        /// <para>
        /// An Elastic IP address is for use either in the EC2-Classic platform or in a VPC. By
        /// default, you can allocate 5 Elastic IP addresses for EC2-Classic per region and 5
        /// Elastic IP addresses for EC2-VPC per region.
        /// </para>
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/elastic-ip-addresses-eip.html">Elastic
        /// IP Addresses</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AllocateAddress service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AllocateAddress">REST API Reference for AllocateAddress Operation</seealso>
        public virtual Task<AllocateAddressResponse> AllocateAddressAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return AllocateAddressAsync(new AllocateAddressRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AllocateAddress operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AllocateAddress operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AllocateAddress">REST API Reference for AllocateAddress Operation</seealso>
        public virtual Task<AllocateAddressResponse> AllocateAddressAsync(AllocateAddressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AllocateAddressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AllocateAddressResponseUnmarshaller.Instance;

            return InvokeAsync<AllocateAddressResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AllocateHosts

        internal virtual AllocateHostsResponse AllocateHosts(AllocateHostsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AllocateHostsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AllocateHostsResponseUnmarshaller.Instance;

            return Invoke<AllocateHostsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AllocateHosts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AllocateHosts operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AllocateHosts">REST API Reference for AllocateHosts Operation</seealso>
        public virtual Task<AllocateHostsResponse> AllocateHostsAsync(AllocateHostsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AllocateHostsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AllocateHostsResponseUnmarshaller.Instance;

            return InvokeAsync<AllocateHostsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ApplySecurityGroupsToClientVpnTargetNetwork

        internal virtual ApplySecurityGroupsToClientVpnTargetNetworkResponse ApplySecurityGroupsToClientVpnTargetNetwork(ApplySecurityGroupsToClientVpnTargetNetworkRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ApplySecurityGroupsToClientVpnTargetNetworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ApplySecurityGroupsToClientVpnTargetNetworkResponseUnmarshaller.Instance;

            return Invoke<ApplySecurityGroupsToClientVpnTargetNetworkResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ApplySecurityGroupsToClientVpnTargetNetwork operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ApplySecurityGroupsToClientVpnTargetNetwork operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ApplySecurityGroupsToClientVpnTargetNetwork">REST API Reference for ApplySecurityGroupsToClientVpnTargetNetwork Operation</seealso>
        public virtual Task<ApplySecurityGroupsToClientVpnTargetNetworkResponse> ApplySecurityGroupsToClientVpnTargetNetworkAsync(ApplySecurityGroupsToClientVpnTargetNetworkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ApplySecurityGroupsToClientVpnTargetNetworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ApplySecurityGroupsToClientVpnTargetNetworkResponseUnmarshaller.Instance;

            return InvokeAsync<ApplySecurityGroupsToClientVpnTargetNetworkResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AssignIpv6Addresses

        internal virtual AssignIpv6AddressesResponse AssignIpv6Addresses(AssignIpv6AddressesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssignIpv6AddressesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssignIpv6AddressesResponseUnmarshaller.Instance;

            return Invoke<AssignIpv6AddressesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AssignIpv6Addresses operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssignIpv6Addresses operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AssignIpv6Addresses">REST API Reference for AssignIpv6Addresses Operation</seealso>
        public virtual Task<AssignIpv6AddressesResponse> AssignIpv6AddressesAsync(AssignIpv6AddressesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssignIpv6AddressesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssignIpv6AddressesResponseUnmarshaller.Instance;

            return InvokeAsync<AssignIpv6AddressesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AssignPrivateIpAddresses

        internal virtual AssignPrivateIpAddressesResponse AssignPrivateIpAddresses(AssignPrivateIpAddressesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssignPrivateIpAddressesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssignPrivateIpAddressesResponseUnmarshaller.Instance;

            return Invoke<AssignPrivateIpAddressesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AssignPrivateIpAddresses operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssignPrivateIpAddresses operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AssignPrivateIpAddresses">REST API Reference for AssignPrivateIpAddresses Operation</seealso>
        public virtual Task<AssignPrivateIpAddressesResponse> AssignPrivateIpAddressesAsync(AssignPrivateIpAddressesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssignPrivateIpAddressesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssignPrivateIpAddressesResponseUnmarshaller.Instance;

            return InvokeAsync<AssignPrivateIpAddressesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AssociateAddress

        internal virtual AssociateAddressResponse AssociateAddress(AssociateAddressRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateAddressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateAddressResponseUnmarshaller.Instance;

            return Invoke<AssociateAddressResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AssociateAddress operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateAddress operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AssociateAddress">REST API Reference for AssociateAddress Operation</seealso>
        public virtual Task<AssociateAddressResponse> AssociateAddressAsync(AssociateAddressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateAddressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateAddressResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateAddressResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AssociateClientVpnTargetNetwork

        internal virtual AssociateClientVpnTargetNetworkResponse AssociateClientVpnTargetNetwork(AssociateClientVpnTargetNetworkRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateClientVpnTargetNetworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateClientVpnTargetNetworkResponseUnmarshaller.Instance;

            return Invoke<AssociateClientVpnTargetNetworkResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AssociateClientVpnTargetNetwork operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateClientVpnTargetNetwork operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AssociateClientVpnTargetNetwork">REST API Reference for AssociateClientVpnTargetNetwork Operation</seealso>
        public virtual Task<AssociateClientVpnTargetNetworkResponse> AssociateClientVpnTargetNetworkAsync(AssociateClientVpnTargetNetworkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateClientVpnTargetNetworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateClientVpnTargetNetworkResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateClientVpnTargetNetworkResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AssociateDhcpOptions

        internal virtual AssociateDhcpOptionsResponse AssociateDhcpOptions(AssociateDhcpOptionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateDhcpOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateDhcpOptionsResponseUnmarshaller.Instance;

            return Invoke<AssociateDhcpOptionsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AssociateDhcpOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateDhcpOptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AssociateDhcpOptions">REST API Reference for AssociateDhcpOptions Operation</seealso>
        public virtual Task<AssociateDhcpOptionsResponse> AssociateDhcpOptionsAsync(AssociateDhcpOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateDhcpOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateDhcpOptionsResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateDhcpOptionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AssociateIamInstanceProfile

        internal virtual AssociateIamInstanceProfileResponse AssociateIamInstanceProfile(AssociateIamInstanceProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateIamInstanceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateIamInstanceProfileResponseUnmarshaller.Instance;

            return Invoke<AssociateIamInstanceProfileResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AssociateIamInstanceProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateIamInstanceProfile operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AssociateIamInstanceProfile">REST API Reference for AssociateIamInstanceProfile Operation</seealso>
        public virtual Task<AssociateIamInstanceProfileResponse> AssociateIamInstanceProfileAsync(AssociateIamInstanceProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateIamInstanceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateIamInstanceProfileResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateIamInstanceProfileResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AssociateRouteTable

        internal virtual AssociateRouteTableResponse AssociateRouteTable(AssociateRouteTableRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateRouteTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateRouteTableResponseUnmarshaller.Instance;

            return Invoke<AssociateRouteTableResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AssociateRouteTable operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateRouteTable operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AssociateRouteTable">REST API Reference for AssociateRouteTable Operation</seealso>
        public virtual Task<AssociateRouteTableResponse> AssociateRouteTableAsync(AssociateRouteTableRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateRouteTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateRouteTableResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateRouteTableResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AssociateSubnetCidrBlock

        internal virtual AssociateSubnetCidrBlockResponse AssociateSubnetCidrBlock(AssociateSubnetCidrBlockRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateSubnetCidrBlockRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateSubnetCidrBlockResponseUnmarshaller.Instance;

            return Invoke<AssociateSubnetCidrBlockResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AssociateSubnetCidrBlock operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateSubnetCidrBlock operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AssociateSubnetCidrBlock">REST API Reference for AssociateSubnetCidrBlock Operation</seealso>
        public virtual Task<AssociateSubnetCidrBlockResponse> AssociateSubnetCidrBlockAsync(AssociateSubnetCidrBlockRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateSubnetCidrBlockRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateSubnetCidrBlockResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateSubnetCidrBlockResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AssociateTransitGatewayRouteTable

        internal virtual AssociateTransitGatewayRouteTableResponse AssociateTransitGatewayRouteTable(AssociateTransitGatewayRouteTableRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateTransitGatewayRouteTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateTransitGatewayRouteTableResponseUnmarshaller.Instance;

            return Invoke<AssociateTransitGatewayRouteTableResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AssociateTransitGatewayRouteTable operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateTransitGatewayRouteTable operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AssociateTransitGatewayRouteTable">REST API Reference for AssociateTransitGatewayRouteTable Operation</seealso>
        public virtual Task<AssociateTransitGatewayRouteTableResponse> AssociateTransitGatewayRouteTableAsync(AssociateTransitGatewayRouteTableRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateTransitGatewayRouteTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateTransitGatewayRouteTableResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateTransitGatewayRouteTableResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AssociateVpcCidrBlock

        internal virtual AssociateVpcCidrBlockResponse AssociateVpcCidrBlock(AssociateVpcCidrBlockRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateVpcCidrBlockRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateVpcCidrBlockResponseUnmarshaller.Instance;

            return Invoke<AssociateVpcCidrBlockResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AssociateVpcCidrBlock operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateVpcCidrBlock operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AssociateVpcCidrBlock">REST API Reference for AssociateVpcCidrBlock Operation</seealso>
        public virtual Task<AssociateVpcCidrBlockResponse> AssociateVpcCidrBlockAsync(AssociateVpcCidrBlockRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateVpcCidrBlockRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateVpcCidrBlockResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateVpcCidrBlockResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AttachClassicLinkVpc

        internal virtual AttachClassicLinkVpcResponse AttachClassicLinkVpc(AttachClassicLinkVpcRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AttachClassicLinkVpcRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachClassicLinkVpcResponseUnmarshaller.Instance;

            return Invoke<AttachClassicLinkVpcResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AttachClassicLinkVpc operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachClassicLinkVpc operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AttachClassicLinkVpc">REST API Reference for AttachClassicLinkVpc Operation</seealso>
        public virtual Task<AttachClassicLinkVpcResponse> AttachClassicLinkVpcAsync(AttachClassicLinkVpcRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AttachClassicLinkVpcRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachClassicLinkVpcResponseUnmarshaller.Instance;

            return InvokeAsync<AttachClassicLinkVpcResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AttachInternetGateway

        internal virtual AttachInternetGatewayResponse AttachInternetGateway(AttachInternetGatewayRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AttachInternetGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachInternetGatewayResponseUnmarshaller.Instance;

            return Invoke<AttachInternetGatewayResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AttachInternetGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachInternetGateway operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AttachInternetGateway">REST API Reference for AttachInternetGateway Operation</seealso>
        public virtual Task<AttachInternetGatewayResponse> AttachInternetGatewayAsync(AttachInternetGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AttachInternetGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachInternetGatewayResponseUnmarshaller.Instance;

            return InvokeAsync<AttachInternetGatewayResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AttachNetworkInterface

        internal virtual AttachNetworkInterfaceResponse AttachNetworkInterface(AttachNetworkInterfaceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AttachNetworkInterfaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachNetworkInterfaceResponseUnmarshaller.Instance;

            return Invoke<AttachNetworkInterfaceResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AttachNetworkInterface operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachNetworkInterface operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AttachNetworkInterface">REST API Reference for AttachNetworkInterface Operation</seealso>
        public virtual Task<AttachNetworkInterfaceResponse> AttachNetworkInterfaceAsync(AttachNetworkInterfaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AttachNetworkInterfaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachNetworkInterfaceResponseUnmarshaller.Instance;

            return InvokeAsync<AttachNetworkInterfaceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AttachVolume

        internal virtual AttachVolumeResponse AttachVolume(AttachVolumeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AttachVolumeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachVolumeResponseUnmarshaller.Instance;

            return Invoke<AttachVolumeResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AttachVolume operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachVolume operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AttachVolume">REST API Reference for AttachVolume Operation</seealso>
        public virtual Task<AttachVolumeResponse> AttachVolumeAsync(AttachVolumeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AttachVolumeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachVolumeResponseUnmarshaller.Instance;

            return InvokeAsync<AttachVolumeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AttachVpnGateway

        internal virtual AttachVpnGatewayResponse AttachVpnGateway(AttachVpnGatewayRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AttachVpnGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachVpnGatewayResponseUnmarshaller.Instance;

            return Invoke<AttachVpnGatewayResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AttachVpnGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AttachVpnGateway operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AttachVpnGateway">REST API Reference for AttachVpnGateway Operation</seealso>
        public virtual Task<AttachVpnGatewayResponse> AttachVpnGatewayAsync(AttachVpnGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AttachVpnGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AttachVpnGatewayResponseUnmarshaller.Instance;

            return InvokeAsync<AttachVpnGatewayResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AuthorizeClientVpnIngress

        internal virtual AuthorizeClientVpnIngressResponse AuthorizeClientVpnIngress(AuthorizeClientVpnIngressRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AuthorizeClientVpnIngressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AuthorizeClientVpnIngressResponseUnmarshaller.Instance;

            return Invoke<AuthorizeClientVpnIngressResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AuthorizeClientVpnIngress operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AuthorizeClientVpnIngress operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AuthorizeClientVpnIngress">REST API Reference for AuthorizeClientVpnIngress Operation</seealso>
        public virtual Task<AuthorizeClientVpnIngressResponse> AuthorizeClientVpnIngressAsync(AuthorizeClientVpnIngressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AuthorizeClientVpnIngressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AuthorizeClientVpnIngressResponseUnmarshaller.Instance;

            return InvokeAsync<AuthorizeClientVpnIngressResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AuthorizeSecurityGroupEgress

        internal virtual AuthorizeSecurityGroupEgressResponse AuthorizeSecurityGroupEgress(AuthorizeSecurityGroupEgressRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AuthorizeSecurityGroupEgressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AuthorizeSecurityGroupEgressResponseUnmarshaller.Instance;

            return Invoke<AuthorizeSecurityGroupEgressResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AuthorizeSecurityGroupEgress operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AuthorizeSecurityGroupEgress operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AuthorizeSecurityGroupEgress">REST API Reference for AuthorizeSecurityGroupEgress Operation</seealso>
        public virtual Task<AuthorizeSecurityGroupEgressResponse> AuthorizeSecurityGroupEgressAsync(AuthorizeSecurityGroupEgressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AuthorizeSecurityGroupEgressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AuthorizeSecurityGroupEgressResponseUnmarshaller.Instance;

            return InvokeAsync<AuthorizeSecurityGroupEgressResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AuthorizeSecurityGroupIngress

        internal virtual AuthorizeSecurityGroupIngressResponse AuthorizeSecurityGroupIngress(AuthorizeSecurityGroupIngressRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AuthorizeSecurityGroupIngressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AuthorizeSecurityGroupIngressResponseUnmarshaller.Instance;

            return Invoke<AuthorizeSecurityGroupIngressResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the AuthorizeSecurityGroupIngress operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AuthorizeSecurityGroupIngress operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/AuthorizeSecurityGroupIngress">REST API Reference for AuthorizeSecurityGroupIngress Operation</seealso>
        public virtual Task<AuthorizeSecurityGroupIngressResponse> AuthorizeSecurityGroupIngressAsync(AuthorizeSecurityGroupIngressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AuthorizeSecurityGroupIngressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AuthorizeSecurityGroupIngressResponseUnmarshaller.Instance;

            return InvokeAsync<AuthorizeSecurityGroupIngressResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  BundleInstance

        internal virtual BundleInstanceResponse BundleInstance(BundleInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BundleInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BundleInstanceResponseUnmarshaller.Instance;

            return Invoke<BundleInstanceResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the BundleInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the BundleInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/BundleInstance">REST API Reference for BundleInstance Operation</seealso>
        public virtual Task<BundleInstanceResponse> BundleInstanceAsync(BundleInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = BundleInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = BundleInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<BundleInstanceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CancelBundleTask

        internal virtual CancelBundleTaskResponse CancelBundleTask(CancelBundleTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelBundleTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelBundleTaskResponseUnmarshaller.Instance;

            return Invoke<CancelBundleTaskResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CancelBundleTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelBundleTask operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CancelBundleTask">REST API Reference for CancelBundleTask Operation</seealso>
        public virtual Task<CancelBundleTaskResponse> CancelBundleTaskAsync(CancelBundleTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelBundleTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelBundleTaskResponseUnmarshaller.Instance;

            return InvokeAsync<CancelBundleTaskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CancelCapacityReservation

        internal virtual CancelCapacityReservationResponse CancelCapacityReservation(CancelCapacityReservationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelCapacityReservationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelCapacityReservationResponseUnmarshaller.Instance;

            return Invoke<CancelCapacityReservationResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CancelCapacityReservation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelCapacityReservation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CancelCapacityReservation">REST API Reference for CancelCapacityReservation Operation</seealso>
        public virtual Task<CancelCapacityReservationResponse> CancelCapacityReservationAsync(CancelCapacityReservationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelCapacityReservationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelCapacityReservationResponseUnmarshaller.Instance;

            return InvokeAsync<CancelCapacityReservationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CancelConversionTask

        internal virtual CancelConversionTaskResponse CancelConversionTask(CancelConversionTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelConversionTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelConversionTaskResponseUnmarshaller.Instance;

            return Invoke<CancelConversionTaskResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CancelConversionTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelConversionTask operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CancelConversionTask">REST API Reference for CancelConversionTask Operation</seealso>
        public virtual Task<CancelConversionTaskResponse> CancelConversionTaskAsync(CancelConversionTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelConversionTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelConversionTaskResponseUnmarshaller.Instance;

            return InvokeAsync<CancelConversionTaskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CancelExportTask

        internal virtual CancelExportTaskResponse CancelExportTask(CancelExportTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelExportTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelExportTaskResponseUnmarshaller.Instance;

            return Invoke<CancelExportTaskResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CancelExportTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelExportTask operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CancelExportTask">REST API Reference for CancelExportTask Operation</seealso>
        public virtual Task<CancelExportTaskResponse> CancelExportTaskAsync(CancelExportTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelExportTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelExportTaskResponseUnmarshaller.Instance;

            return InvokeAsync<CancelExportTaskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CancelImportTask

        internal virtual CancelImportTaskResponse CancelImportTask(CancelImportTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelImportTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelImportTaskResponseUnmarshaller.Instance;

            return Invoke<CancelImportTaskResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CancelImportTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelImportTask operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CancelImportTask">REST API Reference for CancelImportTask Operation</seealso>
        public virtual Task<CancelImportTaskResponse> CancelImportTaskAsync(CancelImportTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelImportTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelImportTaskResponseUnmarshaller.Instance;

            return InvokeAsync<CancelImportTaskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CancelReservedInstancesListing

        internal virtual CancelReservedInstancesListingResponse CancelReservedInstancesListing(CancelReservedInstancesListingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelReservedInstancesListingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelReservedInstancesListingResponseUnmarshaller.Instance;

            return Invoke<CancelReservedInstancesListingResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CancelReservedInstancesListing operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelReservedInstancesListing operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CancelReservedInstancesListing">REST API Reference for CancelReservedInstancesListing Operation</seealso>
        public virtual Task<CancelReservedInstancesListingResponse> CancelReservedInstancesListingAsync(CancelReservedInstancesListingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelReservedInstancesListingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelReservedInstancesListingResponseUnmarshaller.Instance;

            return InvokeAsync<CancelReservedInstancesListingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CancelSpotFleetRequests

        internal virtual CancelSpotFleetRequestsResponse CancelSpotFleetRequests(CancelSpotFleetRequestsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelSpotFleetRequestsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelSpotFleetRequestsResponseUnmarshaller.Instance;

            return Invoke<CancelSpotFleetRequestsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CancelSpotFleetRequests operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelSpotFleetRequests operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CancelSpotFleetRequests">REST API Reference for CancelSpotFleetRequests Operation</seealso>
        public virtual Task<CancelSpotFleetRequestsResponse> CancelSpotFleetRequestsAsync(CancelSpotFleetRequestsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelSpotFleetRequestsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelSpotFleetRequestsResponseUnmarshaller.Instance;

            return InvokeAsync<CancelSpotFleetRequestsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CancelSpotInstanceRequests

        internal virtual CancelSpotInstanceRequestsResponse CancelSpotInstanceRequests(CancelSpotInstanceRequestsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelSpotInstanceRequestsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelSpotInstanceRequestsResponseUnmarshaller.Instance;

            return Invoke<CancelSpotInstanceRequestsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CancelSpotInstanceRequests operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CancelSpotInstanceRequests operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CancelSpotInstanceRequests">REST API Reference for CancelSpotInstanceRequests Operation</seealso>
        public virtual Task<CancelSpotInstanceRequestsResponse> CancelSpotInstanceRequestsAsync(CancelSpotInstanceRequestsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CancelSpotInstanceRequestsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CancelSpotInstanceRequestsResponseUnmarshaller.Instance;

            return InvokeAsync<CancelSpotInstanceRequestsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ConfirmProductInstance

        internal virtual ConfirmProductInstanceResponse ConfirmProductInstance(ConfirmProductInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ConfirmProductInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ConfirmProductInstanceResponseUnmarshaller.Instance;

            return Invoke<ConfirmProductInstanceResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ConfirmProductInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ConfirmProductInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ConfirmProductInstance">REST API Reference for ConfirmProductInstance Operation</seealso>
        public virtual Task<ConfirmProductInstanceResponse> ConfirmProductInstanceAsync(ConfirmProductInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ConfirmProductInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ConfirmProductInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<ConfirmProductInstanceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CopyFpgaImage

        internal virtual CopyFpgaImageResponse CopyFpgaImage(CopyFpgaImageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CopyFpgaImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopyFpgaImageResponseUnmarshaller.Instance;

            return Invoke<CopyFpgaImageResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CopyFpgaImage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopyFpgaImage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CopyFpgaImage">REST API Reference for CopyFpgaImage Operation</seealso>
        public virtual Task<CopyFpgaImageResponse> CopyFpgaImageAsync(CopyFpgaImageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CopyFpgaImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopyFpgaImageResponseUnmarshaller.Instance;

            return InvokeAsync<CopyFpgaImageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CopyImage

        internal virtual CopyImageResponse CopyImage(CopyImageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CopyImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopyImageResponseUnmarshaller.Instance;

            return Invoke<CopyImageResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CopyImage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopyImage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CopyImage">REST API Reference for CopyImage Operation</seealso>
        public virtual Task<CopyImageResponse> CopyImageAsync(CopyImageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CopyImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopyImageResponseUnmarshaller.Instance;

            return InvokeAsync<CopyImageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CopySnapshot

        internal virtual CopySnapshotResponse CopySnapshot(CopySnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CopySnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopySnapshotResponseUnmarshaller.Instance;

            return Invoke<CopySnapshotResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CopySnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CopySnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CopySnapshot">REST API Reference for CopySnapshot Operation</seealso>
        public virtual Task<CopySnapshotResponse> CopySnapshotAsync(CopySnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CopySnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CopySnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<CopySnapshotResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateCapacityReservation

        internal virtual CreateCapacityReservationResponse CreateCapacityReservation(CreateCapacityReservationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCapacityReservationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCapacityReservationResponseUnmarshaller.Instance;

            return Invoke<CreateCapacityReservationResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateCapacityReservation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCapacityReservation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateCapacityReservation">REST API Reference for CreateCapacityReservation Operation</seealso>
        public virtual Task<CreateCapacityReservationResponse> CreateCapacityReservationAsync(CreateCapacityReservationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCapacityReservationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCapacityReservationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateCapacityReservationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateClientVpnEndpoint

        internal virtual CreateClientVpnEndpointResponse CreateClientVpnEndpoint(CreateClientVpnEndpointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateClientVpnEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateClientVpnEndpointResponseUnmarshaller.Instance;

            return Invoke<CreateClientVpnEndpointResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateClientVpnEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateClientVpnEndpoint operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateClientVpnEndpoint">REST API Reference for CreateClientVpnEndpoint Operation</seealso>
        public virtual Task<CreateClientVpnEndpointResponse> CreateClientVpnEndpointAsync(CreateClientVpnEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateClientVpnEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateClientVpnEndpointResponseUnmarshaller.Instance;

            return InvokeAsync<CreateClientVpnEndpointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateClientVpnRoute

        internal virtual CreateClientVpnRouteResponse CreateClientVpnRoute(CreateClientVpnRouteRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateClientVpnRouteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateClientVpnRouteResponseUnmarshaller.Instance;

            return Invoke<CreateClientVpnRouteResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateClientVpnRoute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateClientVpnRoute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateClientVpnRoute">REST API Reference for CreateClientVpnRoute Operation</seealso>
        public virtual Task<CreateClientVpnRouteResponse> CreateClientVpnRouteAsync(CreateClientVpnRouteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateClientVpnRouteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateClientVpnRouteResponseUnmarshaller.Instance;

            return InvokeAsync<CreateClientVpnRouteResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateCustomerGateway

        internal virtual CreateCustomerGatewayResponse CreateCustomerGateway(CreateCustomerGatewayRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCustomerGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCustomerGatewayResponseUnmarshaller.Instance;

            return Invoke<CreateCustomerGatewayResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateCustomerGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCustomerGateway operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateCustomerGateway">REST API Reference for CreateCustomerGateway Operation</seealso>
        public virtual Task<CreateCustomerGatewayResponse> CreateCustomerGatewayAsync(CreateCustomerGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCustomerGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCustomerGatewayResponseUnmarshaller.Instance;

            return InvokeAsync<CreateCustomerGatewayResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDefaultSubnet

        internal virtual CreateDefaultSubnetResponse CreateDefaultSubnet(CreateDefaultSubnetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDefaultSubnetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDefaultSubnetResponseUnmarshaller.Instance;

            return Invoke<CreateDefaultSubnetResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateDefaultSubnet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDefaultSubnet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateDefaultSubnet">REST API Reference for CreateDefaultSubnet Operation</seealso>
        public virtual Task<CreateDefaultSubnetResponse> CreateDefaultSubnetAsync(CreateDefaultSubnetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDefaultSubnetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDefaultSubnetResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDefaultSubnetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDefaultVpc

        internal virtual CreateDefaultVpcResponse CreateDefaultVpc(CreateDefaultVpcRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDefaultVpcRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDefaultVpcResponseUnmarshaller.Instance;

            return Invoke<CreateDefaultVpcResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateDefaultVpc operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDefaultVpc operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateDefaultVpc">REST API Reference for CreateDefaultVpc Operation</seealso>
        public virtual Task<CreateDefaultVpcResponse> CreateDefaultVpcAsync(CreateDefaultVpcRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDefaultVpcRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDefaultVpcResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDefaultVpcResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDhcpOptions

        internal virtual CreateDhcpOptionsResponse CreateDhcpOptions(CreateDhcpOptionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDhcpOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDhcpOptionsResponseUnmarshaller.Instance;

            return Invoke<CreateDhcpOptionsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateDhcpOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDhcpOptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateDhcpOptions">REST API Reference for CreateDhcpOptions Operation</seealso>
        public virtual Task<CreateDhcpOptionsResponse> CreateDhcpOptionsAsync(CreateDhcpOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDhcpOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDhcpOptionsResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDhcpOptionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateEgressOnlyInternetGateway

        internal virtual CreateEgressOnlyInternetGatewayResponse CreateEgressOnlyInternetGateway(CreateEgressOnlyInternetGatewayRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEgressOnlyInternetGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEgressOnlyInternetGatewayResponseUnmarshaller.Instance;

            return Invoke<CreateEgressOnlyInternetGatewayResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateEgressOnlyInternetGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateEgressOnlyInternetGateway operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateEgressOnlyInternetGateway">REST API Reference for CreateEgressOnlyInternetGateway Operation</seealso>
        public virtual Task<CreateEgressOnlyInternetGatewayResponse> CreateEgressOnlyInternetGatewayAsync(CreateEgressOnlyInternetGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateEgressOnlyInternetGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateEgressOnlyInternetGatewayResponseUnmarshaller.Instance;

            return InvokeAsync<CreateEgressOnlyInternetGatewayResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateFleet

        internal virtual CreateFleetResponse CreateFleet(CreateFleetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFleetResponseUnmarshaller.Instance;

            return Invoke<CreateFleetResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateFleet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateFleet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateFleet">REST API Reference for CreateFleet Operation</seealso>
        public virtual Task<CreateFleetResponse> CreateFleetAsync(CreateFleetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFleetResponseUnmarshaller.Instance;

            return InvokeAsync<CreateFleetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateFlowLogs

        internal virtual CreateFlowLogsResponse CreateFlowLogs(CreateFlowLogsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFlowLogsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFlowLogsResponseUnmarshaller.Instance;

            return Invoke<CreateFlowLogsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateFlowLogs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateFlowLogs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateFlowLogs">REST API Reference for CreateFlowLogs Operation</seealso>
        public virtual Task<CreateFlowLogsResponse> CreateFlowLogsAsync(CreateFlowLogsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFlowLogsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFlowLogsResponseUnmarshaller.Instance;

            return InvokeAsync<CreateFlowLogsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateFpgaImage

        internal virtual CreateFpgaImageResponse CreateFpgaImage(CreateFpgaImageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFpgaImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFpgaImageResponseUnmarshaller.Instance;

            return Invoke<CreateFpgaImageResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateFpgaImage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateFpgaImage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateFpgaImage">REST API Reference for CreateFpgaImage Operation</seealso>
        public virtual Task<CreateFpgaImageResponse> CreateFpgaImageAsync(CreateFpgaImageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateFpgaImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateFpgaImageResponseUnmarshaller.Instance;

            return InvokeAsync<CreateFpgaImageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateImage

        internal virtual CreateImageResponse CreateImage(CreateImageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateImageResponseUnmarshaller.Instance;

            return Invoke<CreateImageResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateImage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateImage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateImage">REST API Reference for CreateImage Operation</seealso>
        public virtual Task<CreateImageResponse> CreateImageAsync(CreateImageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateImageResponseUnmarshaller.Instance;

            return InvokeAsync<CreateImageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateInstanceExportTask

        internal virtual CreateInstanceExportTaskResponse CreateInstanceExportTask(CreateInstanceExportTaskRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateInstanceExportTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateInstanceExportTaskResponseUnmarshaller.Instance;

            return Invoke<CreateInstanceExportTaskResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateInstanceExportTask operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateInstanceExportTask operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateInstanceExportTask">REST API Reference for CreateInstanceExportTask Operation</seealso>
        public virtual Task<CreateInstanceExportTaskResponse> CreateInstanceExportTaskAsync(CreateInstanceExportTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateInstanceExportTaskRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateInstanceExportTaskResponseUnmarshaller.Instance;

            return InvokeAsync<CreateInstanceExportTaskResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateInternetGateway

        internal virtual CreateInternetGatewayResponse CreateInternetGateway()
        {
            return CreateInternetGateway(new CreateInternetGatewayRequest());
        }
        internal virtual CreateInternetGatewayResponse CreateInternetGateway(CreateInternetGatewayRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateInternetGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateInternetGatewayResponseUnmarshaller.Instance;

            return Invoke<CreateInternetGatewayResponse>(request, options);
        }


        /// <summary>
        /// Creates an internet gateway for use with a VPC. After creating the internet gateway,
        /// you attach it to a VPC using <a>AttachInternetGateway</a>.
        /// 
        ///  
        /// <para>
        /// For more information about your VPC and internet gateway, see the <a href="https://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/">Amazon
        /// Virtual Private Cloud User Guide</a>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateInternetGateway service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateInternetGateway">REST API Reference for CreateInternetGateway Operation</seealso>
        public virtual Task<CreateInternetGatewayResponse> CreateInternetGatewayAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return CreateInternetGatewayAsync(new CreateInternetGatewayRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateInternetGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateInternetGateway operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateInternetGateway">REST API Reference for CreateInternetGateway Operation</seealso>
        public virtual Task<CreateInternetGatewayResponse> CreateInternetGatewayAsync(CreateInternetGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateInternetGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateInternetGatewayResponseUnmarshaller.Instance;

            return InvokeAsync<CreateInternetGatewayResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateKeyPair

        internal virtual CreateKeyPairResponse CreateKeyPair(CreateKeyPairRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateKeyPairRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateKeyPairResponseUnmarshaller.Instance;

            return Invoke<CreateKeyPairResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateKeyPair operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateKeyPair operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateKeyPair">REST API Reference for CreateKeyPair Operation</seealso>
        public virtual Task<CreateKeyPairResponse> CreateKeyPairAsync(CreateKeyPairRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateKeyPairRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateKeyPairResponseUnmarshaller.Instance;

            return InvokeAsync<CreateKeyPairResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateLaunchTemplate

        internal virtual CreateLaunchTemplateResponse CreateLaunchTemplate(CreateLaunchTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLaunchTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLaunchTemplateResponseUnmarshaller.Instance;

            return Invoke<CreateLaunchTemplateResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateLaunchTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLaunchTemplate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateLaunchTemplate">REST API Reference for CreateLaunchTemplate Operation</seealso>
        public virtual Task<CreateLaunchTemplateResponse> CreateLaunchTemplateAsync(CreateLaunchTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLaunchTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLaunchTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<CreateLaunchTemplateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateLaunchTemplateVersion

        internal virtual CreateLaunchTemplateVersionResponse CreateLaunchTemplateVersion(CreateLaunchTemplateVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLaunchTemplateVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLaunchTemplateVersionResponseUnmarshaller.Instance;

            return Invoke<CreateLaunchTemplateVersionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateLaunchTemplateVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLaunchTemplateVersion operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateLaunchTemplateVersion">REST API Reference for CreateLaunchTemplateVersion Operation</seealso>
        public virtual Task<CreateLaunchTemplateVersionResponse> CreateLaunchTemplateVersionAsync(CreateLaunchTemplateVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLaunchTemplateVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLaunchTemplateVersionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateLaunchTemplateVersionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateNatGateway

        internal virtual CreateNatGatewayResponse CreateNatGateway(CreateNatGatewayRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateNatGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNatGatewayResponseUnmarshaller.Instance;

            return Invoke<CreateNatGatewayResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateNatGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateNatGateway operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateNatGateway">REST API Reference for CreateNatGateway Operation</seealso>
        public virtual Task<CreateNatGatewayResponse> CreateNatGatewayAsync(CreateNatGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateNatGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNatGatewayResponseUnmarshaller.Instance;

            return InvokeAsync<CreateNatGatewayResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateNetworkAcl

        internal virtual CreateNetworkAclResponse CreateNetworkAcl(CreateNetworkAclRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateNetworkAclRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNetworkAclResponseUnmarshaller.Instance;

            return Invoke<CreateNetworkAclResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateNetworkAcl operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateNetworkAcl operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateNetworkAcl">REST API Reference for CreateNetworkAcl Operation</seealso>
        public virtual Task<CreateNetworkAclResponse> CreateNetworkAclAsync(CreateNetworkAclRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateNetworkAclRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNetworkAclResponseUnmarshaller.Instance;

            return InvokeAsync<CreateNetworkAclResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateNetworkAclEntry

        internal virtual CreateNetworkAclEntryResponse CreateNetworkAclEntry(CreateNetworkAclEntryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateNetworkAclEntryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNetworkAclEntryResponseUnmarshaller.Instance;

            return Invoke<CreateNetworkAclEntryResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateNetworkAclEntry operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateNetworkAclEntry operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateNetworkAclEntry">REST API Reference for CreateNetworkAclEntry Operation</seealso>
        public virtual Task<CreateNetworkAclEntryResponse> CreateNetworkAclEntryAsync(CreateNetworkAclEntryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateNetworkAclEntryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNetworkAclEntryResponseUnmarshaller.Instance;

            return InvokeAsync<CreateNetworkAclEntryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateNetworkInterface

        internal virtual CreateNetworkInterfaceResponse CreateNetworkInterface(CreateNetworkInterfaceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateNetworkInterfaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNetworkInterfaceResponseUnmarshaller.Instance;

            return Invoke<CreateNetworkInterfaceResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateNetworkInterface operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateNetworkInterface operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateNetworkInterface">REST API Reference for CreateNetworkInterface Operation</seealso>
        public virtual Task<CreateNetworkInterfaceResponse> CreateNetworkInterfaceAsync(CreateNetworkInterfaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateNetworkInterfaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNetworkInterfaceResponseUnmarshaller.Instance;

            return InvokeAsync<CreateNetworkInterfaceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateNetworkInterfacePermission

        internal virtual CreateNetworkInterfacePermissionResponse CreateNetworkInterfacePermission(CreateNetworkInterfacePermissionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateNetworkInterfacePermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNetworkInterfacePermissionResponseUnmarshaller.Instance;

            return Invoke<CreateNetworkInterfacePermissionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateNetworkInterfacePermission operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateNetworkInterfacePermission operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateNetworkInterfacePermission">REST API Reference for CreateNetworkInterfacePermission Operation</seealso>
        public virtual Task<CreateNetworkInterfacePermissionResponse> CreateNetworkInterfacePermissionAsync(CreateNetworkInterfacePermissionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateNetworkInterfacePermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateNetworkInterfacePermissionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateNetworkInterfacePermissionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreatePlacementGroup

        internal virtual CreatePlacementGroupResponse CreatePlacementGroup(CreatePlacementGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePlacementGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePlacementGroupResponseUnmarshaller.Instance;

            return Invoke<CreatePlacementGroupResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreatePlacementGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePlacementGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreatePlacementGroup">REST API Reference for CreatePlacementGroup Operation</seealso>
        public virtual Task<CreatePlacementGroupResponse> CreatePlacementGroupAsync(CreatePlacementGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePlacementGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePlacementGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreatePlacementGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateReservedInstancesListing

        internal virtual CreateReservedInstancesListingResponse CreateReservedInstancesListing(CreateReservedInstancesListingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateReservedInstancesListingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateReservedInstancesListingResponseUnmarshaller.Instance;

            return Invoke<CreateReservedInstancesListingResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateReservedInstancesListing operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateReservedInstancesListing operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateReservedInstancesListing">REST API Reference for CreateReservedInstancesListing Operation</seealso>
        public virtual Task<CreateReservedInstancesListingResponse> CreateReservedInstancesListingAsync(CreateReservedInstancesListingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateReservedInstancesListingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateReservedInstancesListingResponseUnmarshaller.Instance;

            return InvokeAsync<CreateReservedInstancesListingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateRoute

        internal virtual CreateRouteResponse CreateRoute(CreateRouteRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRouteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRouteResponseUnmarshaller.Instance;

            return Invoke<CreateRouteResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateRoute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRoute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateRoute">REST API Reference for CreateRoute Operation</seealso>
        public virtual Task<CreateRouteResponse> CreateRouteAsync(CreateRouteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRouteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRouteResponseUnmarshaller.Instance;

            return InvokeAsync<CreateRouteResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateRouteTable

        internal virtual CreateRouteTableResponse CreateRouteTable(CreateRouteTableRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRouteTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRouteTableResponseUnmarshaller.Instance;

            return Invoke<CreateRouteTableResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateRouteTable operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateRouteTable operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateRouteTable">REST API Reference for CreateRouteTable Operation</seealso>
        public virtual Task<CreateRouteTableResponse> CreateRouteTableAsync(CreateRouteTableRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateRouteTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateRouteTableResponseUnmarshaller.Instance;

            return InvokeAsync<CreateRouteTableResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateSecurityGroup

        internal virtual CreateSecurityGroupResponse CreateSecurityGroup(CreateSecurityGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSecurityGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSecurityGroupResponseUnmarshaller.Instance;

            return Invoke<CreateSecurityGroupResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateSecurityGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSecurityGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateSecurityGroup">REST API Reference for CreateSecurityGroup Operation</seealso>
        public virtual Task<CreateSecurityGroupResponse> CreateSecurityGroupAsync(CreateSecurityGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSecurityGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSecurityGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSecurityGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateSnapshot

        internal virtual CreateSnapshotResponse CreateSnapshot(CreateSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSnapshotResponseUnmarshaller.Instance;

            return Invoke<CreateSnapshotResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateSnapshot">REST API Reference for CreateSnapshot Operation</seealso>
        public virtual Task<CreateSnapshotResponse> CreateSnapshotAsync(CreateSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSnapshotResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateSpotDatafeedSubscription

        internal virtual CreateSpotDatafeedSubscriptionResponse CreateSpotDatafeedSubscription(CreateSpotDatafeedSubscriptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSpotDatafeedSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSpotDatafeedSubscriptionResponseUnmarshaller.Instance;

            return Invoke<CreateSpotDatafeedSubscriptionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateSpotDatafeedSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSpotDatafeedSubscription operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateSpotDatafeedSubscription">REST API Reference for CreateSpotDatafeedSubscription Operation</seealso>
        public virtual Task<CreateSpotDatafeedSubscriptionResponse> CreateSpotDatafeedSubscriptionAsync(CreateSpotDatafeedSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSpotDatafeedSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSpotDatafeedSubscriptionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSpotDatafeedSubscriptionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateSubnet

        internal virtual CreateSubnetResponse CreateSubnet(CreateSubnetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSubnetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSubnetResponseUnmarshaller.Instance;

            return Invoke<CreateSubnetResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateSubnet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSubnet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateSubnet">REST API Reference for CreateSubnet Operation</seealso>
        public virtual Task<CreateSubnetResponse> CreateSubnetAsync(CreateSubnetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSubnetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSubnetResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSubnetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateTags

        internal virtual CreateTagsResponse CreateTags(CreateTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTagsResponseUnmarshaller.Instance;

            return Invoke<CreateTagsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateTags">REST API Reference for CreateTags Operation</seealso>
        public virtual Task<CreateTagsResponse> CreateTagsAsync(CreateTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTagsResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTagsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateTransitGateway

        internal virtual CreateTransitGatewayResponse CreateTransitGateway(CreateTransitGatewayRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTransitGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTransitGatewayResponseUnmarshaller.Instance;

            return Invoke<CreateTransitGatewayResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateTransitGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTransitGateway operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateTransitGateway">REST API Reference for CreateTransitGateway Operation</seealso>
        public virtual Task<CreateTransitGatewayResponse> CreateTransitGatewayAsync(CreateTransitGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTransitGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTransitGatewayResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTransitGatewayResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateTransitGatewayRoute

        internal virtual CreateTransitGatewayRouteResponse CreateTransitGatewayRoute(CreateTransitGatewayRouteRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTransitGatewayRouteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTransitGatewayRouteResponseUnmarshaller.Instance;

            return Invoke<CreateTransitGatewayRouteResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateTransitGatewayRoute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTransitGatewayRoute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateTransitGatewayRoute">REST API Reference for CreateTransitGatewayRoute Operation</seealso>
        public virtual Task<CreateTransitGatewayRouteResponse> CreateTransitGatewayRouteAsync(CreateTransitGatewayRouteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTransitGatewayRouteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTransitGatewayRouteResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTransitGatewayRouteResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateTransitGatewayRouteTable

        internal virtual CreateTransitGatewayRouteTableResponse CreateTransitGatewayRouteTable(CreateTransitGatewayRouteTableRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTransitGatewayRouteTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTransitGatewayRouteTableResponseUnmarshaller.Instance;

            return Invoke<CreateTransitGatewayRouteTableResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateTransitGatewayRouteTable operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTransitGatewayRouteTable operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateTransitGatewayRouteTable">REST API Reference for CreateTransitGatewayRouteTable Operation</seealso>
        public virtual Task<CreateTransitGatewayRouteTableResponse> CreateTransitGatewayRouteTableAsync(CreateTransitGatewayRouteTableRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTransitGatewayRouteTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTransitGatewayRouteTableResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTransitGatewayRouteTableResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateTransitGatewayVpcAttachment

        internal virtual CreateTransitGatewayVpcAttachmentResponse CreateTransitGatewayVpcAttachment(CreateTransitGatewayVpcAttachmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTransitGatewayVpcAttachmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTransitGatewayVpcAttachmentResponseUnmarshaller.Instance;

            return Invoke<CreateTransitGatewayVpcAttachmentResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateTransitGatewayVpcAttachment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTransitGatewayVpcAttachment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateTransitGatewayVpcAttachment">REST API Reference for CreateTransitGatewayVpcAttachment Operation</seealso>
        public virtual Task<CreateTransitGatewayVpcAttachmentResponse> CreateTransitGatewayVpcAttachmentAsync(CreateTransitGatewayVpcAttachmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTransitGatewayVpcAttachmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTransitGatewayVpcAttachmentResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTransitGatewayVpcAttachmentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateVolume

        internal virtual CreateVolumeResponse CreateVolume(CreateVolumeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVolumeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVolumeResponseUnmarshaller.Instance;

            return Invoke<CreateVolumeResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateVolume operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVolume operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateVolume">REST API Reference for CreateVolume Operation</seealso>
        public virtual Task<CreateVolumeResponse> CreateVolumeAsync(CreateVolumeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVolumeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVolumeResponseUnmarshaller.Instance;

            return InvokeAsync<CreateVolumeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateVpc

        internal virtual CreateVpcResponse CreateVpc(CreateVpcRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVpcRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVpcResponseUnmarshaller.Instance;

            return Invoke<CreateVpcResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateVpc operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVpc operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateVpc">REST API Reference for CreateVpc Operation</seealso>
        public virtual Task<CreateVpcResponse> CreateVpcAsync(CreateVpcRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVpcRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVpcResponseUnmarshaller.Instance;

            return InvokeAsync<CreateVpcResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateVpcEndpoint

        internal virtual CreateVpcEndpointResponse CreateVpcEndpoint(CreateVpcEndpointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVpcEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVpcEndpointResponseUnmarshaller.Instance;

            return Invoke<CreateVpcEndpointResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateVpcEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVpcEndpoint operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateVpcEndpoint">REST API Reference for CreateVpcEndpoint Operation</seealso>
        public virtual Task<CreateVpcEndpointResponse> CreateVpcEndpointAsync(CreateVpcEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVpcEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVpcEndpointResponseUnmarshaller.Instance;

            return InvokeAsync<CreateVpcEndpointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateVpcEndpointConnectionNotification

        internal virtual CreateVpcEndpointConnectionNotificationResponse CreateVpcEndpointConnectionNotification(CreateVpcEndpointConnectionNotificationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVpcEndpointConnectionNotificationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVpcEndpointConnectionNotificationResponseUnmarshaller.Instance;

            return Invoke<CreateVpcEndpointConnectionNotificationResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateVpcEndpointConnectionNotification operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVpcEndpointConnectionNotification operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateVpcEndpointConnectionNotification">REST API Reference for CreateVpcEndpointConnectionNotification Operation</seealso>
        public virtual Task<CreateVpcEndpointConnectionNotificationResponse> CreateVpcEndpointConnectionNotificationAsync(CreateVpcEndpointConnectionNotificationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVpcEndpointConnectionNotificationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVpcEndpointConnectionNotificationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateVpcEndpointConnectionNotificationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateVpcEndpointServiceConfiguration

        internal virtual CreateVpcEndpointServiceConfigurationResponse CreateVpcEndpointServiceConfiguration(CreateVpcEndpointServiceConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVpcEndpointServiceConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVpcEndpointServiceConfigurationResponseUnmarshaller.Instance;

            return Invoke<CreateVpcEndpointServiceConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateVpcEndpointServiceConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVpcEndpointServiceConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateVpcEndpointServiceConfiguration">REST API Reference for CreateVpcEndpointServiceConfiguration Operation</seealso>
        public virtual Task<CreateVpcEndpointServiceConfigurationResponse> CreateVpcEndpointServiceConfigurationAsync(CreateVpcEndpointServiceConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVpcEndpointServiceConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVpcEndpointServiceConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateVpcEndpointServiceConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateVpcPeeringConnection

        internal virtual CreateVpcPeeringConnectionResponse CreateVpcPeeringConnection(CreateVpcPeeringConnectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVpcPeeringConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVpcPeeringConnectionResponseUnmarshaller.Instance;

            return Invoke<CreateVpcPeeringConnectionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateVpcPeeringConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVpcPeeringConnection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateVpcPeeringConnection">REST API Reference for CreateVpcPeeringConnection Operation</seealso>
        public virtual Task<CreateVpcPeeringConnectionResponse> CreateVpcPeeringConnectionAsync(CreateVpcPeeringConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVpcPeeringConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVpcPeeringConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateVpcPeeringConnectionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateVpnConnection

        internal virtual CreateVpnConnectionResponse CreateVpnConnection(CreateVpnConnectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVpnConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVpnConnectionResponseUnmarshaller.Instance;

            return Invoke<CreateVpnConnectionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateVpnConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVpnConnection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateVpnConnection">REST API Reference for CreateVpnConnection Operation</seealso>
        public virtual Task<CreateVpnConnectionResponse> CreateVpnConnectionAsync(CreateVpnConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVpnConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVpnConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateVpnConnectionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateVpnConnectionRoute

        internal virtual CreateVpnConnectionRouteResponse CreateVpnConnectionRoute(CreateVpnConnectionRouteRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVpnConnectionRouteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVpnConnectionRouteResponseUnmarshaller.Instance;

            return Invoke<CreateVpnConnectionRouteResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateVpnConnectionRoute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVpnConnectionRoute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateVpnConnectionRoute">REST API Reference for CreateVpnConnectionRoute Operation</seealso>
        public virtual Task<CreateVpnConnectionRouteResponse> CreateVpnConnectionRouteAsync(CreateVpnConnectionRouteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVpnConnectionRouteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVpnConnectionRouteResponseUnmarshaller.Instance;

            return InvokeAsync<CreateVpnConnectionRouteResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateVpnGateway

        internal virtual CreateVpnGatewayResponse CreateVpnGateway(CreateVpnGatewayRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVpnGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVpnGatewayResponseUnmarshaller.Instance;

            return Invoke<CreateVpnGatewayResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the CreateVpnGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVpnGateway operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/CreateVpnGateway">REST API Reference for CreateVpnGateway Operation</seealso>
        public virtual Task<CreateVpnGatewayResponse> CreateVpnGatewayAsync(CreateVpnGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVpnGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVpnGatewayResponseUnmarshaller.Instance;

            return InvokeAsync<CreateVpnGatewayResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteClientVpnEndpoint

        internal virtual DeleteClientVpnEndpointResponse DeleteClientVpnEndpoint(DeleteClientVpnEndpointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteClientVpnEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteClientVpnEndpointResponseUnmarshaller.Instance;

            return Invoke<DeleteClientVpnEndpointResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteClientVpnEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteClientVpnEndpoint operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteClientVpnEndpoint">REST API Reference for DeleteClientVpnEndpoint Operation</seealso>
        public virtual Task<DeleteClientVpnEndpointResponse> DeleteClientVpnEndpointAsync(DeleteClientVpnEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteClientVpnEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteClientVpnEndpointResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteClientVpnEndpointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteClientVpnRoute

        internal virtual DeleteClientVpnRouteResponse DeleteClientVpnRoute(DeleteClientVpnRouteRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteClientVpnRouteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteClientVpnRouteResponseUnmarshaller.Instance;

            return Invoke<DeleteClientVpnRouteResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteClientVpnRoute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteClientVpnRoute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteClientVpnRoute">REST API Reference for DeleteClientVpnRoute Operation</seealso>
        public virtual Task<DeleteClientVpnRouteResponse> DeleteClientVpnRouteAsync(DeleteClientVpnRouteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteClientVpnRouteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteClientVpnRouteResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteClientVpnRouteResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteCustomerGateway

        internal virtual DeleteCustomerGatewayResponse DeleteCustomerGateway(DeleteCustomerGatewayRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCustomerGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCustomerGatewayResponseUnmarshaller.Instance;

            return Invoke<DeleteCustomerGatewayResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCustomerGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCustomerGateway operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteCustomerGateway">REST API Reference for DeleteCustomerGateway Operation</seealso>
        public virtual Task<DeleteCustomerGatewayResponse> DeleteCustomerGatewayAsync(DeleteCustomerGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCustomerGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCustomerGatewayResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteCustomerGatewayResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDhcpOptions

        internal virtual DeleteDhcpOptionsResponse DeleteDhcpOptions(DeleteDhcpOptionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDhcpOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDhcpOptionsResponseUnmarshaller.Instance;

            return Invoke<DeleteDhcpOptionsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDhcpOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDhcpOptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteDhcpOptions">REST API Reference for DeleteDhcpOptions Operation</seealso>
        public virtual Task<DeleteDhcpOptionsResponse> DeleteDhcpOptionsAsync(DeleteDhcpOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDhcpOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDhcpOptionsResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDhcpOptionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteEgressOnlyInternetGateway

        internal virtual DeleteEgressOnlyInternetGatewayResponse DeleteEgressOnlyInternetGateway(DeleteEgressOnlyInternetGatewayRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEgressOnlyInternetGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEgressOnlyInternetGatewayResponseUnmarshaller.Instance;

            return Invoke<DeleteEgressOnlyInternetGatewayResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteEgressOnlyInternetGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteEgressOnlyInternetGateway operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteEgressOnlyInternetGateway">REST API Reference for DeleteEgressOnlyInternetGateway Operation</seealso>
        public virtual Task<DeleteEgressOnlyInternetGatewayResponse> DeleteEgressOnlyInternetGatewayAsync(DeleteEgressOnlyInternetGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteEgressOnlyInternetGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteEgressOnlyInternetGatewayResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteEgressOnlyInternetGatewayResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteFleets

        internal virtual DeleteFleetsResponse DeleteFleets(DeleteFleetsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFleetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFleetsResponseUnmarshaller.Instance;

            return Invoke<DeleteFleetsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteFleets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFleets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteFleets">REST API Reference for DeleteFleets Operation</seealso>
        public virtual Task<DeleteFleetsResponse> DeleteFleetsAsync(DeleteFleetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFleetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFleetsResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteFleetsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteFlowLogs

        internal virtual DeleteFlowLogsResponse DeleteFlowLogs(DeleteFlowLogsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFlowLogsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFlowLogsResponseUnmarshaller.Instance;

            return Invoke<DeleteFlowLogsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteFlowLogs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFlowLogs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteFlowLogs">REST API Reference for DeleteFlowLogs Operation</seealso>
        public virtual Task<DeleteFlowLogsResponse> DeleteFlowLogsAsync(DeleteFlowLogsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFlowLogsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFlowLogsResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteFlowLogsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteFpgaImage

        internal virtual DeleteFpgaImageResponse DeleteFpgaImage(DeleteFpgaImageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFpgaImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFpgaImageResponseUnmarshaller.Instance;

            return Invoke<DeleteFpgaImageResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteFpgaImage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteFpgaImage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteFpgaImage">REST API Reference for DeleteFpgaImage Operation</seealso>
        public virtual Task<DeleteFpgaImageResponse> DeleteFpgaImageAsync(DeleteFpgaImageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteFpgaImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteFpgaImageResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteFpgaImageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteInternetGateway

        internal virtual DeleteInternetGatewayResponse DeleteInternetGateway(DeleteInternetGatewayRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteInternetGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInternetGatewayResponseUnmarshaller.Instance;

            return Invoke<DeleteInternetGatewayResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteInternetGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteInternetGateway operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteInternetGateway">REST API Reference for DeleteInternetGateway Operation</seealso>
        public virtual Task<DeleteInternetGatewayResponse> DeleteInternetGatewayAsync(DeleteInternetGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteInternetGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInternetGatewayResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteInternetGatewayResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteKeyPair

        internal virtual DeleteKeyPairResponse DeleteKeyPair(DeleteKeyPairRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteKeyPairRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteKeyPairResponseUnmarshaller.Instance;

            return Invoke<DeleteKeyPairResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteKeyPair operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteKeyPair operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteKeyPair">REST API Reference for DeleteKeyPair Operation</seealso>
        public virtual Task<DeleteKeyPairResponse> DeleteKeyPairAsync(DeleteKeyPairRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteKeyPairRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteKeyPairResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteKeyPairResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteLaunchTemplate

        internal virtual DeleteLaunchTemplateResponse DeleteLaunchTemplate(DeleteLaunchTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLaunchTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLaunchTemplateResponseUnmarshaller.Instance;

            return Invoke<DeleteLaunchTemplateResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLaunchTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLaunchTemplate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteLaunchTemplate">REST API Reference for DeleteLaunchTemplate Operation</seealso>
        public virtual Task<DeleteLaunchTemplateResponse> DeleteLaunchTemplateAsync(DeleteLaunchTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLaunchTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLaunchTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteLaunchTemplateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteLaunchTemplateVersions

        internal virtual DeleteLaunchTemplateVersionsResponse DeleteLaunchTemplateVersions(DeleteLaunchTemplateVersionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLaunchTemplateVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLaunchTemplateVersionsResponseUnmarshaller.Instance;

            return Invoke<DeleteLaunchTemplateVersionsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLaunchTemplateVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLaunchTemplateVersions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteLaunchTemplateVersions">REST API Reference for DeleteLaunchTemplateVersions Operation</seealso>
        public virtual Task<DeleteLaunchTemplateVersionsResponse> DeleteLaunchTemplateVersionsAsync(DeleteLaunchTemplateVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLaunchTemplateVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLaunchTemplateVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteLaunchTemplateVersionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteNatGateway

        internal virtual DeleteNatGatewayResponse DeleteNatGateway(DeleteNatGatewayRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteNatGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNatGatewayResponseUnmarshaller.Instance;

            return Invoke<DeleteNatGatewayResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteNatGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteNatGateway operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteNatGateway">REST API Reference for DeleteNatGateway Operation</seealso>
        public virtual Task<DeleteNatGatewayResponse> DeleteNatGatewayAsync(DeleteNatGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteNatGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNatGatewayResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteNatGatewayResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteNetworkAcl

        internal virtual DeleteNetworkAclResponse DeleteNetworkAcl(DeleteNetworkAclRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteNetworkAclRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNetworkAclResponseUnmarshaller.Instance;

            return Invoke<DeleteNetworkAclResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteNetworkAcl operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteNetworkAcl operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteNetworkAcl">REST API Reference for DeleteNetworkAcl Operation</seealso>
        public virtual Task<DeleteNetworkAclResponse> DeleteNetworkAclAsync(DeleteNetworkAclRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteNetworkAclRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNetworkAclResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteNetworkAclResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteNetworkAclEntry

        internal virtual DeleteNetworkAclEntryResponse DeleteNetworkAclEntry(DeleteNetworkAclEntryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteNetworkAclEntryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNetworkAclEntryResponseUnmarshaller.Instance;

            return Invoke<DeleteNetworkAclEntryResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteNetworkAclEntry operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteNetworkAclEntry operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteNetworkAclEntry">REST API Reference for DeleteNetworkAclEntry Operation</seealso>
        public virtual Task<DeleteNetworkAclEntryResponse> DeleteNetworkAclEntryAsync(DeleteNetworkAclEntryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteNetworkAclEntryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNetworkAclEntryResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteNetworkAclEntryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteNetworkInterface

        internal virtual DeleteNetworkInterfaceResponse DeleteNetworkInterface(DeleteNetworkInterfaceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteNetworkInterfaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNetworkInterfaceResponseUnmarshaller.Instance;

            return Invoke<DeleteNetworkInterfaceResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteNetworkInterface operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteNetworkInterface operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteNetworkInterface">REST API Reference for DeleteNetworkInterface Operation</seealso>
        public virtual Task<DeleteNetworkInterfaceResponse> DeleteNetworkInterfaceAsync(DeleteNetworkInterfaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteNetworkInterfaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNetworkInterfaceResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteNetworkInterfaceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteNetworkInterfacePermission

        internal virtual DeleteNetworkInterfacePermissionResponse DeleteNetworkInterfacePermission(DeleteNetworkInterfacePermissionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteNetworkInterfacePermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNetworkInterfacePermissionResponseUnmarshaller.Instance;

            return Invoke<DeleteNetworkInterfacePermissionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteNetworkInterfacePermission operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteNetworkInterfacePermission operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteNetworkInterfacePermission">REST API Reference for DeleteNetworkInterfacePermission Operation</seealso>
        public virtual Task<DeleteNetworkInterfacePermissionResponse> DeleteNetworkInterfacePermissionAsync(DeleteNetworkInterfacePermissionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteNetworkInterfacePermissionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteNetworkInterfacePermissionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteNetworkInterfacePermissionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeletePlacementGroup

        internal virtual DeletePlacementGroupResponse DeletePlacementGroup(DeletePlacementGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePlacementGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePlacementGroupResponseUnmarshaller.Instance;

            return Invoke<DeletePlacementGroupResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeletePlacementGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePlacementGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeletePlacementGroup">REST API Reference for DeletePlacementGroup Operation</seealso>
        public virtual Task<DeletePlacementGroupResponse> DeletePlacementGroupAsync(DeletePlacementGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePlacementGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePlacementGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeletePlacementGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteRoute

        internal virtual DeleteRouteResponse DeleteRoute(DeleteRouteRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRouteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRouteResponseUnmarshaller.Instance;

            return Invoke<DeleteRouteResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRoute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRoute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteRoute">REST API Reference for DeleteRoute Operation</seealso>
        public virtual Task<DeleteRouteResponse> DeleteRouteAsync(DeleteRouteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRouteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRouteResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteRouteResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteRouteTable

        internal virtual DeleteRouteTableResponse DeleteRouteTable(DeleteRouteTableRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRouteTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRouteTableResponseUnmarshaller.Instance;

            return Invoke<DeleteRouteTableResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRouteTable operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteRouteTable operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteRouteTable">REST API Reference for DeleteRouteTable Operation</seealso>
        public virtual Task<DeleteRouteTableResponse> DeleteRouteTableAsync(DeleteRouteTableRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteRouteTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteRouteTableResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteRouteTableResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteSecurityGroup

        internal virtual DeleteSecurityGroupResponse DeleteSecurityGroup(DeleteSecurityGroupRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSecurityGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSecurityGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteSecurityGroupResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSecurityGroup operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSecurityGroup operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteSecurityGroup">REST API Reference for DeleteSecurityGroup Operation</seealso>
        public virtual Task<DeleteSecurityGroupResponse> DeleteSecurityGroupAsync(DeleteSecurityGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSecurityGroupRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSecurityGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSecurityGroupResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteSnapshot

        internal virtual DeleteSnapshotResponse DeleteSnapshot(DeleteSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSnapshotResponseUnmarshaller.Instance;

            return Invoke<DeleteSnapshotResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteSnapshot">REST API Reference for DeleteSnapshot Operation</seealso>
        public virtual Task<DeleteSnapshotResponse> DeleteSnapshotAsync(DeleteSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSnapshotResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteSpotDatafeedSubscription

        internal virtual DeleteSpotDatafeedSubscriptionResponse DeleteSpotDatafeedSubscription()
        {
            return DeleteSpotDatafeedSubscription(new DeleteSpotDatafeedSubscriptionRequest());
        }
        internal virtual DeleteSpotDatafeedSubscriptionResponse DeleteSpotDatafeedSubscription(DeleteSpotDatafeedSubscriptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSpotDatafeedSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSpotDatafeedSubscriptionResponseUnmarshaller.Instance;

            return Invoke<DeleteSpotDatafeedSubscriptionResponse>(request, options);
        }


        /// <summary>
        /// Deletes the data feed for Spot Instances.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSpotDatafeedSubscription service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteSpotDatafeedSubscription">REST API Reference for DeleteSpotDatafeedSubscription Operation</seealso>
        public virtual Task<DeleteSpotDatafeedSubscriptionResponse> DeleteSpotDatafeedSubscriptionAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DeleteSpotDatafeedSubscriptionAsync(new DeleteSpotDatafeedSubscriptionRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSpotDatafeedSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSpotDatafeedSubscription operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteSpotDatafeedSubscription">REST API Reference for DeleteSpotDatafeedSubscription Operation</seealso>
        public virtual Task<DeleteSpotDatafeedSubscriptionResponse> DeleteSpotDatafeedSubscriptionAsync(DeleteSpotDatafeedSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSpotDatafeedSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSpotDatafeedSubscriptionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSpotDatafeedSubscriptionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteSubnet

        internal virtual DeleteSubnetResponse DeleteSubnet(DeleteSubnetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSubnetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSubnetResponseUnmarshaller.Instance;

            return Invoke<DeleteSubnetResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSubnet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSubnet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteSubnet">REST API Reference for DeleteSubnet Operation</seealso>
        public virtual Task<DeleteSubnetResponse> DeleteSubnetAsync(DeleteSubnetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSubnetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSubnetResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSubnetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteTags

        internal virtual DeleteTagsResponse DeleteTags(DeleteTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTagsResponseUnmarshaller.Instance;

            return Invoke<DeleteTagsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteTags">REST API Reference for DeleteTags Operation</seealso>
        public virtual Task<DeleteTagsResponse> DeleteTagsAsync(DeleteTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTagsResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTagsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteTransitGateway

        internal virtual DeleteTransitGatewayResponse DeleteTransitGateway(DeleteTransitGatewayRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTransitGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTransitGatewayResponseUnmarshaller.Instance;

            return Invoke<DeleteTransitGatewayResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTransitGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTransitGateway operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteTransitGateway">REST API Reference for DeleteTransitGateway Operation</seealso>
        public virtual Task<DeleteTransitGatewayResponse> DeleteTransitGatewayAsync(DeleteTransitGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTransitGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTransitGatewayResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTransitGatewayResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteTransitGatewayRoute

        internal virtual DeleteTransitGatewayRouteResponse DeleteTransitGatewayRoute(DeleteTransitGatewayRouteRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTransitGatewayRouteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTransitGatewayRouteResponseUnmarshaller.Instance;

            return Invoke<DeleteTransitGatewayRouteResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTransitGatewayRoute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTransitGatewayRoute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteTransitGatewayRoute">REST API Reference for DeleteTransitGatewayRoute Operation</seealso>
        public virtual Task<DeleteTransitGatewayRouteResponse> DeleteTransitGatewayRouteAsync(DeleteTransitGatewayRouteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTransitGatewayRouteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTransitGatewayRouteResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTransitGatewayRouteResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteTransitGatewayRouteTable

        internal virtual DeleteTransitGatewayRouteTableResponse DeleteTransitGatewayRouteTable(DeleteTransitGatewayRouteTableRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTransitGatewayRouteTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTransitGatewayRouteTableResponseUnmarshaller.Instance;

            return Invoke<DeleteTransitGatewayRouteTableResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTransitGatewayRouteTable operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTransitGatewayRouteTable operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteTransitGatewayRouteTable">REST API Reference for DeleteTransitGatewayRouteTable Operation</seealso>
        public virtual Task<DeleteTransitGatewayRouteTableResponse> DeleteTransitGatewayRouteTableAsync(DeleteTransitGatewayRouteTableRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTransitGatewayRouteTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTransitGatewayRouteTableResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTransitGatewayRouteTableResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteTransitGatewayVpcAttachment

        internal virtual DeleteTransitGatewayVpcAttachmentResponse DeleteTransitGatewayVpcAttachment(DeleteTransitGatewayVpcAttachmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTransitGatewayVpcAttachmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTransitGatewayVpcAttachmentResponseUnmarshaller.Instance;

            return Invoke<DeleteTransitGatewayVpcAttachmentResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTransitGatewayVpcAttachment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteTransitGatewayVpcAttachment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteTransitGatewayVpcAttachment">REST API Reference for DeleteTransitGatewayVpcAttachment Operation</seealso>
        public virtual Task<DeleteTransitGatewayVpcAttachmentResponse> DeleteTransitGatewayVpcAttachmentAsync(DeleteTransitGatewayVpcAttachmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteTransitGatewayVpcAttachmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteTransitGatewayVpcAttachmentResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTransitGatewayVpcAttachmentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteVolume

        internal virtual DeleteVolumeResponse DeleteVolume(DeleteVolumeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVolumeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVolumeResponseUnmarshaller.Instance;

            return Invoke<DeleteVolumeResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVolume operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVolume operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteVolume">REST API Reference for DeleteVolume Operation</seealso>
        public virtual Task<DeleteVolumeResponse> DeleteVolumeAsync(DeleteVolumeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVolumeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVolumeResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteVolumeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteVpc

        internal virtual DeleteVpcResponse DeleteVpc(DeleteVpcRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVpcRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVpcResponseUnmarshaller.Instance;

            return Invoke<DeleteVpcResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVpc operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpc operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteVpc">REST API Reference for DeleteVpc Operation</seealso>
        public virtual Task<DeleteVpcResponse> DeleteVpcAsync(DeleteVpcRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVpcRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVpcResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteVpcResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteVpcEndpointConnectionNotifications

        internal virtual DeleteVpcEndpointConnectionNotificationsResponse DeleteVpcEndpointConnectionNotifications(DeleteVpcEndpointConnectionNotificationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVpcEndpointConnectionNotificationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVpcEndpointConnectionNotificationsResponseUnmarshaller.Instance;

            return Invoke<DeleteVpcEndpointConnectionNotificationsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVpcEndpointConnectionNotifications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpcEndpointConnectionNotifications operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteVpcEndpointConnectionNotifications">REST API Reference for DeleteVpcEndpointConnectionNotifications Operation</seealso>
        public virtual Task<DeleteVpcEndpointConnectionNotificationsResponse> DeleteVpcEndpointConnectionNotificationsAsync(DeleteVpcEndpointConnectionNotificationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVpcEndpointConnectionNotificationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVpcEndpointConnectionNotificationsResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteVpcEndpointConnectionNotificationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteVpcEndpoints

        internal virtual DeleteVpcEndpointsResponse DeleteVpcEndpoints(DeleteVpcEndpointsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVpcEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVpcEndpointsResponseUnmarshaller.Instance;

            return Invoke<DeleteVpcEndpointsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVpcEndpoints operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpcEndpoints operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteVpcEndpoints">REST API Reference for DeleteVpcEndpoints Operation</seealso>
        public virtual Task<DeleteVpcEndpointsResponse> DeleteVpcEndpointsAsync(DeleteVpcEndpointsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVpcEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVpcEndpointsResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteVpcEndpointsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteVpcEndpointServiceConfigurations

        internal virtual DeleteVpcEndpointServiceConfigurationsResponse DeleteVpcEndpointServiceConfigurations(DeleteVpcEndpointServiceConfigurationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVpcEndpointServiceConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVpcEndpointServiceConfigurationsResponseUnmarshaller.Instance;

            return Invoke<DeleteVpcEndpointServiceConfigurationsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVpcEndpointServiceConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpcEndpointServiceConfigurations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteVpcEndpointServiceConfigurations">REST API Reference for DeleteVpcEndpointServiceConfigurations Operation</seealso>
        public virtual Task<DeleteVpcEndpointServiceConfigurationsResponse> DeleteVpcEndpointServiceConfigurationsAsync(DeleteVpcEndpointServiceConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVpcEndpointServiceConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVpcEndpointServiceConfigurationsResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteVpcEndpointServiceConfigurationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteVpcPeeringConnection

        internal virtual DeleteVpcPeeringConnectionResponse DeleteVpcPeeringConnection(DeleteVpcPeeringConnectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVpcPeeringConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVpcPeeringConnectionResponseUnmarshaller.Instance;

            return Invoke<DeleteVpcPeeringConnectionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVpcPeeringConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpcPeeringConnection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteVpcPeeringConnection">REST API Reference for DeleteVpcPeeringConnection Operation</seealso>
        public virtual Task<DeleteVpcPeeringConnectionResponse> DeleteVpcPeeringConnectionAsync(DeleteVpcPeeringConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVpcPeeringConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVpcPeeringConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteVpcPeeringConnectionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteVpnConnection

        internal virtual DeleteVpnConnectionResponse DeleteVpnConnection(DeleteVpnConnectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVpnConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVpnConnectionResponseUnmarshaller.Instance;

            return Invoke<DeleteVpnConnectionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVpnConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpnConnection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteVpnConnection">REST API Reference for DeleteVpnConnection Operation</seealso>
        public virtual Task<DeleteVpnConnectionResponse> DeleteVpnConnectionAsync(DeleteVpnConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVpnConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVpnConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteVpnConnectionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteVpnConnectionRoute

        internal virtual DeleteVpnConnectionRouteResponse DeleteVpnConnectionRoute(DeleteVpnConnectionRouteRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVpnConnectionRouteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVpnConnectionRouteResponseUnmarshaller.Instance;

            return Invoke<DeleteVpnConnectionRouteResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVpnConnectionRoute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpnConnectionRoute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteVpnConnectionRoute">REST API Reference for DeleteVpnConnectionRoute Operation</seealso>
        public virtual Task<DeleteVpnConnectionRouteResponse> DeleteVpnConnectionRouteAsync(DeleteVpnConnectionRouteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVpnConnectionRouteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVpnConnectionRouteResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteVpnConnectionRouteResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteVpnGateway

        internal virtual DeleteVpnGatewayResponse DeleteVpnGateway(DeleteVpnGatewayRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVpnGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVpnGatewayResponseUnmarshaller.Instance;

            return Invoke<DeleteVpnGatewayResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVpnGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVpnGateway operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeleteVpnGateway">REST API Reference for DeleteVpnGateway Operation</seealso>
        public virtual Task<DeleteVpnGatewayResponse> DeleteVpnGatewayAsync(DeleteVpnGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVpnGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVpnGatewayResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteVpnGatewayResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeprovisionByoipCidr

        internal virtual DeprovisionByoipCidrResponse DeprovisionByoipCidr(DeprovisionByoipCidrRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeprovisionByoipCidrRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeprovisionByoipCidrResponseUnmarshaller.Instance;

            return Invoke<DeprovisionByoipCidrResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeprovisionByoipCidr operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeprovisionByoipCidr operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeprovisionByoipCidr">REST API Reference for DeprovisionByoipCidr Operation</seealso>
        public virtual Task<DeprovisionByoipCidrResponse> DeprovisionByoipCidrAsync(DeprovisionByoipCidrRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeprovisionByoipCidrRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeprovisionByoipCidrResponseUnmarshaller.Instance;

            return InvokeAsync<DeprovisionByoipCidrResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeregisterImage

        internal virtual DeregisterImageResponse DeregisterImage(DeregisterImageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterImageResponseUnmarshaller.Instance;

            return Invoke<DeregisterImageResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterImage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterImage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DeregisterImage">REST API Reference for DeregisterImage Operation</seealso>
        public virtual Task<DeregisterImageResponse> DeregisterImageAsync(DeregisterImageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterImageResponseUnmarshaller.Instance;

            return InvokeAsync<DeregisterImageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeAccountAttributes

        internal virtual DescribeAccountAttributesResponse DescribeAccountAttributes()
        {
            return DescribeAccountAttributes(new DescribeAccountAttributesRequest());
        }
        internal virtual DescribeAccountAttributesResponse DescribeAccountAttributes(DescribeAccountAttributesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAccountAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAccountAttributesResponseUnmarshaller.Instance;

            return Invoke<DescribeAccountAttributesResponse>(request, options);
        }


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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAccountAttributes service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeAccountAttributes">REST API Reference for DescribeAccountAttributes Operation</seealso>
        public virtual Task<DescribeAccountAttributesResponse> DescribeAccountAttributesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeAccountAttributesAsync(new DescribeAccountAttributesRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAccountAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAccountAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeAccountAttributes">REST API Reference for DescribeAccountAttributes Operation</seealso>
        public virtual Task<DescribeAccountAttributesResponse> DescribeAccountAttributesAsync(DescribeAccountAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAccountAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAccountAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAccountAttributesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeAddresses

        internal virtual DescribeAddressesResponse DescribeAddresses()
        {
            return DescribeAddresses(new DescribeAddressesRequest());
        }
        internal virtual DescribeAddressesResponse DescribeAddresses(DescribeAddressesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAddressesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAddressesResponseUnmarshaller.Instance;

            return Invoke<DescribeAddressesResponse>(request, options);
        }


        /// <summary>
        /// Describes one or more of your Elastic IP addresses.
        /// 
        ///  
        /// <para>
        /// An Elastic IP address is for use in either the EC2-Classic platform or in a VPC. For
        /// more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/elastic-ip-addresses-eip.html">Elastic
        /// IP Addresses</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAddresses service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeAddresses">REST API Reference for DescribeAddresses Operation</seealso>
        public virtual Task<DescribeAddressesResponse> DescribeAddressesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeAddressesAsync(new DescribeAddressesRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAddresses operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAddresses operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeAddresses">REST API Reference for DescribeAddresses Operation</seealso>
        public virtual Task<DescribeAddressesResponse> DescribeAddressesAsync(DescribeAddressesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAddressesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAddressesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAddressesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeAggregateIdFormat

        internal virtual DescribeAggregateIdFormatResponse DescribeAggregateIdFormat(DescribeAggregateIdFormatRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAggregateIdFormatRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAggregateIdFormatResponseUnmarshaller.Instance;

            return Invoke<DescribeAggregateIdFormatResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAggregateIdFormat operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAggregateIdFormat operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeAggregateIdFormat">REST API Reference for DescribeAggregateIdFormat Operation</seealso>
        public virtual Task<DescribeAggregateIdFormatResponse> DescribeAggregateIdFormatAsync(DescribeAggregateIdFormatRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAggregateIdFormatRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAggregateIdFormatResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAggregateIdFormatResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeAvailabilityZones

        internal virtual DescribeAvailabilityZonesResponse DescribeAvailabilityZones()
        {
            return DescribeAvailabilityZones(new DescribeAvailabilityZonesRequest());
        }
        internal virtual DescribeAvailabilityZonesResponse DescribeAvailabilityZones(DescribeAvailabilityZonesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAvailabilityZonesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAvailabilityZonesResponseUnmarshaller.Instance;

            return Invoke<DescribeAvailabilityZonesResponse>(request, options);
        }


        /// <summary>
        /// Describes one or more of the Availability Zones that are available to you. The results
        /// include zones only for the region you're currently using. If there is an event impacting
        /// an Availability Zone, you can use this request to view the state and any provided
        /// message for that Availability Zone.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-regions-availability-zones.html">Regions
        /// and Availability Zones</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAvailabilityZones service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeAvailabilityZones">REST API Reference for DescribeAvailabilityZones Operation</seealso>
        public virtual Task<DescribeAvailabilityZonesResponse> DescribeAvailabilityZonesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeAvailabilityZonesAsync(new DescribeAvailabilityZonesRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAvailabilityZones operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeAvailabilityZones operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeAvailabilityZones">REST API Reference for DescribeAvailabilityZones Operation</seealso>
        public virtual Task<DescribeAvailabilityZonesResponse> DescribeAvailabilityZonesAsync(DescribeAvailabilityZonesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeAvailabilityZonesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeAvailabilityZonesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAvailabilityZonesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeBundleTasks

        internal virtual DescribeBundleTasksResponse DescribeBundleTasks()
        {
            return DescribeBundleTasks(new DescribeBundleTasksRequest());
        }
        internal virtual DescribeBundleTasksResponse DescribeBundleTasks(DescribeBundleTasksRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeBundleTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeBundleTasksResponseUnmarshaller.Instance;

            return Invoke<DescribeBundleTasksResponse>(request, options);
        }


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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeBundleTasks service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeBundleTasks">REST API Reference for DescribeBundleTasks Operation</seealso>
        public virtual Task<DescribeBundleTasksResponse> DescribeBundleTasksAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeBundleTasksAsync(new DescribeBundleTasksRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeBundleTasks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeBundleTasks operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeBundleTasks">REST API Reference for DescribeBundleTasks Operation</seealso>
        public virtual Task<DescribeBundleTasksResponse> DescribeBundleTasksAsync(DescribeBundleTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeBundleTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeBundleTasksResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeBundleTasksResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeByoipCidrs

        internal virtual DescribeByoipCidrsResponse DescribeByoipCidrs(DescribeByoipCidrsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeByoipCidrsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeByoipCidrsResponseUnmarshaller.Instance;

            return Invoke<DescribeByoipCidrsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeByoipCidrs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeByoipCidrs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeByoipCidrs">REST API Reference for DescribeByoipCidrs Operation</seealso>
        public virtual Task<DescribeByoipCidrsResponse> DescribeByoipCidrsAsync(DescribeByoipCidrsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeByoipCidrsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeByoipCidrsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeByoipCidrsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeCapacityReservations

        internal virtual DescribeCapacityReservationsResponse DescribeCapacityReservations(DescribeCapacityReservationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCapacityReservationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCapacityReservationsResponseUnmarshaller.Instance;

            return Invoke<DescribeCapacityReservationsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCapacityReservations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCapacityReservations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeCapacityReservations">REST API Reference for DescribeCapacityReservations Operation</seealso>
        public virtual Task<DescribeCapacityReservationsResponse> DescribeCapacityReservationsAsync(DescribeCapacityReservationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCapacityReservationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCapacityReservationsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeCapacityReservationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeClassicLinkInstances

        internal virtual DescribeClassicLinkInstancesResponse DescribeClassicLinkInstances(DescribeClassicLinkInstancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClassicLinkInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClassicLinkInstancesResponseUnmarshaller.Instance;

            return Invoke<DescribeClassicLinkInstancesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeClassicLinkInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeClassicLinkInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeClassicLinkInstances">REST API Reference for DescribeClassicLinkInstances Operation</seealso>
        public virtual Task<DescribeClassicLinkInstancesResponse> DescribeClassicLinkInstancesAsync(DescribeClassicLinkInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClassicLinkInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClassicLinkInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeClassicLinkInstancesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeClientVpnAuthorizationRules

        internal virtual DescribeClientVpnAuthorizationRulesResponse DescribeClientVpnAuthorizationRules(DescribeClientVpnAuthorizationRulesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClientVpnAuthorizationRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClientVpnAuthorizationRulesResponseUnmarshaller.Instance;

            return Invoke<DescribeClientVpnAuthorizationRulesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeClientVpnAuthorizationRules operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeClientVpnAuthorizationRules operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeClientVpnAuthorizationRules">REST API Reference for DescribeClientVpnAuthorizationRules Operation</seealso>
        public virtual Task<DescribeClientVpnAuthorizationRulesResponse> DescribeClientVpnAuthorizationRulesAsync(DescribeClientVpnAuthorizationRulesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClientVpnAuthorizationRulesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClientVpnAuthorizationRulesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeClientVpnAuthorizationRulesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeClientVpnConnections

        internal virtual DescribeClientVpnConnectionsResponse DescribeClientVpnConnections(DescribeClientVpnConnectionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClientVpnConnectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClientVpnConnectionsResponseUnmarshaller.Instance;

            return Invoke<DescribeClientVpnConnectionsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeClientVpnConnections operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeClientVpnConnections operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeClientVpnConnections">REST API Reference for DescribeClientVpnConnections Operation</seealso>
        public virtual Task<DescribeClientVpnConnectionsResponse> DescribeClientVpnConnectionsAsync(DescribeClientVpnConnectionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClientVpnConnectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClientVpnConnectionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeClientVpnConnectionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeClientVpnEndpoints

        internal virtual DescribeClientVpnEndpointsResponse DescribeClientVpnEndpoints(DescribeClientVpnEndpointsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClientVpnEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClientVpnEndpointsResponseUnmarshaller.Instance;

            return Invoke<DescribeClientVpnEndpointsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeClientVpnEndpoints operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeClientVpnEndpoints operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeClientVpnEndpoints">REST API Reference for DescribeClientVpnEndpoints Operation</seealso>
        public virtual Task<DescribeClientVpnEndpointsResponse> DescribeClientVpnEndpointsAsync(DescribeClientVpnEndpointsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClientVpnEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClientVpnEndpointsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeClientVpnEndpointsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeClientVpnRoutes

        internal virtual DescribeClientVpnRoutesResponse DescribeClientVpnRoutes(DescribeClientVpnRoutesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClientVpnRoutesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClientVpnRoutesResponseUnmarshaller.Instance;

            return Invoke<DescribeClientVpnRoutesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeClientVpnRoutes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeClientVpnRoutes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeClientVpnRoutes">REST API Reference for DescribeClientVpnRoutes Operation</seealso>
        public virtual Task<DescribeClientVpnRoutesResponse> DescribeClientVpnRoutesAsync(DescribeClientVpnRoutesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClientVpnRoutesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClientVpnRoutesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeClientVpnRoutesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeClientVpnTargetNetworks

        internal virtual DescribeClientVpnTargetNetworksResponse DescribeClientVpnTargetNetworks(DescribeClientVpnTargetNetworksRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClientVpnTargetNetworksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClientVpnTargetNetworksResponseUnmarshaller.Instance;

            return Invoke<DescribeClientVpnTargetNetworksResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeClientVpnTargetNetworks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeClientVpnTargetNetworks operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeClientVpnTargetNetworks">REST API Reference for DescribeClientVpnTargetNetworks Operation</seealso>
        public virtual Task<DescribeClientVpnTargetNetworksResponse> DescribeClientVpnTargetNetworksAsync(DescribeClientVpnTargetNetworksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeClientVpnTargetNetworksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeClientVpnTargetNetworksResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeClientVpnTargetNetworksResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeConversionTasks

        internal virtual DescribeConversionTasksResponse DescribeConversionTasks()
        {
            return DescribeConversionTasks(new DescribeConversionTasksRequest());
        }
        internal virtual DescribeConversionTasksResponse DescribeConversionTasks(DescribeConversionTasksRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeConversionTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConversionTasksResponseUnmarshaller.Instance;

            return Invoke<DescribeConversionTasksResponse>(request, options);
        }


        /// <summary>
        /// Describes one or more of your conversion tasks. For more information, see the <a href="https://docs.aws.amazon.com/vm-import/latest/userguide/">VM
        /// Import/Export User Guide</a>.
        /// 
        ///  
        /// <para>
        /// For information about the import manifest referenced by this API action, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/manifest.html">VM
        /// Import Manifest</a>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeConversionTasks service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeConversionTasks">REST API Reference for DescribeConversionTasks Operation</seealso>
        public virtual Task<DescribeConversionTasksResponse> DescribeConversionTasksAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeConversionTasksAsync(new DescribeConversionTasksRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeConversionTasks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeConversionTasks operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeConversionTasks">REST API Reference for DescribeConversionTasks Operation</seealso>
        public virtual Task<DescribeConversionTasksResponse> DescribeConversionTasksAsync(DescribeConversionTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeConversionTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConversionTasksResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeConversionTasksResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeCustomerGateways

        internal virtual DescribeCustomerGatewaysResponse DescribeCustomerGateways()
        {
            return DescribeCustomerGateways(new DescribeCustomerGatewaysRequest());
        }
        internal virtual DescribeCustomerGatewaysResponse DescribeCustomerGateways(DescribeCustomerGatewaysRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCustomerGatewaysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCustomerGatewaysResponseUnmarshaller.Instance;

            return Invoke<DescribeCustomerGatewaysResponse>(request, options);
        }


        /// <summary>
        /// Describes one or more of your VPN customer gateways.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/vpn/latest/s2svpn/VPC_VPN.html">AWS
        /// Site-to-Site VPN</a> in the <i>AWS Site-to-Site VPN User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeCustomerGateways service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeCustomerGateways">REST API Reference for DescribeCustomerGateways Operation</seealso>
        public virtual Task<DescribeCustomerGatewaysResponse> DescribeCustomerGatewaysAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeCustomerGatewaysAsync(new DescribeCustomerGatewaysRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCustomerGateways operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeCustomerGateways operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeCustomerGateways">REST API Reference for DescribeCustomerGateways Operation</seealso>
        public virtual Task<DescribeCustomerGatewaysResponse> DescribeCustomerGatewaysAsync(DescribeCustomerGatewaysRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCustomerGatewaysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCustomerGatewaysResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeCustomerGatewaysResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDhcpOptions

        internal virtual DescribeDhcpOptionsResponse DescribeDhcpOptions()
        {
            return DescribeDhcpOptions(new DescribeDhcpOptionsRequest());
        }
        internal virtual DescribeDhcpOptionsResponse DescribeDhcpOptions(DescribeDhcpOptionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDhcpOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDhcpOptionsResponseUnmarshaller.Instance;

            return Invoke<DescribeDhcpOptionsResponse>(request, options);
        }


        /// <summary>
        /// Describes one or more of your DHCP options sets.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_DHCP_Options.html">DHCP
        /// Options Sets</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDhcpOptions service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeDhcpOptions">REST API Reference for DescribeDhcpOptions Operation</seealso>
        public virtual Task<DescribeDhcpOptionsResponse> DescribeDhcpOptionsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeDhcpOptionsAsync(new DescribeDhcpOptionsRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDhcpOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDhcpOptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeDhcpOptions">REST API Reference for DescribeDhcpOptions Operation</seealso>
        public virtual Task<DescribeDhcpOptionsResponse> DescribeDhcpOptionsAsync(DescribeDhcpOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDhcpOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDhcpOptionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDhcpOptionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeEgressOnlyInternetGateways

        internal virtual DescribeEgressOnlyInternetGatewaysResponse DescribeEgressOnlyInternetGateways(DescribeEgressOnlyInternetGatewaysRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEgressOnlyInternetGatewaysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEgressOnlyInternetGatewaysResponseUnmarshaller.Instance;

            return Invoke<DescribeEgressOnlyInternetGatewaysResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeEgressOnlyInternetGateways operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeEgressOnlyInternetGateways operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeEgressOnlyInternetGateways">REST API Reference for DescribeEgressOnlyInternetGateways Operation</seealso>
        public virtual Task<DescribeEgressOnlyInternetGatewaysResponse> DescribeEgressOnlyInternetGatewaysAsync(DescribeEgressOnlyInternetGatewaysRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeEgressOnlyInternetGatewaysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeEgressOnlyInternetGatewaysResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeEgressOnlyInternetGatewaysResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeElasticGpus

        internal virtual DescribeElasticGpusResponse DescribeElasticGpus(DescribeElasticGpusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeElasticGpusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeElasticGpusResponseUnmarshaller.Instance;

            return Invoke<DescribeElasticGpusResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeElasticGpus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeElasticGpus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeElasticGpus">REST API Reference for DescribeElasticGpus Operation</seealso>
        public virtual Task<DescribeElasticGpusResponse> DescribeElasticGpusAsync(DescribeElasticGpusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeElasticGpusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeElasticGpusResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeElasticGpusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeExportTasks

        internal virtual DescribeExportTasksResponse DescribeExportTasks()
        {
            return DescribeExportTasks(new DescribeExportTasksRequest());
        }
        internal virtual DescribeExportTasksResponse DescribeExportTasks(DescribeExportTasksRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeExportTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeExportTasksResponseUnmarshaller.Instance;

            return Invoke<DescribeExportTasksResponse>(request, options);
        }


        /// <summary>
        /// Describes one or more of your export tasks.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeExportTasks service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeExportTasks">REST API Reference for DescribeExportTasks Operation</seealso>
        public virtual Task<DescribeExportTasksResponse> DescribeExportTasksAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeExportTasksAsync(new DescribeExportTasksRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeExportTasks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeExportTasks operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeExportTasks">REST API Reference for DescribeExportTasks Operation</seealso>
        public virtual Task<DescribeExportTasksResponse> DescribeExportTasksAsync(DescribeExportTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeExportTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeExportTasksResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeExportTasksResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeFleetHistory

        internal virtual DescribeFleetHistoryResponse DescribeFleetHistory(DescribeFleetHistoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFleetHistoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFleetHistoryResponseUnmarshaller.Instance;

            return Invoke<DescribeFleetHistoryResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeFleetHistory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleetHistory operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeFleetHistory">REST API Reference for DescribeFleetHistory Operation</seealso>
        public virtual Task<DescribeFleetHistoryResponse> DescribeFleetHistoryAsync(DescribeFleetHistoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFleetHistoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFleetHistoryResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeFleetHistoryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeFleetInstances

        internal virtual DescribeFleetInstancesResponse DescribeFleetInstances(DescribeFleetInstancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFleetInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFleetInstancesResponseUnmarshaller.Instance;

            return Invoke<DescribeFleetInstancesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeFleetInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleetInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeFleetInstances">REST API Reference for DescribeFleetInstances Operation</seealso>
        public virtual Task<DescribeFleetInstancesResponse> DescribeFleetInstancesAsync(DescribeFleetInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFleetInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFleetInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeFleetInstancesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeFleets

        internal virtual DescribeFleetsResponse DescribeFleets(DescribeFleetsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFleetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFleetsResponseUnmarshaller.Instance;

            return Invoke<DescribeFleetsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeFleets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeFleets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeFleets">REST API Reference for DescribeFleets Operation</seealso>
        public virtual Task<DescribeFleetsResponse> DescribeFleetsAsync(DescribeFleetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFleetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFleetsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeFleetsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeFlowLogs

        internal virtual DescribeFlowLogsResponse DescribeFlowLogs(DescribeFlowLogsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFlowLogsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFlowLogsResponseUnmarshaller.Instance;

            return Invoke<DescribeFlowLogsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeFlowLogs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeFlowLogs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeFlowLogs">REST API Reference for DescribeFlowLogs Operation</seealso>
        public virtual Task<DescribeFlowLogsResponse> DescribeFlowLogsAsync(DescribeFlowLogsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFlowLogsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFlowLogsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeFlowLogsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeFpgaImageAttribute

        internal virtual DescribeFpgaImageAttributeResponse DescribeFpgaImageAttribute(DescribeFpgaImageAttributeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFpgaImageAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFpgaImageAttributeResponseUnmarshaller.Instance;

            return Invoke<DescribeFpgaImageAttributeResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeFpgaImageAttribute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeFpgaImageAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeFpgaImageAttribute">REST API Reference for DescribeFpgaImageAttribute Operation</seealso>
        public virtual Task<DescribeFpgaImageAttributeResponse> DescribeFpgaImageAttributeAsync(DescribeFpgaImageAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFpgaImageAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFpgaImageAttributeResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeFpgaImageAttributeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeFpgaImages

        internal virtual DescribeFpgaImagesResponse DescribeFpgaImages(DescribeFpgaImagesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFpgaImagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFpgaImagesResponseUnmarshaller.Instance;

            return Invoke<DescribeFpgaImagesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeFpgaImages operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeFpgaImages operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeFpgaImages">REST API Reference for DescribeFpgaImages Operation</seealso>
        public virtual Task<DescribeFpgaImagesResponse> DescribeFpgaImagesAsync(DescribeFpgaImagesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeFpgaImagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeFpgaImagesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeFpgaImagesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeHostReservationOfferings

        internal virtual DescribeHostReservationOfferingsResponse DescribeHostReservationOfferings(DescribeHostReservationOfferingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeHostReservationOfferingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeHostReservationOfferingsResponseUnmarshaller.Instance;

            return Invoke<DescribeHostReservationOfferingsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeHostReservationOfferings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeHostReservationOfferings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeHostReservationOfferings">REST API Reference for DescribeHostReservationOfferings Operation</seealso>
        public virtual Task<DescribeHostReservationOfferingsResponse> DescribeHostReservationOfferingsAsync(DescribeHostReservationOfferingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeHostReservationOfferingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeHostReservationOfferingsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeHostReservationOfferingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeHostReservations

        internal virtual DescribeHostReservationsResponse DescribeHostReservations(DescribeHostReservationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeHostReservationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeHostReservationsResponseUnmarshaller.Instance;

            return Invoke<DescribeHostReservationsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeHostReservations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeHostReservations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeHostReservations">REST API Reference for DescribeHostReservations Operation</seealso>
        public virtual Task<DescribeHostReservationsResponse> DescribeHostReservationsAsync(DescribeHostReservationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeHostReservationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeHostReservationsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeHostReservationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeHosts

        internal virtual DescribeHostsResponse DescribeHosts(DescribeHostsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeHostsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeHostsResponseUnmarshaller.Instance;

            return Invoke<DescribeHostsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeHosts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeHosts operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeHosts">REST API Reference for DescribeHosts Operation</seealso>
        public virtual Task<DescribeHostsResponse> DescribeHostsAsync(DescribeHostsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeHostsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeHostsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeHostsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeIamInstanceProfileAssociations

        internal virtual DescribeIamInstanceProfileAssociationsResponse DescribeIamInstanceProfileAssociations(DescribeIamInstanceProfileAssociationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeIamInstanceProfileAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeIamInstanceProfileAssociationsResponseUnmarshaller.Instance;

            return Invoke<DescribeIamInstanceProfileAssociationsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeIamInstanceProfileAssociations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeIamInstanceProfileAssociations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeIamInstanceProfileAssociations">REST API Reference for DescribeIamInstanceProfileAssociations Operation</seealso>
        public virtual Task<DescribeIamInstanceProfileAssociationsResponse> DescribeIamInstanceProfileAssociationsAsync(DescribeIamInstanceProfileAssociationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeIamInstanceProfileAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeIamInstanceProfileAssociationsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeIamInstanceProfileAssociationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeIdentityIdFormat

        internal virtual DescribeIdentityIdFormatResponse DescribeIdentityIdFormat(DescribeIdentityIdFormatRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeIdentityIdFormatRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeIdentityIdFormatResponseUnmarshaller.Instance;

            return Invoke<DescribeIdentityIdFormatResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeIdentityIdFormat operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeIdentityIdFormat operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeIdentityIdFormat">REST API Reference for DescribeIdentityIdFormat Operation</seealso>
        public virtual Task<DescribeIdentityIdFormatResponse> DescribeIdentityIdFormatAsync(DescribeIdentityIdFormatRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeIdentityIdFormatRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeIdentityIdFormatResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeIdentityIdFormatResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeIdFormat

        internal virtual DescribeIdFormatResponse DescribeIdFormat(DescribeIdFormatRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeIdFormatRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeIdFormatResponseUnmarshaller.Instance;

            return Invoke<DescribeIdFormatResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeIdFormat operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeIdFormat operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeIdFormat">REST API Reference for DescribeIdFormat Operation</seealso>
        public virtual Task<DescribeIdFormatResponse> DescribeIdFormatAsync(DescribeIdFormatRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeIdFormatRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeIdFormatResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeIdFormatResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeImageAttribute

        internal virtual DescribeImageAttributeResponse DescribeImageAttribute(DescribeImageAttributeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeImageAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeImageAttributeResponseUnmarshaller.Instance;

            return Invoke<DescribeImageAttributeResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeImageAttribute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeImageAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeImageAttribute">REST API Reference for DescribeImageAttribute Operation</seealso>
        public virtual Task<DescribeImageAttributeResponse> DescribeImageAttributeAsync(DescribeImageAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeImageAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeImageAttributeResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeImageAttributeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeImages

        internal virtual DescribeImagesResponse DescribeImages()
        {
            return DescribeImages(new DescribeImagesRequest());
        }
        internal virtual DescribeImagesResponse DescribeImages(DescribeImagesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeImagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeImagesResponseUnmarshaller.Instance;

            return Invoke<DescribeImagesResponse>(request, options);
        }


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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeImages service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeImages">REST API Reference for DescribeImages Operation</seealso>
        public virtual Task<DescribeImagesResponse> DescribeImagesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeImagesAsync(new DescribeImagesRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeImages operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeImages operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeImages">REST API Reference for DescribeImages Operation</seealso>
        public virtual Task<DescribeImagesResponse> DescribeImagesAsync(DescribeImagesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeImagesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeImagesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeImagesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeImportImageTasks

        internal virtual DescribeImportImageTasksResponse DescribeImportImageTasks(DescribeImportImageTasksRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeImportImageTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeImportImageTasksResponseUnmarshaller.Instance;

            return Invoke<DescribeImportImageTasksResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeImportImageTasks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeImportImageTasks operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeImportImageTasks">REST API Reference for DescribeImportImageTasks Operation</seealso>
        public virtual Task<DescribeImportImageTasksResponse> DescribeImportImageTasksAsync(DescribeImportImageTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeImportImageTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeImportImageTasksResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeImportImageTasksResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeImportSnapshotTasks

        internal virtual DescribeImportSnapshotTasksResponse DescribeImportSnapshotTasks(DescribeImportSnapshotTasksRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeImportSnapshotTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeImportSnapshotTasksResponseUnmarshaller.Instance;

            return Invoke<DescribeImportSnapshotTasksResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeImportSnapshotTasks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeImportSnapshotTasks operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeImportSnapshotTasks">REST API Reference for DescribeImportSnapshotTasks Operation</seealso>
        public virtual Task<DescribeImportSnapshotTasksResponse> DescribeImportSnapshotTasksAsync(DescribeImportSnapshotTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeImportSnapshotTasksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeImportSnapshotTasksResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeImportSnapshotTasksResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeInstanceAttribute

        internal virtual DescribeInstanceAttributeResponse DescribeInstanceAttribute(DescribeInstanceAttributeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInstanceAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInstanceAttributeResponseUnmarshaller.Instance;

            return Invoke<DescribeInstanceAttributeResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInstanceAttribute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstanceAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeInstanceAttribute">REST API Reference for DescribeInstanceAttribute Operation</seealso>
        public virtual Task<DescribeInstanceAttributeResponse> DescribeInstanceAttributeAsync(DescribeInstanceAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInstanceAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInstanceAttributeResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeInstanceAttributeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeInstanceCreditSpecifications

        internal virtual DescribeInstanceCreditSpecificationsResponse DescribeInstanceCreditSpecifications(DescribeInstanceCreditSpecificationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInstanceCreditSpecificationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInstanceCreditSpecificationsResponseUnmarshaller.Instance;

            return Invoke<DescribeInstanceCreditSpecificationsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInstanceCreditSpecifications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstanceCreditSpecifications operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeInstanceCreditSpecifications">REST API Reference for DescribeInstanceCreditSpecifications Operation</seealso>
        public virtual Task<DescribeInstanceCreditSpecificationsResponse> DescribeInstanceCreditSpecificationsAsync(DescribeInstanceCreditSpecificationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInstanceCreditSpecificationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInstanceCreditSpecificationsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeInstanceCreditSpecificationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeInstances

        internal virtual DescribeInstancesResponse DescribeInstances()
        {
            return DescribeInstances(new DescribeInstancesRequest());
        }
        internal virtual DescribeInstancesResponse DescribeInstances(DescribeInstancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInstancesResponseUnmarshaller.Instance;

            return Invoke<DescribeInstancesResponse>(request, options);
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
        ///  
        /// <para>
        /// If you describe instances in the rare case where an Availability Zone is experiencing
        /// a service disruption and you specify instance IDs that are in the affected zone, or
        /// do not specify any instance IDs at all, the call fails. If you describe instances
        /// and specify only instance IDs that are in an unaffected zone, the call works normally.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeInstances service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeInstances">REST API Reference for DescribeInstances Operation</seealso>
        public virtual Task<DescribeInstancesResponse> DescribeInstancesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeInstancesAsync(new DescribeInstancesRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeInstances">REST API Reference for DescribeInstances Operation</seealso>
        public virtual Task<DescribeInstancesResponse> DescribeInstancesAsync(DescribeInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeInstancesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeInstanceStatus

        internal virtual DescribeInstanceStatusResponse DescribeInstanceStatus()
        {
            return DescribeInstanceStatus(new DescribeInstanceStatusRequest());
        }
        internal virtual DescribeInstanceStatusResponse DescribeInstanceStatus(DescribeInstanceStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInstanceStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInstanceStatusResponseUnmarshaller.Instance;

            return Invoke<DescribeInstanceStatusResponse>(request, options);
        }


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
        /// to identify hardware and software issues. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/monitoring-system-instance-status-check.html">Status
        /// Checks for Your Instances</a> and <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/TroubleshootingInstances.html">Troubleshooting
        /// Instances with Failed Status Checks</a> in the <i>Amazon Elastic Compute Cloud User
        /// Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Scheduled events</b> - Amazon EC2 can schedule events (such as reboot, stop, or
        /// terminate) for your instances related to hardware issues, software updates, or system
        /// maintenance. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/monitoring-instances-status-check_sched.html">Scheduled
        /// Events for Your Instances</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  </li> <li> 
        /// <para>
        ///  <b>Instance state</b> - You can manage your instances from the moment you launch
        /// them through their termination. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-instance-lifecycle.html">Instance
        /// Lifecycle</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeInstanceStatus service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeInstanceStatus">REST API Reference for DescribeInstanceStatus Operation</seealso>
        public virtual Task<DescribeInstanceStatusResponse> DescribeInstanceStatusAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeInstanceStatusAsync(new DescribeInstanceStatusRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInstanceStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInstanceStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeInstanceStatus">REST API Reference for DescribeInstanceStatus Operation</seealso>
        public virtual Task<DescribeInstanceStatusResponse> DescribeInstanceStatusAsync(DescribeInstanceStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInstanceStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInstanceStatusResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeInstanceStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeInternetGateways

        internal virtual DescribeInternetGatewaysResponse DescribeInternetGateways()
        {
            return DescribeInternetGateways(new DescribeInternetGatewaysRequest());
        }
        internal virtual DescribeInternetGatewaysResponse DescribeInternetGateways(DescribeInternetGatewaysRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInternetGatewaysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInternetGatewaysResponseUnmarshaller.Instance;

            return Invoke<DescribeInternetGatewaysResponse>(request, options);
        }


        /// <summary>
        /// Describes one or more of your internet gateways.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeInternetGateways service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeInternetGateways">REST API Reference for DescribeInternetGateways Operation</seealso>
        public virtual Task<DescribeInternetGatewaysResponse> DescribeInternetGatewaysAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeInternetGatewaysAsync(new DescribeInternetGatewaysRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInternetGateways operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInternetGateways operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeInternetGateways">REST API Reference for DescribeInternetGateways Operation</seealso>
        public virtual Task<DescribeInternetGatewaysResponse> DescribeInternetGatewaysAsync(DescribeInternetGatewaysRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInternetGatewaysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInternetGatewaysResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeInternetGatewaysResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeKeyPairs

        internal virtual DescribeKeyPairsResponse DescribeKeyPairs()
        {
            return DescribeKeyPairs(new DescribeKeyPairsRequest());
        }
        internal virtual DescribeKeyPairsResponse DescribeKeyPairs(DescribeKeyPairsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeKeyPairsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeKeyPairsResponseUnmarshaller.Instance;

            return Invoke<DescribeKeyPairsResponse>(request, options);
        }


        /// <summary>
        /// Describes one or more of your key pairs.
        /// 
        ///  
        /// <para>
        /// For more information about key pairs, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-key-pairs.html">Key
        /// Pairs</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeKeyPairs service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeKeyPairs">REST API Reference for DescribeKeyPairs Operation</seealso>
        public virtual Task<DescribeKeyPairsResponse> DescribeKeyPairsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeKeyPairsAsync(new DescribeKeyPairsRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeKeyPairs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeKeyPairs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeKeyPairs">REST API Reference for DescribeKeyPairs Operation</seealso>
        public virtual Task<DescribeKeyPairsResponse> DescribeKeyPairsAsync(DescribeKeyPairsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeKeyPairsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeKeyPairsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeKeyPairsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeLaunchTemplates

        internal virtual DescribeLaunchTemplatesResponse DescribeLaunchTemplates(DescribeLaunchTemplatesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLaunchTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLaunchTemplatesResponseUnmarshaller.Instance;

            return Invoke<DescribeLaunchTemplatesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLaunchTemplates operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLaunchTemplates operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeLaunchTemplates">REST API Reference for DescribeLaunchTemplates Operation</seealso>
        public virtual Task<DescribeLaunchTemplatesResponse> DescribeLaunchTemplatesAsync(DescribeLaunchTemplatesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLaunchTemplatesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLaunchTemplatesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeLaunchTemplatesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeLaunchTemplateVersions

        internal virtual DescribeLaunchTemplateVersionsResponse DescribeLaunchTemplateVersions(DescribeLaunchTemplateVersionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLaunchTemplateVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLaunchTemplateVersionsResponseUnmarshaller.Instance;

            return Invoke<DescribeLaunchTemplateVersionsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLaunchTemplateVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLaunchTemplateVersions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeLaunchTemplateVersions">REST API Reference for DescribeLaunchTemplateVersions Operation</seealso>
        public virtual Task<DescribeLaunchTemplateVersionsResponse> DescribeLaunchTemplateVersionsAsync(DescribeLaunchTemplateVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLaunchTemplateVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLaunchTemplateVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeLaunchTemplateVersionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeMovingAddresses

        internal virtual DescribeMovingAddressesResponse DescribeMovingAddresses(DescribeMovingAddressesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeMovingAddressesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMovingAddressesResponseUnmarshaller.Instance;

            return Invoke<DescribeMovingAddressesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeMovingAddresses operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeMovingAddresses operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeMovingAddresses">REST API Reference for DescribeMovingAddresses Operation</seealso>
        public virtual Task<DescribeMovingAddressesResponse> DescribeMovingAddressesAsync(DescribeMovingAddressesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeMovingAddressesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeMovingAddressesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeMovingAddressesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeNatGateways

        internal virtual DescribeNatGatewaysResponse DescribeNatGateways(DescribeNatGatewaysRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeNatGatewaysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeNatGatewaysResponseUnmarshaller.Instance;

            return Invoke<DescribeNatGatewaysResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeNatGateways operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeNatGateways operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeNatGateways">REST API Reference for DescribeNatGateways Operation</seealso>
        public virtual Task<DescribeNatGatewaysResponse> DescribeNatGatewaysAsync(DescribeNatGatewaysRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeNatGatewaysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeNatGatewaysResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeNatGatewaysResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeNetworkAcls

        internal virtual DescribeNetworkAclsResponse DescribeNetworkAcls()
        {
            return DescribeNetworkAcls(new DescribeNetworkAclsRequest());
        }
        internal virtual DescribeNetworkAclsResponse DescribeNetworkAcls(DescribeNetworkAclsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeNetworkAclsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeNetworkAclsResponseUnmarshaller.Instance;

            return Invoke<DescribeNetworkAclsResponse>(request, options);
        }


        /// <summary>
        /// Describes one or more of your network ACLs.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_ACLs.html">Network
        /// ACLs</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeNetworkAcls service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeNetworkAcls">REST API Reference for DescribeNetworkAcls Operation</seealso>
        public virtual Task<DescribeNetworkAclsResponse> DescribeNetworkAclsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeNetworkAclsAsync(new DescribeNetworkAclsRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeNetworkAcls operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeNetworkAcls operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeNetworkAcls">REST API Reference for DescribeNetworkAcls Operation</seealso>
        public virtual Task<DescribeNetworkAclsResponse> DescribeNetworkAclsAsync(DescribeNetworkAclsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeNetworkAclsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeNetworkAclsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeNetworkAclsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeNetworkInterfaceAttribute

        internal virtual DescribeNetworkInterfaceAttributeResponse DescribeNetworkInterfaceAttribute(DescribeNetworkInterfaceAttributeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeNetworkInterfaceAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeNetworkInterfaceAttributeResponseUnmarshaller.Instance;

            return Invoke<DescribeNetworkInterfaceAttributeResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeNetworkInterfaceAttribute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeNetworkInterfaceAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeNetworkInterfaceAttribute">REST API Reference for DescribeNetworkInterfaceAttribute Operation</seealso>
        public virtual Task<DescribeNetworkInterfaceAttributeResponse> DescribeNetworkInterfaceAttributeAsync(DescribeNetworkInterfaceAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeNetworkInterfaceAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeNetworkInterfaceAttributeResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeNetworkInterfaceAttributeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeNetworkInterfacePermissions

        internal virtual DescribeNetworkInterfacePermissionsResponse DescribeNetworkInterfacePermissions(DescribeNetworkInterfacePermissionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeNetworkInterfacePermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeNetworkInterfacePermissionsResponseUnmarshaller.Instance;

            return Invoke<DescribeNetworkInterfacePermissionsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeNetworkInterfacePermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeNetworkInterfacePermissions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeNetworkInterfacePermissions">REST API Reference for DescribeNetworkInterfacePermissions Operation</seealso>
        public virtual Task<DescribeNetworkInterfacePermissionsResponse> DescribeNetworkInterfacePermissionsAsync(DescribeNetworkInterfacePermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeNetworkInterfacePermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeNetworkInterfacePermissionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeNetworkInterfacePermissionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeNetworkInterfaces

        internal virtual DescribeNetworkInterfacesResponse DescribeNetworkInterfaces()
        {
            return DescribeNetworkInterfaces(new DescribeNetworkInterfacesRequest());
        }
        internal virtual DescribeNetworkInterfacesResponse DescribeNetworkInterfaces(DescribeNetworkInterfacesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeNetworkInterfacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeNetworkInterfacesResponseUnmarshaller.Instance;

            return Invoke<DescribeNetworkInterfacesResponse>(request, options);
        }


        /// <summary>
        /// Describes one or more of your network interfaces.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeNetworkInterfaces service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeNetworkInterfaces">REST API Reference for DescribeNetworkInterfaces Operation</seealso>
        public virtual Task<DescribeNetworkInterfacesResponse> DescribeNetworkInterfacesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeNetworkInterfacesAsync(new DescribeNetworkInterfacesRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeNetworkInterfaces operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeNetworkInterfaces operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeNetworkInterfaces">REST API Reference for DescribeNetworkInterfaces Operation</seealso>
        public virtual Task<DescribeNetworkInterfacesResponse> DescribeNetworkInterfacesAsync(DescribeNetworkInterfacesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeNetworkInterfacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeNetworkInterfacesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeNetworkInterfacesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribePlacementGroups

        internal virtual DescribePlacementGroupsResponse DescribePlacementGroups()
        {
            return DescribePlacementGroups(new DescribePlacementGroupsRequest());
        }
        internal virtual DescribePlacementGroupsResponse DescribePlacementGroups(DescribePlacementGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePlacementGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePlacementGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribePlacementGroupsResponse>(request, options);
        }


        /// <summary>
        /// Describes one or more of your placement groups. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/placement-groups.html">Placement
        /// Groups</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribePlacementGroups service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribePlacementGroups">REST API Reference for DescribePlacementGroups Operation</seealso>
        public virtual Task<DescribePlacementGroupsResponse> DescribePlacementGroupsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribePlacementGroupsAsync(new DescribePlacementGroupsRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribePlacementGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePlacementGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribePlacementGroups">REST API Reference for DescribePlacementGroups Operation</seealso>
        public virtual Task<DescribePlacementGroupsResponse> DescribePlacementGroupsAsync(DescribePlacementGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePlacementGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePlacementGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribePlacementGroupsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribePrefixLists

        internal virtual DescribePrefixListsResponse DescribePrefixLists(DescribePrefixListsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePrefixListsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePrefixListsResponseUnmarshaller.Instance;

            return Invoke<DescribePrefixListsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribePrefixLists operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePrefixLists operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribePrefixLists">REST API Reference for DescribePrefixLists Operation</seealso>
        public virtual Task<DescribePrefixListsResponse> DescribePrefixListsAsync(DescribePrefixListsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePrefixListsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePrefixListsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribePrefixListsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribePrincipalIdFormat

        internal virtual DescribePrincipalIdFormatResponse DescribePrincipalIdFormat(DescribePrincipalIdFormatRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePrincipalIdFormatRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePrincipalIdFormatResponseUnmarshaller.Instance;

            return Invoke<DescribePrincipalIdFormatResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribePrincipalIdFormat operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePrincipalIdFormat operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribePrincipalIdFormat">REST API Reference for DescribePrincipalIdFormat Operation</seealso>
        public virtual Task<DescribePrincipalIdFormatResponse> DescribePrincipalIdFormatAsync(DescribePrincipalIdFormatRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePrincipalIdFormatRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePrincipalIdFormatResponseUnmarshaller.Instance;

            return InvokeAsync<DescribePrincipalIdFormatResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribePublicIpv4Pools

        internal virtual DescribePublicIpv4PoolsResponse DescribePublicIpv4Pools(DescribePublicIpv4PoolsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePublicIpv4PoolsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePublicIpv4PoolsResponseUnmarshaller.Instance;

            return Invoke<DescribePublicIpv4PoolsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribePublicIpv4Pools operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribePublicIpv4Pools operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribePublicIpv4Pools">REST API Reference for DescribePublicIpv4Pools Operation</seealso>
        public virtual Task<DescribePublicIpv4PoolsResponse> DescribePublicIpv4PoolsAsync(DescribePublicIpv4PoolsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribePublicIpv4PoolsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribePublicIpv4PoolsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribePublicIpv4PoolsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeRegions

        internal virtual DescribeRegionsResponse DescribeRegions()
        {
            return DescribeRegions(new DescribeRegionsRequest());
        }
        internal virtual DescribeRegionsResponse DescribeRegions(DescribeRegionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRegionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRegionsResponseUnmarshaller.Instance;

            return Invoke<DescribeRegionsResponse>(request, options);
        }


        /// <summary>
        /// Describes one or more regions that are currently available to you.
        /// 
        ///  
        /// <para>
        /// For a list of the regions supported by Amazon EC2, see <a href="https://docs.aws.amazon.com/general/latest/gr/rande.html#ec2_region">Regions
        /// and Endpoints</a>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeRegions service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeRegions">REST API Reference for DescribeRegions Operation</seealso>
        public virtual Task<DescribeRegionsResponse> DescribeRegionsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeRegionsAsync(new DescribeRegionsRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRegions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRegions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeRegions">REST API Reference for DescribeRegions Operation</seealso>
        public virtual Task<DescribeRegionsResponse> DescribeRegionsAsync(DescribeRegionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRegionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRegionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeRegionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeReservedInstances

        internal virtual DescribeReservedInstancesResponse DescribeReservedInstances()
        {
            return DescribeReservedInstances(new DescribeReservedInstancesRequest());
        }
        internal virtual DescribeReservedInstancesResponse DescribeReservedInstances(DescribeReservedInstancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReservedInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReservedInstancesResponseUnmarshaller.Instance;

            return Invoke<DescribeReservedInstancesResponse>(request, options);
        }


        /// <summary>
        /// Describes one or more of the Reserved Instances that you purchased.
        /// 
        ///  
        /// <para>
        /// For more information about Reserved Instances, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/concepts-on-demand-reserved-instances.html">Reserved
        /// Instances</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeReservedInstances service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeReservedInstances">REST API Reference for DescribeReservedInstances Operation</seealso>
        public virtual Task<DescribeReservedInstancesResponse> DescribeReservedInstancesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeReservedInstancesAsync(new DescribeReservedInstancesRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReservedInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeReservedInstances">REST API Reference for DescribeReservedInstances Operation</seealso>
        public virtual Task<DescribeReservedInstancesResponse> DescribeReservedInstancesAsync(DescribeReservedInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReservedInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReservedInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeReservedInstancesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeReservedInstancesListings

        internal virtual DescribeReservedInstancesListingsResponse DescribeReservedInstancesListings()
        {
            return DescribeReservedInstancesListings(new DescribeReservedInstancesListingsRequest());
        }
        internal virtual DescribeReservedInstancesListingsResponse DescribeReservedInstancesListings(DescribeReservedInstancesListingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReservedInstancesListingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReservedInstancesListingsResponseUnmarshaller.Instance;

            return Invoke<DescribeReservedInstancesListingsResponse>(request, options);
        }


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
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ri-market-general.html">Reserved
        /// Instance Marketplace</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeReservedInstancesListings service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeReservedInstancesListings">REST API Reference for DescribeReservedInstancesListings Operation</seealso>
        public virtual Task<DescribeReservedInstancesListingsResponse> DescribeReservedInstancesListingsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeReservedInstancesListingsAsync(new DescribeReservedInstancesListingsRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReservedInstancesListings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedInstancesListings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeReservedInstancesListings">REST API Reference for DescribeReservedInstancesListings Operation</seealso>
        public virtual Task<DescribeReservedInstancesListingsResponse> DescribeReservedInstancesListingsAsync(DescribeReservedInstancesListingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReservedInstancesListingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReservedInstancesListingsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeReservedInstancesListingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeReservedInstancesModifications

        internal virtual DescribeReservedInstancesModificationsResponse DescribeReservedInstancesModifications()
        {
            return DescribeReservedInstancesModifications(new DescribeReservedInstancesModificationsRequest());
        }
        internal virtual DescribeReservedInstancesModificationsResponse DescribeReservedInstancesModifications(DescribeReservedInstancesModificationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReservedInstancesModificationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReservedInstancesModificationsResponseUnmarshaller.Instance;

            return Invoke<DescribeReservedInstancesModificationsResponse>(request, options);
        }


        /// <summary>
        /// Describes the modifications made to your Reserved Instances. If no parameter is specified,
        /// information about all your Reserved Instances modification requests is returned. If
        /// a modification ID is specified, only information about the specific modification is
        /// returned.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ri-modifying.html">Modifying
        /// Reserved Instances</a> in the Amazon Elastic Compute Cloud User Guide.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeReservedInstancesModifications service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeReservedInstancesModifications">REST API Reference for DescribeReservedInstancesModifications Operation</seealso>
        public virtual Task<DescribeReservedInstancesModificationsResponse> DescribeReservedInstancesModificationsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeReservedInstancesModificationsAsync(new DescribeReservedInstancesModificationsRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReservedInstancesModifications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedInstancesModifications operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeReservedInstancesModifications">REST API Reference for DescribeReservedInstancesModifications Operation</seealso>
        public virtual Task<DescribeReservedInstancesModificationsResponse> DescribeReservedInstancesModificationsAsync(DescribeReservedInstancesModificationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReservedInstancesModificationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReservedInstancesModificationsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeReservedInstancesModificationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeReservedInstancesOfferings

        internal virtual DescribeReservedInstancesOfferingsResponse DescribeReservedInstancesOfferings()
        {
            return DescribeReservedInstancesOfferings(new DescribeReservedInstancesOfferingsRequest());
        }
        internal virtual DescribeReservedInstancesOfferingsResponse DescribeReservedInstancesOfferings(DescribeReservedInstancesOfferingsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReservedInstancesOfferingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReservedInstancesOfferingsResponseUnmarshaller.Instance;

            return Invoke<DescribeReservedInstancesOfferingsResponse>(request, options);
        }


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
        /// For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ri-market-general.html">Reserved
        /// Instance Marketplace</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeReservedInstancesOfferings service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeReservedInstancesOfferings">REST API Reference for DescribeReservedInstancesOfferings Operation</seealso>
        public virtual Task<DescribeReservedInstancesOfferingsResponse> DescribeReservedInstancesOfferingsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeReservedInstancesOfferingsAsync(new DescribeReservedInstancesOfferingsRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReservedInstancesOfferings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeReservedInstancesOfferings operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeReservedInstancesOfferings">REST API Reference for DescribeReservedInstancesOfferings Operation</seealso>
        public virtual Task<DescribeReservedInstancesOfferingsResponse> DescribeReservedInstancesOfferingsAsync(DescribeReservedInstancesOfferingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeReservedInstancesOfferingsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeReservedInstancesOfferingsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeReservedInstancesOfferingsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeRouteTables

        internal virtual DescribeRouteTablesResponse DescribeRouteTables()
        {
            return DescribeRouteTables(new DescribeRouteTablesRequest());
        }
        internal virtual DescribeRouteTablesResponse DescribeRouteTables(DescribeRouteTablesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRouteTablesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRouteTablesResponseUnmarshaller.Instance;

            return Invoke<DescribeRouteTablesResponse>(request, options);
        }


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
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Route_Tables.html">Route
        /// Tables</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeRouteTables service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeRouteTables">REST API Reference for DescribeRouteTables Operation</seealso>
        public virtual Task<DescribeRouteTablesResponse> DescribeRouteTablesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeRouteTablesAsync(new DescribeRouteTablesRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRouteTables operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeRouteTables operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeRouteTables">REST API Reference for DescribeRouteTables Operation</seealso>
        public virtual Task<DescribeRouteTablesResponse> DescribeRouteTablesAsync(DescribeRouteTablesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRouteTablesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRouteTablesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeRouteTablesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeScheduledInstanceAvailability

        internal virtual DescribeScheduledInstanceAvailabilityResponse DescribeScheduledInstanceAvailability(DescribeScheduledInstanceAvailabilityRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeScheduledInstanceAvailabilityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeScheduledInstanceAvailabilityResponseUnmarshaller.Instance;

            return Invoke<DescribeScheduledInstanceAvailabilityResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeScheduledInstanceAvailability operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeScheduledInstanceAvailability operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeScheduledInstanceAvailability">REST API Reference for DescribeScheduledInstanceAvailability Operation</seealso>
        public virtual Task<DescribeScheduledInstanceAvailabilityResponse> DescribeScheduledInstanceAvailabilityAsync(DescribeScheduledInstanceAvailabilityRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeScheduledInstanceAvailabilityRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeScheduledInstanceAvailabilityResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeScheduledInstanceAvailabilityResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeScheduledInstances

        internal virtual DescribeScheduledInstancesResponse DescribeScheduledInstances(DescribeScheduledInstancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeScheduledInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeScheduledInstancesResponseUnmarshaller.Instance;

            return Invoke<DescribeScheduledInstancesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeScheduledInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeScheduledInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeScheduledInstances">REST API Reference for DescribeScheduledInstances Operation</seealso>
        public virtual Task<DescribeScheduledInstancesResponse> DescribeScheduledInstancesAsync(DescribeScheduledInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeScheduledInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeScheduledInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeScheduledInstancesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeSecurityGroupReferences

        internal virtual DescribeSecurityGroupReferencesResponse DescribeSecurityGroupReferences(DescribeSecurityGroupReferencesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSecurityGroupReferencesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSecurityGroupReferencesResponseUnmarshaller.Instance;

            return Invoke<DescribeSecurityGroupReferencesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSecurityGroupReferences operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSecurityGroupReferences operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSecurityGroupReferences">REST API Reference for DescribeSecurityGroupReferences Operation</seealso>
        public virtual Task<DescribeSecurityGroupReferencesResponse> DescribeSecurityGroupReferencesAsync(DescribeSecurityGroupReferencesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSecurityGroupReferencesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSecurityGroupReferencesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSecurityGroupReferencesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeSecurityGroups

        internal virtual DescribeSecurityGroupsResponse DescribeSecurityGroups()
        {
            return DescribeSecurityGroups(new DescribeSecurityGroupsRequest());
        }
        internal virtual DescribeSecurityGroupsResponse DescribeSecurityGroups(DescribeSecurityGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSecurityGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSecurityGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribeSecurityGroupsResponse>(request, options);
        }


        /// <summary>
        /// Describes one or more of your security groups.
        /// 
        ///  
        /// <para>
        /// A security group is for use with instances either in the EC2-Classic platform or in
        /// a specific VPC. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-network-security.html">Amazon
        /// EC2 Security Groups</a> in the <i>Amazon Elastic Compute Cloud User Guide</i> and
        /// <a href="https://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_SecurityGroups.html">Security
        /// Groups for Your VPC</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSecurityGroups service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSecurityGroups">REST API Reference for DescribeSecurityGroups Operation</seealso>
        public virtual Task<DescribeSecurityGroupsResponse> DescribeSecurityGroupsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeSecurityGroupsAsync(new DescribeSecurityGroupsRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSecurityGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSecurityGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSecurityGroups">REST API Reference for DescribeSecurityGroups Operation</seealso>
        public virtual Task<DescribeSecurityGroupsResponse> DescribeSecurityGroupsAsync(DescribeSecurityGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSecurityGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSecurityGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSecurityGroupsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeSnapshotAttribute

        internal virtual DescribeSnapshotAttributeResponse DescribeSnapshotAttribute(DescribeSnapshotAttributeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSnapshotAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSnapshotAttributeResponseUnmarshaller.Instance;

            return Invoke<DescribeSnapshotAttributeResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSnapshotAttribute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSnapshotAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSnapshotAttribute">REST API Reference for DescribeSnapshotAttribute Operation</seealso>
        public virtual Task<DescribeSnapshotAttributeResponse> DescribeSnapshotAttributeAsync(DescribeSnapshotAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSnapshotAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSnapshotAttributeResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSnapshotAttributeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeSnapshots

        internal virtual DescribeSnapshotsResponse DescribeSnapshots()
        {
            return DescribeSnapshots(new DescribeSnapshotsRequest());
        }
        internal virtual DescribeSnapshotsResponse DescribeSnapshots(DescribeSnapshotsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSnapshotsResponseUnmarshaller.Instance;

            return Invoke<DescribeSnapshotsResponse>(request, options);
        }


        /// <summary>
        /// Describes one or more of the EBS snapshots available to you. Available snapshots include
        /// public snapshots available for use by any AWS account, private snapshots that you
        /// own, and private snapshots owned by another AWS account for which you've been given
        /// explicit create volume permissions.
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
        /// For more information about EBS snapshots, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSSnapshots.html">Amazon
        /// EBS Snapshots</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSnapshots service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSnapshots">REST API Reference for DescribeSnapshots Operation</seealso>
        public virtual Task<DescribeSnapshotsResponse> DescribeSnapshotsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeSnapshotsAsync(new DescribeSnapshotsRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSnapshots operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSnapshots operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSnapshots">REST API Reference for DescribeSnapshots Operation</seealso>
        public virtual Task<DescribeSnapshotsResponse> DescribeSnapshotsAsync(DescribeSnapshotsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSnapshotsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSnapshotsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSnapshotsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeSpotDatafeedSubscription

        internal virtual DescribeSpotDatafeedSubscriptionResponse DescribeSpotDatafeedSubscription()
        {
            return DescribeSpotDatafeedSubscription(new DescribeSpotDatafeedSubscriptionRequest());
        }
        internal virtual DescribeSpotDatafeedSubscriptionResponse DescribeSpotDatafeedSubscription(DescribeSpotDatafeedSubscriptionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSpotDatafeedSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSpotDatafeedSubscriptionResponseUnmarshaller.Instance;

            return Invoke<DescribeSpotDatafeedSubscriptionResponse>(request, options);
        }


        /// <summary>
        /// Describes the data feed for Spot Instances. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/spot-data-feeds.html">Spot
        /// Instance Data Feed</a> in the <i>Amazon EC2 User Guide for Linux Instances</i>.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSpotDatafeedSubscription service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSpotDatafeedSubscription">REST API Reference for DescribeSpotDatafeedSubscription Operation</seealso>
        public virtual Task<DescribeSpotDatafeedSubscriptionResponse> DescribeSpotDatafeedSubscriptionAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeSpotDatafeedSubscriptionAsync(new DescribeSpotDatafeedSubscriptionRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSpotDatafeedSubscription operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSpotDatafeedSubscription operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSpotDatafeedSubscription">REST API Reference for DescribeSpotDatafeedSubscription Operation</seealso>
        public virtual Task<DescribeSpotDatafeedSubscriptionResponse> DescribeSpotDatafeedSubscriptionAsync(DescribeSpotDatafeedSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSpotDatafeedSubscriptionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSpotDatafeedSubscriptionResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSpotDatafeedSubscriptionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeSpotFleetInstances

        internal virtual DescribeSpotFleetInstancesResponse DescribeSpotFleetInstances(DescribeSpotFleetInstancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSpotFleetInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSpotFleetInstancesResponseUnmarshaller.Instance;

            return Invoke<DescribeSpotFleetInstancesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSpotFleetInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSpotFleetInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSpotFleetInstances">REST API Reference for DescribeSpotFleetInstances Operation</seealso>
        public virtual Task<DescribeSpotFleetInstancesResponse> DescribeSpotFleetInstancesAsync(DescribeSpotFleetInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSpotFleetInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSpotFleetInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSpotFleetInstancesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeSpotFleetRequestHistory

        internal virtual DescribeSpotFleetRequestHistoryResponse DescribeSpotFleetRequestHistory(DescribeSpotFleetRequestHistoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSpotFleetRequestHistoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSpotFleetRequestHistoryResponseUnmarshaller.Instance;

            return Invoke<DescribeSpotFleetRequestHistoryResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSpotFleetRequestHistory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSpotFleetRequestHistory operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSpotFleetRequestHistory">REST API Reference for DescribeSpotFleetRequestHistory Operation</seealso>
        public virtual Task<DescribeSpotFleetRequestHistoryResponse> DescribeSpotFleetRequestHistoryAsync(DescribeSpotFleetRequestHistoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSpotFleetRequestHistoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSpotFleetRequestHistoryResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSpotFleetRequestHistoryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeSpotFleetRequests

        internal virtual DescribeSpotFleetRequestsResponse DescribeSpotFleetRequests(DescribeSpotFleetRequestsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSpotFleetRequestsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSpotFleetRequestsResponseUnmarshaller.Instance;

            return Invoke<DescribeSpotFleetRequestsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSpotFleetRequests operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSpotFleetRequests operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSpotFleetRequests">REST API Reference for DescribeSpotFleetRequests Operation</seealso>
        public virtual Task<DescribeSpotFleetRequestsResponse> DescribeSpotFleetRequestsAsync(DescribeSpotFleetRequestsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSpotFleetRequestsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSpotFleetRequestsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSpotFleetRequestsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeSpotInstanceRequests

        internal virtual DescribeSpotInstanceRequestsResponse DescribeSpotInstanceRequests()
        {
            return DescribeSpotInstanceRequests(new DescribeSpotInstanceRequestsRequest());
        }
        internal virtual DescribeSpotInstanceRequestsResponse DescribeSpotInstanceRequests(DescribeSpotInstanceRequestsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSpotInstanceRequestsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSpotInstanceRequestsResponseUnmarshaller.Instance;

            return Invoke<DescribeSpotInstanceRequestsResponse>(request, options);
        }


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
        /// We recommend that you set <code>MaxResults</code> to a value between 5 and 1000 to
        /// limit the number of results returned. This paginates the output, which makes the list
        /// more manageable and returns the results faster. If the list of results exceeds your
        /// <code>MaxResults</code> value, then that number of results is returned along with
        /// a <code>NextToken</code> value that can be passed to a subsequent <code>DescribeSpotInstanceRequests</code>
        /// request to retrieve the remaining results.
        /// </para>
        ///  
        /// <para>
        /// Spot Instance requests are deleted four hours after they are canceled and their instances
        /// are terminated.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSpotInstanceRequests service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSpotInstanceRequests">REST API Reference for DescribeSpotInstanceRequests Operation</seealso>
        public virtual Task<DescribeSpotInstanceRequestsResponse> DescribeSpotInstanceRequestsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeSpotInstanceRequestsAsync(new DescribeSpotInstanceRequestsRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSpotInstanceRequests operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSpotInstanceRequests operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSpotInstanceRequests">REST API Reference for DescribeSpotInstanceRequests Operation</seealso>
        public virtual Task<DescribeSpotInstanceRequestsResponse> DescribeSpotInstanceRequestsAsync(DescribeSpotInstanceRequestsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSpotInstanceRequestsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSpotInstanceRequestsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSpotInstanceRequestsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeSpotPriceHistory

        internal virtual DescribeSpotPriceHistoryResponse DescribeSpotPriceHistory()
        {
            return DescribeSpotPriceHistory(new DescribeSpotPriceHistoryRequest());
        }
        internal virtual DescribeSpotPriceHistoryResponse DescribeSpotPriceHistory(DescribeSpotPriceHistoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSpotPriceHistoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSpotPriceHistoryResponseUnmarshaller.Instance;

            return Invoke<DescribeSpotPriceHistoryResponse>(request, options);
        }


        /// <summary>
        /// Describes the Spot price history. For more information, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-spot-instances-history.html">Spot
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
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSpotPriceHistory service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSpotPriceHistory">REST API Reference for DescribeSpotPriceHistory Operation</seealso>
        public virtual Task<DescribeSpotPriceHistoryResponse> DescribeSpotPriceHistoryAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeSpotPriceHistoryAsync(new DescribeSpotPriceHistoryRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSpotPriceHistory operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSpotPriceHistory operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSpotPriceHistory">REST API Reference for DescribeSpotPriceHistory Operation</seealso>
        public virtual Task<DescribeSpotPriceHistoryResponse> DescribeSpotPriceHistoryAsync(DescribeSpotPriceHistoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSpotPriceHistoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSpotPriceHistoryResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSpotPriceHistoryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeStaleSecurityGroups

        internal virtual DescribeStaleSecurityGroupsResponse DescribeStaleSecurityGroups(DescribeStaleSecurityGroupsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStaleSecurityGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStaleSecurityGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribeStaleSecurityGroupsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeStaleSecurityGroups operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeStaleSecurityGroups operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeStaleSecurityGroups">REST API Reference for DescribeStaleSecurityGroups Operation</seealso>
        public virtual Task<DescribeStaleSecurityGroupsResponse> DescribeStaleSecurityGroupsAsync(DescribeStaleSecurityGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeStaleSecurityGroupsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeStaleSecurityGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeStaleSecurityGroupsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeSubnets

        internal virtual DescribeSubnetsResponse DescribeSubnets()
        {
            return DescribeSubnets(new DescribeSubnetsRequest());
        }
        internal virtual DescribeSubnetsResponse DescribeSubnets(DescribeSubnetsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSubnetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSubnetsResponseUnmarshaller.Instance;

            return Invoke<DescribeSubnetsResponse>(request, options);
        }


        /// <summary>
        /// Describes one or more of your subnets.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Subnets.html">Your
        /// VPC and Subnets</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSubnets service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSubnets">REST API Reference for DescribeSubnets Operation</seealso>
        public virtual Task<DescribeSubnetsResponse> DescribeSubnetsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeSubnetsAsync(new DescribeSubnetsRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSubnets operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeSubnets operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeSubnets">REST API Reference for DescribeSubnets Operation</seealso>
        public virtual Task<DescribeSubnetsResponse> DescribeSubnetsAsync(DescribeSubnetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeSubnetsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeSubnetsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSubnetsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeTags

        internal virtual DescribeTagsResponse DescribeTags()
        {
            return DescribeTags(new DescribeTagsRequest());
        }
        internal virtual DescribeTagsResponse DescribeTags(DescribeTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTagsResponseUnmarshaller.Instance;

            return Invoke<DescribeTagsResponse>(request, options);
        }


        /// <summary>
        /// Describes one or more of the tags for your EC2 resources.
        /// 
        ///  
        /// <para>
        /// For more information about tags, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_Tags.html">Tagging
        /// Your Resources</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTags service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeTags">REST API Reference for DescribeTags Operation</seealso>
        public virtual Task<DescribeTagsResponse> DescribeTagsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeTagsAsync(new DescribeTagsRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeTags">REST API Reference for DescribeTags Operation</seealso>
        public virtual Task<DescribeTagsResponse> DescribeTagsAsync(DescribeTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTagsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTagsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeTransitGatewayAttachments

        internal virtual DescribeTransitGatewayAttachmentsResponse DescribeTransitGatewayAttachments(DescribeTransitGatewayAttachmentsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTransitGatewayAttachmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTransitGatewayAttachmentsResponseUnmarshaller.Instance;

            return Invoke<DescribeTransitGatewayAttachmentsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTransitGatewayAttachments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTransitGatewayAttachments operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeTransitGatewayAttachments">REST API Reference for DescribeTransitGatewayAttachments Operation</seealso>
        public virtual Task<DescribeTransitGatewayAttachmentsResponse> DescribeTransitGatewayAttachmentsAsync(DescribeTransitGatewayAttachmentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTransitGatewayAttachmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTransitGatewayAttachmentsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTransitGatewayAttachmentsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeTransitGatewayRouteTables

        internal virtual DescribeTransitGatewayRouteTablesResponse DescribeTransitGatewayRouteTables(DescribeTransitGatewayRouteTablesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTransitGatewayRouteTablesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTransitGatewayRouteTablesResponseUnmarshaller.Instance;

            return Invoke<DescribeTransitGatewayRouteTablesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTransitGatewayRouteTables operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTransitGatewayRouteTables operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeTransitGatewayRouteTables">REST API Reference for DescribeTransitGatewayRouteTables Operation</seealso>
        public virtual Task<DescribeTransitGatewayRouteTablesResponse> DescribeTransitGatewayRouteTablesAsync(DescribeTransitGatewayRouteTablesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTransitGatewayRouteTablesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTransitGatewayRouteTablesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTransitGatewayRouteTablesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeTransitGateways

        internal virtual DescribeTransitGatewaysResponse DescribeTransitGateways(DescribeTransitGatewaysRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTransitGatewaysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTransitGatewaysResponseUnmarshaller.Instance;

            return Invoke<DescribeTransitGatewaysResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTransitGateways operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTransitGateways operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeTransitGateways">REST API Reference for DescribeTransitGateways Operation</seealso>
        public virtual Task<DescribeTransitGatewaysResponse> DescribeTransitGatewaysAsync(DescribeTransitGatewaysRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTransitGatewaysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTransitGatewaysResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTransitGatewaysResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeTransitGatewayVpcAttachments

        internal virtual DescribeTransitGatewayVpcAttachmentsResponse DescribeTransitGatewayVpcAttachments(DescribeTransitGatewayVpcAttachmentsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTransitGatewayVpcAttachmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTransitGatewayVpcAttachmentsResponseUnmarshaller.Instance;

            return Invoke<DescribeTransitGatewayVpcAttachmentsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTransitGatewayVpcAttachments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTransitGatewayVpcAttachments operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeTransitGatewayVpcAttachments">REST API Reference for DescribeTransitGatewayVpcAttachments Operation</seealso>
        public virtual Task<DescribeTransitGatewayVpcAttachmentsResponse> DescribeTransitGatewayVpcAttachmentsAsync(DescribeTransitGatewayVpcAttachmentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTransitGatewayVpcAttachmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTransitGatewayVpcAttachmentsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTransitGatewayVpcAttachmentsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeVolumeAttribute

        internal virtual DescribeVolumeAttributeResponse DescribeVolumeAttribute(DescribeVolumeAttributeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVolumeAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVolumeAttributeResponseUnmarshaller.Instance;

            return Invoke<DescribeVolumeAttributeResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVolumeAttribute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVolumeAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVolumeAttribute">REST API Reference for DescribeVolumeAttribute Operation</seealso>
        public virtual Task<DescribeVolumeAttributeResponse> DescribeVolumeAttributeAsync(DescribeVolumeAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVolumeAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVolumeAttributeResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeVolumeAttributeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeVolumes

        internal virtual DescribeVolumesResponse DescribeVolumes()
        {
            return DescribeVolumes(new DescribeVolumesRequest());
        }
        internal virtual DescribeVolumesResponse DescribeVolumes(DescribeVolumesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVolumesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVolumesResponseUnmarshaller.Instance;

            return Invoke<DescribeVolumesResponse>(request, options);
        }


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
        /// For more information about EBS volumes, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSVolumes.html">Amazon
        /// EBS Volumes</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeVolumes service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVolumes">REST API Reference for DescribeVolumes Operation</seealso>
        public virtual Task<DescribeVolumesResponse> DescribeVolumesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeVolumesAsync(new DescribeVolumesRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVolumes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVolumes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVolumes">REST API Reference for DescribeVolumes Operation</seealso>
        public virtual Task<DescribeVolumesResponse> DescribeVolumesAsync(DescribeVolumesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVolumesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVolumesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeVolumesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeVolumesModifications

        internal virtual DescribeVolumesModificationsResponse DescribeVolumesModifications(DescribeVolumesModificationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVolumesModificationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVolumesModificationsResponseUnmarshaller.Instance;

            return Invoke<DescribeVolumesModificationsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVolumesModifications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVolumesModifications operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVolumesModifications">REST API Reference for DescribeVolumesModifications Operation</seealso>
        public virtual Task<DescribeVolumesModificationsResponse> DescribeVolumesModificationsAsync(DescribeVolumesModificationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVolumesModificationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVolumesModificationsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeVolumesModificationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeVolumeStatus

        internal virtual DescribeVolumeStatusResponse DescribeVolumeStatus()
        {
            return DescribeVolumeStatus(new DescribeVolumeStatusRequest());
        }
        internal virtual DescribeVolumeStatusResponse DescribeVolumeStatus(DescribeVolumeStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVolumeStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVolumeStatusResponseUnmarshaller.Instance;

            return Invoke<DescribeVolumeStatusResponse>(request, options);
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
        ///  <i>Status</i>: Reflects the current status of the volume. The possible values are
        /// <code>ok</code>, <code>impaired</code> , <code>warning</code>, or <code>insufficient-data</code>.
        /// If all checks pass, the overall status of the volume is <code>ok</code>. If the check
        /// fails, the overall status is <code>impaired</code>. If the status is <code>insufficient-data</code>,
        /// then the checks may still be taking place on your volume at the time. We recommend
        /// that you retry the request. For more information about volume status, see <a href="https://docs.aws.amazon.com/AWSEC2/latest/UserGuide/monitoring-volume-status.html">Monitoring
        /// the Status of Your Volumes</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
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
        ///  
        /// <para>
        /// Volume status is based on the volume status checks, and does not reflect the volume
        /// state. Therefore, volume status does not indicate volumes in the <code>error</code>
        /// state (for example, when a volume is incapable of accepting I/O.)
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeVolumeStatus service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVolumeStatus">REST API Reference for DescribeVolumeStatus Operation</seealso>
        public virtual Task<DescribeVolumeStatusResponse> DescribeVolumeStatusAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeVolumeStatusAsync(new DescribeVolumeStatusRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVolumeStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVolumeStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVolumeStatus">REST API Reference for DescribeVolumeStatus Operation</seealso>
        public virtual Task<DescribeVolumeStatusResponse> DescribeVolumeStatusAsync(DescribeVolumeStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVolumeStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVolumeStatusResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeVolumeStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeVpcAttribute

        internal virtual DescribeVpcAttributeResponse DescribeVpcAttribute(DescribeVpcAttributeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVpcAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVpcAttributeResponseUnmarshaller.Instance;

            return Invoke<DescribeVpcAttributeResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVpcAttribute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcAttribute">REST API Reference for DescribeVpcAttribute Operation</seealso>
        public virtual Task<DescribeVpcAttributeResponse> DescribeVpcAttributeAsync(DescribeVpcAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVpcAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVpcAttributeResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeVpcAttributeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeVpcClassicLink

        internal virtual DescribeVpcClassicLinkResponse DescribeVpcClassicLink(DescribeVpcClassicLinkRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVpcClassicLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVpcClassicLinkResponseUnmarshaller.Instance;

            return Invoke<DescribeVpcClassicLinkResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVpcClassicLink operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcClassicLink operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcClassicLink">REST API Reference for DescribeVpcClassicLink Operation</seealso>
        public virtual Task<DescribeVpcClassicLinkResponse> DescribeVpcClassicLinkAsync(DescribeVpcClassicLinkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVpcClassicLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVpcClassicLinkResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeVpcClassicLinkResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeVpcClassicLinkDnsSupport

        internal virtual DescribeVpcClassicLinkDnsSupportResponse DescribeVpcClassicLinkDnsSupport(DescribeVpcClassicLinkDnsSupportRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVpcClassicLinkDnsSupportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVpcClassicLinkDnsSupportResponseUnmarshaller.Instance;

            return Invoke<DescribeVpcClassicLinkDnsSupportResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVpcClassicLinkDnsSupport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcClassicLinkDnsSupport operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcClassicLinkDnsSupport">REST API Reference for DescribeVpcClassicLinkDnsSupport Operation</seealso>
        public virtual Task<DescribeVpcClassicLinkDnsSupportResponse> DescribeVpcClassicLinkDnsSupportAsync(DescribeVpcClassicLinkDnsSupportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVpcClassicLinkDnsSupportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVpcClassicLinkDnsSupportResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeVpcClassicLinkDnsSupportResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeVpcEndpointConnectionNotifications

        internal virtual DescribeVpcEndpointConnectionNotificationsResponse DescribeVpcEndpointConnectionNotifications(DescribeVpcEndpointConnectionNotificationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVpcEndpointConnectionNotificationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVpcEndpointConnectionNotificationsResponseUnmarshaller.Instance;

            return Invoke<DescribeVpcEndpointConnectionNotificationsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVpcEndpointConnectionNotifications operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcEndpointConnectionNotifications operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcEndpointConnectionNotifications">REST API Reference for DescribeVpcEndpointConnectionNotifications Operation</seealso>
        public virtual Task<DescribeVpcEndpointConnectionNotificationsResponse> DescribeVpcEndpointConnectionNotificationsAsync(DescribeVpcEndpointConnectionNotificationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVpcEndpointConnectionNotificationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVpcEndpointConnectionNotificationsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeVpcEndpointConnectionNotificationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeVpcEndpointConnections

        internal virtual DescribeVpcEndpointConnectionsResponse DescribeVpcEndpointConnections(DescribeVpcEndpointConnectionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVpcEndpointConnectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVpcEndpointConnectionsResponseUnmarshaller.Instance;

            return Invoke<DescribeVpcEndpointConnectionsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVpcEndpointConnections operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcEndpointConnections operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcEndpointConnections">REST API Reference for DescribeVpcEndpointConnections Operation</seealso>
        public virtual Task<DescribeVpcEndpointConnectionsResponse> DescribeVpcEndpointConnectionsAsync(DescribeVpcEndpointConnectionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVpcEndpointConnectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVpcEndpointConnectionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeVpcEndpointConnectionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeVpcEndpoints

        internal virtual DescribeVpcEndpointsResponse DescribeVpcEndpoints(DescribeVpcEndpointsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVpcEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVpcEndpointsResponseUnmarshaller.Instance;

            return Invoke<DescribeVpcEndpointsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVpcEndpoints operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcEndpoints operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcEndpoints">REST API Reference for DescribeVpcEndpoints Operation</seealso>
        public virtual Task<DescribeVpcEndpointsResponse> DescribeVpcEndpointsAsync(DescribeVpcEndpointsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVpcEndpointsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVpcEndpointsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeVpcEndpointsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeVpcEndpointServiceConfigurations

        internal virtual DescribeVpcEndpointServiceConfigurationsResponse DescribeVpcEndpointServiceConfigurations(DescribeVpcEndpointServiceConfigurationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVpcEndpointServiceConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVpcEndpointServiceConfigurationsResponseUnmarshaller.Instance;

            return Invoke<DescribeVpcEndpointServiceConfigurationsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVpcEndpointServiceConfigurations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcEndpointServiceConfigurations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcEndpointServiceConfigurations">REST API Reference for DescribeVpcEndpointServiceConfigurations Operation</seealso>
        public virtual Task<DescribeVpcEndpointServiceConfigurationsResponse> DescribeVpcEndpointServiceConfigurationsAsync(DescribeVpcEndpointServiceConfigurationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVpcEndpointServiceConfigurationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVpcEndpointServiceConfigurationsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeVpcEndpointServiceConfigurationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeVpcEndpointServicePermissions

        internal virtual DescribeVpcEndpointServicePermissionsResponse DescribeVpcEndpointServicePermissions(DescribeVpcEndpointServicePermissionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVpcEndpointServicePermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVpcEndpointServicePermissionsResponseUnmarshaller.Instance;

            return Invoke<DescribeVpcEndpointServicePermissionsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVpcEndpointServicePermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcEndpointServicePermissions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcEndpointServicePermissions">REST API Reference for DescribeVpcEndpointServicePermissions Operation</seealso>
        public virtual Task<DescribeVpcEndpointServicePermissionsResponse> DescribeVpcEndpointServicePermissionsAsync(DescribeVpcEndpointServicePermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVpcEndpointServicePermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVpcEndpointServicePermissionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeVpcEndpointServicePermissionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeVpcEndpointServices

        internal virtual DescribeVpcEndpointServicesResponse DescribeVpcEndpointServices(DescribeVpcEndpointServicesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVpcEndpointServicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVpcEndpointServicesResponseUnmarshaller.Instance;

            return Invoke<DescribeVpcEndpointServicesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVpcEndpointServices operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcEndpointServices operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcEndpointServices">REST API Reference for DescribeVpcEndpointServices Operation</seealso>
        public virtual Task<DescribeVpcEndpointServicesResponse> DescribeVpcEndpointServicesAsync(DescribeVpcEndpointServicesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVpcEndpointServicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVpcEndpointServicesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeVpcEndpointServicesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeVpcPeeringConnections

        internal virtual DescribeVpcPeeringConnectionsResponse DescribeVpcPeeringConnections()
        {
            return DescribeVpcPeeringConnections(new DescribeVpcPeeringConnectionsRequest());
        }
        internal virtual DescribeVpcPeeringConnectionsResponse DescribeVpcPeeringConnections(DescribeVpcPeeringConnectionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVpcPeeringConnectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVpcPeeringConnectionsResponseUnmarshaller.Instance;

            return Invoke<DescribeVpcPeeringConnectionsResponse>(request, options);
        }


        /// <summary>
        /// Describes one or more of your VPC peering connections.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeVpcPeeringConnections service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcPeeringConnections">REST API Reference for DescribeVpcPeeringConnections Operation</seealso>
        public virtual Task<DescribeVpcPeeringConnectionsResponse> DescribeVpcPeeringConnectionsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeVpcPeeringConnectionsAsync(new DescribeVpcPeeringConnectionsRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVpcPeeringConnections operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcPeeringConnections operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcPeeringConnections">REST API Reference for DescribeVpcPeeringConnections Operation</seealso>
        public virtual Task<DescribeVpcPeeringConnectionsResponse> DescribeVpcPeeringConnectionsAsync(DescribeVpcPeeringConnectionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVpcPeeringConnectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVpcPeeringConnectionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeVpcPeeringConnectionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeVpcs

        internal virtual DescribeVpcsResponse DescribeVpcs()
        {
            return DescribeVpcs(new DescribeVpcsRequest());
        }
        internal virtual DescribeVpcsResponse DescribeVpcs(DescribeVpcsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVpcsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVpcsResponseUnmarshaller.Instance;

            return Invoke<DescribeVpcsResponse>(request, options);
        }


        /// <summary>
        /// Describes one or more of your VPCs.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeVpcs service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcs">REST API Reference for DescribeVpcs Operation</seealso>
        public virtual Task<DescribeVpcsResponse> DescribeVpcsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeVpcsAsync(new DescribeVpcsRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVpcs operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpcs operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpcs">REST API Reference for DescribeVpcs Operation</seealso>
        public virtual Task<DescribeVpcsResponse> DescribeVpcsAsync(DescribeVpcsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVpcsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVpcsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeVpcsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeVpnConnections

        internal virtual DescribeVpnConnectionsResponse DescribeVpnConnections()
        {
            return DescribeVpnConnections(new DescribeVpnConnectionsRequest());
        }
        internal virtual DescribeVpnConnectionsResponse DescribeVpnConnections(DescribeVpnConnectionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVpnConnectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVpnConnectionsResponseUnmarshaller.Instance;

            return Invoke<DescribeVpnConnectionsResponse>(request, options);
        }


        /// <summary>
        /// Describes one or more of your VPN connections.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/vpn/latest/s2svpn/VPC_VPN.html">AWS
        /// Site-to-Site VPN</a> in the <i>AWS Site-to-Site VPN User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeVpnConnections service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpnConnections">REST API Reference for DescribeVpnConnections Operation</seealso>
        public virtual Task<DescribeVpnConnectionsResponse> DescribeVpnConnectionsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeVpnConnectionsAsync(new DescribeVpnConnectionsRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVpnConnections operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpnConnections operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpnConnections">REST API Reference for DescribeVpnConnections Operation</seealso>
        public virtual Task<DescribeVpnConnectionsResponse> DescribeVpnConnectionsAsync(DescribeVpnConnectionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVpnConnectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVpnConnectionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeVpnConnectionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeVpnGateways

        internal virtual DescribeVpnGatewaysResponse DescribeVpnGateways()
        {
            return DescribeVpnGateways(new DescribeVpnGatewaysRequest());
        }
        internal virtual DescribeVpnGatewaysResponse DescribeVpnGateways(DescribeVpnGatewaysRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVpnGatewaysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVpnGatewaysResponseUnmarshaller.Instance;

            return Invoke<DescribeVpnGatewaysResponse>(request, options);
        }


        /// <summary>
        /// Describes one or more of your virtual private gateways.
        /// 
        ///  
        /// <para>
        /// For more information, see <a href="https://docs.aws.amazon.com/vpn/latest/s2svpn/VPC_VPN.html">AWS
        /// Site-to-Site VPN</a> in the <i>AWS Site-to-Site VPN User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeVpnGateways service method, as returned by EC2.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpnGateways">REST API Reference for DescribeVpnGateways Operation</seealso>
        public virtual Task<DescribeVpnGatewaysResponse> DescribeVpnGatewaysAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeVpnGatewaysAsync(new DescribeVpnGatewaysRequest(), cancellationToken);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVpnGateways operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVpnGateways operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DescribeVpnGateways">REST API Reference for DescribeVpnGateways Operation</seealso>
        public virtual Task<DescribeVpnGatewaysResponse> DescribeVpnGatewaysAsync(DescribeVpnGatewaysRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVpnGatewaysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVpnGatewaysResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeVpnGatewaysResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DetachClassicLinkVpc

        internal virtual DetachClassicLinkVpcResponse DetachClassicLinkVpc(DetachClassicLinkVpcRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetachClassicLinkVpcRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachClassicLinkVpcResponseUnmarshaller.Instance;

            return Invoke<DetachClassicLinkVpcResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DetachClassicLinkVpc operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachClassicLinkVpc operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DetachClassicLinkVpc">REST API Reference for DetachClassicLinkVpc Operation</seealso>
        public virtual Task<DetachClassicLinkVpcResponse> DetachClassicLinkVpcAsync(DetachClassicLinkVpcRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetachClassicLinkVpcRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachClassicLinkVpcResponseUnmarshaller.Instance;

            return InvokeAsync<DetachClassicLinkVpcResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DetachInternetGateway

        internal virtual DetachInternetGatewayResponse DetachInternetGateway(DetachInternetGatewayRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetachInternetGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachInternetGatewayResponseUnmarshaller.Instance;

            return Invoke<DetachInternetGatewayResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DetachInternetGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachInternetGateway operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DetachInternetGateway">REST API Reference for DetachInternetGateway Operation</seealso>
        public virtual Task<DetachInternetGatewayResponse> DetachInternetGatewayAsync(DetachInternetGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetachInternetGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachInternetGatewayResponseUnmarshaller.Instance;

            return InvokeAsync<DetachInternetGatewayResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DetachNetworkInterface

        internal virtual DetachNetworkInterfaceResponse DetachNetworkInterface(DetachNetworkInterfaceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetachNetworkInterfaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachNetworkInterfaceResponseUnmarshaller.Instance;

            return Invoke<DetachNetworkInterfaceResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DetachNetworkInterface operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachNetworkInterface operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DetachNetworkInterface">REST API Reference for DetachNetworkInterface Operation</seealso>
        public virtual Task<DetachNetworkInterfaceResponse> DetachNetworkInterfaceAsync(DetachNetworkInterfaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetachNetworkInterfaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachNetworkInterfaceResponseUnmarshaller.Instance;

            return InvokeAsync<DetachNetworkInterfaceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DetachVolume

        internal virtual DetachVolumeResponse DetachVolume(DetachVolumeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetachVolumeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachVolumeResponseUnmarshaller.Instance;

            return Invoke<DetachVolumeResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DetachVolume operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachVolume operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DetachVolume">REST API Reference for DetachVolume Operation</seealso>
        public virtual Task<DetachVolumeResponse> DetachVolumeAsync(DetachVolumeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetachVolumeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachVolumeResponseUnmarshaller.Instance;

            return InvokeAsync<DetachVolumeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DetachVpnGateway

        internal virtual DetachVpnGatewayResponse DetachVpnGateway(DetachVpnGatewayRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetachVpnGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachVpnGatewayResponseUnmarshaller.Instance;

            return Invoke<DetachVpnGatewayResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DetachVpnGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DetachVpnGateway operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DetachVpnGateway">REST API Reference for DetachVpnGateway Operation</seealso>
        public virtual Task<DetachVpnGatewayResponse> DetachVpnGatewayAsync(DetachVpnGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DetachVpnGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DetachVpnGatewayResponseUnmarshaller.Instance;

            return InvokeAsync<DetachVpnGatewayResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisableTransitGatewayRouteTablePropagation

        internal virtual DisableTransitGatewayRouteTablePropagationResponse DisableTransitGatewayRouteTablePropagation(DisableTransitGatewayRouteTablePropagationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableTransitGatewayRouteTablePropagationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableTransitGatewayRouteTablePropagationResponseUnmarshaller.Instance;

            return Invoke<DisableTransitGatewayRouteTablePropagationResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DisableTransitGatewayRouteTablePropagation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableTransitGatewayRouteTablePropagation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DisableTransitGatewayRouteTablePropagation">REST API Reference for DisableTransitGatewayRouteTablePropagation Operation</seealso>
        public virtual Task<DisableTransitGatewayRouteTablePropagationResponse> DisableTransitGatewayRouteTablePropagationAsync(DisableTransitGatewayRouteTablePropagationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableTransitGatewayRouteTablePropagationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableTransitGatewayRouteTablePropagationResponseUnmarshaller.Instance;

            return InvokeAsync<DisableTransitGatewayRouteTablePropagationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisableVgwRoutePropagation

        internal virtual DisableVgwRoutePropagationResponse DisableVgwRoutePropagation(DisableVgwRoutePropagationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableVgwRoutePropagationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableVgwRoutePropagationResponseUnmarshaller.Instance;

            return Invoke<DisableVgwRoutePropagationResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DisableVgwRoutePropagation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableVgwRoutePropagation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DisableVgwRoutePropagation">REST API Reference for DisableVgwRoutePropagation Operation</seealso>
        public virtual Task<DisableVgwRoutePropagationResponse> DisableVgwRoutePropagationAsync(DisableVgwRoutePropagationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableVgwRoutePropagationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableVgwRoutePropagationResponseUnmarshaller.Instance;

            return InvokeAsync<DisableVgwRoutePropagationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisableVpcClassicLink

        internal virtual DisableVpcClassicLinkResponse DisableVpcClassicLink(DisableVpcClassicLinkRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableVpcClassicLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableVpcClassicLinkResponseUnmarshaller.Instance;

            return Invoke<DisableVpcClassicLinkResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DisableVpcClassicLink operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableVpcClassicLink operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DisableVpcClassicLink">REST API Reference for DisableVpcClassicLink Operation</seealso>
        public virtual Task<DisableVpcClassicLinkResponse> DisableVpcClassicLinkAsync(DisableVpcClassicLinkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableVpcClassicLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableVpcClassicLinkResponseUnmarshaller.Instance;

            return InvokeAsync<DisableVpcClassicLinkResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisableVpcClassicLinkDnsSupport

        internal virtual DisableVpcClassicLinkDnsSupportResponse DisableVpcClassicLinkDnsSupport(DisableVpcClassicLinkDnsSupportRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableVpcClassicLinkDnsSupportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableVpcClassicLinkDnsSupportResponseUnmarshaller.Instance;

            return Invoke<DisableVpcClassicLinkDnsSupportResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DisableVpcClassicLinkDnsSupport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisableVpcClassicLinkDnsSupport operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DisableVpcClassicLinkDnsSupport">REST API Reference for DisableVpcClassicLinkDnsSupport Operation</seealso>
        public virtual Task<DisableVpcClassicLinkDnsSupportResponse> DisableVpcClassicLinkDnsSupportAsync(DisableVpcClassicLinkDnsSupportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisableVpcClassicLinkDnsSupportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisableVpcClassicLinkDnsSupportResponseUnmarshaller.Instance;

            return InvokeAsync<DisableVpcClassicLinkDnsSupportResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateAddress

        internal virtual DisassociateAddressResponse DisassociateAddress(DisassociateAddressRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateAddressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateAddressResponseUnmarshaller.Instance;

            return Invoke<DisassociateAddressResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateAddress operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateAddress operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DisassociateAddress">REST API Reference for DisassociateAddress Operation</seealso>
        public virtual Task<DisassociateAddressResponse> DisassociateAddressAsync(DisassociateAddressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateAddressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateAddressResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateAddressResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateClientVpnTargetNetwork

        internal virtual DisassociateClientVpnTargetNetworkResponse DisassociateClientVpnTargetNetwork(DisassociateClientVpnTargetNetworkRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateClientVpnTargetNetworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateClientVpnTargetNetworkResponseUnmarshaller.Instance;

            return Invoke<DisassociateClientVpnTargetNetworkResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateClientVpnTargetNetwork operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateClientVpnTargetNetwork operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DisassociateClientVpnTargetNetwork">REST API Reference for DisassociateClientVpnTargetNetwork Operation</seealso>
        public virtual Task<DisassociateClientVpnTargetNetworkResponse> DisassociateClientVpnTargetNetworkAsync(DisassociateClientVpnTargetNetworkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateClientVpnTargetNetworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateClientVpnTargetNetworkResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateClientVpnTargetNetworkResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateIamInstanceProfile

        internal virtual DisassociateIamInstanceProfileResponse DisassociateIamInstanceProfile(DisassociateIamInstanceProfileRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateIamInstanceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateIamInstanceProfileResponseUnmarshaller.Instance;

            return Invoke<DisassociateIamInstanceProfileResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateIamInstanceProfile operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateIamInstanceProfile operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DisassociateIamInstanceProfile">REST API Reference for DisassociateIamInstanceProfile Operation</seealso>
        public virtual Task<DisassociateIamInstanceProfileResponse> DisassociateIamInstanceProfileAsync(DisassociateIamInstanceProfileRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateIamInstanceProfileRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateIamInstanceProfileResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateIamInstanceProfileResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateRouteTable

        internal virtual DisassociateRouteTableResponse DisassociateRouteTable(DisassociateRouteTableRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateRouteTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateRouteTableResponseUnmarshaller.Instance;

            return Invoke<DisassociateRouteTableResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateRouteTable operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateRouteTable operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DisassociateRouteTable">REST API Reference for DisassociateRouteTable Operation</seealso>
        public virtual Task<DisassociateRouteTableResponse> DisassociateRouteTableAsync(DisassociateRouteTableRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateRouteTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateRouteTableResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateRouteTableResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateSubnetCidrBlock

        internal virtual DisassociateSubnetCidrBlockResponse DisassociateSubnetCidrBlock(DisassociateSubnetCidrBlockRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateSubnetCidrBlockRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateSubnetCidrBlockResponseUnmarshaller.Instance;

            return Invoke<DisassociateSubnetCidrBlockResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateSubnetCidrBlock operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateSubnetCidrBlock operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DisassociateSubnetCidrBlock">REST API Reference for DisassociateSubnetCidrBlock Operation</seealso>
        public virtual Task<DisassociateSubnetCidrBlockResponse> DisassociateSubnetCidrBlockAsync(DisassociateSubnetCidrBlockRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateSubnetCidrBlockRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateSubnetCidrBlockResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateSubnetCidrBlockResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateTransitGatewayRouteTable

        internal virtual DisassociateTransitGatewayRouteTableResponse DisassociateTransitGatewayRouteTable(DisassociateTransitGatewayRouteTableRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateTransitGatewayRouteTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateTransitGatewayRouteTableResponseUnmarshaller.Instance;

            return Invoke<DisassociateTransitGatewayRouteTableResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateTransitGatewayRouteTable operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateTransitGatewayRouteTable operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DisassociateTransitGatewayRouteTable">REST API Reference for DisassociateTransitGatewayRouteTable Operation</seealso>
        public virtual Task<DisassociateTransitGatewayRouteTableResponse> DisassociateTransitGatewayRouteTableAsync(DisassociateTransitGatewayRouteTableRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateTransitGatewayRouteTableRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateTransitGatewayRouteTableResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateTransitGatewayRouteTableResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateVpcCidrBlock

        internal virtual DisassociateVpcCidrBlockResponse DisassociateVpcCidrBlock(DisassociateVpcCidrBlockRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateVpcCidrBlockRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateVpcCidrBlockResponseUnmarshaller.Instance;

            return Invoke<DisassociateVpcCidrBlockResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateVpcCidrBlock operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateVpcCidrBlock operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/DisassociateVpcCidrBlock">REST API Reference for DisassociateVpcCidrBlock Operation</seealso>
        public virtual Task<DisassociateVpcCidrBlockResponse> DisassociateVpcCidrBlockAsync(DisassociateVpcCidrBlockRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateVpcCidrBlockRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateVpcCidrBlockResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateVpcCidrBlockResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  EnableTransitGatewayRouteTablePropagation

        internal virtual EnableTransitGatewayRouteTablePropagationResponse EnableTransitGatewayRouteTablePropagation(EnableTransitGatewayRouteTablePropagationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableTransitGatewayRouteTablePropagationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableTransitGatewayRouteTablePropagationResponseUnmarshaller.Instance;

            return Invoke<EnableTransitGatewayRouteTablePropagationResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the EnableTransitGatewayRouteTablePropagation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableTransitGatewayRouteTablePropagation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/EnableTransitGatewayRouteTablePropagation">REST API Reference for EnableTransitGatewayRouteTablePropagation Operation</seealso>
        public virtual Task<EnableTransitGatewayRouteTablePropagationResponse> EnableTransitGatewayRouteTablePropagationAsync(EnableTransitGatewayRouteTablePropagationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableTransitGatewayRouteTablePropagationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableTransitGatewayRouteTablePropagationResponseUnmarshaller.Instance;

            return InvokeAsync<EnableTransitGatewayRouteTablePropagationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  EnableVgwRoutePropagation

        internal virtual EnableVgwRoutePropagationResponse EnableVgwRoutePropagation(EnableVgwRoutePropagationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableVgwRoutePropagationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableVgwRoutePropagationResponseUnmarshaller.Instance;

            return Invoke<EnableVgwRoutePropagationResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the EnableVgwRoutePropagation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableVgwRoutePropagation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/EnableVgwRoutePropagation">REST API Reference for EnableVgwRoutePropagation Operation</seealso>
        public virtual Task<EnableVgwRoutePropagationResponse> EnableVgwRoutePropagationAsync(EnableVgwRoutePropagationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableVgwRoutePropagationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableVgwRoutePropagationResponseUnmarshaller.Instance;

            return InvokeAsync<EnableVgwRoutePropagationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  EnableVolumeIO

        internal virtual EnableVolumeIOResponse EnableVolumeIO(EnableVolumeIORequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableVolumeIORequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableVolumeIOResponseUnmarshaller.Instance;

            return Invoke<EnableVolumeIOResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the EnableVolumeIO operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableVolumeIO operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/EnableVolumeIO">REST API Reference for EnableVolumeIO Operation</seealso>
        public virtual Task<EnableVolumeIOResponse> EnableVolumeIOAsync(EnableVolumeIORequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableVolumeIORequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableVolumeIOResponseUnmarshaller.Instance;

            return InvokeAsync<EnableVolumeIOResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  EnableVpcClassicLink

        internal virtual EnableVpcClassicLinkResponse EnableVpcClassicLink(EnableVpcClassicLinkRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableVpcClassicLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableVpcClassicLinkResponseUnmarshaller.Instance;

            return Invoke<EnableVpcClassicLinkResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the EnableVpcClassicLink operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableVpcClassicLink operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/EnableVpcClassicLink">REST API Reference for EnableVpcClassicLink Operation</seealso>
        public virtual Task<EnableVpcClassicLinkResponse> EnableVpcClassicLinkAsync(EnableVpcClassicLinkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableVpcClassicLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableVpcClassicLinkResponseUnmarshaller.Instance;

            return InvokeAsync<EnableVpcClassicLinkResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  EnableVpcClassicLinkDnsSupport

        internal virtual EnableVpcClassicLinkDnsSupportResponse EnableVpcClassicLinkDnsSupport(EnableVpcClassicLinkDnsSupportRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableVpcClassicLinkDnsSupportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableVpcClassicLinkDnsSupportResponseUnmarshaller.Instance;

            return Invoke<EnableVpcClassicLinkDnsSupportResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the EnableVpcClassicLinkDnsSupport operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the EnableVpcClassicLinkDnsSupport operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/EnableVpcClassicLinkDnsSupport">REST API Reference for EnableVpcClassicLinkDnsSupport Operation</seealso>
        public virtual Task<EnableVpcClassicLinkDnsSupportResponse> EnableVpcClassicLinkDnsSupportAsync(EnableVpcClassicLinkDnsSupportRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = EnableVpcClassicLinkDnsSupportRequestMarshaller.Instance;
            options.ResponseUnmarshaller = EnableVpcClassicLinkDnsSupportResponseUnmarshaller.Instance;

            return InvokeAsync<EnableVpcClassicLinkDnsSupportResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ExportClientVpnClientCertificateRevocationList

        internal virtual ExportClientVpnClientCertificateRevocationListResponse ExportClientVpnClientCertificateRevocationList(ExportClientVpnClientCertificateRevocationListRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExportClientVpnClientCertificateRevocationListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportClientVpnClientCertificateRevocationListResponseUnmarshaller.Instance;

            return Invoke<ExportClientVpnClientCertificateRevocationListResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ExportClientVpnClientCertificateRevocationList operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ExportClientVpnClientCertificateRevocationList operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ExportClientVpnClientCertificateRevocationList">REST API Reference for ExportClientVpnClientCertificateRevocationList Operation</seealso>
        public virtual Task<ExportClientVpnClientCertificateRevocationListResponse> ExportClientVpnClientCertificateRevocationListAsync(ExportClientVpnClientCertificateRevocationListRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExportClientVpnClientCertificateRevocationListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportClientVpnClientCertificateRevocationListResponseUnmarshaller.Instance;

            return InvokeAsync<ExportClientVpnClientCertificateRevocationListResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ExportClientVpnClientConfiguration

        internal virtual ExportClientVpnClientConfigurationResponse ExportClientVpnClientConfiguration(ExportClientVpnClientConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExportClientVpnClientConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportClientVpnClientConfigurationResponseUnmarshaller.Instance;

            return Invoke<ExportClientVpnClientConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ExportClientVpnClientConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ExportClientVpnClientConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ExportClientVpnClientConfiguration">REST API Reference for ExportClientVpnClientConfiguration Operation</seealso>
        public virtual Task<ExportClientVpnClientConfigurationResponse> ExportClientVpnClientConfigurationAsync(ExportClientVpnClientConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExportClientVpnClientConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportClientVpnClientConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<ExportClientVpnClientConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ExportTransitGatewayRoutes

        internal virtual ExportTransitGatewayRoutesResponse ExportTransitGatewayRoutes(ExportTransitGatewayRoutesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExportTransitGatewayRoutesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportTransitGatewayRoutesResponseUnmarshaller.Instance;

            return Invoke<ExportTransitGatewayRoutesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ExportTransitGatewayRoutes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ExportTransitGatewayRoutes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ExportTransitGatewayRoutes">REST API Reference for ExportTransitGatewayRoutes Operation</seealso>
        public virtual Task<ExportTransitGatewayRoutesResponse> ExportTransitGatewayRoutesAsync(ExportTransitGatewayRoutesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExportTransitGatewayRoutesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExportTransitGatewayRoutesResponseUnmarshaller.Instance;

            return InvokeAsync<ExportTransitGatewayRoutesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetConsoleOutput

        internal virtual GetConsoleOutputResponse GetConsoleOutput(GetConsoleOutputRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetConsoleOutputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConsoleOutputResponseUnmarshaller.Instance;

            return Invoke<GetConsoleOutputResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetConsoleOutput operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetConsoleOutput operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/GetConsoleOutput">REST API Reference for GetConsoleOutput Operation</seealso>
        public virtual Task<GetConsoleOutputResponse> GetConsoleOutputAsync(GetConsoleOutputRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetConsoleOutputRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConsoleOutputResponseUnmarshaller.Instance;

            return InvokeAsync<GetConsoleOutputResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetConsoleScreenshot

        internal virtual GetConsoleScreenshotResponse GetConsoleScreenshot(GetConsoleScreenshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetConsoleScreenshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConsoleScreenshotResponseUnmarshaller.Instance;

            return Invoke<GetConsoleScreenshotResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetConsoleScreenshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetConsoleScreenshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/GetConsoleScreenshot">REST API Reference for GetConsoleScreenshot Operation</seealso>
        public virtual Task<GetConsoleScreenshotResponse> GetConsoleScreenshotAsync(GetConsoleScreenshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetConsoleScreenshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConsoleScreenshotResponseUnmarshaller.Instance;

            return InvokeAsync<GetConsoleScreenshotResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetHostReservationPurchasePreview

        internal virtual GetHostReservationPurchasePreviewResponse GetHostReservationPurchasePreview(GetHostReservationPurchasePreviewRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetHostReservationPurchasePreviewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetHostReservationPurchasePreviewResponseUnmarshaller.Instance;

            return Invoke<GetHostReservationPurchasePreviewResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetHostReservationPurchasePreview operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetHostReservationPurchasePreview operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/GetHostReservationPurchasePreview">REST API Reference for GetHostReservationPurchasePreview Operation</seealso>
        public virtual Task<GetHostReservationPurchasePreviewResponse> GetHostReservationPurchasePreviewAsync(GetHostReservationPurchasePreviewRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetHostReservationPurchasePreviewRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetHostReservationPurchasePreviewResponseUnmarshaller.Instance;

            return InvokeAsync<GetHostReservationPurchasePreviewResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetLaunchTemplateData

        internal virtual GetLaunchTemplateDataResponse GetLaunchTemplateData(GetLaunchTemplateDataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLaunchTemplateDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLaunchTemplateDataResponseUnmarshaller.Instance;

            return Invoke<GetLaunchTemplateDataResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetLaunchTemplateData operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLaunchTemplateData operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/GetLaunchTemplateData">REST API Reference for GetLaunchTemplateData Operation</seealso>
        public virtual Task<GetLaunchTemplateDataResponse> GetLaunchTemplateDataAsync(GetLaunchTemplateDataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLaunchTemplateDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLaunchTemplateDataResponseUnmarshaller.Instance;

            return InvokeAsync<GetLaunchTemplateDataResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetPasswordData

        internal virtual GetPasswordDataResponse GetPasswordData(GetPasswordDataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPasswordDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPasswordDataResponseUnmarshaller.Instance;

            return Invoke<GetPasswordDataResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetPasswordData operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetPasswordData operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/GetPasswordData">REST API Reference for GetPasswordData Operation</seealso>
        public virtual Task<GetPasswordDataResponse> GetPasswordDataAsync(GetPasswordDataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetPasswordDataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetPasswordDataResponseUnmarshaller.Instance;

            return InvokeAsync<GetPasswordDataResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetReservedInstancesExchangeQuote

        internal virtual GetReservedInstancesExchangeQuoteResponse GetReservedInstancesExchangeQuote(GetReservedInstancesExchangeQuoteRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetReservedInstancesExchangeQuoteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetReservedInstancesExchangeQuoteResponseUnmarshaller.Instance;

            return Invoke<GetReservedInstancesExchangeQuoteResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetReservedInstancesExchangeQuote operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetReservedInstancesExchangeQuote operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/GetReservedInstancesExchangeQuote">REST API Reference for GetReservedInstancesExchangeQuote Operation</seealso>
        public virtual Task<GetReservedInstancesExchangeQuoteResponse> GetReservedInstancesExchangeQuoteAsync(GetReservedInstancesExchangeQuoteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetReservedInstancesExchangeQuoteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetReservedInstancesExchangeQuoteResponseUnmarshaller.Instance;

            return InvokeAsync<GetReservedInstancesExchangeQuoteResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetTransitGatewayAttachmentPropagations

        internal virtual GetTransitGatewayAttachmentPropagationsResponse GetTransitGatewayAttachmentPropagations(GetTransitGatewayAttachmentPropagationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTransitGatewayAttachmentPropagationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTransitGatewayAttachmentPropagationsResponseUnmarshaller.Instance;

            return Invoke<GetTransitGatewayAttachmentPropagationsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetTransitGatewayAttachmentPropagations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTransitGatewayAttachmentPropagations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/GetTransitGatewayAttachmentPropagations">REST API Reference for GetTransitGatewayAttachmentPropagations Operation</seealso>
        public virtual Task<GetTransitGatewayAttachmentPropagationsResponse> GetTransitGatewayAttachmentPropagationsAsync(GetTransitGatewayAttachmentPropagationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTransitGatewayAttachmentPropagationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTransitGatewayAttachmentPropagationsResponseUnmarshaller.Instance;

            return InvokeAsync<GetTransitGatewayAttachmentPropagationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetTransitGatewayRouteTableAssociations

        internal virtual GetTransitGatewayRouteTableAssociationsResponse GetTransitGatewayRouteTableAssociations(GetTransitGatewayRouteTableAssociationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTransitGatewayRouteTableAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTransitGatewayRouteTableAssociationsResponseUnmarshaller.Instance;

            return Invoke<GetTransitGatewayRouteTableAssociationsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetTransitGatewayRouteTableAssociations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTransitGatewayRouteTableAssociations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/GetTransitGatewayRouteTableAssociations">REST API Reference for GetTransitGatewayRouteTableAssociations Operation</seealso>
        public virtual Task<GetTransitGatewayRouteTableAssociationsResponse> GetTransitGatewayRouteTableAssociationsAsync(GetTransitGatewayRouteTableAssociationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTransitGatewayRouteTableAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTransitGatewayRouteTableAssociationsResponseUnmarshaller.Instance;

            return InvokeAsync<GetTransitGatewayRouteTableAssociationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetTransitGatewayRouteTablePropagations

        internal virtual GetTransitGatewayRouteTablePropagationsResponse GetTransitGatewayRouteTablePropagations(GetTransitGatewayRouteTablePropagationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTransitGatewayRouteTablePropagationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTransitGatewayRouteTablePropagationsResponseUnmarshaller.Instance;

            return Invoke<GetTransitGatewayRouteTablePropagationsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the GetTransitGatewayRouteTablePropagations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTransitGatewayRouteTablePropagations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/GetTransitGatewayRouteTablePropagations">REST API Reference for GetTransitGatewayRouteTablePropagations Operation</seealso>
        public virtual Task<GetTransitGatewayRouteTablePropagationsResponse> GetTransitGatewayRouteTablePropagationsAsync(GetTransitGatewayRouteTablePropagationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTransitGatewayRouteTablePropagationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTransitGatewayRouteTablePropagationsResponseUnmarshaller.Instance;

            return InvokeAsync<GetTransitGatewayRouteTablePropagationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ImportClientVpnClientCertificateRevocationList

        internal virtual ImportClientVpnClientCertificateRevocationListResponse ImportClientVpnClientCertificateRevocationList(ImportClientVpnClientCertificateRevocationListRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportClientVpnClientCertificateRevocationListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportClientVpnClientCertificateRevocationListResponseUnmarshaller.Instance;

            return Invoke<ImportClientVpnClientCertificateRevocationListResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ImportClientVpnClientCertificateRevocationList operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportClientVpnClientCertificateRevocationList operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ImportClientVpnClientCertificateRevocationList">REST API Reference for ImportClientVpnClientCertificateRevocationList Operation</seealso>
        public virtual Task<ImportClientVpnClientCertificateRevocationListResponse> ImportClientVpnClientCertificateRevocationListAsync(ImportClientVpnClientCertificateRevocationListRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportClientVpnClientCertificateRevocationListRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportClientVpnClientCertificateRevocationListResponseUnmarshaller.Instance;

            return InvokeAsync<ImportClientVpnClientCertificateRevocationListResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ImportImage

        internal virtual ImportImageResponse ImportImage(ImportImageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportImageResponseUnmarshaller.Instance;

            return Invoke<ImportImageResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ImportImage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportImage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ImportImage">REST API Reference for ImportImage Operation</seealso>
        public virtual Task<ImportImageResponse> ImportImageAsync(ImportImageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportImageResponseUnmarshaller.Instance;

            return InvokeAsync<ImportImageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ImportInstance

        internal virtual ImportInstanceResponse ImportInstance(ImportInstanceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportInstanceResponseUnmarshaller.Instance;

            return Invoke<ImportInstanceResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ImportInstance operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportInstance operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ImportInstance">REST API Reference for ImportInstance Operation</seealso>
        public virtual Task<ImportInstanceResponse> ImportInstanceAsync(ImportInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportInstanceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<ImportInstanceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ImportKeyPair

        internal virtual ImportKeyPairResponse ImportKeyPair(ImportKeyPairRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportKeyPairRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportKeyPairResponseUnmarshaller.Instance;

            return Invoke<ImportKeyPairResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ImportKeyPair operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportKeyPair operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ImportKeyPair">REST API Reference for ImportKeyPair Operation</seealso>
        public virtual Task<ImportKeyPairResponse> ImportKeyPairAsync(ImportKeyPairRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportKeyPairRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportKeyPairResponseUnmarshaller.Instance;

            return InvokeAsync<ImportKeyPairResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ImportSnapshot

        internal virtual ImportSnapshotResponse ImportSnapshot(ImportSnapshotRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportSnapshotResponseUnmarshaller.Instance;

            return Invoke<ImportSnapshotResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ImportSnapshot operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportSnapshot operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ImportSnapshot">REST API Reference for ImportSnapshot Operation</seealso>
        public virtual Task<ImportSnapshotResponse> ImportSnapshotAsync(ImportSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportSnapshotRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<ImportSnapshotResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ImportVolume

        internal virtual ImportVolumeResponse ImportVolume(ImportVolumeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportVolumeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportVolumeResponseUnmarshaller.Instance;

            return Invoke<ImportVolumeResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ImportVolume operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ImportVolume operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ImportVolume">REST API Reference for ImportVolume Operation</seealso>
        public virtual Task<ImportVolumeResponse> ImportVolumeAsync(ImportVolumeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ImportVolumeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ImportVolumeResponseUnmarshaller.Instance;

            return InvokeAsync<ImportVolumeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyCapacityReservation

        internal virtual ModifyCapacityReservationResponse ModifyCapacityReservation(ModifyCapacityReservationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyCapacityReservationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyCapacityReservationResponseUnmarshaller.Instance;

            return Invoke<ModifyCapacityReservationResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyCapacityReservation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyCapacityReservation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyCapacityReservation">REST API Reference for ModifyCapacityReservation Operation</seealso>
        public virtual Task<ModifyCapacityReservationResponse> ModifyCapacityReservationAsync(ModifyCapacityReservationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyCapacityReservationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyCapacityReservationResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyCapacityReservationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyClientVpnEndpoint

        internal virtual ModifyClientVpnEndpointResponse ModifyClientVpnEndpoint(ModifyClientVpnEndpointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyClientVpnEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyClientVpnEndpointResponseUnmarshaller.Instance;

            return Invoke<ModifyClientVpnEndpointResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyClientVpnEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyClientVpnEndpoint operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyClientVpnEndpoint">REST API Reference for ModifyClientVpnEndpoint Operation</seealso>
        public virtual Task<ModifyClientVpnEndpointResponse> ModifyClientVpnEndpointAsync(ModifyClientVpnEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyClientVpnEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyClientVpnEndpointResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyClientVpnEndpointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyFleet

        internal virtual ModifyFleetResponse ModifyFleet(ModifyFleetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyFleetResponseUnmarshaller.Instance;

            return Invoke<ModifyFleetResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyFleet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyFleet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyFleet">REST API Reference for ModifyFleet Operation</seealso>
        public virtual Task<ModifyFleetResponse> ModifyFleetAsync(ModifyFleetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyFleetResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyFleetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyFpgaImageAttribute

        internal virtual ModifyFpgaImageAttributeResponse ModifyFpgaImageAttribute(ModifyFpgaImageAttributeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyFpgaImageAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyFpgaImageAttributeResponseUnmarshaller.Instance;

            return Invoke<ModifyFpgaImageAttributeResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyFpgaImageAttribute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyFpgaImageAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyFpgaImageAttribute">REST API Reference for ModifyFpgaImageAttribute Operation</seealso>
        public virtual Task<ModifyFpgaImageAttributeResponse> ModifyFpgaImageAttributeAsync(ModifyFpgaImageAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyFpgaImageAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyFpgaImageAttributeResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyFpgaImageAttributeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyHosts

        internal virtual ModifyHostsResponse ModifyHosts(ModifyHostsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyHostsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyHostsResponseUnmarshaller.Instance;

            return Invoke<ModifyHostsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyHosts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyHosts operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyHosts">REST API Reference for ModifyHosts Operation</seealso>
        public virtual Task<ModifyHostsResponse> ModifyHostsAsync(ModifyHostsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyHostsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyHostsResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyHostsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyIdentityIdFormat

        internal virtual ModifyIdentityIdFormatResponse ModifyIdentityIdFormat(ModifyIdentityIdFormatRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyIdentityIdFormatRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyIdentityIdFormatResponseUnmarshaller.Instance;

            return Invoke<ModifyIdentityIdFormatResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyIdentityIdFormat operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyIdentityIdFormat operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyIdentityIdFormat">REST API Reference for ModifyIdentityIdFormat Operation</seealso>
        public virtual Task<ModifyIdentityIdFormatResponse> ModifyIdentityIdFormatAsync(ModifyIdentityIdFormatRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyIdentityIdFormatRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyIdentityIdFormatResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyIdentityIdFormatResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyIdFormat

        internal virtual ModifyIdFormatResponse ModifyIdFormat(ModifyIdFormatRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyIdFormatRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyIdFormatResponseUnmarshaller.Instance;

            return Invoke<ModifyIdFormatResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyIdFormat operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyIdFormat operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyIdFormat">REST API Reference for ModifyIdFormat Operation</seealso>
        public virtual Task<ModifyIdFormatResponse> ModifyIdFormatAsync(ModifyIdFormatRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyIdFormatRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyIdFormatResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyIdFormatResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyImageAttribute

        internal virtual ModifyImageAttributeResponse ModifyImageAttribute(ModifyImageAttributeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyImageAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyImageAttributeResponseUnmarshaller.Instance;

            return Invoke<ModifyImageAttributeResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyImageAttribute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyImageAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyImageAttribute">REST API Reference for ModifyImageAttribute Operation</seealso>
        public virtual Task<ModifyImageAttributeResponse> ModifyImageAttributeAsync(ModifyImageAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyImageAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyImageAttributeResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyImageAttributeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyInstanceAttribute

        internal virtual ModifyInstanceAttributeResponse ModifyInstanceAttribute(ModifyInstanceAttributeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyInstanceAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyInstanceAttributeResponseUnmarshaller.Instance;

            return Invoke<ModifyInstanceAttributeResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyInstanceAttribute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyInstanceAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyInstanceAttribute">REST API Reference for ModifyInstanceAttribute Operation</seealso>
        public virtual Task<ModifyInstanceAttributeResponse> ModifyInstanceAttributeAsync(ModifyInstanceAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyInstanceAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyInstanceAttributeResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyInstanceAttributeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyInstanceCapacityReservationAttributes

        internal virtual ModifyInstanceCapacityReservationAttributesResponse ModifyInstanceCapacityReservationAttributes(ModifyInstanceCapacityReservationAttributesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyInstanceCapacityReservationAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyInstanceCapacityReservationAttributesResponseUnmarshaller.Instance;

            return Invoke<ModifyInstanceCapacityReservationAttributesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyInstanceCapacityReservationAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyInstanceCapacityReservationAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyInstanceCapacityReservationAttributes">REST API Reference for ModifyInstanceCapacityReservationAttributes Operation</seealso>
        public virtual Task<ModifyInstanceCapacityReservationAttributesResponse> ModifyInstanceCapacityReservationAttributesAsync(ModifyInstanceCapacityReservationAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyInstanceCapacityReservationAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyInstanceCapacityReservationAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyInstanceCapacityReservationAttributesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyInstanceCreditSpecification

        internal virtual ModifyInstanceCreditSpecificationResponse ModifyInstanceCreditSpecification(ModifyInstanceCreditSpecificationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyInstanceCreditSpecificationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyInstanceCreditSpecificationResponseUnmarshaller.Instance;

            return Invoke<ModifyInstanceCreditSpecificationResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyInstanceCreditSpecification operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyInstanceCreditSpecification operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyInstanceCreditSpecification">REST API Reference for ModifyInstanceCreditSpecification Operation</seealso>
        public virtual Task<ModifyInstanceCreditSpecificationResponse> ModifyInstanceCreditSpecificationAsync(ModifyInstanceCreditSpecificationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyInstanceCreditSpecificationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyInstanceCreditSpecificationResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyInstanceCreditSpecificationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyInstanceEventStartTime

        internal virtual ModifyInstanceEventStartTimeResponse ModifyInstanceEventStartTime(ModifyInstanceEventStartTimeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyInstanceEventStartTimeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyInstanceEventStartTimeResponseUnmarshaller.Instance;

            return Invoke<ModifyInstanceEventStartTimeResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyInstanceEventStartTime operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyInstanceEventStartTime operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyInstanceEventStartTime">REST API Reference for ModifyInstanceEventStartTime Operation</seealso>
        public virtual Task<ModifyInstanceEventStartTimeResponse> ModifyInstanceEventStartTimeAsync(ModifyInstanceEventStartTimeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyInstanceEventStartTimeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyInstanceEventStartTimeResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyInstanceEventStartTimeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyInstancePlacement

        internal virtual ModifyInstancePlacementResponse ModifyInstancePlacement(ModifyInstancePlacementRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyInstancePlacementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyInstancePlacementResponseUnmarshaller.Instance;

            return Invoke<ModifyInstancePlacementResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyInstancePlacement operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyInstancePlacement operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyInstancePlacement">REST API Reference for ModifyInstancePlacement Operation</seealso>
        public virtual Task<ModifyInstancePlacementResponse> ModifyInstancePlacementAsync(ModifyInstancePlacementRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyInstancePlacementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyInstancePlacementResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyInstancePlacementResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyLaunchTemplate

        internal virtual ModifyLaunchTemplateResponse ModifyLaunchTemplate(ModifyLaunchTemplateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyLaunchTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyLaunchTemplateResponseUnmarshaller.Instance;

            return Invoke<ModifyLaunchTemplateResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyLaunchTemplate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyLaunchTemplate operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyLaunchTemplate">REST API Reference for ModifyLaunchTemplate Operation</seealso>
        public virtual Task<ModifyLaunchTemplateResponse> ModifyLaunchTemplateAsync(ModifyLaunchTemplateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyLaunchTemplateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyLaunchTemplateResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyLaunchTemplateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyNetworkInterfaceAttribute

        internal virtual ModifyNetworkInterfaceAttributeResponse ModifyNetworkInterfaceAttribute(ModifyNetworkInterfaceAttributeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyNetworkInterfaceAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyNetworkInterfaceAttributeResponseUnmarshaller.Instance;

            return Invoke<ModifyNetworkInterfaceAttributeResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyNetworkInterfaceAttribute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyNetworkInterfaceAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyNetworkInterfaceAttribute">REST API Reference for ModifyNetworkInterfaceAttribute Operation</seealso>
        public virtual Task<ModifyNetworkInterfaceAttributeResponse> ModifyNetworkInterfaceAttributeAsync(ModifyNetworkInterfaceAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyNetworkInterfaceAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyNetworkInterfaceAttributeResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyNetworkInterfaceAttributeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyReservedInstances

        internal virtual ModifyReservedInstancesResponse ModifyReservedInstances(ModifyReservedInstancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyReservedInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyReservedInstancesResponseUnmarshaller.Instance;

            return Invoke<ModifyReservedInstancesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyReservedInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyReservedInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyReservedInstances">REST API Reference for ModifyReservedInstances Operation</seealso>
        public virtual Task<ModifyReservedInstancesResponse> ModifyReservedInstancesAsync(ModifyReservedInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyReservedInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyReservedInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyReservedInstancesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifySnapshotAttribute

        internal virtual ModifySnapshotAttributeResponse ModifySnapshotAttribute(ModifySnapshotAttributeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifySnapshotAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifySnapshotAttributeResponseUnmarshaller.Instance;

            return Invoke<ModifySnapshotAttributeResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ModifySnapshotAttribute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifySnapshotAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifySnapshotAttribute">REST API Reference for ModifySnapshotAttribute Operation</seealso>
        public virtual Task<ModifySnapshotAttributeResponse> ModifySnapshotAttributeAsync(ModifySnapshotAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifySnapshotAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifySnapshotAttributeResponseUnmarshaller.Instance;

            return InvokeAsync<ModifySnapshotAttributeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifySpotFleetRequest

        internal virtual ModifySpotFleetRequestResponse ModifySpotFleetRequest(ModifySpotFleetRequestRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifySpotFleetRequestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifySpotFleetRequestResponseUnmarshaller.Instance;

            return Invoke<ModifySpotFleetRequestResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ModifySpotFleetRequest operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifySpotFleetRequest operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifySpotFleetRequest">REST API Reference for ModifySpotFleetRequest Operation</seealso>
        public virtual Task<ModifySpotFleetRequestResponse> ModifySpotFleetRequestAsync(ModifySpotFleetRequestRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifySpotFleetRequestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifySpotFleetRequestResponseUnmarshaller.Instance;

            return InvokeAsync<ModifySpotFleetRequestResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifySubnetAttribute

        internal virtual ModifySubnetAttributeResponse ModifySubnetAttribute(ModifySubnetAttributeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifySubnetAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifySubnetAttributeResponseUnmarshaller.Instance;

            return Invoke<ModifySubnetAttributeResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ModifySubnetAttribute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifySubnetAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifySubnetAttribute">REST API Reference for ModifySubnetAttribute Operation</seealso>
        public virtual Task<ModifySubnetAttributeResponse> ModifySubnetAttributeAsync(ModifySubnetAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifySubnetAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifySubnetAttributeResponseUnmarshaller.Instance;

            return InvokeAsync<ModifySubnetAttributeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyTransitGatewayVpcAttachment

        internal virtual ModifyTransitGatewayVpcAttachmentResponse ModifyTransitGatewayVpcAttachment(ModifyTransitGatewayVpcAttachmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyTransitGatewayVpcAttachmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyTransitGatewayVpcAttachmentResponseUnmarshaller.Instance;

            return Invoke<ModifyTransitGatewayVpcAttachmentResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyTransitGatewayVpcAttachment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyTransitGatewayVpcAttachment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyTransitGatewayVpcAttachment">REST API Reference for ModifyTransitGatewayVpcAttachment Operation</seealso>
        public virtual Task<ModifyTransitGatewayVpcAttachmentResponse> ModifyTransitGatewayVpcAttachmentAsync(ModifyTransitGatewayVpcAttachmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyTransitGatewayVpcAttachmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyTransitGatewayVpcAttachmentResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyTransitGatewayVpcAttachmentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyVolume

        internal virtual ModifyVolumeResponse ModifyVolume(ModifyVolumeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyVolumeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyVolumeResponseUnmarshaller.Instance;

            return Invoke<ModifyVolumeResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyVolume operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyVolume operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyVolume">REST API Reference for ModifyVolume Operation</seealso>
        public virtual Task<ModifyVolumeResponse> ModifyVolumeAsync(ModifyVolumeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyVolumeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyVolumeResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyVolumeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyVolumeAttribute

        internal virtual ModifyVolumeAttributeResponse ModifyVolumeAttribute(ModifyVolumeAttributeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyVolumeAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyVolumeAttributeResponseUnmarshaller.Instance;

            return Invoke<ModifyVolumeAttributeResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyVolumeAttribute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyVolumeAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyVolumeAttribute">REST API Reference for ModifyVolumeAttribute Operation</seealso>
        public virtual Task<ModifyVolumeAttributeResponse> ModifyVolumeAttributeAsync(ModifyVolumeAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyVolumeAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyVolumeAttributeResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyVolumeAttributeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyVpcAttribute

        internal virtual ModifyVpcAttributeResponse ModifyVpcAttribute(ModifyVpcAttributeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyVpcAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyVpcAttributeResponseUnmarshaller.Instance;

            return Invoke<ModifyVpcAttributeResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyVpcAttribute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyVpcAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyVpcAttribute">REST API Reference for ModifyVpcAttribute Operation</seealso>
        public virtual Task<ModifyVpcAttributeResponse> ModifyVpcAttributeAsync(ModifyVpcAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyVpcAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyVpcAttributeResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyVpcAttributeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyVpcEndpoint

        internal virtual ModifyVpcEndpointResponse ModifyVpcEndpoint(ModifyVpcEndpointRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyVpcEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyVpcEndpointResponseUnmarshaller.Instance;

            return Invoke<ModifyVpcEndpointResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyVpcEndpoint operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyVpcEndpoint operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyVpcEndpoint">REST API Reference for ModifyVpcEndpoint Operation</seealso>
        public virtual Task<ModifyVpcEndpointResponse> ModifyVpcEndpointAsync(ModifyVpcEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyVpcEndpointRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyVpcEndpointResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyVpcEndpointResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyVpcEndpointConnectionNotification

        internal virtual ModifyVpcEndpointConnectionNotificationResponse ModifyVpcEndpointConnectionNotification(ModifyVpcEndpointConnectionNotificationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyVpcEndpointConnectionNotificationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyVpcEndpointConnectionNotificationResponseUnmarshaller.Instance;

            return Invoke<ModifyVpcEndpointConnectionNotificationResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyVpcEndpointConnectionNotification operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyVpcEndpointConnectionNotification operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyVpcEndpointConnectionNotification">REST API Reference for ModifyVpcEndpointConnectionNotification Operation</seealso>
        public virtual Task<ModifyVpcEndpointConnectionNotificationResponse> ModifyVpcEndpointConnectionNotificationAsync(ModifyVpcEndpointConnectionNotificationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyVpcEndpointConnectionNotificationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyVpcEndpointConnectionNotificationResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyVpcEndpointConnectionNotificationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyVpcEndpointServiceConfiguration

        internal virtual ModifyVpcEndpointServiceConfigurationResponse ModifyVpcEndpointServiceConfiguration(ModifyVpcEndpointServiceConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyVpcEndpointServiceConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyVpcEndpointServiceConfigurationResponseUnmarshaller.Instance;

            return Invoke<ModifyVpcEndpointServiceConfigurationResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyVpcEndpointServiceConfiguration operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyVpcEndpointServiceConfiguration operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyVpcEndpointServiceConfiguration">REST API Reference for ModifyVpcEndpointServiceConfiguration Operation</seealso>
        public virtual Task<ModifyVpcEndpointServiceConfigurationResponse> ModifyVpcEndpointServiceConfigurationAsync(ModifyVpcEndpointServiceConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyVpcEndpointServiceConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyVpcEndpointServiceConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyVpcEndpointServiceConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyVpcEndpointServicePermissions

        internal virtual ModifyVpcEndpointServicePermissionsResponse ModifyVpcEndpointServicePermissions(ModifyVpcEndpointServicePermissionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyVpcEndpointServicePermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyVpcEndpointServicePermissionsResponseUnmarshaller.Instance;

            return Invoke<ModifyVpcEndpointServicePermissionsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyVpcEndpointServicePermissions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyVpcEndpointServicePermissions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyVpcEndpointServicePermissions">REST API Reference for ModifyVpcEndpointServicePermissions Operation</seealso>
        public virtual Task<ModifyVpcEndpointServicePermissionsResponse> ModifyVpcEndpointServicePermissionsAsync(ModifyVpcEndpointServicePermissionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyVpcEndpointServicePermissionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyVpcEndpointServicePermissionsResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyVpcEndpointServicePermissionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyVpcPeeringConnectionOptions

        internal virtual ModifyVpcPeeringConnectionOptionsResponse ModifyVpcPeeringConnectionOptions(ModifyVpcPeeringConnectionOptionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyVpcPeeringConnectionOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyVpcPeeringConnectionOptionsResponseUnmarshaller.Instance;

            return Invoke<ModifyVpcPeeringConnectionOptionsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyVpcPeeringConnectionOptions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyVpcPeeringConnectionOptions operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyVpcPeeringConnectionOptions">REST API Reference for ModifyVpcPeeringConnectionOptions Operation</seealso>
        public virtual Task<ModifyVpcPeeringConnectionOptionsResponse> ModifyVpcPeeringConnectionOptionsAsync(ModifyVpcPeeringConnectionOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyVpcPeeringConnectionOptionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyVpcPeeringConnectionOptionsResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyVpcPeeringConnectionOptionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ModifyVpcTenancy

        internal virtual ModifyVpcTenancyResponse ModifyVpcTenancy(ModifyVpcTenancyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyVpcTenancyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyVpcTenancyResponseUnmarshaller.Instance;

            return Invoke<ModifyVpcTenancyResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ModifyVpcTenancy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ModifyVpcTenancy operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ModifyVpcTenancy">REST API Reference for ModifyVpcTenancy Operation</seealso>
        public virtual Task<ModifyVpcTenancyResponse> ModifyVpcTenancyAsync(ModifyVpcTenancyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ModifyVpcTenancyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ModifyVpcTenancyResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyVpcTenancyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  MonitorInstances

        internal virtual MonitorInstancesResponse MonitorInstances(MonitorInstancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = MonitorInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = MonitorInstancesResponseUnmarshaller.Instance;

            return Invoke<MonitorInstancesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the MonitorInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the MonitorInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/MonitorInstances">REST API Reference for MonitorInstances Operation</seealso>
        public virtual Task<MonitorInstancesResponse> MonitorInstancesAsync(MonitorInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = MonitorInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = MonitorInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<MonitorInstancesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  MoveAddressToVpc

        internal virtual MoveAddressToVpcResponse MoveAddressToVpc(MoveAddressToVpcRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = MoveAddressToVpcRequestMarshaller.Instance;
            options.ResponseUnmarshaller = MoveAddressToVpcResponseUnmarshaller.Instance;

            return Invoke<MoveAddressToVpcResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the MoveAddressToVpc operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the MoveAddressToVpc operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/MoveAddressToVpc">REST API Reference for MoveAddressToVpc Operation</seealso>
        public virtual Task<MoveAddressToVpcResponse> MoveAddressToVpcAsync(MoveAddressToVpcRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = MoveAddressToVpcRequestMarshaller.Instance;
            options.ResponseUnmarshaller = MoveAddressToVpcResponseUnmarshaller.Instance;

            return InvokeAsync<MoveAddressToVpcResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ProvisionByoipCidr

        internal virtual ProvisionByoipCidrResponse ProvisionByoipCidr(ProvisionByoipCidrRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ProvisionByoipCidrRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ProvisionByoipCidrResponseUnmarshaller.Instance;

            return Invoke<ProvisionByoipCidrResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ProvisionByoipCidr operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ProvisionByoipCidr operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ProvisionByoipCidr">REST API Reference for ProvisionByoipCidr Operation</seealso>
        public virtual Task<ProvisionByoipCidrResponse> ProvisionByoipCidrAsync(ProvisionByoipCidrRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ProvisionByoipCidrRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ProvisionByoipCidrResponseUnmarshaller.Instance;

            return InvokeAsync<ProvisionByoipCidrResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PurchaseHostReservation

        internal virtual PurchaseHostReservationResponse PurchaseHostReservation(PurchaseHostReservationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PurchaseHostReservationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PurchaseHostReservationResponseUnmarshaller.Instance;

            return Invoke<PurchaseHostReservationResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PurchaseHostReservation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PurchaseHostReservation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/PurchaseHostReservation">REST API Reference for PurchaseHostReservation Operation</seealso>
        public virtual Task<PurchaseHostReservationResponse> PurchaseHostReservationAsync(PurchaseHostReservationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PurchaseHostReservationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PurchaseHostReservationResponseUnmarshaller.Instance;

            return InvokeAsync<PurchaseHostReservationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PurchaseReservedInstancesOffering

        internal virtual PurchaseReservedInstancesOfferingResponse PurchaseReservedInstancesOffering(PurchaseReservedInstancesOfferingRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PurchaseReservedInstancesOfferingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PurchaseReservedInstancesOfferingResponseUnmarshaller.Instance;

            return Invoke<PurchaseReservedInstancesOfferingResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PurchaseReservedInstancesOffering operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PurchaseReservedInstancesOffering operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/PurchaseReservedInstancesOffering">REST API Reference for PurchaseReservedInstancesOffering Operation</seealso>
        public virtual Task<PurchaseReservedInstancesOfferingResponse> PurchaseReservedInstancesOfferingAsync(PurchaseReservedInstancesOfferingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PurchaseReservedInstancesOfferingRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PurchaseReservedInstancesOfferingResponseUnmarshaller.Instance;

            return InvokeAsync<PurchaseReservedInstancesOfferingResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PurchaseScheduledInstances

        internal virtual PurchaseScheduledInstancesResponse PurchaseScheduledInstances(PurchaseScheduledInstancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PurchaseScheduledInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PurchaseScheduledInstancesResponseUnmarshaller.Instance;

            return Invoke<PurchaseScheduledInstancesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the PurchaseScheduledInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PurchaseScheduledInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/PurchaseScheduledInstances">REST API Reference for PurchaseScheduledInstances Operation</seealso>
        public virtual Task<PurchaseScheduledInstancesResponse> PurchaseScheduledInstancesAsync(PurchaseScheduledInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PurchaseScheduledInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PurchaseScheduledInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<PurchaseScheduledInstancesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RebootInstances

        internal virtual RebootInstancesResponse RebootInstances(RebootInstancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RebootInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RebootInstancesResponseUnmarshaller.Instance;

            return Invoke<RebootInstancesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RebootInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RebootInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RebootInstances">REST API Reference for RebootInstances Operation</seealso>
        public virtual Task<RebootInstancesResponse> RebootInstancesAsync(RebootInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RebootInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RebootInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<RebootInstancesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RegisterImage

        internal virtual RegisterImageResponse RegisterImage(RegisterImageRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterImageResponseUnmarshaller.Instance;

            return Invoke<RegisterImageResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RegisterImage operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterImage operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RegisterImage">REST API Reference for RegisterImage Operation</seealso>
        public virtual Task<RegisterImageResponse> RegisterImageAsync(RegisterImageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterImageRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterImageResponseUnmarshaller.Instance;

            return InvokeAsync<RegisterImageResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RejectTransitGatewayVpcAttachment

        internal virtual RejectTransitGatewayVpcAttachmentResponse RejectTransitGatewayVpcAttachment(RejectTransitGatewayVpcAttachmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RejectTransitGatewayVpcAttachmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RejectTransitGatewayVpcAttachmentResponseUnmarshaller.Instance;

            return Invoke<RejectTransitGatewayVpcAttachmentResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RejectTransitGatewayVpcAttachment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RejectTransitGatewayVpcAttachment operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RejectTransitGatewayVpcAttachment">REST API Reference for RejectTransitGatewayVpcAttachment Operation</seealso>
        public virtual Task<RejectTransitGatewayVpcAttachmentResponse> RejectTransitGatewayVpcAttachmentAsync(RejectTransitGatewayVpcAttachmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RejectTransitGatewayVpcAttachmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RejectTransitGatewayVpcAttachmentResponseUnmarshaller.Instance;

            return InvokeAsync<RejectTransitGatewayVpcAttachmentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RejectVpcEndpointConnections

        internal virtual RejectVpcEndpointConnectionsResponse RejectVpcEndpointConnections(RejectVpcEndpointConnectionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RejectVpcEndpointConnectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RejectVpcEndpointConnectionsResponseUnmarshaller.Instance;

            return Invoke<RejectVpcEndpointConnectionsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RejectVpcEndpointConnections operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RejectVpcEndpointConnections operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RejectVpcEndpointConnections">REST API Reference for RejectVpcEndpointConnections Operation</seealso>
        public virtual Task<RejectVpcEndpointConnectionsResponse> RejectVpcEndpointConnectionsAsync(RejectVpcEndpointConnectionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RejectVpcEndpointConnectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RejectVpcEndpointConnectionsResponseUnmarshaller.Instance;

            return InvokeAsync<RejectVpcEndpointConnectionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RejectVpcPeeringConnection

        internal virtual RejectVpcPeeringConnectionResponse RejectVpcPeeringConnection(RejectVpcPeeringConnectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RejectVpcPeeringConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RejectVpcPeeringConnectionResponseUnmarshaller.Instance;

            return Invoke<RejectVpcPeeringConnectionResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RejectVpcPeeringConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RejectVpcPeeringConnection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RejectVpcPeeringConnection">REST API Reference for RejectVpcPeeringConnection Operation</seealso>
        public virtual Task<RejectVpcPeeringConnectionResponse> RejectVpcPeeringConnectionAsync(RejectVpcPeeringConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RejectVpcPeeringConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RejectVpcPeeringConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<RejectVpcPeeringConnectionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ReleaseAddress

        internal virtual ReleaseAddressResponse ReleaseAddress(ReleaseAddressRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ReleaseAddressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReleaseAddressResponseUnmarshaller.Instance;

            return Invoke<ReleaseAddressResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ReleaseAddress operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReleaseAddress operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ReleaseAddress">REST API Reference for ReleaseAddress Operation</seealso>
        public virtual Task<ReleaseAddressResponse> ReleaseAddressAsync(ReleaseAddressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ReleaseAddressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReleaseAddressResponseUnmarshaller.Instance;

            return InvokeAsync<ReleaseAddressResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ReleaseHosts

        internal virtual ReleaseHostsResponse ReleaseHosts(ReleaseHostsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ReleaseHostsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReleaseHostsResponseUnmarshaller.Instance;

            return Invoke<ReleaseHostsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ReleaseHosts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReleaseHosts operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ReleaseHosts">REST API Reference for ReleaseHosts Operation</seealso>
        public virtual Task<ReleaseHostsResponse> ReleaseHostsAsync(ReleaseHostsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ReleaseHostsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReleaseHostsResponseUnmarshaller.Instance;

            return InvokeAsync<ReleaseHostsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ReplaceIamInstanceProfileAssociation

        internal virtual ReplaceIamInstanceProfileAssociationResponse ReplaceIamInstanceProfileAssociation(ReplaceIamInstanceProfileAssociationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ReplaceIamInstanceProfileAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReplaceIamInstanceProfileAssociationResponseUnmarshaller.Instance;

            return Invoke<ReplaceIamInstanceProfileAssociationResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ReplaceIamInstanceProfileAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReplaceIamInstanceProfileAssociation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ReplaceIamInstanceProfileAssociation">REST API Reference for ReplaceIamInstanceProfileAssociation Operation</seealso>
        public virtual Task<ReplaceIamInstanceProfileAssociationResponse> ReplaceIamInstanceProfileAssociationAsync(ReplaceIamInstanceProfileAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ReplaceIamInstanceProfileAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReplaceIamInstanceProfileAssociationResponseUnmarshaller.Instance;

            return InvokeAsync<ReplaceIamInstanceProfileAssociationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ReplaceNetworkAclAssociation

        internal virtual ReplaceNetworkAclAssociationResponse ReplaceNetworkAclAssociation(ReplaceNetworkAclAssociationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ReplaceNetworkAclAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReplaceNetworkAclAssociationResponseUnmarshaller.Instance;

            return Invoke<ReplaceNetworkAclAssociationResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ReplaceNetworkAclAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReplaceNetworkAclAssociation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ReplaceNetworkAclAssociation">REST API Reference for ReplaceNetworkAclAssociation Operation</seealso>
        public virtual Task<ReplaceNetworkAclAssociationResponse> ReplaceNetworkAclAssociationAsync(ReplaceNetworkAclAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ReplaceNetworkAclAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReplaceNetworkAclAssociationResponseUnmarshaller.Instance;

            return InvokeAsync<ReplaceNetworkAclAssociationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ReplaceNetworkAclEntry

        internal virtual ReplaceNetworkAclEntryResponse ReplaceNetworkAclEntry(ReplaceNetworkAclEntryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ReplaceNetworkAclEntryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReplaceNetworkAclEntryResponseUnmarshaller.Instance;

            return Invoke<ReplaceNetworkAclEntryResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ReplaceNetworkAclEntry operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReplaceNetworkAclEntry operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ReplaceNetworkAclEntry">REST API Reference for ReplaceNetworkAclEntry Operation</seealso>
        public virtual Task<ReplaceNetworkAclEntryResponse> ReplaceNetworkAclEntryAsync(ReplaceNetworkAclEntryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ReplaceNetworkAclEntryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReplaceNetworkAclEntryResponseUnmarshaller.Instance;

            return InvokeAsync<ReplaceNetworkAclEntryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ReplaceRoute

        internal virtual ReplaceRouteResponse ReplaceRoute(ReplaceRouteRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ReplaceRouteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReplaceRouteResponseUnmarshaller.Instance;

            return Invoke<ReplaceRouteResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ReplaceRoute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReplaceRoute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ReplaceRoute">REST API Reference for ReplaceRoute Operation</seealso>
        public virtual Task<ReplaceRouteResponse> ReplaceRouteAsync(ReplaceRouteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ReplaceRouteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReplaceRouteResponseUnmarshaller.Instance;

            return InvokeAsync<ReplaceRouteResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ReplaceRouteTableAssociation

        internal virtual ReplaceRouteTableAssociationResponse ReplaceRouteTableAssociation(ReplaceRouteTableAssociationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ReplaceRouteTableAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReplaceRouteTableAssociationResponseUnmarshaller.Instance;

            return Invoke<ReplaceRouteTableAssociationResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ReplaceRouteTableAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReplaceRouteTableAssociation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ReplaceRouteTableAssociation">REST API Reference for ReplaceRouteTableAssociation Operation</seealso>
        public virtual Task<ReplaceRouteTableAssociationResponse> ReplaceRouteTableAssociationAsync(ReplaceRouteTableAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ReplaceRouteTableAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReplaceRouteTableAssociationResponseUnmarshaller.Instance;

            return InvokeAsync<ReplaceRouteTableAssociationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ReplaceTransitGatewayRoute

        internal virtual ReplaceTransitGatewayRouteResponse ReplaceTransitGatewayRoute(ReplaceTransitGatewayRouteRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ReplaceTransitGatewayRouteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReplaceTransitGatewayRouteResponseUnmarshaller.Instance;

            return Invoke<ReplaceTransitGatewayRouteResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ReplaceTransitGatewayRoute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReplaceTransitGatewayRoute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ReplaceTransitGatewayRoute">REST API Reference for ReplaceTransitGatewayRoute Operation</seealso>
        public virtual Task<ReplaceTransitGatewayRouteResponse> ReplaceTransitGatewayRouteAsync(ReplaceTransitGatewayRouteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ReplaceTransitGatewayRouteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReplaceTransitGatewayRouteResponseUnmarshaller.Instance;

            return InvokeAsync<ReplaceTransitGatewayRouteResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ReportInstanceStatus

        internal virtual ReportInstanceStatusResponse ReportInstanceStatus(ReportInstanceStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ReportInstanceStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReportInstanceStatusResponseUnmarshaller.Instance;

            return Invoke<ReportInstanceStatusResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ReportInstanceStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ReportInstanceStatus operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ReportInstanceStatus">REST API Reference for ReportInstanceStatus Operation</seealso>
        public virtual Task<ReportInstanceStatusResponse> ReportInstanceStatusAsync(ReportInstanceStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ReportInstanceStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ReportInstanceStatusResponseUnmarshaller.Instance;

            return InvokeAsync<ReportInstanceStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RequestSpotFleet

        internal virtual RequestSpotFleetResponse RequestSpotFleet(RequestSpotFleetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RequestSpotFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RequestSpotFleetResponseUnmarshaller.Instance;

            return Invoke<RequestSpotFleetResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RequestSpotFleet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RequestSpotFleet operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RequestSpotFleet">REST API Reference for RequestSpotFleet Operation</seealso>
        public virtual Task<RequestSpotFleetResponse> RequestSpotFleetAsync(RequestSpotFleetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RequestSpotFleetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RequestSpotFleetResponseUnmarshaller.Instance;

            return InvokeAsync<RequestSpotFleetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RequestSpotInstances

        internal virtual RequestSpotInstancesResponse RequestSpotInstances(RequestSpotInstancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RequestSpotInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RequestSpotInstancesResponseUnmarshaller.Instance;

            return Invoke<RequestSpotInstancesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RequestSpotInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RequestSpotInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RequestSpotInstances">REST API Reference for RequestSpotInstances Operation</seealso>
        public virtual Task<RequestSpotInstancesResponse> RequestSpotInstancesAsync(RequestSpotInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RequestSpotInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RequestSpotInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<RequestSpotInstancesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ResetFpgaImageAttribute

        internal virtual ResetFpgaImageAttributeResponse ResetFpgaImageAttribute(ResetFpgaImageAttributeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResetFpgaImageAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetFpgaImageAttributeResponseUnmarshaller.Instance;

            return Invoke<ResetFpgaImageAttributeResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ResetFpgaImageAttribute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetFpgaImageAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ResetFpgaImageAttribute">REST API Reference for ResetFpgaImageAttribute Operation</seealso>
        public virtual Task<ResetFpgaImageAttributeResponse> ResetFpgaImageAttributeAsync(ResetFpgaImageAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResetFpgaImageAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetFpgaImageAttributeResponseUnmarshaller.Instance;

            return InvokeAsync<ResetFpgaImageAttributeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ResetImageAttribute

        internal virtual ResetImageAttributeResponse ResetImageAttribute(ResetImageAttributeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResetImageAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetImageAttributeResponseUnmarshaller.Instance;

            return Invoke<ResetImageAttributeResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ResetImageAttribute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetImageAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ResetImageAttribute">REST API Reference for ResetImageAttribute Operation</seealso>
        public virtual Task<ResetImageAttributeResponse> ResetImageAttributeAsync(ResetImageAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResetImageAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetImageAttributeResponseUnmarshaller.Instance;

            return InvokeAsync<ResetImageAttributeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ResetInstanceAttribute

        internal virtual ResetInstanceAttributeResponse ResetInstanceAttribute(ResetInstanceAttributeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResetInstanceAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetInstanceAttributeResponseUnmarshaller.Instance;

            return Invoke<ResetInstanceAttributeResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ResetInstanceAttribute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetInstanceAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ResetInstanceAttribute">REST API Reference for ResetInstanceAttribute Operation</seealso>
        public virtual Task<ResetInstanceAttributeResponse> ResetInstanceAttributeAsync(ResetInstanceAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResetInstanceAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetInstanceAttributeResponseUnmarshaller.Instance;

            return InvokeAsync<ResetInstanceAttributeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ResetNetworkInterfaceAttribute

        internal virtual ResetNetworkInterfaceAttributeResponse ResetNetworkInterfaceAttribute(ResetNetworkInterfaceAttributeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResetNetworkInterfaceAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetNetworkInterfaceAttributeResponseUnmarshaller.Instance;

            return Invoke<ResetNetworkInterfaceAttributeResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ResetNetworkInterfaceAttribute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetNetworkInterfaceAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ResetNetworkInterfaceAttribute">REST API Reference for ResetNetworkInterfaceAttribute Operation</seealso>
        public virtual Task<ResetNetworkInterfaceAttributeResponse> ResetNetworkInterfaceAttributeAsync(ResetNetworkInterfaceAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResetNetworkInterfaceAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetNetworkInterfaceAttributeResponseUnmarshaller.Instance;

            return InvokeAsync<ResetNetworkInterfaceAttributeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ResetSnapshotAttribute

        internal virtual ResetSnapshotAttributeResponse ResetSnapshotAttribute(ResetSnapshotAttributeRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResetSnapshotAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetSnapshotAttributeResponseUnmarshaller.Instance;

            return Invoke<ResetSnapshotAttributeResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the ResetSnapshotAttribute operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ResetSnapshotAttribute operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/ResetSnapshotAttribute">REST API Reference for ResetSnapshotAttribute Operation</seealso>
        public virtual Task<ResetSnapshotAttributeResponse> ResetSnapshotAttributeAsync(ResetSnapshotAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ResetSnapshotAttributeRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ResetSnapshotAttributeResponseUnmarshaller.Instance;

            return InvokeAsync<ResetSnapshotAttributeResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RestoreAddressToClassic

        internal virtual RestoreAddressToClassicResponse RestoreAddressToClassic(RestoreAddressToClassicRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RestoreAddressToClassicRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreAddressToClassicResponseUnmarshaller.Instance;

            return Invoke<RestoreAddressToClassicResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RestoreAddressToClassic operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RestoreAddressToClassic operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RestoreAddressToClassic">REST API Reference for RestoreAddressToClassic Operation</seealso>
        public virtual Task<RestoreAddressToClassicResponse> RestoreAddressToClassicAsync(RestoreAddressToClassicRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RestoreAddressToClassicRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreAddressToClassicResponseUnmarshaller.Instance;

            return InvokeAsync<RestoreAddressToClassicResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RevokeClientVpnIngress

        internal virtual RevokeClientVpnIngressResponse RevokeClientVpnIngress(RevokeClientVpnIngressRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RevokeClientVpnIngressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RevokeClientVpnIngressResponseUnmarshaller.Instance;

            return Invoke<RevokeClientVpnIngressResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RevokeClientVpnIngress operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RevokeClientVpnIngress operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RevokeClientVpnIngress">REST API Reference for RevokeClientVpnIngress Operation</seealso>
        public virtual Task<RevokeClientVpnIngressResponse> RevokeClientVpnIngressAsync(RevokeClientVpnIngressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RevokeClientVpnIngressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RevokeClientVpnIngressResponseUnmarshaller.Instance;

            return InvokeAsync<RevokeClientVpnIngressResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RevokeSecurityGroupEgress

        internal virtual RevokeSecurityGroupEgressResponse RevokeSecurityGroupEgress(RevokeSecurityGroupEgressRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RevokeSecurityGroupEgressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RevokeSecurityGroupEgressResponseUnmarshaller.Instance;

            return Invoke<RevokeSecurityGroupEgressResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RevokeSecurityGroupEgress operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RevokeSecurityGroupEgress operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RevokeSecurityGroupEgress">REST API Reference for RevokeSecurityGroupEgress Operation</seealso>
        public virtual Task<RevokeSecurityGroupEgressResponse> RevokeSecurityGroupEgressAsync(RevokeSecurityGroupEgressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RevokeSecurityGroupEgressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RevokeSecurityGroupEgressResponseUnmarshaller.Instance;

            return InvokeAsync<RevokeSecurityGroupEgressResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RevokeSecurityGroupIngress

        internal virtual RevokeSecurityGroupIngressResponse RevokeSecurityGroupIngress(RevokeSecurityGroupIngressRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RevokeSecurityGroupIngressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RevokeSecurityGroupIngressResponseUnmarshaller.Instance;

            return Invoke<RevokeSecurityGroupIngressResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RevokeSecurityGroupIngress operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RevokeSecurityGroupIngress operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RevokeSecurityGroupIngress">REST API Reference for RevokeSecurityGroupIngress Operation</seealso>
        public virtual Task<RevokeSecurityGroupIngressResponse> RevokeSecurityGroupIngressAsync(RevokeSecurityGroupIngressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RevokeSecurityGroupIngressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RevokeSecurityGroupIngressResponseUnmarshaller.Instance;

            return InvokeAsync<RevokeSecurityGroupIngressResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RunInstances

        internal virtual RunInstancesResponse RunInstances(RunInstancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RunInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RunInstancesResponseUnmarshaller.Instance;

            return Invoke<RunInstancesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RunInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RunInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RunInstances">REST API Reference for RunInstances Operation</seealso>
        public virtual Task<RunInstancesResponse> RunInstancesAsync(RunInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RunInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RunInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<RunInstancesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RunScheduledInstances

        internal virtual RunScheduledInstancesResponse RunScheduledInstances(RunScheduledInstancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RunScheduledInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RunScheduledInstancesResponseUnmarshaller.Instance;

            return Invoke<RunScheduledInstancesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the RunScheduledInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RunScheduledInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/RunScheduledInstances">REST API Reference for RunScheduledInstances Operation</seealso>
        public virtual Task<RunScheduledInstancesResponse> RunScheduledInstancesAsync(RunScheduledInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RunScheduledInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RunScheduledInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<RunScheduledInstancesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  SearchTransitGatewayRoutes

        internal virtual SearchTransitGatewayRoutesResponse SearchTransitGatewayRoutes(SearchTransitGatewayRoutesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchTransitGatewayRoutesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchTransitGatewayRoutesResponseUnmarshaller.Instance;

            return Invoke<SearchTransitGatewayRoutesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the SearchTransitGatewayRoutes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the SearchTransitGatewayRoutes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/SearchTransitGatewayRoutes">REST API Reference for SearchTransitGatewayRoutes Operation</seealso>
        public virtual Task<SearchTransitGatewayRoutesResponse> SearchTransitGatewayRoutesAsync(SearchTransitGatewayRoutesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = SearchTransitGatewayRoutesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = SearchTransitGatewayRoutesResponseUnmarshaller.Instance;

            return InvokeAsync<SearchTransitGatewayRoutesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartInstances

        internal virtual StartInstancesResponse StartInstances(StartInstancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartInstancesResponseUnmarshaller.Instance;

            return Invoke<StartInstancesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the StartInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/StartInstances">REST API Reference for StartInstances Operation</seealso>
        public virtual Task<StartInstancesResponse> StartInstancesAsync(StartInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<StartInstancesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopInstances

        internal virtual StopInstancesResponse StopInstances(StopInstancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopInstancesResponseUnmarshaller.Instance;

            return Invoke<StopInstancesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the StopInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StopInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/StopInstances">REST API Reference for StopInstances Operation</seealso>
        public virtual Task<StopInstancesResponse> StopInstancesAsync(StopInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<StopInstancesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TerminateClientVpnConnections

        internal virtual TerminateClientVpnConnectionsResponse TerminateClientVpnConnections(TerminateClientVpnConnectionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TerminateClientVpnConnectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TerminateClientVpnConnectionsResponseUnmarshaller.Instance;

            return Invoke<TerminateClientVpnConnectionsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the TerminateClientVpnConnections operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TerminateClientVpnConnections operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/TerminateClientVpnConnections">REST API Reference for TerminateClientVpnConnections Operation</seealso>
        public virtual Task<TerminateClientVpnConnectionsResponse> TerminateClientVpnConnectionsAsync(TerminateClientVpnConnectionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TerminateClientVpnConnectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TerminateClientVpnConnectionsResponseUnmarshaller.Instance;

            return InvokeAsync<TerminateClientVpnConnectionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TerminateInstances

        internal virtual TerminateInstancesResponse TerminateInstances(TerminateInstancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TerminateInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TerminateInstancesResponseUnmarshaller.Instance;

            return Invoke<TerminateInstancesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the TerminateInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TerminateInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/TerminateInstances">REST API Reference for TerminateInstances Operation</seealso>
        public virtual Task<TerminateInstancesResponse> TerminateInstancesAsync(TerminateInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TerminateInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TerminateInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<TerminateInstancesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UnassignIpv6Addresses

        internal virtual UnassignIpv6AddressesResponse UnassignIpv6Addresses(UnassignIpv6AddressesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UnassignIpv6AddressesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UnassignIpv6AddressesResponseUnmarshaller.Instance;

            return Invoke<UnassignIpv6AddressesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UnassignIpv6Addresses operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UnassignIpv6Addresses operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/UnassignIpv6Addresses">REST API Reference for UnassignIpv6Addresses Operation</seealso>
        public virtual Task<UnassignIpv6AddressesResponse> UnassignIpv6AddressesAsync(UnassignIpv6AddressesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UnassignIpv6AddressesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UnassignIpv6AddressesResponseUnmarshaller.Instance;

            return InvokeAsync<UnassignIpv6AddressesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UnassignPrivateIpAddresses

        internal virtual UnassignPrivateIpAddressesResponse UnassignPrivateIpAddresses(UnassignPrivateIpAddressesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UnassignPrivateIpAddressesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UnassignPrivateIpAddressesResponseUnmarshaller.Instance;

            return Invoke<UnassignPrivateIpAddressesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UnassignPrivateIpAddresses operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UnassignPrivateIpAddresses operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/UnassignPrivateIpAddresses">REST API Reference for UnassignPrivateIpAddresses Operation</seealso>
        public virtual Task<UnassignPrivateIpAddressesResponse> UnassignPrivateIpAddressesAsync(UnassignPrivateIpAddressesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UnassignPrivateIpAddressesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UnassignPrivateIpAddressesResponseUnmarshaller.Instance;

            return InvokeAsync<UnassignPrivateIpAddressesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UnmonitorInstances

        internal virtual UnmonitorInstancesResponse UnmonitorInstances(UnmonitorInstancesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UnmonitorInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UnmonitorInstancesResponseUnmarshaller.Instance;

            return Invoke<UnmonitorInstancesResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UnmonitorInstances operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UnmonitorInstances operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/UnmonitorInstances">REST API Reference for UnmonitorInstances Operation</seealso>
        public virtual Task<UnmonitorInstancesResponse> UnmonitorInstancesAsync(UnmonitorInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UnmonitorInstancesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UnmonitorInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<UnmonitorInstancesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateSecurityGroupRuleDescriptionsEgress

        internal virtual UpdateSecurityGroupRuleDescriptionsEgressResponse UpdateSecurityGroupRuleDescriptionsEgress(UpdateSecurityGroupRuleDescriptionsEgressRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSecurityGroupRuleDescriptionsEgressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSecurityGroupRuleDescriptionsEgressResponseUnmarshaller.Instance;

            return Invoke<UpdateSecurityGroupRuleDescriptionsEgressResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSecurityGroupRuleDescriptionsEgress operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSecurityGroupRuleDescriptionsEgress operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/UpdateSecurityGroupRuleDescriptionsEgress">REST API Reference for UpdateSecurityGroupRuleDescriptionsEgress Operation</seealso>
        public virtual Task<UpdateSecurityGroupRuleDescriptionsEgressResponse> UpdateSecurityGroupRuleDescriptionsEgressAsync(UpdateSecurityGroupRuleDescriptionsEgressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSecurityGroupRuleDescriptionsEgressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSecurityGroupRuleDescriptionsEgressResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateSecurityGroupRuleDescriptionsEgressResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateSecurityGroupRuleDescriptionsIngress

        internal virtual UpdateSecurityGroupRuleDescriptionsIngressResponse UpdateSecurityGroupRuleDescriptionsIngress(UpdateSecurityGroupRuleDescriptionsIngressRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSecurityGroupRuleDescriptionsIngressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSecurityGroupRuleDescriptionsIngressResponseUnmarshaller.Instance;

            return Invoke<UpdateSecurityGroupRuleDescriptionsIngressResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSecurityGroupRuleDescriptionsIngress operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSecurityGroupRuleDescriptionsIngress operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/UpdateSecurityGroupRuleDescriptionsIngress">REST API Reference for UpdateSecurityGroupRuleDescriptionsIngress Operation</seealso>
        public virtual Task<UpdateSecurityGroupRuleDescriptionsIngressResponse> UpdateSecurityGroupRuleDescriptionsIngressAsync(UpdateSecurityGroupRuleDescriptionsIngressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSecurityGroupRuleDescriptionsIngressRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSecurityGroupRuleDescriptionsIngressResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateSecurityGroupRuleDescriptionsIngressResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  WithdrawByoipCidr

        internal virtual WithdrawByoipCidrResponse WithdrawByoipCidr(WithdrawByoipCidrRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = WithdrawByoipCidrRequestMarshaller.Instance;
            options.ResponseUnmarshaller = WithdrawByoipCidrResponseUnmarshaller.Instance;

            return Invoke<WithdrawByoipCidrResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the WithdrawByoipCidr operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the WithdrawByoipCidr operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/ec2-2016-11-15/WithdrawByoipCidr">REST API Reference for WithdrawByoipCidr Operation</seealso>
        public virtual Task<WithdrawByoipCidrResponse> WithdrawByoipCidrAsync(WithdrawByoipCidrRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = WithdrawByoipCidrRequestMarshaller.Instance;
            options.ResponseUnmarshaller = WithdrawByoipCidrResponseUnmarshaller.Instance;

            return InvokeAsync<WithdrawByoipCidrResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}