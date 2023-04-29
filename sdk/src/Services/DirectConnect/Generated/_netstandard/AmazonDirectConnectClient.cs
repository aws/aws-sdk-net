/*
 * Copyright Amazon.com, Inc. or its affiliates. All Rights Reserved.
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
 * Do not modify this file. This file is generated from the directconnect-2012-10-25.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.DirectConnect.Model;
using Amazon.DirectConnect.Model.Internal.MarshallTransformations;
using Amazon.DirectConnect.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.DirectConnect
{
    /// <summary>
    /// Implementation for accessing DirectConnect
    ///
    /// Direct Connect links your internal network to an Direct Connect location over a standard
    /// Ethernet fiber-optic cable. One end of the cable is connected to your router, the
    /// other to an Direct Connect router. With this connection in place, you can create virtual
    /// interfaces directly to the Amazon Web Services Cloud (for example, to Amazon EC2 and
    /// Amazon S3) and to Amazon VPC, bypassing Internet service providers in your network
    /// path. A connection provides access to all Amazon Web Services Regions except the China
    /// (Beijing) and (China) Ningxia Regions. Amazon Web Services resources in the China
    /// Regions can only be accessed through locations associated with those Regions.
    /// </summary>
    public partial class AmazonDirectConnectClient : AmazonServiceClient, IAmazonDirectConnect
    {
        private static IServiceMetadata serviceMetadata = new AmazonDirectConnectMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonDirectConnectClient with the credentials loaded from the application's
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
        public AmazonDirectConnectClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonDirectConnectConfig()) { }

        /// <summary>
        /// Constructs AmazonDirectConnectClient with the credentials loaded from the application's
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
        public AmazonDirectConnectClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonDirectConnectConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonDirectConnectClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonDirectConnectClient Configuration Object</param>
        public AmazonDirectConnectClient(AmazonDirectConnectConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }


        /// <summary>
        /// Constructs AmazonDirectConnectClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonDirectConnectClient(AWSCredentials credentials)
            : this(credentials, new AmazonDirectConnectConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDirectConnectClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDirectConnectClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonDirectConnectConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonDirectConnectClient with AWS Credentials and an
        /// AmazonDirectConnectClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonDirectConnectClient Configuration Object</param>
        public AmazonDirectConnectClient(AWSCredentials credentials, AmazonDirectConnectConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonDirectConnectClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonDirectConnectClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonDirectConnectConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDirectConnectClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDirectConnectClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonDirectConnectConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonDirectConnectClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonDirectConnectClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonDirectConnectClient Configuration Object</param>
        public AmazonDirectConnectClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonDirectConnectConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonDirectConnectClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonDirectConnectClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonDirectConnectConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonDirectConnectClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonDirectConnectClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonDirectConnectConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonDirectConnectClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonDirectConnectClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonDirectConnectClient Configuration Object</param>
        public AmazonDirectConnectClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonDirectConnectConfig clientConfig)
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
            pipeline.RemoveHandler<Amazon.Runtime.Internal.EndpointResolver>();
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonDirectConnectEndpointResolver());
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


        #region  AcceptDirectConnectGatewayAssociationProposal

        internal virtual AcceptDirectConnectGatewayAssociationProposalResponse AcceptDirectConnectGatewayAssociationProposal(AcceptDirectConnectGatewayAssociationProposalRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AcceptDirectConnectGatewayAssociationProposalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptDirectConnectGatewayAssociationProposalResponseUnmarshaller.Instance;

            return Invoke<AcceptDirectConnectGatewayAssociationProposalResponse>(request, options);
        }



        /// <summary>
        /// Accepts a proposal request to attach a virtual private gateway or transit gateway
        /// to a Direct Connect gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptDirectConnectGatewayAssociationProposal service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AcceptDirectConnectGatewayAssociationProposal service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/AcceptDirectConnectGatewayAssociationProposal">REST API Reference for AcceptDirectConnectGatewayAssociationProposal Operation</seealso>
        public virtual Task<AcceptDirectConnectGatewayAssociationProposalResponse> AcceptDirectConnectGatewayAssociationProposalAsync(AcceptDirectConnectGatewayAssociationProposalRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AcceptDirectConnectGatewayAssociationProposalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptDirectConnectGatewayAssociationProposalResponseUnmarshaller.Instance;

            return InvokeAsync<AcceptDirectConnectGatewayAssociationProposalResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AllocateConnectionOnInterconnect

        [Obsolete("Deprecated in favor of AllocateHostedConnection.")]
        internal virtual AllocateConnectionOnInterconnectResponse AllocateConnectionOnInterconnect(AllocateConnectionOnInterconnectRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AllocateConnectionOnInterconnectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AllocateConnectionOnInterconnectResponseUnmarshaller.Instance;

            return Invoke<AllocateConnectionOnInterconnectResponse>(request, options);
        }



        /// <summary>
        /// Deprecated. Use <a>AllocateHostedConnection</a> instead.
        /// 
        ///  
        /// <para>
        /// Creates a hosted connection on an interconnect.
        /// </para>
        ///  
        /// <para>
        /// Allocates a VLAN number and a specified amount of bandwidth for use by a hosted connection
        /// on the specified interconnect.
        /// </para>
        ///  <note> 
        /// <para>
        /// Intended for use by Direct Connect Partners only.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AllocateConnectionOnInterconnect service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AllocateConnectionOnInterconnect service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/AllocateConnectionOnInterconnect">REST API Reference for AllocateConnectionOnInterconnect Operation</seealso>
        [Obsolete("Deprecated in favor of AllocateHostedConnection.")]
        public virtual Task<AllocateConnectionOnInterconnectResponse> AllocateConnectionOnInterconnectAsync(AllocateConnectionOnInterconnectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AllocateConnectionOnInterconnectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AllocateConnectionOnInterconnectResponseUnmarshaller.Instance;

            return InvokeAsync<AllocateConnectionOnInterconnectResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AllocateHostedConnection

        internal virtual AllocateHostedConnectionResponse AllocateHostedConnection(AllocateHostedConnectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AllocateHostedConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AllocateHostedConnectionResponseUnmarshaller.Instance;

            return Invoke<AllocateHostedConnectionResponse>(request, options);
        }



        /// <summary>
        /// Creates a hosted connection on the specified interconnect or a link aggregation group
        /// (LAG) of interconnects.
        /// 
        ///  
        /// <para>
        /// Allocates a VLAN number and a specified amount of capacity (bandwidth) for use by
        /// a hosted connection on the specified interconnect or LAG of interconnects. Amazon
        /// Web Services polices the hosted connection for the specified capacity and the Direct
        /// Connect Partner must also police the hosted connection for the specified capacity.
        /// </para>
        ///  <note> 
        /// <para>
        /// Intended for use by Direct Connect Partners only.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AllocateHostedConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AllocateHostedConnection service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DuplicateTagKeysException">
        /// A tag key was specified more than once.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.TooManyTagsException">
        /// You have reached the limit on the number of tags that can be assigned.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/AllocateHostedConnection">REST API Reference for AllocateHostedConnection Operation</seealso>
        public virtual Task<AllocateHostedConnectionResponse> AllocateHostedConnectionAsync(AllocateHostedConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AllocateHostedConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AllocateHostedConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<AllocateHostedConnectionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AllocatePrivateVirtualInterface

        internal virtual AllocatePrivateVirtualInterfaceResponse AllocatePrivateVirtualInterface(AllocatePrivateVirtualInterfaceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AllocatePrivateVirtualInterfaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AllocatePrivateVirtualInterfaceResponseUnmarshaller.Instance;

            return Invoke<AllocatePrivateVirtualInterfaceResponse>(request, options);
        }



        /// <summary>
        /// Provisions a private virtual interface to be owned by the specified Amazon Web Services
        /// account.
        /// 
        ///  
        /// <para>
        /// Virtual interfaces created using this action must be confirmed by the owner using
        /// <a>ConfirmPrivateVirtualInterface</a>. Until then, the virtual interface is in the
        /// <code>Confirming</code> state and is not available to handle traffic.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AllocatePrivateVirtualInterface service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AllocatePrivateVirtualInterface service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DuplicateTagKeysException">
        /// A tag key was specified more than once.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.TooManyTagsException">
        /// You have reached the limit on the number of tags that can be assigned.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/AllocatePrivateVirtualInterface">REST API Reference for AllocatePrivateVirtualInterface Operation</seealso>
        public virtual Task<AllocatePrivateVirtualInterfaceResponse> AllocatePrivateVirtualInterfaceAsync(AllocatePrivateVirtualInterfaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AllocatePrivateVirtualInterfaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AllocatePrivateVirtualInterfaceResponseUnmarshaller.Instance;

            return InvokeAsync<AllocatePrivateVirtualInterfaceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AllocatePublicVirtualInterface

        internal virtual AllocatePublicVirtualInterfaceResponse AllocatePublicVirtualInterface(AllocatePublicVirtualInterfaceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AllocatePublicVirtualInterfaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AllocatePublicVirtualInterfaceResponseUnmarshaller.Instance;

            return Invoke<AllocatePublicVirtualInterfaceResponse>(request, options);
        }



        /// <summary>
        /// Provisions a public virtual interface to be owned by the specified Amazon Web Services
        /// account.
        /// 
        ///  
        /// <para>
        /// The owner of a connection calls this function to provision a public virtual interface
        /// to be owned by the specified Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        /// Virtual interfaces created using this function must be confirmed by the owner using
        /// <a>ConfirmPublicVirtualInterface</a>. Until this step has been completed, the virtual
        /// interface is in the <code>confirming</code> state and is not available to handle traffic.
        /// </para>
        ///  
        /// <para>
        /// When creating an IPv6 public virtual interface, omit the Amazon address and customer
        /// address. IPv6 addresses are automatically assigned from the Amazon pool of IPv6 addresses;
        /// you cannot specify custom IPv6 addresses.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AllocatePublicVirtualInterface service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AllocatePublicVirtualInterface service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DuplicateTagKeysException">
        /// A tag key was specified more than once.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.TooManyTagsException">
        /// You have reached the limit on the number of tags that can be assigned.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/AllocatePublicVirtualInterface">REST API Reference for AllocatePublicVirtualInterface Operation</seealso>
        public virtual Task<AllocatePublicVirtualInterfaceResponse> AllocatePublicVirtualInterfaceAsync(AllocatePublicVirtualInterfaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AllocatePublicVirtualInterfaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AllocatePublicVirtualInterfaceResponseUnmarshaller.Instance;

            return InvokeAsync<AllocatePublicVirtualInterfaceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AllocateTransitVirtualInterface

        internal virtual AllocateTransitVirtualInterfaceResponse AllocateTransitVirtualInterface(AllocateTransitVirtualInterfaceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AllocateTransitVirtualInterfaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AllocateTransitVirtualInterfaceResponseUnmarshaller.Instance;

            return Invoke<AllocateTransitVirtualInterfaceResponse>(request, options);
        }



        /// <summary>
        /// Provisions a transit virtual interface to be owned by the specified Amazon Web Services
        /// account. Use this type of interface to connect a transit gateway to your Direct Connect
        /// gateway.
        /// 
        ///  
        /// <para>
        /// The owner of a connection provisions a transit virtual interface to be owned by the
        /// specified Amazon Web Services account.
        /// </para>
        ///  
        /// <para>
        /// After you create a transit virtual interface, it must be confirmed by the owner using
        /// <a>ConfirmTransitVirtualInterface</a>. Until this step has been completed, the transit
        /// virtual interface is in the <code>requested</code> state and is not available to handle
        /// traffic.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AllocateTransitVirtualInterface service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AllocateTransitVirtualInterface service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DuplicateTagKeysException">
        /// A tag key was specified more than once.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.TooManyTagsException">
        /// You have reached the limit on the number of tags that can be assigned.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/AllocateTransitVirtualInterface">REST API Reference for AllocateTransitVirtualInterface Operation</seealso>
        public virtual Task<AllocateTransitVirtualInterfaceResponse> AllocateTransitVirtualInterfaceAsync(AllocateTransitVirtualInterfaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AllocateTransitVirtualInterfaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AllocateTransitVirtualInterfaceResponseUnmarshaller.Instance;

            return InvokeAsync<AllocateTransitVirtualInterfaceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AssociateConnectionWithLag

        internal virtual AssociateConnectionWithLagResponse AssociateConnectionWithLag(AssociateConnectionWithLagRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateConnectionWithLagRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateConnectionWithLagResponseUnmarshaller.Instance;

            return Invoke<AssociateConnectionWithLagResponse>(request, options);
        }



        /// <summary>
        /// Associates an existing connection with a link aggregation group (LAG). The connection
        /// is interrupted and re-established as a member of the LAG (connectivity to Amazon Web
        /// Services is interrupted). The connection must be hosted on the same Direct Connect
        /// endpoint as the LAG, and its bandwidth must match the bandwidth for the LAG. You can
        /// re-associate a connection that's currently associated with a different LAG; however,
        /// if removing the connection would cause the original LAG to fall below its setting
        /// for minimum number of operational connections, the request fails.
        /// 
        ///  
        /// <para>
        /// Any virtual interfaces that are directly associated with the connection are automatically
        /// re-associated with the LAG. If the connection was originally associated with a different
        /// LAG, the virtual interfaces remain associated with the original LAG.
        /// </para>
        ///  
        /// <para>
        /// For interconnects, any hosted connections are automatically re-associated with the
        /// LAG. If the interconnect was originally associated with a different LAG, the hosted
        /// connections remain associated with the original LAG.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateConnectionWithLag service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateConnectionWithLag service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/AssociateConnectionWithLag">REST API Reference for AssociateConnectionWithLag Operation</seealso>
        public virtual Task<AssociateConnectionWithLagResponse> AssociateConnectionWithLagAsync(AssociateConnectionWithLagRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateConnectionWithLagRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateConnectionWithLagResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateConnectionWithLagResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AssociateHostedConnection

        internal virtual AssociateHostedConnectionResponse AssociateHostedConnection(AssociateHostedConnectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateHostedConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateHostedConnectionResponseUnmarshaller.Instance;

            return Invoke<AssociateHostedConnectionResponse>(request, options);
        }



        /// <summary>
        /// Associates a hosted connection and its virtual interfaces with a link aggregation
        /// group (LAG) or interconnect. If the target interconnect or LAG has an existing hosted
        /// connection with a conflicting VLAN number or IP address, the operation fails. This
        /// action temporarily interrupts the hosted connection's connectivity to Amazon Web Services
        /// as it is being migrated.
        /// 
        ///  <note> 
        /// <para>
        /// Intended for use by Direct Connect Partners only.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateHostedConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateHostedConnection service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/AssociateHostedConnection">REST API Reference for AssociateHostedConnection Operation</seealso>
        public virtual Task<AssociateHostedConnectionResponse> AssociateHostedConnectionAsync(AssociateHostedConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateHostedConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateHostedConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateHostedConnectionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AssociateMacSecKey

        internal virtual AssociateMacSecKeyResponse AssociateMacSecKey(AssociateMacSecKeyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateMacSecKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateMacSecKeyResponseUnmarshaller.Instance;

            return Invoke<AssociateMacSecKeyResponse>(request, options);
        }



        /// <summary>
        /// Associates a MAC Security (MACsec) Connection Key Name (CKN)/ Connectivity Association
        /// Key (CAK) pair with an Direct Connect dedicated connection.
        /// 
        ///  
        /// <para>
        /// You must supply either the <code>secretARN,</code> or the CKN/CAK (<code>ckn</code>
        /// and <code>cak</code>) pair in the request.
        /// </para>
        ///  
        /// <para>
        /// For information about MAC Security (MACsec) key considerations, see <a href="https://docs.aws.amazon.com/directconnect/latest/UserGuide/direct-connect-mac-sec-getting-started.html#mac-sec-key-consideration">MACsec
        /// pre-shared CKN/CAK key considerations </a> in the <i>Direct Connect User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateMacSecKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateMacSecKey service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/AssociateMacSecKey">REST API Reference for AssociateMacSecKey Operation</seealso>
        public virtual Task<AssociateMacSecKeyResponse> AssociateMacSecKeyAsync(AssociateMacSecKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateMacSecKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateMacSecKeyResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateMacSecKeyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AssociateVirtualInterface

        internal virtual AssociateVirtualInterfaceResponse AssociateVirtualInterface(AssociateVirtualInterfaceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateVirtualInterfaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateVirtualInterfaceResponseUnmarshaller.Instance;

            return Invoke<AssociateVirtualInterfaceResponse>(request, options);
        }



        /// <summary>
        /// Associates a virtual interface with a specified link aggregation group (LAG) or connection.
        /// Connectivity to Amazon Web Services is temporarily interrupted as the virtual interface
        /// is being migrated. If the target connection or LAG has an associated virtual interface
        /// with a conflicting VLAN number or a conflicting IP address, the operation fails.
        /// 
        ///  
        /// <para>
        /// Virtual interfaces associated with a hosted connection cannot be associated with a
        /// LAG; hosted connections must be migrated along with their virtual interfaces using
        /// <a>AssociateHostedConnection</a>.
        /// </para>
        ///  
        /// <para>
        /// To reassociate a virtual interface to a new connection or LAG, the requester must
        /// own either the virtual interface itself or the connection to which the virtual interface
        /// is currently associated. Additionally, the requester must own the connection or LAG
        /// for the association.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateVirtualInterface service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateVirtualInterface service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/AssociateVirtualInterface">REST API Reference for AssociateVirtualInterface Operation</seealso>
        public virtual Task<AssociateVirtualInterfaceResponse> AssociateVirtualInterfaceAsync(AssociateVirtualInterfaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateVirtualInterfaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateVirtualInterfaceResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateVirtualInterfaceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ConfirmConnection

        internal virtual ConfirmConnectionResponse ConfirmConnection(ConfirmConnectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ConfirmConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ConfirmConnectionResponseUnmarshaller.Instance;

            return Invoke<ConfirmConnectionResponse>(request, options);
        }



        /// <summary>
        /// Confirms the creation of the specified hosted connection on an interconnect.
        /// 
        ///  
        /// <para>
        /// Upon creation, the hosted connection is initially in the <code>Ordering</code> state,
        /// and remains in this state until the owner confirms creation of the hosted connection.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ConfirmConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ConfirmConnection service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/ConfirmConnection">REST API Reference for ConfirmConnection Operation</seealso>
        public virtual Task<ConfirmConnectionResponse> ConfirmConnectionAsync(ConfirmConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ConfirmConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ConfirmConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<ConfirmConnectionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ConfirmCustomerAgreement

        internal virtual ConfirmCustomerAgreementResponse ConfirmCustomerAgreement(ConfirmCustomerAgreementRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ConfirmCustomerAgreementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ConfirmCustomerAgreementResponseUnmarshaller.Instance;

            return Invoke<ConfirmCustomerAgreementResponse>(request, options);
        }



        /// <summary>
        /// The confirmation of the terms of agreement when creating the connection/link aggregation
        /// group (LAG).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ConfirmCustomerAgreement service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ConfirmCustomerAgreement service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/ConfirmCustomerAgreement">REST API Reference for ConfirmCustomerAgreement Operation</seealso>
        public virtual Task<ConfirmCustomerAgreementResponse> ConfirmCustomerAgreementAsync(ConfirmCustomerAgreementRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ConfirmCustomerAgreementRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ConfirmCustomerAgreementResponseUnmarshaller.Instance;

            return InvokeAsync<ConfirmCustomerAgreementResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ConfirmPrivateVirtualInterface

        internal virtual ConfirmPrivateVirtualInterfaceResponse ConfirmPrivateVirtualInterface(ConfirmPrivateVirtualInterfaceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ConfirmPrivateVirtualInterfaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ConfirmPrivateVirtualInterfaceResponseUnmarshaller.Instance;

            return Invoke<ConfirmPrivateVirtualInterfaceResponse>(request, options);
        }



        /// <summary>
        /// Accepts ownership of a private virtual interface created by another Amazon Web Services
        /// account.
        /// 
        ///  
        /// <para>
        /// After the virtual interface owner makes this call, the virtual interface is created
        /// and attached to the specified virtual private gateway or Direct Connect gateway, and
        /// is made available to handle traffic.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ConfirmPrivateVirtualInterface service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ConfirmPrivateVirtualInterface service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/ConfirmPrivateVirtualInterface">REST API Reference for ConfirmPrivateVirtualInterface Operation</seealso>
        public virtual Task<ConfirmPrivateVirtualInterfaceResponse> ConfirmPrivateVirtualInterfaceAsync(ConfirmPrivateVirtualInterfaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ConfirmPrivateVirtualInterfaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ConfirmPrivateVirtualInterfaceResponseUnmarshaller.Instance;

            return InvokeAsync<ConfirmPrivateVirtualInterfaceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ConfirmPublicVirtualInterface

        internal virtual ConfirmPublicVirtualInterfaceResponse ConfirmPublicVirtualInterface(ConfirmPublicVirtualInterfaceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ConfirmPublicVirtualInterfaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ConfirmPublicVirtualInterfaceResponseUnmarshaller.Instance;

            return Invoke<ConfirmPublicVirtualInterfaceResponse>(request, options);
        }



        /// <summary>
        /// Accepts ownership of a public virtual interface created by another Amazon Web Services
        /// account.
        /// 
        ///  
        /// <para>
        /// After the virtual interface owner makes this call, the specified virtual interface
        /// is created and made available to handle traffic.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ConfirmPublicVirtualInterface service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ConfirmPublicVirtualInterface service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/ConfirmPublicVirtualInterface">REST API Reference for ConfirmPublicVirtualInterface Operation</seealso>
        public virtual Task<ConfirmPublicVirtualInterfaceResponse> ConfirmPublicVirtualInterfaceAsync(ConfirmPublicVirtualInterfaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ConfirmPublicVirtualInterfaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ConfirmPublicVirtualInterfaceResponseUnmarshaller.Instance;

            return InvokeAsync<ConfirmPublicVirtualInterfaceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ConfirmTransitVirtualInterface

        internal virtual ConfirmTransitVirtualInterfaceResponse ConfirmTransitVirtualInterface(ConfirmTransitVirtualInterfaceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ConfirmTransitVirtualInterfaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ConfirmTransitVirtualInterfaceResponseUnmarshaller.Instance;

            return Invoke<ConfirmTransitVirtualInterfaceResponse>(request, options);
        }



        /// <summary>
        /// Accepts ownership of a transit virtual interface created by another Amazon Web Services
        /// account.
        /// 
        ///  
        /// <para>
        ///  After the owner of the transit virtual interface makes this call, the specified transit
        /// virtual interface is created and made available to handle traffic.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ConfirmTransitVirtualInterface service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ConfirmTransitVirtualInterface service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/ConfirmTransitVirtualInterface">REST API Reference for ConfirmTransitVirtualInterface Operation</seealso>
        public virtual Task<ConfirmTransitVirtualInterfaceResponse> ConfirmTransitVirtualInterfaceAsync(ConfirmTransitVirtualInterfaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ConfirmTransitVirtualInterfaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ConfirmTransitVirtualInterfaceResponseUnmarshaller.Instance;

            return InvokeAsync<ConfirmTransitVirtualInterfaceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateBGPPeer

        internal virtual CreateBGPPeerResponse CreateBGPPeer(CreateBGPPeerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateBGPPeerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBGPPeerResponseUnmarshaller.Instance;

            return Invoke<CreateBGPPeerResponse>(request, options);
        }



        /// <summary>
        /// Creates a BGP peer on the specified virtual interface.
        /// 
        ///  
        /// <para>
        /// You must create a BGP peer for the corresponding address family (IPv4/IPv6) in order
        /// to access Amazon Web Services resources that also use that address family.
        /// </para>
        ///  
        /// <para>
        /// If logical redundancy is not supported by the connection, interconnect, or LAG, the
        /// BGP peer cannot be in the same address family as an existing BGP peer on the virtual
        /// interface.
        /// </para>
        ///  
        /// <para>
        /// When creating a IPv6 BGP peer, omit the Amazon address and customer address. IPv6
        /// addresses are automatically assigned from the Amazon pool of IPv6 addresses; you cannot
        /// specify custom IPv6 addresses.
        /// </para>
        ///  <important> 
        /// <para>
        /// If you let Amazon Web Services auto-assign IPv4 addresses, a /30 CIDR will be allocated
        /// from 169.254.0.0/16. Amazon Web Services does not recommend this option if you intend
        /// to use the customer router peer IP address as the source and destination for traffic.
        /// Instead you should use RFC 1918 or other addressing, and specify the address yourself.
        /// For more information about RFC 1918 see <a href="https://datatracker.ietf.org/doc/html/rfc1918">
        /// Address Allocation for Private Internets</a>.
        /// </para>
        ///  </important> 
        /// <para>
        /// For a public virtual interface, the Autonomous System Number (ASN) must be private
        /// or already on the allow list for the virtual interface.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateBGPPeer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateBGPPeer service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/CreateBGPPeer">REST API Reference for CreateBGPPeer Operation</seealso>
        public virtual Task<CreateBGPPeerResponse> CreateBGPPeerAsync(CreateBGPPeerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateBGPPeerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateBGPPeerResponseUnmarshaller.Instance;

            return InvokeAsync<CreateBGPPeerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateConnection

        internal virtual CreateConnectionResponse CreateConnection(CreateConnectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConnectionResponseUnmarshaller.Instance;

            return Invoke<CreateConnectionResponse>(request, options);
        }



        /// <summary>
        /// Creates a connection between a customer network and a specific Direct Connect location.
        /// 
        ///  
        /// <para>
        /// A connection links your internal network to an Direct Connect location over a standard
        /// Ethernet fiber-optic cable. One end of the cable is connected to your router, the
        /// other to an Direct Connect router.
        /// </para>
        ///  
        /// <para>
        /// To find the locations for your Region, use <a>DescribeLocations</a>.
        /// </para>
        ///  
        /// <para>
        /// You can automatically add the new connection to a link aggregation group (LAG) by
        /// specifying a LAG ID in the request. This ensures that the new connection is allocated
        /// on the same Direct Connect endpoint that hosts the specified LAG. If there are no
        /// available ports on the endpoint, the request fails and no connection is created.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateConnection service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DuplicateTagKeysException">
        /// A tag key was specified more than once.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.TooManyTagsException">
        /// You have reached the limit on the number of tags that can be assigned.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/CreateConnection">REST API Reference for CreateConnection Operation</seealso>
        public virtual Task<CreateConnectionResponse> CreateConnectionAsync(CreateConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateConnectionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDirectConnectGateway

        internal virtual CreateDirectConnectGatewayResponse CreateDirectConnectGateway(CreateDirectConnectGatewayRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDirectConnectGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDirectConnectGatewayResponseUnmarshaller.Instance;

            return Invoke<CreateDirectConnectGatewayResponse>(request, options);
        }



        /// <summary>
        /// Creates a Direct Connect gateway, which is an intermediate object that enables you
        /// to connect a set of virtual interfaces and virtual private gateways. A Direct Connect
        /// gateway is global and visible in any Amazon Web Services Region after it is created.
        /// The virtual interfaces and virtual private gateways that are connected through a Direct
        /// Connect gateway can be in different Amazon Web Services Regions. This enables you
        /// to connect to a VPC in any Region, regardless of the Region in which the virtual interfaces
        /// are located, and pass traffic between them.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDirectConnectGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDirectConnectGateway service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/CreateDirectConnectGateway">REST API Reference for CreateDirectConnectGateway Operation</seealso>
        public virtual Task<CreateDirectConnectGatewayResponse> CreateDirectConnectGatewayAsync(CreateDirectConnectGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDirectConnectGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDirectConnectGatewayResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDirectConnectGatewayResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDirectConnectGatewayAssociation

        internal virtual CreateDirectConnectGatewayAssociationResponse CreateDirectConnectGatewayAssociation(CreateDirectConnectGatewayAssociationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDirectConnectGatewayAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDirectConnectGatewayAssociationResponseUnmarshaller.Instance;

            return Invoke<CreateDirectConnectGatewayAssociationResponse>(request, options);
        }



        /// <summary>
        /// Creates an association between a Direct Connect gateway and a virtual private gateway.
        /// The virtual private gateway must be attached to a VPC and must not be associated with
        /// another Direct Connect gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDirectConnectGatewayAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDirectConnectGatewayAssociation service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/CreateDirectConnectGatewayAssociation">REST API Reference for CreateDirectConnectGatewayAssociation Operation</seealso>
        public virtual Task<CreateDirectConnectGatewayAssociationResponse> CreateDirectConnectGatewayAssociationAsync(CreateDirectConnectGatewayAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDirectConnectGatewayAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDirectConnectGatewayAssociationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDirectConnectGatewayAssociationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDirectConnectGatewayAssociationProposal

        internal virtual CreateDirectConnectGatewayAssociationProposalResponse CreateDirectConnectGatewayAssociationProposal(CreateDirectConnectGatewayAssociationProposalRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDirectConnectGatewayAssociationProposalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDirectConnectGatewayAssociationProposalResponseUnmarshaller.Instance;

            return Invoke<CreateDirectConnectGatewayAssociationProposalResponse>(request, options);
        }



        /// <summary>
        /// Creates a proposal to associate the specified virtual private gateway or transit gateway
        /// with the specified Direct Connect gateway.
        /// 
        ///  
        /// <para>
        /// You can associate a Direct Connect gateway and virtual private gateway or transit
        /// gateway that is owned by any Amazon Web Services account. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDirectConnectGatewayAssociationProposal service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDirectConnectGatewayAssociationProposal service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/CreateDirectConnectGatewayAssociationProposal">REST API Reference for CreateDirectConnectGatewayAssociationProposal Operation</seealso>
        public virtual Task<CreateDirectConnectGatewayAssociationProposalResponse> CreateDirectConnectGatewayAssociationProposalAsync(CreateDirectConnectGatewayAssociationProposalRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDirectConnectGatewayAssociationProposalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDirectConnectGatewayAssociationProposalResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDirectConnectGatewayAssociationProposalResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateInterconnect

        internal virtual CreateInterconnectResponse CreateInterconnect(CreateInterconnectRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateInterconnectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateInterconnectResponseUnmarshaller.Instance;

            return Invoke<CreateInterconnectResponse>(request, options);
        }



        /// <summary>
        /// Creates an interconnect between an Direct Connect Partner's network and a specific
        /// Direct Connect location.
        /// 
        ///  
        /// <para>
        /// An interconnect is a connection that is capable of hosting other connections. The
        /// Direct Connect Partner can use an interconnect to provide Direct Connect hosted connections
        /// to customers through their own network services. Like a standard connection, an interconnect
        /// links the partner's network to an Direct Connect location over a standard Ethernet
        /// fiber-optic cable. One end is connected to the partner's router, the other to an Direct
        /// Connect router.
        /// </para>
        ///  
        /// <para>
        /// You can automatically add the new interconnect to a link aggregation group (LAG) by
        /// specifying a LAG ID in the request. This ensures that the new interconnect is allocated
        /// on the same Direct Connect endpoint that hosts the specified LAG. If there are no
        /// available ports on the endpoint, the request fails and no interconnect is created.
        /// </para>
        ///  
        /// <para>
        /// For each end customer, the Direct Connect Partner provisions a connection on their
        /// interconnect by calling <a>AllocateHostedConnection</a>. The end customer can then
        /// connect to Amazon Web Services resources by creating a virtual interface on their
        /// connection, using the VLAN assigned to them by the Direct Connect Partner.
        /// </para>
        ///  <note> 
        /// <para>
        /// Intended for use by Direct Connect Partners only.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateInterconnect service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateInterconnect service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DuplicateTagKeysException">
        /// A tag key was specified more than once.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.TooManyTagsException">
        /// You have reached the limit on the number of tags that can be assigned.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/CreateInterconnect">REST API Reference for CreateInterconnect Operation</seealso>
        public virtual Task<CreateInterconnectResponse> CreateInterconnectAsync(CreateInterconnectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateInterconnectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateInterconnectResponseUnmarshaller.Instance;

            return InvokeAsync<CreateInterconnectResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateLag

        internal virtual CreateLagResponse CreateLag(CreateLagRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLagRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLagResponseUnmarshaller.Instance;

            return Invoke<CreateLagResponse>(request, options);
        }



        /// <summary>
        /// Creates a link aggregation group (LAG) with the specified number of bundled physical
        /// dedicated connections between the customer network and a specific Direct Connect location.
        /// A LAG is a logical interface that uses the Link Aggregation Control Protocol (LACP)
        /// to aggregate multiple interfaces, enabling you to treat them as a single interface.
        /// 
        ///  
        /// <para>
        /// All connections in a LAG must use the same bandwidth (either 1Gbps or 10Gbps) and
        /// must terminate at the same Direct Connect endpoint.
        /// </para>
        ///  
        /// <para>
        /// You can have up to 10 dedicated connections per LAG. Regardless of this limit, if
        /// you request more connections for the LAG than Direct Connect can allocate on a single
        /// endpoint, no LAG is created.
        /// </para>
        ///  
        /// <para>
        /// You can specify an existing physical dedicated connection or interconnect to include
        /// in the LAG (which counts towards the total number of connections). Doing so interrupts
        /// the current physical dedicated connection, and re-establishes them as a member of
        /// the LAG. The LAG will be created on the same Direct Connect endpoint to which the
        /// dedicated connection terminates. Any virtual interfaces associated with the dedicated
        /// connection are automatically disassociated and re-associated with the LAG. The connection
        /// ID does not change.
        /// </para>
        ///  
        /// <para>
        /// If the Amazon Web Services account used to create a LAG is a registered Direct Connect
        /// Partner, the LAG is automatically enabled to host sub-connections. For a LAG owned
        /// by a partner, any associated virtual interfaces cannot be directly configured.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLag service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateLag service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DuplicateTagKeysException">
        /// A tag key was specified more than once.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.TooManyTagsException">
        /// You have reached the limit on the number of tags that can be assigned.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/CreateLag">REST API Reference for CreateLag Operation</seealso>
        public virtual Task<CreateLagResponse> CreateLagAsync(CreateLagRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLagRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLagResponseUnmarshaller.Instance;

            return InvokeAsync<CreateLagResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreatePrivateVirtualInterface

        internal virtual CreatePrivateVirtualInterfaceResponse CreatePrivateVirtualInterface(CreatePrivateVirtualInterfaceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePrivateVirtualInterfaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePrivateVirtualInterfaceResponseUnmarshaller.Instance;

            return Invoke<CreatePrivateVirtualInterfaceResponse>(request, options);
        }



        /// <summary>
        /// Creates a private virtual interface. A virtual interface is the VLAN that transports
        /// Direct Connect traffic. A private virtual interface can be connected to either a Direct
        /// Connect gateway or a Virtual Private Gateway (VGW). Connecting the private virtual
        /// interface to a Direct Connect gateway enables the possibility for connecting to multiple
        /// VPCs, including VPCs in different Amazon Web Services Regions. Connecting the private
        /// virtual interface to a VGW only provides access to a single VPC within the same Region.
        /// 
        ///  
        /// <para>
        /// Setting the MTU of a virtual interface to 9001 (jumbo frames) can cause an update
        /// to the underlying physical connection if it wasn't updated to support jumbo frames.
        /// Updating the connection disrupts network connectivity for all virtual interfaces associated
        /// with the connection for up to 30 seconds. To check whether your connection supports
        /// jumbo frames, call <a>DescribeConnections</a>. To check whether your virtual interface
        /// supports jumbo frames, call <a>DescribeVirtualInterfaces</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePrivateVirtualInterface service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePrivateVirtualInterface service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DuplicateTagKeysException">
        /// A tag key was specified more than once.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.TooManyTagsException">
        /// You have reached the limit on the number of tags that can be assigned.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/CreatePrivateVirtualInterface">REST API Reference for CreatePrivateVirtualInterface Operation</seealso>
        public virtual Task<CreatePrivateVirtualInterfaceResponse> CreatePrivateVirtualInterfaceAsync(CreatePrivateVirtualInterfaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePrivateVirtualInterfaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePrivateVirtualInterfaceResponseUnmarshaller.Instance;

            return InvokeAsync<CreatePrivateVirtualInterfaceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreatePublicVirtualInterface

        internal virtual CreatePublicVirtualInterfaceResponse CreatePublicVirtualInterface(CreatePublicVirtualInterfaceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePublicVirtualInterfaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePublicVirtualInterfaceResponseUnmarshaller.Instance;

            return Invoke<CreatePublicVirtualInterfaceResponse>(request, options);
        }



        /// <summary>
        /// Creates a public virtual interface. A virtual interface is the VLAN that transports
        /// Direct Connect traffic. A public virtual interface supports sending traffic to public
        /// services of Amazon Web Services such as Amazon S3.
        /// 
        ///  
        /// <para>
        /// When creating an IPv6 public virtual interface (<code>addressFamily</code> is <code>ipv6</code>),
        /// leave the <code>customer</code> and <code>amazon</code> address fields blank to use
        /// auto-assigned IPv6 space. Custom IPv6 addresses are not supported.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreatePublicVirtualInterface service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreatePublicVirtualInterface service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DuplicateTagKeysException">
        /// A tag key was specified more than once.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.TooManyTagsException">
        /// You have reached the limit on the number of tags that can be assigned.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/CreatePublicVirtualInterface">REST API Reference for CreatePublicVirtualInterface Operation</seealso>
        public virtual Task<CreatePublicVirtualInterfaceResponse> CreatePublicVirtualInterfaceAsync(CreatePublicVirtualInterfaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePublicVirtualInterfaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePublicVirtualInterfaceResponseUnmarshaller.Instance;

            return InvokeAsync<CreatePublicVirtualInterfaceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateTransitVirtualInterface

        internal virtual CreateTransitVirtualInterfaceResponse CreateTransitVirtualInterface(CreateTransitVirtualInterfaceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTransitVirtualInterfaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTransitVirtualInterfaceResponseUnmarshaller.Instance;

            return Invoke<CreateTransitVirtualInterfaceResponse>(request, options);
        }



        /// <summary>
        /// Creates a transit virtual interface. A transit virtual interface should be used to
        /// access one or more transit gateways associated with Direct Connect gateways. A transit
        /// virtual interface enables the connection of multiple VPCs attached to a transit gateway
        /// to a Direct Connect gateway.
        /// 
        ///  <important> 
        /// <para>
        /// If you associate your transit gateway with one or more Direct Connect gateways, the
        /// Autonomous System Number (ASN) used by the transit gateway and the Direct Connect
        /// gateway must be different. For example, if you use the default ASN 64512 for both
        /// your the transit gateway and Direct Connect gateway, the association request fails.
        /// </para>
        ///  </important> 
        /// <para>
        /// A jumbo MTU value must be either 1500 or 8500. No other values will be accepted. Setting
        /// the MTU of a virtual interface to 8500 (jumbo frames) can cause an update to the underlying
        /// physical connection if it wasn't updated to support jumbo frames. Updating the connection
        /// disrupts network connectivity for all virtual interfaces associated with the connection
        /// for up to 30 seconds. To check whether your connection supports jumbo frames, call
        /// <a>DescribeConnections</a>. To check whether your virtual interface supports jumbo
        /// frames, call <a>DescribeVirtualInterfaces</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTransitVirtualInterface service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTransitVirtualInterface service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DuplicateTagKeysException">
        /// A tag key was specified more than once.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.TooManyTagsException">
        /// You have reached the limit on the number of tags that can be assigned.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/CreateTransitVirtualInterface">REST API Reference for CreateTransitVirtualInterface Operation</seealso>
        public virtual Task<CreateTransitVirtualInterfaceResponse> CreateTransitVirtualInterfaceAsync(CreateTransitVirtualInterfaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTransitVirtualInterfaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTransitVirtualInterfaceResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTransitVirtualInterfaceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteBGPPeer

        internal virtual DeleteBGPPeerResponse DeleteBGPPeer(DeleteBGPPeerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBGPPeerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBGPPeerResponseUnmarshaller.Instance;

            return Invoke<DeleteBGPPeerResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified BGP peer on the specified virtual interface with the specified
        /// customer address and ASN.
        /// 
        ///  
        /// <para>
        /// You cannot delete the last BGP peer from a virtual interface.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteBGPPeer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteBGPPeer service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DeleteBGPPeer">REST API Reference for DeleteBGPPeer Operation</seealso>
        public virtual Task<DeleteBGPPeerResponse> DeleteBGPPeerAsync(DeleteBGPPeerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteBGPPeerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteBGPPeerResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteBGPPeerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteConnection

        internal virtual DeleteConnectionResponse DeleteConnection(DeleteConnectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConnectionResponseUnmarshaller.Instance;

            return Invoke<DeleteConnectionResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified connection.
        /// 
        ///  
        /// <para>
        /// Deleting a connection only stops the Direct Connect port hour and data transfer charges.
        /// If you are partnering with any third parties to connect with the Direct Connect location,
        /// you must cancel your service with them separately.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteConnection service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DeleteConnection">REST API Reference for DeleteConnection Operation</seealso>
        public virtual Task<DeleteConnectionResponse> DeleteConnectionAsync(DeleteConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteConnectionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDirectConnectGateway

        internal virtual DeleteDirectConnectGatewayResponse DeleteDirectConnectGateway(DeleteDirectConnectGatewayRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDirectConnectGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDirectConnectGatewayResponseUnmarshaller.Instance;

            return Invoke<DeleteDirectConnectGatewayResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified Direct Connect gateway. You must first delete all virtual interfaces
        /// that are attached to the Direct Connect gateway and disassociate all virtual private
        /// gateways associated with the Direct Connect gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDirectConnectGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDirectConnectGateway service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DeleteDirectConnectGateway">REST API Reference for DeleteDirectConnectGateway Operation</seealso>
        public virtual Task<DeleteDirectConnectGatewayResponse> DeleteDirectConnectGatewayAsync(DeleteDirectConnectGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDirectConnectGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDirectConnectGatewayResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDirectConnectGatewayResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDirectConnectGatewayAssociation

        internal virtual DeleteDirectConnectGatewayAssociationResponse DeleteDirectConnectGatewayAssociation(DeleteDirectConnectGatewayAssociationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDirectConnectGatewayAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDirectConnectGatewayAssociationResponseUnmarshaller.Instance;

            return Invoke<DeleteDirectConnectGatewayAssociationResponse>(request, options);
        }



        /// <summary>
        /// Deletes the association between the specified Direct Connect gateway and virtual private
        /// gateway.
        /// 
        ///  
        /// <para>
        /// We recommend that you specify the <code>associationID</code> to delete the association.
        /// Alternatively, if you own virtual gateway and a Direct Connect gateway association,
        /// you can specify the <code>virtualGatewayId</code> and <code>directConnectGatewayId</code>
        /// to delete an association.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDirectConnectGatewayAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDirectConnectGatewayAssociation service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DeleteDirectConnectGatewayAssociation">REST API Reference for DeleteDirectConnectGatewayAssociation Operation</seealso>
        public virtual Task<DeleteDirectConnectGatewayAssociationResponse> DeleteDirectConnectGatewayAssociationAsync(DeleteDirectConnectGatewayAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDirectConnectGatewayAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDirectConnectGatewayAssociationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDirectConnectGatewayAssociationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDirectConnectGatewayAssociationProposal

        internal virtual DeleteDirectConnectGatewayAssociationProposalResponse DeleteDirectConnectGatewayAssociationProposal(DeleteDirectConnectGatewayAssociationProposalRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDirectConnectGatewayAssociationProposalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDirectConnectGatewayAssociationProposalResponseUnmarshaller.Instance;

            return Invoke<DeleteDirectConnectGatewayAssociationProposalResponse>(request, options);
        }



        /// <summary>
        /// Deletes the association proposal request between the specified Direct Connect gateway
        /// and virtual private gateway or transit gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDirectConnectGatewayAssociationProposal service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDirectConnectGatewayAssociationProposal service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DeleteDirectConnectGatewayAssociationProposal">REST API Reference for DeleteDirectConnectGatewayAssociationProposal Operation</seealso>
        public virtual Task<DeleteDirectConnectGatewayAssociationProposalResponse> DeleteDirectConnectGatewayAssociationProposalAsync(DeleteDirectConnectGatewayAssociationProposalRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDirectConnectGatewayAssociationProposalRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDirectConnectGatewayAssociationProposalResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDirectConnectGatewayAssociationProposalResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteInterconnect

        internal virtual DeleteInterconnectResponse DeleteInterconnect(DeleteInterconnectRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteInterconnectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInterconnectResponseUnmarshaller.Instance;

            return Invoke<DeleteInterconnectResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified interconnect.
        /// 
        ///  <note> 
        /// <para>
        /// Intended for use by Direct Connect Partners only.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteInterconnect service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteInterconnect service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DeleteInterconnect">REST API Reference for DeleteInterconnect Operation</seealso>
        public virtual Task<DeleteInterconnectResponse> DeleteInterconnectAsync(DeleteInterconnectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteInterconnectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteInterconnectResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteInterconnectResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteLag

        internal virtual DeleteLagResponse DeleteLag(DeleteLagRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLagRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLagResponseUnmarshaller.Instance;

            return Invoke<DeleteLagResponse>(request, options);
        }



        /// <summary>
        /// Deletes the specified link aggregation group (LAG). You cannot delete a LAG if it
        /// has active virtual interfaces or hosted connections.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLag service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteLag service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DeleteLag">REST API Reference for DeleteLag Operation</seealso>
        public virtual Task<DeleteLagResponse> DeleteLagAsync(DeleteLagRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLagRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLagResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteLagResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteVirtualInterface

        internal virtual DeleteVirtualInterfaceResponse DeleteVirtualInterface(DeleteVirtualInterfaceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVirtualInterfaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVirtualInterfaceResponseUnmarshaller.Instance;

            return Invoke<DeleteVirtualInterfaceResponse>(request, options);
        }



        /// <summary>
        /// Deletes a virtual interface.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteVirtualInterface service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteVirtualInterface service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DeleteVirtualInterface">REST API Reference for DeleteVirtualInterface Operation</seealso>
        public virtual Task<DeleteVirtualInterfaceResponse> DeleteVirtualInterfaceAsync(DeleteVirtualInterfaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteVirtualInterfaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteVirtualInterfaceResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteVirtualInterfaceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeConnectionLoa

        [Obsolete("Deprecated in favor of DescribeLoa.")]
        internal virtual DescribeConnectionLoaResponse DescribeConnectionLoa(DescribeConnectionLoaRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeConnectionLoaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConnectionLoaResponseUnmarshaller.Instance;

            return Invoke<DescribeConnectionLoaResponse>(request, options);
        }



        /// <summary>
        /// Deprecated. Use <a>DescribeLoa</a> instead.
        /// 
        ///  
        /// <para>
        /// Gets the LOA-CFA for a connection.
        /// </para>
        ///  
        /// <para>
        /// The Letter of Authorization - Connecting Facility Assignment (LOA-CFA) is a document
        /// that your APN partner or service provider uses when establishing your cross connect
        /// to Amazon Web Services at the colocation facility. For more information, see <a href="https://docs.aws.amazon.com/directconnect/latest/UserGuide/Colocation.html">Requesting
        /// Cross Connects at Direct Connect Locations</a> in the <i>Direct Connect User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConnectionLoa service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeConnectionLoa service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeConnectionLoa">REST API Reference for DescribeConnectionLoa Operation</seealso>
        [Obsolete("Deprecated in favor of DescribeLoa.")]
        public virtual Task<DescribeConnectionLoaResponse> DescribeConnectionLoaAsync(DescribeConnectionLoaRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeConnectionLoaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConnectionLoaResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeConnectionLoaResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeConnections

        internal virtual DescribeConnectionsResponse DescribeConnections()
        {
            return DescribeConnections(new DescribeConnectionsRequest());
        }
        internal virtual DescribeConnectionsResponse DescribeConnections(DescribeConnectionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeConnectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConnectionsResponseUnmarshaller.Instance;

            return Invoke<DescribeConnectionsResponse>(request, options);
        }


        /// <summary>
        /// Displays the specified connection or all connections in this Region.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeConnections service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeConnections">REST API Reference for DescribeConnections Operation</seealso>
        public virtual Task<DescribeConnectionsResponse> DescribeConnectionsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeConnectionsAsync(new DescribeConnectionsRequest(), cancellationToken);
        }



        /// <summary>
        /// Displays the specified connection or all connections in this Region.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConnections service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeConnections service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeConnections">REST API Reference for DescribeConnections Operation</seealso>
        public virtual Task<DescribeConnectionsResponse> DescribeConnectionsAsync(DescribeConnectionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeConnectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConnectionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeConnectionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeConnectionsOnInterconnect

        [Obsolete("Deprecated in favor of DescribeHostedConnections.")]
        internal virtual DescribeConnectionsOnInterconnectResponse DescribeConnectionsOnInterconnect(DescribeConnectionsOnInterconnectRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeConnectionsOnInterconnectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConnectionsOnInterconnectResponseUnmarshaller.Instance;

            return Invoke<DescribeConnectionsOnInterconnectResponse>(request, options);
        }



        /// <summary>
        /// Deprecated. Use <a>DescribeHostedConnections</a> instead.
        /// 
        ///  
        /// <para>
        /// Lists the connections that have been provisioned on the specified interconnect.
        /// </para>
        ///  <note> 
        /// <para>
        /// Intended for use by Direct Connect Partners only.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeConnectionsOnInterconnect service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeConnectionsOnInterconnect service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeConnectionsOnInterconnect">REST API Reference for DescribeConnectionsOnInterconnect Operation</seealso>
        [Obsolete("Deprecated in favor of DescribeHostedConnections.")]
        public virtual Task<DescribeConnectionsOnInterconnectResponse> DescribeConnectionsOnInterconnectAsync(DescribeConnectionsOnInterconnectRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeConnectionsOnInterconnectRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeConnectionsOnInterconnectResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeConnectionsOnInterconnectResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeCustomerMetadata

        internal virtual DescribeCustomerMetadataResponse DescribeCustomerMetadata(DescribeCustomerMetadataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCustomerMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCustomerMetadataResponseUnmarshaller.Instance;

            return Invoke<DescribeCustomerMetadataResponse>(request, options);
        }



        /// <summary>
        /// Get and view a list of customer agreements, along with their signed status and whether
        /// the customer is an NNIPartner, NNIPartnerV2, or a nonPartner.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeCustomerMetadata service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeCustomerMetadata service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeCustomerMetadata">REST API Reference for DescribeCustomerMetadata Operation</seealso>
        public virtual Task<DescribeCustomerMetadataResponse> DescribeCustomerMetadataAsync(DescribeCustomerMetadataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeCustomerMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeCustomerMetadataResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeCustomerMetadataResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDirectConnectGatewayAssociationProposals

        internal virtual DescribeDirectConnectGatewayAssociationProposalsResponse DescribeDirectConnectGatewayAssociationProposals(DescribeDirectConnectGatewayAssociationProposalsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDirectConnectGatewayAssociationProposalsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDirectConnectGatewayAssociationProposalsResponseUnmarshaller.Instance;

            return Invoke<DescribeDirectConnectGatewayAssociationProposalsResponse>(request, options);
        }



        /// <summary>
        /// Describes one or more association proposals for connection between a virtual private
        /// gateway or transit gateway and a Direct Connect gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDirectConnectGatewayAssociationProposals service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDirectConnectGatewayAssociationProposals service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeDirectConnectGatewayAssociationProposals">REST API Reference for DescribeDirectConnectGatewayAssociationProposals Operation</seealso>
        public virtual Task<DescribeDirectConnectGatewayAssociationProposalsResponse> DescribeDirectConnectGatewayAssociationProposalsAsync(DescribeDirectConnectGatewayAssociationProposalsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDirectConnectGatewayAssociationProposalsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDirectConnectGatewayAssociationProposalsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDirectConnectGatewayAssociationProposalsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDirectConnectGatewayAssociations

        internal virtual DescribeDirectConnectGatewayAssociationsResponse DescribeDirectConnectGatewayAssociations(DescribeDirectConnectGatewayAssociationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDirectConnectGatewayAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDirectConnectGatewayAssociationsResponseUnmarshaller.Instance;

            return Invoke<DescribeDirectConnectGatewayAssociationsResponse>(request, options);
        }



        /// <summary>
        /// Lists the associations between your Direct Connect gateways and virtual private gateways
        /// and transit gateways. You must specify one of the following:
        /// 
        ///  <ul> <li> 
        /// <para>
        /// A Direct Connect gateway
        /// </para>
        ///  
        /// <para>
        /// The response contains all virtual private gateways and transit gateways associated
        /// with the Direct Connect gateway.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A virtual private gateway
        /// </para>
        ///  
        /// <para>
        /// The response contains the Direct Connect gateway.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A transit gateway
        /// </para>
        ///  
        /// <para>
        /// The response contains the Direct Connect gateway.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A Direct Connect gateway and a virtual private gateway
        /// </para>
        ///  
        /// <para>
        /// The response contains the association between the Direct Connect gateway and virtual
        /// private gateway.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// A Direct Connect gateway and a transit gateway
        /// </para>
        ///  
        /// <para>
        /// The response contains the association between the Direct Connect gateway and transit
        /// gateway.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDirectConnectGatewayAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDirectConnectGatewayAssociations service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeDirectConnectGatewayAssociations">REST API Reference for DescribeDirectConnectGatewayAssociations Operation</seealso>
        public virtual Task<DescribeDirectConnectGatewayAssociationsResponse> DescribeDirectConnectGatewayAssociationsAsync(DescribeDirectConnectGatewayAssociationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDirectConnectGatewayAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDirectConnectGatewayAssociationsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDirectConnectGatewayAssociationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDirectConnectGatewayAttachments

        internal virtual DescribeDirectConnectGatewayAttachmentsResponse DescribeDirectConnectGatewayAttachments(DescribeDirectConnectGatewayAttachmentsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDirectConnectGatewayAttachmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDirectConnectGatewayAttachmentsResponseUnmarshaller.Instance;

            return Invoke<DescribeDirectConnectGatewayAttachmentsResponse>(request, options);
        }



        /// <summary>
        /// Lists the attachments between your Direct Connect gateways and virtual interfaces.
        /// You must specify a Direct Connect gateway, a virtual interface, or both. If you specify
        /// a Direct Connect gateway, the response contains all virtual interfaces attached to
        /// the Direct Connect gateway. If you specify a virtual interface, the response contains
        /// all Direct Connect gateways attached to the virtual interface. If you specify both,
        /// the response contains the attachment between the Direct Connect gateway and the virtual
        /// interface.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDirectConnectGatewayAttachments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDirectConnectGatewayAttachments service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeDirectConnectGatewayAttachments">REST API Reference for DescribeDirectConnectGatewayAttachments Operation</seealso>
        public virtual Task<DescribeDirectConnectGatewayAttachmentsResponse> DescribeDirectConnectGatewayAttachmentsAsync(DescribeDirectConnectGatewayAttachmentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDirectConnectGatewayAttachmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDirectConnectGatewayAttachmentsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDirectConnectGatewayAttachmentsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeDirectConnectGateways

        internal virtual DescribeDirectConnectGatewaysResponse DescribeDirectConnectGateways(DescribeDirectConnectGatewaysRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDirectConnectGatewaysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDirectConnectGatewaysResponseUnmarshaller.Instance;

            return Invoke<DescribeDirectConnectGatewaysResponse>(request, options);
        }



        /// <summary>
        /// Lists all your Direct Connect gateways or only the specified Direct Connect gateway.
        /// Deleted Direct Connect gateways are not returned.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeDirectConnectGateways service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeDirectConnectGateways service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeDirectConnectGateways">REST API Reference for DescribeDirectConnectGateways Operation</seealso>
        public virtual Task<DescribeDirectConnectGatewaysResponse> DescribeDirectConnectGatewaysAsync(DescribeDirectConnectGatewaysRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDirectConnectGatewaysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDirectConnectGatewaysResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeDirectConnectGatewaysResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeHostedConnections

        internal virtual DescribeHostedConnectionsResponse DescribeHostedConnections(DescribeHostedConnectionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeHostedConnectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeHostedConnectionsResponseUnmarshaller.Instance;

            return Invoke<DescribeHostedConnectionsResponse>(request, options);
        }



        /// <summary>
        /// Lists the hosted connections that have been provisioned on the specified interconnect
        /// or link aggregation group (LAG).
        /// 
        ///  <note> 
        /// <para>
        /// Intended for use by Direct Connect Partners only.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeHostedConnections service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeHostedConnections service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeHostedConnections">REST API Reference for DescribeHostedConnections Operation</seealso>
        public virtual Task<DescribeHostedConnectionsResponse> DescribeHostedConnectionsAsync(DescribeHostedConnectionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeHostedConnectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeHostedConnectionsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeHostedConnectionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeInterconnectLoa

        [Obsolete("Deprecated in favor of DescribeLoa.")]
        internal virtual DescribeInterconnectLoaResponse DescribeInterconnectLoa(DescribeInterconnectLoaRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInterconnectLoaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInterconnectLoaResponseUnmarshaller.Instance;

            return Invoke<DescribeInterconnectLoaResponse>(request, options);
        }



        /// <summary>
        /// Deprecated. Use <a>DescribeLoa</a> instead.
        /// 
        ///  
        /// <para>
        /// Gets the LOA-CFA for the specified interconnect.
        /// </para>
        ///  
        /// <para>
        /// The Letter of Authorization - Connecting Facility Assignment (LOA-CFA) is a document
        /// that is used when establishing your cross connect to Amazon Web Services at the colocation
        /// facility. For more information, see <a href="https://docs.aws.amazon.com/directconnect/latest/UserGuide/Colocation.html">Requesting
        /// Cross Connects at Direct Connect Locations</a> in the <i>Direct Connect User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInterconnectLoa service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeInterconnectLoa service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeInterconnectLoa">REST API Reference for DescribeInterconnectLoa Operation</seealso>
        [Obsolete("Deprecated in favor of DescribeLoa.")]
        public virtual Task<DescribeInterconnectLoaResponse> DescribeInterconnectLoaAsync(DescribeInterconnectLoaRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInterconnectLoaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInterconnectLoaResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeInterconnectLoaResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeInterconnects

        internal virtual DescribeInterconnectsResponse DescribeInterconnects()
        {
            return DescribeInterconnects(new DescribeInterconnectsRequest());
        }
        internal virtual DescribeInterconnectsResponse DescribeInterconnects(DescribeInterconnectsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInterconnectsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInterconnectsResponseUnmarshaller.Instance;

            return Invoke<DescribeInterconnectsResponse>(request, options);
        }


        /// <summary>
        /// Lists the interconnects owned by the Amazon Web Services account or only the specified
        /// interconnect.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeInterconnects service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeInterconnects">REST API Reference for DescribeInterconnects Operation</seealso>
        public virtual Task<DescribeInterconnectsResponse> DescribeInterconnectsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeInterconnectsAsync(new DescribeInterconnectsRequest(), cancellationToken);
        }



        /// <summary>
        /// Lists the interconnects owned by the Amazon Web Services account or only the specified
        /// interconnect.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeInterconnects service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeInterconnects service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeInterconnects">REST API Reference for DescribeInterconnects Operation</seealso>
        public virtual Task<DescribeInterconnectsResponse> DescribeInterconnectsAsync(DescribeInterconnectsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeInterconnectsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeInterconnectsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeInterconnectsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeLags

        internal virtual DescribeLagsResponse DescribeLags(DescribeLagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLagsResponseUnmarshaller.Instance;

            return Invoke<DescribeLagsResponse>(request, options);
        }



        /// <summary>
        /// Describes all your link aggregation groups (LAG) or the specified LAG.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLags service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeLags">REST API Reference for DescribeLags Operation</seealso>
        public virtual Task<DescribeLagsResponse> DescribeLagsAsync(DescribeLagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLagsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeLagsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeLoa

        internal virtual DescribeLoaResponse DescribeLoa(DescribeLoaRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLoaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLoaResponseUnmarshaller.Instance;

            return Invoke<DescribeLoaResponse>(request, options);
        }



        /// <summary>
        /// Gets the LOA-CFA for a connection, interconnect, or link aggregation group (LAG).
        /// 
        ///  
        /// <para>
        /// The Letter of Authorization - Connecting Facility Assignment (LOA-CFA) is a document
        /// that is used when establishing your cross connect to Amazon Web Services at the colocation
        /// facility. For more information, see <a href="https://docs.aws.amazon.com/directconnect/latest/UserGuide/Colocation.html">Requesting
        /// Cross Connects at Direct Connect Locations</a> in the <i>Direct Connect User Guide</i>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoa service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLoa service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeLoa">REST API Reference for DescribeLoa Operation</seealso>
        public virtual Task<DescribeLoaResponse> DescribeLoaAsync(DescribeLoaRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLoaRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLoaResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeLoaResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeLocations

        internal virtual DescribeLocationsResponse DescribeLocations()
        {
            return DescribeLocations(new DescribeLocationsRequest());
        }
        internal virtual DescribeLocationsResponse DescribeLocations(DescribeLocationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLocationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLocationsResponseUnmarshaller.Instance;

            return Invoke<DescribeLocationsResponse>(request, options);
        }


        /// <summary>
        /// Lists the Direct Connect locations in the current Amazon Web Services Region. These
        /// are the locations that can be selected when calling <a>CreateConnection</a> or <a>CreateInterconnect</a>.
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLocations service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeLocations">REST API Reference for DescribeLocations Operation</seealso>
        public virtual Task<DescribeLocationsResponse> DescribeLocationsAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeLocationsAsync(new DescribeLocationsRequest(), cancellationToken);
        }



        /// <summary>
        /// Lists the Direct Connect locations in the current Amazon Web Services Region. These
        /// are the locations that can be selected when calling <a>CreateConnection</a> or <a>CreateInterconnect</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeLocations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeLocations service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeLocations">REST API Reference for DescribeLocations Operation</seealso>
        public virtual Task<DescribeLocationsResponse> DescribeLocationsAsync(DescribeLocationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLocationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLocationsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeLocationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeRouterConfiguration

        internal virtual DescribeRouterConfigurationResponse DescribeRouterConfiguration(DescribeRouterConfigurationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRouterConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRouterConfigurationResponseUnmarshaller.Instance;

            return Invoke<DescribeRouterConfigurationResponse>(request, options);
        }



        /// <summary>
        /// Details about the router.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeRouterConfiguration service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeRouterConfiguration service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeRouterConfiguration">REST API Reference for DescribeRouterConfiguration Operation</seealso>
        public virtual Task<DescribeRouterConfigurationResponse> DescribeRouterConfigurationAsync(DescribeRouterConfigurationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeRouterConfigurationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeRouterConfigurationResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeRouterConfigurationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeTags

        internal virtual DescribeTagsResponse DescribeTags(DescribeTagsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTagsResponseUnmarshaller.Instance;

            return Invoke<DescribeTagsResponse>(request, options);
        }



        /// <summary>
        /// Describes the tags associated with the specified Direct Connect resources.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeTags service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeTags service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeTags">REST API Reference for DescribeTags Operation</seealso>
        public virtual Task<DescribeTagsResponse> DescribeTagsAsync(DescribeTagsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeTagsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeTagsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeTagsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeVirtualGateways

        internal virtual DescribeVirtualGatewaysResponse DescribeVirtualGateways()
        {
            return DescribeVirtualGateways(new DescribeVirtualGatewaysRequest());
        }
        internal virtual DescribeVirtualGatewaysResponse DescribeVirtualGateways(DescribeVirtualGatewaysRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVirtualGatewaysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVirtualGatewaysResponseUnmarshaller.Instance;

            return Invoke<DescribeVirtualGatewaysResponse>(request, options);
        }


        /// <summary>
        /// Lists the virtual private gateways owned by the Amazon Web Services account.
        /// 
        ///  
        /// <para>
        /// You can create one or more Direct Connect private virtual interfaces linked to a virtual
        /// private gateway.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeVirtualGateways service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeVirtualGateways">REST API Reference for DescribeVirtualGateways Operation</seealso>
        public virtual Task<DescribeVirtualGatewaysResponse> DescribeVirtualGatewaysAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeVirtualGatewaysAsync(new DescribeVirtualGatewaysRequest(), cancellationToken);
        }



        /// <summary>
        /// Lists the virtual private gateways owned by the Amazon Web Services account.
        /// 
        ///  
        /// <para>
        /// You can create one or more Direct Connect private virtual interfaces linked to a virtual
        /// private gateway.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVirtualGateways service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeVirtualGateways service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeVirtualGateways">REST API Reference for DescribeVirtualGateways Operation</seealso>
        public virtual Task<DescribeVirtualGatewaysResponse> DescribeVirtualGatewaysAsync(DescribeVirtualGatewaysRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVirtualGatewaysRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVirtualGatewaysResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeVirtualGatewaysResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeVirtualInterfaces

        internal virtual DescribeVirtualInterfacesResponse DescribeVirtualInterfaces()
        {
            return DescribeVirtualInterfaces(new DescribeVirtualInterfacesRequest());
        }
        internal virtual DescribeVirtualInterfacesResponse DescribeVirtualInterfaces(DescribeVirtualInterfacesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVirtualInterfacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVirtualInterfacesResponseUnmarshaller.Instance;

            return Invoke<DescribeVirtualInterfacesResponse>(request, options);
        }


        /// <summary>
        /// Displays all virtual interfaces for an Amazon Web Services account. Virtual interfaces
        /// deleted fewer than 15 minutes before you make the request are also returned. If you
        /// specify a connection ID, only the virtual interfaces associated with the connection
        /// are returned. If you specify a virtual interface ID, then only a single virtual interface
        /// is returned.
        /// 
        ///  
        /// <para>
        /// A virtual interface (VLAN) transmits the traffic between the Direct Connect location
        /// and the customer network.
        /// </para>
        /// </summary>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeVirtualInterfaces service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeVirtualInterfaces">REST API Reference for DescribeVirtualInterfaces Operation</seealso>
        public virtual Task<DescribeVirtualInterfacesResponse> DescribeVirtualInterfacesAsync(System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            return DescribeVirtualInterfacesAsync(new DescribeVirtualInterfacesRequest(), cancellationToken);
        }



        /// <summary>
        /// Displays all virtual interfaces for an Amazon Web Services account. Virtual interfaces
        /// deleted fewer than 15 minutes before you make the request are also returned. If you
        /// specify a connection ID, only the virtual interfaces associated with the connection
        /// are returned. If you specify a virtual interface ID, then only a single virtual interface
        /// is returned.
        /// 
        ///  
        /// <para>
        /// A virtual interface (VLAN) transmits the traffic between the Direct Connect location
        /// and the customer network.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeVirtualInterfaces service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeVirtualInterfaces service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeVirtualInterfaces">REST API Reference for DescribeVirtualInterfaces Operation</seealso>
        public virtual Task<DescribeVirtualInterfacesResponse> DescribeVirtualInterfacesAsync(DescribeVirtualInterfacesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeVirtualInterfacesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeVirtualInterfacesResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeVirtualInterfacesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateConnectionFromLag

        internal virtual DisassociateConnectionFromLagResponse DisassociateConnectionFromLag(DisassociateConnectionFromLagRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateConnectionFromLagRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateConnectionFromLagResponseUnmarshaller.Instance;

            return Invoke<DisassociateConnectionFromLagResponse>(request, options);
        }



        /// <summary>
        /// Disassociates a connection from a link aggregation group (LAG). The connection is
        /// interrupted and re-established as a standalone connection (the connection is not deleted;
        /// to delete the connection, use the <a>DeleteConnection</a> request). If the LAG has
        /// associated virtual interfaces or hosted connections, they remain associated with the
        /// LAG. A disassociated connection owned by an Direct Connect Partner is automatically
        /// converted to an interconnect.
        /// 
        ///  
        /// <para>
        /// If disassociating the connection would cause the LAG to fall below its setting for
        /// minimum number of operational connections, the request fails, except when it's the
        /// last member of the LAG. If all connections are disassociated, the LAG continues to
        /// exist as an empty LAG with no physical connections. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateConnectionFromLag service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateConnectionFromLag service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DisassociateConnectionFromLag">REST API Reference for DisassociateConnectionFromLag Operation</seealso>
        public virtual Task<DisassociateConnectionFromLagResponse> DisassociateConnectionFromLagAsync(DisassociateConnectionFromLagRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateConnectionFromLagRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateConnectionFromLagResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateConnectionFromLagResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateMacSecKey

        internal virtual DisassociateMacSecKeyResponse DisassociateMacSecKey(DisassociateMacSecKeyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateMacSecKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateMacSecKeyResponseUnmarshaller.Instance;

            return Invoke<DisassociateMacSecKeyResponse>(request, options);
        }



        /// <summary>
        /// Removes the association between a MAC Security (MACsec) security key and an Direct
        /// Connect dedicated connection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateMacSecKey service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateMacSecKey service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DisassociateMacSecKey">REST API Reference for DisassociateMacSecKey Operation</seealso>
        public virtual Task<DisassociateMacSecKeyResponse> DisassociateMacSecKeyAsync(DisassociateMacSecKeyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateMacSecKeyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateMacSecKeyResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateMacSecKeyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListVirtualInterfaceTestHistory

        internal virtual ListVirtualInterfaceTestHistoryResponse ListVirtualInterfaceTestHistory(ListVirtualInterfaceTestHistoryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListVirtualInterfaceTestHistoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVirtualInterfaceTestHistoryResponseUnmarshaller.Instance;

            return Invoke<ListVirtualInterfaceTestHistoryResponse>(request, options);
        }



        /// <summary>
        /// Lists the virtual interface failover test history.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListVirtualInterfaceTestHistory service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListVirtualInterfaceTestHistory service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/ListVirtualInterfaceTestHistory">REST API Reference for ListVirtualInterfaceTestHistory Operation</seealso>
        public virtual Task<ListVirtualInterfaceTestHistoryResponse> ListVirtualInterfaceTestHistoryAsync(ListVirtualInterfaceTestHistoryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListVirtualInterfaceTestHistoryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListVirtualInterfaceTestHistoryResponseUnmarshaller.Instance;

            return InvokeAsync<ListVirtualInterfaceTestHistoryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartBgpFailoverTest

        internal virtual StartBgpFailoverTestResponse StartBgpFailoverTest(StartBgpFailoverTestRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartBgpFailoverTestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartBgpFailoverTestResponseUnmarshaller.Instance;

            return Invoke<StartBgpFailoverTestResponse>(request, options);
        }



        /// <summary>
        /// Starts the virtual interface failover test that verifies your configuration meets
        /// your resiliency requirements by placing the BGP peering session in the DOWN state.
        /// You can then send traffic to verify that there are no outages.
        /// 
        ///  
        /// <para>
        /// You can run the test on public, private, transit, and hosted virtual interfaces.
        /// </para>
        ///  
        /// <para>
        /// You can use <a href="https://docs.aws.amazon.com/directconnect/latest/APIReference/API_ListVirtualInterfaceTestHistory.html">ListVirtualInterfaceTestHistory</a>
        /// to view the virtual interface test history.
        /// </para>
        ///  
        /// <para>
        /// If you need to stop the test before the test interval completes, use <a href="https://docs.aws.amazon.com/directconnect/latest/APIReference/API_StopBgpFailoverTest.html">StopBgpFailoverTest</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartBgpFailoverTest service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartBgpFailoverTest service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/StartBgpFailoverTest">REST API Reference for StartBgpFailoverTest Operation</seealso>
        public virtual Task<StartBgpFailoverTestResponse> StartBgpFailoverTestAsync(StartBgpFailoverTestRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartBgpFailoverTestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartBgpFailoverTestResponseUnmarshaller.Instance;

            return InvokeAsync<StartBgpFailoverTestResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StopBgpFailoverTest

        internal virtual StopBgpFailoverTestResponse StopBgpFailoverTest(StopBgpFailoverTestRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopBgpFailoverTestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopBgpFailoverTestResponseUnmarshaller.Instance;

            return Invoke<StopBgpFailoverTestResponse>(request, options);
        }



        /// <summary>
        /// Stops the virtual interface failover test.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StopBgpFailoverTest service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StopBgpFailoverTest service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/StopBgpFailoverTest">REST API Reference for StopBgpFailoverTest Operation</seealso>
        public virtual Task<StopBgpFailoverTestResponse> StopBgpFailoverTestAsync(StopBgpFailoverTestRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StopBgpFailoverTestRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StopBgpFailoverTestResponseUnmarshaller.Instance;

            return InvokeAsync<StopBgpFailoverTestResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  TagResource

        internal virtual TagResourceResponse TagResource(TagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return Invoke<TagResourceResponse>(request, options);
        }



        /// <summary>
        /// Adds the specified tags to the specified Direct Connect resource. Each resource can
        /// have a maximum of 50 tags.
        /// 
        ///  
        /// <para>
        /// Each tag consists of a key and an optional value. If a tag with the same key is already
        /// associated with the resource, this action updates its value.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DuplicateTagKeysException">
        /// A tag key was specified more than once.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.TooManyTagsException">
        /// You have reached the limit on the number of tags that can be assigned.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual Task<TagResourceResponse> TagResourceAsync(TagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<TagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UntagResource

        internal virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return Invoke<UntagResourceResponse>(request, options);
        }



        /// <summary>
        /// Removes one or more tags from the specified Direct Connect resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateConnection

        internal virtual UpdateConnectionResponse UpdateConnection(UpdateConnectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConnectionResponseUnmarshaller.Instance;

            return Invoke<UpdateConnectionResponse>(request, options);
        }



        /// <summary>
        /// Updates the Direct Connect dedicated connection configuration.
        /// 
        ///  
        /// <para>
        /// You can update the following parameters for a connection:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The connection name
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The connection's MAC Security (MACsec) encryption mode.
        /// </para>
        ///  </li> </ul>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateConnection service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/UpdateConnection">REST API Reference for UpdateConnection Operation</seealso>
        public virtual Task<UpdateConnectionResponse> UpdateConnectionAsync(UpdateConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateConnectionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateDirectConnectGateway

        internal virtual UpdateDirectConnectGatewayResponse UpdateDirectConnectGateway(UpdateDirectConnectGatewayRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDirectConnectGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDirectConnectGatewayResponseUnmarshaller.Instance;

            return Invoke<UpdateDirectConnectGatewayResponse>(request, options);
        }



        /// <summary>
        /// Updates the name of a current Direct Connect gateway.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDirectConnectGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDirectConnectGateway service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/UpdateDirectConnectGateway">REST API Reference for UpdateDirectConnectGateway Operation</seealso>
        public virtual Task<UpdateDirectConnectGatewayResponse> UpdateDirectConnectGatewayAsync(UpdateDirectConnectGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDirectConnectGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDirectConnectGatewayResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDirectConnectGatewayResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateDirectConnectGatewayAssociation

        internal virtual UpdateDirectConnectGatewayAssociationResponse UpdateDirectConnectGatewayAssociation(UpdateDirectConnectGatewayAssociationRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDirectConnectGatewayAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDirectConnectGatewayAssociationResponseUnmarshaller.Instance;

            return Invoke<UpdateDirectConnectGatewayAssociationResponse>(request, options);
        }



        /// <summary>
        /// Updates the specified attributes of the Direct Connect gateway association.
        /// 
        ///  
        /// <para>
        /// Add or remove prefixes from the association.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDirectConnectGatewayAssociation service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDirectConnectGatewayAssociation service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/UpdateDirectConnectGatewayAssociation">REST API Reference for UpdateDirectConnectGatewayAssociation Operation</seealso>
        public virtual Task<UpdateDirectConnectGatewayAssociationResponse> UpdateDirectConnectGatewayAssociationAsync(UpdateDirectConnectGatewayAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDirectConnectGatewayAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDirectConnectGatewayAssociationResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDirectConnectGatewayAssociationResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateLag

        internal virtual UpdateLagResponse UpdateLag(UpdateLagRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateLagRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLagResponseUnmarshaller.Instance;

            return Invoke<UpdateLagResponse>(request, options);
        }



        /// <summary>
        /// Updates the attributes of the specified link aggregation group (LAG).
        /// 
        ///  
        /// <para>
        /// You can update the following LAG attributes:
        /// </para>
        ///  <ul> <li> 
        /// <para>
        /// The name of the LAG.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The value for the minimum number of connections that must be operational for the LAG
        /// itself to be operational. 
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The LAG's MACsec encryption mode.
        /// </para>
        ///  
        /// <para>
        /// Amazon Web Services assigns this value to each connection which is part of the LAG.
        /// </para>
        ///  </li> <li> 
        /// <para>
        /// The tags
        /// </para>
        ///  </li> </ul> <note> 
        /// <para>
        /// If you adjust the threshold value for the minimum number of operational connections,
        /// ensure that the new value does not cause the LAG to fall below the threshold and become
        /// non-operational.
        /// </para>
        ///  </note>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLag service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateLag service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/UpdateLag">REST API Reference for UpdateLag Operation</seealso>
        public virtual Task<UpdateLagResponse> UpdateLagAsync(UpdateLagRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateLagRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLagResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateLagResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateVirtualInterfaceAttributes

        internal virtual UpdateVirtualInterfaceAttributesResponse UpdateVirtualInterfaceAttributes(UpdateVirtualInterfaceAttributesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateVirtualInterfaceAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateVirtualInterfaceAttributesResponseUnmarshaller.Instance;

            return Invoke<UpdateVirtualInterfaceAttributesResponse>(request, options);
        }



        /// <summary>
        /// Updates the specified attributes of the specified virtual private interface.
        /// 
        ///  
        /// <para>
        /// Setting the MTU of a virtual interface to 9001 (jumbo frames) can cause an update
        /// to the underlying physical connection if it wasn't updated to support jumbo frames.
        /// Updating the connection disrupts network connectivity for all virtual interfaces associated
        /// with the connection for up to 30 seconds. To check whether your connection supports
        /// jumbo frames, call <a>DescribeConnections</a>. To check whether your virtual q interface
        /// supports jumbo frames, call <a>DescribeVirtualInterfaces</a>.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVirtualInterfaceAttributes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateVirtualInterfaceAttributes service method, as returned by DirectConnect.</returns>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectClientException">
        /// One or more parameters are not valid.
        /// </exception>
        /// <exception cref="Amazon.DirectConnect.Model.DirectConnectServerException">
        /// A server-side error occurred.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/UpdateVirtualInterfaceAttributes">REST API Reference for UpdateVirtualInterfaceAttributes Operation</seealso>
        public virtual Task<UpdateVirtualInterfaceAttributesResponse> UpdateVirtualInterfaceAttributesAsync(UpdateVirtualInterfaceAttributesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateVirtualInterfaceAttributesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateVirtualInterfaceAttributesResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateVirtualInterfaceAttributesResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}