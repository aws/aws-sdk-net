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

using Amazon.EC2.Model;
using Amazon.EC2.Model.Internal.MarshallTransformations;
using Amazon.Runtime;
using Amazon.Runtime.Internal;
using Amazon.Runtime.Internal.Auth;
using Amazon.Runtime.Internal.Transform;


namespace Amazon.EC2
{
    /// <summary>
    /// Implementation for accessing AmazonEC2.
    ///  
    /// <para> Amazon Elastic Compute Cloud (Amazon EC2) is a web service that provides resizable compute capacity in the cloud. It is designed to
    /// make web-scale computing easier for developers. </para> <para> Amazon EC2's simple web service interface allows you to obtain and configure
    /// capacity with minimal friction. It provides you with complete control of your computing resources and lets you run on Amazon's proven
    /// computing environment. Amazon EC2 reduces the time required to obtain and boot new server instances to minutes, allowing you to quickly
    /// scale capacity, both up and down, as your computing requirements change. Amazon EC2 changes the economics of computing by allowing you to
    /// pay only for capacity that you actually use. Amazon EC2 provides developers the tools to build failure resilient applications and isolate
    /// themselves from common failure scenarios. </para> <para> Visit <a href="http://aws.amazon.com/ec2/" >http://aws.amazon.com/ec2/</a> for more
    /// information. </para>
    /// </summary>
    public partial class AmazonEC2Client : AmazonWebServiceClient, IAmazonEC2
    {
    QueryStringSigner signer = new QueryStringSigner();

        #region Dispose

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #endregion

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
        ///         &lt;add key="AWSAccessKey" value="********************"/&gt;
        ///         &lt;add key="AWSSecretKey" value="****************************************"/&gt;
        ///     &lt;/appSettings&gt;
        /// &lt;/configuration&gt;
        /// </code>
        ///
        /// </summary>
        public AmazonEC2Client()
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonEC2Config(), AuthenticationTypes.User | AuthenticationTypes.Session) { }

        /// <summary>
        /// Constructs AmazonEC2Client with the credentials loaded from the application's
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
        public AmazonEC2Client(RegionEndpoint region)
            : base(FallbackCredentialsFactory.GetCredentials(), new AmazonEC2Config{RegionEndpoint = region}, AuthenticationTypes.User | AuthenticationTypes.Session) { }

        /// <summary>
        /// Constructs AmazonEC2Client with the credentials loaded from the application's
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
        /// <param name="config">The AmazonEC2 Configuration Object</param>
        public AmazonEC2Client(AmazonEC2Config config)
            : base(FallbackCredentialsFactory.GetCredentials(), config, AuthenticationTypes.User | AuthenticationTypes.Session) { }

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
            : base(credentials, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
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
            : base(awsAccessKeyId, awsSecretAccessKey, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
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
            : base(awsAccessKeyId, awsSecretAccessKey, awsSessionToken, clientConfig, AuthenticationTypes.User | AuthenticationTypes.Session)
        {
        }

        #endregion


        #region AllocateAddress

        /// <summary>
        /// <para> The AllocateAddress operation acquires an elastic IP address for use with your account. </para>
        /// </summary>
        /// 
        /// <param name="allocateAddressRequest">Container for the necessary parameters to execute the AllocateAddress service method on
        ///          AmazonEC2.</param>
        /// 
        /// <returns>The response from the AllocateAddress service method, as returned by AmazonEC2.</returns>
        /// 
        public AllocateAddressResponse AllocateAddress(AllocateAddressRequest allocateAddressRequest)
        {
            IAsyncResult asyncResult = invokeAllocateAddress(allocateAddressRequest, null, null, true);
            return EndAllocateAddress(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the AllocateAddress operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.AllocateAddress"/>
        /// </summary>
        /// 
        /// <param name="allocateAddressRequest">Container for the necessary parameters to execute the AllocateAddress operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAllocateAddress
        ///         operation.</returns>
        public IAsyncResult BeginAllocateAddress(AllocateAddressRequest allocateAddressRequest, AsyncCallback callback, object state)
        {
            return invokeAllocateAddress(allocateAddressRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the AllocateAddress operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.AllocateAddress"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAllocateAddress.</param>
        /// 
        /// <returns>Returns a AllocateAddressResult from AmazonEC2.</returns>
        public AllocateAddressResponse EndAllocateAddress(IAsyncResult asyncResult)
        {
            return endOperation<AllocateAddressResponse>(asyncResult);
        }
        
        IAsyncResult invokeAllocateAddress(AllocateAddressRequest allocateAddressRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new AllocateAddressRequestMarshaller().Marshall(allocateAddressRequest);
            var unmarshaller = AllocateAddressResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para> The AllocateAddress operation acquires an elastic IP address for use with your account. </para>
        /// </summary>
        /// 
        /// <returns>The response from the AllocateAddress service method, as returned by AmazonEC2.</returns>
        /// 
        public AllocateAddressResponse AllocateAddress()
        {
            return AllocateAddress(new AllocateAddressRequest());
        }
        

        #endregion
    
        #region AssignPrivateIpAddresses

        /// <summary>
        /// </summary>
        /// 
        /// <param name="assignPrivateIpAddressesRequest">Container for the necessary parameters to execute the AssignPrivateIpAddresses service method
        ///          on AmazonEC2.</param>
        /// 
        public AssignPrivateIpAddressesResponse AssignPrivateIpAddresses(AssignPrivateIpAddressesRequest assignPrivateIpAddressesRequest)
        {
            IAsyncResult asyncResult = invokeAssignPrivateIpAddresses(assignPrivateIpAddressesRequest, null, null, true);
            return EndAssignPrivateIpAddresses(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the AssignPrivateIpAddresses operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.AssignPrivateIpAddresses"/>
        /// </summary>
        /// 
        /// <param name="assignPrivateIpAddressesRequest">Container for the necessary parameters to execute the AssignPrivateIpAddresses operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginAssignPrivateIpAddresses(AssignPrivateIpAddressesRequest assignPrivateIpAddressesRequest, AsyncCallback callback, object state)
        {
            return invokeAssignPrivateIpAddresses(assignPrivateIpAddressesRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the AssignPrivateIpAddresses operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.AssignPrivateIpAddresses"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssignPrivateIpAddresses.</param>
        public AssignPrivateIpAddressesResponse EndAssignPrivateIpAddresses(IAsyncResult asyncResult)
        {
            return endOperation<AssignPrivateIpAddressesResponse>(asyncResult);
        }
        
        IAsyncResult invokeAssignPrivateIpAddresses(AssignPrivateIpAddressesRequest assignPrivateIpAddressesRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new AssignPrivateIpAddressesRequestMarshaller().Marshall(assignPrivateIpAddressesRequest);
            var unmarshaller = AssignPrivateIpAddressesResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region AssociateAddress

        /// <summary>
        /// <para> The AssociateAddress operation associates an elastic IP address with an instance. </para> <para> If the IP address is currently
        /// assigned to another instance, the IP address is assigned to the new instance. This is an idempotent operation. If you enter it more than
        /// once, Amazon EC2 does not return an error. </para>
        /// </summary>
        /// 
        /// <param name="associateAddressRequest">Container for the necessary parameters to execute the AssociateAddress service method on
        ///          AmazonEC2.</param>
        /// 
        /// <returns>The response from the AssociateAddress service method, as returned by AmazonEC2.</returns>
        /// 
        public AssociateAddressResponse AssociateAddress(AssociateAddressRequest associateAddressRequest)
        {
            IAsyncResult asyncResult = invokeAssociateAddress(associateAddressRequest, null, null, true);
            return EndAssociateAddress(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateAddress operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.AssociateAddress"/>
        /// </summary>
        /// 
        /// <param name="associateAddressRequest">Container for the necessary parameters to execute the AssociateAddress operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAssociateAddress
        ///         operation.</returns>
        public IAsyncResult BeginAssociateAddress(AssociateAddressRequest associateAddressRequest, AsyncCallback callback, object state)
        {
            return invokeAssociateAddress(associateAddressRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the AssociateAddress operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.AssociateAddress"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateAddress.</param>
        /// 
        /// <returns>Returns a AssociateAddressResult from AmazonEC2.</returns>
        public AssociateAddressResponse EndAssociateAddress(IAsyncResult asyncResult)
        {
            return endOperation<AssociateAddressResponse>(asyncResult);
        }
        
        IAsyncResult invokeAssociateAddress(AssociateAddressRequest associateAddressRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new AssociateAddressRequestMarshaller().Marshall(associateAddressRequest);
            var unmarshaller = AssociateAddressResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region AssociateDhcpOptions

        /// <summary>
        /// <para> Associates a set of DHCP options (that you've previously created) with the specified VPC. Or, associates the default DHCP options
        /// with the VPC. The default set consists of the standard EC2 host name, no domain name, no DNS server, no NTP server, and no NetBIOS server or
        /// node type. After you associate the options with the VPC, any existing instances and all new instances that you launch in that VPC use the
        /// options. For more information about the supported DHCP options and using them with Amazon VPC, go to Using DHCP Options in the Amazon
        /// Virtual Private Cloud Developer Guide. </para>
        /// </summary>
        /// 
        /// <param name="associateDhcpOptionsRequest">Container for the necessary parameters to execute the AssociateDhcpOptions service method on
        ///          AmazonEC2.</param>
        /// 
        public AssociateDhcpOptionsResponse AssociateDhcpOptions(AssociateDhcpOptionsRequest associateDhcpOptionsRequest)
        {
            IAsyncResult asyncResult = invokeAssociateDhcpOptions(associateDhcpOptionsRequest, null, null, true);
            return EndAssociateDhcpOptions(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateDhcpOptions operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.AssociateDhcpOptions"/>
        /// </summary>
        /// 
        /// <param name="associateDhcpOptionsRequest">Container for the necessary parameters to execute the AssociateDhcpOptions operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginAssociateDhcpOptions(AssociateDhcpOptionsRequest associateDhcpOptionsRequest, AsyncCallback callback, object state)
        {
            return invokeAssociateDhcpOptions(associateDhcpOptionsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the AssociateDhcpOptions operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.AssociateDhcpOptions"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateDhcpOptions.</param>
        public AssociateDhcpOptionsResponse EndAssociateDhcpOptions(IAsyncResult asyncResult)
        {
            return endOperation<AssociateDhcpOptionsResponse>(asyncResult);
        }
        
        IAsyncResult invokeAssociateDhcpOptions(AssociateDhcpOptionsRequest associateDhcpOptionsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new AssociateDhcpOptionsRequestMarshaller().Marshall(associateDhcpOptionsRequest);
            var unmarshaller = AssociateDhcpOptionsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region AssociateRouteTable

        /// <summary>
        /// <para> Associates a subnet with a route table. The subnet and route table must be in the same VPC. This association causes traffic
        /// originating from the subnet to be routed according to the routes in the route table. The action returns an association ID, which you need if
        /// you want to disassociate the route table from the subnet later. A route table can be associated with multiple subnets. </para> <para> For
        /// more information about route tables, go to <a href="http://docs.amazonwebservices.com/AmazonVPC/latest/UserGuide/VPC_Route_Tables.html"
        /// >Route Tables</a> in the Amazon Virtual Private Cloud User Guide. </para>
        /// </summary>
        /// 
        /// <param name="associateRouteTableRequest">Container for the necessary parameters to execute the AssociateRouteTable service method on
        ///          AmazonEC2.</param>
        /// 
        /// <returns>The response from the AssociateRouteTable service method, as returned by AmazonEC2.</returns>
        /// 
        public AssociateRouteTableResponse AssociateRouteTable(AssociateRouteTableRequest associateRouteTableRequest)
        {
            IAsyncResult asyncResult = invokeAssociateRouteTable(associateRouteTableRequest, null, null, true);
            return EndAssociateRouteTable(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the AssociateRouteTable operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.AssociateRouteTable"/>
        /// </summary>
        /// 
        /// <param name="associateRouteTableRequest">Container for the necessary parameters to execute the AssociateRouteTable operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndAssociateRouteTable operation.</returns>
        public IAsyncResult BeginAssociateRouteTable(AssociateRouteTableRequest associateRouteTableRequest, AsyncCallback callback, object state)
        {
            return invokeAssociateRouteTable(associateRouteTableRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the AssociateRouteTable operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.AssociateRouteTable"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAssociateRouteTable.</param>
        /// 
        /// <returns>Returns a AssociateRouteTableResult from AmazonEC2.</returns>
        public AssociateRouteTableResponse EndAssociateRouteTable(IAsyncResult asyncResult)
        {
            return endOperation<AssociateRouteTableResponse>(asyncResult);
        }
        
        IAsyncResult invokeAssociateRouteTable(AssociateRouteTableRequest associateRouteTableRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new AssociateRouteTableRequestMarshaller().Marshall(associateRouteTableRequest);
            var unmarshaller = AssociateRouteTableResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region AttachInternetGateway

        /// <summary>
        /// <para> Attaches an Internet gateway to a VPC, enabling connectivity between the Internet and the VPC. For more information about your VPC
        /// and Internet gateway, go to the Amazon Virtual Private Cloud User Guide. </para>
        /// </summary>
        /// 
        /// <param name="attachInternetGatewayRequest">Container for the necessary parameters to execute the AttachInternetGateway service method on
        ///          AmazonEC2.</param>
        /// 
        public AttachInternetGatewayResponse AttachInternetGateway(AttachInternetGatewayRequest attachInternetGatewayRequest)
        {
            IAsyncResult asyncResult = invokeAttachInternetGateway(attachInternetGatewayRequest, null, null, true);
            return EndAttachInternetGateway(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the AttachInternetGateway operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.AttachInternetGateway"/>
        /// </summary>
        /// 
        /// <param name="attachInternetGatewayRequest">Container for the necessary parameters to execute the AttachInternetGateway operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginAttachInternetGateway(AttachInternetGatewayRequest attachInternetGatewayRequest, AsyncCallback callback, object state)
        {
            return invokeAttachInternetGateway(attachInternetGatewayRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the AttachInternetGateway operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.AttachInternetGateway"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAttachInternetGateway.</param>
        public AttachInternetGatewayResponse EndAttachInternetGateway(IAsyncResult asyncResult)
        {
            return endOperation<AttachInternetGatewayResponse>(asyncResult);
        }
        
        IAsyncResult invokeAttachInternetGateway(AttachInternetGatewayRequest attachInternetGatewayRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new AttachInternetGatewayRequestMarshaller().Marshall(attachInternetGatewayRequest);
            var unmarshaller = AttachInternetGatewayResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region AttachNetworkInterface

        /// <summary>
        /// </summary>
        /// 
        /// <param name="attachNetworkInterfaceRequest">Container for the necessary parameters to execute the AttachNetworkInterface service method on
        ///          AmazonEC2.</param>
        /// 
        /// <returns>The response from the AttachNetworkInterface service method, as returned by AmazonEC2.</returns>
        /// 
        public AttachNetworkInterfaceResponse AttachNetworkInterface(AttachNetworkInterfaceRequest attachNetworkInterfaceRequest)
        {
            IAsyncResult asyncResult = invokeAttachNetworkInterface(attachNetworkInterfaceRequest, null, null, true);
            return EndAttachNetworkInterface(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the AttachNetworkInterface operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.AttachNetworkInterface"/>
        /// </summary>
        /// 
        /// <param name="attachNetworkInterfaceRequest">Container for the necessary parameters to execute the AttachNetworkInterface operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndAttachNetworkInterface operation.</returns>
        public IAsyncResult BeginAttachNetworkInterface(AttachNetworkInterfaceRequest attachNetworkInterfaceRequest, AsyncCallback callback, object state)
        {
            return invokeAttachNetworkInterface(attachNetworkInterfaceRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the AttachNetworkInterface operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.AttachNetworkInterface"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAttachNetworkInterface.</param>
        /// 
        /// <returns>Returns a AttachNetworkInterfaceResult from AmazonEC2.</returns>
        public AttachNetworkInterfaceResponse EndAttachNetworkInterface(IAsyncResult asyncResult)
        {
            return endOperation<AttachNetworkInterfaceResponse>(asyncResult);
        }
        
        IAsyncResult invokeAttachNetworkInterface(AttachNetworkInterfaceRequest attachNetworkInterfaceRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new AttachNetworkInterfaceRequestMarshaller().Marshall(attachNetworkInterfaceRequest);
            var unmarshaller = AttachNetworkInterfaceResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region AttachVolume

        /// <summary>
        /// <para> Attach a previously created volume to a running instance. </para>
        /// </summary>
        /// 
        /// <param name="attachVolumeRequest">Container for the necessary parameters to execute the AttachVolume service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the AttachVolume service method, as returned by AmazonEC2.</returns>
        /// 
        public AttachVolumeResponse AttachVolume(AttachVolumeRequest attachVolumeRequest)
        {
            IAsyncResult asyncResult = invokeAttachVolume(attachVolumeRequest, null, null, true);
            return EndAttachVolume(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the AttachVolume operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.AttachVolume"/>
        /// </summary>
        /// 
        /// <param name="attachVolumeRequest">Container for the necessary parameters to execute the AttachVolume operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAttachVolume
        ///         operation.</returns>
        public IAsyncResult BeginAttachVolume(AttachVolumeRequest attachVolumeRequest, AsyncCallback callback, object state)
        {
            return invokeAttachVolume(attachVolumeRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the AttachVolume operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.AttachVolume"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAttachVolume.</param>
        /// 
        /// <returns>Returns a AttachVolumeResult from AmazonEC2.</returns>
        public AttachVolumeResponse EndAttachVolume(IAsyncResult asyncResult)
        {
            return endOperation<AttachVolumeResponse>(asyncResult);
        }
        
        IAsyncResult invokeAttachVolume(AttachVolumeRequest attachVolumeRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new AttachVolumeRequestMarshaller().Marshall(attachVolumeRequest);
            var unmarshaller = AttachVolumeResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region AttachVpnGateway

        /// <summary>
        /// <para> Attaches a VPN gateway to a VPC. This is the last step required to get your VPC fully connected to your data center before launching
        /// instances in it. For more information, go to Process for Using Amazon VPC in the Amazon Virtual Private Cloud Developer Guide. </para>
        /// </summary>
        /// 
        /// <param name="attachVpnGatewayRequest">Container for the necessary parameters to execute the AttachVpnGateway service method on
        ///          AmazonEC2.</param>
        /// 
        /// <returns>The response from the AttachVpnGateway service method, as returned by AmazonEC2.</returns>
        /// 
        public AttachVpnGatewayResponse AttachVpnGateway(AttachVpnGatewayRequest attachVpnGatewayRequest)
        {
            IAsyncResult asyncResult = invokeAttachVpnGateway(attachVpnGatewayRequest, null, null, true);
            return EndAttachVpnGateway(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the AttachVpnGateway operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.AttachVpnGateway"/>
        /// </summary>
        /// 
        /// <param name="attachVpnGatewayRequest">Container for the necessary parameters to execute the AttachVpnGateway operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndAttachVpnGateway
        ///         operation.</returns>
        public IAsyncResult BeginAttachVpnGateway(AttachVpnGatewayRequest attachVpnGatewayRequest, AsyncCallback callback, object state)
        {
            return invokeAttachVpnGateway(attachVpnGatewayRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the AttachVpnGateway operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.AttachVpnGateway"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAttachVpnGateway.</param>
        /// 
        /// <returns>Returns a AttachVpnGatewayResult from AmazonEC2.</returns>
        public AttachVpnGatewayResponse EndAttachVpnGateway(IAsyncResult asyncResult)
        {
            return endOperation<AttachVpnGatewayResponse>(asyncResult);
        }
        
        IAsyncResult invokeAttachVpnGateway(AttachVpnGatewayRequest attachVpnGatewayRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new AttachVpnGatewayRequestMarshaller().Marshall(attachVpnGatewayRequest);
            var unmarshaller = AttachVpnGatewayResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region AuthorizeSecurityGroupEgress

        /// <summary>
        /// <para> This action applies only to security groups in a VPC; it's not supported for EC2 security groups. For information about Amazon
        /// Virtual Private Cloud and VPC security groups, go to the Amazon Virtual Private Cloud User Guide. </para> <para> The action adds one or more
        /// egress rules to a VPC security group. Specifically, this permits instances in a security group to send traffic to either one or more
        /// destination CIDR IP address ranges, or to one or more destination security groups in the same VPC. </para> <para> Each rule consists of the
        /// protocol (e.g., TCP), plus either a CIDR range, or a source group. For the TCP and UDP protocols, you must also specify the destination port
        /// or port range. For the ICMP protocol, you must also specify the ICMP type and code. You can use <c>-1</c> as a wildcard for the ICMP type or
        /// code. </para> <para> Rule changes are propagated to instances within the security group as quickly as possible. However, a small delay might
        /// occur. </para> <para> <b>Important:</b> For VPC security groups: You can have up to 50 rules total per group (covering both ingress and
        /// egress). </para>
        /// </summary>
        /// 
        /// <param name="authorizeSecurityGroupEgressRequest">Container for the necessary parameters to execute the AuthorizeSecurityGroupEgress service
        ///          method on AmazonEC2.</param>
        /// 
        public AuthorizeSecurityGroupEgressResponse AuthorizeSecurityGroupEgress(AuthorizeSecurityGroupEgressRequest authorizeSecurityGroupEgressRequest)
        {
            IAsyncResult asyncResult = invokeAuthorizeSecurityGroupEgress(authorizeSecurityGroupEgressRequest, null, null, true);
            return EndAuthorizeSecurityGroupEgress(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the AuthorizeSecurityGroupEgress operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.AuthorizeSecurityGroupEgress"/>
        /// </summary>
        /// 
        /// <param name="authorizeSecurityGroupEgressRequest">Container for the necessary parameters to execute the AuthorizeSecurityGroupEgress
        ///          operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginAuthorizeSecurityGroupEgress(AuthorizeSecurityGroupEgressRequest authorizeSecurityGroupEgressRequest, AsyncCallback callback, object state)
        {
            return invokeAuthorizeSecurityGroupEgress(authorizeSecurityGroupEgressRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the AuthorizeSecurityGroupEgress operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.AuthorizeSecurityGroupEgress"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAuthorizeSecurityGroupEgress.</param>
        public AuthorizeSecurityGroupEgressResponse EndAuthorizeSecurityGroupEgress(IAsyncResult asyncResult)
        {
            return endOperation<AuthorizeSecurityGroupEgressResponse>(asyncResult);
        }
        
        IAsyncResult invokeAuthorizeSecurityGroupEgress(AuthorizeSecurityGroupEgressRequest authorizeSecurityGroupEgressRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new AuthorizeSecurityGroupEgressRequestMarshaller().Marshall(authorizeSecurityGroupEgressRequest);
            var unmarshaller = AuthorizeSecurityGroupEgressResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region AuthorizeSecurityGroupIngress

        /// <summary>
        /// <para> The AuthorizeSecurityGroupIngress operation adds permissions to a security group. </para> <para> Permissions are specified by the IP
        /// protocol (TCP, UDP or ICMP), the source of the request (by IP range or an Amazon EC2 user-group pair), the source and destination port
        /// ranges (for TCP and UDP), and the ICMP codes and types (for ICMP). When authorizing ICMP, <c>-1</c> can be used as a wildcard in the type
        /// and code fields. </para> <para> Permission changes are propagated to instances within the security group as quickly as possible. However,
        /// depending on the number of instances, a small delay might occur. </para>
        /// </summary>
        /// 
        /// <param name="authorizeSecurityGroupIngressRequest">Container for the necessary parameters to execute the AuthorizeSecurityGroupIngress
        ///          service method on AmazonEC2.</param>
        /// 
        public AuthorizeSecurityGroupIngressResponse AuthorizeSecurityGroupIngress(AuthorizeSecurityGroupIngressRequest authorizeSecurityGroupIngressRequest)
        {
            IAsyncResult asyncResult = invokeAuthorizeSecurityGroupIngress(authorizeSecurityGroupIngressRequest, null, null, true);
            return EndAuthorizeSecurityGroupIngress(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the AuthorizeSecurityGroupIngress operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.AuthorizeSecurityGroupIngress"/>
        /// </summary>
        /// 
        /// <param name="authorizeSecurityGroupIngressRequest">Container for the necessary parameters to execute the AuthorizeSecurityGroupIngress
        ///          operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginAuthorizeSecurityGroupIngress(AuthorizeSecurityGroupIngressRequest authorizeSecurityGroupIngressRequest, AsyncCallback callback, object state)
        {
            return invokeAuthorizeSecurityGroupIngress(authorizeSecurityGroupIngressRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the AuthorizeSecurityGroupIngress operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.AuthorizeSecurityGroupIngress"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginAuthorizeSecurityGroupIngress.</param>
        public AuthorizeSecurityGroupIngressResponse EndAuthorizeSecurityGroupIngress(IAsyncResult asyncResult)
        {
            return endOperation<AuthorizeSecurityGroupIngressResponse>(asyncResult);
        }
        
        IAsyncResult invokeAuthorizeSecurityGroupIngress(AuthorizeSecurityGroupIngressRequest authorizeSecurityGroupIngressRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new AuthorizeSecurityGroupIngressRequestMarshaller().Marshall(authorizeSecurityGroupIngressRequest);
            var unmarshaller = AuthorizeSecurityGroupIngressResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region BundleInstance

        /// <summary>
        /// <para> The BundleInstance operation request that an instance is bundled the next time it boots. The bundling process creates a new image
        /// from a running instance and stores the AMI data in S3. Once bundled, the image must be registered in the normal way using the RegisterImage
        /// API. </para>
        /// </summary>
        /// 
        /// <param name="bundleInstanceRequest">Container for the necessary parameters to execute the BundleInstance service method on
        ///          AmazonEC2.</param>
        /// 
        /// <returns>The response from the BundleInstance service method, as returned by AmazonEC2.</returns>
        /// 
        public BundleInstanceResponse BundleInstance(BundleInstanceRequest bundleInstanceRequest)
        {
            IAsyncResult asyncResult = invokeBundleInstance(bundleInstanceRequest, null, null, true);
            return EndBundleInstance(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the BundleInstance operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.BundleInstance"/>
        /// </summary>
        /// 
        /// <param name="bundleInstanceRequest">Container for the necessary parameters to execute the BundleInstance operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndBundleInstance
        ///         operation.</returns>
        public IAsyncResult BeginBundleInstance(BundleInstanceRequest bundleInstanceRequest, AsyncCallback callback, object state)
        {
            return invokeBundleInstance(bundleInstanceRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the BundleInstance operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.BundleInstance"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginBundleInstance.</param>
        /// 
        /// <returns>Returns a BundleInstanceResult from AmazonEC2.</returns>
        public BundleInstanceResponse EndBundleInstance(IAsyncResult asyncResult)
        {
            return endOperation<BundleInstanceResponse>(asyncResult);
        }
        
        IAsyncResult invokeBundleInstance(BundleInstanceRequest bundleInstanceRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new BundleInstanceRequestMarshaller().Marshall(bundleInstanceRequest);
            var unmarshaller = BundleInstanceResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region CancelBundleTask

        /// <summary>
        /// <para> CancelBundleTask operation cancels a pending or in-progress bundling task. This is an asynchronous call and it make take a while for
        /// the task to be canceled. If a task is canceled while it is storing items, there may be parts of the incomplete AMI stored in S3. It is up to
        /// the caller to clean up these parts from S3. </para>
        /// </summary>
        /// 
        /// <param name="cancelBundleTaskRequest">Container for the necessary parameters to execute the CancelBundleTask service method on
        ///          AmazonEC2.</param>
        /// 
        /// <returns>The response from the CancelBundleTask service method, as returned by AmazonEC2.</returns>
        /// 
        public CancelBundleTaskResponse CancelBundleTask(CancelBundleTaskRequest cancelBundleTaskRequest)
        {
            IAsyncResult asyncResult = invokeCancelBundleTask(cancelBundleTaskRequest, null, null, true);
            return EndCancelBundleTask(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CancelBundleTask operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CancelBundleTask"/>
        /// </summary>
        /// 
        /// <param name="cancelBundleTaskRequest">Container for the necessary parameters to execute the CancelBundleTask operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCancelBundleTask
        ///         operation.</returns>
        public IAsyncResult BeginCancelBundleTask(CancelBundleTaskRequest cancelBundleTaskRequest, AsyncCallback callback, object state)
        {
            return invokeCancelBundleTask(cancelBundleTaskRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CancelBundleTask operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CancelBundleTask"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelBundleTask.</param>
        /// 
        /// <returns>Returns a CancelBundleTaskResult from AmazonEC2.</returns>
        public CancelBundleTaskResponse EndCancelBundleTask(IAsyncResult asyncResult)
        {
            return endOperation<CancelBundleTaskResponse>(asyncResult);
        }
        
        IAsyncResult invokeCancelBundleTask(CancelBundleTaskRequest cancelBundleTaskRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CancelBundleTaskRequestMarshaller().Marshall(cancelBundleTaskRequest);
            var unmarshaller = CancelBundleTaskResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region CancelConversionTask

        /// <summary>
        /// </summary>
        /// 
        /// <param name="cancelConversionTaskRequest">Container for the necessary parameters to execute the CancelConversionTask service method on
        ///          AmazonEC2.</param>
        /// 
        public CancelConversionTaskResponse CancelConversionTask(CancelConversionTaskRequest cancelConversionTaskRequest)
        {
            IAsyncResult asyncResult = invokeCancelConversionTask(cancelConversionTaskRequest, null, null, true);
            return EndCancelConversionTask(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CancelConversionTask operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CancelConversionTask"/>
        /// </summary>
        /// 
        /// <param name="cancelConversionTaskRequest">Container for the necessary parameters to execute the CancelConversionTask operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginCancelConversionTask(CancelConversionTaskRequest cancelConversionTaskRequest, AsyncCallback callback, object state)
        {
            return invokeCancelConversionTask(cancelConversionTaskRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CancelConversionTask operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CancelConversionTask"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelConversionTask.</param>
        public CancelConversionTaskResponse EndCancelConversionTask(IAsyncResult asyncResult)
        {
            return endOperation<CancelConversionTaskResponse>(asyncResult);
        }
        
        IAsyncResult invokeCancelConversionTask(CancelConversionTaskRequest cancelConversionTaskRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CancelConversionTaskRequestMarshaller().Marshall(cancelConversionTaskRequest);
            var unmarshaller = CancelConversionTaskResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region CancelExportTask

        /// <summary>
        /// </summary>
        /// 
        /// <param name="cancelExportTaskRequest">Container for the necessary parameters to execute the CancelExportTask service method on
        ///          AmazonEC2.</param>
        /// 
        public CancelExportTaskResponse CancelExportTask(CancelExportTaskRequest cancelExportTaskRequest)
        {
            IAsyncResult asyncResult = invokeCancelExportTask(cancelExportTaskRequest, null, null, true);
            return EndCancelExportTask(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CancelExportTask operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CancelExportTask"/>
        /// </summary>
        /// 
        /// <param name="cancelExportTaskRequest">Container for the necessary parameters to execute the CancelExportTask operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginCancelExportTask(CancelExportTaskRequest cancelExportTaskRequest, AsyncCallback callback, object state)
        {
            return invokeCancelExportTask(cancelExportTaskRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CancelExportTask operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CancelExportTask"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelExportTask.</param>
        public CancelExportTaskResponse EndCancelExportTask(IAsyncResult asyncResult)
        {
            return endOperation<CancelExportTaskResponse>(asyncResult);
        }
        
        IAsyncResult invokeCancelExportTask(CancelExportTaskRequest cancelExportTaskRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CancelExportTaskRequestMarshaller().Marshall(cancelExportTaskRequest);
            var unmarshaller = CancelExportTaskResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region CancelReservedInstancesListing

        /// <summary>
        /// </summary>
        /// 
        /// <param name="cancelReservedInstancesListingRequest">Container for the necessary parameters to execute the CancelReservedInstancesListing
        ///          service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the CancelReservedInstancesListing service method, as returned by AmazonEC2.</returns>
        /// 
        public CancelReservedInstancesListingResponse CancelReservedInstancesListing(CancelReservedInstancesListingRequest cancelReservedInstancesListingRequest)
        {
            IAsyncResult asyncResult = invokeCancelReservedInstancesListing(cancelReservedInstancesListingRequest, null, null, true);
            return EndCancelReservedInstancesListing(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CancelReservedInstancesListing operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CancelReservedInstancesListing"/>
        /// </summary>
        /// 
        /// <param name="cancelReservedInstancesListingRequest">Container for the necessary parameters to execute the CancelReservedInstancesListing
        ///          operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndCancelReservedInstancesListing operation.</returns>
        public IAsyncResult BeginCancelReservedInstancesListing(CancelReservedInstancesListingRequest cancelReservedInstancesListingRequest, AsyncCallback callback, object state)
        {
            return invokeCancelReservedInstancesListing(cancelReservedInstancesListingRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CancelReservedInstancesListing operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CancelReservedInstancesListing"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelReservedInstancesListing.</param>
        /// 
        /// <returns>Returns a CancelReservedInstancesListingResult from AmazonEC2.</returns>
        public CancelReservedInstancesListingResponse EndCancelReservedInstancesListing(IAsyncResult asyncResult)
        {
            return endOperation<CancelReservedInstancesListingResponse>(asyncResult);
        }
        
        IAsyncResult invokeCancelReservedInstancesListing(CancelReservedInstancesListingRequest cancelReservedInstancesListingRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CancelReservedInstancesListingRequestMarshaller().Marshall(cancelReservedInstancesListingRequest);
            var unmarshaller = CancelReservedInstancesListingResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region CancelSpotInstanceRequests

        /// <summary>
        /// <para> Cancels one or more Spot Instance requests. </para> <para> Spot Instances are instances that Amazon EC2 starts on your behalf when
        /// the maximum price that you specify exceeds the current Spot Price. Amazon EC2 periodically sets the Spot Price based on available Spot
        /// Instance capacity and current spot instance requests. </para> <para> For conceptual information about Spot Instances, refer to the Amazon
        /// Elastic Compute Cloud Developer Guide or Amazon Elastic Compute Cloud User Guide .
        /// </para>
        /// </summary>
        /// 
        /// <param name="cancelSpotInstanceRequestsRequest">Container for the necessary parameters to execute the CancelSpotInstanceRequests service
        ///          method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the CancelSpotInstanceRequests service method, as returned by AmazonEC2.</returns>
        /// 
        public CancelSpotInstanceRequestsResponse CancelSpotInstanceRequests(CancelSpotInstanceRequestsRequest cancelSpotInstanceRequestsRequest)
        {
            IAsyncResult asyncResult = invokeCancelSpotInstanceRequests(cancelSpotInstanceRequestsRequest, null, null, true);
            return EndCancelSpotInstanceRequests(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CancelSpotInstanceRequests operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CancelSpotInstanceRequests"/>
        /// </summary>
        /// 
        /// <param name="cancelSpotInstanceRequestsRequest">Container for the necessary parameters to execute the CancelSpotInstanceRequests operation
        ///          on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndCancelSpotInstanceRequests operation.</returns>
        public IAsyncResult BeginCancelSpotInstanceRequests(CancelSpotInstanceRequestsRequest cancelSpotInstanceRequestsRequest, AsyncCallback callback, object state)
        {
            return invokeCancelSpotInstanceRequests(cancelSpotInstanceRequestsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CancelSpotInstanceRequests operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CancelSpotInstanceRequests"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCancelSpotInstanceRequests.</param>
        /// 
        /// <returns>Returns a CancelSpotInstanceRequestsResult from AmazonEC2.</returns>
        public CancelSpotInstanceRequestsResponse EndCancelSpotInstanceRequests(IAsyncResult asyncResult)
        {
            return endOperation<CancelSpotInstanceRequestsResponse>(asyncResult);
        }
        
        IAsyncResult invokeCancelSpotInstanceRequests(CancelSpotInstanceRequestsRequest cancelSpotInstanceRequestsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CancelSpotInstanceRequestsRequestMarshaller().Marshall(cancelSpotInstanceRequestsRequest);
            var unmarshaller = CancelSpotInstanceRequestsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region ConfirmProductInstance

        /// <summary>
        /// <para> The ConfirmProductInstance operation returns true if the specified product code is attached to the specified instance. The operation
        /// returns false if the product code is not attached to the instance. </para> <para> The ConfirmProductInstance operation can only be executed
        /// by the owner of the AMI. This feature is useful when an AMI owner is providing support and wants to verify whether a user's instance is
        /// eligible. </para>
        /// </summary>
        /// 
        /// <param name="confirmProductInstanceRequest">Container for the necessary parameters to execute the ConfirmProductInstance service method on
        ///          AmazonEC2.</param>
        /// 
        /// <returns>The response from the ConfirmProductInstance service method, as returned by AmazonEC2.</returns>
        /// 
        public ConfirmProductInstanceResponse ConfirmProductInstance(ConfirmProductInstanceRequest confirmProductInstanceRequest)
        {
            IAsyncResult asyncResult = invokeConfirmProductInstance(confirmProductInstanceRequest, null, null, true);
            return EndConfirmProductInstance(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ConfirmProductInstance operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ConfirmProductInstance"/>
        /// </summary>
        /// 
        /// <param name="confirmProductInstanceRequest">Container for the necessary parameters to execute the ConfirmProductInstance operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndConfirmProductInstance operation.</returns>
        public IAsyncResult BeginConfirmProductInstance(ConfirmProductInstanceRequest confirmProductInstanceRequest, AsyncCallback callback, object state)
        {
            return invokeConfirmProductInstance(confirmProductInstanceRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ConfirmProductInstance operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ConfirmProductInstance"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginConfirmProductInstance.</param>
        /// 
        /// <returns>Returns a ConfirmProductInstanceResult from AmazonEC2.</returns>
        public ConfirmProductInstanceResponse EndConfirmProductInstance(IAsyncResult asyncResult)
        {
            return endOperation<ConfirmProductInstanceResponse>(asyncResult);
        }
        
        IAsyncResult invokeConfirmProductInstance(ConfirmProductInstanceRequest confirmProductInstanceRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ConfirmProductInstanceRequestMarshaller().Marshall(confirmProductInstanceRequest);
            var unmarshaller = ConfirmProductInstanceResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region CopyImage

        /// <summary>
        /// </summary>
        /// 
        /// <param name="copyImageRequest">Container for the necessary parameters to execute the CopyImage service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the CopyImage service method, as returned by AmazonEC2.</returns>
        /// 
        public CopyImageResponse CopyImage(CopyImageRequest copyImageRequest)
        {
            IAsyncResult asyncResult = invokeCopyImage(copyImageRequest, null, null, true);
            return EndCopyImage(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CopyImage operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CopyImage"/>
        /// </summary>
        /// 
        /// <param name="copyImageRequest">Container for the necessary parameters to execute the CopyImage operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCopyImage
        ///         operation.</returns>
        public IAsyncResult BeginCopyImage(CopyImageRequest copyImageRequest, AsyncCallback callback, object state)
        {
            return invokeCopyImage(copyImageRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CopyImage operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CopyImage"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCopyImage.</param>
        /// 
        /// <returns>Returns a CopyImageResult from AmazonEC2.</returns>
        public CopyImageResponse EndCopyImage(IAsyncResult asyncResult)
        {
            return endOperation<CopyImageResponse>(asyncResult);
        }
        
        IAsyncResult invokeCopyImage(CopyImageRequest copyImageRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CopyImageRequestMarshaller().Marshall(copyImageRequest);
            var unmarshaller = CopyImageResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region CopySnapshot

        /// <summary>
        /// </summary>
        /// 
        /// <param name="copySnapshotRequest">Container for the necessary parameters to execute the CopySnapshot service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the CopySnapshot service method, as returned by AmazonEC2.</returns>
        /// 
        public CopySnapshotResponse CopySnapshot(CopySnapshotRequest copySnapshotRequest)
        {
            IAsyncResult asyncResult = invokeCopySnapshot(copySnapshotRequest, null, null, true);
            return EndCopySnapshot(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CopySnapshot operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CopySnapshot"/>
        /// </summary>
        /// 
        /// <param name="copySnapshotRequest">Container for the necessary parameters to execute the CopySnapshot operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCopySnapshot
        ///         operation.</returns>
        public IAsyncResult BeginCopySnapshot(CopySnapshotRequest copySnapshotRequest, AsyncCallback callback, object state)
        {
            return invokeCopySnapshot(copySnapshotRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CopySnapshot operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CopySnapshot"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCopySnapshot.</param>
        /// 
        /// <returns>Returns a CopySnapshotResult from AmazonEC2.</returns>
        public CopySnapshotResponse EndCopySnapshot(IAsyncResult asyncResult)
        {
            return endOperation<CopySnapshotResponse>(asyncResult);
        }
        
        IAsyncResult invokeCopySnapshot(CopySnapshotRequest copySnapshotRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CopySnapshotRequestMarshaller().Marshall(copySnapshotRequest);
            var unmarshaller = CopySnapshotResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region CreateCustomerGateway

        /// <summary>
        /// <para> Provides information to AWS about your customer gateway device. The customer gateway is the appliance at your end of the VPN
        /// connection (compared to the VPN gateway, which is the device at the AWS side of the VPN connection). You can have a single active customer
        /// gateway per AWS account (active means that you've created a VPN connection to use with the customer gateway). AWS might delete any customer
        /// gateway that you create with this operation if you leave it inactive for an extended period of time. </para> <para> You must provide the
        /// Internet-routable IP address of the customer gateway's external interface. The IP address must be static. </para> <para> You must also
        /// provide the device's Border Gateway Protocol (BGP) Autonomous System Number (ASN). You can use an existing ASN assigned to your network. If
        /// you don't have an ASN already, you can use a private ASN (in the 64512 - 65534 range). For more information about ASNs, go to <a
        /// href="http://en.wikipedia.org/wiki/Autonomous_system_%28Internet%29" > http://en.wikipedia.org/wiki/Autonomous_system_%28Internet%29</a> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="createCustomerGatewayRequest">Container for the necessary parameters to execute the CreateCustomerGateway service method on
        ///          AmazonEC2.</param>
        /// 
        /// <returns>The response from the CreateCustomerGateway service method, as returned by AmazonEC2.</returns>
        /// 
        public CreateCustomerGatewayResponse CreateCustomerGateway(CreateCustomerGatewayRequest createCustomerGatewayRequest)
        {
            IAsyncResult asyncResult = invokeCreateCustomerGateway(createCustomerGatewayRequest, null, null, true);
            return EndCreateCustomerGateway(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CreateCustomerGateway operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateCustomerGateway"/>
        /// </summary>
        /// 
        /// <param name="createCustomerGatewayRequest">Container for the necessary parameters to execute the CreateCustomerGateway operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndCreateCustomerGateway operation.</returns>
        public IAsyncResult BeginCreateCustomerGateway(CreateCustomerGatewayRequest createCustomerGatewayRequest, AsyncCallback callback, object state)
        {
            return invokeCreateCustomerGateway(createCustomerGatewayRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CreateCustomerGateway operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateCustomerGateway"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateCustomerGateway.</param>
        /// 
        /// <returns>Returns a CreateCustomerGatewayResult from AmazonEC2.</returns>
        public CreateCustomerGatewayResponse EndCreateCustomerGateway(IAsyncResult asyncResult)
        {
            return endOperation<CreateCustomerGatewayResponse>(asyncResult);
        }
        
        IAsyncResult invokeCreateCustomerGateway(CreateCustomerGatewayRequest createCustomerGatewayRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreateCustomerGatewayRequestMarshaller().Marshall(createCustomerGatewayRequest);
            var unmarshaller = CreateCustomerGatewayResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region CreateDhcpOptions

        /// <summary>
        /// <para> Creates a set of DHCP options that you can then associate with one or more VPCs, causing all existing and new instances that you
        /// launch in those VPCs to use the set of DHCP options. The following table lists the individual DHCP options you can specify. For more
        /// information about the options, go to <a href="http://www.ietf.org/rfc/rfc2132.txt" >http://www.ietf.org/rfc/rfc2132.txt</a> </para>
        /// </summary>
        /// 
        /// <param name="createDhcpOptionsRequest">Container for the necessary parameters to execute the CreateDhcpOptions service method on
        ///          AmazonEC2.</param>
        /// 
        /// <returns>The response from the CreateDhcpOptions service method, as returned by AmazonEC2.</returns>
        /// 
        public CreateDhcpOptionsResponse CreateDhcpOptions(CreateDhcpOptionsRequest createDhcpOptionsRequest)
        {
            IAsyncResult asyncResult = invokeCreateDhcpOptions(createDhcpOptionsRequest, null, null, true);
            return EndCreateDhcpOptions(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CreateDhcpOptions operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateDhcpOptions"/>
        /// </summary>
        /// 
        /// <param name="createDhcpOptionsRequest">Container for the necessary parameters to execute the CreateDhcpOptions operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateDhcpOptions
        ///         operation.</returns>
        public IAsyncResult BeginCreateDhcpOptions(CreateDhcpOptionsRequest createDhcpOptionsRequest, AsyncCallback callback, object state)
        {
            return invokeCreateDhcpOptions(createDhcpOptionsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CreateDhcpOptions operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateDhcpOptions"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateDhcpOptions.</param>
        /// 
        /// <returns>Returns a CreateDhcpOptionsResult from AmazonEC2.</returns>
        public CreateDhcpOptionsResponse EndCreateDhcpOptions(IAsyncResult asyncResult)
        {
            return endOperation<CreateDhcpOptionsResponse>(asyncResult);
        }
        
        IAsyncResult invokeCreateDhcpOptions(CreateDhcpOptionsRequest createDhcpOptionsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreateDhcpOptionsRequestMarshaller().Marshall(createDhcpOptionsRequest);
            var unmarshaller = CreateDhcpOptionsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region CreateImage

        /// <summary>
        /// <para> Creates an Amazon EBS-backed AMI from a "running" or "stopped" instance. AMIs that use an Amazon EBS root device boot faster than
        /// AMIs that use instance stores. They can be up to 1 TiB in size, use storage that persists on instance failure, and can be stopped and
        /// started. </para>
        /// </summary>
        /// 
        /// <param name="createImageRequest">Container for the necessary parameters to execute the CreateImage service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the CreateImage service method, as returned by AmazonEC2.</returns>
        /// 
        public CreateImageResponse CreateImage(CreateImageRequest createImageRequest)
        {
            IAsyncResult asyncResult = invokeCreateImage(createImageRequest, null, null, true);
            return EndCreateImage(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CreateImage operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateImage"/>
        /// </summary>
        /// 
        /// <param name="createImageRequest">Container for the necessary parameters to execute the CreateImage operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateImage
        ///         operation.</returns>
        public IAsyncResult BeginCreateImage(CreateImageRequest createImageRequest, AsyncCallback callback, object state)
        {
            return invokeCreateImage(createImageRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CreateImage operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateImage"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateImage.</param>
        /// 
        /// <returns>Returns a CreateImageResult from AmazonEC2.</returns>
        public CreateImageResponse EndCreateImage(IAsyncResult asyncResult)
        {
            return endOperation<CreateImageResponse>(asyncResult);
        }
        
        IAsyncResult invokeCreateImage(CreateImageRequest createImageRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreateImageRequestMarshaller().Marshall(createImageRequest);
            var unmarshaller = CreateImageResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region CreateInstanceExportTask

        /// <summary>
        /// </summary>
        /// 
        /// <param name="createInstanceExportTaskRequest">Container for the necessary parameters to execute the CreateInstanceExportTask service method
        ///          on AmazonEC2.</param>
        /// 
        /// <returns>The response from the CreateInstanceExportTask service method, as returned by AmazonEC2.</returns>
        /// 
        public CreateInstanceExportTaskResponse CreateInstanceExportTask(CreateInstanceExportTaskRequest createInstanceExportTaskRequest)
        {
            IAsyncResult asyncResult = invokeCreateInstanceExportTask(createInstanceExportTaskRequest, null, null, true);
            return EndCreateInstanceExportTask(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CreateInstanceExportTask operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateInstanceExportTask"/>
        /// </summary>
        /// 
        /// <param name="createInstanceExportTaskRequest">Container for the necessary parameters to execute the CreateInstanceExportTask operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndCreateInstanceExportTask operation.</returns>
        public IAsyncResult BeginCreateInstanceExportTask(CreateInstanceExportTaskRequest createInstanceExportTaskRequest, AsyncCallback callback, object state)
        {
            return invokeCreateInstanceExportTask(createInstanceExportTaskRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CreateInstanceExportTask operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateInstanceExportTask"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateInstanceExportTask.</param>
        /// 
        /// <returns>Returns a CreateInstanceExportTaskResult from AmazonEC2.</returns>
        public CreateInstanceExportTaskResponse EndCreateInstanceExportTask(IAsyncResult asyncResult)
        {
            return endOperation<CreateInstanceExportTaskResponse>(asyncResult);
        }
        
        IAsyncResult invokeCreateInstanceExportTask(CreateInstanceExportTaskRequest createInstanceExportTaskRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreateInstanceExportTaskRequestMarshaller().Marshall(createInstanceExportTaskRequest);
            var unmarshaller = CreateInstanceExportTaskResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region CreateInternetGateway

        /// <summary>
        /// <para> Creates a new Internet gateway in your AWS account. After creating the Internet gateway, you then attach it to a VPC using
        /// <c>AttachInternetGateway</c> . For more information about your VPC and Internet gateway, go to Amazon Virtual Private Cloud User Guide.
        /// </para>
        /// </summary>
        /// 
        /// <param name="createInternetGatewayRequest">Container for the necessary parameters to execute the CreateInternetGateway service method on
        ///          AmazonEC2.</param>
        /// 
        /// <returns>The response from the CreateInternetGateway service method, as returned by AmazonEC2.</returns>
        /// 
        public CreateInternetGatewayResponse CreateInternetGateway(CreateInternetGatewayRequest createInternetGatewayRequest)
        {
            IAsyncResult asyncResult = invokeCreateInternetGateway(createInternetGatewayRequest, null, null, true);
            return EndCreateInternetGateway(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CreateInternetGateway operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateInternetGateway"/>
        /// </summary>
        /// 
        /// <param name="createInternetGatewayRequest">Container for the necessary parameters to execute the CreateInternetGateway operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndCreateInternetGateway operation.</returns>
        public IAsyncResult BeginCreateInternetGateway(CreateInternetGatewayRequest createInternetGatewayRequest, AsyncCallback callback, object state)
        {
            return invokeCreateInternetGateway(createInternetGatewayRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CreateInternetGateway operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateInternetGateway"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateInternetGateway.</param>
        /// 
        /// <returns>Returns a CreateInternetGatewayResult from AmazonEC2.</returns>
        public CreateInternetGatewayResponse EndCreateInternetGateway(IAsyncResult asyncResult)
        {
            return endOperation<CreateInternetGatewayResponse>(asyncResult);
        }
        
        IAsyncResult invokeCreateInternetGateway(CreateInternetGatewayRequest createInternetGatewayRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreateInternetGatewayRequestMarshaller().Marshall(createInternetGatewayRequest);
            var unmarshaller = CreateInternetGatewayResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para> Creates a new Internet gateway in your AWS account. After creating the Internet gateway, you then attach it to a VPC using
        /// <c>AttachInternetGateway</c> . For more information about your VPC and Internet gateway, go to Amazon Virtual Private Cloud User Guide.
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the CreateInternetGateway service method, as returned by AmazonEC2.</returns>
        /// 
        public CreateInternetGatewayResponse CreateInternetGateway()
        {
            return CreateInternetGateway(new CreateInternetGatewayRequest());
        }
        

        #endregion
    
        #region CreateKeyPair

        /// <summary>
        /// <para> The CreateKeyPair operation creates a new 2048 bit RSA key pair and returns a unique ID that can be used to reference this key pair
        /// when launching new instances. For more information, see RunInstances. </para>
        /// </summary>
        /// 
        /// <param name="createKeyPairRequest">Container for the necessary parameters to execute the CreateKeyPair service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the CreateKeyPair service method, as returned by AmazonEC2.</returns>
        /// 
        public CreateKeyPairResponse CreateKeyPair(CreateKeyPairRequest createKeyPairRequest)
        {
            IAsyncResult asyncResult = invokeCreateKeyPair(createKeyPairRequest, null, null, true);
            return EndCreateKeyPair(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CreateKeyPair operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateKeyPair"/>
        /// </summary>
        /// 
        /// <param name="createKeyPairRequest">Container for the necessary parameters to execute the CreateKeyPair operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateKeyPair
        ///         operation.</returns>
        public IAsyncResult BeginCreateKeyPair(CreateKeyPairRequest createKeyPairRequest, AsyncCallback callback, object state)
        {
            return invokeCreateKeyPair(createKeyPairRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CreateKeyPair operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateKeyPair"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateKeyPair.</param>
        /// 
        /// <returns>Returns a CreateKeyPairResult from AmazonEC2.</returns>
        public CreateKeyPairResponse EndCreateKeyPair(IAsyncResult asyncResult)
        {
            return endOperation<CreateKeyPairResponse>(asyncResult);
        }
        
        IAsyncResult invokeCreateKeyPair(CreateKeyPairRequest createKeyPairRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreateKeyPairRequestMarshaller().Marshall(createKeyPairRequest);
            var unmarshaller = CreateKeyPairResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region CreateNetworkAcl

        /// <summary>
        /// <para> Creates a new network ACL in a VPC. Network ACLs provide an optional layer of security (on top of security groups) for the instances
        /// in your VPC. For more information about network ACLs, go to Network ACLs in the Amazon Virtual Private Cloud User Guide. </para>
        /// </summary>
        /// 
        /// <param name="createNetworkAclRequest">Container for the necessary parameters to execute the CreateNetworkAcl service method on
        ///          AmazonEC2.</param>
        /// 
        /// <returns>The response from the CreateNetworkAcl service method, as returned by AmazonEC2.</returns>
        /// 
        public CreateNetworkAclResponse CreateNetworkAcl(CreateNetworkAclRequest createNetworkAclRequest)
        {
            IAsyncResult asyncResult = invokeCreateNetworkAcl(createNetworkAclRequest, null, null, true);
            return EndCreateNetworkAcl(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CreateNetworkAcl operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateNetworkAcl"/>
        /// </summary>
        /// 
        /// <param name="createNetworkAclRequest">Container for the necessary parameters to execute the CreateNetworkAcl operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateNetworkAcl
        ///         operation.</returns>
        public IAsyncResult BeginCreateNetworkAcl(CreateNetworkAclRequest createNetworkAclRequest, AsyncCallback callback, object state)
        {
            return invokeCreateNetworkAcl(createNetworkAclRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CreateNetworkAcl operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateNetworkAcl"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateNetworkAcl.</param>
        /// 
        /// <returns>Returns a CreateNetworkAclResult from AmazonEC2.</returns>
        public CreateNetworkAclResponse EndCreateNetworkAcl(IAsyncResult asyncResult)
        {
            return endOperation<CreateNetworkAclResponse>(asyncResult);
        }
        
        IAsyncResult invokeCreateNetworkAcl(CreateNetworkAclRequest createNetworkAclRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreateNetworkAclRequestMarshaller().Marshall(createNetworkAclRequest);
            var unmarshaller = CreateNetworkAclResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region CreateNetworkAclEntry

        /// <summary>
        /// <para> Creates an entry (i.e., rule) in a network ACL with a rule number you specify. Each network ACL has a set of numbered ingress rules
        /// and a separate set of numbered egress rules. When determining whether a packet should be allowed in or out of a subnet associated with the
        /// ACL, Amazon VPC processes the entries in the ACL according to the rule numbers, in ascending order. </para> <para> <b>Important:</b> We
        /// recommend that you leave room between the rules (e.g., 100, 110, 120, etc.), and not number them sequentially (101, 102, 103, etc.). This
        /// allows you to easily add a new rule between existing ones without having to renumber the rules. </para> <para> After you add an entry, you
        /// can't modify it; you must either replace it, or create a new entry and delete the old one. </para> <para> For more information about network
        /// ACLs, go to Network ACLs in the Amazon Virtual Private Cloud User Guide. </para>
        /// </summary>
        /// 
        /// <param name="createNetworkAclEntryRequest">Container for the necessary parameters to execute the CreateNetworkAclEntry service method on
        ///          AmazonEC2.</param>
        /// 
        public CreateNetworkAclEntryResponse CreateNetworkAclEntry(CreateNetworkAclEntryRequest createNetworkAclEntryRequest)
        {
            IAsyncResult asyncResult = invokeCreateNetworkAclEntry(createNetworkAclEntryRequest, null, null, true);
            return EndCreateNetworkAclEntry(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CreateNetworkAclEntry operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateNetworkAclEntry"/>
        /// </summary>
        /// 
        /// <param name="createNetworkAclEntryRequest">Container for the necessary parameters to execute the CreateNetworkAclEntry operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginCreateNetworkAclEntry(CreateNetworkAclEntryRequest createNetworkAclEntryRequest, AsyncCallback callback, object state)
        {
            return invokeCreateNetworkAclEntry(createNetworkAclEntryRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CreateNetworkAclEntry operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateNetworkAclEntry"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateNetworkAclEntry.</param>
        public CreateNetworkAclEntryResponse EndCreateNetworkAclEntry(IAsyncResult asyncResult)
        {
            return endOperation<CreateNetworkAclEntryResponse>(asyncResult);
        }
        
        IAsyncResult invokeCreateNetworkAclEntry(CreateNetworkAclEntryRequest createNetworkAclEntryRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreateNetworkAclEntryRequestMarshaller().Marshall(createNetworkAclEntryRequest);
            var unmarshaller = CreateNetworkAclEntryResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region CreateNetworkInterface

        /// <summary>
        /// </summary>
        /// 
        /// <param name="createNetworkInterfaceRequest">Container for the necessary parameters to execute the CreateNetworkInterface service method on
        ///          AmazonEC2.</param>
        /// 
        /// <returns>The response from the CreateNetworkInterface service method, as returned by AmazonEC2.</returns>
        /// 
        public CreateNetworkInterfaceResponse CreateNetworkInterface(CreateNetworkInterfaceRequest createNetworkInterfaceRequest)
        {
            IAsyncResult asyncResult = invokeCreateNetworkInterface(createNetworkInterfaceRequest, null, null, true);
            return EndCreateNetworkInterface(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CreateNetworkInterface operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateNetworkInterface"/>
        /// </summary>
        /// 
        /// <param name="createNetworkInterfaceRequest">Container for the necessary parameters to execute the CreateNetworkInterface operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndCreateNetworkInterface operation.</returns>
        public IAsyncResult BeginCreateNetworkInterface(CreateNetworkInterfaceRequest createNetworkInterfaceRequest, AsyncCallback callback, object state)
        {
            return invokeCreateNetworkInterface(createNetworkInterfaceRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CreateNetworkInterface operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateNetworkInterface"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateNetworkInterface.</param>
        /// 
        /// <returns>Returns a CreateNetworkInterfaceResult from AmazonEC2.</returns>
        public CreateNetworkInterfaceResponse EndCreateNetworkInterface(IAsyncResult asyncResult)
        {
            return endOperation<CreateNetworkInterfaceResponse>(asyncResult);
        }
        
        IAsyncResult invokeCreateNetworkInterface(CreateNetworkInterfaceRequest createNetworkInterfaceRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreateNetworkInterfaceRequestMarshaller().Marshall(createNetworkInterfaceRequest);
            var unmarshaller = CreateNetworkInterfaceResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region CreatePlacementGroup

        /// <summary>
        /// <para> Creates a PlacementGroup into which multiple Amazon EC2 instances can be launched. Users must give the group a name unique within the
        /// scope of the user account. </para>
        /// </summary>
        /// 
        /// <param name="createPlacementGroupRequest">Container for the necessary parameters to execute the CreatePlacementGroup service method on
        ///          AmazonEC2.</param>
        /// 
        public CreatePlacementGroupResponse CreatePlacementGroup(CreatePlacementGroupRequest createPlacementGroupRequest)
        {
            IAsyncResult asyncResult = invokeCreatePlacementGroup(createPlacementGroupRequest, null, null, true);
            return EndCreatePlacementGroup(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CreatePlacementGroup operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreatePlacementGroup"/>
        /// </summary>
        /// 
        /// <param name="createPlacementGroupRequest">Container for the necessary parameters to execute the CreatePlacementGroup operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginCreatePlacementGroup(CreatePlacementGroupRequest createPlacementGroupRequest, AsyncCallback callback, object state)
        {
            return invokeCreatePlacementGroup(createPlacementGroupRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CreatePlacementGroup operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreatePlacementGroup"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreatePlacementGroup.</param>
        public CreatePlacementGroupResponse EndCreatePlacementGroup(IAsyncResult asyncResult)
        {
            return endOperation<CreatePlacementGroupResponse>(asyncResult);
        }
        
        IAsyncResult invokeCreatePlacementGroup(CreatePlacementGroupRequest createPlacementGroupRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreatePlacementGroupRequestMarshaller().Marshall(createPlacementGroupRequest);
            var unmarshaller = CreatePlacementGroupResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region CreateReservedInstancesListing

        /// <summary>
        /// </summary>
        /// 
        /// <param name="createReservedInstancesListingRequest">Container for the necessary parameters to execute the CreateReservedInstancesListing
        ///          service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the CreateReservedInstancesListing service method, as returned by AmazonEC2.</returns>
        /// 
        public CreateReservedInstancesListingResponse CreateReservedInstancesListing(CreateReservedInstancesListingRequest createReservedInstancesListingRequest)
        {
            IAsyncResult asyncResult = invokeCreateReservedInstancesListing(createReservedInstancesListingRequest, null, null, true);
            return EndCreateReservedInstancesListing(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CreateReservedInstancesListing operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateReservedInstancesListing"/>
        /// </summary>
        /// 
        /// <param name="createReservedInstancesListingRequest">Container for the necessary parameters to execute the CreateReservedInstancesListing
        ///          operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndCreateReservedInstancesListing operation.</returns>
        public IAsyncResult BeginCreateReservedInstancesListing(CreateReservedInstancesListingRequest createReservedInstancesListingRequest, AsyncCallback callback, object state)
        {
            return invokeCreateReservedInstancesListing(createReservedInstancesListingRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CreateReservedInstancesListing operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateReservedInstancesListing"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateReservedInstancesListing.</param>
        /// 
        /// <returns>Returns a CreateReservedInstancesListingResult from AmazonEC2.</returns>
        public CreateReservedInstancesListingResponse EndCreateReservedInstancesListing(IAsyncResult asyncResult)
        {
            return endOperation<CreateReservedInstancesListingResponse>(asyncResult);
        }
        
        IAsyncResult invokeCreateReservedInstancesListing(CreateReservedInstancesListingRequest createReservedInstancesListingRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreateReservedInstancesListingRequestMarshaller().Marshall(createReservedInstancesListingRequest);
            var unmarshaller = CreateReservedInstancesListingResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region CreateRoute

        /// <summary>
        /// <para> Creates a new route in a route table within a VPC. The route's target can be either a gateway attached to the VPC or a NAT instance
        /// in the VPC. </para> <para> When determining how to route traffic, we use the route with the most specific match. For example, let's say the
        /// traffic is destined for <c>192.0.2.3</c> , and the route table includes the following two routes: </para>
        /// <ul>
        /// <li> <c>192.0.2.0/24</c> (goes to some target A) </li>
        /// <li> <c>192.0.2.0/28</c> (goes to some target B) </li>
        /// 
        /// </ul>
        /// <para> Both routes apply to the traffic destined for <c>192.0.2.3</c> . However, the second route in the list is more specific, so we use
        /// that route to determine where to target the traffic. </para> <para> For more information about route tables, go to <a
        /// href="http://docs.amazonwebservices.com/AmazonVPC/latest/UserGuide/VPC_Route_Tables.html" >Route Tables</a> in the Amazon Virtual Private
        /// Cloud User Guide. </para>
        /// </summary>
        /// 
        /// <param name="createRouteRequest">Container for the necessary parameters to execute the CreateRoute service method on AmazonEC2.</param>
        /// 
        public CreateRouteResponse CreateRoute(CreateRouteRequest createRouteRequest)
        {
            IAsyncResult asyncResult = invokeCreateRoute(createRouteRequest, null, null, true);
            return EndCreateRoute(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRoute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateRoute"/>
        /// </summary>
        /// 
        /// <param name="createRouteRequest">Container for the necessary parameters to execute the CreateRoute operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginCreateRoute(CreateRouteRequest createRouteRequest, AsyncCallback callback, object state)
        {
            return invokeCreateRoute(createRouteRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CreateRoute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateRoute"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRoute.</param>
        public CreateRouteResponse EndCreateRoute(IAsyncResult asyncResult)
        {
            return endOperation<CreateRouteResponse>(asyncResult);
        }
        
        IAsyncResult invokeCreateRoute(CreateRouteRequest createRouteRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreateRouteRequestMarshaller().Marshall(createRouteRequest);
            var unmarshaller = CreateRouteResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region CreateRouteTable

        /// <summary>
        /// <para> Creates a new route table within a VPC. After you create a new route table, you can add routes and associate the table with a subnet.
        /// For more information about route tables, go to <a href="http://docs.amazonwebservices.com/AmazonVPC/latest/UserGuide/VPC_Route_Tables.html"
        /// >Route Tables</a> in the Amazon Virtual Private Cloud User Guide. </para>
        /// </summary>
        /// 
        /// <param name="createRouteTableRequest">Container for the necessary parameters to execute the CreateRouteTable service method on
        ///          AmazonEC2.</param>
        /// 
        /// <returns>The response from the CreateRouteTable service method, as returned by AmazonEC2.</returns>
        /// 
        public CreateRouteTableResponse CreateRouteTable(CreateRouteTableRequest createRouteTableRequest)
        {
            IAsyncResult asyncResult = invokeCreateRouteTable(createRouteTableRequest, null, null, true);
            return EndCreateRouteTable(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CreateRouteTable operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateRouteTable"/>
        /// </summary>
        /// 
        /// <param name="createRouteTableRequest">Container for the necessary parameters to execute the CreateRouteTable operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateRouteTable
        ///         operation.</returns>
        public IAsyncResult BeginCreateRouteTable(CreateRouteTableRequest createRouteTableRequest, AsyncCallback callback, object state)
        {
            return invokeCreateRouteTable(createRouteTableRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CreateRouteTable operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateRouteTable"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateRouteTable.</param>
        /// 
        /// <returns>Returns a CreateRouteTableResult from AmazonEC2.</returns>
        public CreateRouteTableResponse EndCreateRouteTable(IAsyncResult asyncResult)
        {
            return endOperation<CreateRouteTableResponse>(asyncResult);
        }
        
        IAsyncResult invokeCreateRouteTable(CreateRouteTableRequest createRouteTableRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreateRouteTableRequestMarshaller().Marshall(createRouteTableRequest);
            var unmarshaller = CreateRouteTableResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region CreateSecurityGroup

        /// <summary>
        /// <para> The CreateSecurityGroup operation creates a new security group. </para> <para> Every instance is launched in a security group. If no
        /// security group is specified during launch, the instances are launched in the default security group. Instances within the same security
        /// group have unrestricted network access to each other. Instances will reject network access attempts from other instances in a different
        /// security group. As the owner of instances you can grant or revoke specific permissions using the AuthorizeSecurityGroupIngress and
        /// RevokeSecurityGroupIngress operations. </para>
        /// </summary>
        /// 
        /// <param name="createSecurityGroupRequest">Container for the necessary parameters to execute the CreateSecurityGroup service method on
        ///          AmazonEC2.</param>
        /// 
        /// <returns>The response from the CreateSecurityGroup service method, as returned by AmazonEC2.</returns>
        /// 
        public CreateSecurityGroupResponse CreateSecurityGroup(CreateSecurityGroupRequest createSecurityGroupRequest)
        {
            IAsyncResult asyncResult = invokeCreateSecurityGroup(createSecurityGroupRequest, null, null, true);
            return EndCreateSecurityGroup(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSecurityGroup operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateSecurityGroup"/>
        /// </summary>
        /// 
        /// <param name="createSecurityGroupRequest">Container for the necessary parameters to execute the CreateSecurityGroup operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndCreateSecurityGroup operation.</returns>
        public IAsyncResult BeginCreateSecurityGroup(CreateSecurityGroupRequest createSecurityGroupRequest, AsyncCallback callback, object state)
        {
            return invokeCreateSecurityGroup(createSecurityGroupRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CreateSecurityGroup operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateSecurityGroup"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSecurityGroup.</param>
        /// 
        /// <returns>Returns a CreateSecurityGroupResult from AmazonEC2.</returns>
        public CreateSecurityGroupResponse EndCreateSecurityGroup(IAsyncResult asyncResult)
        {
            return endOperation<CreateSecurityGroupResponse>(asyncResult);
        }
        
        IAsyncResult invokeCreateSecurityGroup(CreateSecurityGroupRequest createSecurityGroupRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreateSecurityGroupRequestMarshaller().Marshall(createSecurityGroupRequest);
            var unmarshaller = CreateSecurityGroupResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region CreateSnapshot

        /// <summary>
        /// <para> Create a snapshot of the volume identified by volume ID. A volume does not have to be detached at the time the snapshot is taken.
        /// </para> <para><b>NOTE:</b> Snapshot creation requires that the system is in a consistent state. For instance, this means that if taking a
        /// snapshot of a database, the tables must be read-only locked to ensure that the snapshot will not contain a corrupted version of the
        /// database. Therefore, be careful when using this API to ensure that the system remains in the consistent state until the create snapshot
        /// status has returned. </para>
        /// </summary>
        /// 
        /// <param name="createSnapshotRequest">Container for the necessary parameters to execute the CreateSnapshot service method on
        ///          AmazonEC2.</param>
        /// 
        /// <returns>The response from the CreateSnapshot service method, as returned by AmazonEC2.</returns>
        /// 
        public CreateSnapshotResponse CreateSnapshot(CreateSnapshotRequest createSnapshotRequest)
        {
            IAsyncResult asyncResult = invokeCreateSnapshot(createSnapshotRequest, null, null, true);
            return EndCreateSnapshot(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSnapshot operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateSnapshot"/>
        /// </summary>
        /// 
        /// <param name="createSnapshotRequest">Container for the necessary parameters to execute the CreateSnapshot operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSnapshot
        ///         operation.</returns>
        public IAsyncResult BeginCreateSnapshot(CreateSnapshotRequest createSnapshotRequest, AsyncCallback callback, object state)
        {
            return invokeCreateSnapshot(createSnapshotRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CreateSnapshot operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateSnapshot"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSnapshot.</param>
        /// 
        /// <returns>Returns a CreateSnapshotResult from AmazonEC2.</returns>
        public CreateSnapshotResponse EndCreateSnapshot(IAsyncResult asyncResult)
        {
            return endOperation<CreateSnapshotResponse>(asyncResult);
        }
        
        IAsyncResult invokeCreateSnapshot(CreateSnapshotRequest createSnapshotRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreateSnapshotRequestMarshaller().Marshall(createSnapshotRequest);
            var unmarshaller = CreateSnapshotResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region CreateSpotDatafeedSubscription

        /// <summary>
        /// <para> Creates the data feed for Spot Instances, enabling you to view Spot Instance usage logs. You can create one data feed per account.
        /// </para> <para> For conceptual information about Spot Instances, refer to the Amazon Elastic Compute Cloud Developer Guide or Amazon Elastic
        /// Compute Cloud User Guide .
        /// </para>
        /// </summary>
        /// 
        /// <param name="createSpotDatafeedSubscriptionRequest">Container for the necessary parameters to execute the CreateSpotDatafeedSubscription
        ///          service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the CreateSpotDatafeedSubscription service method, as returned by AmazonEC2.</returns>
        /// 
        public CreateSpotDatafeedSubscriptionResponse CreateSpotDatafeedSubscription(CreateSpotDatafeedSubscriptionRequest createSpotDatafeedSubscriptionRequest)
        {
            IAsyncResult asyncResult = invokeCreateSpotDatafeedSubscription(createSpotDatafeedSubscriptionRequest, null, null, true);
            return EndCreateSpotDatafeedSubscription(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSpotDatafeedSubscription operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateSpotDatafeedSubscription"/>
        /// </summary>
        /// 
        /// <param name="createSpotDatafeedSubscriptionRequest">Container for the necessary parameters to execute the CreateSpotDatafeedSubscription
        ///          operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndCreateSpotDatafeedSubscription operation.</returns>
        public IAsyncResult BeginCreateSpotDatafeedSubscription(CreateSpotDatafeedSubscriptionRequest createSpotDatafeedSubscriptionRequest, AsyncCallback callback, object state)
        {
            return invokeCreateSpotDatafeedSubscription(createSpotDatafeedSubscriptionRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CreateSpotDatafeedSubscription operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateSpotDatafeedSubscription"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSpotDatafeedSubscription.</param>
        /// 
        /// <returns>Returns a CreateSpotDatafeedSubscriptionResult from AmazonEC2.</returns>
        public CreateSpotDatafeedSubscriptionResponse EndCreateSpotDatafeedSubscription(IAsyncResult asyncResult)
        {
            return endOperation<CreateSpotDatafeedSubscriptionResponse>(asyncResult);
        }
        
        IAsyncResult invokeCreateSpotDatafeedSubscription(CreateSpotDatafeedSubscriptionRequest createSpotDatafeedSubscriptionRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreateSpotDatafeedSubscriptionRequestMarshaller().Marshall(createSpotDatafeedSubscriptionRequest);
            var unmarshaller = CreateSpotDatafeedSubscriptionResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region CreateSubnet

        /// <summary>
        /// <para> Creates a subnet in an existing VPC. You can create up to 20 subnets in a VPC. If you add more than one subnet to a VPC, they're set
        /// up in a star topology with a logical router in the middle. When you create each subnet, you provide the VPC ID and the CIDR block you want
        /// for the subnet. Once you create a subnet, you can't change its CIDR block. The subnet's CIDR block can be the same as the VPC's CIDR block
        /// (assuming you want only a single subnet in the VPC), or a subset of the VPC's CIDR block. If you create more than one subnet in a VPC, the
        /// subnets' CIDR blocks must not overlap. The smallest subnet (and VPC) you can create uses a <c>/28</c> netmask (16 IP addresses), and the
        /// largest uses a <c>/18</c> netmask (16,384 IP addresses). </para> <para><b>IMPORTANT:</b> AWS reserves both the first four and the last IP
        /// address in each subnet's CIDR block. They're not available for use. </para>
        /// </summary>
        /// 
        /// <param name="createSubnetRequest">Container for the necessary parameters to execute the CreateSubnet service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the CreateSubnet service method, as returned by AmazonEC2.</returns>
        /// 
        public CreateSubnetResponse CreateSubnet(CreateSubnetRequest createSubnetRequest)
        {
            IAsyncResult asyncResult = invokeCreateSubnet(createSubnetRequest, null, null, true);
            return EndCreateSubnet(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CreateSubnet operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateSubnet"/>
        /// </summary>
        /// 
        /// <param name="createSubnetRequest">Container for the necessary parameters to execute the CreateSubnet operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateSubnet
        ///         operation.</returns>
        public IAsyncResult BeginCreateSubnet(CreateSubnetRequest createSubnetRequest, AsyncCallback callback, object state)
        {
            return invokeCreateSubnet(createSubnetRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CreateSubnet operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateSubnet"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateSubnet.</param>
        /// 
        /// <returns>Returns a CreateSubnetResult from AmazonEC2.</returns>
        public CreateSubnetResponse EndCreateSubnet(IAsyncResult asyncResult)
        {
            return endOperation<CreateSubnetResponse>(asyncResult);
        }
        
        IAsyncResult invokeCreateSubnet(CreateSubnetRequest createSubnetRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreateSubnetRequestMarshaller().Marshall(createSubnetRequest);
            var unmarshaller = CreateSubnetResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region CreateTags

        /// <summary>
        /// <para> Adds or overwrites tags for the specified resources. Each resource can have a maximum of 10 tags. Each tag consists of a key-value
        /// pair. Tag keys must be unique per resource. </para>
        /// </summary>
        /// 
        /// <param name="createTagsRequest">Container for the necessary parameters to execute the CreateTags service method on AmazonEC2.</param>
        /// 
        public CreateTagsResponse CreateTags(CreateTagsRequest createTagsRequest)
        {
            IAsyncResult asyncResult = invokeCreateTags(createTagsRequest, null, null, true);
            return EndCreateTags(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CreateTags operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateTags"/>
        /// </summary>
        /// 
        /// <param name="createTagsRequest">Container for the necessary parameters to execute the CreateTags operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginCreateTags(CreateTagsRequest createTagsRequest, AsyncCallback callback, object state)
        {
            return invokeCreateTags(createTagsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CreateTags operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateTags"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateTags.</param>
        public CreateTagsResponse EndCreateTags(IAsyncResult asyncResult)
        {
            return endOperation<CreateTagsResponse>(asyncResult);
        }
        
        IAsyncResult invokeCreateTags(CreateTagsRequest createTagsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreateTagsRequestMarshaller().Marshall(createTagsRequest);
            var unmarshaller = CreateTagsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region CreateVolume

        /// <summary>
        /// <para> Initializes an empty volume of a given size. </para>
        /// </summary>
        /// 
        /// <param name="createVolumeRequest">Container for the necessary parameters to execute the CreateVolume service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the CreateVolume service method, as returned by AmazonEC2.</returns>
        /// 
        public CreateVolumeResponse CreateVolume(CreateVolumeRequest createVolumeRequest)
        {
            IAsyncResult asyncResult = invokeCreateVolume(createVolumeRequest, null, null, true);
            return EndCreateVolume(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CreateVolume operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateVolume"/>
        /// </summary>
        /// 
        /// <param name="createVolumeRequest">Container for the necessary parameters to execute the CreateVolume operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateVolume
        ///         operation.</returns>
        public IAsyncResult BeginCreateVolume(CreateVolumeRequest createVolumeRequest, AsyncCallback callback, object state)
        {
            return invokeCreateVolume(createVolumeRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CreateVolume operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateVolume"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateVolume.</param>
        /// 
        /// <returns>Returns a CreateVolumeResult from AmazonEC2.</returns>
        public CreateVolumeResponse EndCreateVolume(IAsyncResult asyncResult)
        {
            return endOperation<CreateVolumeResponse>(asyncResult);
        }
        
        IAsyncResult invokeCreateVolume(CreateVolumeRequest createVolumeRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreateVolumeRequestMarshaller().Marshall(createVolumeRequest);
            var unmarshaller = CreateVolumeResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region CreateVpc

        /// <summary>
        /// <para> Creates a VPC with the CIDR block you specify. The smallest VPC you can create uses a <c>/28</c> netmask (16 IP addresses), and the
        /// largest uses a <c>/18</c> netmask (16,384 IP addresses). To help you decide how big to make your VPC, go to the topic about creating VPCs in
        /// the Amazon Virtual Private Cloud Developer Guide. </para> <para> By default, each instance you launch in the VPC has the default DHCP
        /// options (the standard EC2 host name, no domain name, no DNS server, no NTP server, and no NetBIOS server or node type). </para>
        /// </summary>
        /// 
        /// <param name="createVpcRequest">Container for the necessary parameters to execute the CreateVpc service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the CreateVpc service method, as returned by AmazonEC2.</returns>
        /// 
        public CreateVpcResponse CreateVpc(CreateVpcRequest createVpcRequest)
        {
            IAsyncResult asyncResult = invokeCreateVpc(createVpcRequest, null, null, true);
            return EndCreateVpc(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CreateVpc operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateVpc"/>
        /// </summary>
        /// 
        /// <param name="createVpcRequest">Container for the necessary parameters to execute the CreateVpc operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateVpc
        ///         operation.</returns>
        public IAsyncResult BeginCreateVpc(CreateVpcRequest createVpcRequest, AsyncCallback callback, object state)
        {
            return invokeCreateVpc(createVpcRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CreateVpc operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateVpc"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateVpc.</param>
        /// 
        /// <returns>Returns a CreateVpcResult from AmazonEC2.</returns>
        public CreateVpcResponse EndCreateVpc(IAsyncResult asyncResult)
        {
            return endOperation<CreateVpcResponse>(asyncResult);
        }
        
        IAsyncResult invokeCreateVpc(CreateVpcRequest createVpcRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreateVpcRequestMarshaller().Marshall(createVpcRequest);
            var unmarshaller = CreateVpcResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region CreateVpnConnection

        /// <summary>
        /// <para> Creates a new VPN connection between an existing VPN gateway and customer gateway. The only supported connection type is ipsec.1.
        /// </para> <para> The response includes information that you need to configure your customer gateway, in XML format. We recommend you use the
        /// command line version of this operation ( <c>ec2-create-vpn-connection</c> ), which takes an <c>-f</c> option (for format) and returns
        /// configuration information formatted as expected by the vendor you specified, or in a generic, human readable format. For information about
        /// the command, go to <c>ec2-create-vpn-connection</c> in the Amazon Virtual Private Cloud Command Line Reference. </para>
        /// <para><b>IMPORTANT:</b> We strongly recommend you use HTTPS when calling this operation because the response contains sensitive
        /// cryptographic information for configuring your customer gateway. If you decide to shut down your VPN connection for any reason and then
        /// create a new one, you must re-configure your customer gateway with the new information returned from this call. </para>
        /// </summary>
        /// 
        /// <param name="createVpnConnectionRequest">Container for the necessary parameters to execute the CreateVpnConnection service method on
        ///          AmazonEC2.</param>
        /// 
        /// <returns>The response from the CreateVpnConnection service method, as returned by AmazonEC2.</returns>
        /// 
        public CreateVpnConnectionResponse CreateVpnConnection(CreateVpnConnectionRequest createVpnConnectionRequest)
        {
            IAsyncResult asyncResult = invokeCreateVpnConnection(createVpnConnectionRequest, null, null, true);
            return EndCreateVpnConnection(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CreateVpnConnection operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateVpnConnection"/>
        /// </summary>
        /// 
        /// <param name="createVpnConnectionRequest">Container for the necessary parameters to execute the CreateVpnConnection operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndCreateVpnConnection operation.</returns>
        public IAsyncResult BeginCreateVpnConnection(CreateVpnConnectionRequest createVpnConnectionRequest, AsyncCallback callback, object state)
        {
            return invokeCreateVpnConnection(createVpnConnectionRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CreateVpnConnection operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateVpnConnection"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateVpnConnection.</param>
        /// 
        /// <returns>Returns a CreateVpnConnectionResult from AmazonEC2.</returns>
        public CreateVpnConnectionResponse EndCreateVpnConnection(IAsyncResult asyncResult)
        {
            return endOperation<CreateVpnConnectionResponse>(asyncResult);
        }
        
        IAsyncResult invokeCreateVpnConnection(CreateVpnConnectionRequest createVpnConnectionRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreateVpnConnectionRequestMarshaller().Marshall(createVpnConnectionRequest);
            var unmarshaller = CreateVpnConnectionResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region CreateVpnConnectionRoute

        /// <summary>
        /// </summary>
        /// 
        /// <param name="createVpnConnectionRouteRequest">Container for the necessary parameters to execute the CreateVpnConnectionRoute service method
        ///          on AmazonEC2.</param>
        /// 
        public CreateVpnConnectionRouteResponse CreateVpnConnectionRoute(CreateVpnConnectionRouteRequest createVpnConnectionRouteRequest)
        {
            IAsyncResult asyncResult = invokeCreateVpnConnectionRoute(createVpnConnectionRouteRequest, null, null, true);
            return EndCreateVpnConnectionRoute(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CreateVpnConnectionRoute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateVpnConnectionRoute"/>
        /// </summary>
        /// 
        /// <param name="createVpnConnectionRouteRequest">Container for the necessary parameters to execute the CreateVpnConnectionRoute operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginCreateVpnConnectionRoute(CreateVpnConnectionRouteRequest createVpnConnectionRouteRequest, AsyncCallback callback, object state)
        {
            return invokeCreateVpnConnectionRoute(createVpnConnectionRouteRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CreateVpnConnectionRoute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateVpnConnectionRoute"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateVpnConnectionRoute.</param>
        public CreateVpnConnectionRouteResponse EndCreateVpnConnectionRoute(IAsyncResult asyncResult)
        {
            return endOperation<CreateVpnConnectionRouteResponse>(asyncResult);
        }
        
        IAsyncResult invokeCreateVpnConnectionRoute(CreateVpnConnectionRouteRequest createVpnConnectionRouteRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreateVpnConnectionRouteRequestMarshaller().Marshall(createVpnConnectionRouteRequest);
            var unmarshaller = CreateVpnConnectionRouteResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region CreateVpnGateway

        /// <summary>
        /// <para> Creates a new VPN gateway. A VPN gateway is the VPC-side endpoint for your VPN connection. You can create a VPN gateway before
        /// creating the VPC itself. </para>
        /// </summary>
        /// 
        /// <param name="createVpnGatewayRequest">Container for the necessary parameters to execute the CreateVpnGateway service method on
        ///          AmazonEC2.</param>
        /// 
        /// <returns>The response from the CreateVpnGateway service method, as returned by AmazonEC2.</returns>
        /// 
        public CreateVpnGatewayResponse CreateVpnGateway(CreateVpnGatewayRequest createVpnGatewayRequest)
        {
            IAsyncResult asyncResult = invokeCreateVpnGateway(createVpnGatewayRequest, null, null, true);
            return EndCreateVpnGateway(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the CreateVpnGateway operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateVpnGateway"/>
        /// </summary>
        /// 
        /// <param name="createVpnGatewayRequest">Container for the necessary parameters to execute the CreateVpnGateway operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndCreateVpnGateway
        ///         operation.</returns>
        public IAsyncResult BeginCreateVpnGateway(CreateVpnGatewayRequest createVpnGatewayRequest, AsyncCallback callback, object state)
        {
            return invokeCreateVpnGateway(createVpnGatewayRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the CreateVpnGateway operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.CreateVpnGateway"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginCreateVpnGateway.</param>
        /// 
        /// <returns>Returns a CreateVpnGatewayResult from AmazonEC2.</returns>
        public CreateVpnGatewayResponse EndCreateVpnGateway(IAsyncResult asyncResult)
        {
            return endOperation<CreateVpnGatewayResponse>(asyncResult);
        }
        
        IAsyncResult invokeCreateVpnGateway(CreateVpnGatewayRequest createVpnGatewayRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new CreateVpnGatewayRequestMarshaller().Marshall(createVpnGatewayRequest);
            var unmarshaller = CreateVpnGatewayResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DeleteCustomerGateway

        /// <summary>
        /// <para> Deletes a customer gateway. You must delete the VPN connection before deleting the customer gateway. </para> <para> You can have a
        /// single active customer gateway per AWS account (active means that you've created a VPN connection with that customer gateway). AWS might
        /// delete any customer gateway you leave inactive for an extended period of time. </para>
        /// </summary>
        /// 
        /// <param name="deleteCustomerGatewayRequest">Container for the necessary parameters to execute the DeleteCustomerGateway service method on
        ///          AmazonEC2.</param>
        /// 
        public DeleteCustomerGatewayResponse DeleteCustomerGateway(DeleteCustomerGatewayRequest deleteCustomerGatewayRequest)
        {
            IAsyncResult asyncResult = invokeDeleteCustomerGateway(deleteCustomerGatewayRequest, null, null, true);
            return EndDeleteCustomerGateway(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteCustomerGateway operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteCustomerGateway"/>
        /// </summary>
        /// 
        /// <param name="deleteCustomerGatewayRequest">Container for the necessary parameters to execute the DeleteCustomerGateway operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginDeleteCustomerGateway(DeleteCustomerGatewayRequest deleteCustomerGatewayRequest, AsyncCallback callback, object state)
        {
            return invokeDeleteCustomerGateway(deleteCustomerGatewayRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteCustomerGateway operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteCustomerGateway"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteCustomerGateway.</param>
        public DeleteCustomerGatewayResponse EndDeleteCustomerGateway(IAsyncResult asyncResult)
        {
            return endOperation<DeleteCustomerGatewayResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeleteCustomerGateway(DeleteCustomerGatewayRequest deleteCustomerGatewayRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteCustomerGatewayRequestMarshaller().Marshall(deleteCustomerGatewayRequest);
            var unmarshaller = DeleteCustomerGatewayResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DeleteDhcpOptions

        /// <summary>
        /// <para> Deletes a set of DHCP options that you specify. Amazon VPC returns an error if the set of options you specify is currently associated
        /// with a VPC. You can disassociate the set of options by associating either a new set of options or the default options with the VPC. </para>
        /// </summary>
        /// 
        /// <param name="deleteDhcpOptionsRequest">Container for the necessary parameters to execute the DeleteDhcpOptions service method on
        ///          AmazonEC2.</param>
        /// 
        public DeleteDhcpOptionsResponse DeleteDhcpOptions(DeleteDhcpOptionsRequest deleteDhcpOptionsRequest)
        {
            IAsyncResult asyncResult = invokeDeleteDhcpOptions(deleteDhcpOptionsRequest, null, null, true);
            return EndDeleteDhcpOptions(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteDhcpOptions operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteDhcpOptions"/>
        /// </summary>
        /// 
        /// <param name="deleteDhcpOptionsRequest">Container for the necessary parameters to execute the DeleteDhcpOptions operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginDeleteDhcpOptions(DeleteDhcpOptionsRequest deleteDhcpOptionsRequest, AsyncCallback callback, object state)
        {
            return invokeDeleteDhcpOptions(deleteDhcpOptionsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteDhcpOptions operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteDhcpOptions"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteDhcpOptions.</param>
        public DeleteDhcpOptionsResponse EndDeleteDhcpOptions(IAsyncResult asyncResult)
        {
            return endOperation<DeleteDhcpOptionsResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeleteDhcpOptions(DeleteDhcpOptionsRequest deleteDhcpOptionsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteDhcpOptionsRequestMarshaller().Marshall(deleteDhcpOptionsRequest);
            var unmarshaller = DeleteDhcpOptionsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DeleteInternetGateway

        /// <summary>
        /// <para> Deletes an Internet gateway from your AWS account. The gateway must not be attached to a VPC. For more information about your VPC and
        /// Internet gateway, go to Amazon Virtual Private Cloud User Guide. </para>
        /// </summary>
        /// 
        /// <param name="deleteInternetGatewayRequest">Container for the necessary parameters to execute the DeleteInternetGateway service method on
        ///          AmazonEC2.</param>
        /// 
        public DeleteInternetGatewayResponse DeleteInternetGateway(DeleteInternetGatewayRequest deleteInternetGatewayRequest)
        {
            IAsyncResult asyncResult = invokeDeleteInternetGateway(deleteInternetGatewayRequest, null, null, true);
            return EndDeleteInternetGateway(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteInternetGateway operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteInternetGateway"/>
        /// </summary>
        /// 
        /// <param name="deleteInternetGatewayRequest">Container for the necessary parameters to execute the DeleteInternetGateway operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginDeleteInternetGateway(DeleteInternetGatewayRequest deleteInternetGatewayRequest, AsyncCallback callback, object state)
        {
            return invokeDeleteInternetGateway(deleteInternetGatewayRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteInternetGateway operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteInternetGateway"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteInternetGateway.</param>
        public DeleteInternetGatewayResponse EndDeleteInternetGateway(IAsyncResult asyncResult)
        {
            return endOperation<DeleteInternetGatewayResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeleteInternetGateway(DeleteInternetGatewayRequest deleteInternetGatewayRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteInternetGatewayRequestMarshaller().Marshall(deleteInternetGatewayRequest);
            var unmarshaller = DeleteInternetGatewayResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DeleteKeyPair

        /// <summary>
        /// <para> The DeleteKeyPair operation deletes a key pair. </para>
        /// </summary>
        /// 
        /// <param name="deleteKeyPairRequest">Container for the necessary parameters to execute the DeleteKeyPair service method on AmazonEC2.</param>
        /// 
        public DeleteKeyPairResponse DeleteKeyPair(DeleteKeyPairRequest deleteKeyPairRequest)
        {
            IAsyncResult asyncResult = invokeDeleteKeyPair(deleteKeyPairRequest, null, null, true);
            return EndDeleteKeyPair(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteKeyPair operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteKeyPair"/>
        /// </summary>
        /// 
        /// <param name="deleteKeyPairRequest">Container for the necessary parameters to execute the DeleteKeyPair operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginDeleteKeyPair(DeleteKeyPairRequest deleteKeyPairRequest, AsyncCallback callback, object state)
        {
            return invokeDeleteKeyPair(deleteKeyPairRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteKeyPair operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteKeyPair"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteKeyPair.</param>
        public DeleteKeyPairResponse EndDeleteKeyPair(IAsyncResult asyncResult)
        {
            return endOperation<DeleteKeyPairResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeleteKeyPair(DeleteKeyPairRequest deleteKeyPairRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteKeyPairRequestMarshaller().Marshall(deleteKeyPairRequest);
            var unmarshaller = DeleteKeyPairResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DeleteNetworkAcl

        /// <summary>
        /// <para> Deletes a network ACL from a VPC. The ACL must not have any subnets associated with it. You can't delete the default network ACL. For
        /// more information about network ACLs, go to Network ACLs in the Amazon Virtual Private Cloud User Guide. </para>
        /// </summary>
        /// 
        /// <param name="deleteNetworkAclRequest">Container for the necessary parameters to execute the DeleteNetworkAcl service method on
        ///          AmazonEC2.</param>
        /// 
        public DeleteNetworkAclResponse DeleteNetworkAcl(DeleteNetworkAclRequest deleteNetworkAclRequest)
        {
            IAsyncResult asyncResult = invokeDeleteNetworkAcl(deleteNetworkAclRequest, null, null, true);
            return EndDeleteNetworkAcl(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteNetworkAcl operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteNetworkAcl"/>
        /// </summary>
        /// 
        /// <param name="deleteNetworkAclRequest">Container for the necessary parameters to execute the DeleteNetworkAcl operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginDeleteNetworkAcl(DeleteNetworkAclRequest deleteNetworkAclRequest, AsyncCallback callback, object state)
        {
            return invokeDeleteNetworkAcl(deleteNetworkAclRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteNetworkAcl operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteNetworkAcl"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteNetworkAcl.</param>
        public DeleteNetworkAclResponse EndDeleteNetworkAcl(IAsyncResult asyncResult)
        {
            return endOperation<DeleteNetworkAclResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeleteNetworkAcl(DeleteNetworkAclRequest deleteNetworkAclRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteNetworkAclRequestMarshaller().Marshall(deleteNetworkAclRequest);
            var unmarshaller = DeleteNetworkAclResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DeleteNetworkAclEntry

        /// <summary>
        /// <para> Deletes an ingress or egress entry (i.e., rule) from a network ACL. For more information about network ACLs, go to Network ACLs in
        /// the Amazon Virtual Private Cloud User Guide. </para>
        /// </summary>
        /// 
        /// <param name="deleteNetworkAclEntryRequest">Container for the necessary parameters to execute the DeleteNetworkAclEntry service method on
        ///          AmazonEC2.</param>
        /// 
        public DeleteNetworkAclEntryResponse DeleteNetworkAclEntry(DeleteNetworkAclEntryRequest deleteNetworkAclEntryRequest)
        {
            IAsyncResult asyncResult = invokeDeleteNetworkAclEntry(deleteNetworkAclEntryRequest, null, null, true);
            return EndDeleteNetworkAclEntry(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteNetworkAclEntry operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteNetworkAclEntry"/>
        /// </summary>
        /// 
        /// <param name="deleteNetworkAclEntryRequest">Container for the necessary parameters to execute the DeleteNetworkAclEntry operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginDeleteNetworkAclEntry(DeleteNetworkAclEntryRequest deleteNetworkAclEntryRequest, AsyncCallback callback, object state)
        {
            return invokeDeleteNetworkAclEntry(deleteNetworkAclEntryRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteNetworkAclEntry operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteNetworkAclEntry"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteNetworkAclEntry.</param>
        public DeleteNetworkAclEntryResponse EndDeleteNetworkAclEntry(IAsyncResult asyncResult)
        {
            return endOperation<DeleteNetworkAclEntryResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeleteNetworkAclEntry(DeleteNetworkAclEntryRequest deleteNetworkAclEntryRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteNetworkAclEntryRequestMarshaller().Marshall(deleteNetworkAclEntryRequest);
            var unmarshaller = DeleteNetworkAclEntryResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DeleteNetworkInterface

        /// <summary>
        /// </summary>
        /// 
        /// <param name="deleteNetworkInterfaceRequest">Container for the necessary parameters to execute the DeleteNetworkInterface service method on
        ///          AmazonEC2.</param>
        /// 
        public DeleteNetworkInterfaceResponse DeleteNetworkInterface(DeleteNetworkInterfaceRequest deleteNetworkInterfaceRequest)
        {
            IAsyncResult asyncResult = invokeDeleteNetworkInterface(deleteNetworkInterfaceRequest, null, null, true);
            return EndDeleteNetworkInterface(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteNetworkInterface operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteNetworkInterface"/>
        /// </summary>
        /// 
        /// <param name="deleteNetworkInterfaceRequest">Container for the necessary parameters to execute the DeleteNetworkInterface operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginDeleteNetworkInterface(DeleteNetworkInterfaceRequest deleteNetworkInterfaceRequest, AsyncCallback callback, object state)
        {
            return invokeDeleteNetworkInterface(deleteNetworkInterfaceRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteNetworkInterface operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteNetworkInterface"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteNetworkInterface.</param>
        public DeleteNetworkInterfaceResponse EndDeleteNetworkInterface(IAsyncResult asyncResult)
        {
            return endOperation<DeleteNetworkInterfaceResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeleteNetworkInterface(DeleteNetworkInterfaceRequest deleteNetworkInterfaceRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteNetworkInterfaceRequestMarshaller().Marshall(deleteNetworkInterfaceRequest);
            var unmarshaller = DeleteNetworkInterfaceResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DeletePlacementGroup

        /// <summary>
        /// <para> Deletes a PlacementGroup from a user's account. Terminate all Amazon EC2 instances in the placement group before deletion. </para>
        /// </summary>
        /// 
        /// <param name="deletePlacementGroupRequest">Container for the necessary parameters to execute the DeletePlacementGroup service method on
        ///          AmazonEC2.</param>
        /// 
        public DeletePlacementGroupResponse DeletePlacementGroup(DeletePlacementGroupRequest deletePlacementGroupRequest)
        {
            IAsyncResult asyncResult = invokeDeletePlacementGroup(deletePlacementGroupRequest, null, null, true);
            return EndDeletePlacementGroup(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeletePlacementGroup operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeletePlacementGroup"/>
        /// </summary>
        /// 
        /// <param name="deletePlacementGroupRequest">Container for the necessary parameters to execute the DeletePlacementGroup operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginDeletePlacementGroup(DeletePlacementGroupRequest deletePlacementGroupRequest, AsyncCallback callback, object state)
        {
            return invokeDeletePlacementGroup(deletePlacementGroupRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeletePlacementGroup operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeletePlacementGroup"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeletePlacementGroup.</param>
        public DeletePlacementGroupResponse EndDeletePlacementGroup(IAsyncResult asyncResult)
        {
            return endOperation<DeletePlacementGroupResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeletePlacementGroup(DeletePlacementGroupRequest deletePlacementGroupRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeletePlacementGroupRequestMarshaller().Marshall(deletePlacementGroupRequest);
            var unmarshaller = DeletePlacementGroupResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DeleteRoute

        /// <summary>
        /// <para> Deletes a route from a route table in a VPC. For more information about route tables, go to <a
        /// href="http://docs.amazonwebservices.com/AmazonVPC/latest/UserGuide/VPC_Route_Tables.html" >Route Tables</a> in the Amazon Virtual Private
        /// Cloud User Guide. </para>
        /// </summary>
        /// 
        /// <param name="deleteRouteRequest">Container for the necessary parameters to execute the DeleteRoute service method on AmazonEC2.</param>
        /// 
        public DeleteRouteResponse DeleteRoute(DeleteRouteRequest deleteRouteRequest)
        {
            IAsyncResult asyncResult = invokeDeleteRoute(deleteRouteRequest, null, null, true);
            return EndDeleteRoute(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRoute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteRoute"/>
        /// </summary>
        /// 
        /// <param name="deleteRouteRequest">Container for the necessary parameters to execute the DeleteRoute operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginDeleteRoute(DeleteRouteRequest deleteRouteRequest, AsyncCallback callback, object state)
        {
            return invokeDeleteRoute(deleteRouteRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteRoute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteRoute"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRoute.</param>
        public DeleteRouteResponse EndDeleteRoute(IAsyncResult asyncResult)
        {
            return endOperation<DeleteRouteResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeleteRoute(DeleteRouteRequest deleteRouteRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteRouteRequestMarshaller().Marshall(deleteRouteRequest);
            var unmarshaller = DeleteRouteResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DeleteRouteTable

        /// <summary>
        /// <para> Deletes a route table from a VPC. The route table must not be associated with a subnet. You can't delete the main route table. For
        /// more information about route tables, go to <a href="http://docs.amazonwebservices.com/AmazonVPC/latest/UserGuide/VPC_Route_Tables.html"
        /// >Route Tables</a> in the Amazon Virtual Private Cloud User Guide. </para>
        /// </summary>
        /// 
        /// <param name="deleteRouteTableRequest">Container for the necessary parameters to execute the DeleteRouteTable service method on
        ///          AmazonEC2.</param>
        /// 
        public DeleteRouteTableResponse DeleteRouteTable(DeleteRouteTableRequest deleteRouteTableRequest)
        {
            IAsyncResult asyncResult = invokeDeleteRouteTable(deleteRouteTableRequest, null, null, true);
            return EndDeleteRouteTable(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteRouteTable operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteRouteTable"/>
        /// </summary>
        /// 
        /// <param name="deleteRouteTableRequest">Container for the necessary parameters to execute the DeleteRouteTable operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginDeleteRouteTable(DeleteRouteTableRequest deleteRouteTableRequest, AsyncCallback callback, object state)
        {
            return invokeDeleteRouteTable(deleteRouteTableRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteRouteTable operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteRouteTable"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteRouteTable.</param>
        public DeleteRouteTableResponse EndDeleteRouteTable(IAsyncResult asyncResult)
        {
            return endOperation<DeleteRouteTableResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeleteRouteTable(DeleteRouteTableRequest deleteRouteTableRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteRouteTableRequestMarshaller().Marshall(deleteRouteTableRequest);
            var unmarshaller = DeleteRouteTableResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DeleteSecurityGroup

        /// <summary>
        /// <para> The DeleteSecurityGroup operation deletes a security group. </para> <para><b>NOTE:</b> If you attempt to delete a security group that
        /// contains instances, a fault is returned. If you attempt to delete a security group that is referenced by another security group, a fault is
        /// returned. For example, if security group B has a rule that allows access from security group A, security group A cannot be deleted until the
        /// allow rule is removed. </para>
        /// </summary>
        /// 
        /// <param name="deleteSecurityGroupRequest">Container for the necessary parameters to execute the DeleteSecurityGroup service method on
        ///          AmazonEC2.</param>
        /// 
        public DeleteSecurityGroupResponse DeleteSecurityGroup(DeleteSecurityGroupRequest deleteSecurityGroupRequest)
        {
            IAsyncResult asyncResult = invokeDeleteSecurityGroup(deleteSecurityGroupRequest, null, null, true);
            return EndDeleteSecurityGroup(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSecurityGroup operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteSecurityGroup"/>
        /// </summary>
        /// 
        /// <param name="deleteSecurityGroupRequest">Container for the necessary parameters to execute the DeleteSecurityGroup operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginDeleteSecurityGroup(DeleteSecurityGroupRequest deleteSecurityGroupRequest, AsyncCallback callback, object state)
        {
            return invokeDeleteSecurityGroup(deleteSecurityGroupRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteSecurityGroup operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteSecurityGroup"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSecurityGroup.</param>
        public DeleteSecurityGroupResponse EndDeleteSecurityGroup(IAsyncResult asyncResult)
        {
            return endOperation<DeleteSecurityGroupResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeleteSecurityGroup(DeleteSecurityGroupRequest deleteSecurityGroupRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteSecurityGroupRequestMarshaller().Marshall(deleteSecurityGroupRequest);
            var unmarshaller = DeleteSecurityGroupResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DeleteSnapshot

        /// <summary>
        /// <para> Deletes the snapshot identified by <c>snapshotId</c> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="deleteSnapshotRequest">Container for the necessary parameters to execute the DeleteSnapshot service method on
        ///          AmazonEC2.</param>
        /// 
        public DeleteSnapshotResponse DeleteSnapshot(DeleteSnapshotRequest deleteSnapshotRequest)
        {
            IAsyncResult asyncResult = invokeDeleteSnapshot(deleteSnapshotRequest, null, null, true);
            return EndDeleteSnapshot(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSnapshot operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteSnapshot"/>
        /// </summary>
        /// 
        /// <param name="deleteSnapshotRequest">Container for the necessary parameters to execute the DeleteSnapshot operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginDeleteSnapshot(DeleteSnapshotRequest deleteSnapshotRequest, AsyncCallback callback, object state)
        {
            return invokeDeleteSnapshot(deleteSnapshotRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteSnapshot operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteSnapshot"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSnapshot.</param>
        public DeleteSnapshotResponse EndDeleteSnapshot(IAsyncResult asyncResult)
        {
            return endOperation<DeleteSnapshotResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeleteSnapshot(DeleteSnapshotRequest deleteSnapshotRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteSnapshotRequestMarshaller().Marshall(deleteSnapshotRequest);
            var unmarshaller = DeleteSnapshotResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DeleteSpotDatafeedSubscription

        /// <summary>
        /// <para> Deletes the data feed for Spot Instances. </para> <para> For conceptual information about Spot Instances, refer to the Amazon Elastic
        /// Compute Cloud Developer Guide or Amazon Elastic Compute Cloud User Guide .
        /// </para>
        /// </summary>
        /// 
        /// <param name="deleteSpotDatafeedSubscriptionRequest">Container for the necessary parameters to execute the DeleteSpotDatafeedSubscription
        ///          service method on AmazonEC2.</param>
        /// 
        public DeleteSpotDatafeedSubscriptionResponse DeleteSpotDatafeedSubscription(DeleteSpotDatafeedSubscriptionRequest deleteSpotDatafeedSubscriptionRequest)
        {
            IAsyncResult asyncResult = invokeDeleteSpotDatafeedSubscription(deleteSpotDatafeedSubscriptionRequest, null, null, true);
            return EndDeleteSpotDatafeedSubscription(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSpotDatafeedSubscription operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteSpotDatafeedSubscription"/>
        /// </summary>
        /// 
        /// <param name="deleteSpotDatafeedSubscriptionRequest">Container for the necessary parameters to execute the DeleteSpotDatafeedSubscription
        ///          operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginDeleteSpotDatafeedSubscription(DeleteSpotDatafeedSubscriptionRequest deleteSpotDatafeedSubscriptionRequest, AsyncCallback callback, object state)
        {
            return invokeDeleteSpotDatafeedSubscription(deleteSpotDatafeedSubscriptionRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteSpotDatafeedSubscription operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteSpotDatafeedSubscription"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSpotDatafeedSubscription.</param>
        public DeleteSpotDatafeedSubscriptionResponse EndDeleteSpotDatafeedSubscription(IAsyncResult asyncResult)
        {
            return endOperation<DeleteSpotDatafeedSubscriptionResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeleteSpotDatafeedSubscription(DeleteSpotDatafeedSubscriptionRequest deleteSpotDatafeedSubscriptionRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteSpotDatafeedSubscriptionRequestMarshaller().Marshall(deleteSpotDatafeedSubscriptionRequest);
            var unmarshaller = DeleteSpotDatafeedSubscriptionResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para> Deletes the data feed for Spot Instances. </para> <para> For conceptual information about Spot Instances, refer to the Amazon Elastic
        /// Compute Cloud Developer Guide or Amazon Elastic Compute Cloud User Guide .
        /// </para>
        /// </summary>
        /// 
        public DeleteSpotDatafeedSubscriptionResponse DeleteSpotDatafeedSubscription()
        {
            return DeleteSpotDatafeedSubscription(new DeleteSpotDatafeedSubscriptionRequest());
        }
        

        #endregion
    
        #region DeleteSubnet

        /// <summary>
        /// <para> Deletes a subnet from a VPC. You must terminate all running instances in the subnet before deleting it, otherwise Amazon VPC returns
        /// an error. </para>
        /// </summary>
        /// 
        /// <param name="deleteSubnetRequest">Container for the necessary parameters to execute the DeleteSubnet service method on AmazonEC2.</param>
        /// 
        public DeleteSubnetResponse DeleteSubnet(DeleteSubnetRequest deleteSubnetRequest)
        {
            IAsyncResult asyncResult = invokeDeleteSubnet(deleteSubnetRequest, null, null, true);
            return EndDeleteSubnet(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteSubnet operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteSubnet"/>
        /// </summary>
        /// 
        /// <param name="deleteSubnetRequest">Container for the necessary parameters to execute the DeleteSubnet operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginDeleteSubnet(DeleteSubnetRequest deleteSubnetRequest, AsyncCallback callback, object state)
        {
            return invokeDeleteSubnet(deleteSubnetRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteSubnet operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteSubnet"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteSubnet.</param>
        public DeleteSubnetResponse EndDeleteSubnet(IAsyncResult asyncResult)
        {
            return endOperation<DeleteSubnetResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeleteSubnet(DeleteSubnetRequest deleteSubnetRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteSubnetRequestMarshaller().Marshall(deleteSubnetRequest);
            var unmarshaller = DeleteSubnetResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DeleteTags

        /// <summary>
        /// <para> Deletes tags from the specified Amazon EC2 resources. </para>
        /// </summary>
        /// 
        /// <param name="deleteTagsRequest">Container for the necessary parameters to execute the DeleteTags service method on AmazonEC2.</param>
        /// 
        public DeleteTagsResponse DeleteTags(DeleteTagsRequest deleteTagsRequest)
        {
            IAsyncResult asyncResult = invokeDeleteTags(deleteTagsRequest, null, null, true);
            return EndDeleteTags(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteTags operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteTags"/>
        /// </summary>
        /// 
        /// <param name="deleteTagsRequest">Container for the necessary parameters to execute the DeleteTags operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginDeleteTags(DeleteTagsRequest deleteTagsRequest, AsyncCallback callback, object state)
        {
            return invokeDeleteTags(deleteTagsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteTags operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteTags"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteTags.</param>
        public DeleteTagsResponse EndDeleteTags(IAsyncResult asyncResult)
        {
            return endOperation<DeleteTagsResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeleteTags(DeleteTagsRequest deleteTagsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteTagsRequestMarshaller().Marshall(deleteTagsRequest);
            var unmarshaller = DeleteTagsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DeleteVolume

        /// <summary>
        /// <para> Deletes a previously created volume. Once successfully deleted, a new volume can be created with the same name. </para>
        /// </summary>
        /// 
        /// <param name="deleteVolumeRequest">Container for the necessary parameters to execute the DeleteVolume service method on AmazonEC2.</param>
        /// 
        public DeleteVolumeResponse DeleteVolume(DeleteVolumeRequest deleteVolumeRequest)
        {
            IAsyncResult asyncResult = invokeDeleteVolume(deleteVolumeRequest, null, null, true);
            return EndDeleteVolume(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVolume operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteVolume"/>
        /// </summary>
        /// 
        /// <param name="deleteVolumeRequest">Container for the necessary parameters to execute the DeleteVolume operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginDeleteVolume(DeleteVolumeRequest deleteVolumeRequest, AsyncCallback callback, object state)
        {
            return invokeDeleteVolume(deleteVolumeRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteVolume operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteVolume"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVolume.</param>
        public DeleteVolumeResponse EndDeleteVolume(IAsyncResult asyncResult)
        {
            return endOperation<DeleteVolumeResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeleteVolume(DeleteVolumeRequest deleteVolumeRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteVolumeRequestMarshaller().Marshall(deleteVolumeRequest);
            var unmarshaller = DeleteVolumeResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DeleteVpc

        /// <summary>
        /// <para> Deletes a VPC. You must detach or delete all gateways or other objects that are dependent on the VPC first. For example, you must
        /// terminate all running instances, delete all VPC security groups (except the default), delete all the route tables (except the default), etc.
        /// </para>
        /// </summary>
        /// 
        /// <param name="deleteVpcRequest">Container for the necessary parameters to execute the DeleteVpc service method on AmazonEC2.</param>
        /// 
        public DeleteVpcResponse DeleteVpc(DeleteVpcRequest deleteVpcRequest)
        {
            IAsyncResult asyncResult = invokeDeleteVpc(deleteVpcRequest, null, null, true);
            return EndDeleteVpc(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVpc operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteVpc"/>
        /// </summary>
        /// 
        /// <param name="deleteVpcRequest">Container for the necessary parameters to execute the DeleteVpc operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginDeleteVpc(DeleteVpcRequest deleteVpcRequest, AsyncCallback callback, object state)
        {
            return invokeDeleteVpc(deleteVpcRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteVpc operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteVpc"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVpc.</param>
        public DeleteVpcResponse EndDeleteVpc(IAsyncResult asyncResult)
        {
            return endOperation<DeleteVpcResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeleteVpc(DeleteVpcRequest deleteVpcRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteVpcRequestMarshaller().Marshall(deleteVpcRequest);
            var unmarshaller = DeleteVpcResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DeleteVpnConnection

        /// <summary>
        /// <para> Deletes a VPN connection. Use this if you want to delete a VPC and all its associated components. Another reason to use this
        /// operation is if you believe the tunnel credentials for your VPN connection have been compromised. In that situation, you can delete the VPN
        /// connection and create a new one that has new keys, without needing to delete the VPC or VPN gateway. If you create a new VPN connection, you
        /// must reconfigure the customer gateway using the new configuration information returned with the new VPN connection ID. </para> <para> If
        /// you're deleting the VPC and all its associated parts, we recommend you detach the VPN gateway from the VPC and delete the VPC before
        /// deleting the VPN connection. </para>
        /// </summary>
        /// 
        /// <param name="deleteVpnConnectionRequest">Container for the necessary parameters to execute the DeleteVpnConnection service method on
        ///          AmazonEC2.</param>
        /// 
        public DeleteVpnConnectionResponse DeleteVpnConnection(DeleteVpnConnectionRequest deleteVpnConnectionRequest)
        {
            IAsyncResult asyncResult = invokeDeleteVpnConnection(deleteVpnConnectionRequest, null, null, true);
            return EndDeleteVpnConnection(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVpnConnection operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteVpnConnection"/>
        /// </summary>
        /// 
        /// <param name="deleteVpnConnectionRequest">Container for the necessary parameters to execute the DeleteVpnConnection operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginDeleteVpnConnection(DeleteVpnConnectionRequest deleteVpnConnectionRequest, AsyncCallback callback, object state)
        {
            return invokeDeleteVpnConnection(deleteVpnConnectionRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteVpnConnection operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteVpnConnection"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVpnConnection.</param>
        public DeleteVpnConnectionResponse EndDeleteVpnConnection(IAsyncResult asyncResult)
        {
            return endOperation<DeleteVpnConnectionResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeleteVpnConnection(DeleteVpnConnectionRequest deleteVpnConnectionRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteVpnConnectionRequestMarshaller().Marshall(deleteVpnConnectionRequest);
            var unmarshaller = DeleteVpnConnectionResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DeleteVpnConnectionRoute

        /// <summary>
        /// </summary>
        /// 
        /// <param name="deleteVpnConnectionRouteRequest">Container for the necessary parameters to execute the DeleteVpnConnectionRoute service method
        ///          on AmazonEC2.</param>
        /// 
        public DeleteVpnConnectionRouteResponse DeleteVpnConnectionRoute(DeleteVpnConnectionRouteRequest deleteVpnConnectionRouteRequest)
        {
            IAsyncResult asyncResult = invokeDeleteVpnConnectionRoute(deleteVpnConnectionRouteRequest, null, null, true);
            return EndDeleteVpnConnectionRoute(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVpnConnectionRoute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteVpnConnectionRoute"/>
        /// </summary>
        /// 
        /// <param name="deleteVpnConnectionRouteRequest">Container for the necessary parameters to execute the DeleteVpnConnectionRoute operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginDeleteVpnConnectionRoute(DeleteVpnConnectionRouteRequest deleteVpnConnectionRouteRequest, AsyncCallback callback, object state)
        {
            return invokeDeleteVpnConnectionRoute(deleteVpnConnectionRouteRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteVpnConnectionRoute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteVpnConnectionRoute"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVpnConnectionRoute.</param>
        public DeleteVpnConnectionRouteResponse EndDeleteVpnConnectionRoute(IAsyncResult asyncResult)
        {
            return endOperation<DeleteVpnConnectionRouteResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeleteVpnConnectionRoute(DeleteVpnConnectionRouteRequest deleteVpnConnectionRouteRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteVpnConnectionRouteRequestMarshaller().Marshall(deleteVpnConnectionRouteRequest);
            var unmarshaller = DeleteVpnConnectionRouteResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DeleteVpnGateway

        /// <summary>
        /// <para> Deletes a VPN gateway. Use this when you want to delete a VPC and all its associated components because you no longer need them. We
        /// recommend that before you delete a VPN gateway, you detach it from the VPC and delete the VPN connection. Note that you don't need to delete
        /// the VPN gateway if you just want to delete and re-create the VPN connection between your VPC and data center. </para>
        /// </summary>
        /// 
        /// <param name="deleteVpnGatewayRequest">Container for the necessary parameters to execute the DeleteVpnGateway service method on
        ///          AmazonEC2.</param>
        /// 
        public DeleteVpnGatewayResponse DeleteVpnGateway(DeleteVpnGatewayRequest deleteVpnGatewayRequest)
        {
            IAsyncResult asyncResult = invokeDeleteVpnGateway(deleteVpnGatewayRequest, null, null, true);
            return EndDeleteVpnGateway(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeleteVpnGateway operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteVpnGateway"/>
        /// </summary>
        /// 
        /// <param name="deleteVpnGatewayRequest">Container for the necessary parameters to execute the DeleteVpnGateway operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginDeleteVpnGateway(DeleteVpnGatewayRequest deleteVpnGatewayRequest, AsyncCallback callback, object state)
        {
            return invokeDeleteVpnGateway(deleteVpnGatewayRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeleteVpnGateway operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeleteVpnGateway"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeleteVpnGateway.</param>
        public DeleteVpnGatewayResponse EndDeleteVpnGateway(IAsyncResult asyncResult)
        {
            return endOperation<DeleteVpnGatewayResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeleteVpnGateway(DeleteVpnGatewayRequest deleteVpnGatewayRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeleteVpnGatewayRequestMarshaller().Marshall(deleteVpnGatewayRequest);
            var unmarshaller = DeleteVpnGatewayResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DeregisterImage

        /// <summary>
        /// <para> The DeregisterImage operation deregisters an AMI. Once deregistered, instances of the AMI can no longer be launched. </para>
        /// </summary>
        /// 
        /// <param name="deregisterImageRequest">Container for the necessary parameters to execute the DeregisterImage service method on
        ///          AmazonEC2.</param>
        /// 
        public DeregisterImageResponse DeregisterImage(DeregisterImageRequest deregisterImageRequest)
        {
            IAsyncResult asyncResult = invokeDeregisterImage(deregisterImageRequest, null, null, true);
            return EndDeregisterImage(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DeregisterImage operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeregisterImage"/>
        /// </summary>
        /// 
        /// <param name="deregisterImageRequest">Container for the necessary parameters to execute the DeregisterImage operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginDeregisterImage(DeregisterImageRequest deregisterImageRequest, AsyncCallback callback, object state)
        {
            return invokeDeregisterImage(deregisterImageRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DeregisterImage operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DeregisterImage"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDeregisterImage.</param>
        public DeregisterImageResponse EndDeregisterImage(IAsyncResult asyncResult)
        {
            return endOperation<DeregisterImageResponse>(asyncResult);
        }
        
        IAsyncResult invokeDeregisterImage(DeregisterImageRequest deregisterImageRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DeregisterImageRequestMarshaller().Marshall(deregisterImageRequest);
            var unmarshaller = DeregisterImageResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DescribeAccountAttributes

        /// <summary>
        /// </summary>
        /// 
        /// <param name="describeAccountAttributesRequest">Container for the necessary parameters to execute the DescribeAccountAttributes service
        ///          method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeAccountAttributes service method, as returned by AmazonEC2.</returns>
        /// 
        public DescribeAccountAttributesResponse DescribeAccountAttributes(DescribeAccountAttributesRequest describeAccountAttributesRequest)
        {
            IAsyncResult asyncResult = invokeDescribeAccountAttributes(describeAccountAttributesRequest, null, null, true);
            return EndDescribeAccountAttributes(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAccountAttributes operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeAccountAttributes"/>
        /// </summary>
        /// 
        /// <param name="describeAccountAttributesRequest">Container for the necessary parameters to execute the DescribeAccountAttributes operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeAccountAttributes operation.</returns>
        public IAsyncResult BeginDescribeAccountAttributes(DescribeAccountAttributesRequest describeAccountAttributesRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeAccountAttributes(describeAccountAttributesRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeAccountAttributes operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeAccountAttributes"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAccountAttributes.</param>
        /// 
        /// <returns>Returns a DescribeAccountAttributesResult from AmazonEC2.</returns>
        public DescribeAccountAttributesResponse EndDescribeAccountAttributes(IAsyncResult asyncResult)
        {
            return endOperation<DescribeAccountAttributesResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeAccountAttributes(DescribeAccountAttributesRequest describeAccountAttributesRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeAccountAttributesRequestMarshaller().Marshall(describeAccountAttributesRequest);
            var unmarshaller = DescribeAccountAttributesResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeAccountAttributes service method, as returned by AmazonEC2.</returns>
        /// 
        public DescribeAccountAttributesResponse DescribeAccountAttributes()
        {
            return DescribeAccountAttributes(new DescribeAccountAttributesRequest());
        }
        

        #endregion
    
        #region DescribeAddresses

        /// <summary>
        /// <para> The DescribeAddresses operation lists elastic IP addresses assigned to your account. </para>
        /// </summary>
        /// 
        /// <param name="describeAddressesRequest">Container for the necessary parameters to execute the DescribeAddresses service method on
        ///          AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeAddresses service method, as returned by AmazonEC2.</returns>
        /// 
        public DescribeAddressesResponse DescribeAddresses(DescribeAddressesRequest describeAddressesRequest)
        {
            IAsyncResult asyncResult = invokeDescribeAddresses(describeAddressesRequest, null, null, true);
            return EndDescribeAddresses(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAddresses operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeAddresses"/>
        /// </summary>
        /// 
        /// <param name="describeAddressesRequest">Container for the necessary parameters to execute the DescribeAddresses operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeAddresses
        ///         operation.</returns>
        public IAsyncResult BeginDescribeAddresses(DescribeAddressesRequest describeAddressesRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeAddresses(describeAddressesRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeAddresses operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeAddresses"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAddresses.</param>
        /// 
        /// <returns>Returns a DescribeAddressesResult from AmazonEC2.</returns>
        public DescribeAddressesResponse EndDescribeAddresses(IAsyncResult asyncResult)
        {
            return endOperation<DescribeAddressesResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeAddresses(DescribeAddressesRequest describeAddressesRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeAddressesRequestMarshaller().Marshall(describeAddressesRequest);
            var unmarshaller = DescribeAddressesResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para> The DescribeAddresses operation lists elastic IP addresses assigned to your account. </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeAddresses service method, as returned by AmazonEC2.</returns>
        /// 
        public DescribeAddressesResponse DescribeAddresses()
        {
            return DescribeAddresses(new DescribeAddressesRequest());
        }
        

        #endregion
    
        #region DescribeAvailabilityZones

        /// <summary>
        /// <para> The DescribeAvailabilityZones operation describes availability zones that are currently available to the account and their states.
        /// </para> <para> Availability zones are not the same across accounts. The availability zone <c>us-east-1a</c> for account A is not necessarily
        /// the same as <c>us-east-1a</c> for account B. Zone assignments are mapped independently for each account. </para>
        /// </summary>
        /// 
        /// <param name="describeAvailabilityZonesRequest">Container for the necessary parameters to execute the DescribeAvailabilityZones service
        ///          method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeAvailabilityZones service method, as returned by AmazonEC2.</returns>
        /// 
        public DescribeAvailabilityZonesResponse DescribeAvailabilityZones(DescribeAvailabilityZonesRequest describeAvailabilityZonesRequest)
        {
            IAsyncResult asyncResult = invokeDescribeAvailabilityZones(describeAvailabilityZonesRequest, null, null, true);
            return EndDescribeAvailabilityZones(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeAvailabilityZones operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeAvailabilityZones"/>
        /// </summary>
        /// 
        /// <param name="describeAvailabilityZonesRequest">Container for the necessary parameters to execute the DescribeAvailabilityZones operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeAvailabilityZones operation.</returns>
        public IAsyncResult BeginDescribeAvailabilityZones(DescribeAvailabilityZonesRequest describeAvailabilityZonesRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeAvailabilityZones(describeAvailabilityZonesRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeAvailabilityZones operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeAvailabilityZones"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeAvailabilityZones.</param>
        /// 
        /// <returns>Returns a DescribeAvailabilityZonesResult from AmazonEC2.</returns>
        public DescribeAvailabilityZonesResponse EndDescribeAvailabilityZones(IAsyncResult asyncResult)
        {
            return endOperation<DescribeAvailabilityZonesResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeAvailabilityZones(DescribeAvailabilityZonesRequest describeAvailabilityZonesRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeAvailabilityZonesRequestMarshaller().Marshall(describeAvailabilityZonesRequest);
            var unmarshaller = DescribeAvailabilityZonesResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para> The DescribeAvailabilityZones operation describes availability zones that are currently available to the account and their states.
        /// </para> <para> Availability zones are not the same across accounts. The availability zone <c>us-east-1a</c> for account A is not necessarily
        /// the same as <c>us-east-1a</c> for account B. Zone assignments are mapped independently for each account. </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeAvailabilityZones service method, as returned by AmazonEC2.</returns>
        /// 
        public DescribeAvailabilityZonesResponse DescribeAvailabilityZones()
        {
            return DescribeAvailabilityZones(new DescribeAvailabilityZonesRequest());
        }
        

        #endregion
    
        #region DescribeBundleTasks

        /// <summary>
        /// <para> The DescribeBundleTasks operation describes in-progress and recent bundle tasks. Complete and failed tasks are removed from the list
        /// a short time after completion. If no bundle ids are given, all bundle tasks are returned. </para>
        /// </summary>
        /// 
        /// <param name="describeBundleTasksRequest">Container for the necessary parameters to execute the DescribeBundleTasks service method on
        ///          AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeBundleTasks service method, as returned by AmazonEC2.</returns>
        /// 
        public DescribeBundleTasksResponse DescribeBundleTasks(DescribeBundleTasksRequest describeBundleTasksRequest)
        {
            IAsyncResult asyncResult = invokeDescribeBundleTasks(describeBundleTasksRequest, null, null, true);
            return EndDescribeBundleTasks(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeBundleTasks operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeBundleTasks"/>
        /// </summary>
        /// 
        /// <param name="describeBundleTasksRequest">Container for the necessary parameters to execute the DescribeBundleTasks operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeBundleTasks operation.</returns>
        public IAsyncResult BeginDescribeBundleTasks(DescribeBundleTasksRequest describeBundleTasksRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeBundleTasks(describeBundleTasksRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeBundleTasks operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeBundleTasks"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeBundleTasks.</param>
        /// 
        /// <returns>Returns a DescribeBundleTasksResult from AmazonEC2.</returns>
        public DescribeBundleTasksResponse EndDescribeBundleTasks(IAsyncResult asyncResult)
        {
            return endOperation<DescribeBundleTasksResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeBundleTasks(DescribeBundleTasksRequest describeBundleTasksRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeBundleTasksRequestMarshaller().Marshall(describeBundleTasksRequest);
            var unmarshaller = DescribeBundleTasksResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para> The DescribeBundleTasks operation describes in-progress and recent bundle tasks. Complete and failed tasks are removed from the list
        /// a short time after completion. If no bundle ids are given, all bundle tasks are returned. </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeBundleTasks service method, as returned by AmazonEC2.</returns>
        /// 
        public DescribeBundleTasksResponse DescribeBundleTasks()
        {
            return DescribeBundleTasks(new DescribeBundleTasksRequest());
        }
        

        #endregion
    
        #region DescribeConversionTasks

        /// <summary>
        /// </summary>
        /// 
        /// <param name="describeConversionTasksRequest">Container for the necessary parameters to execute the DescribeConversionTasks service method on
        ///          AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeConversionTasks service method, as returned by AmazonEC2.</returns>
        /// 
        public DescribeConversionTasksResponse DescribeConversionTasks(DescribeConversionTasksRequest describeConversionTasksRequest)
        {
            IAsyncResult asyncResult = invokeDescribeConversionTasks(describeConversionTasksRequest, null, null, true);
            return EndDescribeConversionTasks(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeConversionTasks operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeConversionTasks"/>
        /// </summary>
        /// 
        /// <param name="describeConversionTasksRequest">Container for the necessary parameters to execute the DescribeConversionTasks operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeConversionTasks operation.</returns>
        public IAsyncResult BeginDescribeConversionTasks(DescribeConversionTasksRequest describeConversionTasksRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeConversionTasks(describeConversionTasksRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeConversionTasks operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeConversionTasks"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeConversionTasks.</param>
        /// 
        /// <returns>Returns a DescribeConversionTasksResult from AmazonEC2.</returns>
        public DescribeConversionTasksResponse EndDescribeConversionTasks(IAsyncResult asyncResult)
        {
            return endOperation<DescribeConversionTasksResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeConversionTasks(DescribeConversionTasksRequest describeConversionTasksRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeConversionTasksRequestMarshaller().Marshall(describeConversionTasksRequest);
            var unmarshaller = DescribeConversionTasksResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeConversionTasks service method, as returned by AmazonEC2.</returns>
        /// 
        public DescribeConversionTasksResponse DescribeConversionTasks()
        {
            return DescribeConversionTasks(new DescribeConversionTasksRequest());
        }
        

        #endregion
    
        #region DescribeCustomerGateways

        /// <summary>
        /// <para> Gives you information about your customer gateways. You can filter the results to return information only about customer gateways
        /// that match criteria you specify. For example, you could ask to get information about a particular customer gateway (or all) only if the
        /// gateway's state is pending or available. You can specify multiple filters (e.g., the customer gateway has a particular IP address for the
        /// Internet-routable external interface, and the gateway's state is pending or available). The result includes information for a particular
        /// customer gateway only if the gateway matches all your filters. If there's no match, no special message is returned; the response is simply
        /// empty. The following table shows the available filters. </para>
        /// </summary>
        /// 
        /// <param name="describeCustomerGatewaysRequest">Container for the necessary parameters to execute the DescribeCustomerGateways service method
        ///          on AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeCustomerGateways service method, as returned by AmazonEC2.</returns>
        /// 
        public DescribeCustomerGatewaysResponse DescribeCustomerGateways(DescribeCustomerGatewaysRequest describeCustomerGatewaysRequest)
        {
            IAsyncResult asyncResult = invokeDescribeCustomerGateways(describeCustomerGatewaysRequest, null, null, true);
            return EndDescribeCustomerGateways(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeCustomerGateways operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeCustomerGateways"/>
        /// </summary>
        /// 
        /// <param name="describeCustomerGatewaysRequest">Container for the necessary parameters to execute the DescribeCustomerGateways operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeCustomerGateways operation.</returns>
        public IAsyncResult BeginDescribeCustomerGateways(DescribeCustomerGatewaysRequest describeCustomerGatewaysRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeCustomerGateways(describeCustomerGatewaysRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeCustomerGateways operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeCustomerGateways"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeCustomerGateways.</param>
        /// 
        /// <returns>Returns a DescribeCustomerGatewaysResult from AmazonEC2.</returns>
        public DescribeCustomerGatewaysResponse EndDescribeCustomerGateways(IAsyncResult asyncResult)
        {
            return endOperation<DescribeCustomerGatewaysResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeCustomerGateways(DescribeCustomerGatewaysRequest describeCustomerGatewaysRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeCustomerGatewaysRequestMarshaller().Marshall(describeCustomerGatewaysRequest);
            var unmarshaller = DescribeCustomerGatewaysResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para> Gives you information about your customer gateways. You can filter the results to return information only about customer gateways
        /// that match criteria you specify. For example, you could ask to get information about a particular customer gateway (or all) only if the
        /// gateway's state is pending or available. You can specify multiple filters (e.g., the customer gateway has a particular IP address for the
        /// Internet-routable external interface, and the gateway's state is pending or available). The result includes information for a particular
        /// customer gateway only if the gateway matches all your filters. If there's no match, no special message is returned; the response is simply
        /// empty. The following table shows the available filters. </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeCustomerGateways service method, as returned by AmazonEC2.</returns>
        /// 
        public DescribeCustomerGatewaysResponse DescribeCustomerGateways()
        {
            return DescribeCustomerGateways(new DescribeCustomerGatewaysRequest());
        }
        

        #endregion
    
        #region DescribeDhcpOptions

        /// <summary>
        /// <para> Gives you information about one or more sets of DHCP options. You can specify one or more DHCP options set IDs, or no IDs (to
        /// describe all your sets of DHCP options). The returned information consists of: </para>
        /// <ul>
        /// <li> The DHCP options set ID </li>
        /// <li> The options </li>
        /// 
        /// </ul>
        /// </summary>
        /// 
        /// <param name="describeDhcpOptionsRequest">Container for the necessary parameters to execute the DescribeDhcpOptions service method on
        ///          AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeDhcpOptions service method, as returned by AmazonEC2.</returns>
        /// 
        public DescribeDhcpOptionsResponse DescribeDhcpOptions(DescribeDhcpOptionsRequest describeDhcpOptionsRequest)
        {
            IAsyncResult asyncResult = invokeDescribeDhcpOptions(describeDhcpOptionsRequest, null, null, true);
            return EndDescribeDhcpOptions(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeDhcpOptions operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeDhcpOptions"/>
        /// </summary>
        /// 
        /// <param name="describeDhcpOptionsRequest">Container for the necessary parameters to execute the DescribeDhcpOptions operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeDhcpOptions operation.</returns>
        public IAsyncResult BeginDescribeDhcpOptions(DescribeDhcpOptionsRequest describeDhcpOptionsRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeDhcpOptions(describeDhcpOptionsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeDhcpOptions operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeDhcpOptions"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeDhcpOptions.</param>
        /// 
        /// <returns>Returns a DescribeDhcpOptionsResult from AmazonEC2.</returns>
        public DescribeDhcpOptionsResponse EndDescribeDhcpOptions(IAsyncResult asyncResult)
        {
            return endOperation<DescribeDhcpOptionsResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeDhcpOptions(DescribeDhcpOptionsRequest describeDhcpOptionsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeDhcpOptionsRequestMarshaller().Marshall(describeDhcpOptionsRequest);
            var unmarshaller = DescribeDhcpOptionsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para> Gives you information about one or more sets of DHCP options. You can specify one or more DHCP options set IDs, or no IDs (to
        /// describe all your sets of DHCP options). The returned information consists of: </para>
        /// <ul>
        /// <li> The DHCP options set ID </li>
        /// <li> The options </li>
        /// 
        /// </ul>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeDhcpOptions service method, as returned by AmazonEC2.</returns>
        /// 
        public DescribeDhcpOptionsResponse DescribeDhcpOptions()
        {
            return DescribeDhcpOptions(new DescribeDhcpOptionsRequest());
        }
        

        #endregion
    
        #region DescribeExportTasks

        /// <summary>
        /// </summary>
        /// 
        /// <param name="describeExportTasksRequest">Container for the necessary parameters to execute the DescribeExportTasks service method on
        ///          AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeExportTasks service method, as returned by AmazonEC2.</returns>
        /// 
        public DescribeExportTasksResponse DescribeExportTasks(DescribeExportTasksRequest describeExportTasksRequest)
        {
            IAsyncResult asyncResult = invokeDescribeExportTasks(describeExportTasksRequest, null, null, true);
            return EndDescribeExportTasks(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeExportTasks operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeExportTasks"/>
        /// </summary>
        /// 
        /// <param name="describeExportTasksRequest">Container for the necessary parameters to execute the DescribeExportTasks operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeExportTasks operation.</returns>
        public IAsyncResult BeginDescribeExportTasks(DescribeExportTasksRequest describeExportTasksRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeExportTasks(describeExportTasksRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeExportTasks operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeExportTasks"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeExportTasks.</param>
        /// 
        /// <returns>Returns a DescribeExportTasksResult from AmazonEC2.</returns>
        public DescribeExportTasksResponse EndDescribeExportTasks(IAsyncResult asyncResult)
        {
            return endOperation<DescribeExportTasksResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeExportTasks(DescribeExportTasksRequest describeExportTasksRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeExportTasksRequestMarshaller().Marshall(describeExportTasksRequest);
            var unmarshaller = DescribeExportTasksResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeExportTasks service method, as returned by AmazonEC2.</returns>
        /// 
        public DescribeExportTasksResponse DescribeExportTasks()
        {
            return DescribeExportTasks(new DescribeExportTasksRequest());
        }
        

        #endregion
    
        #region DescribeImageAttribute

        /// <summary>
        /// <para> The DescribeImageAttribute operation returns information about an attribute of an AMI. Only one attribute can be specified per call.
        /// </para>
        /// </summary>
        /// 
        /// <param name="describeImageAttributeRequest">Container for the necessary parameters to execute the DescribeImageAttribute service method on
        ///          AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeImageAttribute service method, as returned by AmazonEC2.</returns>
        /// 
        public DescribeImageAttributeResponse DescribeImageAttribute(DescribeImageAttributeRequest describeImageAttributeRequest)
        {
            IAsyncResult asyncResult = invokeDescribeImageAttribute(describeImageAttributeRequest, null, null, true);
            return EndDescribeImageAttribute(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeImageAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeImageAttribute"/>
        /// </summary>
        /// 
        /// <param name="describeImageAttributeRequest">Container for the necessary parameters to execute the DescribeImageAttribute operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeImageAttribute operation.</returns>
        public IAsyncResult BeginDescribeImageAttribute(DescribeImageAttributeRequest describeImageAttributeRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeImageAttribute(describeImageAttributeRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeImageAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeImageAttribute"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeImageAttribute.</param>
        /// 
        /// <returns>Returns a DescribeImageAttributeResult from AmazonEC2.</returns>
        public DescribeImageAttributeResponse EndDescribeImageAttribute(IAsyncResult asyncResult)
        {
            return endOperation<DescribeImageAttributeResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeImageAttribute(DescribeImageAttributeRequest describeImageAttributeRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeImageAttributeRequestMarshaller().Marshall(describeImageAttributeRequest);
            var unmarshaller = DescribeImageAttributeResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DescribeImages

        /// <summary>
        /// <para> The DescribeImages operation returns information about AMIs, AKIs, and ARIs available to the user. Information returned includes
        /// image type, product codes, architecture, and kernel and RAM disk IDs. Images available to the user include public images available for any
        /// user to launch, private images owned by the user making the request, and private images owned by other users for which the user has explicit
        /// launch permissions. </para> <para> Launch permissions fall into three categories: </para>
        /// <ul>
        /// <li> <b>Public:</b> The owner of the AMI granted launch permissions for the AMI to the all group. All users have launch permissions for
        /// these AMIs. </li>
        /// <li> <b>Explicit:</b> The owner of the AMI granted launch permissions to a specific user. </li>
        /// <li> <b>Implicit:</b> A user has implicit launch permissions for all AMIs he or she owns. </li>
        /// 
        /// </ul>
        /// <para> The list of AMIs returned can be modified by specifying AMI IDs, AMI owners, or users with launch permissions. If no options are
        /// specified, Amazon EC2 returns all AMIs for which the user has launch permissions. </para> <para> If you specify one or more AMI IDs, only
        /// AMIs that have the specified IDs are returned. If you specify an invalid AMI ID, a fault is returned. If you specify an AMI ID for which you
        /// do not have access, it will not be included in the returned results. </para> <para> If you specify one or more AMI owners, only AMIs from
        /// the specified owners and for which you have access are returned. The results can include the account IDs of the specified owners, amazon for
        /// AMIs owned by Amazon or self for AMIs that you own. </para> <para> If you specify a list of executable users, only users that have launch
        /// permissions for the AMIs are returned. You can specify account IDs (if you own the AMI(s)), self for AMIs for which you own or have explicit
        /// permissions, or all for public AMIs. </para> <para><b>NOTE:</b> Deregistered images are included in the returned results for an unspecified
        /// interval after deregistration. </para>
        /// </summary>
        /// 
        /// <param name="describeImagesRequest">Container for the necessary parameters to execute the DescribeImages service method on
        ///          AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeImages service method, as returned by AmazonEC2.</returns>
        /// 
        public DescribeImagesResponse DescribeImages(DescribeImagesRequest describeImagesRequest)
        {
            IAsyncResult asyncResult = invokeDescribeImages(describeImagesRequest, null, null, true);
            return EndDescribeImages(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeImages operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeImages"/>
        /// </summary>
        /// 
        /// <param name="describeImagesRequest">Container for the necessary parameters to execute the DescribeImages operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeImages
        ///         operation.</returns>
        public IAsyncResult BeginDescribeImages(DescribeImagesRequest describeImagesRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeImages(describeImagesRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeImages operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeImages"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeImages.</param>
        /// 
        /// <returns>Returns a DescribeImagesResult from AmazonEC2.</returns>
        public DescribeImagesResponse EndDescribeImages(IAsyncResult asyncResult)
        {
            return endOperation<DescribeImagesResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeImages(DescribeImagesRequest describeImagesRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeImagesRequestMarshaller().Marshall(describeImagesRequest);
            var unmarshaller = DescribeImagesResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para> The DescribeImages operation returns information about AMIs, AKIs, and ARIs available to the user. Information returned includes
        /// image type, product codes, architecture, and kernel and RAM disk IDs. Images available to the user include public images available for any
        /// user to launch, private images owned by the user making the request, and private images owned by other users for which the user has explicit
        /// launch permissions. </para> <para> Launch permissions fall into three categories: </para>
        /// <ul>
        /// <li> <b>Public:</b> The owner of the AMI granted launch permissions for the AMI to the all group. All users have launch permissions for
        /// these AMIs. </li>
        /// <li> <b>Explicit:</b> The owner of the AMI granted launch permissions to a specific user. </li>
        /// <li> <b>Implicit:</b> A user has implicit launch permissions for all AMIs he or she owns. </li>
        /// 
        /// </ul>
        /// <para> The list of AMIs returned can be modified by specifying AMI IDs, AMI owners, or users with launch permissions. If no options are
        /// specified, Amazon EC2 returns all AMIs for which the user has launch permissions. </para> <para> If you specify one or more AMI IDs, only
        /// AMIs that have the specified IDs are returned. If you specify an invalid AMI ID, a fault is returned. If you specify an AMI ID for which you
        /// do not have access, it will not be included in the returned results. </para> <para> If you specify one or more AMI owners, only AMIs from
        /// the specified owners and for which you have access are returned. The results can include the account IDs of the specified owners, amazon for
        /// AMIs owned by Amazon or self for AMIs that you own. </para> <para> If you specify a list of executable users, only users that have launch
        /// permissions for the AMIs are returned. You can specify account IDs (if you own the AMI(s)), self for AMIs for which you own or have explicit
        /// permissions, or all for public AMIs. </para> <para><b>NOTE:</b> Deregistered images are included in the returned results for an unspecified
        /// interval after deregistration. </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeImages service method, as returned by AmazonEC2.</returns>
        /// 
        public DescribeImagesResponse DescribeImages()
        {
            return DescribeImages(new DescribeImagesRequest());
        }
        

        #endregion
    
        #region DescribeInstanceAttribute

        /// <summary>
        /// <para> Returns information about an attribute of an instance. Only one attribute can be specified per call. </para>
        /// </summary>
        /// 
        /// <param name="describeInstanceAttributeRequest">Container for the necessary parameters to execute the DescribeInstanceAttribute service
        ///          method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeInstanceAttribute service method, as returned by AmazonEC2.</returns>
        /// 
        public DescribeInstanceAttributeResponse DescribeInstanceAttribute(DescribeInstanceAttributeRequest describeInstanceAttributeRequest)
        {
            IAsyncResult asyncResult = invokeDescribeInstanceAttribute(describeInstanceAttributeRequest, null, null, true);
            return EndDescribeInstanceAttribute(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInstanceAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeInstanceAttribute"/>
        /// </summary>
        /// 
        /// <param name="describeInstanceAttributeRequest">Container for the necessary parameters to execute the DescribeInstanceAttribute operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeInstanceAttribute operation.</returns>
        public IAsyncResult BeginDescribeInstanceAttribute(DescribeInstanceAttributeRequest describeInstanceAttributeRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeInstanceAttribute(describeInstanceAttributeRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeInstanceAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeInstanceAttribute"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeInstanceAttribute.</param>
        /// 
        /// <returns>Returns a DescribeInstanceAttributeResult from AmazonEC2.</returns>
        public DescribeInstanceAttributeResponse EndDescribeInstanceAttribute(IAsyncResult asyncResult)
        {
            return endOperation<DescribeInstanceAttributeResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeInstanceAttribute(DescribeInstanceAttributeRequest describeInstanceAttributeRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeInstanceAttributeRequestMarshaller().Marshall(describeInstanceAttributeRequest);
            var unmarshaller = DescribeInstanceAttributeResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DescribeInstanceStatus

        /// <summary>
        /// <para> Describes the status of an Amazon Elastic Compute Cloud (Amazon EC2) instance. Instance status provides information about two types
        /// of scheduled events for an instance that may require your attention: </para>
        /// <ul>
        /// <li> Scheduled Reboot: When Amazon EC2 determines that an instance must be rebooted, the instance's status will return one of two event
        /// codes: <c>system-reboot</c> or <c>instance-reboot</c> . System reboot commonly occurs if certain maintenance or upgrade operations require a
        /// reboot of the underlying host that supports an instance. Instance reboot commonly occurs if the instance must be rebooted, rather than the
        /// underlying host. Rebooting events include a scheduled start and end time. </li>
        /// <li> Scheduled Retirement: When Amazon EC2 determines that an instance must be shut down, the instance's status will return an event code
        /// called <c>instance-retirement</c> . Retirement commonly occurs when the underlying host is degraded and must be replaced. Retirement events
        /// include a scheduled start and end time. You're also notified by email if one of your instances is set to retiring. The email message
        /// indicates when your instance will be permanently retired. </li>
        /// 
        /// </ul>
        /// <para> If your instance is permanently retired, it will not be restarted. You can avoid retirement by manually restarting your instance
        /// when its event code is <c>instance-retirement</c> . This ensures that your instance is started on a healthy host. </para> <para>
        /// <c>DescribeInstanceStatus</c> returns information only for instances in the running state. </para> <para> You can filter the results to
        /// return information only about instances that match criteria you specify. For example, you could get information about instances in a
        /// specific Availability Zone. You can specify multiple values for a filter (e.g., more than one Availability Zone). An instance must match at
        /// least one of the specified values for it to be included in the results. </para> <para> You can specify multiple filters. An instance must
        /// match all the filters for it to be included in the results. If there's no match, no special message is returned; the response is simply
        /// empty. </para> <para> You can use wildcards with the filter values: <c>*</c> matches zero or more characters, and <c>?</c> matches exactly
        /// one character. You can escape special characters using a backslash before the character. For example, a value of <c>\*amazon\?\\</c>
        /// searches for the literal string <c>*amazon?\</c> .
        /// </para> <para> The following filters are available: </para>
        /// <ul>
        /// <li> <c>availability-zone</c> - Filter on an instance's availability zone. </li>
        /// <li> <c>instance-state-name</c> - Filter on the intended state of the instance, e.g., running. </li>
        /// <li> <c>instance-state-code</c> - Filter on the intended state code of the instance, e.g., 16. </li>
        /// 
        /// </ul>
        /// </summary>
        /// 
        /// <param name="describeInstanceStatusRequest">Container for the necessary parameters to execute the DescribeInstanceStatus service method on
        ///          AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeInstanceStatus service method, as returned by AmazonEC2.</returns>
        /// 
        public DescribeInstanceStatusResponse DescribeInstanceStatus(DescribeInstanceStatusRequest describeInstanceStatusRequest)
        {
            IAsyncResult asyncResult = invokeDescribeInstanceStatus(describeInstanceStatusRequest, null, null, true);
            return EndDescribeInstanceStatus(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInstanceStatus operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeInstanceStatus"/>
        /// </summary>
        /// 
        /// <param name="describeInstanceStatusRequest">Container for the necessary parameters to execute the DescribeInstanceStatus operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeInstanceStatus operation.</returns>
        public IAsyncResult BeginDescribeInstanceStatus(DescribeInstanceStatusRequest describeInstanceStatusRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeInstanceStatus(describeInstanceStatusRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeInstanceStatus operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeInstanceStatus"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeInstanceStatus.</param>
        /// 
        /// <returns>Returns a DescribeInstanceStatusResult from AmazonEC2.</returns>
        public DescribeInstanceStatusResponse EndDescribeInstanceStatus(IAsyncResult asyncResult)
        {
            return endOperation<DescribeInstanceStatusResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeInstanceStatus(DescribeInstanceStatusRequest describeInstanceStatusRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeInstanceStatusRequestMarshaller().Marshall(describeInstanceStatusRequest);
            var unmarshaller = DescribeInstanceStatusResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para> Describes the status of an Amazon Elastic Compute Cloud (Amazon EC2) instance. Instance status provides information about two types
        /// of scheduled events for an instance that may require your attention: </para>
        /// <ul>
        /// <li> Scheduled Reboot: When Amazon EC2 determines that an instance must be rebooted, the instance's status will return one of two event
        /// codes: <c>system-reboot</c> or <c>instance-reboot</c> . System reboot commonly occurs if certain maintenance or upgrade operations require a
        /// reboot of the underlying host that supports an instance. Instance reboot commonly occurs if the instance must be rebooted, rather than the
        /// underlying host. Rebooting events include a scheduled start and end time. </li>
        /// <li> Scheduled Retirement: When Amazon EC2 determines that an instance must be shut down, the instance's status will return an event code
        /// called <c>instance-retirement</c> . Retirement commonly occurs when the underlying host is degraded and must be replaced. Retirement events
        /// include a scheduled start and end time. You're also notified by email if one of your instances is set to retiring. The email message
        /// indicates when your instance will be permanently retired. </li>
        /// 
        /// </ul>
        /// <para> If your instance is permanently retired, it will not be restarted. You can avoid retirement by manually restarting your instance
        /// when its event code is <c>instance-retirement</c> . This ensures that your instance is started on a healthy host. </para> <para>
        /// <c>DescribeInstanceStatus</c> returns information only for instances in the running state. </para> <para> You can filter the results to
        /// return information only about instances that match criteria you specify. For example, you could get information about instances in a
        /// specific Availability Zone. You can specify multiple values for a filter (e.g., more than one Availability Zone). An instance must match at
        /// least one of the specified values for it to be included in the results. </para> <para> You can specify multiple filters. An instance must
        /// match all the filters for it to be included in the results. If there's no match, no special message is returned; the response is simply
        /// empty. </para> <para> You can use wildcards with the filter values: <c>*</c> matches zero or more characters, and <c>?</c> matches exactly
        /// one character. You can escape special characters using a backslash before the character. For example, a value of <c>\*amazon\?\\</c>
        /// searches for the literal string <c>*amazon?\</c> .
        /// </para> <para> The following filters are available: </para>
        /// <ul>
        /// <li> <c>availability-zone</c> - Filter on an instance's availability zone. </li>
        /// <li> <c>instance-state-name</c> - Filter on the intended state of the instance, e.g., running. </li>
        /// <li> <c>instance-state-code</c> - Filter on the intended state code of the instance, e.g., 16. </li>
        /// 
        /// </ul>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeInstanceStatus service method, as returned by AmazonEC2.</returns>
        /// 
        public DescribeInstanceStatusResponse DescribeInstanceStatus()
        {
            return DescribeInstanceStatus(new DescribeInstanceStatusRequest());
        }
        

        #endregion
    
        #region DescribeInstances

        /// <summary>
        /// <para> The DescribeInstances operation returns information about instances that you own. </para> <para> If you specify one or more instance
        /// IDs, Amazon EC2 returns information for those instances. If you do not specify instance IDs, Amazon EC2 returns information for all relevant
        /// instances. If you specify an invalid instance ID, a fault is returned. If you specify an instance that you do not own, it will not be
        /// included in the returned results. </para> <para> Recently terminated instances might appear in the returned results. This interval is
        /// usually less than one hour. </para>
        /// </summary>
        /// 
        /// <param name="describeInstancesRequest">Container for the necessary parameters to execute the DescribeInstances service method on
        ///          AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeInstances service method, as returned by AmazonEC2.</returns>
        /// 
        public DescribeInstancesResponse DescribeInstances(DescribeInstancesRequest describeInstancesRequest)
        {
            IAsyncResult asyncResult = invokeDescribeInstances(describeInstancesRequest, null, null, true);
            return EndDescribeInstances(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInstances operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeInstances"/>
        /// </summary>
        /// 
        /// <param name="describeInstancesRequest">Container for the necessary parameters to execute the DescribeInstances operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeInstances
        ///         operation.</returns>
        public IAsyncResult BeginDescribeInstances(DescribeInstancesRequest describeInstancesRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeInstances(describeInstancesRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeInstances operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeInstances"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeInstances.</param>
        /// 
        /// <returns>Returns a DescribeInstancesResult from AmazonEC2.</returns>
        public DescribeInstancesResponse EndDescribeInstances(IAsyncResult asyncResult)
        {
            return endOperation<DescribeInstancesResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeInstances(DescribeInstancesRequest describeInstancesRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeInstancesRequestMarshaller().Marshall(describeInstancesRequest);
            var unmarshaller = DescribeInstancesResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para> The DescribeInstances operation returns information about instances that you own. </para> <para> If you specify one or more instance
        /// IDs, Amazon EC2 returns information for those instances. If you do not specify instance IDs, Amazon EC2 returns information for all relevant
        /// instances. If you specify an invalid instance ID, a fault is returned. If you specify an instance that you do not own, it will not be
        /// included in the returned results. </para> <para> Recently terminated instances might appear in the returned results. This interval is
        /// usually less than one hour. </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeInstances service method, as returned by AmazonEC2.</returns>
        /// 
        public DescribeInstancesResponse DescribeInstances()
        {
            return DescribeInstances(new DescribeInstancesRequest());
        }
        

        #endregion
    
        #region DescribeInternetGateways

        /// <summary>
        /// <para> Gives you information about your Internet gateways. You can filter the results to return information only about Internet gateways
        /// that match criteria you specify. For example, you could get information only about gateways with particular tags. The Internet gateway must
        /// match at least one of the specified values for it to be included in the results. </para> <para> You can specify multiple filters (e.g., the
        /// Internet gateway is attached to a particular VPC and is tagged with a particular value). The result includes information for a particular
        /// Internet gateway only if the gateway matches all your filters. If there's no match, no special message is returned; the response is simply
        /// empty. </para> <para> You can use wildcards with the filter values: an asterisk matches zero or more characters, and <c>?</c> matches
        /// exactly one character. You can escape special characters using a backslash before the character. For example, a value of <c>\*amazon\?\\</c>
        /// searches for the literal string <c>*amazon?\</c> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="describeInternetGatewaysRequest">Container for the necessary parameters to execute the DescribeInternetGateways service method
        ///          on AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeInternetGateways service method, as returned by AmazonEC2.</returns>
        /// 
        public DescribeInternetGatewaysResponse DescribeInternetGateways(DescribeInternetGatewaysRequest describeInternetGatewaysRequest)
        {
            IAsyncResult asyncResult = invokeDescribeInternetGateways(describeInternetGatewaysRequest, null, null, true);
            return EndDescribeInternetGateways(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeInternetGateways operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeInternetGateways"/>
        /// </summary>
        /// 
        /// <param name="describeInternetGatewaysRequest">Container for the necessary parameters to execute the DescribeInternetGateways operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeInternetGateways operation.</returns>
        public IAsyncResult BeginDescribeInternetGateways(DescribeInternetGatewaysRequest describeInternetGatewaysRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeInternetGateways(describeInternetGatewaysRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeInternetGateways operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeInternetGateways"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeInternetGateways.</param>
        /// 
        /// <returns>Returns a DescribeInternetGatewaysResult from AmazonEC2.</returns>
        public DescribeInternetGatewaysResponse EndDescribeInternetGateways(IAsyncResult asyncResult)
        {
            return endOperation<DescribeInternetGatewaysResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeInternetGateways(DescribeInternetGatewaysRequest describeInternetGatewaysRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeInternetGatewaysRequestMarshaller().Marshall(describeInternetGatewaysRequest);
            var unmarshaller = DescribeInternetGatewaysResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para> Gives you information about your Internet gateways. You can filter the results to return information only about Internet gateways
        /// that match criteria you specify. For example, you could get information only about gateways with particular tags. The Internet gateway must
        /// match at least one of the specified values for it to be included in the results. </para> <para> You can specify multiple filters (e.g., the
        /// Internet gateway is attached to a particular VPC and is tagged with a particular value). The result includes information for a particular
        /// Internet gateway only if the gateway matches all your filters. If there's no match, no special message is returned; the response is simply
        /// empty. </para> <para> You can use wildcards with the filter values: an asterisk matches zero or more characters, and <c>?</c> matches
        /// exactly one character. You can escape special characters using a backslash before the character. For example, a value of <c>\*amazon\?\\</c>
        /// searches for the literal string <c>*amazon?\</c> .
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeInternetGateways service method, as returned by AmazonEC2.</returns>
        /// 
        public DescribeInternetGatewaysResponse DescribeInternetGateways()
        {
            return DescribeInternetGateways(new DescribeInternetGatewaysRequest());
        }
        

        #endregion
    
        #region DescribeKeyPairs

        /// <summary>
        /// <para> The DescribeKeyPairs operation returns information about key pairs available to you. If you specify key pairs, information about
        /// those key pairs is returned. Otherwise, information for all registered key pairs is returned. </para>
        /// </summary>
        /// 
        /// <param name="describeKeyPairsRequest">Container for the necessary parameters to execute the DescribeKeyPairs service method on
        ///          AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeKeyPairs service method, as returned by AmazonEC2.</returns>
        /// 
        public DescribeKeyPairsResponse DescribeKeyPairs(DescribeKeyPairsRequest describeKeyPairsRequest)
        {
            IAsyncResult asyncResult = invokeDescribeKeyPairs(describeKeyPairsRequest, null, null, true);
            return EndDescribeKeyPairs(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeKeyPairs operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeKeyPairs"/>
        /// </summary>
        /// 
        /// <param name="describeKeyPairsRequest">Container for the necessary parameters to execute the DescribeKeyPairs operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeKeyPairs
        ///         operation.</returns>
        public IAsyncResult BeginDescribeKeyPairs(DescribeKeyPairsRequest describeKeyPairsRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeKeyPairs(describeKeyPairsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeKeyPairs operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeKeyPairs"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeKeyPairs.</param>
        /// 
        /// <returns>Returns a DescribeKeyPairsResult from AmazonEC2.</returns>
        public DescribeKeyPairsResponse EndDescribeKeyPairs(IAsyncResult asyncResult)
        {
            return endOperation<DescribeKeyPairsResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeKeyPairs(DescribeKeyPairsRequest describeKeyPairsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeKeyPairsRequestMarshaller().Marshall(describeKeyPairsRequest);
            var unmarshaller = DescribeKeyPairsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para> The DescribeKeyPairs operation returns information about key pairs available to you. If you specify key pairs, information about
        /// those key pairs is returned. Otherwise, information for all registered key pairs is returned. </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeKeyPairs service method, as returned by AmazonEC2.</returns>
        /// 
        public DescribeKeyPairsResponse DescribeKeyPairs()
        {
            return DescribeKeyPairs(new DescribeKeyPairsRequest());
        }
        

        #endregion
    
        #region DescribeNetworkAcls

        /// <summary>
        /// <para> Gives you information about the network ACLs in your VPC. You can filter the results to return information only about ACLs that match
        /// criteria you specify. For example, you could get information only the ACL associated with a particular subnet. The ACL must match at least
        /// one of the specified values for it to be included in the results. </para> <para> You can specify multiple filters (e.g., the ACL is
        /// associated with a particular subnet and has an egress entry that denies traffic to a particular port). The result includes information for a
        /// particular ACL only if it matches all your filters. If there's no match, no special message is returned; the response is simply empty.
        /// </para> <para> You can use wildcards with the filter values: an asterisk matches zero or more characters, and <c>?</c> matches exactly one
        /// character. You can escape special characters using a backslash before the character. For example, a value of <c>\*amazon\?\\</c> searches
        /// for the literal string <c>*amazon?\</c> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="describeNetworkAclsRequest">Container for the necessary parameters to execute the DescribeNetworkAcls service method on
        ///          AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeNetworkAcls service method, as returned by AmazonEC2.</returns>
        /// 
        public DescribeNetworkAclsResponse DescribeNetworkAcls(DescribeNetworkAclsRequest describeNetworkAclsRequest)
        {
            IAsyncResult asyncResult = invokeDescribeNetworkAcls(describeNetworkAclsRequest, null, null, true);
            return EndDescribeNetworkAcls(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeNetworkAcls operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeNetworkAcls"/>
        /// </summary>
        /// 
        /// <param name="describeNetworkAclsRequest">Container for the necessary parameters to execute the DescribeNetworkAcls operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeNetworkAcls operation.</returns>
        public IAsyncResult BeginDescribeNetworkAcls(DescribeNetworkAclsRequest describeNetworkAclsRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeNetworkAcls(describeNetworkAclsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeNetworkAcls operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeNetworkAcls"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeNetworkAcls.</param>
        /// 
        /// <returns>Returns a DescribeNetworkAclsResult from AmazonEC2.</returns>
        public DescribeNetworkAclsResponse EndDescribeNetworkAcls(IAsyncResult asyncResult)
        {
            return endOperation<DescribeNetworkAclsResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeNetworkAcls(DescribeNetworkAclsRequest describeNetworkAclsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeNetworkAclsRequestMarshaller().Marshall(describeNetworkAclsRequest);
            var unmarshaller = DescribeNetworkAclsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para> Gives you information about the network ACLs in your VPC. You can filter the results to return information only about ACLs that match
        /// criteria you specify. For example, you could get information only the ACL associated with a particular subnet. The ACL must match at least
        /// one of the specified values for it to be included in the results. </para> <para> You can specify multiple filters (e.g., the ACL is
        /// associated with a particular subnet and has an egress entry that denies traffic to a particular port). The result includes information for a
        /// particular ACL only if it matches all your filters. If there's no match, no special message is returned; the response is simply empty.
        /// </para> <para> You can use wildcards with the filter values: an asterisk matches zero or more characters, and <c>?</c> matches exactly one
        /// character. You can escape special characters using a backslash before the character. For example, a value of <c>\*amazon\?\\</c> searches
        /// for the literal string <c>*amazon?\</c> .
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeNetworkAcls service method, as returned by AmazonEC2.</returns>
        /// 
        public DescribeNetworkAclsResponse DescribeNetworkAcls()
        {
            return DescribeNetworkAcls(new DescribeNetworkAclsRequest());
        }
        

        #endregion
    
        #region DescribeNetworkInterfaceAttribute

        /// <summary>
        /// </summary>
        /// 
        /// <param name="describeNetworkInterfaceAttributeRequest">Container for the necessary parameters to execute the
        ///          DescribeNetworkInterfaceAttribute service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeNetworkInterfaceAttribute service method, as returned by AmazonEC2.</returns>
        /// 
        public DescribeNetworkInterfaceAttributeResponse DescribeNetworkInterfaceAttribute(DescribeNetworkInterfaceAttributeRequest describeNetworkInterfaceAttributeRequest)
        {
            IAsyncResult asyncResult = invokeDescribeNetworkInterfaceAttribute(describeNetworkInterfaceAttributeRequest, null, null, true);
            return EndDescribeNetworkInterfaceAttribute(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeNetworkInterfaceAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeNetworkInterfaceAttribute"/>
        /// </summary>
        /// 
        /// <param name="describeNetworkInterfaceAttributeRequest">Container for the necessary parameters to execute the
        ///          DescribeNetworkInterfaceAttribute operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeNetworkInterfaceAttribute operation.</returns>
        public IAsyncResult BeginDescribeNetworkInterfaceAttribute(DescribeNetworkInterfaceAttributeRequest describeNetworkInterfaceAttributeRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeNetworkInterfaceAttribute(describeNetworkInterfaceAttributeRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeNetworkInterfaceAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeNetworkInterfaceAttribute"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeNetworkInterfaceAttribute.</param>
        /// 
        /// <returns>Returns a DescribeNetworkInterfaceAttributeResult from AmazonEC2.</returns>
        public DescribeNetworkInterfaceAttributeResponse EndDescribeNetworkInterfaceAttribute(IAsyncResult asyncResult)
        {
            return endOperation<DescribeNetworkInterfaceAttributeResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeNetworkInterfaceAttribute(DescribeNetworkInterfaceAttributeRequest describeNetworkInterfaceAttributeRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeNetworkInterfaceAttributeRequestMarshaller().Marshall(describeNetworkInterfaceAttributeRequest);
            var unmarshaller = DescribeNetworkInterfaceAttributeResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DescribeNetworkInterfaces

        /// <summary>
        /// </summary>
        /// 
        /// <param name="describeNetworkInterfacesRequest">Container for the necessary parameters to execute the DescribeNetworkInterfaces service
        ///          method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeNetworkInterfaces service method, as returned by AmazonEC2.</returns>
        /// 
        public DescribeNetworkInterfacesResponse DescribeNetworkInterfaces(DescribeNetworkInterfacesRequest describeNetworkInterfacesRequest)
        {
            IAsyncResult asyncResult = invokeDescribeNetworkInterfaces(describeNetworkInterfacesRequest, null, null, true);
            return EndDescribeNetworkInterfaces(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeNetworkInterfaces operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeNetworkInterfaces"/>
        /// </summary>
        /// 
        /// <param name="describeNetworkInterfacesRequest">Container for the necessary parameters to execute the DescribeNetworkInterfaces operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeNetworkInterfaces operation.</returns>
        public IAsyncResult BeginDescribeNetworkInterfaces(DescribeNetworkInterfacesRequest describeNetworkInterfacesRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeNetworkInterfaces(describeNetworkInterfacesRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeNetworkInterfaces operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeNetworkInterfaces"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeNetworkInterfaces.</param>
        /// 
        /// <returns>Returns a DescribeNetworkInterfacesResult from AmazonEC2.</returns>
        public DescribeNetworkInterfacesResponse EndDescribeNetworkInterfaces(IAsyncResult asyncResult)
        {
            return endOperation<DescribeNetworkInterfacesResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeNetworkInterfaces(DescribeNetworkInterfacesRequest describeNetworkInterfacesRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeNetworkInterfacesRequestMarshaller().Marshall(describeNetworkInterfacesRequest);
            var unmarshaller = DescribeNetworkInterfacesResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeNetworkInterfaces service method, as returned by AmazonEC2.</returns>
        /// 
        public DescribeNetworkInterfacesResponse DescribeNetworkInterfaces()
        {
            return DescribeNetworkInterfaces(new DescribeNetworkInterfacesRequest());
        }
        

        #endregion
    
        #region DescribePlacementGroups

        /// <summary>
        /// <para> Returns information about one or more PlacementGroup instances in a user's account. </para>
        /// </summary>
        /// 
        /// <param name="describePlacementGroupsRequest">Container for the necessary parameters to execute the DescribePlacementGroups service method on
        ///          AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribePlacementGroups service method, as returned by AmazonEC2.</returns>
        /// 
        public DescribePlacementGroupsResponse DescribePlacementGroups(DescribePlacementGroupsRequest describePlacementGroupsRequest)
        {
            IAsyncResult asyncResult = invokeDescribePlacementGroups(describePlacementGroupsRequest, null, null, true);
            return EndDescribePlacementGroups(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribePlacementGroups operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribePlacementGroups"/>
        /// </summary>
        /// 
        /// <param name="describePlacementGroupsRequest">Container for the necessary parameters to execute the DescribePlacementGroups operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribePlacementGroups operation.</returns>
        public IAsyncResult BeginDescribePlacementGroups(DescribePlacementGroupsRequest describePlacementGroupsRequest, AsyncCallback callback, object state)
        {
            return invokeDescribePlacementGroups(describePlacementGroupsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribePlacementGroups operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribePlacementGroups"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribePlacementGroups.</param>
        /// 
        /// <returns>Returns a DescribePlacementGroupsResult from AmazonEC2.</returns>
        public DescribePlacementGroupsResponse EndDescribePlacementGroups(IAsyncResult asyncResult)
        {
            return endOperation<DescribePlacementGroupsResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribePlacementGroups(DescribePlacementGroupsRequest describePlacementGroupsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribePlacementGroupsRequestMarshaller().Marshall(describePlacementGroupsRequest);
            var unmarshaller = DescribePlacementGroupsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para> Returns information about one or more PlacementGroup instances in a user's account. </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribePlacementGroups service method, as returned by AmazonEC2.</returns>
        /// 
        public DescribePlacementGroupsResponse DescribePlacementGroups()
        {
            return DescribePlacementGroups(new DescribePlacementGroupsRequest());
        }
        

        #endregion
    
        #region DescribeRegions

        /// <summary>
        /// <para> The DescribeRegions operation describes regions zones that are currently available to the account. </para>
        /// </summary>
        /// 
        /// <param name="describeRegionsRequest">Container for the necessary parameters to execute the DescribeRegions service method on
        ///          AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeRegions service method, as returned by AmazonEC2.</returns>
        /// 
        public DescribeRegionsResponse DescribeRegions(DescribeRegionsRequest describeRegionsRequest)
        {
            IAsyncResult asyncResult = invokeDescribeRegions(describeRegionsRequest, null, null, true);
            return EndDescribeRegions(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRegions operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeRegions"/>
        /// </summary>
        /// 
        /// <param name="describeRegionsRequest">Container for the necessary parameters to execute the DescribeRegions operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeRegions
        ///         operation.</returns>
        public IAsyncResult BeginDescribeRegions(DescribeRegionsRequest describeRegionsRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeRegions(describeRegionsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeRegions operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeRegions"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeRegions.</param>
        /// 
        /// <returns>Returns a DescribeRegionsResult from AmazonEC2.</returns>
        public DescribeRegionsResponse EndDescribeRegions(IAsyncResult asyncResult)
        {
            return endOperation<DescribeRegionsResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeRegions(DescribeRegionsRequest describeRegionsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeRegionsRequestMarshaller().Marshall(describeRegionsRequest);
            var unmarshaller = DescribeRegionsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para> The DescribeRegions operation describes regions zones that are currently available to the account. </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeRegions service method, as returned by AmazonEC2.</returns>
        /// 
        public DescribeRegionsResponse DescribeRegions()
        {
            return DescribeRegions(new DescribeRegionsRequest());
        }
        

        #endregion
    
        #region DescribeReservedInstances

        /// <summary>
        /// <para> The DescribeReservedInstances operation describes Reserved Instances that were purchased for use with your account. </para>
        /// </summary>
        /// 
        /// <param name="describeReservedInstancesRequest">Container for the necessary parameters to execute the DescribeReservedInstances service
        ///          method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeReservedInstances service method, as returned by AmazonEC2.</returns>
        /// 
        public DescribeReservedInstancesResponse DescribeReservedInstances(DescribeReservedInstancesRequest describeReservedInstancesRequest)
        {
            IAsyncResult asyncResult = invokeDescribeReservedInstances(describeReservedInstancesRequest, null, null, true);
            return EndDescribeReservedInstances(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReservedInstances operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeReservedInstances"/>
        /// </summary>
        /// 
        /// <param name="describeReservedInstancesRequest">Container for the necessary parameters to execute the DescribeReservedInstances operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeReservedInstances operation.</returns>
        public IAsyncResult BeginDescribeReservedInstances(DescribeReservedInstancesRequest describeReservedInstancesRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeReservedInstances(describeReservedInstancesRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeReservedInstances operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeReservedInstances"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeReservedInstances.</param>
        /// 
        /// <returns>Returns a DescribeReservedInstancesResult from AmazonEC2.</returns>
        public DescribeReservedInstancesResponse EndDescribeReservedInstances(IAsyncResult asyncResult)
        {
            return endOperation<DescribeReservedInstancesResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeReservedInstances(DescribeReservedInstancesRequest describeReservedInstancesRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeReservedInstancesRequestMarshaller().Marshall(describeReservedInstancesRequest);
            var unmarshaller = DescribeReservedInstancesResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para> The DescribeReservedInstances operation describes Reserved Instances that were purchased for use with your account. </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeReservedInstances service method, as returned by AmazonEC2.</returns>
        /// 
        public DescribeReservedInstancesResponse DescribeReservedInstances()
        {
            return DescribeReservedInstances(new DescribeReservedInstancesRequest());
        }
        

        #endregion
    
        #region DescribeReservedInstancesListings

        /// <summary>
        /// </summary>
        /// 
        /// <param name="describeReservedInstancesListingsRequest">Container for the necessary parameters to execute the
        ///          DescribeReservedInstancesListings service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeReservedInstancesListings service method, as returned by AmazonEC2.</returns>
        /// 
        public DescribeReservedInstancesListingsResponse DescribeReservedInstancesListings(DescribeReservedInstancesListingsRequest describeReservedInstancesListingsRequest)
        {
            IAsyncResult asyncResult = invokeDescribeReservedInstancesListings(describeReservedInstancesListingsRequest, null, null, true);
            return EndDescribeReservedInstancesListings(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReservedInstancesListings operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeReservedInstancesListings"/>
        /// </summary>
        /// 
        /// <param name="describeReservedInstancesListingsRequest">Container for the necessary parameters to execute the
        ///          DescribeReservedInstancesListings operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeReservedInstancesListings operation.</returns>
        public IAsyncResult BeginDescribeReservedInstancesListings(DescribeReservedInstancesListingsRequest describeReservedInstancesListingsRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeReservedInstancesListings(describeReservedInstancesListingsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeReservedInstancesListings operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeReservedInstancesListings"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeReservedInstancesListings.</param>
        /// 
        /// <returns>Returns a DescribeReservedInstancesListingsResult from AmazonEC2.</returns>
        public DescribeReservedInstancesListingsResponse EndDescribeReservedInstancesListings(IAsyncResult asyncResult)
        {
            return endOperation<DescribeReservedInstancesListingsResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeReservedInstancesListings(DescribeReservedInstancesListingsRequest describeReservedInstancesListingsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeReservedInstancesListingsRequestMarshaller().Marshall(describeReservedInstancesListingsRequest);
            var unmarshaller = DescribeReservedInstancesListingsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeReservedInstancesListings service method, as returned by AmazonEC2.</returns>
        /// 
        public DescribeReservedInstancesListingsResponse DescribeReservedInstancesListings()
        {
            return DescribeReservedInstancesListings(new DescribeReservedInstancesListingsRequest());
        }
        

        #endregion
    
        #region DescribeReservedInstancesModifications

        /// <summary>
        /// <para> The DescribeReservedInstancesModifications operation describes modifications made to Reserved Instances in your account. </para>
        /// </summary>
        /// 
        /// <param name="describeReservedInstancesModificationsRequest">Container for the necessary parameters to execute the
        ///          DescribeReservedInstancesModifications service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeReservedInstancesModifications service method, as returned by AmazonEC2.</returns>
        /// 
        public DescribeReservedInstancesModificationsResponse DescribeReservedInstancesModifications(DescribeReservedInstancesModificationsRequest describeReservedInstancesModificationsRequest)
        {
            IAsyncResult asyncResult = invokeDescribeReservedInstancesModifications(describeReservedInstancesModificationsRequest, null, null, true);
            return EndDescribeReservedInstancesModifications(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReservedInstancesModifications operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeReservedInstancesModifications"/>
        /// </summary>
        /// 
        /// <param name="describeReservedInstancesModificationsRequest">Container for the necessary parameters to execute the
        ///          DescribeReservedInstancesModifications operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeReservedInstancesModifications operation.</returns>
        public IAsyncResult BeginDescribeReservedInstancesModifications(DescribeReservedInstancesModificationsRequest describeReservedInstancesModificationsRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeReservedInstancesModifications(describeReservedInstancesModificationsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeReservedInstancesModifications operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeReservedInstancesModifications"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeReservedInstancesModifications.</param>
        /// 
        /// <returns>Returns a DescribeReservedInstancesModificationsResult from AmazonEC2.</returns>
        public DescribeReservedInstancesModificationsResponse EndDescribeReservedInstancesModifications(IAsyncResult asyncResult)
        {
            return endOperation<DescribeReservedInstancesModificationsResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeReservedInstancesModifications(DescribeReservedInstancesModificationsRequest describeReservedInstancesModificationsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeReservedInstancesModificationsRequestMarshaller().Marshall(describeReservedInstancesModificationsRequest);
            var unmarshaller = DescribeReservedInstancesModificationsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para> The DescribeReservedInstancesModifications operation describes modifications made to Reserved Instances in your account. </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeReservedInstancesModifications service method, as returned by AmazonEC2.</returns>
        /// 
        public DescribeReservedInstancesModificationsResponse DescribeReservedInstancesModifications()
        {
            return DescribeReservedInstancesModifications(new DescribeReservedInstancesModificationsRequest());
        }
        

        #endregion
    
        #region DescribeReservedInstancesOfferings

        /// <summary>
        /// <para> The DescribeReservedInstancesOfferings operation describes Reserved Instance offerings that are available for purchase. With Amazon
        /// EC2 Reserved Instances, you purchase the right to launch Amazon EC2 instances for a period of time (without getting insufficient capacity
        /// errors) and pay a lower usage rate for the actual time used. </para>
        /// </summary>
        /// 
        /// <param name="describeReservedInstancesOfferingsRequest">Container for the necessary parameters to execute the
        ///          DescribeReservedInstancesOfferings service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeReservedInstancesOfferings service method, as returned by AmazonEC2.</returns>
        /// 
        public DescribeReservedInstancesOfferingsResponse DescribeReservedInstancesOfferings(DescribeReservedInstancesOfferingsRequest describeReservedInstancesOfferingsRequest)
        {
            IAsyncResult asyncResult = invokeDescribeReservedInstancesOfferings(describeReservedInstancesOfferingsRequest, null, null, true);
            return EndDescribeReservedInstancesOfferings(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeReservedInstancesOfferings operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeReservedInstancesOfferings"/>
        /// </summary>
        /// 
        /// <param name="describeReservedInstancesOfferingsRequest">Container for the necessary parameters to execute the
        ///          DescribeReservedInstancesOfferings operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeReservedInstancesOfferings operation.</returns>
        public IAsyncResult BeginDescribeReservedInstancesOfferings(DescribeReservedInstancesOfferingsRequest describeReservedInstancesOfferingsRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeReservedInstancesOfferings(describeReservedInstancesOfferingsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeReservedInstancesOfferings operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeReservedInstancesOfferings"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeReservedInstancesOfferings.</param>
        /// 
        /// <returns>Returns a DescribeReservedInstancesOfferingsResult from AmazonEC2.</returns>
        public DescribeReservedInstancesOfferingsResponse EndDescribeReservedInstancesOfferings(IAsyncResult asyncResult)
        {
            return endOperation<DescribeReservedInstancesOfferingsResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeReservedInstancesOfferings(DescribeReservedInstancesOfferingsRequest describeReservedInstancesOfferingsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeReservedInstancesOfferingsRequestMarshaller().Marshall(describeReservedInstancesOfferingsRequest);
            var unmarshaller = DescribeReservedInstancesOfferingsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para> The DescribeReservedInstancesOfferings operation describes Reserved Instance offerings that are available for purchase. With Amazon
        /// EC2 Reserved Instances, you purchase the right to launch Amazon EC2 instances for a period of time (without getting insufficient capacity
        /// errors) and pay a lower usage rate for the actual time used. </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeReservedInstancesOfferings service method, as returned by AmazonEC2.</returns>
        /// 
        public DescribeReservedInstancesOfferingsResponse DescribeReservedInstancesOfferings()
        {
            return DescribeReservedInstancesOfferings(new DescribeReservedInstancesOfferingsRequest());
        }
        

        #endregion
    
        #region DescribeRouteTables

        /// <summary>
        /// <para> Gives you information about your route tables. You can filter the results to return information only about tables that match criteria
        /// you specify. For example, you could get information only about a table associated with a particular subnet. You can specify multiple values
        /// for the filter. The table must match at least one of the specified values for it to be included in the results. </para> <para> You can
        /// specify multiple filters (e.g., the table has a particular route, and is associated with a particular subnet). The result includes
        /// information for a particular table only if it matches all your filters. If there's no match, no special message is returned; the response is
        /// simply empty. </para> <para> You can use wildcards with the filter values: an asterisk matches zero or more characters, and <c>?</c> matches
        /// exactly one character. You can escape special characters using a backslash before the character. For example, a value of <c>\*amazon\?\\</c>
        /// searches for the literal string <c>*amazon?\</c> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="describeRouteTablesRequest">Container for the necessary parameters to execute the DescribeRouteTables service method on
        ///          AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeRouteTables service method, as returned by AmazonEC2.</returns>
        /// 
        public DescribeRouteTablesResponse DescribeRouteTables(DescribeRouteTablesRequest describeRouteTablesRequest)
        {
            IAsyncResult asyncResult = invokeDescribeRouteTables(describeRouteTablesRequest, null, null, true);
            return EndDescribeRouteTables(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeRouteTables operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeRouteTables"/>
        /// </summary>
        /// 
        /// <param name="describeRouteTablesRequest">Container for the necessary parameters to execute the DescribeRouteTables operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeRouteTables operation.</returns>
        public IAsyncResult BeginDescribeRouteTables(DescribeRouteTablesRequest describeRouteTablesRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeRouteTables(describeRouteTablesRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeRouteTables operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeRouteTables"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeRouteTables.</param>
        /// 
        /// <returns>Returns a DescribeRouteTablesResult from AmazonEC2.</returns>
        public DescribeRouteTablesResponse EndDescribeRouteTables(IAsyncResult asyncResult)
        {
            return endOperation<DescribeRouteTablesResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeRouteTables(DescribeRouteTablesRequest describeRouteTablesRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeRouteTablesRequestMarshaller().Marshall(describeRouteTablesRequest);
            var unmarshaller = DescribeRouteTablesResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para> Gives you information about your route tables. You can filter the results to return information only about tables that match criteria
        /// you specify. For example, you could get information only about a table associated with a particular subnet. You can specify multiple values
        /// for the filter. The table must match at least one of the specified values for it to be included in the results. </para> <para> You can
        /// specify multiple filters (e.g., the table has a particular route, and is associated with a particular subnet). The result includes
        /// information for a particular table only if it matches all your filters. If there's no match, no special message is returned; the response is
        /// simply empty. </para> <para> You can use wildcards with the filter values: an asterisk matches zero or more characters, and <c>?</c> matches
        /// exactly one character. You can escape special characters using a backslash before the character. For example, a value of <c>\*amazon\?\\</c>
        /// searches for the literal string <c>*amazon?\</c> .
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeRouteTables service method, as returned by AmazonEC2.</returns>
        /// 
        public DescribeRouteTablesResponse DescribeRouteTables()
        {
            return DescribeRouteTables(new DescribeRouteTablesRequest());
        }
        

        #endregion
    
        #region DescribeSecurityGroups

        /// <summary>
        /// <para> The DescribeSecurityGroups operation returns information about security groups that you own. </para> <para> If you specify security
        /// group names, information about those security group is returned. Otherwise, information for all security group is returned. If you specify a
        /// group that does not exist, a fault is returned. </para>
        /// </summary>
        /// 
        /// <param name="describeSecurityGroupsRequest">Container for the necessary parameters to execute the DescribeSecurityGroups service method on
        ///          AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeSecurityGroups service method, as returned by AmazonEC2.</returns>
        /// 
        public DescribeSecurityGroupsResponse DescribeSecurityGroups(DescribeSecurityGroupsRequest describeSecurityGroupsRequest)
        {
            IAsyncResult asyncResult = invokeDescribeSecurityGroups(describeSecurityGroupsRequest, null, null, true);
            return EndDescribeSecurityGroups(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSecurityGroups operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeSecurityGroups"/>
        /// </summary>
        /// 
        /// <param name="describeSecurityGroupsRequest">Container for the necessary parameters to execute the DescribeSecurityGroups operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeSecurityGroups operation.</returns>
        public IAsyncResult BeginDescribeSecurityGroups(DescribeSecurityGroupsRequest describeSecurityGroupsRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeSecurityGroups(describeSecurityGroupsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeSecurityGroups operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeSecurityGroups"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSecurityGroups.</param>
        /// 
        /// <returns>Returns a DescribeSecurityGroupsResult from AmazonEC2.</returns>
        public DescribeSecurityGroupsResponse EndDescribeSecurityGroups(IAsyncResult asyncResult)
        {
            return endOperation<DescribeSecurityGroupsResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeSecurityGroups(DescribeSecurityGroupsRequest describeSecurityGroupsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeSecurityGroupsRequestMarshaller().Marshall(describeSecurityGroupsRequest);
            var unmarshaller = DescribeSecurityGroupsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para> The DescribeSecurityGroups operation returns information about security groups that you own. </para> <para> If you specify security
        /// group names, information about those security group is returned. Otherwise, information for all security group is returned. If you specify a
        /// group that does not exist, a fault is returned. </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeSecurityGroups service method, as returned by AmazonEC2.</returns>
        /// 
        public DescribeSecurityGroupsResponse DescribeSecurityGroups()
        {
            return DescribeSecurityGroups(new DescribeSecurityGroupsRequest());
        }
        

        #endregion
    
        #region DescribeSnapshotAttribute

        /// <summary>
        /// <para> Returns information about an attribute of a snapshot. Only one attribute can be specified per call. </para>
        /// </summary>
        /// 
        /// <param name="describeSnapshotAttributeRequest">Container for the necessary parameters to execute the DescribeSnapshotAttribute service
        ///          method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeSnapshotAttribute service method, as returned by AmazonEC2.</returns>
        /// 
        public DescribeSnapshotAttributeResponse DescribeSnapshotAttribute(DescribeSnapshotAttributeRequest describeSnapshotAttributeRequest)
        {
            IAsyncResult asyncResult = invokeDescribeSnapshotAttribute(describeSnapshotAttributeRequest, null, null, true);
            return EndDescribeSnapshotAttribute(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSnapshotAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeSnapshotAttribute"/>
        /// </summary>
        /// 
        /// <param name="describeSnapshotAttributeRequest">Container for the necessary parameters to execute the DescribeSnapshotAttribute operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeSnapshotAttribute operation.</returns>
        public IAsyncResult BeginDescribeSnapshotAttribute(DescribeSnapshotAttributeRequest describeSnapshotAttributeRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeSnapshotAttribute(describeSnapshotAttributeRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeSnapshotAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeSnapshotAttribute"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSnapshotAttribute.</param>
        /// 
        /// <returns>Returns a DescribeSnapshotAttributeResult from AmazonEC2.</returns>
        public DescribeSnapshotAttributeResponse EndDescribeSnapshotAttribute(IAsyncResult asyncResult)
        {
            return endOperation<DescribeSnapshotAttributeResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeSnapshotAttribute(DescribeSnapshotAttributeRequest describeSnapshotAttributeRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeSnapshotAttributeRequestMarshaller().Marshall(describeSnapshotAttributeRequest);
            var unmarshaller = DescribeSnapshotAttributeResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DescribeSnapshots

        /// <summary>
        /// <para> Returns information about the Amazon EBS snapshots available to you. Snapshots available to you include public snapshots available
        /// for any AWS account to launch, private snapshots you own, and private snapshots owned by another AWS account but for which you've been given
        /// explicit create volume permissions. </para>
        /// </summary>
        /// 
        /// <param name="describeSnapshotsRequest">Container for the necessary parameters to execute the DescribeSnapshots service method on
        ///          AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeSnapshots service method, as returned by AmazonEC2.</returns>
        /// 
        public DescribeSnapshotsResponse DescribeSnapshots(DescribeSnapshotsRequest describeSnapshotsRequest)
        {
            IAsyncResult asyncResult = invokeDescribeSnapshots(describeSnapshotsRequest, null, null, true);
            return EndDescribeSnapshots(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSnapshots operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeSnapshots"/>
        /// </summary>
        /// 
        /// <param name="describeSnapshotsRequest">Container for the necessary parameters to execute the DescribeSnapshots operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSnapshots
        ///         operation.</returns>
        public IAsyncResult BeginDescribeSnapshots(DescribeSnapshotsRequest describeSnapshotsRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeSnapshots(describeSnapshotsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeSnapshots operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeSnapshots"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSnapshots.</param>
        /// 
        /// <returns>Returns a DescribeSnapshotsResult from AmazonEC2.</returns>
        public DescribeSnapshotsResponse EndDescribeSnapshots(IAsyncResult asyncResult)
        {
            return endOperation<DescribeSnapshotsResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeSnapshots(DescribeSnapshotsRequest describeSnapshotsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeSnapshotsRequestMarshaller().Marshall(describeSnapshotsRequest);
            var unmarshaller = DescribeSnapshotsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para> Returns information about the Amazon EBS snapshots available to you. Snapshots available to you include public snapshots available
        /// for any AWS account to launch, private snapshots you own, and private snapshots owned by another AWS account but for which you've been given
        /// explicit create volume permissions. </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeSnapshots service method, as returned by AmazonEC2.</returns>
        /// 
        public DescribeSnapshotsResponse DescribeSnapshots()
        {
            return DescribeSnapshots(new DescribeSnapshotsRequest());
        }
        

        #endregion
    
        #region DescribeSpotDatafeedSubscription

        /// <summary>
        /// <para> Describes the data feed for Spot Instances. </para> <para> For conceptual information about Spot Instances, refer to the Amazon
        /// Elastic Compute Cloud Developer Guide or Amazon Elastic Compute Cloud User Guide .
        /// </para>
        /// </summary>
        /// 
        /// <param name="describeSpotDatafeedSubscriptionRequest">Container for the necessary parameters to execute the DescribeSpotDatafeedSubscription
        ///          service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeSpotDatafeedSubscription service method, as returned by AmazonEC2.</returns>
        /// 
        public DescribeSpotDatafeedSubscriptionResponse DescribeSpotDatafeedSubscription(DescribeSpotDatafeedSubscriptionRequest describeSpotDatafeedSubscriptionRequest)
        {
            IAsyncResult asyncResult = invokeDescribeSpotDatafeedSubscription(describeSpotDatafeedSubscriptionRequest, null, null, true);
            return EndDescribeSpotDatafeedSubscription(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSpotDatafeedSubscription operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeSpotDatafeedSubscription"/>
        /// </summary>
        /// 
        /// <param name="describeSpotDatafeedSubscriptionRequest">Container for the necessary parameters to execute the DescribeSpotDatafeedSubscription
        ///          operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeSpotDatafeedSubscription operation.</returns>
        public IAsyncResult BeginDescribeSpotDatafeedSubscription(DescribeSpotDatafeedSubscriptionRequest describeSpotDatafeedSubscriptionRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeSpotDatafeedSubscription(describeSpotDatafeedSubscriptionRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeSpotDatafeedSubscription operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeSpotDatafeedSubscription"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSpotDatafeedSubscription.</param>
        /// 
        /// <returns>Returns a DescribeSpotDatafeedSubscriptionResult from AmazonEC2.</returns>
        public DescribeSpotDatafeedSubscriptionResponse EndDescribeSpotDatafeedSubscription(IAsyncResult asyncResult)
        {
            return endOperation<DescribeSpotDatafeedSubscriptionResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeSpotDatafeedSubscription(DescribeSpotDatafeedSubscriptionRequest describeSpotDatafeedSubscriptionRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeSpotDatafeedSubscriptionRequestMarshaller().Marshall(describeSpotDatafeedSubscriptionRequest);
            var unmarshaller = DescribeSpotDatafeedSubscriptionResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para> Describes the data feed for Spot Instances. </para> <para> For conceptual information about Spot Instances, refer to the Amazon
        /// Elastic Compute Cloud Developer Guide or Amazon Elastic Compute Cloud User Guide .
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeSpotDatafeedSubscription service method, as returned by AmazonEC2.</returns>
        /// 
        public DescribeSpotDatafeedSubscriptionResponse DescribeSpotDatafeedSubscription()
        {
            return DescribeSpotDatafeedSubscription(new DescribeSpotDatafeedSubscriptionRequest());
        }
        

        #endregion
    
        #region DescribeSpotInstanceRequests

        /// <summary>
        /// <para> Describes Spot Instance requests. Spot Instances are instances that Amazon EC2 starts on your behalf when the maximum price that you
        /// specify exceeds the current Spot Price. Amazon EC2 periodically sets the Spot Price based on available Spot Instance capacity and current
        /// spot instance requests. For conceptual information about Spot Instances, refer to the <a
        /// href="http://docs.amazonwebservices.com/AWSEC2/2010-08-31/DeveloperGuide/" > Amazon Elastic Compute Cloud Developer Guide</a> or <a
        /// href="http://docs.amazonwebservices.com/AWSEC2/2010-08-31/UserGuide/" > Amazon Elastic Compute Cloud User Guide</a> .
        /// </para> <para> You can filter the results to return information only about Spot Instance requests that match criteria you specify. For
        /// example, you could get information about requests where the Spot Price you specified is a certain value (you can't use greater than or less
        /// than comparison, but you can use <c>*</c> and <c>?</c> wildcards). You can specify multiple values for a filter. A Spot Instance request
        /// must match at least one of the specified values for it to be included in the results. </para> <para> You can specify multiple filters (e.g.,
        /// the Spot Price is equal to a particular value, and the instance type is <c>m1.small</c> ). The result includes information for a particular
        /// request only if it matches all your filters. If there's no match, no special message is returned; the response is simply empty. </para>
        /// <para> You can use wildcards with the filter values: an asterisk matches zero or more characters, and <c>?</c> matches exactly one
        /// character. You can escape special characters using a backslash before the character. For example, a value of <c>\*amazon\?\\</c> searches
        /// for the literal string <c>*amazon?\</c> .
        /// </para>
        /// </summary>
        /// 
        /// <param name="describeSpotInstanceRequestsRequest">Container for the necessary parameters to execute the DescribeSpotInstanceRequests service
        ///          method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeSpotInstanceRequests service method, as returned by AmazonEC2.</returns>
        /// 
        public DescribeSpotInstanceRequestsResponse DescribeSpotInstanceRequests(DescribeSpotInstanceRequestsRequest describeSpotInstanceRequestsRequest)
        {
            IAsyncResult asyncResult = invokeDescribeSpotInstanceRequests(describeSpotInstanceRequestsRequest, null, null, true);
            return EndDescribeSpotInstanceRequests(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSpotInstanceRequests operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeSpotInstanceRequests"/>
        /// </summary>
        /// 
        /// <param name="describeSpotInstanceRequestsRequest">Container for the necessary parameters to execute the DescribeSpotInstanceRequests
        ///          operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeSpotInstanceRequests operation.</returns>
        public IAsyncResult BeginDescribeSpotInstanceRequests(DescribeSpotInstanceRequestsRequest describeSpotInstanceRequestsRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeSpotInstanceRequests(describeSpotInstanceRequestsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeSpotInstanceRequests operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeSpotInstanceRequests"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSpotInstanceRequests.</param>
        /// 
        /// <returns>Returns a DescribeSpotInstanceRequestsResult from AmazonEC2.</returns>
        public DescribeSpotInstanceRequestsResponse EndDescribeSpotInstanceRequests(IAsyncResult asyncResult)
        {
            return endOperation<DescribeSpotInstanceRequestsResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeSpotInstanceRequests(DescribeSpotInstanceRequestsRequest describeSpotInstanceRequestsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeSpotInstanceRequestsRequestMarshaller().Marshall(describeSpotInstanceRequestsRequest);
            var unmarshaller = DescribeSpotInstanceRequestsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para> Describes Spot Instance requests. Spot Instances are instances that Amazon EC2 starts on your behalf when the maximum price that you
        /// specify exceeds the current Spot Price. Amazon EC2 periodically sets the Spot Price based on available Spot Instance capacity and current
        /// spot instance requests. For conceptual information about Spot Instances, refer to the <a
        /// href="http://docs.amazonwebservices.com/AWSEC2/2010-08-31/DeveloperGuide/" > Amazon Elastic Compute Cloud Developer Guide</a> or <a
        /// href="http://docs.amazonwebservices.com/AWSEC2/2010-08-31/UserGuide/" > Amazon Elastic Compute Cloud User Guide</a> .
        /// </para> <para> You can filter the results to return information only about Spot Instance requests that match criteria you specify. For
        /// example, you could get information about requests where the Spot Price you specified is a certain value (you can't use greater than or less
        /// than comparison, but you can use <c>*</c> and <c>?</c> wildcards). You can specify multiple values for a filter. A Spot Instance request
        /// must match at least one of the specified values for it to be included in the results. </para> <para> You can specify multiple filters (e.g.,
        /// the Spot Price is equal to a particular value, and the instance type is <c>m1.small</c> ). The result includes information for a particular
        /// request only if it matches all your filters. If there's no match, no special message is returned; the response is simply empty. </para>
        /// <para> You can use wildcards with the filter values: an asterisk matches zero or more characters, and <c>?</c> matches exactly one
        /// character. You can escape special characters using a backslash before the character. For example, a value of <c>\*amazon\?\\</c> searches
        /// for the literal string <c>*amazon?\</c> .
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeSpotInstanceRequests service method, as returned by AmazonEC2.</returns>
        /// 
        public DescribeSpotInstanceRequestsResponse DescribeSpotInstanceRequests()
        {
            return DescribeSpotInstanceRequests(new DescribeSpotInstanceRequestsRequest());
        }
        

        #endregion
    
        #region DescribeSpotPriceHistory

        /// <summary>
        /// <para> Describes the Spot Price history. </para> <para> Spot Instances are instances that Amazon EC2 starts on your behalf when the maximum
        /// price that you specify exceeds the current Spot Price. Amazon EC2 periodically sets the Spot Price based on available Spot Instance capacity
        /// and current spot instance requests. </para> <para> For conceptual information about Spot Instances, refer to the Amazon Elastic Compute
        /// Cloud Developer Guide or Amazon Elastic Compute Cloud User Guide .
        /// </para>
        /// </summary>
        /// 
        /// <param name="describeSpotPriceHistoryRequest">Container for the necessary parameters to execute the DescribeSpotPriceHistory service method
        ///          on AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeSpotPriceHistory service method, as returned by AmazonEC2.</returns>
        /// 
        public DescribeSpotPriceHistoryResponse DescribeSpotPriceHistory(DescribeSpotPriceHistoryRequest describeSpotPriceHistoryRequest)
        {
            IAsyncResult asyncResult = invokeDescribeSpotPriceHistory(describeSpotPriceHistoryRequest, null, null, true);
            return EndDescribeSpotPriceHistory(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSpotPriceHistory operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeSpotPriceHistory"/>
        /// </summary>
        /// 
        /// <param name="describeSpotPriceHistoryRequest">Container for the necessary parameters to execute the DescribeSpotPriceHistory operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeSpotPriceHistory operation.</returns>
        public IAsyncResult BeginDescribeSpotPriceHistory(DescribeSpotPriceHistoryRequest describeSpotPriceHistoryRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeSpotPriceHistory(describeSpotPriceHistoryRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeSpotPriceHistory operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeSpotPriceHistory"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSpotPriceHistory.</param>
        /// 
        /// <returns>Returns a DescribeSpotPriceHistoryResult from AmazonEC2.</returns>
        public DescribeSpotPriceHistoryResponse EndDescribeSpotPriceHistory(IAsyncResult asyncResult)
        {
            return endOperation<DescribeSpotPriceHistoryResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeSpotPriceHistory(DescribeSpotPriceHistoryRequest describeSpotPriceHistoryRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeSpotPriceHistoryRequestMarshaller().Marshall(describeSpotPriceHistoryRequest);
            var unmarshaller = DescribeSpotPriceHistoryResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para> Describes the Spot Price history. </para> <para> Spot Instances are instances that Amazon EC2 starts on your behalf when the maximum
        /// price that you specify exceeds the current Spot Price. Amazon EC2 periodically sets the Spot Price based on available Spot Instance capacity
        /// and current spot instance requests. </para> <para> For conceptual information about Spot Instances, refer to the Amazon Elastic Compute
        /// Cloud Developer Guide or Amazon Elastic Compute Cloud User Guide .
        /// </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeSpotPriceHistory service method, as returned by AmazonEC2.</returns>
        /// 
        public DescribeSpotPriceHistoryResponse DescribeSpotPriceHistory()
        {
            return DescribeSpotPriceHistory(new DescribeSpotPriceHistoryRequest());
        }
        

        #endregion
    
        #region DescribeSubnets

        /// <summary>
        /// <para> Gives you information about your subnets. You can filter the results to return information only about subnets that match criteria you
        /// specify. </para> <para> For example, you could ask to get information about a particular subnet (or all) only if the subnet's state is
        /// available. You can specify multiple filters (e.g., the subnet is in a particular VPC, and the subnet's state is available). </para> <para>
        /// The result includes information for a particular subnet only if the subnet matches all your filters. If there's no match, no special message
        /// is returned; the response is simply empty. The following table shows the available filters. </para>
        /// </summary>
        /// 
        /// <param name="describeSubnetsRequest">Container for the necessary parameters to execute the DescribeSubnets service method on
        ///          AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeSubnets service method, as returned by AmazonEC2.</returns>
        /// 
        public DescribeSubnetsResponse DescribeSubnets(DescribeSubnetsRequest describeSubnetsRequest)
        {
            IAsyncResult asyncResult = invokeDescribeSubnets(describeSubnetsRequest, null, null, true);
            return EndDescribeSubnets(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeSubnets operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeSubnets"/>
        /// </summary>
        /// 
        /// <param name="describeSubnetsRequest">Container for the necessary parameters to execute the DescribeSubnets operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeSubnets
        ///         operation.</returns>
        public IAsyncResult BeginDescribeSubnets(DescribeSubnetsRequest describeSubnetsRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeSubnets(describeSubnetsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeSubnets operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeSubnets"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeSubnets.</param>
        /// 
        /// <returns>Returns a DescribeSubnetsResult from AmazonEC2.</returns>
        public DescribeSubnetsResponse EndDescribeSubnets(IAsyncResult asyncResult)
        {
            return endOperation<DescribeSubnetsResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeSubnets(DescribeSubnetsRequest describeSubnetsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeSubnetsRequestMarshaller().Marshall(describeSubnetsRequest);
            var unmarshaller = DescribeSubnetsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para> Gives you information about your subnets. You can filter the results to return information only about subnets that match criteria you
        /// specify. </para> <para> For example, you could ask to get information about a particular subnet (or all) only if the subnet's state is
        /// available. You can specify multiple filters (e.g., the subnet is in a particular VPC, and the subnet's state is available). </para> <para>
        /// The result includes information for a particular subnet only if the subnet matches all your filters. If there's no match, no special message
        /// is returned; the response is simply empty. The following table shows the available filters. </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeSubnets service method, as returned by AmazonEC2.</returns>
        /// 
        public DescribeSubnetsResponse DescribeSubnets()
        {
            return DescribeSubnets(new DescribeSubnetsRequest());
        }
        

        #endregion
    
        #region DescribeTags

        /// <summary>
        /// <para> Describes the tags for the specified resources. </para>
        /// </summary>
        /// 
        /// <param name="describeTagsRequest">Container for the necessary parameters to execute the DescribeTags service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeTags service method, as returned by AmazonEC2.</returns>
        /// 
        public DescribeTagsResponse DescribeTags(DescribeTagsRequest describeTagsRequest)
        {
            IAsyncResult asyncResult = invokeDescribeTags(describeTagsRequest, null, null, true);
            return EndDescribeTags(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeTags operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeTags"/>
        /// </summary>
        /// 
        /// <param name="describeTagsRequest">Container for the necessary parameters to execute the DescribeTags operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeTags
        ///         operation.</returns>
        public IAsyncResult BeginDescribeTags(DescribeTagsRequest describeTagsRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeTags(describeTagsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeTags operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeTags"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeTags.</param>
        /// 
        /// <returns>Returns a DescribeTagsResult from AmazonEC2.</returns>
        public DescribeTagsResponse EndDescribeTags(IAsyncResult asyncResult)
        {
            return endOperation<DescribeTagsResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeTags(DescribeTagsRequest describeTagsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeTagsRequestMarshaller().Marshall(describeTagsRequest);
            var unmarshaller = DescribeTagsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para> Describes the tags for the specified resources. </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeTags service method, as returned by AmazonEC2.</returns>
        /// 
        public DescribeTagsResponse DescribeTags()
        {
            return DescribeTags(new DescribeTagsRequest());
        }
        

        #endregion
    
        #region DescribeVolumeAttribute

        /// <summary>
        /// </summary>
        /// 
        /// <param name="describeVolumeAttributeRequest">Container for the necessary parameters to execute the DescribeVolumeAttribute service method on
        ///          AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeVolumeAttribute service method, as returned by AmazonEC2.</returns>
        /// 
        public DescribeVolumeAttributeResponse DescribeVolumeAttribute(DescribeVolumeAttributeRequest describeVolumeAttributeRequest)
        {
            IAsyncResult asyncResult = invokeDescribeVolumeAttribute(describeVolumeAttributeRequest, null, null, true);
            return EndDescribeVolumeAttribute(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVolumeAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeVolumeAttribute"/>
        /// </summary>
        /// 
        /// <param name="describeVolumeAttributeRequest">Container for the necessary parameters to execute the DescribeVolumeAttribute operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeVolumeAttribute operation.</returns>
        public IAsyncResult BeginDescribeVolumeAttribute(DescribeVolumeAttributeRequest describeVolumeAttributeRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeVolumeAttribute(describeVolumeAttributeRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeVolumeAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeVolumeAttribute"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeVolumeAttribute.</param>
        /// 
        /// <returns>Returns a DescribeVolumeAttributeResult from AmazonEC2.</returns>
        public DescribeVolumeAttributeResponse EndDescribeVolumeAttribute(IAsyncResult asyncResult)
        {
            return endOperation<DescribeVolumeAttributeResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeVolumeAttribute(DescribeVolumeAttributeRequest describeVolumeAttributeRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeVolumeAttributeRequestMarshaller().Marshall(describeVolumeAttributeRequest);
            var unmarshaller = DescribeVolumeAttributeResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DescribeVolumeStatus

        /// <summary>
        /// <para> Describes the status of a volume. </para>
        /// </summary>
        /// 
        /// <param name="describeVolumeStatusRequest">Container for the necessary parameters to execute the DescribeVolumeStatus service method on
        ///          AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeVolumeStatus service method, as returned by AmazonEC2.</returns>
        /// 
        public DescribeVolumeStatusResponse DescribeVolumeStatus(DescribeVolumeStatusRequest describeVolumeStatusRequest)
        {
            IAsyncResult asyncResult = invokeDescribeVolumeStatus(describeVolumeStatusRequest, null, null, true);
            return EndDescribeVolumeStatus(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVolumeStatus operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeVolumeStatus"/>
        /// </summary>
        /// 
        /// <param name="describeVolumeStatusRequest">Container for the necessary parameters to execute the DescribeVolumeStatus operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeVolumeStatus operation.</returns>
        public IAsyncResult BeginDescribeVolumeStatus(DescribeVolumeStatusRequest describeVolumeStatusRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeVolumeStatus(describeVolumeStatusRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeVolumeStatus operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeVolumeStatus"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeVolumeStatus.</param>
        /// 
        /// <returns>Returns a DescribeVolumeStatusResult from AmazonEC2.</returns>
        public DescribeVolumeStatusResponse EndDescribeVolumeStatus(IAsyncResult asyncResult)
        {
            return endOperation<DescribeVolumeStatusResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeVolumeStatus(DescribeVolumeStatusRequest describeVolumeStatusRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeVolumeStatusRequestMarshaller().Marshall(describeVolumeStatusRequest);
            var unmarshaller = DescribeVolumeStatusResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para> Describes the status of a volume. </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeVolumeStatus service method, as returned by AmazonEC2.</returns>
        /// 
        public DescribeVolumeStatusResponse DescribeVolumeStatus()
        {
            return DescribeVolumeStatus(new DescribeVolumeStatusRequest());
        }
        

        #endregion
    
        #region DescribeVolumes

        /// <summary>
        /// <para> Describes the status of the indicated volume or, in lieu of any specified, all volumes belonging to the caller. Volumes that have
        /// been deleted are not described. </para>
        /// </summary>
        /// 
        /// <param name="describeVolumesRequest">Container for the necessary parameters to execute the DescribeVolumes service method on
        ///          AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeVolumes service method, as returned by AmazonEC2.</returns>
        /// 
        public DescribeVolumesResponse DescribeVolumes(DescribeVolumesRequest describeVolumesRequest)
        {
            IAsyncResult asyncResult = invokeDescribeVolumes(describeVolumesRequest, null, null, true);
            return EndDescribeVolumes(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVolumes operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeVolumes"/>
        /// </summary>
        /// 
        /// <param name="describeVolumesRequest">Container for the necessary parameters to execute the DescribeVolumes operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeVolumes
        ///         operation.</returns>
        public IAsyncResult BeginDescribeVolumes(DescribeVolumesRequest describeVolumesRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeVolumes(describeVolumesRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeVolumes operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeVolumes"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeVolumes.</param>
        /// 
        /// <returns>Returns a DescribeVolumesResult from AmazonEC2.</returns>
        public DescribeVolumesResponse EndDescribeVolumes(IAsyncResult asyncResult)
        {
            return endOperation<DescribeVolumesResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeVolumes(DescribeVolumesRequest describeVolumesRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeVolumesRequestMarshaller().Marshall(describeVolumesRequest);
            var unmarshaller = DescribeVolumesResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para> Describes the status of the indicated volume or, in lieu of any specified, all volumes belonging to the caller. Volumes that have
        /// been deleted are not described. </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeVolumes service method, as returned by AmazonEC2.</returns>
        /// 
        public DescribeVolumesResponse DescribeVolumes()
        {
            return DescribeVolumes(new DescribeVolumesRequest());
        }
        

        #endregion
    
        #region DescribeVpcAttribute

        /// <summary>
        /// </summary>
        /// 
        /// <param name="describeVpcAttributeRequest">Container for the necessary parameters to execute the DescribeVpcAttribute service method on
        ///          AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeVpcAttribute service method, as returned by AmazonEC2.</returns>
        /// 
        public DescribeVpcAttributeResponse DescribeVpcAttribute(DescribeVpcAttributeRequest describeVpcAttributeRequest)
        {
            IAsyncResult asyncResult = invokeDescribeVpcAttribute(describeVpcAttributeRequest, null, null, true);
            return EndDescribeVpcAttribute(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVpcAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeVpcAttribute"/>
        /// </summary>
        /// 
        /// <param name="describeVpcAttributeRequest">Container for the necessary parameters to execute the DescribeVpcAttribute operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeVpcAttribute operation.</returns>
        public IAsyncResult BeginDescribeVpcAttribute(DescribeVpcAttributeRequest describeVpcAttributeRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeVpcAttribute(describeVpcAttributeRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeVpcAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeVpcAttribute"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeVpcAttribute.</param>
        /// 
        /// <returns>Returns a DescribeVpcAttributeResult from AmazonEC2.</returns>
        public DescribeVpcAttributeResponse EndDescribeVpcAttribute(IAsyncResult asyncResult)
        {
            return endOperation<DescribeVpcAttributeResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeVpcAttribute(DescribeVpcAttributeRequest describeVpcAttributeRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeVpcAttributeRequestMarshaller().Marshall(describeVpcAttributeRequest);
            var unmarshaller = DescribeVpcAttributeResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DescribeVpcs

        /// <summary>
        /// <para> Gives you information about your VPCs. You can filter the results to return information only about VPCs that match criteria you
        /// specify. </para> <para> For example, you could ask to get information about a particular VPC or VPCs (or all your VPCs) only if the VPC's
        /// state is available. You can specify multiple filters (e.g., the VPC uses one of several sets of DHCP options, and the VPC's state is
        /// available). The result includes information for a particular VPC only if the VPC matches all your filters. </para> <para> If there's no
        /// match, no special message is returned; the response is simply empty. The following table shows the available filters. </para>
        /// </summary>
        /// 
        /// <param name="describeVpcsRequest">Container for the necessary parameters to execute the DescribeVpcs service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeVpcs service method, as returned by AmazonEC2.</returns>
        /// 
        public DescribeVpcsResponse DescribeVpcs(DescribeVpcsRequest describeVpcsRequest)
        {
            IAsyncResult asyncResult = invokeDescribeVpcs(describeVpcsRequest, null, null, true);
            return EndDescribeVpcs(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVpcs operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeVpcs"/>
        /// </summary>
        /// 
        /// <param name="describeVpcsRequest">Container for the necessary parameters to execute the DescribeVpcs operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDescribeVpcs
        ///         operation.</returns>
        public IAsyncResult BeginDescribeVpcs(DescribeVpcsRequest describeVpcsRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeVpcs(describeVpcsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeVpcs operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeVpcs"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeVpcs.</param>
        /// 
        /// <returns>Returns a DescribeVpcsResult from AmazonEC2.</returns>
        public DescribeVpcsResponse EndDescribeVpcs(IAsyncResult asyncResult)
        {
            return endOperation<DescribeVpcsResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeVpcs(DescribeVpcsRequest describeVpcsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeVpcsRequestMarshaller().Marshall(describeVpcsRequest);
            var unmarshaller = DescribeVpcsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para> Gives you information about your VPCs. You can filter the results to return information only about VPCs that match criteria you
        /// specify. </para> <para> For example, you could ask to get information about a particular VPC or VPCs (or all your VPCs) only if the VPC's
        /// state is available. You can specify multiple filters (e.g., the VPC uses one of several sets of DHCP options, and the VPC's state is
        /// available). The result includes information for a particular VPC only if the VPC matches all your filters. </para> <para> If there's no
        /// match, no special message is returned; the response is simply empty. The following table shows the available filters. </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeVpcs service method, as returned by AmazonEC2.</returns>
        /// 
        public DescribeVpcsResponse DescribeVpcs()
        {
            return DescribeVpcs(new DescribeVpcsRequest());
        }
        

        #endregion
    
        #region DescribeVpnConnections

        /// <summary>
        /// <para> Gives you information about your VPN connections. </para> <para><b>IMPORTANT:</b> We strongly recommend you use HTTPS when calling
        /// this operation because the response contains sensitive cryptographic information for configuring your customer gateway. You can filter the
        /// results to return information only about VPN connections that match criteria you specify. For example, you could ask to get information
        /// about a particular VPN connection (or all) only if the VPN's state is pending or available. You can specify multiple filters (e.g., the VPN
        /// connection is associated with a particular VPN gateway, and the gateway's state is pending or available). The result includes information
        /// for a particular VPN connection only if the VPN connection matches all your filters. If there's no match, no special message is returned;
        /// the response is simply empty. The following table shows the available filters. </para>
        /// </summary>
        /// 
        /// <param name="describeVpnConnectionsRequest">Container for the necessary parameters to execute the DescribeVpnConnections service method on
        ///          AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeVpnConnections service method, as returned by AmazonEC2.</returns>
        /// 
        public DescribeVpnConnectionsResponse DescribeVpnConnections(DescribeVpnConnectionsRequest describeVpnConnectionsRequest)
        {
            IAsyncResult asyncResult = invokeDescribeVpnConnections(describeVpnConnectionsRequest, null, null, true);
            return EndDescribeVpnConnections(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVpnConnections operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeVpnConnections"/>
        /// </summary>
        /// 
        /// <param name="describeVpnConnectionsRequest">Container for the necessary parameters to execute the DescribeVpnConnections operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeVpnConnections operation.</returns>
        public IAsyncResult BeginDescribeVpnConnections(DescribeVpnConnectionsRequest describeVpnConnectionsRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeVpnConnections(describeVpnConnectionsRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeVpnConnections operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeVpnConnections"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeVpnConnections.</param>
        /// 
        /// <returns>Returns a DescribeVpnConnectionsResult from AmazonEC2.</returns>
        public DescribeVpnConnectionsResponse EndDescribeVpnConnections(IAsyncResult asyncResult)
        {
            return endOperation<DescribeVpnConnectionsResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeVpnConnections(DescribeVpnConnectionsRequest describeVpnConnectionsRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeVpnConnectionsRequestMarshaller().Marshall(describeVpnConnectionsRequest);
            var unmarshaller = DescribeVpnConnectionsResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para> Gives you information about your VPN connections. </para> <para><b>IMPORTANT:</b> We strongly recommend you use HTTPS when calling
        /// this operation because the response contains sensitive cryptographic information for configuring your customer gateway. You can filter the
        /// results to return information only about VPN connections that match criteria you specify. For example, you could ask to get information
        /// about a particular VPN connection (or all) only if the VPN's state is pending or available. You can specify multiple filters (e.g., the VPN
        /// connection is associated with a particular VPN gateway, and the gateway's state is pending or available). The result includes information
        /// for a particular VPN connection only if the VPN connection matches all your filters. If there's no match, no special message is returned;
        /// the response is simply empty. The following table shows the available filters. </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeVpnConnections service method, as returned by AmazonEC2.</returns>
        /// 
        public DescribeVpnConnectionsResponse DescribeVpnConnections()
        {
            return DescribeVpnConnections(new DescribeVpnConnectionsRequest());
        }
        

        #endregion
    
        #region DescribeVpnGateways

        /// <summary>
        /// <para> Gives you information about your VPN gateways. You can filter the results to return information only about VPN gateways that match
        /// criteria you specify. </para> <para> For example, you could ask to get information about a particular VPN gateway (or all) only if the
        /// gateway's state is pending or available. You can specify multiple filters (e.g., the VPN gateway is in a particular Availability Zone and
        /// the gateway's state is pending or available). </para> <para> The result includes information for a particular VPN gateway only if the
        /// gateway matches all your filters. If there's no match, no special message is returned; the response is simply empty. The following table
        /// shows the available filters. </para>
        /// </summary>
        /// 
        /// <param name="describeVpnGatewaysRequest">Container for the necessary parameters to execute the DescribeVpnGateways service method on
        ///          AmazonEC2.</param>
        /// 
        /// <returns>The response from the DescribeVpnGateways service method, as returned by AmazonEC2.</returns>
        /// 
        public DescribeVpnGatewaysResponse DescribeVpnGateways(DescribeVpnGatewaysRequest describeVpnGatewaysRequest)
        {
            IAsyncResult asyncResult = invokeDescribeVpnGateways(describeVpnGatewaysRequest, null, null, true);
            return EndDescribeVpnGateways(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DescribeVpnGateways operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeVpnGateways"/>
        /// </summary>
        /// 
        /// <param name="describeVpnGatewaysRequest">Container for the necessary parameters to execute the DescribeVpnGateways operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndDescribeVpnGateways operation.</returns>
        public IAsyncResult BeginDescribeVpnGateways(DescribeVpnGatewaysRequest describeVpnGatewaysRequest, AsyncCallback callback, object state)
        {
            return invokeDescribeVpnGateways(describeVpnGatewaysRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DescribeVpnGateways operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DescribeVpnGateways"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDescribeVpnGateways.</param>
        /// 
        /// <returns>Returns a DescribeVpnGatewaysResult from AmazonEC2.</returns>
        public DescribeVpnGatewaysResponse EndDescribeVpnGateways(IAsyncResult asyncResult)
        {
            return endOperation<DescribeVpnGatewaysResponse>(asyncResult);
        }
        
        IAsyncResult invokeDescribeVpnGateways(DescribeVpnGatewaysRequest describeVpnGatewaysRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DescribeVpnGatewaysRequestMarshaller().Marshall(describeVpnGatewaysRequest);
            var unmarshaller = DescribeVpnGatewaysResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        /// <summary>
        /// <para> Gives you information about your VPN gateways. You can filter the results to return information only about VPN gateways that match
        /// criteria you specify. </para> <para> For example, you could ask to get information about a particular VPN gateway (or all) only if the
        /// gateway's state is pending or available. You can specify multiple filters (e.g., the VPN gateway is in a particular Availability Zone and
        /// the gateway's state is pending or available). </para> <para> The result includes information for a particular VPN gateway only if the
        /// gateway matches all your filters. If there's no match, no special message is returned; the response is simply empty. The following table
        /// shows the available filters. </para>
        /// </summary>
        /// 
        /// <returns>The response from the DescribeVpnGateways service method, as returned by AmazonEC2.</returns>
        /// 
        public DescribeVpnGatewaysResponse DescribeVpnGateways()
        {
            return DescribeVpnGateways(new DescribeVpnGatewaysRequest());
        }
        

        #endregion
    
        #region DetachInternetGateway

        /// <summary>
        /// <para> Detaches an Internet gateway from a VPC, disabling connectivity between the Internet and the VPC. The VPC must not contain any
        /// running instances with elastic IP addresses. For more information about your VPC and Internet gateway, go to Amazon Virtual Private Cloud
        /// User Guide. </para> <para> For more information about Amazon Virtual Private Cloud and Internet gateways, go to the Amazon Virtual Private
        /// Cloud User Guide. </para>
        /// </summary>
        /// 
        /// <param name="detachInternetGatewayRequest">Container for the necessary parameters to execute the DetachInternetGateway service method on
        ///          AmazonEC2.</param>
        /// 
        public DetachInternetGatewayResponse DetachInternetGateway(DetachInternetGatewayRequest detachInternetGatewayRequest)
        {
            IAsyncResult asyncResult = invokeDetachInternetGateway(detachInternetGatewayRequest, null, null, true);
            return EndDetachInternetGateway(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DetachInternetGateway operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DetachInternetGateway"/>
        /// </summary>
        /// 
        /// <param name="detachInternetGatewayRequest">Container for the necessary parameters to execute the DetachInternetGateway operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginDetachInternetGateway(DetachInternetGatewayRequest detachInternetGatewayRequest, AsyncCallback callback, object state)
        {
            return invokeDetachInternetGateway(detachInternetGatewayRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DetachInternetGateway operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DetachInternetGateway"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetachInternetGateway.</param>
        public DetachInternetGatewayResponse EndDetachInternetGateway(IAsyncResult asyncResult)
        {
            return endOperation<DetachInternetGatewayResponse>(asyncResult);
        }
        
        IAsyncResult invokeDetachInternetGateway(DetachInternetGatewayRequest detachInternetGatewayRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DetachInternetGatewayRequestMarshaller().Marshall(detachInternetGatewayRequest);
            var unmarshaller = DetachInternetGatewayResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DetachNetworkInterface

        /// <summary>
        /// </summary>
        /// 
        /// <param name="detachNetworkInterfaceRequest">Container for the necessary parameters to execute the DetachNetworkInterface service method on
        ///          AmazonEC2.</param>
        /// 
        public DetachNetworkInterfaceResponse DetachNetworkInterface(DetachNetworkInterfaceRequest detachNetworkInterfaceRequest)
        {
            IAsyncResult asyncResult = invokeDetachNetworkInterface(detachNetworkInterfaceRequest, null, null, true);
            return EndDetachNetworkInterface(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DetachNetworkInterface operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DetachNetworkInterface"/>
        /// </summary>
        /// 
        /// <param name="detachNetworkInterfaceRequest">Container for the necessary parameters to execute the DetachNetworkInterface operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginDetachNetworkInterface(DetachNetworkInterfaceRequest detachNetworkInterfaceRequest, AsyncCallback callback, object state)
        {
            return invokeDetachNetworkInterface(detachNetworkInterfaceRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DetachNetworkInterface operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DetachNetworkInterface"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetachNetworkInterface.</param>
        public DetachNetworkInterfaceResponse EndDetachNetworkInterface(IAsyncResult asyncResult)
        {
            return endOperation<DetachNetworkInterfaceResponse>(asyncResult);
        }
        
        IAsyncResult invokeDetachNetworkInterface(DetachNetworkInterfaceRequest detachNetworkInterfaceRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DetachNetworkInterfaceRequestMarshaller().Marshall(detachNetworkInterfaceRequest);
            var unmarshaller = DetachNetworkInterfaceResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DetachVolume

        /// <summary>
        /// <para> Detach a previously attached volume from a running instance. </para>
        /// </summary>
        /// 
        /// <param name="detachVolumeRequest">Container for the necessary parameters to execute the DetachVolume service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the DetachVolume service method, as returned by AmazonEC2.</returns>
        /// 
        public DetachVolumeResponse DetachVolume(DetachVolumeRequest detachVolumeRequest)
        {
            IAsyncResult asyncResult = invokeDetachVolume(detachVolumeRequest, null, null, true);
            return EndDetachVolume(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DetachVolume operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DetachVolume"/>
        /// </summary>
        /// 
        /// <param name="detachVolumeRequest">Container for the necessary parameters to execute the DetachVolume operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndDetachVolume
        ///         operation.</returns>
        public IAsyncResult BeginDetachVolume(DetachVolumeRequest detachVolumeRequest, AsyncCallback callback, object state)
        {
            return invokeDetachVolume(detachVolumeRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DetachVolume operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DetachVolume"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetachVolume.</param>
        /// 
        /// <returns>Returns a DetachVolumeResult from AmazonEC2.</returns>
        public DetachVolumeResponse EndDetachVolume(IAsyncResult asyncResult)
        {
            return endOperation<DetachVolumeResponse>(asyncResult);
        }
        
        IAsyncResult invokeDetachVolume(DetachVolumeRequest detachVolumeRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DetachVolumeRequestMarshaller().Marshall(detachVolumeRequest);
            var unmarshaller = DetachVolumeResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DetachVpnGateway

        /// <summary>
        /// <para> Detaches a VPN gateway from a VPC. You do this if you're planning to turn off the VPC and not use it anymore. You can confirm a VPN
        /// gateway has been completely detached from a VPC by describing the VPN gateway (any attachments to the VPN gateway are also described).
        /// </para> <para> You must wait for the attachment's state to switch to detached before you can delete the VPC or attach a different VPC to the
        /// VPN gateway. </para>
        /// </summary>
        /// 
        /// <param name="detachVpnGatewayRequest">Container for the necessary parameters to execute the DetachVpnGateway service method on
        ///          AmazonEC2.</param>
        /// 
        public DetachVpnGatewayResponse DetachVpnGateway(DetachVpnGatewayRequest detachVpnGatewayRequest)
        {
            IAsyncResult asyncResult = invokeDetachVpnGateway(detachVpnGatewayRequest, null, null, true);
            return EndDetachVpnGateway(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DetachVpnGateway operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DetachVpnGateway"/>
        /// </summary>
        /// 
        /// <param name="detachVpnGatewayRequest">Container for the necessary parameters to execute the DetachVpnGateway operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginDetachVpnGateway(DetachVpnGatewayRequest detachVpnGatewayRequest, AsyncCallback callback, object state)
        {
            return invokeDetachVpnGateway(detachVpnGatewayRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DetachVpnGateway operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DetachVpnGateway"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDetachVpnGateway.</param>
        public DetachVpnGatewayResponse EndDetachVpnGateway(IAsyncResult asyncResult)
        {
            return endOperation<DetachVpnGatewayResponse>(asyncResult);
        }
        
        IAsyncResult invokeDetachVpnGateway(DetachVpnGatewayRequest detachVpnGatewayRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DetachVpnGatewayRequestMarshaller().Marshall(detachVpnGatewayRequest);
            var unmarshaller = DetachVpnGatewayResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DisableVgwRoutePropagation

        /// <summary>
        /// </summary>
        /// 
        /// <param name="disableVgwRoutePropagationRequest">Container for the necessary parameters to execute the DisableVgwRoutePropagation service
        ///          method on AmazonEC2.</param>
        /// 
        public DisableVgwRoutePropagationResponse DisableVgwRoutePropagation(DisableVgwRoutePropagationRequest disableVgwRoutePropagationRequest)
        {
            IAsyncResult asyncResult = invokeDisableVgwRoutePropagation(disableVgwRoutePropagationRequest, null, null, true);
            return EndDisableVgwRoutePropagation(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DisableVgwRoutePropagation operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DisableVgwRoutePropagation"/>
        /// </summary>
        /// 
        /// <param name="disableVgwRoutePropagationRequest">Container for the necessary parameters to execute the DisableVgwRoutePropagation operation
        ///          on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginDisableVgwRoutePropagation(DisableVgwRoutePropagationRequest disableVgwRoutePropagationRequest, AsyncCallback callback, object state)
        {
            return invokeDisableVgwRoutePropagation(disableVgwRoutePropagationRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DisableVgwRoutePropagation operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DisableVgwRoutePropagation"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisableVgwRoutePropagation.</param>
        public DisableVgwRoutePropagationResponse EndDisableVgwRoutePropagation(IAsyncResult asyncResult)
        {
            return endOperation<DisableVgwRoutePropagationResponse>(asyncResult);
        }
        
        IAsyncResult invokeDisableVgwRoutePropagation(DisableVgwRoutePropagationRequest disableVgwRoutePropagationRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DisableVgwRoutePropagationRequestMarshaller().Marshall(disableVgwRoutePropagationRequest);
            var unmarshaller = DisableVgwRoutePropagationResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DisassociateAddress

        /// <summary>
        /// <para> The DisassociateAddress operation disassociates the specified elastic IP address from the instance to which it is assigned. This is
        /// an idempotent operation. If you enter it more than once, Amazon EC2 does not return an error. </para>
        /// </summary>
        /// 
        /// <param name="disassociateAddressRequest">Container for the necessary parameters to execute the DisassociateAddress service method on
        ///          AmazonEC2.</param>
        /// 
        public DisassociateAddressResponse DisassociateAddress(DisassociateAddressRequest disassociateAddressRequest)
        {
            IAsyncResult asyncResult = invokeDisassociateAddress(disassociateAddressRequest, null, null, true);
            return EndDisassociateAddress(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateAddress operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DisassociateAddress"/>
        /// </summary>
        /// 
        /// <param name="disassociateAddressRequest">Container for the necessary parameters to execute the DisassociateAddress operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginDisassociateAddress(DisassociateAddressRequest disassociateAddressRequest, AsyncCallback callback, object state)
        {
            return invokeDisassociateAddress(disassociateAddressRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DisassociateAddress operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DisassociateAddress"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateAddress.</param>
        public DisassociateAddressResponse EndDisassociateAddress(IAsyncResult asyncResult)
        {
            return endOperation<DisassociateAddressResponse>(asyncResult);
        }
        
        IAsyncResult invokeDisassociateAddress(DisassociateAddressRequest disassociateAddressRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DisassociateAddressRequestMarshaller().Marshall(disassociateAddressRequest);
            var unmarshaller = DisassociateAddressResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region DisassociateRouteTable

        /// <summary>
        /// <para> Disassociates a subnet from a route table. </para> <para> After you perform this action, the subnet no longer uses the routes in the
        /// route table. Instead it uses the routes in the VPC's main route table. For more information about route tables, go to <a
        /// href="http://docs.amazonwebservices.com/AmazonVPC/latest/UserGuide/VPC_Route_Tables.html" >Route Tables</a> in the Amazon Virtual Private
        /// Cloud User Guide. </para>
        /// </summary>
        /// 
        /// <param name="disassociateRouteTableRequest">Container for the necessary parameters to execute the DisassociateRouteTable service method on
        ///          AmazonEC2.</param>
        /// 
        public DisassociateRouteTableResponse DisassociateRouteTable(DisassociateRouteTableRequest disassociateRouteTableRequest)
        {
            IAsyncResult asyncResult = invokeDisassociateRouteTable(disassociateRouteTableRequest, null, null, true);
            return EndDisassociateRouteTable(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the DisassociateRouteTable operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DisassociateRouteTable"/>
        /// </summary>
        /// 
        /// <param name="disassociateRouteTableRequest">Container for the necessary parameters to execute the DisassociateRouteTable operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginDisassociateRouteTable(DisassociateRouteTableRequest disassociateRouteTableRequest, AsyncCallback callback, object state)
        {
            return invokeDisassociateRouteTable(disassociateRouteTableRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the DisassociateRouteTable operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.DisassociateRouteTable"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginDisassociateRouteTable.</param>
        public DisassociateRouteTableResponse EndDisassociateRouteTable(IAsyncResult asyncResult)
        {
            return endOperation<DisassociateRouteTableResponse>(asyncResult);
        }
        
        IAsyncResult invokeDisassociateRouteTable(DisassociateRouteTableRequest disassociateRouteTableRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new DisassociateRouteTableRequestMarshaller().Marshall(disassociateRouteTableRequest);
            var unmarshaller = DisassociateRouteTableResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region EnableVgwRoutePropagation

        /// <summary>
        /// </summary>
        /// 
        /// <param name="enableVgwRoutePropagationRequest">Container for the necessary parameters to execute the EnableVgwRoutePropagation service
        ///          method on AmazonEC2.</param>
        /// 
        public EnableVgwRoutePropagationResponse EnableVgwRoutePropagation(EnableVgwRoutePropagationRequest enableVgwRoutePropagationRequest)
        {
            IAsyncResult asyncResult = invokeEnableVgwRoutePropagation(enableVgwRoutePropagationRequest, null, null, true);
            return EndEnableVgwRoutePropagation(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the EnableVgwRoutePropagation operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.EnableVgwRoutePropagation"/>
        /// </summary>
        /// 
        /// <param name="enableVgwRoutePropagationRequest">Container for the necessary parameters to execute the EnableVgwRoutePropagation operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginEnableVgwRoutePropagation(EnableVgwRoutePropagationRequest enableVgwRoutePropagationRequest, AsyncCallback callback, object state)
        {
            return invokeEnableVgwRoutePropagation(enableVgwRoutePropagationRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the EnableVgwRoutePropagation operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.EnableVgwRoutePropagation"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEnableVgwRoutePropagation.</param>
        public EnableVgwRoutePropagationResponse EndEnableVgwRoutePropagation(IAsyncResult asyncResult)
        {
            return endOperation<EnableVgwRoutePropagationResponse>(asyncResult);
        }
        
        IAsyncResult invokeEnableVgwRoutePropagation(EnableVgwRoutePropagationRequest enableVgwRoutePropagationRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new EnableVgwRoutePropagationRequestMarshaller().Marshall(enableVgwRoutePropagationRequest);
            var unmarshaller = EnableVgwRoutePropagationResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region EnableVolumeIO

        /// <summary>
        /// <para> Enable IO on the volume after an event has occured. </para>
        /// </summary>
        /// 
        /// <param name="enableVolumeIORequest">Container for the necessary parameters to execute the EnableVolumeIO service method on
        ///          AmazonEC2.</param>
        /// 
        public EnableVolumeIOResponse EnableVolumeIO(EnableVolumeIORequest enableVolumeIORequest)
        {
            IAsyncResult asyncResult = invokeEnableVolumeIO(enableVolumeIORequest, null, null, true);
            return EndEnableVolumeIO(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the EnableVolumeIO operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.EnableVolumeIO"/>
        /// </summary>
        /// 
        /// <param name="enableVolumeIORequest">Container for the necessary parameters to execute the EnableVolumeIO operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginEnableVolumeIO(EnableVolumeIORequest enableVolumeIORequest, AsyncCallback callback, object state)
        {
            return invokeEnableVolumeIO(enableVolumeIORequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the EnableVolumeIO operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.EnableVolumeIO"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginEnableVolumeIO.</param>
        public EnableVolumeIOResponse EndEnableVolumeIO(IAsyncResult asyncResult)
        {
            return endOperation<EnableVolumeIOResponse>(asyncResult);
        }
        
        IAsyncResult invokeEnableVolumeIO(EnableVolumeIORequest enableVolumeIORequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new EnableVolumeIORequestMarshaller().Marshall(enableVolumeIORequest);
            var unmarshaller = EnableVolumeIOResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region GetConsoleOutput

        /// <summary>
        /// <para> The GetConsoleOutput operation retrieves console output for the specified instance. </para> <para> Instance console output is
        /// buffered and posted shortly after instance boot, reboot, and termination. Amazon EC2 preserves the most recent 64 KB output which will be
        /// available for at least one hour after the most recent post. </para>
        /// </summary>
        /// 
        /// <param name="getConsoleOutputRequest">Container for the necessary parameters to execute the GetConsoleOutput service method on
        ///          AmazonEC2.</param>
        /// 
        /// <returns>The response from the GetConsoleOutput service method, as returned by AmazonEC2.</returns>
        /// 
        public GetConsoleOutputResponse GetConsoleOutput(GetConsoleOutputRequest getConsoleOutputRequest)
        {
            IAsyncResult asyncResult = invokeGetConsoleOutput(getConsoleOutputRequest, null, null, true);
            return EndGetConsoleOutput(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the GetConsoleOutput operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.GetConsoleOutput"/>
        /// </summary>
        /// 
        /// <param name="getConsoleOutputRequest">Container for the necessary parameters to execute the GetConsoleOutput operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetConsoleOutput
        ///         operation.</returns>
        public IAsyncResult BeginGetConsoleOutput(GetConsoleOutputRequest getConsoleOutputRequest, AsyncCallback callback, object state)
        {
            return invokeGetConsoleOutput(getConsoleOutputRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the GetConsoleOutput operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.GetConsoleOutput"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetConsoleOutput.</param>
        /// 
        /// <returns>Returns a GetConsoleOutputResult from AmazonEC2.</returns>
        public GetConsoleOutputResponse EndGetConsoleOutput(IAsyncResult asyncResult)
        {
            return endOperation<GetConsoleOutputResponse>(asyncResult);
        }
        
        IAsyncResult invokeGetConsoleOutput(GetConsoleOutputRequest getConsoleOutputRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new GetConsoleOutputRequestMarshaller().Marshall(getConsoleOutputRequest);
            var unmarshaller = GetConsoleOutputResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region GetPasswordData

        /// <summary>
        /// <para> Retrieves the encrypted administrator password for the instances running Windows. </para> <para><b>NOTE:</b> The Windows password is
        /// only generated the first time an AMI is launched. It is not generated for rebundled AMIs or after the password is changed on an instance.
        /// The password is encrypted using the key pair that you provided. </para>
        /// </summary>
        /// 
        /// <param name="getPasswordDataRequest">Container for the necessary parameters to execute the GetPasswordData service method on
        ///          AmazonEC2.</param>
        /// 
        /// <returns>The response from the GetPasswordData service method, as returned by AmazonEC2.</returns>
        /// 
        public GetPasswordDataResponse GetPasswordData(GetPasswordDataRequest getPasswordDataRequest)
        {
            IAsyncResult asyncResult = invokeGetPasswordData(getPasswordDataRequest, null, null, true);
            return EndGetPasswordData(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the GetPasswordData operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.GetPasswordData"/>
        /// </summary>
        /// 
        /// <param name="getPasswordDataRequest">Container for the necessary parameters to execute the GetPasswordData operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndGetPasswordData
        ///         operation.</returns>
        public IAsyncResult BeginGetPasswordData(GetPasswordDataRequest getPasswordDataRequest, AsyncCallback callback, object state)
        {
            return invokeGetPasswordData(getPasswordDataRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the GetPasswordData operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.GetPasswordData"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginGetPasswordData.</param>
        /// 
        /// <returns>Returns a GetPasswordDataResult from AmazonEC2.</returns>
        public GetPasswordDataResponse EndGetPasswordData(IAsyncResult asyncResult)
        {
            return endOperation<GetPasswordDataResponse>(asyncResult);
        }
        
        IAsyncResult invokeGetPasswordData(GetPasswordDataRequest getPasswordDataRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new GetPasswordDataRequestMarshaller().Marshall(getPasswordDataRequest);
            var unmarshaller = GetPasswordDataResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region ImportInstance

        /// <summary>
        /// </summary>
        /// 
        /// <param name="importInstanceRequest">Container for the necessary parameters to execute the ImportInstance service method on
        ///          AmazonEC2.</param>
        /// 
        /// <returns>The response from the ImportInstance service method, as returned by AmazonEC2.</returns>
        /// 
        public ImportInstanceResponse ImportInstance(ImportInstanceRequest importInstanceRequest)
        {
            IAsyncResult asyncResult = invokeImportInstance(importInstanceRequest, null, null, true);
            return EndImportInstance(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ImportInstance operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ImportInstance"/>
        /// </summary>
        /// 
        /// <param name="importInstanceRequest">Container for the necessary parameters to execute the ImportInstance operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndImportInstance
        ///         operation.</returns>
        public IAsyncResult BeginImportInstance(ImportInstanceRequest importInstanceRequest, AsyncCallback callback, object state)
        {
            return invokeImportInstance(importInstanceRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ImportInstance operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ImportInstance"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginImportInstance.</param>
        /// 
        /// <returns>Returns a ImportInstanceResult from AmazonEC2.</returns>
        public ImportInstanceResponse EndImportInstance(IAsyncResult asyncResult)
        {
            return endOperation<ImportInstanceResponse>(asyncResult);
        }
        
        IAsyncResult invokeImportInstance(ImportInstanceRequest importInstanceRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ImportInstanceRequestMarshaller().Marshall(importInstanceRequest);
            var unmarshaller = ImportInstanceResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region ImportKeyPair

        /// <summary>
        /// <para> Imports the public key from an RSA key pair created with a third-party tool. This operation differs from CreateKeyPair as the private
        /// key is never transferred between the caller and AWS servers. </para> <para> RSA key pairs are easily created on Microsoft Windows and Linux
        /// OS systems using the <c>ssh-keygen</c> command line tool provided with the standard OpenSSH installation. Standard library support for RSA
        /// key pair creation is also available for Java, Ruby, Python, and many other programming languages. </para> <para>The following formats are
        /// supported:</para>
        /// <ul>
        /// <li> OpenSSH public key format, </li>
        /// <li> Base64 encoded DER format. </li>
        /// <li> SSH public key file format as specified in <a href="http://tools.ietf.org/html/rfc4716" > RFC4716 </a> .
        /// </li>
        /// 
        /// </ul>
        /// </summary>
        /// 
        /// <param name="importKeyPairRequest">Container for the necessary parameters to execute the ImportKeyPair service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the ImportKeyPair service method, as returned by AmazonEC2.</returns>
        /// 
        public ImportKeyPairResponse ImportKeyPair(ImportKeyPairRequest importKeyPairRequest)
        {
            IAsyncResult asyncResult = invokeImportKeyPair(importKeyPairRequest, null, null, true);
            return EndImportKeyPair(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ImportKeyPair operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ImportKeyPair"/>
        /// </summary>
        /// 
        /// <param name="importKeyPairRequest">Container for the necessary parameters to execute the ImportKeyPair operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndImportKeyPair
        ///         operation.</returns>
        public IAsyncResult BeginImportKeyPair(ImportKeyPairRequest importKeyPairRequest, AsyncCallback callback, object state)
        {
            return invokeImportKeyPair(importKeyPairRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ImportKeyPair operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ImportKeyPair"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginImportKeyPair.</param>
        /// 
        /// <returns>Returns a ImportKeyPairResult from AmazonEC2.</returns>
        public ImportKeyPairResponse EndImportKeyPair(IAsyncResult asyncResult)
        {
            return endOperation<ImportKeyPairResponse>(asyncResult);
        }
        
        IAsyncResult invokeImportKeyPair(ImportKeyPairRequest importKeyPairRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ImportKeyPairRequestMarshaller().Marshall(importKeyPairRequest);
            var unmarshaller = ImportKeyPairResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region ImportVolume

        /// <summary>
        /// </summary>
        /// 
        /// <param name="importVolumeRequest">Container for the necessary parameters to execute the ImportVolume service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the ImportVolume service method, as returned by AmazonEC2.</returns>
        /// 
        public ImportVolumeResponse ImportVolume(ImportVolumeRequest importVolumeRequest)
        {
            IAsyncResult asyncResult = invokeImportVolume(importVolumeRequest, null, null, true);
            return EndImportVolume(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ImportVolume operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ImportVolume"/>
        /// </summary>
        /// 
        /// <param name="importVolumeRequest">Container for the necessary parameters to execute the ImportVolume operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndImportVolume
        ///         operation.</returns>
        public IAsyncResult BeginImportVolume(ImportVolumeRequest importVolumeRequest, AsyncCallback callback, object state)
        {
            return invokeImportVolume(importVolumeRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ImportVolume operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ImportVolume"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginImportVolume.</param>
        /// 
        /// <returns>Returns a ImportVolumeResult from AmazonEC2.</returns>
        public ImportVolumeResponse EndImportVolume(IAsyncResult asyncResult)
        {
            return endOperation<ImportVolumeResponse>(asyncResult);
        }
        
        IAsyncResult invokeImportVolume(ImportVolumeRequest importVolumeRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ImportVolumeRequestMarshaller().Marshall(importVolumeRequest);
            var unmarshaller = ImportVolumeResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region ModifyImageAttribute

        /// <summary>
        /// <para> The ModifyImageAttribute operation modifies an attribute of an AMI. </para>
        /// </summary>
        /// 
        /// <param name="modifyImageAttributeRequest">Container for the necessary parameters to execute the ModifyImageAttribute service method on
        ///          AmazonEC2.</param>
        /// 
        public ModifyImageAttributeResponse ModifyImageAttribute(ModifyImageAttributeRequest modifyImageAttributeRequest)
        {
            IAsyncResult asyncResult = invokeModifyImageAttribute(modifyImageAttributeRequest, null, null, true);
            return EndModifyImageAttribute(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyImageAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ModifyImageAttribute"/>
        /// </summary>
        /// 
        /// <param name="modifyImageAttributeRequest">Container for the necessary parameters to execute the ModifyImageAttribute operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginModifyImageAttribute(ModifyImageAttributeRequest modifyImageAttributeRequest, AsyncCallback callback, object state)
        {
            return invokeModifyImageAttribute(modifyImageAttributeRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ModifyImageAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ModifyImageAttribute"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyImageAttribute.</param>
        public ModifyImageAttributeResponse EndModifyImageAttribute(IAsyncResult asyncResult)
        {
            return endOperation<ModifyImageAttributeResponse>(asyncResult);
        }
        
        IAsyncResult invokeModifyImageAttribute(ModifyImageAttributeRequest modifyImageAttributeRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ModifyImageAttributeRequestMarshaller().Marshall(modifyImageAttributeRequest);
            var unmarshaller = ModifyImageAttributeResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region ModifyInstanceAttribute

        /// <summary>
        /// <para> Modifies an attribute of an instance. </para>
        /// </summary>
        /// 
        /// <param name="modifyInstanceAttributeRequest">Container for the necessary parameters to execute the ModifyInstanceAttribute service method on
        ///          AmazonEC2.</param>
        /// 
        public ModifyInstanceAttributeResponse ModifyInstanceAttribute(ModifyInstanceAttributeRequest modifyInstanceAttributeRequest)
        {
            IAsyncResult asyncResult = invokeModifyInstanceAttribute(modifyInstanceAttributeRequest, null, null, true);
            return EndModifyInstanceAttribute(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyInstanceAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ModifyInstanceAttribute"/>
        /// </summary>
        /// 
        /// <param name="modifyInstanceAttributeRequest">Container for the necessary parameters to execute the ModifyInstanceAttribute operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginModifyInstanceAttribute(ModifyInstanceAttributeRequest modifyInstanceAttributeRequest, AsyncCallback callback, object state)
        {
            return invokeModifyInstanceAttribute(modifyInstanceAttributeRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ModifyInstanceAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ModifyInstanceAttribute"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyInstanceAttribute.</param>
        public ModifyInstanceAttributeResponse EndModifyInstanceAttribute(IAsyncResult asyncResult)
        {
            return endOperation<ModifyInstanceAttributeResponse>(asyncResult);
        }
        
        IAsyncResult invokeModifyInstanceAttribute(ModifyInstanceAttributeRequest modifyInstanceAttributeRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ModifyInstanceAttributeRequestMarshaller().Marshall(modifyInstanceAttributeRequest);
            var unmarshaller = ModifyInstanceAttributeResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region ModifyNetworkInterfaceAttribute

        /// <summary>
        /// </summary>
        /// 
        /// <param name="modifyNetworkInterfaceAttributeRequest">Container for the necessary parameters to execute the ModifyNetworkInterfaceAttribute
        ///          service method on AmazonEC2.</param>
        /// 
        public ModifyNetworkInterfaceAttributeResponse ModifyNetworkInterfaceAttribute(ModifyNetworkInterfaceAttributeRequest modifyNetworkInterfaceAttributeRequest)
        {
            IAsyncResult asyncResult = invokeModifyNetworkInterfaceAttribute(modifyNetworkInterfaceAttributeRequest, null, null, true);
            return EndModifyNetworkInterfaceAttribute(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyNetworkInterfaceAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ModifyNetworkInterfaceAttribute"/>
        /// </summary>
        /// 
        /// <param name="modifyNetworkInterfaceAttributeRequest">Container for the necessary parameters to execute the ModifyNetworkInterfaceAttribute
        ///          operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginModifyNetworkInterfaceAttribute(ModifyNetworkInterfaceAttributeRequest modifyNetworkInterfaceAttributeRequest, AsyncCallback callback, object state)
        {
            return invokeModifyNetworkInterfaceAttribute(modifyNetworkInterfaceAttributeRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ModifyNetworkInterfaceAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ModifyNetworkInterfaceAttribute"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyNetworkInterfaceAttribute.</param>
        public ModifyNetworkInterfaceAttributeResponse EndModifyNetworkInterfaceAttribute(IAsyncResult asyncResult)
        {
            return endOperation<ModifyNetworkInterfaceAttributeResponse>(asyncResult);
        }
        
        IAsyncResult invokeModifyNetworkInterfaceAttribute(ModifyNetworkInterfaceAttributeRequest modifyNetworkInterfaceAttributeRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ModifyNetworkInterfaceAttributeRequestMarshaller().Marshall(modifyNetworkInterfaceAttributeRequest);
            var unmarshaller = ModifyNetworkInterfaceAttributeResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region ModifyReservedInstances

        /// <summary>
        /// <para> The ModifyReservedInstances operation modifies the Availability Zone, instance count, instance type, or network platform (EC2-Classic
        /// or EC2-VPC) of your Reserved Instances. </para>
        /// </summary>
        /// 
        /// <param name="modifyReservedInstancesRequest">Container for the necessary parameters to execute the ModifyReservedInstances service method on
        ///          AmazonEC2.</param>
        /// 
        /// <returns>The response from the ModifyReservedInstances service method, as returned by AmazonEC2.</returns>
        /// 
        public ModifyReservedInstancesResponse ModifyReservedInstances(ModifyReservedInstancesRequest modifyReservedInstancesRequest)
        {
            IAsyncResult asyncResult = invokeModifyReservedInstances(modifyReservedInstancesRequest, null, null, true);
            return EndModifyReservedInstances(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyReservedInstances operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ModifyReservedInstances"/>
        /// </summary>
        /// 
        /// <param name="modifyReservedInstancesRequest">Container for the necessary parameters to execute the ModifyReservedInstances operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndModifyReservedInstances operation.</returns>
        public IAsyncResult BeginModifyReservedInstances(ModifyReservedInstancesRequest modifyReservedInstancesRequest, AsyncCallback callback, object state)
        {
            return invokeModifyReservedInstances(modifyReservedInstancesRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ModifyReservedInstances operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ModifyReservedInstances"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyReservedInstances.</param>
        /// 
        /// <returns>Returns a ModifyReservedInstancesResult from AmazonEC2.</returns>
        public ModifyReservedInstancesResponse EndModifyReservedInstances(IAsyncResult asyncResult)
        {
            return endOperation<ModifyReservedInstancesResponse>(asyncResult);
        }
        
        IAsyncResult invokeModifyReservedInstances(ModifyReservedInstancesRequest modifyReservedInstancesRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ModifyReservedInstancesRequestMarshaller().Marshall(modifyReservedInstancesRequest);
            var unmarshaller = ModifyReservedInstancesResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region ModifySnapshotAttribute

        /// <summary>
        /// <para> Adds or remove permission settings for the specified snapshot. </para>
        /// </summary>
        /// 
        /// <param name="modifySnapshotAttributeRequest">Container for the necessary parameters to execute the ModifySnapshotAttribute service method on
        ///          AmazonEC2.</param>
        /// 
        public ModifySnapshotAttributeResponse ModifySnapshotAttribute(ModifySnapshotAttributeRequest modifySnapshotAttributeRequest)
        {
            IAsyncResult asyncResult = invokeModifySnapshotAttribute(modifySnapshotAttributeRequest, null, null, true);
            return EndModifySnapshotAttribute(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ModifySnapshotAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ModifySnapshotAttribute"/>
        /// </summary>
        /// 
        /// <param name="modifySnapshotAttributeRequest">Container for the necessary parameters to execute the ModifySnapshotAttribute operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginModifySnapshotAttribute(ModifySnapshotAttributeRequest modifySnapshotAttributeRequest, AsyncCallback callback, object state)
        {
            return invokeModifySnapshotAttribute(modifySnapshotAttributeRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ModifySnapshotAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ModifySnapshotAttribute"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifySnapshotAttribute.</param>
        public ModifySnapshotAttributeResponse EndModifySnapshotAttribute(IAsyncResult asyncResult)
        {
            return endOperation<ModifySnapshotAttributeResponse>(asyncResult);
        }
        
        IAsyncResult invokeModifySnapshotAttribute(ModifySnapshotAttributeRequest modifySnapshotAttributeRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ModifySnapshotAttributeRequestMarshaller().Marshall(modifySnapshotAttributeRequest);
            var unmarshaller = ModifySnapshotAttributeResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region ModifyVolumeAttribute

        /// <summary>
        /// </summary>
        /// 
        /// <param name="modifyVolumeAttributeRequest">Container for the necessary parameters to execute the ModifyVolumeAttribute service method on
        ///          AmazonEC2.</param>
        /// 
        public ModifyVolumeAttributeResponse ModifyVolumeAttribute(ModifyVolumeAttributeRequest modifyVolumeAttributeRequest)
        {
            IAsyncResult asyncResult = invokeModifyVolumeAttribute(modifyVolumeAttributeRequest, null, null, true);
            return EndModifyVolumeAttribute(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyVolumeAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ModifyVolumeAttribute"/>
        /// </summary>
        /// 
        /// <param name="modifyVolumeAttributeRequest">Container for the necessary parameters to execute the ModifyVolumeAttribute operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginModifyVolumeAttribute(ModifyVolumeAttributeRequest modifyVolumeAttributeRequest, AsyncCallback callback, object state)
        {
            return invokeModifyVolumeAttribute(modifyVolumeAttributeRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ModifyVolumeAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ModifyVolumeAttribute"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyVolumeAttribute.</param>
        public ModifyVolumeAttributeResponse EndModifyVolumeAttribute(IAsyncResult asyncResult)
        {
            return endOperation<ModifyVolumeAttributeResponse>(asyncResult);
        }
        
        IAsyncResult invokeModifyVolumeAttribute(ModifyVolumeAttributeRequest modifyVolumeAttributeRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ModifyVolumeAttributeRequestMarshaller().Marshall(modifyVolumeAttributeRequest);
            var unmarshaller = ModifyVolumeAttributeResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region ModifyVpcAttribute

        /// <summary>
        /// </summary>
        /// 
        /// <param name="modifyVpcAttributeRequest">Container for the necessary parameters to execute the ModifyVpcAttribute service method on
        ///          AmazonEC2.</param>
        /// 
        public ModifyVpcAttributeResponse ModifyVpcAttribute(ModifyVpcAttributeRequest modifyVpcAttributeRequest)
        {
            IAsyncResult asyncResult = invokeModifyVpcAttribute(modifyVpcAttributeRequest, null, null, true);
            return EndModifyVpcAttribute(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ModifyVpcAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ModifyVpcAttribute"/>
        /// </summary>
        /// 
        /// <param name="modifyVpcAttributeRequest">Container for the necessary parameters to execute the ModifyVpcAttribute operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginModifyVpcAttribute(ModifyVpcAttributeRequest modifyVpcAttributeRequest, AsyncCallback callback, object state)
        {
            return invokeModifyVpcAttribute(modifyVpcAttributeRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ModifyVpcAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ModifyVpcAttribute"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginModifyVpcAttribute.</param>
        public ModifyVpcAttributeResponse EndModifyVpcAttribute(IAsyncResult asyncResult)
        {
            return endOperation<ModifyVpcAttributeResponse>(asyncResult);
        }
        
        IAsyncResult invokeModifyVpcAttribute(ModifyVpcAttributeRequest modifyVpcAttributeRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ModifyVpcAttributeRequestMarshaller().Marshall(modifyVpcAttributeRequest);
            var unmarshaller = ModifyVpcAttributeResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region MonitorInstances

        /// <summary>
        /// <para> Enables monitoring for a running instance. </para>
        /// </summary>
        /// 
        /// <param name="monitorInstancesRequest">Container for the necessary parameters to execute the MonitorInstances service method on
        ///          AmazonEC2.</param>
        /// 
        /// <returns>The response from the MonitorInstances service method, as returned by AmazonEC2.</returns>
        /// 
        public MonitorInstancesResponse MonitorInstances(MonitorInstancesRequest monitorInstancesRequest)
        {
            IAsyncResult asyncResult = invokeMonitorInstances(monitorInstancesRequest, null, null, true);
            return EndMonitorInstances(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the MonitorInstances operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.MonitorInstances"/>
        /// </summary>
        /// 
        /// <param name="monitorInstancesRequest">Container for the necessary parameters to execute the MonitorInstances operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndMonitorInstances
        ///         operation.</returns>
        public IAsyncResult BeginMonitorInstances(MonitorInstancesRequest monitorInstancesRequest, AsyncCallback callback, object state)
        {
            return invokeMonitorInstances(monitorInstancesRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the MonitorInstances operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.MonitorInstances"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginMonitorInstances.</param>
        /// 
        /// <returns>Returns a MonitorInstancesResult from AmazonEC2.</returns>
        public MonitorInstancesResponse EndMonitorInstances(IAsyncResult asyncResult)
        {
            return endOperation<MonitorInstancesResponse>(asyncResult);
        }
        
        IAsyncResult invokeMonitorInstances(MonitorInstancesRequest monitorInstancesRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new MonitorInstancesRequestMarshaller().Marshall(monitorInstancesRequest);
            var unmarshaller = MonitorInstancesResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region PurchaseReservedInstancesOffering

        /// <summary>
        /// <para> The PurchaseReservedInstancesOffering operation purchases a Reserved Instance for use with your account. With Amazon EC2 Reserved
        /// Instances, you purchase the right to launch Amazon EC2 instances for a period of time (without getting insufficient capacity errors) and pay
        /// a lower usage rate for the actual time used. </para>
        /// </summary>
        /// 
        /// <param name="purchaseReservedInstancesOfferingRequest">Container for the necessary parameters to execute the
        ///          PurchaseReservedInstancesOffering service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the PurchaseReservedInstancesOffering service method, as returned by AmazonEC2.</returns>
        /// 
        public PurchaseReservedInstancesOfferingResponse PurchaseReservedInstancesOffering(PurchaseReservedInstancesOfferingRequest purchaseReservedInstancesOfferingRequest)
        {
            IAsyncResult asyncResult = invokePurchaseReservedInstancesOffering(purchaseReservedInstancesOfferingRequest, null, null, true);
            return EndPurchaseReservedInstancesOffering(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the PurchaseReservedInstancesOffering operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.PurchaseReservedInstancesOffering"/>
        /// </summary>
        /// 
        /// <param name="purchaseReservedInstancesOfferingRequest">Container for the necessary parameters to execute the
        ///          PurchaseReservedInstancesOffering operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndPurchaseReservedInstancesOffering operation.</returns>
        public IAsyncResult BeginPurchaseReservedInstancesOffering(PurchaseReservedInstancesOfferingRequest purchaseReservedInstancesOfferingRequest, AsyncCallback callback, object state)
        {
            return invokePurchaseReservedInstancesOffering(purchaseReservedInstancesOfferingRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the PurchaseReservedInstancesOffering operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.PurchaseReservedInstancesOffering"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginPurchaseReservedInstancesOffering.</param>
        /// 
        /// <returns>Returns a PurchaseReservedInstancesOfferingResult from AmazonEC2.</returns>
        public PurchaseReservedInstancesOfferingResponse EndPurchaseReservedInstancesOffering(IAsyncResult asyncResult)
        {
            return endOperation<PurchaseReservedInstancesOfferingResponse>(asyncResult);
        }
        
        IAsyncResult invokePurchaseReservedInstancesOffering(PurchaseReservedInstancesOfferingRequest purchaseReservedInstancesOfferingRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new PurchaseReservedInstancesOfferingRequestMarshaller().Marshall(purchaseReservedInstancesOfferingRequest);
            var unmarshaller = PurchaseReservedInstancesOfferingResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region RebootInstances

        /// <summary>
        /// <para> The RebootInstances operation requests a reboot of one or more instances. This operation is asynchronous; it only queues a request to
        /// reboot the specified instance(s). The operation will succeed if the instances are valid and belong to the user. Requests to reboot
        /// terminated instances are ignored. </para>
        /// </summary>
        /// 
        /// <param name="rebootInstancesRequest">Container for the necessary parameters to execute the RebootInstances service method on
        ///          AmazonEC2.</param>
        /// 
        public RebootInstancesResponse RebootInstances(RebootInstancesRequest rebootInstancesRequest)
        {
            IAsyncResult asyncResult = invokeRebootInstances(rebootInstancesRequest, null, null, true);
            return EndRebootInstances(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the RebootInstances operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.RebootInstances"/>
        /// </summary>
        /// 
        /// <param name="rebootInstancesRequest">Container for the necessary parameters to execute the RebootInstances operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginRebootInstances(RebootInstancesRequest rebootInstancesRequest, AsyncCallback callback, object state)
        {
            return invokeRebootInstances(rebootInstancesRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the RebootInstances operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.RebootInstances"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRebootInstances.</param>
        public RebootInstancesResponse EndRebootInstances(IAsyncResult asyncResult)
        {
            return endOperation<RebootInstancesResponse>(asyncResult);
        }
        
        IAsyncResult invokeRebootInstances(RebootInstancesRequest rebootInstancesRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new RebootInstancesRequestMarshaller().Marshall(rebootInstancesRequest);
            var unmarshaller = RebootInstancesResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region RegisterImage

        /// <summary>
        /// <para> The RegisterImage operation registers an AMI with Amazon EC2. Images must be registered before they can be launched. For more
        /// information, see RunInstances. </para> <para> Each AMI is associated with an unique ID which is provided by the Amazon EC2 service through
        /// the RegisterImage operation. During registration, Amazon EC2 retrieves the specified image manifest from Amazon S3 and verifies that the
        /// image is owned by the user registering the image. </para> <para> The image manifest is retrieved once and stored within the Amazon EC2. Any
        /// modifications to an image in Amazon S3 invalidates this registration. If you make changes to an image, deregister the previous image and
        /// register the new image. For more information, see DeregisterImage. </para>
        /// </summary>
        /// 
        /// <param name="registerImageRequest">Container for the necessary parameters to execute the RegisterImage service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the RegisterImage service method, as returned by AmazonEC2.</returns>
        /// 
        public RegisterImageResponse RegisterImage(RegisterImageRequest registerImageRequest)
        {
            IAsyncResult asyncResult = invokeRegisterImage(registerImageRequest, null, null, true);
            return EndRegisterImage(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the RegisterImage operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.RegisterImage"/>
        /// </summary>
        /// 
        /// <param name="registerImageRequest">Container for the necessary parameters to execute the RegisterImage operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRegisterImage
        ///         operation.</returns>
        public IAsyncResult BeginRegisterImage(RegisterImageRequest registerImageRequest, AsyncCallback callback, object state)
        {
            return invokeRegisterImage(registerImageRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the RegisterImage operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.RegisterImage"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRegisterImage.</param>
        /// 
        /// <returns>Returns a RegisterImageResult from AmazonEC2.</returns>
        public RegisterImageResponse EndRegisterImage(IAsyncResult asyncResult)
        {
            return endOperation<RegisterImageResponse>(asyncResult);
        }
        
        IAsyncResult invokeRegisterImage(RegisterImageRequest registerImageRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new RegisterImageRequestMarshaller().Marshall(registerImageRequest);
            var unmarshaller = RegisterImageResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region ReleaseAddress

        /// <summary>
        /// <para> The ReleaseAddress operation releases an elastic IP address associated with your account. </para> <para><b>NOTE:</b> Releasing an IP
        /// address automatically disassociates it from any instance with which it is associated. For more information, see DisassociateAddress. </para>
        /// <para><b>IMPORTANT:</b> After releasing an elastic IP address, it is released to the IP address pool and might no longer be available to
        /// your account. Make sure to update your DNS records and any servers or devices that communicate with the address. If you run this operation
        /// on an elastic IP address that is already released, the address might be assigned to another account which will cause Amazon EC2 to return an
        /// error. </para>
        /// </summary>
        /// 
        /// <param name="releaseAddressRequest">Container for the necessary parameters to execute the ReleaseAddress service method on
        ///          AmazonEC2.</param>
        /// 
        public ReleaseAddressResponse ReleaseAddress(ReleaseAddressRequest releaseAddressRequest)
        {
            IAsyncResult asyncResult = invokeReleaseAddress(releaseAddressRequest, null, null, true);
            return EndReleaseAddress(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ReleaseAddress operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ReleaseAddress"/>
        /// </summary>
        /// 
        /// <param name="releaseAddressRequest">Container for the necessary parameters to execute the ReleaseAddress operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginReleaseAddress(ReleaseAddressRequest releaseAddressRequest, AsyncCallback callback, object state)
        {
            return invokeReleaseAddress(releaseAddressRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ReleaseAddress operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ReleaseAddress"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginReleaseAddress.</param>
        public ReleaseAddressResponse EndReleaseAddress(IAsyncResult asyncResult)
        {
            return endOperation<ReleaseAddressResponse>(asyncResult);
        }
        
        IAsyncResult invokeReleaseAddress(ReleaseAddressRequest releaseAddressRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ReleaseAddressRequestMarshaller().Marshall(releaseAddressRequest);
            var unmarshaller = ReleaseAddressResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region ReplaceNetworkAclAssociation

        /// <summary>
        /// <para> Changes which network ACL a subnet is associated with. By default when you create a subnet, it's automatically associated with the
        /// default network ACL. For more information about network ACLs, go to Network ACLs in the Amazon Virtual Private Cloud User Guide. </para>
        /// </summary>
        /// 
        /// <param name="replaceNetworkAclAssociationRequest">Container for the necessary parameters to execute the ReplaceNetworkAclAssociation service
        ///          method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the ReplaceNetworkAclAssociation service method, as returned by AmazonEC2.</returns>
        /// 
        public ReplaceNetworkAclAssociationResponse ReplaceNetworkAclAssociation(ReplaceNetworkAclAssociationRequest replaceNetworkAclAssociationRequest)
        {
            IAsyncResult asyncResult = invokeReplaceNetworkAclAssociation(replaceNetworkAclAssociationRequest, null, null, true);
            return EndReplaceNetworkAclAssociation(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ReplaceNetworkAclAssociation operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ReplaceNetworkAclAssociation"/>
        /// </summary>
        /// 
        /// <param name="replaceNetworkAclAssociationRequest">Container for the necessary parameters to execute the ReplaceNetworkAclAssociation
        ///          operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndReplaceNetworkAclAssociation operation.</returns>
        public IAsyncResult BeginReplaceNetworkAclAssociation(ReplaceNetworkAclAssociationRequest replaceNetworkAclAssociationRequest, AsyncCallback callback, object state)
        {
            return invokeReplaceNetworkAclAssociation(replaceNetworkAclAssociationRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ReplaceNetworkAclAssociation operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ReplaceNetworkAclAssociation"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginReplaceNetworkAclAssociation.</param>
        /// 
        /// <returns>Returns a ReplaceNetworkAclAssociationResult from AmazonEC2.</returns>
        public ReplaceNetworkAclAssociationResponse EndReplaceNetworkAclAssociation(IAsyncResult asyncResult)
        {
            return endOperation<ReplaceNetworkAclAssociationResponse>(asyncResult);
        }
        
        IAsyncResult invokeReplaceNetworkAclAssociation(ReplaceNetworkAclAssociationRequest replaceNetworkAclAssociationRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ReplaceNetworkAclAssociationRequestMarshaller().Marshall(replaceNetworkAclAssociationRequest);
            var unmarshaller = ReplaceNetworkAclAssociationResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region ReplaceNetworkAclEntry

        /// <summary>
        /// <para> Replaces an entry (i.e., rule) in a network ACL. For more information about network ACLs, go to Network ACLs in the Amazon Virtual
        /// Private Cloud User Guide. </para>
        /// </summary>
        /// 
        /// <param name="replaceNetworkAclEntryRequest">Container for the necessary parameters to execute the ReplaceNetworkAclEntry service method on
        ///          AmazonEC2.</param>
        /// 
        public ReplaceNetworkAclEntryResponse ReplaceNetworkAclEntry(ReplaceNetworkAclEntryRequest replaceNetworkAclEntryRequest)
        {
            IAsyncResult asyncResult = invokeReplaceNetworkAclEntry(replaceNetworkAclEntryRequest, null, null, true);
            return EndReplaceNetworkAclEntry(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ReplaceNetworkAclEntry operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ReplaceNetworkAclEntry"/>
        /// </summary>
        /// 
        /// <param name="replaceNetworkAclEntryRequest">Container for the necessary parameters to execute the ReplaceNetworkAclEntry operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginReplaceNetworkAclEntry(ReplaceNetworkAclEntryRequest replaceNetworkAclEntryRequest, AsyncCallback callback, object state)
        {
            return invokeReplaceNetworkAclEntry(replaceNetworkAclEntryRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ReplaceNetworkAclEntry operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ReplaceNetworkAclEntry"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginReplaceNetworkAclEntry.</param>
        public ReplaceNetworkAclEntryResponse EndReplaceNetworkAclEntry(IAsyncResult asyncResult)
        {
            return endOperation<ReplaceNetworkAclEntryResponse>(asyncResult);
        }
        
        IAsyncResult invokeReplaceNetworkAclEntry(ReplaceNetworkAclEntryRequest replaceNetworkAclEntryRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ReplaceNetworkAclEntryRequestMarshaller().Marshall(replaceNetworkAclEntryRequest);
            var unmarshaller = ReplaceNetworkAclEntryResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region ReplaceRoute

        /// <summary>
        /// <para> Replaces an existing route within a route table in a VPC. For more information about route tables, go to <a
        /// href="http://docs.amazonwebservices.com/AmazonVPC/latest/UserGuide/VPC_Route_Tables.html" >Route Tables</a> in the Amazon Virtual Private
        /// Cloud User Guide. </para>
        /// </summary>
        /// 
        /// <param name="replaceRouteRequest">Container for the necessary parameters to execute the ReplaceRoute service method on AmazonEC2.</param>
        /// 
        public ReplaceRouteResponse ReplaceRoute(ReplaceRouteRequest replaceRouteRequest)
        {
            IAsyncResult asyncResult = invokeReplaceRoute(replaceRouteRequest, null, null, true);
            return EndReplaceRoute(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ReplaceRoute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ReplaceRoute"/>
        /// </summary>
        /// 
        /// <param name="replaceRouteRequest">Container for the necessary parameters to execute the ReplaceRoute operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginReplaceRoute(ReplaceRouteRequest replaceRouteRequest, AsyncCallback callback, object state)
        {
            return invokeReplaceRoute(replaceRouteRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ReplaceRoute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ReplaceRoute"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginReplaceRoute.</param>
        public ReplaceRouteResponse EndReplaceRoute(IAsyncResult asyncResult)
        {
            return endOperation<ReplaceRouteResponse>(asyncResult);
        }
        
        IAsyncResult invokeReplaceRoute(ReplaceRouteRequest replaceRouteRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ReplaceRouteRequestMarshaller().Marshall(replaceRouteRequest);
            var unmarshaller = ReplaceRouteResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region ReplaceRouteTableAssociation

        /// <summary>
        /// <para> Changes the route table associated with a given subnet in a VPC. After you execute this action, the subnet uses the routes in the new
        /// route table it's associated with. For more information about route tables, go to <a
        /// href="http://docs.amazonwebservices.com/AmazonVPC/latest/UserGuide/VPC_Route_Tables.html" >Route Tables</a> in the Amazon Virtual Private
        /// Cloud User Guide. </para> <para> You can also use this to change which table is the main route table in the VPC. You just specify the main
        /// route table's association ID and the route table that you want to be the new main route table. </para>
        /// </summary>
        /// 
        /// <param name="replaceRouteTableAssociationRequest">Container for the necessary parameters to execute the ReplaceRouteTableAssociation service
        ///          method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the ReplaceRouteTableAssociation service method, as returned by AmazonEC2.</returns>
        /// 
        public ReplaceRouteTableAssociationResponse ReplaceRouteTableAssociation(ReplaceRouteTableAssociationRequest replaceRouteTableAssociationRequest)
        {
            IAsyncResult asyncResult = invokeReplaceRouteTableAssociation(replaceRouteTableAssociationRequest, null, null, true);
            return EndReplaceRouteTableAssociation(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ReplaceRouteTableAssociation operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ReplaceRouteTableAssociation"/>
        /// </summary>
        /// 
        /// <param name="replaceRouteTableAssociationRequest">Container for the necessary parameters to execute the ReplaceRouteTableAssociation
        ///          operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndReplaceRouteTableAssociation operation.</returns>
        public IAsyncResult BeginReplaceRouteTableAssociation(ReplaceRouteTableAssociationRequest replaceRouteTableAssociationRequest, AsyncCallback callback, object state)
        {
            return invokeReplaceRouteTableAssociation(replaceRouteTableAssociationRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ReplaceRouteTableAssociation operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ReplaceRouteTableAssociation"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginReplaceRouteTableAssociation.</param>
        /// 
        /// <returns>Returns a ReplaceRouteTableAssociationResult from AmazonEC2.</returns>
        public ReplaceRouteTableAssociationResponse EndReplaceRouteTableAssociation(IAsyncResult asyncResult)
        {
            return endOperation<ReplaceRouteTableAssociationResponse>(asyncResult);
        }
        
        IAsyncResult invokeReplaceRouteTableAssociation(ReplaceRouteTableAssociationRequest replaceRouteTableAssociationRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ReplaceRouteTableAssociationRequestMarshaller().Marshall(replaceRouteTableAssociationRequest);
            var unmarshaller = ReplaceRouteTableAssociationResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region ReportInstanceStatus

        /// <summary>
        /// </summary>
        /// 
        /// <param name="reportInstanceStatusRequest">Container for the necessary parameters to execute the ReportInstanceStatus service method on
        ///          AmazonEC2.</param>
        /// 
        public ReportInstanceStatusResponse ReportInstanceStatus(ReportInstanceStatusRequest reportInstanceStatusRequest)
        {
            IAsyncResult asyncResult = invokeReportInstanceStatus(reportInstanceStatusRequest, null, null, true);
            return EndReportInstanceStatus(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ReportInstanceStatus operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ReportInstanceStatus"/>
        /// </summary>
        /// 
        /// <param name="reportInstanceStatusRequest">Container for the necessary parameters to execute the ReportInstanceStatus operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginReportInstanceStatus(ReportInstanceStatusRequest reportInstanceStatusRequest, AsyncCallback callback, object state)
        {
            return invokeReportInstanceStatus(reportInstanceStatusRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ReportInstanceStatus operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ReportInstanceStatus"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginReportInstanceStatus.</param>
        public ReportInstanceStatusResponse EndReportInstanceStatus(IAsyncResult asyncResult)
        {
            return endOperation<ReportInstanceStatusResponse>(asyncResult);
        }
        
        IAsyncResult invokeReportInstanceStatus(ReportInstanceStatusRequest reportInstanceStatusRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ReportInstanceStatusRequestMarshaller().Marshall(reportInstanceStatusRequest);
            var unmarshaller = ReportInstanceStatusResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region RequestSpotInstances

        /// <summary>
        /// <para> Creates a Spot Instance request. </para> <para> Spot Instances are instances that Amazon EC2 starts on your behalf when the maximum
        /// price that you specify exceeds the current Spot Price. Amazon EC2 periodically sets the Spot Price based on available Spot Instance capacity
        /// and current spot instance requests. </para> <para> For conceptual information about Spot Instances, refer to the Amazon Elastic Compute
        /// Cloud Developer Guide or Amazon Elastic Compute Cloud User Guide. </para>
        /// </summary>
        /// 
        /// <param name="requestSpotInstancesRequest">Container for the necessary parameters to execute the RequestSpotInstances service method on
        ///          AmazonEC2.</param>
        /// 
        /// <returns>The response from the RequestSpotInstances service method, as returned by AmazonEC2.</returns>
        /// 
        public RequestSpotInstancesResponse RequestSpotInstances(RequestSpotInstancesRequest requestSpotInstancesRequest)
        {
            IAsyncResult asyncResult = invokeRequestSpotInstances(requestSpotInstancesRequest, null, null, true);
            return EndRequestSpotInstances(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the RequestSpotInstances operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.RequestSpotInstances"/>
        /// </summary>
        /// 
        /// <param name="requestSpotInstancesRequest">Container for the necessary parameters to execute the RequestSpotInstances operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndRequestSpotInstances operation.</returns>
        public IAsyncResult BeginRequestSpotInstances(RequestSpotInstancesRequest requestSpotInstancesRequest, AsyncCallback callback, object state)
        {
            return invokeRequestSpotInstances(requestSpotInstancesRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the RequestSpotInstances operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.RequestSpotInstances"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRequestSpotInstances.</param>
        /// 
        /// <returns>Returns a RequestSpotInstancesResult from AmazonEC2.</returns>
        public RequestSpotInstancesResponse EndRequestSpotInstances(IAsyncResult asyncResult)
        {
            return endOperation<RequestSpotInstancesResponse>(asyncResult);
        }
        
        IAsyncResult invokeRequestSpotInstances(RequestSpotInstancesRequest requestSpotInstancesRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new RequestSpotInstancesRequestMarshaller().Marshall(requestSpotInstancesRequest);
            var unmarshaller = RequestSpotInstancesResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region ResetImageAttribute

        /// <summary>
        /// <para> The ResetImageAttribute operation resets an attribute of an AMI to its default value. </para> <para><b>NOTE:</b> The productCodes
        /// attribute cannot be reset. </para>
        /// </summary>
        /// 
        /// <param name="resetImageAttributeRequest">Container for the necessary parameters to execute the ResetImageAttribute service method on
        ///          AmazonEC2.</param>
        /// 
        public ResetImageAttributeResponse ResetImageAttribute(ResetImageAttributeRequest resetImageAttributeRequest)
        {
            IAsyncResult asyncResult = invokeResetImageAttribute(resetImageAttributeRequest, null, null, true);
            return EndResetImageAttribute(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ResetImageAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ResetImageAttribute"/>
        /// </summary>
        /// 
        /// <param name="resetImageAttributeRequest">Container for the necessary parameters to execute the ResetImageAttribute operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginResetImageAttribute(ResetImageAttributeRequest resetImageAttributeRequest, AsyncCallback callback, object state)
        {
            return invokeResetImageAttribute(resetImageAttributeRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ResetImageAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ResetImageAttribute"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResetImageAttribute.</param>
        public ResetImageAttributeResponse EndResetImageAttribute(IAsyncResult asyncResult)
        {
            return endOperation<ResetImageAttributeResponse>(asyncResult);
        }
        
        IAsyncResult invokeResetImageAttribute(ResetImageAttributeRequest resetImageAttributeRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ResetImageAttributeRequestMarshaller().Marshall(resetImageAttributeRequest);
            var unmarshaller = ResetImageAttributeResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region ResetInstanceAttribute

        /// <summary>
        /// <para> Resets an attribute of an instance to its default value. </para>
        /// </summary>
        /// 
        /// <param name="resetInstanceAttributeRequest">Container for the necessary parameters to execute the ResetInstanceAttribute service method on
        ///          AmazonEC2.</param>
        /// 
        public ResetInstanceAttributeResponse ResetInstanceAttribute(ResetInstanceAttributeRequest resetInstanceAttributeRequest)
        {
            IAsyncResult asyncResult = invokeResetInstanceAttribute(resetInstanceAttributeRequest, null, null, true);
            return EndResetInstanceAttribute(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ResetInstanceAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ResetInstanceAttribute"/>
        /// </summary>
        /// 
        /// <param name="resetInstanceAttributeRequest">Container for the necessary parameters to execute the ResetInstanceAttribute operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginResetInstanceAttribute(ResetInstanceAttributeRequest resetInstanceAttributeRequest, AsyncCallback callback, object state)
        {
            return invokeResetInstanceAttribute(resetInstanceAttributeRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ResetInstanceAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ResetInstanceAttribute"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResetInstanceAttribute.</param>
        public ResetInstanceAttributeResponse EndResetInstanceAttribute(IAsyncResult asyncResult)
        {
            return endOperation<ResetInstanceAttributeResponse>(asyncResult);
        }
        
        IAsyncResult invokeResetInstanceAttribute(ResetInstanceAttributeRequest resetInstanceAttributeRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ResetInstanceAttributeRequestMarshaller().Marshall(resetInstanceAttributeRequest);
            var unmarshaller = ResetInstanceAttributeResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region ResetNetworkInterfaceAttribute

        /// <summary>
        /// </summary>
        /// 
        /// <param name="resetNetworkInterfaceAttributeRequest">Container for the necessary parameters to execute the ResetNetworkInterfaceAttribute
        ///          service method on AmazonEC2.</param>
        /// 
        public ResetNetworkInterfaceAttributeResponse ResetNetworkInterfaceAttribute(ResetNetworkInterfaceAttributeRequest resetNetworkInterfaceAttributeRequest)
        {
            IAsyncResult asyncResult = invokeResetNetworkInterfaceAttribute(resetNetworkInterfaceAttributeRequest, null, null, true);
            return EndResetNetworkInterfaceAttribute(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ResetNetworkInterfaceAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ResetNetworkInterfaceAttribute"/>
        /// </summary>
        /// 
        /// <param name="resetNetworkInterfaceAttributeRequest">Container for the necessary parameters to execute the ResetNetworkInterfaceAttribute
        ///          operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginResetNetworkInterfaceAttribute(ResetNetworkInterfaceAttributeRequest resetNetworkInterfaceAttributeRequest, AsyncCallback callback, object state)
        {
            return invokeResetNetworkInterfaceAttribute(resetNetworkInterfaceAttributeRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ResetNetworkInterfaceAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ResetNetworkInterfaceAttribute"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResetNetworkInterfaceAttribute.</param>
        public ResetNetworkInterfaceAttributeResponse EndResetNetworkInterfaceAttribute(IAsyncResult asyncResult)
        {
            return endOperation<ResetNetworkInterfaceAttributeResponse>(asyncResult);
        }
        
        IAsyncResult invokeResetNetworkInterfaceAttribute(ResetNetworkInterfaceAttributeRequest resetNetworkInterfaceAttributeRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ResetNetworkInterfaceAttributeRequestMarshaller().Marshall(resetNetworkInterfaceAttributeRequest);
            var unmarshaller = ResetNetworkInterfaceAttributeResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region ResetSnapshotAttribute

        /// <summary>
        /// <para> Resets permission settings for the specified snapshot. </para>
        /// </summary>
        /// 
        /// <param name="resetSnapshotAttributeRequest">Container for the necessary parameters to execute the ResetSnapshotAttribute service method on
        ///          AmazonEC2.</param>
        /// 
        public ResetSnapshotAttributeResponse ResetSnapshotAttribute(ResetSnapshotAttributeRequest resetSnapshotAttributeRequest)
        {
            IAsyncResult asyncResult = invokeResetSnapshotAttribute(resetSnapshotAttributeRequest, null, null, true);
            return EndResetSnapshotAttribute(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the ResetSnapshotAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ResetSnapshotAttribute"/>
        /// </summary>
        /// 
        /// <param name="resetSnapshotAttributeRequest">Container for the necessary parameters to execute the ResetSnapshotAttribute operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginResetSnapshotAttribute(ResetSnapshotAttributeRequest resetSnapshotAttributeRequest, AsyncCallback callback, object state)
        {
            return invokeResetSnapshotAttribute(resetSnapshotAttributeRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the ResetSnapshotAttribute operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.ResetSnapshotAttribute"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginResetSnapshotAttribute.</param>
        public ResetSnapshotAttributeResponse EndResetSnapshotAttribute(IAsyncResult asyncResult)
        {
            return endOperation<ResetSnapshotAttributeResponse>(asyncResult);
        }
        
        IAsyncResult invokeResetSnapshotAttribute(ResetSnapshotAttributeRequest resetSnapshotAttributeRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new ResetSnapshotAttributeRequestMarshaller().Marshall(resetSnapshotAttributeRequest);
            var unmarshaller = ResetSnapshotAttributeResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region RevokeSecurityGroupEgress

        /// <summary>
        /// <para> This action applies only to security groups in a VPC. It doesn't work with EC2 security groups. For information about Amazon Virtual
        /// Private Cloud and VPC security groups, go to the Amazon Virtual Private Cloud User Guide. </para> <para> The action removes one or more
        /// egress rules from a VPC security group. The values that you specify in the revoke request (e.g., ports, etc.) must match the existing rule's
        /// values in order for the rule to be revoked. </para> <para> Each rule consists of the protocol, and the CIDR range or destination security
        /// group. For the TCP and UDP protocols, you must also specify the destination port or range of ports. For the ICMP protocol, you must also
        /// specify the ICMP type and code. </para> <para> Rule changes are propagated to instances within the security group as quickly as possible.
        /// However, a small delay might occur. </para>
        /// </summary>
        /// 
        /// <param name="revokeSecurityGroupEgressRequest">Container for the necessary parameters to execute the RevokeSecurityGroupEgress service
        ///          method on AmazonEC2.</param>
        /// 
        public RevokeSecurityGroupEgressResponse RevokeSecurityGroupEgress(RevokeSecurityGroupEgressRequest revokeSecurityGroupEgressRequest)
        {
            IAsyncResult asyncResult = invokeRevokeSecurityGroupEgress(revokeSecurityGroupEgressRequest, null, null, true);
            return EndRevokeSecurityGroupEgress(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the RevokeSecurityGroupEgress operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.RevokeSecurityGroupEgress"/>
        /// </summary>
        /// 
        /// <param name="revokeSecurityGroupEgressRequest">Container for the necessary parameters to execute the RevokeSecurityGroupEgress operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginRevokeSecurityGroupEgress(RevokeSecurityGroupEgressRequest revokeSecurityGroupEgressRequest, AsyncCallback callback, object state)
        {
            return invokeRevokeSecurityGroupEgress(revokeSecurityGroupEgressRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the RevokeSecurityGroupEgress operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.RevokeSecurityGroupEgress"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRevokeSecurityGroupEgress.</param>
        public RevokeSecurityGroupEgressResponse EndRevokeSecurityGroupEgress(IAsyncResult asyncResult)
        {
            return endOperation<RevokeSecurityGroupEgressResponse>(asyncResult);
        }
        
        IAsyncResult invokeRevokeSecurityGroupEgress(RevokeSecurityGroupEgressRequest revokeSecurityGroupEgressRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new RevokeSecurityGroupEgressRequestMarshaller().Marshall(revokeSecurityGroupEgressRequest);
            var unmarshaller = RevokeSecurityGroupEgressResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region RevokeSecurityGroupIngress

        /// <summary>
        /// <para> The RevokeSecurityGroupIngress operation revokes permissions from a security group. The permissions used to revoke must be specified
        /// using the same values used to grant the permissions. </para> <para> Permissions are specified by IP protocol (TCP, UDP, or ICMP), the source
        /// of the request (by IP range or an Amazon EC2 user-group pair), the source and destination port ranges (for TCP and UDP), and the ICMP codes
        /// and types (for ICMP). </para> <para> Permission changes are quickly propagated to instances within the security group. However, depending on
        /// the number of instances in the group, a small delay might occur. </para>
        /// </summary>
        /// 
        /// <param name="revokeSecurityGroupIngressRequest">Container for the necessary parameters to execute the RevokeSecurityGroupIngress service
        ///          method on AmazonEC2.</param>
        /// 
        public RevokeSecurityGroupIngressResponse RevokeSecurityGroupIngress(RevokeSecurityGroupIngressRequest revokeSecurityGroupIngressRequest)
        {
            IAsyncResult asyncResult = invokeRevokeSecurityGroupIngress(revokeSecurityGroupIngressRequest, null, null, true);
            return EndRevokeSecurityGroupIngress(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the RevokeSecurityGroupIngress operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.RevokeSecurityGroupIngress"/>
        /// </summary>
        /// 
        /// <param name="revokeSecurityGroupIngressRequest">Container for the necessary parameters to execute the RevokeSecurityGroupIngress operation
        ///          on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginRevokeSecurityGroupIngress(RevokeSecurityGroupIngressRequest revokeSecurityGroupIngressRequest, AsyncCallback callback, object state)
        {
            return invokeRevokeSecurityGroupIngress(revokeSecurityGroupIngressRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the RevokeSecurityGroupIngress operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.RevokeSecurityGroupIngress"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRevokeSecurityGroupIngress.</param>
        public RevokeSecurityGroupIngressResponse EndRevokeSecurityGroupIngress(IAsyncResult asyncResult)
        {
            return endOperation<RevokeSecurityGroupIngressResponse>(asyncResult);
        }
        
        IAsyncResult invokeRevokeSecurityGroupIngress(RevokeSecurityGroupIngressRequest revokeSecurityGroupIngressRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new RevokeSecurityGroupIngressRequestMarshaller().Marshall(revokeSecurityGroupIngressRequest);
            var unmarshaller = RevokeSecurityGroupIngressResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region RunInstances

        /// <summary>
        /// <para> The RunInstances operation launches a specified number of instances. </para> <para> If Amazon EC2 cannot launch the minimum number
        /// AMIs you request, no instances launch. If there is insufficient capacity to launch the maximum number of AMIs you request, Amazon EC2
        /// launches as many as possible to satisfy the requested maximum values. </para> <para> Every instance is launched in a security group. If you
        /// do not specify a security group at launch, the instances start in your default security group. For more information on creating security
        /// groups, see CreateSecurityGroup. </para> <para> An optional instance type can be specified. For information about instance types, see
        /// Instance Types. </para> <para> You can provide an optional key pair ID for each image in the launch request (for more information, see
        /// CreateKeyPair). All instances that are created from images that use this key pair will have access to the associated public key at boot. You
        /// can use this key to provide secure access to an instance of an image on a per-instance basis. Amazon EC2 public images use this feature to
        /// provide secure access without passwords. </para> <para><b>IMPORTANT:</b> Launching public images without a key pair ID will leave them
        /// inaccessible. The public key material is made available to the instance at boot time by placing it in the openssh_id.pub file on a logical
        /// device that is exposed to the instance as /dev/sda2 (the ephemeral store). The format of this file is suitable for use as an entry within
        /// ~/.ssh/authorized_keys (the OpenSSH format). This can be done at boot (e.g., as part of rc.local) allowing for secure access without
        /// passwords. Optional user data can be provided in the launch request. All instances that collectively comprise the launch request have access
        /// to this data For more information, see Instance Metadata. </para> <para><b>NOTE:</b> If any of the AMIs have a product code attached for
        /// which the user has not subscribed, the RunInstances call will fail. </para> <para><b>IMPORTANT:</b> We strongly recommend using the 2.6.18
        /// Xen stock kernel with the c1.medium and c1.xlarge instances. Although the default Amazon EC2 kernels will work, the new kernels provide
        /// greater stability and performance for these instance types. For more information about kernels, see Kernels, RAM Disks, and Block Device
        /// Mappings. </para>
        /// </summary>
        /// 
        /// <param name="runInstancesRequest">Container for the necessary parameters to execute the RunInstances service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the RunInstances service method, as returned by AmazonEC2.</returns>
        /// 
        public RunInstancesResponse RunInstances(RunInstancesRequest runInstancesRequest)
        {
            IAsyncResult asyncResult = invokeRunInstances(runInstancesRequest, null, null, true);
            return EndRunInstances(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the RunInstances operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.RunInstances"/>
        /// </summary>
        /// 
        /// <param name="runInstancesRequest">Container for the necessary parameters to execute the RunInstances operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndRunInstances
        ///         operation.</returns>
        public IAsyncResult BeginRunInstances(RunInstancesRequest runInstancesRequest, AsyncCallback callback, object state)
        {
            return invokeRunInstances(runInstancesRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the RunInstances operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.RunInstances"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginRunInstances.</param>
        /// 
        /// <returns>Returns a RunInstancesResult from AmazonEC2.</returns>
        public RunInstancesResponse EndRunInstances(IAsyncResult asyncResult)
        {
            return endOperation<RunInstancesResponse>(asyncResult);
        }
        
        IAsyncResult invokeRunInstances(RunInstancesRequest runInstancesRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new RunInstancesRequestMarshaller().Marshall(runInstancesRequest);
            var unmarshaller = RunInstancesResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region StartInstances

        /// <summary>
        /// <para> Starts an instance that uses an Amazon EBS volume as its root device. Instances that use Amazon EBS volumes as their root devices can
        /// be quickly stopped and started. When an instance is stopped, the compute resources are released and you are not billed for hourly instance
        /// usage. However, your root partition Amazon EBS volume remains, continues to persist your data, and you are charged for Amazon EBS volume
        /// usage. You can restart your instance at any time. </para> <para><b>NOTE:</b> Performing this operation on an instance that uses an instance
        /// store as its root device returns an error. </para>
        /// </summary>
        /// 
        /// <param name="startInstancesRequest">Container for the necessary parameters to execute the StartInstances service method on
        ///          AmazonEC2.</param>
        /// 
        /// <returns>The response from the StartInstances service method, as returned by AmazonEC2.</returns>
        /// 
        public StartInstancesResponse StartInstances(StartInstancesRequest startInstancesRequest)
        {
            IAsyncResult asyncResult = invokeStartInstances(startInstancesRequest, null, null, true);
            return EndStartInstances(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the StartInstances operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.StartInstances"/>
        /// </summary>
        /// 
        /// <param name="startInstancesRequest">Container for the necessary parameters to execute the StartInstances operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStartInstances
        ///         operation.</returns>
        public IAsyncResult BeginStartInstances(StartInstancesRequest startInstancesRequest, AsyncCallback callback, object state)
        {
            return invokeStartInstances(startInstancesRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the StartInstances operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.StartInstances"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStartInstances.</param>
        /// 
        /// <returns>Returns a StartInstancesResult from AmazonEC2.</returns>
        public StartInstancesResponse EndStartInstances(IAsyncResult asyncResult)
        {
            return endOperation<StartInstancesResponse>(asyncResult);
        }
        
        IAsyncResult invokeStartInstances(StartInstancesRequest startInstancesRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new StartInstancesRequestMarshaller().Marshall(startInstancesRequest);
            var unmarshaller = StartInstancesResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region StopInstances

        /// <summary>
        /// <para> Stops an instance that uses an Amazon EBS volume as its root device. Instances that use Amazon EBS volumes as their root devices can
        /// be quickly stopped and started. When an instance is stopped, the compute resources are released and you are not billed for hourly instance
        /// usage. However, your root partition Amazon EBS volume remains, continues to persist your data, and you are charged for Amazon EBS volume
        /// usage. You can restart your instance at any time. </para> <para><b>NOTE:</b> Before stopping an instance, make sure it is in a state from
        /// which it can be restarted. Stopping an instance does not preserve data stored in RAM. Performing this operation on an instance that uses an
        /// instance store as its root device returns an error. </para>
        /// </summary>
        /// 
        /// <param name="stopInstancesRequest">Container for the necessary parameters to execute the StopInstances service method on AmazonEC2.</param>
        /// 
        /// <returns>The response from the StopInstances service method, as returned by AmazonEC2.</returns>
        /// 
        public StopInstancesResponse StopInstances(StopInstancesRequest stopInstancesRequest)
        {
            IAsyncResult asyncResult = invokeStopInstances(stopInstancesRequest, null, null, true);
            return EndStopInstances(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the StopInstances operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.StopInstances"/>
        /// </summary>
        /// 
        /// <param name="stopInstancesRequest">Container for the necessary parameters to execute the StopInstances operation on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking EndStopInstances
        ///         operation.</returns>
        public IAsyncResult BeginStopInstances(StopInstancesRequest stopInstancesRequest, AsyncCallback callback, object state)
        {
            return invokeStopInstances(stopInstancesRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the StopInstances operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.StopInstances"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginStopInstances.</param>
        /// 
        /// <returns>Returns a StopInstancesResult from AmazonEC2.</returns>
        public StopInstancesResponse EndStopInstances(IAsyncResult asyncResult)
        {
            return endOperation<StopInstancesResponse>(asyncResult);
        }
        
        IAsyncResult invokeStopInstances(StopInstancesRequest stopInstancesRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new StopInstancesRequestMarshaller().Marshall(stopInstancesRequest);
            var unmarshaller = StopInstancesResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region TerminateInstances

        /// <summary>
        /// <para> The TerminateInstances operation shuts down one or more instances. This operation is idempotent; if you terminate an instance more
        /// than once, each call will succeed. </para> <para> Terminated instances will remain visible after termination (approximately one hour).
        /// </para>
        /// </summary>
        /// 
        /// <param name="terminateInstancesRequest">Container for the necessary parameters to execute the TerminateInstances service method on
        ///          AmazonEC2.</param>
        /// 
        /// <returns>The response from the TerminateInstances service method, as returned by AmazonEC2.</returns>
        /// 
        public TerminateInstancesResponse TerminateInstances(TerminateInstancesRequest terminateInstancesRequest)
        {
            IAsyncResult asyncResult = invokeTerminateInstances(terminateInstancesRequest, null, null, true);
            return EndTerminateInstances(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the TerminateInstances operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.TerminateInstances"/>
        /// </summary>
        /// 
        /// <param name="terminateInstancesRequest">Container for the necessary parameters to execute the TerminateInstances operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndTerminateInstances operation.</returns>
        public IAsyncResult BeginTerminateInstances(TerminateInstancesRequest terminateInstancesRequest, AsyncCallback callback, object state)
        {
            return invokeTerminateInstances(terminateInstancesRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the TerminateInstances operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.TerminateInstances"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginTerminateInstances.</param>
        /// 
        /// <returns>Returns a TerminateInstancesResult from AmazonEC2.</returns>
        public TerminateInstancesResponse EndTerminateInstances(IAsyncResult asyncResult)
        {
            return endOperation<TerminateInstancesResponse>(asyncResult);
        }
        
        IAsyncResult invokeTerminateInstances(TerminateInstancesRequest terminateInstancesRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new TerminateInstancesRequestMarshaller().Marshall(terminateInstancesRequest);
            var unmarshaller = TerminateInstancesResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region UnassignPrivateIpAddresses

        /// <summary>
        /// </summary>
        /// 
        /// <param name="unassignPrivateIpAddressesRequest">Container for the necessary parameters to execute the UnassignPrivateIpAddresses service
        ///          method on AmazonEC2.</param>
        /// 
        public UnassignPrivateIpAddressesResponse UnassignPrivateIpAddresses(UnassignPrivateIpAddressesRequest unassignPrivateIpAddressesRequest)
        {
            IAsyncResult asyncResult = invokeUnassignPrivateIpAddresses(unassignPrivateIpAddressesRequest, null, null, true);
            return EndUnassignPrivateIpAddresses(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the UnassignPrivateIpAddresses operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.UnassignPrivateIpAddresses"/>
        /// </summary>
        /// 
        /// <param name="unassignPrivateIpAddressesRequest">Container for the necessary parameters to execute the UnassignPrivateIpAddresses operation
        ///          on AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        public IAsyncResult BeginUnassignPrivateIpAddresses(UnassignPrivateIpAddressesRequest unassignPrivateIpAddressesRequest, AsyncCallback callback, object state)
        {
            return invokeUnassignPrivateIpAddresses(unassignPrivateIpAddressesRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the UnassignPrivateIpAddresses operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.UnassignPrivateIpAddresses"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUnassignPrivateIpAddresses.</param>
        public UnassignPrivateIpAddressesResponse EndUnassignPrivateIpAddresses(IAsyncResult asyncResult)
        {
            return endOperation<UnassignPrivateIpAddressesResponse>(asyncResult);
        }
        
        IAsyncResult invokeUnassignPrivateIpAddresses(UnassignPrivateIpAddressesRequest unassignPrivateIpAddressesRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new UnassignPrivateIpAddressesRequestMarshaller().Marshall(unassignPrivateIpAddressesRequest);
            var unmarshaller = UnassignPrivateIpAddressesResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
        #region UnmonitorInstances

        /// <summary>
        /// <para> Disables monitoring for a running instance. </para>
        /// </summary>
        /// 
        /// <param name="unmonitorInstancesRequest">Container for the necessary parameters to execute the UnmonitorInstances service method on
        ///          AmazonEC2.</param>
        /// 
        /// <returns>The response from the UnmonitorInstances service method, as returned by AmazonEC2.</returns>
        /// 
        public UnmonitorInstancesResponse UnmonitorInstances(UnmonitorInstancesRequest unmonitorInstancesRequest)
        {
            IAsyncResult asyncResult = invokeUnmonitorInstances(unmonitorInstancesRequest, null, null, true);
            return EndUnmonitorInstances(asyncResult);
        }

        

        /// <summary>
        /// Initiates the asynchronous execution of the UnmonitorInstances operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.UnmonitorInstances"/>
        /// </summary>
        /// 
        /// <param name="unmonitorInstancesRequest">Container for the necessary parameters to execute the UnmonitorInstances operation on
        ///          AmazonEC2.</param>
        /// <param name="callback">An AsyncCallback delegate that is invoked when the operation completes.</param>
        /// <param name="state">A user-defined state object that is passed to the callback procedure. Retrieve this object from within the callback
        ///          procedure using the AsyncState property.</param>
        /// 
        /// <returns>An IAsyncResult that can be used to poll or wait for results, or both; this value is also needed when invoking
        ///         EndUnmonitorInstances operation.</returns>
        public IAsyncResult BeginUnmonitorInstances(UnmonitorInstancesRequest unmonitorInstancesRequest, AsyncCallback callback, object state)
        {
            return invokeUnmonitorInstances(unmonitorInstancesRequest, callback, state, false);
        }

        

        /// <summary>
        /// Finishes the asynchronous execution of the UnmonitorInstances operation.
        /// <seealso cref="Amazon.EC2.IAmazonEC2.UnmonitorInstances"/>
        /// </summary>
        /// 
        /// <param name="asyncResult">The IAsyncResult returned by the call to BeginUnmonitorInstances.</param>
        /// 
        /// <returns>Returns a UnmonitorInstancesResult from AmazonEC2.</returns>
        public UnmonitorInstancesResponse EndUnmonitorInstances(IAsyncResult asyncResult)
        {
            return endOperation<UnmonitorInstancesResponse>(asyncResult);
        }
        
        IAsyncResult invokeUnmonitorInstances(UnmonitorInstancesRequest unmonitorInstancesRequest, AsyncCallback callback, object state, bool synchronized)
        {
            IRequest irequest = new UnmonitorInstancesRequestMarshaller().Marshall(unmonitorInstancesRequest);
            var unmarshaller = UnmonitorInstancesResponseUnmarshaller.GetInstance();
            AsyncResult result = new AsyncResult(irequest, callback, state, synchronized, signer, unmarshaller);
            Invoke(result);
            return result;
        }
        
        

        #endregion
    
    }
}
    
