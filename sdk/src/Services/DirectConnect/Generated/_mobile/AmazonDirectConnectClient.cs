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
    /// AWS Direct Connect links your internal network to an AWS Direct Connect location over
    /// a standard Ethernet fiber-optic cable. One end of the cable is connected to your router,
    /// the other to an AWS Direct Connect router. With this connection in place, you can
    /// create virtual interfaces directly to the AWS cloud (for example, to Amazon EC2 and
    /// Amazon S3) and to Amazon VPC, bypassing Internet service providers in your network
    /// path. A connection provides access to all AWS Regions except the China (Beijing) and
    /// (China) Ningxia Regions. AWS resources in the China Regions can only be accessed through
    /// locations associated with those Regions.
    /// </summary>
    public partial class AmazonDirectConnectClient : AmazonServiceClient, IAmazonDirectConnect
    {
        private static IServiceMetadata serviceMetadata = new AmazonDirectConnectMetadata();
        
        #region Constructors

#if CORECLR
    
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

#endif

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
        /// Initiates the asynchronous execution of the AllocateConnectionOnInterconnect operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AllocateConnectionOnInterconnect operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the AllocateHostedConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AllocateHostedConnection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the AllocatePrivateVirtualInterface operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AllocatePrivateVirtualInterface operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the AllocatePublicVirtualInterface operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AllocatePublicVirtualInterface operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/AllocatePublicVirtualInterface">REST API Reference for AllocatePublicVirtualInterface Operation</seealso>
        public virtual Task<AllocatePublicVirtualInterfaceResponse> AllocatePublicVirtualInterfaceAsync(AllocatePublicVirtualInterfaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AllocatePublicVirtualInterfaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AllocatePublicVirtualInterfaceResponseUnmarshaller.Instance;

            return InvokeAsync<AllocatePublicVirtualInterfaceResponse>(request, options, cancellationToken);
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
        /// Initiates the asynchronous execution of the AssociateConnectionWithLag operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateConnectionWithLag operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the AssociateHostedConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateHostedConnection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/AssociateHostedConnection">REST API Reference for AssociateHostedConnection Operation</seealso>
        public virtual Task<AssociateHostedConnectionResponse> AssociateHostedConnectionAsync(AssociateHostedConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateHostedConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateHostedConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<AssociateHostedConnectionResponse>(request, options, cancellationToken);
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
        /// Initiates the asynchronous execution of the AssociateVirtualInterface operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateVirtualInterface operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the ConfirmConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ConfirmConnection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/ConfirmConnection">REST API Reference for ConfirmConnection Operation</seealso>
        public virtual Task<ConfirmConnectionResponse> ConfirmConnectionAsync(ConfirmConnectionRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ConfirmConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ConfirmConnectionResponseUnmarshaller.Instance;

            return InvokeAsync<ConfirmConnectionResponse>(request, options, cancellationToken);
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
        /// Initiates the asynchronous execution of the ConfirmPrivateVirtualInterface operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ConfirmPrivateVirtualInterface operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the ConfirmPublicVirtualInterface operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ConfirmPublicVirtualInterface operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/ConfirmPublicVirtualInterface">REST API Reference for ConfirmPublicVirtualInterface Operation</seealso>
        public virtual Task<ConfirmPublicVirtualInterfaceResponse> ConfirmPublicVirtualInterfaceAsync(ConfirmPublicVirtualInterfaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ConfirmPublicVirtualInterfaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ConfirmPublicVirtualInterfaceResponseUnmarshaller.Instance;

            return InvokeAsync<ConfirmPublicVirtualInterfaceResponse>(request, options, cancellationToken);
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
        /// Initiates the asynchronous execution of the CreateBGPPeer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateBGPPeer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the CreateConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateConnection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the CreateDirectConnectGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDirectConnectGateway operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the CreateDirectConnectGatewayAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDirectConnectGatewayAssociation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/CreateDirectConnectGatewayAssociation">REST API Reference for CreateDirectConnectGatewayAssociation Operation</seealso>
        public virtual Task<CreateDirectConnectGatewayAssociationResponse> CreateDirectConnectGatewayAssociationAsync(CreateDirectConnectGatewayAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDirectConnectGatewayAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDirectConnectGatewayAssociationResponseUnmarshaller.Instance;

            return InvokeAsync<CreateDirectConnectGatewayAssociationResponse>(request, options, cancellationToken);
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
        /// Initiates the asynchronous execution of the CreateInterconnect operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateInterconnect operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the CreateLag operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLag operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the CreatePrivateVirtualInterface operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePrivateVirtualInterface operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the CreatePublicVirtualInterface operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreatePublicVirtualInterface operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/CreatePublicVirtualInterface">REST API Reference for CreatePublicVirtualInterface Operation</seealso>
        public virtual Task<CreatePublicVirtualInterfaceResponse> CreatePublicVirtualInterfaceAsync(CreatePublicVirtualInterfaceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreatePublicVirtualInterfaceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreatePublicVirtualInterfaceResponseUnmarshaller.Instance;

            return InvokeAsync<CreatePublicVirtualInterfaceResponse>(request, options, cancellationToken);
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
        /// Initiates the asynchronous execution of the DeleteBGPPeer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteBGPPeer operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the DeleteConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnection operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the DeleteDirectConnectGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDirectConnectGateway operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the DeleteDirectConnectGatewayAssociation operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDirectConnectGatewayAssociation operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DeleteDirectConnectGatewayAssociation">REST API Reference for DeleteDirectConnectGatewayAssociation Operation</seealso>
        public virtual Task<DeleteDirectConnectGatewayAssociationResponse> DeleteDirectConnectGatewayAssociationAsync(DeleteDirectConnectGatewayAssociationRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDirectConnectGatewayAssociationRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDirectConnectGatewayAssociationResponseUnmarshaller.Instance;

            return InvokeAsync<DeleteDirectConnectGatewayAssociationResponse>(request, options, cancellationToken);
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
        /// Initiates the asynchronous execution of the DeleteInterconnect operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteInterconnect operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the DeleteLag operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLag operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the DeleteVirtualInterface operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteVirtualInterface operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the DescribeConnectionLoa operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeConnectionLoa operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the DescribeConnections operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeConnections operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the DescribeConnectionsOnInterconnect operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeConnectionsOnInterconnect operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        
        #region  DescribeDirectConnectGatewayAssociations

        internal virtual DescribeDirectConnectGatewayAssociationsResponse DescribeDirectConnectGatewayAssociations(DescribeDirectConnectGatewayAssociationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeDirectConnectGatewayAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeDirectConnectGatewayAssociationsResponseUnmarshaller.Instance;

            return Invoke<DescribeDirectConnectGatewayAssociationsResponse>(request, options);
        }


        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDirectConnectGatewayAssociations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDirectConnectGatewayAssociations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the DescribeDirectConnectGatewayAttachments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDirectConnectGatewayAttachments operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the DescribeDirectConnectGateways operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeDirectConnectGateways operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the DescribeHostedConnections operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeHostedConnections operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the DescribeInterconnectLoa operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInterconnectLoa operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Lists the interconnects owned by the AWS account or only the specified interconnect.
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
        /// Initiates the asynchronous execution of the DescribeInterconnects operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeInterconnects operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the DescribeLags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the DescribeLoa operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLoa operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Lists the AWS Direct Connect locations in the current AWS Region. These are the locations
        /// that can be selected when calling <a>CreateConnection</a> or <a>CreateInterconnect</a>.
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
        /// Initiates the asynchronous execution of the DescribeLocations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeLocations operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DescribeLocations">REST API Reference for DescribeLocations Operation</seealso>
        public virtual Task<DescribeLocationsResponse> DescribeLocationsAsync(DescribeLocationsRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeLocationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeLocationsResponseUnmarshaller.Instance;

            return InvokeAsync<DescribeLocationsResponse>(request, options, cancellationToken);
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
        /// Initiates the asynchronous execution of the DescribeTags operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeTags operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Lists the virtual private gateways owned by the AWS account.
        /// 
        ///  
        /// <para>
        /// You can create one or more AWS Direct Connect private virtual interfaces linked to
        /// a virtual private gateway.
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
        /// Initiates the asynchronous execution of the DescribeVirtualGateways operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVirtualGateways operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Displays all virtual interfaces for an AWS account. Virtual interfaces deleted fewer
        /// than 15 minutes before you make the request are also returned. If you specify a connection
        /// ID, only the virtual interfaces associated with the connection are returned. If you
        /// specify a virtual interface ID, then only a single virtual interface is returned.
        /// 
        ///  
        /// <para>
        /// A virtual interface (VLAN) transmits the traffic between the AWS Direct Connect location
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
        /// Initiates the asynchronous execution of the DescribeVirtualInterfaces operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeVirtualInterfaces operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the DisassociateConnectionFromLag operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateConnectionFromLag operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/DisassociateConnectionFromLag">REST API Reference for DisassociateConnectionFromLag Operation</seealso>
        public virtual Task<DisassociateConnectionFromLagResponse> DisassociateConnectionFromLagAsync(DisassociateConnectionFromLagRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateConnectionFromLagRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateConnectionFromLagResponseUnmarshaller.Instance;

            return InvokeAsync<DisassociateConnectionFromLagResponse>(request, options, cancellationToken);
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
        /// Initiates the asynchronous execution of the TagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the UntagResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/directconnect-2012-10-25/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual Task<UntagResourceResponse> UntagResourceAsync(UntagResourceRequest request, System.Threading.CancellationToken cancellationToken = default(CancellationToken))
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return InvokeAsync<UntagResourceResponse>(request, options, cancellationToken);
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
        /// Initiates the asynchronous execution of the UpdateLag operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateLag operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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
        /// Initiates the asynchronous execution of the UpdateVirtualInterfaceAttributes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateVirtualInterfaceAttributes operation.</param>
        /// <param name="cancellationToken">
        ///     A cancellation token that can be used by other objects or threads to receive notice of cancellation.
        /// </param>
        /// <returns>The task object representing the asynchronous operation.</returns>
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