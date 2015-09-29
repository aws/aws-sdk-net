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
 * Do not modify this file. This file is generated from the ec2-2015-10-01.normal.json service model.
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

        
        #region  AcceptVpcPeeringConnection

        internal AcceptVpcPeeringConnectionResponse AcceptVpcPeeringConnection(AcceptVpcPeeringConnectionRequest request)
        {
            var marshaller = new AcceptVpcPeeringConnectionRequestMarshaller();
            var unmarshaller = AcceptVpcPeeringConnectionResponseUnmarshaller.Instance;

            return Invoke<AcceptVpcPeeringConnectionRequest,AcceptVpcPeeringConnectionResponse>(request, marshaller, unmarshaller);
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
        public Task<AcceptVpcPeeringConnectionResponse> AcceptVpcPeeringConnectionAsync(AcceptVpcPeeringConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AcceptVpcPeeringConnectionRequestMarshaller();
            var unmarshaller = AcceptVpcPeeringConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<AcceptVpcPeeringConnectionRequest,AcceptVpcPeeringConnectionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  AllocateAddress

        internal AllocateAddressResponse AllocateAddress()
        {
            return AllocateAddress(new AllocateAddressRequest());
        }
        internal AllocateAddressResponse AllocateAddress(AllocateAddressRequest request)
        {
            var marshaller = new AllocateAddressRequestMarshaller();
            var unmarshaller = AllocateAddressResponseUnmarshaller.Instance;

            return Invoke<AllocateAddressRequest,AllocateAddressResponse>(request, marshaller, unmarshaller);
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
        /// <param name="cancellationToken"> ttd1
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AllocateAddress service method, as returned by EC2.</returns>
        public Task<AllocateAddressResponse> AllocateAddressAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        public Task<AllocateAddressResponse> AllocateAddressAsync(AllocateAddressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AllocateAddressRequestMarshaller();
            var unmarshaller = AllocateAddressResponseUnmarshaller.Instance;

            return InvokeAsync<AllocateAddressRequest,AllocateAddressResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  AssignPrivateIpAddresses

        internal AssignPrivateIpAddressesResponse AssignPrivateIpAddresses(AssignPrivateIpAddressesRequest request)
        {
            var marshaller = new AssignPrivateIpAddressesRequestMarshaller();
            var unmarshaller = AssignPrivateIpAddressesResponseUnmarshaller.Instance;

            return Invoke<AssignPrivateIpAddressesRequest,AssignPrivateIpAddressesResponse>(request, marshaller, unmarshaller);
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
        public Task<AssignPrivateIpAddressesResponse> AssignPrivateIpAddressesAsync(AssignPrivateIpAddressesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AssignPrivateIpAddressesRequestMarshaller();
            var unmarshaller = AssignPrivateIpAddressesResponseUnmarshaller.Instance;

            return InvokeAsync<AssignPrivateIpAddressesRequest,AssignPrivateIpAddressesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  AssociateAddress

        internal AssociateAddressResponse AssociateAddress(AssociateAddressRequest request)
        {
            var marshaller = new AssociateAddressRequestMarshaller();
            var unmarshaller = AssociateAddressResponseUnmarshaller.Instance;

            return Invoke<AssociateAddressRequest,AssociateAddressResponse>(request, marshaller, unmarshaller);
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
        public Task<AssociateAddressResponse> AssociateAddressAsync(AssociateAddressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AssociateAddressRequestMarshaller();
            var unmarshaller = AssociateAddressResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateAddressRequest,AssociateAddressResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  AssociateDhcpOptions

        internal AssociateDhcpOptionsResponse AssociateDhcpOptions(AssociateDhcpOptionsRequest request)
        {
            var marshaller = new AssociateDhcpOptionsRequestMarshaller();
            var unmarshaller = AssociateDhcpOptionsResponseUnmarshaller.Instance;

            return Invoke<AssociateDhcpOptionsRequest,AssociateDhcpOptionsResponse>(request, marshaller, unmarshaller);
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
        public Task<AssociateDhcpOptionsResponse> AssociateDhcpOptionsAsync(AssociateDhcpOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AssociateDhcpOptionsRequestMarshaller();
            var unmarshaller = AssociateDhcpOptionsResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateDhcpOptionsRequest,AssociateDhcpOptionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  AssociateRouteTable

        internal AssociateRouteTableResponse AssociateRouteTable(AssociateRouteTableRequest request)
        {
            var marshaller = new AssociateRouteTableRequestMarshaller();
            var unmarshaller = AssociateRouteTableResponseUnmarshaller.Instance;

            return Invoke<AssociateRouteTableRequest,AssociateRouteTableResponse>(request, marshaller, unmarshaller);
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
        public Task<AssociateRouteTableResponse> AssociateRouteTableAsync(AssociateRouteTableRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AssociateRouteTableRequestMarshaller();
            var unmarshaller = AssociateRouteTableResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateRouteTableRequest,AssociateRouteTableResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  AttachClassicLinkVpc

        internal AttachClassicLinkVpcResponse AttachClassicLinkVpc(AttachClassicLinkVpcRequest request)
        {
            var marshaller = new AttachClassicLinkVpcRequestMarshaller();
            var unmarshaller = AttachClassicLinkVpcResponseUnmarshaller.Instance;

            return Invoke<AttachClassicLinkVpcRequest,AttachClassicLinkVpcResponse>(request, marshaller, unmarshaller);
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
        public Task<AttachClassicLinkVpcResponse> AttachClassicLinkVpcAsync(AttachClassicLinkVpcRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AttachClassicLinkVpcRequestMarshaller();
            var unmarshaller = AttachClassicLinkVpcResponseUnmarshaller.Instance;

            return InvokeAsync<AttachClassicLinkVpcRequest,AttachClassicLinkVpcResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  AttachInternetGateway

        internal AttachInternetGatewayResponse AttachInternetGateway(AttachInternetGatewayRequest request)
        {
            var marshaller = new AttachInternetGatewayRequestMarshaller();
            var unmarshaller = AttachInternetGatewayResponseUnmarshaller.Instance;

            return Invoke<AttachInternetGatewayRequest,AttachInternetGatewayResponse>(request, marshaller, unmarshaller);
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
        public Task<AttachInternetGatewayResponse> AttachInternetGatewayAsync(AttachInternetGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AttachInternetGatewayRequestMarshaller();
            var unmarshaller = AttachInternetGatewayResponseUnmarshaller.Instance;

            return InvokeAsync<AttachInternetGatewayRequest,AttachInternetGatewayResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  AttachNetworkInterface

        internal AttachNetworkInterfaceResponse AttachNetworkInterface(AttachNetworkInterfaceRequest request)
        {
            var marshaller = new AttachNetworkInterfaceRequestMarshaller();
            var unmarshaller = AttachNetworkInterfaceResponseUnmarshaller.Instance;

            return Invoke<AttachNetworkInterfaceRequest,AttachNetworkInterfaceResponse>(request, marshaller, unmarshaller);
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
        public Task<AttachNetworkInterfaceResponse> AttachNetworkInterfaceAsync(AttachNetworkInterfaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AttachNetworkInterfaceRequestMarshaller();
            var unmarshaller = AttachNetworkInterfaceResponseUnmarshaller.Instance;

            return InvokeAsync<AttachNetworkInterfaceRequest,AttachNetworkInterfaceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  AttachVolume

        internal AttachVolumeResponse AttachVolume(AttachVolumeRequest request)
        {
            var marshaller = new AttachVolumeRequestMarshaller();
            var unmarshaller = AttachVolumeResponseUnmarshaller.Instance;

            return Invoke<AttachVolumeRequest,AttachVolumeResponse>(request, marshaller, unmarshaller);
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
        public Task<AttachVolumeResponse> AttachVolumeAsync(AttachVolumeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AttachVolumeRequestMarshaller();
            var unmarshaller = AttachVolumeResponseUnmarshaller.Instance;

            return InvokeAsync<AttachVolumeRequest,AttachVolumeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  AttachVpnGateway

        internal AttachVpnGatewayResponse AttachVpnGateway(AttachVpnGatewayRequest request)
        {
            var marshaller = new AttachVpnGatewayRequestMarshaller();
            var unmarshaller = AttachVpnGatewayResponseUnmarshaller.Instance;

            return Invoke<AttachVpnGatewayRequest,AttachVpnGatewayResponse>(request, marshaller, unmarshaller);
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
        public Task<AttachVpnGatewayResponse> AttachVpnGatewayAsync(AttachVpnGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AttachVpnGatewayRequestMarshaller();
            var unmarshaller = AttachVpnGatewayResponseUnmarshaller.Instance;

            return InvokeAsync<AttachVpnGatewayRequest,AttachVpnGatewayResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  AuthorizeSecurityGroupEgress

        internal AuthorizeSecurityGroupEgressResponse AuthorizeSecurityGroupEgress(AuthorizeSecurityGroupEgressRequest request)
        {
            var marshaller = new AuthorizeSecurityGroupEgressRequestMarshaller();
            var unmarshaller = AuthorizeSecurityGroupEgressResponseUnmarshaller.Instance;

            return Invoke<AuthorizeSecurityGroupEgressRequest,AuthorizeSecurityGroupEgressResponse>(request, marshaller, unmarshaller);
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
        public Task<AuthorizeSecurityGroupEgressResponse> AuthorizeSecurityGroupEgressAsync(AuthorizeSecurityGroupEgressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AuthorizeSecurityGroupEgressRequestMarshaller();
            var unmarshaller = AuthorizeSecurityGroupEgressResponseUnmarshaller.Instance;

            return InvokeAsync<AuthorizeSecurityGroupEgressRequest,AuthorizeSecurityGroupEgressResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  AuthorizeSecurityGroupIngress

        internal AuthorizeSecurityGroupIngressResponse AuthorizeSecurityGroupIngress(AuthorizeSecurityGroupIngressRequest request)
        {
            var marshaller = new AuthorizeSecurityGroupIngressRequestMarshaller();
            var unmarshaller = AuthorizeSecurityGroupIngressResponseUnmarshaller.Instance;

            return Invoke<AuthorizeSecurityGroupIngressRequest,AuthorizeSecurityGroupIngressResponse>(request, marshaller, unmarshaller);
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
        public Task<AuthorizeSecurityGroupIngressResponse> AuthorizeSecurityGroupIngressAsync(AuthorizeSecurityGroupIngressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new AuthorizeSecurityGroupIngressRequestMarshaller();
            var unmarshaller = AuthorizeSecurityGroupIngressResponseUnmarshaller.Instance;

            return InvokeAsync<AuthorizeSecurityGroupIngressRequest,AuthorizeSecurityGroupIngressResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  BundleInstance

        internal BundleInstanceResponse BundleInstance(BundleInstanceRequest request)
        {
            var marshaller = new BundleInstanceRequestMarshaller();
            var unmarshaller = BundleInstanceResponseUnmarshaller.Instance;

            return Invoke<BundleInstanceRequest,BundleInstanceResponse>(request, marshaller, unmarshaller);
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
        public Task<BundleInstanceResponse> BundleInstanceAsync(BundleInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new BundleInstanceRequestMarshaller();
            var unmarshaller = BundleInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<BundleInstanceRequest,BundleInstanceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CancelBundleTask

        internal CancelBundleTaskResponse CancelBundleTask(CancelBundleTaskRequest request)
        {
            var marshaller = new CancelBundleTaskRequestMarshaller();
            var unmarshaller = CancelBundleTaskResponseUnmarshaller.Instance;

            return Invoke<CancelBundleTaskRequest,CancelBundleTaskResponse>(request, marshaller, unmarshaller);
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
        public Task<CancelBundleTaskResponse> CancelBundleTaskAsync(CancelBundleTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CancelBundleTaskRequestMarshaller();
            var unmarshaller = CancelBundleTaskResponseUnmarshaller.Instance;

            return InvokeAsync<CancelBundleTaskRequest,CancelBundleTaskResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CancelConversionTask

        internal CancelConversionTaskResponse CancelConversionTask(CancelConversionTaskRequest request)
        {
            var marshaller = new CancelConversionTaskRequestMarshaller();
            var unmarshaller = CancelConversionTaskResponseUnmarshaller.Instance;

            return Invoke<CancelConversionTaskRequest,CancelConversionTaskResponse>(request, marshaller, unmarshaller);
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
        public Task<CancelConversionTaskResponse> CancelConversionTaskAsync(CancelConversionTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CancelConversionTaskRequestMarshaller();
            var unmarshaller = CancelConversionTaskResponseUnmarshaller.Instance;

            return InvokeAsync<CancelConversionTaskRequest,CancelConversionTaskResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CancelExportTask

        internal CancelExportTaskResponse CancelExportTask(CancelExportTaskRequest request)
        {
            var marshaller = new CancelExportTaskRequestMarshaller();
            var unmarshaller = CancelExportTaskResponseUnmarshaller.Instance;

            return Invoke<CancelExportTaskRequest,CancelExportTaskResponse>(request, marshaller, unmarshaller);
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
        public Task<CancelExportTaskResponse> CancelExportTaskAsync(CancelExportTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CancelExportTaskRequestMarshaller();
            var unmarshaller = CancelExportTaskResponseUnmarshaller.Instance;

            return InvokeAsync<CancelExportTaskRequest,CancelExportTaskResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CancelImportTask

        internal CancelImportTaskResponse CancelImportTask(CancelImportTaskRequest request)
        {
            var marshaller = new CancelImportTaskRequestMarshaller();
            var unmarshaller = CancelImportTaskResponseUnmarshaller.Instance;

            return Invoke<CancelImportTaskRequest,CancelImportTaskResponse>(request, marshaller, unmarshaller);
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
        public Task<CancelImportTaskResponse> CancelImportTaskAsync(CancelImportTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CancelImportTaskRequestMarshaller();
            var unmarshaller = CancelImportTaskResponseUnmarshaller.Instance;

            return InvokeAsync<CancelImportTaskRequest,CancelImportTaskResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CancelReservedInstancesListing

        internal CancelReservedInstancesListingResponse CancelReservedInstancesListing(CancelReservedInstancesListingRequest request)
        {
            var marshaller = new CancelReservedInstancesListingRequestMarshaller();
            var unmarshaller = CancelReservedInstancesListingResponseUnmarshaller.Instance;

            return Invoke<CancelReservedInstancesListingRequest,CancelReservedInstancesListingResponse>(request, marshaller, unmarshaller);
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
        public Task<CancelReservedInstancesListingResponse> CancelReservedInstancesListingAsync(CancelReservedInstancesListingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CancelReservedInstancesListingRequestMarshaller();
            var unmarshaller = CancelReservedInstancesListingResponseUnmarshaller.Instance;

            return InvokeAsync<CancelReservedInstancesListingRequest,CancelReservedInstancesListingResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CancelSpotFleetRequests

        internal CancelSpotFleetRequestsResponse CancelSpotFleetRequests(CancelSpotFleetRequestsRequest request)
        {
            var marshaller = new CancelSpotFleetRequestsRequestMarshaller();
            var unmarshaller = CancelSpotFleetRequestsResponseUnmarshaller.Instance;

            return Invoke<CancelSpotFleetRequestsRequest,CancelSpotFleetRequestsResponse>(request, marshaller, unmarshaller);
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
        public Task<CancelSpotFleetRequestsResponse> CancelSpotFleetRequestsAsync(CancelSpotFleetRequestsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CancelSpotFleetRequestsRequestMarshaller();
            var unmarshaller = CancelSpotFleetRequestsResponseUnmarshaller.Instance;

            return InvokeAsync<CancelSpotFleetRequestsRequest,CancelSpotFleetRequestsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CancelSpotInstanceRequests

        internal CancelSpotInstanceRequestsResponse CancelSpotInstanceRequests(CancelSpotInstanceRequestsRequest request)
        {
            var marshaller = new CancelSpotInstanceRequestsRequestMarshaller();
            var unmarshaller = CancelSpotInstanceRequestsResponseUnmarshaller.Instance;

            return Invoke<CancelSpotInstanceRequestsRequest,CancelSpotInstanceRequestsResponse>(request, marshaller, unmarshaller);
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
        public Task<CancelSpotInstanceRequestsResponse> CancelSpotInstanceRequestsAsync(CancelSpotInstanceRequestsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CancelSpotInstanceRequestsRequestMarshaller();
            var unmarshaller = CancelSpotInstanceRequestsResponseUnmarshaller.Instance;

            return InvokeAsync<CancelSpotInstanceRequestsRequest,CancelSpotInstanceRequestsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ConfirmProductInstance

        internal ConfirmProductInstanceResponse ConfirmProductInstance(ConfirmProductInstanceRequest request)
        {
            var marshaller = new ConfirmProductInstanceRequestMarshaller();
            var unmarshaller = ConfirmProductInstanceResponseUnmarshaller.Instance;

            return Invoke<ConfirmProductInstanceRequest,ConfirmProductInstanceResponse>(request, marshaller, unmarshaller);
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
        public Task<ConfirmProductInstanceResponse> ConfirmProductInstanceAsync(ConfirmProductInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ConfirmProductInstanceRequestMarshaller();
            var unmarshaller = ConfirmProductInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<ConfirmProductInstanceRequest,ConfirmProductInstanceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CopyImage

        internal CopyImageResponse CopyImage(CopyImageRequest request)
        {
            var marshaller = new CopyImageRequestMarshaller();
            var unmarshaller = CopyImageResponseUnmarshaller.Instance;

            return Invoke<CopyImageRequest,CopyImageResponse>(request, marshaller, unmarshaller);
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
        public Task<CopyImageResponse> CopyImageAsync(CopyImageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CopyImageRequestMarshaller();
            var unmarshaller = CopyImageResponseUnmarshaller.Instance;

            return InvokeAsync<CopyImageRequest,CopyImageResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CopySnapshot

        internal CopySnapshotResponse CopySnapshot(CopySnapshotRequest request)
        {
            var marshaller = new CopySnapshotRequestMarshaller();
            var unmarshaller = CopySnapshotResponseUnmarshaller.Instance;

            return Invoke<CopySnapshotRequest,CopySnapshotResponse>(request, marshaller, unmarshaller);
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
        public Task<CopySnapshotResponse> CopySnapshotAsync(CopySnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CopySnapshotRequestMarshaller();
            var unmarshaller = CopySnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<CopySnapshotRequest,CopySnapshotResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateCustomerGateway

        internal CreateCustomerGatewayResponse CreateCustomerGateway(CreateCustomerGatewayRequest request)
        {
            var marshaller = new CreateCustomerGatewayRequestMarshaller();
            var unmarshaller = CreateCustomerGatewayResponseUnmarshaller.Instance;

            return Invoke<CreateCustomerGatewayRequest,CreateCustomerGatewayResponse>(request, marshaller, unmarshaller);
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
        public Task<CreateCustomerGatewayResponse> CreateCustomerGatewayAsync(CreateCustomerGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateCustomerGatewayRequestMarshaller();
            var unmarshaller = CreateCustomerGatewayResponseUnmarshaller.Instance;

            return InvokeAsync<CreateCustomerGatewayRequest,CreateCustomerGatewayResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateDhcpOptions

        internal CreateDhcpOptionsResponse CreateDhcpOptions(CreateDhcpOptionsRequest request)
        {
            var marshaller = new CreateDhcpOptionsRequestMarshaller();
            var unmarshaller = CreateDhcpOptionsResponseUnmarshaller.Instance;

            return Invoke<CreateDhcpOptionsRequest,CreateDhcpOptionsResponse>(request, marshaller, unmarshaller);
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
        public Task<CreateDhcpOptionsResponse> CreateDhcpOptionsAsync(CreateDhcpOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateDhcpOptionsRequestMarshaller();
            var unmarshaller = CreateDhcpOptionsResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDhcpOptionsRequest,CreateDhcpOptionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateFlowLogs

        internal CreateFlowLogsResponse CreateFlowLogs(CreateFlowLogsRequest request)
        {
            var marshaller = new CreateFlowLogsRequestMarshaller();
            var unmarshaller = CreateFlowLogsResponseUnmarshaller.Instance;

            return Invoke<CreateFlowLogsRequest,CreateFlowLogsResponse>(request, marshaller, unmarshaller);
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
        public Task<CreateFlowLogsResponse> CreateFlowLogsAsync(CreateFlowLogsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateFlowLogsRequestMarshaller();
            var unmarshaller = CreateFlowLogsResponseUnmarshaller.Instance;

            return InvokeAsync<CreateFlowLogsRequest,CreateFlowLogsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateImage

        internal CreateImageResponse CreateImage(CreateImageRequest request)
        {
            var marshaller = new CreateImageRequestMarshaller();
            var unmarshaller = CreateImageResponseUnmarshaller.Instance;

            return Invoke<CreateImageRequest,CreateImageResponse>(request, marshaller, unmarshaller);
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
        public Task<CreateImageResponse> CreateImageAsync(CreateImageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateImageRequestMarshaller();
            var unmarshaller = CreateImageResponseUnmarshaller.Instance;

            return InvokeAsync<CreateImageRequest,CreateImageResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateInstanceExportTask

        internal CreateInstanceExportTaskResponse CreateInstanceExportTask(CreateInstanceExportTaskRequest request)
        {
            var marshaller = new CreateInstanceExportTaskRequestMarshaller();
            var unmarshaller = CreateInstanceExportTaskResponseUnmarshaller.Instance;

            return Invoke<CreateInstanceExportTaskRequest,CreateInstanceExportTaskResponse>(request, marshaller, unmarshaller);
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
        public Task<CreateInstanceExportTaskResponse> CreateInstanceExportTaskAsync(CreateInstanceExportTaskRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateInstanceExportTaskRequestMarshaller();
            var unmarshaller = CreateInstanceExportTaskResponseUnmarshaller.Instance;

            return InvokeAsync<CreateInstanceExportTaskRequest,CreateInstanceExportTaskResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateInternetGateway

        internal CreateInternetGatewayResponse CreateInternetGateway()
        {
            return CreateInternetGateway(new CreateInternetGatewayRequest());
        }
        internal CreateInternetGatewayResponse CreateInternetGateway(CreateInternetGatewayRequest request)
        {
            var marshaller = new CreateInternetGatewayRequestMarshaller();
            var unmarshaller = CreateInternetGatewayResponseUnmarshaller.Instance;

            return Invoke<CreateInternetGatewayRequest,CreateInternetGatewayResponse>(request, marshaller, unmarshaller);
        }


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
        /// <param name="cancellationToken"> ttd1
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateInternetGateway service method, as returned by EC2.</returns>
        public Task<CreateInternetGatewayResponse> CreateInternetGatewayAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        public Task<CreateInternetGatewayResponse> CreateInternetGatewayAsync(CreateInternetGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateInternetGatewayRequestMarshaller();
            var unmarshaller = CreateInternetGatewayResponseUnmarshaller.Instance;

            return InvokeAsync<CreateInternetGatewayRequest,CreateInternetGatewayResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateKeyPair

        internal CreateKeyPairResponse CreateKeyPair(CreateKeyPairRequest request)
        {
            var marshaller = new CreateKeyPairRequestMarshaller();
            var unmarshaller = CreateKeyPairResponseUnmarshaller.Instance;

            return Invoke<CreateKeyPairRequest,CreateKeyPairResponse>(request, marshaller, unmarshaller);
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
        public Task<CreateKeyPairResponse> CreateKeyPairAsync(CreateKeyPairRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateKeyPairRequestMarshaller();
            var unmarshaller = CreateKeyPairResponseUnmarshaller.Instance;

            return InvokeAsync<CreateKeyPairRequest,CreateKeyPairResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateNetworkAcl

        internal CreateNetworkAclResponse CreateNetworkAcl(CreateNetworkAclRequest request)
        {
            var marshaller = new CreateNetworkAclRequestMarshaller();
            var unmarshaller = CreateNetworkAclResponseUnmarshaller.Instance;

            return Invoke<CreateNetworkAclRequest,CreateNetworkAclResponse>(request, marshaller, unmarshaller);
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
        public Task<CreateNetworkAclResponse> CreateNetworkAclAsync(CreateNetworkAclRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateNetworkAclRequestMarshaller();
            var unmarshaller = CreateNetworkAclResponseUnmarshaller.Instance;

            return InvokeAsync<CreateNetworkAclRequest,CreateNetworkAclResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateNetworkAclEntry

        internal CreateNetworkAclEntryResponse CreateNetworkAclEntry(CreateNetworkAclEntryRequest request)
        {
            var marshaller = new CreateNetworkAclEntryRequestMarshaller();
            var unmarshaller = CreateNetworkAclEntryResponseUnmarshaller.Instance;

            return Invoke<CreateNetworkAclEntryRequest,CreateNetworkAclEntryResponse>(request, marshaller, unmarshaller);
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
        public Task<CreateNetworkAclEntryResponse> CreateNetworkAclEntryAsync(CreateNetworkAclEntryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateNetworkAclEntryRequestMarshaller();
            var unmarshaller = CreateNetworkAclEntryResponseUnmarshaller.Instance;

            return InvokeAsync<CreateNetworkAclEntryRequest,CreateNetworkAclEntryResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateNetworkInterface

        internal CreateNetworkInterfaceResponse CreateNetworkInterface(CreateNetworkInterfaceRequest request)
        {
            var marshaller = new CreateNetworkInterfaceRequestMarshaller();
            var unmarshaller = CreateNetworkInterfaceResponseUnmarshaller.Instance;

            return Invoke<CreateNetworkInterfaceRequest,CreateNetworkInterfaceResponse>(request, marshaller, unmarshaller);
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
        public Task<CreateNetworkInterfaceResponse> CreateNetworkInterfaceAsync(CreateNetworkInterfaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateNetworkInterfaceRequestMarshaller();
            var unmarshaller = CreateNetworkInterfaceResponseUnmarshaller.Instance;

            return InvokeAsync<CreateNetworkInterfaceRequest,CreateNetworkInterfaceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreatePlacementGroup

        internal CreatePlacementGroupResponse CreatePlacementGroup(CreatePlacementGroupRequest request)
        {
            var marshaller = new CreatePlacementGroupRequestMarshaller();
            var unmarshaller = CreatePlacementGroupResponseUnmarshaller.Instance;

            return Invoke<CreatePlacementGroupRequest,CreatePlacementGroupResponse>(request, marshaller, unmarshaller);
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
        public Task<CreatePlacementGroupResponse> CreatePlacementGroupAsync(CreatePlacementGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreatePlacementGroupRequestMarshaller();
            var unmarshaller = CreatePlacementGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreatePlacementGroupRequest,CreatePlacementGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateReservedInstancesListing

        internal CreateReservedInstancesListingResponse CreateReservedInstancesListing(CreateReservedInstancesListingRequest request)
        {
            var marshaller = new CreateReservedInstancesListingRequestMarshaller();
            var unmarshaller = CreateReservedInstancesListingResponseUnmarshaller.Instance;

            return Invoke<CreateReservedInstancesListingRequest,CreateReservedInstancesListingResponse>(request, marshaller, unmarshaller);
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
        public Task<CreateReservedInstancesListingResponse> CreateReservedInstancesListingAsync(CreateReservedInstancesListingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateReservedInstancesListingRequestMarshaller();
            var unmarshaller = CreateReservedInstancesListingResponseUnmarshaller.Instance;

            return InvokeAsync<CreateReservedInstancesListingRequest,CreateReservedInstancesListingResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateRoute

        internal CreateRouteResponse CreateRoute(CreateRouteRequest request)
        {
            var marshaller = new CreateRouteRequestMarshaller();
            var unmarshaller = CreateRouteResponseUnmarshaller.Instance;

            return Invoke<CreateRouteRequest,CreateRouteResponse>(request, marshaller, unmarshaller);
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
        public Task<CreateRouteResponse> CreateRouteAsync(CreateRouteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateRouteRequestMarshaller();
            var unmarshaller = CreateRouteResponseUnmarshaller.Instance;

            return InvokeAsync<CreateRouteRequest,CreateRouteResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateRouteTable

        internal CreateRouteTableResponse CreateRouteTable(CreateRouteTableRequest request)
        {
            var marshaller = new CreateRouteTableRequestMarshaller();
            var unmarshaller = CreateRouteTableResponseUnmarshaller.Instance;

            return Invoke<CreateRouteTableRequest,CreateRouteTableResponse>(request, marshaller, unmarshaller);
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
        public Task<CreateRouteTableResponse> CreateRouteTableAsync(CreateRouteTableRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateRouteTableRequestMarshaller();
            var unmarshaller = CreateRouteTableResponseUnmarshaller.Instance;

            return InvokeAsync<CreateRouteTableRequest,CreateRouteTableResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateSecurityGroup

        internal CreateSecurityGroupResponse CreateSecurityGroup(CreateSecurityGroupRequest request)
        {
            var marshaller = new CreateSecurityGroupRequestMarshaller();
            var unmarshaller = CreateSecurityGroupResponseUnmarshaller.Instance;

            return Invoke<CreateSecurityGroupRequest,CreateSecurityGroupResponse>(request, marshaller, unmarshaller);
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
        public Task<CreateSecurityGroupResponse> CreateSecurityGroupAsync(CreateSecurityGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateSecurityGroupRequestMarshaller();
            var unmarshaller = CreateSecurityGroupResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSecurityGroupRequest,CreateSecurityGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateSnapshot

        internal CreateSnapshotResponse CreateSnapshot(CreateSnapshotRequest request)
        {
            var marshaller = new CreateSnapshotRequestMarshaller();
            var unmarshaller = CreateSnapshotResponseUnmarshaller.Instance;

            return Invoke<CreateSnapshotRequest,CreateSnapshotResponse>(request, marshaller, unmarshaller);
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
        public Task<CreateSnapshotResponse> CreateSnapshotAsync(CreateSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateSnapshotRequestMarshaller();
            var unmarshaller = CreateSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSnapshotRequest,CreateSnapshotResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateSpotDatafeedSubscription

        internal CreateSpotDatafeedSubscriptionResponse CreateSpotDatafeedSubscription(CreateSpotDatafeedSubscriptionRequest request)
        {
            var marshaller = new CreateSpotDatafeedSubscriptionRequestMarshaller();
            var unmarshaller = CreateSpotDatafeedSubscriptionResponseUnmarshaller.Instance;

            return Invoke<CreateSpotDatafeedSubscriptionRequest,CreateSpotDatafeedSubscriptionResponse>(request, marshaller, unmarshaller);
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
        public Task<CreateSpotDatafeedSubscriptionResponse> CreateSpotDatafeedSubscriptionAsync(CreateSpotDatafeedSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateSpotDatafeedSubscriptionRequestMarshaller();
            var unmarshaller = CreateSpotDatafeedSubscriptionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSpotDatafeedSubscriptionRequest,CreateSpotDatafeedSubscriptionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateSubnet

        internal CreateSubnetResponse CreateSubnet(CreateSubnetRequest request)
        {
            var marshaller = new CreateSubnetRequestMarshaller();
            var unmarshaller = CreateSubnetResponseUnmarshaller.Instance;

            return Invoke<CreateSubnetRequest,CreateSubnetResponse>(request, marshaller, unmarshaller);
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
        public Task<CreateSubnetResponse> CreateSubnetAsync(CreateSubnetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateSubnetRequestMarshaller();
            var unmarshaller = CreateSubnetResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSubnetRequest,CreateSubnetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateTags

        internal CreateTagsResponse CreateTags(CreateTagsRequest request)
        {
            var marshaller = new CreateTagsRequestMarshaller();
            var unmarshaller = CreateTagsResponseUnmarshaller.Instance;

            return Invoke<CreateTagsRequest,CreateTagsResponse>(request, marshaller, unmarshaller);
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
        public Task<CreateTagsResponse> CreateTagsAsync(CreateTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateTagsRequestMarshaller();
            var unmarshaller = CreateTagsResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTagsRequest,CreateTagsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateVolume

        internal CreateVolumeResponse CreateVolume(CreateVolumeRequest request)
        {
            var marshaller = new CreateVolumeRequestMarshaller();
            var unmarshaller = CreateVolumeResponseUnmarshaller.Instance;

            return Invoke<CreateVolumeRequest,CreateVolumeResponse>(request, marshaller, unmarshaller);
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
        public Task<CreateVolumeResponse> CreateVolumeAsync(CreateVolumeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateVolumeRequestMarshaller();
            var unmarshaller = CreateVolumeResponseUnmarshaller.Instance;

            return InvokeAsync<CreateVolumeRequest,CreateVolumeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateVpc

        internal CreateVpcResponse CreateVpc(CreateVpcRequest request)
        {
            var marshaller = new CreateVpcRequestMarshaller();
            var unmarshaller = CreateVpcResponseUnmarshaller.Instance;

            return Invoke<CreateVpcRequest,CreateVpcResponse>(request, marshaller, unmarshaller);
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
        public Task<CreateVpcResponse> CreateVpcAsync(CreateVpcRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateVpcRequestMarshaller();
            var unmarshaller = CreateVpcResponseUnmarshaller.Instance;

            return InvokeAsync<CreateVpcRequest,CreateVpcResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateVpcEndpoint

        internal CreateVpcEndpointResponse CreateVpcEndpoint(CreateVpcEndpointRequest request)
        {
            var marshaller = new CreateVpcEndpointRequestMarshaller();
            var unmarshaller = CreateVpcEndpointResponseUnmarshaller.Instance;

            return Invoke<CreateVpcEndpointRequest,CreateVpcEndpointResponse>(request, marshaller, unmarshaller);
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
        public Task<CreateVpcEndpointResponse> CreateVpcEndpointAsync(CreateVpcEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateVpcEndpointRequestMarshaller();
            var unmarshaller = CreateVpcEndpointResponseUnmarshaller.Instance;

            return InvokeAsync<CreateVpcEndpointRequest,CreateVpcEndpointResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateVpcPeeringConnection

        internal CreateVpcPeeringConnectionResponse CreateVpcPeeringConnection(CreateVpcPeeringConnectionRequest request)
        {
            var marshaller = new CreateVpcPeeringConnectionRequestMarshaller();
            var unmarshaller = CreateVpcPeeringConnectionResponseUnmarshaller.Instance;

            return Invoke<CreateVpcPeeringConnectionRequest,CreateVpcPeeringConnectionResponse>(request, marshaller, unmarshaller);
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
        public Task<CreateVpcPeeringConnectionResponse> CreateVpcPeeringConnectionAsync(CreateVpcPeeringConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateVpcPeeringConnectionRequestMarshaller();
            var unmarshaller = CreateVpcPeeringConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateVpcPeeringConnectionRequest,CreateVpcPeeringConnectionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateVpnConnection

        internal CreateVpnConnectionResponse CreateVpnConnection(CreateVpnConnectionRequest request)
        {
            var marshaller = new CreateVpnConnectionRequestMarshaller();
            var unmarshaller = CreateVpnConnectionResponseUnmarshaller.Instance;

            return Invoke<CreateVpnConnectionRequest,CreateVpnConnectionResponse>(request, marshaller, unmarshaller);
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
        public Task<CreateVpnConnectionResponse> CreateVpnConnectionAsync(CreateVpnConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateVpnConnectionRequestMarshaller();
            var unmarshaller = CreateVpnConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateVpnConnectionRequest,CreateVpnConnectionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateVpnConnectionRoute

        internal CreateVpnConnectionRouteResponse CreateVpnConnectionRoute(CreateVpnConnectionRouteRequest request)
        {
            var marshaller = new CreateVpnConnectionRouteRequestMarshaller();
            var unmarshaller = CreateVpnConnectionRouteResponseUnmarshaller.Instance;

            return Invoke<CreateVpnConnectionRouteRequest,CreateVpnConnectionRouteResponse>(request, marshaller, unmarshaller);
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
        public Task<CreateVpnConnectionRouteResponse> CreateVpnConnectionRouteAsync(CreateVpnConnectionRouteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateVpnConnectionRouteRequestMarshaller();
            var unmarshaller = CreateVpnConnectionRouteResponseUnmarshaller.Instance;

            return InvokeAsync<CreateVpnConnectionRouteRequest,CreateVpnConnectionRouteResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  CreateVpnGateway

        internal CreateVpnGatewayResponse CreateVpnGateway(CreateVpnGatewayRequest request)
        {
            var marshaller = new CreateVpnGatewayRequestMarshaller();
            var unmarshaller = CreateVpnGatewayResponseUnmarshaller.Instance;

            return Invoke<CreateVpnGatewayRequest,CreateVpnGatewayResponse>(request, marshaller, unmarshaller);
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
        public Task<CreateVpnGatewayResponse> CreateVpnGatewayAsync(CreateVpnGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new CreateVpnGatewayRequestMarshaller();
            var unmarshaller = CreateVpnGatewayResponseUnmarshaller.Instance;

            return InvokeAsync<CreateVpnGatewayRequest,CreateVpnGatewayResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteCustomerGateway

        internal DeleteCustomerGatewayResponse DeleteCustomerGateway(DeleteCustomerGatewayRequest request)
        {
            var marshaller = new DeleteCustomerGatewayRequestMarshaller();
            var unmarshaller = DeleteCustomerGatewayResponseUnmarshaller.Instance;

            return Invoke<DeleteCustomerGatewayRequest,DeleteCustomerGatewayResponse>(request, marshaller, unmarshaller);
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
        public Task<DeleteCustomerGatewayResponse> DeleteCustomerGatewayAsync(DeleteCustomerGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteCustomerGatewayRequestMarshaller();
            var unmarshaller = DeleteCustomerGatewayResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteCustomerGatewayRequest,DeleteCustomerGatewayResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteDhcpOptions

        internal DeleteDhcpOptionsResponse DeleteDhcpOptions(DeleteDhcpOptionsRequest request)
        {
            var marshaller = new DeleteDhcpOptionsRequestMarshaller();
            var unmarshaller = DeleteDhcpOptionsResponseUnmarshaller.Instance;

            return Invoke<DeleteDhcpOptionsRequest,DeleteDhcpOptionsResponse>(request, marshaller, unmarshaller);
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
        public Task<DeleteDhcpOptionsResponse> DeleteDhcpOptionsAsync(DeleteDhcpOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteDhcpOptionsRequestMarshaller();
            var unmarshaller = DeleteDhcpOptionsResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDhcpOptionsRequest,DeleteDhcpOptionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteFlowLogs

        internal DeleteFlowLogsResponse DeleteFlowLogs(DeleteFlowLogsRequest request)
        {
            var marshaller = new DeleteFlowLogsRequestMarshaller();
            var unmarshaller = DeleteFlowLogsResponseUnmarshaller.Instance;

            return Invoke<DeleteFlowLogsRequest,DeleteFlowLogsResponse>(request, marshaller, unmarshaller);
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
        public Task<DeleteFlowLogsResponse> DeleteFlowLogsAsync(DeleteFlowLogsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteFlowLogsRequestMarshaller();
            var unmarshaller = DeleteFlowLogsResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteFlowLogsRequest,DeleteFlowLogsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteInternetGateway

        internal DeleteInternetGatewayResponse DeleteInternetGateway(DeleteInternetGatewayRequest request)
        {
            var marshaller = new DeleteInternetGatewayRequestMarshaller();
            var unmarshaller = DeleteInternetGatewayResponseUnmarshaller.Instance;

            return Invoke<DeleteInternetGatewayRequest,DeleteInternetGatewayResponse>(request, marshaller, unmarshaller);
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
        public Task<DeleteInternetGatewayResponse> DeleteInternetGatewayAsync(DeleteInternetGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteInternetGatewayRequestMarshaller();
            var unmarshaller = DeleteInternetGatewayResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteInternetGatewayRequest,DeleteInternetGatewayResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteKeyPair

        internal DeleteKeyPairResponse DeleteKeyPair(DeleteKeyPairRequest request)
        {
            var marshaller = new DeleteKeyPairRequestMarshaller();
            var unmarshaller = DeleteKeyPairResponseUnmarshaller.Instance;

            return Invoke<DeleteKeyPairRequest,DeleteKeyPairResponse>(request, marshaller, unmarshaller);
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
        public Task<DeleteKeyPairResponse> DeleteKeyPairAsync(DeleteKeyPairRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteKeyPairRequestMarshaller();
            var unmarshaller = DeleteKeyPairResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteKeyPairRequest,DeleteKeyPairResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteNetworkAcl

        internal DeleteNetworkAclResponse DeleteNetworkAcl(DeleteNetworkAclRequest request)
        {
            var marshaller = new DeleteNetworkAclRequestMarshaller();
            var unmarshaller = DeleteNetworkAclResponseUnmarshaller.Instance;

            return Invoke<DeleteNetworkAclRequest,DeleteNetworkAclResponse>(request, marshaller, unmarshaller);
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
        public Task<DeleteNetworkAclResponse> DeleteNetworkAclAsync(DeleteNetworkAclRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteNetworkAclRequestMarshaller();
            var unmarshaller = DeleteNetworkAclResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteNetworkAclRequest,DeleteNetworkAclResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteNetworkAclEntry

        internal DeleteNetworkAclEntryResponse DeleteNetworkAclEntry(DeleteNetworkAclEntryRequest request)
        {
            var marshaller = new DeleteNetworkAclEntryRequestMarshaller();
            var unmarshaller = DeleteNetworkAclEntryResponseUnmarshaller.Instance;

            return Invoke<DeleteNetworkAclEntryRequest,DeleteNetworkAclEntryResponse>(request, marshaller, unmarshaller);
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
        public Task<DeleteNetworkAclEntryResponse> DeleteNetworkAclEntryAsync(DeleteNetworkAclEntryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteNetworkAclEntryRequestMarshaller();
            var unmarshaller = DeleteNetworkAclEntryResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteNetworkAclEntryRequest,DeleteNetworkAclEntryResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteNetworkInterface

        internal DeleteNetworkInterfaceResponse DeleteNetworkInterface(DeleteNetworkInterfaceRequest request)
        {
            var marshaller = new DeleteNetworkInterfaceRequestMarshaller();
            var unmarshaller = DeleteNetworkInterfaceResponseUnmarshaller.Instance;

            return Invoke<DeleteNetworkInterfaceRequest,DeleteNetworkInterfaceResponse>(request, marshaller, unmarshaller);
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
        public Task<DeleteNetworkInterfaceResponse> DeleteNetworkInterfaceAsync(DeleteNetworkInterfaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteNetworkInterfaceRequestMarshaller();
            var unmarshaller = DeleteNetworkInterfaceResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteNetworkInterfaceRequest,DeleteNetworkInterfaceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeletePlacementGroup

        internal DeletePlacementGroupResponse DeletePlacementGroup(DeletePlacementGroupRequest request)
        {
            var marshaller = new DeletePlacementGroupRequestMarshaller();
            var unmarshaller = DeletePlacementGroupResponseUnmarshaller.Instance;

            return Invoke<DeletePlacementGroupRequest,DeletePlacementGroupResponse>(request, marshaller, unmarshaller);
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
        public Task<DeletePlacementGroupResponse> DeletePlacementGroupAsync(DeletePlacementGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeletePlacementGroupRequestMarshaller();
            var unmarshaller = DeletePlacementGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeletePlacementGroupRequest,DeletePlacementGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteRoute

        internal DeleteRouteResponse DeleteRoute(DeleteRouteRequest request)
        {
            var marshaller = new DeleteRouteRequestMarshaller();
            var unmarshaller = DeleteRouteResponseUnmarshaller.Instance;

            return Invoke<DeleteRouteRequest,DeleteRouteResponse>(request, marshaller, unmarshaller);
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
        public Task<DeleteRouteResponse> DeleteRouteAsync(DeleteRouteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteRouteRequestMarshaller();
            var unmarshaller = DeleteRouteResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteRouteRequest,DeleteRouteResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteRouteTable

        internal DeleteRouteTableResponse DeleteRouteTable(DeleteRouteTableRequest request)
        {
            var marshaller = new DeleteRouteTableRequestMarshaller();
            var unmarshaller = DeleteRouteTableResponseUnmarshaller.Instance;

            return Invoke<DeleteRouteTableRequest,DeleteRouteTableResponse>(request, marshaller, unmarshaller);
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
        public Task<DeleteRouteTableResponse> DeleteRouteTableAsync(DeleteRouteTableRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteRouteTableRequestMarshaller();
            var unmarshaller = DeleteRouteTableResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteRouteTableRequest,DeleteRouteTableResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteSecurityGroup

        internal DeleteSecurityGroupResponse DeleteSecurityGroup(DeleteSecurityGroupRequest request)
        {
            var marshaller = new DeleteSecurityGroupRequestMarshaller();
            var unmarshaller = DeleteSecurityGroupResponseUnmarshaller.Instance;

            return Invoke<DeleteSecurityGroupRequest,DeleteSecurityGroupResponse>(request, marshaller, unmarshaller);
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
        public Task<DeleteSecurityGroupResponse> DeleteSecurityGroupAsync(DeleteSecurityGroupRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteSecurityGroupRequestMarshaller();
            var unmarshaller = DeleteSecurityGroupResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSecurityGroupRequest,DeleteSecurityGroupResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteSnapshot

        internal DeleteSnapshotResponse DeleteSnapshot(DeleteSnapshotRequest request)
        {
            var marshaller = new DeleteSnapshotRequestMarshaller();
            var unmarshaller = DeleteSnapshotResponseUnmarshaller.Instance;

            return Invoke<DeleteSnapshotRequest,DeleteSnapshotResponse>(request, marshaller, unmarshaller);
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
        public Task<DeleteSnapshotResponse> DeleteSnapshotAsync(DeleteSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteSnapshotRequestMarshaller();
            var unmarshaller = DeleteSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSnapshotRequest,DeleteSnapshotResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteSpotDatafeedSubscription

        internal DeleteSpotDatafeedSubscriptionResponse DeleteSpotDatafeedSubscription()
        {
            return DeleteSpotDatafeedSubscription(new DeleteSpotDatafeedSubscriptionRequest());
        }
        internal DeleteSpotDatafeedSubscriptionResponse DeleteSpotDatafeedSubscription(DeleteSpotDatafeedSubscriptionRequest request)
        {
            var marshaller = new DeleteSpotDatafeedSubscriptionRequestMarshaller();
            var unmarshaller = DeleteSpotDatafeedSubscriptionResponseUnmarshaller.Instance;

            return Invoke<DeleteSpotDatafeedSubscriptionRequest,DeleteSpotDatafeedSubscriptionResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Deletes the data feed for Spot instances.
        /// </summary>
        /// <param name="cancellationToken"> ttd1
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSpotDatafeedSubscription service method, as returned by EC2.</returns>
        public Task<DeleteSpotDatafeedSubscriptionResponse> DeleteSpotDatafeedSubscriptionAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        public Task<DeleteSpotDatafeedSubscriptionResponse> DeleteSpotDatafeedSubscriptionAsync(DeleteSpotDatafeedSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteSpotDatafeedSubscriptionRequestMarshaller();
            var unmarshaller = DeleteSpotDatafeedSubscriptionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSpotDatafeedSubscriptionRequest,DeleteSpotDatafeedSubscriptionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteSubnet

        internal DeleteSubnetResponse DeleteSubnet(DeleteSubnetRequest request)
        {
            var marshaller = new DeleteSubnetRequestMarshaller();
            var unmarshaller = DeleteSubnetResponseUnmarshaller.Instance;

            return Invoke<DeleteSubnetRequest,DeleteSubnetResponse>(request, marshaller, unmarshaller);
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
        public Task<DeleteSubnetResponse> DeleteSubnetAsync(DeleteSubnetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteSubnetRequestMarshaller();
            var unmarshaller = DeleteSubnetResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSubnetRequest,DeleteSubnetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteTags

        internal DeleteTagsResponse DeleteTags(DeleteTagsRequest request)
        {
            var marshaller = new DeleteTagsRequestMarshaller();
            var unmarshaller = DeleteTagsResponseUnmarshaller.Instance;

            return Invoke<DeleteTagsRequest,DeleteTagsResponse>(request, marshaller, unmarshaller);
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
        public Task<DeleteTagsResponse> DeleteTagsAsync(DeleteTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteTagsRequestMarshaller();
            var unmarshaller = DeleteTagsResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteTagsRequest,DeleteTagsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteVolume

        internal DeleteVolumeResponse DeleteVolume(DeleteVolumeRequest request)
        {
            var marshaller = new DeleteVolumeRequestMarshaller();
            var unmarshaller = DeleteVolumeResponseUnmarshaller.Instance;

            return Invoke<DeleteVolumeRequest,DeleteVolumeResponse>(request, marshaller, unmarshaller);
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
        public Task<DeleteVolumeResponse> DeleteVolumeAsync(DeleteVolumeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteVolumeRequestMarshaller();
            var unmarshaller = DeleteVolumeResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteVolumeRequest,DeleteVolumeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteVpc

        internal DeleteVpcResponse DeleteVpc(DeleteVpcRequest request)
        {
            var marshaller = new DeleteVpcRequestMarshaller();
            var unmarshaller = DeleteVpcResponseUnmarshaller.Instance;

            return Invoke<DeleteVpcRequest,DeleteVpcResponse>(request, marshaller, unmarshaller);
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
        public Task<DeleteVpcResponse> DeleteVpcAsync(DeleteVpcRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteVpcRequestMarshaller();
            var unmarshaller = DeleteVpcResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteVpcRequest,DeleteVpcResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteVpcEndpoints

        internal DeleteVpcEndpointsResponse DeleteVpcEndpoints(DeleteVpcEndpointsRequest request)
        {
            var marshaller = new DeleteVpcEndpointsRequestMarshaller();
            var unmarshaller = DeleteVpcEndpointsResponseUnmarshaller.Instance;

            return Invoke<DeleteVpcEndpointsRequest,DeleteVpcEndpointsResponse>(request, marshaller, unmarshaller);
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
        public Task<DeleteVpcEndpointsResponse> DeleteVpcEndpointsAsync(DeleteVpcEndpointsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteVpcEndpointsRequestMarshaller();
            var unmarshaller = DeleteVpcEndpointsResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteVpcEndpointsRequest,DeleteVpcEndpointsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteVpcPeeringConnection

        internal DeleteVpcPeeringConnectionResponse DeleteVpcPeeringConnection(DeleteVpcPeeringConnectionRequest request)
        {
            var marshaller = new DeleteVpcPeeringConnectionRequestMarshaller();
            var unmarshaller = DeleteVpcPeeringConnectionResponseUnmarshaller.Instance;

            return Invoke<DeleteVpcPeeringConnectionRequest,DeleteVpcPeeringConnectionResponse>(request, marshaller, unmarshaller);
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
        public Task<DeleteVpcPeeringConnectionResponse> DeleteVpcPeeringConnectionAsync(DeleteVpcPeeringConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteVpcPeeringConnectionRequestMarshaller();
            var unmarshaller = DeleteVpcPeeringConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteVpcPeeringConnectionRequest,DeleteVpcPeeringConnectionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteVpnConnection

        internal DeleteVpnConnectionResponse DeleteVpnConnection(DeleteVpnConnectionRequest request)
        {
            var marshaller = new DeleteVpnConnectionRequestMarshaller();
            var unmarshaller = DeleteVpnConnectionResponseUnmarshaller.Instance;

            return Invoke<DeleteVpnConnectionRequest,DeleteVpnConnectionResponse>(request, marshaller, unmarshaller);
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
        public Task<DeleteVpnConnectionResponse> DeleteVpnConnectionAsync(DeleteVpnConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteVpnConnectionRequestMarshaller();
            var unmarshaller = DeleteVpnConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteVpnConnectionRequest,DeleteVpnConnectionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteVpnConnectionRoute

        internal DeleteVpnConnectionRouteResponse DeleteVpnConnectionRoute(DeleteVpnConnectionRouteRequest request)
        {
            var marshaller = new DeleteVpnConnectionRouteRequestMarshaller();
            var unmarshaller = DeleteVpnConnectionRouteResponseUnmarshaller.Instance;

            return Invoke<DeleteVpnConnectionRouteRequest,DeleteVpnConnectionRouteResponse>(request, marshaller, unmarshaller);
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
        public Task<DeleteVpnConnectionRouteResponse> DeleteVpnConnectionRouteAsync(DeleteVpnConnectionRouteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteVpnConnectionRouteRequestMarshaller();
            var unmarshaller = DeleteVpnConnectionRouteResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteVpnConnectionRouteRequest,DeleteVpnConnectionRouteResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeleteVpnGateway

        internal DeleteVpnGatewayResponse DeleteVpnGateway(DeleteVpnGatewayRequest request)
        {
            var marshaller = new DeleteVpnGatewayRequestMarshaller();
            var unmarshaller = DeleteVpnGatewayResponseUnmarshaller.Instance;

            return Invoke<DeleteVpnGatewayRequest,DeleteVpnGatewayResponse>(request, marshaller, unmarshaller);
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
        public Task<DeleteVpnGatewayResponse> DeleteVpnGatewayAsync(DeleteVpnGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeleteVpnGatewayRequestMarshaller();
            var unmarshaller = DeleteVpnGatewayResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteVpnGatewayRequest,DeleteVpnGatewayResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DeregisterImage

        internal DeregisterImageResponse DeregisterImage(DeregisterImageRequest request)
        {
            var marshaller = new DeregisterImageRequestMarshaller();
            var unmarshaller = DeregisterImageResponseUnmarshaller.Instance;

            return Invoke<DeregisterImageRequest,DeregisterImageResponse>(request, marshaller, unmarshaller);
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
        public Task<DeregisterImageResponse> DeregisterImageAsync(DeregisterImageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DeregisterImageRequestMarshaller();
            var unmarshaller = DeregisterImageResponseUnmarshaller.Instance;

            return InvokeAsync<DeregisterImageRequest,DeregisterImageResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeAccountAttributes

        internal DescribeAccountAttributesResponse DescribeAccountAttributes()
        {
            return DescribeAccountAttributes(new DescribeAccountAttributesRequest());
        }
        internal DescribeAccountAttributesResponse DescribeAccountAttributes(DescribeAccountAttributesRequest request)
        {
            var marshaller = new DescribeAccountAttributesRequestMarshaller();
            var unmarshaller = DescribeAccountAttributesResponseUnmarshaller.Instance;

            return Invoke<DescribeAccountAttributesRequest,DescribeAccountAttributesResponse>(request, marshaller, unmarshaller);
        }


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
        /// <param name="cancellationToken"> ttd1
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAccountAttributes service method, as returned by EC2.</returns>
        public Task<DescribeAccountAttributesResponse> DescribeAccountAttributesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        public Task<DescribeAccountAttributesResponse> DescribeAccountAttributesAsync(DescribeAccountAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeAccountAttributesRequestMarshaller();
            var unmarshaller = DescribeAccountAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAccountAttributesRequest,DescribeAccountAttributesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeAddresses

        internal DescribeAddressesResponse DescribeAddresses()
        {
            return DescribeAddresses(new DescribeAddressesRequest());
        }
        internal DescribeAddressesResponse DescribeAddresses(DescribeAddressesRequest request)
        {
            var marshaller = new DescribeAddressesRequestMarshaller();
            var unmarshaller = DescribeAddressesResponseUnmarshaller.Instance;

            return Invoke<DescribeAddressesRequest,DescribeAddressesResponse>(request, marshaller, unmarshaller);
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
        /// <param name="cancellationToken"> ttd1
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAddresses service method, as returned by EC2.</returns>
        public Task<DescribeAddressesResponse> DescribeAddressesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        public Task<DescribeAddressesResponse> DescribeAddressesAsync(DescribeAddressesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeAddressesRequestMarshaller();
            var unmarshaller = DescribeAddressesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAddressesRequest,DescribeAddressesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeAvailabilityZones

        internal DescribeAvailabilityZonesResponse DescribeAvailabilityZones()
        {
            return DescribeAvailabilityZones(new DescribeAvailabilityZonesRequest());
        }
        internal DescribeAvailabilityZonesResponse DescribeAvailabilityZones(DescribeAvailabilityZonesRequest request)
        {
            var marshaller = new DescribeAvailabilityZonesRequestMarshaller();
            var unmarshaller = DescribeAvailabilityZonesResponseUnmarshaller.Instance;

            return Invoke<DescribeAvailabilityZonesRequest,DescribeAvailabilityZonesResponse>(request, marshaller, unmarshaller);
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
        /// <param name="cancellationToken"> ttd1
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeAvailabilityZones service method, as returned by EC2.</returns>
        public Task<DescribeAvailabilityZonesResponse> DescribeAvailabilityZonesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        public Task<DescribeAvailabilityZonesResponse> DescribeAvailabilityZonesAsync(DescribeAvailabilityZonesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeAvailabilityZonesRequestMarshaller();
            var unmarshaller = DescribeAvailabilityZonesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeAvailabilityZonesRequest,DescribeAvailabilityZonesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeBundleTasks

        internal DescribeBundleTasksResponse DescribeBundleTasks()
        {
            return DescribeBundleTasks(new DescribeBundleTasksRequest());
        }
        internal DescribeBundleTasksResponse DescribeBundleTasks(DescribeBundleTasksRequest request)
        {
            var marshaller = new DescribeBundleTasksRequestMarshaller();
            var unmarshaller = DescribeBundleTasksResponseUnmarshaller.Instance;

            return Invoke<DescribeBundleTasksRequest,DescribeBundleTasksResponse>(request, marshaller, unmarshaller);
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
        /// </note>
        /// </summary>
        /// <param name="cancellationToken"> ttd1
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeBundleTasks service method, as returned by EC2.</returns>
        public Task<DescribeBundleTasksResponse> DescribeBundleTasksAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        public Task<DescribeBundleTasksResponse> DescribeBundleTasksAsync(DescribeBundleTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeBundleTasksRequestMarshaller();
            var unmarshaller = DescribeBundleTasksResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeBundleTasksRequest,DescribeBundleTasksResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeClassicLinkInstances

        internal DescribeClassicLinkInstancesResponse DescribeClassicLinkInstances(DescribeClassicLinkInstancesRequest request)
        {
            var marshaller = new DescribeClassicLinkInstancesRequestMarshaller();
            var unmarshaller = DescribeClassicLinkInstancesResponseUnmarshaller.Instance;

            return Invoke<DescribeClassicLinkInstancesRequest,DescribeClassicLinkInstancesResponse>(request, marshaller, unmarshaller);
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
        public Task<DescribeClassicLinkInstancesResponse> DescribeClassicLinkInstancesAsync(DescribeClassicLinkInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeClassicLinkInstancesRequestMarshaller();
            var unmarshaller = DescribeClassicLinkInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeClassicLinkInstancesRequest,DescribeClassicLinkInstancesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeConversionTasks

        internal DescribeConversionTasksResponse DescribeConversionTasks()
        {
            return DescribeConversionTasks(new DescribeConversionTasksRequest());
        }
        internal DescribeConversionTasksResponse DescribeConversionTasks(DescribeConversionTasksRequest request)
        {
            var marshaller = new DescribeConversionTasksRequestMarshaller();
            var unmarshaller = DescribeConversionTasksResponseUnmarshaller.Instance;

            return Invoke<DescribeConversionTasksRequest,DescribeConversionTasksResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Describes one or more of your conversion tasks. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/UploadingYourInstancesandVolumes.html">Using
        /// the Command Line Tools to Import Your Virtual Machine to Amazon EC2</a> in the <i>Amazon
        /// Elastic Compute Cloud User Guide</i>.
        /// </summary>
        /// <param name="cancellationToken"> ttd1
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeConversionTasks service method, as returned by EC2.</returns>
        public Task<DescribeConversionTasksResponse> DescribeConversionTasksAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        public Task<DescribeConversionTasksResponse> DescribeConversionTasksAsync(DescribeConversionTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeConversionTasksRequestMarshaller();
            var unmarshaller = DescribeConversionTasksResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeConversionTasksRequest,DescribeConversionTasksResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeCustomerGateways

        internal DescribeCustomerGatewaysResponse DescribeCustomerGateways()
        {
            return DescribeCustomerGateways(new DescribeCustomerGatewaysRequest());
        }
        internal DescribeCustomerGatewaysResponse DescribeCustomerGateways(DescribeCustomerGatewaysRequest request)
        {
            var marshaller = new DescribeCustomerGatewaysRequestMarshaller();
            var unmarshaller = DescribeCustomerGatewaysResponseUnmarshaller.Instance;

            return Invoke<DescribeCustomerGatewaysRequest,DescribeCustomerGatewaysResponse>(request, marshaller, unmarshaller);
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
        /// <param name="cancellationToken"> ttd1
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeCustomerGateways service method, as returned by EC2.</returns>
        public Task<DescribeCustomerGatewaysResponse> DescribeCustomerGatewaysAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        public Task<DescribeCustomerGatewaysResponse> DescribeCustomerGatewaysAsync(DescribeCustomerGatewaysRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeCustomerGatewaysRequestMarshaller();
            var unmarshaller = DescribeCustomerGatewaysResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeCustomerGatewaysRequest,DescribeCustomerGatewaysResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeDhcpOptions

        internal DescribeDhcpOptionsResponse DescribeDhcpOptions()
        {
            return DescribeDhcpOptions(new DescribeDhcpOptionsRequest());
        }
        internal DescribeDhcpOptionsResponse DescribeDhcpOptions(DescribeDhcpOptionsRequest request)
        {
            var marshaller = new DescribeDhcpOptionsRequestMarshaller();
            var unmarshaller = DescribeDhcpOptionsResponseUnmarshaller.Instance;

            return Invoke<DescribeDhcpOptionsRequest,DescribeDhcpOptionsResponse>(request, marshaller, unmarshaller);
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
        /// <param name="cancellationToken"> ttd1
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDhcpOptions service method, as returned by EC2.</returns>
        public Task<DescribeDhcpOptionsResponse> DescribeDhcpOptionsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        public Task<DescribeDhcpOptionsResponse> DescribeDhcpOptionsAsync(DescribeDhcpOptionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeDhcpOptionsRequestMarshaller();
            var unmarshaller = DescribeDhcpOptionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDhcpOptionsRequest,DescribeDhcpOptionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeExportTasks

        internal DescribeExportTasksResponse DescribeExportTasks()
        {
            return DescribeExportTasks(new DescribeExportTasksRequest());
        }
        internal DescribeExportTasksResponse DescribeExportTasks(DescribeExportTasksRequest request)
        {
            var marshaller = new DescribeExportTasksRequestMarshaller();
            var unmarshaller = DescribeExportTasksResponseUnmarshaller.Instance;

            return Invoke<DescribeExportTasksRequest,DescribeExportTasksResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Describes one or more of your export tasks.
        /// </summary>
        /// <param name="cancellationToken"> ttd1
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeExportTasks service method, as returned by EC2.</returns>
        public Task<DescribeExportTasksResponse> DescribeExportTasksAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        public Task<DescribeExportTasksResponse> DescribeExportTasksAsync(DescribeExportTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeExportTasksRequestMarshaller();
            var unmarshaller = DescribeExportTasksResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeExportTasksRequest,DescribeExportTasksResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeFlowLogs

        internal DescribeFlowLogsResponse DescribeFlowLogs(DescribeFlowLogsRequest request)
        {
            var marshaller = new DescribeFlowLogsRequestMarshaller();
            var unmarshaller = DescribeFlowLogsResponseUnmarshaller.Instance;

            return Invoke<DescribeFlowLogsRequest,DescribeFlowLogsResponse>(request, marshaller, unmarshaller);
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
        public Task<DescribeFlowLogsResponse> DescribeFlowLogsAsync(DescribeFlowLogsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeFlowLogsRequestMarshaller();
            var unmarshaller = DescribeFlowLogsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeFlowLogsRequest,DescribeFlowLogsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeImageAttribute

        internal DescribeImageAttributeResponse DescribeImageAttribute(DescribeImageAttributeRequest request)
        {
            var marshaller = new DescribeImageAttributeRequestMarshaller();
            var unmarshaller = DescribeImageAttributeResponseUnmarshaller.Instance;

            return Invoke<DescribeImageAttributeRequest,DescribeImageAttributeResponse>(request, marshaller, unmarshaller);
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
        public Task<DescribeImageAttributeResponse> DescribeImageAttributeAsync(DescribeImageAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeImageAttributeRequestMarshaller();
            var unmarshaller = DescribeImageAttributeResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeImageAttributeRequest,DescribeImageAttributeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeImages

        internal DescribeImagesResponse DescribeImages()
        {
            return DescribeImages(new DescribeImagesRequest());
        }
        internal DescribeImagesResponse DescribeImages(DescribeImagesRequest request)
        {
            var marshaller = new DescribeImagesRequestMarshaller();
            var unmarshaller = DescribeImagesResponseUnmarshaller.Instance;

            return Invoke<DescribeImagesRequest,DescribeImagesResponse>(request, marshaller, unmarshaller);
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
        /// </note>
        /// </summary>
        /// <param name="cancellationToken"> ttd1
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeImages service method, as returned by EC2.</returns>
        public Task<DescribeImagesResponse> DescribeImagesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        public Task<DescribeImagesResponse> DescribeImagesAsync(DescribeImagesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeImagesRequestMarshaller();
            var unmarshaller = DescribeImagesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeImagesRequest,DescribeImagesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeImportImageTasks

        internal DescribeImportImageTasksResponse DescribeImportImageTasks(DescribeImportImageTasksRequest request)
        {
            var marshaller = new DescribeImportImageTasksRequestMarshaller();
            var unmarshaller = DescribeImportImageTasksResponseUnmarshaller.Instance;

            return Invoke<DescribeImportImageTasksRequest,DescribeImportImageTasksResponse>(request, marshaller, unmarshaller);
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
        public Task<DescribeImportImageTasksResponse> DescribeImportImageTasksAsync(DescribeImportImageTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeImportImageTasksRequestMarshaller();
            var unmarshaller = DescribeImportImageTasksResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeImportImageTasksRequest,DescribeImportImageTasksResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeImportSnapshotTasks

        internal DescribeImportSnapshotTasksResponse DescribeImportSnapshotTasks(DescribeImportSnapshotTasksRequest request)
        {
            var marshaller = new DescribeImportSnapshotTasksRequestMarshaller();
            var unmarshaller = DescribeImportSnapshotTasksResponseUnmarshaller.Instance;

            return Invoke<DescribeImportSnapshotTasksRequest,DescribeImportSnapshotTasksResponse>(request, marshaller, unmarshaller);
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
        public Task<DescribeImportSnapshotTasksResponse> DescribeImportSnapshotTasksAsync(DescribeImportSnapshotTasksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeImportSnapshotTasksRequestMarshaller();
            var unmarshaller = DescribeImportSnapshotTasksResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeImportSnapshotTasksRequest,DescribeImportSnapshotTasksResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeInstanceAttribute

        internal DescribeInstanceAttributeResponse DescribeInstanceAttribute(DescribeInstanceAttributeRequest request)
        {
            var marshaller = new DescribeInstanceAttributeRequestMarshaller();
            var unmarshaller = DescribeInstanceAttributeResponseUnmarshaller.Instance;

            return Invoke<DescribeInstanceAttributeRequest,DescribeInstanceAttributeResponse>(request, marshaller, unmarshaller);
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
        public Task<DescribeInstanceAttributeResponse> DescribeInstanceAttributeAsync(DescribeInstanceAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeInstanceAttributeRequestMarshaller();
            var unmarshaller = DescribeInstanceAttributeResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeInstanceAttributeRequest,DescribeInstanceAttributeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeInstances

        internal DescribeInstancesResponse DescribeInstances()
        {
            return DescribeInstances(new DescribeInstancesRequest());
        }
        internal DescribeInstancesResponse DescribeInstances(DescribeInstancesRequest request)
        {
            var marshaller = new DescribeInstancesRequestMarshaller();
            var unmarshaller = DescribeInstancesResponseUnmarshaller.Instance;

            return Invoke<DescribeInstancesRequest,DescribeInstancesResponse>(request, marshaller, unmarshaller);
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
        /// <param name="cancellationToken"> ttd1
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeInstances service method, as returned by EC2.</returns>
        public Task<DescribeInstancesResponse> DescribeInstancesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        public Task<DescribeInstancesResponse> DescribeInstancesAsync(DescribeInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeInstancesRequestMarshaller();
            var unmarshaller = DescribeInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeInstancesRequest,DescribeInstancesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeInstanceStatus

        internal DescribeInstanceStatusResponse DescribeInstanceStatus()
        {
            return DescribeInstanceStatus(new DescribeInstanceStatusRequest());
        }
        internal DescribeInstanceStatusResponse DescribeInstanceStatus(DescribeInstanceStatusRequest request)
        {
            var marshaller = new DescribeInstanceStatusRequestMarshaller();
            var unmarshaller = DescribeInstanceStatusResponseUnmarshaller.Instance;

            return Invoke<DescribeInstanceStatusRequest,DescribeInstanceStatusResponse>(request, marshaller, unmarshaller);
        }


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
        /// <param name="cancellationToken"> ttd1
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeInstanceStatus service method, as returned by EC2.</returns>
        public Task<DescribeInstanceStatusResponse> DescribeInstanceStatusAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        public Task<DescribeInstanceStatusResponse> DescribeInstanceStatusAsync(DescribeInstanceStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeInstanceStatusRequestMarshaller();
            var unmarshaller = DescribeInstanceStatusResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeInstanceStatusRequest,DescribeInstanceStatusResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeInternetGateways

        internal DescribeInternetGatewaysResponse DescribeInternetGateways()
        {
            return DescribeInternetGateways(new DescribeInternetGatewaysRequest());
        }
        internal DescribeInternetGatewaysResponse DescribeInternetGateways(DescribeInternetGatewaysRequest request)
        {
            var marshaller = new DescribeInternetGatewaysRequestMarshaller();
            var unmarshaller = DescribeInternetGatewaysResponseUnmarshaller.Instance;

            return Invoke<DescribeInternetGatewaysRequest,DescribeInternetGatewaysResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Describes one or more of your Internet gateways.
        /// </summary>
        /// <param name="cancellationToken"> ttd1
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeInternetGateways service method, as returned by EC2.</returns>
        public Task<DescribeInternetGatewaysResponse> DescribeInternetGatewaysAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        public Task<DescribeInternetGatewaysResponse> DescribeInternetGatewaysAsync(DescribeInternetGatewaysRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeInternetGatewaysRequestMarshaller();
            var unmarshaller = DescribeInternetGatewaysResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeInternetGatewaysRequest,DescribeInternetGatewaysResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeKeyPairs

        internal DescribeKeyPairsResponse DescribeKeyPairs()
        {
            return DescribeKeyPairs(new DescribeKeyPairsRequest());
        }
        internal DescribeKeyPairsResponse DescribeKeyPairs(DescribeKeyPairsRequest request)
        {
            var marshaller = new DescribeKeyPairsRequestMarshaller();
            var unmarshaller = DescribeKeyPairsResponseUnmarshaller.Instance;

            return Invoke<DescribeKeyPairsRequest,DescribeKeyPairsResponse>(request, marshaller, unmarshaller);
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
        /// <param name="cancellationToken"> ttd1
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeKeyPairs service method, as returned by EC2.</returns>
        public Task<DescribeKeyPairsResponse> DescribeKeyPairsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        public Task<DescribeKeyPairsResponse> DescribeKeyPairsAsync(DescribeKeyPairsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeKeyPairsRequestMarshaller();
            var unmarshaller = DescribeKeyPairsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeKeyPairsRequest,DescribeKeyPairsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeMovingAddresses

        internal DescribeMovingAddressesResponse DescribeMovingAddresses(DescribeMovingAddressesRequest request)
        {
            var marshaller = new DescribeMovingAddressesRequestMarshaller();
            var unmarshaller = DescribeMovingAddressesResponseUnmarshaller.Instance;

            return Invoke<DescribeMovingAddressesRequest,DescribeMovingAddressesResponse>(request, marshaller, unmarshaller);
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
        public Task<DescribeMovingAddressesResponse> DescribeMovingAddressesAsync(DescribeMovingAddressesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeMovingAddressesRequestMarshaller();
            var unmarshaller = DescribeMovingAddressesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeMovingAddressesRequest,DescribeMovingAddressesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeNetworkAcls

        internal DescribeNetworkAclsResponse DescribeNetworkAcls()
        {
            return DescribeNetworkAcls(new DescribeNetworkAclsRequest());
        }
        internal DescribeNetworkAclsResponse DescribeNetworkAcls(DescribeNetworkAclsRequest request)
        {
            var marshaller = new DescribeNetworkAclsRequestMarshaller();
            var unmarshaller = DescribeNetworkAclsResponseUnmarshaller.Instance;

            return Invoke<DescribeNetworkAclsRequest,DescribeNetworkAclsResponse>(request, marshaller, unmarshaller);
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
        /// <param name="cancellationToken"> ttd1
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeNetworkAcls service method, as returned by EC2.</returns>
        public Task<DescribeNetworkAclsResponse> DescribeNetworkAclsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        public Task<DescribeNetworkAclsResponse> DescribeNetworkAclsAsync(DescribeNetworkAclsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeNetworkAclsRequestMarshaller();
            var unmarshaller = DescribeNetworkAclsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeNetworkAclsRequest,DescribeNetworkAclsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeNetworkInterfaceAttribute

        internal DescribeNetworkInterfaceAttributeResponse DescribeNetworkInterfaceAttribute(DescribeNetworkInterfaceAttributeRequest request)
        {
            var marshaller = new DescribeNetworkInterfaceAttributeRequestMarshaller();
            var unmarshaller = DescribeNetworkInterfaceAttributeResponseUnmarshaller.Instance;

            return Invoke<DescribeNetworkInterfaceAttributeRequest,DescribeNetworkInterfaceAttributeResponse>(request, marshaller, unmarshaller);
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
        public Task<DescribeNetworkInterfaceAttributeResponse> DescribeNetworkInterfaceAttributeAsync(DescribeNetworkInterfaceAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeNetworkInterfaceAttributeRequestMarshaller();
            var unmarshaller = DescribeNetworkInterfaceAttributeResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeNetworkInterfaceAttributeRequest,DescribeNetworkInterfaceAttributeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeNetworkInterfaces

        internal DescribeNetworkInterfacesResponse DescribeNetworkInterfaces()
        {
            return DescribeNetworkInterfaces(new DescribeNetworkInterfacesRequest());
        }
        internal DescribeNetworkInterfacesResponse DescribeNetworkInterfaces(DescribeNetworkInterfacesRequest request)
        {
            var marshaller = new DescribeNetworkInterfacesRequestMarshaller();
            var unmarshaller = DescribeNetworkInterfacesResponseUnmarshaller.Instance;

            return Invoke<DescribeNetworkInterfacesRequest,DescribeNetworkInterfacesResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Describes one or more of your network interfaces.
        /// </summary>
        /// <param name="cancellationToken"> ttd1
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeNetworkInterfaces service method, as returned by EC2.</returns>
        public Task<DescribeNetworkInterfacesResponse> DescribeNetworkInterfacesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        public Task<DescribeNetworkInterfacesResponse> DescribeNetworkInterfacesAsync(DescribeNetworkInterfacesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeNetworkInterfacesRequestMarshaller();
            var unmarshaller = DescribeNetworkInterfacesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeNetworkInterfacesRequest,DescribeNetworkInterfacesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribePlacementGroups

        internal DescribePlacementGroupsResponse DescribePlacementGroups()
        {
            return DescribePlacementGroups(new DescribePlacementGroupsRequest());
        }
        internal DescribePlacementGroupsResponse DescribePlacementGroups(DescribePlacementGroupsRequest request)
        {
            var marshaller = new DescribePlacementGroupsRequestMarshaller();
            var unmarshaller = DescribePlacementGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribePlacementGroupsRequest,DescribePlacementGroupsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Describes one or more of your placement groups. For more information about placement
        /// groups and cluster instances, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using_cluster_computing.html">Cluster
        /// Instances</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </summary>
        /// <param name="cancellationToken"> ttd1
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribePlacementGroups service method, as returned by EC2.</returns>
        public Task<DescribePlacementGroupsResponse> DescribePlacementGroupsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        public Task<DescribePlacementGroupsResponse> DescribePlacementGroupsAsync(DescribePlacementGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribePlacementGroupsRequestMarshaller();
            var unmarshaller = DescribePlacementGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribePlacementGroupsRequest,DescribePlacementGroupsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribePrefixLists

        internal DescribePrefixListsResponse DescribePrefixLists(DescribePrefixListsRequest request)
        {
            var marshaller = new DescribePrefixListsRequestMarshaller();
            var unmarshaller = DescribePrefixListsResponseUnmarshaller.Instance;

            return Invoke<DescribePrefixListsRequest,DescribePrefixListsResponse>(request, marshaller, unmarshaller);
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
        public Task<DescribePrefixListsResponse> DescribePrefixListsAsync(DescribePrefixListsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribePrefixListsRequestMarshaller();
            var unmarshaller = DescribePrefixListsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribePrefixListsRequest,DescribePrefixListsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeRegions

        internal DescribeRegionsResponse DescribeRegions()
        {
            return DescribeRegions(new DescribeRegionsRequest());
        }
        internal DescribeRegionsResponse DescribeRegions(DescribeRegionsRequest request)
        {
            var marshaller = new DescribeRegionsRequestMarshaller();
            var unmarshaller = DescribeRegionsResponseUnmarshaller.Instance;

            return Invoke<DescribeRegionsRequest,DescribeRegionsResponse>(request, marshaller, unmarshaller);
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
        /// <param name="cancellationToken"> ttd1
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeRegions service method, as returned by EC2.</returns>
        public Task<DescribeRegionsResponse> DescribeRegionsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        public Task<DescribeRegionsResponse> DescribeRegionsAsync(DescribeRegionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeRegionsRequestMarshaller();
            var unmarshaller = DescribeRegionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeRegionsRequest,DescribeRegionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeReservedInstances

        internal DescribeReservedInstancesResponse DescribeReservedInstances()
        {
            return DescribeReservedInstances(new DescribeReservedInstancesRequest());
        }
        internal DescribeReservedInstancesResponse DescribeReservedInstances(DescribeReservedInstancesRequest request)
        {
            var marshaller = new DescribeReservedInstancesRequestMarshaller();
            var unmarshaller = DescribeReservedInstancesResponseUnmarshaller.Instance;

            return Invoke<DescribeReservedInstancesRequest,DescribeReservedInstancesResponse>(request, marshaller, unmarshaller);
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
        /// <param name="cancellationToken"> ttd1
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeReservedInstances service method, as returned by EC2.</returns>
        public Task<DescribeReservedInstancesResponse> DescribeReservedInstancesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        public Task<DescribeReservedInstancesResponse> DescribeReservedInstancesAsync(DescribeReservedInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeReservedInstancesRequestMarshaller();
            var unmarshaller = DescribeReservedInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeReservedInstancesRequest,DescribeReservedInstancesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeReservedInstancesListings

        internal DescribeReservedInstancesListingsResponse DescribeReservedInstancesListings()
        {
            return DescribeReservedInstancesListings(new DescribeReservedInstancesListingsRequest());
        }
        internal DescribeReservedInstancesListingsResponse DescribeReservedInstancesListings(DescribeReservedInstancesListingsRequest request)
        {
            var marshaller = new DescribeReservedInstancesListingsRequestMarshaller();
            var unmarshaller = DescribeReservedInstancesListingsResponseUnmarshaller.Instance;

            return Invoke<DescribeReservedInstancesListingsRequest,DescribeReservedInstancesListingsResponse>(request, marshaller, unmarshaller);
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
        /// For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ri-market-general.html">Reserved
        /// Instance Marketplace</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken"> ttd1
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeReservedInstancesListings service method, as returned by EC2.</returns>
        public Task<DescribeReservedInstancesListingsResponse> DescribeReservedInstancesListingsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        public Task<DescribeReservedInstancesListingsResponse> DescribeReservedInstancesListingsAsync(DescribeReservedInstancesListingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeReservedInstancesListingsRequestMarshaller();
            var unmarshaller = DescribeReservedInstancesListingsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeReservedInstancesListingsRequest,DescribeReservedInstancesListingsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeReservedInstancesModifications

        internal DescribeReservedInstancesModificationsResponse DescribeReservedInstancesModifications()
        {
            return DescribeReservedInstancesModifications(new DescribeReservedInstancesModificationsRequest());
        }
        internal DescribeReservedInstancesModificationsResponse DescribeReservedInstancesModifications(DescribeReservedInstancesModificationsRequest request)
        {
            var marshaller = new DescribeReservedInstancesModificationsRequestMarshaller();
            var unmarshaller = DescribeReservedInstancesModificationsResponseUnmarshaller.Instance;

            return Invoke<DescribeReservedInstancesModificationsRequest,DescribeReservedInstancesModificationsResponse>(request, marshaller, unmarshaller);
        }


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
        /// <param name="cancellationToken"> ttd1
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeReservedInstancesModifications service method, as returned by EC2.</returns>
        public Task<DescribeReservedInstancesModificationsResponse> DescribeReservedInstancesModificationsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        public Task<DescribeReservedInstancesModificationsResponse> DescribeReservedInstancesModificationsAsync(DescribeReservedInstancesModificationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeReservedInstancesModificationsRequestMarshaller();
            var unmarshaller = DescribeReservedInstancesModificationsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeReservedInstancesModificationsRequest,DescribeReservedInstancesModificationsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeReservedInstancesOfferings

        internal DescribeReservedInstancesOfferingsResponse DescribeReservedInstancesOfferings()
        {
            return DescribeReservedInstancesOfferings(new DescribeReservedInstancesOfferingsRequest());
        }
        internal DescribeReservedInstancesOfferingsResponse DescribeReservedInstancesOfferings(DescribeReservedInstancesOfferingsRequest request)
        {
            var marshaller = new DescribeReservedInstancesOfferingsRequestMarshaller();
            var unmarshaller = DescribeReservedInstancesOfferingsResponseUnmarshaller.Instance;

            return Invoke<DescribeReservedInstancesOfferingsRequest,DescribeReservedInstancesOfferingsResponse>(request, marshaller, unmarshaller);
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
        /// <param name="cancellationToken"> ttd1
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeReservedInstancesOfferings service method, as returned by EC2.</returns>
        public Task<DescribeReservedInstancesOfferingsResponse> DescribeReservedInstancesOfferingsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        public Task<DescribeReservedInstancesOfferingsResponse> DescribeReservedInstancesOfferingsAsync(DescribeReservedInstancesOfferingsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeReservedInstancesOfferingsRequestMarshaller();
            var unmarshaller = DescribeReservedInstancesOfferingsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeReservedInstancesOfferingsRequest,DescribeReservedInstancesOfferingsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeRouteTables

        internal DescribeRouteTablesResponse DescribeRouteTables()
        {
            return DescribeRouteTables(new DescribeRouteTablesRequest());
        }
        internal DescribeRouteTablesResponse DescribeRouteTables(DescribeRouteTablesRequest request)
        {
            var marshaller = new DescribeRouteTablesRequestMarshaller();
            var unmarshaller = DescribeRouteTablesResponseUnmarshaller.Instance;

            return Invoke<DescribeRouteTablesRequest,DescribeRouteTablesResponse>(request, marshaller, unmarshaller);
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
        /// For more information about route tables, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Route_Tables.html">Route
        /// Tables</a> in the <i>Amazon Virtual Private Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken"> ttd1
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeRouteTables service method, as returned by EC2.</returns>
        public Task<DescribeRouteTablesResponse> DescribeRouteTablesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        public Task<DescribeRouteTablesResponse> DescribeRouteTablesAsync(DescribeRouteTablesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeRouteTablesRequestMarshaller();
            var unmarshaller = DescribeRouteTablesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeRouteTablesRequest,DescribeRouteTablesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeSecurityGroups

        internal DescribeSecurityGroupsResponse DescribeSecurityGroups()
        {
            return DescribeSecurityGroups(new DescribeSecurityGroupsRequest());
        }
        internal DescribeSecurityGroupsResponse DescribeSecurityGroups(DescribeSecurityGroupsRequest request)
        {
            var marshaller = new DescribeSecurityGroupsRequestMarshaller();
            var unmarshaller = DescribeSecurityGroupsResponseUnmarshaller.Instance;

            return Invoke<DescribeSecurityGroupsRequest,DescribeSecurityGroupsResponse>(request, marshaller, unmarshaller);
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
        /// <param name="cancellationToken"> ttd1
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSecurityGroups service method, as returned by EC2.</returns>
        public Task<DescribeSecurityGroupsResponse> DescribeSecurityGroupsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        public Task<DescribeSecurityGroupsResponse> DescribeSecurityGroupsAsync(DescribeSecurityGroupsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeSecurityGroupsRequestMarshaller();
            var unmarshaller = DescribeSecurityGroupsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSecurityGroupsRequest,DescribeSecurityGroupsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeSnapshotAttribute

        internal DescribeSnapshotAttributeResponse DescribeSnapshotAttribute(DescribeSnapshotAttributeRequest request)
        {
            var marshaller = new DescribeSnapshotAttributeRequestMarshaller();
            var unmarshaller = DescribeSnapshotAttributeResponseUnmarshaller.Instance;

            return Invoke<DescribeSnapshotAttributeRequest,DescribeSnapshotAttributeResponse>(request, marshaller, unmarshaller);
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
        public Task<DescribeSnapshotAttributeResponse> DescribeSnapshotAttributeAsync(DescribeSnapshotAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeSnapshotAttributeRequestMarshaller();
            var unmarshaller = DescribeSnapshotAttributeResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSnapshotAttributeRequest,DescribeSnapshotAttributeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeSnapshots

        internal DescribeSnapshotsResponse DescribeSnapshots()
        {
            return DescribeSnapshots(new DescribeSnapshotsRequest());
        }
        internal DescribeSnapshotsResponse DescribeSnapshots(DescribeSnapshotsRequest request)
        {
            var marshaller = new DescribeSnapshotsRequestMarshaller();
            var unmarshaller = DescribeSnapshotsResponseUnmarshaller.Instance;

            return Invoke<DescribeSnapshotsRequest,DescribeSnapshotsResponse>(request, marshaller, unmarshaller);
        }


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
        /// <param name="cancellationToken"> ttd1
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSnapshots service method, as returned by EC2.</returns>
        public Task<DescribeSnapshotsResponse> DescribeSnapshotsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        public Task<DescribeSnapshotsResponse> DescribeSnapshotsAsync(DescribeSnapshotsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeSnapshotsRequestMarshaller();
            var unmarshaller = DescribeSnapshotsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSnapshotsRequest,DescribeSnapshotsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeSpotDatafeedSubscription

        internal DescribeSpotDatafeedSubscriptionResponse DescribeSpotDatafeedSubscription()
        {
            return DescribeSpotDatafeedSubscription(new DescribeSpotDatafeedSubscriptionRequest());
        }
        internal DescribeSpotDatafeedSubscriptionResponse DescribeSpotDatafeedSubscription(DescribeSpotDatafeedSubscriptionRequest request)
        {
            var marshaller = new DescribeSpotDatafeedSubscriptionRequestMarshaller();
            var unmarshaller = DescribeSpotDatafeedSubscriptionResponseUnmarshaller.Instance;

            return Invoke<DescribeSpotDatafeedSubscriptionRequest,DescribeSpotDatafeedSubscriptionResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Describes the data feed for Spot instances. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/spot-data-feeds.html">Spot
        /// Instance Data Feed</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </summary>
        /// <param name="cancellationToken"> ttd1
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSpotDatafeedSubscription service method, as returned by EC2.</returns>
        public Task<DescribeSpotDatafeedSubscriptionResponse> DescribeSpotDatafeedSubscriptionAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        public Task<DescribeSpotDatafeedSubscriptionResponse> DescribeSpotDatafeedSubscriptionAsync(DescribeSpotDatafeedSubscriptionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeSpotDatafeedSubscriptionRequestMarshaller();
            var unmarshaller = DescribeSpotDatafeedSubscriptionResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSpotDatafeedSubscriptionRequest,DescribeSpotDatafeedSubscriptionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeSpotFleetInstances

        internal DescribeSpotFleetInstancesResponse DescribeSpotFleetInstances(DescribeSpotFleetInstancesRequest request)
        {
            var marshaller = new DescribeSpotFleetInstancesRequestMarshaller();
            var unmarshaller = DescribeSpotFleetInstancesResponseUnmarshaller.Instance;

            return Invoke<DescribeSpotFleetInstancesRequest,DescribeSpotFleetInstancesResponse>(request, marshaller, unmarshaller);
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
        public Task<DescribeSpotFleetInstancesResponse> DescribeSpotFleetInstancesAsync(DescribeSpotFleetInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeSpotFleetInstancesRequestMarshaller();
            var unmarshaller = DescribeSpotFleetInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSpotFleetInstancesRequest,DescribeSpotFleetInstancesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeSpotFleetRequestHistory

        internal DescribeSpotFleetRequestHistoryResponse DescribeSpotFleetRequestHistory(DescribeSpotFleetRequestHistoryRequest request)
        {
            var marshaller = new DescribeSpotFleetRequestHistoryRequestMarshaller();
            var unmarshaller = DescribeSpotFleetRequestHistoryResponseUnmarshaller.Instance;

            return Invoke<DescribeSpotFleetRequestHistoryRequest,DescribeSpotFleetRequestHistoryResponse>(request, marshaller, unmarshaller);
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
        public Task<DescribeSpotFleetRequestHistoryResponse> DescribeSpotFleetRequestHistoryAsync(DescribeSpotFleetRequestHistoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeSpotFleetRequestHistoryRequestMarshaller();
            var unmarshaller = DescribeSpotFleetRequestHistoryResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSpotFleetRequestHistoryRequest,DescribeSpotFleetRequestHistoryResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeSpotFleetRequests

        internal DescribeSpotFleetRequestsResponse DescribeSpotFleetRequests(DescribeSpotFleetRequestsRequest request)
        {
            var marshaller = new DescribeSpotFleetRequestsRequestMarshaller();
            var unmarshaller = DescribeSpotFleetRequestsResponseUnmarshaller.Instance;

            return Invoke<DescribeSpotFleetRequestsRequest,DescribeSpotFleetRequestsResponse>(request, marshaller, unmarshaller);
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
        public Task<DescribeSpotFleetRequestsResponse> DescribeSpotFleetRequestsAsync(DescribeSpotFleetRequestsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeSpotFleetRequestsRequestMarshaller();
            var unmarshaller = DescribeSpotFleetRequestsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSpotFleetRequestsRequest,DescribeSpotFleetRequestsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeSpotInstanceRequests

        internal DescribeSpotInstanceRequestsResponse DescribeSpotInstanceRequests()
        {
            return DescribeSpotInstanceRequests(new DescribeSpotInstanceRequestsRequest());
        }
        internal DescribeSpotInstanceRequestsResponse DescribeSpotInstanceRequests(DescribeSpotInstanceRequestsRequest request)
        {
            var marshaller = new DescribeSpotInstanceRequestsRequestMarshaller();
            var unmarshaller = DescribeSpotInstanceRequestsResponseUnmarshaller.Instance;

            return Invoke<DescribeSpotInstanceRequestsRequest,DescribeSpotInstanceRequestsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Describes the Spot instance requests that belong to your account. Spot instances are
        /// instances that Amazon EC2 launches when the bid price that you specify exceeds the
        /// current Spot price. Amazon EC2 periodically sets the Spot price based on available
        /// Spot instance capacity and current Spot instance requests. For more information, see
        /// <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/spot-requests.html">Spot
        /// Instance Requests</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// 
        ///  
        /// <para>
        /// You can use <code>DescribeSpotInstanceRequests</code> to find a running Spot instance
        /// by examining the response. If the status of the Spot instance is <code>fulfilled</code>,
        /// the instance ID appears in the response and contains the identifier of the instance.
        /// Alternatively, you can use <a>DescribeInstances</a> with a filter to look for instances
        /// where the instance lifecycle is <code>spot</code>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken"> ttd1
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSpotInstanceRequests service method, as returned by EC2.</returns>
        public Task<DescribeSpotInstanceRequestsResponse> DescribeSpotInstanceRequestsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        public Task<DescribeSpotInstanceRequestsResponse> DescribeSpotInstanceRequestsAsync(DescribeSpotInstanceRequestsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeSpotInstanceRequestsRequestMarshaller();
            var unmarshaller = DescribeSpotInstanceRequestsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSpotInstanceRequestsRequest,DescribeSpotInstanceRequestsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeSpotPriceHistory

        internal DescribeSpotPriceHistoryResponse DescribeSpotPriceHistory()
        {
            return DescribeSpotPriceHistory(new DescribeSpotPriceHistoryRequest());
        }
        internal DescribeSpotPriceHistoryResponse DescribeSpotPriceHistory(DescribeSpotPriceHistoryRequest request)
        {
            var marshaller = new DescribeSpotPriceHistoryRequestMarshaller();
            var unmarshaller = DescribeSpotPriceHistoryResponseUnmarshaller.Instance;

            return Invoke<DescribeSpotPriceHistoryRequest,DescribeSpotPriceHistoryResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Describes the Spot price history. The prices returned are listed in chronological
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
        /// <param name="cancellationToken"> ttd1
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSpotPriceHistory service method, as returned by EC2.</returns>
        public Task<DescribeSpotPriceHistoryResponse> DescribeSpotPriceHistoryAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        public Task<DescribeSpotPriceHistoryResponse> DescribeSpotPriceHistoryAsync(DescribeSpotPriceHistoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeSpotPriceHistoryRequestMarshaller();
            var unmarshaller = DescribeSpotPriceHistoryResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSpotPriceHistoryRequest,DescribeSpotPriceHistoryResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeSubnets

        internal DescribeSubnetsResponse DescribeSubnets()
        {
            return DescribeSubnets(new DescribeSubnetsRequest());
        }
        internal DescribeSubnetsResponse DescribeSubnets(DescribeSubnetsRequest request)
        {
            var marshaller = new DescribeSubnetsRequestMarshaller();
            var unmarshaller = DescribeSubnetsResponseUnmarshaller.Instance;

            return Invoke<DescribeSubnetsRequest,DescribeSubnetsResponse>(request, marshaller, unmarshaller);
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
        /// <param name="cancellationToken"> ttd1
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeSubnets service method, as returned by EC2.</returns>
        public Task<DescribeSubnetsResponse> DescribeSubnetsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        public Task<DescribeSubnetsResponse> DescribeSubnetsAsync(DescribeSubnetsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeSubnetsRequestMarshaller();
            var unmarshaller = DescribeSubnetsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeSubnetsRequest,DescribeSubnetsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeTags

        internal DescribeTagsResponse DescribeTags()
        {
            return DescribeTags(new DescribeTagsRequest());
        }
        internal DescribeTagsResponse DescribeTags(DescribeTagsRequest request)
        {
            var marshaller = new DescribeTagsRequestMarshaller();
            var unmarshaller = DescribeTagsResponseUnmarshaller.Instance;

            return Invoke<DescribeTagsRequest,DescribeTagsResponse>(request, marshaller, unmarshaller);
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
        /// <param name="cancellationToken"> ttd1
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTags service method, as returned by EC2.</returns>
        public Task<DescribeTagsResponse> DescribeTagsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        public Task<DescribeTagsResponse> DescribeTagsAsync(DescribeTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeTagsRequestMarshaller();
            var unmarshaller = DescribeTagsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTagsRequest,DescribeTagsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeVolumeAttribute

        internal DescribeVolumeAttributeResponse DescribeVolumeAttribute(DescribeVolumeAttributeRequest request)
        {
            var marshaller = new DescribeVolumeAttributeRequestMarshaller();
            var unmarshaller = DescribeVolumeAttributeResponseUnmarshaller.Instance;

            return Invoke<DescribeVolumeAttributeRequest,DescribeVolumeAttributeResponse>(request, marshaller, unmarshaller);
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
        public Task<DescribeVolumeAttributeResponse> DescribeVolumeAttributeAsync(DescribeVolumeAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeVolumeAttributeRequestMarshaller();
            var unmarshaller = DescribeVolumeAttributeResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeVolumeAttributeRequest,DescribeVolumeAttributeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeVolumes

        internal DescribeVolumesResponse DescribeVolumes()
        {
            return DescribeVolumes(new DescribeVolumesRequest());
        }
        internal DescribeVolumesResponse DescribeVolumes(DescribeVolumesRequest request)
        {
            var marshaller = new DescribeVolumesRequestMarshaller();
            var unmarshaller = DescribeVolumesResponseUnmarshaller.Instance;

            return Invoke<DescribeVolumesRequest,DescribeVolumesResponse>(request, marshaller, unmarshaller);
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
        /// For more information about EBS volumes, see <a href='http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSVolumes.html'>Amazon
        /// EBS Volumes</a> in the <i>Amazon Elastic Compute Cloud User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken"> ttd1
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeVolumes service method, as returned by EC2.</returns>
        public Task<DescribeVolumesResponse> DescribeVolumesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        public Task<DescribeVolumesResponse> DescribeVolumesAsync(DescribeVolumesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeVolumesRequestMarshaller();
            var unmarshaller = DescribeVolumesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeVolumesRequest,DescribeVolumesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeVolumeStatus

        internal DescribeVolumeStatusResponse DescribeVolumeStatus()
        {
            return DescribeVolumeStatus(new DescribeVolumeStatusRequest());
        }
        internal DescribeVolumeStatusResponse DescribeVolumeStatus(DescribeVolumeStatusRequest request)
        {
            var marshaller = new DescribeVolumeStatusRequestMarshaller();
            var unmarshaller = DescribeVolumeStatusResponseUnmarshaller.Instance;

            return Invoke<DescribeVolumeStatusRequest,DescribeVolumeStatusResponse>(request, marshaller, unmarshaller);
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
        ///  <note> 
        /// <para>
        /// Volume status is based on the volume status checks, and does not reflect the volume
        /// state. Therefore, volume status does not indicate volumes in the <code>error</code>
        /// state (for example, when a volume is incapable of accepting I/O.)
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="cancellationToken"> ttd1
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeVolumeStatus service method, as returned by EC2.</returns>
        public Task<DescribeVolumeStatusResponse> DescribeVolumeStatusAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        public Task<DescribeVolumeStatusResponse> DescribeVolumeStatusAsync(DescribeVolumeStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeVolumeStatusRequestMarshaller();
            var unmarshaller = DescribeVolumeStatusResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeVolumeStatusRequest,DescribeVolumeStatusResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeVpcAttribute

        internal DescribeVpcAttributeResponse DescribeVpcAttribute(DescribeVpcAttributeRequest request)
        {
            var marshaller = new DescribeVpcAttributeRequestMarshaller();
            var unmarshaller = DescribeVpcAttributeResponseUnmarshaller.Instance;

            return Invoke<DescribeVpcAttributeRequest,DescribeVpcAttributeResponse>(request, marshaller, unmarshaller);
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
        public Task<DescribeVpcAttributeResponse> DescribeVpcAttributeAsync(DescribeVpcAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeVpcAttributeRequestMarshaller();
            var unmarshaller = DescribeVpcAttributeResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeVpcAttributeRequest,DescribeVpcAttributeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeVpcClassicLink

        internal DescribeVpcClassicLinkResponse DescribeVpcClassicLink(DescribeVpcClassicLinkRequest request)
        {
            var marshaller = new DescribeVpcClassicLinkRequestMarshaller();
            var unmarshaller = DescribeVpcClassicLinkResponseUnmarshaller.Instance;

            return Invoke<DescribeVpcClassicLinkRequest,DescribeVpcClassicLinkResponse>(request, marshaller, unmarshaller);
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
        public Task<DescribeVpcClassicLinkResponse> DescribeVpcClassicLinkAsync(DescribeVpcClassicLinkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeVpcClassicLinkRequestMarshaller();
            var unmarshaller = DescribeVpcClassicLinkResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeVpcClassicLinkRequest,DescribeVpcClassicLinkResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeVpcEndpoints

        internal DescribeVpcEndpointsResponse DescribeVpcEndpoints(DescribeVpcEndpointsRequest request)
        {
            var marshaller = new DescribeVpcEndpointsRequestMarshaller();
            var unmarshaller = DescribeVpcEndpointsResponseUnmarshaller.Instance;

            return Invoke<DescribeVpcEndpointsRequest,DescribeVpcEndpointsResponse>(request, marshaller, unmarshaller);
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
        public Task<DescribeVpcEndpointsResponse> DescribeVpcEndpointsAsync(DescribeVpcEndpointsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeVpcEndpointsRequestMarshaller();
            var unmarshaller = DescribeVpcEndpointsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeVpcEndpointsRequest,DescribeVpcEndpointsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeVpcEndpointServices

        internal DescribeVpcEndpointServicesResponse DescribeVpcEndpointServices(DescribeVpcEndpointServicesRequest request)
        {
            var marshaller = new DescribeVpcEndpointServicesRequestMarshaller();
            var unmarshaller = DescribeVpcEndpointServicesResponseUnmarshaller.Instance;

            return Invoke<DescribeVpcEndpointServicesRequest,DescribeVpcEndpointServicesResponse>(request, marshaller, unmarshaller);
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
        public Task<DescribeVpcEndpointServicesResponse> DescribeVpcEndpointServicesAsync(DescribeVpcEndpointServicesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeVpcEndpointServicesRequestMarshaller();
            var unmarshaller = DescribeVpcEndpointServicesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeVpcEndpointServicesRequest,DescribeVpcEndpointServicesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeVpcPeeringConnections

        internal DescribeVpcPeeringConnectionsResponse DescribeVpcPeeringConnections()
        {
            return DescribeVpcPeeringConnections(new DescribeVpcPeeringConnectionsRequest());
        }
        internal DescribeVpcPeeringConnectionsResponse DescribeVpcPeeringConnections(DescribeVpcPeeringConnectionsRequest request)
        {
            var marshaller = new DescribeVpcPeeringConnectionsRequestMarshaller();
            var unmarshaller = DescribeVpcPeeringConnectionsResponseUnmarshaller.Instance;

            return Invoke<DescribeVpcPeeringConnectionsRequest,DescribeVpcPeeringConnectionsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Describes one or more of your VPC peering connections.
        /// </summary>
        /// <param name="cancellationToken"> ttd1
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeVpcPeeringConnections service method, as returned by EC2.</returns>
        public Task<DescribeVpcPeeringConnectionsResponse> DescribeVpcPeeringConnectionsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        public Task<DescribeVpcPeeringConnectionsResponse> DescribeVpcPeeringConnectionsAsync(DescribeVpcPeeringConnectionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeVpcPeeringConnectionsRequestMarshaller();
            var unmarshaller = DescribeVpcPeeringConnectionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeVpcPeeringConnectionsRequest,DescribeVpcPeeringConnectionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeVpcs

        internal DescribeVpcsResponse DescribeVpcs()
        {
            return DescribeVpcs(new DescribeVpcsRequest());
        }
        internal DescribeVpcsResponse DescribeVpcs(DescribeVpcsRequest request)
        {
            var marshaller = new DescribeVpcsRequestMarshaller();
            var unmarshaller = DescribeVpcsResponseUnmarshaller.Instance;

            return Invoke<DescribeVpcsRequest,DescribeVpcsResponse>(request, marshaller, unmarshaller);
        }


        /// <summary>
        /// Describes one or more of your VPCs.
        /// </summary>
        /// <param name="cancellationToken"> ttd1
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeVpcs service method, as returned by EC2.</returns>
        public Task<DescribeVpcsResponse> DescribeVpcsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        public Task<DescribeVpcsResponse> DescribeVpcsAsync(DescribeVpcsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeVpcsRequestMarshaller();
            var unmarshaller = DescribeVpcsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeVpcsRequest,DescribeVpcsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeVpnConnections

        internal DescribeVpnConnectionsResponse DescribeVpnConnections()
        {
            return DescribeVpnConnections(new DescribeVpnConnectionsRequest());
        }
        internal DescribeVpnConnectionsResponse DescribeVpnConnections(DescribeVpnConnectionsRequest request)
        {
            var marshaller = new DescribeVpnConnectionsRequestMarshaller();
            var unmarshaller = DescribeVpnConnectionsResponseUnmarshaller.Instance;

            return Invoke<DescribeVpnConnectionsRequest,DescribeVpnConnectionsResponse>(request, marshaller, unmarshaller);
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
        /// <param name="cancellationToken"> ttd1
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeVpnConnections service method, as returned by EC2.</returns>
        public Task<DescribeVpnConnectionsResponse> DescribeVpnConnectionsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        public Task<DescribeVpnConnectionsResponse> DescribeVpnConnectionsAsync(DescribeVpnConnectionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeVpnConnectionsRequestMarshaller();
            var unmarshaller = DescribeVpnConnectionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeVpnConnectionsRequest,DescribeVpnConnectionsResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DescribeVpnGateways

        internal DescribeVpnGatewaysResponse DescribeVpnGateways()
        {
            return DescribeVpnGateways(new DescribeVpnGatewaysRequest());
        }
        internal DescribeVpnGatewaysResponse DescribeVpnGateways(DescribeVpnGatewaysRequest request)
        {
            var marshaller = new DescribeVpnGatewaysRequestMarshaller();
            var unmarshaller = DescribeVpnGatewaysResponseUnmarshaller.Instance;

            return Invoke<DescribeVpnGatewaysRequest,DescribeVpnGatewaysResponse>(request, marshaller, unmarshaller);
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
        /// <param name="cancellationToken"> ttd1
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeVpnGateways service method, as returned by EC2.</returns>
        public Task<DescribeVpnGatewaysResponse> DescribeVpnGatewaysAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
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
        public Task<DescribeVpnGatewaysResponse> DescribeVpnGatewaysAsync(DescribeVpnGatewaysRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DescribeVpnGatewaysRequestMarshaller();
            var unmarshaller = DescribeVpnGatewaysResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeVpnGatewaysRequest,DescribeVpnGatewaysResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DetachClassicLinkVpc

        internal DetachClassicLinkVpcResponse DetachClassicLinkVpc(DetachClassicLinkVpcRequest request)
        {
            var marshaller = new DetachClassicLinkVpcRequestMarshaller();
            var unmarshaller = DetachClassicLinkVpcResponseUnmarshaller.Instance;

            return Invoke<DetachClassicLinkVpcRequest,DetachClassicLinkVpcResponse>(request, marshaller, unmarshaller);
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
        public Task<DetachClassicLinkVpcResponse> DetachClassicLinkVpcAsync(DetachClassicLinkVpcRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DetachClassicLinkVpcRequestMarshaller();
            var unmarshaller = DetachClassicLinkVpcResponseUnmarshaller.Instance;

            return InvokeAsync<DetachClassicLinkVpcRequest,DetachClassicLinkVpcResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DetachInternetGateway

        internal DetachInternetGatewayResponse DetachInternetGateway(DetachInternetGatewayRequest request)
        {
            var marshaller = new DetachInternetGatewayRequestMarshaller();
            var unmarshaller = DetachInternetGatewayResponseUnmarshaller.Instance;

            return Invoke<DetachInternetGatewayRequest,DetachInternetGatewayResponse>(request, marshaller, unmarshaller);
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
        public Task<DetachInternetGatewayResponse> DetachInternetGatewayAsync(DetachInternetGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DetachInternetGatewayRequestMarshaller();
            var unmarshaller = DetachInternetGatewayResponseUnmarshaller.Instance;

            return InvokeAsync<DetachInternetGatewayRequest,DetachInternetGatewayResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DetachNetworkInterface

        internal DetachNetworkInterfaceResponse DetachNetworkInterface(DetachNetworkInterfaceRequest request)
        {
            var marshaller = new DetachNetworkInterfaceRequestMarshaller();
            var unmarshaller = DetachNetworkInterfaceResponseUnmarshaller.Instance;

            return Invoke<DetachNetworkInterfaceRequest,DetachNetworkInterfaceResponse>(request, marshaller, unmarshaller);
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
        public Task<DetachNetworkInterfaceResponse> DetachNetworkInterfaceAsync(DetachNetworkInterfaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DetachNetworkInterfaceRequestMarshaller();
            var unmarshaller = DetachNetworkInterfaceResponseUnmarshaller.Instance;

            return InvokeAsync<DetachNetworkInterfaceRequest,DetachNetworkInterfaceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DetachVolume

        internal DetachVolumeResponse DetachVolume(DetachVolumeRequest request)
        {
            var marshaller = new DetachVolumeRequestMarshaller();
            var unmarshaller = DetachVolumeResponseUnmarshaller.Instance;

            return Invoke<DetachVolumeRequest,DetachVolumeResponse>(request, marshaller, unmarshaller);
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
        public Task<DetachVolumeResponse> DetachVolumeAsync(DetachVolumeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DetachVolumeRequestMarshaller();
            var unmarshaller = DetachVolumeResponseUnmarshaller.Instance;

            return InvokeAsync<DetachVolumeRequest,DetachVolumeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DetachVpnGateway

        internal DetachVpnGatewayResponse DetachVpnGateway(DetachVpnGatewayRequest request)
        {
            var marshaller = new DetachVpnGatewayRequestMarshaller();
            var unmarshaller = DetachVpnGatewayResponseUnmarshaller.Instance;

            return Invoke<DetachVpnGatewayRequest,DetachVpnGatewayResponse>(request, marshaller, unmarshaller);
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
        public Task<DetachVpnGatewayResponse> DetachVpnGatewayAsync(DetachVpnGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DetachVpnGatewayRequestMarshaller();
            var unmarshaller = DetachVpnGatewayResponseUnmarshaller.Instance;

            return InvokeAsync<DetachVpnGatewayRequest,DetachVpnGatewayResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DisableVgwRoutePropagation

        internal DisableVgwRoutePropagationResponse DisableVgwRoutePropagation(DisableVgwRoutePropagationRequest request)
        {
            var marshaller = new DisableVgwRoutePropagationRequestMarshaller();
            var unmarshaller = DisableVgwRoutePropagationResponseUnmarshaller.Instance;

            return Invoke<DisableVgwRoutePropagationRequest,DisableVgwRoutePropagationResponse>(request, marshaller, unmarshaller);
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
        public Task<DisableVgwRoutePropagationResponse> DisableVgwRoutePropagationAsync(DisableVgwRoutePropagationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DisableVgwRoutePropagationRequestMarshaller();
            var unmarshaller = DisableVgwRoutePropagationResponseUnmarshaller.Instance;

            return InvokeAsync<DisableVgwRoutePropagationRequest,DisableVgwRoutePropagationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DisableVpcClassicLink

        internal DisableVpcClassicLinkResponse DisableVpcClassicLink(DisableVpcClassicLinkRequest request)
        {
            var marshaller = new DisableVpcClassicLinkRequestMarshaller();
            var unmarshaller = DisableVpcClassicLinkResponseUnmarshaller.Instance;

            return Invoke<DisableVpcClassicLinkRequest,DisableVpcClassicLinkResponse>(request, marshaller, unmarshaller);
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
        public Task<DisableVpcClassicLinkResponse> DisableVpcClassicLinkAsync(DisableVpcClassicLinkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DisableVpcClassicLinkRequestMarshaller();
            var unmarshaller = DisableVpcClassicLinkResponseUnmarshaller.Instance;

            return InvokeAsync<DisableVpcClassicLinkRequest,DisableVpcClassicLinkResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DisassociateAddress

        internal DisassociateAddressResponse DisassociateAddress(DisassociateAddressRequest request)
        {
            var marshaller = new DisassociateAddressRequestMarshaller();
            var unmarshaller = DisassociateAddressResponseUnmarshaller.Instance;

            return Invoke<DisassociateAddressRequest,DisassociateAddressResponse>(request, marshaller, unmarshaller);
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
        public Task<DisassociateAddressResponse> DisassociateAddressAsync(DisassociateAddressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DisassociateAddressRequestMarshaller();
            var unmarshaller = DisassociateAddressResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateAddressRequest,DisassociateAddressResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  DisassociateRouteTable

        internal DisassociateRouteTableResponse DisassociateRouteTable(DisassociateRouteTableRequest request)
        {
            var marshaller = new DisassociateRouteTableRequestMarshaller();
            var unmarshaller = DisassociateRouteTableResponseUnmarshaller.Instance;

            return Invoke<DisassociateRouteTableRequest,DisassociateRouteTableResponse>(request, marshaller, unmarshaller);
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
        public Task<DisassociateRouteTableResponse> DisassociateRouteTableAsync(DisassociateRouteTableRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new DisassociateRouteTableRequestMarshaller();
            var unmarshaller = DisassociateRouteTableResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateRouteTableRequest,DisassociateRouteTableResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  EnableVgwRoutePropagation

        internal EnableVgwRoutePropagationResponse EnableVgwRoutePropagation(EnableVgwRoutePropagationRequest request)
        {
            var marshaller = new EnableVgwRoutePropagationRequestMarshaller();
            var unmarshaller = EnableVgwRoutePropagationResponseUnmarshaller.Instance;

            return Invoke<EnableVgwRoutePropagationRequest,EnableVgwRoutePropagationResponse>(request, marshaller, unmarshaller);
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
        public Task<EnableVgwRoutePropagationResponse> EnableVgwRoutePropagationAsync(EnableVgwRoutePropagationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new EnableVgwRoutePropagationRequestMarshaller();
            var unmarshaller = EnableVgwRoutePropagationResponseUnmarshaller.Instance;

            return InvokeAsync<EnableVgwRoutePropagationRequest,EnableVgwRoutePropagationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  EnableVolumeIO

        internal EnableVolumeIOResponse EnableVolumeIO(EnableVolumeIORequest request)
        {
            var marshaller = new EnableVolumeIORequestMarshaller();
            var unmarshaller = EnableVolumeIOResponseUnmarshaller.Instance;

            return Invoke<EnableVolumeIORequest,EnableVolumeIOResponse>(request, marshaller, unmarshaller);
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
        public Task<EnableVolumeIOResponse> EnableVolumeIOAsync(EnableVolumeIORequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new EnableVolumeIORequestMarshaller();
            var unmarshaller = EnableVolumeIOResponseUnmarshaller.Instance;

            return InvokeAsync<EnableVolumeIORequest,EnableVolumeIOResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  EnableVpcClassicLink

        internal EnableVpcClassicLinkResponse EnableVpcClassicLink(EnableVpcClassicLinkRequest request)
        {
            var marshaller = new EnableVpcClassicLinkRequestMarshaller();
            var unmarshaller = EnableVpcClassicLinkResponseUnmarshaller.Instance;

            return Invoke<EnableVpcClassicLinkRequest,EnableVpcClassicLinkResponse>(request, marshaller, unmarshaller);
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
        public Task<EnableVpcClassicLinkResponse> EnableVpcClassicLinkAsync(EnableVpcClassicLinkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new EnableVpcClassicLinkRequestMarshaller();
            var unmarshaller = EnableVpcClassicLinkResponseUnmarshaller.Instance;

            return InvokeAsync<EnableVpcClassicLinkRequest,EnableVpcClassicLinkResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetConsoleOutput

        internal GetConsoleOutputResponse GetConsoleOutput(GetConsoleOutputRequest request)
        {
            var marshaller = new GetConsoleOutputRequestMarshaller();
            var unmarshaller = GetConsoleOutputResponseUnmarshaller.Instance;

            return Invoke<GetConsoleOutputRequest,GetConsoleOutputResponse>(request, marshaller, unmarshaller);
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
        public Task<GetConsoleOutputResponse> GetConsoleOutputAsync(GetConsoleOutputRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetConsoleOutputRequestMarshaller();
            var unmarshaller = GetConsoleOutputResponseUnmarshaller.Instance;

            return InvokeAsync<GetConsoleOutputRequest,GetConsoleOutputResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  GetPasswordData

        internal GetPasswordDataResponse GetPasswordData(GetPasswordDataRequest request)
        {
            var marshaller = new GetPasswordDataRequestMarshaller();
            var unmarshaller = GetPasswordDataResponseUnmarshaller.Instance;

            return Invoke<GetPasswordDataRequest,GetPasswordDataResponse>(request, marshaller, unmarshaller);
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
        public Task<GetPasswordDataResponse> GetPasswordDataAsync(GetPasswordDataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new GetPasswordDataRequestMarshaller();
            var unmarshaller = GetPasswordDataResponseUnmarshaller.Instance;

            return InvokeAsync<GetPasswordDataRequest,GetPasswordDataResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ImportImage

        internal ImportImageResponse ImportImage(ImportImageRequest request)
        {
            var marshaller = new ImportImageRequestMarshaller();
            var unmarshaller = ImportImageResponseUnmarshaller.Instance;

            return Invoke<ImportImageRequest,ImportImageResponse>(request, marshaller, unmarshaller);
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
        public Task<ImportImageResponse> ImportImageAsync(ImportImageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ImportImageRequestMarshaller();
            var unmarshaller = ImportImageResponseUnmarshaller.Instance;

            return InvokeAsync<ImportImageRequest,ImportImageResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ImportInstance

        internal ImportInstanceResponse ImportInstance(ImportInstanceRequest request)
        {
            var marshaller = new ImportInstanceRequestMarshaller();
            var unmarshaller = ImportInstanceResponseUnmarshaller.Instance;

            return Invoke<ImportInstanceRequest,ImportInstanceResponse>(request, marshaller, unmarshaller);
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
        public Task<ImportInstanceResponse> ImportInstanceAsync(ImportInstanceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ImportInstanceRequestMarshaller();
            var unmarshaller = ImportInstanceResponseUnmarshaller.Instance;

            return InvokeAsync<ImportInstanceRequest,ImportInstanceResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ImportKeyPair

        internal ImportKeyPairResponse ImportKeyPair(ImportKeyPairRequest request)
        {
            var marshaller = new ImportKeyPairRequestMarshaller();
            var unmarshaller = ImportKeyPairResponseUnmarshaller.Instance;

            return Invoke<ImportKeyPairRequest,ImportKeyPairResponse>(request, marshaller, unmarshaller);
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
        public Task<ImportKeyPairResponse> ImportKeyPairAsync(ImportKeyPairRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ImportKeyPairRequestMarshaller();
            var unmarshaller = ImportKeyPairResponseUnmarshaller.Instance;

            return InvokeAsync<ImportKeyPairRequest,ImportKeyPairResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ImportSnapshot

        internal ImportSnapshotResponse ImportSnapshot(ImportSnapshotRequest request)
        {
            var marshaller = new ImportSnapshotRequestMarshaller();
            var unmarshaller = ImportSnapshotResponseUnmarshaller.Instance;

            return Invoke<ImportSnapshotRequest,ImportSnapshotResponse>(request, marshaller, unmarshaller);
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
        public Task<ImportSnapshotResponse> ImportSnapshotAsync(ImportSnapshotRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ImportSnapshotRequestMarshaller();
            var unmarshaller = ImportSnapshotResponseUnmarshaller.Instance;

            return InvokeAsync<ImportSnapshotRequest,ImportSnapshotResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ImportVolume

        internal ImportVolumeResponse ImportVolume(ImportVolumeRequest request)
        {
            var marshaller = new ImportVolumeRequestMarshaller();
            var unmarshaller = ImportVolumeResponseUnmarshaller.Instance;

            return Invoke<ImportVolumeRequest,ImportVolumeResponse>(request, marshaller, unmarshaller);
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
        public Task<ImportVolumeResponse> ImportVolumeAsync(ImportVolumeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ImportVolumeRequestMarshaller();
            var unmarshaller = ImportVolumeResponseUnmarshaller.Instance;

            return InvokeAsync<ImportVolumeRequest,ImportVolumeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ModifyImageAttribute

        internal ModifyImageAttributeResponse ModifyImageAttribute(ModifyImageAttributeRequest request)
        {
            var marshaller = new ModifyImageAttributeRequestMarshaller();
            var unmarshaller = ModifyImageAttributeResponseUnmarshaller.Instance;

            return Invoke<ModifyImageAttributeRequest,ModifyImageAttributeResponse>(request, marshaller, unmarshaller);
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
        public Task<ModifyImageAttributeResponse> ModifyImageAttributeAsync(ModifyImageAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ModifyImageAttributeRequestMarshaller();
            var unmarshaller = ModifyImageAttributeResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyImageAttributeRequest,ModifyImageAttributeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ModifyInstanceAttribute

        internal ModifyInstanceAttributeResponse ModifyInstanceAttribute(ModifyInstanceAttributeRequest request)
        {
            var marshaller = new ModifyInstanceAttributeRequestMarshaller();
            var unmarshaller = ModifyInstanceAttributeResponseUnmarshaller.Instance;

            return Invoke<ModifyInstanceAttributeRequest,ModifyInstanceAttributeResponse>(request, marshaller, unmarshaller);
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
        public Task<ModifyInstanceAttributeResponse> ModifyInstanceAttributeAsync(ModifyInstanceAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ModifyInstanceAttributeRequestMarshaller();
            var unmarshaller = ModifyInstanceAttributeResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyInstanceAttributeRequest,ModifyInstanceAttributeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ModifyNetworkInterfaceAttribute

        internal ModifyNetworkInterfaceAttributeResponse ModifyNetworkInterfaceAttribute(ModifyNetworkInterfaceAttributeRequest request)
        {
            var marshaller = new ModifyNetworkInterfaceAttributeRequestMarshaller();
            var unmarshaller = ModifyNetworkInterfaceAttributeResponseUnmarshaller.Instance;

            return Invoke<ModifyNetworkInterfaceAttributeRequest,ModifyNetworkInterfaceAttributeResponse>(request, marshaller, unmarshaller);
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
        public Task<ModifyNetworkInterfaceAttributeResponse> ModifyNetworkInterfaceAttributeAsync(ModifyNetworkInterfaceAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ModifyNetworkInterfaceAttributeRequestMarshaller();
            var unmarshaller = ModifyNetworkInterfaceAttributeResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyNetworkInterfaceAttributeRequest,ModifyNetworkInterfaceAttributeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ModifyReservedInstances

        internal ModifyReservedInstancesResponse ModifyReservedInstances(ModifyReservedInstancesRequest request)
        {
            var marshaller = new ModifyReservedInstancesRequestMarshaller();
            var unmarshaller = ModifyReservedInstancesResponseUnmarshaller.Instance;

            return Invoke<ModifyReservedInstancesRequest,ModifyReservedInstancesResponse>(request, marshaller, unmarshaller);
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
        public Task<ModifyReservedInstancesResponse> ModifyReservedInstancesAsync(ModifyReservedInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ModifyReservedInstancesRequestMarshaller();
            var unmarshaller = ModifyReservedInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyReservedInstancesRequest,ModifyReservedInstancesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ModifySnapshotAttribute

        internal ModifySnapshotAttributeResponse ModifySnapshotAttribute(ModifySnapshotAttributeRequest request)
        {
            var marshaller = new ModifySnapshotAttributeRequestMarshaller();
            var unmarshaller = ModifySnapshotAttributeResponseUnmarshaller.Instance;

            return Invoke<ModifySnapshotAttributeRequest,ModifySnapshotAttributeResponse>(request, marshaller, unmarshaller);
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
        public Task<ModifySnapshotAttributeResponse> ModifySnapshotAttributeAsync(ModifySnapshotAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ModifySnapshotAttributeRequestMarshaller();
            var unmarshaller = ModifySnapshotAttributeResponseUnmarshaller.Instance;

            return InvokeAsync<ModifySnapshotAttributeRequest,ModifySnapshotAttributeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ModifySpotFleetRequest

        internal ModifySpotFleetRequestResponse ModifySpotFleetRequest(ModifySpotFleetRequestRequest request)
        {
            var marshaller = new ModifySpotFleetRequestRequestMarshaller();
            var unmarshaller = ModifySpotFleetRequestResponseUnmarshaller.Instance;

            return Invoke<ModifySpotFleetRequestRequest,ModifySpotFleetRequestResponse>(request, marshaller, unmarshaller);
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
        public Task<ModifySpotFleetRequestResponse> ModifySpotFleetRequestAsync(ModifySpotFleetRequestRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ModifySpotFleetRequestRequestMarshaller();
            var unmarshaller = ModifySpotFleetRequestResponseUnmarshaller.Instance;

            return InvokeAsync<ModifySpotFleetRequestRequest,ModifySpotFleetRequestResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ModifySubnetAttribute

        internal ModifySubnetAttributeResponse ModifySubnetAttribute(ModifySubnetAttributeRequest request)
        {
            var marshaller = new ModifySubnetAttributeRequestMarshaller();
            var unmarshaller = ModifySubnetAttributeResponseUnmarshaller.Instance;

            return Invoke<ModifySubnetAttributeRequest,ModifySubnetAttributeResponse>(request, marshaller, unmarshaller);
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
        public Task<ModifySubnetAttributeResponse> ModifySubnetAttributeAsync(ModifySubnetAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ModifySubnetAttributeRequestMarshaller();
            var unmarshaller = ModifySubnetAttributeResponseUnmarshaller.Instance;

            return InvokeAsync<ModifySubnetAttributeRequest,ModifySubnetAttributeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ModifyVolumeAttribute

        internal ModifyVolumeAttributeResponse ModifyVolumeAttribute(ModifyVolumeAttributeRequest request)
        {
            var marshaller = new ModifyVolumeAttributeRequestMarshaller();
            var unmarshaller = ModifyVolumeAttributeResponseUnmarshaller.Instance;

            return Invoke<ModifyVolumeAttributeRequest,ModifyVolumeAttributeResponse>(request, marshaller, unmarshaller);
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
        public Task<ModifyVolumeAttributeResponse> ModifyVolumeAttributeAsync(ModifyVolumeAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ModifyVolumeAttributeRequestMarshaller();
            var unmarshaller = ModifyVolumeAttributeResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyVolumeAttributeRequest,ModifyVolumeAttributeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ModifyVpcAttribute

        internal ModifyVpcAttributeResponse ModifyVpcAttribute(ModifyVpcAttributeRequest request)
        {
            var marshaller = new ModifyVpcAttributeRequestMarshaller();
            var unmarshaller = ModifyVpcAttributeResponseUnmarshaller.Instance;

            return Invoke<ModifyVpcAttributeRequest,ModifyVpcAttributeResponse>(request, marshaller, unmarshaller);
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
        public Task<ModifyVpcAttributeResponse> ModifyVpcAttributeAsync(ModifyVpcAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ModifyVpcAttributeRequestMarshaller();
            var unmarshaller = ModifyVpcAttributeResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyVpcAttributeRequest,ModifyVpcAttributeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ModifyVpcEndpoint

        internal ModifyVpcEndpointResponse ModifyVpcEndpoint(ModifyVpcEndpointRequest request)
        {
            var marshaller = new ModifyVpcEndpointRequestMarshaller();
            var unmarshaller = ModifyVpcEndpointResponseUnmarshaller.Instance;

            return Invoke<ModifyVpcEndpointRequest,ModifyVpcEndpointResponse>(request, marshaller, unmarshaller);
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
        public Task<ModifyVpcEndpointResponse> ModifyVpcEndpointAsync(ModifyVpcEndpointRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ModifyVpcEndpointRequestMarshaller();
            var unmarshaller = ModifyVpcEndpointResponseUnmarshaller.Instance;

            return InvokeAsync<ModifyVpcEndpointRequest,ModifyVpcEndpointResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  MonitorInstances

        internal MonitorInstancesResponse MonitorInstances(MonitorInstancesRequest request)
        {
            var marshaller = new MonitorInstancesRequestMarshaller();
            var unmarshaller = MonitorInstancesResponseUnmarshaller.Instance;

            return Invoke<MonitorInstancesRequest,MonitorInstancesResponse>(request, marshaller, unmarshaller);
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
        public Task<MonitorInstancesResponse> MonitorInstancesAsync(MonitorInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new MonitorInstancesRequestMarshaller();
            var unmarshaller = MonitorInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<MonitorInstancesRequest,MonitorInstancesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  MoveAddressToVpc

        internal MoveAddressToVpcResponse MoveAddressToVpc(MoveAddressToVpcRequest request)
        {
            var marshaller = new MoveAddressToVpcRequestMarshaller();
            var unmarshaller = MoveAddressToVpcResponseUnmarshaller.Instance;

            return Invoke<MoveAddressToVpcRequest,MoveAddressToVpcResponse>(request, marshaller, unmarshaller);
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
        public Task<MoveAddressToVpcResponse> MoveAddressToVpcAsync(MoveAddressToVpcRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new MoveAddressToVpcRequestMarshaller();
            var unmarshaller = MoveAddressToVpcResponseUnmarshaller.Instance;

            return InvokeAsync<MoveAddressToVpcRequest,MoveAddressToVpcResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  PurchaseReservedInstancesOffering

        internal PurchaseReservedInstancesOfferingResponse PurchaseReservedInstancesOffering(PurchaseReservedInstancesOfferingRequest request)
        {
            var marshaller = new PurchaseReservedInstancesOfferingRequestMarshaller();
            var unmarshaller = PurchaseReservedInstancesOfferingResponseUnmarshaller.Instance;

            return Invoke<PurchaseReservedInstancesOfferingRequest,PurchaseReservedInstancesOfferingResponse>(request, marshaller, unmarshaller);
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
        public Task<PurchaseReservedInstancesOfferingResponse> PurchaseReservedInstancesOfferingAsync(PurchaseReservedInstancesOfferingRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new PurchaseReservedInstancesOfferingRequestMarshaller();
            var unmarshaller = PurchaseReservedInstancesOfferingResponseUnmarshaller.Instance;

            return InvokeAsync<PurchaseReservedInstancesOfferingRequest,PurchaseReservedInstancesOfferingResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RebootInstances

        internal RebootInstancesResponse RebootInstances(RebootInstancesRequest request)
        {
            var marshaller = new RebootInstancesRequestMarshaller();
            var unmarshaller = RebootInstancesResponseUnmarshaller.Instance;

            return Invoke<RebootInstancesRequest,RebootInstancesResponse>(request, marshaller, unmarshaller);
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
        public Task<RebootInstancesResponse> RebootInstancesAsync(RebootInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RebootInstancesRequestMarshaller();
            var unmarshaller = RebootInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<RebootInstancesRequest,RebootInstancesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RegisterImage

        internal RegisterImageResponse RegisterImage(RegisterImageRequest request)
        {
            var marshaller = new RegisterImageRequestMarshaller();
            var unmarshaller = RegisterImageResponseUnmarshaller.Instance;

            return Invoke<RegisterImageRequest,RegisterImageResponse>(request, marshaller, unmarshaller);
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
        public Task<RegisterImageResponse> RegisterImageAsync(RegisterImageRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RegisterImageRequestMarshaller();
            var unmarshaller = RegisterImageResponseUnmarshaller.Instance;

            return InvokeAsync<RegisterImageRequest,RegisterImageResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RejectVpcPeeringConnection

        internal RejectVpcPeeringConnectionResponse RejectVpcPeeringConnection(RejectVpcPeeringConnectionRequest request)
        {
            var marshaller = new RejectVpcPeeringConnectionRequestMarshaller();
            var unmarshaller = RejectVpcPeeringConnectionResponseUnmarshaller.Instance;

            return Invoke<RejectVpcPeeringConnectionRequest,RejectVpcPeeringConnectionResponse>(request, marshaller, unmarshaller);
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
        public Task<RejectVpcPeeringConnectionResponse> RejectVpcPeeringConnectionAsync(RejectVpcPeeringConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RejectVpcPeeringConnectionRequestMarshaller();
            var unmarshaller = RejectVpcPeeringConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<RejectVpcPeeringConnectionRequest,RejectVpcPeeringConnectionResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ReleaseAddress

        internal ReleaseAddressResponse ReleaseAddress(ReleaseAddressRequest request)
        {
            var marshaller = new ReleaseAddressRequestMarshaller();
            var unmarshaller = ReleaseAddressResponseUnmarshaller.Instance;

            return Invoke<ReleaseAddressRequest,ReleaseAddressResponse>(request, marshaller, unmarshaller);
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
        public Task<ReleaseAddressResponse> ReleaseAddressAsync(ReleaseAddressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ReleaseAddressRequestMarshaller();
            var unmarshaller = ReleaseAddressResponseUnmarshaller.Instance;

            return InvokeAsync<ReleaseAddressRequest,ReleaseAddressResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ReplaceNetworkAclAssociation

        internal ReplaceNetworkAclAssociationResponse ReplaceNetworkAclAssociation(ReplaceNetworkAclAssociationRequest request)
        {
            var marshaller = new ReplaceNetworkAclAssociationRequestMarshaller();
            var unmarshaller = ReplaceNetworkAclAssociationResponseUnmarshaller.Instance;

            return Invoke<ReplaceNetworkAclAssociationRequest,ReplaceNetworkAclAssociationResponse>(request, marshaller, unmarshaller);
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
        public Task<ReplaceNetworkAclAssociationResponse> ReplaceNetworkAclAssociationAsync(ReplaceNetworkAclAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ReplaceNetworkAclAssociationRequestMarshaller();
            var unmarshaller = ReplaceNetworkAclAssociationResponseUnmarshaller.Instance;

            return InvokeAsync<ReplaceNetworkAclAssociationRequest,ReplaceNetworkAclAssociationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ReplaceNetworkAclEntry

        internal ReplaceNetworkAclEntryResponse ReplaceNetworkAclEntry(ReplaceNetworkAclEntryRequest request)
        {
            var marshaller = new ReplaceNetworkAclEntryRequestMarshaller();
            var unmarshaller = ReplaceNetworkAclEntryResponseUnmarshaller.Instance;

            return Invoke<ReplaceNetworkAclEntryRequest,ReplaceNetworkAclEntryResponse>(request, marshaller, unmarshaller);
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
        public Task<ReplaceNetworkAclEntryResponse> ReplaceNetworkAclEntryAsync(ReplaceNetworkAclEntryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ReplaceNetworkAclEntryRequestMarshaller();
            var unmarshaller = ReplaceNetworkAclEntryResponseUnmarshaller.Instance;

            return InvokeAsync<ReplaceNetworkAclEntryRequest,ReplaceNetworkAclEntryResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ReplaceRoute

        internal ReplaceRouteResponse ReplaceRoute(ReplaceRouteRequest request)
        {
            var marshaller = new ReplaceRouteRequestMarshaller();
            var unmarshaller = ReplaceRouteResponseUnmarshaller.Instance;

            return Invoke<ReplaceRouteRequest,ReplaceRouteResponse>(request, marshaller, unmarshaller);
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
        public Task<ReplaceRouteResponse> ReplaceRouteAsync(ReplaceRouteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ReplaceRouteRequestMarshaller();
            var unmarshaller = ReplaceRouteResponseUnmarshaller.Instance;

            return InvokeAsync<ReplaceRouteRequest,ReplaceRouteResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ReplaceRouteTableAssociation

        internal ReplaceRouteTableAssociationResponse ReplaceRouteTableAssociation(ReplaceRouteTableAssociationRequest request)
        {
            var marshaller = new ReplaceRouteTableAssociationRequestMarshaller();
            var unmarshaller = ReplaceRouteTableAssociationResponseUnmarshaller.Instance;

            return Invoke<ReplaceRouteTableAssociationRequest,ReplaceRouteTableAssociationResponse>(request, marshaller, unmarshaller);
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
        public Task<ReplaceRouteTableAssociationResponse> ReplaceRouteTableAssociationAsync(ReplaceRouteTableAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ReplaceRouteTableAssociationRequestMarshaller();
            var unmarshaller = ReplaceRouteTableAssociationResponseUnmarshaller.Instance;

            return InvokeAsync<ReplaceRouteTableAssociationRequest,ReplaceRouteTableAssociationResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ReportInstanceStatus

        internal ReportInstanceStatusResponse ReportInstanceStatus(ReportInstanceStatusRequest request)
        {
            var marshaller = new ReportInstanceStatusRequestMarshaller();
            var unmarshaller = ReportInstanceStatusResponseUnmarshaller.Instance;

            return Invoke<ReportInstanceStatusRequest,ReportInstanceStatusResponse>(request, marshaller, unmarshaller);
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
        public Task<ReportInstanceStatusResponse> ReportInstanceStatusAsync(ReportInstanceStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ReportInstanceStatusRequestMarshaller();
            var unmarshaller = ReportInstanceStatusResponseUnmarshaller.Instance;

            return InvokeAsync<ReportInstanceStatusRequest,ReportInstanceStatusResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RequestSpotFleet

        internal RequestSpotFleetResponse RequestSpotFleet(RequestSpotFleetRequest request)
        {
            var marshaller = new RequestSpotFleetRequestMarshaller();
            var unmarshaller = RequestSpotFleetResponseUnmarshaller.Instance;

            return Invoke<RequestSpotFleetRequest,RequestSpotFleetResponse>(request, marshaller, unmarshaller);
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
        public Task<RequestSpotFleetResponse> RequestSpotFleetAsync(RequestSpotFleetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RequestSpotFleetRequestMarshaller();
            var unmarshaller = RequestSpotFleetResponseUnmarshaller.Instance;

            return InvokeAsync<RequestSpotFleetRequest,RequestSpotFleetResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RequestSpotInstances

        internal RequestSpotInstancesResponse RequestSpotInstances(RequestSpotInstancesRequest request)
        {
            var marshaller = new RequestSpotInstancesRequestMarshaller();
            var unmarshaller = RequestSpotInstancesResponseUnmarshaller.Instance;

            return Invoke<RequestSpotInstancesRequest,RequestSpotInstancesResponse>(request, marshaller, unmarshaller);
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
        public Task<RequestSpotInstancesResponse> RequestSpotInstancesAsync(RequestSpotInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RequestSpotInstancesRequestMarshaller();
            var unmarshaller = RequestSpotInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<RequestSpotInstancesRequest,RequestSpotInstancesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ResetImageAttribute

        internal ResetImageAttributeResponse ResetImageAttribute(ResetImageAttributeRequest request)
        {
            var marshaller = new ResetImageAttributeRequestMarshaller();
            var unmarshaller = ResetImageAttributeResponseUnmarshaller.Instance;

            return Invoke<ResetImageAttributeRequest,ResetImageAttributeResponse>(request, marshaller, unmarshaller);
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
        public Task<ResetImageAttributeResponse> ResetImageAttributeAsync(ResetImageAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ResetImageAttributeRequestMarshaller();
            var unmarshaller = ResetImageAttributeResponseUnmarshaller.Instance;

            return InvokeAsync<ResetImageAttributeRequest,ResetImageAttributeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ResetInstanceAttribute

        internal ResetInstanceAttributeResponse ResetInstanceAttribute(ResetInstanceAttributeRequest request)
        {
            var marshaller = new ResetInstanceAttributeRequestMarshaller();
            var unmarshaller = ResetInstanceAttributeResponseUnmarshaller.Instance;

            return Invoke<ResetInstanceAttributeRequest,ResetInstanceAttributeResponse>(request, marshaller, unmarshaller);
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
        public Task<ResetInstanceAttributeResponse> ResetInstanceAttributeAsync(ResetInstanceAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ResetInstanceAttributeRequestMarshaller();
            var unmarshaller = ResetInstanceAttributeResponseUnmarshaller.Instance;

            return InvokeAsync<ResetInstanceAttributeRequest,ResetInstanceAttributeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ResetNetworkInterfaceAttribute

        internal ResetNetworkInterfaceAttributeResponse ResetNetworkInterfaceAttribute(ResetNetworkInterfaceAttributeRequest request)
        {
            var marshaller = new ResetNetworkInterfaceAttributeRequestMarshaller();
            var unmarshaller = ResetNetworkInterfaceAttributeResponseUnmarshaller.Instance;

            return Invoke<ResetNetworkInterfaceAttributeRequest,ResetNetworkInterfaceAttributeResponse>(request, marshaller, unmarshaller);
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
        public Task<ResetNetworkInterfaceAttributeResponse> ResetNetworkInterfaceAttributeAsync(ResetNetworkInterfaceAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ResetNetworkInterfaceAttributeRequestMarshaller();
            var unmarshaller = ResetNetworkInterfaceAttributeResponseUnmarshaller.Instance;

            return InvokeAsync<ResetNetworkInterfaceAttributeRequest,ResetNetworkInterfaceAttributeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  ResetSnapshotAttribute

        internal ResetSnapshotAttributeResponse ResetSnapshotAttribute(ResetSnapshotAttributeRequest request)
        {
            var marshaller = new ResetSnapshotAttributeRequestMarshaller();
            var unmarshaller = ResetSnapshotAttributeResponseUnmarshaller.Instance;

            return Invoke<ResetSnapshotAttributeRequest,ResetSnapshotAttributeResponse>(request, marshaller, unmarshaller);
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
        public Task<ResetSnapshotAttributeResponse> ResetSnapshotAttributeAsync(ResetSnapshotAttributeRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new ResetSnapshotAttributeRequestMarshaller();
            var unmarshaller = ResetSnapshotAttributeResponseUnmarshaller.Instance;

            return InvokeAsync<ResetSnapshotAttributeRequest,ResetSnapshotAttributeResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RestoreAddressToClassic

        internal RestoreAddressToClassicResponse RestoreAddressToClassic(RestoreAddressToClassicRequest request)
        {
            var marshaller = new RestoreAddressToClassicRequestMarshaller();
            var unmarshaller = RestoreAddressToClassicResponseUnmarshaller.Instance;

            return Invoke<RestoreAddressToClassicRequest,RestoreAddressToClassicResponse>(request, marshaller, unmarshaller);
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
        public Task<RestoreAddressToClassicResponse> RestoreAddressToClassicAsync(RestoreAddressToClassicRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RestoreAddressToClassicRequestMarshaller();
            var unmarshaller = RestoreAddressToClassicResponseUnmarshaller.Instance;

            return InvokeAsync<RestoreAddressToClassicRequest,RestoreAddressToClassicResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RevokeSecurityGroupEgress

        internal RevokeSecurityGroupEgressResponse RevokeSecurityGroupEgress(RevokeSecurityGroupEgressRequest request)
        {
            var marshaller = new RevokeSecurityGroupEgressRequestMarshaller();
            var unmarshaller = RevokeSecurityGroupEgressResponseUnmarshaller.Instance;

            return Invoke<RevokeSecurityGroupEgressRequest,RevokeSecurityGroupEgressResponse>(request, marshaller, unmarshaller);
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
        public Task<RevokeSecurityGroupEgressResponse> RevokeSecurityGroupEgressAsync(RevokeSecurityGroupEgressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RevokeSecurityGroupEgressRequestMarshaller();
            var unmarshaller = RevokeSecurityGroupEgressResponseUnmarshaller.Instance;

            return InvokeAsync<RevokeSecurityGroupEgressRequest,RevokeSecurityGroupEgressResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RevokeSecurityGroupIngress

        internal RevokeSecurityGroupIngressResponse RevokeSecurityGroupIngress(RevokeSecurityGroupIngressRequest request)
        {
            var marshaller = new RevokeSecurityGroupIngressRequestMarshaller();
            var unmarshaller = RevokeSecurityGroupIngressResponseUnmarshaller.Instance;

            return Invoke<RevokeSecurityGroupIngressRequest,RevokeSecurityGroupIngressResponse>(request, marshaller, unmarshaller);
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
        public Task<RevokeSecurityGroupIngressResponse> RevokeSecurityGroupIngressAsync(RevokeSecurityGroupIngressRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RevokeSecurityGroupIngressRequestMarshaller();
            var unmarshaller = RevokeSecurityGroupIngressResponseUnmarshaller.Instance;

            return InvokeAsync<RevokeSecurityGroupIngressRequest,RevokeSecurityGroupIngressResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  RunInstances

        internal RunInstancesResponse RunInstances(RunInstancesRequest request)
        {
            var marshaller = new RunInstancesRequestMarshaller();
            var unmarshaller = RunInstancesResponseUnmarshaller.Instance;

            return Invoke<RunInstancesRequest,RunInstancesResponse>(request, marshaller, unmarshaller);
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
        public Task<RunInstancesResponse> RunInstancesAsync(RunInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new RunInstancesRequestMarshaller();
            var unmarshaller = RunInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<RunInstancesRequest,RunInstancesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StartInstances

        internal StartInstancesResponse StartInstances(StartInstancesRequest request)
        {
            var marshaller = new StartInstancesRequestMarshaller();
            var unmarshaller = StartInstancesResponseUnmarshaller.Instance;

            return Invoke<StartInstancesRequest,StartInstancesResponse>(request, marshaller, unmarshaller);
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
        public Task<StartInstancesResponse> StartInstancesAsync(StartInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new StartInstancesRequestMarshaller();
            var unmarshaller = StartInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<StartInstancesRequest,StartInstancesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  StopInstances

        internal StopInstancesResponse StopInstances(StopInstancesRequest request)
        {
            var marshaller = new StopInstancesRequestMarshaller();
            var unmarshaller = StopInstancesResponseUnmarshaller.Instance;

            return Invoke<StopInstancesRequest,StopInstancesResponse>(request, marshaller, unmarshaller);
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
        public Task<StopInstancesResponse> StopInstancesAsync(StopInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new StopInstancesRequestMarshaller();
            var unmarshaller = StopInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<StopInstancesRequest,StopInstancesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  TerminateInstances

        internal TerminateInstancesResponse TerminateInstances(TerminateInstancesRequest request)
        {
            var marshaller = new TerminateInstancesRequestMarshaller();
            var unmarshaller = TerminateInstancesResponseUnmarshaller.Instance;

            return Invoke<TerminateInstancesRequest,TerminateInstancesResponse>(request, marshaller, unmarshaller);
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
        public Task<TerminateInstancesResponse> TerminateInstancesAsync(TerminateInstancesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new TerminateInstancesRequestMarshaller();
            var unmarshaller = TerminateInstancesResponseUnmarshaller.Instance;

            return InvokeAsync<TerminateInstancesRequest,TerminateInstancesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UnassignPrivateIpAddresses

        internal UnassignPrivateIpAddressesResponse UnassignPrivateIpAddresses(UnassignPrivateIpAddressesRequest request)
        {
            var marshaller = new UnassignPrivateIpAddressesRequestMarshaller();
            var unmarshaller = UnassignPrivateIpAddressesResponseUnmarshaller.Instance;

            return Invoke<UnassignPrivateIpAddressesRequest,UnassignPrivateIpAddressesResponse>(request, marshaller, unmarshaller);
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
        public Task<UnassignPrivateIpAddressesResponse> UnassignPrivateIpAddressesAsync(UnassignPrivateIpAddressesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var marshaller = new UnassignPrivateIpAddressesRequestMarshaller();
            var unmarshaller = UnassignPrivateIpAddressesResponseUnmarshaller.Instance;

            return InvokeAsync<UnassignPrivateIpAddressesRequest,UnassignPrivateIpAddressesResponse>(request, marshaller, 
                unmarshaller, cancellationToken);
        }

        #endregion
        
        #region  UnmonitorInstances

        internal UnmonitorInstancesResponse UnmonitorInstances(UnmonitorInstancesRequest request)
        {
            var marshaller = new UnmonitorInstancesRequestMarshaller();
            var unmarshaller = UnmonitorInstancesResponseUnmarshaller.Instance;

            return Invoke<UnmonitorInstancesRequest,UnmonitorInstancesResponse>(request, marshaller, unmarshaller);
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