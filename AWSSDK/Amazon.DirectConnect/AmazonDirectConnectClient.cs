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
    /// <para>AWS Direct Connect makes it easy to establish a dedicated network connection from your premises to Amazon Web Services (AWS). Using
    /// AWS Direct Connect, you can establish private connectivity between AWS and your data center, office, or colocation environment, which in
    /// many cases can reduce your network costs, increase bandwidth throughput, and provide a more consistent network experience than
    /// Internet-based connections.</para> <para>The AWS Direct Connect API Reference provides descriptions, syntax, and usage examples for each of
    /// the actions and data types for AWS Direct Connect. Use the following links to get started using the <i>AWS Direct Connect API Reference</i>
    /// :</para>
    /// <ul>
    /// <li> <a href="http://docs.aws.amazon.com/directconnect/latest/APIReference/API_Operations.html" >Actions</a> : An alphabetical list of all
    /// AWS Direct Connect actions.</li>
    /// <li> <a href="http://docs.aws.amazon.com/directconnect/latest/APIReference/API_Types.html" >Data Types</a> : An alphabetical list of all
    /// AWS Direct Connect data types.</li>
    /// <li> <a href="http://docs.aws.amazon.com/directconnect/latest/APIReference/CommonParameters.html" >Common Query Parameters</a> : Parameters
    /// that all Query actions can use.</li>
    /// <li> <a href="http://docs.aws.amazon.com/directconnect/latest/APIReference/CommonErrors.html" >Common Errors</a> : Client and server errors
    /// that all actions can return.</li>
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
        /// AmazonDirectConnectConfig Configuration object. If the config object's
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
   
        #region ConfirmPublicVirtualInterface

        /// <summary>
        /// <para>Accept ownership of a public virtual interface created by another customer.</para> <para>After the virtual interface owner calls this
        /// function, the specified virtual interface will be created and made available for handling traffic.</para>
        /// </summary>
        /// 
        /// <param name="confirmPublicVirtualInterfaceRequest">Container for the necessary parameters to execute the ConfirmPublicVirtualInterface
        ///          service method on AmazonDirectConnect.</param>
        /// 
        /// <returns>The response from the ConfirmPublicVirtualInterface service method, as returned by AmazonDirectConnect.</returns>
        /// 
        /// <exception cref="DirectConnectServerException"/>
        /// <exception cref="DirectConnectClientException"/>
        public ConfirmPublicVirtualInterfaceResponse ConfirmPublicVirtualInterface(ConfirmPublicVirtualInterfaceRequest confirmPublicVirtualInterfaceRequest)
        {
            IAsyncResult asyncResult = invokeConfirmPublicVirtualInterface(confirmPublicVirtualInterfaceRequest, null, null, true);
            return EndConfirmPublicVirtualInterface(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ConfirmPublicVirtualInterface operation.
        /// <seealso cref="Amazon.DirectConnect.AmazonDirectConnect.ConfirmPublicVirtualInterface"/>
        /// </summary>
        /// 
        /// <param name="confirmPublicVirtualInterfaceRequest">Container for the necessary parameters to execute the ConfirmPublicVirtualInterface
        ///          operation on AmazonDirectConnect.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndConfirmPublicVirtualInterface operation.</returns>
        public IAsyncResult BeginConfirmPublicVirtualInterface(ConfirmPublicVirtualInterfaceRequest confirmPublicVirtualInterfaceRequest, AsyncCallback callback, object state)
        {
            return invokeConfirmPublicVirtualInterface(confirmPublicVirtualInterfaceRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ConfirmPublicVirtualInterface operation.
        /// <seealso cref="Amazon.DirectConnect.AmazonDirectConnect.ConfirmPublicVirtualInterface"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginConfirmPublicVirtualInterface.</param>
        /// 
        /// <returns>Returns a ConfirmPublicVirtualInterfaceResult from AmazonDirectConnect.</returns>
        public ConfirmPublicVirtualInterfaceResponse EndConfirmPublicVirtualInterface(IAsyncResult asyncResult)
        {
            return endOperation<ConfirmPublicVirtualInterfaceResponse>(asyncResult);
        }
        
        IAsyncResult invokeConfirmPublicVirtualInterface(ConfirmPublicVirtualInterfaceRequest confirmPublicVirtualInterfaceRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ConfirmPublicVirtualInterfaceRequestMarshaller().Marshall(confirmPublicVirtualInterfaceRequest);
            var unmarshaller = ConfirmPublicVirtualInterfaceResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DescribeLocations

        /// <summary>
        /// <para>Returns the list of Direct Connect locations in the current AWS region. These are the locations that may be selected when calling
        /// CreateConnection or CreateInterconnect.</para>
        /// </summary>
        /// 
        /// <param name="describeLocationsRequest">Container for the necessary parameters to execute the DescribeLocations service method on
        ///          AmazonDirectConnect.</param>
        /// 
        /// <returns>The response from the DescribeLocations service method, as returned by AmazonDirectConnect.</returns>
        /// 
        /// <exception cref="DirectConnectServerException"/>
        /// <exception cref="DirectConnectClientException"/>
        public DescribeLocationsResponse DescribeLocations(DescribeLocationsRequest describeLocationsRequest)
        {
            IAsyncResult asyncResult = invokeDescribeLocations(describeLocationsRequest, null, null, true);
            return EndDescribeLocations(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeLocations operation.
        /// <seealso cref="Amazon.DirectConnect.AmazonDirectConnect.DescribeLocations"/>
        /// </summary>
        /// 
        /// <param name="describeLocationsRequest">Container for the necessary parameters to execute the DescribeLocations operation on
        ///          AmazonDirectConnect.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeLocations
        ///         operation.</returns>
        public IAsyncResult BeginDescribeLocations(DescribeLocationsRequest describeLocationsRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeLocations(describeLocationsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeLocations operation.
        /// <seealso cref="Amazon.DirectConnect.AmazonDirectConnect.DescribeLocations"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeLocations.</param>
        /// 
        /// <returns>Returns a DescribeLocationsResult from AmazonDirectConnect.</returns>
        public DescribeLocationsResponse EndDescribeLocations(IAsyncResult asyncResult)
        {
            return endOperation<DescribeLocationsResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeLocations(DescribeLocationsRequest describeLocationsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeLocationsRequestMarshaller().Marshall(describeLocationsRequest);
            var unmarshaller = DescribeLocationsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para>Returns the list of Direct Connect locations in the current AWS region. These are the locations that may be selected when calling
        /// CreateConnection or CreateInterconnect.</para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeLocations service method, as returned by AmazonDirectConnect.</returns>
        /// 
        /// <exception cref="DirectConnectServerException"/>
        /// <exception cref="DirectConnectClientException"/>
        public DescribeLocationsResponse DescribeLocations()
        {
            return DescribeLocations(new DescribeLocationsRequest());
        }
        

        #endregion
    
        #region CreatePrivateVirtualInterface

        /// <summary>
        /// <para>Creates a new private virtual interface. A virtual interface is the VLAN that transports AWS Direct Connect traffic. A private
        /// virtual interface supports sending traffic to a single Virtual Private Cloud (VPC).</para>
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
        
        

        #endregion
    
        #region DeleteVirtualInterface

        /// <summary>
        /// <para>Deletes a virtual interface.</para>
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
        
        

        #endregion
    
        #region CreatePublicVirtualInterface

        /// <summary>
        /// <para>Creates a new public virtual interface. A virtual interface is the VLAN that transports AWS Direct Connect traffic. A public virtual
        /// interface supports sending traffic to public services of AWS such as Amazon Simple Storage Service (Amazon S3).</para>
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
        
        

        #endregion
    
        #region CreateInterconnect

        /// <summary>
        /// <para>Creates a new interconnect between a Direct Connect partner's network and a specific AWS Direct Connect location.</para> <para>An
        /// interconnect is a connection which is capable of hosting other connections. The AWS Direct Connect partner can use an interconnect to
        /// provide sub-1Gbps Direct Connect service to tier 2 customers who do not have their own connections. Like a standard connection, an
        /// interconnect links the Direct Connect partner's network to an AWS Direct Connect location over a standard 1 Gbps or 10 Gbps Ethernet
        /// fiber-optic cable. One end is connected to the partner's router, the other to an AWS Direct Connect router.</para> <para>For each end
        /// customer, the Direct Connect partner provisions a connection on their interconnect by calling AllocateConnectionOnInterconnect. The end
        /// customer can then connect to AWS resources by creating a virtual interface on their connection, using the VLAN assigned to them by the
        /// Direct Connect partner.</para>
        /// </summary>
        /// 
        /// <param name="createInterconnectRequest">Container for the necessary parameters to execute the CreateInterconnect service method on
        ///          AmazonDirectConnect.</param>
        /// 
        /// <returns>The response from the CreateInterconnect service method, as returned by AmazonDirectConnect.</returns>
        /// 
        /// <exception cref="DirectConnectServerException"/>
        /// <exception cref="DirectConnectClientException"/>
        public CreateInterconnectResponse CreateInterconnect(CreateInterconnectRequest createInterconnectRequest)
        {
            IAsyncResult asyncResult = invokeCreateInterconnect(createInterconnectRequest, null, null, true);
            return EndCreateInterconnect(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CreateInterconnect operation.
        /// <seealso cref="Amazon.DirectConnect.AmazonDirectConnect.CreateInterconnect"/>
        /// </summary>
        /// 
        /// <param name="createInterconnectRequest">Container for the necessary parameters to execute the CreateInterconnect operation on
        ///          AmazonDirectConnect.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndCreateInterconnect operation.</returns>
        public IAsyncResult BeginCreateInterconnect(CreateInterconnectRequest createInterconnectRequest, AsyncCallback callback, object state)
        {
            return invokeCreateInterconnect(createInterconnectRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CreateInterconnect operation.
        /// <seealso cref="Amazon.DirectConnect.AmazonDirectConnect.CreateInterconnect"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateInterconnect.</param>
        /// 
        /// <returns>Returns a CreateInterconnectResult from AmazonDirectConnect.</returns>
        public CreateInterconnectResponse EndCreateInterconnect(IAsyncResult asyncResult)
        {
            return endOperation<CreateInterconnectResponse>(asyncResult);
        }
        
        IAsyncResult invokeCreateInterconnect(CreateInterconnectRequest createInterconnectRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreateInterconnectRequestMarshaller().Marshall(createInterconnectRequest);
            var unmarshaller = CreateInterconnectResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DescribeVirtualInterfaces

        /// <summary>
        /// <para>Displays all virtual interfaces for an AWS account. Virtual interfaces deleted fewer than 15 minutes before DescribeVirtualInterfaces
        /// is called are also returned. If a connection ID is included then only virtual interfaces associated with this connection will be returned.
        /// If a virtual interface ID is included then only a single virtual interface will be returned.</para> <para> A virtual interface (VLAN)
        /// transmits the traffic between the Direct Connect location and the customer.</para> <para>If a connection ID is provided, only virtual
        /// interfaces provisioned on the specified connection will be returned. If a virtual interface ID is provided, only this particular virtual
        /// interface will be returned.</para>
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
        /// <para>Displays all virtual interfaces for an AWS account. Virtual interfaces deleted fewer than 15 minutes before DescribeVirtualInterfaces
        /// is called are also returned. If a connection ID is included then only virtual interfaces associated with this connection will be returned.
        /// If a virtual interface ID is included then only a single virtual interface will be returned.</para> <para> A virtual interface (VLAN)
        /// transmits the traffic between the Direct Connect location and the customer.</para> <para>If a connection ID is provided, only virtual
        /// interfaces provisioned on the specified connection will be returned. If a virtual interface ID is provided, only this particular virtual
        /// interface will be returned.</para>
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
    
        #region ConfirmConnection

        /// <summary>
        /// <para>Confirm the creation of a hosted connection on an interconnect.</para> <para>Upon creation, the hosted connection is initially in the
        /// 'Ordering' state, and will remain in this state until the owner calls ConfirmConnection to confirm creation of the hosted connection.</para>
        /// </summary>
        /// 
        /// <param name="confirmConnectionRequest">Container for the necessary parameters to execute the ConfirmConnection service method on
        ///          AmazonDirectConnect.</param>
        /// 
        /// <returns>The response from the ConfirmConnection service method, as returned by AmazonDirectConnect.</returns>
        /// 
        /// <exception cref="DirectConnectServerException"/>
        /// <exception cref="DirectConnectClientException"/>
        public ConfirmConnectionResponse ConfirmConnection(ConfirmConnectionRequest confirmConnectionRequest)
        {
            IAsyncResult asyncResult = invokeConfirmConnection(confirmConnectionRequest, null, null, true);
            return EndConfirmConnection(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ConfirmConnection operation.
        /// <seealso cref="Amazon.DirectConnect.AmazonDirectConnect.ConfirmConnection"/>
        /// </summary>
        /// 
        /// <param name="confirmConnectionRequest">Container for the necessary parameters to execute the ConfirmConnection operation on
        ///          AmazonDirectConnect.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndConfirmConnection
        ///         operation.</returns>
        public IAsyncResult BeginConfirmConnection(ConfirmConnectionRequest confirmConnectionRequest, AsyncCallback callback, object state)
        {
            return invokeConfirmConnection(confirmConnectionRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ConfirmConnection operation.
        /// <seealso cref="Amazon.DirectConnect.AmazonDirectConnect.ConfirmConnection"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginConfirmConnection.</param>
        /// 
        /// <returns>Returns a ConfirmConnectionResult from AmazonDirectConnect.</returns>
        public ConfirmConnectionResponse EndConfirmConnection(IAsyncResult asyncResult)
        {
            return endOperation<ConfirmConnectionResponse>(asyncResult);
        }
        
        IAsyncResult invokeConfirmConnection(ConfirmConnectionRequest confirmConnectionRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ConfirmConnectionRequestMarshaller().Marshall(confirmConnectionRequest);
            var unmarshaller = ConfirmConnectionResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DescribeInterconnects

        /// <summary>
        /// <para>Returns a list of interconnects owned by the AWS account.</para> <para>If an interconnect ID is provided, it will only return this
        /// particular interconnect.</para>
        /// </summary>
        /// 
        /// <param name="describeInterconnectsRequest">Container for the necessary parameters to execute the DescribeInterconnects service method on
        ///          AmazonDirectConnect.</param>
        /// 
        /// <returns>The response from the DescribeInterconnects service method, as returned by AmazonDirectConnect.</returns>
        /// 
        /// <exception cref="DirectConnectServerException"/>
        /// <exception cref="DirectConnectClientException"/>
        public DescribeInterconnectsResponse DescribeInterconnects(DescribeInterconnectsRequest describeInterconnectsRequest)
        {
            IAsyncResult asyncResult = invokeDescribeInterconnects(describeInterconnectsRequest, null, null, true);
            return EndDescribeInterconnects(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInterconnects operation.
        /// <seealso cref="Amazon.DirectConnect.AmazonDirectConnect.DescribeInterconnects"/>
        /// </summary>
        /// 
        /// <param name="describeInterconnectsRequest">Container for the necessary parameters to execute the DescribeInterconnects operation on
        ///          AmazonDirectConnect.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeInterconnects operation.</returns>
        public IAsyncResult BeginDescribeInterconnects(DescribeInterconnectsRequest describeInterconnectsRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeInterconnects(describeInterconnectsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeInterconnects operation.
        /// <seealso cref="Amazon.DirectConnect.AmazonDirectConnect.DescribeInterconnects"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeInterconnects.</param>
        /// 
        /// <returns>Returns a DescribeInterconnectsResult from AmazonDirectConnect.</returns>
        public DescribeInterconnectsResponse EndDescribeInterconnects(IAsyncResult asyncResult)
        {
            return endOperation<DescribeInterconnectsResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeInterconnects(DescribeInterconnectsRequest describeInterconnectsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeInterconnectsRequestMarshaller().Marshall(describeInterconnectsRequest);
            var unmarshaller = DescribeInterconnectsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para>Returns a list of interconnects owned by the AWS account.</para> <para>If an interconnect ID is provided, it will only return this
        /// particular interconnect.</para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeInterconnects service method, as returned by AmazonDirectConnect.</returns>
        /// 
        /// <exception cref="DirectConnectServerException"/>
        /// <exception cref="DirectConnectClientException"/>
        public DescribeInterconnectsResponse DescribeInterconnects()
        {
            return DescribeInterconnects(new DescribeInterconnectsRequest());
        }
        

        #endregion
    
        #region DescribeVirtualGateways

        /// <summary>
        /// <para>Returns a list of virtual private gateways owned by the AWS account.</para> <para>You can create one or more AWS Direct Connect
        /// private virtual interfaces linking to a virtual private gateway. A virtual private gateway can be managed via Amazon Virtual Private Cloud
        /// (VPC) console or the <a href="http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-CreateVpnGateway.html" >EC2
        /// CreateVpnGateway</a> action.</para>
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
        /// <para>Returns a list of virtual private gateways owned by the AWS account.</para> <para>You can create one or more AWS Direct Connect
        /// private virtual interfaces linking to a virtual private gateway. A virtual private gateway can be managed via Amazon Virtual Private Cloud
        /// (VPC) console or the <a href="http://docs.aws.amazon.com/AWSEC2/latest/APIReference/ApiReference-query-CreateVpnGateway.html" >EC2
        /// CreateVpnGateway</a> action.</para>
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
    
        #region ConfirmPrivateVirtualInterface

        /// <summary>
        /// <para>Accept ownership of a private virtual interface created by another customer.</para> <para>After the virtual interface owner calls this
        /// function, the virtual interface will be created and attached to the given virtual private gateway, and will be available for handling
        /// traffic.</para>
        /// </summary>
        /// 
        /// <param name="confirmPrivateVirtualInterfaceRequest">Container for the necessary parameters to execute the ConfirmPrivateVirtualInterface
        ///          service method on AmazonDirectConnect.</param>
        /// 
        /// <returns>The response from the ConfirmPrivateVirtualInterface service method, as returned by AmazonDirectConnect.</returns>
        /// 
        /// <exception cref="DirectConnectServerException"/>
        /// <exception cref="DirectConnectClientException"/>
        public ConfirmPrivateVirtualInterfaceResponse ConfirmPrivateVirtualInterface(ConfirmPrivateVirtualInterfaceRequest confirmPrivateVirtualInterfaceRequest)
        {
            IAsyncResult asyncResult = invokeConfirmPrivateVirtualInterface(confirmPrivateVirtualInterfaceRequest, null, null, true);
            return EndConfirmPrivateVirtualInterface(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ConfirmPrivateVirtualInterface operation.
        /// <seealso cref="Amazon.DirectConnect.AmazonDirectConnect.ConfirmPrivateVirtualInterface"/>
        /// </summary>
        /// 
        /// <param name="confirmPrivateVirtualInterfaceRequest">Container for the necessary parameters to execute the ConfirmPrivateVirtualInterface
        ///          operation on AmazonDirectConnect.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndConfirmPrivateVirtualInterface operation.</returns>
        public IAsyncResult BeginConfirmPrivateVirtualInterface(ConfirmPrivateVirtualInterfaceRequest confirmPrivateVirtualInterfaceRequest, AsyncCallback callback, object state)
        {
            return invokeConfirmPrivateVirtualInterface(confirmPrivateVirtualInterfaceRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ConfirmPrivateVirtualInterface operation.
        /// <seealso cref="Amazon.DirectConnect.AmazonDirectConnect.ConfirmPrivateVirtualInterface"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginConfirmPrivateVirtualInterface.</param>
        /// 
        /// <returns>Returns a ConfirmPrivateVirtualInterfaceResult from AmazonDirectConnect.</returns>
        public ConfirmPrivateVirtualInterfaceResponse EndConfirmPrivateVirtualInterface(IAsyncResult asyncResult)
        {
            return endOperation<ConfirmPrivateVirtualInterfaceResponse>(asyncResult);
        }
        
        IAsyncResult invokeConfirmPrivateVirtualInterface(ConfirmPrivateVirtualInterfaceRequest confirmPrivateVirtualInterfaceRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ConfirmPrivateVirtualInterfaceRequestMarshaller().Marshall(confirmPrivateVirtualInterfaceRequest);
            var unmarshaller = ConfirmPrivateVirtualInterfaceResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
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
    
        #region AllocatePublicVirtualInterface

        /// <summary>
        /// <para>Provisions a public virtual interface to be owned by a different customer.</para> <para>The owner of a connection calls this function
        /// to provision a public virtual interface which will be owned by another AWS customer.</para> <para>Virtual interfaces created using this
        /// function must be confirmed by the virtual interface owner by calling ConfirmPublicVirtualInterface. Until this step has been completed, the
        /// virtual interface will be in 'Confirming' state, and will not be available for handling traffic.</para>
        /// </summary>
        /// 
        /// <param name="allocatePublicVirtualInterfaceRequest">Container for the necessary parameters to execute the AllocatePublicVirtualInterface
        ///          service method on AmazonDirectConnect.</param>
        /// 
        /// <returns>The response from the AllocatePublicVirtualInterface service method, as returned by AmazonDirectConnect.</returns>
        /// 
        /// <exception cref="DirectConnectServerException"/>
        /// <exception cref="DirectConnectClientException"/>
        public AllocatePublicVirtualInterfaceResponse AllocatePublicVirtualInterface(AllocatePublicVirtualInterfaceRequest allocatePublicVirtualInterfaceRequest)
        {
            IAsyncResult asyncResult = invokeAllocatePublicVirtualInterface(allocatePublicVirtualInterfaceRequest, null, null, true);
            return EndAllocatePublicVirtualInterface(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the AllocatePublicVirtualInterface operation.
        /// <seealso cref="Amazon.DirectConnect.AmazonDirectConnect.AllocatePublicVirtualInterface"/>
        /// </summary>
        /// 
        /// <param name="allocatePublicVirtualInterfaceRequest">Container for the necessary parameters to execute the AllocatePublicVirtualInterface
        ///          operation on AmazonDirectConnect.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndAllocatePublicVirtualInterface operation.</returns>
        public IAsyncResult BeginAllocatePublicVirtualInterface(AllocatePublicVirtualInterfaceRequest allocatePublicVirtualInterfaceRequest, AsyncCallback callback, object state)
        {
            return invokeAllocatePublicVirtualInterface(allocatePublicVirtualInterfaceRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the AllocatePublicVirtualInterface operation.
        /// <seealso cref="Amazon.DirectConnect.AmazonDirectConnect.AllocatePublicVirtualInterface"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAllocatePublicVirtualInterface.</param>
        /// 
        /// <returns>Returns a AllocatePublicVirtualInterfaceResult from AmazonDirectConnect.</returns>
        public AllocatePublicVirtualInterfaceResponse EndAllocatePublicVirtualInterface(IAsyncResult asyncResult)
        {
            return endOperation<AllocatePublicVirtualInterfaceResponse>(asyncResult);
        }
        
        IAsyncResult invokeAllocatePublicVirtualInterface(AllocatePublicVirtualInterfaceRequest allocatePublicVirtualInterfaceRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new AllocatePublicVirtualInterfaceRequestMarshaller().Marshall(allocatePublicVirtualInterfaceRequest);
            var unmarshaller = AllocatePublicVirtualInterfaceResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region AllocatePrivateVirtualInterface

        /// <summary>
        /// <para>Provisions a private virtual interface to be owned by a different customer.</para> <para>The owner of a connection calls this function
        /// to provision a private virtual interface which will be owned by another AWS customer.</para> <para>Virtual interfaces created using this
        /// function must be confirmed by the virtual interface owner by calling ConfirmPrivateVirtualInterface. Until this step has been completed,
        /// the virtual interface will be in 'Confirming' state, and will not be available for handling traffic.</para>
        /// </summary>
        /// 
        /// <param name="allocatePrivateVirtualInterfaceRequest">Container for the necessary parameters to execute the AllocatePrivateVirtualInterface
        ///          service method on AmazonDirectConnect.</param>
        /// 
        /// <returns>The response from the AllocatePrivateVirtualInterface service method, as returned by AmazonDirectConnect.</returns>
        /// 
        /// <exception cref="DirectConnectServerException"/>
        /// <exception cref="DirectConnectClientException"/>
        public AllocatePrivateVirtualInterfaceResponse AllocatePrivateVirtualInterface(AllocatePrivateVirtualInterfaceRequest allocatePrivateVirtualInterfaceRequest)
        {
            IAsyncResult asyncResult = invokeAllocatePrivateVirtualInterface(allocatePrivateVirtualInterfaceRequest, null, null, true);
            return EndAllocatePrivateVirtualInterface(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the AllocatePrivateVirtualInterface operation.
        /// <seealso cref="Amazon.DirectConnect.AmazonDirectConnect.AllocatePrivateVirtualInterface"/>
        /// </summary>
        /// 
        /// <param name="allocatePrivateVirtualInterfaceRequest">Container for the necessary parameters to execute the AllocatePrivateVirtualInterface
        ///          operation on AmazonDirectConnect.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndAllocatePrivateVirtualInterface operation.</returns>
        public IAsyncResult BeginAllocatePrivateVirtualInterface(AllocatePrivateVirtualInterfaceRequest allocatePrivateVirtualInterfaceRequest, AsyncCallback callback, object state)
        {
            return invokeAllocatePrivateVirtualInterface(allocatePrivateVirtualInterfaceRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the AllocatePrivateVirtualInterface operation.
        /// <seealso cref="Amazon.DirectConnect.AmazonDirectConnect.AllocatePrivateVirtualInterface"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAllocatePrivateVirtualInterface.</param>
        /// 
        /// <returns>Returns a AllocatePrivateVirtualInterfaceResult from AmazonDirectConnect.</returns>
        public AllocatePrivateVirtualInterfaceResponse EndAllocatePrivateVirtualInterface(IAsyncResult asyncResult)
        {
            return endOperation<AllocatePrivateVirtualInterfaceResponse>(asyncResult);
        }
        
        IAsyncResult invokeAllocatePrivateVirtualInterface(AllocatePrivateVirtualInterfaceRequest allocatePrivateVirtualInterfaceRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new AllocatePrivateVirtualInterfaceRequestMarshaller().Marshall(allocatePrivateVirtualInterfaceRequest);
            var unmarshaller = AllocatePrivateVirtualInterfaceResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DeleteConnection

        /// <summary>
        /// <para>Deletes the connection.</para> <para>Deleting a connection only stops the AWS Direct Connect port hour and data transfer charges. You
        /// separately need to cancel any services or charges for cross-connects or network circuits that connect you to the AWS Direct Connect location
        /// with the providers of those services.</para>
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
    
        #region DescribeConnectionsOnInterconnect

        /// <summary>
        /// <para>Return a list of connections that have been provisioned on the given interconnect.</para>
        /// </summary>
        /// 
        /// <param name="describeConnectionsOnInterconnectRequest">Container for the necessary parameters to execute the
        ///          DescribeConnectionsOnInterconnect service method on AmazonDirectConnect.</param>
        /// 
        /// <returns>The response from the DescribeConnectionsOnInterconnect service method, as returned by AmazonDirectConnect.</returns>
        /// 
        /// <exception cref="DirectConnectServerException"/>
        /// <exception cref="DirectConnectClientException"/>
        public DescribeConnectionsOnInterconnectResponse DescribeConnectionsOnInterconnect(DescribeConnectionsOnInterconnectRequest describeConnectionsOnInterconnectRequest)
        {
            IAsyncResult asyncResult = invokeDescribeConnectionsOnInterconnect(describeConnectionsOnInterconnectRequest, null, null, true);
            return EndDescribeConnectionsOnInterconnect(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeConnectionsOnInterconnect operation.
        /// <seealso cref="Amazon.DirectConnect.AmazonDirectConnect.DescribeConnectionsOnInterconnect"/>
        /// </summary>
        /// 
        /// <param name="describeConnectionsOnInterconnectRequest">Container for the necessary parameters to execute the
        ///          DescribeConnectionsOnInterconnect operation on AmazonDirectConnect.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeConnectionsOnInterconnect operation.</returns>
        public IAsyncResult BeginDescribeConnectionsOnInterconnect(DescribeConnectionsOnInterconnectRequest describeConnectionsOnInterconnectRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeConnectionsOnInterconnect(describeConnectionsOnInterconnectRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeConnectionsOnInterconnect operation.
        /// <seealso cref="Amazon.DirectConnect.AmazonDirectConnect.DescribeConnectionsOnInterconnect"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeConnectionsOnInterconnect.</param>
        /// 
        /// <returns>Returns a DescribeConnectionsOnInterconnectResult from AmazonDirectConnect.</returns>
        public DescribeConnectionsOnInterconnectResponse EndDescribeConnectionsOnInterconnect(IAsyncResult asyncResult)
        {
            return endOperation<DescribeConnectionsOnInterconnectResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeConnectionsOnInterconnect(DescribeConnectionsOnInterconnectRequest describeConnectionsOnInterconnectRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeConnectionsOnInterconnectRequestMarshaller().Marshall(describeConnectionsOnInterconnectRequest);
            var unmarshaller = DescribeConnectionsOnInterconnectResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region AllocateConnectionOnInterconnect

        /// <summary>
        /// <para>Creates a hosted connection on an interconnect.</para> <para>Allocates a VLAN number and a specified amount of bandwidth for use by a
        /// hosted connection on the given interconnect.</para>
        /// </summary>
        /// 
        /// <param name="allocateConnectionOnInterconnectRequest">Container for the necessary parameters to execute the AllocateConnectionOnInterconnect
        ///          service method on AmazonDirectConnect.</param>
        /// 
        /// <returns>The response from the AllocateConnectionOnInterconnect service method, as returned by AmazonDirectConnect.</returns>
        /// 
        /// <exception cref="DirectConnectServerException"/>
        /// <exception cref="DirectConnectClientException"/>
        public AllocateConnectionOnInterconnectResponse AllocateConnectionOnInterconnect(AllocateConnectionOnInterconnectRequest allocateConnectionOnInterconnectRequest)
        {
            IAsyncResult asyncResult = invokeAllocateConnectionOnInterconnect(allocateConnectionOnInterconnectRequest, null, null, true);
            return EndAllocateConnectionOnInterconnect(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the AllocateConnectionOnInterconnect operation.
        /// <seealso cref="Amazon.DirectConnect.AmazonDirectConnect.AllocateConnectionOnInterconnect"/>
        /// </summary>
        /// 
        /// <param name="allocateConnectionOnInterconnectRequest">Container for the necessary parameters to execute the AllocateConnectionOnInterconnect
        ///          operation on AmazonDirectConnect.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndAllocateConnectionOnInterconnect operation.</returns>
        public IAsyncResult BeginAllocateConnectionOnInterconnect(AllocateConnectionOnInterconnectRequest allocateConnectionOnInterconnectRequest, AsyncCallback callback, object state)
        {
            return invokeAllocateConnectionOnInterconnect(allocateConnectionOnInterconnectRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the AllocateConnectionOnInterconnect operation.
        /// <seealso cref="Amazon.DirectConnect.AmazonDirectConnect.AllocateConnectionOnInterconnect"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAllocateConnectionOnInterconnect.</param>
        /// 
        /// <returns>Returns a AllocateConnectionOnInterconnectResult from AmazonDirectConnect.</returns>
        public AllocateConnectionOnInterconnectResponse EndAllocateConnectionOnInterconnect(IAsyncResult asyncResult)
        {
            return endOperation<AllocateConnectionOnInterconnectResponse>(asyncResult);
        }
        
        IAsyncResult invokeAllocateConnectionOnInterconnect(AllocateConnectionOnInterconnectRequest allocateConnectionOnInterconnectRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new AllocateConnectionOnInterconnectRequestMarshaller().Marshall(allocateConnectionOnInterconnectRequest);
            var unmarshaller = AllocateConnectionOnInterconnectResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region CreateConnection

        /// <summary>
        /// <para>Creates a new connection between the customer network and a specific AWS Direct Connect location.</para> <para>A connection links your
        /// internal network to an AWS Direct Connect location over a standard 1 gigabit or 10 gigabit Ethernet fiber-optic cable. One end of the cable
        /// is connected to your router, the other to an AWS Direct Connect router. A Direct Connect location provides access to Amazon Web Services in
        /// the region it is associated with. You can establish connections with AWS Direct Connect locations in multiple regions, but a connection in
        /// one region does not provide connectivity to other regions.</para>
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
    
        #region DeleteInterconnect

        /// <summary>
        /// <para>Deletes the specified interconnect.</para>
        /// </summary>
        /// 
        /// <param name="deleteInterconnectRequest">Container for the necessary parameters to execute the DeleteInterconnect service method on
        ///          AmazonDirectConnect.</param>
        /// 
        /// <returns>The response from the DeleteInterconnect service method, as returned by AmazonDirectConnect.</returns>
        /// 
        /// <exception cref="DirectConnectServerException"/>
        /// <exception cref="DirectConnectClientException"/>
        public DeleteInterconnectResponse DeleteInterconnect(DeleteInterconnectRequest deleteInterconnectRequest)
        {
            IAsyncResult asyncResult = invokeDeleteInterconnect(deleteInterconnectRequest, null, null, true);
            return EndDeleteInterconnect(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteInterconnect operation.
        /// <seealso cref="Amazon.DirectConnect.AmazonDirectConnect.DeleteInterconnect"/>
        /// </summary>
        /// 
        /// <param name="deleteInterconnectRequest">Container for the necessary parameters to execute the DeleteInterconnect operation on
        ///          AmazonDirectConnect.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDeleteInterconnect operation.</returns>
        public IAsyncResult BeginDeleteInterconnect(DeleteInterconnectRequest deleteInterconnectRequest, AsyncCallback callback, object state)
        {
            return invokeDeleteInterconnect(deleteInterconnectRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteInterconnect operation.
        /// <seealso cref="Amazon.DirectConnect.AmazonDirectConnect.DeleteInterconnect"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteInterconnect.</param>
        /// 
        /// <returns>Returns a DeleteInterconnectResult from AmazonDirectConnect.</returns>
        public DeleteInterconnectResponse EndDeleteInterconnect(IAsyncResult asyncResult)
        {
            return endOperation<DeleteInterconnectResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeleteInterconnect(DeleteInterconnectRequest deleteInterconnectRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteInterconnectRequestMarshaller().Marshall(deleteInterconnectRequest);
            var unmarshaller = DeleteInterconnectResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
    }
}
    
