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
    /// Amazon Elastic Compute Cloud <para>Amazon Elastic Compute Cloud (Amazon EC2) provides resizable computing capacity in the Amazon Web
    /// Services (AWS) cloud. Using Amazon EC2 eliminates your need to invest in hardware up front, so you can develop and deploy applications
    /// faster.</para>
    /// </summary>
    public partial class AmazonEC2Client : AmazonWebServiceClient, IAmazonEC2
    {
    EC2Signer signer = new EC2Signer();

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
        /// <para>Acquires an Elastic IP address.</para> <para>An Elastic IP address is for use either in the EC2-Classic platform or in a VPC. For more
        /// information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/elastic-ip-addresses-eip.html" >Elastic IP Addresses</a> in the
        /// <i>Amazon Elastic Compute Cloud User Guide</i> .</para>
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
        /// <para>Acquires an Elastic IP address.</para> <para>An Elastic IP address is for use either in the EC2-Classic platform or in a VPC. For more
        /// information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/elastic-ip-addresses-eip.html" >Elastic IP Addresses</a> in the
        /// <i>Amazon Elastic Compute Cloud User Guide</i> .</para>
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
        /// <para>Assigns one or more secondary private IP addresses to the specified network interface. You can specify one or more specific secondary
        /// IP addresses, or you can specify the number of secondary IP addresses to be automatically assigned within the subnet's CIDR block range. The
        /// number of secondary IP addresses that you can assign to an instance varies by instance type. For information about instance types, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/instance-types.html" >Instance Types</a> in the <i>Amazon Elastic Compute Cloud
        /// User Guide</i> . For more information about Elastic IP addresses, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/elastic-ip-addresses-eip.html" >Elastic IP Addresses</a> in the <i>Amazon Elastic
        /// Compute Cloud User Guide</i> .</para> <para>AssignPrivateIpAddresses is available only in EC2-VPC.</para>
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
        /// <para>Associates an Elastic IP address with an instance or a network interface.</para> <para>An Elastic IP address is for use in either the
        /// EC2-Classic platform or in a VPC. For more information, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/elastic-ip-addresses-eip.html" >Elastic IP Addresses</a> in the <i>Amazon Elastic
        /// Compute Cloud User Guide</i> .</para> <para>[EC2-Classic, default VPC] If the Elastic IP address is already associated with a different
        /// instance, it is disassociated from that instance and associated with the specified instance.</para> <para>[EC2-VPC] If you don't specify a
        /// private IP address, the Elastic IP address is associated with the primary IP address. If the Elastic IP address is already associated with a
        /// different instance or a network interface, you get an error unless you allow reassociation.</para> <para>This is an idempotent operation. If
        /// you perform the operation more than once, Amazon EC2 doesn't return an error.</para>
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
        /// <para>Associates a set of DHCP options (that you've previously created) with the specified VPC, or associates no DHCP options with the
        /// VPC.</para> <para>After you associate the options with the VPC, any existing instances and all new instances that you launch in that VPC use
        /// the options. You don't need to restart or relaunch the instances. They automatically pick up the changes within a few hours, depending on
        /// how frequently the instance renews its DHCP lease. You can explicitly renew the lease using the operating system on the instance.</para>
        /// <para>For more information, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_DHCP_Options.html" >DHCP Options Sets</a>
        /// in the <i>Amazon Virtual Private Cloud User Guide</i> .</para>
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
        /// <para>Associates a subnet with a route table. The subnet and route table must be in the same VPC. This association causes traffic
        /// originating from the subnet to be routed according to the routes in the route table. The action returns an association ID, which you need in
        /// order to disassociate the route table from the subnet later. A route table can be associated with multiple subnets.</para> <para>For more
        /// information about route tables, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Route_Tables.html" >Route Tables</a>
        /// in the <i>Amazon Virtual Private Cloud User Guide</i> .</para>
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
        /// <para>Attaches an Internet gateway to a VPC, enabling connectivity between the Internet and the VPC. For more information about your VPC and
        /// Internet gateway, see the <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/" >Amazon Virtual Private Cloud User Guide</a>
        /// .</para>
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
        /// <para>Attaches a network interface to an instance.</para>
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
        /// <para>Attaches an Amazon EBS volume to a running or stopped instance and exposes it to the instance with the specified device name.</para>
        /// <para>For a list of supported device names, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-attaching-volume.html"
        /// >Attaching an Amazon EBS Volume to an Instance</a> . Any device names that aren't reserved for instance store volumes can be used for Amazon
        /// EBS volumes. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/InstanceStorage.html" >Amazon EC2
        /// Instance Store</a> in the <i>Amazon Elastic Compute Cloud User Guide</i> .</para> <para>If a volume has an AWS Marketplace product
        /// code:</para>
        /// <ul>
        /// <li>The volume can only be attached as the root device of a stopped instance.</li>
        /// <li>You must be subscribed to the AWS Marketplace code that is on the volume.</li>
        /// <li>The configuration (instance type, operating system) of the instance must support that specific AWS Marketplace code. For example, you
        /// cannot take a volume from a Windows instance and attach it to a Linux instance.</li>
        /// <li>AWS Marketplace product codes are copied from the volume to the instance.</li>
        /// 
        /// </ul>
        /// <para>For an overview of the AWS Marketplace, see <a href="https://aws.amazon.com/marketplace/help/200900000"
        /// >https://aws.amazon.com/marketplace/help/200900000</a> . For more information about how to use the AWS Marketplace, see <a
        /// href="https://aws.amazon.com/marketplace" >AWS Marketplace</a> .</para> <para>For more information about Amazon EBS volumes, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-attaching-volume.html" >Attaching Amazon EBS Volumes</a> in the <i>Amazon
        /// Elastic Compute Cloud User Guide</i> .</para>
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
        /// <para>Attaches a virtual private gateway to a VPC. For more information, see <a
        /// href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_VPN.html" >Adding a Hardware Virtual Private Gateway to Your VPC</a> in the
        /// <i>Amazon Virtual Private Cloud User Guide</i> .</para>
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
        /// <para>Adds one or more egress rules to a security group for use with a VPC. Specifically, this action permits instances to send traffic to
        /// one or more CIDR IP address ranges, or to one or more security groups for the same VPC.</para> <para><b>IMPORTANT:</b> You can have up to 50
        /// rules per security group (covering both ingress and egress rules). </para> <para>A security group is for use with instances either in the
        /// EC2-Classic platform or in a specific VPC. This action doesn't apply to security groups for use in EC2-Classic. For more information, see <a
        /// href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_SecurityGroups.html" >Security Groups for Your VPC</a> in the <i>Amazon
        /// Virtual Private Cloud User Guide</i> .</para> <para>Each rule consists of the protocol (for example, TCP), plus either a CIDR range or a
        /// source group. For the TCP and UDP protocols, you must also specify the destination port or port range. For the ICMP protocol, you must also
        /// specify the ICMP type and code. You can use -1 for the type or code to mean all types or all codes.</para> <para>Rule changes are propagated
        /// to affected instances as quickly as possible. However, a small delay might occur.</para>
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
        /// <para>Adds one or more ingress rules to a security group.</para> <para><b>IMPORTANT:</b> EC2-Classic: You can have up to 100 rules per
        /// group. EC2-VPC: You can have up to 50 rules per group (covering both ingress and egress rules). </para> <para>Rule changes are propagated to
        /// instances within the security group as quickly as possible. However, a small delay might occur.</para> <para>[EC2-Classic] This action gives
        /// one or more CIDR IP address ranges permission to access a security group in your account, or gives one or more security groups (called the
        /// <i>source groups</i> ) permission to access a security group for your account. A source group can be for your own AWS account, or
        /// another.</para> <para>[EC2-VPC] This action gives one or more CIDR IP address ranges permission to access a security group in your VPC, or
        /// gives one or more other security groups (called the <i>source groups</i> ) permission to access a security group for your VPC. The security
        /// groups must all be for the same VPC.</para>
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
        /// <para>Bundles an Amazon instance store-backed Windows instance.</para> <para>During bundling, only the root device volume (C:\) is bundled.
        /// Data on other instance store volumes is not preserved.</para> <para><b>NOTE:</b> This procedure is not applicable for Linux/Unix instances
        /// or Windows instances that are backed by Amazon EBS. </para> <para>For more information, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/WindowsGuide/Creating_InstanceStoreBacked_WinAMI.html" >Creating an Instance Store-Backed
        /// Windows AMI</a> .</para>
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
        /// <para>Cancels a bundling operation for an instance store-backed Windows instance.</para>
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
        /// <para>Cancels an active conversion task. The task can be the import of an instance or volume. The action removes all artifacts of the
        /// conversion, including a partially uploaded volume or instance. If the conversion is complete or is in the process of transferring the final
        /// disk image, the command fails and returns an exception.</para> <para>For more information, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/UploadingYourInstancesandVolumes.html" >Using the Command Line Tools to Import Your
        /// Virtual Machine to Amazon EC2</a> in the <i>Amazon Elastic Compute Cloud User Guide</i> .</para>
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
        /// <para>Cancels an active export task. The request removes all artifacts of the export, including any partially-created Amazon S3 objects. If
        /// the export task is complete or is in the process of transferring the final disk image, the command fails and returns an error.</para>
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
        /// <para>Cancels the specified Reserved Instance listing in the Reserved Instance Marketplace.</para> <para>For more information, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ri-market-general.html" >Reserved Instance Marketplace</a> in the <i>Amazon Elastic
        /// Compute Cloud User Guide</i> .</para>
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
        /// <para>Cancels one or more Spot Instance requests. Spot Instances are instances that Amazon EC2 starts on your behalf when the maximum price
        /// that you specify exceeds the current Spot Price. Amazon EC2 periodically sets the Spot Price based on available Spot Instance capacity and
        /// current Spot Instance requests. For more information about Spot Instances, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-spot-instances.html" >Spot Instances</a> in the <i>Amazon Elastic Compute
        /// Cloud User Guide</i> .</para> <para><b>IMPORTANT:</b> Canceling a Spot Instance request does not terminate running Spot Instances associated
        /// with the request. </para>
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
        /// <para>Determines whether a product code is associated with an instance. This action can only be used by the owner of the product code. It is
        /// useful when a product code owner needs to verify whether another user's instance is eligible for support.</para>
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
        /// <para>Initiates the copy of an AMI from the specified source region to the region in which the request was made.</para> <para>For more
        /// information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/CopyingAMIs.html" >Copying AMIs</a> in the <i>Amazon Elastic
        /// Compute Cloud User Guide</i> .</para>
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
        /// <para>Copies a point-in-time snapshot of an Amazon EBS volume and stores it in Amazon S3. You can copy the snapshot within the same region
        /// or from one region to another. You can use the snapshot to create Amazon EBS volumes or Amazon Machine Images (AMIs).</para> <para>For more
        /// information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-copy-snapshot.html" >Copying an Amazon EBS Snapshot</a> in
        /// the <i>Amazon Elastic Compute Cloud User Guide</i> .</para>
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
        /// <para>Provides information to AWS about your VPN customer gateway device. The customer gateway is the appliance at your end of the VPN
        /// connection. (The device on the AWS side of the VPN connection is the virtual private gateway.) You must provide the Internet-routable IP
        /// address of the customer gateway's external interface. The IP address must be static and can't be behind a device performing network address
        /// translation (NAT).</para> <para>For devices that use Border Gateway Protocol (BGP), you can also provide the device's BGP Autonomous System
        /// Number (ASN). You can use an existing ASN assigned to your network. If you don't have an ASN already, you can use a private ASN (in the
        /// 64512 - 65534 range).</para> <para><b>NOTE:</b> Amazon EC2 supports all 2-byte ASN numbers in the range of 1 - 65534, with the exception of
        /// 7224, which is reserved in the us-east-1 region, and 9059, which is reserved in the eu-west-1 region. </para> <para>For more information
        /// about VPN customer gateways, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_VPN.html" >Adding a Hardware Virtual
        /// Private Gateway to Your VPC</a> in the <i>Amazon Virtual Private Cloud User Guide</i> .</para>
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
        /// <para>Creates a set of DHCP options for your VPC. After creating the set, you must associate it with the VPC, causing all existing and new
        /// instances that you launch in the VPC to use this set of DHCP options. The following are the individual DHCP options you can specify. For
        /// more information about the options, see <a href="http://www.ietf.org/rfc/rfc2132.txt" >RFC 2132</a> .</para> <para>For more information
        /// about DHCP options, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_DHCP_Options.html" >DHCP Options Sets</a> in the
        /// <i>Amazon Virtual Private Cloud User Guide</i> .</para>
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
        /// <para>Creates an Amazon EBS-backed AMI from an Amazon EBS-backed instance that is either running or stopped.</para> <para>If you customized
        /// your instance with instance store volumes or EBS volumes in addition to the root device volume, the new AMI contains block device mapping
        /// information for those volumes. When you launch an instance from this new AMI, the instance automatically launches with those additional
        /// volumes.</para> <para>For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/creating-an-ami-ebs.html"
        /// >Creating Amazon EBS-Backed Linux AMIs</a> in the <i>Amazon Elastic Compute Cloud User Guide</i> .</para>
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
        /// <para>Exports a running or stopped instance to an Amazon S3 bucket.</para> <para>For information about the supported operating systems,
        /// image formats, and known limitations for the types of instances you can export, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ExportingEC2Instances.html" >Exporting EC2 Instances</a> in the <i>Amazon Elastic
        /// Compute Cloud User Guide</i> .</para>
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
        /// <para>Creates an Internet gateway for use with a VPC. After creating the Internet gateway, you attach it to a VPC using
        /// AttachInternetGateway.</para> <para>For more information about your VPC and Internet gateway, see the <a
        /// href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/" >Amazon Virtual Private Cloud User Guide</a> .</para>
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
        /// <para>Creates an Internet gateway for use with a VPC. After creating the Internet gateway, you attach it to a VPC using
        /// AttachInternetGateway.</para> <para>For more information about your VPC and Internet gateway, see the <a
        /// href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/" >Amazon Virtual Private Cloud User Guide</a> .</para>
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
        /// <para>Creates a 2048-bit RSA key pair with the specified name. Amazon EC2 stores the public key and displays the private key for you to save
        /// to a file. The private key is returned as an unencrypted PEM encoded PKCS#8 private key. If a key with the specified name already exists,
        /// Amazon EC2 returns an error.</para> <para>You can have up to five thousand key pairs per region.</para> <para>For more information about key
        /// pairs, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-key-pairs.html" >Key Pairs</a> in the <i>Amazon Elastic Compute
        /// Cloud User Guide</i> .</para>
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
        /// <para>Creates a network ACL in a VPC. Network ACLs provide an optional layer of security (in addition to security groups) for the instances
        /// in your VPC.</para> <para>For more information about network ACLs, see <a
        /// href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_ACLs.html" >Network ACLs</a> in the <i>Amazon Virtual Private Cloud User
        /// Guide</i> .</para>
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
        /// <para>Creates an entry (a rule) in a network ACL with the specified rule number. Each network ACL has a set of numbered ingress rules and a
        /// separate set of numbered egress rules. When determining whether a packet should be allowed in or out of a subnet associated with the ACL, we
        /// process the entries in the ACL according to the rule numbers, in ascending order. Each network ACL has a set of ingress rules and a separate
        /// set of egress rules.</para> <para>We recommend that you leave room between the rule numbers (for example, 100, 110, 120, ...), and not
        /// number them one right after the other (for example, 101, 102, 103, ...). This makes it easier to add a rule between existing ones without
        /// having to renumber the rules.</para> <para>After you add an entry, you can't modify it; you must either replace it, or create an entry and
        /// delete the old one.</para> <para>For more information about network ACLs, see <a
        /// href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_ACLs.html" >Network ACLs</a> in the <i>Amazon Virtual Private Cloud User
        /// Guide</i> .</para>
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
        /// <para>Creates a network interface in the specified subnet.</para> <para>For more information about network interfaces, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-eni.html" >Elastic Network Interfaces</a> in the <i>Amazon Elastic Compute
        /// Cloud User Guide</i> .</para>
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
        /// <para>Creates a placement group that you launch cluster instances into. You must give the group a name that's unique within the scope of
        /// your account.</para> <para>For more information about placement groups and cluster instances, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using_cluster_computing.html" >Cluster Instances</a> in the <i>Amazon Elastic
        /// Compute Cloud User Guide</i> .</para>
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
        /// <para>Creates a listing for Amazon EC2 Reserved Instances to be sold in the Reserved Instance Marketplace. You can submit one Reserved
        /// Instance listing at a time.</para> <para>For more information, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ri-market-general.html" >Reserved Instance Marketplace</a> in the <i>Amazon Elastic
        /// Compute Cloud User Guide</i> .</para>
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
        /// <para>Creates a route in a route table within a VPC.</para> <para>You must specify one of the following targets: Internet gateway, NAT
        /// instance, or network interface.</para> <para>When determining how to route traffic, we use the route with the most specific match. For
        /// example, let's say the traffic is destined for <c>192.0.2.3</c> , and the route table includes the following two routes:</para>
        /// <ul>
        /// <li> <para> <c>192.0.2.0/24</c> (goes to some target A)</para> </li>
        /// <li> <para> <c>192.0.2.0/28</c> (goes to some target B)</para> </li>
        /// 
        /// </ul>
        /// <para>Both routes apply to the traffic destined for <c>192.0.2.3</c> . However, the second route in the list covers a smaller number of IP
        /// addresses and is therefore more specific, so we use that route to determine where to target the traffic.</para> <para>For more information
        /// about route tables, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Route_Tables.html" >Route Tables</a> in the
        /// <i>Amazon Virtual Private Cloud User Guide</i> .</para>
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
        /// <para>Creates a route table for the specified VPC. After you create a route table, you can add routes and associate the table with a
        /// subnet.</para> <para>For more information about route tables, see <a
        /// href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Route_Tables.html" >Route Tables</a> in the <i>Amazon Virtual Private Cloud
        /// User Guide</i> .</para>
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
        /// <para>Creates a security group.</para> <para>A security group is for use with instances either in the EC2-Classic platform or in a specific
        /// VPC. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-network-security.html" >Amazon EC2 Security
        /// Groups</a> in the <i>Amazon Elastic Compute Cloud User Guide</i> and <a
        /// href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_SecurityGroups.html" >Security Groups for Your VPC</a> in the <i>Amazon
        /// Virtual Private Cloud User Guide</i> .</para> <para><b>IMPORTANT:</b> EC2-Classic: You can have up to 500 security groups. EC2-VPC: You can
        /// create up to 100 security groups per VPC. </para> <para>When you create a security group, you specify a friendly name of your choice. You
        /// can have a security group for use in EC2-Classic with the same name as a security group for use in a VPC. However, you can't have two
        /// security groups for use in EC2-Classic with the same name or two security groups for use in a VPC with the same name.</para> <para>You have
        /// a default security group for use in EC2-Classic and a default security group for use in your VPC. If you don't specify a security group when
        /// you launch an instance, the instance is launched into the appropriate default security group. A default security group includes a default
        /// rule that grants instances unrestricted network access to each other.</para> <para>You can add or remove rules from your security groups
        /// using AuthorizeSecurityGroupIngress, AuthorizeSecurityGroupEgress, RevokeSecurityGroupIngress, and RevokeSecurityGroupEgress.</para>
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
        /// <para>Creates a snapshot of an Amazon EBS volume and stores it in Amazon S3. You can use snapshots for backups, to make copies of Amazon EBS
        /// volumes, and to save data before shutting down an instance.</para> <para>When a snapshot is created, any AWS Marketplace product codes that
        /// are associated with the source volume are propagated to the snapshot.</para> <para>You can take a snapshot of an attached volume that is in
        /// use. However, snapshots only capture data that has been written to your Amazon EBS volume at the time the snapshot command is issued; this
        /// may exclude any data that has been cached by any applications or the operating system. If you can pause any file writes to the volume long
        /// enough to take a snapshot, your snapshot should be complete. However, if you cannot pause all file writes to the volume, you should unmount
        /// the volume from within the instance, issue the snapshot command, and then remount the volume to ensure a consistent and complete snapshot.
        /// You may remount and use your volume while the snapshot status is <c>pending</c> .</para> <para>To create a snapshot for Amazon EBS volumes
        /// that serve as root devices, you should stop the instance before taking the snapshot.</para> <para>For more information, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-creating-snapshot.html" >Creating an Amazon EBS Snapshot</a> in the <i>Amazon
        /// Elastic Compute Cloud User Guide</i> .</para>
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
        /// <para>Creates a datafeed for Spot Instances, enabling you to view Spot Instance usage logs. You can create one data feed per AWS account.
        /// For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-spot-instances.html" >Spot Instances</a> in the
        /// <i>Amazon Elastic Compute Cloud User Guide</i> .</para>
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
        /// <para>Creates a subnet in an existing VPC.</para> <para>When you create each subnet, you provide the VPC ID and the CIDR block you want for
        /// the subnet. After you create a subnet, you can't change its CIDR block. The subnet's CIDR block can be the same as the VPC's CIDR block
        /// (assuming you want only a single subnet in the VPC), or a subset of the VPC's CIDR block. If you create more than one subnet in a VPC, the
        /// subnets' CIDR blocks must not overlap. The smallest subnet (and VPC) you can create uses a /28 netmask (16 IP addresses), and the largest
        /// uses a /16 netmask (65,536 IP addresses).</para> <para><b>IMPORTANT:</b> AWS reserves both the first four and the last IP address in each
        /// subnet's CIDR block. They're not available for use. </para> <para>If you add more than one subnet to a VPC, they're set up in a star
        /// topology with a logical router in the middle.</para> <para>For more information about subnets, see <a
        /// href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Subnets.html" >Your VPC and Subnets</a> in the <i>Amazon Virtual Private
        /// Cloud User Guide</i> .</para>
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
        /// <para>Adds or overwrites one or more tags for the specified EC2 resource or resources. Each resource can have a maximum of 10 tags. Each tag
        /// consists of a key and optional value. Tag keys must be unique per resource.</para> <para>For more information about tags, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_Tags.html" >Tagging Your Resources</a> in the <i>Amazon Elastic Compute Cloud
        /// User Guide</i> .</para>
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
        /// <para>Creates an Amazon EBS volume that can be attached to any instance in the same Availability Zone.</para> <para>Any AWS Marketplace
        /// product codes from the snapshot are propagated to the volume.</para> <para>For more information, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-creating-volume.html" >Creating or Restoring an Amazon EBS Volume</a> in the
        /// <i>Amazon Elastic Compute Cloud User Guide</i> .</para>
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
        /// <para>Creates a VPC with the specified CIDR block.</para> <para>The smallest VPC you can create uses a /28 netmask (16 IP addresses), and
        /// the largest uses a /16 netmask (65,536 IP addresses). To help you decide how big to make your VPC, see <a
        /// href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Subnets.html" >Your VPC and Subnets</a> in the <i>Amazon Virtual Private
        /// Cloud User Guide</i> .</para> <para>By default, each instance you launch in the VPC has the default DHCP options, which includes only a
        /// default DNS server that we provide (AmazonProvidedDNS). For more information about DHCP options, see <a
        /// href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_DHCP_Options.html" >DHCP Options Sets</a> in the <i>Amazon Virtual Private
        /// Cloud User Guide</i> .</para>
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
        /// <para>Creates a VPN connection between an existing virtual private gateway and a VPN customer gateway. The only supported connection type is
        /// <c>ipsec.1</c> .</para> <para>The response includes information that you need to give to your network administrator to configure your
        /// customer gateway.</para> <para><b>IMPORTANT:</b> We strongly recommend that you use HTTPS when calling this operation because the response
        /// contains sensitive cryptographic information for configuring your customer gateway. </para> <para>If you decide to shut down your VPN
        /// connection for any reason and later create a new VPN connection, you must reconfigure your customer gateway with the new information
        /// returned from this call.</para> <para>For more information about VPN connections, see <a
        /// href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_VPN.html" >Adding a Hardware Virtual Private Gateway to Your VPC</a> in the
        /// <i>Amazon Virtual Private Cloud User Guide</i> .</para>
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
        /// <para>Creates a static route associated with a VPN connection between an existing virtual private gateway and a VPN customer gateway. The
        /// static route allows traffic to be routed from the virtual private gateway to the VPN customer gateway.</para> <para>For more information
        /// about VPN connections, see <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_VPN.html" >Adding a Hardware Virtual Private
        /// Gateway to Your VPC</a> in the <i>Amazon Virtual Private Cloud User Guide</i> .</para>
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
        /// <para>Creates a virtual private gateway. A virtual private gateway is the endpoint on the VPC side of your VPN connection. You can create a
        /// virtual private gateway before creating the VPC itself.</para> <para>For more information about virtual private gateways, see <a
        /// href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_VPN.html" >Adding a Hardware Virtual Private Gateway to Your VPC</a> in the
        /// <i>Amazon Virtual Private Cloud User Guide</i> .</para>
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
        /// <para>Deletes the specified customer gateway. You must delete the VPN connection before you can delete the customer gateway.</para>
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
        /// <para>Deletes the specified set of DHCP options. You must disassociate the set of DHCP options before you can delete it. You can
        /// disassociate the set of DHCP options by associating either a new set of options or the default set of options with the VPC.</para>
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
        /// <para>Deletes the specified Internet gateway. You must detach the Internet gateway from the VPC before you can delete it.</para>
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
        /// <para>Deletes the specified key pair, by removing the public key from Amazon EC2.</para>
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
        /// <para>Deletes the specified network ACL. You can't delete the ACL if it's associated with any subnets. You can't delete the default network
        /// ACL.</para>
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
        /// <para>Deletes the specified ingress or egress entry (rule) from the specified network ACL.</para>
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
        /// <para>Deletes the specified network interface. You must detach the network interface before you can delete it.</para>
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
        /// <para>Deletes the specified placement group. You must terminate all instances in the placement group before you can delete the placement
        /// group. For more information about placement groups and cluster instances, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using_cluster_computing.html" >Cluster Instances</a> in the <i>Amazon Elastic
        /// Compute Cloud User Guide</i> .</para>
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
        /// <para>Deletes the specified route from the specified route table.</para>
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
        /// <para>Deletes the specified route table. You must disassociate the route table from any subnets before you can delete it. You can't delete
        /// the main route table.</para>
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
        /// <para>Deletes a security group.</para> <para>If you attempt to delete a security group that is associated with an instance, or is referenced
        /// by another security group, the operation fails with <c>InvalidGroup.InUse</c> in EC2-Classic or <c>DependencyViolation</c> in
        /// EC2-VPC.</para>
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
        /// <para>Deletes the specified snapshot.</para> <para>When you make periodic snapshots of a volume, the snapshots are incremental, and only the
        /// blocks on the device that have changed since your last snapshot are saved in the new snapshot. When you delete a snapshot, only the data not
        /// needed for any other snapshot is removed. So regardless of which prior snapshots have been deleted, all active snapshots will have access to
        /// all the information needed to restore the volume.</para> <para>You cannot delete a snapshot of the root device of an Amazon EBS volume used
        /// by a registered AMI. You must first de-register the AMI before you can delete the snapshot.</para> <para>For more information, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-deleting-snapshot.html" >Deleting an Amazon EBS Snapshot</a> in the <i>Amazon
        /// Elastic Compute Cloud User Guide</i> .</para>
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
        /// <para>Deletes the datafeed for Spot Instances. For more information, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-spot-instances.html" >Spot Instances</a> in the <i>Amazon Elastic Compute
        /// Cloud User Guide</i> .</para>
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
        /// <para>Deletes the datafeed for Spot Instances. For more information, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-spot-instances.html" >Spot Instances</a> in the <i>Amazon Elastic Compute
        /// Cloud User Guide</i> .</para>
        /// </summary>
        /// 
        public DeleteSpotDatafeedSubscriptionResponse DeleteSpotDatafeedSubscription()
        {
            return DeleteSpotDatafeedSubscription(new DeleteSpotDatafeedSubscriptionRequest());
        }
        

        #endregion
    
        #region DeleteSubnet

        /// <summary>
        /// <para>Deletes the specified subnet. You must terminate all running instances in the subnet before you can delete the subnet.</para>
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
        /// <para>Deletes the specified set of tags from the specified set of resources. This call is designed to follow a <c>DescribeTags</c>
        /// request.</para> <para>For more information about tags, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_Tags.html"
        /// >Tagging Your Resources</a> in the <i>Amazon Elastic Compute Cloud User Guide</i> .</para>
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
        /// <para>Deletes the specified Amazon EBS volume. The volume must be in the <c>available</c> state (not attached to an instance).</para>
        /// <para><b>NOTE:</b> The volume remains in the deleting state for several minutes. </para> <para>For more information, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-deleting-volume.html" >Deleting an Amazon EBS Volume</a> in the <i>Amazon
        /// Elastic Compute Cloud User Guide</i> .</para>
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
        /// <para>Deletes the specified VPC. You must detach or delete all gateways and resources that are associated with the VPC before you can delete
        /// it. For example, you must terminate all instances running in the VPC, delete all security groups associated with the VPC (except the default
        /// one), delete all route tables associated with the VPC (except the default one), and so on.</para>
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
        /// <para>Deletes the specified VPN connection.</para> <para>If you're deleting the VPC and its associated components, we recommend that you
        /// detach the virtual private gateway from the VPC and delete the VPC before deleting the VPN connection.</para>
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
        /// <para>Deletes the specified static route associated with a VPN connection between an existing virtual private gateway and a VPN customer
        /// gateway. The static route allows traffic to be routed from the virtual private gateway to the VPN customer gateway.</para>
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
        /// <para>Deletes the specified virtual private gateway. We recommend that before you delete a virtual private gateway, you detach it from the
        /// VPC and delete the VPN connection. Note that you don't need to delete the virtual private gateway if you plan to delete and recreate the VPN
        /// connection between your VPC and your network.</para>
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
        /// <para>Deregisters the specified AMI. After you deregister an AMI, it can't be used to launch new instances.</para> <para>This command does
        /// not delete the AMI.</para>
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
        /// <para>Describes the specified attribute of your AWS account.</para>
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
        /// <para>Describes the specified attribute of your AWS account.</para>
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
        /// <para>Describes one or more of your Elastic IP addresses.</para> <para>An Elastic IP address is for use in either the EC2-Classic platform
        /// or in a VPC. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/elastic-ip-addresses-eip.html" >Elastic
        /// IP Addresses</a> in the <i>Amazon Elastic Compute Cloud User Guide</i> .</para>
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
        /// <para>Describes one or more of your Elastic IP addresses.</para> <para>An Elastic IP address is for use in either the EC2-Classic platform
        /// or in a VPC. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/elastic-ip-addresses-eip.html" >Elastic
        /// IP Addresses</a> in the <i>Amazon Elastic Compute Cloud User Guide</i> .</para>
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
        /// <para>Describes one or more of the Availability Zones that are available to you. The results include zones only for the region you're
        /// currently using. If there is an event impacting an Availability Zone, you can use this request to view the state and any provided message
        /// for that Availability Zone.</para> <para>For more information, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-regions-availability-zones.html" >Regions and Availability Zones</a> in the
        /// <i>Amazon Elastic Compute Cloud User Guide</i> .</para>
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
        /// <para>Describes one or more of the Availability Zones that are available to you. The results include zones only for the region you're
        /// currently using. If there is an event impacting an Availability Zone, you can use this request to view the state and any provided message
        /// for that Availability Zone.</para> <para>For more information, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-regions-availability-zones.html" >Regions and Availability Zones</a> in the
        /// <i>Amazon Elastic Compute Cloud User Guide</i> .</para>
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
        /// <para>Describes one or more of your bundling tasks.</para> <para><b>NOTE:</b> Completed bundle tasks are listed for only a limited time. If
        /// your bundle task is no longer in the list, you can still register an AMI from it. Just use RegisterImage with the Amazon S3 bucket name and
        /// image manifest name you provided to the bundle task. </para>
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
        /// <para>Describes one or more of your bundling tasks.</para> <para><b>NOTE:</b> Completed bundle tasks are listed for only a limited time. If
        /// your bundle task is no longer in the list, you can still register an AMI from it. Just use RegisterImage with the Amazon S3 bucket name and
        /// image manifest name you provided to the bundle task. </para>
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
        /// <para>Describes one or more of your conversion tasks. For more information, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/UploadingYourInstancesandVolumes.html" >Using the Command Line Tools to Import Your
        /// Virtual Machine to Amazon EC2</a> in the <i>Amazon Elastic Compute Cloud User Guide</i> .</para>
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
        /// <para>Describes one or more of your conversion tasks. For more information, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/UploadingYourInstancesandVolumes.html" >Using the Command Line Tools to Import Your
        /// Virtual Machine to Amazon EC2</a> in the <i>Amazon Elastic Compute Cloud User Guide</i> .</para>
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
        /// <para>Describes one or more of your VPN customer gateways.</para> <para>For more information about VPN customer gateways, see <a
        /// href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_VPN.html" >Adding a Hardware Virtual Private Gateway to Your VPC</a> in the
        /// <i>Amazon Virtual Private Cloud User Guide</i> .</para>
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
        /// <para>Describes one or more of your VPN customer gateways.</para> <para>For more information about VPN customer gateways, see <a
        /// href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_VPN.html" >Adding a Hardware Virtual Private Gateway to Your VPC</a> in the
        /// <i>Amazon Virtual Private Cloud User Guide</i> .</para>
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
        /// <para>Describes one or more of your DHCP options sets.</para> <para>For more information about DHCP options sets, see <a
        /// href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_DHCP_Options.html" >DHCP Options Sets</a> in the <i>Amazon Virtual Private
        /// Cloud User Guide</i> .</para>
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
        /// <para>Describes one or more of your DHCP options sets.</para> <para>For more information about DHCP options sets, see <a
        /// href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_DHCP_Options.html" >DHCP Options Sets</a> in the <i>Amazon Virtual Private
        /// Cloud User Guide</i> .</para>
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
        /// <para>Describes one or more of your export tasks.</para>
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
        /// <para>Describes one or more of your export tasks.</para>
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
        /// <para>Describes an attributes of an AMI. You can specify only one attribute at a time.</para>
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
        /// <para>Describes one or more of the images (AMIs, AKIs, and ARIs) available to you. Images available to you include public images, private
        /// images that you own, and private images owned by other AWS accounts but for which you have explicit launch permissions.</para>
        /// <para><b>NOTE:</b> Deregistered images are included in the returned results for an unspecified interval after deregistration. </para>
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
        /// <para>Describes one or more of the images (AMIs, AKIs, and ARIs) available to you. Images available to you include public images, private
        /// images that you own, and private images owned by other AWS accounts but for which you have explicit launch permissions.</para>
        /// <para><b>NOTE:</b> Deregistered images are included in the returned results for an unspecified interval after deregistration. </para>
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
        /// <para>Describes an attribute of the specified instance. You can specify only one attribute at a time.</para>
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
        /// <para>Describes the status of one or more instances, including any scheduled events.</para> <para>Instance status has two main
        /// components:</para>
        /// <ul>
        /// <li> <para>System Status reports impaired functionality that stems from issues related to the systems that support an instance, such as
        /// such as hardware failures and network connectivity problems. This call reports such problems as impaired reachability.</para> </li>
        /// <li> <para>Instance Status reports impaired functionality that arises from problems internal to the instance. This call reports such
        /// problems as impaired reachability.</para> </li>
        /// 
        /// </ul>
        /// <para>Instance status provides information about four types of scheduled events for an instance that may require your attention:</para>
        /// <ul>
        /// <li> <para>Scheduled Reboot: When Amazon EC2 determines that an instance must be rebooted, the instances status returns one of two event
        /// codes: <c>system-reboot</c> or <c>instance-reboot</c> . System reboot commonly occurs if certain maintenance or upgrade operations require a
        /// reboot of the underlying host that supports an instance. Instance reboot commonly occurs if the instance must be rebooted, rather than the
        /// underlying host. Rebooting events include a scheduled start and end time.</para> </li>
        /// <li> <para>System Maintenance: When Amazon EC2 determines that an instance requires maintenance that requires power or network impact, the
        /// instance status is the event code <c>system-maintenance</c> . System maintenance is either power maintenance or network maintenance. For
        /// power maintenance, your instance will be unavailable for a brief period of time and then rebooted. For network maintenance, your instance
        /// will experience a brief loss of network connectivity. System maintenance events include a scheduled start and end time. You will also be
        /// notified by email if one of your instances is set for system maintenance. The email message indicates when your instance is scheduled for
        /// maintenance.</para> </li>
        /// <li> <para>Scheduled Retirement: When Amazon EC2 determines that an instance must be shut down, the instance status is the event code
        /// <c>instance-retirement</c> . Retirement commonly occurs when the underlying host is degraded and must be replaced. Retirement events include
        /// a scheduled start and end time. You will also be notified by email if one of your instances is set to retiring. The email message indicates
        /// when your instance will be permanently retired.</para> </li>
        /// <li> <para>Scheduled Stop: When Amazon EC2 determines that an instance must be shut down, the instances status returns an event code called
        /// <c>instance-stop</c> .
        /// Stop events include a scheduled start and end time. You will also be notified by email if one of your instances is set to stop. The
        /// email message indicates when your instance will be stopped.</para> </li>
        /// 
        /// </ul>
        /// <para>When your instance is retired, it will either be terminated (if its root device type is the instance-store) or stopped (if its root
        /// device type is an EBS volume). Instances stopped due to retirement will not be restarted, but you can do so manually. You can also avoid
        /// retirement of EBS-backed instances by manually restarting your instance when its event code is <c>instance-retirement</c> . This ensures
        /// that your instance is started on a different underlying host.</para>
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
        /// <para>Describes the status of one or more instances, including any scheduled events.</para> <para>Instance status has two main
        /// components:</para>
        /// <ul>
        /// <li> <para>System Status reports impaired functionality that stems from issues related to the systems that support an instance, such as
        /// such as hardware failures and network connectivity problems. This call reports such problems as impaired reachability.</para> </li>
        /// <li> <para>Instance Status reports impaired functionality that arises from problems internal to the instance. This call reports such
        /// problems as impaired reachability.</para> </li>
        /// 
        /// </ul>
        /// <para>Instance status provides information about four types of scheduled events for an instance that may require your attention:</para>
        /// <ul>
        /// <li> <para>Scheduled Reboot: When Amazon EC2 determines that an instance must be rebooted, the instances status returns one of two event
        /// codes: <c>system-reboot</c> or <c>instance-reboot</c> . System reboot commonly occurs if certain maintenance or upgrade operations require a
        /// reboot of the underlying host that supports an instance. Instance reboot commonly occurs if the instance must be rebooted, rather than the
        /// underlying host. Rebooting events include a scheduled start and end time.</para> </li>
        /// <li> <para>System Maintenance: When Amazon EC2 determines that an instance requires maintenance that requires power or network impact, the
        /// instance status is the event code <c>system-maintenance</c> . System maintenance is either power maintenance or network maintenance. For
        /// power maintenance, your instance will be unavailable for a brief period of time and then rebooted. For network maintenance, your instance
        /// will experience a brief loss of network connectivity. System maintenance events include a scheduled start and end time. You will also be
        /// notified by email if one of your instances is set for system maintenance. The email message indicates when your instance is scheduled for
        /// maintenance.</para> </li>
        /// <li> <para>Scheduled Retirement: When Amazon EC2 determines that an instance must be shut down, the instance status is the event code
        /// <c>instance-retirement</c> . Retirement commonly occurs when the underlying host is degraded and must be replaced. Retirement events include
        /// a scheduled start and end time. You will also be notified by email if one of your instances is set to retiring. The email message indicates
        /// when your instance will be permanently retired.</para> </li>
        /// <li> <para>Scheduled Stop: When Amazon EC2 determines that an instance must be shut down, the instances status returns an event code called
        /// <c>instance-stop</c> .
        /// Stop events include a scheduled start and end time. You will also be notified by email if one of your instances is set to stop. The
        /// email message indicates when your instance will be stopped.</para> </li>
        /// 
        /// </ul>
        /// <para>When your instance is retired, it will either be terminated (if its root device type is the instance-store) or stopped (if its root
        /// device type is an EBS volume). Instances stopped due to retirement will not be restarted, but you can do so manually. You can also avoid
        /// retirement of EBS-backed instances by manually restarting your instance when its event code is <c>instance-retirement</c> . This ensures
        /// that your instance is started on a different underlying host.</para>
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
        /// <para>Describes one or more of your instances.</para> <para>If you specify one or more instance IDs, Amazon EC2 returns information for
        /// those instances. If you do not specify instance IDs, Amazon EC2 returns information for all relevant instances. If you specify an instance
        /// ID that is not valid, an error is returned. If you specify an instance that you do not own, it is not included in the returned
        /// results.</para> <para>Recently terminated instances might appear in the returned results. This interval is usually less than one
        /// hour.</para>
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
        /// <para>Describes one or more of your instances.</para> <para>If you specify one or more instance IDs, Amazon EC2 returns information for
        /// those instances. If you do not specify instance IDs, Amazon EC2 returns information for all relevant instances. If you specify an instance
        /// ID that is not valid, an error is returned. If you specify an instance that you do not own, it is not included in the returned
        /// results.</para> <para>Recently terminated instances might appear in the returned results. This interval is usually less than one
        /// hour.</para>
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
        /// <para>Describes one or more of your Internet gateways.</para>
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
        /// <para>Describes one or more of your Internet gateways.</para>
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
        /// <para>Describes one or more of your key pairs.</para> <para>For more information about key pairs, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-key-pairs.html" >Key Pairs</a> in the <i>Amazon Elastic Compute Cloud User
        /// Guide</i> .</para>
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
        /// <para>Describes one or more of your key pairs.</para> <para>For more information about key pairs, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-key-pairs.html" >Key Pairs</a> in the <i>Amazon Elastic Compute Cloud User
        /// Guide</i> .</para>
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
        /// <para>Describes one or more of your network ACLs.</para> <para>For more information about network ACLs, see <a
        /// href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_ACLs.html" >Network ACLs</a> in the <i>Amazon Virtual Private Cloud User
        /// Guide</i> .</para>
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
        /// <para>Describes one or more of your network ACLs.</para> <para>For more information about network ACLs, see <a
        /// href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_ACLs.html" >Network ACLs</a> in the <i>Amazon Virtual Private Cloud User
        /// Guide</i> .</para>
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
        /// <para>Describes a network interface attribute. You can specify only one attribute at a time.</para>
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
        /// <para>Describes one or more of your network interfaces.</para>
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
        /// <para>Describes one or more of your network interfaces.</para>
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
        /// <para>Describes one or more of your placement groups. For more information about placement groups and cluster instances, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using_cluster_computing.html" >Cluster Instances</a> in the <i>Amazon Elastic
        /// Compute Cloud User Guide</i> .</para>
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
        /// <para>Describes one or more of your placement groups. For more information about placement groups and cluster instances, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using_cluster_computing.html" >Cluster Instances</a> in the <i>Amazon Elastic
        /// Compute Cloud User Guide</i> .</para>
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
        /// <para>Describes one or more regions that are currently available to you.</para> <para>For a list of the regions supported by Amazon EC2, see
        /// <a href="http://docs.aws.amazon.com/general/latest/gr/rande.html#ec2_region" >Regions and Endpoints</a> .</para>
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
        /// <para>Describes one or more regions that are currently available to you.</para> <para>For a list of the regions supported by Amazon EC2, see
        /// <a href="http://docs.aws.amazon.com/general/latest/gr/rande.html#ec2_region" >Regions and Endpoints</a> .</para>
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
        /// <para>Describes one or more of the Reserved Instances that you purchased.</para> <para>For more information about Reserved Instances, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/concepts-on-demand-reserved-instances.html" >Reserved Instances</a> in the
        /// <i>Amazon Elastic Compute Cloud User Guide</i> .</para>
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
        /// <para>Describes one or more of the Reserved Instances that you purchased.</para> <para>For more information about Reserved Instances, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/concepts-on-demand-reserved-instances.html" >Reserved Instances</a> in the
        /// <i>Amazon Elastic Compute Cloud User Guide</i> .</para>
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
        /// <para>Describes your account's Reserved Instance listings in the Reserved Instance Marketplace.</para> <para>For more information, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ri-market-general.html" >Reserved Instance Marketplace</a> in the <i>Amazon Elastic
        /// Compute Cloud User Guide</i> .</para>
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
        /// <para>Describes your account's Reserved Instance listings in the Reserved Instance Marketplace.</para> <para>For more information, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ri-market-general.html" >Reserved Instance Marketplace</a> in the <i>Amazon Elastic
        /// Compute Cloud User Guide</i> .</para>
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
        /// <para>Describes the modifications made to your Reserved Instances. If no parameter is specified, information about all your Reserved
        /// Instances modification requests is returned. If a modification ID is specified, only information about the specific modification is
        /// returned.</para>
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
        /// <para>Describes the modifications made to your Reserved Instances. If no parameter is specified, information about all your Reserved
        /// Instances modification requests is returned. If a modification ID is specified, only information about the specific modification is
        /// returned.</para>
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
        /// <para>Describes Reserved Instance offerings that are available for purchase. With Reserved Instances, you purchase the right to launch
        /// instances for a period of time. During that time period, you do not receive insufficient capacity errors, and you pay a lower usage rate
        /// than the rate charged for On-Demand instances for the actual time used.</para> <para>For more information, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ri-market-general.html" >Reserved Instance Marketplace</a> in the <i>Amazon Elastic
        /// Compute Cloud User Guide</i> .</para>
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
        /// <para>Describes Reserved Instance offerings that are available for purchase. With Reserved Instances, you purchase the right to launch
        /// instances for a period of time. During that time period, you do not receive insufficient capacity errors, and you pay a lower usage rate
        /// than the rate charged for On-Demand instances for the actual time used.</para> <para>For more information, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ri-market-general.html" >Reserved Instance Marketplace</a> in the <i>Amazon Elastic
        /// Compute Cloud User Guide</i> .</para>
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
        /// <para>Describes one or more of your route tables.</para> <para>For more information about route tables, see <a
        /// href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Route_Tables.html" >Route Tables</a> in the <i>Amazon Virtual Private Cloud
        /// User Guide</i> .</para>
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
        /// <para>Describes one or more of your route tables.</para> <para>For more information about route tables, see <a
        /// href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Route_Tables.html" >Route Tables</a> in the <i>Amazon Virtual Private Cloud
        /// User Guide</i> .</para>
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
        /// <para>Describes one or more of your security groups.</para> <para>A security group is for use with instances either in the EC2-Classic
        /// platform or in a specific VPC. For more information, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-network-security.html" >Amazon EC2 Security Groups</a> in the <i>Amazon
        /// Elastic Compute Cloud User Guide</i> and <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_SecurityGroups.html" >Security
        /// Groups for Your VPC</a> in the <i>Amazon Virtual Private Cloud User Guide</i> .</para>
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
        /// <para>Describes one or more of your security groups.</para> <para>A security group is for use with instances either in the EC2-Classic
        /// platform or in a specific VPC. For more information, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-network-security.html" >Amazon EC2 Security Groups</a> in the <i>Amazon
        /// Elastic Compute Cloud User Guide</i> and <a href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_SecurityGroups.html" >Security
        /// Groups for Your VPC</a> in the <i>Amazon Virtual Private Cloud User Guide</i> .</para>
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
        /// <para>Describes an attribute of the specified snapshot. You can specify only one attribute at a time.</para> <para>For more information
        /// about Amazon EBS snapshots, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSSnapshots.html" >Amazon EBS Snapshots</a> in
        /// the <i>Amazon Elastic Compute Cloud User Guide</i> .</para>
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
        /// <para>Describes one or more of the Amazon EBS snapshots available to you. Available snapshots include public snapshots available for any AWS
        /// account to launch, private snapshots that you own, and private snapshots owned by another AWS account but for which you've been given
        /// explicit create volume permissions.</para> <para>The create volume permissions fall into the following categories:</para>
        /// <ul>
        /// <li> <i>public</i> : The owner of the snapshot granted create volume permissions for the snapshot to the <c>all</c> group. All AWS accounts
        /// have create volume permissions for these snapshots.</li>
        /// <li> <i>explicit</i> : The owner of the snapshot granted create volume permissions to a specific AWS account.</li>
        /// <li> <i>implicit</i> : An AWS account has implicit create volume permissions for all snapshots it owns.</li>
        /// 
        /// </ul>
        /// <para>The list of snapshots returned can be modified by specifying snapshot IDs, snapshot owners, or AWS accounts with create volume
        /// permissions. If no options are specified, Amazon EC2 returns all snapshots for which you have create volume permissions.</para> <para>If you
        /// specify one or more snapshot IDs, only snapshots that have the specified IDs are returned. If you specify an invalid snapshot ID, an error
        /// is returned. If you specify a snapshot ID for which you do not have access, it is not included in the returned results.</para> <para>If you
        /// specify one or more snapshot owners, only snapshots from the specified owners and for which you have access are returned. The results can
        /// include the AWS account IDs of the specified owners, <c>amazon</c> for snapshots owned by Amazon, or <c>self</c> for snapshots that you
        /// own.</para> <para>If you specify a list of restorable users, only snapshots with create snapshot permissions for those users are returned.
        /// You can specify AWS account IDs (if you own the snapshots), <c>self</c> for snapshots for which you own or have explicit permissions, or
        /// <c>all</c> for public snapshots.</para> <para>For more information about Amazon EBS snapshots, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSSnapshots.html" >Amazon EBS Snapshots</a> in the <i>Amazon Elastic Compute Cloud
        /// User Guide</i> .</para>
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
        /// <para>Describes one or more of the Amazon EBS snapshots available to you. Available snapshots include public snapshots available for any AWS
        /// account to launch, private snapshots that you own, and private snapshots owned by another AWS account but for which you've been given
        /// explicit create volume permissions.</para> <para>The create volume permissions fall into the following categories:</para>
        /// <ul>
        /// <li> <i>public</i> : The owner of the snapshot granted create volume permissions for the snapshot to the <c>all</c> group. All AWS accounts
        /// have create volume permissions for these snapshots.</li>
        /// <li> <i>explicit</i> : The owner of the snapshot granted create volume permissions to a specific AWS account.</li>
        /// <li> <i>implicit</i> : An AWS account has implicit create volume permissions for all snapshots it owns.</li>
        /// 
        /// </ul>
        /// <para>The list of snapshots returned can be modified by specifying snapshot IDs, snapshot owners, or AWS accounts with create volume
        /// permissions. If no options are specified, Amazon EC2 returns all snapshots for which you have create volume permissions.</para> <para>If you
        /// specify one or more snapshot IDs, only snapshots that have the specified IDs are returned. If you specify an invalid snapshot ID, an error
        /// is returned. If you specify a snapshot ID for which you do not have access, it is not included in the returned results.</para> <para>If you
        /// specify one or more snapshot owners, only snapshots from the specified owners and for which you have access are returned. The results can
        /// include the AWS account IDs of the specified owners, <c>amazon</c> for snapshots owned by Amazon, or <c>self</c> for snapshots that you
        /// own.</para> <para>If you specify a list of restorable users, only snapshots with create snapshot permissions for those users are returned.
        /// You can specify AWS account IDs (if you own the snapshots), <c>self</c> for snapshots for which you own or have explicit permissions, or
        /// <c>all</c> for public snapshots.</para> <para>For more information about Amazon EBS snapshots, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSSnapshots.html" >Amazon EBS Snapshots</a> in the <i>Amazon Elastic Compute Cloud
        /// User Guide</i> .</para>
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
        /// <para>Describes the datafeed for Spot Instances. For more information, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-spot-instances.html" >Spot Instances</a> in the <i>Amazon Elastic Compute
        /// Cloud User Guide</i> .</para>
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
        /// <para>Describes the datafeed for Spot Instances. For more information, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-spot-instances.html" >Spot Instances</a> in the <i>Amazon Elastic Compute
        /// Cloud User Guide</i> .</para>
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
        /// <para>Describes the Spot Instance requests that belong to your account. Spot Instances are instances that Amazon EC2 starts on your behalf
        /// when the maximum price that you specify exceeds the current Spot Price. Amazon EC2 periodically sets the Spot Price based on available Spot
        /// Instance capacity and current Spot Instance requests. For more information about Spot Instances, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-spot-instances.html" >Spot Instances</a> in the <i>Amazon Elastic Compute
        /// Cloud User Guide</i> .</para> <para>You can use <c>DescribeSpotInstanceRequests</c> to find a running Spot Instance by examining the
        /// response. If the status of the Spot Instance is <c>fulfilled</c> , the instance ID appears in the response and contains the identifier of
        /// the instance. Alternatively, you can use DescribeInstances with a filter to look for instances where the instance lifecycle is <c>spot</c>
        /// .</para>
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
        /// <para>Describes the Spot Instance requests that belong to your account. Spot Instances are instances that Amazon EC2 starts on your behalf
        /// when the maximum price that you specify exceeds the current Spot Price. Amazon EC2 periodically sets the Spot Price based on available Spot
        /// Instance capacity and current Spot Instance requests. For more information about Spot Instances, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-spot-instances.html" >Spot Instances</a> in the <i>Amazon Elastic Compute
        /// Cloud User Guide</i> .</para> <para>You can use <c>DescribeSpotInstanceRequests</c> to find a running Spot Instance by examining the
        /// response. If the status of the Spot Instance is <c>fulfilled</c> , the instance ID appears in the response and contains the identifier of
        /// the instance. Alternatively, you can use DescribeInstances with a filter to look for instances where the instance lifecycle is <c>spot</c>
        /// .</para>
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
        /// <para>Describes the Spot Price history. Spot Instances are instances that Amazon EC2 starts on your behalf when the maximum price that you
        /// specify exceeds the current Spot Price. Amazon EC2 periodically sets the Spot Price based on available Spot Instance capacity and current
        /// Spot Instance requests. For more information about Spot Instances, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-spot-instances.html" >Spot Instances</a> in the <i>Amazon Elastic Compute
        /// Cloud User Guide</i> .</para> <para>When you specify an Availability Zone, this operation describes the price history for the specified
        /// Availability Zone with the most recent set of prices listed first. If you don't specify an Availability Zone, you get the prices across all
        /// Availability Zones, starting with the most recent set. However, if you're using an API version earlier than 2011-05-15, you get the lowest
        /// price across the region for the specified time period. The prices returned are listed in chronological order, from the oldest to the most
        /// recent.</para>
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
        /// <para>Describes the Spot Price history. Spot Instances are instances that Amazon EC2 starts on your behalf when the maximum price that you
        /// specify exceeds the current Spot Price. Amazon EC2 periodically sets the Spot Price based on available Spot Instance capacity and current
        /// Spot Instance requests. For more information about Spot Instances, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-spot-instances.html" >Spot Instances</a> in the <i>Amazon Elastic Compute
        /// Cloud User Guide</i> .</para> <para>When you specify an Availability Zone, this operation describes the price history for the specified
        /// Availability Zone with the most recent set of prices listed first. If you don't specify an Availability Zone, you get the prices across all
        /// Availability Zones, starting with the most recent set. However, if you're using an API version earlier than 2011-05-15, you get the lowest
        /// price across the region for the specified time period. The prices returned are listed in chronological order, from the oldest to the most
        /// recent.</para>
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
        /// <para>Describes one or more of your subnets.</para> <para>For more information about subnets, see <a
        /// href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Subnets.html" >Your VPC and Subnets</a> in the <i>Amazon Virtual Private
        /// Cloud User Guide</i> .</para>
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
        /// <para>Describes one or more of your subnets.</para> <para>For more information about subnets, see <a
        /// href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Subnets.html" >Your VPC and Subnets</a> in the <i>Amazon Virtual Private
        /// Cloud User Guide</i> .</para>
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
        /// <para>Describes one or more of the tags for your EC2 resources.</para> <para>For more information about tags, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_Tags.html" >Tagging Your Resources</a> in the <i>Amazon Elastic Compute Cloud
        /// User Guide</i> .</para>
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
        /// <para>Describes one or more of the tags for your EC2 resources.</para> <para>For more information about tags, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_Tags.html" >Tagging Your Resources</a> in the <i>Amazon Elastic Compute Cloud
        /// User Guide</i> .</para>
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
        /// <para>Describes the specified attribute of the specified volume. You can specify only one attribute at a time.</para> <para>For more
        /// information about Amazon EBS volumes, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSVolumes.html" >Amazon EBS
        /// Volumes</a> in the <i>Amazon Elastic Compute Cloud User Guide</i> .</para>
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
        /// <para>Describes the status of the specified volumes. Volume status provides the result of the checks performed on your volumes to determine
        /// events that can impair the performance of your volumes. The performance of a volume can be affected if an issue occurs on the volume's
        /// underlying host. If the volume's underlying host experiences a power outage or system issue, after the system is restored, there could be
        /// data inconsistencies on the volume. Volume events notify you if this occurs. Volume actions notify you if any action needs to be taken in
        /// response to the event.</para> <para>The <c>DescribeVolumeStatus</c> operation provides the following information about the specified
        /// volumes:</para> <para> <i>Status</i> : Reflects the current status of the volume. The possible values are <c>ok</c> ,
        /// <c>impaired</c> ,
        /// <c>warning</c> , or <c>insufficient-data</c> . If all checks pass, the overall status of the volume is <c>ok</c> . If
        /// the check fails, the overall status is <c>impaired</c> . If the status is <c>insufficient-data</c> , then the checks may still be taking
        /// place on your volume at the time. We recommend that you retry the request. For more information on volume status, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/monitoring-volume-status.html" >Monitoring the Status of Your Volumes</a> .</para>
        /// <para> <i>Events</i> : Reflect the cause of a volume status and may require you to take action. For example, if your volume returns an
        /// <c>impaired</c> status, then the volume event might be <c>potential-data-inconsistency</c> . This means that your volume has been affected
        /// by an issue with the underlying host, has all I/O operations disabled, and may have inconsistent data.</para> <para> <i>Actions</i> :
        /// Reflect the actions you may have to take in response to an event. For example, if the status of the volume is <c>impaired</c> and the volume
        /// event shows <c>potential-data-inconsistency</c> , then the action shows <c>enable-volume-io</c> . This means that you may want to enable the
        /// I/O operations for the volume by calling the EnableVolumeIO action and then check the volume for data consistency.</para> <para><b>NOTE:</b>
        /// Volume status is based on the volume status checks, and does not reflect the volume state. Therefore, volume status does not indicate
        /// volumes in the error state (for example, when a volume is incapable of accepting I/O.) </para>
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
        /// <para>Describes the status of the specified volumes. Volume status provides the result of the checks performed on your volumes to determine
        /// events that can impair the performance of your volumes. The performance of a volume can be affected if an issue occurs on the volume's
        /// underlying host. If the volume's underlying host experiences a power outage or system issue, after the system is restored, there could be
        /// data inconsistencies on the volume. Volume events notify you if this occurs. Volume actions notify you if any action needs to be taken in
        /// response to the event.</para> <para>The <c>DescribeVolumeStatus</c> operation provides the following information about the specified
        /// volumes:</para> <para> <i>Status</i> : Reflects the current status of the volume. The possible values are <c>ok</c> ,
        /// <c>impaired</c> ,
        /// <c>warning</c> , or <c>insufficient-data</c> . If all checks pass, the overall status of the volume is <c>ok</c> . If
        /// the check fails, the overall status is <c>impaired</c> . If the status is <c>insufficient-data</c> , then the checks may still be taking
        /// place on your volume at the time. We recommend that you retry the request. For more information on volume status, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/monitoring-volume-status.html" >Monitoring the Status of Your Volumes</a> .</para>
        /// <para> <i>Events</i> : Reflect the cause of a volume status and may require you to take action. For example, if your volume returns an
        /// <c>impaired</c> status, then the volume event might be <c>potential-data-inconsistency</c> . This means that your volume has been affected
        /// by an issue with the underlying host, has all I/O operations disabled, and may have inconsistent data.</para> <para> <i>Actions</i> :
        /// Reflect the actions you may have to take in response to an event. For example, if the status of the volume is <c>impaired</c> and the volume
        /// event shows <c>potential-data-inconsistency</c> , then the action shows <c>enable-volume-io</c> . This means that you may want to enable the
        /// I/O operations for the volume by calling the EnableVolumeIO action and then check the volume for data consistency.</para> <para><b>NOTE:</b>
        /// Volume status is based on the volume status checks, and does not reflect the volume state. Therefore, volume status does not indicate
        /// volumes in the error state (for example, when a volume is incapable of accepting I/O.) </para>
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
        /// <para>Describes the specified Amazon EBS volumes.</para> <para>For more information about Amazon EBS volumes, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSVolumes.html" >Amazon EBS Volumes</a> in the <i>Amazon Elastic Compute Cloud
        /// User Guide</i> .</para>
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
        /// <para>Describes the specified Amazon EBS volumes.</para> <para>For more information about Amazon EBS volumes, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/EBSVolumes.html" >Amazon EBS Volumes</a> in the <i>Amazon Elastic Compute Cloud
        /// User Guide</i> .</para>
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
        /// <para>Describes the specified attribute of the specified VPC. You can specify only one attribute at a time.</para>
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
        /// <para>Describes one or more of your VPCs.</para>
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
        /// <para>Describes one or more of your VPCs.</para>
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
        /// <para>Describes one or more of your VPN connections.</para> <para>For more information about VPN connections, see <a
        /// href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_VPN.html" >Adding a Hardware Virtual Private Gateway to Your VPC</a> in the
        /// <i>Amazon Virtual Private Cloud User Guide</i> .</para>
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
        /// <para>Describes one or more of your VPN connections.</para> <para>For more information about VPN connections, see <a
        /// href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_VPN.html" >Adding a Hardware Virtual Private Gateway to Your VPC</a> in the
        /// <i>Amazon Virtual Private Cloud User Guide</i> .</para>
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
        /// <para>Describes one or more of your virtual private gateways.</para> <para>For more information about virtual private gateways, see <a
        /// href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_VPN.html" >Adding an IPsec Hardware VPN to Your VPC</a> in the <i>Amazon
        /// Virtual Private Cloud User Guide</i> .</para>
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
        /// <para>Describes one or more of your virtual private gateways.</para> <para>For more information about virtual private gateways, see <a
        /// href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_VPN.html" >Adding an IPsec Hardware VPN to Your VPC</a> in the <i>Amazon
        /// Virtual Private Cloud User Guide</i> .</para>
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
        /// <para>Detaches an Internet gateway from a VPC, disabling connectivity between the Internet and the VPC. The VPC must not contain any running
        /// instances with Elastic IP addresses.</para>
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
        /// <para>Detaches a network interface from an instance.</para>
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
        /// <para>Detaches an Amazon EBS volume from an instance. Make sure to unmount any file systems on the device within your operating system
        /// before detaching the volume. Failure to do so results in the volume being stuck in a busy state while detaching.</para> <para>If an Amazon
        /// EBS volume is the root device of an instance, it can't be detached while the instance is running. To detach the root volume, stop the
        /// instance first.</para> <para>If the root volume is detached from an instance with an AWS Marketplace product code, then the AWS Marketplace
        /// product codes from that volume are no longer associated with the instance.</para> <para>For more information, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-detaching-volume.html" >Detaching an Amazon EBS Volume</a> in the <i>Amazon
        /// Elastic Compute Cloud User Guide</i> .</para>
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
        /// <para>Detaches a virtual private gateway from a VPC. You do this if you're planning to turn off the VPC and not use it anymore. You can
        /// confirm a virtual private gateway has been completely detached from a VPC by describing the virtual private gateway (any attachments to the
        /// virtual private gateway are also described).</para> <para>You must wait for the attachment's state to switch to <c>detached</c> before you
        /// can delete the VPC or attach a different VPC to the virtual private gateway.</para>
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
        /// <para>Disables a virtual private gateway (VGW) from propagating routes to the routing tables of a VPC.</para>
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
        /// <para>Disassociates an Elastic IP address from the instance or network interface it's associated with.</para> <para>This is an idempotent
        /// operation. If you perform the operation more than once, Amazon EC2 doesn't return an error.</para>
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
        /// <para>Disassociates a subnet from a route table.</para> <para>After you perform this action, the subnet no longer uses the routes in the
        /// route table. Instead, it uses the routes in the VPC's main route table. For more information about route tables, see <a
        /// href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Route_Tables.html" >Route Tables</a> in the <i>Amazon Virtual Private Cloud
        /// User Guide</i> .</para>
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
        /// <para>Enables a virtual private gateway (VGW) to propagate routes to the routing tables of a VPC.</para>
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
        /// <para>Enables I/O operations for a volume that had I/O operations disabled because the data on the volume was potentially
        /// inconsistent.</para>
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
        /// <para>Gets the console output for the specified instance.</para> <para>Instances do not have a physical monitor through which you can view
        /// their console output. They also lack physical controls that allow you to power up, reboot, or shut them down. To allow these actions, we
        /// provide them through the Amazon EC2 API and command line interface.</para> <para>Instance console output is buffered and posted shortly
        /// after instance boot, reboot, and termination. Amazon EC2 preserves the most recent 64 KB output which is available for at least one hour
        /// after the most recent post.</para> <para>For Linux/Unix instances, the instance console output displays the exact console output that would
        /// normally be displayed on a physical monitor attached to a machine. This output is buffered because the instance produces it and then posts
        /// it to a store where the instance's owner can retrieve it.</para> <para>For Windows instances, the instance console output displays the last
        /// three system event log errors.</para>
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
        /// <para>Retrieves the encrypted administrator password for an instance running Windows.</para> <para>The Windows password is only generated
        /// the first time an AMI is launched. It is not generated for rebundled AMIs or after the password is changed on an instance.</para> <para>The
        /// password is encrypted using the key pair that you specified when you launched the instance. You must provide the corresponding key pair
        /// file.</para> <para>Password generation and encryption takes a few moments. We recommend that you wait up to 15 minutes after launching an
        /// instance before trying to retrieve the generated password.</para>
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
        /// <para>Creates an import instance task using metadata from the specified disk image. After importing the image, you then upload it using the
        /// ec2-upload-disk-image command in the EC2 command line tools. For more information, see Using the Command Line Tools to Import Your Virtual
        /// Machine to Amazon EC2 in the Amazon Elastic Compute Cloud User Guide.</para>
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
        /// <para>Imports the public key from an RSA key pair that you created with a third-party tool. Compare this with CreateKeyPair, in which AWS
        /// creates the key pair and gives the keys to you (AWS keeps a copy of the public key). With ImportKeyPair, you create the key pair and give
        /// AWS just the public key. The private key is never transferred between you and AWS.</para> <para>For more information about key pairs, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-key-pairs.html" >Key Pairs</a> in the <i>Amazon Elastic Compute Cloud User
        /// Guide</i> .</para>
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
        /// <para>Creates an import volume task using metadata from the specified disk image. After importing the image, you then upload it using the
        /// ec2-upload-disk-image command in the Amazon EC2 command-line interface (CLI) tools. For more information, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/UploadingYourInstancesandVolumes.html" >Using the Command Line Tools to Import Your
        /// Virtual Machine to Amazon EC2</a> in the <i>Amazon Elastic Compute Cloud User Guide</i> .</para>
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
        /// <para>Modifies the specified attribute of the specified AMI. You can specify only one attribute at a time.</para> <para><b>NOTE:</b> AWS
        /// Marketplace product codes cannot be modified. Images with an AWS Marketplace product code cannot be made public. </para>
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
        /// <para>Modifies the specified attribute of the specified instance. You can specify only one attribute at a time.</para> <para>To modify some
        /// attributes, the instance must be stopped. For more information, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_ChangingAttributesWhileInstanceStopped.html" >Modifying Attributes of a
        /// Stopped Instance</a> in the <i>Amazon Elastic Compute Cloud User Guide</i> .</para>
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
        /// <para>Modifies the specified network interface attribute. You can specify only one attribute at a time.</para>
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
        /// <para>Modifies the Availability Zone, instance count, instance type, or network platform (EC2-Classic or EC2-VPC) of your Reserved
        /// Instances. The Reserved Instances to be modified must be identical, except for Availability Zone, network platform, and instance
        /// type.</para>
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
        /// <para>Adds or removes permission settings for the specified snapshot.</para> <para>For more information on modifying snapshot permissions,
        /// see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-modifying-snapshot-permissions.html" >Sharing Snapshots</a> in the
        /// <i>Amazon Elastic Compute Cloud User Guide</i> .</para> <para><b>NOTE:</b> Snapshots with AWS Marketplace product codes cannot be made
        /// public. </para>
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
        /// <para>Modifies a volume attribute.</para> <para>By default, all I/O operations for the volume are suspended when the data on the volume is
        /// determined to be potentially inconsistent, to prevent undetectable, latent data corruption. The I/O access to the volume can be resumed by
        /// first enabling I/O access and then checking the data consistency on your volume.</para> <para>You can change the default behavior to resume
        /// I/O operations. We recommend that you change this only for boot volumes or for volumes that are stateless or disposable.</para>
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
        /// <para>Modifies the specified attribute of the specified VPC.</para>
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
        /// <para>Enables monitoring for a running instance. For more information about monitoring instances, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-cloudwatch.html" >Monitoring Your Instances and Volumes</a> in the <i>Amazon
        /// Elastic Compute Cloud User Guide</i> .</para>
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
        /// <para>Purchases a Reserved Instance for use with your account. With Amazon EC2 Reserved Instances, you obtain a capacity reservation for a
        /// certain instance configuration over a specified period of time. You pay a lower usage rate than with On-Demand instances for the time that
        /// you actually use the capacity reservation.</para> <para>For more information, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ri-market-general.html" >Reserved Instance Marketplace</a> in the <i>Amazon Elastic
        /// Compute Cloud User Guide</i> .</para>
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
        /// <para>Requests a reboot of one or more instances. This operation is asynchronous; it only queues a request to reboot the specified
        /// instances. The operation succeeds if the instances are valid and belong to you. Requests to reboot terminated instances are ignored.</para>
        /// <para>If a Linux/Unix instance does not cleanly shut down within four minutes, Amazon EC2 performs a hard reboot.</para>
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
        /// <para>Registers an AMI. When you're creating an AMI, this is the final step you must complete before you can launch an instance from the
        /// AMI. For more information about creating AMIs, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/creating-an-ami.html"
        /// >Creating Your Own AMIs</a> in the <i>Amazon Elastic Compute Cloud User Guide</i> .</para> <para><b>NOTE:</b> For Amazon EBS-backed
        /// instances, CreateImage creates and registers the AMI in a single request, so you don't have to register the AMI yourself. </para> <para>You
        /// can also use <c>RegisterImage</c> to create an Amazon EBS-backed AMI from a snapshot of a root device volume. For more information, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Using_LaunchingInstanceFromSnapshot.html" >Launching an Instance from a
        /// Snapshot</a> in the <i>Amazon Elastic Compute Cloud User Guide</i> .</para> <para>If needed, you can deregister an AMI at any time. Any
        /// modifications you make to an AMI backed by an instance store volume invalidates its registration. If you make changes to an image,
        /// deregister the previous image and register the new image.</para> <para><b>NOTE:</b> You can't register an image where a secondary (non-root)
        /// snapshot has AWS Marketplace product codes. </para>
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
        /// <para>Releases the specified Elastic IP address.</para> <para>After releasing an Elastic IP address, it is released to the IP address pool
        /// and might be unavailable to you. Be sure to update your DNS records and any servers or devices that communicate with the address. If you
        /// attempt to release an Elastic IP address that you already released, you'll get an <c>AuthFailure</c> error if the address is already
        /// allocated to another AWS account.</para> <para>[EC2-Classic, default VPC] Releasing an Elastic IP address automatically disassociates it
        /// from any instance that it's associated with. To disassociate an Elastic IP address without releasing it, use DisassociateAddress.</para>
        /// <para>[Nondefault VPC] You must use the DisassociateAddress to disassociate the Elastic IP address before you try to release it. Otherwise,
        /// Amazon EC2 returns an error ( <c>InvalidIPAddress.InUse</c> ).</para>
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
        /// <para>Changes which network ACL a subnet is associated with. By default when you create a subnet, it's automatically associated with the
        /// default network ACL. For more information about network ACLs, see <a
        /// href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_ACLs.html" >Network ACLs</a> in the <i>Amazon Virtual Private Cloud User
        /// Guide</i> .</para>
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
        /// <para>Replaces an entry (rule) in a network ACL. For more information about network ACLs, see <a
        /// href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_ACLs.html" >Network ACLs</a> in the <i>Amazon Virtual Private Cloud User
        /// Guide</i> .</para>
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
        /// <para>Replaces an existing route within a route table in a VPC. You must provide only one of the following: Internet gateway, NAT instance,
        /// or network interface.</para> <para>For more information about route tables, see <a
        /// href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Route_Tables.html" >Route Tables</a> in the <i>Amazon Virtual Private Cloud
        /// User Guide</i> .</para>
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
        /// <para>Changes the route table associated with a given subnet in a VPC. After the operation completes, the subnet uses the routes in the new
        /// route table it's associated with. For more information about route tables, see <a
        /// href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_Route_Tables.html" >Route Tables</a> in the <i>Amazon Virtual Private Cloud
        /// User Guide</i> .</para> <para>You can also use ReplaceRouteTableAssociation to change which table is the main route table in the VPC. You
        /// just specify the main route table's association ID and the route table to be the new main route table.</para>
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
        /// <para>Submits feedback about the status of an instance. The instance must be in the <c>running</c> state. If your experience with the
        /// instance differs from the instance status returned by DescribeInstanceStatus, use ReportInstanceStatus to report your experience with the
        /// instance. Amazon EC2 collects this information to improve the accuracy of status checks.</para>
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
        /// <para>Creates a Spot Instance request. Spot Instances are instances that Amazon EC2 starts on your behalf when the maximum price that you
        /// specify exceeds the current Spot Price. Amazon EC2 periodically sets the Spot Price based on available Spot Instance capacity and current
        /// Spot Instance requests. For more information about Spot Instances, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-spot-instances.html" >Spot Instances</a> in the <i>Amazon Elastic Compute
        /// Cloud User Guide</i> .</para>
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
        /// <para>Resets an attribute of an AMI to its default value.</para>
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
        /// <para>Resets an attribute of an instance to its default value. To reset the kernel or RAM disk, the instance must be in a stopped state. To
        /// reset the <c>SourceDestCheck</c> , the instance can be either running or stopped.</para> <para>The <c>SourceDestCheck</c> attribute controls
        /// whether source/destination checking is enabled. The default value is <c>true</c> , which means checking is enabled. This value must be
        /// <c>false</c> for a NAT instance to perform NAT. For more information, see <a
        /// href="http://docs.aws.amazon.com/AmazonVPC/latest/UserGuide/VPC_NAT_Instance.html" >NAT Instances</a> in the <i>Amazon Virtual Private Cloud
        /// User Guide</i> .</para>
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
        /// <para>Resets a network interface attribute. You can specify only one attribute at a time.</para>
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
        /// <para>Resets permission settings for the specified snapshot.</para> <para>For more information on modifying snapshot permissions, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ebs-modifying-snapshot-permissions.html" >Sharing Snapshots</a> in the <i>Amazon
        /// Elastic Compute Cloud User Guide</i> .</para>
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
        /// <para>Removes one or more egress rules from a security group for EC2-VPC. The values that you specify in the revoke request (for example,
        /// ports) must match the existing rule's values for the rule to be revoked.</para> <para>Each rule consists of the protocol and the CIDR range
        /// or source security group. For the TCP and UDP protocols, you must also specify the destination port or range of ports. For the ICMP
        /// protocol, you must also specify the ICMP type and code.</para> <para>Rule changes are propagated to instances within the security group as
        /// quickly as possible. However, a small delay might occur.</para>
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
        /// <para>Removes one or more ingress rules from a security group. The values that you specify in the revoke request (for example, ports) must
        /// match the existing rule's values for the rule to be removed.</para> <para>Each rule consists of the protocol and the CIDR range or source
        /// security group. For the TCP and UDP protocols, you must also specify the destination port or range of ports. For the ICMP protocol, you must
        /// also specify the ICMP type and code.</para> <para>Rule changes are propagated to instances within the security group as quickly as possible.
        /// However, a small delay might occur.</para>
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
        /// <para>Launches the specified number of instances using an AMI for which you have permissions.</para> <para>When you launch an instance, it
        /// enters the <c>pending</c> state. After the instance is ready for you, it enters the <c>running</c> state. To check the state of your
        /// instance, call DescribeInstances.</para> <para>If you don't specify a security group when launching an instance, Amazon EC2 uses the default
        /// security group. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-network-security.html" >Security
        /// Groups</a> in the <i>Amazon Elastic Compute Cloud User Guide</i> .</para> <para>Linux instances have access to the public key of the key
        /// pair at boot. You can use this key to provide secure access to the instance. Amazon EC2 public images use this feature to provide secure
        /// access without passwords. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-key-pairs.html" >Key
        /// Pairs</a> in the <i>Amazon Elastic Compute Cloud User Guide</i> .</para> <para>You can provide optional user data when launching an
        /// instance. For more information, see <a href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/AESDG-chapter-instancedata.html" >Instance
        /// Metadata</a> in the <i>Amazon Elastic Compute Cloud User Guide</i> .</para> <para>If any of the AMIs have a product code attached for which
        /// the user has not subscribed, <c>RunInstances</c> fails.</para>
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
        /// <para>Starts an Amazon EBS-backed AMI that you've previously stopped.</para> <para>Instances that use Amazon EBS volumes as their root
        /// devices can be quickly stopped and started. When an instance is stopped, the compute resources are released and you are not billed for
        /// hourly instance usage. However, your root partition Amazon EBS volume remains, continues to persist your data, and you are charged for
        /// Amazon EBS volume usage. You can restart your instance at any time. Each time you transition an instance from stopped to started, Amazon EC2
        /// charges a full instance hour, even if transitions happen multiple times within a single hour.</para> <para>Before stopping an instance, make
        /// sure it is in a state from which it can be restarted. Stopping an instance does not preserve data stored in RAM.</para> <para>Performing
        /// this operation on an instance that uses an instance store as its root device returns an error.</para> <para>For more information, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/Stop_Start.html" >Stopping Instances</a> in the <i>Amazon Elastic Compute Cloud
        /// User Guide</i> .</para>
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
        /// <para>Stops an Amazon EBS-backed instance. Each time you transition an instance from stopped to started, Amazon EC2 charges a full instance
        /// hour, even if transitions happen multiple times within a single hour.</para> <para>You can't start or stop Spot Instances.</para>
        /// <para>Instances that use Amazon EBS volumes as their root devices can be quickly stopped and started. When an instance is stopped, the
        /// compute resources are released and you are not billed for hourly instance usage. However, your root partition Amazon EBS volume remains,
        /// continues to persist your data, and you are charged for Amazon EBS volume usage. You can restart your instance at any time.</para>
        /// <para>Before stopping an instance, make sure it is in a state from which it can be restarted. Stopping an instance does not preserve data
        /// stored in RAM.</para> <para>Performing this operation on an instance that uses an instance store as its root device returns an error.</para>
        /// <para>You can stop, start, and terminate EBS-backed instances. You can only terminate instance store-backed instances. What happens to an
        /// instance differs if you stop it or terminate it. For example, when you stop an instance, the root device and any other devices attached to
        /// the instance persist. When you terminate an instance, the root device and any other devices attached during the instance launch are
        /// automatically deleted. For more information about the differences between stopping and terminating instances, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-instance-lifecycle.html" >Instance Lifecycle</a> in the <i>Amazon Elastic
        /// Compute Cloud User Guide</i> .</para>
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
        /// <para>Shuts down one or more instances. This operation is idempotent; if you terminate an instance more than once, each call
        /// succeeds.</para> <para>Terminated instances remain visible after termination (for approximately one hour).</para> <para>By default, Amazon
        /// EC2 deletes all Amazon EBS volumes that were attached when the instance launched. Volumes attached after instance launch continue
        /// running.</para> <para>You can stop, start, and terminate EBS-backed instances. You can only terminate instance store-backed instances. What
        /// happens to an instance differs if you stop it or terminate it. For example, when you stop an instance, the root device and any other devices
        /// attached to the instance persist. When you terminate an instance, the root device and any other devices attached during the instance launch
        /// are automatically deleted. For more information about the differences between stopping and terminating instances, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/ec2-instance-lifecycle.html" >Instance Lifecycle</a> in the <i>Amazon Elastic
        /// Compute Cloud User Guide</i> .</para>
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
        /// <para>Unassigns one or more secondary private IP addresses from a network interface.</para>
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
        /// <para>Disables monitoring for a running instance. For more information about monitoring instances, see <a
        /// href="http://docs.aws.amazon.com/AWSEC2/latest/UserGuide/using-cloudwatch.html" >Monitoring Your Instances and Volumes</a> in the <i>Amazon
        /// Elastic Compute Cloud User Guide</i> .</para>
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
    
