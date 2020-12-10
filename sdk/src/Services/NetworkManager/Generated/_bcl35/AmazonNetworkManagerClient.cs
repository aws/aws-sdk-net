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
    /// Transit Gateway Network Manager (Network Manager) enables you to create a global network,
    /// in which you can monitor your AWS and on-premises networks that are built around transit
    /// gateways.
    /// 
    ///  
    /// <para>
    /// The Network Manager APIs are supported in the US West (Oregon) Region only. You must
    /// specify the <code>us-west-2</code> Region in all requests made to Network Manager.
    /// </para>
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


        #region  AssociateCustomerGateway

        /// <summary>
        /// Associates a customer gateway with a device and optionally, with a link. If you specify
        /// a link, it must be associated with the specified device. 
        /// 
        ///  
        /// <para>
        /// You can only associate customer gateways that are connected to a VPN attachment on
        /// a transit gateway. The transit gateway must be registered in your global network.
        /// When you register a transit gateway, customer gateways that are connected to the transit
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
        /// (devices, links, and sites) and deregister all transit gateways.
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
        
        #region  RegisterTransitGateway

        /// <summary>
        /// Registers a transit gateway in your global network. The transit gateway can be in
        /// any AWS Region, but it must be owned by the same AWS account that owns the global
        /// network. You cannot register a transit gateway in more than one global network.
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
        
    }
}