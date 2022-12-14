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

#if BCL45 || AWS_ASYNC_ENUMERABLES_API
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

        #region Overrides

        
        /// <summary>
        /// Creates the signer for the service.
        /// </summary>
        protected override AbstractAWSSigner CreateSigner()
        {
            return new AWS4Signer();
        }

        /// <summary>
        /// Customize the pipeline
        /// </summary>
        /// <param name="pipeline"></param>
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
        public virtual AcceptAttachmentResponse AcceptAttachment(AcceptAttachmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AcceptAttachmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptAttachmentResponseUnmarshaller.Instance;

            return Invoke<AcceptAttachmentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AcceptAttachment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AcceptAttachment operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAcceptAttachment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/AcceptAttachment">REST API Reference for AcceptAttachment Operation</seealso>
        public virtual IAsyncResult BeginAcceptAttachment(AcceptAttachmentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AcceptAttachmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AcceptAttachmentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AcceptAttachment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAcceptAttachment.</param>
        /// 
        /// <returns>Returns a  AcceptAttachmentResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/AcceptAttachment">REST API Reference for AcceptAttachment Operation</seealso>
        public virtual AcceptAttachmentResponse EndAcceptAttachment(IAsyncResult asyncResult)
        {
            return EndInvoke<AcceptAttachmentResponse>(asyncResult);
        }

        #endregion
        
        #region  AssociateConnectPeer

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
        public virtual AssociateConnectPeerResponse AssociateConnectPeer(AssociateConnectPeerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateConnectPeerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateConnectPeerResponseUnmarshaller.Instance;

            return Invoke<AssociateConnectPeerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateConnectPeer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateConnectPeer operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateConnectPeer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/AssociateConnectPeer">REST API Reference for AssociateConnectPeer Operation</seealso>
        public virtual IAsyncResult BeginAssociateConnectPeer(AssociateConnectPeerRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateConnectPeerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateConnectPeerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateConnectPeer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateConnectPeer.</param>
        /// 
        /// <returns>Returns a  AssociateConnectPeerResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/AssociateConnectPeer">REST API Reference for AssociateConnectPeer Operation</seealso>
        public virtual AssociateConnectPeerResponse EndAssociateConnectPeer(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateConnectPeerResponse>(asyncResult);
        }

        #endregion
        
        #region  AssociateCustomerGateway

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
        public virtual AssociateCustomerGatewayResponse AssociateCustomerGateway(AssociateCustomerGatewayRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateCustomerGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateCustomerGatewayResponseUnmarshaller.Instance;

            return Invoke<AssociateCustomerGatewayResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateCustomerGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateCustomerGateway operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateCustomerGateway
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/AssociateCustomerGateway">REST API Reference for AssociateCustomerGateway Operation</seealso>
        public virtual IAsyncResult BeginAssociateCustomerGateway(AssociateCustomerGatewayRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateCustomerGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateCustomerGatewayResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateCustomerGateway operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateCustomerGateway.</param>
        /// 
        /// <returns>Returns a  AssociateCustomerGatewayResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/AssociateCustomerGateway">REST API Reference for AssociateCustomerGateway Operation</seealso>
        public virtual AssociateCustomerGatewayResponse EndAssociateCustomerGateway(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateCustomerGatewayResponse>(asyncResult);
        }

        #endregion
        
        #region  AssociateLink

        /// <summary>
        /// Associates a link to a device. A device can be associated to multiple links and a
        /// link can be associated to multiple devices. The device and link must be in the same
        /// global network and the same site.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the AssociateLink service method.</param>
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
        public virtual AssociateLinkResponse AssociateLink(AssociateLinkRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateLinkResponseUnmarshaller.Instance;

            return Invoke<AssociateLinkResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateLink operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateLink operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateLink
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/AssociateLink">REST API Reference for AssociateLink Operation</seealso>
        public virtual IAsyncResult BeginAssociateLink(AssociateLinkRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateLinkResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateLink operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateLink.</param>
        /// 
        /// <returns>Returns a  AssociateLinkResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/AssociateLink">REST API Reference for AssociateLink Operation</seealso>
        public virtual AssociateLinkResponse EndAssociateLink(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateLinkResponse>(asyncResult);
        }

        #endregion
        
        #region  AssociateTransitGatewayConnectPeer

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
        public virtual AssociateTransitGatewayConnectPeerResponse AssociateTransitGatewayConnectPeer(AssociateTransitGatewayConnectPeerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateTransitGatewayConnectPeerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateTransitGatewayConnectPeerResponseUnmarshaller.Instance;

            return Invoke<AssociateTransitGatewayConnectPeerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateTransitGatewayConnectPeer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the AssociateTransitGatewayConnectPeer operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateTransitGatewayConnectPeer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/AssociateTransitGatewayConnectPeer">REST API Reference for AssociateTransitGatewayConnectPeer Operation</seealso>
        public virtual IAsyncResult BeginAssociateTransitGatewayConnectPeer(AssociateTransitGatewayConnectPeerRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = AssociateTransitGatewayConnectPeerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = AssociateTransitGatewayConnectPeerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  AssociateTransitGatewayConnectPeer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateTransitGatewayConnectPeer.</param>
        /// 
        /// <returns>Returns a  AssociateTransitGatewayConnectPeerResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/AssociateTransitGatewayConnectPeer">REST API Reference for AssociateTransitGatewayConnectPeer Operation</seealso>
        public virtual AssociateTransitGatewayConnectPeerResponse EndAssociateTransitGatewayConnectPeer(IAsyncResult asyncResult)
        {
            return EndInvoke<AssociateTransitGatewayConnectPeerResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateConnectAttachment

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
        public virtual CreateConnectAttachmentResponse CreateConnectAttachment(CreateConnectAttachmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateConnectAttachmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConnectAttachmentResponseUnmarshaller.Instance;

            return Invoke<CreateConnectAttachmentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateConnectAttachment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateConnectAttachment operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateConnectAttachment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/CreateConnectAttachment">REST API Reference for CreateConnectAttachment Operation</seealso>
        public virtual IAsyncResult BeginCreateConnectAttachment(CreateConnectAttachmentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateConnectAttachmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConnectAttachmentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateConnectAttachment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateConnectAttachment.</param>
        /// 
        /// <returns>Returns a  CreateConnectAttachmentResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/CreateConnectAttachment">REST API Reference for CreateConnectAttachment Operation</seealso>
        public virtual CreateConnectAttachmentResponse EndCreateConnectAttachment(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateConnectAttachmentResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateConnection

        /// <summary>
        /// Creates a connection between two devices. The devices can be a physical or virtual
        /// appliance that connects to a third-party appliance in a VPC, or a physical appliance
        /// that connects to another physical appliance in an on-premises network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConnection service method.</param>
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
        public virtual CreateConnectionResponse CreateConnection(CreateConnectionRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the CreateConnection operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateConnection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/CreateConnection">REST API Reference for CreateConnection Operation</seealso>
        public virtual IAsyncResult BeginCreateConnection(CreateConnectionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConnectionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateConnection.</param>
        /// 
        /// <returns>Returns a  CreateConnectionResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/CreateConnection">REST API Reference for CreateConnection Operation</seealso>
        public virtual CreateConnectionResponse EndCreateConnection(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateConnectionResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateConnectPeer

        /// <summary>
        /// Creates a core network Connect peer for a specified core network connect attachment
        /// between a core network and an appliance. The peer address and transit gateway address
        /// must be the same IP address family (IPv4 or IPv6).
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateConnectPeer service method.</param>
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
        public virtual CreateConnectPeerResponse CreateConnectPeer(CreateConnectPeerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateConnectPeerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConnectPeerResponseUnmarshaller.Instance;

            return Invoke<CreateConnectPeerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateConnectPeer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateConnectPeer operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateConnectPeer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/CreateConnectPeer">REST API Reference for CreateConnectPeer Operation</seealso>
        public virtual IAsyncResult BeginCreateConnectPeer(CreateConnectPeerRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateConnectPeerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateConnectPeerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateConnectPeer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateConnectPeer.</param>
        /// 
        /// <returns>Returns a  CreateConnectPeerResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/CreateConnectPeer">REST API Reference for CreateConnectPeer Operation</seealso>
        public virtual CreateConnectPeerResponse EndCreateConnectPeer(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateConnectPeerResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateCoreNetwork

        /// <summary>
        /// Creates a core network as part of your global network, and optionally, with a core
        /// network policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateCoreNetwork service method.</param>
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
        public virtual CreateCoreNetworkResponse CreateCoreNetwork(CreateCoreNetworkRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCoreNetworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCoreNetworkResponseUnmarshaller.Instance;

            return Invoke<CreateCoreNetworkResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCoreNetwork operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateCoreNetwork operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateCoreNetwork
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/CreateCoreNetwork">REST API Reference for CreateCoreNetwork Operation</seealso>
        public virtual IAsyncResult BeginCreateCoreNetwork(CreateCoreNetworkRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateCoreNetworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateCoreNetworkResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateCoreNetwork operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCoreNetwork.</param>
        /// 
        /// <returns>Returns a  CreateCoreNetworkResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/CreateCoreNetwork">REST API Reference for CreateCoreNetwork Operation</seealso>
        public virtual CreateCoreNetworkResponse EndCreateCoreNetwork(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateCoreNetworkResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateDevice

        /// <summary>
        /// Creates a new device in a global network. If you specify both a site ID and a location,
        /// the location of the site is used for visualization in the Network Manager console.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateDevice service method.</param>
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
        public virtual CreateDeviceResponse CreateDevice(CreateDeviceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDeviceResponseUnmarshaller.Instance;

            return Invoke<CreateDeviceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateDevice operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDevice
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/CreateDevice">REST API Reference for CreateDevice Operation</seealso>
        public virtual IAsyncResult BeginCreateDevice(CreateDeviceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateDeviceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateDevice operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDevice.</param>
        /// 
        /// <returns>Returns a  CreateDeviceResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/CreateDevice">REST API Reference for CreateDevice Operation</seealso>
        public virtual CreateDeviceResponse EndCreateDevice(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateDeviceResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateGlobalNetwork

        /// <summary>
        /// Creates a new, empty global network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateGlobalNetwork service method.</param>
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
        public virtual CreateGlobalNetworkResponse CreateGlobalNetwork(CreateGlobalNetworkRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateGlobalNetworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGlobalNetworkResponseUnmarshaller.Instance;

            return Invoke<CreateGlobalNetworkResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateGlobalNetwork operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateGlobalNetwork operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateGlobalNetwork
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/CreateGlobalNetwork">REST API Reference for CreateGlobalNetwork Operation</seealso>
        public virtual IAsyncResult BeginCreateGlobalNetwork(CreateGlobalNetworkRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateGlobalNetworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateGlobalNetworkResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateGlobalNetwork operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateGlobalNetwork.</param>
        /// 
        /// <returns>Returns a  CreateGlobalNetworkResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/CreateGlobalNetwork">REST API Reference for CreateGlobalNetwork Operation</seealso>
        public virtual CreateGlobalNetworkResponse EndCreateGlobalNetwork(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateGlobalNetworkResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateLink

        /// <summary>
        /// Creates a new link for a specified site.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateLink service method.</param>
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
        public virtual CreateLinkResponse CreateLink(CreateLinkRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLinkResponseUnmarshaller.Instance;

            return Invoke<CreateLinkResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateLink operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateLink operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateLink
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/CreateLink">REST API Reference for CreateLink Operation</seealso>
        public virtual IAsyncResult BeginCreateLink(CreateLinkRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateLinkResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateLink operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateLink.</param>
        /// 
        /// <returns>Returns a  CreateLinkResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/CreateLink">REST API Reference for CreateLink Operation</seealso>
        public virtual CreateLinkResponse EndCreateLink(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateLinkResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateSite

        /// <summary>
        /// Creates a new site in a global network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSite service method.</param>
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
        public virtual CreateSiteResponse CreateSite(CreateSiteRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSiteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSiteResponseUnmarshaller.Instance;

            return Invoke<CreateSiteResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSite operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSite operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSite
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/CreateSite">REST API Reference for CreateSite Operation</seealso>
        public virtual IAsyncResult BeginCreateSite(CreateSiteRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSiteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSiteResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSite operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSite.</param>
        /// 
        /// <returns>Returns a  CreateSiteResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/CreateSite">REST API Reference for CreateSite Operation</seealso>
        public virtual CreateSiteResponse EndCreateSite(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateSiteResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateSiteToSiteVpnAttachment

        /// <summary>
        /// Creates an Amazon Web Services site-to-site VPN attachment on an edge location of
        /// a core network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateSiteToSiteVpnAttachment service method.</param>
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
        public virtual CreateSiteToSiteVpnAttachmentResponse CreateSiteToSiteVpnAttachment(CreateSiteToSiteVpnAttachmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSiteToSiteVpnAttachmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSiteToSiteVpnAttachmentResponseUnmarshaller.Instance;

            return Invoke<CreateSiteToSiteVpnAttachmentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSiteToSiteVpnAttachment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateSiteToSiteVpnAttachment operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSiteToSiteVpnAttachment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/CreateSiteToSiteVpnAttachment">REST API Reference for CreateSiteToSiteVpnAttachment Operation</seealso>
        public virtual IAsyncResult BeginCreateSiteToSiteVpnAttachment(CreateSiteToSiteVpnAttachmentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateSiteToSiteVpnAttachmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateSiteToSiteVpnAttachmentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateSiteToSiteVpnAttachment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSiteToSiteVpnAttachment.</param>
        /// 
        /// <returns>Returns a  CreateSiteToSiteVpnAttachmentResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/CreateSiteToSiteVpnAttachment">REST API Reference for CreateSiteToSiteVpnAttachment Operation</seealso>
        public virtual CreateSiteToSiteVpnAttachmentResponse EndCreateSiteToSiteVpnAttachment(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateSiteToSiteVpnAttachmentResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateTransitGatewayPeering

        /// <summary>
        /// Creates a transit gateway peering connection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTransitGatewayPeering service method.</param>
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
        public virtual CreateTransitGatewayPeeringResponse CreateTransitGatewayPeering(CreateTransitGatewayPeeringRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTransitGatewayPeeringRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTransitGatewayPeeringResponseUnmarshaller.Instance;

            return Invoke<CreateTransitGatewayPeeringResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTransitGatewayPeering operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTransitGatewayPeering operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTransitGatewayPeering
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/CreateTransitGatewayPeering">REST API Reference for CreateTransitGatewayPeering Operation</seealso>
        public virtual IAsyncResult BeginCreateTransitGatewayPeering(CreateTransitGatewayPeeringRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTransitGatewayPeeringRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTransitGatewayPeeringResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTransitGatewayPeering operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTransitGatewayPeering.</param>
        /// 
        /// <returns>Returns a  CreateTransitGatewayPeeringResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/CreateTransitGatewayPeering">REST API Reference for CreateTransitGatewayPeering Operation</seealso>
        public virtual CreateTransitGatewayPeeringResponse EndCreateTransitGatewayPeering(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateTransitGatewayPeeringResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateTransitGatewayRouteTableAttachment

        /// <summary>
        /// Creates a transit gateway route table attachment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateTransitGatewayRouteTableAttachment service method.</param>
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
        public virtual CreateTransitGatewayRouteTableAttachmentResponse CreateTransitGatewayRouteTableAttachment(CreateTransitGatewayRouteTableAttachmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTransitGatewayRouteTableAttachmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTransitGatewayRouteTableAttachmentResponseUnmarshaller.Instance;

            return Invoke<CreateTransitGatewayRouteTableAttachmentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTransitGatewayRouteTableAttachment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateTransitGatewayRouteTableAttachment operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateTransitGatewayRouteTableAttachment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/CreateTransitGatewayRouteTableAttachment">REST API Reference for CreateTransitGatewayRouteTableAttachment Operation</seealso>
        public virtual IAsyncResult BeginCreateTransitGatewayRouteTableAttachment(CreateTransitGatewayRouteTableAttachmentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateTransitGatewayRouteTableAttachmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateTransitGatewayRouteTableAttachmentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateTransitGatewayRouteTableAttachment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTransitGatewayRouteTableAttachment.</param>
        /// 
        /// <returns>Returns a  CreateTransitGatewayRouteTableAttachmentResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/CreateTransitGatewayRouteTableAttachment">REST API Reference for CreateTransitGatewayRouteTableAttachment Operation</seealso>
        public virtual CreateTransitGatewayRouteTableAttachmentResponse EndCreateTransitGatewayRouteTableAttachment(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateTransitGatewayRouteTableAttachmentResponse>(asyncResult);
        }

        #endregion
        
        #region  CreateVpcAttachment

        /// <summary>
        /// Creates a VPC attachment on an edge location of a core network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the CreateVpcAttachment service method.</param>
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
        public virtual CreateVpcAttachmentResponse CreateVpcAttachment(CreateVpcAttachmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVpcAttachmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVpcAttachmentResponseUnmarshaller.Instance;

            return Invoke<CreateVpcAttachmentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the CreateVpcAttachment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the CreateVpcAttachment operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateVpcAttachment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/CreateVpcAttachment">REST API Reference for CreateVpcAttachment Operation</seealso>
        public virtual IAsyncResult BeginCreateVpcAttachment(CreateVpcAttachmentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = CreateVpcAttachmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = CreateVpcAttachmentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  CreateVpcAttachment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateVpcAttachment.</param>
        /// 
        /// <returns>Returns a  CreateVpcAttachmentResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/CreateVpcAttachment">REST API Reference for CreateVpcAttachment Operation</seealso>
        public virtual CreateVpcAttachmentResponse EndCreateVpcAttachment(IAsyncResult asyncResult)
        {
            return EndInvoke<CreateVpcAttachmentResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteAttachment

        /// <summary>
        /// Deletes an attachment. Supports all attachment types.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteAttachment service method.</param>
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
        public virtual DeleteAttachmentResponse DeleteAttachment(DeleteAttachmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAttachmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAttachmentResponseUnmarshaller.Instance;

            return Invoke<DeleteAttachmentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteAttachment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteAttachment operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteAttachment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/DeleteAttachment">REST API Reference for DeleteAttachment Operation</seealso>
        public virtual IAsyncResult BeginDeleteAttachment(DeleteAttachmentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteAttachmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteAttachmentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteAttachment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteAttachment.</param>
        /// 
        /// <returns>Returns a  DeleteAttachmentResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/DeleteAttachment">REST API Reference for DeleteAttachment Operation</seealso>
        public virtual DeleteAttachmentResponse EndDeleteAttachment(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteAttachmentResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteConnection

        /// <summary>
        /// Deletes the specified connection in your global network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnection service method.</param>
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
        public virtual DeleteConnectionResponse DeleteConnection(DeleteConnectionRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnection operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteConnection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/DeleteConnection">REST API Reference for DeleteConnection Operation</seealso>
        public virtual IAsyncResult BeginDeleteConnection(DeleteConnectionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConnectionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteConnection.</param>
        /// 
        /// <returns>Returns a  DeleteConnectionResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/DeleteConnection">REST API Reference for DeleteConnection Operation</seealso>
        public virtual DeleteConnectionResponse EndDeleteConnection(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteConnectionResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteConnectPeer

        /// <summary>
        /// Deletes a Connect peer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnectPeer service method.</param>
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
        public virtual DeleteConnectPeerResponse DeleteConnectPeer(DeleteConnectPeerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteConnectPeerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConnectPeerResponseUnmarshaller.Instance;

            return Invoke<DeleteConnectPeerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteConnectPeer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteConnectPeer operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteConnectPeer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/DeleteConnectPeer">REST API Reference for DeleteConnectPeer Operation</seealso>
        public virtual IAsyncResult BeginDeleteConnectPeer(DeleteConnectPeerRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteConnectPeerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteConnectPeerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteConnectPeer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteConnectPeer.</param>
        /// 
        /// <returns>Returns a  DeleteConnectPeerResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/DeleteConnectPeer">REST API Reference for DeleteConnectPeer Operation</seealso>
        public virtual DeleteConnectPeerResponse EndDeleteConnectPeer(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteConnectPeerResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteCoreNetwork

        /// <summary>
        /// Deletes a core network along with all core network policies. This can only be done
        /// if there are no attachments on a core network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCoreNetwork service method.</param>
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
        public virtual DeleteCoreNetworkResponse DeleteCoreNetwork(DeleteCoreNetworkRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCoreNetworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCoreNetworkResponseUnmarshaller.Instance;

            return Invoke<DeleteCoreNetworkResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCoreNetwork operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCoreNetwork operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCoreNetwork
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/DeleteCoreNetwork">REST API Reference for DeleteCoreNetwork Operation</seealso>
        public virtual IAsyncResult BeginDeleteCoreNetwork(DeleteCoreNetworkRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCoreNetworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCoreNetworkResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCoreNetwork operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCoreNetwork.</param>
        /// 
        /// <returns>Returns a  DeleteCoreNetworkResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/DeleteCoreNetwork">REST API Reference for DeleteCoreNetwork Operation</seealso>
        public virtual DeleteCoreNetworkResponse EndDeleteCoreNetwork(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteCoreNetworkResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteCoreNetworkPolicyVersion

        /// <summary>
        /// Deletes a policy version from a core network. You can't delete the current LIVE policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteCoreNetworkPolicyVersion service method.</param>
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
        public virtual DeleteCoreNetworkPolicyVersionResponse DeleteCoreNetworkPolicyVersion(DeleteCoreNetworkPolicyVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCoreNetworkPolicyVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCoreNetworkPolicyVersionResponseUnmarshaller.Instance;

            return Invoke<DeleteCoreNetworkPolicyVersionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCoreNetworkPolicyVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteCoreNetworkPolicyVersion operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteCoreNetworkPolicyVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/DeleteCoreNetworkPolicyVersion">REST API Reference for DeleteCoreNetworkPolicyVersion Operation</seealso>
        public virtual IAsyncResult BeginDeleteCoreNetworkPolicyVersion(DeleteCoreNetworkPolicyVersionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteCoreNetworkPolicyVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteCoreNetworkPolicyVersionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteCoreNetworkPolicyVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCoreNetworkPolicyVersion.</param>
        /// 
        /// <returns>Returns a  DeleteCoreNetworkPolicyVersionResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/DeleteCoreNetworkPolicyVersion">REST API Reference for DeleteCoreNetworkPolicyVersion Operation</seealso>
        public virtual DeleteCoreNetworkPolicyVersionResponse EndDeleteCoreNetworkPolicyVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteCoreNetworkPolicyVersionResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteDevice

        /// <summary>
        /// Deletes an existing device. You must first disassociate the device from any links
        /// and customer gateways.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteDevice service method.</param>
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
        public virtual DeleteDeviceResponse DeleteDevice(DeleteDeviceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDeviceResponseUnmarshaller.Instance;

            return Invoke<DeleteDeviceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteDevice operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteDevice
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/DeleteDevice">REST API Reference for DeleteDevice Operation</seealso>
        public virtual IAsyncResult BeginDeleteDevice(DeleteDeviceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteDeviceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteDevice operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDevice.</param>
        /// 
        /// <returns>Returns a  DeleteDeviceResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/DeleteDevice">REST API Reference for DeleteDevice Operation</seealso>
        public virtual DeleteDeviceResponse EndDeleteDevice(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteDeviceResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteGlobalNetwork

        /// <summary>
        /// Deletes an existing global network. You must first delete all global network objects
        /// (devices, links, and sites), deregister all transit gateways, and delete any core
        /// networks.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteGlobalNetwork service method.</param>
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
        public virtual DeleteGlobalNetworkResponse DeleteGlobalNetwork(DeleteGlobalNetworkRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteGlobalNetworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGlobalNetworkResponseUnmarshaller.Instance;

            return Invoke<DeleteGlobalNetworkResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteGlobalNetwork operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteGlobalNetwork operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteGlobalNetwork
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/DeleteGlobalNetwork">REST API Reference for DeleteGlobalNetwork Operation</seealso>
        public virtual IAsyncResult BeginDeleteGlobalNetwork(DeleteGlobalNetworkRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteGlobalNetworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteGlobalNetworkResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteGlobalNetwork operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteGlobalNetwork.</param>
        /// 
        /// <returns>Returns a  DeleteGlobalNetworkResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/DeleteGlobalNetwork">REST API Reference for DeleteGlobalNetwork Operation</seealso>
        public virtual DeleteGlobalNetworkResponse EndDeleteGlobalNetwork(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteGlobalNetworkResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteLink

        /// <summary>
        /// Deletes an existing link. You must first disassociate the link from any devices and
        /// customer gateways.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteLink service method.</param>
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
        public virtual DeleteLinkResponse DeleteLink(DeleteLinkRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLinkResponseUnmarshaller.Instance;

            return Invoke<DeleteLinkResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteLink operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteLink operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteLink
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/DeleteLink">REST API Reference for DeleteLink Operation</seealso>
        public virtual IAsyncResult BeginDeleteLink(DeleteLinkRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteLinkResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteLink operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteLink.</param>
        /// 
        /// <returns>Returns a  DeleteLinkResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/DeleteLink">REST API Reference for DeleteLink Operation</seealso>
        public virtual DeleteLinkResponse EndDeleteLink(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteLinkResponse>(asyncResult);
        }

        #endregion
        
        #region  DeletePeering

        /// <summary>
        /// Deletes an existing peering connection.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeletePeering service method.</param>
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
        public virtual DeletePeeringResponse DeletePeering(DeletePeeringRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePeeringRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePeeringResponseUnmarshaller.Instance;

            return Invoke<DeletePeeringResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePeering operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeletePeering operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeletePeering
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/DeletePeering">REST API Reference for DeletePeering Operation</seealso>
        public virtual IAsyncResult BeginDeletePeering(DeletePeeringRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeletePeeringRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeletePeeringResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeletePeering operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePeering.</param>
        /// 
        /// <returns>Returns a  DeletePeeringResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/DeletePeering">REST API Reference for DeletePeering Operation</seealso>
        public virtual DeletePeeringResponse EndDeletePeering(IAsyncResult asyncResult)
        {
            return EndInvoke<DeletePeeringResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteResourcePolicy

        /// <summary>
        /// Deletes a resource policy for the specified resource. This revokes the access of the
        /// principals specified in the resource policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePolicy service method.</param>
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
        public virtual DeleteResourcePolicyResponse DeleteResourcePolicy(DeleteResourcePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResourcePolicyResponseUnmarshaller.Instance;

            return Invoke<DeleteResourcePolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteResourcePolicy operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteResourcePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        public virtual IAsyncResult BeginDeleteResourcePolicy(DeleteResourcePolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteResourcePolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteResourcePolicy.</param>
        /// 
        /// <returns>Returns a  DeleteResourcePolicyResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/DeleteResourcePolicy">REST API Reference for DeleteResourcePolicy Operation</seealso>
        public virtual DeleteResourcePolicyResponse EndDeleteResourcePolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteResourcePolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  DeleteSite

        /// <summary>
        /// Deletes an existing site. The site cannot be associated with any device or link.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeleteSite service method.</param>
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
        public virtual DeleteSiteResponse DeleteSite(DeleteSiteRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSiteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSiteResponseUnmarshaller.Instance;

            return Invoke<DeleteSiteResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSite operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeleteSite operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteSite
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/DeleteSite">REST API Reference for DeleteSite Operation</seealso>
        public virtual IAsyncResult BeginDeleteSite(DeleteSiteRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeleteSiteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeleteSiteResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeleteSite operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSite.</param>
        /// 
        /// <returns>Returns a  DeleteSiteResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/DeleteSite">REST API Reference for DeleteSite Operation</seealso>
        public virtual DeleteSiteResponse EndDeleteSite(IAsyncResult asyncResult)
        {
            return EndInvoke<DeleteSiteResponse>(asyncResult);
        }

        #endregion
        
        #region  DeregisterTransitGateway

        /// <summary>
        /// Deregisters a transit gateway from your global network. This action does not delete
        /// your transit gateway, or modify any of its attachments. This action removes any customer
        /// gateway associations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DeregisterTransitGateway service method.</param>
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
        public virtual DeregisterTransitGatewayResponse DeregisterTransitGateway(DeregisterTransitGatewayRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterTransitGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterTransitGatewayResponseUnmarshaller.Instance;

            return Invoke<DeregisterTransitGatewayResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterTransitGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DeregisterTransitGateway operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeregisterTransitGateway
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/DeregisterTransitGateway">REST API Reference for DeregisterTransitGateway Operation</seealso>
        public virtual IAsyncResult BeginDeregisterTransitGateway(DeregisterTransitGatewayRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DeregisterTransitGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DeregisterTransitGatewayResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DeregisterTransitGateway operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeregisterTransitGateway.</param>
        /// 
        /// <returns>Returns a  DeregisterTransitGatewayResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/DeregisterTransitGateway">REST API Reference for DeregisterTransitGateway Operation</seealso>
        public virtual DeregisterTransitGatewayResponse EndDeregisterTransitGateway(IAsyncResult asyncResult)
        {
            return EndInvoke<DeregisterTransitGatewayResponse>(asyncResult);
        }

        #endregion
        
        #region  DescribeGlobalNetworks

        /// <summary>
        /// Describes one or more global networks. By default, all global networks are described.
        /// To describe the objects in your global network, you must use the appropriate <code>Get*</code>
        /// action. For example, to list the transit gateways in your global network, use <a>GetTransitGatewayRegistrations</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DescribeGlobalNetworks service method.</param>
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
        public virtual DescribeGlobalNetworksResponse DescribeGlobalNetworks(DescribeGlobalNetworksRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeGlobalNetworksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGlobalNetworksResponseUnmarshaller.Instance;

            return Invoke<DescribeGlobalNetworksResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeGlobalNetworks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DescribeGlobalNetworks operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeGlobalNetworks
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/DescribeGlobalNetworks">REST API Reference for DescribeGlobalNetworks Operation</seealso>
        public virtual IAsyncResult BeginDescribeGlobalNetworks(DescribeGlobalNetworksRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DescribeGlobalNetworksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DescribeGlobalNetworksResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DescribeGlobalNetworks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeGlobalNetworks.</param>
        /// 
        /// <returns>Returns a  DescribeGlobalNetworksResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/DescribeGlobalNetworks">REST API Reference for DescribeGlobalNetworks Operation</seealso>
        public virtual DescribeGlobalNetworksResponse EndDescribeGlobalNetworks(IAsyncResult asyncResult)
        {
            return EndInvoke<DescribeGlobalNetworksResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociateConnectPeer

        /// <summary>
        /// Disassociates a core network Connect peer from a device and a link.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateConnectPeer service method.</param>
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
        public virtual DisassociateConnectPeerResponse DisassociateConnectPeer(DisassociateConnectPeerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateConnectPeerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateConnectPeerResponseUnmarshaller.Instance;

            return Invoke<DisassociateConnectPeerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateConnectPeer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateConnectPeer operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateConnectPeer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/DisassociateConnectPeer">REST API Reference for DisassociateConnectPeer Operation</seealso>
        public virtual IAsyncResult BeginDisassociateConnectPeer(DisassociateConnectPeerRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateConnectPeerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateConnectPeerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateConnectPeer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateConnectPeer.</param>
        /// 
        /// <returns>Returns a  DisassociateConnectPeerResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/DisassociateConnectPeer">REST API Reference for DisassociateConnectPeer Operation</seealso>
        public virtual DisassociateConnectPeerResponse EndDisassociateConnectPeer(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateConnectPeerResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociateCustomerGateway

        /// <summary>
        /// Disassociates a customer gateway from a device and a link.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateCustomerGateway service method.</param>
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
        public virtual DisassociateCustomerGatewayResponse DisassociateCustomerGateway(DisassociateCustomerGatewayRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateCustomerGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateCustomerGatewayResponseUnmarshaller.Instance;

            return Invoke<DisassociateCustomerGatewayResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateCustomerGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateCustomerGateway operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateCustomerGateway
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/DisassociateCustomerGateway">REST API Reference for DisassociateCustomerGateway Operation</seealso>
        public virtual IAsyncResult BeginDisassociateCustomerGateway(DisassociateCustomerGatewayRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateCustomerGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateCustomerGatewayResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateCustomerGateway operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateCustomerGateway.</param>
        /// 
        /// <returns>Returns a  DisassociateCustomerGatewayResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/DisassociateCustomerGateway">REST API Reference for DisassociateCustomerGateway Operation</seealso>
        public virtual DisassociateCustomerGatewayResponse EndDisassociateCustomerGateway(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateCustomerGatewayResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociateLink

        /// <summary>
        /// Disassociates an existing device from a link. You must first disassociate any customer
        /// gateways that are associated with the link.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateLink service method.</param>
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
        public virtual DisassociateLinkResponse DisassociateLink(DisassociateLinkRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateLinkResponseUnmarshaller.Instance;

            return Invoke<DisassociateLinkResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateLink operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateLink operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateLink
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/DisassociateLink">REST API Reference for DisassociateLink Operation</seealso>
        public virtual IAsyncResult BeginDisassociateLink(DisassociateLinkRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateLinkResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateLink operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateLink.</param>
        /// 
        /// <returns>Returns a  DisassociateLinkResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/DisassociateLink">REST API Reference for DisassociateLink Operation</seealso>
        public virtual DisassociateLinkResponse EndDisassociateLink(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateLinkResponse>(asyncResult);
        }

        #endregion
        
        #region  DisassociateTransitGatewayConnectPeer

        /// <summary>
        /// Disassociates a transit gateway Connect peer from a device and link.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the DisassociateTransitGatewayConnectPeer service method.</param>
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
        public virtual DisassociateTransitGatewayConnectPeerResponse DisassociateTransitGatewayConnectPeer(DisassociateTransitGatewayConnectPeerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateTransitGatewayConnectPeerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateTransitGatewayConnectPeerResponseUnmarshaller.Instance;

            return Invoke<DisassociateTransitGatewayConnectPeerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateTransitGatewayConnectPeer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the DisassociateTransitGatewayConnectPeer operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDisassociateTransitGatewayConnectPeer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/DisassociateTransitGatewayConnectPeer">REST API Reference for DisassociateTransitGatewayConnectPeer Operation</seealso>
        public virtual IAsyncResult BeginDisassociateTransitGatewayConnectPeer(DisassociateTransitGatewayConnectPeerRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = DisassociateTransitGatewayConnectPeerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = DisassociateTransitGatewayConnectPeerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  DisassociateTransitGatewayConnectPeer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateTransitGatewayConnectPeer.</param>
        /// 
        /// <returns>Returns a  DisassociateTransitGatewayConnectPeerResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/DisassociateTransitGatewayConnectPeer">REST API Reference for DisassociateTransitGatewayConnectPeer Operation</seealso>
        public virtual DisassociateTransitGatewayConnectPeerResponse EndDisassociateTransitGatewayConnectPeer(IAsyncResult asyncResult)
        {
            return EndInvoke<DisassociateTransitGatewayConnectPeerResponse>(asyncResult);
        }

        #endregion
        
        #region  ExecuteCoreNetworkChangeSet

        /// <summary>
        /// Executes a change set on your core network. Deploys changes globally based on the
        /// policy submitted..
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ExecuteCoreNetworkChangeSet service method.</param>
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
        public virtual ExecuteCoreNetworkChangeSetResponse ExecuteCoreNetworkChangeSet(ExecuteCoreNetworkChangeSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExecuteCoreNetworkChangeSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExecuteCoreNetworkChangeSetResponseUnmarshaller.Instance;

            return Invoke<ExecuteCoreNetworkChangeSetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ExecuteCoreNetworkChangeSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ExecuteCoreNetworkChangeSet operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndExecuteCoreNetworkChangeSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/ExecuteCoreNetworkChangeSet">REST API Reference for ExecuteCoreNetworkChangeSet Operation</seealso>
        public virtual IAsyncResult BeginExecuteCoreNetworkChangeSet(ExecuteCoreNetworkChangeSetRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ExecuteCoreNetworkChangeSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ExecuteCoreNetworkChangeSetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ExecuteCoreNetworkChangeSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginExecuteCoreNetworkChangeSet.</param>
        /// 
        /// <returns>Returns a  ExecuteCoreNetworkChangeSetResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/ExecuteCoreNetworkChangeSet">REST API Reference for ExecuteCoreNetworkChangeSet Operation</seealso>
        public virtual ExecuteCoreNetworkChangeSetResponse EndExecuteCoreNetworkChangeSet(IAsyncResult asyncResult)
        {
            return EndInvoke<ExecuteCoreNetworkChangeSetResponse>(asyncResult);
        }

        #endregion
        
        #region  GetConnectAttachment

        /// <summary>
        /// Returns information about a core network Connect attachment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConnectAttachment service method.</param>
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
        public virtual GetConnectAttachmentResponse GetConnectAttachment(GetConnectAttachmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetConnectAttachmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConnectAttachmentResponseUnmarshaller.Instance;

            return Invoke<GetConnectAttachmentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetConnectAttachment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetConnectAttachment operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetConnectAttachment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetConnectAttachment">REST API Reference for GetConnectAttachment Operation</seealso>
        public virtual IAsyncResult BeginGetConnectAttachment(GetConnectAttachmentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetConnectAttachmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConnectAttachmentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetConnectAttachment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetConnectAttachment.</param>
        /// 
        /// <returns>Returns a  GetConnectAttachmentResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetConnectAttachment">REST API Reference for GetConnectAttachment Operation</seealso>
        public virtual GetConnectAttachmentResponse EndGetConnectAttachment(IAsyncResult asyncResult)
        {
            return EndInvoke<GetConnectAttachmentResponse>(asyncResult);
        }

        #endregion
        
        #region  GetConnections

        /// <summary>
        /// Gets information about one or more of your connections in a global network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConnections service method.</param>
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
        public virtual GetConnectionsResponse GetConnections(GetConnectionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetConnectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConnectionsResponseUnmarshaller.Instance;

            return Invoke<GetConnectionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetConnections operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetConnections operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetConnections
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetConnections">REST API Reference for GetConnections Operation</seealso>
        public virtual IAsyncResult BeginGetConnections(GetConnectionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetConnectionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConnectionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetConnections operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetConnections.</param>
        /// 
        /// <returns>Returns a  GetConnectionsResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetConnections">REST API Reference for GetConnections Operation</seealso>
        public virtual GetConnectionsResponse EndGetConnections(IAsyncResult asyncResult)
        {
            return EndInvoke<GetConnectionsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetConnectPeer

        /// <summary>
        /// Returns information about a core network Connect peer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConnectPeer service method.</param>
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
        public virtual GetConnectPeerResponse GetConnectPeer(GetConnectPeerRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetConnectPeerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConnectPeerResponseUnmarshaller.Instance;

            return Invoke<GetConnectPeerResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetConnectPeer operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetConnectPeer operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetConnectPeer
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetConnectPeer">REST API Reference for GetConnectPeer Operation</seealso>
        public virtual IAsyncResult BeginGetConnectPeer(GetConnectPeerRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetConnectPeerRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConnectPeerResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetConnectPeer operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetConnectPeer.</param>
        /// 
        /// <returns>Returns a  GetConnectPeerResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetConnectPeer">REST API Reference for GetConnectPeer Operation</seealso>
        public virtual GetConnectPeerResponse EndGetConnectPeer(IAsyncResult asyncResult)
        {
            return EndInvoke<GetConnectPeerResponse>(asyncResult);
        }

        #endregion
        
        #region  GetConnectPeerAssociations

        /// <summary>
        /// Returns information about a core network Connect peer associations.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetConnectPeerAssociations service method.</param>
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
        public virtual GetConnectPeerAssociationsResponse GetConnectPeerAssociations(GetConnectPeerAssociationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetConnectPeerAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConnectPeerAssociationsResponseUnmarshaller.Instance;

            return Invoke<GetConnectPeerAssociationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetConnectPeerAssociations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetConnectPeerAssociations operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetConnectPeerAssociations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetConnectPeerAssociations">REST API Reference for GetConnectPeerAssociations Operation</seealso>
        public virtual IAsyncResult BeginGetConnectPeerAssociations(GetConnectPeerAssociationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetConnectPeerAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetConnectPeerAssociationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetConnectPeerAssociations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetConnectPeerAssociations.</param>
        /// 
        /// <returns>Returns a  GetConnectPeerAssociationsResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetConnectPeerAssociations">REST API Reference for GetConnectPeerAssociations Operation</seealso>
        public virtual GetConnectPeerAssociationsResponse EndGetConnectPeerAssociations(IAsyncResult asyncResult)
        {
            return EndInvoke<GetConnectPeerAssociationsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetCoreNetwork

        /// <summary>
        /// Returns information about the LIVE policy for a core network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCoreNetwork service method.</param>
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
        public virtual GetCoreNetworkResponse GetCoreNetwork(GetCoreNetworkRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCoreNetworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCoreNetworkResponseUnmarshaller.Instance;

            return Invoke<GetCoreNetworkResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetCoreNetwork operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCoreNetwork operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCoreNetwork
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetCoreNetwork">REST API Reference for GetCoreNetwork Operation</seealso>
        public virtual IAsyncResult BeginGetCoreNetwork(GetCoreNetworkRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCoreNetworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCoreNetworkResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetCoreNetwork operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCoreNetwork.</param>
        /// 
        /// <returns>Returns a  GetCoreNetworkResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetCoreNetwork">REST API Reference for GetCoreNetwork Operation</seealso>
        public virtual GetCoreNetworkResponse EndGetCoreNetwork(IAsyncResult asyncResult)
        {
            return EndInvoke<GetCoreNetworkResponse>(asyncResult);
        }

        #endregion
        
        #region  GetCoreNetworkChangeEvents

        /// <summary>
        /// Returns information about a core network change event.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCoreNetworkChangeEvents service method.</param>
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
        public virtual GetCoreNetworkChangeEventsResponse GetCoreNetworkChangeEvents(GetCoreNetworkChangeEventsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCoreNetworkChangeEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCoreNetworkChangeEventsResponseUnmarshaller.Instance;

            return Invoke<GetCoreNetworkChangeEventsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetCoreNetworkChangeEvents operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCoreNetworkChangeEvents operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCoreNetworkChangeEvents
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetCoreNetworkChangeEvents">REST API Reference for GetCoreNetworkChangeEvents Operation</seealso>
        public virtual IAsyncResult BeginGetCoreNetworkChangeEvents(GetCoreNetworkChangeEventsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCoreNetworkChangeEventsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCoreNetworkChangeEventsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetCoreNetworkChangeEvents operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCoreNetworkChangeEvents.</param>
        /// 
        /// <returns>Returns a  GetCoreNetworkChangeEventsResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetCoreNetworkChangeEvents">REST API Reference for GetCoreNetworkChangeEvents Operation</seealso>
        public virtual GetCoreNetworkChangeEventsResponse EndGetCoreNetworkChangeEvents(IAsyncResult asyncResult)
        {
            return EndInvoke<GetCoreNetworkChangeEventsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetCoreNetworkChangeSet

        /// <summary>
        /// Returns a change set between the LIVE core network policy and a submitted policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCoreNetworkChangeSet service method.</param>
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
        public virtual GetCoreNetworkChangeSetResponse GetCoreNetworkChangeSet(GetCoreNetworkChangeSetRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCoreNetworkChangeSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCoreNetworkChangeSetResponseUnmarshaller.Instance;

            return Invoke<GetCoreNetworkChangeSetResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetCoreNetworkChangeSet operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCoreNetworkChangeSet operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCoreNetworkChangeSet
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetCoreNetworkChangeSet">REST API Reference for GetCoreNetworkChangeSet Operation</seealso>
        public virtual IAsyncResult BeginGetCoreNetworkChangeSet(GetCoreNetworkChangeSetRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCoreNetworkChangeSetRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCoreNetworkChangeSetResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetCoreNetworkChangeSet operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCoreNetworkChangeSet.</param>
        /// 
        /// <returns>Returns a  GetCoreNetworkChangeSetResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetCoreNetworkChangeSet">REST API Reference for GetCoreNetworkChangeSet Operation</seealso>
        public virtual GetCoreNetworkChangeSetResponse EndGetCoreNetworkChangeSet(IAsyncResult asyncResult)
        {
            return EndInvoke<GetCoreNetworkChangeSetResponse>(asyncResult);
        }

        #endregion
        
        #region  GetCoreNetworkPolicy

        /// <summary>
        /// Returns details about a core network policy. You can get details about your current
        /// live policy or any previous policy version.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCoreNetworkPolicy service method.</param>
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
        public virtual GetCoreNetworkPolicyResponse GetCoreNetworkPolicy(GetCoreNetworkPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCoreNetworkPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCoreNetworkPolicyResponseUnmarshaller.Instance;

            return Invoke<GetCoreNetworkPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetCoreNetworkPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCoreNetworkPolicy operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCoreNetworkPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetCoreNetworkPolicy">REST API Reference for GetCoreNetworkPolicy Operation</seealso>
        public virtual IAsyncResult BeginGetCoreNetworkPolicy(GetCoreNetworkPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCoreNetworkPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCoreNetworkPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetCoreNetworkPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCoreNetworkPolicy.</param>
        /// 
        /// <returns>Returns a  GetCoreNetworkPolicyResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetCoreNetworkPolicy">REST API Reference for GetCoreNetworkPolicy Operation</seealso>
        public virtual GetCoreNetworkPolicyResponse EndGetCoreNetworkPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<GetCoreNetworkPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  GetCustomerGatewayAssociations

        /// <summary>
        /// Gets the association information for customer gateways that are associated with devices
        /// and links in your global network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetCustomerGatewayAssociations service method.</param>
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
        public virtual GetCustomerGatewayAssociationsResponse GetCustomerGatewayAssociations(GetCustomerGatewayAssociationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCustomerGatewayAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCustomerGatewayAssociationsResponseUnmarshaller.Instance;

            return Invoke<GetCustomerGatewayAssociationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetCustomerGatewayAssociations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetCustomerGatewayAssociations operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetCustomerGatewayAssociations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetCustomerGatewayAssociations">REST API Reference for GetCustomerGatewayAssociations Operation</seealso>
        public virtual IAsyncResult BeginGetCustomerGatewayAssociations(GetCustomerGatewayAssociationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetCustomerGatewayAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetCustomerGatewayAssociationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetCustomerGatewayAssociations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetCustomerGatewayAssociations.</param>
        /// 
        /// <returns>Returns a  GetCustomerGatewayAssociationsResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetCustomerGatewayAssociations">REST API Reference for GetCustomerGatewayAssociations Operation</seealso>
        public virtual GetCustomerGatewayAssociationsResponse EndGetCustomerGatewayAssociations(IAsyncResult asyncResult)
        {
            return EndInvoke<GetCustomerGatewayAssociationsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetDevices

        /// <summary>
        /// Gets information about one or more of your devices in a global network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetDevices service method.</param>
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
        public virtual GetDevicesResponse GetDevices(GetDevicesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDevicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDevicesResponseUnmarshaller.Instance;

            return Invoke<GetDevicesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetDevices operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetDevices operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetDevices
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetDevices">REST API Reference for GetDevices Operation</seealso>
        public virtual IAsyncResult BeginGetDevices(GetDevicesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetDevicesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetDevicesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetDevices operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetDevices.</param>
        /// 
        /// <returns>Returns a  GetDevicesResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetDevices">REST API Reference for GetDevices Operation</seealso>
        public virtual GetDevicesResponse EndGetDevices(IAsyncResult asyncResult)
        {
            return EndInvoke<GetDevicesResponse>(asyncResult);
        }

        #endregion
        
        #region  GetLinkAssociations

        /// <summary>
        /// Gets the link associations for a device or a link. Either the device ID or the link
        /// ID must be specified.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetLinkAssociations service method.</param>
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
        public virtual GetLinkAssociationsResponse GetLinkAssociations(GetLinkAssociationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLinkAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLinkAssociationsResponseUnmarshaller.Instance;

            return Invoke<GetLinkAssociationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetLinkAssociations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLinkAssociations operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetLinkAssociations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetLinkAssociations">REST API Reference for GetLinkAssociations Operation</seealso>
        public virtual IAsyncResult BeginGetLinkAssociations(GetLinkAssociationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLinkAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLinkAssociationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetLinkAssociations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetLinkAssociations.</param>
        /// 
        /// <returns>Returns a  GetLinkAssociationsResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetLinkAssociations">REST API Reference for GetLinkAssociations Operation</seealso>
        public virtual GetLinkAssociationsResponse EndGetLinkAssociations(IAsyncResult asyncResult)
        {
            return EndInvoke<GetLinkAssociationsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetLinks

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
        public virtual GetLinksResponse GetLinks(GetLinksRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLinksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLinksResponseUnmarshaller.Instance;

            return Invoke<GetLinksResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetLinks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetLinks operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetLinks
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetLinks">REST API Reference for GetLinks Operation</seealso>
        public virtual IAsyncResult BeginGetLinks(GetLinksRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetLinksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetLinksResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetLinks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetLinks.</param>
        /// 
        /// <returns>Returns a  GetLinksResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetLinks">REST API Reference for GetLinks Operation</seealso>
        public virtual GetLinksResponse EndGetLinks(IAsyncResult asyncResult)
        {
            return EndInvoke<GetLinksResponse>(asyncResult);
        }

        #endregion
        
        #region  GetNetworkResourceCounts

        /// <summary>
        /// Gets the count of network resources, by resource type, for the specified global network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNetworkResourceCounts service method.</param>
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
        public virtual GetNetworkResourceCountsResponse GetNetworkResourceCounts(GetNetworkResourceCountsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetNetworkResourceCountsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetNetworkResourceCountsResponseUnmarshaller.Instance;

            return Invoke<GetNetworkResourceCountsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetNetworkResourceCounts operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetNetworkResourceCounts operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetNetworkResourceCounts
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetNetworkResourceCounts">REST API Reference for GetNetworkResourceCounts Operation</seealso>
        public virtual IAsyncResult BeginGetNetworkResourceCounts(GetNetworkResourceCountsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetNetworkResourceCountsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetNetworkResourceCountsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetNetworkResourceCounts operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetNetworkResourceCounts.</param>
        /// 
        /// <returns>Returns a  GetNetworkResourceCountsResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetNetworkResourceCounts">REST API Reference for GetNetworkResourceCounts Operation</seealso>
        public virtual GetNetworkResourceCountsResponse EndGetNetworkResourceCounts(IAsyncResult asyncResult)
        {
            return EndInvoke<GetNetworkResourceCountsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetNetworkResourceRelationships

        /// <summary>
        /// Gets the network resource relationships for the specified global network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNetworkResourceRelationships service method.</param>
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
        public virtual GetNetworkResourceRelationshipsResponse GetNetworkResourceRelationships(GetNetworkResourceRelationshipsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetNetworkResourceRelationshipsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetNetworkResourceRelationshipsResponseUnmarshaller.Instance;

            return Invoke<GetNetworkResourceRelationshipsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetNetworkResourceRelationships operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetNetworkResourceRelationships operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetNetworkResourceRelationships
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetNetworkResourceRelationships">REST API Reference for GetNetworkResourceRelationships Operation</seealso>
        public virtual IAsyncResult BeginGetNetworkResourceRelationships(GetNetworkResourceRelationshipsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetNetworkResourceRelationshipsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetNetworkResourceRelationshipsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetNetworkResourceRelationships operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetNetworkResourceRelationships.</param>
        /// 
        /// <returns>Returns a  GetNetworkResourceRelationshipsResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetNetworkResourceRelationships">REST API Reference for GetNetworkResourceRelationships Operation</seealso>
        public virtual GetNetworkResourceRelationshipsResponse EndGetNetworkResourceRelationships(IAsyncResult asyncResult)
        {
            return EndInvoke<GetNetworkResourceRelationshipsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetNetworkResources

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
        public virtual GetNetworkResourcesResponse GetNetworkResources(GetNetworkResourcesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetNetworkResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetNetworkResourcesResponseUnmarshaller.Instance;

            return Invoke<GetNetworkResourcesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetNetworkResources operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetNetworkResources operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetNetworkResources
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetNetworkResources">REST API Reference for GetNetworkResources Operation</seealso>
        public virtual IAsyncResult BeginGetNetworkResources(GetNetworkResourcesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetNetworkResourcesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetNetworkResourcesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetNetworkResources operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetNetworkResources.</param>
        /// 
        /// <returns>Returns a  GetNetworkResourcesResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetNetworkResources">REST API Reference for GetNetworkResources Operation</seealso>
        public virtual GetNetworkResourcesResponse EndGetNetworkResources(IAsyncResult asyncResult)
        {
            return EndInvoke<GetNetworkResourcesResponse>(asyncResult);
        }

        #endregion
        
        #region  GetNetworkRoutes

        /// <summary>
        /// Gets the network routes of the specified global network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNetworkRoutes service method.</param>
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
        public virtual GetNetworkRoutesResponse GetNetworkRoutes(GetNetworkRoutesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetNetworkRoutesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetNetworkRoutesResponseUnmarshaller.Instance;

            return Invoke<GetNetworkRoutesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetNetworkRoutes operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetNetworkRoutes operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetNetworkRoutes
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetNetworkRoutes">REST API Reference for GetNetworkRoutes Operation</seealso>
        public virtual IAsyncResult BeginGetNetworkRoutes(GetNetworkRoutesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetNetworkRoutesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetNetworkRoutesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetNetworkRoutes operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetNetworkRoutes.</param>
        /// 
        /// <returns>Returns a  GetNetworkRoutesResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetNetworkRoutes">REST API Reference for GetNetworkRoutes Operation</seealso>
        public virtual GetNetworkRoutesResponse EndGetNetworkRoutes(IAsyncResult asyncResult)
        {
            return EndInvoke<GetNetworkRoutesResponse>(asyncResult);
        }

        #endregion
        
        #region  GetNetworkTelemetry

        /// <summary>
        /// Gets the network telemetry of the specified global network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetNetworkTelemetry service method.</param>
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
        public virtual GetNetworkTelemetryResponse GetNetworkTelemetry(GetNetworkTelemetryRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetNetworkTelemetryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetNetworkTelemetryResponseUnmarshaller.Instance;

            return Invoke<GetNetworkTelemetryResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetNetworkTelemetry operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetNetworkTelemetry operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetNetworkTelemetry
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetNetworkTelemetry">REST API Reference for GetNetworkTelemetry Operation</seealso>
        public virtual IAsyncResult BeginGetNetworkTelemetry(GetNetworkTelemetryRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetNetworkTelemetryRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetNetworkTelemetryResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetNetworkTelemetry operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetNetworkTelemetry.</param>
        /// 
        /// <returns>Returns a  GetNetworkTelemetryResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetNetworkTelemetry">REST API Reference for GetNetworkTelemetry Operation</seealso>
        public virtual GetNetworkTelemetryResponse EndGetNetworkTelemetry(IAsyncResult asyncResult)
        {
            return EndInvoke<GetNetworkTelemetryResponse>(asyncResult);
        }

        #endregion
        
        #region  GetResourcePolicy

        /// <summary>
        /// Returns information about a resource policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePolicy service method.</param>
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
        public virtual GetResourcePolicyResponse GetResourcePolicy(GetResourcePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourcePolicyResponseUnmarshaller.Instance;

            return Invoke<GetResourcePolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetResourcePolicy operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetResourcePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetResourcePolicy">REST API Reference for GetResourcePolicy Operation</seealso>
        public virtual IAsyncResult BeginGetResourcePolicy(GetResourcePolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetResourcePolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetResourcePolicy.</param>
        /// 
        /// <returns>Returns a  GetResourcePolicyResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetResourcePolicy">REST API Reference for GetResourcePolicy Operation</seealso>
        public virtual GetResourcePolicyResponse EndGetResourcePolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<GetResourcePolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  GetRouteAnalysis

        /// <summary>
        /// Gets information about the specified route analysis.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetRouteAnalysis service method.</param>
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
        public virtual GetRouteAnalysisResponse GetRouteAnalysis(GetRouteAnalysisRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRouteAnalysisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRouteAnalysisResponseUnmarshaller.Instance;

            return Invoke<GetRouteAnalysisResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetRouteAnalysis operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetRouteAnalysis operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetRouteAnalysis
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetRouteAnalysis">REST API Reference for GetRouteAnalysis Operation</seealso>
        public virtual IAsyncResult BeginGetRouteAnalysis(GetRouteAnalysisRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetRouteAnalysisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetRouteAnalysisResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetRouteAnalysis operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetRouteAnalysis.</param>
        /// 
        /// <returns>Returns a  GetRouteAnalysisResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetRouteAnalysis">REST API Reference for GetRouteAnalysis Operation</seealso>
        public virtual GetRouteAnalysisResponse EndGetRouteAnalysis(IAsyncResult asyncResult)
        {
            return EndInvoke<GetRouteAnalysisResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSites

        /// <summary>
        /// Gets information about one or more of your sites in a global network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSites service method.</param>
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
        public virtual GetSitesResponse GetSites(GetSitesRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSitesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSitesResponseUnmarshaller.Instance;

            return Invoke<GetSitesResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSites operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSites operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSites
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetSites">REST API Reference for GetSites Operation</seealso>
        public virtual IAsyncResult BeginGetSites(GetSitesRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSitesRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSitesResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSites operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSites.</param>
        /// 
        /// <returns>Returns a  GetSitesResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetSites">REST API Reference for GetSites Operation</seealso>
        public virtual GetSitesResponse EndGetSites(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSitesResponse>(asyncResult);
        }

        #endregion
        
        #region  GetSiteToSiteVpnAttachment

        /// <summary>
        /// Returns information about a site-to-site VPN attachment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetSiteToSiteVpnAttachment service method.</param>
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
        public virtual GetSiteToSiteVpnAttachmentResponse GetSiteToSiteVpnAttachment(GetSiteToSiteVpnAttachmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSiteToSiteVpnAttachmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSiteToSiteVpnAttachmentResponseUnmarshaller.Instance;

            return Invoke<GetSiteToSiteVpnAttachmentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetSiteToSiteVpnAttachment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetSiteToSiteVpnAttachment operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetSiteToSiteVpnAttachment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetSiteToSiteVpnAttachment">REST API Reference for GetSiteToSiteVpnAttachment Operation</seealso>
        public virtual IAsyncResult BeginGetSiteToSiteVpnAttachment(GetSiteToSiteVpnAttachmentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetSiteToSiteVpnAttachmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetSiteToSiteVpnAttachmentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetSiteToSiteVpnAttachment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetSiteToSiteVpnAttachment.</param>
        /// 
        /// <returns>Returns a  GetSiteToSiteVpnAttachmentResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetSiteToSiteVpnAttachment">REST API Reference for GetSiteToSiteVpnAttachment Operation</seealso>
        public virtual GetSiteToSiteVpnAttachmentResponse EndGetSiteToSiteVpnAttachment(IAsyncResult asyncResult)
        {
            return EndInvoke<GetSiteToSiteVpnAttachmentResponse>(asyncResult);
        }

        #endregion
        
        #region  GetTransitGatewayConnectPeerAssociations

        /// <summary>
        /// Gets information about one or more of your transit gateway Connect peer associations
        /// in a global network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTransitGatewayConnectPeerAssociations service method.</param>
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
        public virtual GetTransitGatewayConnectPeerAssociationsResponse GetTransitGatewayConnectPeerAssociations(GetTransitGatewayConnectPeerAssociationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTransitGatewayConnectPeerAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTransitGatewayConnectPeerAssociationsResponseUnmarshaller.Instance;

            return Invoke<GetTransitGatewayConnectPeerAssociationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetTransitGatewayConnectPeerAssociations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTransitGatewayConnectPeerAssociations operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTransitGatewayConnectPeerAssociations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetTransitGatewayConnectPeerAssociations">REST API Reference for GetTransitGatewayConnectPeerAssociations Operation</seealso>
        public virtual IAsyncResult BeginGetTransitGatewayConnectPeerAssociations(GetTransitGatewayConnectPeerAssociationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTransitGatewayConnectPeerAssociationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTransitGatewayConnectPeerAssociationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetTransitGatewayConnectPeerAssociations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTransitGatewayConnectPeerAssociations.</param>
        /// 
        /// <returns>Returns a  GetTransitGatewayConnectPeerAssociationsResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetTransitGatewayConnectPeerAssociations">REST API Reference for GetTransitGatewayConnectPeerAssociations Operation</seealso>
        public virtual GetTransitGatewayConnectPeerAssociationsResponse EndGetTransitGatewayConnectPeerAssociations(IAsyncResult asyncResult)
        {
            return EndInvoke<GetTransitGatewayConnectPeerAssociationsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetTransitGatewayPeering

        /// <summary>
        /// Returns information about a transit gateway peer.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTransitGatewayPeering service method.</param>
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
        public virtual GetTransitGatewayPeeringResponse GetTransitGatewayPeering(GetTransitGatewayPeeringRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTransitGatewayPeeringRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTransitGatewayPeeringResponseUnmarshaller.Instance;

            return Invoke<GetTransitGatewayPeeringResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetTransitGatewayPeering operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTransitGatewayPeering operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTransitGatewayPeering
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetTransitGatewayPeering">REST API Reference for GetTransitGatewayPeering Operation</seealso>
        public virtual IAsyncResult BeginGetTransitGatewayPeering(GetTransitGatewayPeeringRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTransitGatewayPeeringRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTransitGatewayPeeringResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetTransitGatewayPeering operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTransitGatewayPeering.</param>
        /// 
        /// <returns>Returns a  GetTransitGatewayPeeringResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetTransitGatewayPeering">REST API Reference for GetTransitGatewayPeering Operation</seealso>
        public virtual GetTransitGatewayPeeringResponse EndGetTransitGatewayPeering(IAsyncResult asyncResult)
        {
            return EndInvoke<GetTransitGatewayPeeringResponse>(asyncResult);
        }

        #endregion
        
        #region  GetTransitGatewayRegistrations

        /// <summary>
        /// Gets information about the transit gateway registrations in a specified global network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTransitGatewayRegistrations service method.</param>
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
        public virtual GetTransitGatewayRegistrationsResponse GetTransitGatewayRegistrations(GetTransitGatewayRegistrationsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTransitGatewayRegistrationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTransitGatewayRegistrationsResponseUnmarshaller.Instance;

            return Invoke<GetTransitGatewayRegistrationsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetTransitGatewayRegistrations operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTransitGatewayRegistrations operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTransitGatewayRegistrations
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetTransitGatewayRegistrations">REST API Reference for GetTransitGatewayRegistrations Operation</seealso>
        public virtual IAsyncResult BeginGetTransitGatewayRegistrations(GetTransitGatewayRegistrationsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTransitGatewayRegistrationsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTransitGatewayRegistrationsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetTransitGatewayRegistrations operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTransitGatewayRegistrations.</param>
        /// 
        /// <returns>Returns a  GetTransitGatewayRegistrationsResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetTransitGatewayRegistrations">REST API Reference for GetTransitGatewayRegistrations Operation</seealso>
        public virtual GetTransitGatewayRegistrationsResponse EndGetTransitGatewayRegistrations(IAsyncResult asyncResult)
        {
            return EndInvoke<GetTransitGatewayRegistrationsResponse>(asyncResult);
        }

        #endregion
        
        #region  GetTransitGatewayRouteTableAttachment

        /// <summary>
        /// Returns information about a transit gateway route table attachment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetTransitGatewayRouteTableAttachment service method.</param>
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
        public virtual GetTransitGatewayRouteTableAttachmentResponse GetTransitGatewayRouteTableAttachment(GetTransitGatewayRouteTableAttachmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTransitGatewayRouteTableAttachmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTransitGatewayRouteTableAttachmentResponseUnmarshaller.Instance;

            return Invoke<GetTransitGatewayRouteTableAttachmentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetTransitGatewayRouteTableAttachment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetTransitGatewayRouteTableAttachment operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetTransitGatewayRouteTableAttachment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetTransitGatewayRouteTableAttachment">REST API Reference for GetTransitGatewayRouteTableAttachment Operation</seealso>
        public virtual IAsyncResult BeginGetTransitGatewayRouteTableAttachment(GetTransitGatewayRouteTableAttachmentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetTransitGatewayRouteTableAttachmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetTransitGatewayRouteTableAttachmentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetTransitGatewayRouteTableAttachment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetTransitGatewayRouteTableAttachment.</param>
        /// 
        /// <returns>Returns a  GetTransitGatewayRouteTableAttachmentResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetTransitGatewayRouteTableAttachment">REST API Reference for GetTransitGatewayRouteTableAttachment Operation</seealso>
        public virtual GetTransitGatewayRouteTableAttachmentResponse EndGetTransitGatewayRouteTableAttachment(IAsyncResult asyncResult)
        {
            return EndInvoke<GetTransitGatewayRouteTableAttachmentResponse>(asyncResult);
        }

        #endregion
        
        #region  GetVpcAttachment

        /// <summary>
        /// Returns information about a VPC attachment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the GetVpcAttachment service method.</param>
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
        public virtual GetVpcAttachmentResponse GetVpcAttachment(GetVpcAttachmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVpcAttachmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVpcAttachmentResponseUnmarshaller.Instance;

            return Invoke<GetVpcAttachmentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the GetVpcAttachment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the GetVpcAttachment operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetVpcAttachment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetVpcAttachment">REST API Reference for GetVpcAttachment Operation</seealso>
        public virtual IAsyncResult BeginGetVpcAttachment(GetVpcAttachmentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = GetVpcAttachmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = GetVpcAttachmentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  GetVpcAttachment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetVpcAttachment.</param>
        /// 
        /// <returns>Returns a  GetVpcAttachmentResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/GetVpcAttachment">REST API Reference for GetVpcAttachment Operation</seealso>
        public virtual GetVpcAttachmentResponse EndGetVpcAttachment(IAsyncResult asyncResult)
        {
            return EndInvoke<GetVpcAttachmentResponse>(asyncResult);
        }

        #endregion
        
        #region  ListAttachments

        /// <summary>
        /// Returns a list of core network attachments.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListAttachments service method.</param>
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
        public virtual ListAttachmentsResponse ListAttachments(ListAttachmentsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAttachmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAttachmentsResponseUnmarshaller.Instance;

            return Invoke<ListAttachmentsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListAttachments operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListAttachments operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListAttachments
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/ListAttachments">REST API Reference for ListAttachments Operation</seealso>
        public virtual IAsyncResult BeginListAttachments(ListAttachmentsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListAttachmentsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListAttachmentsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListAttachments operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListAttachments.</param>
        /// 
        /// <returns>Returns a  ListAttachmentsResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/ListAttachments">REST API Reference for ListAttachments Operation</seealso>
        public virtual ListAttachmentsResponse EndListAttachments(IAsyncResult asyncResult)
        {
            return EndInvoke<ListAttachmentsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListConnectPeers

        /// <summary>
        /// Returns a list of core network Connect peers.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListConnectPeers service method.</param>
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
        public virtual ListConnectPeersResponse ListConnectPeers(ListConnectPeersRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListConnectPeersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConnectPeersResponseUnmarshaller.Instance;

            return Invoke<ListConnectPeersResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListConnectPeers operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListConnectPeers operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListConnectPeers
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/ListConnectPeers">REST API Reference for ListConnectPeers Operation</seealso>
        public virtual IAsyncResult BeginListConnectPeers(ListConnectPeersRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListConnectPeersRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListConnectPeersResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListConnectPeers operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListConnectPeers.</param>
        /// 
        /// <returns>Returns a  ListConnectPeersResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/ListConnectPeers">REST API Reference for ListConnectPeers Operation</seealso>
        public virtual ListConnectPeersResponse EndListConnectPeers(IAsyncResult asyncResult)
        {
            return EndInvoke<ListConnectPeersResponse>(asyncResult);
        }

        #endregion
        
        #region  ListCoreNetworkPolicyVersions

        /// <summary>
        /// Returns a list of core network policy versions.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCoreNetworkPolicyVersions service method.</param>
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
        public virtual ListCoreNetworkPolicyVersionsResponse ListCoreNetworkPolicyVersions(ListCoreNetworkPolicyVersionsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCoreNetworkPolicyVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCoreNetworkPolicyVersionsResponseUnmarshaller.Instance;

            return Invoke<ListCoreNetworkPolicyVersionsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListCoreNetworkPolicyVersions operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCoreNetworkPolicyVersions operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCoreNetworkPolicyVersions
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/ListCoreNetworkPolicyVersions">REST API Reference for ListCoreNetworkPolicyVersions Operation</seealso>
        public virtual IAsyncResult BeginListCoreNetworkPolicyVersions(ListCoreNetworkPolicyVersionsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCoreNetworkPolicyVersionsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCoreNetworkPolicyVersionsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListCoreNetworkPolicyVersions operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCoreNetworkPolicyVersions.</param>
        /// 
        /// <returns>Returns a  ListCoreNetworkPolicyVersionsResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/ListCoreNetworkPolicyVersions">REST API Reference for ListCoreNetworkPolicyVersions Operation</seealso>
        public virtual ListCoreNetworkPolicyVersionsResponse EndListCoreNetworkPolicyVersions(IAsyncResult asyncResult)
        {
            return EndInvoke<ListCoreNetworkPolicyVersionsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListCoreNetworks

        /// <summary>
        /// Returns a list of owned and shared core networks.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListCoreNetworks service method.</param>
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
        public virtual ListCoreNetworksResponse ListCoreNetworks(ListCoreNetworksRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCoreNetworksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCoreNetworksResponseUnmarshaller.Instance;

            return Invoke<ListCoreNetworksResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListCoreNetworks operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListCoreNetworks operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListCoreNetworks
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/ListCoreNetworks">REST API Reference for ListCoreNetworks Operation</seealso>
        public virtual IAsyncResult BeginListCoreNetworks(ListCoreNetworksRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListCoreNetworksRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListCoreNetworksResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListCoreNetworks operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListCoreNetworks.</param>
        /// 
        /// <returns>Returns a  ListCoreNetworksResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/ListCoreNetworks">REST API Reference for ListCoreNetworks Operation</seealso>
        public virtual ListCoreNetworksResponse EndListCoreNetworks(IAsyncResult asyncResult)
        {
            return EndInvoke<ListCoreNetworksResponse>(asyncResult);
        }

        #endregion
        
        #region  ListOrganizationServiceAccessStatus

        /// <summary>
        /// Gets the status of the Service Linked Role (SLR) deployment for the accounts in a
        /// given Amazon Web Services Organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListOrganizationServiceAccessStatus service method.</param>
        /// 
        /// <returns>The response from the ListOrganizationServiceAccessStatus service method, as returned by NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/ListOrganizationServiceAccessStatus">REST API Reference for ListOrganizationServiceAccessStatus Operation</seealso>
        public virtual ListOrganizationServiceAccessStatusResponse ListOrganizationServiceAccessStatus(ListOrganizationServiceAccessStatusRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListOrganizationServiceAccessStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOrganizationServiceAccessStatusResponseUnmarshaller.Instance;

            return Invoke<ListOrganizationServiceAccessStatusResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListOrganizationServiceAccessStatus operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListOrganizationServiceAccessStatus operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListOrganizationServiceAccessStatus
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/ListOrganizationServiceAccessStatus">REST API Reference for ListOrganizationServiceAccessStatus Operation</seealso>
        public virtual IAsyncResult BeginListOrganizationServiceAccessStatus(ListOrganizationServiceAccessStatusRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListOrganizationServiceAccessStatusRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListOrganizationServiceAccessStatusResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListOrganizationServiceAccessStatus operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListOrganizationServiceAccessStatus.</param>
        /// 
        /// <returns>Returns a  ListOrganizationServiceAccessStatusResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/ListOrganizationServiceAccessStatus">REST API Reference for ListOrganizationServiceAccessStatus Operation</seealso>
        public virtual ListOrganizationServiceAccessStatusResponse EndListOrganizationServiceAccessStatus(IAsyncResult asyncResult)
        {
            return EndInvoke<ListOrganizationServiceAccessStatusResponse>(asyncResult);
        }

        #endregion
        
        #region  ListPeerings

        /// <summary>
        /// Lists the peerings for a core network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListPeerings service method.</param>
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
        public virtual ListPeeringsResponse ListPeerings(ListPeeringsRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPeeringsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPeeringsResponseUnmarshaller.Instance;

            return Invoke<ListPeeringsResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListPeerings operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListPeerings operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListPeerings
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/ListPeerings">REST API Reference for ListPeerings Operation</seealso>
        public virtual IAsyncResult BeginListPeerings(ListPeeringsRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListPeeringsRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListPeeringsResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListPeerings operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListPeerings.</param>
        /// 
        /// <returns>Returns a  ListPeeringsResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/ListPeerings">REST API Reference for ListPeerings Operation</seealso>
        public virtual ListPeeringsResponse EndListPeerings(IAsyncResult asyncResult)
        {
            return EndInvoke<ListPeeringsResponse>(asyncResult);
        }

        #endregion
        
        #region  ListTagsForResource

        /// <summary>
        /// Lists the tags for a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource service method.</param>
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
        public virtual ListTagsForResourceResponse ListTagsForResource(ListTagsForResourceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return Invoke<ListTagsForResourceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the ListTagsForResource operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndListTagsForResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual IAsyncResult BeginListTagsForResource(ListTagsForResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = ListTagsForResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = ListTagsForResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  ListTagsForResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginListTagsForResource.</param>
        /// 
        /// <returns>Returns a  ListTagsForResourceResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/ListTagsForResource">REST API Reference for ListTagsForResource Operation</seealso>
        public virtual ListTagsForResourceResponse EndListTagsForResource(IAsyncResult asyncResult)
        {
            return EndInvoke<ListTagsForResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  PutCoreNetworkPolicy

        /// <summary>
        /// Creates a new, immutable version of a core network policy. A subsequent change set
        /// is created showing the differences between the LIVE policy and the submitted policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutCoreNetworkPolicy service method.</param>
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
        public virtual PutCoreNetworkPolicyResponse PutCoreNetworkPolicy(PutCoreNetworkPolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutCoreNetworkPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutCoreNetworkPolicyResponseUnmarshaller.Instance;

            return Invoke<PutCoreNetworkPolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutCoreNetworkPolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutCoreNetworkPolicy operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutCoreNetworkPolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/PutCoreNetworkPolicy">REST API Reference for PutCoreNetworkPolicy Operation</seealso>
        public virtual IAsyncResult BeginPutCoreNetworkPolicy(PutCoreNetworkPolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutCoreNetworkPolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutCoreNetworkPolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutCoreNetworkPolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutCoreNetworkPolicy.</param>
        /// 
        /// <returns>Returns a  PutCoreNetworkPolicyResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/PutCoreNetworkPolicy">REST API Reference for PutCoreNetworkPolicy Operation</seealso>
        public virtual PutCoreNetworkPolicyResponse EndPutCoreNetworkPolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<PutCoreNetworkPolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  PutResourcePolicy

        /// <summary>
        /// Creates or updates a resource policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePolicy service method.</param>
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
        public virtual PutResourcePolicyResponse PutResourcePolicy(PutResourcePolicyRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutResourcePolicyResponseUnmarshaller.Instance;

            return Invoke<PutResourcePolicyResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the PutResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the PutResourcePolicy operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndPutResourcePolicy
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        public virtual IAsyncResult BeginPutResourcePolicy(PutResourcePolicyRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = PutResourcePolicyRequestMarshaller.Instance;
            options.ResponseUnmarshaller = PutResourcePolicyResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  PutResourcePolicy operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPutResourcePolicy.</param>
        /// 
        /// <returns>Returns a  PutResourcePolicyResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/PutResourcePolicy">REST API Reference for PutResourcePolicy Operation</seealso>
        public virtual PutResourcePolicyResponse EndPutResourcePolicy(IAsyncResult asyncResult)
        {
            return EndInvoke<PutResourcePolicyResponse>(asyncResult);
        }

        #endregion
        
        #region  RegisterTransitGateway

        /// <summary>
        /// Registers a transit gateway in your global network. The transit gateway can be in
        /// any Amazon Web Services Region, but it must be owned by the same Amazon Web Services
        /// account that owns the global network. You cannot register a transit gateway in more
        /// than one global network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RegisterTransitGateway service method.</param>
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
        public virtual RegisterTransitGatewayResponse RegisterTransitGateway(RegisterTransitGatewayRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterTransitGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterTransitGatewayResponseUnmarshaller.Instance;

            return Invoke<RegisterTransitGatewayResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterTransitGateway operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RegisterTransitGateway operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegisterTransitGateway
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/RegisterTransitGateway">REST API Reference for RegisterTransitGateway Operation</seealso>
        public virtual IAsyncResult BeginRegisterTransitGateway(RegisterTransitGatewayRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RegisterTransitGatewayRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RegisterTransitGatewayResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RegisterTransitGateway operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterTransitGateway.</param>
        /// 
        /// <returns>Returns a  RegisterTransitGatewayResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/RegisterTransitGateway">REST API Reference for RegisterTransitGateway Operation</seealso>
        public virtual RegisterTransitGatewayResponse EndRegisterTransitGateway(IAsyncResult asyncResult)
        {
            return EndInvoke<RegisterTransitGatewayResponse>(asyncResult);
        }

        #endregion
        
        #region  RejectAttachment

        /// <summary>
        /// Rejects a core network attachment request.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RejectAttachment service method.</param>
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
        public virtual RejectAttachmentResponse RejectAttachment(RejectAttachmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RejectAttachmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RejectAttachmentResponseUnmarshaller.Instance;

            return Invoke<RejectAttachmentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RejectAttachment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RejectAttachment operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRejectAttachment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/RejectAttachment">REST API Reference for RejectAttachment Operation</seealso>
        public virtual IAsyncResult BeginRejectAttachment(RejectAttachmentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RejectAttachmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RejectAttachmentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RejectAttachment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRejectAttachment.</param>
        /// 
        /// <returns>Returns a  RejectAttachmentResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/RejectAttachment">REST API Reference for RejectAttachment Operation</seealso>
        public virtual RejectAttachmentResponse EndRejectAttachment(IAsyncResult asyncResult)
        {
            return EndInvoke<RejectAttachmentResponse>(asyncResult);
        }

        #endregion
        
        #region  RestoreCoreNetworkPolicyVersion

        /// <summary>
        /// Restores a previous policy version as a new, immutable version of a core network policy.
        /// A subsequent change set is created showing the differences between the LIVE policy
        /// and restored policy.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the RestoreCoreNetworkPolicyVersion service method.</param>
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
        public virtual RestoreCoreNetworkPolicyVersionResponse RestoreCoreNetworkPolicyVersion(RestoreCoreNetworkPolicyVersionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RestoreCoreNetworkPolicyVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreCoreNetworkPolicyVersionResponseUnmarshaller.Instance;

            return Invoke<RestoreCoreNetworkPolicyVersionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the RestoreCoreNetworkPolicyVersion operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the RestoreCoreNetworkPolicyVersion operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRestoreCoreNetworkPolicyVersion
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/RestoreCoreNetworkPolicyVersion">REST API Reference for RestoreCoreNetworkPolicyVersion Operation</seealso>
        public virtual IAsyncResult BeginRestoreCoreNetworkPolicyVersion(RestoreCoreNetworkPolicyVersionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = RestoreCoreNetworkPolicyVersionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = RestoreCoreNetworkPolicyVersionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  RestoreCoreNetworkPolicyVersion operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRestoreCoreNetworkPolicyVersion.</param>
        /// 
        /// <returns>Returns a  RestoreCoreNetworkPolicyVersionResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/RestoreCoreNetworkPolicyVersion">REST API Reference for RestoreCoreNetworkPolicyVersion Operation</seealso>
        public virtual RestoreCoreNetworkPolicyVersionResponse EndRestoreCoreNetworkPolicyVersion(IAsyncResult asyncResult)
        {
            return EndInvoke<RestoreCoreNetworkPolicyVersionResponse>(asyncResult);
        }

        #endregion
        
        #region  StartOrganizationServiceAccessUpdate

        /// <summary>
        /// Enables the Network Manager service for an Amazon Web Services Organization. This
        /// can only be called by a management account within the organization.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartOrganizationServiceAccessUpdate service method.</param>
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
        public virtual StartOrganizationServiceAccessUpdateResponse StartOrganizationServiceAccessUpdate(StartOrganizationServiceAccessUpdateRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartOrganizationServiceAccessUpdateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartOrganizationServiceAccessUpdateResponseUnmarshaller.Instance;

            return Invoke<StartOrganizationServiceAccessUpdateResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartOrganizationServiceAccessUpdate operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartOrganizationServiceAccessUpdate operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartOrganizationServiceAccessUpdate
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/StartOrganizationServiceAccessUpdate">REST API Reference for StartOrganizationServiceAccessUpdate Operation</seealso>
        public virtual IAsyncResult BeginStartOrganizationServiceAccessUpdate(StartOrganizationServiceAccessUpdateRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartOrganizationServiceAccessUpdateRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartOrganizationServiceAccessUpdateResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartOrganizationServiceAccessUpdate operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartOrganizationServiceAccessUpdate.</param>
        /// 
        /// <returns>Returns a  StartOrganizationServiceAccessUpdateResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/StartOrganizationServiceAccessUpdate">REST API Reference for StartOrganizationServiceAccessUpdate Operation</seealso>
        public virtual StartOrganizationServiceAccessUpdateResponse EndStartOrganizationServiceAccessUpdate(IAsyncResult asyncResult)
        {
            return EndInvoke<StartOrganizationServiceAccessUpdateResponse>(asyncResult);
        }

        #endregion
        
        #region  StartRouteAnalysis

        /// <summary>
        /// Starts analyzing the routing path between the specified source and destination. For
        /// more information, see <a href="https://docs.aws.amazon.com/vpc/latest/tgw/route-analyzer.html">Route
        /// Analyzer</a>.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the StartRouteAnalysis service method.</param>
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
        public virtual StartRouteAnalysisResponse StartRouteAnalysis(StartRouteAnalysisRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartRouteAnalysisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartRouteAnalysisResponseUnmarshaller.Instance;

            return Invoke<StartRouteAnalysisResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the StartRouteAnalysis operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the StartRouteAnalysis operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartRouteAnalysis
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/StartRouteAnalysis">REST API Reference for StartRouteAnalysis Operation</seealso>
        public virtual IAsyncResult BeginStartRouteAnalysis(StartRouteAnalysisRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = StartRouteAnalysisRequestMarshaller.Instance;
            options.ResponseUnmarshaller = StartRouteAnalysisResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  StartRouteAnalysis operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartRouteAnalysis.</param>
        /// 
        /// <returns>Returns a  StartRouteAnalysisResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/StartRouteAnalysis">REST API Reference for StartRouteAnalysis Operation</seealso>
        public virtual StartRouteAnalysisResponse EndStartRouteAnalysis(IAsyncResult asyncResult)
        {
            return EndInvoke<StartRouteAnalysisResponse>(asyncResult);
        }

        #endregion
        
        #region  TagResource

        /// <summary>
        /// Tags a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the TagResource service method.</param>
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
        public virtual TagResourceResponse TagResource(TagResourceRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the TagResource operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndTagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual IAsyncResult BeginTagResource(TagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = TagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = TagResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  TagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTagResource.</param>
        /// 
        /// <returns>Returns a  TagResourceResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/TagResource">REST API Reference for TagResource Operation</seealso>
        public virtual TagResourceResponse EndTagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<TagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UntagResource

        /// <summary>
        /// Removes tags from a specified resource.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UntagResource service method.</param>
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
        public virtual UntagResourceResponse UntagResource(UntagResourceRequest request)
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
        /// <param name="request">Container for the necessary parameters to execute the UntagResource operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUntagResource
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual IAsyncResult BeginUntagResource(UntagResourceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UntagResourceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UntagResourceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UntagResource operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUntagResource.</param>
        /// 
        /// <returns>Returns a  UntagResourceResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/UntagResource">REST API Reference for UntagResource Operation</seealso>
        public virtual UntagResourceResponse EndUntagResource(IAsyncResult asyncResult)
        {
            return EndInvoke<UntagResourceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateConnection

        /// <summary>
        /// Updates the information for an existing connection. To remove information for any
        /// of the parameters, specify an empty string.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateConnection service method.</param>
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
        public virtual UpdateConnectionResponse UpdateConnection(UpdateConnectionRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConnectionResponseUnmarshaller.Instance;

            return Invoke<UpdateConnectionResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateConnection operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateConnection operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateConnection
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/UpdateConnection">REST API Reference for UpdateConnection Operation</seealso>
        public virtual IAsyncResult BeginUpdateConnection(UpdateConnectionRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateConnectionRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateConnectionResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateConnection operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateConnection.</param>
        /// 
        /// <returns>Returns a  UpdateConnectionResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/UpdateConnection">REST API Reference for UpdateConnection Operation</seealso>
        public virtual UpdateConnectionResponse EndUpdateConnection(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateConnectionResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateCoreNetwork

        /// <summary>
        /// Updates the description of a core network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateCoreNetwork service method.</param>
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
        public virtual UpdateCoreNetworkResponse UpdateCoreNetwork(UpdateCoreNetworkRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateCoreNetworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCoreNetworkResponseUnmarshaller.Instance;

            return Invoke<UpdateCoreNetworkResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateCoreNetwork operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateCoreNetwork operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateCoreNetwork
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/UpdateCoreNetwork">REST API Reference for UpdateCoreNetwork Operation</seealso>
        public virtual IAsyncResult BeginUpdateCoreNetwork(UpdateCoreNetworkRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateCoreNetworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateCoreNetworkResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateCoreNetwork operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateCoreNetwork.</param>
        /// 
        /// <returns>Returns a  UpdateCoreNetworkResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/UpdateCoreNetwork">REST API Reference for UpdateCoreNetwork Operation</seealso>
        public virtual UpdateCoreNetworkResponse EndUpdateCoreNetwork(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateCoreNetworkResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateDevice

        /// <summary>
        /// Updates the details for an existing device. To remove information for any of the parameters,
        /// specify an empty string.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateDevice service method.</param>
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
        public virtual UpdateDeviceResponse UpdateDevice(UpdateDeviceRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDeviceResponseUnmarshaller.Instance;

            return Invoke<UpdateDeviceResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateDevice operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateDevice operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateDevice
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/UpdateDevice">REST API Reference for UpdateDevice Operation</seealso>
        public virtual IAsyncResult BeginUpdateDevice(UpdateDeviceRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateDeviceRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateDeviceResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateDevice operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateDevice.</param>
        /// 
        /// <returns>Returns a  UpdateDeviceResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/UpdateDevice">REST API Reference for UpdateDevice Operation</seealso>
        public virtual UpdateDeviceResponse EndUpdateDevice(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateDeviceResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateGlobalNetwork

        /// <summary>
        /// Updates an existing global network. To remove information for any of the parameters,
        /// specify an empty string.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateGlobalNetwork service method.</param>
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
        public virtual UpdateGlobalNetworkResponse UpdateGlobalNetwork(UpdateGlobalNetworkRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateGlobalNetworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGlobalNetworkResponseUnmarshaller.Instance;

            return Invoke<UpdateGlobalNetworkResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateGlobalNetwork operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateGlobalNetwork operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateGlobalNetwork
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/UpdateGlobalNetwork">REST API Reference for UpdateGlobalNetwork Operation</seealso>
        public virtual IAsyncResult BeginUpdateGlobalNetwork(UpdateGlobalNetworkRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateGlobalNetworkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateGlobalNetworkResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateGlobalNetwork operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateGlobalNetwork.</param>
        /// 
        /// <returns>Returns a  UpdateGlobalNetworkResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/UpdateGlobalNetwork">REST API Reference for UpdateGlobalNetwork Operation</seealso>
        public virtual UpdateGlobalNetworkResponse EndUpdateGlobalNetwork(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateGlobalNetworkResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateLink

        /// <summary>
        /// Updates the details for an existing link. To remove information for any of the parameters,
        /// specify an empty string.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateLink service method.</param>
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
        public virtual UpdateLinkResponse UpdateLink(UpdateLinkRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLinkResponseUnmarshaller.Instance;

            return Invoke<UpdateLinkResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateLink operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateLink operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateLink
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/UpdateLink">REST API Reference for UpdateLink Operation</seealso>
        public virtual IAsyncResult BeginUpdateLink(UpdateLinkRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateLinkRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateLinkResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateLink operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateLink.</param>
        /// 
        /// <returns>Returns a  UpdateLinkResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/UpdateLink">REST API Reference for UpdateLink Operation</seealso>
        public virtual UpdateLinkResponse EndUpdateLink(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateLinkResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateNetworkResourceMetadata

        /// <summary>
        /// Updates the resource metadata for the specified global network.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateNetworkResourceMetadata service method.</param>
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
        public virtual UpdateNetworkResourceMetadataResponse UpdateNetworkResourceMetadata(UpdateNetworkResourceMetadataRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateNetworkResourceMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateNetworkResourceMetadataResponseUnmarshaller.Instance;

            return Invoke<UpdateNetworkResourceMetadataResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateNetworkResourceMetadata operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateNetworkResourceMetadata operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateNetworkResourceMetadata
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/UpdateNetworkResourceMetadata">REST API Reference for UpdateNetworkResourceMetadata Operation</seealso>
        public virtual IAsyncResult BeginUpdateNetworkResourceMetadata(UpdateNetworkResourceMetadataRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateNetworkResourceMetadataRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateNetworkResourceMetadataResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateNetworkResourceMetadata operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateNetworkResourceMetadata.</param>
        /// 
        /// <returns>Returns a  UpdateNetworkResourceMetadataResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/UpdateNetworkResourceMetadata">REST API Reference for UpdateNetworkResourceMetadata Operation</seealso>
        public virtual UpdateNetworkResourceMetadataResponse EndUpdateNetworkResourceMetadata(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateNetworkResourceMetadataResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateSite

        /// <summary>
        /// Updates the information for an existing site. To remove information for any of the
        /// parameters, specify an empty string.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateSite service method.</param>
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
        public virtual UpdateSiteResponse UpdateSite(UpdateSiteRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSiteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSiteResponseUnmarshaller.Instance;

            return Invoke<UpdateSiteResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateSite operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateSite operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateSite
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/UpdateSite">REST API Reference for UpdateSite Operation</seealso>
        public virtual IAsyncResult BeginUpdateSite(UpdateSiteRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateSiteRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateSiteResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateSite operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateSite.</param>
        /// 
        /// <returns>Returns a  UpdateSiteResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/UpdateSite">REST API Reference for UpdateSite Operation</seealso>
        public virtual UpdateSiteResponse EndUpdateSite(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateSiteResponse>(asyncResult);
        }

        #endregion
        
        #region  UpdateVpcAttachment

        /// <summary>
        /// Updates a VPC attachment.
        /// </summary>
        /// <param name="request">Container for the necessary parameters to execute the UpdateVpcAttachment service method.</param>
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
        public virtual UpdateVpcAttachmentResponse UpdateVpcAttachment(UpdateVpcAttachmentRequest request)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateVpcAttachmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateVpcAttachmentResponseUnmarshaller.Instance;

            return Invoke<UpdateVpcAttachmentResponse>(request, options);
        }

        /// <summary>
        /// Initiates the asynchronous execution of the UpdateVpcAttachment operation.
        /// </summary>
        /// 
        /// <param name="request">Container for the necessary parameters to execute the UpdateVpcAttachment operation on AmazonNetworkManagerClient.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndUpdateVpcAttachment
        ///         operation.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/UpdateVpcAttachment">REST API Reference for UpdateVpcAttachment Operation</seealso>
        public virtual IAsyncResult BeginUpdateVpcAttachment(UpdateVpcAttachmentRequest request, AsyncCallback callback, object state)
        {
            var options = new InvokeOptions();
            options.RequestMarshaller = UpdateVpcAttachmentRequestMarshaller.Instance;
            options.ResponseUnmarshaller = UpdateVpcAttachmentResponseUnmarshaller.Instance;

            return BeginInvoke(request, options, callback, state);
        }

        /// <summary>
        /// Finishes the asynchronous execution of the  UpdateVpcAttachment operation.
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUpdateVpcAttachment.</param>
        /// 
        /// <returns>Returns a  UpdateVpcAttachmentResult from NetworkManager.</returns>
        /// <seealso href="http://docs.aws.amazon.com/goto/WebAPI/networkmanager-2019-07-05/UpdateVpcAttachment">REST API Reference for UpdateVpcAttachment Operation</seealso>
        public virtual UpdateVpcAttachmentResponse EndUpdateVpcAttachment(IAsyncResult asyncResult)
        {
            return EndInvoke<UpdateVpcAttachmentResponse>(asyncResult);
        }

        #endregion
        
    }
}