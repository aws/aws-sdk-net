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
 * Do not modify this file. This file is generated from the networkmanager-2019-07-05.normal.json service model.
 */


using System;
using System.Runtime.ExceptionServices;
using System.Threading;
using System.Threading.Tasks;
using System.Collections.Generic;
using System.Net;

using Amazon.NetworkManager.Model;
using Amazon.NetworkManager.Model.Internal.MarshallTransformations;
using Amazon.NetworkManager.Internal;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;

namespace Amazon.NetworkManager
{
    /// <summary>
    /// Implementation for accessing NetworkManager
    ///
    /// Amazon Web Services enables you to centrally manage your Amazon Web Services Cloud
    /// WAN core network and your Transit Gateway network across Amazon Web Services accounts,
    /// Regions, and on-premises locations.
    /// </summary>
    public partial class AmazonNetworkManagerClient : AmazonServiceClient, IAmazonNetworkManager
    {
        private static IServiceMetadata serviceMetadata = new AmazonNetworkManagerMetadata();
        
        #region Constructors

        /// <summary>
        /// Constructs AmazonNetworkManagerClient with the credentials loaded from the application's
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
        public AmazonNetworkManagerClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonNetworkManagerConfig()) { }

        /// <summary>
        /// Constructs AmazonNetworkManagerClient with the credentials loaded from the application's
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
        public AmazonNetworkManagerClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonNetworkManagerConfig{RegionEndpoint = region}) { }

        /// <summary>
        /// Constructs AmazonNetworkManagerClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonNetworkManagerClient Configuration Object</param>
        public AmazonNetworkManagerClient(AmazonNetworkManagerConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config) { }


        /// <summary>
        /// Constructs AmazonNetworkManagerClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        public AmazonNetworkManagerClient(AWSCredentials credentials)
            : this(credentials, new AmazonNetworkManagerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonNetworkManagerClient with AWS Credentials
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="region">The region to connect.</param>
        public AmazonNetworkManagerClient(AWSCredentials credentials, RegionEndpoint region)
            : this(credentials, new AmazonNetworkManagerConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonNetworkManagerClient with AWS Credentials and an
        /// AmazonNetworkManagerClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonNetworkManagerClient Configuration Object</param>
        public AmazonNetworkManagerClient(AWSCredentials credentials, AmazonNetworkManagerConfig clientConfig)
            : base(credentials, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonNetworkManagerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        public AmazonNetworkManagerClient(string awsAccessKeyId, string awsSecretAccessKey)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonNetworkManagerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonNetworkManagerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="region">The region to connect.</param>
        public AmazonNetworkManagerClient(string awsAccessKeyId, string awsSecretAccessKey, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, new AmazonNetworkManagerConfig() {RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonNetworkManagerClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonNetworkManagerClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonNetworkManagerClient Configuration Object</param>
        public AmazonNetworkManagerClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonNetworkManagerConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig)
        {
        }

        /// <summary>
        /// Constructs AmazonNetworkManagerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        public AmazonNetworkManagerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonNetworkManagerConfig())
        {
        }

        /// <summary>
        /// Constructs AmazonNetworkManagerClient with AWS Access Key ID and AWS Secret Key
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="region">The region to connect.</param>
        public AmazonNetworkManagerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, RegionEndpoint region)
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonNetworkManagerConfig{RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonNetworkManagerClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonNetworkManagerClient Configuration object. 
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonNetworkManagerClient Configuration Object</param>
        public AmazonNetworkManagerClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonNetworkManagerConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig)
        {
        }

        #endregion
#if AWS_ASYNC_ENUMERABLES_API
        private INetworkManagerPaginatorFactory _paginators;

        /// <summary>
        /// Paginators for the service
        /// </summary>
        public INetworkManagerPaginatorFactory Paginators 
        {
            get 
            {
                if (this._paginators == null) 
                {
                    this._paginators = new NetworkManagerPaginatorFactory(this);
                }
                return this._paginators;
            }
        }
#endif

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
            pipeline.AddHandlerAfter<Amazon.Runtime.Internal.Marshaller>(new AmazonNetworkManagerEndpointResolver());
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


        #region  AcceptAttachment

        internal virtual AcceptAttachmentResponse AcceptAttachment(AcceptAttachmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AcceptAttachmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptAttachmentResponseUnmarshaller.Instance;

            return Invoke<AcceptAttachmentResponse>(request, options);
        }



        /// <summary>
        /// Accepts a core network attachment request. 
        /// 
        ///  
        /// <para>
        /// Once the attachment request is accepted by a core network owner, the attachment is
        /// created and connected to a core network.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AcceptAttachment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AcceptAttachment service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ConflictException">
        /// There was a conflict processing the request. Updating or deleting the resource can
        /// cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/AcceptAttachment">REST API Reference for AcceptAttachment Operation</seealso>
        public virtual Task<AcceptAttachmentResponse> AcceptAttachmentAsync(AcceptAttachmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AcceptAttachmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptAttachmentResponseUnmarshaller.Instance;

            return InvokeAsync<AcceptAttachmentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AssociateConnectPeer

        internal virtual AssociateConnectPeerResponse AssociateConnectPeer(AssociateConnectPeerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateConnectPeerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateConnectPeerResponseUnmarshaller.Instance;

            return Invoke<AssociateConnectPeerResponse>(request, options);
        }



        /// <summary>
        /// Associates a core network Connect peer with a device and optionally, with a link.
        /// 
        /// 
        ///  
        /// <para>
        /// If you specify a link, it must be associated with the specified device. You can only
        /// associate core network Connect peers that have been created on a core network Connect
        /// attachment on a core network. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateConnectPeer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateConnectPeer service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ConflictException">
        /// There was a conflict processing the request. Updating or deleting the resource can
        /// cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ServiceQuotaExceededException">
        /// A service limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/AssociateConnectPeer">REST API Reference for AssociateConnectPeer Operation</seealso>
        public virtual Task<AssociateConnectPeerResponse> AssociateConnectPeerAsync(AssociateConnectPeerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateConnectPeerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateConnectPeerResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateConnectPeerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AssociateCustomerGateway

        internal virtual AssociateCustomerGatewayResponse AssociateCustomerGateway(AssociateCustomerGatewayRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateCustomerGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateCustomerGatewayResponseUnmarshaller.Instance;

            return Invoke<AssociateCustomerGatewayResponse>(request, options);
        }



        /// <summary>
        /// Associates a customer gateway with a device and optionally, with a link. If you specify
        /// a link, it must be associated with the specified device. 
        /// 
        ///  
        /// <para>
        /// You can only associate customer gateways that are connected to a VPN attachment on
        /// a transit gateway or core network registered in your global network. When you register
        /// a transit gateway or core network, customer gateways that are connected to the transit
        /// gateway are automatically included in the global network. To list customer gateways
        /// that are connected to a transit gateway, use the <a href="https://docs.aws.amazon.com/AWSEC2/latest/APIReference/API_DescribeVpnConnections.html">DescribeVpnConnections</a>
        /// EC2 API and filter by <code>transit-gateway-id</code>.
        /// </para>
        ///  
        /// <para>
        /// You cannot associate a customer gateway with more than one device and link. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateCustomerGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateCustomerGateway service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ConflictException">
        /// There was a conflict processing the request. Updating or deleting the resource can
        /// cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ServiceQuotaExceededException">
        /// A service limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/AssociateCustomerGateway">REST API Reference for AssociateCustomerGateway Operation</seealso>
        public virtual Task<AssociateCustomerGatewayResponse> AssociateCustomerGatewayAsync(AssociateCustomerGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateCustomerGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateCustomerGatewayResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateCustomerGatewayResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AssociateLink

        internal virtual AssociateLinkResponse AssociateLink(AssociateLinkRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateLinkResponseUnmarshaller.Instance;

            return Invoke<AssociateLinkResponse>(request, options);
        }



        /// <summary>
        /// Associates a link to a device. A device can be associated to multiple links and a
        /// link can be associated to multiple devices. The device and link must be in the same
        /// global network and the same site.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateLink service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateLink service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ConflictException">
        /// There was a conflict processing the request. Updating or deleting the resource can
        /// cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ServiceQuotaExceededException">
        /// A service limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/AssociateLink">REST API Reference for AssociateLink Operation</seealso>
        public virtual Task<AssociateLinkResponse> AssociateLinkAsync(AssociateLinkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateLinkResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateLinkResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  AssociateTransitGatewayConnectPeer

        internal virtual AssociateTransitGatewayConnectPeerResponse AssociateTransitGatewayConnectPeer(AssociateTransitGatewayConnectPeerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateTransitGatewayConnectPeerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateTransitGatewayConnectPeerResponseUnmarshaller.Instance;

            return Invoke<AssociateTransitGatewayConnectPeerResponse>(request, options);
        }



        /// <summary>
        /// Associates a transit gateway Connect peer with a device, and optionally, with a link.
        /// If you specify a link, it must be associated with the specified device. 
        /// 
        ///  
        /// <para>
        /// You can only associate transit gateway Connect peers that have been created on a transit
        /// gateway that's registered in your global network.
        /// </para>
        ///  
        /// <para>
        /// You cannot associate a transit gateway Connect peer with more than one device and
        /// link. 
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateTransitGatewayConnectPeer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the AssociateTransitGatewayConnectPeer service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ConflictException">
        /// There was a conflict processing the request. Updating or deleting the resource can
        /// cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ServiceQuotaExceededException">
        /// A service limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/AssociateTransitGatewayConnectPeer">REST API Reference for AssociateTransitGatewayConnectPeer Operation</seealso>
        public virtual Task<AssociateTransitGatewayConnectPeerResponse> AssociateTransitGatewayConnectPeerAsync(AssociateTransitGatewayConnectPeerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateTransitGatewayConnectPeerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateTransitGatewayConnectPeerResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateTransitGatewayConnectPeerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateConnectAttachment

        internal virtual CreateConnectAttachmentResponse CreateConnectAttachment(CreateConnectAttachmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateConnectAttachmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConnectAttachmentResponseUnmarshaller.Instance;

            return Invoke<CreateConnectAttachmentResponse>(request, options);
        }



        /// <summary>
        /// Creates a core network Connect attachment from a specified core network attachment.
        /// 
        /// 
        ///  
        /// <para>
        /// A core network Connect attachment is a GRE-based tunnel attachment that you can use
        /// to establish a connection between a core network and an appliance. A core network
        /// Connect attachment uses an existing VPC attachment as the underlying transport mechanism.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConnectAttachment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateConnectAttachment service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ConflictException">
        /// There was a conflict processing the request. Updating or deleting the resource can
        /// cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/CreateConnectAttachment">REST API Reference for CreateConnectAttachment Operation</seealso>
        public virtual Task<CreateConnectAttachmentResponse> CreateConnectAttachmentAsync(CreateConnectAttachmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateConnectAttachmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConnectAttachmentResponseUnmarshaller.Instance;

            return InvokeAsync<CreateConnectAttachmentResponse>(request, options, cancellationToken);
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
        /// Creates a connection between two devices. The devices can be a physical or virtual
        /// appliance that connects to a third-party appliance in a VPC, or a physical appliance
        /// that connects to another physical appliance in an on-premises network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateConnection service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ConflictException">
        /// There was a conflict processing the request. Updating or deleting the resource can
        /// cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ServiceQuotaExceededException">
        /// A service limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/CreateConnection">REST API Reference for CreateConnection Operation</seealso>
        public virtual Task<CreateConnectionResponse> CreateConnectionAsync(CreateConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<CreateConnectionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateConnectPeer

        internal virtual CreateConnectPeerResponse CreateConnectPeer(CreateConnectPeerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateConnectPeerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConnectPeerResponseUnmarshaller.Instance;

            return Invoke<CreateConnectPeerResponse>(request, options);
        }



        /// <summary>
        /// Creates a core network Connect peer for a specified core network connect attachment
        /// between a core network and an appliance. The peer address and transit gateway address
        /// must be the same IP address family (IPv4 or IPv6).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConnectPeer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateConnectPeer service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ConflictException">
        /// There was a conflict processing the request. Updating or deleting the resource can
        /// cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/CreateConnectPeer">REST API Reference for CreateConnectPeer Operation</seealso>
        public virtual Task<CreateConnectPeerResponse> CreateConnectPeerAsync(CreateConnectPeerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateConnectPeerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConnectPeerResponseUnmarshaller.Instance;

            return InvokeAsync<CreateConnectPeerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateCoreNetwork

        internal virtual CreateCoreNetworkResponse CreateCoreNetwork(CreateCoreNetworkRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCoreNetworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCoreNetworkResponseUnmarshaller.Instance;

            return Invoke<CreateCoreNetworkResponse>(request, options);
        }



        /// <summary>
        /// Creates a core network as part of your global network, and optionally, with a core
        /// network policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCoreNetwork service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateCoreNetwork service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ConflictException">
        /// There was a conflict processing the request. Updating or deleting the resource can
        /// cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.CoreNetworkPolicyException">
        /// Describes a core network policy exception.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ServiceQuotaExceededException">
        /// A service limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/CreateCoreNetwork">REST API Reference for CreateCoreNetwork Operation</seealso>
        public virtual Task<CreateCoreNetworkResponse> CreateCoreNetworkAsync(CreateCoreNetworkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCoreNetworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCoreNetworkResponseUnmarshaller.Instance;

            return InvokeAsync<CreateCoreNetworkResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateDevice

        internal virtual CreateDeviceResponse CreateDevice(CreateDeviceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDeviceResponseUnmarshaller.Instance;

            return Invoke<CreateDeviceResponse>(request, options);
        }



        /// <summary>
        /// Creates a new device in a global network. If you specify both a site ID and a location,
        /// the location of the site is used for visualization in the Network Manager console.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDevice service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateDevice service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ConflictException">
        /// There was a conflict processing the request. Updating or deleting the resource can
        /// cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ServiceQuotaExceededException">
        /// A service limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/CreateDevice">REST API Reference for CreateDevice Operation</seealso>
        public virtual Task<CreateDeviceResponse> CreateDeviceAsync(CreateDeviceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDeviceResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDeviceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateGlobalNetwork

        internal virtual CreateGlobalNetworkResponse CreateGlobalNetwork(CreateGlobalNetworkRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateGlobalNetworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGlobalNetworkResponseUnmarshaller.Instance;

            return Invoke<CreateGlobalNetworkResponse>(request, options);
        }



        /// <summary>
        /// Creates a new, empty global network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGlobalNetwork service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateGlobalNetwork service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ConflictException">
        /// There was a conflict processing the request. Updating or deleting the resource can
        /// cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ServiceQuotaExceededException">
        /// A service limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/CreateGlobalNetwork">REST API Reference for CreateGlobalNetwork Operation</seealso>
        public virtual Task<CreateGlobalNetworkResponse> CreateGlobalNetworkAsync(CreateGlobalNetworkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateGlobalNetworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGlobalNetworkResponseUnmarshaller.Instance;

            return InvokeAsync<CreateGlobalNetworkResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateLink

        internal virtual CreateLinkResponse CreateLink(CreateLinkRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLinkResponseUnmarshaller.Instance;

            return Invoke<CreateLinkResponse>(request, options);
        }



        /// <summary>
        /// Creates a new link for a specified site.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLink service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateLink service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ConflictException">
        /// There was a conflict processing the request. Updating or deleting the resource can
        /// cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ServiceQuotaExceededException">
        /// A service limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/CreateLink">REST API Reference for CreateLink Operation</seealso>
        public virtual Task<CreateLinkResponse> CreateLinkAsync(CreateLinkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLinkResponseUnmarshaller.Instance;

            return InvokeAsync<CreateLinkResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateSite

        internal virtual CreateSiteResponse CreateSite(CreateSiteRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSiteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSiteResponseUnmarshaller.Instance;

            return Invoke<CreateSiteResponse>(request, options);
        }



        /// <summary>
        /// Creates a new site in a global network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSite service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSite service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ConflictException">
        /// There was a conflict processing the request. Updating or deleting the resource can
        /// cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ServiceQuotaExceededException">
        /// A service limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/CreateSite">REST API Reference for CreateSite Operation</seealso>
        public virtual Task<CreateSiteResponse> CreateSiteAsync(CreateSiteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSiteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSiteResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSiteResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateSiteToSiteVpnAttachment

        internal virtual CreateSiteToSiteVpnAttachmentResponse CreateSiteToSiteVpnAttachment(CreateSiteToSiteVpnAttachmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSiteToSiteVpnAttachmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSiteToSiteVpnAttachmentResponseUnmarshaller.Instance;

            return Invoke<CreateSiteToSiteVpnAttachmentResponse>(request, options);
        }



        /// <summary>
        /// Creates an Amazon Web Services site-to-site VPN attachment on an edge location of
        /// a core network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSiteToSiteVpnAttachment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateSiteToSiteVpnAttachment service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ConflictException">
        /// There was a conflict processing the request. Updating or deleting the resource can
        /// cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/CreateSiteToSiteVpnAttachment">REST API Reference for CreateSiteToSiteVpnAttachment Operation</seealso>
        public virtual Task<CreateSiteToSiteVpnAttachmentResponse> CreateSiteToSiteVpnAttachmentAsync(CreateSiteToSiteVpnAttachmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSiteToSiteVpnAttachmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSiteToSiteVpnAttachmentResponseUnmarshaller.Instance;

            return InvokeAsync<CreateSiteToSiteVpnAttachmentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateTransitGatewayPeering

        internal virtual CreateTransitGatewayPeeringResponse CreateTransitGatewayPeering(CreateTransitGatewayPeeringRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTransitGatewayPeeringRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTransitGatewayPeeringResponseUnmarshaller.Instance;

            return Invoke<CreateTransitGatewayPeeringResponse>(request, options);
        }



        /// <summary>
        /// Creates a transit gateway peering connection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTransitGatewayPeering service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTransitGatewayPeering service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ConflictException">
        /// There was a conflict processing the request. Updating or deleting the resource can
        /// cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/CreateTransitGatewayPeering">REST API Reference for CreateTransitGatewayPeering Operation</seealso>
        public virtual Task<CreateTransitGatewayPeeringResponse> CreateTransitGatewayPeeringAsync(CreateTransitGatewayPeeringRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTransitGatewayPeeringRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTransitGatewayPeeringResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTransitGatewayPeeringResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateTransitGatewayRouteTableAttachment

        internal virtual CreateTransitGatewayRouteTableAttachmentResponse CreateTransitGatewayRouteTableAttachment(CreateTransitGatewayRouteTableAttachmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTransitGatewayRouteTableAttachmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTransitGatewayRouteTableAttachmentResponseUnmarshaller.Instance;

            return Invoke<CreateTransitGatewayRouteTableAttachmentResponse>(request, options);
        }



        /// <summary>
        /// Creates a transit gateway route table attachment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTransitGatewayRouteTableAttachment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateTransitGatewayRouteTableAttachment service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ConflictException">
        /// There was a conflict processing the request. Updating or deleting the resource can
        /// cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/CreateTransitGatewayRouteTableAttachment">REST API Reference for CreateTransitGatewayRouteTableAttachment Operation</seealso>
        public virtual Task<CreateTransitGatewayRouteTableAttachmentResponse> CreateTransitGatewayRouteTableAttachmentAsync(CreateTransitGatewayRouteTableAttachmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTransitGatewayRouteTableAttachmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTransitGatewayRouteTableAttachmentResponseUnmarshaller.Instance;

            return InvokeAsync<CreateTransitGatewayRouteTableAttachmentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  CreateVpcAttachment

        internal virtual CreateVpcAttachmentResponse CreateVpcAttachment(CreateVpcAttachmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVpcAttachmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVpcAttachmentResponseUnmarshaller.Instance;

            return Invoke<CreateVpcAttachmentResponse>(request, options);
        }



        /// <summary>
        /// Creates a VPC attachment on an edge location of a core network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVpcAttachment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the CreateVpcAttachment service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ConflictException">
        /// There was a conflict processing the request. Updating or deleting the resource can
        /// cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/CreateVpcAttachment">REST API Reference for CreateVpcAttachment Operation</seealso>
        public virtual Task<CreateVpcAttachmentResponse> CreateVpcAttachmentAsync(CreateVpcAttachmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVpcAttachmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVpcAttachmentResponseUnmarshaller.Instance;

            return InvokeAsync<CreateVpcAttachmentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteAttachment

        internal virtual DeleteAttachmentResponse DeleteAttachment(DeleteAttachmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAttachmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAttachmentResponseUnmarshaller.Instance;

            return Invoke<DeleteAttachmentResponse>(request, options);
        }



        /// <summary>
        /// Deletes an attachment. Supports all attachment types.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAttachment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteAttachment service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ConflictException">
        /// There was a conflict processing the request. Updating or deleting the resource can
        /// cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/DeleteAttachment">REST API Reference for DeleteAttachment Operation</seealso>
        public virtual Task<DeleteAttachmentResponse> DeleteAttachmentAsync(DeleteAttachmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAttachmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAttachmentResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteAttachmentResponse>(request, options, cancellationToken);
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
        /// Deletes the specified connection in your global network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteConnection service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ConflictException">
        /// There was a conflict processing the request. Updating or deleting the resource can
        /// cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/DeleteConnection">REST API Reference for DeleteConnection Operation</seealso>
        public virtual Task<DeleteConnectionResponse> DeleteConnectionAsync(DeleteConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteConnectionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteConnectPeer

        internal virtual DeleteConnectPeerResponse DeleteConnectPeer(DeleteConnectPeerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteConnectPeerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConnectPeerResponseUnmarshaller.Instance;

            return Invoke<DeleteConnectPeerResponse>(request, options);
        }



        /// <summary>
        /// Deletes a Connect peer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnectPeer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteConnectPeer service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ConflictException">
        /// There was a conflict processing the request. Updating or deleting the resource can
        /// cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/DeleteConnectPeer">REST API Reference for DeleteConnectPeer Operation</seealso>
        public virtual Task<DeleteConnectPeerResponse> DeleteConnectPeerAsync(DeleteConnectPeerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteConnectPeerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConnectPeerResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteConnectPeerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteCoreNetwork

        internal virtual DeleteCoreNetworkResponse DeleteCoreNetwork(DeleteCoreNetworkRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCoreNetworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCoreNetworkResponseUnmarshaller.Instance;

            return Invoke<DeleteCoreNetworkResponse>(request, options);
        }



        /// <summary>
        /// Deletes a core network along with all core network policies. This can only be done
        /// if there are no attachments on a core network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCoreNetwork service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCoreNetwork service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ConflictException">
        /// There was a conflict processing the request. Updating or deleting the resource can
        /// cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/DeleteCoreNetwork">REST API Reference for DeleteCoreNetwork Operation</seealso>
        public virtual Task<DeleteCoreNetworkResponse> DeleteCoreNetworkAsync(DeleteCoreNetworkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCoreNetworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCoreNetworkResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteCoreNetworkResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteCoreNetworkPolicyVersion

        internal virtual DeleteCoreNetworkPolicyVersionResponse DeleteCoreNetworkPolicyVersion(DeleteCoreNetworkPolicyVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCoreNetworkPolicyVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCoreNetworkPolicyVersionResponseUnmarshaller.Instance;

            return Invoke<DeleteCoreNetworkPolicyVersionResponse>(request, options);
        }



        /// <summary>
        /// Deletes a policy version from a core network. You can't delete the current LIVE policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCoreNetworkPolicyVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteCoreNetworkPolicyVersion service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ConflictException">
        /// There was a conflict processing the request. Updating or deleting the resource can
        /// cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/DeleteCoreNetworkPolicyVersion">REST API Reference for DeleteCoreNetworkPolicyVersion Operation</seealso>
        public virtual Task<DeleteCoreNetworkPolicyVersionResponse> DeleteCoreNetworkPolicyVersionAsync(DeleteCoreNetworkPolicyVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCoreNetworkPolicyVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCoreNetworkPolicyVersionResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteCoreNetworkPolicyVersionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteDevice

        internal virtual DeleteDeviceResponse DeleteDevice(DeleteDeviceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDeviceResponseUnmarshaller.Instance;

            return Invoke<DeleteDeviceResponse>(request, options);
        }



        /// <summary>
        /// Deletes an existing device. You must first disassociate the device from any links
        /// and customer gateways.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDevice service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteDevice service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ConflictException">
        /// There was a conflict processing the request. Updating or deleting the resource can
        /// cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/DeleteDevice">REST API Reference for DeleteDevice Operation</seealso>
        public virtual Task<DeleteDeviceResponse> DeleteDeviceAsync(DeleteDeviceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDeviceResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDeviceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteGlobalNetwork

        internal virtual DeleteGlobalNetworkResponse DeleteGlobalNetwork(DeleteGlobalNetworkRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteGlobalNetworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGlobalNetworkResponseUnmarshaller.Instance;

            return Invoke<DeleteGlobalNetworkResponse>(request, options);
        }



        /// <summary>
        /// Deletes an existing global network. You must first delete all global network objects
        /// (devices, links, and sites), deregister all transit gateways, and delete any core
        /// networks.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGlobalNetwork service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteGlobalNetwork service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ConflictException">
        /// There was a conflict processing the request. Updating or deleting the resource can
        /// cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/DeleteGlobalNetwork">REST API Reference for DeleteGlobalNetwork Operation</seealso>
        public virtual Task<DeleteGlobalNetworkResponse> DeleteGlobalNetworkAsync(DeleteGlobalNetworkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteGlobalNetworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGlobalNetworkResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteGlobalNetworkResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteLink

        internal virtual DeleteLinkResponse DeleteLink(DeleteLinkRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLinkResponseUnmarshaller.Instance;

            return Invoke<DeleteLinkResponse>(request, options);
        }



        /// <summary>
        /// Deletes an existing link. You must first disassociate the link from any devices and
        /// customer gateways.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLink service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteLink service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ConflictException">
        /// There was a conflict processing the request. Updating or deleting the resource can
        /// cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/DeleteLink">REST API Reference for DeleteLink Operation</seealso>
        public virtual Task<DeleteLinkResponse> DeleteLinkAsync(DeleteLinkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLinkResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteLinkResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeletePeering

        internal virtual DeletePeeringResponse DeletePeering(DeletePeeringRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePeeringRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePeeringResponseUnmarshaller.Instance;

            return Invoke<DeletePeeringResponse>(request, options);
        }



        /// <summary>
        /// Deletes an existing peering connection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePeering service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeletePeering service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ConflictException">
        /// There was a conflict processing the request. Updating or deleting the resource can
        /// cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/DeletePeering">REST API Reference for DeletePeering Operation</seealso>
        public virtual Task<DeletePeeringResponse> DeletePeeringAsync(DeletePeeringRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePeeringRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePeeringResponseUnmarshaller.Instance;

            return InvokeAsync<DeletePeeringResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteResourcePolicy

        internal virtual DeleteResourcePolicyResponse DeleteResourcePolicy(DeleteResourcePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResourcePolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteResourcePolicyResponse>(request, options);
        }



        /// <summary>
        /// Deletes a resource policy for the specified resource. This revokes the access of the
        /// principals specified in the resource policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteResourcePolicy service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ConflictException">
        /// There was a conflict processing the request. Updating or deleting the resource can
        /// cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        public virtual Task<DeleteResourcePolicyResponse> DeleteResourcePolicyAsync(DeleteResourcePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResourcePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteResourcePolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeleteSite

        internal virtual DeleteSiteResponse DeleteSite(DeleteSiteRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSiteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSiteResponseUnmarshaller.Instance;

            return Invoke<DeleteSiteResponse>(request, options);
        }



        /// <summary>
        /// Deletes an existing site. The site cannot be associated with any device or link.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSite service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeleteSite service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ConflictException">
        /// There was a conflict processing the request. Updating or deleting the resource can
        /// cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/DeleteSite">REST API Reference for DeleteSite Operation</seealso>
        public virtual Task<DeleteSiteResponse> DeleteSiteAsync(DeleteSiteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSiteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSiteResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteSiteResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DeregisterTransitGateway

        internal virtual DeregisterTransitGatewayResponse DeregisterTransitGateway(DeregisterTransitGatewayRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterTransitGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterTransitGatewayResponseUnmarshaller.Instance;

            return Invoke<DeregisterTransitGatewayResponse>(request, options);
        }



        /// <summary>
        /// Deregisters a transit gateway from your global network. This action does not delete
        /// your transit gateway, or modify any of its attachments. This action removes any customer
        /// gateway associations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterTransitGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DeregisterTransitGateway service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ConflictException">
        /// There was a conflict processing the request. Updating or deleting the resource can
        /// cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/DeregisterTransitGateway">REST API Reference for DeregisterTransitGateway Operation</seealso>
        public virtual Task<DeregisterTransitGatewayResponse> DeregisterTransitGatewayAsync(DeregisterTransitGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterTransitGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterTransitGatewayResponseUnmarshaller.Instance;

            return InvokeAsync<DeregisterTransitGatewayResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DescribeGlobalNetworks

        internal virtual DescribeGlobalNetworksResponse DescribeGlobalNetworks(DescribeGlobalNetworksRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeGlobalNetworksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGlobalNetworksResponseUnmarshaller.Instance;

            return Invoke<DescribeGlobalNetworksResponse>(request, options);
        }



        /// <summary>
        /// Describes one or more global networks. By default, all global networks are described.
        /// To describe the objects in your global network, you must use the appropriate <code>Get*</code>
        /// action. For example, to list the transit gateways in your global network, use <a>GetTransitGatewayRegistrations</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeGlobalNetworks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DescribeGlobalNetworks service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/DescribeGlobalNetworks">REST API Reference for DescribeGlobalNetworks Operation</seealso>
        public virtual Task<DescribeGlobalNetworksResponse> DescribeGlobalNetworksAsync(DescribeGlobalNetworksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeGlobalNetworksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGlobalNetworksResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeGlobalNetworksResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateConnectPeer

        internal virtual DisassociateConnectPeerResponse DisassociateConnectPeer(DisassociateConnectPeerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateConnectPeerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateConnectPeerResponseUnmarshaller.Instance;

            return Invoke<DisassociateConnectPeerResponse>(request, options);
        }



        /// <summary>
        /// Disassociates a core network Connect peer from a device and a link.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateConnectPeer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateConnectPeer service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ConflictException">
        /// There was a conflict processing the request. Updating or deleting the resource can
        /// cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/DisassociateConnectPeer">REST API Reference for DisassociateConnectPeer Operation</seealso>
        public virtual Task<DisassociateConnectPeerResponse> DisassociateConnectPeerAsync(DisassociateConnectPeerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateConnectPeerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateConnectPeerResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateConnectPeerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateCustomerGateway

        internal virtual DisassociateCustomerGatewayResponse DisassociateCustomerGateway(DisassociateCustomerGatewayRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateCustomerGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateCustomerGatewayResponseUnmarshaller.Instance;

            return Invoke<DisassociateCustomerGatewayResponse>(request, options);
        }



        /// <summary>
        /// Disassociates a customer gateway from a device and a link.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateCustomerGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateCustomerGateway service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ConflictException">
        /// There was a conflict processing the request. Updating or deleting the resource can
        /// cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/DisassociateCustomerGateway">REST API Reference for DisassociateCustomerGateway Operation</seealso>
        public virtual Task<DisassociateCustomerGatewayResponse> DisassociateCustomerGatewayAsync(DisassociateCustomerGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateCustomerGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateCustomerGatewayResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateCustomerGatewayResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateLink

        internal virtual DisassociateLinkResponse DisassociateLink(DisassociateLinkRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateLinkResponseUnmarshaller.Instance;

            return Invoke<DisassociateLinkResponse>(request, options);
        }



        /// <summary>
        /// Disassociates an existing device from a link. You must first disassociate any customer
        /// gateways that are associated with the link.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateLink service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateLink service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ConflictException">
        /// There was a conflict processing the request. Updating or deleting the resource can
        /// cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/DisassociateLink">REST API Reference for DisassociateLink Operation</seealso>
        public virtual Task<DisassociateLinkResponse> DisassociateLinkAsync(DisassociateLinkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateLinkResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateLinkResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  DisassociateTransitGatewayConnectPeer

        internal virtual DisassociateTransitGatewayConnectPeerResponse DisassociateTransitGatewayConnectPeer(DisassociateTransitGatewayConnectPeerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateTransitGatewayConnectPeerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateTransitGatewayConnectPeerResponseUnmarshaller.Instance;

            return Invoke<DisassociateTransitGatewayConnectPeerResponse>(request, options);
        }



        /// <summary>
        /// Disassociates a transit gateway Connect peer from a device and link.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateTransitGatewayConnectPeer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the DisassociateTransitGatewayConnectPeer service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ConflictException">
        /// There was a conflict processing the request. Updating or deleting the resource can
        /// cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/DisassociateTransitGatewayConnectPeer">REST API Reference for DisassociateTransitGatewayConnectPeer Operation</seealso>
        public virtual Task<DisassociateTransitGatewayConnectPeerResponse> DisassociateTransitGatewayConnectPeerAsync(DisassociateTransitGatewayConnectPeerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateTransitGatewayConnectPeerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateTransitGatewayConnectPeerResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateTransitGatewayConnectPeerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ExecuteCoreNetworkChangeSet

        internal virtual ExecuteCoreNetworkChangeSetResponse ExecuteCoreNetworkChangeSet(ExecuteCoreNetworkChangeSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExecuteCoreNetworkChangeSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExecuteCoreNetworkChangeSetResponseUnmarshaller.Instance;

            return Invoke<ExecuteCoreNetworkChangeSetResponse>(request, options);
        }



        /// <summary>
        /// Executes a change set on your core network. Deploys changes globally based on the
        /// policy submitted..
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExecuteCoreNetworkChangeSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ExecuteCoreNetworkChangeSet service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ConflictException">
        /// There was a conflict processing the request. Updating or deleting the resource can
        /// cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/ExecuteCoreNetworkChangeSet">REST API Reference for ExecuteCoreNetworkChangeSet Operation</seealso>
        public virtual Task<ExecuteCoreNetworkChangeSetResponse> ExecuteCoreNetworkChangeSetAsync(ExecuteCoreNetworkChangeSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExecuteCoreNetworkChangeSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExecuteCoreNetworkChangeSetResponseUnmarshaller.Instance;

            return InvokeAsync<ExecuteCoreNetworkChangeSetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetConnectAttachment

        internal virtual GetConnectAttachmentResponse GetConnectAttachment(GetConnectAttachmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetConnectAttachmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConnectAttachmentResponseUnmarshaller.Instance;

            return Invoke<GetConnectAttachmentResponse>(request, options);
        }



        /// <summary>
        /// Returns information about a core network Connect attachment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConnectAttachment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetConnectAttachment service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetConnectAttachment">REST API Reference for GetConnectAttachment Operation</seealso>
        public virtual Task<GetConnectAttachmentResponse> GetConnectAttachmentAsync(GetConnectAttachmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetConnectAttachmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConnectAttachmentResponseUnmarshaller.Instance;

            return InvokeAsync<GetConnectAttachmentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetConnections

        internal virtual GetConnectionsResponse GetConnections(GetConnectionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetConnectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConnectionsResponseUnmarshaller.Instance;

            return Invoke<GetConnectionsResponse>(request, options);
        }



        /// <summary>
        /// Gets information about one or more of your connections in a global network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConnections service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetConnections service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetConnections">REST API Reference for GetConnections Operation</seealso>
        public virtual Task<GetConnectionsResponse> GetConnectionsAsync(GetConnectionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetConnectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConnectionsResponseUnmarshaller.Instance;

            return InvokeAsync<GetConnectionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetConnectPeer

        internal virtual GetConnectPeerResponse GetConnectPeer(GetConnectPeerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetConnectPeerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConnectPeerResponseUnmarshaller.Instance;

            return Invoke<GetConnectPeerResponse>(request, options);
        }



        /// <summary>
        /// Returns information about a core network Connect peer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConnectPeer service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetConnectPeer service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetConnectPeer">REST API Reference for GetConnectPeer Operation</seealso>
        public virtual Task<GetConnectPeerResponse> GetConnectPeerAsync(GetConnectPeerRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetConnectPeerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConnectPeerResponseUnmarshaller.Instance;

            return InvokeAsync<GetConnectPeerResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetConnectPeerAssociations

        internal virtual GetConnectPeerAssociationsResponse GetConnectPeerAssociations(GetConnectPeerAssociationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetConnectPeerAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConnectPeerAssociationsResponseUnmarshaller.Instance;

            return Invoke<GetConnectPeerAssociationsResponse>(request, options);
        }



        /// <summary>
        /// Returns information about a core network Connect peer associations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConnectPeerAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetConnectPeerAssociations service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ConflictException">
        /// There was a conflict processing the request. Updating or deleting the resource can
        /// cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetConnectPeerAssociations">REST API Reference for GetConnectPeerAssociations Operation</seealso>
        public virtual Task<GetConnectPeerAssociationsResponse> GetConnectPeerAssociationsAsync(GetConnectPeerAssociationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetConnectPeerAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConnectPeerAssociationsResponseUnmarshaller.Instance;

            return InvokeAsync<GetConnectPeerAssociationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetCoreNetwork

        internal virtual GetCoreNetworkResponse GetCoreNetwork(GetCoreNetworkRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCoreNetworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCoreNetworkResponseUnmarshaller.Instance;

            return Invoke<GetCoreNetworkResponse>(request, options);
        }



        /// <summary>
        /// Returns information about the LIVE policy for a core network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCoreNetwork service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCoreNetwork service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetCoreNetwork">REST API Reference for GetCoreNetwork Operation</seealso>
        public virtual Task<GetCoreNetworkResponse> GetCoreNetworkAsync(GetCoreNetworkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCoreNetworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCoreNetworkResponseUnmarshaller.Instance;

            return InvokeAsync<GetCoreNetworkResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetCoreNetworkChangeEvents

        internal virtual GetCoreNetworkChangeEventsResponse GetCoreNetworkChangeEvents(GetCoreNetworkChangeEventsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCoreNetworkChangeEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCoreNetworkChangeEventsResponseUnmarshaller.Instance;

            return Invoke<GetCoreNetworkChangeEventsResponse>(request, options);
        }



        /// <summary>
        /// Returns information about a core network change event.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCoreNetworkChangeEvents service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCoreNetworkChangeEvents service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetCoreNetworkChangeEvents">REST API Reference for GetCoreNetworkChangeEvents Operation</seealso>
        public virtual Task<GetCoreNetworkChangeEventsResponse> GetCoreNetworkChangeEventsAsync(GetCoreNetworkChangeEventsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCoreNetworkChangeEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCoreNetworkChangeEventsResponseUnmarshaller.Instance;

            return InvokeAsync<GetCoreNetworkChangeEventsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetCoreNetworkChangeSet

        internal virtual GetCoreNetworkChangeSetResponse GetCoreNetworkChangeSet(GetCoreNetworkChangeSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCoreNetworkChangeSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCoreNetworkChangeSetResponseUnmarshaller.Instance;

            return Invoke<GetCoreNetworkChangeSetResponse>(request, options);
        }



        /// <summary>
        /// Returns a change set between the LIVE core network policy and a submitted policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCoreNetworkChangeSet service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCoreNetworkChangeSet service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetCoreNetworkChangeSet">REST API Reference for GetCoreNetworkChangeSet Operation</seealso>
        public virtual Task<GetCoreNetworkChangeSetResponse> GetCoreNetworkChangeSetAsync(GetCoreNetworkChangeSetRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCoreNetworkChangeSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCoreNetworkChangeSetResponseUnmarshaller.Instance;

            return InvokeAsync<GetCoreNetworkChangeSetResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetCoreNetworkPolicy

        internal virtual GetCoreNetworkPolicyResponse GetCoreNetworkPolicy(GetCoreNetworkPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCoreNetworkPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCoreNetworkPolicyResponseUnmarshaller.Instance;

            return Invoke<GetCoreNetworkPolicyResponse>(request, options);
        }



        /// <summary>
        /// Returns details about a core network policy. You can get details about your current
        /// live policy or any previous policy version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCoreNetworkPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCoreNetworkPolicy service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetCoreNetworkPolicy">REST API Reference for GetCoreNetworkPolicy Operation</seealso>
        public virtual Task<GetCoreNetworkPolicyResponse> GetCoreNetworkPolicyAsync(GetCoreNetworkPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCoreNetworkPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCoreNetworkPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<GetCoreNetworkPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetCustomerGatewayAssociations

        internal virtual GetCustomerGatewayAssociationsResponse GetCustomerGatewayAssociations(GetCustomerGatewayAssociationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCustomerGatewayAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCustomerGatewayAssociationsResponseUnmarshaller.Instance;

            return Invoke<GetCustomerGatewayAssociationsResponse>(request, options);
        }



        /// <summary>
        /// Gets the association information for customer gateways that are associated with devices
        /// and links in your global network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCustomerGatewayAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetCustomerGatewayAssociations service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ConflictException">
        /// There was a conflict processing the request. Updating or deleting the resource can
        /// cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetCustomerGatewayAssociations">REST API Reference for GetCustomerGatewayAssociations Operation</seealso>
        public virtual Task<GetCustomerGatewayAssociationsResponse> GetCustomerGatewayAssociationsAsync(GetCustomerGatewayAssociationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCustomerGatewayAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCustomerGatewayAssociationsResponseUnmarshaller.Instance;

            return InvokeAsync<GetCustomerGatewayAssociationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetDevices

        internal virtual GetDevicesResponse GetDevices(GetDevicesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDevicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDevicesResponseUnmarshaller.Instance;

            return Invoke<GetDevicesResponse>(request, options);
        }



        /// <summary>
        /// Gets information about one or more of your devices in a global network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDevices service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetDevices service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetDevices">REST API Reference for GetDevices Operation</seealso>
        public virtual Task<GetDevicesResponse> GetDevicesAsync(GetDevicesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDevicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDevicesResponseUnmarshaller.Instance;

            return InvokeAsync<GetDevicesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetLinkAssociations

        internal virtual GetLinkAssociationsResponse GetLinkAssociations(GetLinkAssociationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLinkAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLinkAssociationsResponseUnmarshaller.Instance;

            return Invoke<GetLinkAssociationsResponse>(request, options);
        }



        /// <summary>
        /// Gets the link associations for a device or a link. Either the device ID or the link
        /// ID must be specified.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLinkAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetLinkAssociations service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetLinkAssociations">REST API Reference for GetLinkAssociations Operation</seealso>
        public virtual Task<GetLinkAssociationsResponse> GetLinkAssociationsAsync(GetLinkAssociationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLinkAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLinkAssociationsResponseUnmarshaller.Instance;

            return InvokeAsync<GetLinkAssociationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetLinks

        internal virtual GetLinksResponse GetLinks(GetLinksRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLinksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLinksResponseUnmarshaller.Instance;

            return Invoke<GetLinksResponse>(request, options);
        }



        /// <summary>
        /// Gets information about one or more links in a specified global network.
        /// 
        ///  
        /// <para>
        /// If you specify the site ID, you cannot specify the type or provider in the same request.
        /// You can specify the type and provider in the same request.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLinks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetLinks service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetLinks">REST API Reference for GetLinks Operation</seealso>
        public virtual Task<GetLinksResponse> GetLinksAsync(GetLinksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLinksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLinksResponseUnmarshaller.Instance;

            return InvokeAsync<GetLinksResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetNetworkResourceCounts

        internal virtual GetNetworkResourceCountsResponse GetNetworkResourceCounts(GetNetworkResourceCountsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetNetworkResourceCountsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetNetworkResourceCountsResponseUnmarshaller.Instance;

            return Invoke<GetNetworkResourceCountsResponse>(request, options);
        }



        /// <summary>
        /// Gets the count of network resources, by resource type, for the specified global network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNetworkResourceCounts service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetNetworkResourceCounts service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetNetworkResourceCounts">REST API Reference for GetNetworkResourceCounts Operation</seealso>
        public virtual Task<GetNetworkResourceCountsResponse> GetNetworkResourceCountsAsync(GetNetworkResourceCountsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetNetworkResourceCountsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetNetworkResourceCountsResponseUnmarshaller.Instance;

            return InvokeAsync<GetNetworkResourceCountsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetNetworkResourceRelationships

        internal virtual GetNetworkResourceRelationshipsResponse GetNetworkResourceRelationships(GetNetworkResourceRelationshipsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetNetworkResourceRelationshipsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetNetworkResourceRelationshipsResponseUnmarshaller.Instance;

            return Invoke<GetNetworkResourceRelationshipsResponse>(request, options);
        }



        /// <summary>
        /// Gets the network resource relationships for the specified global network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNetworkResourceRelationships service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetNetworkResourceRelationships service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetNetworkResourceRelationships">REST API Reference for GetNetworkResourceRelationships Operation</seealso>
        public virtual Task<GetNetworkResourceRelationshipsResponse> GetNetworkResourceRelationshipsAsync(GetNetworkResourceRelationshipsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetNetworkResourceRelationshipsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetNetworkResourceRelationshipsResponseUnmarshaller.Instance;

            return InvokeAsync<GetNetworkResourceRelationshipsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetNetworkResources

        internal virtual GetNetworkResourcesResponse GetNetworkResources(GetNetworkResourcesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetNetworkResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetNetworkResourcesResponseUnmarshaller.Instance;

            return Invoke<GetNetworkResourcesResponse>(request, options);
        }



        /// <summary>
        /// Describes the network resources for the specified global network.
        /// 
        ///  
        /// <para>
        /// The results include information from the corresponding Describe call for the resource,
        /// minus any sensitive information such as pre-shared keys.
        /// </para>
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNetworkResources service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetNetworkResources service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetNetworkResources">REST API Reference for GetNetworkResources Operation</seealso>
        public virtual Task<GetNetworkResourcesResponse> GetNetworkResourcesAsync(GetNetworkResourcesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetNetworkResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetNetworkResourcesResponseUnmarshaller.Instance;

            return InvokeAsync<GetNetworkResourcesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetNetworkRoutes

        internal virtual GetNetworkRoutesResponse GetNetworkRoutes(GetNetworkRoutesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetNetworkRoutesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetNetworkRoutesResponseUnmarshaller.Instance;

            return Invoke<GetNetworkRoutesResponse>(request, options);
        }



        /// <summary>
        /// Gets the network routes of the specified global network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNetworkRoutes service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetNetworkRoutes service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetNetworkRoutes">REST API Reference for GetNetworkRoutes Operation</seealso>
        public virtual Task<GetNetworkRoutesResponse> GetNetworkRoutesAsync(GetNetworkRoutesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetNetworkRoutesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetNetworkRoutesResponseUnmarshaller.Instance;

            return InvokeAsync<GetNetworkRoutesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetNetworkTelemetry

        internal virtual GetNetworkTelemetryResponse GetNetworkTelemetry(GetNetworkTelemetryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetNetworkTelemetryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetNetworkTelemetryResponseUnmarshaller.Instance;

            return Invoke<GetNetworkTelemetryResponse>(request, options);
        }



        /// <summary>
        /// Gets the network telemetry of the specified global network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNetworkTelemetry service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetNetworkTelemetry service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetNetworkTelemetry">REST API Reference for GetNetworkTelemetry Operation</seealso>
        public virtual Task<GetNetworkTelemetryResponse> GetNetworkTelemetryAsync(GetNetworkTelemetryRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetNetworkTelemetryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetNetworkTelemetryResponseUnmarshaller.Instance;

            return InvokeAsync<GetNetworkTelemetryResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetResourcePolicy

        internal virtual GetResourcePolicyResponse GetResourcePolicy(GetResourcePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourcePolicyResponseUnmarshaller.Instance;

            return Invoke<GetResourcePolicyResponse>(request, options);
        }



        /// <summary>
        /// Returns information about a resource policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetResourcePolicy service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetResourcePolicy">REST API Reference for GetResourcePolicy Operation</seealso>
        public virtual Task<GetResourcePolicyResponse> GetResourcePolicyAsync(GetResourcePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourcePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<GetResourcePolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetRouteAnalysis

        internal virtual GetRouteAnalysisResponse GetRouteAnalysis(GetRouteAnalysisRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRouteAnalysisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRouteAnalysisResponseUnmarshaller.Instance;

            return Invoke<GetRouteAnalysisResponse>(request, options);
        }



        /// <summary>
        /// Gets information about the specified route analysis.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRouteAnalysis service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetRouteAnalysis service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetRouteAnalysis">REST API Reference for GetRouteAnalysis Operation</seealso>
        public virtual Task<GetRouteAnalysisResponse> GetRouteAnalysisAsync(GetRouteAnalysisRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRouteAnalysisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRouteAnalysisResponseUnmarshaller.Instance;

            return InvokeAsync<GetRouteAnalysisResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSites

        internal virtual GetSitesResponse GetSites(GetSitesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSitesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSitesResponseUnmarshaller.Instance;

            return Invoke<GetSitesResponse>(request, options);
        }



        /// <summary>
        /// Gets information about one or more of your sites in a global network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSites service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSites service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetSites">REST API Reference for GetSites Operation</seealso>
        public virtual Task<GetSitesResponse> GetSitesAsync(GetSitesRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSitesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSitesResponseUnmarshaller.Instance;

            return InvokeAsync<GetSitesResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetSiteToSiteVpnAttachment

        internal virtual GetSiteToSiteVpnAttachmentResponse GetSiteToSiteVpnAttachment(GetSiteToSiteVpnAttachmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSiteToSiteVpnAttachmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSiteToSiteVpnAttachmentResponseUnmarshaller.Instance;

            return Invoke<GetSiteToSiteVpnAttachmentResponse>(request, options);
        }



        /// <summary>
        /// Returns information about a site-to-site VPN attachment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSiteToSiteVpnAttachment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetSiteToSiteVpnAttachment service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetSiteToSiteVpnAttachment">REST API Reference for GetSiteToSiteVpnAttachment Operation</seealso>
        public virtual Task<GetSiteToSiteVpnAttachmentResponse> GetSiteToSiteVpnAttachmentAsync(GetSiteToSiteVpnAttachmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSiteToSiteVpnAttachmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSiteToSiteVpnAttachmentResponseUnmarshaller.Instance;

            return InvokeAsync<GetSiteToSiteVpnAttachmentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetTransitGatewayConnectPeerAssociations

        internal virtual GetTransitGatewayConnectPeerAssociationsResponse GetTransitGatewayConnectPeerAssociations(GetTransitGatewayConnectPeerAssociationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTransitGatewayConnectPeerAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTransitGatewayConnectPeerAssociationsResponseUnmarshaller.Instance;

            return Invoke<GetTransitGatewayConnectPeerAssociationsResponse>(request, options);
        }



        /// <summary>
        /// Gets information about one or more of your transit gateway Connect peer associations
        /// in a global network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTransitGatewayConnectPeerAssociations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTransitGatewayConnectPeerAssociations service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ConflictException">
        /// There was a conflict processing the request. Updating or deleting the resource can
        /// cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetTransitGatewayConnectPeerAssociations">REST API Reference for GetTransitGatewayConnectPeerAssociations Operation</seealso>
        public virtual Task<GetTransitGatewayConnectPeerAssociationsResponse> GetTransitGatewayConnectPeerAssociationsAsync(GetTransitGatewayConnectPeerAssociationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTransitGatewayConnectPeerAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTransitGatewayConnectPeerAssociationsResponseUnmarshaller.Instance;

            return InvokeAsync<GetTransitGatewayConnectPeerAssociationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetTransitGatewayPeering

        internal virtual GetTransitGatewayPeeringResponse GetTransitGatewayPeering(GetTransitGatewayPeeringRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTransitGatewayPeeringRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTransitGatewayPeeringResponseUnmarshaller.Instance;

            return Invoke<GetTransitGatewayPeeringResponse>(request, options);
        }



        /// <summary>
        /// Returns information about a transit gateway peer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTransitGatewayPeering service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTransitGatewayPeering service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetTransitGatewayPeering">REST API Reference for GetTransitGatewayPeering Operation</seealso>
        public virtual Task<GetTransitGatewayPeeringResponse> GetTransitGatewayPeeringAsync(GetTransitGatewayPeeringRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTransitGatewayPeeringRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTransitGatewayPeeringResponseUnmarshaller.Instance;

            return InvokeAsync<GetTransitGatewayPeeringResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetTransitGatewayRegistrations

        internal virtual GetTransitGatewayRegistrationsResponse GetTransitGatewayRegistrations(GetTransitGatewayRegistrationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTransitGatewayRegistrationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTransitGatewayRegistrationsResponseUnmarshaller.Instance;

            return Invoke<GetTransitGatewayRegistrationsResponse>(request, options);
        }



        /// <summary>
        /// Gets information about the transit gateway registrations in a specified global network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTransitGatewayRegistrations service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTransitGatewayRegistrations service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetTransitGatewayRegistrations">REST API Reference for GetTransitGatewayRegistrations Operation</seealso>
        public virtual Task<GetTransitGatewayRegistrationsResponse> GetTransitGatewayRegistrationsAsync(GetTransitGatewayRegistrationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTransitGatewayRegistrationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTransitGatewayRegistrationsResponseUnmarshaller.Instance;

            return InvokeAsync<GetTransitGatewayRegistrationsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetTransitGatewayRouteTableAttachment

        internal virtual GetTransitGatewayRouteTableAttachmentResponse GetTransitGatewayRouteTableAttachment(GetTransitGatewayRouteTableAttachmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTransitGatewayRouteTableAttachmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTransitGatewayRouteTableAttachmentResponseUnmarshaller.Instance;

            return Invoke<GetTransitGatewayRouteTableAttachmentResponse>(request, options);
        }



        /// <summary>
        /// Returns information about a transit gateway route table attachment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTransitGatewayRouteTableAttachment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetTransitGatewayRouteTableAttachment service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetTransitGatewayRouteTableAttachment">REST API Reference for GetTransitGatewayRouteTableAttachment Operation</seealso>
        public virtual Task<GetTransitGatewayRouteTableAttachmentResponse> GetTransitGatewayRouteTableAttachmentAsync(GetTransitGatewayRouteTableAttachmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTransitGatewayRouteTableAttachmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTransitGatewayRouteTableAttachmentResponseUnmarshaller.Instance;

            return InvokeAsync<GetTransitGatewayRouteTableAttachmentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  GetVpcAttachment

        internal virtual GetVpcAttachmentResponse GetVpcAttachment(GetVpcAttachmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVpcAttachmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVpcAttachmentResponseUnmarshaller.Instance;

            return Invoke<GetVpcAttachmentResponse>(request, options);
        }



        /// <summary>
        /// Returns information about a VPC attachment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVpcAttachment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the GetVpcAttachment service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetVpcAttachment">REST API Reference for GetVpcAttachment Operation</seealso>
        public virtual Task<GetVpcAttachmentResponse> GetVpcAttachmentAsync(GetVpcAttachmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVpcAttachmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVpcAttachmentResponseUnmarshaller.Instance;

            return InvokeAsync<GetVpcAttachmentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListAttachments

        internal virtual ListAttachmentsResponse ListAttachments(ListAttachmentsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAttachmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAttachmentsResponseUnmarshaller.Instance;

            return Invoke<ListAttachmentsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of core network attachments.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAttachments service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListAttachments service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/ListAttachments">REST API Reference for ListAttachments Operation</seealso>
        public virtual Task<ListAttachmentsResponse> ListAttachmentsAsync(ListAttachmentsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAttachmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAttachmentsResponseUnmarshaller.Instance;

            return InvokeAsync<ListAttachmentsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListConnectPeers

        internal virtual ListConnectPeersResponse ListConnectPeers(ListConnectPeersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListConnectPeersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConnectPeersResponseUnmarshaller.Instance;

            return Invoke<ListConnectPeersResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of core network Connect peers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConnectPeers service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListConnectPeers service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/ListConnectPeers">REST API Reference for ListConnectPeers Operation</seealso>
        public virtual Task<ListConnectPeersResponse> ListConnectPeersAsync(ListConnectPeersRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListConnectPeersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConnectPeersResponseUnmarshaller.Instance;

            return InvokeAsync<ListConnectPeersResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListCoreNetworkPolicyVersions

        internal virtual ListCoreNetworkPolicyVersionsResponse ListCoreNetworkPolicyVersions(ListCoreNetworkPolicyVersionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCoreNetworkPolicyVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCoreNetworkPolicyVersionsResponseUnmarshaller.Instance;

            return Invoke<ListCoreNetworkPolicyVersionsResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of core network policy versions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCoreNetworkPolicyVersions service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCoreNetworkPolicyVersions service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/ListCoreNetworkPolicyVersions">REST API Reference for ListCoreNetworkPolicyVersions Operation</seealso>
        public virtual Task<ListCoreNetworkPolicyVersionsResponse> ListCoreNetworkPolicyVersionsAsync(ListCoreNetworkPolicyVersionsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCoreNetworkPolicyVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCoreNetworkPolicyVersionsResponseUnmarshaller.Instance;

            return InvokeAsync<ListCoreNetworkPolicyVersionsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListCoreNetworks

        internal virtual ListCoreNetworksResponse ListCoreNetworks(ListCoreNetworksRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCoreNetworksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCoreNetworksResponseUnmarshaller.Instance;

            return Invoke<ListCoreNetworksResponse>(request, options);
        }



        /// <summary>
        /// Returns a list of owned and shared core networks.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCoreNetworks service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListCoreNetworks service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/ListCoreNetworks">REST API Reference for ListCoreNetworks Operation</seealso>
        public virtual Task<ListCoreNetworksResponse> ListCoreNetworksAsync(ListCoreNetworksRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCoreNetworksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCoreNetworksResponseUnmarshaller.Instance;

            return InvokeAsync<ListCoreNetworksResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListOrganizationServiceAccessStatus

        internal virtual ListOrganizationServiceAccessStatusResponse ListOrganizationServiceAccessStatus(ListOrganizationServiceAccessStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListOrganizationServiceAccessStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOrganizationServiceAccessStatusResponseUnmarshaller.Instance;

            return Invoke<ListOrganizationServiceAccessStatusResponse>(request, options);
        }



        /// <summary>
        /// Gets the status of the Service Linked Role (SLR) deployment for the accounts in a
        /// given Amazon Web Services Organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOrganizationServiceAccessStatus service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListOrganizationServiceAccessStatus service method, as returned by NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/ListOrganizationServiceAccessStatus">REST API Reference for ListOrganizationServiceAccessStatus Operation</seealso>
        public virtual Task<ListOrganizationServiceAccessStatusResponse> ListOrganizationServiceAccessStatusAsync(ListOrganizationServiceAccessStatusRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListOrganizationServiceAccessStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOrganizationServiceAccessStatusResponseUnmarshaller.Instance;

            return InvokeAsync<ListOrganizationServiceAccessStatusResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListPeerings

        internal virtual ListPeeringsResponse ListPeerings(ListPeeringsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPeeringsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPeeringsResponseUnmarshaller.Instance;

            return Invoke<ListPeeringsResponse>(request, options);
        }



        /// <summary>
        /// Lists the peerings for a core network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPeerings service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListPeerings service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/ListPeerings">REST API Reference for ListPeerings Operation</seealso>
        public virtual Task<ListPeeringsResponse> ListPeeringsAsync(ListPeeringsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPeeringsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPeeringsResponseUnmarshaller.Instance;

            return InvokeAsync<ListPeeringsResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  ListTagsForResource

        internal virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }



        /// <summary>
        /// Lists the tags for a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the ListTagsForResource service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual Task<ListTagsForResourceResponse> ListTagsForResourceAsync(ListTagsForResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return InvokeAsync<ListTagsForResourceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutCoreNetworkPolicy

        internal virtual PutCoreNetworkPolicyResponse PutCoreNetworkPolicy(PutCoreNetworkPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutCoreNetworkPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutCoreNetworkPolicyResponseUnmarshaller.Instance;

            return Invoke<PutCoreNetworkPolicyResponse>(request, options);
        }



        /// <summary>
        /// Creates a new, immutable version of a core network policy. A subsequent change set
        /// is created showing the differences between the LIVE policy and the submitted policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutCoreNetworkPolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutCoreNetworkPolicy service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ConflictException">
        /// There was a conflict processing the request. Updating or deleting the resource can
        /// cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.CoreNetworkPolicyException">
        /// Describes a core network policy exception.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/PutCoreNetworkPolicy">REST API Reference for PutCoreNetworkPolicy Operation</seealso>
        public virtual Task<PutCoreNetworkPolicyResponse> PutCoreNetworkPolicyAsync(PutCoreNetworkPolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutCoreNetworkPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutCoreNetworkPolicyResponseUnmarshaller.Instance;

            return InvokeAsync<PutCoreNetworkPolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  PutResourcePolicy

        internal virtual PutResourcePolicyResponse PutResourcePolicy(PutResourcePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutResourcePolicyResponseUnmarshaller.Instance;

            return Invoke<PutResourcePolicyResponse>(request, options);
        }



        /// <summary>
        /// Creates or updates a resource policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePolicy service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the PutResourcePolicy service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ConflictException">
        /// There was a conflict processing the request. Updating or deleting the resource can
        /// cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ServiceQuotaExceededException">
        /// A service limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        public virtual Task<PutResourcePolicyResponse> PutResourcePolicyAsync(PutResourcePolicyRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutResourcePolicyResponseUnmarshaller.Instance;

            return InvokeAsync<PutResourcePolicyResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RegisterTransitGateway

        internal virtual RegisterTransitGatewayResponse RegisterTransitGateway(RegisterTransitGatewayRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterTransitGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterTransitGatewayResponseUnmarshaller.Instance;

            return Invoke<RegisterTransitGatewayResponse>(request, options);
        }



        /// <summary>
        /// Registers a transit gateway in your global network. Not all Regions support transit
        /// gateways for global networks. For a list of the supported Regions, see <a href="https://docs.aws.amazon.com/network-manager/latest/tgwnm/what-are-global-networks.html#nm-available-regions">Region
        /// Availability</a> in the <i>Amazon Web Services Transit Gateways for Global Networks
        /// User Guide</i>. The transit gateway can be in any of the supported Amazon Web Services
        /// Regions, but it must be owned by the same Amazon Web Services account that owns the
        /// global network. You cannot register a transit gateway in more than one global network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterTransitGateway service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RegisterTransitGateway service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ConflictException">
        /// There was a conflict processing the request. Updating or deleting the resource can
        /// cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/RegisterTransitGateway">REST API Reference for RegisterTransitGateway Operation</seealso>
        public virtual Task<RegisterTransitGatewayResponse> RegisterTransitGatewayAsync(RegisterTransitGatewayRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterTransitGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterTransitGatewayResponseUnmarshaller.Instance;

            return InvokeAsync<RegisterTransitGatewayResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RejectAttachment

        internal virtual RejectAttachmentResponse RejectAttachment(RejectAttachmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RejectAttachmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RejectAttachmentResponseUnmarshaller.Instance;

            return Invoke<RejectAttachmentResponse>(request, options);
        }



        /// <summary>
        /// Rejects a core network attachment request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RejectAttachment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RejectAttachment service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ConflictException">
        /// There was a conflict processing the request. Updating or deleting the resource can
        /// cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/RejectAttachment">REST API Reference for RejectAttachment Operation</seealso>
        public virtual Task<RejectAttachmentResponse> RejectAttachmentAsync(RejectAttachmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RejectAttachmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RejectAttachmentResponseUnmarshaller.Instance;

            return InvokeAsync<RejectAttachmentResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  RestoreCoreNetworkPolicyVersion

        internal virtual RestoreCoreNetworkPolicyVersionResponse RestoreCoreNetworkPolicyVersion(RestoreCoreNetworkPolicyVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RestoreCoreNetworkPolicyVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreCoreNetworkPolicyVersionResponseUnmarshaller.Instance;

            return Invoke<RestoreCoreNetworkPolicyVersionResponse>(request, options);
        }



        /// <summary>
        /// Restores a previous policy version as a new, immutable version of a core network policy.
        /// A subsequent change set is created showing the differences between the LIVE policy
        /// and restored policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreCoreNetworkPolicyVersion service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the RestoreCoreNetworkPolicyVersion service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ConflictException">
        /// There was a conflict processing the request. Updating or deleting the resource can
        /// cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/RestoreCoreNetworkPolicyVersion">REST API Reference for RestoreCoreNetworkPolicyVersion Operation</seealso>
        public virtual Task<RestoreCoreNetworkPolicyVersionResponse> RestoreCoreNetworkPolicyVersionAsync(RestoreCoreNetworkPolicyVersionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RestoreCoreNetworkPolicyVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreCoreNetworkPolicyVersionResponseUnmarshaller.Instance;

            return InvokeAsync<RestoreCoreNetworkPolicyVersionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartOrganizationServiceAccessUpdate

        internal virtual StartOrganizationServiceAccessUpdateResponse StartOrganizationServiceAccessUpdate(StartOrganizationServiceAccessUpdateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartOrganizationServiceAccessUpdateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartOrganizationServiceAccessUpdateResponseUnmarshaller.Instance;

            return Invoke<StartOrganizationServiceAccessUpdateResponse>(request, options);
        }



        /// <summary>
        /// Enables the Network Manager service for an Amazon Web Services Organization. This
        /// can only be called by a management account within the organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartOrganizationServiceAccessUpdate service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartOrganizationServiceAccessUpdate service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ConflictException">
        /// There was a conflict processing the request. Updating or deleting the resource can
        /// cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ServiceQuotaExceededException">
        /// A service limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/StartOrganizationServiceAccessUpdate">REST API Reference for StartOrganizationServiceAccessUpdate Operation</seealso>
        public virtual Task<StartOrganizationServiceAccessUpdateResponse> StartOrganizationServiceAccessUpdateAsync(StartOrganizationServiceAccessUpdateRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartOrganizationServiceAccessUpdateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartOrganizationServiceAccessUpdateResponseUnmarshaller.Instance;

            return InvokeAsync<StartOrganizationServiceAccessUpdateResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  StartRouteAnalysis

        internal virtual StartRouteAnalysisResponse StartRouteAnalysis(StartRouteAnalysisRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartRouteAnalysisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartRouteAnalysisResponseUnmarshaller.Instance;

            return Invoke<StartRouteAnalysisResponse>(request, options);
        }



        /// <summary>
        /// Starts analyzing the routing path between the specified source and destination. For
        /// more information, see <a href="https://docs.aws.amazon.com/vpc/latest/tgw/route-analyzer.html">Route
        /// Analyzer</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartRouteAnalysis service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the StartRouteAnalysis service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ConflictException">
        /// There was a conflict processing the request. Updating or deleting the resource can
        /// cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/StartRouteAnalysis">REST API Reference for StartRouteAnalysis Operation</seealso>
        public virtual Task<StartRouteAnalysisResponse> StartRouteAnalysisAsync(StartRouteAnalysisRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartRouteAnalysisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartRouteAnalysisResponseUnmarshaller.Instance;

            return InvokeAsync<StartRouteAnalysisResponse>(request, options, cancellationToken);
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
        /// Tags a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the TagResource service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ConflictException">
        /// There was a conflict processing the request. Updating or deleting the resource can
        /// cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ServiceQuotaExceededException">
        /// A service limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/TagResource">REST API Reference for TagResource Operation</seealso>
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
        /// Removes tags from a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UntagResource service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ConflictException">
        /// There was a conflict processing the request. Updating or deleting the resource can
        /// cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/UntagResource">REST API Reference for UntagResource Operation</seealso>
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
        /// Updates the information for an existing connection. To remove information for any
        /// of the parameters, specify an empty string.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConnection service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateConnection service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ConflictException">
        /// There was a conflict processing the request. Updating or deleting the resource can
        /// cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/UpdateConnection">REST API Reference for UpdateConnection Operation</seealso>
        public virtual Task<UpdateConnectionResponse> UpdateConnectionAsync(UpdateConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateConnectionResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateCoreNetwork

        internal virtual UpdateCoreNetworkResponse UpdateCoreNetwork(UpdateCoreNetworkRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateCoreNetworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCoreNetworkResponseUnmarshaller.Instance;

            return Invoke<UpdateCoreNetworkResponse>(request, options);
        }



        /// <summary>
        /// Updates the description of a core network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCoreNetwork service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateCoreNetwork service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ConflictException">
        /// There was a conflict processing the request. Updating or deleting the resource can
        /// cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/UpdateCoreNetwork">REST API Reference for UpdateCoreNetwork Operation</seealso>
        public virtual Task<UpdateCoreNetworkResponse> UpdateCoreNetworkAsync(UpdateCoreNetworkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateCoreNetworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCoreNetworkResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateCoreNetworkResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateDevice

        internal virtual UpdateDeviceResponse UpdateDevice(UpdateDeviceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDeviceResponseUnmarshaller.Instance;

            return Invoke<UpdateDeviceResponse>(request, options);
        }



        /// <summary>
        /// Updates the details for an existing device. To remove information for any of the parameters,
        /// specify an empty string.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDevice service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateDevice service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ConflictException">
        /// There was a conflict processing the request. Updating or deleting the resource can
        /// cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/UpdateDevice">REST API Reference for UpdateDevice Operation</seealso>
        public virtual Task<UpdateDeviceResponse> UpdateDeviceAsync(UpdateDeviceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDeviceResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateDeviceResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateGlobalNetwork

        internal virtual UpdateGlobalNetworkResponse UpdateGlobalNetwork(UpdateGlobalNetworkRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateGlobalNetworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGlobalNetworkResponseUnmarshaller.Instance;

            return Invoke<UpdateGlobalNetworkResponse>(request, options);
        }



        /// <summary>
        /// Updates an existing global network. To remove information for any of the parameters,
        /// specify an empty string.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGlobalNetwork service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateGlobalNetwork service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ConflictException">
        /// There was a conflict processing the request. Updating or deleting the resource can
        /// cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/UpdateGlobalNetwork">REST API Reference for UpdateGlobalNetwork Operation</seealso>
        public virtual Task<UpdateGlobalNetworkResponse> UpdateGlobalNetworkAsync(UpdateGlobalNetworkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateGlobalNetworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGlobalNetworkResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateGlobalNetworkResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateLink

        internal virtual UpdateLinkResponse UpdateLink(UpdateLinkRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLinkResponseUnmarshaller.Instance;

            return Invoke<UpdateLinkResponse>(request, options);
        }



        /// <summary>
        /// Updates the details for an existing link. To remove information for any of the parameters,
        /// specify an empty string.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLink service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateLink service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ConflictException">
        /// There was a conflict processing the request. Updating or deleting the resource can
        /// cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ServiceQuotaExceededException">
        /// A service limit was exceeded.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/UpdateLink">REST API Reference for UpdateLink Operation</seealso>
        public virtual Task<UpdateLinkResponse> UpdateLinkAsync(UpdateLinkRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLinkResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateLinkResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateNetworkResourceMetadata

        internal virtual UpdateNetworkResourceMetadataResponse UpdateNetworkResourceMetadata(UpdateNetworkResourceMetadataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateNetworkResourceMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateNetworkResourceMetadataResponseUnmarshaller.Instance;

            return Invoke<UpdateNetworkResourceMetadataResponse>(request, options);
        }



        /// <summary>
        /// Updates the resource metadata for the specified global network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateNetworkResourceMetadata service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateNetworkResourceMetadata service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ConflictException">
        /// There was a conflict processing the request. Updating or deleting the resource can
        /// cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/UpdateNetworkResourceMetadata">REST API Reference for UpdateNetworkResourceMetadata Operation</seealso>
        public virtual Task<UpdateNetworkResourceMetadataResponse> UpdateNetworkResourceMetadataAsync(UpdateNetworkResourceMetadataRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateNetworkResourceMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateNetworkResourceMetadataResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateNetworkResourceMetadataResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateSite

        internal virtual UpdateSiteResponse UpdateSite(UpdateSiteRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSiteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSiteResponseUnmarshaller.Instance;

            return Invoke<UpdateSiteResponse>(request, options);
        }



        /// <summary>
        /// Updates the information for an existing site. To remove information for any of the
        /// parameters, specify an empty string.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSite service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateSite service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ConflictException">
        /// There was a conflict processing the request. Updating or deleting the resource can
        /// cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/UpdateSite">REST API Reference for UpdateSite Operation</seealso>
        public virtual Task<UpdateSiteResponse> UpdateSiteAsync(UpdateSiteRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSiteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSiteResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateSiteResponse>(request, options, cancellationToken);
        }

        #endregion
        
        #region  UpdateVpcAttachment

        internal virtual UpdateVpcAttachmentResponse UpdateVpcAttachment(UpdateVpcAttachmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateVpcAttachmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateVpcAttachmentResponseUnmarshaller.Instance;

            return Invoke<UpdateVpcAttachmentResponse>(request, options);
        }



        /// <summary>
        /// Updates a VPC attachment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVpcAttachment service method.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// 
        /// <returns>The response from the UpdateVpcAttachment service method, as returned by NetworkManager.</returns>
        /// <exception cref="Amazon.NetworkManager.Model.AccessDeniedException">
        /// You do not have sufficient access to perform this action.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ConflictException">
        /// There was a conflict processing the request. Updating or deleting the resource can
        /// cause an inconsistent state.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.InternalServerException">
        /// The request has failed due to an internal error.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ResourceNotFoundException">
        /// The specified resource could not be found.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ThrottlingException">
        /// The request was denied due to request throttling.
        /// </exception>
        /// <exception cref="Amazon.NetworkManager.Model.ValidationException">
        /// The input fails to satisfy the constraints.
        /// </exception>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/UpdateVpcAttachment">REST API Reference for UpdateVpcAttachment Operation</seealso>
        public virtual Task<UpdateVpcAttachmentResponse> UpdateVpcAttachmentAsync(UpdateVpcAttachmentRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateVpcAttachmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateVpcAttachmentResponseUnmarshaller.Instance;

            return InvokeAsync<UpdateVpcAttachmentResponse>(request, options, cancellationToken);
        }

        #endregion
        
    }
}