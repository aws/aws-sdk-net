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

using Amazon.DirectConnect.Model;
using Amazon.DirectConnect.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;


namespace Amazon.DirectConnect
{
    /// <summary>
    /// Implementation for accessing AmazonDirectConnect.
    ///  
    /// <para>AWS Direct Connect makes it easy to establish a dedicated network connection from your premise to Amazon Web Services. Using AWS
    /// Direct Connect, you can establish private connectivity between AWS and your data center, office, or colocation environment, which in many
    /// cases can reduce your network costs, increase bandwidth throughput, and provide a more consistent network experience than Internet-based
    /// connections.</para> <para>Use the following links to get started using the <i>AWS Direct Connect API Reference</i> :</para>
    /// <ul>
    /// <li> Actions: An alphabetical list of all AWS Direct Connect actions.</li>
    /// <li> Data Types: An alphabetical list of all AWS Direct Connect data types.</li>
    /// <li> Common Parameters: Parameters that all Query actions can use.</li>
    /// <li> Common Errors: Client and server errors that all actions can return.</li>
    /// <li> Regions and Endpoints: Itemized regions and endpoints for all AWS products.</li>
    /// 
    /// </ul>
    /// </summary>
    public class AmazonDirectConnectClient : AmazonWebServiceClient, AmazonDirectConnect
    {
    
        AbstractAWSSigner signer = new AWS4Signer();

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
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonDirectConnectClient()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonDirectConnectConfig(), true, AuthenticationTypes.User | AuthenticationTypes.Session) { }

        /// <summary>
        /// Constructs AmazonDirectConnectClient with the credentials loaded from the application's
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
        public AmazonDirectConnectClient(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonDirectConnectConfig(){RegionEndpoint = region}, true, AuthenticationTypes.User | AuthenticationTypes.Session) { }

        /// <summary>
        /// Constructs AmazonDirectConnectClient with the credentials loaded from the application's
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
        /// <param name="config">The AmazonDirectConnect Configuration Object</param>
        public AmazonDirectConnectClient(AmazonDirectConnectConfig config)
            : base(FallbackCredentialsFactory.GetCredentials(), config, true, AuthenticationTypes.User | AuthenticationTypes.Session) { }

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
            : this(credentials, new AmazonDirectConnectConfig(){RegionEndpoint=region})
        {
        }

        /// <summary>
        /// Constructs AmazonDirectConnectClient with AWS Credentials and an
        /// AmazonDirectConnectClient Configuration object.
        /// </summary>
        /// <param name="credentials">AWS Credentials</param>
        /// <param name="clientConfig">The AmazonDirectConnectClient Configuration Object</param>
        public AmazonDirectConnectClient(AWSCredentials credentials, AmazonDirectConnectConfig clientConfig)
            : base(credentials, clientConfig, false, AuthenticationTypes.User | AuthenticationTypes.Session)
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
        /// AmazonDirectConnectClient Configuration object. If the config object's
        /// UseSecureStringForAwsSecretKey is false, the AWS Secret Key
        /// is stored as a clear-text string. Please use this option only
        /// if the application environment doesn't allow the use of SecureStrings.
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="clientConfig">The AmazonDirectConnectClient Configuration Object</param>
        public AmazonDirectConnectClient(string awsAccessKeyId, string awsSecretAccessKey, AmazonDirectConnectConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
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
            : this(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, new AmazonDirectConnectConfig(){RegionEndpoint = region})
        {
        }

        /// <summary>
        /// Constructs AmazonDirectConnectClient with AWS Access Key ID, AWS Secret Key and an
        /// AmazonDirectConnectClient Configuration object. If the config object's
        /// UseSecureStringForAwsSecretKey is false, the AWS Secret Key
        /// is stored as a clear-text string. Please use this option only
        /// if the application environment doesn't allow the use of SecureStrings.
        /// </summary>
        /// <param name="awsAccessKeyId">AWS Access Key ID</param>
        /// <param name="awsSecretAccessKey">AWS Secret Access Key</param>
        /// <param name="awsSessionToken">AWS Session Token</param>
        /// <param name="clientConfig">The AmazonDirectConnectClient Configuration Object</param>
        public AmazonDirectConnectClient(string awsAccessKeyId, string awsSecretAccessKey, string awsSessionToken, AmazonDirectConnectConfig clientConfig)
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        #endregion
   
        #region DescribeVirtualInterfaces

        /// <summary>
        /// <para>Displays all virtual interfaces for an AWS account. Virtual interfaces deleted for less than 15 minutes are also returned. If virtual
        /// interface ID is included then only a single virtual interface will be returned.</para> <para> A virtual interface (VLAN) transmits the
        /// traffic between the Direct Connect location and the customer.</para>
        /// </summary>
        /// 
        /// <param name="describeVirtualInterfacesRequest">Container for the necessary parameters to execute the DescribeVirtualInterfaces service
        ///          method on AmazonDirectConnect.</param>
        /// 
        /// <returns>The response from the DescribeVirtualInterfaces service method, as returned by AmazonDirectConnect.</returns>
        /// 
        /// <exception cref="DirectConnectServerException"/>
        /// <exception cref="DirectConnectClientException"/>
        public DescribeVirtualInterfacesResponse DescribeVirtualInterfaces(DescribeVirtualInterfacesRequest describeVirtualInterfacesRequest)
        {
            IAsyncResult asyncResult = invokeDescribeVirtualInterfaces(describeVirtualInterfacesRequest, null, null, true);
            return EndDescribeVirtualInterfaces(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVirtualInterfaces operation.
        /// <seealso cref="Amazon.DirectConnect.AmazonDirectConnect.DescribeVirtualInterfaces"/>
        /// </summary>
        /// 
        /// <param name="describeVirtualInterfacesRequest">Container for the necessary parameters to execute the DescribeVirtualInterfaces operation on
        ///          AmazonDirectConnect.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeVirtualInterfaces operation.</returns>
        public IAsyncResult BeginDescribeVirtualInterfaces(DescribeVirtualInterfacesRequest describeVirtualInterfacesRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeVirtualInterfaces(describeVirtualInterfacesRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeVirtualInterfaces operation.
        /// <seealso cref="Amazon.DirectConnect.AmazonDirectConnect.DescribeVirtualInterfaces"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeVirtualInterfaces.</param>
        /// 
        /// <returns>Returns a DescribeVirtualInterfacesResult from AmazonDirectConnect.</returns>
        public DescribeVirtualInterfacesResponse EndDescribeVirtualInterfaces(IAsyncResult asyncResult)
        {
            return endOperation<DescribeVirtualInterfacesResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeVirtualInterfaces(DescribeVirtualInterfacesRequest describeVirtualInterfacesRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeVirtualInterfacesRequestMarshaller().Marshall(describeVirtualInterfacesRequest);
            var unmarshaller = DescribeVirtualInterfacesResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para>Displays all virtual interfaces for an AWS account. Virtual interfaces deleted for less than 15 minutes are also returned. If virtual
        /// interface ID is included then only a single virtual interface will be returned.</para> <para> A virtual interface (VLAN) transmits the
        /// traffic between the Direct Connect location and the customer.</para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeVirtualInterfaces service method, as returned by AmazonDirectConnect.</returns>
        /// 
        /// <exception cref="DirectConnectServerException"/>
        /// <exception cref="DirectConnectClientException"/>
        public DescribeVirtualInterfacesResponse DescribeVirtualInterfaces()
        {
            return DescribeVirtualInterfaces(new DescribeVirtualInterfacesRequest());
        }
        

        #endregion
    
        #region DescribeVirtualGateways

        /// <summary>
        /// <para>Returns a list of virtual private gateways owned by the AWS account.</para> <para>You can create one or more Direct Connect private
        /// virtual interfaces linking to a virtual private gateway. Virtual private gateway can be managed via AWS Virtual Private Cloud Console or the
        /// EC2 CreateVpnGateway API.</para>
        /// </summary>
        /// 
        /// <param name="describeVirtualGatewaysRequest">Container for the necessary parameters to execute the DescribeVirtualGateways service method on
        ///          AmazonDirectConnect.</param>
        /// 
        /// <returns>The response from the DescribeVirtualGateways service method, as returned by AmazonDirectConnect.</returns>
        /// 
        /// <exception cref="DirectConnectServerException"/>
        /// <exception cref="DirectConnectClientException"/>
        public DescribeVirtualGatewaysResponse DescribeVirtualGateways(DescribeVirtualGatewaysRequest describeVirtualGatewaysRequest)
        {
            IAsyncResult asyncResult = invokeDescribeVirtualGateways(describeVirtualGatewaysRequest, null, null, true);
            return EndDescribeVirtualGateways(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVirtualGateways operation.
        /// <seealso cref="Amazon.DirectConnect.AmazonDirectConnect.DescribeVirtualGateways"/>
        /// </summary>
        /// 
        /// <param name="describeVirtualGatewaysRequest">Container for the necessary parameters to execute the DescribeVirtualGateways operation on
        ///          AmazonDirectConnect.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeVirtualGateways operation.</returns>
        public IAsyncResult BeginDescribeVirtualGateways(DescribeVirtualGatewaysRequest describeVirtualGatewaysRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeVirtualGateways(describeVirtualGatewaysRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeVirtualGateways operation.
        /// <seealso cref="Amazon.DirectConnect.AmazonDirectConnect.DescribeVirtualGateways"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeVirtualGateways.</param>
        /// 
        /// <returns>Returns a DescribeVirtualGatewaysResult from AmazonDirectConnect.</returns>
        public DescribeVirtualGatewaysResponse EndDescribeVirtualGateways(IAsyncResult asyncResult)
        {
            return endOperation<DescribeVirtualGatewaysResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeVirtualGateways(DescribeVirtualGatewaysRequest describeVirtualGatewaysRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeVirtualGatewaysRequestMarshaller().Marshall(describeVirtualGatewaysRequest);
            var unmarshaller = DescribeVirtualGatewaysResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para>Returns a list of virtual private gateways owned by the AWS account.</para> <para>You can create one or more Direct Connect private
        /// virtual interfaces linking to a virtual private gateway. Virtual private gateway can be managed via AWS Virtual Private Cloud Console or the
        /// EC2 CreateVpnGateway API.</para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeVirtualGateways service method, as returned by AmazonDirectConnect.</returns>
        /// 
        /// <exception cref="DirectConnectServerException"/>
        /// <exception cref="DirectConnectClientException"/>
        public DescribeVirtualGatewaysResponse DescribeVirtualGateways()
        {
            return DescribeVirtualGateways(new DescribeVirtualGatewaysRequest());
        }
        

        #endregion
    
        #region DescribeConnectionDetail

        /// <summary>
        /// <para>Displays details about a specific Connection including the order steps for the connection and the current state of the connection
        /// order.</para>
        /// </summary>
        /// 
        /// <param name="describeConnectionDetailRequest">Container for the necessary parameters to execute the DescribeConnectionDetail service method
        ///          on AmazonDirectConnect.</param>
        /// 
        /// <returns>The response from the DescribeConnectionDetail service method, as returned by AmazonDirectConnect.</returns>
        /// 
        /// <exception cref="DirectConnectServerException"/>
        /// <exception cref="DirectConnectClientException"/>
        public DescribeConnectionDetailResponse DescribeConnectionDetail(DescribeConnectionDetailRequest describeConnectionDetailRequest)
        {
            IAsyncResult asyncResult = invokeDescribeConnectionDetail(describeConnectionDetailRequest, null, null, true);
            return EndDescribeConnectionDetail(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeConnectionDetail operation.
        /// <seealso cref="Amazon.DirectConnect.AmazonDirectConnect.DescribeConnectionDetail"/>
        /// </summary>
        /// 
        /// <param name="describeConnectionDetailRequest">Container for the necessary parameters to execute the DescribeConnectionDetail operation on
        ///          AmazonDirectConnect.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeConnectionDetail operation.</returns>
        public IAsyncResult BeginDescribeConnectionDetail(DescribeConnectionDetailRequest describeConnectionDetailRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeConnectionDetail(describeConnectionDetailRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeConnectionDetail operation.
        /// <seealso cref="Amazon.DirectConnect.AmazonDirectConnect.DescribeConnectionDetail"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeConnectionDetail.</param>
        /// 
        /// <returns>Returns a DescribeConnectionDetailResult from AmazonDirectConnect.</returns>
        public DescribeConnectionDetailResponse EndDescribeConnectionDetail(IAsyncResult asyncResult)
        {
            return endOperation<DescribeConnectionDetailResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeConnectionDetail(DescribeConnectionDetailRequest describeConnectionDetailRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeConnectionDetailRequestMarshaller().Marshall(describeConnectionDetailRequest);
            var unmarshaller = DescribeConnectionDetailResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DescribeOfferings

        /// <summary>
        /// <para>Describes one or more of the Offerings that are currently available for creating new Connections. The results include offerings for
        /// all regions.</para> <para>To order a new Connection you will need to select a specific Offering ID.</para>
        /// </summary>
        /// 
        /// <param name="describeOfferingsRequest">Container for the necessary parameters to execute the DescribeOfferings service method on
        ///          AmazonDirectConnect.</param>
        /// 
        /// <returns>The response from the DescribeOfferings service method, as returned by AmazonDirectConnect.</returns>
        /// 
        /// <exception cref="DirectConnectServerException"/>
        /// <exception cref="DirectConnectClientException"/>
        public DescribeOfferingsResponse DescribeOfferings(DescribeOfferingsRequest describeOfferingsRequest)
        {
            IAsyncResult asyncResult = invokeDescribeOfferings(describeOfferingsRequest, null, null, true);
            return EndDescribeOfferings(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeOfferings operation.
        /// <seealso cref="Amazon.DirectConnect.AmazonDirectConnect.DescribeOfferings"/>
        /// </summary>
        /// 
        /// <param name="describeOfferingsRequest">Container for the necessary parameters to execute the DescribeOfferings operation on
        ///          AmazonDirectConnect.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeOfferings
        ///         operation.</returns>
        public IAsyncResult BeginDescribeOfferings(DescribeOfferingsRequest describeOfferingsRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeOfferings(describeOfferingsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeOfferings operation.
        /// <seealso cref="Amazon.DirectConnect.AmazonDirectConnect.DescribeOfferings"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeOfferings.</param>
        /// 
        /// <returns>Returns a DescribeOfferingsResult from AmazonDirectConnect.</returns>
        public DescribeOfferingsResponse EndDescribeOfferings(IAsyncResult asyncResult)
        {
            return endOperation<DescribeOfferingsResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeOfferings(DescribeOfferingsRequest describeOfferingsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeOfferingsRequestMarshaller().Marshall(describeOfferingsRequest);
            var unmarshaller = DescribeOfferingsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para>Describes one or more of the Offerings that are currently available for creating new Connections. The results include offerings for
        /// all regions.</para> <para>To order a new Connection you will need to select a specific Offering ID.</para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeOfferings service method, as returned by AmazonDirectConnect.</returns>
        /// 
        /// <exception cref="DirectConnectServerException"/>
        /// <exception cref="DirectConnectClientException"/>
        public DescribeOfferingsResponse DescribeOfferings()
        {
            return DescribeOfferings(new DescribeOfferingsRequest());
        }
        

        #endregion
    
        #region DescribeConnections

        /// <summary>
        /// <para>Displays all connections in this region.</para> <para>If a connection ID is provided, it will only return this particular
        /// connection.</para>
        /// </summary>
        /// 
        /// <param name="describeConnectionsRequest">Container for the necessary parameters to execute the DescribeConnections service method on
        ///          AmazonDirectConnect.</param>
        /// 
        /// <returns>The response from the DescribeConnections service method, as returned by AmazonDirectConnect.</returns>
        /// 
        /// <exception cref="DirectConnectServerException"/>
        /// <exception cref="DirectConnectClientException"/>
        public DescribeConnectionsResponse DescribeConnections(DescribeConnectionsRequest describeConnectionsRequest)
        {
            IAsyncResult asyncResult = invokeDescribeConnections(describeConnectionsRequest, null, null, true);
            return EndDescribeConnections(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeConnections operation.
        /// <seealso cref="Amazon.DirectConnect.AmazonDirectConnect.DescribeConnections"/>
        /// </summary>
        /// 
        /// <param name="describeConnectionsRequest">Container for the necessary parameters to execute the DescribeConnections operation on
        ///          AmazonDirectConnect.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeConnections operation.</returns>
        public IAsyncResult BeginDescribeConnections(DescribeConnectionsRequest describeConnectionsRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeConnections(describeConnectionsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeConnections operation.
        /// <seealso cref="Amazon.DirectConnect.AmazonDirectConnect.DescribeConnections"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeConnections.</param>
        /// 
        /// <returns>Returns a DescribeConnectionsResult from AmazonDirectConnect.</returns>
        public DescribeConnectionsResponse EndDescribeConnections(IAsyncResult asyncResult)
        {
            return endOperation<DescribeConnectionsResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeConnections(DescribeConnectionsRequest describeConnectionsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeConnectionsRequestMarshaller().Marshall(describeConnectionsRequest);
            var unmarshaller = DescribeConnectionsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para>Displays all connections in this region.</para> <para>If a connection ID is provided, it will only return this particular
        /// connection.</para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeConnections service method, as returned by AmazonDirectConnect.</returns>
        /// 
        /// <exception cref="DirectConnectServerException"/>
        /// <exception cref="DirectConnectClientException"/>
        public DescribeConnectionsResponse DescribeConnections()
        {
            return DescribeConnections(new DescribeConnectionsRequest());
        }
        

        #endregion
    
        #region DescribeOfferingDetail

        /// <summary>
        /// <para>Displays additional ordering step details for a specified Offering.</para>
        /// </summary>
        /// 
        /// <param name="describeOfferingDetailRequest">Container for the necessary parameters to execute the DescribeOfferingDetail service method on
        ///          AmazonDirectConnect.</param>
        /// 
        /// <returns>The response from the DescribeOfferingDetail service method, as returned by AmazonDirectConnect.</returns>
        /// 
        /// <exception cref="DirectConnectServerException"/>
        /// <exception cref="DirectConnectClientException"/>
        public DescribeOfferingDetailResponse DescribeOfferingDetail(DescribeOfferingDetailRequest describeOfferingDetailRequest)
        {
            IAsyncResult asyncResult = invokeDescribeOfferingDetail(describeOfferingDetailRequest, null, null, true);
            return EndDescribeOfferingDetail(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeOfferingDetail operation.
        /// <seealso cref="Amazon.DirectConnect.AmazonDirectConnect.DescribeOfferingDetail"/>
        /// </summary>
        /// 
        /// <param name="describeOfferingDetailRequest">Container for the necessary parameters to execute the DescribeOfferingDetail operation on
        ///          AmazonDirectConnect.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeOfferingDetail operation.</returns>
        public IAsyncResult BeginDescribeOfferingDetail(DescribeOfferingDetailRequest describeOfferingDetailRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeOfferingDetail(describeOfferingDetailRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeOfferingDetail operation.
        /// <seealso cref="Amazon.DirectConnect.AmazonDirectConnect.DescribeOfferingDetail"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeOfferingDetail.</param>
        /// 
        /// <returns>Returns a DescribeOfferingDetailResult from AmazonDirectConnect.</returns>
        public DescribeOfferingDetailResponse EndDescribeOfferingDetail(IAsyncResult asyncResult)
        {
            return endOperation<DescribeOfferingDetailResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeOfferingDetail(DescribeOfferingDetailRequest describeOfferingDetailRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeOfferingDetailRequestMarshaller().Marshall(describeOfferingDetailRequest);
            var unmarshaller = DescribeOfferingDetailResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DeleteConnection

        /// <summary>
        /// <para>Deletes the Connection.</para> <para>Deleting a connection only stops the AWS Direct Connect Port and Data Transfer charges. You
        /// separately need to cancel any services or charges for cross-connects or network circuits that connect you to the AWS Direct Connect location
        /// with those providers.</para>
        /// </summary>
        /// 
        /// <param name="deleteConnectionRequest">Container for the necessary parameters to execute the DeleteConnection service method on
        ///          AmazonDirectConnect.</param>
        /// 
        /// <returns>The response from the DeleteConnection service method, as returned by AmazonDirectConnect.</returns>
        /// 
        /// <exception cref="DirectConnectServerException"/>
        /// <exception cref="DirectConnectClientException"/>
        public DeleteConnectionResponse DeleteConnection(DeleteConnectionRequest deleteConnectionRequest)
        {
            IAsyncResult asyncResult = invokeDeleteConnection(deleteConnectionRequest, null, null, true);
            return EndDeleteConnection(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteConnection operation.
        /// <seealso cref="Amazon.DirectConnect.AmazonDirectConnect.DeleteConnection"/>
        /// </summary>
        /// 
        /// <param name="deleteConnectionRequest">Container for the necessary parameters to execute the DeleteConnection operation on
        ///          AmazonDirectConnect.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDeleteConnection
        ///         operation.</returns>
        public IAsyncResult BeginDeleteConnection(DeleteConnectionRequest deleteConnectionRequest, AsyncCallback callback, object state)
        {
            return invokeDeleteConnection(deleteConnectionRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteConnection operation.
        /// <seealso cref="Amazon.DirectConnect.AmazonDirectConnect.DeleteConnection"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteConnection.</param>
        /// 
        /// <returns>Returns a DeleteConnectionResult from AmazonDirectConnect.</returns>
        public DeleteConnectionResponse EndDeleteConnection(IAsyncResult asyncResult)
        {
            return endOperation<DeleteConnectionResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeleteConnection(DeleteConnectionRequest deleteConnectionRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteConnectionRequestMarshaller().Marshall(deleteConnectionRequest);
            var unmarshaller = DeleteConnectionResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region CreateConnection

        /// <summary>
        /// <para>Creates a new network connection between the customer network and a specific AWS Direct Connect location.</para> <para>A connection
        /// links your internal network to an AWS Direct Connect location over a standard 1 gigabit or 10 gigabit Ethernet fiber-optic cable. One end of
        /// the cable is connected to your router, the other to an AWS Direct Connect router. A Direct Connect location provides access to Amazon Web
        /// Services in the region it is associated with. You can establish connections with AWS Direct Connect locations in multiple regions, but a
        /// connection in one region does not provide connectivity to other regions.</para>
        /// </summary>
        /// 
        /// <param name="createConnectionRequest">Container for the necessary parameters to execute the CreateConnection service method on
        ///          AmazonDirectConnect.</param>
        /// 
        /// <returns>The response from the CreateConnection service method, as returned by AmazonDirectConnect.</returns>
        /// 
        /// <exception cref="DirectConnectServerException"/>
        /// <exception cref="DirectConnectClientException"/>
        public CreateConnectionResponse CreateConnection(CreateConnectionRequest createConnectionRequest)
        {
            IAsyncResult asyncResult = invokeCreateConnection(createConnectionRequest, null, null, true);
            return EndCreateConnection(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CreateConnection operation.
        /// <seealso cref="Amazon.DirectConnect.AmazonDirectConnect.CreateConnection"/>
        /// </summary>
        /// 
        /// <param name="createConnectionRequest">Container for the necessary parameters to execute the CreateConnection operation on
        ///          AmazonDirectConnect.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateConnection
        ///         operation.</returns>
        public IAsyncResult BeginCreateConnection(CreateConnectionRequest createConnectionRequest, AsyncCallback callback, object state)
        {
            return invokeCreateConnection(createConnectionRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CreateConnection operation.
        /// <seealso cref="Amazon.DirectConnect.AmazonDirectConnect.CreateConnection"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateConnection.</param>
        /// 
        /// <returns>Returns a CreateConnectionResult from AmazonDirectConnect.</returns>
        public CreateConnectionResponse EndCreateConnection(IAsyncResult asyncResult)
        {
            return endOperation<CreateConnectionResponse>(asyncResult);
        }
        
        IAsyncResult invokeCreateConnection(CreateConnectionRequest createConnectionRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreateConnectionRequestMarshaller().Marshall(createConnectionRequest);
            var unmarshaller = CreateConnectionResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region CreatePrivateVirtualInterface

        /// <summary>
        /// <para> Creates a new private virtual interface. A virtual interface is the VLAN that transports Direct Connect traffic. A private virtual
        /// interface supports sending traffic to a single VPC. </para>
        /// </summary>
        /// 
        /// <param name="createPrivateVirtualInterfaceRequest">Container for the necessary parameters to execute the CreatePrivateVirtualInterface
        ///          service method on AmazonDirectConnect.</param>
        /// 
        /// <returns>The response from the CreatePrivateVirtualInterface service method, as returned by AmazonDirectConnect.</returns>
        /// 
        /// <exception cref="DirectConnectServerException"/>
        /// <exception cref="DirectConnectClientException"/>
        public CreatePrivateVirtualInterfaceResponse CreatePrivateVirtualInterface(CreatePrivateVirtualInterfaceRequest createPrivateVirtualInterfaceRequest)
        {
            IAsyncResult asyncResult = invokeCreatePrivateVirtualInterface(createPrivateVirtualInterfaceRequest, null, null, true);
            return EndCreatePrivateVirtualInterface(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePrivateVirtualInterface operation.
        /// <seealso cref="Amazon.DirectConnect.AmazonDirectConnect.CreatePrivateVirtualInterface"/>
        /// </summary>
        /// 
        /// <param name="createPrivateVirtualInterfaceRequest">Container for the necessary parameters to execute the CreatePrivateVirtualInterface
        ///          operation on AmazonDirectConnect.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndCreatePrivateVirtualInterface operation.</returns>
        public IAsyncResult BeginCreatePrivateVirtualInterface(CreatePrivateVirtualInterfaceRequest createPrivateVirtualInterfaceRequest, AsyncCallback callback, object state)
        {
            return invokeCreatePrivateVirtualInterface(createPrivateVirtualInterfaceRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CreatePrivateVirtualInterface operation.
        /// <seealso cref="Amazon.DirectConnect.AmazonDirectConnect.CreatePrivateVirtualInterface"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePrivateVirtualInterface.</param>
        /// 
        /// <returns>Returns a CreatePrivateVirtualInterfaceResult from AmazonDirectConnect.</returns>
        public CreatePrivateVirtualInterfaceResponse EndCreatePrivateVirtualInterface(IAsyncResult asyncResult)
        {
            return endOperation<CreatePrivateVirtualInterfaceResponse>(asyncResult);
        }
        
        IAsyncResult invokeCreatePrivateVirtualInterface(CreatePrivateVirtualInterfaceRequest createPrivateVirtualInterfaceRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreatePrivateVirtualInterfaceRequestMarshaller().Marshall(createPrivateVirtualInterfaceRequest);
            var unmarshaller = CreatePrivateVirtualInterfaceResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para> Creates a new private virtual interface. A virtual interface is the VLAN that transports Direct Connect traffic. A private virtual
        /// interface supports sending traffic to a single VPC. </para>
        /// </summary>
        /// 
        /// <returns>The response from the CreatePrivateVirtualInterface service method, as returned by AmazonDirectConnect.</returns>
        /// 
        /// <exception cref="DirectConnectServerException"/>
        /// <exception cref="DirectConnectClientException"/>
        public CreatePrivateVirtualInterfaceResponse CreatePrivateVirtualInterface()
        {
            return CreatePrivateVirtualInterface(new CreatePrivateVirtualInterfaceRequest());
        }
        

        #endregion
    
        #region DeleteVirtualInterface

        /// <summary>
        /// <para> Deletes a virtual interface. </para>
        /// </summary>
        /// 
        /// <param name="deleteVirtualInterfaceRequest">Container for the necessary parameters to execute the DeleteVirtualInterface service method on
        ///          AmazonDirectConnect.</param>
        /// 
        /// <returns>The response from the DeleteVirtualInterface service method, as returned by AmazonDirectConnect.</returns>
        /// 
        /// <exception cref="DirectConnectServerException"/>
        /// <exception cref="DirectConnectClientException"/>
        public DeleteVirtualInterfaceResponse DeleteVirtualInterface(DeleteVirtualInterfaceRequest deleteVirtualInterfaceRequest)
        {
            IAsyncResult asyncResult = invokeDeleteVirtualInterface(deleteVirtualInterfaceRequest, null, null, true);
            return EndDeleteVirtualInterface(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVirtualInterface operation.
        /// <seealso cref="Amazon.DirectConnect.AmazonDirectConnect.DeleteVirtualInterface"/>
        /// </summary>
        /// 
        /// <param name="deleteVirtualInterfaceRequest">Container for the necessary parameters to execute the DeleteVirtualInterface operation on
        ///          AmazonDirectConnect.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDeleteVirtualInterface operation.</returns>
        public IAsyncResult BeginDeleteVirtualInterface(DeleteVirtualInterfaceRequest deleteVirtualInterfaceRequest, AsyncCallback callback, object state)
        {
            return invokeDeleteVirtualInterface(deleteVirtualInterfaceRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteVirtualInterface operation.
        /// <seealso cref="Amazon.DirectConnect.AmazonDirectConnect.DeleteVirtualInterface"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVirtualInterface.</param>
        /// 
        /// <returns>Returns a DeleteVirtualInterfaceResult from AmazonDirectConnect.</returns>
        public DeleteVirtualInterfaceResponse EndDeleteVirtualInterface(IAsyncResult asyncResult)
        {
            return endOperation<DeleteVirtualInterfaceResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeleteVirtualInterface(DeleteVirtualInterfaceRequest deleteVirtualInterfaceRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteVirtualInterfaceRequestMarshaller().Marshall(deleteVirtualInterfaceRequest);
            var unmarshaller = DeleteVirtualInterfaceResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para> Deletes a virtual interface. </para>
        /// </summary>
        /// 
        /// <returns>The response from the DeleteVirtualInterface service method, as returned by AmazonDirectConnect.</returns>
        /// 
        /// <exception cref="DirectConnectServerException"/>
        /// <exception cref="DirectConnectClientException"/>
        public DeleteVirtualInterfaceResponse DeleteVirtualInterface()
        {
            return DeleteVirtualInterface(new DeleteVirtualInterfaceRequest());
        }
        

        #endregion
    
        #region CreatePublicVirtualInterface

        /// <summary>
        /// <para> Creates a new public virtual interface. A virtual interface is the VLAN that transports Direct Connect traffic. A public virtual
        /// interface supports sending traffic to public AWS services such as S3. </para>
        /// </summary>
        /// 
        /// <param name="createPublicVirtualInterfaceRequest">Container for the necessary parameters to execute the CreatePublicVirtualInterface service
        ///          method on AmazonDirectConnect.</param>
        /// 
        /// <returns>The response from the CreatePublicVirtualInterface service method, as returned by AmazonDirectConnect.</returns>
        /// 
        /// <exception cref="DirectConnectServerException"/>
        /// <exception cref="DirectConnectClientException"/>
        public CreatePublicVirtualInterfaceResponse CreatePublicVirtualInterface(CreatePublicVirtualInterfaceRequest createPublicVirtualInterfaceRequest)
        {
            IAsyncResult asyncResult = invokeCreatePublicVirtualInterface(createPublicVirtualInterfaceRequest, null, null, true);
            return EndCreatePublicVirtualInterface(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePublicVirtualInterface operation.
        /// <seealso cref="Amazon.DirectConnect.AmazonDirectConnect.CreatePublicVirtualInterface"/>
        /// </summary>
        /// 
        /// <param name="createPublicVirtualInterfaceRequest">Container for the necessary parameters to execute the CreatePublicVirtualInterface
        ///          operation on AmazonDirectConnect.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndCreatePublicVirtualInterface operation.</returns>
        public IAsyncResult BeginCreatePublicVirtualInterface(CreatePublicVirtualInterfaceRequest createPublicVirtualInterfaceRequest, AsyncCallback callback, object state)
        {
            return invokeCreatePublicVirtualInterface(createPublicVirtualInterfaceRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CreatePublicVirtualInterface operation.
        /// <seealso cref="Amazon.DirectConnect.AmazonDirectConnect.CreatePublicVirtualInterface"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePublicVirtualInterface.</param>
        /// 
        /// <returns>Returns a CreatePublicVirtualInterfaceResult from AmazonDirectConnect.</returns>
        public CreatePublicVirtualInterfaceResponse EndCreatePublicVirtualInterface(IAsyncResult asyncResult)
        {
            return endOperation<CreatePublicVirtualInterfaceResponse>(asyncResult);
        }
        
        IAsyncResult invokeCreatePublicVirtualInterface(CreatePublicVirtualInterfaceRequest createPublicVirtualInterfaceRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreatePublicVirtualInterfaceRequestMarshaller().Marshall(createPublicVirtualInterfaceRequest);
            var unmarshaller = CreatePublicVirtualInterfaceResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para> Creates a new public virtual interface. A virtual interface is the VLAN that transports Direct Connect traffic. A public virtual
        /// interface supports sending traffic to public AWS services such as S3. </para>
        /// </summary>
        /// 
        /// <returns>The response from the CreatePublicVirtualInterface service method, as returned by AmazonDirectConnect.</returns>
        /// 
        /// <exception cref="DirectConnectServerException"/>
        /// <exception cref="DirectConnectClientException"/>
        public CreatePublicVirtualInterfaceResponse CreatePublicVirtualInterface()
        {
            return CreatePublicVirtualInterface(new CreatePublicVirtualInterfaceRequest());
        }
        

        #endregion
    
    }
}
    
